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


namespace PresentationWeb1
{
    public partial class Info : System.Web.UI.Page
    {
        private readonly MembershipBusiness business = new MembershipBusiness();
        public static int Sid = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
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
        }
    }
}