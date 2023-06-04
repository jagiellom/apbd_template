using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Template.Models.Entities;

[PrimaryKey(nameof(ProductId), nameof(OrderId))]
public class ProductOrder
{
    public int ProductId { get; set; }
    public int OrderId { get; set; }
    public int Amount { get; set; }
    
    [ForeignKey(nameof(ProductId))]
    public virtual Product Product { get; set; }
    [ForeignKey(nameof(OrderId))]
    public virtual Order Order { get; set; }
}