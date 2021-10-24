using Application.DTOs.ProductCategory;
using Domain.Entities;

namespace Application.Mappings
{
    public partial class DomainMappingProfile
    {
        private void ProductCategoryProfile()
        {
            CreateMap<ProductCategory, ProductCategoryGetDTO>().ReverseMap();
            CreateMap<ProductCategory, ProductCategoryPostDTO>().ReverseMap();
            CreateMap<ProductCategory, ProductCategoryPutDTO>().ReverseMap();
        }
    }
}