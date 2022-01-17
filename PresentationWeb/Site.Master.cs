using DataLayer;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace PresentationWeb
{
    public partial class SiteMaster : MasterPage
    {
        private readonly MembershipRepository membershipRepository = new MembershipRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Info.Sid != 0)
            {
                Login.InnerText = "Log out"; // Ako je korisnik ulogovan tekst na dugmetu "Log in" se menja u "Log out" 

                List<Membership> memberships = membershipRepository.GetAllMemberships();

                foreach (Membership membership in memberships)
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