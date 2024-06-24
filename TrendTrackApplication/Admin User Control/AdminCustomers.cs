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

namespace TrendTrackApplication
{
    public partial class AdminCustomers : UserControl
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True";
        private CustomersData customersData;
        private int currentPage = 1;
        private int totalPages = 1;
        private int pageSize = 20;

        public AdminCustomers()
        {
            InitializeComponent();
            customersData = new CustomersData(connectionString);
            DisplayAllCustomersData();
        }
    
        private void AdminCustomers_Load(object sender, EventArgs e)
        {
        }

        private void btn_customers_previousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayCurrentPage();
            }
        }

        private void currentPage_txtbox_TextChanged(object sender, EventArgs e)
        {
            LoadSpecifiedPage();
        }
       

        private void btn_customers_nextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                DisplayCurrentPage();
            }

        }
        private void DisplayAllCustomersData()
        {
           try
            {
                int totalRecords;
                var customers = customersData.GetCustomers(currentPage, pageSize, out totalRecords);
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

                dataGridView1.DataSource = customers;
                dataGridView1.AutoGenerateColumns = true;

                dataGridView1.Columns["CustomerID"].HeaderText = "Customer ID";
                dataGridView1.Columns["Price"].HeaderText = "Price";
                dataGridView1.Columns["Amount"].HeaderText = "Amount Paid";
                dataGridView1.Columns["Change"].HeaderText = "Change";
                dataGridView1.Columns["Date"].HeaderText = "Date";

                currentPage_txtbox.Text = currentPage.ToString();
                btn_customers_previousPage.Enabled = currentPage > 1;
                btn_customers_nextPage.Enabled = currentPage < totalPages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayCurrentPage()
        {
            try
            {
                int totalRecords;
                var customers = customersData.GetCustomers(currentPage, pageSize, out totalRecords);
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

                dataGridView1.DataSource = customers;

                dataGridView1.Columns["CustomerID"].HeaderText = "Customer ID";
                dataGridView1.Columns["Price"].HeaderText = "Price";
                dataGridView1.Columns["Amount"].HeaderText = "Amount Paid";
                dataGridView1.Columns["Change"].HeaderText = "Change";
                dataGridView1.Columns["Date"].HeaderText = "Date";

                currentPage_txtbox.Text = currentPage.ToString();
                btn_customers_previousPage.Enabled = currentPage > 1;
                btn_customers_nextPage.Enabled = currentPage < totalPages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSpecifiedPage()
        {
            if (int.TryParse(currentPage_txtbox.Text, out int pageNumber))
            {
                if (pageNumber >= 1 && pageNumber <= totalPages)
                {
                    currentPage = pageNumber;
                    DisplayCurrentPage();
                }
                else
                {
                    MessageBox.Show("Invalid page number. Please enter a number between 1 and " + totalPages + ".", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid page number. Please enter a valid number.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplaySearchResults(int customerId)
        {
            try
            {
                int totalRecords;
                var customers = customersData.SearchCustomerById(customerId, currentPage, pageSize, out totalRecords);
                totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

                dataGridView1.DataSource = customers;
                dataGridView1.AutoGenerateColumns = true;

                dataGridView1.Columns["CustomerID"].HeaderText = "Customer ID";
                dataGridView1.Columns["Price"].HeaderText = "Price";
                dataGridView1.Columns["Amount"].HeaderText = "Amount Paid";
                dataGridView1.Columns["Change"].HeaderText = "Change";
                dataGridView1.Columns["Date"].HeaderText = "Date";

                currentPage_txtbox.Text = currentPage.ToString();
                btn_customers_previousPage.Enabled = currentPage > 1;
                btn_customers_nextPage.Enabled = currentPage < totalPages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_customer_Click(object sender, EventArgs e)
        {
            string searchQuery = customers_searchText.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                DisplayAllCustomersData();
            }
            else
            {
                if (int.TryParse(searchQuery, out int customerId))
                {
                    DisplaySearchResults(customerId);
                }
                else
                {
                    MessageBox.Show("Please enter a valid Customer ID.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
