namespace TrendTrackApplication.Cashier_User_Control
{
    partial class CashierOrder
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
            panel1 = new Panel();
            flowLayoutPanelCart = new FlowLayoutPanel();
            btn_order_checkout = new RoundedButton();
            order_totalPrice = new Label();
            order_change = new Label();
            order_amount = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            productAvail_searchText = new TextBox();
            btn_search_availProduct = new RoundedButton();
            btn_cart_clear = new RoundedButton();
            flowLayoutPanelProducts = new FlowLayoutPanel();
            printDialog1 = new PrintDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(flowLayoutPanelCart);
            panel1.Controls.Add(btn_order_checkout);
            panel1.Controls.Add(order_totalPrice);
            panel1.Controls.Add(order_change);
            panel1.Controls.Add(order_amount);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label3);
            panel1.Font = new Font("Cambria", 11.25F);
            panel1.Location = new Point(729, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 686);
            panel1.TabIndex = 22;
            // 
            // flowLayoutPanelCart
            // 
            flowLayoutPanelCart.AutoScroll = true;
            flowLayoutPanelCart.Location = new Point(12, 43);
            flowLayoutPanelCart.Name = "flowLayoutPanelCart";
            flowLayoutPanelCart.Size = new Size(285, 379);
            flowLayoutPanelCart.TabIndex = 34;
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
            btn_order_checkout.Location = new Point(29, 620);
            btn_order_checkout.Name = "btn_order_checkout";
            btn_order_checkout.Size = new Size(268, 33);
            btn_order_checkout.TabIndex = 32;
            btn_order_checkout.Text = "Checkout";
            btn_order_checkout.TextColor = Color.White;
            btn_order_checkout.UseVisualStyleBackColor = false;
            btn_order_checkout.Click += btn_order_checkout_Click;
            // 
            // order_totalPrice
            // 
            order_totalPrice.AutoSize = true;
            order_totalPrice.Font = new Font("Cambria", 11.25F);
            order_totalPrice.Location = new Point(171, 435);
            order_totalPrice.Name = "order_totalPrice";
            order_totalPrice.Size = new Size(58, 17);
            order_totalPrice.TabIndex = 25;
            order_totalPrice.Text = "Amount";
            order_totalPrice.Click += order_totalPrice_Click;
            // 
            // order_change
            // 
            order_change.AutoSize = true;
            order_change.Font = new Font("Cambria", 11.25F);
            order_change.Location = new Point(171, 559);
            order_change.Name = "order_change";
            order_change.Size = new Size(106, 17);
            order_change.TabIndex = 24;
            order_change.Text = "Change Amount";
            order_change.Click += order_change_Click;
            // 
            // order_amount
            // 
            order_amount.Font = new Font("Cambria", 11.25F);
            order_amount.Location = new Point(171, 490);
            order_amount.Name = "order_amount";
            order_amount.Size = new Size(85, 25);
            order_amount.TabIndex = 22;
            order_amount.TextChanged += order_amount_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cambria", 11.25F);
            label10.Location = new Point(29, 559);
            label10.Name = "label10";
            label10.Size = new Size(57, 17);
            label10.TabIndex = 5;
            label10.Text = "Change:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 11.25F);
            label9.Location = new Point(29, 498);
            label9.Name = "label9";
            label9.Size = new Size(85, 17);
            label9.TabIndex = 4;
            label9.Text = "Amount (₱):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 11.25F);
            label8.Location = new Point(29, 435);
            label8.Name = "label8";
            label8.Size = new Size(103, 17);
            label8.TabIndex = 3;
            label8.Text = "Total Price (₱):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label3.Location = new Point(139, 10);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 2;
            label3.Text = "Orders";
            // 
            // productAvail_searchText
            // 
            productAvail_searchText.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productAvail_searchText.Location = new Point(18, 31);
            productAvail_searchText.Name = "productAvail_searchText";
            productAvail_searchText.Size = new Size(349, 26);
            productAvail_searchText.TabIndex = 28;
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
            btn_search_availProduct.Size = new Size(88, 27);
            btn_search_availProduct.TabIndex = 29;
            btn_search_availProduct.TextColor = Color.White;
            btn_search_availProduct.UseVisualStyleBackColor = false;
            btn_search_availProduct.Click += btn_search_availProduct_Click;
            // 
            // btn_cart_clear
            // 
            btn_cart_clear.BackColor = Color.SteelBlue;
            btn_cart_clear.BackGroundColor = Color.SteelBlue;
            btn_cart_clear.BorderColor = Color.SteelBlue;
            btn_cart_clear.BorderRadius = 10;
            btn_cart_clear.BorderSize = 3;
            btn_cart_clear.FlatAppearance.BorderSize = 0;
            btn_cart_clear.FlatStyle = FlatStyle.Flat;
            btn_cart_clear.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cart_clear.ForeColor = Color.White;
            btn_cart_clear.Location = new Point(919, 24);
            btn_cart_clear.Name = "btn_cart_clear";
            btn_cart_clear.Size = new Size(118, 33);
            btn_cart_clear.TabIndex = 35;
            btn_cart_clear.Text = "Clear";
            btn_cart_clear.TextColor = Color.White;
            btn_cart_clear.UseVisualStyleBackColor = false;
            btn_cart_clear.Click += btn_cart_clear_Click;
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.AutoScroll = true;
            flowLayoutPanelProducts.Location = new Point(18, 69);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(705, 686);
            flowLayoutPanelProducts.TabIndex = 36;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // CashierOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanelProducts);
            Controls.Add(btn_cart_clear);
            Controls.Add(btn_search_availProduct);
            Controls.Add(productAvail_searchText);
            Controls.Add(panel1);
            Name = "CashierOrder";
            Size = new Size(1054, 770);
            Load += CashierOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private RoundedButton btn_order_checkout;
        private Label order_totalPrice;
        private Label order_change;
        private TextBox order_amount;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label3;
        private TextBox productAvail_searchText;
        private RoundedButton btn_search_availProduct;
        private FlowLayoutPanel flowLayoutPanelCart;
        private RoundedButton btn_cart_clear;
        private FlowLayoutPanel flowLayoutPanelProducts;
        private PrintDialog printDialog1;
    }
}
