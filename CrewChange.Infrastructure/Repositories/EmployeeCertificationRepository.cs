using CrewChange.Application.Interfaces;
using CrewChange.Domain.Entities;
using CrewChange.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CrewChange.Infrastructure.Repositories;

public class EmployeeCertificationRepository : IEmployeeCertificationRepository
{
    private readonly ApplicationDbContext _context;

    public EmployeeCertificationRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<EmployeeCertification>> GetAllByEmployeeIdAsync(int employeeId)
    {
        return await _context.EmployeeCertifications
            .Where(c => c.EmployeeId == employeeId)
            .ToListAsync();
    }

    public async Task<EmployeeCertification?> GetByIdAsync(int id)
    {
        return await _context.EmployeeCertifications
            .Include(c => c.Employee)
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<EmployeeCertification> AddAsync(EmployeeCertification certification)
    {
        _context.EmployeeCertifications.Add(certification);
        await _context.SaveChangesAsync();
        return certification;
    }

    public async Task UpdateAsync(EmployeeCertification certification)
    {
        _context.Entry(certification).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var certification = await _context.EmployeeCertifications.FindAsync(id);
        if (certification != null)
        {
            _context.EmployeeCertifications.Remove(certification);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<bool> ExistsAsync(int id)
    {
        return await _context.EmployeeCertifications.AnyAsync(c => c.Id == id);
    }
}
