using _00_Basic.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _00_Basic.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;

        // dependency injection
        public EmployeesController(IEmployeeRepository repository)
        {
            _repository = repository;
        }


        // get all employee
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetEmployees()
        {
            var employees = _repository.GetAll();
            return Ok(employees);
        }
        // get one employee
        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            var employee = _repository.GetById(id);
            return employee;
        }

        [HttpPost]
        public ActionResult<Employee> PostEmployee([FromBody] Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _repository.Add(employee);
            return CreatedAtAction(nameof(GetEmployee), new { id = employee.Id }, employee);
        }
        // update and existing employee entirly (Put/api/employee/{id})
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] Employee updateEmployee)
        {
            if(id != updateEmployee.Id)
            {
                return BadRequest("Employee id mismatch");
            }
            if(!_repository.Exists(id))
            {
                return NotFound();
            }
            _repository.Update(updateEmployee);
            return NoContent();
        }

        // particularly update an existing employee (PATCH/api/employee/{id})
        [HttpPatch("{id}")]
        public IActionResult PatchEmployee(int id, [FromBody] Employee employee)
        {
            var existingEmployee = _repository.GetById(id);
            if(existingEmployee == null)
            {
                return NotFound();
            }
            // for simplicity ,updating all fields . In real scanario, use JSON Patch.
            existingEmployee.Name = employee.Name ?? existingEmployee.Name;
            existingEmployee.Gender = employee.Gender ?? existingEmployee.Gender;
            existingEmployee.Salary = employee.Salary != 0 ? employee.Salary : existingEmployee.Salary;
            _repository.Update(existingEmployee);
            return NoContent();
        }

        // Deleates an employee (DELETE api/employee{id})
        public IActionResult DeleteEmployee(int id)
        {
            if(!_repository.Exists(id))
            {
                return NotFound();
            }
            _repository.Delete(id);
            return NoContent();
        }
    }
}
