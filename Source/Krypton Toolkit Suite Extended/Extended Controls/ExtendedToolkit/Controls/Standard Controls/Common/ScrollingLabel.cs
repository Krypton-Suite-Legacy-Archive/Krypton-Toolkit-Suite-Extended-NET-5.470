using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.Common
{
    /// <summary>
    /// Summary description for UserControl1.
    /// </summary>
    [ToolboxBitmap(typeof(Label)), ToolboxItem(false)]
    public class ScrollingLabel : System.Windows.Forms.UserControl
    {
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Timer timer1;

        private int currentPos = 1;

        private bool _center = true;
        [Browsable(true), Category("Appearance-Extended")]
        public bool Center
        {
            get { return _center; }
            set { _center = value; }
        }

        private Orientation _orientations;
        [Browsable(true), Category("Appearance-Extended")]
        public Orientation Orientations
        {
            get { return _orientations; }
            set { _orientations = value; }
        }

        private Color _textColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.ControlText);
        [Browsable(true), Category("Appearance-Extended")]
        public Color TextColour
        {
            get { return _textColor; }
            set { _textColor = value; }
        }

        private Color _borderColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.ControlText);
        [Browsable(true), Category("Appearance-Extended")]
        public Color BorderColour
        {
            get { return _borderColor; }
            set { _borderColor = value; }
        }

        private string _text;
        [Browsable(true), Category("Appearance-Extended")]
        public string MarqueeText
        {
            get { return _text; }
            set { _text = value; }
        }

        private bool _border = false;
        [Browsable(true), Category("Appearance-Extended")]
        public bool Border
        {
            get { return _border; }
            set { _border = value; }
        }

        private bool _enableMouseTracking = true;
        [Browsable(true), Category("Appearance-Extended")]
        public bool EnableMouseTracking
        {
            get { return _enableMouseTracking; }
            set { _enableMouseTracking = value; }
        }

        [Browsable(true), Category("Appearance-Extended")]
        public int Interval
        {
            get { return timer1.Interval * 10; }
            set
            {
                if (value < 10) value = 10;
                timer1.Interval = value / 10;
            }
        }


        public ScrollingLabel()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitForm call
            this.Size = new Size(this.Width, this.Font.Height);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 100;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ScrollingLabel
            // 
            this.Name = "ScrollingLabel";
            this.Size = new System.Drawing.Size(80, 23);
            this.Resize += new System.EventHandler(this.Marquee_Resize);
            this.MouseEnter += new System.EventHandler(this.ScrollingLabel_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ScrollingLabel_MouseLeave);
            this.ResumeLayout(false);

        }
        #endregion

        private void Marquee_Resize(object sender, System.EventArgs e)
        {
            if (_orientations == Orientation.Horizontal) this.Height = this.Font.Height;
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {

            switch (_orientations)
            {
                case Orientation.Horizontal:

                    //center
                    Single VertStartPosition = 0;
                    if (_center) VertStartPosition = (this.Height - e.Graphics.MeasureString(_text, this.Font).Height) / 2;
                    if (VertStartPosition < 0) VertStartPosition = 0;

                    e.Graphics.DrawString(_text, this.Font, new SolidBrush(this._textColor), currentPos, VertStartPosition);
                    e.Graphics.DrawString(_text, this.Font, new SolidBrush(this._textColor), this.Width + currentPos, VertStartPosition);

                    currentPos--;

                    if ((currentPos < 0) && (Math.Abs(currentPos) >= e.Graphics.MeasureString(_text, this.Font).Width))
                        currentPos = this.Width + currentPos;

                    break;
                case Orientation.Vertical:

                    //center
                    Single StartPosition = 0;
                    if (_center) StartPosition = (this.Height - e.Graphics.MeasureString(_text, this.Font).Height) / 2;
                    if (StartPosition < 0) StartPosition = 0;

                    e.Graphics.DrawString(_text, this.Font, new SolidBrush(this._textColor), StartPosition, currentPos);
                    e.Graphics.DrawString(_text, this.Font, new SolidBrush(this._textColor), StartPosition, this.Height + currentPos);

                    currentPos--;

                    if ((currentPos < 0) && (Math.Abs(currentPos) >= e.Graphics.MeasureString(_text, this.Font).Height))
                        currentPos = this.Height + currentPos;
                    break;
            }

            if (_border)
            {
                e.Graphics.DrawRectangle(new Pen(this._borderColor), 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        private void ScrollingLabel_MouseEnter(object sender, EventArgs e)
        {
            if (_enableMouseTracking) timer1.Stop();
        }

        private void ScrollingLabel_MouseLeave(object sender, EventArgs e)
        {
            if (_enableMouseTracking) timer1.Start();
        }
        public enum Orientation
        {
            Vertical = 1,
            Horizontal = 0
        }
    }
}