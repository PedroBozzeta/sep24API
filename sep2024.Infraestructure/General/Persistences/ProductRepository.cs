using Microsoft.EntityFrameworkCore;
using sep2024.Domain.Models.Entities;
using sep2024.Domain.Repositories;
using sep2024.Infraestructure.Core.Contexts;

namespace sep2024.Infraestructure.General.Persistences
{
    public class ProductRepository : IProductRepository

    {

        private readonly ApplicationDbContext _dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public virtual async Task<IReadOnlyList<Product>> FindAllAsync()
        {
            return await _dbContext.Products.AsNoTracking().ToListAsync();
        }

        public virtual async Task<Product> FindByIdAsync(int id)
        {
            return await _dbContext.Products.FindAsync(id);
        }

        public virtual async Task<Product> SaveAsync(Product product)
        {
            EntityState state = _dbContext.Entry(product).State;
            if (state == EntityState.Detached)
            {
                _dbContext.Products.Add(product);
            }
            // Si la entidad está en estado Modified, se actualiza
            else if (state == EntityState.Modified)
            {
                _dbContext.Products.Update(product);
            }

            await _dbContext.SaveChangesAsync();
            return product;
        }
    }
}
