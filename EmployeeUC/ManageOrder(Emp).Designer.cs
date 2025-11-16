namespace DB_Project1.EmployeeUC
{
    partial class ManageOrder_Emp_
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
            this.ViewpendingOrders = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_customerassociated = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView_orderlist = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.ViewOrdersButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.DeleteAllOrdersButton = new System.Windows.Forms.Button();
            this.EditOrderButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserDataGrid_OrderitemsData = new System.Windows.Forms.DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.button_totalpendingorders = new System.Windows.Forms.Button();
            this.ViewProcessingOrder_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customerassociated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orderlist)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid_OrderitemsData)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewpendingOrders
            // 
            this.ViewpendingOrders.BackColor = System.Drawing.Color.LightSlateGray;
            this.ViewpendingOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewpendingOrders.Location = new System.Drawing.Point(14, 344);
            this.ViewpendingOrders.Name = "ViewpendingOrders";
            this.ViewpendingOrders.Size = new System.Drawing.Size(186, 34);
            this.ViewpendingOrders.TabIndex = 33;
            this.ViewpendingOrders.Text = "Pending Orders";
            this.ViewpendingOrders.UseVisualStyleBackColor = false;
            this.ViewpendingOrders.Click += new System.EventHandler(this.ViewpendingOrders_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Status:";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox5.Location = new System.Drawing.Point(14, 291);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(164, 22);
            this.textBox5.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Date: (MM/DD/YYYY)";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox4.Location = new System.Drawing.Point(14, 233);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 22);
            this.textBox4.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Employee ID:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.Location = new System.Drawing.Point(14, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 22);
            this.textBox3.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Customer\'s Associated:";
            // 
            // dataGridView_customerassociated
            // 
            this.dataGridView_customerassociated.AllowUserToAddRows = false;
            this.dataGridView_customerassociated.AllowUserToDeleteRows = false;
            this.dataGridView_customerassociated.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView_customerassociated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_customerassociated.Location = new System.Drawing.Point(209, 253);
            this.dataGridView_customerassociated.Name = "dataGridView_customerassociated";
            this.dataGridView_customerassociated.ReadOnly = true;
            this.dataGridView_customerassociated.RowHeadersWidth = 30;
            this.dataGridView_customerassociated.RowTemplate.Height = 24;
            this.dataGridView_customerassociated.Size = new System.Drawing.Size(267, 163);
            this.dataGridView_customerassociated.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Order ID:";
            // 
            // dataGridView_orderlist
            // 
            this.dataGridView_orderlist.AllowUserToAddRows = false;
            this.dataGridView_orderlist.AllowUserToDeleteRows = false;
            this.dataGridView_orderlist.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView_orderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_orderlist.Location = new System.Drawing.Point(194, 58);
            this.dataGridView_orderlist.Name = "dataGridView_orderlist";
            this.dataGridView_orderlist.ReadOnly = true;
            this.dataGridView_orderlist.RowHeadersWidth = 30;
            this.dataGridView_orderlist.RowTemplate.Height = 24;
            this.dataGridView_orderlist.Size = new System.Drawing.Size(282, 163);
            this.dataGridView_orderlist.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Customer ID:";
            // 
            // ViewOrdersButton
            // 
            this.ViewOrdersButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.ViewOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewOrdersButton.Location = new System.Drawing.Point(231, 424);
            this.ViewOrdersButton.Name = "ViewOrdersButton";
            this.ViewOrdersButton.Size = new System.Drawing.Size(225, 34);
            this.ViewOrdersButton.TabIndex = 17;
            this.ViewOrdersButton.Text = "Orders from Last Month";
            this.ViewOrdersButton.UseVisualStyleBackColor = false;
            this.ViewOrdersButton.Click += new System.EventHandler(this.ViewOrdersButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order List:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(14, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 22);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(17, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 14;
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.DeleteOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteOrderButton.Location = new System.Drawing.Point(34, 421);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(77, 34);
            this.DeleteOrderButton.TabIndex = 3;
            this.DeleteOrderButton.Text = "Delete";
            this.DeleteOrderButton.UseVisualStyleBackColor = false;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // DeleteAllOrdersButton
            // 
            this.DeleteAllOrdersButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.DeleteAllOrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAllOrdersButton.Location = new System.Drawing.Point(156, 421);
            this.DeleteAllOrdersButton.Name = "DeleteAllOrdersButton";
            this.DeleteAllOrdersButton.Size = new System.Drawing.Size(103, 34);
            this.DeleteAllOrdersButton.TabIndex = 2;
            this.DeleteAllOrdersButton.Text = "Delete All";
            this.DeleteAllOrdersButton.UseVisualStyleBackColor = false;
            this.DeleteAllOrdersButton.Click += new System.EventHandler(this.DeleteAllOrdersButton_Click);
            // 
            // EditOrderButton
            // 
            this.EditOrderButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.EditOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditOrderButton.Location = new System.Drawing.Point(156, 373);
            this.EditOrderButton.Name = "EditOrderButton";
            this.EditOrderButton.Size = new System.Drawing.Size(77, 34);
            this.EditOrderButton.TabIndex = 1;
            this.EditOrderButton.Text = "Edit";
            this.EditOrderButton.UseVisualStyleBackColor = false;
            this.EditOrderButton.Click += new System.EventHandler(this.EditOrderButton_Click);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.AddOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrderButton.Location = new System.Drawing.Point(34, 373);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(77, 34);
            this.AddOrderButton.TabIndex = 0;
            this.AddOrderButton.Text = "Add";
            this.AddOrderButton.UseVisualStyleBackColor = false;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.DeleteOrderButton);
            this.guna2Panel1.Controls.Add(this.DeleteAllOrdersButton);
            this.guna2Panel1.Controls.Add(this.UserDataGrid_OrderitemsData);
            this.guna2Panel1.Controls.Add(this.EditOrderButton);
            this.guna2Panel1.Controls.Add(this.AddOrderButton);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(271, 469);
            this.guna2Panel1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Order Items:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Manage Orders";
            // 
            // UserDataGrid_OrderitemsData
            // 
            this.UserDataGrid_OrderitemsData.AllowUserToAddRows = false;
            this.UserDataGrid_OrderitemsData.AllowUserToDeleteRows = false;
            this.UserDataGrid_OrderitemsData.BackgroundColor = System.Drawing.Color.Lavender;
            this.UserDataGrid_OrderitemsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGrid_OrderitemsData.Location = new System.Drawing.Point(34, 110);
            this.UserDataGrid_OrderitemsData.Name = "UserDataGrid_OrderitemsData";
            this.UserDataGrid_OrderitemsData.ReadOnly = true;
            this.UserDataGrid_OrderitemsData.RowHeadersWidth = 20;
            this.UserDataGrid_OrderitemsData.RowTemplate.Height = 24;
            this.UserDataGrid_OrderitemsData.Size = new System.Drawing.Size(223, 244);
            this.UserDataGrid_OrderitemsData.TabIndex = 3;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.guna2Panel2.Controls.Add(this.button_totalpendingorders);
            this.guna2Panel2.Controls.Add(this.ViewProcessingOrder_button);
            this.guna2Panel2.Controls.Add(this.ViewpendingOrders);
            this.guna2Panel2.Controls.Add(this.label8);
            this.guna2Panel2.Controls.Add(this.textBox5);
            this.guna2Panel2.Controls.Add(this.label7);
            this.guna2Panel2.Controls.Add(this.textBox4);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.textBox3);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.dataGridView_customerassociated);
            this.guna2Panel2.Controls.Add(this.label11);
            this.guna2Panel2.Controls.Add(this.dataGridView_orderlist);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.ViewOrdersButton);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.textBox2);
            this.guna2Panel2.Controls.Add(this.textBox1);
            this.guna2Panel2.Location = new System.Drawing.Point(280, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(490, 469);
            this.guna2Panel2.TabIndex = 7;
            // 
            // button_totalpendingorders
            // 
            this.button_totalpendingorders.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_totalpendingorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_totalpendingorders.Location = new System.Drawing.Point(14, 424);
            this.button_totalpendingorders.Name = "button_totalpendingorders";
            this.button_totalpendingorders.Size = new System.Drawing.Size(211, 34);
            this.button_totalpendingorders.TabIndex = 35;
            this.button_totalpendingorders.Text = "Total Pending Orders";
            this.button_totalpendingorders.UseVisualStyleBackColor = false;
            this.button_totalpendingorders.Click += new System.EventHandler(this.button_totalpendingorders_Click);
            // 
            // ViewProcessingOrder_button
            // 
            this.ViewProcessingOrder_button.BackColor = System.Drawing.Color.LightSlateGray;
            this.ViewProcessingOrder_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewProcessingOrder_button.Location = new System.Drawing.Point(14, 384);
            this.ViewProcessingOrder_button.Name = "ViewProcessingOrder_button";
            this.ViewProcessingOrder_button.Size = new System.Drawing.Size(186, 34);
            this.ViewProcessingOrder_button.TabIndex = 34;
            this.ViewProcessingOrder_button.Text = "Processing Orders";
            this.ViewProcessingOrder_button.UseVisualStyleBackColor = false;
            this.ViewProcessingOrder_button.Click += new System.EventHandler(this.ViewProcessingOrder_button_Click);
            // 
            // ManageOrder_Emp_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "ManageOrder_Emp_";
            this.Size = new System.Drawing.Size(773, 475);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customerassociated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orderlist)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid_OrderitemsData)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewpendingOrders;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_customerassociated;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView_orderlist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ViewOrdersButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DeleteOrderButton;
        private System.Windows.Forms.Button DeleteAllOrdersButton;
        private System.Windows.Forms.Button EditOrderButton;
        private System.Windows.Forms.Button AddOrderButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView UserDataGrid_OrderitemsData;
        private System.Windows.Forms.Button ViewProcessingOrder_button;
        private System.Windows.Forms.Button button_totalpendingorders;
    }
}
