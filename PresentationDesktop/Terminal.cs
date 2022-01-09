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
    public partial class Terminal : Form
    {
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
        public Terminal()
        {            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
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

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            Hide();
            NewMember newMember = new NewMember();
            newMember.Show();
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
            Hide();
            PersonalTraining personalTraining = new PersonalTraining();
            personalTraining.Show();
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            Hide();
            Membership membership = new Membership();
            membership.Show();
        }

        private void btnMemberInfo_Click(object sender, EventArgs e)
        {
            Hide();
            MembershipInfo membershipInfo = new MembershipInfo();
            membershipInfo.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //textBoxUserID
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

        //textBoxFilter
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtFilter_Enter(object sender, EventArgs e)
        {

        }
        private void txtFilter_Leave(object sender, EventArgs e)
        {

        }

        private void WelcomeText_Click(object sender, EventArgs e)
        {

        }
    }
}
