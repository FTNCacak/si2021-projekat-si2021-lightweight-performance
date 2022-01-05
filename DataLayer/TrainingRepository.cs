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
    public class TrainingRepository : ITrainingRepository
    {
        public List<Training> GetAllTrainings()
        {
            List<Training> trainingList = new List<Training>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = "SELECT * FROM Trainings"
                };

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Training training = new Training
                    {
                        Appointment = dataReader.GetDateTime(0),
                        MembershipID = dataReader.GetInt32(1),
                        EmployeeID = dataReader.GetInt32(2),
                        Type = dataReader.GetString(3)
                    };
                    trainingList.Add(training);
                }
            }
            return trainingList;
        }

        public int InsertTraining(Training training)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = string.Format("INSERT INTO Trainings VALUES ('[0]','[1]','[2]','[3]')", training.Appointment, training.MembershipID, training.EmployeeID, training.Type)
                };

                return command.ExecuteNonQuery();
            }
        }

        //izmeniti metodu ako se bude koristila
        public int UpdateTraining(Training training)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                string sqlQuery = "UPDATE Trainings SET Appointment = @Appointment, CardNumber = @CardNumber, PersonalNumber = @PersonalNmber, Type = @Type";

                SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
                command.Parameters.AddWithValue("@PersonalNumber", training.Appointment);
                command.Parameters.AddWithValue("@FirstName", training.MembershipID);
                command.Parameters.AddWithValue("@LastName", training.EmployeeID);
                command.Parameters.AddWithValue("@EmploymentDate", training.Type);

                return command.ExecuteNonQuery();
            }
        }

        public int DeleteTraining(DateTime Appointment, int MembershipID, int EmployeeID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = string.Format("DELETE FROM Trainings WHERE Appointment = {0}, MembershipID = {1}, EmployeeID = {2}", Appointment, MembershipID, EmployeeID)
                };

                return command.ExecuteNonQuery();
            }
        }
    }
}
