using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Template.Models.Entities;

public class Order
{
    [Key]
    public int Id { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
    public DateTime? FullfilledAt { get; set; }
    public int ClientId { get; set; }
    public int StatusId { get; set; }
    
    [ForeignKey(nameof(ClientId))]
    public virtual Client Client { get; set; }
    [ForeignKey(nameof(StatusId))]
    public virtual Status Status { get; set; }
}