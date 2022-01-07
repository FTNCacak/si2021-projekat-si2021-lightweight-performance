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
        /*private readonly IMembershipBusiness membershipBusiness;

        public NewMember(IMembershipBusiness membershipBusiness)
        {
            this.membershipBusiness = membershipBusiness;
            InitializeComponent();
        }*/
        public NewMember() { InitializeComponent(); }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Shared.Models.Membership member = new Shared.Models.Membership();
            member.FirstName = txtFirstName.Text;
            member.LastName = txtLastName.Text;
            member.Address = txtAddress.Text;
            member.PhoneNumber = txtPhoneNumber.Text;
            member.BirthDate = dtpBirthdate.Value;
            member.PaymentDate = DateTime.Now;
            member.Note = txtNote.Text;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Terminal terminal = new Terminal();
            terminal.ShowDialog();
        }
    }
}
