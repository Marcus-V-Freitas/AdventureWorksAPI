using Application.DTOs.ProductSubCategory;
using Domain.Entities;

namespace Application.Mappings
{
    public partial class DomainMappingProfile
    {
        private void ProductSubCategoryProfile()
        {
            CreateMap<ProductSubCategory, ProductSubCategoryGetDTO>().ReverseMap();
            CreateMap<ProductSubCategory, ProductSubCategoryPostDTO>().ReverseMap();
            CreateMap<ProductSubCategory, ProductSubCategoryPutDTO>().ReverseMap();
        }
    }
}