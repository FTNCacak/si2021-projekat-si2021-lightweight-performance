using DataLayer;
using BusinessLayer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PresentationDesktop
{
    public partial class NewMember : Form
    {
        private readonly MembershipBusiness membershipBusiness = new MembershipBusiness();

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

        public NewMember()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void NewMember_Load(object sender, EventArgs e)
        {
            txtFirstName.Focus();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty || txtAddress.Text == string.Empty || txtPhoneNumber.Text == string.Empty || dtpBirthdate.Value == DateTime.Now)
            {
                MessageBox.Show("All fields except Note must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

            if (!Regex.Match(txtFirstName.Text, "^[A-Z][a-z]*$").Success)
            {
                MessageBox.Show("First name is entered incorrectly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

            if (!Regex.Match(txtLastName.Text, "^[A-Z][a-z]*$").Success)
            {
                MessageBox.Show("Last name is entered incorrectly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return;
            }

            if (!Regex.Match(txtAddress.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z])+\s[0-9]+$").Success)
            {
                MessageBox.Show("Address is entered incorrectly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }

            if (!Regex.Match(txtPhoneNumber.Text, @"^[0][6]\d{1}/[1-9]\d{2,3}-\d{3,4}$").Success)
            {
                MessageBox.Show("Phone number is entered incorrectly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return;
            }

            try
            {
                Membership member = new Membership
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Address = txtAddress.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    BirthDate = dtpBirthdate.Value,
                    PaymentDate = DateTime.Now,
                    ExpirationDate = DateTime.Now.AddMonths(1),
                    Note = txtNote.Text
                };

                if (membershipBusiness.InsertMembership(member))
                {
                    MessageBox.Show("New member added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFirstName.Text = string.Empty;
                    txtLastName.Text = string.Empty;
                    txtAddress.Text = string.Empty;
                    txtPhoneNumber.Text = string.Empty;
                    dtpBirthdate.Value = DateTime.Now;
                    txtNote.Text = string.Empty;
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

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            Hide();
            Terminal terminal = new Terminal();
            terminal.Show();
        }
    }
}
