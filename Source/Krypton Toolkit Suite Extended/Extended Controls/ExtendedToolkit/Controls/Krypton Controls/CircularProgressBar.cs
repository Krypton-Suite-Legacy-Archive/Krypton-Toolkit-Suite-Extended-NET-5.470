using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WinFormAnimation;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    [ToolboxItem(true), ToolboxBitmap(typeof(CircularProgressBar), "ToolboxBitmaps.CircularProgressBar.bmp"), DefaultBindingProperty("Value")]
    public class CircularProgressBar : ProgressBar
    {
        #region Variables
        private readonly Animator _animator;
        private int? _animatedStartAngle;
        private float? _animatedValue;
        private AnimationFunctions.Function _animationFunction;
        private Brush _backBrush;
        private KnownAnimationFunctions _knownAnimationFunction;
        private ProgressBarStyle? _style;
        private int _lastValue;
        private KryptonPalette _palette;
        #endregion

        #region Properties
        /// <summary>
        ///     Sets a known animation function.
        /// </summary>
        [Category("Behavior")]
        public KnownAnimationFunctions AnimationFunction
        {
            get => _knownAnimationFunction;
            set
            {
                _animationFunction = AnimationFunctions.FromKnown(value);
                _knownAnimationFunction = value;
            }
        }

        /// <summary>
        ///     Gets or sets the animation speed in milliseconds.
        /// </summary>
        [Category("Behavior")]
        public int AnimationSpeed { get; set; }

        /// <summary>
        ///     Sets a custom animation function.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public AnimationFunctions.Function CustomAnimationFunction
        {
            private get { return _animationFunction; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                _knownAnimationFunction = KnownAnimationFunctions.None;
                _animationFunction = value;
            }
        }

        /// <summary>
        ///     Gets or sets the font of text in the <see cref="CircularProgressBar" />.
        /// </summary>
        /// <returns>
        ///     The <see cref="T:System.Drawing.Font" /> of the text. The default is the font set by the container.
        /// </returns>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public override Font Font
        {
            get => base.Font;
            set => base.Font = value;
        }

        /// <summary>
        /// </summary>
        [Category("Appearance")]
        public Color InnerColor { get; set; }

        /// <summary>
        /// </summary>
        [Category("Layout")]
        public int InnerMargin { get; set; }

        /// <summary>
        /// </summary>
        [Category("Layout")]
        public int InnerWidth { get; set; }

        /// <summary>
        /// </summary>
        [Category("Appearance")]
        public Color OuterColor { get; set; }

        /// <summary>
        /// </summary>
        [Category("Layout")]
        public int OuterMargin { get; set; }

        /// <summary>
        /// </summary>
        [Category("Layout")]
        public int OuterWidth { get; set; }

        /// <summary>
        /// </summary>
        [Category("Appearance")]
        public Color ProgressColor { get; set; }

        /// <summary>
        /// </summary>
        [Category("Layout")]
        public int ProgressWidth { get; set; }

        /// <summary>
        /// </summary>
        [Category("Appearance")]
        public Font SecondaryFont { get; set; }

        /// <summary>
        /// </summary>
        [Category("Layout")]
        public int StartAngle { get; set; }

        /// <summary>
        /// </summary>
        [Category("Appearance")]
        public Color SubscriptColor { get; set; }


        /// <summary>
        /// </summary>
        [Category("Layout")]
        public Padding SubscriptMargin { get; set; }

        /// <summary>
        /// </summary>
        [Category("Appearance")]
        public string SubscriptText { get; set; }

        /// <summary>
        /// </summary>
        [Category("Appearance")]
        public Color SuperscriptColor { get; set; }

        /// <summary>
        /// </summary>
        [Category("Layout")]
        public Padding SuperscriptMargin { get; set; }

        /// <summary>
        /// </summary>
        [Category("Appearance")]
        public string SuperscriptText { get; set; }

        /// <summary>
        ///     Gets or sets the text in the <see cref="CircularProgressBar" />.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        /// <summary>
        /// </summary>
        [Category("Layout")]
        public Padding TextMargin { get; set; }
        #endregion

        #region Constructor
        public CircularProgressBar()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            _animator = DesignMode ? null : new Animator();

            AnimationFunction = KnownAnimationFunctions.Liner;

            AnimationSpeed = 500;

            MarqueeAnimationSpeed = 2000;

            StartAngle = 270;

            _lastValue = Value;

            BackColor = Color.Transparent;

            ForeColor = Color.FromArgb(64, 64, 64);

            DoubleBuffered = true;

            Font = new Font("Segoe UI", 72, FontStyle.Bold);

            SecondaryFont = new Font("Segoe UI", (float)(Font.Size * .5), FontStyle.Regular);

            OuterMargin = -25;

            OuterWidth = 26;

            OuterColor = Color.Gray;

            ProgressWidth = 25;

            ProgressColor = Color.FromArgb(255, 128, 0);

            InnerMargin = 2;

            InnerWidth = -1;

            InnerColor = Color.FromArgb(224, 224, 224);

            TextMargin = new Padding(8, 8, 0, 0);

            Value = 68;

            SuperscriptMargin = new Padding(10, 35, 0, 0);

            SuperscriptColor = Color.FromArgb(166, 166, 166);

            SuperscriptText = "°C";

            SubscriptMargin = new Padding(10, -35, 0, 0);

            SubscriptColor = Color.FromArgb(166, 166, 166);

            SubscriptText = ".23";

            Size = new Size(320, 320);
        }
        #endregion

        #region Methods
        private static PointF AddPoint(PointF point, int value)
        {
            point.X += value;

            point.Y += value;

            return point;
        }

        private static Size AddSize(Size size, int value)
        {
            size.Height += value;

            size.Width += value;

            return size;
        }

        private static Rectangle ToRectangle(RectangleF rect) => new Rectangle((int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height);
        #endregion

        #region Overrides
        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                //if (!DesignMode)
                //{
                //    if (Style == ProgressBarStyle.Marquee)
                //    {
                //        InitialiseMarquee(_style != Style);
                //    }
                //    else
                //    {
                //        InitialiseContinues(_style != Style);
                //    }

                //    _style = Style;
                //}

                //if (_backBrush == null)
                //{
                //    RecreateBackgroundBrush();
                //}

                //StartPaint(e.Graphics);
            }
            catch
            {
            }
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            //RecreateBackgroundBrush();
        }

        protected override void OnParentBackgroundImageChanged(EventArgs e)
        {
          //  RecreateBackgroundBrush();
        }

        protected override void OnParentChanged(EventArgs e)
        {
            if (Parent != null)
            {
                
            }

            base.OnParentChanged(e);

            if (Parent != null)
            {

            }
        }
        #endregion
    }
}