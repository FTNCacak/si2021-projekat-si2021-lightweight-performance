using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using System.Data.SqlClient;

namespace DataLayer
{
    public class CheckinRepository
    {
        //Dalibor
        private readonly string connString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=GymDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public List<Checkin> GetAllCheckins()
        {
            List<Checkin> checkinList = new List<Checkin>();

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = "SELECT * FROM Checkins"
                };

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Checkin checkin = new Checkin
                    {
                        CheckinDate = dataReader.GetDateTime(0),
                        CardNumber = dataReader.GetInt32(1)
                    };

                    checkinList.Add(checkin);
                }
            }
            return checkinList;
        }

        public int InsertCheckin(Checkin checkin)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = string.Format("INSERT INTO Checkins VALUES ('[0]','[1]')",
                    checkin.CheckinDate, checkin.CardNumber)
                };

                return command.ExecuteNonQuery();
            }
        }

        public int UpdateCheckin(Checkin checkin)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                string sqlQuery = "UPDATE Checkins SET CheckinDate = @CheckinDate, CardNumber = @CardNumber";

                SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
                command.Parameters.AddWithValue("@CheckinDate", checkin.CheckinDate);
                command.Parameters.AddWithValue("@CardNumber", checkin.CardNumber);

                return command.ExecuteNonQuery();
            }
        }

        public int DeleteCheckin(DateTime CheckinDate, int CardNumber)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = string.Format("DELETE FROM Checkins WHERE CheckinDate = {0}, CardNumber = {1}", CheckinDate, CardNumber)
                };

                return command.ExecuteNonQuery();
            }
        }
    }
}
