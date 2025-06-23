namespace CrewChange.Application.DTOs;

public class BaseDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}

public class BaseReferenceDto : BaseDto
{
    public string? Description { get; set; }
}
