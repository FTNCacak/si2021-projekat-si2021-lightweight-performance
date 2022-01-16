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
            Info.Sid = 0; //Brisanje ID-a predhodno ulogovanog korisnika
            Lbl3Message.Text = "";//Resetovanje labele u kojoj se pojavljuju poruke
        }

        protected void Btn1LogIn_Click(object sender, EventArgs e)
        {
            int Id=0;
            string pass = tb2Pass.Text;
            List<Membership> memberships = business.GetAllMemberships();

            try
            {

                if (string.Equals("", tb1ID.Text))
                {
                    Lbl3Message.Text = "MemberID is Empty!";
                    if (string.Equals("", tb2Pass.Text))
                    {
                        Lbl3Message.Text = "MemberID and Password are Empty!";
                    }
                    return;
                }
                else if (memberships.FindIndex(m => m.MembershipID == Convert.ToInt32(tb1ID.Text)) == -1) //Provera da li je uneti indeks postojeci
                {

                        Lbl3Message.Text = "Member with this ID doesn't exist!";
                        return;
                }
                else
                {
                    Id = Convert.ToInt32(tb1ID.Text);
                }


            }
            catch
            {
                Lbl3Message.Text = "Membership ID cannot contain letters!";
            }

            foreach (Membership membership in memberships)
            {
                if (membership.MembershipID == Id)
                {
                    if (string.Equals(pass, membership.FirstName + membership.LastName + membership.PhoneNumber))//Sifra je izgenerisana kombinovanjem Imena, Prezimena i broja telefona
                    {
                        Lbl3Message.Text = "Good";
                        Info.Sid = membership.MembershipID; //Pamcenje ID-a korisnika koji je uneo tacnu sifru
                        Response.Redirect("https://localhost:44363/Info");

                    }
                    else
                    {
                        if (string.Equals("", tb2Pass.Text))
                        {
                            Lbl3Message.Text = "Password is Empty!";
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
}