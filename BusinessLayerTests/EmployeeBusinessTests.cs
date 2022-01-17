using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;

namespace BusinessLayerTests
{
    [TestClass]
    public class EmployeeBusinessTests
    {
        private readonly Mock<IEmployeeRepository> mockEmployeeRepository = new Mock<IEmployeeRepository>();
        private EmployeeBusiness employeeBusiness;
        private readonly List<Employee> employees = new List<Employee>();
        private readonly Employee employee = new Employee
        {
            EmployeeID = 1,
            PersonalNumber = "2512000123456",
            FirstName = "Dalibor",
            LastName = "Tosic",
            EmploymentDate = DateTime.Now,
            ContractExpiration = DateTime.Now.AddYears(2),
            Address = "adresa",
            PhoneNumber = "1234567890",
            BirthDate = Convert.ToDateTime("1/1/2000 00:00:00")
        };

        [TestInitialize]
        public void Initialize()
        {
            employees.Add(employee);
            employees.Add(new Employee
            {
                EmployeeID = 2,
                PersonalNumber = "2912000123456",
                FirstName = "Aleksa",
                LastName = "Matovic",
                EmploymentDate = DateTime.Now,
                ContractExpiration = DateTime.Now.AddYears(2),
                Address = "adresa",
                PhoneNumber = "1234567890",
                BirthDate = Convert.ToDateTime("1/1/2000 00:00:00")
            });
        }

        [TestMethod]
        public void SearchEmployee_MatchExists()
        {
            // Arrange

            mockEmployeeRepository.Setup(x => x.GetAllEmployees()).Returns(employees);
            employeeBusiness = new EmployeeBusiness(mockEmployeeRepository.Object);

            // Act

            var result = employeeBusiness.SearchEmployee("Dalibor", "Tosic");

            // Assert

            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void GetEmployeeID_ReturnsID()
        {
            // Arrange

            mockEmployeeRepository.Setup(x => x.GetAllEmployees()).Returns(employees);
            employeeBusiness = new EmployeeBusiness(mockEmployeeRepository.Object);

            // Act

            var result = employeeBusiness.GetEmployeeID("Dalibor", "Tosic");

            // Assert

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetAllEmployees_ReturnsNotNull()
        {
            // Arrange

            mockEmployeeRepository.Setup(x => x.GetAllEmployees()).Returns(employees);
            employeeBusiness = new EmployeeBusiness(mockEmployeeRepository.Object);

            // Act

            var result = employeeBusiness.GetAllEmployees();

            // Assert

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void InsertEmployee_IsInserted()
        {
            // Arrange

            mockEmployeeRepository.Setup(x => x.InsertEmployee(employee)).Returns(1);
            employeeBusiness = new EmployeeBusiness(mockEmployeeRepository.Object);

            // Act

            var result = employeeBusiness.InsertEmployee(employee);

            // Assert

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UpdateEmployeeDetails_IsUpdated()
        {
            // Arrange

            mockEmployeeRepository.Setup(x => x.UpdateEmployeeDetails(employee)).Returns(1);
            employeeBusiness = new EmployeeBusiness(mockEmployeeRepository.Object);

            // Act

            var result = employeeBusiness.UpdateEmployeeDetails(employee);

            // Assert

            Assert.IsTrue(result);
        }
    }
}
