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
    public partial class frmRegister : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True");
        public frmRegister()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegister_FormClosing);

        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmLogin logForm = new frmLogin();
            logForm.Show();
            this.Hide();
        }



        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cb_register_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool showPassword = cb_register_showPassword.Checked;

            register_password.PasswordChar = showPassword ? '\0' : '*';
            register_confirmPassword.PasswordChar = showPassword ? '\0' : '*';
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_register_regform_Click(object sender, EventArgs e)
        {
            if (register_username.Text == "" || register_password.Text == "" || register_confirmPassword.Text == "")
            {
                MessageBox.Show("Please fill all empty fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string checkUsername = "SELECT * FROM Users WHERE username = @usern";

                        using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(register_username.Text.Trim() + " is already taken.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid password, at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Trim() != register_confirmPassword.Text.Trim())
                            {
                                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO Users(username, password, role, status, dateCreated) " +
                                                     "VALUES (@usern, @pass, @role, @status, @date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                                    insertD.Parameters.AddWithValue("@role", "Cashier");
                                    insertD.Parameters.AddWithValue("@status", "Approval");
                                    DateTime today = DateTime.Now;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    frmLogin loginForm = new frmLogin();
                                    loginForm.Show();
                                    this.Hide();
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
        }

        private void register_username_finalized_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
