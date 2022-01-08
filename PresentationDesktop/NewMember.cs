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

namespace PresentationDesktop
{
    public partial class NewMember : Form
    {
        readonly MembershipBusiness membershipBusiness = new MembershipBusiness();

        public NewMember()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Shared.Models.Membership member = new Shared.Models.Membership
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                PhoneNumber = txtPhoneNumber.Text,
                BirthDate = dtpBirthdate.Value,
                PaymentDate = DateTime.Now,
                Note = txtNote.Text
            };

            if(txtFirstName.Text == String.Empty || txtLastName.Text == String.Empty || txtAddress.Text == String.Empty || txtPhoneNumber.Text == String.Empty || dtpBirthdate.Value == DateTime.Now)
            {
                MessageBox.Show("All fields except Note must be filled!");
            }
            else
            {
                if (membershipBusiness.InsertMembership(member))
                {
                    MessageBox.Show("New member added!");
                    txtFirstName.Text = String.Empty;
                    txtLastName.Text = String.Empty;
                    txtAddress.Text = String.Empty;
                    txtPhoneNumber.Text = String.Empty;
                    dtpBirthdate.Value = DateTime.Now;
                    txtNote.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            Terminal terminal = new Terminal();
            terminal.Show();
        }
    }
}
