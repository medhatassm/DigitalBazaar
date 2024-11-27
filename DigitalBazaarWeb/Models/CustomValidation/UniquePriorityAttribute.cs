using System.ComponentModel.DataAnnotations;
using DigitalBazaarWeb.Data;

namespace DigitalBazaarWeb.Models.CustomValidation;

public class UniquePriorityAttribute : ValidationAttribute
{
    private readonly string _idPropertyName;

    public UniquePriorityAttribute(string idPropertyName)
    {
        _idPropertyName = idPropertyName;
    }

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null)
            return ValidationResult.Success;

        var dbContext = (AppDbContext)validationContext.GetService(typeof(AppDbContext))!;
        var currentPriority = (int)value;
        
        var idProperty = validationContext.ObjectType.GetProperty(_idPropertyName);
        if (idProperty == null)
        {
            throw new ArgumentException("Property with this name not found");
        }

        var idValue = idProperty.GetValue(validationContext.ObjectInstance);
        
        var isDuplicate = dbContext.Categories.Any(c => c != null && c.Priority == currentPriority && c.Id != (int)idValue);

        return isDuplicate ? new ValidationResult("This priority value is already in use.") : ValidationResult.Success;
    }
}