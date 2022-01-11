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
    public partial class Login : System.Web.UI.Page
    {
        private readonly MembershipBusiness business = new MembershipBusiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            Info.Sid = 0;
            Lbl3Message.Text = "";
        }

        protected void Btn1LogIn_Click(object sender, EventArgs e)
        {
            int Id;
            string pass = tb2Pass.Text;
            List<Membership> memberships = business.GetAllMemberships();
            if (string.Equals("", tb1ID.Text))
            {
                Lbl3Message.Text = "MemberID is Empty!";
                Id = 0;
            }
            else
            {
                Id = Convert.ToInt32(tb1ID.Text);
            }


            foreach(Membership membership in memberships)
            {
                if (membership.MembershipID == Id)
                {
                    if (string.Equals(pass, membership.FirstName + membership.LastName + membership.PhoneNumber))
                    {
                        Lbl3Message.Text = "Good";
                        Info.Sid = membership.MembershipID;
                        Response.Redirect("https://localhost:44363/Info");

                    }
                    else
                    {
                        Lbl3Message.Text = "Wrong password!";
                    }
                }
            }
     



        }
    }
}