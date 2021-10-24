using Application.DTOs.Employee;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.Repository
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _employeeRepository.DeleteAsync(x => x.EmployeeID == id);
        }

        public async Task<bool> EditAsync(EmployeePutDTO model)
        {
            var employee = _mapper.Map<Employee>(model);
            return await _employeeRepository.EditAsync(employee, employee.EmployeeID.Value);
        }

        public async Task<List<EmployeeGetDTO>> FindAllAsync(string search)
        {
            var employees = await _employeeRepository.FindAllAsync(x => x.Title == search);
            return _mapper.Map<List<EmployeeGetDTO>>(employees);
        }

        public async Task<List<EmployeeGetDTO>> FindAllAsync()
        {
            var employees = await _employeeRepository.FindAllAsync();
            return _mapper.Map<List<EmployeeGetDTO>>(employees);
        }

        public async Task<EmployeeGetDTO> FindAsync(int id)
        {
            var employee = await _employeeRepository.FindAsync(x => x.EmployeeID == id);
            return _mapper.Map<EmployeeGetDTO>(employee);
        }

        public async Task<EmployeeGetDTO> InsertAsync(EmployeePostDTO model)
        {
            var employee = _mapper.Map<Employee>(model);
            var employeeInserted = await _employeeRepository.InsertAsync(employee);
            return _mapper.Map<EmployeeGetDTO>(employeeInserted);
        }
    }
}