using DB_Project1.AdminUC;
using DB_Project1.AllFunction;
using DB_Project1.CustomerUC;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DB_Project1
{
    public partial class Customer : Form
    {

        public Customer(string name, string email, string phone)
        {
            InitializeComponent();

            // Set labels with the provided parameters
            nameLabel.Text = "Name: " + name;
            emailLabel.Text = "Email: " + email;
            phoneLabel.Text = "Phone: " + phone;
        }

        private void InitializePlaceOrder()
        {
            PlaceOrder placeOrder = new PlaceOrder();
            placeOrder.Dock = DockStyle.Fill;
            placeOrder.CheckoutClicked += PlaceOrder_CheckoutClicked;
            panel2.Controls.Add(placeOrder);
        }

        private void PlaceOrder_CheckoutClicked(object sender, EventArgs e)
        {
            // Remove the current user control
            panel2.Controls.Clear();

            // Add the PaymentUC user control
            Payment payment = new Payment();
            payment.Dock = DockStyle.Fill;
            panel2.Controls.Add(payment);
        }




        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void place_order_button_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            PlaceOrder PlaceOrder = new PlaceOrder();
            PlaceOrder.Dock = DockStyle.Fill;

            panel2.Controls.Add(PlaceOrder);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void view_products_btn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ViewProducts ViewProducts = new ViewProducts();
            ViewProducts.Dock = DockStyle.Fill;

            panel2.Controls.Add(ViewProducts);
        }

        public string CustomerName
        {
            get { return nameLabel.Text; }
        }

        private void feedback_btn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Feedback Feedback = new Feedback();
            Feedback.Dock = DockStyle.Fill;

            panel2.Controls.Add(Feedback);
        }

        private void view_discount_Click(object sender, EventArgs e)
        {
            
            panel2.Controls.Clear();
            ViewDiscounts ViewDiscounts = new ViewDiscounts();
            ViewDiscounts.Dock = DockStyle.Fill;

            panel2.Controls.Add(ViewDiscounts);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            LoginPage loginForm = new LoginPage();
            this.Close();
            loginForm.Show();
        }

        private void view_order_btn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ViewOrders ViewOrders = new ViewOrders();
            ViewOrders.Dock = DockStyle.Fill;

            panel2.Controls.Add(ViewOrders);

        }
    }
}
