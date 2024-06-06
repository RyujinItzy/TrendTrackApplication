namespace TrendTrackApplication
{
    partial class AdminCategories
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            btn_categories_remove = new RoundedButton();
            btn_categories_update = new RoundedButton();
            btn_categories_add = new RoundedButton();
            category_searchText = new TextBox();
            panel7 = new Panel();
            btn_categories_nextPage = new Button();
            btn_categories_previousPage = new Button();
            currentPage_txtbox = new TextBox();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            btn_search_categories = new RoundedButton();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_categories_remove
            // 
            btn_categories_remove.BackColor = Color.DarkRed;
            btn_categories_remove.BackGroundColor = Color.DarkRed;
            btn_categories_remove.BorderColor = Color.DarkRed;
            btn_categories_remove.BorderRadius = 10;
            btn_categories_remove.BorderSize = 3;
            btn_categories_remove.FlatAppearance.BorderSize = 0;
            btn_categories_remove.FlatStyle = FlatStyle.Flat;
            btn_categories_remove.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_categories_remove.ForeColor = Color.White;
            btn_categories_remove.Location = new Point(923, 46);
            btn_categories_remove.Name = "btn_categories_remove";
            btn_categories_remove.Size = new Size(105, 33);
            btn_categories_remove.TabIndex = 22;
            btn_categories_remove.Text = "Remove";
            btn_categories_remove.TextColor = Color.White;
            btn_categories_remove.UseVisualStyleBackColor = false;
            btn_categories_remove.Click += btn_categories_remove_Click;
            // 
            // btn_categories_update
            // 
            btn_categories_update.BackColor = Color.Navy;
            btn_categories_update.BackGroundColor = Color.Navy;
            btn_categories_update.BorderColor = Color.Navy;
            btn_categories_update.BorderRadius = 10;
            btn_categories_update.BorderSize = 3;
            btn_categories_update.FlatAppearance.BorderSize = 0;
            btn_categories_update.FlatStyle = FlatStyle.Flat;
            btn_categories_update.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_categories_update.ForeColor = Color.White;
            btn_categories_update.Location = new Point(812, 46);
            btn_categories_update.Name = "btn_categories_update";
            btn_categories_update.Size = new Size(105, 33);
            btn_categories_update.TabIndex = 21;
            btn_categories_update.Text = "Update";
            btn_categories_update.TextColor = Color.White;
            btn_categories_update.UseVisualStyleBackColor = false;
            btn_categories_update.Click += btn_categories_update_Click;
            // 
            // btn_categories_add
            // 
            btn_categories_add.BackColor = Color.DarkGreen;
            btn_categories_add.BackGroundColor = Color.DarkGreen;
            btn_categories_add.BorderColor = Color.DarkGreen;
            btn_categories_add.BorderRadius = 10;
            btn_categories_add.BorderSize = 3;
            btn_categories_add.FlatAppearance.BorderSize = 0;
            btn_categories_add.FlatStyle = FlatStyle.Flat;
            btn_categories_add.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_categories_add.ForeColor = Color.White;
            btn_categories_add.Location = new Point(701, 46);
            btn_categories_add.Name = "btn_categories_add";
            btn_categories_add.Size = new Size(105, 33);
            btn_categories_add.TabIndex = 20;
            btn_categories_add.Text = "Add";
            btn_categories_add.TextColor = Color.White;
            btn_categories_add.UseVisualStyleBackColor = false;
            btn_categories_add.Click += btn_categories_add_Click;
            // 
            // category_searchText
            // 
            category_searchText.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            category_searchText.Location = new Point(26, 44);
            category_searchText.Name = "category_searchText";
            category_searchText.Size = new Size(337, 32);
            category_searchText.TabIndex = 19;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(btn_categories_nextPage);
            panel7.Controls.Add(btn_categories_previousPage);
            panel7.Controls.Add(currentPage_txtbox);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(dataGridView1);
            panel7.Location = new Point(26, 89);
            panel7.Name = "panel7";
            panel7.Size = new Size(1002, 657);
            panel7.TabIndex = 18;
            // 
            // btn_categories_nextPage
            // 
            btn_categories_nextPage.BackColor = Color.SteelBlue;
            btn_categories_nextPage.FlatStyle = FlatStyle.Flat;
            btn_categories_nextPage.ForeColor = Color.CornflowerBlue;
            btn_categories_nextPage.Image = Properties.Resources.nextPage_icon_notfill_18;
            btn_categories_nextPage.Location = new Point(523, 628);
            btn_categories_nextPage.Name = "btn_categories_nextPage";
            btn_categories_nextPage.Size = new Size(39, 23);
            btn_categories_nextPage.TabIndex = 9;
            btn_categories_nextPage.UseVisualStyleBackColor = false;
            btn_categories_nextPage.Click += btn_categories_nextPage_Click;
            // 
            // btn_categories_previousPage
            // 
            btn_categories_previousPage.BackColor = Color.SteelBlue;
            btn_categories_previousPage.FlatStyle = FlatStyle.Flat;
            btn_categories_previousPage.ForeColor = Color.SteelBlue;
            btn_categories_previousPage.Image = Properties.Resources.previousPage_icon_notfill_18;
            btn_categories_previousPage.Location = new Point(429, 628);
            btn_categories_previousPage.Name = "btn_categories_previousPage";
            btn_categories_previousPage.Size = new Size(39, 23);
            btn_categories_previousPage.TabIndex = 7;
            btn_categories_previousPage.UseVisualStyleBackColor = false;
            btn_categories_previousPage.Click += btn_categories_previousPage_Click;
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
            label12.Size = new Size(159, 19);
            label12.TabIndex = 2;
            label12.Text = "All Categories's Data";
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
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.SteelBlue;
            dataGridViewCellStyle10.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(17, 56);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(954, 565);
            dataGridView1.TabIndex = 0;
            // 
            // btn_search_categories
            // 
            btn_search_categories.BackColor = Color.SteelBlue;
            btn_search_categories.BackGroundColor = Color.SteelBlue;
            btn_search_categories.BorderColor = Color.RoyalBlue;
            btn_search_categories.BorderRadius = 10;
            btn_search_categories.BorderSize = 0;
            btn_search_categories.FlatAppearance.BorderSize = 0;
            btn_search_categories.FlatStyle = FlatStyle.Flat;
            btn_search_categories.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search_categories.ForeColor = Color.White;
            btn_search_categories.Image = Properties.Resources.search_icon_24;
            btn_search_categories.Location = new Point(369, 43);
            btn_search_categories.Name = "btn_search_categories";
            btn_search_categories.Size = new Size(88, 33);
            btn_search_categories.TabIndex = 24;
            btn_search_categories.TextColor = Color.White;
            btn_search_categories.UseVisualStyleBackColor = false;
            btn_search_categories.Click += btn_search_categories_Click;
            // 
            // AdminCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_search_categories);
            Controls.Add(btn_categories_remove);
            Controls.Add(btn_categories_update);
            Controls.Add(btn_categories_add);
            Controls.Add(category_searchText);
            Controls.Add(panel7);
            Name = "AdminCategories";
            Size = new Size(1054, 770);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RoundedButton btn_categories_remove;
        private RoundedButton btn_categories_update;
        private RoundedButton btn_categories_add;
        private TextBox category_searchText;
        private Panel panel7;
        private TextBox currentPage_txtbox;
        private Label label12;
        private DataGridView dataGridView1;
        private RoundedButton btn_search_categories;
        private Button btn_categories_previousPage;
        private Button btn_categories_nextPage;
    }
}
