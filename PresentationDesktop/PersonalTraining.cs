using DataLayer;
using BusinessLayer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationDesktop
{
    public partial class PersonalTraining : Form
    {
        private readonly EmployeeBusiness employeeBusiness = new EmployeeBusiness();
        private readonly TrainingBusiness trainingBusiness = new TrainingBusiness();

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

        public PersonalTraining()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void PersonalTraining_Load(object sender, EventArgs e)
        {
            textBoxMemberID.Focus();

            List<Employee> employees = employeeBusiness.GetAllEmployees();
            foreach (Employee employee in employees)
                comboBoxTrainer.Items.Add(employee.FirstName + " " + employee.LastName);

            UpdateDGV();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string[] name = comboBoxTrainer.SelectedItem.ToString().Split(' ');

            Training training = new Training()
            {
                Appointment = dtpTraining.Value,
                MembershipID = Convert.ToInt32(textBoxMemberID.Text),
                EmployeeID = employeeBusiness.GetEmployeeID(name[0], name[1]),
                Type = textBoxPlan.Text,
            };

            if (textBoxMemberID.Text == string.Empty || textBoxPlan.Text == string.Empty || comboBoxTrainer.SelectedIndex == -1 || dtpTraining.Value == DateTime.Now)
            {
                MessageBox.Show("All fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (trainingBusiness.InsertTraining(training))
                {
                    MessageBox.Show("New training added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateDGV();
                    textBoxMemberID.Text = string.Empty;
                    textBoxPlan.Text = string.Empty;
                    comboBoxTrainer.SelectedIndex = -1;
                    dtpTraining.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            Hide();
            Terminal terminal = new Terminal();
            terminal.Show();
        }

        public void UpdateDGV()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Appointment, Memberships.FirstName, Memberships.LastName, Employees.FirstName, Employees.LastName, Type FROM Trainings, Memberships, Employees WHERE Appointment > GetDate() AND Trainings.MembershipID = Memberships.MembershipID AND Trainings.EmployeeID = Employees.EmployeeID ORDER BY Appointment ASC", sqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
            }
        }
    }
}
