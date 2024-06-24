namespace TrendTrackApplication.Forms
{
    partial class AddUserForm
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
            btn_users_add = new RoundedButton();
            btn_users_clear = new RoundedButton();
            users_status = new ComboBox();
            users_role = new ComboBox();
            users_password = new TextBox();
            users_username = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_users_add);
            panel1.Controls.Add(btn_users_clear);
            panel1.Controls.Add(users_status);
            panel1.Controls.Add(users_role);
            panel1.Controls.Add(users_password);
            panel1.Controls.Add(users_username);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 340);
            panel1.TabIndex = 0;
            // 
            // btn_users_add
            // 
            btn_users_add.BackColor = Color.DarkGreen;
            btn_users_add.BackGroundColor = Color.DarkGreen;
            btn_users_add.BorderColor = Color.RoyalBlue;
            btn_users_add.BorderRadius = 10;
            btn_users_add.BorderSize = 0;
            btn_users_add.FlatAppearance.BorderSize = 0;
            btn_users_add.FlatStyle = FlatStyle.Flat;
            btn_users_add.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_users_add.ForeColor = Color.White;
            btn_users_add.Location = new Point(376, 291);
            btn_users_add.Name = "btn_users_add";
            btn_users_add.Size = new Size(105, 31);
            btn_users_add.TabIndex = 20;
            btn_users_add.Text = "Add";
            btn_users_add.TextColor = Color.White;
            btn_users_add.UseVisualStyleBackColor = false;
            btn_users_add.Click += btn_users_add_Click;
            // 
            // btn_users_clear
            // 
            btn_users_clear.BackColor = Color.RoyalBlue;
            btn_users_clear.BackGroundColor = Color.RoyalBlue;
            btn_users_clear.BorderColor = Color.RoyalBlue;
            btn_users_clear.BorderRadius = 10;
            btn_users_clear.BorderSize = 0;
            btn_users_clear.FlatAppearance.BorderSize = 0;
            btn_users_clear.FlatStyle = FlatStyle.Flat;
            btn_users_clear.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_users_clear.ForeColor = Color.White;
            btn_users_clear.Location = new Point(487, 291);
            btn_users_clear.Name = "btn_users_clear";
            btn_users_clear.Size = new Size(105, 31);
            btn_users_clear.TabIndex = 19;
            btn_users_clear.Text = "Clear";
            btn_users_clear.TextColor = Color.White;
            btn_users_clear.UseVisualStyleBackColor = false;
            btn_users_clear.Click += btn_users_clear_Click;
            // 
            // users_status
            // 
            users_status.DropDownStyle = ComboBoxStyle.DropDownList;
            users_status.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            users_status.FormattingEnabled = true;
            users_status.Items.AddRange(new object[] { "Active", "Inactive", "Waiting for Approval" });
            users_status.Location = new Point(337, 161);
            users_status.Name = "users_status";
            users_status.Size = new Size(181, 27);
            users_status.TabIndex = 18;
            // 
            // users_role
            // 
            users_role.DropDownStyle = ComboBoxStyle.DropDownList;
            users_role.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            users_role.FormattingEnabled = true;
            users_role.Items.AddRange(new object[] { "Admin", "Cashier" });
            users_role.Location = new Point(337, 89);
            users_role.Name = "users_role";
            users_role.Size = new Size(181, 27);
            users_role.TabIndex = 17;
            // 
            // users_password
            // 
            users_password.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            users_password.Location = new Point(29, 161);
            users_password.Name = "users_password";
            users_password.Size = new Size(190, 26);
            users_password.TabIndex = 16;
            // 
            // users_username
            // 
            users_username.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            users_username.Location = new Point(29, 91);
            users_username.Name = "users_username";
            users_username.Size = new Size(190, 26);
            users_username.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F);
            label5.Location = new Point(337, 69);
            label5.Name = "label5";
            label5.Size = new Size(40, 19);
            label5.TabIndex = 14;
            label5.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F);
            label4.Location = new Point(337, 139);
            label4.Name = "label4";
            label4.Size = new Size(51, 19);
            label4.TabIndex = 13;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F);
            label3.Location = new Point(31, 139);
            label3.Name = "label3";
            label3.Size = new Size(77, 19);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F);
            label2.Location = new Point(29, 69);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 11;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(161, 22);
            label1.TabIndex = 10;
            label1.Text = "User Information";
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(636, 362);
            Controls.Add(panel1);
            Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AddUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add User";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox users_status;
        private ComboBox users_role;
        private TextBox users_password;
        private TextBox users_username;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RoundedButton btn_users_clear;
        private RoundedButton btn_users_add;
    }
}