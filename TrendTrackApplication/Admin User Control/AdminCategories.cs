using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TrendTrackApplication.Forms;
using TrendTrackApplication.Category_Forms;
using TrendTrackApplication.User_Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic.ApplicationServices;

namespace TrendTrackApplication
{
    public partial class AdminCategories : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True");

        private int currentPage = 1;
        private int totalPages = 1;
        private int itemsPerPage = 20;

        public AdminCategories()
        {
            InitializeComponent();
            DisplayCurrentPage();
        }

        public void DisplayAllCategoriesData()
        {
            try
            {
                int offset = (currentPage - 1) * itemsPerPage;
                string query = $"SELECT CategoryID AS 'Category ID', category AS 'Category Name', dateCreated AS 'Date Created' FROM Categories ORDER BY CategoryID OFFSET {offset} ROWS FETCH NEXT {itemsPerPage} ROWS ONLY";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView1.AutoGenerateColumns = true;

                // Get total count of categories
                int totalRows = GetTotalRows();
                totalPages = (int)Math.Ceiling((double)totalRows / itemsPerPage);

                currentPage_txtbox.Text = currentPage.ToString();
                btn_categories_previousPage.Enabled = currentPage > 1;
                btn_categories_nextPage.Enabled = currentPage < totalPages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private int GetTotalRows()
        {
            int totalRows = 0;
            string query = "SELECT COUNT(*) FROM Categories";

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

        private void btn_categories_add_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm();
            addCategoryForm.ShowDialog();
            DisplayAllCategoriesData();
        }

        private void btn_categories_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int categoryID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Category ID"].Value);
                string categoryName = dataGridView1.SelectedRows[0].Cells["Category Name"].Value.ToString();

                UpdateCategoryForm updateCategoryForm = new UpdateCategoryForm(categoryID, categoryName);
                updateCategoryForm.FormClosed += UpdateCategoryForm_FormClosed;
                updateCategoryForm.ShowDialog();

                DisplayAllCategoriesData();
            }
            else
            {
                MessageBox.Show("Please select a category to update.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCategoryForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            DisplayCurrentPage();
        }

        private void btn_categories_remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int categoryID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Category ID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to remove this record?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True"))
                        {
                            connection.Open();
                            string deleteData = "DELETE FROM Categories WHERE categoryID = @id";

                            using (SqlCommand deleteD = new SqlCommand(deleteData, connection))
                            {
                                deleteD.Parameters.AddWithValue("@id", categoryID);
                                deleteD.ExecuteNonQuery();
                            }
                        }

                        DisplayAllCategoriesData();
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
                MessageBox.Show("Please select a category to remove.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_categories_Click(object sender, EventArgs e)
        {
            string searchQuery = category_searchText.Text.Trim();

            try
            {
                string query = $"SELECT CategoryID AS 'Category ID', category AS 'Category Name', dateCreated AS 'Date Created' FROM Categories WHERE CategoryID LIKE '%{searchQuery}%' OR category LIKE '%{searchQuery}%'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayCurrentPage()
        {
            try
            {
                int offset = (currentPage - 1) * itemsPerPage;
                string query = $"SELECT CategoryID AS 'Category ID', category AS 'Category Name', dateCreated AS 'Date Created' FROM Categories ORDER BY CategoryID OFFSET {offset} ROWS FETCH NEXT {itemsPerPage} ROWS ONLY";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                currentPage_txtbox.Text = currentPage.ToString();
                btn_categories_previousPage.Enabled = currentPage > 1;
                btn_categories_nextPage.Enabled = currentPage < totalPages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void currentPage_txtbox_TextChanged(object sender, EventArgs e)
        {
            LoadSpecifiedPage();
        }

        private void btn_categories_previousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayCurrentPage();
            }
        }

        private void btn_categories_nextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                DisplayCurrentPage();
            }
        }
    }
}