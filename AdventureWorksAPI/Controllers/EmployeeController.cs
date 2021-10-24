using Application.DTOs.Employee;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace AdventureWorksAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        /// <summary>
        /// Get All Employees
        /// </summary>
        /// <returns> Array Employees </returns>
        [HttpGet("", Name = "GetAllEmployee")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200", Type = typeof(IEnumerable<EmployeeGetDTO>))]
        [SwaggerResponse((int)HttpStatusCode.NotFound, Description = "Missing Employees object")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _employeeService.FindAllAsync();

            if (result == null)
            {
                return NotFound(null);
            }

            return Ok(result);
        }

        /// <summary>
        /// Get Employee By Id
        /// </summary>
        /// <returns> Employee </returns>
        [HttpGet("{employeeID:int}", Name = "GetByEmployeeId")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200", Type = typeof(EmployeeGetDTO))]
        [SwaggerResponse((int)HttpStatusCode.NotFound, Description = "Missing Employee object")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> GetByEmployeeIdAsync([FromRoute] int employeeID)
        {
            var result = await _employeeService.FindAsync(employeeID);

            if (result == null)
            {
                return NotFound(null);
            }

            return Ok(result);
        }

        /// <summary>
        /// Create Employee Object
        /// </summary>
        /// <param name="Employee"> Employee Data </param>
        /// <returns> Employee </returns>
        [HttpPost("", Name = "CreateEmployee")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200", Type = typeof(EmployeeGetDTO))]
        [SwaggerResponse((int)HttpStatusCode.NotFound, Description = "Missing Employee object")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> CreateEmployeeAsync([FromBody] EmployeePostDTO Employee)
        {
            var result = await _employeeService.InsertAsync(Employee);

            if (result == null)
            {
                return NotFound(null);
            }

            return Ok(result);
        }

        /// <summary>
        /// Update Employee Object
        /// </summary>
        /// <param name="Employee"> Employee Data </param>
        /// <returns> bool </returns>
        [HttpPut("", Name = "UpdateEmployee")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200", Type = typeof(bool))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> UpdateEmployeeAsync([FromBody] EmployeePutDTO Employee)
        {
            return Ok(await _employeeService.EditAsync(Employee));
        }

        /// <summary>
        /// Delete Employee Object
        /// </summary>
        /// <param name="EmployeeID"> Employee Code </param>
        /// <returns> bool </returns>
        [HttpDelete("{employeeID:int}", Name = "DeleteEmployee")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Returns 200", Type = typeof(bool))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public async Task<IActionResult> DeleteEmployeeAsync([FromBody] int employeeID)
        {
            return Ok(await _employeeService.DeleteAsync(employeeID));
        }
    }
}