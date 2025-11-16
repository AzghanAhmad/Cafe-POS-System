namespace DB_Project1
{
    partial class Customer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout_btn = new Guna.UI2.WinForms.Guna2Button();
            this.view_discount = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.feedback_btn = new Guna.UI2.WinForms.Guna2Button();
            this.view_products_btn = new Guna.UI2.WinForms.Guna2Button();
            this.place_order_button = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.view_order_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.view_order_btn);
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.view_discount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.feedback_btn);
            this.panel1.Controls.Add(this.view_products_btn);
            this.panel1.Controls.Add(this.place_order_button);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 594);
            this.panel1.TabIndex = 1;
            // 
            // logout_btn
            // 
            this.logout_btn.BorderColor = System.Drawing.Color.Transparent;
            this.logout_btn.BorderRadius = 14;
            this.logout_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.logout_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logout_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logout_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logout_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logout_btn.FillColor = System.Drawing.Color.Gainsboro;
            this.logout_btn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.logout_btn.ForeColor = System.Drawing.Color.Black;
            this.logout_btn.Location = new System.Drawing.Point(43, 540);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(144, 34);
            this.logout_btn.TabIndex = 10;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // view_discount
            // 
            this.view_discount.BackColor = System.Drawing.Color.LightSlateGray;
            this.view_discount.BorderColor = System.Drawing.Color.Transparent;
            this.view_discount.BorderRadius = 14;
            this.view_discount.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.view_discount.CheckedState.FillColor = System.Drawing.Color.White;
            this.view_discount.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.view_discount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.view_discount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.view_discount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.view_discount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.view_discount.FillColor = System.Drawing.Color.Gainsboro;
            this.view_discount.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.view_discount.ForeColor = System.Drawing.Color.Black;
            this.view_discount.Location = new System.Drawing.Point(17, 321);
            this.view_discount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.view_discount.Name = "view_discount";
            this.view_discount.Size = new System.Drawing.Size(237, 34);
            this.view_discount.TabIndex = 9;
            this.view_discount.Text = "View Discounts";
            this.view_discount.Click += new System.EventHandler(this.view_discount_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 41);
            this.label6.TabIndex = 8;
            this.label6.Text = "Portal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 41);
            this.label5.TabIndex = 7;
            this.label5.Text = "Customer\'s";
            // 
            // feedback_btn
            // 
            this.feedback_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.feedback_btn.BorderColor = System.Drawing.Color.Transparent;
            this.feedback_btn.BorderRadius = 14;
            this.feedback_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.feedback_btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.feedback_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.feedback_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.feedback_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.feedback_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.feedback_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.feedback_btn.FillColor = System.Drawing.Color.Gainsboro;
            this.feedback_btn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.feedback_btn.ForeColor = System.Drawing.Color.Black;
            this.feedback_btn.Location = new System.Drawing.Point(17, 448);
            this.feedback_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.feedback_btn.Name = "feedback_btn";
            this.feedback_btn.Size = new System.Drawing.Size(237, 34);
            this.feedback_btn.TabIndex = 3;
            this.feedback_btn.Text = "Provide Feedback";
            this.feedback_btn.Click += new System.EventHandler(this.feedback_btn_Click);
            // 
            // view_products_btn
            // 
            this.view_products_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.view_products_btn.BorderColor = System.Drawing.Color.Transparent;
            this.view_products_btn.BorderRadius = 14;
            this.view_products_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.view_products_btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.view_products_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.view_products_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.view_products_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.view_products_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.view_products_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.view_products_btn.FillColor = System.Drawing.Color.Gainsboro;
            this.view_products_btn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.view_products_btn.ForeColor = System.Drawing.Color.Black;
            this.view_products_btn.Location = new System.Drawing.Point(17, 252);
            this.view_products_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.view_products_btn.Name = "view_products_btn";
            this.view_products_btn.Size = new System.Drawing.Size(237, 34);
            this.view_products_btn.TabIndex = 1;
            this.view_products_btn.Text = "View Products";
            this.view_products_btn.Click += new System.EventHandler(this.view_products_btn_Click);
            // 
            // place_order_button
            // 
            this.place_order_button.BackColor = System.Drawing.Color.LightSlateGray;
            this.place_order_button.BorderRadius = 14;
            this.place_order_button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.place_order_button.CheckedState.FillColor = System.Drawing.Color.White;
            this.place_order_button.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.place_order_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.place_order_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.place_order_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.place_order_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.place_order_button.FillColor = System.Drawing.Color.Gainsboro;
            this.place_order_button.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.place_order_button.ForeColor = System.Drawing.Color.Black;
            this.place_order_button.Location = new System.Drawing.Point(17, 192);
            this.place_order_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.place_order_button.Name = "place_order_button";
            this.place_order_button.Size = new System.Drawing.Size(237, 34);
            this.place_order_button.TabIndex = 0;
            this.place_order_button.Text = "Place Order";
            this.place_order_button.Click += new System.EventHandler(this.place_order_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.phoneLabel);
            this.panel2.Controls.Add(this.emailLabel);
            this.panel2.Controls.Add(this.nameLabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(255, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 594);
            this.panel2.TabIndex = 2;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(140, 419);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(155, 52);
            this.phoneLabel.TabIndex = 6;
            this.phoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(140, 335);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(150, 52);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(140, 254);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(148, 52);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(392, 55);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Any Option";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(560, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cafe Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // view_order_btn
            // 
            this.view_order_btn.BackColor = System.Drawing.Color.LightSlateGray;
            this.view_order_btn.BorderColor = System.Drawing.Color.Transparent;
            this.view_order_btn.BorderRadius = 14;
            this.view_order_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.view_order_btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.view_order_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.view_order_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.view_order_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.view_order_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.view_order_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.view_order_btn.FillColor = System.Drawing.Color.Gainsboro;
            this.view_order_btn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.view_order_btn.ForeColor = System.Drawing.Color.Black;
            this.view_order_btn.Location = new System.Drawing.Point(17, 382);
            this.view_order_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.view_order_btn.Name = "view_order_btn";
            this.view_order_btn.Size = new System.Drawing.Size(237, 34);
            this.view_order_btn.TabIndex = 11;
            this.view_order_btn.Text = "View Orders";
            this.view_order_btn.Click += new System.EventHandler(this.view_order_btn_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1137, 618);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Customer";
            this.Text = "Customer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button place_order_button;
        private Guna.UI2.WinForms.Guna2Button feedback_btn;
        private Guna.UI2.WinForms.Guna2Button view_products_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button view_discount;
        private Guna.UI2.WinForms.Guna2Button logout_btn;
        private Guna.UI2.WinForms.Guna2Button view_order_btn;
    }
}