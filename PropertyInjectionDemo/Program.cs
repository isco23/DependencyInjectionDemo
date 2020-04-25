using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInjectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
            employeeBusinessLogic.empDataObject = new EmployeeDataAccess();

            List<Employee> listEmp = employeeBusinessLogic.GetAllEmployees();
            foreach (Employee employee in listEmp)
            {
                Console.WriteLine("Id = {0} , Name = {1} , Department = {2}", employee.Id, employee.Name, employee.Department);
            }
            Console.ReadKey();
        }
    }
}
