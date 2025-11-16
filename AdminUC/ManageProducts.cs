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
    public partial class ManageProducts : UserControl
    {
        DataTable table = new DataTable("Products");
        public ManageProducts()
        {
            InitializeComponent();
            displayProductsData();
        }
        private void displayProductsData()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "SELECT * FROM Product";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        table.Clear();
                        adapter.Fill(table);
                        UserDataGrid_ProductDetails.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void AddProductButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text) || string.IsNullOrWhiteSpace(textBox8.Text))
            {
                MessageBox.Show("Please fill in all product details.");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int productId))
            {
                MessageBox.Show("Please enter a valid Product ID.");
                return;
            }

            if (!decimal.TryParse(textBox4.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid Price.");
                return;
            }

            if (!int.TryParse(textBox5.Text, out int categoryId))
            {
                MessageBox.Show("Please enter a valid Category ID.");
                return;
            }

            if (!int.TryParse(textBox6.Text, out int supplierId))
            {
                MessageBox.Show("Please enter a valid Supplier ID.");
                return;
            }

            if (!int.TryParse(textBox7.Text, out int adminId))
            {
                MessageBox.Show("Please enter a valid Admin ID.");
                return;
            }

            if (!int.TryParse(textBox8.Text, out int stockQuantity))
            {
                MessageBox.Show("Please enter a valid Stock Quantity.");
                return;
            }

            AddProduct(productId, textBox2.Text, textBox3.Text, price, categoryId, supplierId, adminId, stockQuantity);
            displayProductsData();
            cleartextfields();
        }

        private void AddProduct(int productId, string name, string description, decimal price, int categoryId, int supplierId, int adminId, int stockQuantity)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "INSERT INTO Product (ProductID, Name, Description, Price, CategoryID, SupplierID, AdminID, StockQuantity) VALUES (@ProductID, @Name, @Description, @Price, @CategoryID, @SupplierID, @AdminID, @StockQuantity)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productId);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@CategoryID", categoryId);
                        command.Parameters.AddWithValue("@SupplierID", supplierId);
                        command.Parameters.AddWithValue("@AdminID", adminId);
                        command.Parameters.AddWithValue("@StockQuantity", stockQuantity);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Product added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add product.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EditProductButton_Click(object sender, EventArgs e)
        {
            if (UserDataGrid_ProductDetails.SelectedRows.Count > 0)
            {
                int selectedRowIndex = UserDataGrid_ProductDetails.SelectedRows[0].Index;

                int selectedProductId = Convert.ToInt32(UserDataGrid_ProductDetails.Rows[selectedRowIndex].Cells["ProductID"].Value);

                string name = textBox2.Text;
                string description = textBox3.Text;
                decimal price;
                int productId, categoryId, supplierId, adminId, stockQuantity;

                if (!int.TryParse(textBox1.Text, out productId))
                {
                    MessageBox.Show("Please enter a valid Product ID.");
                    return;
                }

                if (!decimal.TryParse(textBox4.Text, out price))
                {
                    MessageBox.Show("Please enter a valid Price.");
                    return;
                }

                if (!int.TryParse(textBox5.Text, out categoryId))
                {
                    MessageBox.Show("Please enter a valid Category ID.");
                    return;
                }

                if (!int.TryParse(textBox6.Text, out supplierId))
                {
                    MessageBox.Show("Please enter a valid Supplier ID.");
                    return;
                }

                if (!int.TryParse(textBox7.Text, out adminId))
                {
                    MessageBox.Show("Please enter a valid Admin ID.");
                    return;
                }

                if (!int.TryParse(textBox8.Text, out stockQuantity))
                {
                    MessageBox.Show("Please enter a valid Stock Quantity.");
                    return;
                }

                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
                string query = "UPDATE Product SET ProductID = @ProductID, Name = @Name, Description = @Description, Price = @Price, CategoryID = @CategoryID, SupplierID = @SupplierID, AdminID = @AdminID, StockQuantity = @StockQuantity WHERE ProductID = @SelectedProductID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ProductID", productId);
                            command.Parameters.AddWithValue("@Name", name);
                            command.Parameters.AddWithValue("@Description", description);
                            command.Parameters.AddWithValue("@Price", price);
                            command.Parameters.AddWithValue("@CategoryID", categoryId);
                            command.Parameters.AddWithValue("@SupplierID", supplierId);
                            command.Parameters.AddWithValue("@AdminID", adminId);
                            command.Parameters.AddWithValue("@StockQuantity", stockQuantity);
                            command.Parameters.AddWithValue("@SelectedProductID", selectedProductId);

                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Product updated successfully.");
                                displayProductsData();
                                cleartextfields();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update product.");
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
                MessageBox.Show("Please select a product to edit.");
            }
        }



        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            if (UserDataGrid_ProductDetails.SelectedRows.Count > 0)
            {
                int selectedRowIndex = UserDataGrid_ProductDetails.SelectedRows[0].Index;

                int selectedProductId = Convert.ToInt32(UserDataGrid_ProductDetails.Rows[selectedRowIndex].Cells["ProductID"].Value);

                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
                string query = "DELETE FROM Product WHERE ProductID = @ProductID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ProductID", selectedProductId);

                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Product deleted successfully.");
                                displayProductsData();
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
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void DeleteAllProductButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "DELETE FROM Product";

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
                            MessageBox.Show("All products deleted successfully.");
                            displayProductsData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void cleartextfields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void button_expensivecategories_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = @"select c.CategoryName, AVG(p.Price) as AvgPrice from Product p join Category c on p.CategoryID = c.CategoryID group by c.CategoryName having AVG(p.Price) > 50;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable orderTable = new DataTable();
                        adapter.Fill(orderTable);
                        UserDataGrid_ProductDetails.DataSource = orderTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button_highlyRatedProducts_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = @"select P.Name as ProductName,SUM(I.Quantity) AS TotalStock from Product P join Inventory I on P.ProductID = I.ProductID group by P.Name having SUM(I.Quantity) < 5;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable orderTable = new DataTable();
                        adapter.Fill(orderTable);
                        UserDataGrid_ProductDetails.DataSource = orderTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TotalSalesButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = @"select * from TotalSalesByProduct";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable orderTable = new DataTable();
                        adapter.Fill(orderTable);
                        UserDataGrid_ProductDetails.DataSource = orderTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button_total_productin_category_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = @"select * from TotalProductsInEachCategory";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable orderTable = new DataTable();
                        adapter.Fill(orderTable);
                        UserDataGrid_ProductDetails.DataSource = orderTable;
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
