using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using System.Data.SqlClient;

namespace DataLayer
{
    public class EmployeeRepository
    {
        //Dalibor
        private readonly string connString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=GymDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employeeList = new List<Employee>();

            using (SqlConnection sqlConnection = new SqlConnection(connString))
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
                        PersonalNumber = dataReader.GetInt32(0),
                        FirstName = dataReader.GetString(1),
                        LastName = dataReader.GetString(2),
                        EmploymentDate = dataReader.GetDateTime(3),
                        ContractExpiration = dataReader.GetDateTime(4),
                        Address = dataReader.GetString(5),
                        PhoneNumber = dataReader.GetString(6),
                        BirthDate = dataReader.GetDateTime(7)
                    };

                    employeeList.Add(employee);
                }
            }
            return employeeList;
        }

        public int InsertEmployee(Employee employee)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = string.Format("INSERT INTO Employees VALUES ('[0]','[1]','[2]','[3]','[4]','[5]','[6]','[7]')",
                    employee.PersonalNumber, employee.FirstName, employee.LastName, employee.EmploymentDate, employee.ContractExpiration, employee.Address, employee.PhoneNumber, employee.BirthDate)
                };

                return command.ExecuteNonQuery();   
            }
        }

        public int UpdateEmployee(Employee employee)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
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

        public int DeleteEmployee(int PersonalNumber)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = string.Format("DELETE FROM Employees WHERE PersonalNumber= {0}", PersonalNumber)
                };

                return command.ExecuteNonQuery();
            }
        }
    }
}
