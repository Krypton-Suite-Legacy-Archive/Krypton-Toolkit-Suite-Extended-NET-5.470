using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.ToolstripControls
{
    [ToolboxBitmap(typeof(ToolStripStatusLabel)), ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.StatusStrip | ToolStripItemDesignerAvailability.ToolStrip)]
    public class ExtendedToolStripStatusLabel : ToolStripStatusLabel
    {
        #region Variables

        #region Krypton
        IPalette _palette;

        IRenderer _renderer;

        // This may not be needed, but oh well...
        KryptonPalette _kryptonPalette;
        #endregion

        bool _alert, _enableBlinking;

        Color _textColour, _backGradient1, _backGradient2, _textGlow, _alertColour1, _alertColour2, _alertTextColour;

        Font _textTypeface;

        LinearGradientMode _linearGradientMode;

        int _textGlowSpread, _flashInterval;

        Timer _alertFlashTimer;

        long _blinkDuration;
        #endregion

        #region Properties        
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ExtendedToolStripStatusLabel"/> is alert.
        /// </summary>
        /// <value>
        ///   <c>true</c> if alert; otherwise, <c>false</c>.
        /// </value>
        [DefaultValue(false), Description("Alerts the user."), Category("Appearance")]
        public bool Alert
        {
            get
            {
                return _alert;
            }

            set
            {
                _alert = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [enable blinking].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable blinking]; otherwise, <c>false</c>.
        /// </value>
        [DefaultValue(false), Description("Enables a blinking mode."), Category("Blinking Settings")]
        public bool EnableBlinking
        {
            get
            {
                return _enableBlinking;
            }

            set
            {
                _enableBlinking = value;
            }
        }

        /// <summary>
        /// Gets or sets the alert colour one.
        /// </summary>
        /// <value>
        /// The alert colour one.
        /// </value>
        [DefaultValue(typeof(Color), "White"), Description("Defined alert first colour."), Category("Blinking Settings")]
        public Color AlertColourOne
        {
            get
            {
                return _alertColour1;
            }

            set
            {
                _alertColour1 = value;

                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the alert colour two.
        /// </summary>
        /// <value>
        /// The alert colour two.
        /// </value>
        [DefaultValue(typeof(Color), "Black"), Description("Defined alert second colour."), Category("Blinking Settings")]
        public Color AlertColourTwo
        {
            get
            {
                return _alertColour2;
            }

            set
            {
                _alertColour2 = value;

                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the alert text colour.
        /// </summary>
        /// <value>
        /// The alert text colour.
        /// </value>
        [DefaultValue(typeof(Color), "Red"), Description("Defined alert text colour."), Category("Blinking Settings")]
        public Color AlertTextColour
        {
            get
            {
                return _alertTextColour;
            }

            set
            {
                _alertTextColour = value;

                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the gradient colour one.
        /// </summary>
        /// <value>
        /// The gradient colour one.
        /// </value>
        [DefaultValue(typeof(Color), "White"), Description("The first gradient colour."), Category("Appearance")]
        public Color GradientColourOne
        {
            get
            {
                return _backGradient1;
            }

            set
            {
                _backGradient1 = value;

                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the gradient colour two.
        /// </summary>
        /// <value>
        /// The gradient colour two.
        /// </value>
        [DefaultValue(typeof(Color), "Blue"), Description("The second gradient colour."), Category("Appearance")]
        public Color GradientColourTwo
        {
            get
            {
                return _backGradient2;
            }

            set
            {
                _backGradient2 = value;

                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the text glow colour.
        /// </summary>
        /// <value>
        /// The text glow colour.
        /// </value>
        [DefaultValue(typeof(Color), "White"), Description("The text glow colour."), Category("Appearance")]
        public Color TextGlow
        {
            get
            {
                return _textGlow;
            }

            set
            {
                _textGlow = value;

                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the gradient mode.
        /// </summary>
        /// <value>
        /// The gradient mode.
        /// </value>
        [DefaultValue(typeof(LinearGradientMode), "ForwardDiagonal"), Description("Gradient mode"), Category("Appearance")]
        public LinearGradientMode GradientMode
        {
            get
            {
                return _linearGradientMode;
            }

            set
            {
                _linearGradientMode = value;

                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the text glow spread.
        /// </summary>
        /// <value>
        /// The text glow spread.
        /// </value>
        [DefaultValue(5), Description("The text glow spread"), Category("Appearance")]
        public int TextGlowSpread
        {
            get
            {
                return _textGlowSpread;
            }

            set
            {
                _textGlowSpread = value;
            }
        }

        /// <summary>
        /// Gets or sets the alert blink interval.
        /// </summary>
        /// <value>
        /// The alert blink interval.
        /// </value>
        [DefaultValue(256), Description("The blink interval."), Category("Blinking Settings")]
        public int AlertBlinkInterval
        {
            get
            {
                return _flashInterval;
            }

            set
            {
                _flashInterval = value;
            }
        }

        /// <summary>
        /// Gets or sets the duration of the blink.
        /// </summary>
        /// <value>
        /// The duration of the blink.
        /// </value>
        [DefaultValue(10), Description("Defines how long the blinking lasts for."), Category("Blinking Settings")]
        public long BlinkDuration
        {
            get
            {
                return _blinkDuration;
            }

            set
            {
                _blinkDuration = value;
            }
        }
        #endregion

        #region Constructors
        public ExtendedToolStripStatusLabel()
        {
            Alert = false;

            AlertColourOne = Color.White;

            AlertColourTwo = Color.Black;

            AlertTextColour = Color.Red;

            GradientColourOne = Color.Empty;

            GradientColourTwo = Color.Empty;

            TextGlow = Color.White;

            GradientMode = LinearGradientMode.ForwardDiagonal;

            TextGlowSpread = 5;

            AlertBlinkInterval = 256;

            BlinkDuration = 10;
        }

        //public ExtendedToolStripStatusLabel(bool enableBlinking)
        //{
        //    if (enableBlinking)
        //    {
        //        _alertFlashTimer = new Timer();

        //        _alertFlashTimer.Interval = AlertBlinkInterval;

        //        if (enableBlinking)
        //        {
        //            _alertFlashTimer.Start();

        //            _alertFlashTimer.Tick += AlertFlashTimer_Tick;

        //            base.ForeColor = AlertTextColour;
        //        }
        //    }
        //}

        //private void AlertFlashTimer_Tick(object sender, EventArgs e)
        //{
        //    if (AlertColourOne != Color.Empty && AlertColourTwo != Color.Empty)
        //    {
        //        if (BackColor == AlertColourOne)
        //        {
        //            BackColor = AlertColourTwo;
        //        }
        //        else
        //        {
        //            BackColor = AlertColourOne;
        //        }
        //    }
        //}
        #endregion

        #region Overrides
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public override Color BackColor { get; set; }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.ToolStripItem.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            // Set a graphics variable
            Graphics g = e.Graphics;

            // Rectangle variable
            Rectangle r = new Rectangle(0, 0, Width, Height);

            if (BackColor != Color.Empty)
            {
                // Fill the background with a solid colour
                using (SolidBrush solidBrush = new SolidBrush(BackColor))
                {
                    g.FillRectangle(solidBrush, r);
                }
            }
            else if (GradientColourOne != Color.Empty || GradientColourTwo != Color.Empty)
            {
                // Fill the background with a gradient colour
                using (LinearGradientBrush lgb = new LinearGradientBrush(r, GradientColourOne, GradientColourTwo, GradientMode))
                {
                    g.FillRectangle(lgb, r);
                }
            }

            // Text rendering
            if (ForeColor != Color.Empty)
            {
                g.TextRenderingHint = TextRenderingHint.AntiAlias | TextRenderingHint.ClearTypeGridFit;

                // Preserve user font settings
                Font typeface = new Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit);

                SolidBrush brush = new SolidBrush(ForeColor);

                // Draw the text
                g.DrawString(Text, typeface, brush, 0, 0);
            }

            //base.OnPaint(e);
        }
        #endregion

        #region Methods
        public void SetTextColour(Color textColour)
        {
            if (_palette != null)
            {

            }
        }

        /// <summary>
        /// Blinks the label.
        /// </summary>
        public async void BlinkLabel(long blinkDuration)
        {
            var sw = Stopwatch.StartNew();

            var fgc = ForeColor;

            var bgc = BackColor;

            while (sw.ElapsedMilliseconds < blinkDuration)
            {
                await Task.Delay(_flashInterval);

                base.BackColor = base.BackColor == AlertColourOne ? AlertColourTwo : AlertColourOne;

                base.ForeColor = AlertTextColour;

                Invalidate();
            }

            BackColor = bgc;

            ForeColor = fgc;

            Invalidate();

            sw.Stop();
        }

        public async void SoftBlink(Color alertColour1, Color alertColour2, Color alertTextColour, short cycleInterval, bool bkClr, long blinkDuration)
        {
            var sw = Stopwatch.StartNew();

            var fgc = ForeColor;

            var bgc = BackColor;

            short halfCycle = (short)Math.Round(cycleInterval * 0.5);

            while (sw.ElapsedMilliseconds < blinkDuration)
            {
                await Task.Delay(1);

                var n = sw.ElapsedMilliseconds % cycleInterval;

                var per = (double)Math.Abs(n - halfCycle) / halfCycle;

                var red = (short)Math.Round((alertColour2.R - alertColour1.R) * per) + alertColour1.R;

                var grn = (short)Math.Round((alertColour2.G - alertColour1.G) * per) + alertColour1.G;

                var blw = (short)Math.Round((alertColour2.B - alertColour1.B) * per) + alertColour1.B;

                var clr = Color.FromArgb(red, grn, blw);

                if (bkClr)
                {
                    base.BackColor = clr;
                }
                else
                {
                    base.ForeColor = clr;
                }

                Invalidate();
            }

            BackColor = bgc;

            ForeColor = fgc;

            Invalidate();

            sw.Stop();
        }
        #endregion
    }
}