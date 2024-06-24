using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrendTrackApplication
{
    public partial class AdminDashboard : UserControl
    {
        private readonly SqlConnection connection = new SqlConnection( @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True");
        public AdminDashboard()
        {
            InitializeComponent();
            LoadNumberOfOrders();
            LoadTotalRevenue();
            LoadTotalProfit();
            LoadNumberOfUsers();
            LoadNumberOfCustomers();
            LoadNumberOfProducts();
            LoadTodaysCustomers();
            LoadTodaysProfit();
            LoadGrossRevenueChart();
            LoadProfitChart();
            LoadBestSellingProductsChart();
        }
        private void LoadBestSellingProductsChart()
        {
            try
            {
                connection.Open();

                string query = @"SELECT TOP 5 p.productName, SUM(o.quantity) AS TotalQuantity
                         FROM Products p
                         INNER JOIN Orders o ON p.productID = o.productID
                         GROUP BY p.productName
                         ORDER BY TotalQuantity DESC";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Lists to store product names and their corresponding quantities
                List<string> productNames = new List<string>();
                List<int> quantities = new List<int>();

                while (reader.Read())
                {
                    productNames.Add(reader.GetString(0));
                    quantities.Add(reader.GetInt32(1));
                }

                // Bind data to the chart
                chart_topProducts.Series[0].Points.DataBindXY(productNames, quantities);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        private void LoadProfitChart()
        {
            try
            {
                connection.Open();

                string query = @"SELECT DATEADD(dd, 0, DATEDIFF(dd, 0, o.date)) AS OrderDate, 
                                SUM((p.salePrice - p.costPrice) * o.quantity) AS Profit
                         FROM Orders o
                         INNER JOIN Products p ON o.productID = p.productID
                         GROUP BY DATEADD(dd, 0, DATEDIFF(dd, 0, o.date))
                         ORDER BY OrderDate";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<DateTime> dates = new List<DateTime>();
                List<decimal> profits = new List<decimal>();

                while (reader.Read())
                {
                    dates.Add(reader.GetDateTime(0));
                    profits.Add(reader.GetDecimal(1));
                }

                chart_profitChart.Series[0].Points.DataBindXY(dates, profits);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        private void LoadGrossRevenueChart()
        {
            try
            {
                connection.Open();

                string query = @"SELECT CONVERT(date, date) AS OrderDate, SUM(totalPrice) AS TotalRevenue
                         FROM Orders
                         GROUP BY CONVERT(date, date)
                         ORDER BY CONVERT(date, date)";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                chart_grossRevenue.Series.Clear();

                chart_grossRevenue.Series.Add("Gross Revenue");

                chart_grossRevenue.Series["Gross Revenue"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                chart_grossRevenue.Series["Gross Revenue"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;

                chart_grossRevenue.Series["Gross Revenue"].XValueMember = "OrderDate";
                chart_grossRevenue.Series["Gross Revenue"].YValueMembers = "TotalRevenue";
                chart_grossRevenue.DataSource = dataTable;

                // Refresh the chart
                chart_grossRevenue.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadTodaysProfit()
        {
            try
            {
                connection.Open();

                string query = @"SELECT SUM((o.totalPrice - p.costPrice * o.quantity)) 
                        FROM Orders o
                        INNER JOIN Products p ON o.productID = p.productID
                        WHERE CONVERT(date, o.date) = CONVERT(date, GETDATE())";

                SqlCommand command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();

                decimal todaysProfit = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                lbl_todaysProfit.Text = "₱" + todaysProfit.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        private void LoadTodaysCustomers()
        {
            try
            {
                connection.Open();

                string query = "SELECT COUNT(DISTINCT customerID) FROM Orders WHERE CONVERT(date, date) = CONVERT(date, GETDATE())";
                SqlCommand command = new SqlCommand(query, connection);
                int todaysCustomers = (int)command.ExecuteScalar();

                lbl_todaysCustomer.Text = todaysCustomers.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        private void LoadNumberOfProducts()
        {
            try
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Products";
                SqlCommand command = new SqlCommand(query, connection);
                int numberOfProducts = (int)command.ExecuteScalar();

                lbl_numberOfProducts.Text = numberOfProducts.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        private void LoadNumberOfCustomers()
        {
            try
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Customers";
                SqlCommand command = new SqlCommand(query, connection);
                int numberOfCustomers = (int)command.ExecuteScalar();

                lbl_numberOfCustomers.Text = numberOfCustomers.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        private void LoadTotalRevenue()
        {
            try
            {
                connection.Open();

                string query = "SELECT SUM(TotalPrice) FROM Orders";
                SqlCommand command = new SqlCommand(query, connection);
                object totalRevenue = command.ExecuteScalar();

                if (totalRevenue != DBNull.Value)
                {
                    CultureInfo culture = new CultureInfo("fil-PH"); 
                    lbl_totalRevenue.Text = Convert.ToDecimal(totalRevenue).ToString("C", culture);
                }
                else
                {
                    lbl_totalRevenue.Text = "₱0.00"; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadTotalProfit()
        {
            try
            {
                connection.Open();

                // Retrieve total revenue
                string revenueQuery = "SELECT SUM(totalPrice) FROM Orders";
                SqlCommand revenueCommand = new SqlCommand(revenueQuery, connection);
                object totalRevenueObj = revenueCommand.ExecuteScalar();
                decimal totalRevenue = (totalRevenueObj != DBNull.Value) ? Convert.ToDecimal(totalRevenueObj) : 0;

                // Retrieve total cost
                string costQuery = "SELECT SUM(Orders.quantity * Products.costPrice) " +
                                   "FROM Orders " +
                                   "JOIN Products ON Orders.productID = Products.productID";
                SqlCommand costCommand = new SqlCommand(costQuery, connection);
                object totalCostObj = costCommand.ExecuteScalar();
                decimal totalCost = (totalCostObj != DBNull.Value) ? Convert.ToDecimal(totalCostObj) : 0;


                decimal profit = totalRevenue - totalCost;

                CultureInfo culture = new CultureInfo("fil-PH"); 
                lbl_totalProfit.Text = profit.ToString("C", culture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        private void LoadNumberOfOrders()
        {
            try
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Orders";
                SqlCommand command = new SqlCommand(query, connection);
                int numberOfOrders = (int)command.ExecuteScalar();

                lbl_NumberOfOrders.Text = numberOfOrders.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        private void LoadNumberOfUsers()
        {
            try
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users";
                SqlCommand command = new SqlCommand(query, connection);
                int numberOfUsers = (int)command.ExecuteScalar();

                lbl_NumberOfUsers.Text = numberOfUsers.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
