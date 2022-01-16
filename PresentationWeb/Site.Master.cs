using BusinessLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationWeb1
{
    public partial class SiteMaster : MasterPage
    {
        private readonly MembershipBusiness business = new MembershipBusiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Info.Sid != 0)
            {
                Login.InnerText = "Log out"; //Ako je korisnik ulogovan tekst na dugmetu "Log in" se menja u "Log out" 

                List<Membership> memberships = business.GetAllMemberships();
                

                foreach ( Membership membership in memberships)
                {
                    if (membership.MembershipID == Info.Sid)
                    {
                        Title.Text = "Currently logged in as " + membership.FirstName + " " + membership.LastName; //Kada se korisnik uloguje, u footer-u ce se ispisivati njegovo ime
                    }
                }

            }
        }
    }
}