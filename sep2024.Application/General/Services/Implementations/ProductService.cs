using AutoMapper;
using sep2024.Domain.Models.Dtos;
using sep2024.Domain.Models.Entities;
using sep2024.Infraestructure.General.Persistences;

namespace sep2024.Application.General.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _productoRepository;
        private readonly IMapper _mapper;

        public ProductService(ProductRepository productoRepository, IMapper mapper)
        {
            _productoRepository = productoRepository;
            _mapper = mapper;
        }
        public async Task<Product> CreateAync(ProductSaveDto productDto)
        {
            Product producto = _mapper.Map<Product>(productDto);
            return await _productoRepository.SaveAsync(producto);
        }

        public async Task<Product> DeleteById(int id)
        {
            Product producto = await _productoRepository.FindByIdAsync(id);
            if (producto != null)
            {
                producto.State = false;
            }
            return await _productoRepository.SaveAsync(producto);
        }

        public async Task<IReadOnlyList<Product>> FindAllAsync()
        {
            IReadOnlyList<Product> products = await _productoRepository.FindAllAsync();

            return products;
        }

        public async Task<Product> FindById(int id)
        {
            return await _productoRepository.FindByIdAsync(id);
        }

        public async Task<Product> Update(int id, ProductSaveDto productSaveDto)
        {
            Product producto = await _productoRepository.FindByIdAsync(id);

            if (producto != null)
            {
                _mapper.Map<ProductSaveDto, Product>(productSaveDto, producto);
                return await _productoRepository.SaveAsync(producto);
            }
            throw new Exception("Producto no encontrado");
        }
    }
}
