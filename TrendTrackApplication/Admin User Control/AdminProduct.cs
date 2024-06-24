using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TrendTrackApplication.Product_Forms;

namespace TrendTrackApplication.Admin_User_Control
{
    public partial class AdminProduct : UserControl
    {
        private readonly SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True");
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True";
        private int currentPage = 1;
        private int totalPages = 1;
        private int itemsPerPage = 20;

        public AdminProduct()
        {
            InitializeComponent();
            DisplayAllProductsData();
        }

        private void btn_products_add_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            DisplayAllProductsData();
            LogActivity("Added a new product");
        }

        private void btn_products_update_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                string productID = selectedRow.Cells["productID"].Value.ToString();
                string productName = selectedRow.Cells["productName"].Value.ToString();
                string categoryName = selectedRow.Cells["CategoryName"].Value.ToString(); 
                decimal costPrice = Convert.ToDecimal(selectedRow.Cells["costPrice"].Value);
                decimal salePrice = Convert.ToDecimal(selectedRow.Cells["salePrice"].Value);
                int stock = Convert.ToInt32(selectedRow.Cells["stock"].Value);
                string imagePath = selectedRow.Cells["image_path"].Value.ToString();
                string status = selectedRow.Cells["status"].Value.ToString();

                UpdateProductForm updateProductForm = new UpdateProductForm(productID, productName, categoryName, costPrice, salePrice, stock, imagePath, status);
                updateProductForm.ShowDialog();
                DisplayAllProductsData();
                LogActivity($"Updated product with ID: {productID}");
            }
            else
            {
                MessageBox.Show("Please select a product to update.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_products_remove_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                string productID = selectedRow.Cells["productID"].Value.ToString();

                if (MessageBox.Show("Are you sure you want to remove this record?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True");
                    try
                    {
                        connect.Open();

                        // Archive the product
                        string archiveQuery = "INSERT INTO Archive (dataID, dataType, archivedData) " +
                                              "SELECT @productID, 'Product', " +
                                              "CONVERT(varbinary(MAX), (SELECT * FROM Products WHERE productID = @productID FOR XML PATH('')))";

                        using (SqlCommand archiveCmd = new SqlCommand(archiveQuery, connect))
                        {
                            archiveCmd.Parameters.AddWithValue("@productID", productID);
                            archiveCmd.ExecuteNonQuery();
                        }

                        // Remove the product
                        string deleteQuery = "DELETE FROM Products WHERE productID = @productID";

                        using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, connect))
                        {
                            deleteCmd.Parameters.AddWithValue("@productID", productID);
                            deleteCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Product removed and archived successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayAllProductsData();
                        LogActivity($"Removed and archived product with ID: {productID}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to remove product: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to remove.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_product_Click(object sender, EventArgs e)
        {
            string searchQuery = products_searchText.Text.Trim();
            DisplaySearchedProducts(searchQuery);
        }

        private void currentPage_txtbox_TextChanged(object sender, EventArgs e)
        {
            LoadSpecifiedPage();
        }

        private void btn_products_previousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayCurrentPage();
            }
        }

        private void btn_products_nextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                DisplayCurrentPage();
            }
        }
        private void DisplayAllProductsData()
        {
            try
            {
                int offset = (currentPage - 1) * itemsPerPage;
                string query = $"SELECT p.productID, p.productName, c.categoryID, c.category AS CategoryName, p.costPrice, p.salePrice, p.stock, p.image_path, p.status, p.date " +
                               $"FROM Products p " +
                               $"JOIN Categories c ON p.categoryID = c.categoryID " +
                               $"ORDER BY p.productID " +
                               $"OFFSET {offset} ROWS FETCH NEXT {itemsPerPage} ROWS ONLY";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView2.DataSource = table;
                dataGridView2.AutoGenerateColumns = true;

                // Set custom column header text
                dataGridView2.Columns["productID"].HeaderText = "Product Code";
                dataGridView2.Columns["productName"].HeaderText = "Product Name";
                dataGridView2.Columns["categoryID"].HeaderText = "Category ID";
                dataGridView2.Columns["CategoryName"].HeaderText = "Category Name";
                dataGridView2.Columns["costPrice"].HeaderText = "Cost Price";
                dataGridView2.Columns["salePrice"].HeaderText = "Sale Price";
                dataGridView2.Columns["stock"].HeaderText = "Stock";
                dataGridView2.Columns["image_path"].HeaderText = "Image Path";
                dataGridView2.Columns["status"].HeaderText = "Status";
                dataGridView2.Columns["date"].HeaderText = "Date";

                int totalRows = GetTotalRows();
                totalPages = (int)Math.Ceiling((double)totalRows / itemsPerPage);

                currentPage_txtbox.Text = currentPage.ToString();
                btn_products_previousPage.Enabled = currentPage > 1;
                btn_products_nextPage.Enabled = currentPage < totalPages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetTotalRows()
        {
            int totalRows = 0;
            string query = "SELECT COUNT(*) FROM Products";

            using (SqlCommand command = new SqlCommand(query, connect))
            {
                try
                {
                    connect.Open();
                    totalRows = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

            return totalRows;
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

        private void DisplayCurrentPage()
        {
            try
            {
                int offset = (currentPage - 1) * itemsPerPage;
                string query = $"SELECT p.productID, p.productName, c.categoryID, c.category AS CategoryName, p.costPrice, p.salePrice, p.stock, p.image_path, p.status, p.date " +
                               $"FROM Products p " +
                               $"JOIN Categories c ON p.categoryID = c.categoryID " +
                               $"ORDER BY p.productID " +
                               $"OFFSET {offset} ROWS FETCH NEXT {itemsPerPage} ROWS ONLY";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView2.DataSource = table;
                dataGridView2.AutoGenerateColumns = true;

                // Set custom column header text
                dataGridView2.Columns["productID"].HeaderText = "Product Code";
                dataGridView2.Columns["productName"].HeaderText = "Product Name";
                dataGridView2.Columns["categoryID"].HeaderText = "Category ID";
                dataGridView2.Columns["CategoryName"].HeaderText = "Category Name";
                dataGridView2.Columns["costPrice"].HeaderText = "Cost Price";
                dataGridView2.Columns["salePrice"].HeaderText = "Sale Price";
                dataGridView2.Columns["stock"].HeaderText = "Stock";
                dataGridView2.Columns["image_path"].HeaderText = "Image Path";
                dataGridView2.Columns["status"].HeaderText = "Status";
                dataGridView2.Columns["date"].HeaderText = "Date";

                currentPage_txtbox.Text = currentPage.ToString();
                btn_products_previousPage.Enabled = currentPage > 1;
                btn_products_nextPage.Enabled = currentPage < totalPages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplaySearchedProducts(string searchQuery)
        {
            try
            {
                string query = $"SELECT p.productID, p.productName, c.categoryID, c.category AS CategoryName, p.costPrice, p.salePrice, p.stock, p.image_path, p.status, p.date " +
                               $"FROM Products p " +
                               $"JOIN Categories c ON p.categoryID = c.categoryID " +
                               $"WHERE p.productID LIKE '%{searchQuery}%' " +
                               $"OR p.productName LIKE '%{searchQuery}%' " +
                               $"OR c.category LIKE '%{searchQuery}%' " +
                               $"OR p.costPrice LIKE '%{searchQuery}%' " +
                               $"OR p.salePrice LIKE '%{searchQuery}%' " +
                               $"OR p.status = '{searchQuery}'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView2.DataSource = table;
                dataGridView2.AutoGenerateColumns = true;

                // Set custom column header text
                dataGridView2.Columns["productID"].HeaderText = "Product Code";
                dataGridView2.Columns["productName"].HeaderText = "Product Name";
                dataGridView2.Columns["categoryID"].HeaderText = "Category ID";
                dataGridView2.Columns["CategoryName"].HeaderText = "Category Name";
                dataGridView2.Columns["costPrice"].HeaderText = "Cost Price";
                dataGridView2.Columns["salePrice"].HeaderText = "Sale Price";
                dataGridView2.Columns["stock"].HeaderText = "Stock";
                dataGridView2.Columns["image_path"].HeaderText = "Image Path";
                dataGridView2.Columns["status"].HeaderText = "Status";
                dataGridView2.Columns["date"].HeaderText = "Date";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LogActivity(string action)
        {
            string userID = "1"; 
            string query = "INSERT INTO ActivityLog (userID, action) VALUES (@userID, @action)";

            using (SqlConnection connect = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connect))
            {
                command.Parameters.AddWithValue("@userID", userID);
                command.Parameters.AddWithValue("@action", action);

                try
                {
                    connect.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to log activity: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void AdminProduct_Load(object sender, EventArgs e)
        {

        }
    }
}