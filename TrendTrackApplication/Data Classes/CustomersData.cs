using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendTrackApplication.Data_Classes
{
    public class CustomersData
    {
        private readonly string connectionString= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True";

        public CustomersData(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int AddCustomer(decimal price, decimal amountPaid, decimal change)
        {
            string query = "INSERT INTO Customers (price, amount, change, date) OUTPUT INSERTED.customerID VALUES (@Price, @Amount, @Change, @Date)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Amount", amountPaid);
                command.Parameters.AddWithValue("@Change", change);
                command.Parameters.AddWithValue("@Date", DateTime.Now);

                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }
        public DataTable GetCustomers(int pageNumber, int pageSize, out int totalRecords)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string countQuery = "SELECT COUNT(*) FROM Customers";
                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    connection.Open();
                    totalRecords = (int)countCommand.ExecuteScalar();
                }

                string query = @"SELECT CustomerID, Price, Amount, Change, Date 
                                 FROM Customers
                                 ORDER BY CustomerID
                                 OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Offset", (pageNumber - 1) * pageSize);
                    command.Parameters.AddWithValue("@PageSize", pageSize);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
        public DataTable SearchCustomerById(int customerId, int currentPage, int pageSize, out int totalRecords)
        {
            totalRecords = 0;
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT CustomerID, Price, Amount, Change, Date FROM Customers WHERE CustomerID = @CustomerID ORDER BY CustomerID OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";
                string countQuery = $"SELECT COUNT(*) FROM Customers WHERE CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    command.Parameters.AddWithValue("@Offset", (currentPage - 1) * pageSize);
                    command.Parameters.AddWithValue("@PageSize", pageSize);

                    countCommand.Parameters.AddWithValue("@CustomerID", customerId);

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
    }
}
