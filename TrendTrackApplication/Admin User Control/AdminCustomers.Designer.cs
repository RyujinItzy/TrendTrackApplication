﻿namespace TrendTrackApplication
{
    partial class AdminCustomers
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
            panel7 = new Panel();
            btn_customers_nextPage = new Button();
            btn_customers_previousPage = new Button();
            currentPage_txtbox = new TextBox();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            btn_search_customer = new RoundedButton();
            customers_searchText = new TextBox();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(btn_customers_nextPage);
            panel7.Controls.Add(btn_customers_previousPage);
            panel7.Controls.Add(currentPage_txtbox);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(dataGridView1);
            panel7.Location = new Point(26, 89);
            panel7.Name = "panel7";
            panel7.Size = new Size(1002, 657);
            panel7.TabIndex = 11;
            // 
            // btn_customers_nextPage
            // 
            btn_customers_nextPage.BackColor = Color.SteelBlue;
            btn_customers_nextPage.FlatStyle = FlatStyle.Flat;
            btn_customers_nextPage.ForeColor = Color.CornflowerBlue;
            btn_customers_nextPage.Image = Properties.Resources.nextPage_icon_notfill_18;
            btn_customers_nextPage.Location = new Point(523, 628);
            btn_customers_nextPage.Name = "btn_customers_nextPage";
            btn_customers_nextPage.Size = new Size(39, 23);
            btn_customers_nextPage.TabIndex = 6;
            btn_customers_nextPage.UseVisualStyleBackColor = false;
            btn_customers_nextPage.Click += btn_customers_nextPage_Click;
            // 
            // btn_customers_previousPage
            // 
            btn_customers_previousPage.BackColor = Color.SteelBlue;
            btn_customers_previousPage.FlatStyle = FlatStyle.Flat;
            btn_customers_previousPage.ForeColor = Color.SteelBlue;
            btn_customers_previousPage.Image = Properties.Resources.previousPage_icon_notfill_18;
            btn_customers_previousPage.Location = new Point(429, 628);
            btn_customers_previousPage.Name = "btn_customers_previousPage";
            btn_customers_previousPage.Size = new Size(39, 23);
            btn_customers_previousPage.TabIndex = 5;
            btn_customers_previousPage.UseVisualStyleBackColor = false;
            btn_customers_previousPage.Click += btn_customers_previousPage_Click;
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
            label12.Size = new Size(110, 19);
            label12.TabIndex = 2;
            label12.Text = "All Customers";
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
            // btn_search_customer
            // 
            btn_search_customer.BackColor = Color.SteelBlue;
            btn_search_customer.BackGroundColor = Color.SteelBlue;
            btn_search_customer.BorderColor = Color.RoyalBlue;
            btn_search_customer.BorderRadius = 10;
            btn_search_customer.BorderSize = 0;
            btn_search_customer.FlatAppearance.BorderSize = 0;
            btn_search_customer.FlatStyle = FlatStyle.Flat;
            btn_search_customer.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search_customer.ForeColor = Color.White;
            btn_search_customer.Image = Properties.Resources.search_icon_24;
            btn_search_customer.Location = new Point(369, 43);
            btn_search_customer.Name = "btn_search_customer";
            btn_search_customer.Size = new Size(88, 33);
            btn_search_customer.TabIndex = 19;
            btn_search_customer.TextColor = Color.White;
            btn_search_customer.UseVisualStyleBackColor = false;
            btn_search_customer.Click += btn_search_customer_Click;
            // 
            // customers_searchText
            // 
            customers_searchText.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customers_searchText.Location = new Point(26, 44);
            customers_searchText.Name = "customers_searchText";
            customers_searchText.Size = new Size(337, 32);
            customers_searchText.TabIndex = 18;
            // 
            // AdminCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_search_customer);
            Controls.Add(customers_searchText);
            Controls.Add(panel7);
            Name = "AdminCustomers";
            Size = new Size(1054, 770);
            Load += AdminCustomers_Load;
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel7;
        private Button btn_customers_nextPage;
        private Button btn_customers_previousPage;
        private TextBox currentPage_txtbox;
        private Label label12;
        private DataGridView dataGridView1;
        private RoundedButton btn_search_customer;
        private TextBox customers_searchText;
    }
}
