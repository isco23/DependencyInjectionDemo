using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodInjectionDemo
{
    public interface IEmployeeDataAccess
    {
        List<Employee> SelectAllEmployees();
    }
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> _listEmployees = new List<Employee>();
            _listEmployees.Add(new Employee() { Id = 1, Name = "Isco", Department = "IT" });
            _listEmployees.Add(new Employee() { Id = 2, Name = "Ozil", Department = "EC" });
            _listEmployees.Add(new Employee() { Id = 3, Name = "Dimaria", Department = "AME" });
            return _listEmployees;
        }
    }
}
