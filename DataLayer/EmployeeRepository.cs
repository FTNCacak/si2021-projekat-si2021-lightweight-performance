using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employeeList = new List<Employee>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = "SELECT * FROM Employees"
                };

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Employee employee = new Employee
                    {
                        EmployeeID = dataReader.GetInt32(0),
                        PersonalNumber = dataReader.GetString(1),
                        FirstName = dataReader.GetString(2),
                        LastName = dataReader.GetString(3),
                        EmploymentDate = dataReader.GetDateTime(4),
                        ContractExpiration = dataReader.GetDateTime(5),
                        Address = dataReader.GetString(6),
                        PhoneNumber = dataReader.GetString(7),
                        BirthDate = dataReader.GetDateTime(8)
                    };

                    employeeList.Add(employee);
                }
            }
            return employeeList;
        }

        public int InsertEmployee(Employee employee)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Employees VALUES(@PersonalNumber, @FirstName, @LastName, @EmploymentDate, @ContractExpiration, @Address, @PhoneNumber, @BirthDate)", sqlConnection);

                command.Parameters.AddWithValue("@PersonalNumber", employee.PersonalNumber);
                command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                command.Parameters.AddWithValue("@LastName", employee.LastName);
                command.Parameters.AddWithValue("@EmploymentDate", employee.EmploymentDate);
                command.Parameters.AddWithValue("@ContractExpiration", employee.ContractExpiration);
                command.Parameters.AddWithValue("@Address", employee.Address);
                command.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                command.Parameters.AddWithValue("@BirthDate", employee.BirthDate);

                return command.ExecuteNonQuery();
            }
        }

        //izmeniti metodu ako se bude koristila
        public int UpdateEmployee(Employee employee)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                string sqlQuery = "UPDATE Employees SET PersonalNumber = @PersonalNumber, FirstName = @FirstName, LastName = @LastName, EmploymentDate = @EmploymentDate, ContractExpiration = @ContractExpiration, Address = @Address, PhoneNumber = @PhoneNumber, BirthDate = @BirthDate";

                SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
                command.Parameters.AddWithValue("@PersonalNumber", employee.PersonalNumber);
                command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                command.Parameters.AddWithValue("@LastName", employee.LastName);
                command.Parameters.AddWithValue("@EmploymentDate", employee.EmploymentDate);
                command.Parameters.AddWithValue("@ContractExpiration", employee.ContractExpiration);
                command.Parameters.AddWithValue("@Address", employee.Address);
                command.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                command.Parameters.AddWithValue("@BirthDate", employee.BirthDate);

                return command.ExecuteNonQuery();
            }
        }

        public int DeleteEmployee(int EmployeeID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = string.Format("DELETE FROM Employees WHERE EmployeeID = {0}", EmployeeID)
                };

                return command.ExecuteNonQuery();
            }
        }
    }
}
