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
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;

namespace DB_Project1.AdminUC
{
    public partial class ManageEmployees : UserControl
    {
        DataTable table = new DataTable("Employees");

        public ManageEmployees()
        {
            InitializeComponent();
            displayEmployeesData();
        }

        private void displayEmployeesData()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS; Integrated Security=True; Encrypt=false";
            string query = "SELECT * FROM Employee";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        table.Clear();
                        adapter.Fill(table);
                        UserDataGrid.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private int rowCount = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Please fill in all employee details.");
                return;
            }

            if (!int.TryParse(textBox5.Text, out int adminID))
            {
                MessageBox.Show("Please enter a valid AdminID.");
                return;
            }
           

            AddEmployee_ftn( textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, adminID, textBox6.Text);
            displayEmployeesData();
            cleartextfields();
        }

        private void AddEmployee_ftn(string name, string email, string phone, string password, int adminID,string position)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS; Integrated Security=True; Encrypt=false";
            string query = "INSERT INTO Employee ( Name, Email, Phone, Password, AdminID,Position) VALUES (@Name, @Email, @Phone, @Password, @AdminID,@position)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@AdminID", adminID);
                        command.Parameters.AddWithValue("@Position", position);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Employee added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add employee.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

       

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageEmployees_Load(object sender, EventArgs e)
        {
            table.Columns.Clear();

            table.Columns.Add("EmployeeID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Phone", typeof(string));
            table.Columns.Add("Password", typeof(string));
            table.Columns.Add("AdminId", typeof(int));
            table.Columns.Add("Position", typeof(string));


            UserDataGrid.DataSource = table;

            displayEmployeesData();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void cleartextfields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
        private void EditEmployee_Click(object sender, EventArgs e)
        {
            if (UserDataGrid.SelectedRows.Count > 0)
            {
                int selectedRowIndex = UserDataGrid.SelectedRows[0].Index;

                int selectedEmployeeID = Convert.ToInt32(UserDataGrid.Rows[selectedRowIndex].Cells["EmployeeID"].Value);

                string name = textBox1.Text;
                string email = textBox2.Text;
                string phone = textBox3.Text;
                string password = textBox4.Text;
                string position = textBox6.Text;


                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    MessageBox.Show("Please fill in all employee details to edit the employee.");
                    return;
                }
                if (!int.TryParse(textBox5.Text, out int adminID))
                {
                    MessageBox.Show("Please enter a valid AdminID.");
                    return;
                }

                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS; Integrated Security=True; Encrypt=false";
                string query = "UPDATE Employee SET Name = @Name, Email = @Email, Phone = @Phone, Password = @Password, AdminID = @AdminID, Position = @Position WHERE EmployeeID = @EmployeeID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Name", name);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@Phone", phone);
                            command.Parameters.AddWithValue("@Password", password);
                            command.Parameters.AddWithValue("@AdminID", adminID);
                            command.Parameters.AddWithValue("@Position", position);
                            command.Parameters.AddWithValue("@EmployeeID", selectedEmployeeID);

                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Employee updated successfully.");
                                displayEmployeesData();
                                cleartextfields();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update employee.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to edit.");
            }
        }




        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            if (UserDataGrid.SelectedRows.Count > 0)
            {
                int selectedRowIndex = UserDataGrid.SelectedRows[0].Index;

                int selectedEmployeeID = Convert.ToInt32(UserDataGrid.Rows[selectedRowIndex].Cells["EmployeeID"].Value);

                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS; Integrated Security=True; Encrypt=false";
                string query = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@EmployeeID", selectedEmployeeID);

                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Employee deleted successfully.");
                                displayEmployeesData();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.");
            }
        }


        private void DeleteAllEmployee_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS; Integrated Security=True; Encrypt=false";
            string query = "DELETE FROM Employee";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("All employees deleted successfully.");
                            displayEmployeesData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void UserDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AssignedRoleButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS; Integrated Security=True; Encrypt=false";
            string query = "select  e.Name as Employeename, a.Name as AdminName from Employee e join Admin a on e.AdminID = a.AdminID";             //2 table join query

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable resultTable = new DataTable();
                        adapter.Fill(resultTable);

                        table.Clear();
                        table.Columns.Clear();
                        table.Columns.Add("EmployeeName", typeof(string));
                        table.Columns.Add("AdminName", typeof(string));

                        foreach (DataRow row in resultTable.Rows)
                        {
                            table.Rows.Add(row["EmployeeName"], row["AdminName"]);
                        }
                        UserDataGrid.DataSource = table;
                        AddEmployee.Enabled = true;
                        EditEmployee.Enabled = true;
                        DeleteEmployee.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        
        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
