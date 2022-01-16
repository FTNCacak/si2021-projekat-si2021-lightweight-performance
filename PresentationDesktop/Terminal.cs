using DataLayer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PresentationDesktop
{
    public partial class Terminal : Form
    {
        private readonly ICheckinBusiness checkinBusiness;
        private readonly IMembershipBusiness membershipBusiness;
        private readonly string user = "owner"; // inicijalizovano u slučaju da programer želi da preskoči Login formu

        // zaobljavanje ivica prozora
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

        // omogućava pomeranje prozora aplikacije
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
            checkinBusiness = (ICheckinBusiness)Program.ServiceProvider.GetService(typeof(ICheckinBusiness));
            membershipBusiness = (IMembershipBusiness)Program.ServiceProvider.GetService(typeof(IMembershipBusiness));
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        public Terminal(string user)
        {
            checkinBusiness = (ICheckinBusiness)Program.ServiceProvider.GetService(typeof(ICheckinBusiness));
            membershipBusiness = (IMembershipBusiness)Program.ServiceProvider.GetService(typeof(IMembershipBusiness));
            this.user = user;
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void Terminal_Load(object sender, EventArgs e)
        {
            // Admin korisnici ne treba da vide New Employee dugme
            if (user == "owner")
            {
                btnNewEmployee.Visible = true;
                pictureBoxNewEmployee.Visible = true;
                labelUser.Text += "Owner";
            }
            else
            {
                btnNewEmployee.Visible = false;
                pictureBoxNewEmployee.Visible = false;
                labelUser.Text += "Admin";
            }

            UpdateDGV();
        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                bool match = false;

                Checkin checkin = new Checkin
                {
                    MembershipID = Convert.ToInt32(txtUserID.Text),
                    CheckinDate = DateTime.Now
                };

                List<Membership> list = membershipBusiness.GetAllMemberships();

                // proverava da li se uneseni ID poklapa sa nekim iz baze podataka
                foreach (Membership membership in list)
                    if (membership.MembershipID == Convert.ToInt32(txtUserID.Text))
                        match = true;

                if (!match)
                {
                    MessageBox.Show("A member with that ID doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserID.Text = string.Empty;
                    UpdateDGV();
                    return;
                }

                if (checkinBusiness.InsertCheckin(checkin))
                {
                    txtUserID.Text = string.Empty;
                    UpdateDGV();
                }
                else
                {
                    MessageBox.Show("Unexpected error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNewMember_Click(object sender, EventArgs e)
        {
            Hide();
            NewMember newMember = new NewMember();
            newMember.Show();
        }

        private void BtnNewEmployee_Click(object sender, EventArgs e)
        {
            Hide();
            NewEmployee newEmployee = new NewEmployee();
            newEmployee.Show();
        }

        private void BtnMembership_Click(object sender, EventArgs e)
        {
            Hide();
            UpdateMembership updateMembership = new UpdateMembership();
            updateMembership.Show();
        }

        private void BtnPersonalTraining_Click(object sender, EventArgs e)
        {
            Hide();
            PersonalTraining personalTraining = new PersonalTraining();
            personalTraining.Show();
        }

        private void BtnMemberInfo_Click(object sender, EventArgs e)
        {
            Hide();
            ViewData membershipInfo = new ViewData();
            membershipInfo.Show();
        }

        private void PictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtUserID_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter taster kao prečica za brži unos
            if (e.KeyCode == Keys.Enter)
                btnCheckIn.PerformClick();
        }

        private void UpdateDGV()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT CheckinDate AS 'Check-in Time', Checkins.MembershipID, CONCAT(FirstName, ' ', LastName) AS 'Name', ExpirationDate FROM Checkins, Memberships WHERE Checkins.MembershipID = Memberships.MembershipID ORDER BY CheckinDate DESC", sqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns["Check-in Time"].DisplayIndex = 0;
                dataGridView1.Columns["Check-in Time"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["Check-in Time"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
                dataGridView1.Columns["MembershipID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["MembershipID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns["Name"].DisplayIndex = 3;
                dataGridView1.Columns["CheckinDate"].Visible = false;
                dataGridView1.Columns["FirstName"].Visible = false;
                dataGridView1.Columns["LastName"].Visible = false;
            }
        }
    }
}
