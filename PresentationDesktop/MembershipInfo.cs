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
using System.Runtime.InteropServices;

namespace PresentationDesktop
{
    public partial class MembershipInfo : Form
    {
        //Corner manipulation
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
      );
        public MembershipInfo()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        //Drag
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        private int clickCount = 0;


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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
            Terminal terminal = new Terminal();
            terminal.Show();
        }
    }
}
