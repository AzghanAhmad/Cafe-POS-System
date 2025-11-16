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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Project1.AdminUC
{
    public partial class ManageOrders : UserControl
    {
        DataTable orderItemsTable = new DataTable();
        DataTable customerTable = new DataTable();
        public ManageOrders()
        {
            InitializeComponent();
            InitializeOrderItemsTable(); 
            LoadCustomerData();
            LoadOrderData();
            LoadOrderItemsData();
        }
        private void InitializeOrderItemsTable()
        {
            orderItemsTable.Columns.Add("OrderItemID", typeof(int));
            orderItemsTable.Columns.Add("OrderID", typeof(int));
            orderItemsTable.Columns.Add("ProductID", typeof(int));
            orderItemsTable.Columns.Add("Quantity", typeof(int));
            orderItemsTable.Columns.Add("Price", typeof(decimal));
            UserDataGrid_ProductData.DataSource = orderItemsTable;
        }


        private void UserDataGrid_ProductData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadOrderItemsData();
        }
        private void LoadOrderItemsData()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "select * from OrderItems";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable orderItemsTable = new DataTable();
                        adapter.Fill(orderItemsTable);
                        UserDataGrid_ProductData.DataSource = orderItemsTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView_orderlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void ViewOrdersButton_Click(object sender, EventArgs e)
        {
            LoadLastMonthOrders();
        }
        private void LoadCustomerData()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "select * from Customer";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable customerTable = new DataTable();
                        adapter.Fill(customerTable);
                        dataGridView_customerassociated.DataSource = customerTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadOrderData()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = "select * from Orderr";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable orderTable = new DataTable();
                        adapter.Fill(orderTable);
                        dataGridView_orderlist.DataSource = orderTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadLastMonthOrders()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = @"select o.OrderID, c.Name AS CustomerName, e.Name AS EmployeeName, o.Date, o.Status from Orderr o join Customer c on o.CustomerID = c.CustomerID join Employee e ON o.EmployeeID = e.EmployeeID where o.Date >= DATEADD(MONTH, -1, GETDATE())";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable orderTable = new DataTable();
                        adapter.Fill(orderTable);
                        dataGridView_orderlist.DataSource = orderTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dataGridView_customerassociated_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please fill in all order details.");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int orderId))
            {
                MessageBox.Show("Please enter a valid Order ID.");
                return;
            }

            if (!int.TryParse(textBox2.Text, out int customerId))
            {
                MessageBox.Show("Please enter a valid Customer ID.");
                return;
            }

            if (!int.TryParse(textBox3.Text, out int employeeId))
            {
                MessageBox.Show("Please enter a valid Employee ID.");
                return;
            }

            if (!DateTime.TryParse(textBox4.Text, out DateTime date))
            {
                MessageBox.Show("Please enter a valid Date.");
                return;
            }

            string status = textBox5.Text;

            AddOrder(orderId, customerId, employeeId, date, status);
        }

        private void AddOrder(int orderId, int customerId, int employeeId, DateTime date, string status)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string insertOrderQuery = "INSERT INTO Orderr (OrderID, CustomerID, EmployeeID, Date, Status) VALUES (@OrderID, @CustomerID, @EmployeeID, @Date, @Status)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(insertOrderQuery, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", orderId);
                        command.Parameters.AddWithValue("@CustomerID", customerId);
                        command.Parameters.AddWithValue("@EmployeeID", employeeId);
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@Status", status);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Order added successfully.");
                            LoadOrderData();
                            cleartextfields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add order.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EditOrderButton_Click(object sender, EventArgs e)
        {
            if (dataGridView_orderlist.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView_orderlist.SelectedRows[0].Index;

                int selectedOrderId = Convert.ToInt32(dataGridView_orderlist.Rows[selectedRowIndex].Cells["OrderID"].Value);
                int selectedCustomerId = Convert.ToInt32(dataGridView_orderlist.Rows[selectedRowIndex].Cells["CustomerID"].Value);
                int selectedEmployeeId = Convert.ToInt32(dataGridView_orderlist.Rows[selectedRowIndex].Cells["EmployeeID"].Value);
                DateTime selectedDate = Convert.ToDateTime(dataGridView_orderlist.Rows[selectedRowIndex].Cells["Date"].Value);
                string selectedStatus = dataGridView_orderlist.Rows[selectedRowIndex].Cells["Status"].Value.ToString();

                if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    MessageBox.Show("Please fill in all order details to edit the order.");
                    return;
                }

                if (!DateTime.TryParse(textBox4.Text, out DateTime date))
                {
                    MessageBox.Show("Please enter a valid Date.");
                    return;
                }

                string status = textBox5.Text;

                EditOrder(selectedOrderId, selectedCustomerId, selectedEmployeeId, date, status);
            }
            else
            {
                MessageBox.Show("Please select an order to edit.");
            }
        }

        private void EditOrder(int orderId, int customerId, int employeeId, DateTime date, string status)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string updateOrderQuery = "UPDATE Orderr SET CustomerID = @CustomerID, EmployeeID = @EmployeeID, Date = @Date, Status = @Status WHERE OrderID = @OrderID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(updateOrderQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerId);
                        command.Parameters.AddWithValue("@EmployeeID", employeeId);
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@OrderID", orderId);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Order updated successfully.");
                            LoadOrderData();
                            cleartextfields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update order.");
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
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            if (dataGridView_orderlist.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView_orderlist.SelectedRows[0].Index;

                int selectedOrderId = Convert.ToInt32(dataGridView_orderlist.Rows[selectedRowIndex].Cells["OrderID"].Value);

                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
                string deleteOrderQuery = "DELETE FROM Orderr WHERE OrderID = @OrderID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(deleteOrderQuery, connection))
                        {
                            command.Parameters.AddWithValue("@OrderID", selectedOrderId);
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Order deleted successfully.");
                        LoadOrderData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an order to delete.");
            }
        }

        private void DeleteAllOrdersButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all orders?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
                string deleteQuery = "DELETE FROM Orderr";

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

                    LoadOrderData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buttonOrderDeails_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = @"select o.OrderID, c.Name As CustomerName, p.Name AS ProductName,o.date As OrderDate,oi.Quantity As OrderQuantity from Orderr o join Customer c on o.CustomerID = c.CustomerID join OrderItems oi on o.OrderID = oi.OrderID join Product p on oi.ProductID = p.ProductID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable orderTable = new DataTable();
                        adapter.Fill(orderTable);
                        dataGridView_orderlist.DataSource = orderTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        

        private void TotalPendingOrdersbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS;Integrated Security=True;Encrypt=false";
            string query = @"select Date, COUNT(OrderID) as TotalOrders from Orderr where Date = CAST(GETDATE() as Date) group by Date;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable orderTable = new DataTable();
                        adapter.Fill(orderTable);
                        dataGridView_orderlist.DataSource = orderTable;
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
