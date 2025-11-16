namespace DB_Project1.AllFunction
{
    partial class Payment
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
            this.card_radio = new System.Windows.Forms.RadioButton();
            this.cash_radio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.card_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cvv_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.expiry_month_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.expiry_year_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.card_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.confirm_btn = new Guna.UI2.WinForms.Guna2Button();
            this.back_btn = new Guna.UI2.WinForms.Guna2Button();
            this.payment_summary_btn = new Guna.UI2.WinForms.Guna2Button();
            this.card_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // card_radio
            // 
            this.card_radio.AutoSize = true;
            this.card_radio.Location = new System.Drawing.Point(510, 163);
            this.card_radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.card_radio.Name = "card_radio";
            this.card_radio.Size = new System.Drawing.Size(114, 24);
            this.card_radio.TabIndex = 8;
            this.card_radio.TabStop = true;
            this.card_radio.Text = "Credit Card";
            this.card_radio.UseVisualStyleBackColor = true;
            this.card_radio.CheckedChanged += new System.EventHandler(this.card_radio_CheckedChanged);
            // 
            // cash_radio
            // 
            this.cash_radio.AutoSize = true;
            this.cash_radio.Location = new System.Drawing.Point(412, 163);
            this.cash_radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cash_radio.Name = "cash_radio";
            this.cash_radio.Size = new System.Drawing.Size(71, 24);
            this.cash_radio.TabIndex = 7;
            this.cash_radio.TabStop = true;
            this.cash_radio.Text = "Cash";
            this.cash_radio.UseVisualStyleBackColor = true;
            this.cash_radio.CheckedChanged += new System.EventHandler(this.cash_radio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select payment method:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Payment";
            // 
            // card_panel
            // 
            this.card_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card_panel.Controls.Add(this.label3);
            this.card_panel.Controls.Add(this.cvv_text);
            this.card_panel.Controls.Add(this.expiry_month_text);
            this.card_panel.Controls.Add(this.label6);
            this.card_panel.Controls.Add(this.label7);
            this.card_panel.Controls.Add(this.expiry_year_text);
            this.card_panel.Controls.Add(this.card_text);
            this.card_panel.Controls.Add(this.label5);
            this.card_panel.Location = new System.Drawing.Point(18, 215);
            this.card_panel.Name = "card_panel";
            this.card_panel.Size = new System.Drawing.Size(835, 265);
            this.card_panel.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "CVV:";
            // 
            // cvv_text
            // 
            this.cvv_text.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cvv_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cvv_text.DefaultText = "";
            this.cvv_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cvv_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cvv_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cvv_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cvv_text.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.cvv_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cvv_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cvv_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cvv_text.Location = new System.Drawing.Point(264, 186);
            this.cvv_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cvv_text.Name = "cvv_text";
            this.cvv_text.PasswordChar = '\0';
            this.cvv_text.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.cvv_text.PlaceholderText = "XXX";
            this.cvv_text.SelectedText = "";
            this.cvv_text.Size = new System.Drawing.Size(214, 30);
            this.cvv_text.TabIndex = 18;
            // 
            // expiry_month_text
            // 
            this.expiry_month_text.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.expiry_month_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expiry_month_text.DefaultText = "";
            this.expiry_month_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.expiry_month_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.expiry_month_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expiry_month_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expiry_month_text.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.expiry_month_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expiry_month_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expiry_month_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expiry_month_text.Location = new System.Drawing.Point(264, 78);
            this.expiry_month_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expiry_month_text.Name = "expiry_month_text";
            this.expiry_month_text.PasswordChar = '\0';
            this.expiry_month_text.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.expiry_month_text.PlaceholderText = "XX";
            this.expiry_month_text.SelectedText = "";
            this.expiry_month_text.Size = new System.Drawing.Size(214, 30);
            this.expiry_month_text.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Expiry year:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Expiry month:";
            // 
            // expiry_year_text
            // 
            this.expiry_year_text.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.expiry_year_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expiry_year_text.DefaultText = "";
            this.expiry_year_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.expiry_year_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.expiry_year_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expiry_year_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.expiry_year_text.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.expiry_year_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expiry_year_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expiry_year_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.expiry_year_text.Location = new System.Drawing.Point(264, 135);
            this.expiry_year_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expiry_year_text.Name = "expiry_year_text";
            this.expiry_year_text.PasswordChar = '\0';
            this.expiry_year_text.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.expiry_year_text.PlaceholderText = "XXXX";
            this.expiry_year_text.SelectedText = "";
            this.expiry_year_text.Size = new System.Drawing.Size(214, 30);
            this.expiry_year_text.TabIndex = 14;
            // 
            // card_text
            // 
            this.card_text.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.card_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.card_text.DefaultText = "";
            this.card_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.card_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.card_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.card_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.card_text.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.card_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.card_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.card_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.card_text.Location = new System.Drawing.Point(264, 25);
            this.card_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.card_text.Name = "card_text";
            this.card_text.PasswordChar = '\0';
            this.card_text.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.card_text.PlaceholderText = "XXXX XXXX XXXX XXXX";
            this.card_text.SelectedText = "";
            this.card_text.Size = new System.Drawing.Size(214, 30);
            this.card_text.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Card number:";
            // 
            // confirm_btn
            // 
            this.confirm_btn.AutoRoundedCorners = true;
            this.confirm_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.confirm_btn.BorderRadius = 21;
            this.confirm_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.confirm_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.confirm_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirm_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.confirm_btn.FillColor = System.Drawing.Color.LightSlateGray;
            this.confirm_btn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.confirm_btn.ForeColor = System.Drawing.Color.Black;
            this.confirm_btn.Location = new System.Drawing.Point(479, 510);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(136, 44);
            this.confirm_btn.TabIndex = 20;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.AutoRoundedCorners = true;
            this.back_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.back_btn.BorderRadius = 21;
            this.back_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.back_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.back_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.back_btn.FillColor = System.Drawing.Color.LightSlateGray;
            this.back_btn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.back_btn.ForeColor = System.Drawing.Color.Black;
            this.back_btn.Location = new System.Drawing.Point(251, 510);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(136, 44);
            this.back_btn.TabIndex = 21;
            this.back_btn.Text = "Back";
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // payment_summary_btn
            // 
            this.payment_summary_btn.AutoRoundedCorners = true;
            this.payment_summary_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.payment_summary_btn.BorderRadius = 21;
            this.payment_summary_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.payment_summary_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.payment_summary_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.payment_summary_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.payment_summary_btn.FillColor = System.Drawing.Color.LightSlateGray;
            this.payment_summary_btn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.payment_summary_btn.ForeColor = System.Drawing.Color.Black;
            this.payment_summary_btn.Location = new System.Drawing.Point(626, 18);
            this.payment_summary_btn.Name = "payment_summary_btn";
            this.payment_summary_btn.Size = new System.Drawing.Size(227, 44);
            this.payment_summary_btn.TabIndex = 22;
            this.payment_summary_btn.Text = "Payment Summary";
            this.payment_summary_btn.Click += new System.EventHandler(this.payment_summary_btn_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.payment_summary_btn);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.card_panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.card_radio);
            this.Controls.Add(this.cash_radio);
            this.Controls.Add(this.label2);
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(870, 594);
            this.card_panel.ResumeLayout(false);
            this.card_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton card_radio;
        private System.Windows.Forms.RadioButton cash_radio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel card_panel;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox cvv_text;
        private Guna.UI2.WinForms.Guna2TextBox expiry_month_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox expiry_year_text;
        private Guna.UI2.WinForms.Guna2TextBox card_text;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button confirm_btn;
        private Guna.UI2.WinForms.Guna2Button back_btn;
        private Guna.UI2.WinForms.Guna2Button payment_summary_btn;
    }
}
