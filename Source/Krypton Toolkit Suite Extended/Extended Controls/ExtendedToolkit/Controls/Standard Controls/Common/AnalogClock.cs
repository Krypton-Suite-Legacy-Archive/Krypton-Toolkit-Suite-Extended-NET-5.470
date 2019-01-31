using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.Common
{
    /// <summary>
	/// Defines the ticking style used for the second and minute hands of the analog clock. 
	/// </summary>
	public enum TickStyle
    {
        /// <summary>
        /// Smooth ticking style. For example if used with second hand it will be updated every millisecond.
        /// </summary>
        Smooth,
        /// <summary>
        /// Normal ticking style. For example if used with second hand it will be updated every second only.
        /// </summary>
        Normal
    }


    /// <summary>
    /// Represents the Analog clock control.
    /// </summary>
    //[ToolboxBitmap(typeof(AnalogClock), "AC.ExtendedRenderer.Toolkit.StdControls.Images.AnalogClock.bmp"), ToolboxItem(true)]
    [ToolboxBitmap(typeof(Timer)), ToolboxItem(false)]
    public class AnalogClock : UserControl
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Creates a new instace of the Analog Clock control.
        /// </summary>
        public AnalogClock()
        {

            InitializeComponent();
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //this.SetStyle(ControlStyles.Opaque, true);
            //this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
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
            // 
            // AnalogClock
            // 
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.Name = "AnalogClock";
            this.Size = new System.Drawing.Size(232, 232);
            this.Resize += new System.EventHandler(this.AnalogClock_Resize);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AnalogClock_Paint);

        }
        #endregion

        #region Properties
        /// <summary>
        /// The Background image used in the clock face.
        /// </summary>
        /// <remarks>Using a large image will result in poor performance and increased memory consumption.</remarks>
        [
        Category("Clock"),
        Description("The Background image used in the clock face."),

        ]
        public Image FaceImage
        {
            get { return img; }
            set { this.img = value; Invalidate(); }
        }


        /// <summary>
        /// Defines the second hand tick style.
        /// </summary>
        [
        Category("Clock"),
        Description("Defines the second hand tick style."),

        ]
        public TickStyle SecondHandTickStyle
        {
            get { return secondHandTickStyle; }
            set { this.secondHandTickStyle = value; }
        }

        /// <summary>
        /// Defines the minute hand tick style.
        /// </summary>
        [
        Category("Clock"),
        Description("Defines the minute hand tick style."),

        ]
        public TickStyle MinuteHandTickStyle
        {
            get { return minHandTickStyle; }
            set { minHandTickStyle = value; }
        }

        /// <summary>
        /// Determines whether the Numerals are drawn on the clock face.
        /// </summary>
        [
        Category("Clock"),
        Description("Determines whether the Numerals are drawn on the clock face."),
        DefaultValue(true),
        ]
        public bool DrawNumerals
        {
            get { return drawnumerals; }
            set { drawnumerals = value; Invalidate(); }

        }

        /// <summary>
        /// Sets or gets the rendering quality of the clock.
        /// </summary>
        /// <remarks>This property does not effect the numeral text rendering quality. To set the numeral text rendering quality use the <see cref="TextRenderingHint"/> Property</remarks>
        [
        Category("Clock"),
        Description("Sets or gets the rendering quality of the clock."),
        DefaultValue(SmoothingMode.AntiAlias),
        ]
        public SmoothingMode SmoothingMode
        {
            get { return smoothingMode; }
            set { this.smoothingMode = value; Invalidate(); }
        }

        /// <summary>
        /// Sets or gets the text rendering mode used for the clock numerals.
        /// </summary>
        [
        Category("Clock"),
        Description("Sets or gets the text rendering mode used for the clock numerals."),
        DefaultValue(TextRenderingHint.AntiAlias),
        ]
        public TextRenderingHint TextRenderingHint
        {
            get { return this.textRenderingHint; }
            set { this.textRenderingHint = value; Invalidate(); }

        }

        /// <summary>
        /// Determines whether the clock Rim is drawn or not.
        /// </summary>
        [
        Category("Clock"),
        Description("Determines whether the clock Rim is drawn or not."),
        DefaultValue(true),
        ]
        public bool DrawRim
        {
            get { return this.drawRim; }
            set { this.drawRim = value; Invalidate(); }
        }

        /// <summary>
        /// Determines whether drop shadow for the clock is drawn or not.
        /// </summary>
        [
        Category("Clock"),
        Description("Determines whether drop shadow for the clock is drawn or not."),
        DefaultValue(true),
        ]
        public bool DrawDropShadow
        {
            get { return this.drawDropShadow; }
            set { drawDropShadow = value; Invalidate(); }
        }

        /// <summary>
        /// Sets or gets the color of the Drop Shadow.
        /// </summary>
        [
        Category("Clock"),
        Description("Sets or gets the color of the Drop Shadow."),

        ]
        public Color DropShadowColour
        {
            get { return this.dropShadowColor; }
            set { this.dropShadowColor = value; Invalidate(); }
        }


        /// <summary>
        /// Sets or gets the color of the second hand drop Shadow.
        /// </summary>
        [
        Category("Clock"),
        Description("Sets or gets the color of the second hand drop Shadow."),

        ]
        public Color SecondHandDropShadowColour
        {
            get { return this.secondHandDropShadowColor; }
            set { this.secondHandDropShadowColor = value; Invalidate(); }
        }


        /// <summary>
        /// Sets or gets the color of the Minute hand drop Shadow.
        /// </summary>
        [
        Category("Clock"),
        Description("Sets or gets the color of the Minute hand drop Shadow."),

        ]
        public Color MinuteHandDropShadowColour
        {
            get { return this.minuteHandDropShadowColor; }
            set { this.minuteHandDropShadowColor = value; Invalidate(); }
        }

        /// <summary>
        /// Sets or gets the color of the hour hand drop Shadow.
        /// </summary>
        [
        Category("Clock"),
        Description("Sets or gets the color of the hour hand drop Shadow."),

        ]
        public Color HourHandDropShadowColour
        {
            get { return this.hourHandDropShadowColor; }
            set { this.hourHandDropShadowColor = value; Invalidate(); }
        }
















        /// <summary>
        /// Determines the first color of the clock face gradient.
        /// </summary>
        [
        Category("Clock"),
        Description("Determines the first color of the clock face gradient."),

        ]
        public Color FaceColourHigh
        {
            get { return this.faceColor1; }
            set { this.faceColor1 = value; Invalidate(); }
        }

        /// <summary>
        /// Determines the second color of the clock face gradient.
        /// </summary>
        [
        Category("Clock"),
        Description("Determines the second color of the clock face gradient."),
        DefaultValue(typeof(Color), "Black")
        ]
        public Color FaceColourLow
        {
            get { return this.faceColor2; }
            set { this.faceColor2 = value; Invalidate(); }
        }


        /// <summary>
        /// Determines whether the second hand casts a drop shadow for added realism.  
        /// </summary>
        [
        Category("Clock"),
        Description("Determines whether the second hand casts a drop shadow for added realism."),
        DefaultValue(true)
        ]
        public bool DrawSecondHandShadow
        {
            get { return this.drawSecondHandShadow; }
            set { this.drawSecondHandShadow = value; Invalidate(); }
        }


        /// <summary>
        /// Determines whether the hour hand casts a drop shadow for added realism.  
        /// </summary>
        [
        Category("Clock"),
        Description("Determines whether the hour hand casts a drop shadow for added realism."),
        ]
        public bool DrawHourHandShadow
        {
            get { return this.drawHourHandShadow; }
            set { this.drawHourHandShadow = value; Invalidate(); }
        }

        /// <summary>
        /// Determines whether the minute hand casts a drop shadow for added realism.  
        /// </summary>
        [
        Category("Clock"),
        Description("Determines whether the minute hand casts a drop shadow for added realism."),
        ]
        public bool DrawMinuteHandShadow
        {
            get { return this.drawMinuteHandShadow; }
            set { this.drawMinuteHandShadow = value; Invalidate(); }
        }

        /// <summary>
        /// Determines the first color of the rim gradient.
        /// </summary>
        [
        Category("Clock"),
        Description("Determines the first color of the rim gradient."),
        ]
        public Color RimColourHigh
        {
            get { return this.rimColor1; }
            set { this.rimColor1 = value; Invalidate(); }
        }

        /// <summary>
        /// Determines the second color of the rim face gradient.
        /// </summary>
        [
        Category("Clock"),
        Description("Determines the second color of the rim face gradient."),
        ]
        public Color RimColourLow
        {
            get { return this.rimColor2; }
            set { this.rimColor2 = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the direction of the Rim gradient.
        /// </summary>
        //TODO:replace this by degree
        [
        Category("Clock"),
        Description("Gets or sets the direction of the Rim gradient."),
        ]
        public LinearGradientMode RimGradientMode
        {
            get { return this.faceGradientMode; }
            set { this.faceGradientMode = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the direction of the Clock Face gradient.
        /// </summary>
        //TODO:replace this by degree
        [
        Category("Clock"),
        Description("Gets or sets the direction of the Clock Face gradient."),
        ]
        public LinearGradientMode FaceGradientMode
        {
            get { return this.rimGradientMode; }
            set { this.rimGradientMode = value; Invalidate(); }
        }

        /// <summary>
        /// Determines the Seconds hand end line shape.
        /// </summary>
        [
        Category("Clock"),
        Description("Determines the shape of second hand."),
        ]
        public LineCap SecondHandEndCap
        {
            get { return this.secLineEndCap; }
            set { this.secLineEndCap = value; Invalidate(); }
        }

        /// <summary>
        /// The System.DateTime structure which is used to display time.
        /// </summary>
        /// <example>
        /// <code>
        /// AnalogClock clock = new AnalogClock();
        /// clock.Time = DateTime.Now;
        /// </code>
        /// </example>
        /// <remarks>The clock face is updated every time the value of this property is changed.</remarks>
        [
        Category("Clock"),
        Description("The DateTime structure which the clock uses to display time."),
        Browsable(false)
        ]
        public DateTime Time
        {
            get { return this.time; }
            set { this.time = value; this.Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the Seconds Hand.
        /// </summary>
        [
        Category("Clock"),
        Description("Gets or sets the color of the Seconds Hand."),
        ]
        public Color SecondHandColour
        {
            get { return this.secondHandColor; }
            set { this.secondHandColor = value; Invalidate(); }
        }

        /// <summary>
        /// Sets or gets the color of the clock Numerals.
        /// </summary>
        /// <remarks>To change the numeral font use the <see cref=" Font "/> Property </remarks>
        [
        Category("Clock"),
        Description("Sets or gets the color of the clock Numerals."),
        ]
        public Color NumeralColour
        {
            get { return this.numeralColor; }
            set { this.numeralColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the Hour Hand.
        /// </summary>
        [
        Category("Clock"),
        Description("Gets or sets the color of the Hour Hand."),
        ]
        public Color HourHandColour
        {
            get { return this.hourHandColor; }
            set { this.hourHandColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the Minute Hand.
        /// </summary>
        [
        Category("Clock"),
        Description("Gets or sets the color of the Minute Hand."),
        ]
        public Color MinuteHandColour
        {
            get { return this.minHandColor; }
            set { this.minHandColor = value; Invalidate(); }
        }


        /// <summary>
        /// Determines whether the second Hand is shown. 
        /// </summary>
        /// 
        [
        Category("Clock"),
        Description("Determines whether the second Hand is shown."),
        ]
        public bool DrawSecondHand
        {
            get { return drawSecondHand; }
            set { this.drawSecondHand = value; Invalidate(); }
        }


        /// <summary>
        /// Determines whether the minute hand is shown. 
        /// </summary>
        /// 
        [
        Category("Clock"),
        Description("Determines whether the minute hand is shown."),
        ]
        public bool DrawMinuteHand
        {
            get { return drawMinuteHand; }
            set { this.drawMinuteHand = value; Invalidate(); }
        }

        /// <summary>
        /// Determines whether the hour Hand is shown. 
        /// </summary>
        /// 
        [
        Category("Clock"),
        Description("Determines whether the hour Hand is shown."),
        ]
        public bool DrawHourHand
        {
            get { return drawHourHand; }
            set { this.drawHourHand = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the drop shadow offset.
        /// </summary>
        /// 
        [
        Category("Clock"),
        Description("Gets or sets the drop shadow offset."),
        ]
        public Point DropShadowOffset
        {
            get { return dropShadowOffset; }
            set { this.dropShadowOffset = value; Invalidate(); }
        }





        #endregion



        private bool drawnumerals = true;
        private bool drawRim = true;
        private bool drawDropShadow = true;
        private bool drawSecondHandShadow = true;
        private bool drawMinuteHandShadow = true;
        private bool drawHourHandShadow = true;
        private bool drawSecondHand = true;
        private bool drawMinuteHand = true;
        private bool drawHourHand = true;

        private Color dropShadowColor = Color.Black;

        private Color secondHandDropShadowColor = Color.Gray;
        private Color hourHandDropShadowColor = Color.Gray;
        private Color minuteHandDropShadowColor = Color.Gray;

        private Color faceColor1 = Color.RoyalBlue;
        private Color faceColor2 = Color.SkyBlue;
        private Color rimColor1 = Color.RoyalBlue;
        private Color rimColor2 = Color.SkyBlue;
        private Color numeralColor = Color.WhiteSmoke;
        private Color secondHandColor = Color.Tomato;

        private LinearGradientBrush gb;
        private SmoothingMode smoothingMode = SmoothingMode.AntiAlias;
        private TextRenderingHint textRenderingHint = TextRenderingHint.AntiAlias;
        private LineCap secLineEndCap = LineCap.Round;
        //private Point dropShadowOffset = new Point(5,5);
        private LinearGradientMode faceGradientMode = LinearGradientMode.ForwardDiagonal;
        private LinearGradientMode rimGradientMode = LinearGradientMode.BackwardDiagonal;
        private DateTime time;

        private Color hourHandColor = Color.Gainsboro;
        private Color minHandColor = Color.WhiteSmoke;

        private float radius;
        private float midx;
        private float midy;
        private float y;
        private float x;
        private float fontsize;
        private Font textFont;
        private int min;
        private int hour;
        private double sec;
        private Image img;
        private float minuteAngle;
        private double secondAngle;
        private double hourAngle;

        private TickStyle secondHandTickStyle = TickStyle.Normal;
        private TickStyle minHandTickStyle = TickStyle.Normal;

        private Point dropShadowOffset;

        private void AnalogClock_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            DrawClock(e.Graphics);
        }


        private float GetX(float deg)
        { return (float)(radius * Math.Cos((Math.PI / 180) * deg)); }

        private float GetY(float deg)
        { return (float)(radius * Math.Sin((Math.PI / 180) * deg)); }


        private void AnalogClock_Resize(object sender, System.EventArgs e)
        {
            this.Width = this.Height;
            this.Width = this.Width;
            this.Invalidate();
        }

        /// <summary>
        /// Draws analog clock on the given GDI+ Drawing surface.
        /// </summary>
        /// <param name="e">The GDI+ Drawing surface.</param>
        private void DrawClock(Graphics e)
        {
            Graphics grfx = e;
            grfx.SmoothingMode = smoothingMode;
            grfx.TextRenderingHint = textRenderingHint;
            grfx.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            midx = this.ClientSize.Width / 2;
            midy = this.ClientSize.Height / 2;


            x = this.ClientSize.Width;
            y = this.ClientSize.Height;

            SolidBrush stringBrush = new SolidBrush(this.numeralColor);
            Pen pen = new Pen(stringBrush, 2);


            //Define rectangles inside which we will draw circles.

            Rectangle rect = new Rectangle(0 + 10, 0 + 10, (int)x - 20, (int)y - 20);
            Rectangle rectrim = new Rectangle(0 + 20, 0 + 20, (int)x - 40, (int)y - 40);

            Rectangle rectinner = new Rectangle(0 + 40, 0 + 40, (int)x - 80, (int)y - 80);
            Rectangle rectdropshadow = new Rectangle(0 + 10, 0 + 10, (int)x - 17, (int)y - 17);


            radius = rectinner.Width / 2;

            fontsize = radius / 5;
            textFont = this.Font;


            //Drop Shadow
            gb = new LinearGradientBrush(rect, Color.Transparent, dropShadowColor, LinearGradientMode.BackwardDiagonal);
            rectdropshadow.Offset(dropShadowOffset);
            if (this.drawDropShadow)
                grfx.FillEllipse(gb, rectdropshadow);


            //Face
            gb = new LinearGradientBrush(rect, rimColor1, rimColor2, faceGradientMode);
            if (this.drawRim)
                grfx.FillEllipse(gb, rect);




            //Rim
            gb = new LinearGradientBrush(rect, faceColor1, faceColor2, rimGradientMode);
            grfx.FillEllipse(gb, rectrim);










            //Define a circular clip region and draw the image inside it.
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rectrim);
            grfx.SetClip(path);

            if (this.img != null)
            {
                grfx.DrawImage(this.img, rect);
            }
            path.Dispose();

            //Reset clip region
            grfx.ResetClip();

            //			Triangular region
            //			pen.Width =2;
            //			grfx.DrawRectangle(pen, rect);
            //			grfx.DrawRectangle(pen, rectinner);
            //			grfx.DrawRectangle(pen, rectrim);
            //			grfx.DrawRectangle(pen, rectdropshadow);
            //			
            //			grfx.DrawRectangle(pen, rect);
            //			grfx.DrawEllipse(pen, rect);
            //			grfx.DrawEllipse(pen, rectinner);
            //			grfx.DrawEllipse(pen, rectrim);
            //			grfx.DrawEllipse(pen, rectdropshadow);
            //			


            //Center Point
            //grfx.DrawEllipse(pen, midx, midy ,2 ,2);

            //Define the midpoint of the control as the centre
            grfx.TranslateTransform(midx, midy);



            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;


            //Draw Numerals on the Face 
            int deg = 360 / 12;
            if (drawnumerals)
            {
                for (int i = 1; i <= 12; i++)
                {

                    grfx.DrawString(i.ToString(), textFont, stringBrush, -1 * GetX(i * deg + 90), -1 * GetY(i * deg + 90), format);
                }

            }
            format.Dispose();



            hour = time.Hour;
            min = time.Minute;
            Point centre = new Point(0, 0);

            //Draw Minute hand
            if (drawMinuteHand)
            {

                if (minHandTickStyle == TickStyle.Smooth)
                    minuteAngle = (float)(2.0 * Math.PI * (min + sec / 60.0) / 60.0);
                else
                    minuteAngle = (float)(2.0 * Math.PI * (min / 60.0));

                pen.EndCap = LineCap.Round;
                pen.StartCap = LineCap.RoundAnchor;
                pen.Width = (int)radius / 14;

                centre.Offset(2, 2);
                pen.Color = Color.Gray;
                Point minHandShadow = new Point((int)(radius * Math.Sin(minuteAngle)), (int)(-(radius) * Math.Cos(minuteAngle) + 2));


                if (this.drawMinuteHandShadow)
                {
                    pen.Color = minuteHandDropShadowColor;
                    grfx.DrawLine(pen, centre, minHandShadow);
                }

                centre.X = centre.Y = 0;
                pen.Color = minHandColor;
                Point minHand = new Point((int)(radius * Math.Sin(minuteAngle)), (int)(-(radius) * Math.Cos(minuteAngle)));
                grfx.DrawLine(pen, centre, minHand);
            }

            //--End Minute Hand


            // Draw Hour Hand
            if (drawHourHand)
            {
                hourAngle = 2.0 * Math.PI * (hour + min / 60.0) / 12.0;


                pen.EndCap = LineCap.Round;
                pen.StartCap = LineCap.RoundAnchor;
                pen.Width = (int)radius / 14;

                centre.X = centre.Y = 1;
                pen.Color = Color.Gray;
                Point hourHandShadow = new Point((int)((radius * Math.Sin(hourAngle) / 1.5) + 2), (int)((-(radius) * Math.Cos(hourAngle) / 1.5) + 2));

                if (this.drawHourHandShadow)
                {
                    pen.Color = hourHandDropShadowColor;
                    grfx.DrawLine(pen, centre, hourHandShadow);
                }

                centre.X = centre.Y = 0;
                pen.Color = hourHandColor;
                Point hourHand = new Point((int)(radius * Math.Sin(hourAngle) / 1.5), (int)(-(radius) * Math.Cos(hourAngle) / 1.5));
                grfx.DrawLine(pen, centre, hourHand);
            }
            //---End Hour Hand


            if (secondHandTickStyle == TickStyle.Smooth)
                sec = time.Second + (time.Millisecond * 0.001);
            else
                sec = time.Second;


            //Draw Sec Hand
            if (drawSecondHand)
            {
                int width = (int)radius / 25;
                pen.Width = width;
                pen.EndCap = secLineEndCap;
                pen.StartCap = LineCap.RoundAnchor;
                secondAngle = 2.0 * Math.PI * sec / 60.0;




                //Draw Second Hand Drop Shadow
                pen.Color = Color.DimGray;
                centre.X = 1;
                centre.Y = 1;

                Point secHand = new Point((int)(radius * Math.Sin(secondAngle)), (int)(-(radius) * Math.Cos(secondAngle)));
                Point secHandshadow = new Point((int)(radius * Math.Sin(secondAngle)), (int)(-(radius) * Math.Cos(secondAngle) + 2));



                if (drawSecondHandShadow)
                {
                    pen.Color = secondHandDropShadowColor;
                    grfx.DrawLine(pen, centre, secHandshadow);

                }

                centre.X = centre.Y = 0;
                pen.Color = secondHandColor;
                grfx.DrawLine(pen, centre, secHand);
            }
            pen.Dispose();


        }


    }
}