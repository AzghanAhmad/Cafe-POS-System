namespace DB_Project1.AllFunction
{
    partial class PlaceOrder
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.category_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.list_box = new System.Windows.Forms.ListView();
            this.search_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.price_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.total_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.add_to_cart_btn = new Guna.UI2.WinForms.Guna2Button();
            this.quantity_num = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.product_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cMSDataSet = new DB_Project1.CMSDataSet();
            this.remove_btn = new Guna.UI2.WinForms.Guna2Button();
            this.checkout_btn = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.grand_total_box = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place Order";
            // 
            // category_combo
            // 
            this.category_combo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.category_combo.FormattingEnabled = true;
            this.category_combo.Location = new System.Drawing.Point(70, 136);
            this.category_combo.Name = "category_combo";
            this.category_combo.Size = new System.Drawing.Size(194, 28);
            this.category_combo.TabIndex = 1;
            this.category_combo.SelectedIndexChanged += new System.EventHandler(this.category_combo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // list_box
            // 
            this.list_box.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.list_box.HideSelection = false;
            this.list_box.Location = new System.Drawing.Point(70, 241);
            this.list_box.Name = "list_box";
            this.list_box.Size = new System.Drawing.Size(194, 313);
            this.list_box.TabIndex = 3;
            this.list_box.UseCompatibleStateImageBehavior = false;
            this.list_box.SelectedIndexChanged += new System.EventHandler(this.list_box_SelectedIndexChanged);
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
            this.search_text.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.search_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_text.Location = new System.Drawing.Point(68, 187);
            this.search_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search_text.Name = "search_text";
            this.search_text.PasswordChar = '\0';
            this.search_text.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.search_text.PlaceholderText = "           Search\r\n";
            this.search_text.SelectedText = "";
            this.search_text.Size = new System.Drawing.Size(194, 27);
            this.search_text.TabIndex = 4;
            this.search_text.TextChanged += new System.EventHandler(this.search_text_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(574, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total:";
            // 
            // name_text
            // 
            this.name_text.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.name_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_text.DefaultText = "";
            this.name_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_text.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.name_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.name_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_text.Location = new System.Drawing.Point(330, 129);
            this.name_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name_text.Name = "name_text";
            this.name_text.PasswordChar = '\0';
            this.name_text.PlaceholderText = "";
            this.name_text.SelectedText = "";
            this.name_text.Size = new System.Drawing.Size(201, 35);
            this.name_text.TabIndex = 9;
            // 
            // price_text
            // 
            this.price_text.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.price_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price_text.DefaultText = "";
            this.price_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.price_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.price_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price_text.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.price_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.price_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price_text.Location = new System.Drawing.Point(578, 128);
            this.price_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.price_text.Name = "price_text";
            this.price_text.PasswordChar = '\0';
            this.price_text.PlaceholderText = "";
            this.price_text.SelectedText = "";
            this.price_text.Size = new System.Drawing.Size(201, 36);
            this.price_text.TabIndex = 10;
            // 
            // total_text
            // 
            this.total_text.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.total_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.total_text.DefaultText = "";
            this.total_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.total_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.total_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.total_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.total_text.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.total_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.total_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.total_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.total_text.Location = new System.Drawing.Point(578, 203);
            this.total_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.total_text.Name = "total_text";
            this.total_text.PasswordChar = '\0';
            this.total_text.PlaceholderText = "";
            this.total_text.SelectedText = "";
            this.total_text.Size = new System.Drawing.Size(201, 35);
            this.total_text.TabIndex = 11;
            // 
            // add_to_cart_btn
            // 
            this.add_to_cart_btn.AutoRoundedCorners = true;
            this.add_to_cart_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.add_to_cart_btn.BorderRadius = 21;
            this.add_to_cart_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_to_cart_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_to_cart_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_to_cart_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_to_cart_btn.FillColor = System.Drawing.Color.LightSlateGray;
            this.add_to_cart_btn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.add_to_cart_btn.ForeColor = System.Drawing.Color.Black;
            this.add_to_cart_btn.Location = new System.Drawing.Point(591, 246);
            this.add_to_cart_btn.Name = "add_to_cart_btn";
            this.add_to_cart_btn.Size = new System.Drawing.Size(188, 44);
            this.add_to_cart_btn.TabIndex = 14;
            this.add_to_cart_btn.Text = "Add to Cart";
            this.add_to_cart_btn.Click += new System.EventHandler(this.add_to_cart_btn_Click);
            // 
            // quantity_num
            // 
            this.quantity_num.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.quantity_num.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantity_num.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.quantity_num.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quantity_num.Location = new System.Drawing.Point(330, 203);
            this.quantity_num.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantity_num.Name = "quantity_num";
            this.quantity_num.Size = new System.Drawing.Size(201, 33);
            this.quantity_num.TabIndex = 16;
            this.quantity_num.UpDownButtonFillColor = System.Drawing.Color.White;
            this.quantity_num.ValueChanged += new System.EventHandler(this.quantity_num_ValueChanged);
            // 
            // product_grid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.product_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.product_grid.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.product_grid.ColumnHeadersHeight = 22;
            this.product_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.product_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_column,
            this.name_column,
            this.price_column,
            this.quantity_column,
            this.total_column});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.product_grid.DefaultCellStyle = dataGridViewCellStyle6;
            this.product_grid.GridColor = System.Drawing.Color.LightSlateGray;
            this.product_grid.Location = new System.Drawing.Point(330, 306);
            this.product_grid.Name = "product_grid";
            this.product_grid.RowHeadersVisible = false;
            this.product_grid.RowHeadersWidth = 62;
            this.product_grid.RowTemplate.Height = 28;
            this.product_grid.Size = new System.Drawing.Size(502, 191);
            this.product_grid.TabIndex = 17;
            this.product_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.product_grid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.product_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.product_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.product_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.product_grid.ThemeStyle.BackColor = System.Drawing.Color.Lavender;
            this.product_grid.ThemeStyle.GridColor = System.Drawing.Color.LightSlateGray;
            this.product_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.product_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.product_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.product_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.product_grid.ThemeStyle.HeaderStyle.Height = 22;
            this.product_grid.ThemeStyle.ReadOnly = false;
            this.product_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.product_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.product_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.product_grid.ThemeStyle.RowsStyle.Height = 28;
            this.product_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.product_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // id_column
            // 
            this.id_column.FillWeight = 60F;
            this.id_column.HeaderText = "ID";
            this.id_column.MinimumWidth = 8;
            this.id_column.Name = "id_column";
            // 
            // name_column
            // 
            this.name_column.FillWeight = 74.68695F;
            this.name_column.HeaderText = "Name";
            this.name_column.MinimumWidth = 8;
            this.name_column.Name = "name_column";
            // 
            // price_column
            // 
            this.price_column.FillWeight = 37.32137F;
            this.price_column.HeaderText = "Price";
            this.price_column.MinimumWidth = 8;
            this.price_column.Name = "price_column";
            // 
            // quantity_column
            // 
            this.quantity_column.FillWeight = 37.32137F;
            this.quantity_column.HeaderText = "Quantity";
            this.quantity_column.MinimumWidth = 8;
            this.quantity_column.Name = "quantity_column";
            // 
            // total_column
            // 
            this.total_column.FillWeight = 37.32137F;
            this.total_column.HeaderText = "Total";
            this.total_column.MinimumWidth = 8;
            this.total_column.Name = "total_column";
            // 
            // cMSDataSetBindingSource
            // 
            this.cMSDataSetBindingSource.DataSource = this.cMSDataSet;
            this.cMSDataSetBindingSource.Position = 0;
            // 
            // cMSDataSet
            // 
            this.cMSDataSet.DataSetName = "CMSDataSet";
            this.cMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // remove_btn
            // 
            this.remove_btn.AutoRoundedCorners = true;
            this.remove_btn.BorderRadius = 21;
            this.remove_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.remove_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.remove_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.remove_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.remove_btn.FillColor = System.Drawing.Color.LightSlateGray;
            this.remove_btn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.remove_btn.ForeColor = System.Drawing.Color.Black;
            this.remove_btn.Location = new System.Drawing.Point(330, 510);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(136, 44);
            this.remove_btn.TabIndex = 18;
            this.remove_btn.Text = "Remove";
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // checkout_btn
            // 
            this.checkout_btn.AutoRoundedCorners = true;
            this.checkout_btn.BorderRadius = 21;
            this.checkout_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.checkout_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.checkout_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkout_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.checkout_btn.FillColor = System.Drawing.Color.LightSlateGray;
            this.checkout_btn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.checkout_btn.ForeColor = System.Drawing.Color.Black;
            this.checkout_btn.Location = new System.Drawing.Point(486, 510);
            this.checkout_btn.Name = "checkout_btn";
            this.checkout_btn.Size = new System.Drawing.Size(136, 44);
            this.checkout_btn.TabIndex = 19;
            this.checkout_btn.Text = "Checkout";
            this.checkout_btn.Click += new System.EventHandler(this.checkout_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(628, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Grand Total:";
            // 
            // grand_total_box
            // 
            this.grand_total_box.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grand_total_box.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.grand_total_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.grand_total_box.DefaultText = "";
            this.grand_total_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.grand_total_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.grand_total_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.grand_total_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.grand_total_box.FillColor = System.Drawing.Color.LightSteelBlue;
            this.grand_total_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grand_total_box.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.grand_total_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grand_total_box.Location = new System.Drawing.Point(736, 510);
            this.grand_total_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grand_total_box.Name = "grand_total_box";
            this.grand_total_box.PasswordChar = '\0';
            this.grand_total_box.PlaceholderText = "";
            this.grand_total_box.SelectedText = "";
            this.grand_total_box.Size = new System.Drawing.Size(96, 22);
            this.grand_total_box.TabIndex = 21;
            // 
            // PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.grand_total_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkout_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.product_grid);
            this.Controls.Add(this.quantity_num);
            this.Controls.Add(this.add_to_cart_btn);
            this.Controls.Add(this.total_text);
            this.Controls.Add(this.price_text);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search_text);
            this.Controls.Add(this.list_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.category_combo);
            this.Controls.Add(this.label1);
            this.Name = "PlaceOrder";
            this.Size = new System.Drawing.Size(870, 594);
            ((System.ComponentModel.ISupportInitialize)(this.quantity_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox category_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView list_box;
        private Guna.UI2.WinForms.Guna2TextBox search_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox name_text;
        private Guna.UI2.WinForms.Guna2TextBox price_text;
        private Guna.UI2.WinForms.Guna2TextBox total_text;
        private Guna.UI2.WinForms.Guna2Button add_to_cart_btn;
        private Guna.UI2.WinForms.Guna2NumericUpDown quantity_num;
        private Guna.UI2.WinForms.Guna2DataGridView product_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_column;
        private Guna.UI2.WinForms.Guna2Button remove_btn;
        private Guna.UI2.WinForms.Guna2Button checkout_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource cMSDataSetBindingSource;
        private CMSDataSet cMSDataSet;
        private Guna.UI2.WinForms.Guna2TextBox grand_total_box;
    }
}
