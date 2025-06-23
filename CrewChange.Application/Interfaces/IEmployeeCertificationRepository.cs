using CrewChange.Domain.Entities;

namespace CrewChange.Application.Interfaces;

public interface IEmployeeCertificationRepository
{
    Task<IEnumerable<EmployeeCertification>> GetAllByEmployeeIdAsync(int employeeId);
    Task<EmployeeCertification?> GetByIdAsync(int id);
    Task<EmployeeCertification> AddAsync(EmployeeCertification certification);
    Task UpdateAsync(EmployeeCertification certification);
    Task DeleteAsync(int id);
    Task<bool> ExistsAsync(int id);
}
