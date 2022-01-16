using DataLayer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PresentationDesktop
{
    public partial class PersonalTraining : Form
    {
        private readonly IEmployeeBusiness employeeBusiness;
        private readonly ITrainingBusiness trainingBusiness;

        // zaobljavanje ivica prozora
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

        // omogućava pomeranje prozora aplikacije
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
            employeeBusiness = (IEmployeeBusiness)Program.ServiceProvider.GetService(typeof(IEmployeeBusiness));
            trainingBusiness = (ITrainingBusiness)Program.ServiceProvider.GetService(typeof(ITrainingBusiness));
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void PersonalTraining_Load(object sender, EventArgs e)
        {
            textBoxMemberID.Focus();

            // dodaje zaposlene kao izbor trenera u ComboBox kontrolu
            List<Employee> employees = employeeBusiness.GetAllEmployees();
            foreach (Employee employee in employees)
                comboBoxTrainer.Items.Add(employee.FirstName + " " + employee.LastName);

            UpdateDGV();
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            // uneto ime i prezime razdvaja na 2 dela za pretraživanje u bazi podataka
            string[] name = comboBoxTrainer.SelectedItem.ToString().Split(' ');

            if (textBoxMemberID.Text == string.Empty || textBoxPlan.Text == string.Empty || comboBoxTrainer.SelectedIndex == -1 || dtpTraining.Value == DateTime.Now)
            {
                MessageBox.Show("All fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Training training = new Training()
                {
                    Appointment = dtpTraining.Value,
                    MembershipID = Convert.ToInt32(textBoxMemberID.Text),
                    EmployeeID = employeeBusiness.GetEmployeeID(name[0], name[1]),
                    Type = textBoxPlan.Text,
                };

                if (trainingBusiness.InsertTraining(training))
                {
                    MessageBox.Show("New training added!\nCost: 500 din", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateDGV();
                    textBoxMemberID.Text = string.Empty;
                    textBoxPlan.Text = string.Empty;
                    comboBoxTrainer.SelectedIndex = -1;
                    dtpTraining.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Unexpected error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PictureBoxBack_Click(object sender, EventArgs e)
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

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Appointment, CONCAT(Memberships.FirstName, ' ', Memberships.LastName) AS 'Member Name', CONCAT(Employees.FirstName, ' ', Employees.LastName) AS 'Trainer Name', Type FROM Trainings, Memberships, Employees WHERE Appointment > GetDate() AND Trainings.MembershipID = Memberships.MembershipID AND Trainings.EmployeeID = Employees.EmployeeID ORDER BY Appointment ASC", sqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}
