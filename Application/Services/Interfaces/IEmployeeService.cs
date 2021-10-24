using Application.DTOs.Employee;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<EmployeeGetDTO> InsertAsync(EmployeePostDTO model);

        Task<bool> EditAsync(EmployeePutDTO model);

        Task<bool> DeleteAsync(int id);

        Task<List<EmployeeGetDTO>> FindAllAsync(string search);

        Task<List<EmployeeGetDTO>> FindAllAsync();

        Task<EmployeeGetDTO> FindAsync(int id);
    }
}