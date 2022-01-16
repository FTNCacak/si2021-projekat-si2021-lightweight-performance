using Shared.Interfaces;
using Shared.Models;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeBusiness(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public List<Employee> SearchEmployee(string firstName, string lastName)
        {
            return employeeRepository.GetAllEmployees().Where(employee => employee.FirstName.ToUpper().Equals(firstName.ToUpper()) && employee.LastName.ToUpper().Equals(lastName.ToUpper())).ToList();
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

        public List<Employee> GetAllEmployees()
        {
            return employeeRepository.GetAllEmployees().ToList();
        }

        public bool InsertEmployee(Employee employee)
        {
            return employeeRepository.InsertEmployee(employee) != 0;
        }

        public bool UpdateEmployeeDetails(Employee employee)
        {
            return employeeRepository.UpdateEmployeeDetails(employee) != 0;
        }
    }
}
