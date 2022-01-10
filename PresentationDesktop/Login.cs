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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = textBoxUser.Text;
            string password = textBoxPass.Text;

            if(userName == "admin" && password == "12345")
            {
                Hide();
                Terminal terminal = new Terminal();
                terminal.Show();

                lblError.Text = string.Empty;
                textBoxUser.Text = string.Empty;
                textBoxPass.Text = string.Empty;
            }
            else
            {
                lblError.Text = "WRONG LOGIN INFO";
                textBoxUser.Text = string.Empty;
                textBoxPass.Text = string.Empty;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }
    }
}
