using Microsoft.EntityFrameworkCore;
using Template.Models.Entities;

namespace Template.Models;

public class Context : DbContext
{

    public Context()
    {
    }
    
    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }
    
    public virtual DbSet<Entities.Template> Template { get; set; }
    
}