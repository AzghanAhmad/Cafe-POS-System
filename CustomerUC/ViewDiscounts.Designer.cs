namespace DB_Project1.CustomerUC
{
    partial class ViewDiscounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.search_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sort_combo = new System.Windows.Forms.ComboBox();
            this.discount_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.discount_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // search_text
            // 
            this.search_text.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.search_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_text.DefaultText = "";
            this.search_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_text.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.search_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search_text.ForeColor = System.Drawing.Color.Black;
            this.search_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_text.Location = new System.Drawing.Point(174, 107);
            this.search_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search_text.Name = "search_text";
            this.search_text.PasswordChar = '\0';
            this.search_text.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.search_text.PlaceholderText = "          Search Products\r\n";
            this.search_text.SelectedText = "";
            this.search_text.Size = new System.Drawing.Size(245, 35);
            this.search_text.TabIndex = 37;
            this.search_text.TextChanged += new System.EventHandler(this.search_text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 35;
            this.label2.Text = "Sort by:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 45);
            this.label1.TabIndex = 33;
            this.label1.Text = "Discounts";
            // 
            // sort_combo
            // 
            this.sort_combo.FormattingEnabled = true;
            this.sort_combo.Items.AddRange(new object[] {
            "Discount Percentage Low to High",
            "Discount Percentage High to Low",
            "Products with a discount percentage higher than the average discount percentage",
            "Maximum discount percentage among those products"});
            this.sort_combo.Location = new System.Drawing.Point(507, 114);
            this.sort_combo.Name = "sort_combo";
            this.sort_combo.Size = new System.Drawing.Size(261, 28);
            this.sort_combo.TabIndex = 46;
            this.sort_combo.SelectedIndexChanged += new System.EventHandler(this.sort_combo_SelectedIndexChanged);
            // 
            // discount_grid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.discount_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.discount_grid.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.discount_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.discount_grid.ColumnHeadersHeight = 22;
            this.discount_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.discount_grid.DefaultCellStyle = dataGridViewCellStyle6;
            this.discount_grid.GridColor = System.Drawing.Color.LightSlateGray;
            this.discount_grid.Location = new System.Drawing.Point(59, 171);
            this.discount_grid.Name = "discount_grid";
            this.discount_grid.RowHeadersVisible = false;
            this.discount_grid.RowHeadersWidth = 62;
            this.discount_grid.RowTemplate.Height = 28;
            this.discount_grid.Size = new System.Drawing.Size(750, 394);
            this.discount_grid.TabIndex = 47;
            this.discount_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.discount_grid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.discount_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.discount_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.discount_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.discount_grid.ThemeStyle.BackColor = System.Drawing.Color.Lavender;
            this.discount_grid.ThemeStyle.GridColor = System.Drawing.Color.LightSlateGray;
            this.discount_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.discount_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.discount_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.discount_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.discount_grid.ThemeStyle.HeaderStyle.Height = 22;
            this.discount_grid.ThemeStyle.ReadOnly = false;
            this.discount_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.discount_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.discount_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.discount_grid.ThemeStyle.RowsStyle.Height = 28;
            this.discount_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.discount_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ViewDiscounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.discount_grid);
            this.Controls.Add(this.sort_combo);
            this.Controls.Add(this.search_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewDiscounts";
            this.Size = new System.Drawing.Size(870, 594);
            ((System.ComponentModel.ISupportInitialize)(this.discount_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox search_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sort_combo;
        private Guna.UI2.WinForms.Guna2DataGridView discount_grid;
    }
}
