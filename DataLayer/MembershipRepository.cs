using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using System.Data.SqlClient;

namespace DataLayer
{
    public class MembershipRepository
    {
        //Dalibor
        private readonly string connString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=GymDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Membership> GetAllMemberships()
        {
            List<Membership> membershipList = new List<Membership>();

            using (SqlConnection sqlConnection = new SqlConnection(connString))
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
                        Note = dataReader.GetString(7)
                    };

                    membershipList.Add(membership);
                }

            }
            return membershipList;
        }

        public int InsertMembership(Membership membership)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = string.Format("INSERT INTO Memberships VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", 
                        membership.FirstName, membership.LastName, membership.Address, membership.PhoneNumber, membership.BirthDate, membership.PaymentDate, membership.Note)
                };

                return command.ExecuteNonQuery();
            }
        }

        //izmeniti metodu ako se bude koristila
        public int UpdateMembership(Membership membership)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                string sqlQuery = "UPDATE Memberships SET FirstName=@FirstName, LastName=@LastName, Address=@Address, PhoneNumber = @PhoneNumber, BirthDate = @BirthDate,PaymentDate = @PaymentDate,Note = @Note WHERE CardNumber=@CardNumber";

                SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
                command.Parameters.AddWithValue("@CardNumber", membership.MembershipID);
                command.Parameters.AddWithValue("@FirstName", membership.FirstName);
                command.Parameters.AddWithValue("@LastName", membership.LastName);
                command.Parameters.AddWithValue("@Address", membership.Address);
                command.Parameters.AddWithValue("@PhoneNumber", membership.PhoneNumber);
                command.Parameters.AddWithValue("@BirthDate", membership.BirthDate);
                command.Parameters.AddWithValue("@PaymentDate", membership.PaymentDate);
                command.Parameters.AddWithValue("@Note", membership.Note);

                return command.ExecuteNonQuery();
            }
        }

        public int DeleteMembership(int MembershipID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = string.Format("DELETE FROM Memberships WHERE MembershipID = {0}", MembershipID)
                };

                return command.ExecuteNonQuery();
            }
        }
    }
}
