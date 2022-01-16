using Shared.Interfaces;
using Shared.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataLayer
{
    public class MembershipRepository : IMembershipRepository
    {
        public List<Membership> GetAllMemberships()
        {
            List<Membership> membershipList = new List<Membership>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = "SELECT * FROM Memberships"
                };

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Membership membership = new Membership
                    {
                        MembershipID = dataReader.GetInt32(0),
                        FirstName = dataReader.GetString(1),
                        LastName = dataReader.GetString(2),
                        Address = dataReader.GetString(3),
                        PhoneNumber = dataReader.GetString(4),
                        BirthDate = dataReader.GetDateTime(5),
                        PaymentDate = dataReader.GetDateTime(6),
                        ExpirationDate = dataReader.GetDateTime(7)
                    };

                    if (dataReader.IsDBNull(8))
                        membership.Note = string.Empty;
                    else
                        membership.Note = dataReader.GetString(8);

                    membershipList.Add(membership);
                }
            }
            return membershipList;
        }

        public int InsertMembership(Membership membership)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Memberships VALUES(@FirstName, @LastName, @Address, @PhoneNumber, @BirthDate, @PaymentDate, @ExpirationDate, @Note)", sqlConnection);

                command.Parameters.AddWithValue("@FirstName", membership.FirstName);
                command.Parameters.AddWithValue("@LastName", membership.LastName);
                command.Parameters.AddWithValue("@Address", membership.Address);
                command.Parameters.AddWithValue("@PhoneNumber", membership.PhoneNumber);
                command.Parameters.AddWithValue("@Birthdate", membership.BirthDate);
                command.Parameters.AddWithValue("@PaymentDate", membership.PaymentDate);
                command.Parameters.AddWithValue("@ExpirationDate", membership.ExpirationDate);
                command.Parameters.AddWithValue("@Note", membership.Note);

                return command.ExecuteNonQuery();
            }
        }

        public int UpdateMembership(Membership membership, int number)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                string sqlQuery = "UPDATE Memberships SET ExpirationDate = CASE WHEN ExpirationDate < GetDate() THEN DateAdd(month, @number, GetDate()) ELSE DateAdd(month, @number, @ExpirationDate) END WHERE MembershipID = @MembershipID";

                SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
                command.Parameters.AddWithValue("@ExpirationDate", membership.ExpirationDate);
                command.Parameters.AddWithValue("@MembershipID", membership.MembershipID);
                command.Parameters.AddWithValue("@number", number);

                return command.ExecuteNonQuery();
            }
        }

        public int UpdateMembershipDetails(Membership membership)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                string sqlQuery = "UPDATE Memberships SET FirstName = @FirstName, LastName = @LastName, Address = @Address, PhoneNumber = @PhoneNumber, Note = @Note WHERE MembershipID = @MembershipID";

                SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
                command.Parameters.AddWithValue("@MembershipID", membership.MembershipID);
                command.Parameters.AddWithValue("@FirstName", membership.FirstName);
                command.Parameters.AddWithValue("@LastName", membership.LastName);
                command.Parameters.AddWithValue("@Address", membership.Address);
                command.Parameters.AddWithValue("@PhoneNumber", membership.PhoneNumber);
                command.Parameters.AddWithValue("@Note", membership.Note);

                return command.ExecuteNonQuery();
            }
        }
    }
}
