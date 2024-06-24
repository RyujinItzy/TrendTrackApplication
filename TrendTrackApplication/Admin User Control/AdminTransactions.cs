using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrendTrackApplication.Data_Classes;

namespace TrendTrackApplication.Admin_User_Control
{
    public partial class AdminTransactions : UserControl
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True";
        private OrdersData ordersData;
        private int currentPage = 1;
        private int pageSize = 20;
        private int totalRecords = 0;
        private int totalPages = 0;
        public AdminTransactions()
        {
            InitializeComponent();
            ordersData = new OrdersData(connectionString);
            LoadOrders();
        }
        
        
       
        private void LoadOrders()
        {
            var orders = ordersData.GetOrders(currentPage, pageSize, out totalRecords);
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            dataGridView1.DataSource = orders;
            UpdatePageInfo();
            // Change OrderID header text to Transaction
            if (dataGridView1.Columns["OrderID"] != null)
            {
                dataGridView1.Columns["OrderID"].HeaderText = "Transaction";
            }
        }
  
        private void AdminTransactions_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
        private void UpdatePageInfo()
        {
            currentPage_txtbox.Text = currentPage.ToString();
            btn_order_previousPage.Enabled = currentPage > 1;
            btn_order_nextPage.Enabled = currentPage < totalPages;
        }

        private void btn_search_order_Click(object sender, EventArgs e)
        {
            if (int.TryParse(order_searchText.Text.Trim(), out int orderId))
            {
                SearchOrder(orderId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Transaction ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SearchOrder(int orderId)
        {
            var orders = ordersData.SearchOrderById(orderId, currentPage, pageSize, out totalRecords);
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            dataGridView1.DataSource = orders;
            UpdatePageInfo();
            if (dataGridView1.Columns["OrderID"] != null)
            {
                dataGridView1.Columns["OrderID"].HeaderText = "Transaction";
            }
        }

        private void btn_order_previousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadOrders();
            }
        }



        private void btn_order_nextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadOrders();
            }
        }

        private void currentPage_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(currentPage_txtbox.Text, out int page) && page >= 1 && page <= totalPages)
            {
                currentPage = page;
                LoadOrders();
            }
            else
            {
                currentPage_txtbox.Text = currentPage.ToString();
            }
        }
    }
}
