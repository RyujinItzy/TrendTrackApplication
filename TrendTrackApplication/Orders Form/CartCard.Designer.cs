namespace TrendTrackApplication.Orders_Form
{
    partial class CartCard
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
            panel1 = new Panel();
            lbl_ProdPrice = new Label();
            lbl_remove = new Label();
            lbl_ProdName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbl_ProdPrice);
            panel1.Controls.Add(lbl_remove);
            panel1.Controls.Add(lbl_ProdName);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 68);
            panel1.TabIndex = 0;
            // 
            // lbl_ProdPrice
            // 
            lbl_ProdPrice.AutoSize = true;
            lbl_ProdPrice.Font = new Font("Calisto MT", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ProdPrice.Location = new Point(194, 14);
            lbl_ProdPrice.Name = "lbl_ProdPrice";
            lbl_ProdPrice.Size = new Size(42, 17);
            lbl_ProdPrice.TabIndex = 3;
            lbl_ProdPrice.Text = "label1";
            lbl_ProdPrice.Click += lbl_ProdPrice_Click;
            // 
            // lbl_remove
            // 
            lbl_remove.AutoSize = true;
            lbl_remove.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_remove.ForeColor = Color.DarkRed;
            lbl_remove.Location = new Point(14, 42);
            lbl_remove.Name = "lbl_remove";
            lbl_remove.Size = new Size(56, 15);
            lbl_remove.TabIndex = 2;
            lbl_remove.Text = "Remove";
            lbl_remove.Click += lbl_remove_Click;
            // 
            // lbl_ProdName
            // 
            lbl_ProdName.AutoSize = true;
            lbl_ProdName.Font = new Font("Calisto MT", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ProdName.Location = new Point(14, 14);
            lbl_ProdName.Name = "lbl_ProdName";
            lbl_ProdName.Size = new Size(42, 17);
            lbl_ProdName.TabIndex = 0;
            lbl_ProdName.Text = "label1";
            lbl_ProdName.Click += lbl_ProdName_Click;
            // 
            // CartCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            Controls.Add(panel1);
            Name = "CartCard";
            Size = new Size(272, 74);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_ProdPrice;
        private Label lbl_remove;
        private Label lbl_ProdName;
    }
}
