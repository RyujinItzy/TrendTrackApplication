using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrendTrackApplication.Data_Classes;
using TrendTrackApplication.Orders_Form;
using static System.Windows.Forms.AxHost;

namespace TrendTrackApplication.Cashier_User_Control
{
    public partial class CashierOrder : UserControl
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True";
        private ProductsData productsData = new ProductsData();
        private List<Product> cart = new List<Product>();
        private decimal totalPrice = 0;
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private int customerId=0;
        public CashierOrder()
        {
            InitializeComponent();

            InitializePrintPreview();

            PopulateProductsPanel();
        }
        private void InitializePrintPreview()
        {

            printDocument = new PrintDocument();
            printDocument.PrintPage += (s, ev) => PrintDocument_PrintPage(s, ev, customerId);

            printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 800,
                Height = 600
            };
        }
        private void order_totalPrice_Click(object sender, EventArgs e)
        {
        }
        private void order_change_Click(object sender, EventArgs e)
        {

        }
        private void CashierOrder_Load(object sender, EventArgs e)
        {

        }

        private void ProductCard_AddToCartClicked(object sender, EventArgs e)
        {
            if (sender is ProductCard productCard)
            {
                var product = new Product
                {
                    ProductID = productCard.ProductID,
                    ProductName = productCard.ProductName,
                    SalePrice = productCard.ProductPrice,
                    Stock = 1 
                };

                AddProductToCart(product);
            }
        }

        private void PopulateProductsPanel()
        {
            var availableProducts = productsData.GetAvailableProducts();

            foreach (var product in availableProducts)
            {
                var productCard = new ProductCard
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    ProductImage = Image.FromFile(product.ImagePath),
                    ProductPrice = product.SalePrice
                };

                productCard.AddToCartClicked += ProductCard_AddToCartClicked;

                flowLayoutPanelProducts.Controls.Add(productCard);
            }
        }

        private void AddProductToCart(Product product)
        {
            cart.Add(product);
            UpdateCart();
            UpdateTotalPrice();
        }

        private void RemoveProductFromCart(Product product)
        {
            cart.Remove(product);
            UpdateCart();
            UpdateTotalPrice();
        }

        private void UpdateCart()
        {
            flowLayoutPanelCart.Controls.Clear();

            foreach (var product in cart)
            {
                var cartCard = new CartCard
                {
                   // ProductID = product.ProductID,(i wanna put this here)

                    ProductName = product.ProductName,
                    ProductPrice = product.SalePrice
                };

                cartCard.RemoveClicked += (sender, e) => RemoveProductFromCart(product);
                flowLayoutPanelCart.Controls.Add(cartCard);
            }
        }

        private void btn_cart_clear_Click(object sender, EventArgs e)
        {
            flowLayoutPanelCart.Controls.Clear();
            cart.Clear();
            UpdateTotalPrice();
        }

        private void btn_search_availProduct_Click(object sender, EventArgs e)
        {
            var searchText = productAvail_searchText.Text.ToLower();
            var filteredProducts = productsData.GetAvailableProducts()
                .Where(product =>
                    product.ProductName.ToLower().Contains(searchText) ||
                    product.SalePrice.ToString().Contains(searchText))
                .ToList();

            flowLayoutPanelProducts.Controls.Clear();

            foreach (var product in filteredProducts)
            {
                var productCard = new ProductCard
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    ProductImage = Image.FromFile(product.ImagePath),
                    ProductPrice = product.SalePrice
                };

                productCard.AddToCartClicked += ProductCard_AddToCartClicked;
                flowLayoutPanelProducts.Controls.Add(productCard);
            }
        }

        private void UpdateTotalPrice()
        {
            totalPrice = cart.Sum(product => product.SalePrice);
            order_totalPrice.Text = $"₱{totalPrice:N2}"; 
            UpdateChange();
        }

        private void order_amount_TextChanged(object sender, EventArgs e)
        {
            UpdateChange();
        }

        private void UpdateChange()
        {
            if (decimal.TryParse(order_amount.Text, out decimal amount))
            {
                var change = amount - totalPrice;
                order_change.Text = change >= 0 ? $"₱{change:N2}" : "Insufficient Amount"; 
            }
            else
            {
                order_change.Text = "Invalid Amount";
            }
        }

        private void btn_order_checkout_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Cart is empty. Unable to checkout.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!decimal.TryParse(order_amount.Text, out decimal amount))
            {
                MessageBox.Show("Invalid amount entered. Please enter a valid number.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (amount < totalPrice)
            {
                MessageBox.Show("Insufficient amount. Please enter an amount equal to or greater than the total price.", "Insufficient Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var change = amount - totalPrice;
            order_change.Text = change.ToString("C");

            var result = MessageBox.Show($"Total Price: {totalPrice:C}\nDo you want to proceed with the checkout?", "Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var customersData = new CustomersData(connectionString);
                var customerId = customersData.AddCustomer(totalPrice, amount, change);

                var ordersData = new OrdersData(connectionString);
                foreach (var product in cart)
                {
                    int quantity = cart.Count(p => p.ProductID == product.ProductID);

                    decimal subtotal = quantity * product.SalePrice;

                    ordersData.InsertOrderRecord(customerId, product.ProductID, quantity, product.SalePrice, subtotal);
                }

                MessageBox.Show("Checkout successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Print the receipt
                PrintReceipt();

                // Clear the order amount and cart
                order_amount.Text = "";
                btn_cart_clear_Click(sender, e);
            }
        }
        private void PrintReceipt()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (s, ev) => PrintDocument_PrintPage(s, ev, customerId);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e, int customerId)
        {
            DateTime currentDate = DateTime.Now;

            float startX = e.MarginBounds.Left;

            e.Graphics.DrawString("Trend Track Clothing Shop", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(startX, 10));

            e.Graphics.DrawString("Receipt Details", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(startX, 30));
            e.Graphics.DrawString("--------------------", new Font("Arial", 10), Brushes.Black, new PointF(startX, 50));
            e.Graphics.DrawString($"Date: {currentDate}", new Font("Arial", 10), Brushes.Black, new PointF(startX, 70));
            e.Graphics.DrawString("--------------------", new Font("Arial", 10), Brushes.Black, new PointF(startX, 90));
            e.Graphics.DrawString("Products:", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new PointF(startX, 110));

            float yPos = 130; 

            var productQuantities = new Dictionary<string, int>();

            foreach (var product in cart)
            {
                if (productQuantities.ContainsKey(product.ProductID))
                {
                    productQuantities[product.ProductID]++;
                }
                else
                {
                    productQuantities[product.ProductID] = 1;
                }
            }

            foreach (var entry in productQuantities)
            {
                var product = cart.First(p => p.ProductID == entry.Key);
                int quantity = entry.Value;
                decimal subtotal = quantity * product.SalePrice;
                string productDetails = $"{product.ProductID} - {product.ProductName}: ₱{product.SalePrice:N2} x {quantity} = ₱{subtotal:N2}";

                e.Graphics.DrawString(productDetails, new Font("Arial", 10), Brushes.Black, new PointF(startX, yPos));

                yPos += 20; 
            }

            e.Graphics.DrawString("--------------------", new Font("Arial", 10), Brushes.Black, new PointF(startX, yPos));
            e.Graphics.DrawString($"Total Price: ₱{totalPrice:N2}", new Font("Arial", 10), Brushes.Black, new PointF(startX, yPos + 20));
            e.Graphics.DrawString($"Amount Paid: ₱{order_amount.Text}", new Font("Arial", 10), Brushes.Black, new PointF(startX, yPos + 40));
            e.Graphics.DrawString($"Change: ₱{order_change.Text}", new Font("Arial", 10), Brushes.Black, new PointF(startX, yPos + 60));
        }
    }
}
