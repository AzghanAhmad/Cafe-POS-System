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
    public partial class ViewDiscounts : UserControl
    {
       
        public ViewDiscounts()
        {
            InitializeComponent();
            LoadDiscounts();
        }

        private void LoadDiscounts(string query = null)
        {
            if (query == null)
            {
                // Default query to load all discounts
                query = "SELECT p.ProductID, p.Name, p.Price, d.Percentage " +
                        "FROM Product p " +
                        "INNER JOIN Discount d ON p.ProductID = d.ProductID";
            }

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS; Integrated Security=True; Encrypt=false";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable discountData = new DataTable();
                            adapter.Fill(discountData);

                            PopulateDiscountGrid(discountData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void PopulateDiscountGrid(DataTable discountData)
        {
            // Add a new DataColumn for Discounted Price
            DataColumn discountedPriceColumn = new DataColumn("Discounted Price", typeof(decimal));
            discountData.Columns.Add(discountedPriceColumn);

            // Calculate Discounted Price for each row
            foreach (DataRow row in discountData.Rows)
            {
                // Extract Price and Percentage values from the current row
                decimal price = Convert.ToDecimal(row["Price"]);
                decimal percentage = Convert.ToDecimal(row["Percentage"]);

                // Calculate Discounted Price by subtracting the Percentage from the Price
                decimal discountedPrice = price - (price * percentage / 100);

                // Assign the calculated Discounted Price to the new column in the current row
                row["Discounted Price"] = discountedPrice;
            }

            // Bind the modified DataTable to your DataGridView
            discount_grid.DataSource = discountData;
        }

        private void SearchDiscountedProducts(string searchTerm)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=False";
            string query = "SELECT p.ProductID, p.Name, p.Price, d.Percentage " +
                           "FROM Product p " +
                           "INNER JOIN Discount d ON p.ProductID = d.ProductID " +
                           "WHERE p.Name LIKE @SearchTerm OR d.Name LIKE @SearchTerm";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                        connection.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable discountData = new DataTable();
                            adapter.Fill(discountData);

                            PopulateDiscountGrid(discountData);
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
                string searchTerm = search_text.Text;
                SearchDiscountedProducts(searchTerm);
            
        }

        private void sort_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected sorting option
            string selectedSortingOption = sort_combo.SelectedItem.ToString();

            // Define the SQL query based on the selected sorting option
            string query = "";
            switch (selectedSortingOption)
            {
                case "Discount Percentage Low to High":
                    query = "SELECT p.ProductID, p.Name, p.Price, d.Percentage " +
                            "FROM Product p " +
                            "INNER JOIN Discount d ON p.ProductID = d.ProductID " +
                            "ORDER BY d.Percentage ASC";
                    break;
                case "Discount Percentage High to Low":
                    query = "SELECT p.ProductID, p.Name, p.Price, d.Percentage " +
                            "FROM Product p " +
                            "INNER JOIN Discount d ON p.ProductID = d.ProductID " +
                            "ORDER BY d.Percentage DESC";
                    break;
                // Products with a discount percentage higher than the average discount percentage for products with prices higher than the overall average price
                case "Products with a discount percentage higher than the average discount percentage":
                    query = "SELECT p.ProductID, p.Name, p.Price, d.Percentage FROM Product p INNER JOIN Discount d ON p.ProductID = d.ProductID WHERE d.Percentage > (SELECT AVG(Percentage)  FROM Discount WHERE ProductID IN (  SELECT ProductID   FROM Product  WHERE Price > ( SELECT AVG(Price)  FROM Product )))";
                    break;
                case "Maximum discount percentage among those products":
                    query = " SELECT MAX(d.Percentage) AS MaxDiscountPercentage FROM Discount d WHERE d.ProductID IN (SELECT ProductID FROM Product WHERE Price > ( SELECT AVG(Price) FROM Product)  )";
                    break;

                default:
                    break;
            }

            LoadDiscounts(query);
        }


    }

}

