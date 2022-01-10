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
        private readonly MembershipBusiness membershipBusiness = new MembershipBusiness();
        private int clickCount = 0;

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

        public MembershipInfo()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void MembershipInfo_Load(object sender, EventArgs e)
        {
            UpdateDGV("members");
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            clickCount++;

            if (clickCount % 2 == 0)
            {
                buttonShow.Text = "Show employees";
                UpdateDGV("members");
            }
            else
            {
                buttonShow.Text = "Show members";
                UpdateDGV("employees");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text;
                string[] firstLastName = name.Split(' ');
                List<Membership> list = membershipBusiness.SearchMembership(firstLastName[0], firstLastName[1]);
                dataGridView1.DataSource = list;
            }
            catch
            {
                MessageBox.Show("The field must containt first and last name!", "Error");
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            Hide();
            Terminal terminal = new Terminal();
            terminal.Show();
        }

        private void UpdateDGV(string mode)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();
                SqlDataAdapter adapter;

                if (mode == "members")
                    adapter = new SqlDataAdapter("SELECT * FROM Memberships", sqlConnection);
                else
                    adapter = new SqlDataAdapter("SELECT * FROM Employees", sqlConnection);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
    }
}
