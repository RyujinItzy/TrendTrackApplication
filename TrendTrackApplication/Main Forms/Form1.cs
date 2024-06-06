using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TrendTrackApplication
{
    public partial class frmLogin : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\visual studio c#\TrendTrackApplication\TrendTrackApplication\TrendDB.mdf"";Integrated Security=True");

        public frmLogin()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_register_click_Click(object sender, EventArgs e)
        {
            frmRegister regForm = new frmRegister();
            regForm.Show();

            this.Hide();
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

        private void cb_login_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool showPassword = cb_login_showPassword.Checked;

            login_password.PasswordChar = showPassword ? '\0' : '*';
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }
        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(*) FROM Users WHERE username = @usern AND password = @pass AND status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", "Active");

                        int rowCount = (int)cmd.ExecuteScalar();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (rowCount > 0)
                        {
                            string selectRole = "SELECT role FROM Users WHERE username = @usern AND password = @pass";

                            using (SqlCommand getRole = new SqlCommand(selectRole, connect))
                            {
                                getRole.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                                getRole.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                                string userRole = getRole.ExecuteScalar() as string;

                                MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (userRole == "Admin")
                                {
                                    MainForm mainForm = new MainForm();
                                    mainForm.Show();
                                    this.Hide();
                                }
                                else if (userRole == "Cashier")
                                {
                                    CashierMainForm cashierMainForm = new CashierMainForm();
                                    cashierMainForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("User is either inactive or for approval", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect login credentials!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}
