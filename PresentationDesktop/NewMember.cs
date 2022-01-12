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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
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

                if (txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty || txtAddress.Text == string.Empty || txtPhoneNumber.Text == string.Empty || dtpBirthdate.Value == DateTime.Now)
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            Hide();
            Terminal terminal = new Terminal();
            terminal.Show();
        }

        private void NewMember_Load(object sender, EventArgs e)
        {

        }
    }
}
