using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace DB_Project1
{

    public partial class LoginPage : Form
    {
       // string connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS; Integrated Security=True; Encrypt=false";
        public LoginPage()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string email = text_email.Text;
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

            // Check if the email is empty
            if (string.IsNullOrWhiteSpace(email))
            {
                lblout.Text = "Please enter email.";
                return;
            }

            // Check if the password is empty
            if (string.IsNullOrWhiteSpace(password))
            {
                lblout.Text = "Please enter password.";
                return;
            }

            // connection string
            string cnstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS; Integrated Security=True; Encrypt=false";
            string cnstrinnnn="Data Source = (LocalDB)\\MSSQLLocalDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
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

            // SQL query
            string sqlquery = $"SELECT COUNT(*) FROM {tableName} WHERE Email = @Email AND Password = @Password";


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
                        cm.Parameters.AddWithValue("@Email", email);
                        cm.Parameters.AddWithValue("@Password", password);

                        int count = (int)cm.ExecuteScalar();

                        int count1 = 0;
                        string conn= "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS; Integrated Security=True; Encrypt=false";
                        using (SqlConnection con1 = new SqlConnection(conn))
                        {
                            con1.Open();
                            string sqlquery1 = $"SELECT COUNT(*) FROM {tableName} WHERE Email = @Email AND Password = @Password";
                            using (SqlCommand cm1 = new SqlCommand(sqlquery1, con1))
                            {
                                cm1.Parameters.AddWithValue("@Email", email);
                                cm1.Parameters.AddWithValue("@Password", password);
                                count1 = (int)cm1.ExecuteScalar();
                            }
                        }

                        if (count > 0)
                        {
                            // Credentials are valid, user can be logged in
                            lblout.Text = "Login successful!";

                            if (role == "Customer")
                            {
                                // Get additional details for Customer
                                string customerName = "";
                                string customerEmail = "";
                                string customerPhone = "";

                                // SQL query to retrieve customer details
                                string customerQuery = $"SELECT Name, Email, Phone FROM {tableName} WHERE Email = @Email";

                                using (SqlCommand customerCmd = new SqlCommand(customerQuery, con))
                                {
                                    customerCmd.Parameters.AddWithValue("@Email", email);

                                    using (SqlDataReader reader = customerCmd.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            customerName = reader["Name"].ToString();
                                            customerEmail = reader["Email"].ToString();
                                            customerPhone = reader["Phone"].ToString();
                                        }
                                    }
                                }

                                // Open Customer form with details
                                Customer customerForm = new Customer(customerName, customerEmail, customerPhone);
                                customerForm.Show();
                                this.Hide();
                            }
                            else if (role == "Admin")
                            {
                                // Admin login
                                string adminName = "";
                                string adminPhone = "";

                                // Get admin details
                                string adminQuery = $"SELECT Name, Phone FROM {tableName} WHERE Email = @Email";
                                using (SqlCommand adminCmd = new SqlCommand(adminQuery, con))
                                {
                                    adminCmd.Parameters.AddWithValue("@Email", email);

                                    SqlDataReader reader = adminCmd.ExecuteReader();
                                    if (reader.Read())
                                    {
                                        adminName = reader["Name"].ToString();
                                        adminPhone = reader["Phone"].ToString();
                                    }
                                }

                                // Open Admin form with details
                                AdminForm adminForm = new AdminForm(adminName, email, adminPhone);
                                adminForm.Show();
                                this.Hide();
                            }
                            else if (role == "Employee")
                            {
                                // Employee login
                                string employeeName = "";
                                string employeePhone = "";

                                // Get employee details
                                string employeeQuery = $"SELECT Name, Phone FROM {tableName} WHERE Email = @Email";
                                using (SqlCommand employeeCmd = new SqlCommand(employeeQuery, con))
                                {
                                    employeeCmd.Parameters.AddWithValue("@Email", email);

                                    SqlDataReader reader = employeeCmd.ExecuteReader();
                                    if (reader.Read())
                                    {
                                        employeeName = reader["Name"].ToString();
                                        employeePhone = reader["Phone"].ToString();
                                    }
                                }

                                // Open Employee form with details
                                EmployeeForm employeeForm = new EmployeeForm(employeeName, email, employeePhone);
                                employeeForm.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            // Credentials are invalid, display error message
                            lblout.Text = "Invalid email or password.";
                        }
                        // Execute the query
                        cm.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                lblout.Text = "Error: " + ex.Message;
            }
        }


        private void logup_button_Click(object sender, EventArgs e)
        {
            SignupPage form2 = new SignupPage();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
