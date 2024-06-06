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
    [DefaultEvent("TextChanged")]
    public partial class JyannTextBox : UserControl
    {
        private Color borderColor = Color.RoyalBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.MidnightBlue;
        private bool isFocused = false;

        private int borderRadius = 0;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;

        public JyannTextBox()
        {
            InitializeComponent();
            SetPlaceHolder();
            textBox1.TextChanged += TextBox1_TextChanged;
        }

        [Category("Action")]
        [Description("Occurs when the text content changes.")]
        public event EventHandler TextChanged;

        [Category("Jyann Advance Code")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        [Category("Jyann Advance Code")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }

        [Category("Jyann Advance Code")]
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set { underlinedStyle = value; this.Invalidate(); }
        }

        [Category("Jyann Advance Code")]
        public bool PasswordChar
        {
            get { return isPasswordChar; }
            set
            {
                isPasswordChar = value;
                if (!isPlaceholder)
                {
                    textBox1.UseSystemPasswordChar = value;
                }
                this.Invalidate();
            }
        }

        [Category("Jyann Advance Code")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; this.Invalidate(); }
        }

        [Category("Jyann Advance Code")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; textBox1.BackColor = value; }
        }

        [Category("Jyann Advance Code")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set { base.ForeColor = value; textBox1.ForeColor = value; }
        }

        [Category("Jyann Advance Code")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                {
                    UpdateControlHeight();
                }
            }
        }

        [Category("Jyann Advance Code")]
        public string Texts
        {
            get { return isPlaceholder ? "" : textBox1.Text; }
            set
            {
                textBox1.Text = value;
                SetPlaceHolder();
            }
        }

        [Category("Jyann Advance Code")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        [Category("Jyann Advance Code")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();
                }
            }
        }

        [Category("Jyann Advance Code")]
        public Color PlaceholderColor
        {
            get { return placeholderColor; }
            set
            {
                placeholderColor = value;
                if (isPlaceholder)
                {
                    textBox1.ForeColor = value;
                }
            }
        }

        [Category("Jyann Advance Code")]
        public string PlaceholderText
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                textBox1.Text = "";
                SetPlaceHolder();
            }
        }

        [Category("Jyann Advance Code")]
        public bool UseSystemPasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        private void SetPlaceHolder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrEmpty(placeholderText))
            {
                isPlaceholder = true;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = placeholderColor;
                if (isPasswordChar)
                {
                    textBox1.UseSystemPasswordChar = false;
                }
            }
        }

        private void RemovePlaceHolder()
        {
            if (isPlaceholder)
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                {
                    textBox1.UseSystemPasswordChar = true;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRadius > 1) // rounded textbox
            {
                // fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    // drawing
                    this.Region = new Region(pathBorderSmooth); // set rounded region of user control
                    if (borderRadius > 15) SetTextBoxRoundedRegion(); // set rounded region of textbox component
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;

                    if (underlinedStyle) // line style
                    {
                        // draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        // draw border
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else // normal style
                    {
                        // draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        // draw border
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else // square/normal textbox
            {
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                    if (!isFocused)
                    {
                        if (underlinedStyle)
                        {
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else
                        {
                            graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                        }
                    }
                    else
                    {
                        penBorder.Color = borderFocusColor;
                        if (underlinedStyle)
                        {
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else
                        {
                            graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                        }
                    }
                }
            }
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region(pathTxt);
            }
        }

        private GraphicsPath GetFigurePath(RectangleF rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (!textBox1.Multiline)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(TextChanged != null) 
            { 
                TextChanged.Invoke(sender,e);
            }
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void TextBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void TextBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceHolder();
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceHolder();
        }
    }
}