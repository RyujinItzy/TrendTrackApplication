namespace TrendTrackApplication.Admin_User_Control
{
    partial class AdminActivityLog
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel7 = new Panel();
            btn_log_nextPage = new Button();
            btn_log_previousPage = new Button();
            currentPage_txtbox = new TextBox();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            btn_search_log = new RoundedButton();
            logs_searchText = new TextBox();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(btn_log_nextPage);
            panel7.Controls.Add(btn_log_previousPage);
            panel7.Controls.Add(currentPage_txtbox);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(dataGridView1);
            panel7.Location = new Point(26, 89);
            panel7.Name = "panel7";
            panel7.Size = new Size(1002, 657);
            panel7.TabIndex = 12;
            // 
            // btn_log_nextPage
            // 
            btn_log_nextPage.BackColor = Color.SteelBlue;
            btn_log_nextPage.FlatStyle = FlatStyle.Flat;
            btn_log_nextPage.ForeColor = Color.CornflowerBlue;
            btn_log_nextPage.Image = Properties.Resources.nextPage_icon_notfill_18;
            btn_log_nextPage.Location = new Point(523, 628);
            btn_log_nextPage.Name = "btn_log_nextPage";
            btn_log_nextPage.Size = new Size(39, 23);
            btn_log_nextPage.TabIndex = 6;
            btn_log_nextPage.UseVisualStyleBackColor = false;
            // 
            // btn_log_previousPage
            // 
            btn_log_previousPage.BackColor = Color.SteelBlue;
            btn_log_previousPage.FlatStyle = FlatStyle.Flat;
            btn_log_previousPage.ForeColor = Color.SteelBlue;
            btn_log_previousPage.Image = Properties.Resources.previousPage_icon_notfill_18;
            btn_log_previousPage.Location = new Point(429, 628);
            btn_log_previousPage.Name = "btn_log_previousPage";
            btn_log_previousPage.Size = new Size(39, 23);
            btn_log_previousPage.TabIndex = 5;
            btn_log_previousPage.UseVisualStyleBackColor = false;
            // 
            // currentPage_txtbox
            // 
            currentPage_txtbox.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentPage_txtbox.Location = new Point(474, 628);
            currentPage_txtbox.Name = "currentPage_txtbox";
            currentPage_txtbox.Size = new Size(43, 22);
            currentPage_txtbox.TabIndex = 4;
            currentPage_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(17, 20);
            label12.Name = "label12";
            label12.Size = new Size(95, 19);
            label12.TabIndex = 2;
            label12.Text = "Activity Log";
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.SteelBlue;
            dataGridViewCellStyle7.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(17, 56);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(954, 565);
            dataGridView1.TabIndex = 0;
            // 
            // btn_search_log
            // 
            btn_search_log.BackColor = Color.SteelBlue;
            btn_search_log.BackGroundColor = Color.SteelBlue;
            btn_search_log.BorderColor = Color.RoyalBlue;
            btn_search_log.BorderRadius = 10;
            btn_search_log.BorderSize = 0;
            btn_search_log.FlatAppearance.BorderSize = 0;
            btn_search_log.FlatStyle = FlatStyle.Flat;
            btn_search_log.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search_log.ForeColor = Color.White;
            btn_search_log.Image = Properties.Resources.search_icon_24;
            btn_search_log.Location = new Point(369, 43);
            btn_search_log.Name = "btn_search_log";
            btn_search_log.Size = new Size(88, 33);
            btn_search_log.TabIndex = 21;
            btn_search_log.TextColor = Color.White;
            btn_search_log.UseVisualStyleBackColor = false;
            // 
            // logs_searchText
            // 
            logs_searchText.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logs_searchText.Location = new Point(26, 44);
            logs_searchText.Name = "logs_searchText";
            logs_searchText.Size = new Size(337, 32);
            logs_searchText.TabIndex = 20;
            // 
            // AdminActivityLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_search_log);
            Controls.Add(logs_searchText);
            Controls.Add(panel7);
            Name = "AdminActivityLog";
            Size = new Size(1054, 770);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel7;
        private Button btn_log_nextPage;
        private Button btn_log_previousPage;
        private TextBox currentPage_txtbox;
        private Label label12;
        private DataGridView dataGridView1;
        private RoundedButton btn_search_log;
        private TextBox logs_searchText;
    }
}
