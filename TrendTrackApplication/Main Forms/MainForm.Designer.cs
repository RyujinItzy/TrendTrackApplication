namespace TrendTrackApplication
{
    partial class MainForm
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
            panelContainer = new FlowLayoutPanel();
            adminUsers2 = new AdminUsers();
            adminDashboard2 = new AdminDashboard();
            panelSideMenu = new Panel();
            btn_logout = new Button();
            btn_reports = new Button();
            panel_Monitor_subMenu = new Panel();
            btn_archive = new Button();
            btn_auditTrail = new Button();
            btn_ActivityLog = new Button();
            btn_actlogs_monitor_dropdown = new Button();
            btn_customers = new Button();
            btn_users = new Button();
            panel_inventory_subMenu = new Panel();
            btn_products = new Button();
            btn_categories = new Button();
            btn_inventory_dropdown = new Button();
            btn_dashboard = new Button();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            adminDashboard1 = new AdminDashboard();
            adminUsers3 = new AdminUsers();
            panel1.SuspendLayout();
            panelContainer.SuspendLayout();
            panelSideMenu.SuspendLayout();
            panel_Monitor_subMenu.SuspendLayout();
            panel_inventory_subMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(adminUsers3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1339, 38);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(486, 19);
            label1.TabIndex = 1;
            label1.Text = "Trend Track POS and Inventory Management System | Admin's Portal";
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(adminUsers2);
            panelContainer.Controls.Add(adminDashboard2);
            panelContainer.Location = new Point(285, 38);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1054, 770);
            panelContainer.TabIndex = 2;
            // 
            // adminUsers2
            // 
            adminUsers2.Location = new Point(3, 3);
            adminUsers2.Name = "adminUsers2";
            adminUsers2.Size = new Size(1054, 770);
            adminUsers2.TabIndex = 1;
            // 
            // adminDashboard2
            // 
            adminDashboard2.Location = new Point(3, 779);
            adminDashboard2.Name = "adminDashboard2";
            adminDashboard2.Size = new Size(1054, 770);
            adminDashboard2.TabIndex = 0;
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelSideMenu.BackColor = Color.SteelBlue;
            panelSideMenu.Controls.Add(btn_logout);
            panelSideMenu.Controls.Add(btn_reports);
            panelSideMenu.Controls.Add(panel_Monitor_subMenu);
            panelSideMenu.Controls.Add(btn_actlogs_monitor_dropdown);
            panelSideMenu.Controls.Add(btn_customers);
            panelSideMenu.Controls.Add(btn_users);
            panelSideMenu.Controls.Add(panel_inventory_subMenu);
            panelSideMenu.Controls.Add(btn_inventory_dropdown);
            panelSideMenu.Controls.Add(btn_dashboard);
            panelSideMenu.Controls.Add(panel2);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 38);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(279, 777);
            panelSideMenu.TabIndex = 1;
            // 
            // btn_logout
            // 
            btn_logout.Dock = DockStyle.Top;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = Color.White;
            btn_logout.Image = Properties.Resources.logout_icon_24;
            btn_logout.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout.Location = new Point(0, 808);
            btn_logout.Name = "btn_logout";
            btn_logout.Padding = new Padding(10, 0, 0, 0);
            btn_logout.Size = new Size(262, 53);
            btn_logout.TabIndex = 29;
            btn_logout.Text = "          Logout";
            btn_logout.TextAlign = ContentAlignment.MiddleLeft;
            btn_logout.UseVisualStyleBackColor = true;
            // 
            // btn_reports
            // 
            btn_reports.Dock = DockStyle.Top;
            btn_reports.FlatAppearance.BorderSize = 0;
            btn_reports.FlatStyle = FlatStyle.Flat;
            btn_reports.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_reports.ForeColor = Color.White;
            btn_reports.Image = Properties.Resources.reports_icon_24;
            btn_reports.ImageAlign = ContentAlignment.MiddleLeft;
            btn_reports.Location = new Point(0, 755);
            btn_reports.Name = "btn_reports";
            btn_reports.Padding = new Padding(10, 0, 0, 0);
            btn_reports.Size = new Size(262, 53);
            btn_reports.TabIndex = 28;
            btn_reports.Text = "          Reports";
            btn_reports.TextAlign = ContentAlignment.MiddleLeft;
            btn_reports.UseVisualStyleBackColor = true;
            btn_reports.Click += button8_Click;
            // 
            // panel_Monitor_subMenu
            // 
            panel_Monitor_subMenu.BackColor = Color.SkyBlue;
            panel_Monitor_subMenu.Controls.Add(btn_archive);
            panel_Monitor_subMenu.Controls.Add(btn_auditTrail);
            panel_Monitor_subMenu.Controls.Add(btn_ActivityLog);
            panel_Monitor_subMenu.Dock = DockStyle.Top;
            panel_Monitor_subMenu.Location = new Point(0, 586);
            panel_Monitor_subMenu.Name = "panel_Monitor_subMenu";
            panel_Monitor_subMenu.Size = new Size(262, 169);
            panel_Monitor_subMenu.TabIndex = 27;
            // 
            // btn_archive
            // 
            btn_archive.Dock = DockStyle.Top;
            btn_archive.FlatAppearance.BorderSize = 0;
            btn_archive.FlatStyle = FlatStyle.Flat;
            btn_archive.Font = new Font("Cambria", 12F);
            btn_archive.ForeColor = Color.White;
            btn_archive.Image = Properties.Resources.archive_icon_24;
            btn_archive.ImageAlign = ContentAlignment.MiddleLeft;
            btn_archive.Location = new Point(0, 106);
            btn_archive.Name = "btn_archive";
            btn_archive.Padding = new Padding(30, 0, 0, 0);
            btn_archive.Size = new Size(262, 53);
            btn_archive.TabIndex = 2;
            btn_archive.Text = "          Archived";
            btn_archive.TextAlign = ContentAlignment.MiddleLeft;
            btn_archive.UseVisualStyleBackColor = true;
            btn_archive.Click += btn_archive_Click;
            // 
            // btn_auditTrail
            // 
            btn_auditTrail.Dock = DockStyle.Top;
            btn_auditTrail.FlatAppearance.BorderSize = 0;
            btn_auditTrail.FlatStyle = FlatStyle.Flat;
            btn_auditTrail.Font = new Font("Cambria", 12F);
            btn_auditTrail.ForeColor = Color.White;
            btn_auditTrail.Image = Properties.Resources.audittrail_icon_241;
            btn_auditTrail.ImageAlign = ContentAlignment.MiddleLeft;
            btn_auditTrail.Location = new Point(0, 53);
            btn_auditTrail.Name = "btn_auditTrail";
            btn_auditTrail.Padding = new Padding(30, 0, 0, 0);
            btn_auditTrail.Size = new Size(262, 53);
            btn_auditTrail.TabIndex = 1;
            btn_auditTrail.Text = "          Audit Trail";
            btn_auditTrail.TextAlign = ContentAlignment.MiddleLeft;
            btn_auditTrail.UseVisualStyleBackColor = true;
            btn_auditTrail.Click += btn_auditActLog_Click;
            // 
            // btn_ActivityLog
            // 
            btn_ActivityLog.Dock = DockStyle.Top;
            btn_ActivityLog.FlatAppearance.BorderSize = 0;
            btn_ActivityLog.FlatStyle = FlatStyle.Flat;
            btn_ActivityLog.Font = new Font("Cambria", 12F);
            btn_ActivityLog.ForeColor = Color.White;
            btn_ActivityLog.Image = Properties.Resources.activitylog_icon_24;
            btn_ActivityLog.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ActivityLog.Location = new Point(0, 0);
            btn_ActivityLog.Name = "btn_ActivityLog";
            btn_ActivityLog.Padding = new Padding(30, 0, 0, 0);
            btn_ActivityLog.Size = new Size(262, 53);
            btn_ActivityLog.TabIndex = 0;
            btn_ActivityLog.Text = "          Activity Log";
            btn_ActivityLog.TextAlign = ContentAlignment.MiddleLeft;
            btn_ActivityLog.UseVisualStyleBackColor = true;
            btn_ActivityLog.Click += btn_auditActLog_Click;
            // 
            // btn_actlogs_monitor_dropdown
            // 
            btn_actlogs_monitor_dropdown.Dock = DockStyle.Top;
            btn_actlogs_monitor_dropdown.FlatAppearance.BorderSize = 0;
            btn_actlogs_monitor_dropdown.FlatStyle = FlatStyle.Flat;
            btn_actlogs_monitor_dropdown.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_actlogs_monitor_dropdown.ForeColor = Color.White;
            btn_actlogs_monitor_dropdown.Image = Properties.Resources.acivity_icon_24;
            btn_actlogs_monitor_dropdown.ImageAlign = ContentAlignment.MiddleLeft;
            btn_actlogs_monitor_dropdown.Location = new Point(0, 533);
            btn_actlogs_monitor_dropdown.Name = "btn_actlogs_monitor_dropdown";
            btn_actlogs_monitor_dropdown.Padding = new Padding(10, 0, 0, 0);
            btn_actlogs_monitor_dropdown.Size = new Size(262, 53);
            btn_actlogs_monitor_dropdown.TabIndex = 26;
            btn_actlogs_monitor_dropdown.Text = "          Activity Monitoring";
            btn_actlogs_monitor_dropdown.TextAlign = ContentAlignment.MiddleLeft;
            btn_actlogs_monitor_dropdown.UseVisualStyleBackColor = true;
            btn_actlogs_monitor_dropdown.Click += btn_actlogs_monitor_dropdown_Click;
            // 
            // btn_customers
            // 
            btn_customers.Dock = DockStyle.Top;
            btn_customers.FlatAppearance.BorderSize = 0;
            btn_customers.FlatStyle = FlatStyle.Flat;
            btn_customers.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_customers.ForeColor = Color.White;
            btn_customers.Image = Properties.Resources.customer_icon_24;
            btn_customers.ImageAlign = ContentAlignment.MiddleLeft;
            btn_customers.Location = new Point(0, 480);
            btn_customers.Name = "btn_customers";
            btn_customers.Padding = new Padding(10, 0, 0, 0);
            btn_customers.Size = new Size(262, 53);
            btn_customers.TabIndex = 25;
            btn_customers.Text = "          Customers";
            btn_customers.TextAlign = ContentAlignment.MiddleLeft;
            btn_customers.UseVisualStyleBackColor = true;
            btn_customers.Click += btn_customers_Click;
            // 
            // btn_users
            // 
            btn_users.Dock = DockStyle.Top;
            btn_users.FlatAppearance.BorderSize = 0;
            btn_users.FlatStyle = FlatStyle.Flat;
            btn_users.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_users.ForeColor = Color.White;
            btn_users.Image = Properties.Resources.users_icon_24;
            btn_users.ImageAlign = ContentAlignment.MiddleLeft;
            btn_users.Location = new Point(0, 427);
            btn_users.Name = "btn_users";
            btn_users.Padding = new Padding(10, 0, 0, 0);
            btn_users.Size = new Size(262, 53);
            btn_users.TabIndex = 24;
            btn_users.Text = "          Users";
            btn_users.TextAlign = ContentAlignment.MiddleLeft;
            btn_users.UseVisualStyleBackColor = true;
            btn_users.Click += btn_users_Click;
            // 
            // panel_inventory_subMenu
            // 
            panel_inventory_subMenu.BackColor = Color.SkyBlue;
            panel_inventory_subMenu.Controls.Add(btn_products);
            panel_inventory_subMenu.Controls.Add(btn_categories);
            panel_inventory_subMenu.Dock = DockStyle.Top;
            panel_inventory_subMenu.Location = new Point(0, 311);
            panel_inventory_subMenu.Name = "panel_inventory_subMenu";
            panel_inventory_subMenu.Size = new Size(262, 116);
            panel_inventory_subMenu.TabIndex = 23;
            // 
            // btn_products
            // 
            btn_products.Dock = DockStyle.Top;
            btn_products.FlatAppearance.BorderSize = 0;
            btn_products.FlatStyle = FlatStyle.Flat;
            btn_products.Font = new Font("Cambria", 12F);
            btn_products.ForeColor = Color.White;
            btn_products.Image = Properties.Resources.product_icon_white_24;
            btn_products.ImageAlign = ContentAlignment.MiddleLeft;
            btn_products.Location = new Point(0, 53);
            btn_products.Name = "btn_products";
            btn_products.Padding = new Padding(30, 0, 0, 0);
            btn_products.Size = new Size(262, 53);
            btn_products.TabIndex = 1;
            btn_products.Text = "          Products";
            btn_products.TextAlign = ContentAlignment.MiddleLeft;
            btn_products.UseVisualStyleBackColor = true;
            btn_products.Click += btn_products_Click;
            // 
            // btn_categories
            // 
            btn_categories.Dock = DockStyle.Top;
            btn_categories.FlatAppearance.BorderSize = 0;
            btn_categories.FlatStyle = FlatStyle.Flat;
            btn_categories.Font = new Font("Cambria", 12F);
            btn_categories.ForeColor = Color.White;
            btn_categories.Image = Properties.Resources.categories_icon_24;
            btn_categories.ImageAlign = ContentAlignment.MiddleLeft;
            btn_categories.Location = new Point(0, 0);
            btn_categories.Name = "btn_categories";
            btn_categories.Padding = new Padding(30, 0, 0, 0);
            btn_categories.Size = new Size(262, 53);
            btn_categories.TabIndex = 0;
            btn_categories.Text = "          Categories";
            btn_categories.TextAlign = ContentAlignment.MiddleLeft;
            btn_categories.UseVisualStyleBackColor = true;
            btn_categories.Click += button5_Click;
            // 
            // btn_inventory_dropdown
            // 
            btn_inventory_dropdown.Dock = DockStyle.Top;
            btn_inventory_dropdown.FlatAppearance.BorderSize = 0;
            btn_inventory_dropdown.FlatStyle = FlatStyle.Flat;
            btn_inventory_dropdown.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_inventory_dropdown.ForeColor = Color.White;
            btn_inventory_dropdown.Image = Properties.Resources.inventory_icon_241;
            btn_inventory_dropdown.ImageAlign = ContentAlignment.MiddleLeft;
            btn_inventory_dropdown.Location = new Point(0, 258);
            btn_inventory_dropdown.Name = "btn_inventory_dropdown";
            btn_inventory_dropdown.Padding = new Padding(10, 0, 0, 0);
            btn_inventory_dropdown.Size = new Size(262, 53);
            btn_inventory_dropdown.TabIndex = 22;
            btn_inventory_dropdown.Text = "          Inventory";
            btn_inventory_dropdown.TextAlign = ContentAlignment.MiddleLeft;
            btn_inventory_dropdown.UseVisualStyleBackColor = true;
            btn_inventory_dropdown.Click += btn_inventory_dropdown_Click;
            // 
            // btn_dashboard
            // 
            btn_dashboard.Dock = DockStyle.Top;
            btn_dashboard.FlatAppearance.BorderSize = 0;
            btn_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dashboard.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_dashboard.ForeColor = Color.White;
            btn_dashboard.Image = Properties.Resources.dashboard_icon_24;
            btn_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.Location = new Point(0, 205);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Padding = new Padding(10, 0, 0, 0);
            btn_dashboard.Size = new Size(262, 53);
            btn_dashboard.TabIndex = 21;
            btn_dashboard.Text = "          Dashboard";
            btn_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.UseVisualStyleBackColor = true;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 205);
            panel2.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(115, 167);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 1;
            label2.Text = "Admin";
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
            // adminDashboard1
            // 
            adminDashboard1.Location = new Point(558, 555);
            adminDashboard1.Name = "adminDashboard1";
            adminDashboard1.Size = new Size(8, 8);
            adminDashboard1.TabIndex = 3;
            // 
            // adminUsers3
            // 
            adminUsers3.Location = new Point(352, 7);
            adminUsers3.Name = "adminUsers3";
            adminUsers3.Size = new Size(1054, 770);
            adminUsers3.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1339, 815);
            Controls.Add(adminDashboard1);
            Controls.Add(panelContainer);
            Controls.Add(panelSideMenu);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            MinimumSize = new Size(1355, 731);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelContainer.ResumeLayout(false);
            panelSideMenu.ResumeLayout(false);
            panel_Monitor_subMenu.ResumeLayout(false);
            panel_inventory_subMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel panelContainer;
        private AdminUsers adminUsers1;
        private AdminDashboard adminDashboard1;
        private AdminCustomers adminCustomers1;
        private AdminCategories adminCategories1;
        private Panel panelSideMenu;
        private Panel panel2;
        private Button btn_dashboard;
        private Label label2;
        private PictureBox pictureBox2;
        private Button btn_inventory_dropdown;
        private Panel panel_inventory_subMenu;
        private Button btn_users;
        private Button btn_products;
        private Button btn_categories;
        private Button btn_actlogs_monitor_dropdown;
        private Button btn_customers;
        private Panel panel_Monitor_subMenu;
        private Button btn_auditTrail;
        private Button btn_ActivityLog;
        private Button btn_reports;
        private Button btn_archive;
        private Button btn_logout;
        private AdminDashboard adminDashboard2;
        private AdminUsers adminUsers2;
        private AdminUsers adminUsers3;
    }
}