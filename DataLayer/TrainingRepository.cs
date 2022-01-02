using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using System.Data.SqlClient;

namespace DataLayer
{
    public class TrainingRepository
    {
        private string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GymDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<Training> GetAllTrainings()
        {
            List<Training> trainingList = new List<Training>();
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT * FROM Training";

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Training training = new Training();
                    training.Appointment = dataReader.GetDateTime(0);
                    training.CardNumber = dataReader.GetInt32(1);
                    training.PersonalNumber = dataReader.GetInt32(2);
                    training.Type = dataReader.GetString(3);
                    trainingList.Add(training);
                }
            }
            return trainingList;
        }

        public int InsertTraining(Training training)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO Training VALUES ('[0]','[1]','[2]','[3]')",
                    training.Appointment, training.CardNumber, training.PersonalNumber, training.Type);
                return command.ExecuteNonQuery();
            }
        }

        public int UpdateTraining(Training training)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                string sqlQuery = "UPDATE Training SET Appointment = @Appointment, CardNumber = @CardNumber, PersonalNumber = @PersonalNmber, Type = @Type";

                SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
                command.Parameters.AddWithValue("@PersonalNumber", training.Appointment);
                command.Parameters.AddWithValue("@FirstName", training.CardNumber);
                command.Parameters.AddWithValue("@LastName", training.PersonalNumber);
                command.Parameters.AddWithValue("@EmploymentDate", training.Type);
                return command.ExecuteNonQuery();
            }
        }

        public int DeleteTraining(DateTime Appointment, int CardNumber, int PersonalNumber)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;
                command.CommandText = string.Format("DELETE FROM Training WHERE Appointment= {0}, CardNumber = {1}, PersonalNumber = {2}", Appointment, CardNumber, PersonalNumber);

                return command.ExecuteNonQuery();
            }
        }
    }
}
