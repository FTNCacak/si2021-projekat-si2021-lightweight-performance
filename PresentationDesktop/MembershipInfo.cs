using DataLayer;
using BusinessLayer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationDesktop
{
    public partial class MembershipInfo : Form
    {
        private int clickCount = 0;

        public MembershipInfo()
        {
            InitializeComponent();
        }

        private void MembershipInfo_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Memberships", sqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            clickCount++;

            if(clickCount % 2 == 0)
            {
                buttonShow.Text = "Show employees";
                using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
                {
                    sqlConnection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Memberships", sqlConnection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            else
            {
                buttonShow.Text = "Show members";
                using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
                {
                    sqlConnection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Employees", sqlConnection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Hide();
            Terminal terminal = new Terminal();
            terminal.Show();
        }
    }
}
