using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DigitalBazaarWeb.Models.CustomValidation;
using Microsoft.EntityFrameworkCore;

namespace DigitalBazaarWeb.Models.Entites;

public class Category
{
    [Key] // Primary Key
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-Increment
    public int Id { get; set; }

    [Required] // Required
    [MaxLength(30)] // MaxLength 30
    public string Title { get; set; }

    [DefaultValue(0)] // Default value: 0
    public int Count { get; set; }

    [Required] // Required
    [DefaultValue(0)] // Default value: 0
    [UniquePriority("Id")] // Custom validation
    public int Priority { get; set; }

    [Required] // Required
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)] // Default to current date
    public DateTime CreatedDate { get; set; } = DateTime.Now;

    public DateTime? UpdatedDate { get; set; } // Nullable

    [Required] // Required
    [DefaultValue(true)] // Default value: true
    public bool IsActive { get; set; }
}