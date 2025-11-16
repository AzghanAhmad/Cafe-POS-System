namespace DB_Project1.EmployeeUC
{
    partial class ManageInventory
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ProductsDataGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StockLessThan10 = new System.Windows.Forms.Button();
            this.InventoryDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteAllInventory = new System.Windows.Forms.Button();
            this.EditInventory = new System.Windows.Forms.Button();
            this.AddInventory = new System.Windows.Forms.Button();
            this.DeleteInventory = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.InventoryAllDetails_Button = new System.Windows.Forms.Button();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.guna2Panel2.Controls.Add(this.InventoryAllDetails_Button);
            this.guna2Panel2.Controls.Add(this.ProductsDataGrid);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.label8);
            this.guna2Panel2.Controls.Add(this.StockLessThan10);
            this.guna2Panel2.Controls.Add(this.InventoryDataGrid);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Location = new System.Drawing.Point(280, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(490, 469);
            this.guna2Panel2.TabIndex = 5;
            // 
            // ProductsDataGrid
            // 
            this.ProductsDataGrid.AllowUserToAddRows = false;
            this.ProductsDataGrid.AllowUserToDeleteRows = false;
            this.ProductsDataGrid.BackgroundColor = System.Drawing.Color.Lavender;
            this.ProductsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGrid.Location = new System.Drawing.Point(261, 60);
            this.ProductsDataGrid.Name = "ProductsDataGrid";
            this.ProductsDataGrid.ReadOnly = true;
            this.ProductsDataGrid.RowHeadersWidth = 51;
            this.ProductsDataGrid.RowTemplate.Height = 24;
            this.ProductsDataGrid.Size = new System.Drawing.Size(220, 263);
            this.ProductsDataGrid.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Products Data:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(289, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Check Inventory Information:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // StockLessThan10
            // 
            this.StockLessThan10.BackColor = System.Drawing.Color.LightSlateGray;
            this.StockLessThan10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockLessThan10.Location = new System.Drawing.Point(18, 382);
            this.StockLessThan10.Name = "StockLessThan10";
            this.StockLessThan10.Size = new System.Drawing.Size(197, 34);
            this.StockLessThan10.TabIndex = 17;
            this.StockLessThan10.Text = "Stock less than 10";
            this.StockLessThan10.UseVisualStyleBackColor = false;
            this.StockLessThan10.Click += new System.EventHandler(this.StockLessThan10_Click);
            // 
            // InventoryDataGrid
            // 
            this.InventoryDataGrid.AllowUserToAddRows = false;
            this.InventoryDataGrid.AllowUserToDeleteRows = false;
            this.InventoryDataGrid.BackgroundColor = System.Drawing.Color.Lavender;
            this.InventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryDataGrid.Location = new System.Drawing.Point(15, 60);
            this.InventoryDataGrid.Name = "InventoryDataGrid";
            this.InventoryDataGrid.ReadOnly = true;
            this.InventoryDataGrid.RowHeadersWidth = 51;
            this.InventoryDataGrid.RowTemplate.Height = 24;
            this.InventoryDataGrid.Size = new System.Drawing.Size(220, 263);
            this.InventoryDataGrid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inventory Data:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.Location = new System.Drawing.Point(95, 194);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(95, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(95, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 0;
            // 
            // DeleteAllInventory
            // 
            this.DeleteAllInventory.BackColor = System.Drawing.Color.LightSlateGray;
            this.DeleteAllInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAllInventory.Location = new System.Drawing.Point(156, 421);
            this.DeleteAllInventory.Name = "DeleteAllInventory";
            this.DeleteAllInventory.Size = new System.Drawing.Size(103, 34);
            this.DeleteAllInventory.TabIndex = 2;
            this.DeleteAllInventory.Text = "Delete All";
            this.DeleteAllInventory.UseVisualStyleBackColor = false;
            this.DeleteAllInventory.Click += new System.EventHandler(this.DeleteAllInventory_Click);
            // 
            // EditInventory
            // 
            this.EditInventory.BackColor = System.Drawing.Color.LightSlateGray;
            this.EditInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditInventory.Location = new System.Drawing.Point(156, 364);
            this.EditInventory.Name = "EditInventory";
            this.EditInventory.Size = new System.Drawing.Size(77, 34);
            this.EditInventory.TabIndex = 1;
            this.EditInventory.Text = "Edit";
            this.EditInventory.UseVisualStyleBackColor = false;
            this.EditInventory.Click += new System.EventHandler(this.EditInventory_Click);
            // 
            // AddInventory
            // 
            this.AddInventory.BackColor = System.Drawing.Color.LightSlateGray;
            this.AddInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddInventory.Location = new System.Drawing.Point(34, 364);
            this.AddInventory.Name = "AddInventory";
            this.AddInventory.Size = new System.Drawing.Size(77, 34);
            this.AddInventory.TabIndex = 0;
            this.AddInventory.Text = "Add";
            this.AddInventory.UseVisualStyleBackColor = false;
            this.AddInventory.Click += new System.EventHandler(this.AddInventory_Click);
            // 
            // DeleteInventory
            // 
            this.DeleteInventory.BackColor = System.Drawing.Color.LightSlateGray;
            this.DeleteInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteInventory.Location = new System.Drawing.Point(34, 421);
            this.DeleteInventory.Name = "DeleteInventory";
            this.DeleteInventory.Size = new System.Drawing.Size(77, 34);
            this.DeleteInventory.TabIndex = 3;
            this.DeleteInventory.Text = "Delete";
            this.DeleteInventory.UseVisualStyleBackColor = false;
            this.DeleteInventory.Click += new System.EventHandler(this.DeleteInventory_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.guna2Panel1.Controls.Add(this.dateTimePicker1);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.textBox3);
            this.guna2Panel1.Controls.Add(this.textBox2);
            this.guna2Panel1.Controls.Add(this.textBox1);
            this.guna2Panel1.Controls.Add(this.DeleteInventory);
            this.guna2Panel1.Controls.Add(this.DeleteAllInventory);
            this.guna2Panel1.Controls.Add(this.EditInventory);
            this.guna2Panel1.Controls.Add(this.AddInventory);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(271, 469);
            this.guna2Panel1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Enter Details:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Inventory ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Product ID:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 257);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // InventoryAllDetails_Button
            // 
            this.InventoryAllDetails_Button.BackColor = System.Drawing.Color.LightSlateGray;
            this.InventoryAllDetails_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryAllDetails_Button.Location = new System.Drawing.Point(223, 382);
            this.InventoryAllDetails_Button.Name = "InventoryAllDetails_Button";
            this.InventoryAllDetails_Button.Size = new System.Drawing.Size(197, 34);
            this.InventoryAllDetails_Button.TabIndex = 21;
            this.InventoryAllDetails_Button.Text = "Inventory All Details";
            this.InventoryAllDetails_Button.UseVisualStyleBackColor = false;
            this.InventoryAllDetails_Button.Click += new System.EventHandler(this.InventoryAllDetails_Button_Click);
            // 
            // ManageInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ManageInventory";
            this.Size = new System.Drawing.Size(773, 475);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.DataGridView ProductsDataGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button StockLessThan10;
        private System.Windows.Forms.DataGridView InventoryDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DeleteAllInventory;
        private System.Windows.Forms.Button EditInventory;
        private System.Windows.Forms.Button AddInventory;
        private System.Windows.Forms.Button DeleteInventory;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button InventoryAllDetails_Button;
    }
}
