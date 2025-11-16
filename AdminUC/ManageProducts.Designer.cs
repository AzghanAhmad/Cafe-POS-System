namespace DB_Project1.AdminUC
{
    partial class ManageProducts
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
            this.UserDataGrid_ProductDetails = new System.Windows.Forms.DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.button_highlyRatedProducts = new System.Windows.Forms.Button();
            this.button_expensivecategories = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.DeleteAllProductButton = new System.Windows.Forms.Button();
            this.EditProductButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.TotalSalesButton = new System.Windows.Forms.Button();
            this.button_total_productin_category = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid_ProductDetails)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserDataGrid_ProductDetails
            // 
            this.UserDataGrid_ProductDetails.AllowUserToAddRows = false;
            this.UserDataGrid_ProductDetails.AllowUserToDeleteRows = false;
            this.UserDataGrid_ProductDetails.BackgroundColor = System.Drawing.Color.Lavender;
            this.UserDataGrid_ProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGrid_ProductDetails.Location = new System.Drawing.Point(15, 52);
            this.UserDataGrid_ProductDetails.Name = "UserDataGrid_ProductDetails";
            this.UserDataGrid_ProductDetails.ReadOnly = true;
            this.UserDataGrid_ProductDetails.RowHeadersWidth = 51;
            this.UserDataGrid_ProductDetails.RowTemplate.Height = 24;
            this.UserDataGrid_ProductDetails.Size = new System.Drawing.Size(460, 284);
            this.UserDataGrid_ProductDetails.TabIndex = 3;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.guna2Panel2.Controls.Add(this.button_total_productin_category);
            this.guna2Panel2.Controls.Add(this.TotalSalesButton);
            this.guna2Panel2.Controls.Add(this.button_highlyRatedProducts);
            this.guna2Panel2.Controls.Add(this.button_expensivecategories);
            this.guna2Panel2.Controls.Add(this.label8);
            this.guna2Panel2.Controls.Add(this.UserDataGrid_ProductDetails);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Location = new System.Drawing.Point(280, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(490, 469);
            this.guna2Panel2.TabIndex = 3;
            // 
            // button_highlyRatedProducts
            // 
            this.button_highlyRatedProducts.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_highlyRatedProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_highlyRatedProducts.Location = new System.Drawing.Point(4, 422);
            this.button_highlyRatedProducts.Name = "button_highlyRatedProducts";
            this.button_highlyRatedProducts.Size = new System.Drawing.Size(234, 34);
            this.button_highlyRatedProducts.TabIndex = 24;
            this.button_highlyRatedProducts.Text = "Less Remainig Product";
            this.button_highlyRatedProducts.UseVisualStyleBackColor = false;
            this.button_highlyRatedProducts.Click += new System.EventHandler(this.button_highlyRatedProducts_Click);
            // 
            // button_expensivecategories
            // 
            this.button_expensivecategories.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_expensivecategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_expensivecategories.Location = new System.Drawing.Point(2, 382);
            this.button_expensivecategories.Name = "button_expensivecategories";
            this.button_expensivecategories.Size = new System.Drawing.Size(260, 34);
            this.button_expensivecategories.TabIndex = 23;
            this.button_expensivecategories.Text = "Average Price of Categories";
            this.button_expensivecategories.UseVisualStyleBackColor = false;
            this.button_expensivecategories.Click += new System.EventHandler(this.button_expensivecategories_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Check Products Information:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Details:";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.guna2Panel1.Controls.Add(this.label11);
            this.guna2Panel1.Controls.Add(this.textBox8);
            this.guna2Panel1.Controls.Add(this.label10);
            this.guna2Panel1.Controls.Add(this.textBox7);
            this.guna2Panel1.Controls.Add(this.textBox6);
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.textBox5);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.textBox4);
            this.guna2Panel1.Controls.Add(this.textBox3);
            this.guna2Panel1.Controls.Add(this.textBox2);
            this.guna2Panel1.Controls.Add(this.textBox1);
            this.guna2Panel1.Controls.Add(this.DeleteProductButton);
            this.guna2Panel1.Controls.Add(this.DeleteAllProductButton);
            this.guna2Panel1.Controls.Add(this.EditProductButton);
            this.guna2Panel1.Controls.Add(this.AddProductButton);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(271, 469);
            this.guna2Panel1.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Price:";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox8.Location = new System.Drawing.Point(95, 340);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(164, 22);
            this.textBox8.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Product ID:";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox7.Location = new System.Drawing.Point(95, 309);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(164, 22);
            this.textBox7.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox6.Location = new System.Drawing.Point(95, 268);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(164, 22);
            this.textBox6.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Stock Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Enter Details:";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox5.Location = new System.Drawing.Point(95, 229);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(164, 22);
            this.textBox5.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Admin ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Supplier ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Category ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox4.Location = new System.Drawing.Point(95, 186);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.Location = new System.Drawing.Point(95, 146);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(95, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(95, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 0;
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.DeleteProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProductButton.Location = new System.Drawing.Point(34, 421);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(77, 34);
            this.DeleteProductButton.TabIndex = 3;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = false;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // DeleteAllProductButton
            // 
            this.DeleteAllProductButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.DeleteAllProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAllProductButton.Location = new System.Drawing.Point(156, 421);
            this.DeleteAllProductButton.Name = "DeleteAllProductButton";
            this.DeleteAllProductButton.Size = new System.Drawing.Size(103, 34);
            this.DeleteAllProductButton.TabIndex = 2;
            this.DeleteAllProductButton.Text = "Delete All";
            this.DeleteAllProductButton.UseVisualStyleBackColor = false;
            this.DeleteAllProductButton.Click += new System.EventHandler(this.DeleteAllProductButton_Click);
            // 
            // EditProductButton
            // 
            this.EditProductButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.EditProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProductButton.Location = new System.Drawing.Point(156, 372);
            this.EditProductButton.Name = "EditProductButton";
            this.EditProductButton.Size = new System.Drawing.Size(77, 34);
            this.EditProductButton.TabIndex = 1;
            this.EditProductButton.Text = "Edit";
            this.EditProductButton.UseVisualStyleBackColor = false;
            this.EditProductButton.Click += new System.EventHandler(this.EditProductButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.AddProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.Location = new System.Drawing.Point(34, 372);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(77, 34);
            this.AddProductButton.TabIndex = 0;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // TotalSalesButton
            // 
            this.TotalSalesButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.TotalSalesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalesButton.Location = new System.Drawing.Point(259, 382);
            this.TotalSalesButton.Name = "TotalSalesButton";
            this.TotalSalesButton.Size = new System.Drawing.Size(234, 34);
            this.TotalSalesButton.TabIndex = 25;
            this.TotalSalesButton.Text = "Total Sales for Products";
            this.TotalSalesButton.UseVisualStyleBackColor = false;
            this.TotalSalesButton.Click += new System.EventHandler(this.TotalSalesButton_Click);
            // 
            // button_total_productin_category
            // 
            this.button_total_productin_category.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_total_productin_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_total_productin_category.Location = new System.Drawing.Point(233, 422);
            this.button_total_productin_category.Name = "button_total_productin_category";
            this.button_total_productin_category.Size = new System.Drawing.Size(260, 34);
            this.button_total_productin_category.TabIndex = 26;
            this.button_total_productin_category.Text = "Total Products in Category";
            this.button_total_productin_category.UseVisualStyleBackColor = false;
            this.button_total_productin_category.Click += new System.EventHandler(this.button_total_productin_category_Click);
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ManageProducts";
            this.Size = new System.Drawing.Size(773, 475);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid_ProductDetails)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView UserDataGrid_ProductDetails;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button DeleteAllProductButton;
        private System.Windows.Forms.Button EditProductButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_expensivecategories;
        private System.Windows.Forms.Button button_highlyRatedProducts;
        private System.Windows.Forms.Button TotalSalesButton;
        private System.Windows.Forms.Button button_total_productin_category;
    }
}
