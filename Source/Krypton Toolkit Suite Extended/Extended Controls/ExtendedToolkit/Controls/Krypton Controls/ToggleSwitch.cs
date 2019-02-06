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
    /// A toggle switch.
    /// Boilerplate code from: https://github.com/aalitor/AltoControls/blob/on-development/AltoControls/Controls/SwitchButton.cs
    /// </summary>
    [ToolboxItem(true)]
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
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
        private bool _isOn, _textEnabled, _useGradientOnKnob;
        private Color _borderColour, _offColour, _onColour, _disabledColour, _knobColour, _disabledKnobColour, _enabledTextColour, _disabledTextColour, _startGradientColour, _middleGradientColour, _endGradientColour, _penColour;
        private Timer _paintTicker = new Timer();
        private string _enabledText, _disabledText;
        private LinearGradientMode _mode;
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

        public bool UseGradientOnKnob
        {
            get => _useGradientOnKnob;

            set
            {
                _useGradientOnKnob = value;

                Invalidate();
            }
        }

        public Color OffColour { get => _offColour; set => _offColour = value; }

        public Color BorderColour
        {
            get { return _borderColour; }

            set
            {
                _borderColour = value;

                Invalidate();
            }
        }

        public Color DisabledKnobColour
        {
            get => _disabledKnobColour;

            set
            {
                _disabledKnobColour = value;

                Invalidate();
            }
        }

        //[DefaultValue(Color.LightGreen)]
        public Color OnColour
        {
            get => _onColour;

            set
            {
                _onColour = value;

                Invalidate();
            }
        }

        public Color DisabledColour
        {
            get => _disabledColour;

            set
            {
                _disabledColour = value;

                Invalidate();
            }
        }

        public Color OnTextColour
        {
            get => _enabledTextColour;

            set
            {
                _enabledTextColour = value;

                Invalidate();
            }
        }

        public Color OffTextColour
        {
            get => _disabledTextColour;

            set
            {
                _disabledTextColour = value;

                Invalidate();
            }
        }

        public Color KnobColour
        {
            get => _knobColour;

            set
            {
                _knobColour = value;

                Invalidate();
            }
        }

        public Color StartGradientColour
        {
            get => _startGradientColour;

            set
            {
                _startGradientColour = value;

                Invalidate();
            }
        }

        public Color MiddleGradientColour
        {
            get => _middleGradientColour;

            set
            {
                _middleGradientColour = value;

                Invalidate();
            }
        }

        public Color EndGradientColour
        {
            get => _endGradientColour;

            set
            {
                _endGradientColour = value;

                Invalidate();
            }
        }

        public Color PenColour
        {
            get => _penColour;


            set
            {
                _penColour = value;

                Invalidate();
            }
        }

        public LinearGradientMode GradientMode
        {
            get => _mode;

            set
            {
                _mode = value;

                Invalidate();
            }
        }

        [DefaultValue("On")]
        public string EnabledText
        {
            get => _enabledText;

            set
            {
                _enabledText = value;

                Invalidate();
            }
        }

        [DefaultValue("Off")]
        public string DisabledText
        {
            get => _disabledText;

            set
            {
                _disabledText = value;

                Invalidate();
            }
        }

        protected override Size DefaultSize => new Size(60, 35);
        #endregion

        #region Constructor
        public ToggleSwitch()
        {
            // Double buffering
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            SetStyle(ControlStyles.UserPaint, true);

            SetStyle(ControlStyles.ResizeRedraw, true);

            #region Set Colours
            OffColour = Color.LightGray;

            OnColour = Color.LightGreen;

            KnobColour = Color.FromArgb(246, 240, 230);

            DisabledColour = Color.FromArgb(207, 207, 207);

            DisabledKnobColour = Color.FromArgb(179, 179, 179);

            OnTextColour = Color.Gray;

            OffTextColour = Color.White;

            StartGradientColour = Color.FromArgb(187, 206, 230);

            MiddleGradientColour = Color.FromArgb(220, 232, 246);

            EndGradientColour = Color.FromArgb(132, 157, 189);

            GradientMode = LinearGradientMode.ForwardDiagonal;

            PenColour = Color.LightGray;
            #endregion

            EnabledText = "On";

            DisabledText = "Off";

            Cursor = Cursors.Hand;

            DoubleBuffered = true;

            _artis = 4;

            _diameter = 30;

            TextEnabled = true;

            _rect = new RoundedRectangleF(2 * _diameter, _diameter + 2, _diameter / 2, 1, 1);

            _circle = new RectangleF(1, 1, _diameter, _diameter);

            IsOn = true;

            UseGradientOnKnob = false;

            BorderColour = Color.LightGray;

            BackColor = Color.Transparent;

            Font = new Font("Segoe UI", 11f, FontStyle.Bold);

            _paintTicker.Interval = 1;

            _paintTicker.Tick += PaintTicker_Tick;

            Text = string.Empty;
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
                using (SolidBrush sb = new SolidBrush(IsOn ? OnColour : OffColour)) //Color.LightGreen : Color.LightGray))
                {
                    e.Graphics.FillPath(sb, _rect.Path);
                }

                using (Pen pen = new Pen(BorderColour, 2f))
                {
                    e.Graphics.DrawPath(pen, _rect.Path);
                }

                string on = EnabledText, off = DisabledText;

                if (TextEnabled)
                {
                    using (Font typeface = new Font(Font.FontFamily.Name, Font.Size * _diameter / 30, Font.Style))
                    {
                        int height = TextRenderer.MeasureText(on, typeface).Height;

                        float y = (_diameter - height) / 2f;

                        SolidBrush onBrush = new SolidBrush(OnTextColour), offBrush = new SolidBrush(OffTextColour);

                        e.Graphics.DrawString(on, typeface, onBrush, 5, y + 1);

                        height = TextRenderer.MeasureText(off, typeface).Height;

                        y = (_diameter - height) / 2f;

                        e.Graphics.DrawString(off, typeface, offBrush, _diameter + 2, y + 1);
                    }


                    if (UseGradientOnKnob)
                    {
                        using (LinearGradientBrush lgb = new LinearGradientBrush(_circle, StartGradientColour, EndGradientColour, GradientMode)) //, Color.Aquamarine, LinearGradientMode.ForwardDiagonal))
                        {
                            e.Graphics.FillEllipse(lgb, _circle);
                        }
                    }
                    else
                    {
                        using (SolidBrush circleBrush = new SolidBrush(KnobColour)) //"#F6F0E6".FromHex()))
                        {
                            e.Graphics.FillEllipse(circleBrush, _circle);
                        }
                    }

                    using (Pen pen = new Pen(PenColour, 1.2f))
                    {
                        e.Graphics.DrawEllipse(pen, _circle);
                    }
                }
            }
            else
            {
                using (SolidBrush disableBrush = new SolidBrush(DisabledColour)) //"#CFCFCF".FromHex()))
                {
                    using (SolidBrush ellBrush = new SolidBrush(DisabledKnobColour)) //"#B3B3B3".FromHex()))
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