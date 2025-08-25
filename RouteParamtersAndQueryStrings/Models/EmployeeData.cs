using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RouteParamtersAndQueryStrings.Models
{
    public class EmployeeData
    {
        public static List<Employee> employees = new List<Employee>
        {
            new Employee() {Id = 1, Name = "Paul", Gender = "M", Department = "IT", City = "Los Angles"},
            new Employee() {Id = 2, Name = "Tina", Gender = "F", Department = "Support", City = "San Franscisco"},
        };
    }
}
