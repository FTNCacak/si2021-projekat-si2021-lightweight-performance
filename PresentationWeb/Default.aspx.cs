using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationWeb1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44363/Info");//Pri pokretanju web aplikacije, otvara se strana info (ako je korisnik ulogovan)
        }
    }
}