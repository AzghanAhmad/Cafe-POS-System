using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project1.AllFunction
{
    public partial class PlaceOrder : UserControl
    {
        // Define a variable to store the product ID of the selected product
        private int selectedProductId;

        public PlaceOrder()
        {
            InitializeComponent();
            LoadCategories();

        }

        private void LoadProductsByCategory(string selectedCategory)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS; Integrated Security=True; Encrypt=false";
            string query = "SELECT ProductID, Name, Price FROM Product WHERE CategoryID IN (SELECT CategoryID FROM Category WHERE CategoryName = @Category)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Category", selectedCategory);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            list_box.Items.Clear();

                            while (reader.Read())
                            {
                                list_box.Items.Add(reader["Name"].ToString());

                                // Store the product ID in the Tag property of each list box item
                                int productId = Convert.ToInt32(reader["ProductID"]);
                                list_box.Items[list_box.Items.Count - 1].Tag = productId;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadCategories()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS; Integrated Security=True; Encrypt=false";
            string query = "SELECT CategoryName FROM Category";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            category_combo.Items.Clear();

                            while (reader.Read())
                            {
                                category_combo.Items.Add(reader["CategoryName"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void list_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_box.SelectedItems.Count > 0)
            {
                // Get the product ID from the Tag property of the selected list view item
                selectedProductId = Convert.ToInt32(list_box.SelectedItems[0].Tag);

                // Fetch product details from the database based on the selected product ID
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS; Integrated Security=True; Encrypt=false";
                string query = "SELECT Name, Price FROM Product WHERE ProductID = @ProductId";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ProductId", selectedProductId);

                            connection.Open();

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Auto-fill the text boxes with product details
                                    name_text.Text = reader["Name"].ToString();
                                    price_text.Text = reader["Price"].ToString();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void calculateTotal()
        {
            // Calculate total price based on quantity and price
            if (int.TryParse(quantity_num.Value.ToString(), out int quantity) && decimal.TryParse(price_text.Text, out decimal price))
            {
                decimal total = quantity * price;
                total_text.Text = total.ToString();
            }
        }

        private void quantity_num_ValueChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void add_to_cart_btn_Click(object sender, EventArgs e)
        {
            // Add the product details to the cart grid view
            string[] row = {
                selectedProductId.ToString(), // Product ID
                name_text.Text,               // Product name
                price_text.Text,              // Product price
                quantity_num.Value.ToString(),// Quantity
                total_text.Text               // Total
            };
            product_grid.Rows.Add(row);
            UpdateTotalPriceTextBox();
            // Clear the text boxes for the user to add another product
            name_text.Clear();
            price_text.Clear();
            quantity_num.Value = 1;
            total_text.Clear();
        }

        private void category_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (category_combo.SelectedItem != null)
            {
                string selectedCategory = category_combo.SelectedItem.ToString();
                LoadProductsByCategory(selectedCategory);
            }
        }
        private void remove_btn_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (product_grid.SelectedRows.Count > 0)
            {
                // Remove the selected row from the product_grid
                product_grid.Rows.Remove(product_grid.SelectedRows[0]);
                UpdateTotalPriceTextBox();
            }
            else
            {
                MessageBox.Show("Please select a row to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateTotalPriceTextBox()
        {
            decimal totalPrice = 0;

            // Iterate through each row in the product_grid
            foreach (DataGridViewRow row in product_grid.Rows)
            {
                // Check if the row is not null and if it has cells
                if (row != null && row.Cells["total_column"] != null)
                {
                    // Get the cell value
                    object totalCellValue = row.Cells["total_column"].Value;
                    if (totalCellValue != null)
                    {
                        // Parse the total price string to decimal
                        if (decimal.TryParse(totalCellValue.ToString(), out decimal rowTotal))
                        {
                            // Add the total price of the current row to the grand total
                            totalPrice += rowTotal;
                        }
                        else
                        {
                           
                        }
                    }
                    else
                    {
                         
                    }
                }
            }

            // Update the grand_total_box with the grand total
            grand_total_box.Text = "Rs. " + totalPrice.ToString();
        }

        private void SearchProducts(string searchTerm)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS; Integrated Security=True; Encrypt=false";
            string query = "SELECT ProductID, Name FROM Product WHERE Name LIKE @SearchTerm";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add wildcard (%) to search term to match partial names
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear existing items in the list box
                            list_box.Items.Clear();

                            // Add search results to the list box
                            while (reader.Read())
                            {
                                // Create a string with the product name and ID, separated by a delimiter
                                string productName = reader["Name"].ToString();
                                int productId = Convert.ToInt32(reader["ProductID"]);
                                string listItem = $"{productName} (ID: {productId})";

                                // Add the item to the list box
                                list_box.Items.Add(listItem);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void search_text_TextChanged_1(object sender, EventArgs e)
        {
            SearchProducts(search_text.Text);
        }

        


        public event EventHandler CheckoutClicked;
        private void checkout_btn_Click(object sender, EventArgs e)
        {
            // Hide the "Place Order" user control
            this.Hide();

            // Show the "Payment" user control
            Payment paymentUC = new Payment();
            paymentUC.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(paymentUC);
        }

        public DataTable GetProductData()
        {
            DataTable productData = new DataTable();

            // Define the columns for the DataTable
            productData.Columns.Add("ProductID", typeof(int));
            productData.Columns.Add("Name", typeof(string));
            productData.Columns.Add("Price", typeof(decimal));
            productData.Columns.Add("Quantity", typeof(int));
            productData.Columns.Add("Total", typeof(decimal));

            // Iterate through each row in the product_grid and add data to the DataTable
            foreach (DataGridViewRow row in product_grid.Rows)
            {
                int productId;
                string name;
                decimal price;
                int quantity;
                decimal total;

                // Check if the row is not null and if it has cells
                if (row != null && row.Cells["id_column"] != null && row.Cells["name_column"] != null &&
                    row.Cells["price_column"] != null && row.Cells["quantity_column"] != null && row.Cells["total_column"] != null)
                {
                    // Parse cell values to appropriate types
                    if (int.TryParse(row.Cells["id_column"].Value.ToString(), out productId) &&
                        decimal.TryParse(row.Cells["price_column"].Value.ToString(), out price) &&
                        int.TryParse(row.Cells["quantity_column"].Value.ToString(), out quantity) &&
                        decimal.TryParse(row.Cells["total_column"].Value.ToString(), out total))
                    {
                        name = row.Cells["name_column"].Value.ToString();

                        // Add row to the DataTable
                        productData.Rows.Add(productId, name, price, quantity, total);
                    }
                }
            }

            return productData;
        }



    }
}

