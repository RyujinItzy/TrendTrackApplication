namespace TrendTrackApplication
{
    partial class AdminArchive
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
            btn_archive_nextPage = new Button();
            btn_archive_previousPage = new Button();
            currentPage_txtbox = new TextBox();
            Archive = new Label();
            dataGridView1 = new DataGridView();
            btn_search_archive = new RoundedButton();
            archive_searchText = new TextBox();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(btn_archive_nextPage);
            panel7.Controls.Add(btn_archive_previousPage);
            panel7.Controls.Add(currentPage_txtbox);
            panel7.Controls.Add(Archive);
            panel7.Controls.Add(dataGridView1);
            panel7.Location = new Point(26, 89);
            panel7.Name = "panel7";
            panel7.Size = new Size(1002, 657);
            panel7.TabIndex = 14;
            // 
            // btn_archive_nextPage
            // 
            btn_archive_nextPage.BackColor = Color.SteelBlue;
            btn_archive_nextPage.FlatStyle = FlatStyle.Flat;
            btn_archive_nextPage.ForeColor = Color.CornflowerBlue;
            btn_archive_nextPage.Image = Properties.Resources.nextPage_icon_notfill_18;
            btn_archive_nextPage.Location = new Point(523, 628);
            btn_archive_nextPage.Name = "btn_archive_nextPage";
            btn_archive_nextPage.Size = new Size(39, 23);
            btn_archive_nextPage.TabIndex = 6;
            btn_archive_nextPage.UseVisualStyleBackColor = false;
            // 
            // btn_archive_previousPage
            // 
            btn_archive_previousPage.BackColor = Color.SteelBlue;
            btn_archive_previousPage.FlatStyle = FlatStyle.Flat;
            btn_archive_previousPage.ForeColor = Color.SteelBlue;
            btn_archive_previousPage.Image = Properties.Resources.previousPage_icon_notfill_18;
            btn_archive_previousPage.Location = new Point(429, 628);
            btn_archive_previousPage.Name = "btn_archive_previousPage";
            btn_archive_previousPage.Size = new Size(39, 23);
            btn_archive_previousPage.TabIndex = 5;
            btn_archive_previousPage.UseVisualStyleBackColor = false;
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
            // Archive
            // 
            Archive.AutoSize = true;
            Archive.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Archive.Location = new Point(17, 20);
            Archive.Name = "Archive";
            Archive.Size = new Size(65, 19);
            Archive.TabIndex = 2;
            Archive.Text = "Archive";
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
            // 
            // btn_search_archive
            // 
            btn_search_archive.BackColor = Color.SteelBlue;
            btn_search_archive.BackGroundColor = Color.SteelBlue;
            btn_search_archive.BorderColor = Color.RoyalBlue;
            btn_search_archive.BorderRadius = 10;
            btn_search_archive.BorderSize = 0;
            btn_search_archive.FlatAppearance.BorderSize = 0;
            btn_search_archive.FlatStyle = FlatStyle.Flat;
            btn_search_archive.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search_archive.ForeColor = Color.White;
            btn_search_archive.Image = Properties.Resources.search_icon_24;
            btn_search_archive.Location = new Point(369, 43);
            btn_search_archive.Name = "btn_search_archive";
            btn_search_archive.Size = new Size(88, 33);
            btn_search_archive.TabIndex = 25;
            btn_search_archive.TextColor = Color.White;
            btn_search_archive.UseVisualStyleBackColor = false;
            // 
            // archive_searchText
            // 
            archive_searchText.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            archive_searchText.Location = new Point(26, 44);
            archive_searchText.Name = "archive_searchText";
            archive_searchText.Size = new Size(337, 32);
            archive_searchText.TabIndex = 24;
            // 
            // AdminArchive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_search_archive);
            Controls.Add(archive_searchText);
            Controls.Add(panel7);
            Name = "AdminArchive";
            Size = new Size(1054, 770);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel7;
        private Button btn_archive_nextPage;
        private Button btn_archive_previousPage;
        private TextBox currentPage_txtbox;
        private Label Archive;
        private DataGridView dataGridView1;
        private RoundedButton btn_search_archive;
        private TextBox archive_searchText;
    }
}
