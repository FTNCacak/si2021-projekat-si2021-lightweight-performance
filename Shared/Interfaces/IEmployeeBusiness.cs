using Shared.Models;
using System.Collections.Generic;

namespace Shared.Interfaces
{
    public interface IEmployeeBusiness
    {
        List<Employee> SearchEmployee(string firstName, string lastName);
        int GetEmployeeID(string firstName, string lastName);
        List<Employee> GetAllEmployees();
        bool InsertEmployee(Employee employee);
        bool UpdateEmployeeDetails(Employee employee);
    }
}
