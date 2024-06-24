namespace TrendTrackApplication
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            btn_login = new RoundedButton();
            login_password = new TextBox();
            login_username = new TextBox();
            panel2 = new Panel();
            cb_login_showPassword = new CheckBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(login_password);
            panel1.Controls.Add(login_username);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(cb_login_showPassword);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(45, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 384);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(425, 134);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 21;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(425, 77);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 20;
            label2.Text = "Username";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.SteelBlue;
            btn_login.BackGroundColor = Color.SteelBlue;
            btn_login.BorderColor = Color.SteelBlue;
            btn_login.BorderRadius = 10;
            btn_login.BorderSize = 0;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(422, 282);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(245, 32);
            btn_login.TabIndex = 19;
            btn_login.Text = "Login";
            btn_login.TextColor = Color.White;
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // login_password
            // 
            login_password.BackColor = Color.WhiteSmoke;
            login_password.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_password.Location = new Point(425, 154);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(242, 25);
            login_password.TabIndex = 17;
            login_password.TextChanged += login_password_TextChanged;
            // 
            // login_username
            // 
            login_username.BackColor = Color.WhiteSmoke;
            login_username.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username.Location = new Point(425, 97);
            login_username.Name = "login_username";
            login_username.Size = new Size(242, 25);
            login_username.TabIndex = 16;
            login_username.TextChanged += login_username_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(351, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 325);
            panel2.TabIndex = 15;
            // 
            // cb_login_showPassword
            // 
            cb_login_showPassword.AutoSize = true;
            cb_login_showPassword.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_login_showPassword.Location = new Point(560, 185);
            cb_login_showPassword.Name = "cb_login_showPassword";
            cb_login_showPassword.Size = new Size(107, 18);
            cb_login_showPassword.TabIndex = 14;
            cb_login_showPassword.Text = "Show Password";
            cb_login_showPassword.UseVisualStyleBackColor = true;
            cb_login_showPassword.CheckedChanged += cb_login_showPassword_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password_25_48;
            pictureBox3.Location = new Point(390, 154);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.username_1_48;
            pictureBox2.Location = new Point(390, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Trend__track_logo;
            pictureBox1.Location = new Point(32, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(504, 37);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private CheckBox cb_login_showPassword;
        private Label label1;
        private Panel panel2;
        private TextBox login_password;
        private TextBox login_username;
        private RoundedButton btn_login;
        private RoundedButton roundedButton2;
        private Label label3;
        private Label label2;
    }
}
