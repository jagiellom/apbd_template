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
    
    public virtual DbSet<Client> Clients { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<ProductOrder> ProductOrders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Client>(e =>
            e.HasData(new List<Client>()
            {
                new Client(){
                    Id = 1,
                    FirstName = "Adam",
                    LastName = "Mickiewicz"
                },
                new Client()
                {
                    Id = 2,
                    FirstName = "Jan",
                    LastName = "Kowalski"
                }
            }));

        modelBuilder.Entity<Product>(e =>
            e.HasData(new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Krem",
                    Price = (decimal)10.2
                },
                new Product()
                {
                    Id = 2,
                    Name = "Chleb baltonowski krojony",
                    Price = (decimal)123.12
                }
            }));

        modelBuilder.Entity<Status>(e =>
            e.HasData(new List<Status>()
            {
                new Status()
                {
                    Id = 1,
                    Name = "Gotowy"
                },
                new Status()
                {
                    Id = 2,
                    Name = "W przygotowaniu"
                }
            }));

        modelBuilder.Entity<Order>(e =>
            e.HasData(new List<Order>()
            {
                new Order()
                {
                    Id = 1,
                    ClientId = 1,
                    CreatedAt = new DateTime(2023, 2, 5),
                    FullfilledAt = null,
                    StatusId = 2
                },
                new Order()
                {
                    Id = 2,
                    ClientId = 2,
                    CreatedAt = new DateTime(2023, 2, 5),
                    FullfilledAt = new DateTime(2023, 2, 5),
                    StatusId = 1
                }
            }));

        modelBuilder.Entity<ProductOrder>(e =>
            e.HasData(new List<ProductOrder>()
            {
                new ProductOrder()
                {
                    Amount = 10,
                    OrderId = 1,
                    ProductId = 1
                },
                new ProductOrder()
                {
                    Amount = 20,
                    OrderId = 2,
                    ProductId = 2
                }
            }));
    }
}