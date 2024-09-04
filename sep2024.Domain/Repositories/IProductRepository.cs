
using sep2024.Domain.Models.Entities;

namespace sep2024.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IReadOnlyList<Product>> FindAllAsync();
        Task<Product> FindByIdAsync(int id);
        Task<Product> SaveAsync(Product product);
    }
}
