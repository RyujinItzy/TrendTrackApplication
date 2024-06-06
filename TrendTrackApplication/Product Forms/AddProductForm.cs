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

namespace TrendTrackApplication.Product_Forms
{
    public partial class AddProductForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True");

        public AddProductForm()
        {
            InitializeComponent();
            //LoadCategories();
        }

        private bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            return connect.State == ConnectionState.Open;
        }

        private void btn_products_add_Click(object sender, EventArgs e)
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

                            File.Copy(products_picture.ImageLocation, path, true);

                            // Insert product data
                            string insertData = "INSERT INTO Products (productID, productName, categoryID, costPrice, salePrice, stock, image_path, status, date)" +
                                                "VALUES (@prodID, @prodName, @catID, @costprice, @saleprice, @stock, @path, @status, @date)";
                            using (SqlCommand insertCmd = new SqlCommand(insertData, connect))
                            {
                                insertCmd.Parameters.AddWithValue("@prodID", products_prodID.Text.Trim());
                                insertCmd.Parameters.AddWithValue("@prodName", products_prodName.Text.Trim());
                                insertCmd.Parameters.AddWithValue("@catID", categoryID); // Use the retrieved category ID
                                insertCmd.Parameters.AddWithValue("@costprice", products_costPrice.Text.Trim());
                                insertCmd.Parameters.AddWithValue("@saleprice", products_salesPrice.Text.Trim());
                                insertCmd.Parameters.AddWithValue("@stock", products_stock.Text.Trim());
                                insertCmd.Parameters.AddWithValue("@path", path);
                                insertCmd.Parameters.AddWithValue("@status", products_status_cb.SelectedItem.ToString());
                                insertCmd.Parameters.AddWithValue("@date", DateTime.Now);

                                insertCmd.ExecuteNonQuery();
                                MessageBox.Show("Product added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Failed to add product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_products_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
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
     
        private void AddProductForm_Load(object sender, EventArgs e)
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
    }
}