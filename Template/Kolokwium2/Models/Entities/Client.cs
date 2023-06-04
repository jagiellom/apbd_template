using System.ComponentModel.DataAnnotations;

namespace Template.Models.Entities;

public class Client
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }
}