using ExtendedControls.Base.Code.Drawing;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    public class PromptRoundedTextbox : Control
    {
        #region Constants
        private const int WM_SETFOCUS = 7, WM_KILLFOCUS = 8, WM_ERASEBKGND = 14, WM_PAINT = 15;
        #endregion

        #region Variables
        private bool _focusSelect = true, _drawPrompt = true;
        private int _radius = 15;
        private TextBox _box = new TextBox();
        private string _promptText = string.Empty;
        private Color _promptTextColour = SystemColors.GrayText, _brush;
        private GraphicsPath _shape, _innerRect;
        private Font _promptTypeface = null;
        #endregion

        #region Properties
        public bool DrawPrompt { get => _drawPrompt; set => _drawPrompt = value; }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Appearance")]
        public string PromptText { get => _promptText; set => _promptText = value; }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Appearance")]
        [Description("The ForeColour to use when displaying the PromptText.")]
        public Color PromptForeColour
        {
            get { return _promptTextColour; }
            set { _promptTextColour = value; Invalidate(); }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Appearance")]
        [Description("The typeface to use when displaying the PromptText.")]
        public Font PromptTypeface
        {
            get { return _promptTypeface; }
            set { _promptTypeface = value; Invalidate(); }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Category("Behavior")]
        [Description("Automatically select the text when control receives the focus.")]
        public bool FocusSelect
        {
            get { return _focusSelect; }
            set { _focusSelect = value; }
        }

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
        public PromptRoundedTextbox()
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

            ForeColor = Color.DimGray;

            _brush = Color.White;

            _box.BackColor = _brush;

            //_box.StateCommon.Back.Color1 = _brush;

            Text = null;

            Font = new Font("Segoe UI", 11);

            PromptTypeface = Font;

            Size = new Size(135, 33);

            DoubleBuffered = true;

            _box.KeyDown += Box_KeyDown;

            _box.TextChanged += Box_TextChanged;

            _box.MouseDoubleClick += Box_MouseDoubleClick;

            _box.TextAlignChanged += Box_TextAlignChanged;
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

        private void Box_TextAlignChanged(object sender, EventArgs e)
        {
            Invalidate();
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

        protected virtual void DrawTextPrompt()
        {
            using (Graphics gfx = CreateGraphics())
            {
                DrawTextPrompt(gfx);
            }
        }

        protected virtual void DrawTextPrompt(Graphics g)
        {
            TextFormatFlags flags = TextFormatFlags.NoPadding | TextFormatFlags.Top | TextFormatFlags.EndEllipsis;

            Rectangle rectangle = ClientRectangle;

            switch (_box.TextAlign)
            {
                case HorizontalAlignment.Left:
                    flags = flags | TextFormatFlags.Left;

                    rectangle.Offset(1, 1);
                    break;
                case HorizontalAlignment.Right:
                    flags = flags | TextFormatFlags.Right;

                    rectangle.Offset(0, 1);
                    break;
                case HorizontalAlignment.Center:
                    flags = flags | TextFormatFlags.HorizontalCenter;

                    rectangle.Offset(0, 1);
                    break;
            }

            TextRenderer.DrawText(g, PromptText, PromptTypeface, rectangle, PromptForeColour, BackColor, flags);
        }
        #endregion

        #region Overridden Methods
        protected override void OnEnter(EventArgs e)
        {
            if (_box.Text.Length > 0 && FocusSelect)
            {
                _box.SelectAll();
            }

            base.OnEnter(e);
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

            if (DrawPrompt && _box.Text.Length == 0)
            {
                DrawTextPrompt(e.Graphics);
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_SETFOCUS:
                    DrawPrompt = false;
                    break;
                case WM_KILLFOCUS:
                    DrawPrompt = true;
                    break;
            }

            base.WndProc(ref m);

            // Only draw the prompt on the WM_PAINT event and when the Text property is empty
            if (m.Msg == WM_PAINT && DrawPrompt && Text.Length == 0 && !GetStyle(ControlStyles.UserPaint))
            {
                DrawTextPrompt();
            }
        }
        #endregion
    }
}