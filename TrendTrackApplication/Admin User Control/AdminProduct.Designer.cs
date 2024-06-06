namespace TrendTrackApplication.Admin_User_Control
{
    partial class AdminProduct
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel3 = new Panel();
            btn_products_nextPage = new Button();
            btn_products_previousPage = new Button();
            currentPage_txtbox = new TextBox();
            label9 = new Label();
            dataGridView2 = new DataGridView();
            products_searchText = new TextBox();
            btn_products_update = new RoundedButton();
            btn_products_remove = new RoundedButton();
            btn_search_product = new RoundedButton();
            btn_products_add_final = new RoundedButton();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btn_products_nextPage);
            panel3.Controls.Add(btn_products_previousPage);
            panel3.Controls.Add(currentPage_txtbox);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(dataGridView2);
            panel3.Location = new Point(26, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(1002, 657);
            panel3.TabIndex = 11;
            // 
            // btn_products_nextPage
            // 
            btn_products_nextPage.BackColor = Color.SteelBlue;
            btn_products_nextPage.FlatStyle = FlatStyle.Flat;
            btn_products_nextPage.ForeColor = Color.CornflowerBlue;
            btn_products_nextPage.Image = Properties.Resources.nextPage_icon_notfill_18;
            btn_products_nextPage.Location = new Point(523, 628);
            btn_products_nextPage.Name = "btn_products_nextPage";
            btn_products_nextPage.Size = new Size(39, 23);
            btn_products_nextPage.TabIndex = 6;
            btn_products_nextPage.UseVisualStyleBackColor = false;
            btn_products_nextPage.Click += btn_products_nextPage_Click;
            // 
            // btn_products_previousPage
            // 
            btn_products_previousPage.BackColor = Color.SteelBlue;
            btn_products_previousPage.FlatStyle = FlatStyle.Flat;
            btn_products_previousPage.ForeColor = Color.SteelBlue;
            btn_products_previousPage.Image = Properties.Resources.previousPage_icon_notfill_18;
            btn_products_previousPage.Location = new Point(429, 628);
            btn_products_previousPage.Name = "btn_products_previousPage";
            btn_products_previousPage.Size = new Size(39, 23);
            btn_products_previousPage.TabIndex = 5;
            btn_products_previousPage.UseVisualStyleBackColor = false;
            btn_products_previousPage.Click += btn_products_previousPage_Click;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(17, 20);
            label9.Name = "label9";
            label9.Size = new Size(143, 19);
            label9.TabIndex = 2;
            label9.Text = "All Product's Data";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.LightGray;
            dataGridView2.Location = new Point(17, 56);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 25;
            dataGridView2.ScrollBars = ScrollBars.None;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(954, 565);
            dataGridView2.TabIndex = 0;
            // 
            // products_searchText
            // 
            products_searchText.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            products_searchText.Location = new Point(26, 44);
            products_searchText.Name = "products_searchText";
            products_searchText.Size = new Size(337, 32);
            products_searchText.TabIndex = 18;
            // 
            // btn_products_update
            // 
            btn_products_update.BackColor = Color.Navy;
            btn_products_update.BackGroundColor = Color.Navy;
            btn_products_update.BorderColor = Color.Navy;
            btn_products_update.BorderRadius = 10;
            btn_products_update.BorderSize = 3;
            btn_products_update.FlatAppearance.BorderSize = 0;
            btn_products_update.FlatStyle = FlatStyle.Flat;
            btn_products_update.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_products_update.ForeColor = Color.White;
            btn_products_update.Location = new Point(812, 46);
            btn_products_update.Name = "btn_products_update";
            btn_products_update.Size = new Size(105, 33);
            btn_products_update.TabIndex = 24;
            btn_products_update.Text = "Update";
            btn_products_update.TextColor = Color.White;
            btn_products_update.UseVisualStyleBackColor = false;
            btn_products_update.Click += btn_products_update_Click;
            // 
            // btn_products_remove
            // 
            btn_products_remove.BackColor = Color.DarkRed;
            btn_products_remove.BackGroundColor = Color.DarkRed;
            btn_products_remove.BorderColor = Color.DarkRed;
            btn_products_remove.BorderRadius = 10;
            btn_products_remove.BorderSize = 3;
            btn_products_remove.FlatAppearance.BorderSize = 0;
            btn_products_remove.FlatStyle = FlatStyle.Flat;
            btn_products_remove.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_products_remove.ForeColor = Color.White;
            btn_products_remove.Location = new Point(923, 46);
            btn_products_remove.Name = "btn_products_remove";
            btn_products_remove.Size = new Size(105, 33);
            btn_products_remove.TabIndex = 23;
            btn_products_remove.Text = "Remove";
            btn_products_remove.TextColor = Color.White;
            btn_products_remove.UseVisualStyleBackColor = false;
            btn_products_remove.Click += btn_products_remove_Click;
            // 
            // btn_search_product
            // 
            btn_search_product.BackColor = Color.SteelBlue;
            btn_search_product.BackGroundColor = Color.SteelBlue;
            btn_search_product.BorderColor = Color.RoyalBlue;
            btn_search_product.BorderRadius = 10;
            btn_search_product.BorderSize = 0;
            btn_search_product.FlatAppearance.BorderSize = 0;
            btn_search_product.FlatStyle = FlatStyle.Flat;
            btn_search_product.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search_product.ForeColor = Color.White;
            btn_search_product.Image = Properties.Resources.search_icon_24;
            btn_search_product.Location = new Point(369, 43);
            btn_search_product.Name = "btn_search_product";
            btn_search_product.Size = new Size(88, 33);
            btn_search_product.TabIndex = 26;
            btn_search_product.TextColor = Color.White;
            btn_search_product.UseVisualStyleBackColor = false;
            btn_search_product.Click += btn_search_product_Click;
            // 
            // btn_products_add_final
            // 
            btn_products_add_final.BackColor = Color.DarkGreen;
            btn_products_add_final.BackGroundColor = Color.DarkGreen;
            btn_products_add_final.BorderColor = Color.DarkGreen;
            btn_products_add_final.BorderRadius = 10;
            btn_products_add_final.BorderSize = 3;
            btn_products_add_final.FlatAppearance.BorderSize = 0;
            btn_products_add_final.FlatStyle = FlatStyle.Flat;
            btn_products_add_final.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_products_add_final.ForeColor = Color.White;
            btn_products_add_final.Location = new Point(701, 46);
            btn_products_add_final.Name = "btn_products_add_final";
            btn_products_add_final.Size = new Size(105, 33);
            btn_products_add_final.TabIndex = 27;
            btn_products_add_final.Text = "Add";
            btn_products_add_final.TextColor = Color.White;
            btn_products_add_final.UseVisualStyleBackColor = false;
            btn_products_add_final.Click += btn_products_add_Click;
            // 
            // AdminProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_products_add_final);
            Controls.Add(btn_search_product);
            Controls.Add(btn_products_update);
            Controls.Add(btn_products_remove);
            Controls.Add(products_searchText);
            Controls.Add(panel3);
            Name = "AdminProduct";
            Size = new Size(1054, 770);
            Load += AdminProduct_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Button btn_products_nextPage;
        private Button btn_products_previousPage;
        private TextBox currentPage_txtbox;
        private Label label9;
        private DataGridView dataGridView2;
        private RoundedButton btn_search_products;
        private TextBox products_searchText;
        private RoundedButton btn_products_update;
        private RoundedButton btn_products_remove;
        private RoundedButton btn_search_product;
        private RoundedButton btn_products_add_final;
    }
}
