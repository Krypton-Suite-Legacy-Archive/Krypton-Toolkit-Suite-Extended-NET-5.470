using ExtendedControls.Base.Code.Colours.ColourWheel;
using ExtendedControls.Base.Structs.ColourWheel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.Colours
{
    public partial class ColourWheel : Control
    {
        #region Variables
        private Color _frameColour = Color.CadetBlue;
        private HSLColour _selectedColour = new HSLColour(Color.BlanchedAlmond);
        private PathGradientBrush _brush = null;
        private List<PointF> _path = new List<PointF>();
        private List<Color> _colours = new List<Color>();
        private double _wheelLuminosity = 0.5;
        #endregion

        #region Events
        public event EventHandler SelectedColourChanged;
        #endregion

        #region Properties        
        /// <summary>
        /// Gets or sets the selected HSL colour.
        /// </summary>
        /// <value>
        /// The selected HSL colour.
        /// </value>
        public HSLColour SelectedHSLColour
        {
            get
            {
                return _selectedColour;
            }

            set
            {
                if (_selectedColour == value)
                {
                    return;
                }

                Invalidate(Utilities.Rect(ColourSelectorRectangle));

                _selectedColour = value;

                if (SelectedColourChanged != null)
                {
                    SelectedColourChanged(this, null);
                }

                Refresh();
            }
        }

        public RectangleF ColourSelectorRectangle
        {
            get
            {
                HSLColour colour = _selectedColour;

                double angleR = colour.Hue * Math.PI / 180;

                PointF centre = Utilities.Centre(ColourWheelRectangle);

                double radius = Radius(ColourWheelRectangle);

                radius *= colour.Saturation;

                double x = centre.X + Math.Cos(angleR) * radius, y = centre.Y - Math.Sin(angleR) * radius;

                Rectangle colRect = new Rectangle(new Point((int)x, (int)y), new Size(0, 0));

                colRect.Inflate(12, 12);

                return colRect;
            }
        }

        public RectangleF WheelRectangle
        {
            get
            {
                Rectangle r = ClientRectangle;

                r.Width -= 1;

                r.Height -= 1;

                return r;
            }
        }

        public RectangleF ColourWheelRectangle
        {
            get
            {
                RectangleF r = WheelRectangle;

                r.Inflate(-5, -5);

                return r;
            }
        }
        #endregion

        #region Constructor        
        /// <summary>
        /// Initialises a new instance of the <see cref="ColourWheel"/> class.
        /// </summary>
        public ColourWheel()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            DoubleBuffered = true;

            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
        }
        #endregion

        #region Overrides        
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.GotFocus" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);

            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.LostFocus" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);

            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            using (SolidBrush sb = new SolidBrush(BackColor))
            {
                e.Graphics.FillRectangle(sb, ClientRectangle);
            }

            RectangleF wheelRectangle = WheelRectangle;

            Utilities.DrawFrame(e.Graphics, wheelRectangle, 6, _frameColour);

            wheelRectangle = ColourWheelRectangle;

            PointF centre = Utilities.Centre(wheelRectangle);

            e.Graphics.SmoothingMode = SmoothingMode.HighSpeed;

            if (_brush == null)
            {
                _brush = new PathGradientBrush(_path.ToArray(), WrapMode.Clamp);

                _brush.CenterPoint = centre;

                _brush.CenterColor = Color.White;

                _brush.SurroundColors = _colours.ToArray();
            }

            e.Graphics.FillPie(_brush, Utilities.Rect(wheelRectangle), 0, 360);

            DrawColourSelector(e.Graphics);

            if (Focused)
            {
                RectangleF r = WheelRectangle;

                r.Inflate(-2, -2);

                ControlPaint.DrawFocusRectangle(e.Graphics, Utilities.Rect(r));
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Resize" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (_brush != null)
            {
                _brush.Dispose();
            }

            _brush = null;

            RecalculateWheelPoints();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseMove" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            PointF mousePoint = new PointF(e.X, e.Y);

            if (e.Button == MouseButtons.Left)
            {
                SetColour(mousePoint);
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseDown" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            Focus();

            PointF mousePoint = new PointF(e.X, e.Y);

            if (e.Button == MouseButtons.Left)
            {
                SetColour(mousePoint);
            }
        }

        /// <summary>
        /// Processes a dialog key.
        /// </summary>
        /// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values that represents the key to process.</param>
        /// <returns>
        ///   <see langword="true" /> if the key was processed by the control; otherwise, <see langword="false" />.
        /// </returns>
        protected override bool ProcessDialogKey(Keys keyData)
        {
            HSLColour c = SelectedHSLColour;

            double hue = c.Hue;

            int step = 1;

            if ((keyData & Keys.Control) == Keys.Control)
            {
                step = 5;
            }

            if ((keyData & Keys.Up) == Keys.Up)
            {
                hue += step;
            }

            if ((keyData & Keys.Down) == Keys.Down)
            {
                hue -= step;
            }

            if (hue >= 360)
            {
                hue = 0;
            }

            if (hue < 0)
            {
                hue = 359;
            }


            if (hue != c.Hue)
            {
                c.Hue = hue;

                SelectedHSLColour = c;

                return true;
            }

            return base.ProcessDialogKey(keyData);
        }
        #endregion

        #region Methods
        private void DrawColourSelector(Graphics g)
        {
            Rectangle r = Utilities.Rect(ColourSelectorRectangle);

            PointF centre = Utilities.Centre(r);

            Image image = SelectorImages.Image(SelectorImages.eIndexes.DOGHNUT);

            g.DrawImageUnscaled(image, (int)(centre.X - image.Width / 2), (int)(centre.Y - image.Height / 2));
        }

        private float Radius(RectangleF r)
        {
            PointF centre = Utilities.Centre(r);

            float radius = Math.Min((r.Width / 2), (r.Height / 2));

            return radius;
        }

        private void RecalculateWheelPoints()
        {
            _path.Clear();

            _colours.Clear();

            PointF centre = Utilities.Centre(ColourWheelRectangle);

            float radius = Radius(ColourWheelRectangle);

            double angle = 0, fullCircle = 360, step = 5;

            while (angle < fullCircle)
            {
                double angleR = angle * (Math.PI / 180), x = centre.X + Math.Cos(angleR) * radius, y = centre.Y - Math.Sin(angleR) * radius;

                _path.Add(new PointF((float)x, (float)y));

                _colours.Add(new HSLColour(angle, 0, _wheelLuminosity).Colour);

                angle += step;
            }
        }

        private void SetColour(PointF mousePoint)
        {
            if (WheelRectangle.Contains(mousePoint) == false)
            {
                return;
            }

            PointF centre = Utilities.Centre(ColourWheelRectangle);

            double radius = Radius(ColourWheelRectangle), dX = Math.Abs(mousePoint.X - centre.X), dY = Math.Abs(mousePoint.Y - centre.Y), angle = Math.Atan(dX / dY) / Math.PI * 180, dist = Math.Pow((Math.Pow(dX, 2) + (Math.Pow(dY, 2))), 0.5), saturation = dist / radius;

            if (dist < 6)
            {
                saturation = 0;
            }

            if (mousePoint.X < centre.X)
            {
                angle = 180 - angle;
            }

            if (mousePoint.Y > centre.Y)
            {
                angle = 360 - angle;
            }

            SelectedHSLColour = new HSLColour(angle, saturation, SelectedHSLColour.Luminosity);
        }
        #endregion
    }
}