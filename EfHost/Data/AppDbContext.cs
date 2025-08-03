using Microsoft.EntityFrameworkCore;
using EfHost.Models;

namespace EfHost.Data;

public class AppDbContext : DbContext
{
    // Constructor that accepts DbContextOptions and passes them to the base class
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    // DbSet property for Product entity
    public DbSet<Product> Products => Set<Product>();


    // Override the OnModelCreating method to configure the model
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Call the base method to ensure any configurations in the base class are applied
        base.OnModelCreating(modelBuilder);

        // Configure the Product entity
        modelBuilder.Entity<Product>().HasData(
            new Product 
            { 
                Id = 1,
                Name = "Starter Widget",
                Price = 99.99,
                Description = "A versatile widget that meets all your starter needs."
            },
            new Product
            {
                Id = 2,
                Name = "Pro Gear",
                Price = 249.50,
                Description = "High-end gear for serious inventory operations. Durable, sleek, and reliable."
            }
        );

    }
}
