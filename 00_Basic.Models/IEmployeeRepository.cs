using System;
using System.Collections.Generic;
using System.Text;

namespace _00_Basic.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
        bool Exists(int id);
    }
}
