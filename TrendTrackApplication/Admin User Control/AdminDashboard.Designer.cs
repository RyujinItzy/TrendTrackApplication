namespace TrendTrackApplication
{
    partial class AdminDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            label1 = new Label();
            btn_notification = new RoundedButton();
            dtp_startDate = new DateTimePicker();
            dtp_endDate = new DateTimePicker();
            btn_custom = new Button();
            btn_today = new Button();
            btn_last7days = new Button();
            btn_last30days = new Button();
            btn_ok_customdate = new Button();
            panel1 = new Panel();
            lbl_NumberOfOrders = new Label();
            label2 = new Label();
            panel2 = new Panel();
            lbl_totalRevenue = new Label();
            label4 = new Label();
            panel3 = new Panel();
            lbl_totalProfit = new Label();
            label5 = new Label();
            chart_grossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart_topProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel4 = new Panel();
            lbl_todaysProfit = new Label();
            label13 = new Label();
            lbl_numberOfProducts = new Label();
            label12 = new Label();
            lbl_todaysCustomer = new Label();
            label9 = new Label();
            lbl_NumberOfUsers = new Label();
            label8 = new Label();
            label7 = new Label();
            lbl_numberOfCustomers = new Label();
            label6 = new Label();
            panel5 = new Panel();
            dgv_Understock = new DataGridView();
            label10 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_grossRevenue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_topProducts).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Understock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(17, 22);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // btn_notification
            // 
            btn_notification.BackColor = Color.SteelBlue;
            btn_notification.BackGroundColor = Color.SteelBlue;
            btn_notification.BorderColor = Color.RoyalBlue;
            btn_notification.BorderRadius = 20;
            btn_notification.BorderSize = 0;
            btn_notification.FlatAppearance.BorderSize = 0;
            btn_notification.FlatStyle = FlatStyle.Flat;
            btn_notification.ForeColor = Color.White;
            btn_notification.Image = Properties.Resources.notification_icon_24;
            btn_notification.Location = new Point(995, 3);
            btn_notification.Name = "btn_notification";
            btn_notification.Size = new Size(46, 41);
            btn_notification.TabIndex = 1;
            btn_notification.TextColor = Color.White;
            btn_notification.UseVisualStyleBackColor = false;
            // 
            // dtp_startDate
            // 
            dtp_startDate.CustomFormat = "MMM dd, yyyy";
            dtp_startDate.Format = DateTimePickerFormat.Custom;
            dtp_startDate.Location = new Point(169, 24);
            dtp_startDate.Name = "dtp_startDate";
            dtp_startDate.Size = new Size(110, 23);
            dtp_startDate.TabIndex = 2;
            // 
            // dtp_endDate
            // 
            dtp_endDate.CustomFormat = "MMM dd, yyyy";
            dtp_endDate.Format = DateTimePickerFormat.Custom;
            dtp_endDate.Location = new Point(285, 24);
            dtp_endDate.Name = "dtp_endDate";
            dtp_endDate.Size = new Size(110, 23);
            dtp_endDate.TabIndex = 3;
            // 
            // btn_custom
            // 
            btn_custom.Font = new Font("Cambria", 9F);
            btn_custom.Location = new Point(462, 17);
            btn_custom.Name = "btn_custom";
            btn_custom.Size = new Size(120, 30);
            btn_custom.TabIndex = 4;
            btn_custom.Text = "Custom";
            btn_custom.UseVisualStyleBackColor = true;
            // 
            // btn_today
            // 
            btn_today.Font = new Font("Cambria", 9F);
            btn_today.Location = new Point(588, 17);
            btn_today.Name = "btn_today";
            btn_today.Size = new Size(120, 30);
            btn_today.TabIndex = 5;
            btn_today.Text = "Today";
            btn_today.UseVisualStyleBackColor = true;
            // 
            // btn_last7days
            // 
            btn_last7days.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_last7days.Location = new Point(714, 17);
            btn_last7days.Name = "btn_last7days";
            btn_last7days.Size = new Size(120, 30);
            btn_last7days.TabIndex = 6;
            btn_last7days.Text = "Last 7 days";
            btn_last7days.UseVisualStyleBackColor = true;
            // 
            // btn_last30days
            // 
            btn_last30days.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_last30days.Location = new Point(840, 17);
            btn_last30days.Name = "btn_last30days";
            btn_last30days.Size = new Size(120, 30);
            btn_last30days.TabIndex = 7;
            btn_last30days.Text = "Last 30 days";
            btn_last30days.UseVisualStyleBackColor = true;
            // 
            // btn_ok_customdate
            // 
            btn_ok_customdate.Font = new Font("Cambria", 9F);
            btn_ok_customdate.Location = new Point(417, 17);
            btn_ok_customdate.Name = "btn_ok_customdate";
            btn_ok_customdate.Size = new Size(39, 30);
            btn_ok_customdate.TabIndex = 8;
            btn_ok_customdate.Text = "Ok";
            btn_ok_customdate.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbl_NumberOfOrders);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 52);
            panel1.TabIndex = 9;
            // 
            // lbl_NumberOfOrders
            // 
            lbl_NumberOfOrders.AutoSize = true;
            lbl_NumberOfOrders.Font = new Font("Cambria", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NumberOfOrders.Location = new Point(24, 14);
            lbl_NumberOfOrders.Name = "lbl_NumberOfOrders";
            lbl_NumberOfOrders.Size = new Size(76, 23);
            lbl_NumberOfOrders.TabIndex = 1;
            lbl_NumberOfOrders.Text = "100000\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 14);
            label2.TabIndex = 0;
            label2.Text = "Number of Orders";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lbl_totalRevenue);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(223, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 52);
            panel2.TabIndex = 10;
            // 
            // lbl_totalRevenue
            // 
            lbl_totalRevenue.AutoSize = true;
            lbl_totalRevenue.Font = new Font("Cambria", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_totalRevenue.Location = new Point(24, 14);
            lbl_totalRevenue.Name = "lbl_totalRevenue";
            lbl_totalRevenue.Size = new Size(76, 23);
            lbl_totalRevenue.TabIndex = 1;
            lbl_totalRevenue.Text = "100000\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 14);
            label4.TabIndex = 0;
            label4.Text = "Total Revenue";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lbl_totalProfit);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(639, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(402, 52);
            panel3.TabIndex = 11;
            // 
            // lbl_totalProfit
            // 
            lbl_totalProfit.AutoSize = true;
            lbl_totalProfit.Font = new Font("Cambria", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_totalProfit.Location = new Point(24, 14);
            lbl_totalProfit.Name = "lbl_totalProfit";
            lbl_totalProfit.Size = new Size(76, 23);
            lbl_totalProfit.TabIndex = 1;
            lbl_totalProfit.Text = "100000\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 14);
            label5.TabIndex = 0;
            label5.Text = "Total Profit";
            // 
            // chart_grossRevenue
            // 
            chartArea1.Name = "ChartArea1";
            chart_grossRevenue.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            chart_grossRevenue.Legends.Add(legend1);
            chart_grossRevenue.Location = new Point(3, 122);
            chart_grossRevenue.Name = "chart_grossRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_grossRevenue.Series.Add(series1);
            chart_grossRevenue.Size = new Size(705, 293);
            chart_grossRevenue.TabIndex = 12;
            chart_grossRevenue.Text = "chart1";
            title1.Alignment = ContentAlignment.TopLeft;
            title1.Font = new Font("Cambria", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title1.Name = "Title1";
            title1.Text = "Gross Revenue";
            chart_grossRevenue.Titles.Add(title1);
            // 
            // chart_topProducts
            // 
            chartArea2.Name = "ChartArea1";
            chart_topProducts.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            chart_topProducts.Legends.Add(legend2);
            chart_topProducts.Location = new Point(714, 122);
            chart_topProducts.Name = "chart_topProducts";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            series2.LabelForeColor = Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart_topProducts.Series.Add(series2);
            chart_topProducts.Size = new Size(327, 317);
            chart_topProducts.TabIndex = 13;
            chart_topProducts.Text = "chart2";
            title2.Alignment = ContentAlignment.TopLeft;
            title2.Font = new Font("Cambria", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title2.Name = "Title1";
            title2.Text = "Top 5 Products";
            chart_topProducts.Titles.Add(title2);
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lbl_todaysProfit);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(lbl_numberOfProducts);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(lbl_todaysCustomer);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(lbl_NumberOfUsers);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(lbl_numberOfCustomers);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(3, 421);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 346);
            panel4.TabIndex = 10;
            // 
            // lbl_todaysProfit
            // 
            lbl_todaysProfit.AutoSize = true;
            lbl_todaysProfit.Font = new Font("Cambria", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_todaysProfit.Location = new Point(14, 303);
            lbl_todaysProfit.Name = "lbl_todaysProfit";
            lbl_todaysProfit.Size = new Size(76, 23);
            lbl_todaysProfit.TabIndex = 10;
            lbl_todaysProfit.Text = "100000\r\n";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(14, 289);
            label13.Name = "label13";
            label13.Size = new Size(78, 14);
            label13.TabIndex = 9;
            label13.Text = "Today's Profit";
            // 
            // lbl_numberOfProducts
            // 
            lbl_numberOfProducts.AutoSize = true;
            lbl_numberOfProducts.Font = new Font("Cambria", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_numberOfProducts.Location = new Point(13, 176);
            lbl_numberOfProducts.Name = "lbl_numberOfProducts";
            lbl_numberOfProducts.Size = new Size(76, 23);
            lbl_numberOfProducts.TabIndex = 8;
            lbl_numberOfProducts.Text = "100000\r\n";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(13, 162);
            label12.Name = "label12";
            label12.Size = new Size(112, 14);
            label12.TabIndex = 7;
            label12.Text = "Number of Products\r\n";
            // 
            // lbl_todaysCustomer
            // 
            lbl_todaysCustomer.AutoSize = true;
            lbl_todaysCustomer.Font = new Font("Cambria", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_todaysCustomer.Location = new Point(14, 239);
            lbl_todaysCustomer.Name = "lbl_todaysCustomer";
            lbl_todaysCustomer.Size = new Size(76, 23);
            lbl_todaysCustomer.TabIndex = 6;
            lbl_todaysCustomer.Text = "100000\r\n";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(14, 225);
            label9.Name = "label9";
            label9.Size = new Size(104, 14);
            label9.TabIndex = 5;
            label9.Text = "Today's Customers";
            // 
            // lbl_NumberOfUsers
            // 
            lbl_NumberOfUsers.AutoSize = true;
            lbl_NumberOfUsers.Font = new Font("Cambria", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NumberOfUsers.Location = new Point(14, 54);
            lbl_NumberOfUsers.Name = "lbl_NumberOfUsers";
            lbl_NumberOfUsers.Size = new Size(76, 23);
            lbl_NumberOfUsers.TabIndex = 4;
            lbl_NumberOfUsers.Text = "100000\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(14, 40);
            label8.Name = "label8";
            label8.Size = new Size(95, 14);
            label8.TabIndex = 3;
            label8.Text = "Number of Users";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(126, 23);
            label7.TabIndex = 2;
            label7.Text = "Total Counter";
            // 
            // lbl_numberOfCustomers
            // 
            lbl_numberOfCustomers.AutoSize = true;
            lbl_numberOfCustomers.Font = new Font("Cambria", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_numberOfCustomers.Location = new Point(14, 114);
            lbl_numberOfCustomers.Name = "lbl_numberOfCustomers";
            lbl_numberOfCustomers.Size = new Size(76, 23);
            lbl_numberOfCustomers.TabIndex = 1;
            lbl_numberOfCustomers.Text = "100000\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 100);
            label6.Name = "label6";
            label6.Size = new Size(121, 14);
            label6.TabIndex = 0;
            label6.Text = "Number of Customers";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(dgv_Understock);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(209, 421);
            panel5.Name = "panel5";
            panel5.Size = new Size(499, 346);
            panel5.TabIndex = 11;
            // 
            // dgv_Understock
            // 
            dgv_Understock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Understock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Understock.Location = new Point(14, 30);
            dgv_Understock.Name = "dgv_Understock";
            dgv_Understock.Size = new Size(468, 313);
            dgv_Understock.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cambria", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(190, 23);
            label10.TabIndex = 2;
            label10.Text = "Products Understock";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Name = "Legend1";
            chart1.Legends.Add(legend3);
            chart1.Location = new Point(714, 445);
            chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart1.Series.Add(series3);
            chart1.Size = new Size(327, 319);
            chart1.TabIndex = 14;
            chart1.Text = "chart1";
            title3.Alignment = ContentAlignment.TopLeft;
            title3.Font = new Font("Cambria", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title3.Name = "Title1";
            title3.Text = "Profit ";
            chart1.Titles.Add(title3);
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chart1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(chart_topProducts);
            Controls.Add(chart_grossRevenue);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_ok_customdate);
            Controls.Add(btn_last30days);
            Controls.Add(btn_last7days);
            Controls.Add(btn_today);
            Controls.Add(btn_custom);
            Controls.Add(dtp_endDate);
            Controls.Add(dtp_startDate);
            Controls.Add(btn_notification);
            Controls.Add(label1);
            Name = "AdminDashboard";
            Size = new Size(1054, 770);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart_grossRevenue).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_topProducts).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Understock).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RoundedButton btn_notification;
        private DateTimePicker dtp_startDate;
        private DateTimePicker dtp_endDate;
        private Button btn_custom;
        private Button btn_today;
        private Button btn_last7days;
        private Button btn_last30days;
        private Button btn_ok_customdate;
        private Panel panel1;
        private Label lbl_NumberOfOrders;
        private Label label2;
        private Panel panel2;
        private Label lbl_totalRevenue;
        private Label label4;
        private Panel panel3;
        private Label lbl_totalProfit;
        private Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_grossRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_topProducts;
        private Panel panel4;
        private Label lbl_numberOfCustomers;
        private Label label6;
        private Label label7;
        private Label lbl_NumberOfUsers;
        private Label label8;
        private Panel panel5;
        private Label label10;
        private DataGridView dgv_Understock;
        private Label lbl_todaysCustomer;
        private Label label9;
        private Label lbl_numberOfProducts;
        private Label label12;
        private Label lbl_todaysProfit;
        private Label label13;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
