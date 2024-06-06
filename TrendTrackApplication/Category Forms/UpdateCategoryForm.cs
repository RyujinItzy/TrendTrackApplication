using Microsoft.VisualBasic.ApplicationServices;
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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TrendTrackApplication.Category_Forms
{
    public partial class UpdateCategoryForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True");
        private int categoryID;
        public UpdateCategoryForm(int categoryID, string category)
        {
            InitializeComponent();
            this.categoryID = categoryID;
            categories_name.Text = category;
        }
        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void clearFields()
        {
            categories_name.Text = "";
        }

        private void btn_categories_update_Click(object sender, EventArgs e)
        {
            if (categories_name.Text == "")
            {
                MessageBox.Show("Empty Field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update Category ID: " + categoryID + "?", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE Categories SET category = @cat WHERE categoryID = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@cat", categories_name.Text.Trim());
                                updateD.Parameters.AddWithValue("@id", categoryID);

                                updateD.ExecuteNonQuery();
                                MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection Failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        private void btn_categories_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
