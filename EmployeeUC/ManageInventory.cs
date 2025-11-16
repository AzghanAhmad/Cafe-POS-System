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

namespace DB_Project1.EmployeeUC
{
    public partial class ManageInventory : UserControl
    {
        DataTable inventoryTable = new DataTable("Inventory");
        DataTable productsTable = new DataTable("Products");

        public ManageInventory()
        {
            InitializeComponent();
            DisplayInventoryData();
            DisplayProductsData();
        }

        private void DisplayInventoryData()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "select * from Inventory";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        inventoryTable.Clear();
                        adapter.Fill(inventoryTable);
                        InventoryDataGrid.DataSource = inventoryTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DisplayProductsData()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "SELECT * FROM Product";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        productsTable.Clear();
                        adapter.Fill(productsTable);
                        ProductsDataGrid.DataSource = productsTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddInventory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                MessageBox.Show("Please fill in all inventory details.");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int inventoryID))
            {
                MessageBox.Show("Please enter a valid Inventory ID.");
                return;
            }

            if (!int.TryParse(textBox2.Text, out int productID))
            {
                MessageBox.Show("Please enter a valid Product ID.");
                return;
            }

            if (!int.TryParse(textBox3.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid Quantity.");
                return;
            }

            AddInventoryFtn(inventoryID, productID, quantity, dateTimePicker1.Value);
            DisplayInventoryData();
            ClearTextFields();
        }

        private void AddInventoryFtn(int inventoryID, int productID, int quantity, DateTime dateReceived)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "INSERT INTO Inventory (InventoryID, ProductID, Quantity, DateReceived) VALUES (@InventoryID, @ProductID, @Quantity, @DateReceived)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InventoryID", inventoryID);
                        command.Parameters.AddWithValue("@ProductID", productID);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@DateReceived", dateReceived);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Inventory added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add inventory.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EditInventory_Click(object sender, EventArgs e)
        {
            if (InventoryDataGrid.SelectedRows.Count > 0)
            {
                int selectedRowIndex = InventoryDataGrid.SelectedRows[0].Index;

                int selectedInventoryID = Convert.ToInt32(InventoryDataGrid.Rows[selectedRowIndex].Cells["InventoryID"].Value);

                if (!int.TryParse(textBox1.Text, out int inventoryID))
                {
                    MessageBox.Show("Please enter a valid Inventory ID.");
                    return;
                }

                if (!int.TryParse(textBox2.Text, out int productID))
                {
                    MessageBox.Show("Please enter a valid Product ID.");
                    return;
                }

                if (!int.TryParse(textBox3.Text, out int quantity))
                {
                    MessageBox.Show("Please enter a valid Quantity.");
                    return;
                }

                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
                string query = "UPDATE Inventory SET ProductID = @ProductID, Quantity = @Quantity, DateReceived = @DateReceived WHERE InventoryID = @InventoryID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ProductID", productID);
                            command.Parameters.AddWithValue("@Quantity", quantity);
                            command.Parameters.AddWithValue("@DateReceived", dateTimePicker1.Value);
                            command.Parameters.AddWithValue("@InventoryID", inventoryID);

                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Inventory updated successfully.");
                                DisplayInventoryData();
                                ClearTextFields();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update inventory.");
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
                MessageBox.Show("Please select an inventory item to edit.");
            }
        }

        private void DeleteInventory_Click(object sender, EventArgs e)
        {
            if (InventoryDataGrid.SelectedRows.Count > 0)
            {
                int selectedRowIndex = InventoryDataGrid.SelectedRows[0].Index;

                int selectedInventoryID = Convert.ToInt32(InventoryDataGrid.Rows[selectedRowIndex].Cells["InventoryID"].Value);

                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
                string query = "DELETE FROM Inventory WHERE InventoryID = @InventoryID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@InventoryID", selectedInventoryID);

                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Inventory item deleted successfully.");
                                DisplayInventoryData();
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
                MessageBox.Show("Please select an inventory item to delete.");
            }
        }

        private void DeleteAllInventory_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "DELETE FROM Inventory";

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
                            MessageBox.Show("All inventory items deleted successfully.");
                            DisplayInventoryData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void StockLessThan10_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "select Name As Products_With_Less_Than_10_Quantity_In_Stock from Product where ProductID IN ( select ProductID from Inventory where Quantity < 10);";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable resultTable = new DataTable();
                        adapter.Fill(resultTable);
                        inventoryTable.Clear();
                        inventoryTable.Columns.Clear();
                        inventoryTable.Columns.Add("Products_With_Less_Than_10_Quantity_In_Stock", typeof(string));
                        foreach (DataRow row in resultTable.Rows)
                        {
                            inventoryTable.Rows.Add(row["Products_With_Less_Than_10_Quantity_In_Stock"]);
                        }
                        InventoryDataGrid.DataSource = inventoryTable;
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
            dateTimePicker1.Value = DateTime.Now;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void InventoryAllDetails_Button_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "select i.InventoryID, p.Name as ProductName, i.Quantity, s.Name As SupplierName from Inventory i join Product p on i.ProductID = p.ProductID join Supplier s on p.SupplierID = s.SupplierID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        inventoryTable.Clear();
                        adapter.Fill(inventoryTable);
                        InventoryDataGrid.DataSource = inventoryTable;
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
