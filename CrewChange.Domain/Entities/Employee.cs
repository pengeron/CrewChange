namespace CrewChange.Domain.Entities;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Ssn { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string PagerNumber { get; set; } = string.Empty;
    public string FaxNumber { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public int StateId { get; set; }
    public string ZipCode { get; set; } = string.Empty;
    public int MaritalStatusId { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime HireDate { get; set; }
    public int EmployeeStatusId { get; set; }
    public int EmployeeGroupId { get; set; }
    public int EducationLevelId { get; set; }
    public int EmployeeWorkStatusId { get; set; }
    public int WorkStatusId { get; set; }
    public bool Terminated { get; set; }
    public DateTime? DateTerminated { get; set; }
    public string ReasonTerminated { get; set; } = string.Empty;
    public int LocationId { get; set; }
    public DateTime? SseExpirationDate { get; set; }
    public int JobId { get; set; }
    public int EmployeeScheduleTypeId { get; set; }
    public int GenderTypeId { get; set; }
    public int NationalityTypeId { get; set; }
    public int VeteranStatusTypeId { get; set; }
    public int? TerminationReasonId { get; set; }

    // Navigation properties
    public State State { get; set; } = null!;
    public MaritalStatus MaritalStatus { get; set; } = null!;
    public EmployeeStatus EmployeeStatus { get; set; } = null!;
    public EmployeeGroup EmployeeGroup { get; set; } = null!;
    public EducationLevel EducationLevel { get; set; } = null!;
    public WorkStatus EmployeeWorkStatus { get; set; } = null!;
    public WorkStatus WorkStatus { get; set; } = null!;
    public Location Location { get; set; } = null!;
    public Job Job { get; set; } = null!;
    public EmployeeScheduleType EmployeeScheduleType { get; set; } = null!;
    public GenderType GenderType { get; set; } = null!;
    public NationalityType NationalityType { get; set; } = null!;
    public VeteranStatusType VeteranStatusType { get; set; } = null!;
    public TerminationReason? TerminationReason { get; set; }
    public ICollection<EmployeeCertification> Certifications { get; set; } = new List<EmployeeCertification>();
}
