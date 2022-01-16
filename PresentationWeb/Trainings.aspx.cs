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
    public partial class Trainings : System.Web.UI.Page
    {
        private readonly MembershipBusiness business = new MembershipBusiness();
        private readonly EmployeeBusiness employee = new EmployeeBusiness();
        private readonly TrainingBusiness training = new TrainingBusiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl1Message.Text = "";
            if (Info.Sid == 0)
            {
                Response.Redirect("https://localhost:44363/Login");//Ako se korisnik nije ulogovao, a pokusao je da pristupi kartici, vratice se na Login stranicu
            }
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Appointment, CONCAT( Memberships.FirstName,' ', Memberships.LastName) AS 'MemberName', CONCAT( Employees.FirstName,' ', Employees.LastName) AS 'EmployeeName', Type FROM Trainings, Memberships, Employees WHERE Trainings.MembershipID = " + Info.Sid + " AND Trainings.MembershipID = Memberships.MembershipID AND Trainings.EmployeeID = Employees.EmployeeID ORDER BY Appointment ASC", sqlConnection);

                DataTable dt = new DataTable();
                
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    lbl1Message.Text = "No scheduled trainings!";//U slucaju da je DataTable prazan pojavljuje se ova poruka
                }
                else
                {
                    GridViewTRAINING.DataSource = dt;
                    GridViewTRAINING.DataBind();
                }
            }

        }
    }
}