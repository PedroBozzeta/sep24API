using sep2024.Domain.Models.Dtos;
using sep2024.Domain.Models.Entities;

namespace sep2024.Application.General.Services
{
    public interface IProductService

    {
        Task<IReadOnlyList<Product>> FindAllAsync();
        Task<Product> FindById(int id);
        Task<Product> Update(int id, ProductSaveDto product);
        Task<Product> CreateAync(ProductSaveDto product);
        Task<Product> DeleteById(int id);

    }
}
