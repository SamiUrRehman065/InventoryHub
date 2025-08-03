using System.ComponentModel.DataAnnotations;

namespace EfHost.Models;

public class Product
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)] 
    public string Name { get; set; } = string.Empty;

    [Range(0.01, double.MaxValue)]
    public double Price { get; set; }

    [MaxLength(500)]
    public string Description { get; set; } = string.Empty;
   
}