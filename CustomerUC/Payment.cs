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

namespace DB_Project1.AllFunction
{

    public partial class Payment : UserControl
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void cash_radio_CheckedChanged(object sender, EventArgs e)
        {
            // If cash radio button is checked, hide the card panel
            if (cash_radio.Checked)
            {
                card_panel.Visible = false;
                
            }
        }

        private void card_radio_CheckedChanged(object sender, EventArgs e)
        {
            // If card radio button is checked, show the card panel
            if (card_radio.Checked)
            {
                card_panel.Visible = true;
                
            }
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (cash_radio.Checked)
            {
                // Perform actions for cash payment
                MessageBox.Show("Payment confirmed. Thank you for your purchase!");
            }
            else if (card_radio.Checked)
            {
                // Perform actions for card payment
                string cardNumber = card_text.Text;
                string expMonth = expiry_month_text.Text;
                string expYear = expiry_year_text.Text;
                string cvv = cvv_text.Text;

                // Validate card information
                if (IsValidCardInfo(cardNumber, expMonth, expYear, cvv))
                {
                    MessageBox.Show("Payment confirmed. Thank you for your purchase!");
                }
                else
                {
                    MessageBox.Show("Invalid card information. Please check and try again.");
                }
            }
        }

        private bool IsValidCardInfo(string cardNumber, string expMonth, string expYear, string cvv)
        {
            // Perform validation for card information
            if (cardNumber.Length != 16 || !int.TryParse(cardNumber, out _))
                return false;

            if (expMonth.Length != 2 || !int.TryParse(expMonth, out int month) || month < 1 || month > 12)
                return false;

            if (expYear.Length != 4 || !int.TryParse(expYear, out int year) || year < DateTime.Now.Year)
                return false;

            if (cvv.Length != 3 || !int.TryParse(cvv, out _))
                return false;

            return true;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            
            PlaceOrder PlaceOrderUC = new PlaceOrder();
            PlaceOrderUC.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(PlaceOrderUC);
        }

        private void GenerateAndSaveReceipt()
        {
            // Fetch customer name from the Customer form
            string customerName = ((Customer)this.ParentForm).CustomerName;

            // Fetch item details from the product_grid in the previous user control
            DataTable productData = ((PlaceOrder)this.Parent).GetProductData(); 

            // Gather other necessary information for the receipt
            decimal subtotal = CalculateSubtotal(productData);
            decimal discount = 10.00m; // Example discount
            decimal total = subtotal - discount; // Example total
            string paymentMethod = cash_radio.Checked ? "Cash" : "Credit Card"; // Payment method

            // Generate current date and time
            DateTime currentDate = DateTime.Now;

            // Create a new receipt instance and populate its properties
            Receipt receipt = new Receipt
            {
                Date = currentDate,
                Items = FormatProductData(productData),
                Discount = discount,
                Total = total,
                PaymentMethod = paymentMethod,
                Customer = customerName
            };

            // Insert receipt data into the database
            if (SaveReceiptToDatabase(receipt))
            {
                // Optionally display the receipt to the user
                MessageBox.Show("Receipt generated and saved successfully.");
            }
            else
            {
                MessageBox.Show("Failed to save receipt data to the database.");
            }
        }

        private bool SaveReceiptToDatabase(Receipt receipt)
        {
            // Database connection string
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS; Integrated Security=True; Encrypt=false";

            // SQL query to insert receipt data into the database
            string query = "INSERT INTO Receipt (Date, Items, Discount, Total, PaymentMethod) " +
                           "VALUES (@Date, @Items, @Discount, @Total, @PaymentMethod)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@Date", receipt.Date);
                        command.Parameters.AddWithValue("@Items", receipt.Items);
                        command.Parameters.AddWithValue("@Discount", receipt.Discount);
                        command.Parameters.AddWithValue("@Total", receipt.Total);
                        command.Parameters.AddWithValue("@PaymentMethod", receipt.PaymentMethod);

                        // Open the connection and execute the command
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                return true; // Receipt data saved successfully
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false; // Failed to save receipt data
            }
        }

        private decimal CalculateSubtotal(DataTable productData)
        {
            decimal subtotal = 0;

            foreach (DataRow row in productData.Rows)
            {
                decimal price = Convert.ToDecimal(row["Price"]);
                int quantity = Convert.ToInt32(row["Quantity"]);
                subtotal += price * quantity;
            }

            return subtotal;
        }

        private string FormatProductData(DataTable productData)
        {
            StringBuilder formattedData = new StringBuilder();

            foreach (DataRow row in productData.Rows)
            {
                string name = row["Name"].ToString();
                decimal price = Convert.ToDecimal(row["Price"]);
                int quantity = Convert.ToInt32(row["Quantity"]);

                // Append item details to the formatted data string
                formattedData.AppendLine($"{name} - ${price} x {quantity}");
            }

            return formattedData.ToString();
        }

        private void payment_summary_btn_Click(object sender, EventArgs e)
        {
            // Call the method to retrieve data from the PaymentSummary view
            DataTable paymentSummaryData = GetPaymentSummaryData();

            // Check if data is retrieved successfully
            if (paymentSummaryData != null)
            {
                
            }
            else
            {
                // Handle case when data retrieval fails
                MessageBox.Show("Failed to retrieve payment summary data.");
            }

        }


        private DataTable GetPaymentSummaryData()
        {
            DataTable paymentSummaryData = new DataTable();

            // Define your connection string
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS; Integrated Security=True; Encrypt=false";

            // Define your SQL query to select data from the PaymentSummary view
            string query = "SELECT * FROM PaymentSummary";

            try
            {
                // Create a connection object
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Create a command object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Create a data adapter to fill the DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        // Fill the DataTable with data from the view
                        adapter.Fill(paymentSummaryData);
                    }
                }

                return paymentSummaryData;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during execution
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

    }
    public class Receipt
    {
        public int ReceiptID { get; set; }
        public DateTime Date { get; set; }
        public string Items { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public int PaymentID { get; set; }
        public string PaymentMethod { get; set; }
        public string Customer { get; set; }
    }
}
