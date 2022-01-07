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
    public partial class Terminal : Form
    {
        public Terminal()
        {
            InitializeComponent();
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewMember newMember = new NewMember();
            newMember.ShowDialog();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            txtUserID.Text = String.Empty;

        }

        private void Terminal_Load(object sender, EventArgs e)
        {

        }

        private void btnPersonalTraining_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonalTraining personalTraining = new PersonalTraining();
            personalTraining.ShowDialog();
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            this.Hide();
            Membership membership = new Membership();
            membership.ShowDialog();
        }

        private void btnMemberInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            MembershipInfo membershipInfo = new MembershipInfo();
            membershipInfo.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
