namespace TrendTrackApplication
{
    partial class CashierOrders
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
            panel2 = new Panel();
            order_prodID = new ComboBox();
            order_price = new Label();
            order_name = new Label();
            btn_order_clear = new Button();
            btn_order_remove = new Button();
            order_quantity = new NumericUpDown();
            label7 = new Label();
            btn_order_add = new Button();
            order_category = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            order_totalPrice = new Label();
            order_change = new Label();
            btn_order_receipt = new Button();
            btn_order_checkout = new Button();
            order_amount = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            panel7 = new Panel();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)order_quantity).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(order_prodID);
            panel2.Controls.Add(order_price);
            panel2.Controls.Add(order_name);
            panel2.Controls.Add(btn_order_clear);
            panel2.Controls.Add(btn_order_remove);
            panel2.Controls.Add(order_quantity);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btn_order_add);
            panel2.Controls.Add(order_category);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(30, 424);
            panel2.Name = "panel2";
            panel2.Size = new Size(559, 315);
            panel2.TabIndex = 20;
            // 
            // order_prodID
            // 
            order_prodID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            order_prodID.FormattingEnabled = true;
            order_prodID.Location = new Point(325, 94);
            order_prodID.Name = "order_prodID";
            order_prodID.Size = new Size(190, 28);
            order_prodID.TabIndex = 24;
            order_prodID.SelectedIndexChanged += order_prodID_SelectedIndexChanged;
            // 
            // order_price
            // 
            order_price.AutoSize = true;
            order_price.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            order_price.Location = new Point(121, 199);
            order_price.Name = "order_price";
            order_price.Size = new Size(40, 20);
            order_price.TabIndex = 23;
            order_price.Text = "Price";
            // 
            // order_name
            // 
            order_name.AutoSize = true;
            order_name.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            order_name.Location = new Point(121, 146);
            order_name.Name = "order_name";
            order_name.Size = new Size(44, 20);
            order_name.TabIndex = 22;
            order_name.Text = "Name";
            // 
            // btn_order_clear
            // 
            btn_order_clear.BackColor = Color.RoyalBlue;
            btn_order_clear.FlatStyle = FlatStyle.Flat;
            btn_order_clear.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_order_clear.ForeColor = Color.White;
            btn_order_clear.Location = new Point(403, 258);
            btn_order_clear.Name = "btn_order_clear";
            btn_order_clear.Size = new Size(112, 31);
            btn_order_clear.TabIndex = 21;
            btn_order_clear.Text = "CLEAR";
            btn_order_clear.UseVisualStyleBackColor = false;
            // 
            // btn_order_remove
            // 
            btn_order_remove.BackColor = Color.RoyalBlue;
            btn_order_remove.FlatStyle = FlatStyle.Flat;
            btn_order_remove.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_order_remove.ForeColor = Color.White;
            btn_order_remove.Location = new Point(201, 258);
            btn_order_remove.Name = "btn_order_remove";
            btn_order_remove.Size = new Size(112, 31);
            btn_order_remove.TabIndex = 20;
            btn_order_remove.Text = "REMOVE";
            btn_order_remove.UseVisualStyleBackColor = false;
            // 
            // order_quantity
            // 
            order_quantity.Font = new Font("Microsoft Sans Serif", 12F);
            order_quantity.Location = new Point(325, 169);
            order_quantity.Name = "order_quantity";
            order_quantity.Size = new Size(190, 26);
            order_quantity.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(17, 199);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 14;
            label7.Text = "Price: (₱):";
            label7.Click += label7_Click;
            // 
            // btn_order_add
            // 
            btn_order_add.BackColor = Color.RoyalBlue;
            btn_order_add.FlatStyle = FlatStyle.Flat;
            btn_order_add.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_order_add.ForeColor = Color.White;
            btn_order_add.Location = new Point(17, 258);
            btn_order_add.Name = "btn_order_add";
            btn_order_add.Size = new Size(112, 31);
            btn_order_add.TabIndex = 10;
            btn_order_add.Text = "ADD";
            btn_order_add.UseVisualStyleBackColor = false;
            // 
            // order_category
            // 
            order_category.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            order_category.FormattingEnabled = true;
            order_category.Location = new Point(17, 94);
            order_category.Name = "order_category";
            order_category.Size = new Size(190, 28);
            order_category.TabIndex = 9;
            order_category.SelectedIndexChanged += order_category_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(325, 71);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 5;
            label5.Text = "Product ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(325, 146);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 4;
            label4.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 146);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 3;
            label1.Text = "Product Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 71);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 2;
            label2.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 26);
            label6.Name = "label6";
            label6.Size = new Size(150, 18);
            label6.TabIndex = 1;
            label6.Text = "Order Information";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(order_totalPrice);
            panel1.Controls.Add(order_change);
            panel1.Controls.Add(btn_order_receipt);
            panel1.Controls.Add(btn_order_checkout);
            panel1.Controls.Add(order_amount);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(611, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 708);
            panel1.TabIndex = 19;
            // 
            // order_totalPrice
            // 
            order_totalPrice.AutoSize = true;
            order_totalPrice.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            order_totalPrice.Location = new Point(208, 417);
            order_totalPrice.Name = "order_totalPrice";
            order_totalPrice.Size = new Size(44, 20);
            order_totalPrice.TabIndex = 25;
            order_totalPrice.Text = "Name";
            // 
            // order_change
            // 
            order_change.AutoSize = true;
            order_change.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            order_change.Location = new Point(208, 517);
            order_change.Name = "order_change";
            order_change.Size = new Size(44, 20);
            order_change.TabIndex = 24;
            order_change.Text = "Name";
            // 
            // btn_order_receipt
            // 
            btn_order_receipt.BackColor = Color.RoyalBlue;
            btn_order_receipt.FlatStyle = FlatStyle.Flat;
            btn_order_receipt.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_order_receipt.ForeColor = Color.White;
            btn_order_receipt.Location = new Point(16, 643);
            btn_order_receipt.Name = "btn_order_receipt";
            btn_order_receipt.Size = new Size(382, 39);
            btn_order_receipt.TabIndex = 23;
            btn_order_receipt.Text = "Receipt";
            btn_order_receipt.UseVisualStyleBackColor = false;
            // 
            // btn_order_checkout
            // 
            btn_order_checkout.BackColor = Color.RoyalBlue;
            btn_order_checkout.FlatStyle = FlatStyle.Flat;
            btn_order_checkout.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_order_checkout.ForeColor = Color.White;
            btn_order_checkout.Location = new Point(16, 573);
            btn_order_checkout.Name = "btn_order_checkout";
            btn_order_checkout.Size = new Size(382, 39);
            btn_order_checkout.TabIndex = 22;
            btn_order_checkout.Text = "Check Out";
            btn_order_checkout.UseVisualStyleBackColor = false;
            // 
            // order_amount
            // 
            order_amount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            order_amount.Location = new Point(208, 461);
            order_amount.Name = "order_amount";
            order_amount.Size = new Size(190, 26);
            order_amount.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(16, 519);
            label10.Name = "label10";
            label10.Size = new Size(75, 18);
            label10.TabIndex = 5;
            label10.Text = "Change:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 466);
            label9.Name = "label9";
            label9.Size = new Size(100, 18);
            label9.TabIndex = 4;
            label9.Text = "Amount (₱):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 419);
            label8.Name = "label8";
            label8.Size = new Size(124, 18);
            label8.TabIndex = 3;
            label8.Text = "Total Price (₱):";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(16, 55);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(382, 288);
            dataGridView2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 20);
            label3.Name = "label3";
            label3.Size = new Size(64, 18);
            label3.TabIndex = 2;
            label3.Text = "Orders";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label12);
            panel7.Controls.Add(dataGridView1);
            panel7.Location = new Point(30, 31);
            panel7.Name = "panel7";
            panel7.Size = new Size(559, 364);
            panel7.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(17, 20);
            label12.Name = "label12";
            label12.Size = new Size(158, 18);
            label12.TabIndex = 2;
            label12.Text = "Available Products";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(524, 288);
            dataGridView1.TabIndex = 0;
            // 
            // CashierOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Name = "CashierOrders";
            Size = new Size(1054, 770);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)order_quantity).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label7;
        private Button btn_order_add;
        private ComboBox order_category;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label6;
        private Panel panel1;
        private Label label3;
        private Panel panel7;
        private Label label12;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button btn_order_remove;
        private NumericUpDown order_quantity;
        private Button btn_order_clear;
        private Label label8;
        private Button btn_order_checkout;
        private TextBox order_amount;
        private Label label10;
        private Label label9;
        private Button btn_order_receipt;
        private Label order_price;
        private Label order_name;
        private Label order_totalPrice;
        private Label order_change;
        private ComboBox order_prodID;
    }
}
