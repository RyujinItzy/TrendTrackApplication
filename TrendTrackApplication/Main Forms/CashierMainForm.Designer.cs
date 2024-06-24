namespace TrendTrackApplication
{
    partial class CashierMainForm
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
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            adminCustomers1 = new AdminCustomers();
            cashierOrder1 = new Cashier_User_Control.CashierOrder();
            panel2 = new Panel();
            btn_logout_cashier = new Button();
            btn_customer_cashier = new Button();
            btn_order_cashier = new Button();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1339, 38);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(493, 19);
            label1.TabIndex = 1;
            label1.Text = "Trend Track POS and Inventory Management System | Cashier's Portal";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(adminCustomers1);
            flowLayoutPanel1.Controls.Add(cashierOrder1);
            flowLayoutPanel1.Location = new Point(285, 38);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1054, 770);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // adminCustomers1
            // 
            adminCustomers1.Location = new Point(3, 3);
            adminCustomers1.Name = "adminCustomers1";
            adminCustomers1.Size = new Size(1054, 770);
            adminCustomers1.TabIndex = 1;
            // 
            // cashierOrder1
            // 
            cashierOrder1.Location = new Point(3, 779);
            cashierOrder1.Name = "cashierOrder1";
            cashierOrder1.Size = new Size(1054, 770);
            cashierOrder1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btn_logout_cashier);
            panel2.Controls.Add(btn_customer_cashier);
            panel2.Controls.Add(btn_order_cashier);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 773);
            panel2.TabIndex = 4;
            // 
            // btn_logout_cashier
            // 
            btn_logout_cashier.Dock = DockStyle.Top;
            btn_logout_cashier.FlatAppearance.BorderSize = 0;
            btn_logout_cashier.FlatStyle = FlatStyle.Flat;
            btn_logout_cashier.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout_cashier.ForeColor = Color.White;
            btn_logout_cashier.Image = Properties.Resources.logout_icon_24;
            btn_logout_cashier.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout_cashier.Location = new Point(0, 311);
            btn_logout_cashier.Name = "btn_logout_cashier";
            btn_logout_cashier.Padding = new Padding(10, 0, 0, 0);
            btn_logout_cashier.Size = new Size(279, 53);
            btn_logout_cashier.TabIndex = 39;
            btn_logout_cashier.Text = "          Logout";
            btn_logout_cashier.TextAlign = ContentAlignment.MiddleLeft;
            btn_logout_cashier.UseVisualStyleBackColor = true;
            btn_logout_cashier.Click += btn_logout_cashier_Click;
            // 
            // btn_customer_cashier
            // 
            btn_customer_cashier.Dock = DockStyle.Top;
            btn_customer_cashier.FlatAppearance.BorderSize = 0;
            btn_customer_cashier.FlatStyle = FlatStyle.Flat;
            btn_customer_cashier.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_customer_cashier.ForeColor = Color.White;
            btn_customer_cashier.Image = Properties.Resources.customer_icon_24;
            btn_customer_cashier.ImageAlign = ContentAlignment.MiddleLeft;
            btn_customer_cashier.Location = new Point(0, 258);
            btn_customer_cashier.Name = "btn_customer_cashier";
            btn_customer_cashier.Padding = new Padding(10, 0, 0, 0);
            btn_customer_cashier.Size = new Size(279, 53);
            btn_customer_cashier.TabIndex = 38;
            btn_customer_cashier.Text = "          Customers";
            btn_customer_cashier.TextAlign = ContentAlignment.MiddleLeft;
            btn_customer_cashier.UseVisualStyleBackColor = true;
            btn_customer_cashier.Click += btn_customer_cashier_Click;
            // 
            // btn_order_cashier
            // 
            btn_order_cashier.Dock = DockStyle.Top;
            btn_order_cashier.FlatAppearance.BorderSize = 0;
            btn_order_cashier.FlatStyle = FlatStyle.Flat;
            btn_order_cashier.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_order_cashier.ForeColor = Color.White;
            btn_order_cashier.Image = Properties.Resources.sale_icon_24;
            btn_order_cashier.ImageAlign = ContentAlignment.MiddleLeft;
            btn_order_cashier.Location = new Point(0, 205);
            btn_order_cashier.Name = "btn_order_cashier";
            btn_order_cashier.Padding = new Padding(10, 0, 0, 0);
            btn_order_cashier.Size = new Size(279, 53);
            btn_order_cashier.TabIndex = 31;
            btn_order_cashier.Text = "          Order";
            btn_order_cashier.TextAlign = ContentAlignment.MiddleLeft;
            btn_order_cashier.UseVisualStyleBackColor = true;
            btn_order_cashier.Click += btn_order_cashier_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 205);
            panel3.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(115, 167);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 1;
            label2.Text = "Cashier";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Trend__track_logo;
            pictureBox2.Location = new Point(12, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(254, 158);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // CashierMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 811);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "CashierMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private PictureBox pictureBox2;
        private Button btn_order_cashier;
        private Cashier_User_Control.CashierOrder cashierOrder1;
        private Button btn_logout_cashier;
        private Button btn_customer_cashier;
        private AdminCustomers adminCustomers1;
    }
}