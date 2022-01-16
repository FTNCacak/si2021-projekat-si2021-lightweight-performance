using DataLayer;
using BusinessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PresentationWeb
{
    public partial class Info : System.Web.UI.Page
    {
        private readonly MembershipBusiness membershipBusiness = new MembershipBusiness();
        public static int Sid = 0; // Promenljiva koja pamti ID korisnika koji se uspesno ulogovao

        protected void Page_Load(object sender, EventArgs e)
        {
            lbl1Message.Text = "";
            if (Info.Sid == 0)
            {
                Response.Redirect("https://localhost:44363/Login"); // Ako se korisnik nije ulogovao, a pokusao je da pristupi kartici, vratice se na Login stranicu
            }

            List<Membership> memberships = membershipBusiness.GetAllMemberships();

            foreach (Membership membership in memberships)
            {
                if (membership.MembershipID == Sid)
                {
                    lbl1_MembershipID.Text = membership.MembershipID.ToString();
                    lbl2_FirstName.Text = membership.FirstName;
                    lbl3LastName.Text = membership.LastName;
                    lbl4Address.Text = membership.Address;
                    lbl5PhoneNumber.Text = membership.PhoneNumber;
                    lbl6BirthDate.Text = membership.BirthDate.ToString("dd/MM/yyyy");
                    lbl7PaymentDate.Text = membership.PaymentDate.ToString("dd/MM/yyyy");
                    lbl8ExpirationDate.Text = membership.ExpirationDate.ToString("dd/MM/yyyy");
                }
            }

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT CheckinDate FROM Checkins WHERE Checkins.MembershipID = " + Info.Sid + "ORDER BY CheckinDate DESC", sqlConnection);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    lbl1Message.Text = "No recorded check-ins!"; // U slucaju da je DataTable prazan pojavljuje se ova poruka
                }
                else
                {
                    GridViewCHECKIN.DataSource = dt;
                    GridViewCHECKIN.DataBind();
                }
            }
        }
    }
}