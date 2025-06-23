using System.ComponentModel.DataAnnotations;

namespace CrewChange.Application.DTOs;

public class EmployeeCertificationDto
{
    public int Id { get; set; }
    public string CertificationName { get; set; } = string.Empty;
    public DateTime IssueDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public string CertificationNumber { get; set; } = string.Empty;
    public string IssuingAuthority { get; set; } = string.Empty;
    public string DocumentUrl { get; set; } = string.Empty;
}

public class CreateEmployeeCertificationDto
{
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please select an employee")]
    public int EmployeeId { get; set; }

    [Required, StringLength(100)]
    public string CertificationName { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Date)]
    public DateTime IssueDate { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime ExpirationDate { get; set; }

    [Required, StringLength(50)]
    public string CertificationNumber { get; set; } = string.Empty;

    [Required, StringLength(100)]
    public string IssuingAuthority { get; set; } = string.Empty;
}
