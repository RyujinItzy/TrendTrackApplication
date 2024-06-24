namespace TrendTrackApplication
{
    partial class AdminReport
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
            panel7 = new Panel();
            label1 = new Label();
            dtp_report_startDate = new DateTimePicker();
            typeOfReport_comboBox = new ComboBox();
            label12 = new Label();
            btn_generateReport = new RoundedButton();
            dtp_report_endDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(dtp_report_endDate);
            panel7.Controls.Add(btn_generateReport);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(dtp_report_startDate);
            panel7.Controls.Add(typeOfReport_comboBox);
            panel7.Controls.Add(label12);
            panel7.Location = new Point(26, 31);
            panel7.Margin = new Padding(4, 4, 4, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(1002, 715);
            panel7.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label1.Location = new Point(22, 106);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 19);
            label1.TabIndex = 20;
            label1.Text = "Type of Report";
            // 
            // dtp_report_startDate
            // 
            dtp_report_startDate.Font = new Font("Cambria", 12F);
            dtp_report_startDate.Location = new Point(22, 235);
            dtp_report_startDate.Margin = new Padding(4, 4, 4, 4);
            dtp_report_startDate.Name = "dtp_report_startDate";
            dtp_report_startDate.Size = new Size(278, 26);
            dtp_report_startDate.TabIndex = 19;
            // 
            // typeOfReport_comboBox
            // 
            typeOfReport_comboBox.Font = new Font("Cambria", 12F);
            typeOfReport_comboBox.FormattingEnabled = true;
            typeOfReport_comboBox.Location = new Point(22, 129);
            typeOfReport_comboBox.Margin = new Padding(4, 4, 4, 4);
            typeOfReport_comboBox.Name = "typeOfReport_comboBox";
            typeOfReport_comboBox.Size = new Size(363, 27);
            typeOfReport_comboBox.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label12.Location = new Point(22, 25);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(67, 19);
            label12.TabIndex = 2;
            label12.Text = "Reports";
            // 
            // btn_generateReport
            // 
            btn_generateReport.BackColor = Color.RoyalBlue;
            btn_generateReport.BackGroundColor = Color.RoyalBlue;
            btn_generateReport.BorderColor = Color.RoyalBlue;
            btn_generateReport.BorderRadius = 20;
            btn_generateReport.BorderSize = 0;
            btn_generateReport.FlatAppearance.BorderSize = 0;
            btn_generateReport.FlatStyle = FlatStyle.Flat;
            btn_generateReport.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_generateReport.ForeColor = Color.White;
            btn_generateReport.Location = new Point(22, 456);
            btn_generateReport.Name = "btn_generateReport";
            btn_generateReport.Size = new Size(160, 40);
            btn_generateReport.TabIndex = 21;
            btn_generateReport.Text = "Generate Report";
            btn_generateReport.TextColor = Color.White;
            btn_generateReport.UseVisualStyleBackColor = false;
            // 
            // dtp_report_endDate
            // 
            dtp_report_endDate.Font = new Font("Cambria", 12F);
            dtp_report_endDate.Location = new Point(22, 335);
            dtp_report_endDate.Margin = new Padding(4);
            dtp_report_endDate.Name = "dtp_report_endDate";
            dtp_report_endDate.Size = new Size(278, 26);
            dtp_report_endDate.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label2.Location = new Point(22, 212);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 23;
            label2.Text = "Start Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label3.Location = new Point(22, 312);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 24;
            label3.Text = "End Date";
            // 
            // AdminReport
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel7);
            Font = new Font("Cambria", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AdminReport";
            Size = new Size(1054, 770);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Label label12;
        private ComboBox typeOfReport_comboBox;
        private Label label1;
        private DateTimePicker dtp_report_startDate;
        private RoundedButton btn_generateReport;
        private Label label3;
        private Label label2;
        private DateTimePicker dtp_report_endDate;
    }
}
