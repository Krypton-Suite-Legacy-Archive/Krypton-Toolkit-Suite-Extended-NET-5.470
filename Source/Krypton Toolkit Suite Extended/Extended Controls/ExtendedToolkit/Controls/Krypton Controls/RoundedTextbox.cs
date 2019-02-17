using ExtendedControls.Base.Code.Drawing;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    /// <summary>
    /// Provides a rounded textbox like Google Chrome's current Omnibox design.
    /// Original code: https://github.com/aalitor/AltoControls/blob/on-development/AltoControls/Controls/AltoTextBox.cs
    /// </summary>
    [ToolboxBitmap(typeof(TextBox))]
    [ToolboxItem(true)]
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    [Description("Provides a rounded textbox like Google Chrome's current Omnibox design.")]
    public class RoundedTextbox : Control
    {
        #region Variables
        private int _radius = 15;

        // Original code
        public TextBox _box = new TextBox();

        //public KryptonTextBox _box = new KryptonTextBox();
        private GraphicsPath _shape, _innerRect;
        private Color _brush;
        #endregion

        #region Properties
        [DefaultValue(15)]
        public int Radius { get { return _radius; } set { _radius = value; } }

        public Color Brush
        {
            get
            {
                return _brush;
            }

            set
            {
                _brush = value;

                if (_brush != Color.Transparent)
                {
                    _box.BackColor = _brush;

                    //_box.StateCommon.Back.Color1 = _brush;
                }

                Invalidate();
            }
        }

        public override Color BackColor { get => base.BackColor; set => base.BackColor = value; }
        #endregion

        #region Constructor
        public RoundedTextbox()
        {
            // Double buffering
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            SetStyle(ControlStyles.UserPaint, true);

            SetStyle(ControlStyles.ResizeRedraw, true);

            _box.Parent = this;

            Controls.Add(_box);

            _box.BorderStyle = BorderStyle.None;

            _box.TextAlign = HorizontalAlignment.Left;

            //_box.StateCommon.Content.Font = Font;

            BackColor = Color.Transparent;

            ForeColor = Color.Black; //Color.DimGray;

            _brush = Color.White;

            _box.BackColor = _brush;

            //_box.StateCommon.Back.Color1 = _brush;

            Text = null;

            Font = new Font("Segoe UI", 11);

            Size = new Size(135, 33);

            DoubleBuffered = true;

            _box.KeyDown += Box_KeyDown;

            _box.TextChanged += Box_TextChanged;

            _box.MouseDoubleClick += Box_MouseDoubleClick;
        }
        #endregion

        #region Event Handlers
        private void Box_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            _box.SelectAll();
        }

        private void Box_TextChanged(object sender, EventArgs e)
        {
            Text = _box.Text;
        }

        private void Box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                _box.SelectionStart = 0;

                _box.SelectionLength = Text.Length;
            }
        }
        #endregion

        #region Methods
        public void SelectAll()
        {
            if (_box.Text != null)
            {
                _box.SelectAll();
            }
        }
        #endregion

        #region Overridden Methods
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            _box.Text = Text;
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);

            _box.Font = Font;

            //_box.StateCommon.Content.Font = Font;

            Invalidate();
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);

            _box.ForeColor = ForeColor;

            //_box.StateCommon.Content.Color1 = ForeColor;

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            _shape = new RoundedRectangleF(Width, Height, Radius).Path;

            _innerRect = new RoundedRectangleF(Width - 0.5f, Height - 0.5f, Radius, 0.5f, 0.5f).Path;

            if (_box.Height >= Height - 4)
            {
                Height = _box.Height + 4;
            }

            _box.Location = new Point(Radius - 5, Height / 2 - _box.Font.Height / 2);

            _box.Width = Width - (int)(Radius * 1.5);

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            Bitmap bmp = new Bitmap(Width, Height);

            Graphics grpx = Graphics.FromImage(bmp);

            using (SolidBrush slb = new SolidBrush(_brush))
            {
                e.Graphics.FillPath(slb, _innerRect);
            }

            Transparenter.MakeTransparent(this, e.Graphics);

            base.OnPaint(e);
        }
        #endregion
    }
}