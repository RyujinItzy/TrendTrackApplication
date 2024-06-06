using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace TrendTrackApplication
{
    public class UsersData
    {
        public int UserID { get; set; }
       
        public string Username { get; set; }
        
        public string Password { get; set; }
  
        public string Role { get; set; }
   
        public string Status { get; set; }
        public DateTime Date { get; set; }

        public List<UsersData> AllUsersData()
        {
            List<UsersData> listData = new List<UsersData>();

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True";

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT * FROM Users";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        UsersData udata = new UsersData
                        {
                            UserID = (int)reader["userID"],
                            Username = reader["username"].ToString(),
                            Password = reader["password"].ToString(),
                            Role = reader["role"].ToString(),
                            Status = reader["status"].ToString(),
                            Date = (DateTime)reader["dateCreated"]
                        };

                        listData.Add(udata);
                    }
                }
            }
            return listData;
        }
    }
}