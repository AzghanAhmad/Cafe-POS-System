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
    public partial class ViewOrders : UserControl
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        private void show_orders_btn_Click(object sender, EventArgs e)
        {
            // Define your connection string
            string connectionString = "YourConnectionString";

            // Define your SQL query
            string query = @"
        SELECT O.OrderID, C.Name AS CustomerName, P.Name AS ProductName
        FROM Orderr O
        JOIN Customer C ON O.CustomerID = C.CustomerID
        JOIN OrderItems OI ON O.OrderID = OI.OrderID
        JOIN Product P ON OI.ProductID = P.ProductID";

            try
            {
                // Create a connection object
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Create a command object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the query and retrieve the results
                        SqlDataReader reader = command.ExecuteReader();

                        // Check if there are rows returned
                        if (reader.HasRows)
                        {
                            // Clear existing rows in the grid
                            ordersGridView.Rows.Clear();

                            // Loop through the rows and add them to the grid
                            while (reader.Read())
                            {
                                // Retrieve data from the reader
                                int orderID = reader.GetInt32(reader.GetOrdinal("OrderID"));
                                string customerName = reader.GetString(reader.GetOrdinal("CustomerName"));
                                string productName = reader.GetString(reader.GetOrdinal("ProductName"));

                                // Add the data to the grid
                                ordersGridView.Rows.Add(orderID, customerName, productName);
                            }
                        }
                        else
                        {
                            // Handle case when no orders are found
                            MessageBox.Show("No orders found.");
                        }

                        // Close the reader
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during execution
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
