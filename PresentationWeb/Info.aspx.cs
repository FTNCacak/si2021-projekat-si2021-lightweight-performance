using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLayer;
using BusinessLayer;
using Shared.Interfaces;
using Shared.Models;
using System.Data.SqlClient;
using System.Data;

namespace PresentationWeb1
{
    public partial class Info : System.Web.UI.Page
    {
        private readonly MembershipBusiness business = new MembershipBusiness();
        public static int Sid = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            lbl1Message.Text = "";
            if (Info.Sid == 0)
            {
                Response.Redirect("https://localhost:44363/Login");
            }
            List<Membership> memberships = business.GetAllMemberships();
            

            foreach (Membership membership in memberships)
            {
                if (membership.MembershipID == Sid)
                {
                    lbl1_MembershipID.Text = membership.MembershipID.ToString();
                    lbl2_FirstName.Text = membership.FirstName;
                    lbl3LastName.Text = membership.LastName;
                    lbl4Address.Text = membership.Address;
                    lbl5PhoneNumber.Text = membership.PhoneNumber;
                    lbl6BirthDate.Text = membership.BirthDate.ToString();
                    lbl7PaymentDate.Text = membership.PaymentDate.ToString();
                    lbl8ExpirationDate.Text = membership.ExpirationDate.ToString();
                    lbl9Note.Text = membership.Note;
                }
            }

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT CheckinDate FROM Checkins WHERE Checkins.MembershipID = " + Info.Sid + "ORDER BY CheckinDate DESC", sqlConnection);


                DataTable dt = new DataTable();

                adapter.Fill(dt);

                if (GridViewCHECKIN.Rows.Count == 0)
                {
                    lbl1Message.Text = "No recorded check-ins!";
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