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

namespace TrendTrackApplication
{
    public partial class AdminArchive : UserControl
    {
        private readonly SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True");

        public AdminArchive()
        {
            InitializeComponent();
            DisplayArchivedData();
        }

        private void DisplayArchivedData()
        {
            try
            {
                string query = "SELECT archiveID, dataID, dataType, dateArchived " +
                               "FROM Archive WHERE dataType = 'Product'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView1.AutoGenerateColumns = true;

                dataGridView1.Columns["archiveID"].HeaderText = "Archive ID";
                dataGridView1.Columns["dataID"].HeaderText = "Product ID";
                dataGridView1.Columns["dataType"].HeaderText = "Data Type";
                dataGridView1.Columns["dateArchived"].HeaderText = "Date Archived";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminArchive_Load(object sender, EventArgs e)
        {

        }
    }
}
