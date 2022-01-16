using DataLayer;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PresentationDesktop
{
    public partial class ViewData : Form
    {
        private readonly IEmployeeBusiness employeeBusiness;
        private readonly IMembershipBusiness membershipBusiness;
        private int clickCount = 0;

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

        public ViewData()
        {
            employeeBusiness = (IEmployeeBusiness)Program.ServiceProvider.GetService(typeof(IEmployeeBusiness));
            membershipBusiness = (IMembershipBusiness)Program.ServiceProvider.GetService(typeof(IMembershipBusiness));
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void MembershipInfo_Load(object sender, EventArgs e)
        {
            textBoxName.Focus();
            checkBoxActive.Checked = true;
            UpdateDGV("members");
        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            // prati klikove na dugme u cilju ažuriranja podataka
            clickCount++;

            if (clickCount % 2 == 0)
            {
                checkBoxActive.Text = "Show active memberships";
                buttonShow.Text = "Show employees";
                labelTitle.Text = "Membership Database";
                UpdateDGV("members");
            }
            else
            {
                checkBoxActive.Text = "Show active employees";
                buttonShow.Text = "Show members";
                labelTitle.Text = "Employee Database";
                UpdateDGV("employees");
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            // uneto ime i prezime razdvaja na 2 dela za pretraživanje u bazi podataka
            string[] name = textBoxName.Text.Split(' ');

            if (!Regex.Match(textBoxName.Text, "(^$)|^[a-zA-Z]+|[a-zA-Z]+$").Success)
            {
                MessageBox.Show("Name is entered incorrectly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Focus();
                return;
            }

            if (textBoxName.Text == string.Empty && clickCount % 2 == 0)
                UpdateDGV("members");
            else if (textBoxName.Text == string.Empty && clickCount % 2 != 0)
                UpdateDGV("employees");
            else
            {
                try
                {
                    // prati klikove na dugme Show kako bi se prikazali odgovarajući podaci
                    if (clickCount % 2 == 0)
                    {
                        // lista se popunjava objektima tipa Membership kod kojih se ime i prezime poklapaju sa zadatim, ako je lista prazna onda nema poklapanja
                        List<Membership> list = membershipBusiness.SearchMembership(name[0], name[1]);
                        if (list.Count == 0)
                        {
                            MessageBox.Show("The person with that name does not exist in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dataGridView1.DataSource = list;
                            textBoxName.Text = string.Empty;
                        }
                    }
                    else
                    {
                        // lista se popunjava objektima tipa Employee kod kojih se ime i prezime poklapaju sa zadatim, ako je lista prazna onda nema poklapanja
                        List<Employee> list = employeeBusiness.SearchEmployee(name[0], name[1]);
                        if (list.Count == 0)
                        {
                            MessageBox.Show("The person with that name does not exist in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dataGridView1.DataSource = list;
                            textBoxName.Text = string.Empty;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("The field must contain first and last name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CheckBoxActive_CheckedChanged(object sender, EventArgs e)
        {
            // CheckBox prati klikove na dugme Show kako bi se prikazali odgovarajući podaci
            if (clickCount % 2 == 0)
                UpdateDGV("members");
            else
                UpdateDGV("employees");
        }

        private void PictureBoxBack_Click(object sender, EventArgs e)
        {
            Hide();
            Terminal terminal = new Terminal();
            terminal.Show();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // učitava podatke u zavisnosti da li je u pitanju član ili zaposlena osoba
            if (clickCount % 2 == 0)
            {
                Membership membership = new Membership();

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    membership.MembershipID = Convert.ToInt32(row.Cells[0].Value);
                    membership.FirstName = row.Cells[1].Value.ToString();
                    membership.LastName = row.Cells[2].Value.ToString();
                    membership.Address = row.Cells[3].Value.ToString();
                    membership.PhoneNumber = row.Cells[4].Value.ToString();
                    membership.BirthDate = Convert.ToDateTime(row.Cells[5].Value);
                    membership.PaymentDate = Convert.ToDateTime(row.Cells[6].Value);
                    membership.ExpirationDate = Convert.ToDateTime(row.Cells[7].Value);
                    membership.Note = row.Cells[8].Value.ToString();
                }

                Hide();
                EditData editData = new EditData(membership);
                editData.Show();
            }
            else
            {
                Employee employee = new Employee();

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    employee.EmployeeID = Convert.ToInt32(row.Cells[0].Value);
                    employee.PersonalNumber = row.Cells[1].Value.ToString();
                    employee.FirstName = row.Cells[2].Value.ToString();
                    employee.LastName = row.Cells[3].Value.ToString();
                    employee.EmploymentDate = Convert.ToDateTime(row.Cells[4].Value);
                    employee.ContractExpiration = Convert.ToDateTime(row.Cells[5].Value);
                    employee.Address = row.Cells[6].Value.ToString();
                    employee.PhoneNumber = row.Cells[7].Value.ToString();
                    employee.BirthDate = Convert.ToDateTime(row.Cells[8].Value);
                }

                Hide();
                EditData editData = new EditData(employee);
                editData.Show();
            }
        }

        private void UpdateDGV(string mode)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();
                SqlDataAdapter adapter;

                // prati stanje CheckBox kontrole i klikove na dugme Show za prikazivanje odgovarajućih podataka
                if (checkBoxActive.Checked)
                    if (mode == "members")
                        adapter = new SqlDataAdapter("SELECT MembershipID AS 'ID', FirstName AS 'First Name', LastName AS 'Last Name', Address, PhoneNumber AS 'Phone Number', BirthDate as 'Birth Date', PaymentDate AS 'Payment Date', ExpirationDate AS 'Expiration Date', Note FROM Memberships WHERE ExpirationDate > GetDate()", sqlConnection);
                    else
                        adapter = new SqlDataAdapter("SELECT EmployeeID AS 'ID', PersonalNumber AS 'Personal Number', FirstName AS 'First Name', LastName AS 'Last Name', EmploymentDate AS 'Employment Date', ContractExpiration AS 'Contract Expiration', Address, PhoneNumber AS 'Phone Number', BirthDate AS 'Birth Date' FROM Employees WHERE ContractExpiration > GetDate()", sqlConnection);
                else
                    if (mode == "members")
                        adapter = new SqlDataAdapter("SELECT MembershipID AS 'ID', FirstName AS 'First Name', LastName AS 'Last Name', Address, PhoneNumber AS 'Phone Number', BirthDate as 'Birth Date', PaymentDate AS 'Payment Date', ExpirationDate AS 'Expiration Date', Note FROM Memberships", sqlConnection);
                    else
                        adapter = new SqlDataAdapter("SELECT EmployeeID AS 'ID', PersonalNumber AS 'Personal Number', FirstName AS 'First Name', LastName AS 'Last Name', EmploymentDate AS 'Employment Date', ContractExpiration AS 'Contract Expiration', Address, PhoneNumber AS 'Phone Number', BirthDate AS 'Birth Date' FROM Employees", sqlConnection);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
            }
        }
    }
}
