using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendTrackApplication.Data_Classes
{
    public class OrdersData
    {
        private readonly string connectionString;

        public OrdersData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable GetOrders(int currentPage, int pageSize, out int totalRecords)
        {
            totalRecords = 0;
            DataTable dataTable = new DataTable();

            int startIndex = (currentPage - 1) * pageSize;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT OrderID, CustomerID, ProductID, Quantity, OriginalPrice, TotalPrice, Date FROM Orders ORDER BY OrderID DESC OFFSET {startIndex} ROWS FETCH NEXT {pageSize} ROWS ONLY";
                string countQuery = "SELECT COUNT(*) FROM Orders";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    connection.Open();
                    totalRecords = (int)countCommand.ExecuteScalar();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public DataTable SearchOrderById(int orderId, int pageNumber, int pageSize, out int totalRecords)
        {
            totalRecords = 0;
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT OrderID, CustomerID, ProductID, Quantity, OriginalPrice, TotalPrice, Date FROM Orders WHERE OrderID = @OrderID ORDER BY OrderID DESC OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";
                string countQuery = $"SELECT COUNT(*) FROM Orders WHERE OrderID = @OrderID";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    command.Parameters.AddWithValue("@OrderID", orderId);
                    command.Parameters.AddWithValue("@Offset", (pageNumber - 1) * pageSize);
                    command.Parameters.AddWithValue("@PageSize", pageSize);

                    countCommand.Parameters.AddWithValue("@OrderID", orderId);

                    connection.Open();
                    totalRecords = (int)countCommand.ExecuteScalar();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public void InsertOrderRecord(int customerID, string productID, int quantity, decimal originalPrice, decimal totalPrice)
        {
            string query = @"INSERT INTO Orders (customerID, productID, quantity, originalPrice, totalPrice, date) 
                             VALUES (@CustomerID, @ProductID, @Quantity, @OriginalPrice, @TotalPrice, @Date)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@ProductID", productID);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@OriginalPrice", originalPrice);
                command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                command.Parameters.AddWithValue("@Date", DateTime.Now);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}