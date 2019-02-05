using ExtendedControls.Base.Code.Colours;
using ExtendedControls.Base.Code.Drawing;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    public class ToggleSwitch : Control
    {
        #region Events
        public delegate void SliderChangedEventHandler(object sender, EventArgs e);

        public event SliderChangedEventHandler SliderValueChanged;
        #endregion

        #region Variables
        private float _diameter, _artis;
        private RoundedRectangleF _rect;
        private RectangleF _circle;
        private bool _isOn, _textEnabled;
        private Color _borderColour;
        private Timer _paintTicker = new Timer();
        #endregion

        #region Properties
        public bool TextEnabled
        {
            get { return _textEnabled; }

            set
            {
                _textEnabled = value;

                Invalidate();
            }
        }
        public bool IsOn
        {
            get { return _isOn; }

            set
            {
                _paintTicker.Stop();

                _isOn = value;

                _paintTicker.Start();

                if (SliderValueChanged != null)
                {
                    SliderValueChanged(this, EventArgs.Empty);
                }
            }
        }
        public Color BorderColour
        {
            get { return _borderColour; }

            set
            {
                _borderColour = value;

                Invalidate();
            }
        }

        protected override Size DefaultSize => new Size(60, 35);
        #endregion

        #region Constructor
        public ToggleSwitch()
        {
            Cursor = Cursors.Hand;

            DoubleBuffered = true;

            _artis = 4;

            _diameter = 30;

            TextEnabled = true;

            _rect = new RoundedRectangleF(2 * _diameter, _diameter + 2, _diameter / 2, 1, 1);

            _circle = new RectangleF(1, 1, _diameter, _diameter);

            IsOn = true;

            BorderColour = Color.LightGray;

            BackColor = Color.Transparent;

            _paintTicker.Interval = 1;

            _paintTicker.Tick += PaintTicker_Tick;
        }
        #endregion

        #region Event Handlers
        private void PaintTicker_Tick(object sender, EventArgs e)
        {
            float x = _circle.X;

            if (IsOn)
            {
                if (x + _artis <= Width - _diameter - 1)
                {
                    x += _artis;

                    _circle = new RectangleF(x, 1, _diameter, _diameter);

                    Invalidate();
                }
                else
                {
                    x = Width - _diameter - 1;

                    _circle = new RectangleF(x, 1, _diameter, _diameter);

                    Invalidate();

                    _paintTicker.Stop();
                }

            }
            else //switch the circle to the left with animation
            {
                if (x - _artis >= 1)
                {
                    x -= _artis;

                    _circle = new RectangleF(x, 1, _diameter, _diameter);

                    Invalidate();
                }
                else
                {
                    x = 1;

                    _circle = new RectangleF(x, 1, _diameter, _diameter);

                    Invalidate();

                    _paintTicker.Stop();

                }
            }
        }
        #endregion

        #region Overrides
        protected override void OnEnabledChanged(EventArgs e)
        {
            Invalidate();

            base.OnEnabledChanged(e);
        }

        protected override void OnResize(EventArgs e)
        {
            Width = (Height - 2) * 2;

            _diameter = Width / 2;

            _artis = 4 * _diameter / 30;

            _rect = new RoundedRectangleF(2 * _diameter, _diameter + 2, _diameter / 2, 1, 1);

            _circle = new RectangleF(!IsOn ? 1 : Width - _diameter - 1, 1, _diameter, _diameter);

            base.OnResize(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            if (Enabled)
            {
                using (SolidBrush sb = new SolidBrush(IsOn ? Color.LightGreen : Color.LightGray))
                {
                    e.Graphics.FillPath(sb, _rect.Path);
                }

                using (Pen pen = new Pen(BorderColour, 2f))
                {
                    e.Graphics.DrawPath(pen, _rect.Path);
                }

                string on = "On", off = "Off";

                if (TextEnabled)
                {
                    using (Font typeface = new Font("Segoe UI", 11f * _diameter / 30, FontStyle.Bold))
                    {
                        int height = TextRenderer.MeasureText(on, typeface).Height;

                        float y = (_diameter - height) / 2f;

                        e.Graphics.DrawString(on, typeface, Brushes.Gray, 5, y + 1);

                        height = TextRenderer.MeasureText(off, typeface).Height;

                        y = (_diameter - height) / 2f;

                        e.Graphics.DrawString(off, typeface, Brushes.Gray, _diameter + 2, y + 1);
                    }

                    using (SolidBrush circleBrush = new SolidBrush("#F6F0E6".FromHex()))
                    {
                        e.Graphics.FillEllipse(circleBrush, _circle);
                    }

                    using (Pen pen = new Pen(Color.LightGray, 1.2f))
                    {
                        e.Graphics.DrawEllipse(pen, _circle);
                    }
                }
            }
            else
            {
                using (SolidBrush disableBrush = new SolidBrush("#CFCFCF".FromHex()))
                {
                    using (SolidBrush ellBrush = new SolidBrush("#B3B3B3".FromHex()))
                    {
                        e.Graphics.FillPath(disableBrush, _rect.Path);

                        e.Graphics.FillEllipse(ellBrush, _circle);

                        e.Graphics.DrawEllipse(Pens.DarkGray, _circle);
                    }
                }
            }

            base.OnPaint(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            _isOn = !_isOn;

            IsOn = _isOn;

            base.OnMouseDown(e);
        }
        #endregion
    }
}