using Application.DTOs.Employee;
using Domain.Entities;

namespace Application.Mappings
{
    public partial class DomainMappingProfile
    {
        private void EmployeeProfile()
        {
            CreateMap<Employee, EmployeeGetDTO>().ReverseMap();
            CreateMap<Employee, EmployeePostDTO>().ReverseMap();
            CreateMap<Employee, EmployeePutDTO>().ReverseMap();
        }
    }
}