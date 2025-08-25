using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleUrlsSingleResoures.Models
{
    public static class EmployeeData
    {

        public static List<Employee> Employee = new List<Employee>
        {
            new Employee() { Id = 1, Name = "Paul", Gender = "Male", Department = "HR", City = "Los Angles"},
            new Employee() { Id = 2, Name = "Simsun", Gender = "Female", Department = "IT", City = "San Fransisco"},
            new Employee() { Id = 3, Name = "Simsutn", Gender = "Male", Department = "IT", City = "San Fransisco"},
            new Employee() { Id = 4, Name = "Simsusn", Gender = "Female", Department = "HR", City = "San Fransissco"},
            new Employee() { Id = 5, Name = "timsun", Gender = "Male", Department = "IT", City = "San Fransiscod"},
            new Employee() { Id = 6, Name = "LKimsun", Gender = "Female", Department = "HR", City = "San Fransisdco"},

        };
    }
}
