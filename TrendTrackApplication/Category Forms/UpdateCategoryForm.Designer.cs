namespace TrendTrackApplication.Category_Forms
{
    partial class UpdateCategoryForm
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
            btn_categories_update = new RoundedButton();
            btn_categories_clear = new RoundedButton();
            categories_name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_categories_update);
            panel1.Controls.Add(btn_categories_clear);
            panel1.Controls.Add(categories_name);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(479, 266);
            panel1.TabIndex = 2;
            // 
            // btn_categories_update
            // 
            btn_categories_update.BackColor = Color.Navy;
            btn_categories_update.BackGroundColor = Color.Navy;
            btn_categories_update.BorderColor = Color.RoyalBlue;
            btn_categories_update.BorderRadius = 10;
            btn_categories_update.BorderSize = 0;
            btn_categories_update.FlatAppearance.BorderSize = 0;
            btn_categories_update.FlatStyle = FlatStyle.Flat;
            btn_categories_update.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_categories_update.ForeColor = Color.White;
            btn_categories_update.Location = new Point(243, 218);
            btn_categories_update.Name = "btn_categories_update";
            btn_categories_update.Size = new Size(105, 31);
            btn_categories_update.TabIndex = 20;
            btn_categories_update.Text = "Update";
            btn_categories_update.TextColor = Color.White;
            btn_categories_update.UseVisualStyleBackColor = false;
            btn_categories_update.Click += btn_categories_update_Click;
            // 
            // btn_categories_clear
            // 
            btn_categories_clear.BackColor = Color.RoyalBlue;
            btn_categories_clear.BackGroundColor = Color.RoyalBlue;
            btn_categories_clear.BorderColor = Color.RoyalBlue;
            btn_categories_clear.BorderRadius = 10;
            btn_categories_clear.BorderSize = 0;
            btn_categories_clear.FlatAppearance.BorderSize = 0;
            btn_categories_clear.FlatStyle = FlatStyle.Flat;
            btn_categories_clear.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_categories_clear.ForeColor = Color.White;
            btn_categories_clear.Location = new Point(354, 218);
            btn_categories_clear.Name = "btn_categories_clear";
            btn_categories_clear.Size = new Size(105, 31);
            btn_categories_clear.TabIndex = 19;
            btn_categories_clear.Text = "Clear";
            btn_categories_clear.TextColor = Color.White;
            btn_categories_clear.UseVisualStyleBackColor = false;
            btn_categories_clear.Click += btn_categories_clear_Click;
            // 
            // categories_name
            // 
            categories_name.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categories_name.Location = new Point(29, 91);
            categories_name.Name = "categories_name";
            categories_name.Size = new Size(190, 26);
            categories_name.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F);
            label2.Location = new Point(29, 69);
            label2.Name = "label2";
            label2.Size = new Size(115, 19);
            label2.TabIndex = 11;
            label2.Text = "Category Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(198, 22);
            label1.TabIndex = 10;
            label1.Text = "Category Information";
            // 
            // UpdateCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(505, 286);
            Controls.Add(panel1);
            Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UpdateCategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Category";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RoundedButton btn_categories_update;
        private RoundedButton btn_categories_clear;
        private TextBox categories_name;
        private Label label2;
        private Label label1;
    }
}