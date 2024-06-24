using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrendTrackApplication.Orders_Form
{
    public partial class ProductCard : UserControl
    {
        private string productName;
        private decimal productPrice;
        private string productImage;
        public string ProductID { get; set; }


        public string ProductName
        {
            get { return productName; }
            set
            {
                productName = value;
                lbl_ProdName.Text = productName;
            }
        }

        public decimal ProductPrice
        {
            get { return productPrice; }
            set
            {
                productPrice = value;
                lbl_prodPrice.Text = $"₱{productPrice.ToString("N2")}";
            }
        }

        public Image ProductImage
        {
            get { return pictureOfProduct.Image; }
            set { pictureOfProduct.Image = value; }
        }

        public event EventHandler AddToCartClicked;

        public ProductCard()
        {
            InitializeComponent();

        }
        public void SubscribeToAddToCartEvent()
        {
            btn_addToCart.Click += (s, e) => AddToCartClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btn_addToCart_Click(object sender, EventArgs e)
        {
            AddToCartClicked?.Invoke(this, EventArgs.Empty);
        }

        private void lbl_prodPrice_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ProdName_Click(object sender, EventArgs e)
        {

        }

        private void pictureOfProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
