using System.ComponentModel.DataAnnotations;

namespace CrewChange.Application.Validation;

public class BirthDateAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null) return ValidationResult.Success;

        if (value is not DateTime birthDate)
            return new ValidationResult("Invalid date format");

        if (birthDate > DateTime.Today)
            return new ValidationResult("Birth date cannot be in the future");

        if (birthDate.Year < 1900)
            return new ValidationResult("Birth date year must be after 1900");

        var age = DateTime.Today.Year - birthDate.Year;
        if (birthDate > DateTime.Today.AddYears(-age)) age--;

        if (age < 16)
            return new ValidationResult("Employee must be at least 16 years old");

        if (age > 100)
            return new ValidationResult("Please verify birth date, age appears to be over 100 years");

        return ValidationResult.Success;
    }
}
