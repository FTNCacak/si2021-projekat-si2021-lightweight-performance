using System;
using System.Windows.Forms;

namespace PresentationDesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "admin" && textBoxPass.Text == "12345")
            {
                Hide();
                Terminal terminal = new Terminal(textBoxUser.Text);
                terminal.Show();

                lblError.Text = string.Empty;
                textBoxUser.Text = string.Empty;
                textBoxPass.Text = string.Empty;
            }
            else if (textBoxUser.Text == "owner" && textBoxPass.Text == "12345")
            {
                Hide();
                Terminal terminal = new Terminal(textBoxUser.Text);
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

        private void PictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
