using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace CrewChange.Application.Validation;

public class PhoneNumberAttribute : ValidationAttribute
{
    private static readonly Regex PhoneRegex = new(@"^\+?1?\d{10,14}$");

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null) return ValidationResult.Success;

        var phone = value.ToString();
        if (string.IsNullOrWhiteSpace(phone))
            return ValidationResult.Success;

        // Remove any non-digit characters
        phone = Regex.Replace(phone, @"[^\d]", "");

        if (!PhoneRegex.IsMatch(phone))
            return new ValidationResult("Please enter a valid phone number with 10-14 digits");

        return ValidationResult.Success;
    }
}
