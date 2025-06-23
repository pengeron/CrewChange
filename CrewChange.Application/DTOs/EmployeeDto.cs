using System.ComponentModel.DataAnnotations;
using CrewChange.Application.Validation;

namespace CrewChange.Application.DTOs;

public class EmployeeDto
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public DateTime HireDate { get; set; }
    public bool Terminated { get; set; }
    public DateTime? DateTerminated { get; set; }
    public DateTime? SseExpirationDate { get; set; }

    // Reference Data
    public BaseDto State { get; set; } = null!;
    public BaseDto MaritalStatus { get; set; } = null!;
    public BaseReferenceDto EmployeeStatus { get; set; } = null!;
    public BaseDto EmployeeGroup { get; set; } = null!;
    public BaseReferenceDto EducationLevel { get; set; } = null!;
    public BaseReferenceDto WorkStatus { get; set; } = null!;
    public BaseDto Location { get; set; } = null!;
    public BaseDto Job { get; set; } = null!;
    public BaseDto EmployeeScheduleType { get; set; } = null!;
    public BaseDto GenderType { get; set; } = null!;
    public BaseDto NationalityType { get; set; } = null!;
    public BaseReferenceDto VeteranStatusType { get; set; } = null!;
    public BaseReferenceDto? TerminationReason { get; set; }
}

public class CreateEmployeeDto
{
    [Required, StringLength(50)]
    public string FirstName { get; set; } = string.Empty;

    [Required, StringLength(50)]
    public string LastName { get; set; } = string.Empty;

    [Required, Ssn]
    public string Ssn { get; set; } = string.Empty;

    [Required, EmailAddress, StringLength(100)]
    public string Email { get; set; } = string.Empty;

    [Phone, StringLength(20)]
    public string PhoneNumber { get; set; } = string.Empty;    [PhoneNumber, StringLength(20)]
    public string PagerNumber { get; set; } = string.Empty;

    [PhoneNumber, StringLength(20)]
    public string FaxNumber { get; set; } = string.Empty;

    [Required, StringLength(200)]
    public string Address { get; set; } = string.Empty;

    [Required, StringLength(100)]
    public string City { get; set; } = string.Empty;

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please select a state")]
    public int StateId { get; set; }

    [Required, RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "ZIP code must be 5 digits or 5+4 digits")]
    public string ZipCode { get; set; } = string.Empty;

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please select a marital status")]
    public int MaritalStatusId { get; set; }

    [Required, BirthDate]
    public DateTime DateOfBirth { get; set; }

    [Required]
    public DateTime HireDate { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please select an employee status")]
    public int EmployeeStatusId { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please select an employee group")]
    public int EmployeeGroupId { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please select an education level")]
    public int EducationLevelId { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please select a work status")]
    public int WorkStatusId { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please select a location")]
    public int LocationId { get; set; }

    [DataType(DataType.Date)]
    public DateTime? SseExpirationDate { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please select a job")]
    public int JobId { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please select a schedule type")]
    public int EmployeeScheduleTypeId { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please select a gender")]
    public int GenderTypeId { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please select a nationality")]
    public int NationalityTypeId { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please select a veteran status")]
    public int VeteranStatusTypeId { get; set; }
}

public class UpdateEmployeeDto : CreateEmployeeDto
{    [Required]
    public int Id { get; set; }

    public bool Terminated { get; set; }

    [DataType(DataType.Date)]
    public DateTime? DateTerminated { get; set; }

    [StringLength(500)]
    public string ReasonTerminated { get; set; } = string.Empty;

    [Range(1, int.MaxValue, ErrorMessage = "Please select a termination reason")]
    public int? TerminationReasonId { get; set; }
}

public class EmployeeListDto
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public DateTime HireDate { get; set; }
    public string JobTitle { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string EmployeeStatus { get; set; } = string.Empty;
}
