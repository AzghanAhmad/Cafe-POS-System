namespace DB_Project1.CustomerUC
{
    partial class Feedback
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.complaint_radio = new System.Windows.Forms.RadioButton();
            this.suggestion_radio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.compliment_radio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.feedback_box = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio5 = new System.Windows.Forms.RadioButton();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.submit_btn = new Guna.UI2.WinForms.Guna2Button();
            this.type_group_box = new System.Windows.Forms.GroupBox();
            this.rating_group_box = new System.Windows.Forms.GroupBox();
            this.type_group_box.SuspendLayout();
            this.rating_group_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 38);
            this.label1.TabIndex = 37;
            this.label1.Text = "Feedback";
            // 
            // complaint_radio
            // 
            this.complaint_radio.AutoSize = true;
            this.complaint_radio.Location = new System.Drawing.Point(120, 7);
            this.complaint_radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.complaint_radio.Name = "complaint_radio";
            this.complaint_radio.Size = new System.Drawing.Size(88, 20);
            this.complaint_radio.TabIndex = 40;
            this.complaint_radio.TabStop = true;
            this.complaint_radio.Text = "Complaint";
            this.complaint_radio.UseVisualStyleBackColor = true;
            this.complaint_radio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // suggestion_radio
            // 
            this.suggestion_radio.AutoSize = true;
            this.suggestion_radio.Location = new System.Drawing.Point(5, 7);
            this.suggestion_radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suggestion_radio.Name = "suggestion_radio";
            this.suggestion_radio.Size = new System.Drawing.Size(96, 20);
            this.suggestion_radio.TabIndex = 39;
            this.suggestion_radio.TabStop = true;
            this.suggestion_radio.Text = "Suggestion";
            this.suggestion_radio.UseVisualStyleBackColor = true;
            this.suggestion_radio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "Feedback type:";
            // 
            // compliment_radio
            // 
            this.compliment_radio.AutoSize = true;
            this.compliment_radio.Location = new System.Drawing.Point(233, 7);
            this.compliment_radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.compliment_radio.Name = "compliment_radio";
            this.compliment_radio.Size = new System.Drawing.Size(99, 20);
            this.compliment_radio.TabIndex = 41;
            this.compliment_radio.TabStop = true;
            this.compliment_radio.Text = "Compliment";
            this.compliment_radio.UseVisualStyleBackColor = true;
            this.compliment_radio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 42;
            this.label3.Text = "Comments:";
            // 
            // feedback_box
            // 
            this.feedback_box.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.feedback_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.feedback_box.Location = new System.Drawing.Point(77, 172);
            this.feedback_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.feedback_box.Name = "feedback_box";
            this.feedback_box.Size = new System.Drawing.Size(621, 126);
            this.feedback_box.TabIndex = 43;
            this.feedback_box.Text = "";
            this.feedback_box.TextChanged += new System.EventHandler(this.feedback_box_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 44;
            this.label4.Text = "Rating:";
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(162, 9);
            this.radio3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(35, 20);
            this.radio3.TabIndex = 47;
            this.radio3.TabStop = true;
            this.radio3.Text = "3";
            this.radio3.UseVisualStyleBackColor = true;
            this.radio3.CheckedChanged += new System.EventHandler(this.rating_CheckedChanged);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(84, 9);
            this.radio2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(35, 20);
            this.radio2.TabIndex = 46;
            this.radio2.TabStop = true;
            this.radio2.Text = "2";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.rating_CheckedChanged);
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(5, 9);
            this.radio1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(35, 20);
            this.radio1.TabIndex = 45;
            this.radio1.TabStop = true;
            this.radio1.Text = "1";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.rating_CheckedChanged);
            // 
            // radio5
            // 
            this.radio5.AutoSize = true;
            this.radio5.Location = new System.Drawing.Point(302, 9);
            this.radio5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio5.Name = "radio5";
            this.radio5.Size = new System.Drawing.Size(35, 20);
            this.radio5.TabIndex = 49;
            this.radio5.TabStop = true;
            this.radio5.Text = "5";
            this.radio5.UseVisualStyleBackColor = true;
            this.radio5.CheckedChanged += new System.EventHandler(this.rating_CheckedChanged);
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Location = new System.Drawing.Point(233, 9);
            this.radio4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(35, 20);
            this.radio4.TabIndex = 48;
            this.radio4.TabStop = true;
            this.radio4.Text = "4";
            this.radio4.UseVisualStyleBackColor = true;
            this.radio4.CheckedChanged += new System.EventHandler(this.rating_CheckedChanged);
            // 
            // submit_btn
            // 
            this.submit_btn.AutoRoundedCorners = true;
            this.submit_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.submit_btn.BorderRadius = 16;
            this.submit_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.submit_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.submit_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.submit_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.submit_btn.FillColor = System.Drawing.Color.Empty;
            this.submit_btn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.submit_btn.ForeColor = System.Drawing.Color.Black;
            this.submit_btn.Location = new System.Drawing.Point(335, 402);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(121, 35);
            this.submit_btn.TabIndex = 50;
            this.submit_btn.Text = "Submit";
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // type_group_box
            // 
            this.type_group_box.Controls.Add(this.suggestion_radio);
            this.type_group_box.Controls.Add(this.complaint_radio);
            this.type_group_box.Controls.Add(this.compliment_radio);
            this.type_group_box.Location = new System.Drawing.Point(243, 102);
            this.type_group_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.type_group_box.Name = "type_group_box";
            this.type_group_box.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.type_group_box.Size = new System.Drawing.Size(338, 28);
            this.type_group_box.TabIndex = 51;
            this.type_group_box.TabStop = false;
            // 
            // rating_group_box
            // 
            this.rating_group_box.Controls.Add(this.radio1);
            this.rating_group_box.Controls.Add(this.radio2);
            this.rating_group_box.Controls.Add(this.radio3);
            this.rating_group_box.Controls.Add(this.radio5);
            this.rating_group_box.Controls.Add(this.radio4);
            this.rating_group_box.Location = new System.Drawing.Point(77, 335);
            this.rating_group_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rating_group_box.Name = "rating_group_box";
            this.rating_group_box.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rating_group_box.Size = new System.Drawing.Size(354, 33);
            this.rating_group_box.TabIndex = 52;
            this.rating_group_box.TabStop = false;
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.rating_group_box);
            this.Controls.Add(this.type_group_box);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.feedback_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Feedback";
            this.Size = new System.Drawing.Size(773, 475);
            this.type_group_box.ResumeLayout(false);
            this.type_group_box.PerformLayout();
            this.rating_group_box.ResumeLayout(false);
            this.rating_group_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton complaint_radio;
        private System.Windows.Forms.RadioButton suggestion_radio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton compliment_radio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox feedback_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio5;
        private System.Windows.Forms.RadioButton radio4;
        private Guna.UI2.WinForms.Guna2Button submit_btn;
        private System.Windows.Forms.GroupBox type_group_box;
        private System.Windows.Forms.GroupBox rating_group_box;
    }
}
