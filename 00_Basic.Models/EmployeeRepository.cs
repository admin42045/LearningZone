using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _00_Basic.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> employeeRepository;
        public EmployeeRepository()
        {
            employeeRepository = new List<Employee>
            {
                new Employee() { Id = 1, Name = "Paul", Gender = "M", Salary = 2000 },
                new Employee() { Id = 2, Name = "Timsun", Gender = "F", Salary = 4000 },
            };           
        }           
        public void Add(Employee employee)
        {
            employee.Id = employeeRepository.Max(e => e.Id) + 1;
            employeeRepository.Add(employee);
        }

        public void Delete(int id)
        {
            var employee = GetById(id);
            if(employee != null)
            {
                employeeRepository.Remove(employee);
            }
        }
        public bool Exists(int id)
        {
            return employeeRepository.Any(e => e.Id == id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return employeeRepository;
        }

        public Employee GetById(int id)
        {
            return employeeRepository.FirstOrDefault(e => e.Id == id);
        }

        public void Update(Employee employee)
        {
            var existingEmployee = GetById(employee.Id);
            if(existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                existingEmployee.Gender = employee.Gender;
                existingEmployee.Salary = employee.Salary;
            }
        }
    }
}