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
    public partial class ManageDiscounts : UserControl
    {
        DataTable discountTable = new DataTable();
        DataTable productTable = new DataTable();
        DataTable categoryTable = new DataTable();

        public ManageDiscounts()
        {
            InitializeComponent();
            InitializeDiscountTable();
            InitializeProductTable();
            InitializeCategoryCombo();
        }
        private void InitializeDiscountTable()
        {
            discountTable.Columns.Add("DiscountID", typeof(int));
            discountTable.Columns.Add("Name", typeof(string));
            discountTable.Columns.Add("Description", typeof(string));
            discountTable.Columns.Add("Percentage", typeof(decimal));
            discountTable.Columns.Add("ProductID", typeof(int));
            dataGridView_discountlist.DataSource = discountTable;
            LoadDiscountData();
        }
        private void LoadDiscountData()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "SELECT * FROM Discount";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        discountTable.Clear();
                        adapter.Fill(discountTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void InitializeProductTable()
        {
            productTable.Columns.Add("ProductID", typeof(int));
            productTable.Columns.Add("Name", typeof(string));
            productTable.Columns.Add("Description", typeof(string));
            productTable.Columns.Add("Price", typeof(decimal));
            productTable.Columns.Add("CategoryID", typeof(int));
            productTable.Columns.Add("SupplierID", typeof(int));
            productTable.Columns.Add("AdminID", typeof(int));
            productTable.Columns.Add("StockQuantity", typeof(int));
            UserDataGrid_ProductData.DataSource = productTable;
        }
        private void LoadProductsById(int productId)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "SELECT * FROM Product WHERE ProductID = @ProductID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@ProductID", productId);
                        productTable.Clear();
                        adapter.Fill(productTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void InitializeCategoryCombo()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "SELECT * FROM Category";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        categoryTable.Clear();
                        adapter.Fill(categoryTable);
                        category_combo.DataSource = categoryTable;
                        category_combo.DisplayMember = "CategoryName";
                        category_combo.ValueMember = "CategoryID";
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
            int selectedRowIndex = e.RowIndex;
            if (selectedRowIndex >= 0 && selectedRowIndex < UserDataGrid_ProductData.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = UserDataGrid_ProductData.Rows[selectedRowIndex];
                int categoryId = Convert.ToInt32(selectedRow.Cells["CategoryID"].Value);
                category_combo.SelectedValue = categoryId;
            }
        }

        private void category_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(category_combo.SelectedValue);
            LoadProductsByCategory(categoryId);
        }
        private void LoadProductsByCategory(int categoryId)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "SELECT * FROM Product WHERE CategoryID = @CategoryID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@CategoryID", categoryId);
                        productTable.Clear();
                        adapter.Fill(productTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_discountlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView_discountlist.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = dataGridView_discountlist.Rows[selectedRowIndex];
                int productId = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
                LoadProductsById(productId);
            }
        }

        private void ViewDiscountsButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "select d.Name as DiscountName, d.Description, d.Percentage, p.Name as ProductName, p.Price as OriginalPrice, a.Name as AdminName from Discount d join Product p on d.ProductID = p.ProductID join Admin a on p.AdminID = a.AdminID";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable resultTable = new DataTable();
                        adapter.Fill(resultTable);

                        dataGridView_discountlist.DataSource = resultTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void AddDiscountButton_Click_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please fill in all discount details.");
                return;
            }

            if (!int.TryParse(textBox5.Text, out int discountId))
            {
                MessageBox.Show("Please enter a valid Discount ID.");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int productId))
            {
                MessageBox.Show("Please enter a valid Product ID.");
                return;
            }

            if (!decimal.TryParse(textBox4.Text, out decimal percentage))
            {
                MessageBox.Show("Please enter a valid Percentage.");
                return;
            }

            string discountName = textBox2.Text;
            string description = textBox3.Text;

            AddDiscount(discountId, productId, discountName, description, percentage);
        }

        private void AddDiscount(int discountId, int productId, string discountName, string description, decimal percentage)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string insertDiscountQuery = "insert into Discount (DiscountID, ProductID, Name, Description, Percentage) values (@DiscountID, @ProductID, @Name, @Description, @Percentage)";
            string updateProductQuery = "update Product set Price = Price * (1 - @Percentage / 100) where ProductID = @ProductID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand insertDiscountCommand = new SqlCommand(insertDiscountQuery, connection))
                    {
                        insertDiscountCommand.Parameters.AddWithValue("@DiscountID", discountId);
                        insertDiscountCommand.Parameters.AddWithValue("@ProductID", productId);
                        insertDiscountCommand.Parameters.AddWithValue("@Name", discountName);
                        insertDiscountCommand.Parameters.AddWithValue("@Description", description);
                        insertDiscountCommand.Parameters.AddWithValue("@Percentage", percentage);
                        insertDiscountCommand.ExecuteNonQuery();
                    }
                    using (SqlCommand updateProductCommand = new SqlCommand(updateProductQuery, connection))
                    {
                        updateProductCommand.Parameters.AddWithValue("@ProductID", productId);
                        updateProductCommand.Parameters.AddWithValue("@Percentage", percentage);
                        updateProductCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Discount applied successfully.");
                    LoadDiscountData();
                    cleartextfields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EditDiscountButton_Click_Click(object sender, EventArgs e)
        {
            if (dataGridView_discountlist.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView_discountlist.SelectedRows[0].Index;

                int selectedDiscountID = Convert.ToInt32(dataGridView_discountlist.Rows[selectedRowIndex].Cells["DiscountID"].Value);
                
                
                int selectedProductID = Convert.ToInt32(dataGridView_discountlist.Rows[selectedRowIndex].Cells["ProductID"].Value);

                if (string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Please fill in all discount details to edit the discount.");
                    return;
                }

                if (!decimal.TryParse(textBox4.Text, out decimal percentage))
                {
                    MessageBox.Show("Please enter a valid Percentage.");
                    return;
                }

                string discountName = textBox2.Text;
                string description = textBox3.Text;

                EditDiscount(selectedDiscountID, selectedProductID, discountName, description, percentage);
            }
            else
            {
                MessageBox.Show("Please select a discount to edit.");
            }
        }
        private void EditDiscount(int discountID, int productID, string discountName, string description, decimal percentage)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string updateDiscountQuery = "UPDATE Discount SET Name = @Name, Description = @Description, Percentage = @Percentage WHERE DiscountID = @DiscountID";
            string updateProductQuery = "UPDATE Product SET Price = Price / (1 - @Percentage / 100) WHERE ProductID = @ProductID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand updateDiscountCommand = new SqlCommand(updateDiscountQuery, connection))
                    {
                        updateDiscountCommand.Parameters.AddWithValue("@Name", discountName);
                        updateDiscountCommand.Parameters.AddWithValue("@Description", description);
                        updateDiscountCommand.Parameters.AddWithValue("@Percentage", percentage);
                        updateDiscountCommand.Parameters.AddWithValue("@DiscountID", discountID);

                        connection.Open();
                        int result = updateDiscountCommand.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Discount updated successfully.");
                            LoadDiscountData();
                            cleartextfields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update discount.");
                        }
                    }

                    using (SqlCommand updateProductCommand = new SqlCommand(updateProductQuery, connection))
                    {
                        updateProductCommand.Parameters.AddWithValue("@ProductID", productID);
                        updateProductCommand.Parameters.AddWithValue("@Percentage", percentage);
                        updateProductCommand.ExecuteNonQuery();
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
        }


        private void DeleteDiscountButton_Click_Click(object sender, EventArgs e)
        {
            if (dataGridView_discountlist.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView_discountlist.SelectedRows[0].Index;

                int selectedDiscountID = Convert.ToInt32(dataGridView_discountlist.Rows[selectedRowIndex].Cells["DiscountID"].Value);
                int selectedProductID = Convert.ToInt32(dataGridView_discountlist.Rows[selectedRowIndex].Cells["ProductID"].Value);
                decimal selectedPercentage = Convert.ToDecimal(dataGridView_discountlist.Rows[selectedRowIndex].Cells["Percentage"].Value);

                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
                string deleteDiscountQuery = "DELETE FROM Discount WHERE DiscountID = @DiscountID";
                string updateProductQuery = "UPDATE Product SET Price = Price / (1 - @Percentage / 100) WHERE ProductID = @ProductID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand deleteDiscountCommand = new SqlCommand(deleteDiscountQuery, connection))
                        {
                            deleteDiscountCommand.Parameters.AddWithValue("@DiscountID", selectedDiscountID);
                            deleteDiscountCommand.ExecuteNonQuery();
                        }

                        using (SqlCommand updateProductCommand = new SqlCommand(updateProductQuery, connection))
                        {
                            updateProductCommand.Parameters.AddWithValue("@ProductID", selectedProductID);
                            updateProductCommand.Parameters.AddWithValue("@Percentage", selectedPercentage);
                            updateProductCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Discount deleted successfully.");
                        LoadDiscountData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a discount to delete.");
            }
        }

        private void DeleteAllDiscountButton_Click_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all discounts?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
                string deleteQuery = "DELETE FROM Discount";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }

                    LoadDiscountData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = SearchTextBox.Text.Trim();

            if (searchKeyword != "")
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
                string query = "SELECT * FROM Discount WHERE Name LIKE @SearchKeyword";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@SearchKeyword", "%" + searchKeyword + "%");

                            DataTable resultTable = new DataTable();
                            adapter.Fill(resultTable);

                            dataGridView_discountlist.DataSource = resultTable;
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
                dataGridView_discountlist.DataSource = discountTable;
            }
        }


    }
}
