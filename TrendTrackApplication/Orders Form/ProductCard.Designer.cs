namespace TrendTrackApplication.Orders_Form
{
    partial class ProductCard
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
            btn_addToCart = new RoundedButton();
            lbl_prodPrice = new Label();
            lbl_ProdName = new Label();
            pictureOfProduct = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureOfProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_addToCart);
            panel1.Controls.Add(lbl_prodPrice);
            panel1.Controls.Add(lbl_ProdName);
            panel1.Controls.Add(pictureOfProduct);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 179);
            panel1.TabIndex = 0;
            // 
            // btn_addToCart
            // 
            btn_addToCart.BackColor = Color.RoyalBlue;
            btn_addToCart.BackGroundColor = Color.RoyalBlue;
            btn_addToCart.BorderColor = Color.RoyalBlue;
            btn_addToCart.BorderRadius = 20;
            btn_addToCart.BorderSize = 0;
            btn_addToCart.FlatAppearance.BorderSize = 0;
            btn_addToCart.FlatStyle = FlatStyle.Flat;
            btn_addToCart.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_addToCart.ForeColor = Color.White;
            btn_addToCart.Location = new Point(43, 143);
            btn_addToCart.Name = "btn_addToCart";
            btn_addToCart.Size = new Size(129, 33);
            btn_addToCart.TabIndex = 4;
            btn_addToCart.Text = "Add to Cart\r\n";
            btn_addToCart.TextColor = Color.White;
            btn_addToCart.UseVisualStyleBackColor = false;
            btn_addToCart.Click += btn_addToCart_Click;
            // 
            // lbl_prodPrice
            // 
            lbl_prodPrice.AutoSize = true;
            lbl_prodPrice.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_prodPrice.Location = new Point(136, 121);
            lbl_prodPrice.Name = "lbl_prodPrice";
            lbl_prodPrice.Size = new Size(54, 19);
            lbl_prodPrice.TabIndex = 3;
            lbl_prodPrice.Text = "label1";
            lbl_prodPrice.Click += lbl_prodPrice_Click;
            // 
            // lbl_ProdName
            // 
            lbl_ProdName.AutoSize = true;
            lbl_ProdName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ProdName.Location = new Point(3, 121);
            lbl_ProdName.Name = "lbl_ProdName";
            lbl_ProdName.Size = new Size(54, 19);
            lbl_ProdName.TabIndex = 1;
            lbl_ProdName.Text = "label1";
            lbl_ProdName.Click += lbl_ProdName_Click;
            // 
            // pictureOfProduct
            // 
            pictureOfProduct.Location = new Point(3, 3);
            pictureOfProduct.Name = "pictureOfProduct";
            pictureOfProduct.Size = new Size(213, 115);
            pictureOfProduct.SizeMode = PictureBoxSizeMode.Zoom;
            pictureOfProduct.TabIndex = 0;
            pictureOfProduct.TabStop = false;
            pictureOfProduct.Click += pictureOfProduct_Click;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            Controls.Add(panel1);
            Name = "ProductCard";
            Size = new Size(225, 185);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureOfProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_ProdName;
        private PictureBox pictureOfProduct;
        private Label lbl_prodPrice;
        private RoundedButton btn_addToCart;
    }
}
