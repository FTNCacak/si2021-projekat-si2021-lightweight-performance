using Shared.Interfaces;
using Shared.Models;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PresentationDesktop
{
    public partial class EditData : Form
    {
        private readonly IEmployeeBusiness employeeBusiness;
        private readonly IMembershipBusiness membershipBusiness;
        readonly Membership membership;
        readonly Employee employee;
        readonly string mode;

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

        public EditData(Membership membership)
        {
            employeeBusiness = (IEmployeeBusiness)Program.ServiceProvider.GetService(typeof(IEmployeeBusiness));
            membershipBusiness = (IMembershipBusiness)Program.ServiceProvider.GetService(typeof(IMembershipBusiness));
            this.membership = membership;
            mode = "membership";

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        public EditData(Employee employee)
        {
            employeeBusiness = (IEmployeeBusiness)Program.ServiceProvider.GetService(typeof(IEmployeeBusiness));
            membershipBusiness = (IMembershipBusiness)Program.ServiceProvider.GetService(typeof(IMembershipBusiness));
            this.employee = employee;
            mode = "employee";

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void EditData_Load(object sender, EventArgs e)
        {
            txtFirstName.Focus();

            // učitava podatke u zavisnosti da li je u pitanju član ili zaposlena osoba
            if (mode == "membership")
            {
                txtFirstName.Text = membership.FirstName;
                txtLastName.Text = membership.LastName;
                txtAddress.Text = membership.Address;
                txtPhoneNumber.Text = membership.PhoneNumber;
                txtNotePersonalNumber.Text = membership.Note;

                labelNotePersonalNumber.Text = "Note:";
                txtNotePersonalNumber.Multiline = true;
            }
            else
            {
                txtFirstName.Text = employee.FirstName;
                txtLastName.Text = employee.LastName;
                txtAddress.Text = employee.Address;
                txtPhoneNumber.Text = employee.PhoneNumber;
                txtNotePersonalNumber.Text = employee.PersonalNumber;

                labelNotePersonalNumber.Text = "Personal Number:";
                txtNotePersonalNumber.Multiline = false;
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty || txtAddress.Text == string.Empty || txtPhoneNumber.Text == string.Empty)
            {
                if (mode == "membership")
                    MessageBox.Show("All fields except Note must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("All fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtFirstName.Focus();
                return;
            }

            if (!Regex.Match(txtFirstName.Text, @"^[a-zA-Z]+$").Success)
            {
                MessageBox.Show("First name can only contain letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

            if (!Regex.Match(txtLastName.Text, @"^[a-zA-Z]+$").Success)
            {
                MessageBox.Show("Last name can only contain letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return;
            }

            if (!Regex.Match(txtPhoneNumber.Text, @"^(\d{10})?$").Success)
            {
                MessageBox.Show("Phone number must be a 10 digit number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return;
            }

            // učitava podatke u zavisnosti da li je u pitanju član ili zaposlena osoba
            if (mode == "membership")
            {
                membership.FirstName = txtFirstName.Text;
                membership.LastName = txtLastName.Text;
                membership.Address = txtAddress.Text;
                membership.PhoneNumber = txtPhoneNumber.Text;
                membership.Note = txtNotePersonalNumber.Text;

                if (membershipBusiness.UpdateMembershipDetails(membership))
                    MessageBox.Show("Data sucessfully changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Unexpected error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                employee.FirstName = txtFirstName.Text;
                employee.LastName = txtLastName.Text;
                employee.Address = txtAddress.Text;
                employee.PhoneNumber = txtPhoneNumber.Text;
                employee.PersonalNumber = txtNotePersonalNumber.Text;

                if (employeeBusiness.UpdateEmployeeDetails(employee))
                    MessageBox.Show("Data sucessfully changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Unexpected error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PictureBoxBack_Click(object sender, EventArgs e)
        {
            Hide();
            ViewData membershipInfo = new ViewData();
            membershipInfo.Show();
        }
    }
}
