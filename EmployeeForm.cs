using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DB_Project1.AdminUC;
using DB_Project1.EmployeeUC;

namespace DB_Project1
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm(string name, string email, string phone)
        {
            InitializeComponent();

            // Set the labels with the provided parameters
            nameLabel.Text = "Name: " + name;
            emailLabel.Text = "Email: " + email;
            phoneLabel.Text = "Phone: " + phone;
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            ManageOrder_Emp_ manageorders = new ManageOrder_Emp_();
            manageorders.Dock = DockStyle.Fill;

            panel2.Controls.Add(manageorders);


        }

        private void ManageCustomersButton_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            ManageInventory manageinventory = new ManageInventory();
            manageinventory.Dock = DockStyle.Fill;

            panel2.Controls.Add(manageinventory);
        }

        private void ManageProductsButtoon_Click(object sender, EventArgs e)
        {

            panel2.Controls.Clear();
            Manageproducts_Emp_ manageproducts = new Manageproducts_Emp_();
            manageproducts.Dock = DockStyle.Fill;

            panel2.Controls.Add(manageproducts);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LoginPage loginForm = new LoginPage();
            this.Close();
            loginForm.Show();
        }
    }
}
