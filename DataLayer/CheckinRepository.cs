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
        private string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GymDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<Checkin> GetAllCheckins()
        {
            List<Checkin> checkinList = new List<Checkin>();
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT * FROM Checkins";

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Checkin checkin = new Checkin();
                    checkin.CheckinDate = dataReader.GetDateTime(0);
                    checkin.CardNumber = dataReader.GetInt32(1);
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
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO Checkins VALUES ('[0]','[1]')",
                    checkin.CheckinDate, checkin.CardNumber);
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

                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;
                command.CommandText = string.Format("DELETE FROM Checkins WHERE CheckinDate = {0}, CardNumber = {1}", CheckinDate, CardNumber);

                return command.ExecuteNonQuery();
            }
        }
    }
}
