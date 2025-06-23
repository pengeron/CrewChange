namespace CrewChange.Domain.Entities;

public class EmployeeCertification
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public string CertificationName { get; set; } = string.Empty;
    public string CertificationNumber { get; set; } = string.Empty;
    public DateTime IssueDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    
    public Employee Employee { get; set; } = null!;
}
