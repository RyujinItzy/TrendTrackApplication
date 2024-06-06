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

namespace TrendTrackApplication.User_Forms
{
    public partial class UpdateUserForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True");
        private int userID;
        public UpdateUserForm(int userID, string username, string password, string role, string status)
        {
            InitializeComponent();

            // Initialize the userID field
            this.userID = userID;

            // Populate the fields with the provided user data
            users_username.Text = username;
            users_password.Text = password;
            users_role.Text = role;
            users_status.Text = status;
        }
        private void clearFields()
        {
            users_username.Text = "";
            users_password.Text = "";
            users_role.SelectedIndex = -1;
            users_status.SelectedIndex = -1;
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

        private void btn_user_update_Click(object sender, EventArgs e)
        {
            if (users_username.Text == "" || users_password.Text == "" || users_role.SelectedIndex == -1 || users_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty Field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update User ID: " + userID + "?", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE Users SET username = @usern, password = @pass, role = @role, status = @status WHERE userID = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@usern", users_username.Text.Trim());
                                updateD.Parameters.AddWithValue("@pass", users_password.Text.Trim());
                                updateD.Parameters.AddWithValue("@role", users_role.SelectedItem.ToString());
                                updateD.Parameters.AddWithValue("@status", users_status.SelectedItem.ToString());
                                updateD.Parameters.AddWithValue("@id", userID);

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

        private void btn_users_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
