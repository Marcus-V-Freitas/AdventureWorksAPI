using Application.DTOs.Product;
using Domain.Entities;

namespace Application.Mappings
{
    public partial class DomainMappingProfile
    {
        private void ProductProfile()
        {
            CreateMap<Product, ProductGetDTO>().ReverseMap();
            CreateMap<Product, ProductPostDTO>().ReverseMap();
            CreateMap<Product, ProductPutDTO>().ReverseMap();
        }
    }
}