using Shared.Models;
using System.Collections.Generic;

namespace Shared.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        int InsertEmployee(Employee employee);
        int UpdateEmployeeDetails(Employee employee);
    }
}
