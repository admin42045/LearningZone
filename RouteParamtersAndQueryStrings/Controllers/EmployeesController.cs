using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RouteParamtersAndQueryStrings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RouteParamtersAndQueryStrings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetEmployees()
        {
            return Ok(EmployeeData.employees.ToList());
        }
        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployeeById(int id)
        {
            var employee = EmployeeData.employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return NotFound($"Employee with {id} not found!");
            return Ok(employee);
        }
        // handling multiple route parameter
        [HttpGet("Gender/{gender}/City/{city}")]
        public ActionResult<IEnumerable<Employee>> GetEmployeesByGenderAndCity(string gender, string city)
        {
            var filteredEmployee = EmployeeData.employees
                                    .Where(e => e.Gender.Equals(gender, StringComparison.OrdinalIgnoreCase) &&
                                    e.City.Equals(city, StringComparison.OrdinalIgnoreCase))
                                    .ToList();
            if (!filteredEmployee.Any())
                return NotFound($"No employee found with gendre {gender} in city {city}");
            return Ok(filteredEmployee);
        }

        // GET/api/employees/Search?Department=IT
        [HttpGet("Search")]
        public ActionResult<IEnumerable<Employee>> SearchEmployees([FromQuery] string department)
        {
            var filteredEmployee = EmployeeData.employees
                                    .Where(e => e.Department.Equals(department, StringComparison.OrdinalIgnoreCase))
                                    .ToList();
            if(!filteredEmployee.Any())
            {
                return NotFound($"No employee found in department {department}.");
            }
            return Ok(filteredEmployee);
        }
        // GET/api/employees/Search?Gender=M&Department=IT&City=Los Angles
        public ActionResult<IEnumerable<Employee>> SearchEmployeeByCityAndDepartment([FromQuery] string? gender,[FromQuery] string? department, [FromQuery] string? city)
        {
            var filteredEmployee = EmployeeData.employees.AsEnumerable();
            if (!string.IsNullOrEmpty(gender)) filteredEmployee = filteredEmployee.Where(e => e.Gender.Equals(gender, StringComparison.OrdinalIgnoreCase));
            if (!string.IsNullOrEmpty(department)) filteredEmployee = filteredEmployee.Where(e => e.Department.Equals(department, StringComparison.OrdinalIgnoreCase));
            if (!string.IsNullOrEmpty(city)) filteredEmployee = filteredEmployee.Where(e => e.City.Equals(city, StringComparison.OrdinalIgnoreCase));
            var result = filteredEmployee.ToList();
            return Ok(result);
        }
    };
}
