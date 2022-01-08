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
    public class CheckinRepository : ICheckinRepository
    {
        public List<Checkin> GetAllCheckins()
        {
            List<Checkin> checkinList = new List<Checkin>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
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
                        MembershipID = dataReader.GetInt32(1)
                    };

                    checkinList.Add(checkin);
                }
            }
            return checkinList;
        }

        public int InsertCheckin(Checkin checkin)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = string.Format("INSERT INTO Checkins VALUES ('[0]','[1]')",
                        checkin.CheckinDate, checkin.MembershipID)
                };

                return command.ExecuteNonQuery();
            }
        }

        //izmeniti metodu ako se bude koristila
        public int UpdateCheckin(Checkin checkin)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                string sqlQuery = "UPDATE Checkins SET CheckinDate = @CheckinDate, MembershipID = @MembershipID";

                SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
                command.Parameters.AddWithValue("@CheckinDate", checkin.CheckinDate);
                command.Parameters.AddWithValue("@MembershipID", checkin.MembershipID);

                return command.ExecuteNonQuery();
            }
        }

        public int DeleteCheckin(DateTime CheckinDate, int MembershipID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = string.Format("DELETE FROM Checkins WHERE CheckinDate = {0}, MembershipID = {1}", CheckinDate, MembershipID)
                };

                return command.ExecuteNonQuery();
            }
        }
    }
}
