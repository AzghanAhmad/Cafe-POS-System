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

namespace DB_Project1
{
    public partial class AdminForm : Form
    {
        public AdminForm(string name, string email, string phone)
        {
            InitializeComponent();

            // Set the labels with the provided parameters
            nameLabel.Text = "Name: " + name;
            emailLabel.Text = "Email: " + email;
            phoneLabel.Text = "Phone: " + phone;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear(); 

            ManageEmployees manageEmployees = new ManageEmployees();
            manageEmployees.Dock = DockStyle.Fill;

            panel2.Controls.Add(manageEmployees);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            LoginPage loginForm = new LoginPage();
            this.Close();
            loginForm.Show();
        }

        private void ManageProductsButton_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            ManageProducts manageproducts = new ManageProducts();
            manageproducts.Dock = DockStyle.Fill;
            panel2.Controls.Add(manageproducts);

        }

        private void ManageDiscountsButton_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            ManageDiscounts managediscounts = new ManageDiscounts();
            managediscounts.Dock = DockStyle.Fill;
            panel2.Controls.Add(managediscounts);
        }

        private void guna2Button2_Click(object sender, EventArgs e)   //manage order button
        {
            panel2.Controls.Clear();

            ManageOrders manageorders = new ManageOrders();
            manageorders.Dock = DockStyle.Fill;
            panel2.Controls.Add(manageorders);

        }

        private void ManageSuppliersButton_Click(object sender, EventArgs e)
        {

            panel2.Controls.Clear();

            ManageSuppliers managesuppliers = new ManageSuppliers();
            managesuppliers.Dock = DockStyle.Fill;
            panel2.Controls.Add(managesuppliers);
        }
    }
}
