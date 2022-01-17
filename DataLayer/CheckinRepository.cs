using Shared.Interfaces;
using Shared.Models;
using System.Data.SqlClient;

namespace DataLayer
{
    public class CheckinRepository : ICheckinRepository
    {
        public int InsertCheckin(Checkin checkin)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Checkins VALUES(@CheckinDate, @MembershipID)", sqlConnection);

                command.Parameters.AddWithValue("@CheckinDate", checkin.CheckinDate);
                command.Parameters.AddWithValue("@MembershipID", checkin.MembershipID);

                return command.ExecuteNonQuery();
            }
        }
    }
}
