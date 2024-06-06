using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TrendTrackApplication
{
    public partial class CashierOrders : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True");

        public CashierOrders()
        {
            InitializeComponent();
            displayAllAvailableProducts();
            displayAllCategories();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public void displayAllAvailableProducts()
        {
            try
            {
                ProductsData apData = new ProductsData();
                //List<Product> listData = apData.GetAvailableProducts();

               // dataGridView1.DataSource = listData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load products: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void displayAllCategories()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM Categories";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string item = reader.GetString(1);
                                order_category.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed Connection: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void order_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            order_prodID.SelectedIndex = -1;
            order_prodID.Items.Clear();
            order_name.Text = "";
            order_price.Text = "";


            string selectedValue = order_category.SelectedItem as string;

            if (selectedValue != null)
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string selectData = $"SELECT * FROM Products WHERE category = '{selectedValue}' AND status = @status";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string value = reader["productID"].ToString();
                                    order_prodID.Items.Add(value);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void order_prodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = order_prodID.SelectedItem as string;

            if(checkConnection())
            {
                if(selectedValue != null)
                {
                    try
                    {
                        connect.Open();

                        string selectData = $"SELECT * FROM Products WHERE productID = '{selectedValue}' AND status = @status";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string prodName = reader["productName"].ToString();
                                    decimal prodPrice = Convert.ToDecimal(reader["price"]);

                                    order_name.Text = prodName;
                                    order_price.Text = prodPrice.ToString("0.00");

                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close() ;
                    }
                }
            }
        }
    }
}
