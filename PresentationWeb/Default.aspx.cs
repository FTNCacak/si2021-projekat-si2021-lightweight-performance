using System;
using System.Web.UI;

namespace PresentationWeb
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44363/Info"); // Pri pokretanju web aplikacije, otvara se strana info (ako je korisnik ulogovan)
        }
    }
}