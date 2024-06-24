namespace TrendTrackApplication.Product_Forms
{
    partial class AddProductForm
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
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            products_size = new Label();
            products_description = new RichTextBox();
            label10 = new Label();
            btn_products_import = new RoundedButton();
            label9 = new Label();
            products_picture = new PictureBox();
            products_stock = new TextBox();
            label8 = new Label();
            products_salesPrice = new TextBox();
            products_costPrice = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btn_products_add = new RoundedButton();
            btn_products_clear = new RoundedButton();
            products_status_cb = new ComboBox();
            products_category_cb = new ComboBox();
            products_prodName = new TextBox();
            products_prodID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)products_picture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(products_size);
            panel1.Controls.Add(products_description);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btn_products_import);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(products_picture);
            panel1.Controls.Add(products_stock);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(products_salesPrice);
            panel1.Controls.Add(products_costPrice);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btn_products_add);
            panel1.Controls.Add(btn_products_clear);
            panel1.Controls.Add(products_status_cb);
            panel1.Controls.Add(products_category_cb);
            panel1.Controls.Add(products_prodName);
            panel1.Controls.Add(products_prodID);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 488);
            panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "XS", "Small", "Medium", "Large", "XL" });
            comboBox1.Location = new Point(29, 391);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 27);
            comboBox1.TabIndex = 35;
            // 
            // products_size
            // 
            products_size.AutoSize = true;
            products_size.Font = new Font("Cambria", 12F);
            products_size.Location = new Point(29, 369);
            products_size.Name = "products_size";
            products_size.Size = new Size(36, 19);
            products_size.TabIndex = 34;
            products_size.Text = "Size";
            // 
            // products_description
            // 
            products_description.Location = new Point(289, 319);
            products_description.Name = "products_description";
            products_description.Size = new Size(190, 141);
            products_description.TabIndex = 31;
            products_description.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cambria", 12F);
            label10.Location = new Point(289, 291);
            label10.Name = "label10";
            label10.Size = new Size(89, 19);
            label10.TabIndex = 30;
            label10.Text = "Description";
            // 
            // btn_products_import
            // 
            btn_products_import.BackColor = Color.RoyalBlue;
            btn_products_import.BackGroundColor = Color.RoyalBlue;
            btn_products_import.BorderColor = Color.RoyalBlue;
            btn_products_import.BorderRadius = 10;
            btn_products_import.BorderSize = 0;
            btn_products_import.FlatAppearance.BorderSize = 0;
            btn_products_import.FlatStyle = FlatStyle.Flat;
            btn_products_import.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_products_import.ForeColor = Color.White;
            btn_products_import.Location = new Point(648, 316);
            btn_products_import.Name = "btn_products_import";
            btn_products_import.Size = new Size(105, 24);
            btn_products_import.TabIndex = 29;
            btn_products_import.Text = "Browse";
            btn_products_import.TextColor = Color.White;
            btn_products_import.UseVisualStyleBackColor = false;
            btn_products_import.Click += btn_products_import_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(631, 27);
            label9.Name = "label9";
            label9.Size = new Size(138, 22);
            label9.TabIndex = 28;
            label9.Text = "Product Image";
            // 
            // products_picture
            // 
            products_picture.BackColor = Color.DarkGray;
            products_picture.Location = new Point(546, 60);
            products_picture.Name = "products_picture";
            products_picture.Size = new Size(300, 250);
            products_picture.SizeMode = PictureBoxSizeMode.Zoom;
            products_picture.TabIndex = 27;
            products_picture.TabStop = false;
            // 
            // products_stock
            // 
            products_stock.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            products_stock.Location = new Point(289, 242);
            products_stock.Name = "products_stock";
            products_stock.Size = new Size(190, 26);
            products_stock.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 12F);
            label8.Location = new Point(291, 220);
            label8.Name = "label8";
            label8.Size = new Size(46, 19);
            label8.TabIndex = 25;
            label8.Text = "Stock";
            // 
            // products_salesPrice
            // 
            products_salesPrice.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            products_salesPrice.Location = new Point(289, 161);
            products_salesPrice.Name = "products_salesPrice";
            products_salesPrice.Size = new Size(190, 26);
            products_salesPrice.TabIndex = 24;
            // 
            // products_costPrice
            // 
            products_costPrice.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            products_costPrice.Location = new Point(291, 91);
            products_costPrice.Name = "products_costPrice";
            products_costPrice.Size = new Size(190, 26);
            products_costPrice.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 12F);
            label6.Location = new Point(291, 139);
            label6.Name = "label6";
            label6.Size = new Size(76, 19);
            label6.TabIndex = 22;
            label6.Text = "Sale Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 12F);
            label7.Location = new Point(291, 69);
            label7.Name = "label7";
            label7.Size = new Size(78, 19);
            label7.TabIndex = 21;
            label7.Text = "Cost Price";
            // 
            // btn_products_add
            // 
            btn_products_add.BackColor = Color.DarkGreen;
            btn_products_add.BackGroundColor = Color.DarkGreen;
            btn_products_add.BorderColor = Color.RoyalBlue;
            btn_products_add.BorderRadius = 10;
            btn_products_add.BorderSize = 0;
            btn_products_add.FlatAppearance.BorderSize = 0;
            btn_products_add.FlatStyle = FlatStyle.Flat;
            btn_products_add.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_products_add.ForeColor = Color.White;
            btn_products_add.Location = new Point(630, 429);
            btn_products_add.Name = "btn_products_add";
            btn_products_add.Size = new Size(105, 31);
            btn_products_add.TabIndex = 20;
            btn_products_add.Text = "Add";
            btn_products_add.TextColor = Color.White;
            btn_products_add.UseVisualStyleBackColor = false;
            btn_products_add.Click += btn_products_add_Click;
            // 
            // btn_products_clear
            // 
            btn_products_clear.BackColor = Color.RoyalBlue;
            btn_products_clear.BackGroundColor = Color.RoyalBlue;
            btn_products_clear.BorderColor = Color.RoyalBlue;
            btn_products_clear.BorderRadius = 10;
            btn_products_clear.BorderSize = 0;
            btn_products_clear.FlatAppearance.BorderSize = 0;
            btn_products_clear.FlatStyle = FlatStyle.Flat;
            btn_products_clear.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_products_clear.ForeColor = Color.White;
            btn_products_clear.Location = new Point(741, 429);
            btn_products_clear.Name = "btn_products_clear";
            btn_products_clear.Size = new Size(105, 31);
            btn_products_clear.TabIndex = 19;
            btn_products_clear.Text = "Clear";
            btn_products_clear.TextColor = Color.White;
            btn_products_clear.UseVisualStyleBackColor = false;
            btn_products_clear.Click += btn_products_clear_Click;
            // 
            // products_status_cb
            // 
            products_status_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            products_status_cb.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            products_status_cb.FormattingEnabled = true;
            products_status_cb.Items.AddRange(new object[] { "Available", "Unavailable" });
            products_status_cb.Location = new Point(29, 313);
            products_status_cb.Name = "products_status_cb";
            products_status_cb.Size = new Size(190, 27);
            products_status_cb.TabIndex = 18;
            // 
            // products_category_cb
            // 
            products_category_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            products_category_cb.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            products_category_cb.FormattingEnabled = true;
            products_category_cb.Location = new Point(29, 241);
            products_category_cb.Name = "products_category_cb";
            products_category_cb.Size = new Size(190, 27);
            products_category_cb.TabIndex = 17;
            // 
            // products_prodName
            // 
            products_prodName.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            products_prodName.Location = new Point(29, 161);
            products_prodName.Name = "products_prodName";
            products_prodName.Size = new Size(190, 26);
            products_prodName.TabIndex = 16;
            // 
            // products_prodID
            // 
            products_prodID.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            products_prodID.Location = new Point(29, 91);
            products_prodID.Name = "products_prodID";
            products_prodID.Size = new Size(190, 26);
            products_prodID.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F);
            label5.Location = new Point(29, 221);
            label5.Name = "label5";
            label5.Size = new Size(71, 19);
            label5.TabIndex = 14;
            label5.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F);
            label4.Location = new Point(29, 291);
            label4.Name = "label4";
            label4.Size = new Size(51, 19);
            label4.TabIndex = 13;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F);
            label3.Location = new Point(31, 139);
            label3.Name = "label3";
            label3.Size = new Size(108, 19);
            label3.TabIndex = 12;
            label3.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F);
            label2.Location = new Point(29, 69);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 11;
            label2.Text = "Product ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(190, 22);
            label1.TabIndex = 10;
            label1.Text = "Product Information";
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(897, 512);
            Controls.Add(panel1);
            Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Product Form";
            Load += AddProductForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)products_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox products_salesPrice;
        private TextBox products_costPrice;
        private Label label6;
        private Label label7;
        private RoundedButton btn_products_add;
        private RoundedButton btn_products_clear;
        private ComboBox products_status_cb;
        private ComboBox products_category_cb;
        private TextBox products_prodName;
        private TextBox products_prodID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RoundedButton btn_products_import;
        private Label label9;
        private PictureBox products_picture;
        private TextBox products_stock;
        private Label label8;
        private Label label10;
        private RichTextBox products_description;
        private Label products_size;
        private ComboBox comboBox1;
    }
}