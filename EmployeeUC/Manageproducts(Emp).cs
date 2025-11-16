using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DB_Project1.EmployeeUC
{
    public partial class Manageproducts_Emp_ : UserControl
    {
        DataTable productTable = new DataTable("Products");
        DataTable discountTable = new DataTable("Discounts"); 
        public Manageproducts_Emp_()
        {
            InitializeComponent();
            displayProductsData();
            displayDiscountsData();
        }
        private void displayDiscountsData()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string discountQuery = "SELECT * FROM Discount";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(discountQuery, connection))
                    {
                        discountTable.Clear();
                        adapter.Fill(discountTable);
                        dataGridView_discountlist.DataSource = discountTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void displayProductsData()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string productQuery = "SELECT * FROM Product";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(productQuery, connection))
                    {
                        productTable.Clear();
                        adapter.Fill(productTable);
                        UserDataGrid_ProductData.DataSource = productTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void AddProductButton_Click_Click(object sender, EventArgs e)
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

        private void EditProductButton_Click_Click(object sender, EventArgs e)
        {
            if (UserDataGrid_ProductData.SelectedRows.Count > 0)
            {
                int selectedRowIndex = UserDataGrid_ProductData.SelectedRows[0].Index;

                int selectedProductId = Convert.ToInt32(UserDataGrid_ProductData.Rows[selectedRowIndex].Cells["ProductID"].Value);

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

        private void DeleteProductButton_Click_Click(object sender, EventArgs e)
        {
            if (UserDataGrid_ProductData.SelectedRows.Count > 0)
            {
                int selectedRowIndex = UserDataGrid_ProductData.SelectedRows[0].Index;

                int selectedProductId = Convert.ToInt32(UserDataGrid_ProductData.Rows[selectedRowIndex].Cells["ProductID"].Value);

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


        private void DeleteAllProductsButton_Click_Click(object sender, EventArgs e)
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
            SearchTextBox.Text = "";
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataView dv = productTable.DefaultView;
            dv.RowFilter = string.Format("Name LIKE '%{0}%' OR Description LIKE '%{0}%'", SearchTextBox.Text);
            UserDataGrid_ProductData.DataSource = dv.ToTable();
        }

        private void dataGridView_discountlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewDiscountedProductsButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = @"SELECT p.ProductID, p.Name, p.Description, p.Price, d.DiscountPercentage, p.Price - (p.Price * (d.DiscountPercentage / 100)) AS DiscountedPrice from Product p inner join Discount d on p.DiscountID = d.DiscountID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable discountedProductsTable = new DataTable();
                        adapter.Fill(discountedProductsTable);
                        UserDataGrid_ProductData.DataSource = discountedProductsTable;
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
