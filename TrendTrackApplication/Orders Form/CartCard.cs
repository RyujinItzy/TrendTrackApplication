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
    public partial class CartCard : UserControl
    {
        public event EventHandler RemoveClicked;
        public CartCard()
        {
            InitializeComponent();
        }
        public string ProductName
        {
            get { return lbl_ProdName.Text; }
            set { lbl_ProdName.Text = value; }
        }

        public decimal ProductPrice
        {
            get { return decimal.Parse(lbl_ProdPrice.Text.Replace("₱", "")); }
            set { lbl_ProdPrice.Text = $"₱{value.ToString()}"; }
        }


        private void lbl_ProdName_Click(object sender, EventArgs e)
        {

        }

        private void lbl_remove_Click(object sender, EventArgs e)
        {
            RemoveClicked?.Invoke(this, EventArgs.Empty);
        }


        private void lbl_ProdPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
