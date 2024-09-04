using AutoMapper;
using sep2024.Domain.Models.Dtos;
using sep2024.Domain.Models.Entities;

namespace sep2024.Application.General.Mappers
{
    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<Product, ProductSaveDto>();
            CreateMap<ProductSaveDto, Product>().ReverseMap();
        }
    }
}
