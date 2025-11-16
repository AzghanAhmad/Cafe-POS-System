using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project1
{
    public partial class SignupPage : Form
    {
        public SignupPage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_register_Click(object sender, EventArgs e)
        {
            string name = text_name.Text;
            string email = text_email.Text;
            string phone = text_phone.Text;
            string password = text_password.Text;
            string role = "";

            // Check if any role option is selected
            if (admin_radio.Checked)
            {
                role = "Admin";
            }
            else if (employee_radio.Checked)
            {
                role = "Employee";
            }
            else if (customer_radio.Checked)
            {
                role = "Customer";
            }

            // Check if role is selected
            if (string.IsNullOrWhiteSpace(role))
            {
                lblout.Text = "Please select your role.";
                return;
            }

            // Check if the name is empty
            if (string.IsNullOrWhiteSpace(name))
            {
                lblout.Text = "Please enter name.";
                return;
            }

            // Check if the email is empty
            if (string.IsNullOrWhiteSpace(email))
            {
                lblout.Text = "Please enter email.";
                return;
            }

            // Check if the phone is empty
            if (string.IsNullOrWhiteSpace(phone))
            {
                lblout.Text = "Please enter phone number.";
                return;
            }

            // Check if the password is empty
            if (string.IsNullOrWhiteSpace(password))
            {
                lblout.Text = "Please enter password.";
                return;
            }

            // Connection string
            string cnstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS; Integrated Security=True; Encrypt=false";

            string tableName = "";
            if (role == "Admin")
            {
                tableName = "Admin";
            }
            else if (role == "Employee")
            {
                tableName = "Employee";
            }
            else if (role == "Customer")
            {
                tableName = "Customer";
            }
                // Your SQL query
                string sqlquery = $"INSERT INTO {tableName} (Name, Email, Phone, Password) VALUES (@name, @email, @phone, @password)";
            try
            {
                // Create a connection
                using (SqlConnection con = new SqlConnection(cnstring))
                {
                    con.Open();

                    // Create a command with the SQL query and the connection
                    using (SqlCommand cm = new SqlCommand(sqlquery, con))
                    {
                        // Add parameters to the command
                        cm.Parameters.AddWithValue("@name", name);
                        cm.Parameters.AddWithValue("@email", email);
                        cm.Parameters.AddWithValue("@phone", phone);
                        cm.Parameters.AddWithValue("@password", password);

                        // Execute the query
                        cm.ExecuteNonQuery();
                    }
                }

                lblout.Text = "Record inserted successfully.";
            }
            catch (Exception ex)
            {
                lblout.Text = "Error: " + ex.Message;
            }


        }

        private void button_back_to_login_Click(object sender, EventArgs e)
        {
            LoginPage form1 = new LoginPage();
            form1.Show();
            this.Hide();
        }
    }
}
