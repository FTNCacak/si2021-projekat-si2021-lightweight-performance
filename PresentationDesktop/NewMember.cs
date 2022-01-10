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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PresentationDesktop
{
    public partial class NewMember : Form
    {
<<<<<<< HEAD
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
=======
>>>>>>> ef1168acf8dac0fcc95e77aae77c74740c213f21

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
        public NewMember()
        {
            InitializeComponent();
<<<<<<< HEAD
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
=======
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
>>>>>>> ef1168acf8dac0fcc95e77aae77c74740c213f21
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

        readonly MembershipBusiness membershipBusiness = new MembershipBusiness();

        private void btnConfirm_Click(object sender, EventArgs e)
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

            if(txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty || txtAddress.Text == string.Empty || txtPhoneNumber.Text == string.Empty || dtpBirthdate.Value == DateTime.Now)
            {
                MessageBox.Show("All fields except Note must be filled!");
            }
            else
            {
                if (membershipBusiness.InsertMembership(member))
                {
                    MessageBox.Show("New member added!");
                    txtFirstName.Text = string.Empty;
                    txtLastName.Text = string.Empty;
                    txtAddress.Text = string.Empty;
                    txtPhoneNumber.Text = string.Empty;
                    dtpBirthdate.Value = DateTime.Now;
                    txtNote.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }

<<<<<<< HEAD
        private void pictureBoxBack_Click(object sender, EventArgs e)
=======
        private void NewMember_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
>>>>>>> ef1168acf8dac0fcc95e77aae77c74740c213f21
        {
            Hide();
            Terminal terminal = new Terminal();
            terminal.Show();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
