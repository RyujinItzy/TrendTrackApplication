using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TrendTrackApplication
{
    class CategoriesData
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public DateTime Date {  get; set; }
        public List<CategoriesData> AllCategoriesData()
        {
            List<CategoriesData> listData = new List<CategoriesData>();

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True";

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT * FROM Categories";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        CategoriesData cdata = new CategoriesData(); 
                        cdata.CategoryID = (int)reader["categoryID"]; 
                        cdata.CategoryName = reader["category"].ToString();
                        cdata.Date = (DateTime)reader["dateCreated"];

                        listData.Add(cdata);
                    }
                }
            }
            return listData;
        }
    }
}
