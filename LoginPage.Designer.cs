namespace DB_Project1
{
    partial class LoginPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.admin_radio = new System.Windows.Forms.RadioButton();
            this.employee_radio = new System.Windows.Forms.RadioButton();
            this.customer_radio = new System.Windows.Forms.RadioButton();
            this.text_email = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.signup_button = new System.Windows.Forms.Button();
            this.lblout = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAFE MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Log in as:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // admin_radio
            // 
            this.admin_radio.AutoSize = true;
            this.admin_radio.Location = new System.Drawing.Point(249, 120);
            this.admin_radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_radio.Name = "admin_radio";
            this.admin_radio.Size = new System.Drawing.Size(66, 20);
            this.admin_radio.TabIndex = 4;
            this.admin_radio.TabStop = true;
            this.admin_radio.Text = "Admin";
            this.admin_radio.UseVisualStyleBackColor = true;
            // 
            // employee_radio
            // 
            this.employee_radio.AutoSize = true;
            this.employee_radio.Location = new System.Drawing.Point(340, 119);
            this.employee_radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employee_radio.Name = "employee_radio";
            this.employee_radio.Size = new System.Drawing.Size(90, 20);
            this.employee_radio.TabIndex = 5;
            this.employee_radio.TabStop = true;
            this.employee_radio.Text = "Employee";
            this.employee_radio.UseVisualStyleBackColor = true;
            // 
            // customer_radio
            // 
            this.customer_radio.AutoSize = true;
            this.customer_radio.Location = new System.Drawing.Point(448, 119);
            this.customer_radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customer_radio.Name = "customer_radio";
            this.customer_radio.Size = new System.Drawing.Size(85, 20);
            this.customer_radio.TabIndex = 6;
            this.customer_radio.TabStop = true;
            this.customer_radio.Text = "Customer";
            this.customer_radio.UseVisualStyleBackColor = true;
            // 
            // text_email
            // 
            this.text_email.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_email.Location = new System.Drawing.Point(286, 163);
            this.text_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(216, 22);
            this.text_email.TabIndex = 7;
            // 
            // text_password
            // 
            this.text_password.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_password.Location = new System.Drawing.Point(286, 203);
            this.text_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '*';
            this.text_password.Size = new System.Drawing.Size(216, 22);
            this.text_password.TabIndex = 8;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.LightSlateGray;
            this.login_button.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(340, 265);
            this.login_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(87, 35);
            this.login_button.TabIndex = 9;
            this.login_button.Text = "Log in";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // signup_button
            // 
            this.signup_button.BackColor = System.Drawing.Color.LightSteelBlue;
            this.signup_button.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_button.Location = new System.Drawing.Point(433, 303);
            this.signup_button.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(90, 35);
            this.signup_button.TabIndex = 10;
            this.signup_button.Text = "Sign up";
            this.signup_button.UseVisualStyleBackColor = false;
            this.signup_button.Click += new System.EventHandler(this.logup_button_Click);
            // 
            // lblout
            // 
            this.lblout.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblout.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblout.Location = new System.Drawing.Point(278, 241);
            this.lblout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblout.Name = "lblout";
            this.lblout.Size = new System.Drawing.Size(191, 20);
            this.lblout.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSlateGray;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(286, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 40);
            this.label5.TabIndex = 12;
            this.label5.Text = "LOG IN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Don\'t have an account?";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblout);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.customer_radio);
            this.Controls.Add(this.employee_radio);
            this.Controls.Add(this.admin_radio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginPage";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton admin_radio;
        private System.Windows.Forms.RadioButton employee_radio;
        private System.Windows.Forms.RadioButton customer_radio;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.TextBox lblout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

