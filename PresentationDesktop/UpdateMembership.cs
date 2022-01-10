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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationDesktop
{
    public partial class UpdateMembership : Form
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

        public UpdateMembership()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (membershipBusiness.UpdateMembership(membershipBusiness.GetMembershipByID(Convert.ToInt32(textBoxMemberID.Text)), Convert.ToInt32(textBoxMonths.Text)))
                {
                    if (Convert.ToInt32(textBoxMonths.Text) == 1)
                        MessageBox.Show("Cost for 1 month of membership: 2500", "Success");
                    else
                        MessageBox.Show("Cost for " + textBoxMonths.Text + " months of membership: " + Convert.ToInt32(textBoxMonths.Text) * 2500, "Success");
                }
            }
            catch
            {
                MessageBox.Show("A member with that ID doesn't exist!", "Error");
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
