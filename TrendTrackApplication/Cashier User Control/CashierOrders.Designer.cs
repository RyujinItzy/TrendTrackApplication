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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            order_prodID = new ComboBox();
            order_productPrice = new Label();
            order_productName = new Label();
            order_quantity = new NumericUpDown();
            label7 = new Label();
            order_product_category = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            order_totalPrice = new Label();
            order_change = new Label();
            order_amount = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            label12 = new Label();
            panel7 = new Panel();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            btn_search_availProduct = new RoundedButton();
            productAvail_searchText = new TextBox();
            roundedButton1 = new RoundedButton();
            textBox1 = new TextBox();
            btn_productAvail_nextPage = new Button();
            btn_productAvail_previousPage = new Button();
            currentPage_txtbox = new TextBox();
            btn_order_add = new RoundedButton();
            btn_order_remove = new RoundedButton();
            btn_order_clear = new RoundedButton();
            btn_order_checkout = new RoundedButton();
            roundedButton2 = new RoundedButton();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)order_quantity).BeginInit();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btn_order_clear);
            panel2.Controls.Add(btn_order_remove);
            panel2.Controls.Add(btn_order_add);
            panel2.Controls.Add(order_prodID);
            panel2.Controls.Add(order_productPrice);
            panel2.Controls.Add(order_productName);
            panel2.Controls.Add(order_quantity);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(order_product_category);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(30, 450);
            panel2.Name = "panel2";
            panel2.Size = new Size(559, 289);
            panel2.TabIndex = 20;
            // 
            // order_prodID
            // 
            order_prodID.Font = new Font("Cambria", 12F);
            order_prodID.FormattingEnabled = true;
            order_prodID.Location = new Point(325, 82);
            order_prodID.Name = "order_prodID";
            order_prodID.Size = new Size(190, 27);
            order_prodID.TabIndex = 24;
            order_prodID.SelectedIndexChanged += order_prodID_SelectedIndexChanged;
            // 
            // order_productPrice
            // 
            order_productPrice.AutoSize = true;
            order_productPrice.Font = new Font("Cambria", 12F);
            order_productPrice.Location = new Point(135, 169);
            order_productPrice.Name = "order_productPrice";
            order_productPrice.Size = new Size(44, 19);
            order_productPrice.TabIndex = 23;
            order_productPrice.Text = "Price";
            // 
            // order_productName
            // 
            order_productName.AutoSize = true;
            order_productName.Font = new Font("Cambria", 12F);
            order_productName.Location = new Point(135, 127);
            order_productName.Name = "order_productName";
            order_productName.Size = new Size(49, 19);
            order_productName.TabIndex = 22;
            order_productName.Text = "Name";
            // 
            // order_quantity
            // 
            order_quantity.Font = new Font("Cambria", 12F);
            order_quantity.Location = new Point(325, 149);
            order_quantity.Name = "order_quantity";
            order_quantity.Size = new Size(190, 26);
            order_quantity.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 12F);
            label7.Location = new Point(17, 169);
            label7.Name = "label7";
            label7.Size = new Size(77, 19);
            label7.TabIndex = 14;
            label7.Text = "Price: (₱):";
            label7.Click += label7_Click;
            // 
            // order_product_category
            // 
            order_product_category.Font = new Font("Cambria", 12F);
            order_product_category.FormattingEnabled = true;
            order_product_category.Location = new Point(17, 82);
            order_product_category.Name = "order_product_category";
            order_product_category.Size = new Size(190, 27);
            order_product_category.TabIndex = 9;
            order_product_category.SelectedIndexChanged += order_category_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F);
            label5.Location = new Point(325, 60);
            label5.Name = "label5";
            label5.Size = new Size(84, 19);
            label5.TabIndex = 5;
            label5.Text = "Product ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F);
            label4.Location = new Point(325, 127);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 4;
            label4.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F);
            label1.Location = new Point(17, 127);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 3;
            label1.Text = "Product Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F);
            label2.Location = new Point(17, 60);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 2;
            label2.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 27);
            label6.Name = "label6";
            label6.Size = new Size(150, 18);
            label6.TabIndex = 1;
            label6.Text = "Order Information";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(roundedButton2);
            panel1.Controls.Add(btn_order_checkout);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(order_totalPrice);
            panel1.Controls.Add(order_change);
            panel1.Controls.Add(order_amount);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
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
            // order_amount
            // 
            order_amount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            order_amount.Location = new Point(208, 461);
            order_amount.Name = "order_amount";
            order_amount.Size = new Size(85, 26);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label3.Location = new Point(16, 20);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 2;
            label3.Text = "Orders";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label12.Location = new Point(17, 18);
            label12.Name = "label12";
            label12.Size = new Size(147, 19);
            label12.TabIndex = 2;
            label12.Text = "Available Products";
            label12.Click += label12_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(roundedButton1);
            panel7.Controls.Add(textBox1);
            panel7.Controls.Add(btn_productAvail_nextPage);
            panel7.Controls.Add(btn_productAvail_previousPage);
            panel7.Controls.Add(currentPage_txtbox);
            panel7.Controls.Add(dataGridView2);
            panel7.Controls.Add(label12);
            panel7.Font = new Font("Cambria", 12F);
            panel7.Location = new Point(30, 69);
            panel7.Name = "panel7";
            panel7.Size = new Size(559, 364);
            panel7.TabIndex = 18;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.SteelBlue;
            dataGridViewCellStyle4.Font = new Font("Cambria", 12F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.ColumnHeadersHeight = 35;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Cambria", 12F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.LightGray;
            dataGridView2.Location = new Point(17, 53);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Cambria", 12F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 25;
            dataGridView2.ScrollBars = ScrollBars.None;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(520, 269);
            dataGridView2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(27, 65);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(371, 299);
            dataGridView1.TabIndex = 4;
            // 
            // btn_search_availProduct
            // 
            btn_search_availProduct.BackColor = Color.SteelBlue;
            btn_search_availProduct.BackGroundColor = Color.SteelBlue;
            btn_search_availProduct.BorderColor = Color.RoyalBlue;
            btn_search_availProduct.BorderRadius = 10;
            btn_search_availProduct.BorderSize = 0;
            btn_search_availProduct.FlatAppearance.BorderSize = 0;
            btn_search_availProduct.FlatStyle = FlatStyle.Flat;
            btn_search_availProduct.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search_availProduct.ForeColor = Color.White;
            btn_search_availProduct.Image = Properties.Resources.search_icon_24;
            btn_search_availProduct.Location = new Point(373, 30);
            btn_search_availProduct.Name = "btn_search_availProduct";
            btn_search_availProduct.Size = new Size(88, 33);
            btn_search_availProduct.TabIndex = 28;
            btn_search_availProduct.TextColor = Color.White;
            btn_search_availProduct.UseVisualStyleBackColor = false;
            // 
            // productAvail_searchText
            // 
            productAvail_searchText.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productAvail_searchText.Location = new Point(30, 31);
            productAvail_searchText.Name = "productAvail_searchText";
            productAvail_searchText.Size = new Size(337, 32);
            productAvail_searchText.TabIndex = 27;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.SteelBlue;
            roundedButton1.BackGroundColor = Color.SteelBlue;
            roundedButton1.BorderColor = Color.RoyalBlue;
            roundedButton1.BorderRadius = 10;
            roundedButton1.BorderSize = 0;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Image = Properties.Resources.search_icon_24;
            roundedButton1.Location = new Point(144, -257);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(88, 33);
            roundedButton1.TabIndex = 31;
            roundedButton1.TextColor = Color.White;
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(-199, -256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(337, 32);
            textBox1.TabIndex = 30;
            // 
            // btn_productAvail_nextPage
            // 
            btn_productAvail_nextPage.BackColor = Color.SteelBlue;
            btn_productAvail_nextPage.FlatStyle = FlatStyle.Flat;
            btn_productAvail_nextPage.ForeColor = Color.CornflowerBlue;
            btn_productAvail_nextPage.Image = Properties.Resources.nextPage_icon_notfill_18;
            btn_productAvail_nextPage.Location = new Point(303, 328);
            btn_productAvail_nextPage.Name = "btn_productAvail_nextPage";
            btn_productAvail_nextPage.Size = new Size(39, 23);
            btn_productAvail_nextPage.TabIndex = 29;
            btn_productAvail_nextPage.UseVisualStyleBackColor = false;
            // 
            // btn_productAvail_previousPage
            // 
            btn_productAvail_previousPage.BackColor = Color.SteelBlue;
            btn_productAvail_previousPage.FlatStyle = FlatStyle.Flat;
            btn_productAvail_previousPage.ForeColor = Color.SteelBlue;
            btn_productAvail_previousPage.Image = Properties.Resources.previousPage_icon_notfill_18;
            btn_productAvail_previousPage.Location = new Point(209, 328);
            btn_productAvail_previousPage.Name = "btn_productAvail_previousPage";
            btn_productAvail_previousPage.Size = new Size(39, 23);
            btn_productAvail_previousPage.TabIndex = 28;
            btn_productAvail_previousPage.UseVisualStyleBackColor = false;
            // 
            // currentPage_txtbox
            // 
            currentPage_txtbox.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentPage_txtbox.Location = new Point(254, 328);
            currentPage_txtbox.Name = "currentPage_txtbox";
            currentPage_txtbox.Size = new Size(43, 22);
            currentPage_txtbox.TabIndex = 27;
            currentPage_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_order_add
            // 
            btn_order_add.BackColor = Color.DarkGreen;
            btn_order_add.BackGroundColor = Color.DarkGreen;
            btn_order_add.BorderColor = Color.DarkGreen;
            btn_order_add.BorderRadius = 10;
            btn_order_add.BorderSize = 3;
            btn_order_add.FlatAppearance.BorderSize = 0;
            btn_order_add.FlatStyle = FlatStyle.Flat;
            btn_order_add.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_order_add.ForeColor = Color.White;
            btn_order_add.Location = new Point(188, 230);
            btn_order_add.Name = "btn_order_add";
            btn_order_add.Size = new Size(105, 33);
            btn_order_add.TabIndex = 29;
            btn_order_add.Text = "Add";
            btn_order_add.TextColor = Color.White;
            btn_order_add.UseVisualStyleBackColor = false;
            // 
            // btn_order_remove
            // 
            btn_order_remove.BackColor = Color.DarkRed;
            btn_order_remove.BackGroundColor = Color.DarkRed;
            btn_order_remove.BorderColor = Color.DarkRed;
            btn_order_remove.BorderRadius = 10;
            btn_order_remove.BorderSize = 3;
            btn_order_remove.FlatAppearance.BorderSize = 0;
            btn_order_remove.FlatStyle = FlatStyle.Flat;
            btn_order_remove.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_order_remove.ForeColor = Color.White;
            btn_order_remove.Location = new Point(299, 230);
            btn_order_remove.Name = "btn_order_remove";
            btn_order_remove.Size = new Size(105, 33);
            btn_order_remove.TabIndex = 30;
            btn_order_remove.Text = "Remove";
            btn_order_remove.TextColor = Color.White;
            btn_order_remove.UseVisualStyleBackColor = false;
            // 
            // btn_order_clear
            // 
            btn_order_clear.BackColor = Color.SteelBlue;
            btn_order_clear.BackGroundColor = Color.SteelBlue;
            btn_order_clear.BorderColor = Color.SteelBlue;
            btn_order_clear.BorderRadius = 10;
            btn_order_clear.BorderSize = 3;
            btn_order_clear.FlatAppearance.BorderSize = 0;
            btn_order_clear.FlatStyle = FlatStyle.Flat;
            btn_order_clear.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_order_clear.ForeColor = Color.White;
            btn_order_clear.Location = new Point(410, 230);
            btn_order_clear.Name = "btn_order_clear";
            btn_order_clear.Size = new Size(105, 33);
            btn_order_clear.TabIndex = 31;
            btn_order_clear.Text = "Clear";
            btn_order_clear.TextColor = Color.White;
            btn_order_clear.UseVisualStyleBackColor = false;
            // 
            // btn_order_checkout
            // 
            btn_order_checkout.BackColor = Color.SteelBlue;
            btn_order_checkout.BackGroundColor = Color.SteelBlue;
            btn_order_checkout.BorderColor = Color.SteelBlue;
            btn_order_checkout.BorderRadius = 10;
            btn_order_checkout.BorderSize = 3;
            btn_order_checkout.FlatAppearance.BorderSize = 0;
            btn_order_checkout.FlatStyle = FlatStyle.Flat;
            btn_order_checkout.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_order_checkout.ForeColor = Color.White;
            btn_order_checkout.Location = new Point(16, 582);
            btn_order_checkout.Name = "btn_order_checkout";
            btn_order_checkout.Size = new Size(382, 33);
            btn_order_checkout.TabIndex = 32;
            btn_order_checkout.Text = "Checkout";
            btn_order_checkout.TextColor = Color.White;
            btn_order_checkout.UseVisualStyleBackColor = false;
            // 
            // roundedButton2
            // 
            roundedButton2.BackColor = Color.SteelBlue;
            roundedButton2.BackGroundColor = Color.SteelBlue;
            roundedButton2.BorderColor = Color.SteelBlue;
            roundedButton2.BorderRadius = 10;
            roundedButton2.BorderSize = 3;
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton2.ForeColor = Color.White;
            roundedButton2.Location = new Point(16, 649);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(382, 33);
            roundedButton2.TabIndex = 33;
            roundedButton2.Text = "Receipt";
            roundedButton2.TextColor = Color.White;
            roundedButton2.UseVisualStyleBackColor = false;
            // 
            // CashierOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_search_availProduct);
            Controls.Add(productAvail_searchText);
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
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label7;
        private ComboBox order_product_category;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label6;
        private Panel panel1;
        private Label label3;
        private NumericUpDown order_quantity;
        private Label label8;
        private TextBox order_amount;
        private Label label10;
        private Label label9;
        private Label order_productPrice;
        private Label order_productName;
        private Label order_totalPrice;
        private Label order_change;
        private ComboBox order_prodID;
        private Label label12;
        private Panel panel7;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private RoundedButton btn_search_availProduct;
        private TextBox productAvail_searchText;
        private RoundedButton roundedButton1;
        private TextBox textBox1;
        private Button btn_productAvail_nextPage;
        private Button btn_productAvail_previousPage;
        private TextBox currentPage_txtbox;
        private RoundedButton btn_order_add;
        private RoundedButton btn_order_remove;
        private RoundedButton btn_order_clear;
        private RoundedButton roundedButton2;
        private RoundedButton btn_order_checkout;
    }
}
