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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userName = textBoxUser.Text;
            String password = textBoxPass.Text;
            if(userName == "admin" && password == "12345")
            {
                this.Hide();
                Terminal terminal = new Terminal();
                terminal.ShowDialog();
            }
            else
            {
                lblError.Text = "WRONG LOGIN INFO";
                textBoxUser.Text = String.Empty;
                textBoxPass.Text = String.Empty;
            }
        }
    }
}
