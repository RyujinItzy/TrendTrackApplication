namespace TrendTrackApplication
{
    partial class AdminUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel7 = new Panel();
            btn_users_nextPage = new Button();
            btn_users_previousPage = new Button();
            currentPage_txtbox = new TextBox();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            users_searchText = new TextBox();
            btn_users_remove = new RoundedButton();
            btn_search_users = new RoundedButton();
            btn_users_update = new RoundedButton();
            btn_users_add = new RoundedButton();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(btn_users_nextPage);
            panel7.Controls.Add(btn_users_previousPage);
            panel7.Controls.Add(currentPage_txtbox);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(dataGridView1);
            panel7.Location = new Point(26, 89);
            panel7.Name = "panel7";
            panel7.Size = new Size(1002, 657);
            panel7.TabIndex = 9;
            // 
            // btn_users_nextPage
            // 
            btn_users_nextPage.BackColor = Color.SteelBlue;
            btn_users_nextPage.FlatStyle = FlatStyle.Flat;
            btn_users_nextPage.ForeColor = Color.CornflowerBlue;
            btn_users_nextPage.Image = Properties.Resources.nextPage_icon_notfill_18;
            btn_users_nextPage.Location = new Point(523, 628);
            btn_users_nextPage.Name = "btn_users_nextPage";
            btn_users_nextPage.Size = new Size(39, 23);
            btn_users_nextPage.TabIndex = 6;
            btn_users_nextPage.UseVisualStyleBackColor = false;
            btn_users_nextPage.Click += btn_users_nextPage_Click;
            // 
            // btn_users_previousPage
            // 
            btn_users_previousPage.BackColor = Color.SteelBlue;
            btn_users_previousPage.FlatStyle = FlatStyle.Flat;
            btn_users_previousPage.ForeColor = Color.SteelBlue;
            btn_users_previousPage.Image = Properties.Resources.previousPage_icon_notfill_18;
            btn_users_previousPage.Location = new Point(429, 628);
            btn_users_previousPage.Name = "btn_users_previousPage";
            btn_users_previousPage.Size = new Size(39, 23);
            btn_users_previousPage.TabIndex = 5;
            btn_users_previousPage.UseVisualStyleBackColor = false;
            btn_users_previousPage.Click += btn_users_previousPage_Click;
            // 
            // currentPage_txtbox
            // 
            currentPage_txtbox.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentPage_txtbox.Location = new Point(474, 628);
            currentPage_txtbox.Name = "currentPage_txtbox";
            currentPage_txtbox.Size = new Size(43, 22);
            currentPage_txtbox.TabIndex = 4;
            currentPage_txtbox.TextAlign = HorizontalAlignment.Center;
            currentPage_txtbox.TextChanged += currentPage_txtbox_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(17, 20);
            label12.Name = "label12";
            label12.Size = new Size(116, 19);
            label12.TabIndex = 2;
            label12.Text = "All User's Data";
            label12.Click += label12_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.SteelBlue;
            dataGridViewCellStyle4.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(17, 56);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(954, 565);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // users_searchText
            // 
            users_searchText.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            users_searchText.Location = new Point(26, 44);
            users_searchText.Name = "users_searchText";
            users_searchText.Size = new Size(337, 32);
            users_searchText.TabIndex = 10;
            // 
            // btn_users_remove
            // 
            btn_users_remove.BackColor = Color.DarkRed;
            btn_users_remove.BackGroundColor = Color.DarkRed;
            btn_users_remove.BorderColor = Color.DarkRed;
            btn_users_remove.BorderRadius = 10;
            btn_users_remove.BorderSize = 3;
            btn_users_remove.FlatAppearance.BorderSize = 0;
            btn_users_remove.FlatStyle = FlatStyle.Flat;
            btn_users_remove.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_users_remove.ForeColor = Color.White;
            btn_users_remove.Location = new Point(923, 46);
            btn_users_remove.Name = "btn_users_remove";
            btn_users_remove.Size = new Size(105, 33);
            btn_users_remove.TabIndex = 16;
            btn_users_remove.Text = "Remove";
            btn_users_remove.TextColor = Color.White;
            btn_users_remove.UseVisualStyleBackColor = false;
            btn_users_remove.Click += btn_users_remove_Click;
            // 
            // btn_search_users
            // 
            btn_search_users.BackColor = Color.SteelBlue;
            btn_search_users.BackGroundColor = Color.SteelBlue;
            btn_search_users.BorderColor = Color.RoyalBlue;
            btn_search_users.BorderRadius = 10;
            btn_search_users.BorderSize = 0;
            btn_search_users.FlatAppearance.BorderSize = 0;
            btn_search_users.FlatStyle = FlatStyle.Flat;
            btn_search_users.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search_users.ForeColor = Color.White;
            btn_search_users.Image = Properties.Resources.search_icon_24;
            btn_search_users.Location = new Point(369, 43);
            btn_search_users.Name = "btn_search_users";
            btn_search_users.Size = new Size(88, 33);
            btn_search_users.TabIndex = 17;
            btn_search_users.TextColor = Color.White;
            btn_search_users.UseVisualStyleBackColor = false;
            btn_search_users.Click += btn_search_users_Click;
            // 
            // btn_users_update
            // 
            btn_users_update.BackColor = Color.Navy;
            btn_users_update.BackGroundColor = Color.Navy;
            btn_users_update.BorderColor = Color.Navy;
            btn_users_update.BorderRadius = 10;
            btn_users_update.BorderSize = 3;
            btn_users_update.FlatAppearance.BorderSize = 0;
            btn_users_update.FlatStyle = FlatStyle.Flat;
            btn_users_update.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_users_update.ForeColor = Color.White;
            btn_users_update.Location = new Point(812, 46);
            btn_users_update.Name = "btn_users_update";
            btn_users_update.Size = new Size(105, 33);
            btn_users_update.TabIndex = 18;
            btn_users_update.Text = "Update";
            btn_users_update.TextColor = Color.White;
            btn_users_update.UseVisualStyleBackColor = false;
            btn_users_update.Click += btn_users_update_Click;
            // 
            // btn_users_add
            // 
            btn_users_add.BackColor = Color.DarkGreen;
            btn_users_add.BackGroundColor = Color.DarkGreen;
            btn_users_add.BorderColor = Color.DarkGreen;
            btn_users_add.BorderRadius = 10;
            btn_users_add.BorderSize = 3;
            btn_users_add.FlatAppearance.BorderSize = 0;
            btn_users_add.FlatStyle = FlatStyle.Flat;
            btn_users_add.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_users_add.ForeColor = Color.White;
            btn_users_add.Location = new Point(701, 46);
            btn_users_add.Name = "btn_users_add";
            btn_users_add.Size = new Size(105, 33);
            btn_users_add.TabIndex = 19;
            btn_users_add.Text = "Add";
            btn_users_add.TextColor = Color.White;
            btn_users_add.UseVisualStyleBackColor = false;
            btn_users_add.Click += btn_users_add_Click;
            // 
            // AdminUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_users_add);
            Controls.Add(btn_users_update);
            Controls.Add(btn_search_users);
            Controls.Add(btn_users_remove);
            Controls.Add(users_searchText);
            Controls.Add(panel7);
            Name = "AdminUsers";
            Size = new Size(1054, 770);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel7;
        private Label label12;
        private DataGridView dataGridView1;
        private TextBox users_searchText;
        private RoundedButton btn_users_remove;
        private RoundedButton btn_search_users;
        private Button btn_users_nextPage;
        private Button btn_users_previousPage;
        private TextBox currentPage_txtbox;
        private RoundedButton btn_users_update;
        private RoundedButton btn_users_add;
    }
}
