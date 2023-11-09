using AutoMapper;
using SignalR.EntityLayer.Entities;
using SlgnalR.DtoLayer.ProductDto;

namespace SignalRApi.Mapping
{
    public class ProductMapping :Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
        }
    }
}
