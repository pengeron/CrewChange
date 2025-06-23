using CrewChange.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrewChange.API.Controllers;

public abstract class ReferenceControllerBase<T> : ControllerBase where T : class
{
    protected readonly ApplicationDbContext _context;
    private readonly string _entityName;

    protected ReferenceControllerBase(ApplicationDbContext context, string entityName)
    {
        _context = context;
        _entityName = entityName;
    }

    [HttpGet]
    public virtual async Task<ActionResult<IEnumerable<T>>> GetAll()
    {
        return await _context.Set<T>().ToListAsync();
    }

    [HttpGet("{id}")]
    public virtual async Task<ActionResult<T>> Get(int id)
    {
        var entity = await _context.Set<T>().FindAsync(id);

        if (entity == null)
        {
            return NotFound($"{_entityName} with ID {id} was not found.");
        }

        return entity;
    }

    [HttpPost]
    public virtual async Task<ActionResult<T>> Create(T entity)
    {
        _context.Set<T>().Add(entity);
        await _context.SaveChangesAsync();

        var idProperty = typeof(T).GetProperty("Id");
        if (idProperty != null)
        {
            return CreatedAtAction(nameof(Get), new { id = idProperty.GetValue(entity) }, entity);
        }

        return CreatedAtAction(nameof(Get), new { }, entity);
    }

    [HttpPut("{id}")]
    public virtual async Task<IActionResult> Update(int id, T entity)
    {
        var idProperty = typeof(T).GetProperty("Id");
        if (idProperty != null)
        {
            var entityId = (int)idProperty.GetValue(entity)!;
            if (id != entityId)
            {
                return BadRequest($"The ID in the URL ({id}) does not match the ID in the body ({entityId}).");
            }
        }

        _context.Entry(entity).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!await EntityExists(id))
            {
                return NotFound($"{_entityName} with ID {id} was not found.");
            }
            throw;
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public virtual async Task<IActionResult> Delete(int id)
    {
        var entity = await _context.Set<T>().FindAsync(id);
        if (entity == null)
        {
            return NotFound($"{_entityName} with ID {id} was not found.");
        }

        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    protected virtual async Task<bool> EntityExists(int id)
    {
        return await _context.Set<T>().FindAsync(id) != null;
    }
}
