namespace TrendTrackApplication
{
    partial class AdminActLogAuditTrail
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
            button1 = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            button5 = new Button();
            textBox3 = new TextBox();
            panel7 = new Panel();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.search_699_16;
            button1.Location = new Point(258, 394);
            button1.Name = "button1";
            button1.Size = new Size(65, 26);
            button1.TabIndex = 25;
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F);
            textBox1.Location = new Point(28, 394);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 26);
            textBox1.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView2);
            panel1.Location = new Point(28, 449);
            panel1.Name = "panel1";
            panel1.Size = new Size(998, 288);
            panel1.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 20);
            label1.Name = "label1";
            label1.Size = new Size(102, 18);
            label1.TabIndex = 2;
            label1.Text = "Activity Log";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(17, 60);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(954, 205);
            dataGridView2.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.AppWorkspace;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.search_699_16;
            button5.Location = new Point(258, 33);
            button5.Name = "button5";
            button5.Size = new Size(65, 26);
            button5.TabIndex = 22;
            button5.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 12F);
            textBox3.Location = new Point(28, 33);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(224, 26);
            textBox3.TabIndex = 21;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label12);
            panel7.Controls.Add(dataGridView1);
            panel7.Location = new Point(28, 83);
            panel7.Name = "panel7";
            panel7.Size = new Size(998, 288);
            panel7.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(17, 20);
            label12.Name = "label12";
            label12.Size = new Size(89, 18);
            label12.TabIndex = 2;
            label12.Text = "Audit Trail";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(954, 205);
            dataGridView1.TabIndex = 0;
            // 
            // AdminActLogAuditTrail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(textBox3);
            Controls.Add(panel7);
            Name = "AdminActLogAuditTrail";
            Size = new Size(1054, 770);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView2;
        private Button button5;
        private TextBox textBox3;
        private Panel panel7;
        private Label label12;
        private DataGridView dataGridView1;
    }
}
