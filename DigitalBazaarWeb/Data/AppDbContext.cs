using DigitalBazaarWeb.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace DigitalBazaarWeb.Data;

// Passing Configuration To DbContext Using Dependency Injection
public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Category?> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Unique constraint (Note: Use Fluent API for unique index)
        modelBuilder.Entity<Category>().HasIndex(x => x.Priority).IsUnique();
    }
}