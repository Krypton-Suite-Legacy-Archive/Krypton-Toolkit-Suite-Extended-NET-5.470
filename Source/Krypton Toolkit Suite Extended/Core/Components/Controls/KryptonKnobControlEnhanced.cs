using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace KryptonToolkitSuiteExtendedCore.Components.Controls
{
    public class KryptonKnobControlEnhanced : UserControl
    {
        #region Designer Code
        private Container components = null;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // KryptonKnobControlEnhanced
            // 
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "KryptonKnobControlEnhanced";
            this.Resize += new System.EventHandler(this.KryptonKnobControlEnhanced_Resize);

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }

            base.Dispose(disposing);
        }
        #endregion

        #region Variables
        private bool _showSmallScale = false, _showLargeScale = true, _isFocused = false, _isKnobRotating = false;

        private Brush _bKnob, _bKnobPoint;

        private Rectangle _rKnob, _rScale;

        private int _minimum = 0, _maximum = 25, _largeChange = 5, _smallChange = 1, _value = 0;

        private Point _pKnob;

        private Pen _dottedPen;

        private Image _offScreenImage;

        private Graphics _gOffScreen;

        private IPalette _palette;
        #endregion

        #region Properties
        /// <summary>
        /// Shows Small Scale marking.
        /// </summary>
        public bool ShowSmallScale
        {
            get => _showSmallScale;

            set
            {
                _showSmallScale = value;
                // need to redraw 
                Refresh();
            }
        }

        /// <summary>
        /// Shows Large Scale marking
        /// </summary>
        public bool ShowLargeScale
        {
            get => _showLargeScale;

            set
            {
                _showLargeScale = value;
                // need to redraw
                Refresh();
            }
        }

        /// <summary>
        /// Minimum Value for knob Control
        /// </summary>
        public int Minimum
        {
            get => _minimum;
            set => _minimum = value;
        }
        /// <summary>
        /// Maximum value for knob control
        /// </summary>
        public int Maximum
        {
            get => _maximum;
            set => _maximum = value;
        }

        /// <summary>
        /// value set for large change
        /// </summary>
        public int LargeChange
        {
            get => _largeChange;

            set
            {
                _largeChange = value;
                Refresh();
            }
        }
        /// <summary>
        /// value set for small change.
        /// </summary>
        public int SmallChange
        {
            get => _smallChange;

            set
            {
                _smallChange = value;
                Refresh();
            }
        }

        /// <summary>
        /// Current Value of knob control
        /// </summary>
        public int Value
        {
            get => _value;

            set
            {

                _value = value;
                // need to redraw 
                Refresh();
                // call delegate  
                OnValueChanged(this);
            }
        }
        #endregion

        #region Delegates
        public delegate void ValueChangedEventHandler(object sender);
        #endregion

        #region Events
        public event ValueChangedEventHandler ValueChanged;
        #endregion

        #region Virtual
        protected virtual void OnValueChanged(object sender)
        {
            if (ValueChanged != null)
            {
                ValueChanged(sender);
            }
        }
        #endregion

        #region Constructor
        public KryptonKnobControlEnhanced()
        {
            _dottedPen = new Pen(Classes.Drawing.Utility.GetDarkColour(BackColor, 40));

            _dottedPen.DashStyle = DashStyle.Dash;

            _dottedPen.DashCap = DashCap.Flat;

            InitializeComponent();

            InitialiseColours();

            SetDimensions();
        }
        #endregion

        #region Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            _gOffScreen.Clear(BackColor);

            _gOffScreen.FillEllipse(_bKnob, _rKnob);

            _gOffScreen.SmoothingMode = SmoothingMode.AntiAlias;

            _gOffScreen.DrawEllipse(new Pen(BackColor), _rKnob);

            if (_isFocused) _gOffScreen.DrawEllipse(_dottedPen, _rKnob);

            Point arrow = GetKnobPosition();

            Classes.Drawing.Utility.DrawInsetCircle(ref _gOffScreen, new Rectangle(arrow.X - 3, arrow.Y - 3, 6, 6), new Pen(BackColor));

            if (_showSmallScale)
            {
                for (int i = _minimum; i < _maximum; i += _smallChange)
                {
                    _gOffScreen.DrawLine(new Pen(ForeColor), GetMarkerPoint(0, i), GetMarkerPoint(0, i));
                }
            }

            if (_showLargeScale)
            {
                for (int i = _minimum; i < _maximum; i += _largeChange)
                {
                    _gOffScreen.DrawLine(new Pen(ForeColor), GetMarkerPoint(0, i), GetMarkerPoint(0, i));
                }
            }

            g.DrawImage(_offScreenImage, 0, 0);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (Classes.Drawing.Utility.IsPointInRectangle(new Point(e.X, e.Y), _rKnob)) _isKnobRotating = true;
        }

        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Left:
                    return true;
            }

            return base.IsInputKey(keyData);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            _isKnobRotating = true;

            if (Classes.Drawing.Utility.IsPointInRectangle(new Point(e.X, e.Y), _rKnob)) Value = GetValueFromPosition(new Point(e.X, e.Y));

            Cursor = Cursors.Default;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (_isKnobRotating)
            {
                Cursor = Cursors.Hand;

                Point p = new Point(e.X, e.Y);

                int positionValue = GetValueFromPosition(p);

                Value = positionValue;
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            _isFocused = true;

            Refresh();

            base.OnEnter(new EventArgs());
        }

        protected override void OnLeave(EventArgs e)
        {
            _isFocused = false;

            Refresh();

            base.OnLeave(new EventArgs());
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Right)
            {
                if (_value < Maximum) Value = _value + 1;

                Refresh();
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Left)
            {
                if (_value > Minimum) Value = _value - 1;

                Refresh();
            }
        }
        #endregion

        #region Methods
        private void SetDimensions()
        {
            int size = Width;

            if (Width > Height) size = Height;

            _rKnob = new Rectangle((int)(size * 0.10), (int)(size * 0.10), (int)(size * 0.80), (int)(size * 0.80));

            _rScale = new Rectangle(2, 2, size - 4, size - 4);

            _pKnob = new Point(_rKnob.X + _rKnob.Width / 2, _rKnob.Y + _rKnob.Height / 2);

            _offScreenImage = new Bitmap(Width, Height);

            _gOffScreen = Graphics.FromImage(_offScreenImage);

            _bKnob = new LinearGradientBrush(_rKnob, Classes.Drawing.Utility.GetLightColour(BackColor, 55), Classes.Drawing.Utility.GetDarkColour(BackColor, 55), LinearGradientMode.ForwardDiagonal);

            _bKnobPoint = new LinearGradientBrush(_rKnob, Classes.Drawing.Utility.GetLightColour(BackColor, 55), Classes.Drawing.Utility.GetDarkColour(BackColor, 55), LinearGradientMode.ForwardDiagonal);
        }

        private void InitialiseColours()
        {
            BackColor = _palette.ColorTable.MenuStripGradientBegin;
        }

        private Point GetKnobPosition()
        {
            double degree = 270 * Value / (Maximum - Minimum);

            degree = (degree + 135) * Math.PI / 180;

            Point positionPoint = new Point(0, 0);

            positionPoint.X = (int)(Math.Cos(degree) * (_rKnob.Width / 2 - 10) + _rKnob.X + _rKnob.Width / 2);

            positionPoint.Y = (int)(Math.Sin(degree) * (_rKnob.Width / 2 - 10) + _rKnob.Y + _rKnob.Height / 2);

            return positionPoint;
        }

        private Point GetMarkerPoint(int length, int Value)
        {
            double degree = 270 * Value / (Maximum - Minimum);

            degree = (degree + 135) * Math.PI / 180;

            Point positionPoint = new Point(0, 0);

            positionPoint.X = (int)(Math.Cos(degree) * (_rKnob.Width / 2 - length + 7) + _rKnob.X + _rKnob.Width / 2);

            positionPoint.Y = (int)(Math.Sin(degree) * (_rKnob.Width / 2 - length + 7) + _rKnob.Y + _rKnob.Height / 2);

            return positionPoint;
        }

        private int GetValueFromPosition(Point p)
        {
            double degree = 0.0;

            int v = 0;

            if (p.X <= _pKnob.X)
            {
                degree = (double)(_pKnob.Y - p.Y) / (double)(_pKnob.X - p.X);

                degree = Math.Atan(degree);

                degree = (degree) * (180 / Math.PI) + 45;

                v = (int)(degree * (this.Maximum - this.Minimum) / 270);

            }
            else if (p.X > _pKnob.X)
            {
                degree = (double)(p.Y - _pKnob.Y) / (double)(p.X - _pKnob.X);

                degree = Math.Atan(degree);

                degree = 225 + (degree) * (180 / Math.PI);

                v = (int)(degree * (this.Maximum - this.Minimum) / 270);

            }

            if (v > Maximum) v = Maximum;

            if (v < Minimum) v = Minimum;

            return v;

        }
        #endregion

        private void KryptonKnobControlEnhanced_Resize(object sender, EventArgs e)
        {
            SetDimensions();

            Refresh();
        }
    }
}