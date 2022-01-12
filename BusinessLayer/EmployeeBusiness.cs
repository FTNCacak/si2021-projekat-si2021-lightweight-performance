using DataLayer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private readonly EmployeeRepository employeeRepository = new EmployeeRepository();

        public List<Employee> GetAllEmployees()
        {
            return employeeRepository.GetAllEmployees().ToList();
        }

        public int GetEmployeeID(string firstName, string lastName)
        {
            int id = 0;
            List<Employee> employees = employeeRepository.GetAllEmployees();

            foreach (Employee employee in employees)
                if (employee.FirstName == firstName && employee.LastName == lastName)
                    id = employee.EmployeeID;

            return id;
        }
    }
}
