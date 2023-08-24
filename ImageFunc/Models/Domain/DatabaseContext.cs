using Microsoft.EntityFrameworkCore;

namespace ImageFunc.Models.Domain
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
            // Initialize non-nullable properties in the constructor
            Product = Set<Product>(); // Assuming Product is a DbSet<Product>
        }

        public DbSet<Product> Product { get; set; }
    }
}
