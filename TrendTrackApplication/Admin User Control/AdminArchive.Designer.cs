namespace TrendTrackApplication
{
    partial class AdminArchive
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
            button5 = new Button();
            textBox3 = new TextBox();
            panel7 = new Panel();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            button5.TabIndex = 19;
            button5.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 12F);
            textBox3.Location = new Point(28, 33);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(224, 26);
            textBox3.TabIndex = 18;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label12);
            panel7.Controls.Add(dataGridView1);
            panel7.Location = new Point(28, 83);
            panel7.Name = "panel7";
            panel7.Size = new Size(998, 654);
            panel7.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(17, 20);
            label12.Name = "label12";
            label12.Size = new Size(80, 18);
            label12.TabIndex = 2;
            label12.Text = "Archived";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(954, 572);
            dataGridView1.TabIndex = 0;
            // 
            // AdminArchive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button5);
            Controls.Add(textBox3);
            Controls.Add(panel7);
            Name = "AdminArchive";
            Size = new Size(1054, 770);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private TextBox textBox3;
        private Panel panel7;
        private Label label12;
        private DataGridView dataGridView1;
    }
}
