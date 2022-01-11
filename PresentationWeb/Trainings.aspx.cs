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
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                if (Info.Sid == 0)
                {
                    Response.Redirect("https://localhost:44363/Login");
                }
                sqlConnection.Open();
                //SqlCommand command = new SqlCommand("SELECT Appointment, Memberships.FirstName, Memberships.LastName, Employees.FirstName, Employees.LastName, Type FROM Trainings, Memberships, Employees WHERE Trainings.MembershipID =@id Trainings.MembershipID = Memberships.MembershipID AND Trainings.EmployeeID = Employees.EmployeeID ORDER BY Appointment ASC", sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Appointment, Memberships.FirstName, Memberships.LastName, Employees.FirstName, Employees.LastName, Type FROM Trainings, Memberships, Employees WHERE Trainings.MembershipID = " + Info.Sid + " AND Trainings.MembershipID = Memberships.MembershipID AND Trainings.EmployeeID = Employees.EmployeeID ORDER BY Appointment ASC", sqlConnection);

                //command.Parameters.AddWithValue("@id",Info.Sid);

                DataTable dt = new DataTable();
                
                adapter.Fill(dt);
                //SqlDataAdapter adapter=command.

                GridViewTRAINING.DataSource = dt;
                GridViewTRAINING.DataBind();

                //GridViewTRAINING.
            }

        }
    }
}