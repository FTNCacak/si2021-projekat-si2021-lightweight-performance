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
    public partial class Terminal : Form
    {
        private readonly CheckinBusiness checkinBusiness = new CheckinBusiness();

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

        public Terminal()
        {            
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void Terminal_Load(object sender, EventArgs e)
        {
            UpdateDGV();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string userID = txtUserID.Text;

            Checkin checkin = new Checkin
            {
                MembershipID = Convert.ToInt32(userID),
                CheckinDate = DateTime.Now
            };

            if (txtUserID.Text == string.Empty)
                MessageBox.Show("INVALID DATA");
            else
            {
                if (checkinBusiness.InsertCheckin(checkin))
                {
                    txtUserID.Text = string.Empty;
                    UpdateDGV();
                }
                else
                {
                    MessageBox.Show("INVALID DATA");
                }
            }
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            Hide();
            NewMember newMember = new NewMember();
            newMember.Show();
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            Hide();
            UpdateMembership membership = new UpdateMembership();
            membership.Show();
        }

        private void btnPersonalTraining_Click(object sender, EventArgs e)
        {
            Hide();
            PersonalTraining personalTraining = new PersonalTraining();
            personalTraining.Show();
        }

        private void btnMemberInfo_Click(object sender, EventArgs e)
        {
            Hide();
            MembershipInfo membershipInfo = new MembershipInfo();
            membershipInfo.Show();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateDGV()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT CheckinDate, FirstName, LastName, ExpirationDate FROM Checkins, Memberships WHERE Checkins.MembershipID = Memberships.MembershipID ORDER BY CheckinDate DESC", sqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void txtUserID_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "Enter user ID here")
            {
                txtUserID.Text = "";
                txtUserID.ForeColor = Color.Black;
            }
        }
        private void txtUserID_Leave(object sender, EventArgs e)
        {
            if (txtUserID.Text == "")
            {
                txtUserID.Text = "Enter user ID here";
                txtUserID.ForeColor = Color.Silver;
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT CheckinDate, FirstName, LastName, ExpirationDate FROM Checkins, Memberships WHERE Appointment = " + dateTimePicker1.Value + " AND Checkins.MembershipID = Memberships.MembershipID ORDER BY CheckinDate DESC", sqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
    }
}
