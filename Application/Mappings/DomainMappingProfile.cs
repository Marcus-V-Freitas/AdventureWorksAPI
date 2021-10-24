using AutoMapper;

namespace Application.Mappings
{
    public partial class DomainMappingProfile : Profile
    {
        public DomainMappingProfile()
        {
            ProductProfile();
            ProductModelProfile();
            ProductCategoryProfile();
            ProductSubCategoryProfile();
            EmployeeProfile();
        }
    }
}