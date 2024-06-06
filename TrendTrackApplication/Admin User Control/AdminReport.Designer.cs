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
            label12 = new Label();
            button2 = new Button();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label1);
            panel7.Controls.Add(dateTimePicker1);
            panel7.Controls.Add(comboBox1);
            panel7.Controls.Add(button2);
            panel7.Controls.Add(label12);
            panel7.Location = new Point(28, 33);
            panel7.Name = "panel7";
            panel7.Size = new Size(998, 704);
            panel7.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(17, 20);
            label12.Name = "label12";
            label12.Size = new Size(72, 18);
            label12.TabIndex = 2;
            label12.Text = "Reports";
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(17, 318);
            button2.Name = "button2";
            button2.Size = new Size(112, 26);
            button2.TabIndex = 15;
            button2.Text = "Generate";
            button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(17, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(283, 28);
            comboBox1.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 12F);
            dateTimePicker1.Location = new Point(17, 220);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(283, 26);
            dateTimePicker1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 84);
            label1.Name = "label1";
            label1.Size = new Size(125, 18);
            label1.TabIndex = 20;
            label1.Text = "Type of Report";
            // 
            // AdminReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel7);
            Name = "AdminReport";
            Size = new Size(1054, 770);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Label label12;
        private ComboBox comboBox1;
        private Button button2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
    }
}
