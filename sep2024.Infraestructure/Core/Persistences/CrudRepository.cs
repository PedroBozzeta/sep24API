
using sep2024.Domain.Models.Entities;

namespace sep2024.Infraestructure.Core.Persistences
{
    public abstract class CrudRepository<T, ID>
    {
        public Task<IReadOnlyList<Product>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> SaveAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
