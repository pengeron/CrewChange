using CrewChange.Application.Interfaces;
using CrewChange.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CrewChange.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeesController(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
    {
        var employees = await _employeeRepository.GetAllAsync();
        return Ok(employees);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Employee>> GetEmployee(int id)
    {
        var employee = await _employeeRepository.GetByIdAsync(id);
        if (employee == null)
        {
            return NotFound();
        }
        return Ok(employee);
    }

    [HttpPost]
    public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
    {
        var createdEmployee = await _employeeRepository.AddAsync(employee);
        return CreatedAtAction(nameof(GetEmployee), new { id = createdEmployee.Id }, createdEmployee);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateEmployee(int id, Employee employee)
    {
        if (id != employee.Id)
        {
            return BadRequest();
        }

        if (!await _employeeRepository.ExistsAsync(id))
        {
            return NotFound();
        }

        await _employeeRepository.UpdateAsync(employee);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEmployee(int id)
    {
        if (!await _employeeRepository.ExistsAsync(id))
        {
            return NotFound();
        }

        await _employeeRepository.DeleteAsync(id);
        return NoContent();
    }
}
