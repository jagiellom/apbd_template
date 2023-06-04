using System.ComponentModel.DataAnnotations;

namespace Template.Models.Entities;

public class Product
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [Required]
    public decimal Price { get; set; }
}