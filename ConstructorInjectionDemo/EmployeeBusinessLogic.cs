using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInjectionDemo
{
    public class EmployeeBusinessLogic
    {
        public IEmployeeDataAccess employeeDataAccess;

        public EmployeeBusinessLogic(IEmployeeDataAccess _employeeDataAccess)
        {
            this.employeeDataAccess = _employeeDataAccess;
        }
        public List<Employee> GetEmployees()
        {            
            return employeeDataAccess.SelectAllEmployees();
        }

    }
}
