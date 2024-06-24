using System.Data;
using System.Data.SqlClient;
using TrendTrackApplication.Forms;
using TrendTrackApplication.User_Forms;
namespace TrendTrackApplication
{
    public partial class AdminUsers : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True");

        private int currentPage = 1;
        private int totalPages = 1; // Initialize to 1 initially
        private int itemsPerPage = 20;

        public AdminUsers()
        {
            InitializeComponent();
            DisplayAllUsersData();
        }

        private void btn_users_remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int userID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UserID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to remove this record?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True"))
                        {
                            connection.Open();
                            string deleteData = "DELETE FROM Users WHERE userID = @id";

                            using (SqlCommand deleteD = new SqlCommand(deleteData, connection))
                            {
                                deleteD.Parameters.AddWithValue("@id", userID);
                                deleteD.ExecuteNonQuery();
                            }
                        }

                        DisplayAllUsersData();
                        MessageBox.Show("Removed Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to remove.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.RowIndex != -1)
                {
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                }
            }
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisplayCurrentPage();
        }
        private void btn_search_users_Click(object sender, EventArgs e)
        {
            string searchQuery = users_searchText.Text.Trim();

            try
            {
                string query = $"SELECT * FROM Users WHERE username LIKE '%{searchQuery}%' OR UserID LIKE '%{searchQuery}%' OR Role LIKE '%{searchQuery}%' OR Status LIKE '%{searchQuery}%'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                // Set custom column header text
                dataGridView1.Columns["UserID"].HeaderText = "User ID";
                dataGridView1.Columns["Username"].HeaderText = "Username";
                dataGridView1.Columns["Password"].HeaderText = "Password";
                dataGridView1.Columns["Role"].HeaderText = "Role";
                dataGridView1.Columns["Status"].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_users_previousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayCurrentPage();
            }
        }

        private void currentPage_txtbox_TextChanged(object sender, EventArgs e)
        {
            LoadSpecifiedPage();
        }

        private void btn_users_nextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                DisplayCurrentPage();
            }
        }
        private void DisplayAllUsersData()
        {
            try
            {
                int offset = (currentPage - 1) * itemsPerPage;
                string query = $"SELECT * FROM (SELECT ROW_NUMBER() OVER (ORDER BY UserID) AS RowNum, * FROM Users) AS UserWithRowNum WHERE RowNum BETWEEN {offset + 1} AND {offset + itemsPerPage}";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView1.AutoGenerateColumns = true;

                // Set custom column header text
                dataGridView1.Columns["UserID"].HeaderText = "User ID";
                dataGridView1.Columns["Username"].HeaderText = "Username";
                dataGridView1.Columns["Password"].HeaderText = "Password";
                dataGridView1.Columns["Role"].HeaderText = "Role";
                dataGridView1.Columns["Status"].HeaderText = "Status";

                // Get total count of users
                int totalRows = GetTotalRows();
                totalPages = (int)Math.Ceiling((double)totalRows / itemsPerPage);

                currentPage_txtbox.Text = currentPage.ToString();
                btn_users_previousPage.Enabled = currentPage > 1;
                btn_users_nextPage.Enabled = currentPage < totalPages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetTotalRows()
        {
            int totalRows = 0;
            string query = "SELECT COUNT(*) FROM Users";

            using (SqlCommand command = new SqlCommand(query, connect))
            {
                try
                {
                    connect.Open();
                    totalRows = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

            return totalRows;
        }
        private void LoadSpecifiedPage()
        {
            if (int.TryParse(currentPage_txtbox.Text, out int pageNumber))
            {
                if (pageNumber >= 1 && pageNumber <= totalPages)
                {
                    currentPage = pageNumber;
                    DisplayCurrentPage();
                }
                else
                {
                    MessageBox.Show("Invalid page number. Please enter a number between 1 and " + totalPages + ".", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid page number. Please enter a valid number.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayCurrentPage()
        {
            try
            {
                int offset = (currentPage - 1) * itemsPerPage;
                string query = $"SELECT * FROM Users ORDER BY UserID OFFSET {offset} ROWS FETCH NEXT {itemsPerPage} ROWS ONLY";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                // Set custom column header text
                dataGridView1.Columns["UserID"].HeaderText = "User ID";
                dataGridView1.Columns["Username"].HeaderText = "Username";
                dataGridView1.Columns["Password"].HeaderText = "Password";
                dataGridView1.Columns["Role"].HeaderText = "Role";
                dataGridView1.Columns["Status"].HeaderText = "Status";

                currentPage_txtbox.Text = currentPage.ToString();
                btn_users_previousPage.Enabled = currentPage > 1;
                btn_users_nextPage.Enabled = currentPage < totalPages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_users_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int userID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UserID"].Value);
                string username = dataGridView1.SelectedRows[0].Cells["Username"].Value.ToString();
                string password = dataGridView1.SelectedRows[0].Cells["Password"].Value.ToString();
                string role = dataGridView1.SelectedRows[0].Cells["Role"].Value.ToString();
                string status = dataGridView1.SelectedRows[0].Cells["Status"].Value.ToString();

                UpdateUserForm updateUserForm = new UpdateUserForm(userID, username, password, role, status);
                updateUserForm.FormClosed += UpdateUserForm_FormClosed;
                updateUserForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a user to update.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_users_add_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
            DisplayAllUsersData();
        }
    }
}