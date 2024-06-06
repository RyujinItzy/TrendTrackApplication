namespace TrendTrackApplication
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            label12 = new Label();
            panel7 = new Panel();
            button5 = new Button();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(17, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(954, 572);
            dataGridView1.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(17, 20);
            label12.Name = "label12";
            label12.Size = new Size(165, 18);
            label12.TabIndex = 2;
            label12.Text = "All Customer's Data";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label12);
            panel7.Controls.Add(dataGridView1);
            panel7.Location = new Point(26, 87);
            panel7.Name = "panel7";
            panel7.Size = new Size(998, 654);
            panel7.TabIndex = 11;
            panel7.Paint += panel7_Paint;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.AppWorkspace;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.search_699_16;
            button5.Location = new Point(256, 37);
            button5.Name = "button5";
            button5.Size = new Size(65, 26);
            button5.TabIndex = 16;
            button5.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 12F);
            textBox3.Location = new Point(26, 37);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(224, 26);
            textBox3.TabIndex = 15;
            // 
            // AdminCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button5);
            Controls.Add(textBox3);
            Controls.Add(panel7);
            Name = "AdminCustomers";
            Size = new Size(1054, 770);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label12;
        private Panel panel7;
        private Button button5;
        private TextBox textBox3;
    }
}
