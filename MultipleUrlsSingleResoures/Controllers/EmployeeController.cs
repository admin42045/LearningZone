using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultipleUrlsSingleResoures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleUrlsSingleResoures.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("All")]
        [HttpGet("AllEmployees")]
        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            var employee = EmployeeData.Employee;
            return Ok(employee);
        }

        [Route("api/old-employees")]
        [Route("api/stuff")]
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAllEmployeess()
        {
            var employees = EmployeeData.Employee;
            return Ok(employees);
        }
    }
}
