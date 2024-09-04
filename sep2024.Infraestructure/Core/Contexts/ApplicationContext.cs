using Microsoft.EntityFrameworkCore;
using sep2024.Domain.Models.Entities;
using sep2024.Infraestructure.General.Configurations;

namespace sep2024.Infraestructure.Core.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }

    }
}
