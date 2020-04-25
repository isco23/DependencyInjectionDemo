using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodInjectionDemo
{
    public class EmployeeBusinessLogic
    {
        public IEmployeeDataAccess employeeDataAccess;

        public List<Employee> GetEmployees(IEmployeeDataAccess _employeeDataAccess)
        {
            employeeDataAccess = _employeeDataAccess;
            return employeeDataAccess.SelectAllEmployees();
        }

    }
}
