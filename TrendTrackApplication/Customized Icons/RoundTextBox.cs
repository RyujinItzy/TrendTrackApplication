using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrendTrackApplication.Customized_Icons
{

    partial class RoundTextBox : TextBox
    {
        private bool isPlaceholder = false;
        private string placeholderText = "Enter text...";
        private char passwordChar = '\0';
        private int borderRadius = 10;

        public RoundTextBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            TextChanged += RoundTextBox_TextChanged;
            GotFocus += RoundTextBox_GotFocus;
            LostFocus += RoundTextBox_LostFocus;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(Width - borderRadius, Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(new Pen(ForeColor), path);

            if (isPlaceholder && !Focused)
            {
                using (var brush = new SolidBrush(Color.Gray))
                {
                    e.Graphics.DrawString(placeholderText, Font, brush, new PointF(2, 2));
                }
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            isPlaceholder = string.IsNullOrEmpty(Text);
            Invalidate();
        }

        private void RoundTextBox_TextChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void RoundTextBox_GotFocus(object sender, EventArgs e)
        {
            isPlaceholder = false;
            Invalidate();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoundTextBox_LostFocus(object sender, EventArgs e)
        {
            isPlaceholder = string.IsNullOrEmpty(Text);
            Invalidate();
        }

    

        public string PlaceholderText
        {
            get { return placeholderText; }
            set { placeholderText = value; Invalidate(); }
        }

        public new char PasswordChar
        {
            get { return passwordChar; }
            set { passwordChar = value; Invalidate(); }
        }

        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; Invalidate(); }
        }
    }
}
