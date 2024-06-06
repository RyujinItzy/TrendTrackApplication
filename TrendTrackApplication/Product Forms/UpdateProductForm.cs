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
using TrendTrackApplication.Data_Classes;

namespace TrendTrackApplication.Product_Forms
{
    public partial class UpdateProductForm : Form
    {
        private readonly SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf;Integrated Security=True");
        private string productID;
        private string originalImagePath;

        public UpdateProductForm(string prodID, string prodName, string categoryName, decimal costPrice, decimal salePrice, int stock, string imagePath, string status)
        {
            InitializeComponent();
            productID = prodID;
            originalImagePath = imagePath;
            PopulateCategoryComboBox(categoryName);
            products_prodID.Text = prodID;
            products_prodName.Text = prodName;
            products_category_cb.SelectedItem = categoryName;
            products_costPrice.Text = costPrice.ToString();
            products_salesPrice.Text = salePrice.ToString();
            products_stock.Text = stock.ToString();
            products_status_cb.SelectedItem = status;
            products_picture.ImageLocation = imagePath;
        }
        private void PopulateCategoryComboBox(string selectedCategory)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }

                string categoryQuery = "SELECT category FROM Categories";
                SqlCommand categoryCmd = new SqlCommand(categoryQuery, connect);
                SqlDataReader reader = categoryCmd.ExecuteReader();

                while (reader.Read())
                {
                    products_category_cb.Items.Add(reader["category"].ToString());
                }

                if (!string.IsNullOrEmpty(selectedCategory))
                {
                    products_category_cb.SelectedItem = selectedCategory;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }


        private bool CheckConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            return connect.State == ConnectionState.Open;
        }

        private void btn_products_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(products_prodID.Text) || string.IsNullOrEmpty(products_prodName.Text) ||
               products_category_cb.SelectedIndex == -1 || string.IsNullOrEmpty(products_costPrice.Text) ||
               string.IsNullOrEmpty(products_salesPrice.Text) || string.IsNullOrEmpty(products_stock.Text) ||
               products_status_cb.SelectedIndex == -1 || products_picture.Image == null)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True"))
                {
                    connect.Open();

                    // Retrieve category ID based on the selected category name
                    string categoryName = products_category_cb.SelectedItem.ToString();
                    string categoryQuery = "SELECT categoryID FROM Categories WHERE category = @categoryName";
                    using (SqlCommand categoryCmd = new SqlCommand(categoryQuery, connect))
                    {
                        categoryCmd.Parameters.AddWithValue("@categoryName", categoryName);

                        object result = categoryCmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            int categoryID = Convert.ToInt32(result);

                            // Handle image saving
                            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                            string relativePath = Path.Combine("Product_Directory", products_prodID.Text.Trim() + ".jpg");
                            string path = Path.Combine(baseDirectory, relativePath);
                            string directoryPath = Path.GetDirectoryName(path);

                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            if (products_picture.ImageLocation != originalImagePath)
                            {
                                File.Copy(products_picture.ImageLocation, path, true);
                            }
                            else
                            {
                                path = originalImagePath;
                            }

                            // Update product data
                            string updateData = "UPDATE Products SET productName = @prodName, categoryID = @catID, " +
                                                "costPrice = @costPrice, salePrice = @salePrice, stock = @stock, " +
                                                "image_path = @path, status = @status WHERE productID = @prodID";
                            using (SqlCommand updateCmd = new SqlCommand(updateData, connect))
                            {
                                updateCmd.Parameters.AddWithValue("@prodID", productID);
                                updateCmd.Parameters.AddWithValue("@prodName", products_prodName.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@catID", categoryID);
                                updateCmd.Parameters.AddWithValue("@costPrice", products_costPrice.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@salePrice", products_salesPrice.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@stock", products_stock.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@path", path);
                                updateCmd.Parameters.AddWithValue("@status", products_status_cb.SelectedItem.ToString());

                                updateCmd.ExecuteNonQuery();
                                MessageBox.Show("Product updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Category not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_products_import_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = "Image Files (*.jpg; *.png)|*.jpg; *.png"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    products_picture.ImageLocation = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (CheckConnection())
                {
                    string categoryQuery = "SELECT category FROM Categories";
                    SqlCommand categoryCmd = new SqlCommand(categoryQuery, connect);
                    SqlDataReader reader = categoryCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        products_category_cb.Items.Add(reader["category"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        private void btn_products_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            products_prodID.Text = "";
            products_prodName.Text = "";
            products_category_cb.SelectedIndex = -1;
            products_costPrice.Text = "";
            products_salesPrice.Text = "";
            products_stock.Text = "";
            products_status_cb.SelectedIndex = -1;
            products_picture.Image = null;
        }
    }
}