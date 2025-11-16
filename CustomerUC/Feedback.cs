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
    public partial class Feedback : UserControl
    {
        public Feedback()
        {
            InitializeComponent();

            // Subscribe to the CheckedChanged event for all feedback type radio buttons
            foreach (Control control in type_group_box.Controls)
            {
                if (control is RadioButton)
                {
                   ((RadioButton)control).CheckedChanged += radio_CheckedChanged;
                }
            }

            // Subscribe to the CheckedChanged event for all rating radio buttons
            foreach (Control control in rating_group_box.Controls)
            {
                if (control is RadioButton)
                {
                    ((RadioButton)control).CheckedChanged += rating_CheckedChanged;
                }
            }
        }

        private const string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS; Integrated Security=True; Encrypt=false";
         

        private void submit_btn_Click(object sender, EventArgs e)
        {
            // Validate the input
            if (!ValidateInput())
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get feedback data
            int FeedbackID = 0;
            string feedbackType = GetSelectedFeedbackType();
            string comments = feedback_box.Text;
            int rating = GetSelectedRating();
            DateTime date = DateTime.Today; // Capture the current date

            // Store feedback in the database
            if (StoreFeedbackInDatabase(FeedbackID,feedbackType, comments, rating, date))
            {
                MessageBox.Show("Feedback submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear the form after successful submission
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to submit feedback. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidateInput()
        {
            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(GetSelectedFeedbackType()) || string.IsNullOrWhiteSpace(feedback_box.Text) || GetSelectedRating() == -1)
            {
                return false;
            }
            return true;
        }

        private string GetSelectedFeedbackType()
        {
            // Determine which feedback type is selected
            if (complaint_radio.Checked)
            {
                return "Complaint";
            }
            else if (suggestion_radio.Checked)
            {
                return "Suggestion";
            }
            else if (compliment_radio.Checked)
            {
                return "Compliment";
            }
            return string.Empty;
        }

        private int GetSelectedRating()
        {
            // Determine which rating is selected
            if (radio1.Checked)
            {
                return 1;
            }
            else if (radio2.Checked)
            {
                return 2;
            }
            else if (radio3.Checked)
            {
                return 3;
            }
            else if (radio4.Checked)
            {
                return 4;
            }
            else if (radio5.Checked)
            {
                return 5;
            }
            return -1; // Indicate no rating selected
        }

        private bool StoreFeedbackInDatabase(int FeedbackID,string feedbackType, string comments, int rating, DateTime date)
        {
            try
            {
                // Connect to the database
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Insert feedback into the database
                    string query = "INSERT INTO Feedback (FeedbackID,Type, Ratings, Comment, Date) VALUES (@FeedbackID, @Type, @Ratings, @Comment, @Date)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FeedbackID", Guid.NewGuid().ToString());
                        command.Parameters.AddWithValue("@Type", feedbackType);
                        command.Parameters.AddWithValue("@Ratings", rating);
                        command.Parameters.AddWithValue("@Comment", comments);
                        command.Parameters.AddWithValue("@Date", date);
                        command.ExecuteNonQuery();
                    }
                }
                return true; // Feedback stored successfully
            }
            catch (Exception ex)
            {
                // Handle exception
                MessageBox.Show("Failed to submit feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Failed to store feedback
            }
        }


        private void ClearForm()
        {
            // Clear all fields in the form
            complaint_radio.Checked = false;
            suggestion_radio.Checked = false;
            compliment_radio.Checked = false;
            feedback_box.Clear();
            radio1.Checked = false;
            radio2.Checked = false;
            radio3.Checked = false;
            radio4.Checked = false;
            radio5.Checked = false;
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            // Uncheck all feedback type radio buttons except the one that triggered the event
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                foreach (Control control in type_group_box.Controls)
                {
                    if (control is RadioButton && control != radioButton)
                    {
                        ((RadioButton)control).Checked = false;
                    }
                }
            }
        }

        private void rating_CheckedChanged(object sender, EventArgs e)
        {
            // Uncheck all rating radio buttons except the one that triggered the event
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                foreach (Control control in rating_group_box.Controls)
                {
                    if (control is RadioButton && control != radioButton)
                    {
                        ((RadioButton)control).Checked = false;
                    }
                }
            }
        }

        private void feedback_box_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
