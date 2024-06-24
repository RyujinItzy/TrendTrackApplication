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

namespace TrendTrackApplication.Admin_User_Control
{
    public partial class AdminActivityLog : UserControl
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True";
        public AdminActivityLog()
        {
            InitializeComponent();
            LoadActivityLog();  
        }
        private void LoadActivityLog()
        {
            string query = "SELECT logID, userID, action, date FROM ActivityLog";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                dataGridView1.Columns["logID"].HeaderText = "Log ID";
                dataGridView1.Columns["userID"].HeaderText = "User ID";
                dataGridView1.Columns["action"].HeaderText = "Action";
                dataGridView1.Columns["date"].HeaderText = "Date";
            }
        }
    }
}
