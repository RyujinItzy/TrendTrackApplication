﻿namespace TrendTrackApplication.Customized_Icons
{
    partial class JyannTextBox
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
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(7, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 16);
            textBox1.TabIndex = 0;
            textBox1.Click += TextBox1_Click;
            textBox1.TextChanged += TextBox1_TextChanged;
            textBox1.Enter += TextBox1_Enter;
            textBox1.KeyPress += TextBox1_KeyPress;
            textBox1.Leave += TextBox1_Leave;
            textBox1.MouseEnter += TextBox1_MouseEnter;
            textBox1.MouseLeave += TextBox1_MouseLeave;
            // 
            // JyannTextBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            Controls.Add(textBox1);
            Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DimGray;
            Name = "JyannTextBox";
            Padding = new Padding(7);
            Size = new Size(250, 30);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
    }
}
