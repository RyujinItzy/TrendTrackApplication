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
            panel2 = new Panel();
            btn_product_cashier = new Button();
            btn_dashboard_cashier = new Button();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            btn_order_cashier = new Button();
            btn_actlogs_monitor_dropdown_cashier = new Button();
            btn_customers_cashier = new Button();
            panel_Monitor_subMenu = new Panel();
            btn_archive_cashier = new Button();
            btn_auditTrail_cashier = new Button();
            btn_ActivityLog_cashier = new Button();
            btn_reports_cashier = new Button();
            btn_logout_cashier = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_Monitor_subMenu.SuspendLayout();
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
            flowLayoutPanel1.Location = new Point(285, 38);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1054, 770);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btn_logout_cashier);
            panel2.Controls.Add(btn_reports_cashier);
            panel2.Controls.Add(panel_Monitor_subMenu);
            panel2.Controls.Add(btn_actlogs_monitor_dropdown_cashier);
            panel2.Controls.Add(btn_customers_cashier);
            panel2.Controls.Add(btn_order_cashier);
            panel2.Controls.Add(btn_product_cashier);
            panel2.Controls.Add(btn_dashboard_cashier);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 773);
            panel2.TabIndex = 4;
            // 
            // btn_product_cashier
            // 
            btn_product_cashier.Dock = DockStyle.Top;
            btn_product_cashier.FlatAppearance.BorderSize = 0;
            btn_product_cashier.FlatStyle = FlatStyle.Flat;
            btn_product_cashier.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_product_cashier.ForeColor = Color.White;
            btn_product_cashier.Image = Properties.Resources.product_icon_white_241;
            btn_product_cashier.ImageAlign = ContentAlignment.MiddleLeft;
            btn_product_cashier.Location = new Point(0, 258);
            btn_product_cashier.Name = "btn_product_cashier";
            btn_product_cashier.Padding = new Padding(10, 0, 0, 0);
            btn_product_cashier.Size = new Size(279, 53);
            btn_product_cashier.TabIndex = 23;
            btn_product_cashier.Text = "          Products";
            btn_product_cashier.TextAlign = ContentAlignment.MiddleLeft;
            btn_product_cashier.UseVisualStyleBackColor = true;
            // 
            // btn_dashboard_cashier
            // 
            btn_dashboard_cashier.Dock = DockStyle.Top;
            btn_dashboard_cashier.FlatAppearance.BorderSize = 0;
            btn_dashboard_cashier.FlatStyle = FlatStyle.Flat;
            btn_dashboard_cashier.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_dashboard_cashier.ForeColor = Color.White;
            btn_dashboard_cashier.Image = Properties.Resources.dashboard_icon_24;
            btn_dashboard_cashier.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dashboard_cashier.Location = new Point(0, 205);
            btn_dashboard_cashier.Name = "btn_dashboard_cashier";
            btn_dashboard_cashier.Padding = new Padding(10, 0, 0, 0);
            btn_dashboard_cashier.Size = new Size(279, 53);
            btn_dashboard_cashier.TabIndex = 22;
            btn_dashboard_cashier.Text = "          Dashboard";
            btn_dashboard_cashier.TextAlign = ContentAlignment.MiddleLeft;
            btn_dashboard_cashier.UseVisualStyleBackColor = true;
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
            // btn_order_cashier
            // 
            btn_order_cashier.Dock = DockStyle.Top;
            btn_order_cashier.FlatAppearance.BorderSize = 0;
            btn_order_cashier.FlatStyle = FlatStyle.Flat;
            btn_order_cashier.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_order_cashier.ForeColor = Color.White;
            btn_order_cashier.Image = Properties.Resources.order_icon_24;
            btn_order_cashier.ImageAlign = ContentAlignment.MiddleLeft;
            btn_order_cashier.Location = new Point(0, 311);
            btn_order_cashier.Name = "btn_order_cashier";
            btn_order_cashier.Padding = new Padding(10, 0, 0, 0);
            btn_order_cashier.Size = new Size(279, 53);
            btn_order_cashier.TabIndex = 31;
            btn_order_cashier.Text = "          Order";
            btn_order_cashier.TextAlign = ContentAlignment.MiddleLeft;
            btn_order_cashier.UseVisualStyleBackColor = true;
            // 
            // btn_actlogs_monitor_dropdown_cashier
            // 
            btn_actlogs_monitor_dropdown_cashier.Dock = DockStyle.Top;
            btn_actlogs_monitor_dropdown_cashier.FlatAppearance.BorderSize = 0;
            btn_actlogs_monitor_dropdown_cashier.FlatStyle = FlatStyle.Flat;
            btn_actlogs_monitor_dropdown_cashier.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_actlogs_monitor_dropdown_cashier.ForeColor = Color.White;
            btn_actlogs_monitor_dropdown_cashier.Image = Properties.Resources.acivity_icon_24;
            btn_actlogs_monitor_dropdown_cashier.ImageAlign = ContentAlignment.MiddleLeft;
            btn_actlogs_monitor_dropdown_cashier.Location = new Point(0, 417);
            btn_actlogs_monitor_dropdown_cashier.Name = "btn_actlogs_monitor_dropdown_cashier";
            btn_actlogs_monitor_dropdown_cashier.Padding = new Padding(10, 0, 0, 0);
            btn_actlogs_monitor_dropdown_cashier.Size = new Size(279, 53);
            btn_actlogs_monitor_dropdown_cashier.TabIndex = 33;
            btn_actlogs_monitor_dropdown_cashier.Text = "          Activity Monitoring";
            btn_actlogs_monitor_dropdown_cashier.TextAlign = ContentAlignment.MiddleLeft;
            btn_actlogs_monitor_dropdown_cashier.UseVisualStyleBackColor = true;
            // 
            // btn_customers_cashier
            // 
            btn_customers_cashier.Dock = DockStyle.Top;
            btn_customers_cashier.FlatAppearance.BorderSize = 0;
            btn_customers_cashier.FlatStyle = FlatStyle.Flat;
            btn_customers_cashier.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_customers_cashier.ForeColor = Color.White;
            btn_customers_cashier.Image = Properties.Resources.customer_icon_24;
            btn_customers_cashier.ImageAlign = ContentAlignment.MiddleLeft;
            btn_customers_cashier.Location = new Point(0, 364);
            btn_customers_cashier.Name = "btn_customers_cashier";
            btn_customers_cashier.Padding = new Padding(10, 0, 0, 0);
            btn_customers_cashier.Size = new Size(279, 53);
            btn_customers_cashier.TabIndex = 32;
            btn_customers_cashier.Text = "          Customers";
            btn_customers_cashier.TextAlign = ContentAlignment.MiddleLeft;
            btn_customers_cashier.UseVisualStyleBackColor = true;
            // 
            // panel_Monitor_subMenu
            // 
            panel_Monitor_subMenu.BackColor = Color.SkyBlue;
            panel_Monitor_subMenu.Controls.Add(btn_archive_cashier);
            panel_Monitor_subMenu.Controls.Add(btn_auditTrail_cashier);
            panel_Monitor_subMenu.Controls.Add(btn_ActivityLog_cashier);
            panel_Monitor_subMenu.Dock = DockStyle.Top;
            panel_Monitor_subMenu.Location = new Point(0, 470);
            panel_Monitor_subMenu.Name = "panel_Monitor_subMenu";
            panel_Monitor_subMenu.Size = new Size(279, 169);
            panel_Monitor_subMenu.TabIndex = 34;
            // 
            // btn_archive_cashier
            // 
            btn_archive_cashier.Dock = DockStyle.Top;
            btn_archive_cashier.FlatAppearance.BorderSize = 0;
            btn_archive_cashier.FlatStyle = FlatStyle.Flat;
            btn_archive_cashier.Font = new Font("Cambria", 12F);
            btn_archive_cashier.ForeColor = Color.White;
            btn_archive_cashier.Image = Properties.Resources.archive_icon_24;
            btn_archive_cashier.ImageAlign = ContentAlignment.MiddleLeft;
            btn_archive_cashier.Location = new Point(0, 106);
            btn_archive_cashier.Name = "btn_archive_cashier";
            btn_archive_cashier.Padding = new Padding(30, 0, 0, 0);
            btn_archive_cashier.Size = new Size(279, 53);
            btn_archive_cashier.TabIndex = 2;
            btn_archive_cashier.Text = "          Archive";
            btn_archive_cashier.TextAlign = ContentAlignment.MiddleLeft;
            btn_archive_cashier.UseVisualStyleBackColor = true;
            // 
            // btn_auditTrail_cashier
            // 
            btn_auditTrail_cashier.Dock = DockStyle.Top;
            btn_auditTrail_cashier.FlatAppearance.BorderSize = 0;
            btn_auditTrail_cashier.FlatStyle = FlatStyle.Flat;
            btn_auditTrail_cashier.Font = new Font("Cambria", 12F);
            btn_auditTrail_cashier.ForeColor = Color.White;
            btn_auditTrail_cashier.Image = Properties.Resources.audittrail_icon_241;
            btn_auditTrail_cashier.ImageAlign = ContentAlignment.MiddleLeft;
            btn_auditTrail_cashier.Location = new Point(0, 53);
            btn_auditTrail_cashier.Name = "btn_auditTrail_cashier";
            btn_auditTrail_cashier.Padding = new Padding(30, 0, 0, 0);
            btn_auditTrail_cashier.Size = new Size(279, 53);
            btn_auditTrail_cashier.TabIndex = 1;
            btn_auditTrail_cashier.Text = "          Audit Trail";
            btn_auditTrail_cashier.TextAlign = ContentAlignment.MiddleLeft;
            btn_auditTrail_cashier.UseVisualStyleBackColor = true;
            // 
            // btn_ActivityLog_cashier
            // 
            btn_ActivityLog_cashier.Dock = DockStyle.Top;
            btn_ActivityLog_cashier.FlatAppearance.BorderSize = 0;
            btn_ActivityLog_cashier.FlatStyle = FlatStyle.Flat;
            btn_ActivityLog_cashier.Font = new Font("Cambria", 12F);
            btn_ActivityLog_cashier.ForeColor = Color.White;
            btn_ActivityLog_cashier.Image = Properties.Resources.activitylog_icon_24;
            btn_ActivityLog_cashier.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ActivityLog_cashier.Location = new Point(0, 0);
            btn_ActivityLog_cashier.Name = "btn_ActivityLog_cashier";
            btn_ActivityLog_cashier.Padding = new Padding(30, 0, 0, 0);
            btn_ActivityLog_cashier.Size = new Size(279, 53);
            btn_ActivityLog_cashier.TabIndex = 0;
            btn_ActivityLog_cashier.Text = "          Activity Log";
            btn_ActivityLog_cashier.TextAlign = ContentAlignment.MiddleLeft;
            btn_ActivityLog_cashier.UseVisualStyleBackColor = true;
            // 
            // btn_reports_cashier
            // 
            btn_reports_cashier.Dock = DockStyle.Top;
            btn_reports_cashier.FlatAppearance.BorderSize = 0;
            btn_reports_cashier.FlatStyle = FlatStyle.Flat;
            btn_reports_cashier.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_reports_cashier.ForeColor = Color.White;
            btn_reports_cashier.Image = Properties.Resources.reports_icon_24;
            btn_reports_cashier.ImageAlign = ContentAlignment.MiddleLeft;
            btn_reports_cashier.Location = new Point(0, 639);
            btn_reports_cashier.Name = "btn_reports_cashier";
            btn_reports_cashier.Padding = new Padding(10, 0, 0, 0);
            btn_reports_cashier.Size = new Size(279, 53);
            btn_reports_cashier.TabIndex = 35;
            btn_reports_cashier.Text = "          Reports";
            btn_reports_cashier.TextAlign = ContentAlignment.MiddleLeft;
            btn_reports_cashier.UseVisualStyleBackColor = true;
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
            btn_logout_cashier.Location = new Point(0, 692);
            btn_logout_cashier.Name = "btn_logout_cashier";
            btn_logout_cashier.Padding = new Padding(10, 0, 0, 0);
            btn_logout_cashier.Size = new Size(279, 53);
            btn_logout_cashier.TabIndex = 36;
            btn_logout_cashier.Text = "          Logout";
            btn_logout_cashier.TextAlign = ContentAlignment.MiddleLeft;
            btn_logout_cashier.UseVisualStyleBackColor = true;
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
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_Monitor_subMenu.ResumeLayout(false);
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
        private Button btn_dashboard_cashier;
        private Button btn_product_cashier;
        private Button btn_order_cashier;
        private Button btn_actlogs_monitor_dropdown_cashier;
        private Button btn_customers_cashier;
        private Panel panel_Monitor_subMenu;
        private Button btn_archive_cashier;
        private Button btn_auditTrail_cashier;
        private Button btn_ActivityLog_cashier;
        private Button btn_reports_cashier;
        private Button btn_logout_cashier;
    }
}