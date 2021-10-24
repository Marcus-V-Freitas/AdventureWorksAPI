using Application.DTOs.ProductModel;
using Domain.Entities;

namespace Application.Mappings
{
    public partial class DomainMappingProfile
    {
        private void ProductModelProfile()
        {
            CreateMap<ProductModel, ProductModelGetDTO>().ReverseMap();
            CreateMap<ProductModel, ProductModelPostDTO>().ReverseMap();
            CreateMap<ProductModel, ProductModelPutDTO>().ReverseMap();
        }
    }
}