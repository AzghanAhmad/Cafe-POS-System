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
namespace DB_Project1.CustomerUC
{
    public partial class ViewProducts : UserControl
    {
        private int selectedProductId;
        public ViewProducts()
        {
            InitializeComponent();
            LoadCategories();
        }

        /*
        private void LoadProductsByCategory(string selectedCategory)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS; Integrated Security=True; Encrypt=false";
            string query = "SELECT ProductID, Name, Price, Description FROM Product WHERE CategoryID IN (SELECT CategoryID FROM Category WHERE CategoryName = @Category)";

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
        */
        private void LoadProductsByCategory(string selectedCategory)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS; Integrated Security=True; Encrypt=false";
            string query = @"
        SELECT p.ProductID, p.Name, p.Price, p.Description,
               (SELECT MAX(Discount.Percentage) FROM Discount WHERE Discount.ProductID = p.ProductID) AS MaxDiscount,
               (SELECT COUNT(OrderItems.Quantity) FROM OrderItems WHERE OrderItems.ProductID = p.ProductID) AS TotalOrders
        FROM Product p
        WHERE p.CategoryID IN (SELECT CategoryID FROM Category WHERE CategoryName = @Category)";

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
                string query = "SELECT ProductID, Name, Description, Price FROM Product WHERE ProductID = @ProductId";

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
                                    id_text.Text = reader["ProductID"].ToString();
                                    name_text.Text = reader["Name"].ToString();
                                    price_text.Text = reader["Price"].ToString();
                                    description_text.Text = reader["Description"].ToString();

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

        private void search_text_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(search_text.Text);
        }

        private void category_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (category_combo.SelectedItem != null)
            {
                string selectedCategory = category_combo.SelectedItem.ToString();
                LoadProductsByCategory(selectedCategory);
            }
        }
    }
}
