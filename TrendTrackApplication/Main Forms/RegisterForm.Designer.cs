namespace TrendTrackApplication
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            register_confirmPassword = new TextBox();
            register_password = new TextBox();
            register_username = new TextBox();
            btn_register_regform = new RoundedButton();
            panel2 = new Panel();
            cb_register_showPassword = new CheckBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label_login_click = new Label();
            label4 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(register_confirmPassword);
            panel1.Controls.Add(register_password);
            panel1.Controls.Add(register_username);
            panel1.Controls.Add(btn_register_regform);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(cb_register_showPassword);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label_login_click);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(45, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 384);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(425, 188);
            label5.Name = "label5";
            label5.Size = new Size(124, 17);
            label5.TabIndex = 27;
            label5.Text = "Confirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(425, 134);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 26;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(425, 77);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 21;
            label2.Text = "Username";
            // 
            // register_confirmPassword
            // 
            register_confirmPassword.BackColor = Color.WhiteSmoke;
            register_confirmPassword.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_confirmPassword.Location = new Point(425, 208);
            register_confirmPassword.Name = "register_confirmPassword";
            register_confirmPassword.PasswordChar = '*';
            register_confirmPassword.Size = new Size(242, 25);
            register_confirmPassword.TabIndex = 25;
            // 
            // register_password
            // 
            register_password.BackColor = Color.WhiteSmoke;
            register_password.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_password.Location = new Point(425, 154);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(242, 25);
            register_password.TabIndex = 24;
            // 
            // register_username
            // 
            register_username.BackColor = Color.WhiteSmoke;
            register_username.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_username.Location = new Point(425, 97);
            register_username.Name = "register_username";
            register_username.Size = new Size(242, 25);
            register_username.TabIndex = 23;
            // 
            // btn_register_regform
            // 
            btn_register_regform.BackColor = Color.SteelBlue;
            btn_register_regform.BackGroundColor = Color.SteelBlue;
            btn_register_regform.BorderColor = Color.RoyalBlue;
            btn_register_regform.BorderRadius = 10;
            btn_register_regform.BorderSize = 0;
            btn_register_regform.FlatAppearance.BorderSize = 0;
            btn_register_regform.FlatStyle = FlatStyle.Flat;
            btn_register_regform.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_register_regform.ForeColor = Color.White;
            btn_register_regform.Location = new Point(422, 282);
            btn_register_regform.Name = "btn_register_regform";
            btn_register_regform.Size = new Size(245, 32);
            btn_register_regform.TabIndex = 20;
            btn_register_regform.Text = "Register";
            btn_register_regform.TextColor = Color.White;
            btn_register_regform.UseVisualStyleBackColor = false;
            btn_register_regform.Click += btn_register_regform_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(351, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 325);
            panel2.TabIndex = 16;
            // 
            // cb_register_showPassword
            // 
            cb_register_showPassword.AutoSize = true;
            cb_register_showPassword.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_register_showPassword.Location = new Point(560, 244);
            cb_register_showPassword.Name = "cb_register_showPassword";
            cb_register_showPassword.Size = new Size(107, 18);
            cb_register_showPassword.TabIndex = 13;
            cb_register_showPassword.Text = "Show Password";
            cb_register_showPassword.UseVisualStyleBackColor = true;
            cb_register_showPassword.CheckedChanged += cb_register_showPassword_CheckedChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.password_25_48;
            pictureBox4.Location = new Point(390, 208);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(26, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
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
            pictureBox1.Image = Properties.Resources.Trend__track_logo1;
            pictureBox1.Location = new Point(32, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label_login_click
            // 
            label_login_click.AutoSize = true;
            label_login_click.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_login_click.ForeColor = Color.SteelBlue;
            label_login_click.Location = new Point(573, 337);
            label_login_click.Name = "label_login_click";
            label_login_click.Size = new Size(66, 14);
            label_login_click.TabIndex = 6;
            label_login_click.Text = "Login Here!";
            label_login_click.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(428, 337);
            label4.Name = "label4";
            label4.Size = new Size(139, 14);
            label4.TabIndex = 5;
            label4.Text = "Already have an account?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(495, 37);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Form";
            FormClosing += frmRegister_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label_login_click;
        private Label label4;
        private PictureBox pictureBox4;
        private CheckBox cb_register_showPassword;
        private Label label1;
        private Panel panel2;
        private RoundedButton btn_register_regform;
        private TextBox register_confirmPassword;
        private TextBox register_password;
        private TextBox register_username;
        private Label label5;
        private Label label3;
        private Label label2;
    }
}