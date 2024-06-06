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

namespace TrendTrackApplication.Forms
{
    public partial class AddUserForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True");
        public AddUserForm()
        {
            InitializeComponent();
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

        private void btn_users_add_Click(object sender, EventArgs e)
        {
            if (users_username.Text == "" || users_password.Text == "" || users_role.SelectedIndex == -1 || users_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty Field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string checkUsername = "SELECT * FROM Users WHERE username = @usern";


                    using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", users_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(users_username.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            string insertData = "INSERT INTO Users (username, password, role, status, dateCreated) " +
                           "VALUES(@usern, @pass, @role, @status, @date)";

                            using (SqlCommand insertD = new SqlCommand(insertData, connect))
                            {
                                insertD.Parameters.AddWithValue("@usern", users_username.Text.Trim());
                                insertD.Parameters.AddWithValue("@pass", users_password.Text.Trim());
                                insertD.Parameters.AddWithValue("@role", users_role.SelectedItem.ToString());
                                insertD.Parameters.AddWithValue("@status", users_status.SelectedItem.ToString());

                                DateTime today = DateTime.Now;
                                insertD.Parameters.AddWithValue("@date", today);

                                insertD.ExecuteNonQuery();
                                MessageBox.Show("Added Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
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

        private void btn_users_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
