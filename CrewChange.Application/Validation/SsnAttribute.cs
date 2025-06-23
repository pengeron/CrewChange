using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace CrewChange.Application.Validation;

public class SsnAttribute : ValidationAttribute
{
    private static readonly Regex SsnRegex = new(@"^\d{3}-?\d{2}-?\d{4}$");

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null) return ValidationResult.Success;

        var ssn = value.ToString();
        if (string.IsNullOrWhiteSpace(ssn))
            return ValidationResult.Success;

        if (!SsnRegex.IsMatch(ssn))
            return new ValidationResult("SSN must be in the format XXX-XX-XXXX or XXXXXXXXX");

        return ValidationResult.Success;
    }
}
