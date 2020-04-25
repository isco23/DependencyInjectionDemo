using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInjectionDemo
{
    public class EmployeeBusinessLogic
    {
        private IEmployeeDataAccess employeeDataAccess;
        public IEmployeeDataAccess empDataObject
        {
            set
            {
                this.employeeDataAccess = value;
            }
            get
            {
                if(empDataObject == null)
                {
                    throw new Exception("Employee is not initialized");
                }
                else
                {
                    return employeeDataAccess;
                }
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeDataAccess.SelectAllEmployees();
        }
    }
}
