using Shared.Interfaces;
using Shared.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

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

                SqlCommand command = new SqlCommand("INSERT INTO Trainings VALUES(@Appointment, @MembershipID, @EmployeeID, @Type)", sqlConnection);

                command.Parameters.AddWithValue("@Appointment", training.Appointment);
                command.Parameters.AddWithValue("@MembershipID", training.MembershipID);
                command.Parameters.AddWithValue("@EmployeeID", training.EmployeeID);
                command.Parameters.AddWithValue("@Type", training.Type);

                return command.ExecuteNonQuery();
            }
        }
    }
}
