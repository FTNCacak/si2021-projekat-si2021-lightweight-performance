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
    }
}
