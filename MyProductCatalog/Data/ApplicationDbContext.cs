// In Data/ApplicationDbContext.cs

using Microsoft.EntityFrameworkCore;
using MyProductCatalog.Models; // We need to use our Product model

namespace MyProductCatalog.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // This creates a table named "Products" in the database
        public DbSet<Product> Products { get; set; }
    }
}