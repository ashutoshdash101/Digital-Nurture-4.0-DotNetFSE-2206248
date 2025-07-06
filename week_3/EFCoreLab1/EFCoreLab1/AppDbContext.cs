using EFCoreLab1.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreLab1
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=RetailDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
