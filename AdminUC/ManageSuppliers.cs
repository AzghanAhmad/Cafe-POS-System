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

namespace DB_Project1.AdminUC
{
    public partial class ManageSuppliers : UserControl
    {
        DataTable table = new DataTable("Suppliers");

        public ManageSuppliers()
        {
            InitializeComponent();
            DisplaySuppliersData();
        }

        private void DisplaySuppliersData()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "SELECT * FROM Supplier";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        table.Clear();
                        adapter.Fill(table);
                        SuppliersDataGrid.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void AddESupplier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please fill in all supplier details.");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int supplierID))
            {
                MessageBox.Show("Please enter a valid Supplier ID.");
                return;
            }

            AddSupplierFtn(supplierID, textBox2.Text, textBox3.Text, textBox4.Text);
            DisplaySuppliersData();
            ClearTextFields();
        }

        private void AddSupplierFtn(int supplierID, string name, string phone, string email)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "INSERT INTO Supplier (SupplierID, Name, Phone, Email) VALUES (@SupplierID, @Name, @Phone, @Email)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SupplierID", supplierID);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Email", email);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Supplier added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add supplier.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EditSupplier_Click(object sender, EventArgs e)
        {
            if (SuppliersDataGrid.SelectedRows.Count > 0)
            {
                int selectedRowIndex = SuppliersDataGrid.SelectedRows[0].Index;

                int selectedSupplierID = Convert.ToInt32(SuppliersDataGrid.Rows[selectedRowIndex].Cells["SupplierID"].Value);

                string name = textBox2.Text;
                string phone = textBox3.Text;
                string email = textBox4.Text;

                if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Please fill in all supplier details to edit the supplier.");
                    return;
                }

                if (!int.TryParse(textBox1.Text, out int supplierID))
                {
                    MessageBox.Show("Please enter a valid Supplier ID.");
                    return;
                }

                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
                string query = "UPDATE Supplier SET Name = @Name, Phone = @Phone, Email = @Email WHERE SupplierID = @SupplierID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Name", name);
                            command.Parameters.AddWithValue("@Phone", phone);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@SupplierID", supplierID);

                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Supplier updated successfully.");
                                DisplaySuppliersData();
                                ClearTextFields();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update supplier.");
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
                MessageBox.Show("Please select a supplier to edit.");
            }
        }

        private void DeleteSupplier_Click(object sender, EventArgs e)
        {
            if (SuppliersDataGrid.SelectedRows.Count > 0)
            {
                int selectedRowIndex = SuppliersDataGrid.SelectedRows[0].Index;

                int selectedSupplierID = Convert.ToInt32(SuppliersDataGrid.Rows[selectedRowIndex].Cells["SupplierID"].Value);

                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
                string query = "DELETE FROM Supplier WHERE SupplierID = @SupplierID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@SupplierID", selectedSupplierID);

                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Supplier deleted successfully.");
                                DisplaySuppliersData();
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
                MessageBox.Show("Please select a supplier to delete.");
            }
        }

        private void DeleteAllSupplier_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "DELETE FROM Supplier";

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
                            MessageBox.Show("All suppliers deleted successfully.");
                            DisplaySuppliersData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void ProductsSupplied_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "select p.Name as ProductName,s.Name as SupplierName from Supplier s join Product p on s.SupplierID = p.SupplierID";

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
                        table.Columns.Add("SupplierName", typeof(string));
                        table.Columns.Add("ProductName", typeof(string));

                        foreach (DataRow row in resultTable.Rows)
                        {
                            table.Rows.Add(row["SupplierName"], row["ProductName"]);
                        }
                        SuppliersDataGrid.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearTextFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button_loyalSuppliers_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = @"select S.Name As SupplierName, COUNT(*) AS TotalProductsInStock from Product P join Supplier S on P.SupplierID = S.SupplierID where P.StockQuantity > 5 group by S.Name having COUNT(*) > 3; ";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable orderTable = new DataTable();
                        adapter.Fill(orderTable);
                        SuppliersDataGrid.DataSource = orderTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button_activesuppliers_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = @"select * from ActiveSuppliers";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable orderTable = new DataTable();
                        adapter.Fill(orderTable);
                        SuppliersDataGrid.DataSource = orderTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
