using System.Data.SqlClient;
using TrendTrackApplication.Data_Classes;

namespace TrendTrackApplication
{
    public class ProductsData
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True";

        public List<Product> GetAllProducts()
        {
            List<Product> listData = new List<Product>();

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT p.id, p.productID, p.productName, c.categoryID, c.category AS CategoryName, p.costPrice, p.salePrice, p.stock, p.image_path, p.status, p.date " +
                                    "FROM Products p " +
                                    "JOIN Categories c ON p.categoryID = c.categoryID";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Product pdata = new Product
                        {
                            Id = (int)reader["id"],
                            ProductID = reader["productID"].ToString(),
                            ProductName = reader["productName"].ToString(),
                            CategoryID = (int)reader["categoryID"],
                            CategoryName = reader["CategoryName"].ToString(),
                            CostPrice = (decimal)reader["costPrice"],
                            SalePrice = (decimal)reader["salePrice"],
                            Stock = (int)reader["stock"],
                            ImagePath = reader["image_path"].ToString(),
                            Status = reader["status"].ToString(),
                            Date = (DateTime)reader["date"]
                        };

                        listData.Add(pdata);
                    }
                }
            }
            return listData;
        }

        public List<Product> GetAvailableProducts()
        {
            List<Product> listData = new List<Product>();

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT p.id, p.productID, p.productName, c.categoryID, c.category AS CategoryName, p.costPrice, p.salePrice, p.stock, p.image_path, p.status, p.date " +
                                    "FROM Products p " +
                                    "JOIN Categories c ON p.categoryID = c.categoryID " +
                                    "WHERE p.status = @status";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@status", "Available");
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Product apdata = new Product
                        {
                            Id = (int)reader["id"],
                            ProductID = reader["productID"].ToString(),
                            ProductName = reader["productName"].ToString(),
                            CategoryID = (int)reader["categoryID"],
                            CategoryName = reader["CategoryName"].ToString(),
                            CostPrice = (decimal)reader["costPrice"],
                            SalePrice = (decimal)reader["salePrice"],
                            Stock = (int)reader["stock"],
                            ImagePath = reader["image_path"].ToString(),
                            Status = reader["status"].ToString(),
                            Date = (DateTime)reader["date"]
                        };

                        listData.Add(apdata);
                    }
                }
            }
            return listData;
        }
    }
}