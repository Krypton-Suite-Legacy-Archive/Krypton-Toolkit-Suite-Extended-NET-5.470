using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Ribbon
{
    [ToolboxBitmap(typeof(Button))]
    public class RibbonRoundButton : Button
    {

        #region About Constructor
        public RibbonRoundButton()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor |
                          ControlStyles.UserPaint |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.Opaque, false);
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.Transparent;
            this.TextImageRelation = TextImageRelation.ImageAboveText;
            this.Text = "";
            this.Size = new Size(40, 40);

            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);
        }
        #endregion

        #region About Image Properties
        private Point _imgoffset = new Point(0, 0);
        public Point ImgOffset
        {
            get { return _imgoffset; }
            set { _imgoffset = value; this.Refresh(); }
        }

        private int _imgscale = 100;
        public int ImgScale
        {
            get { return _imgscale; }
            set { _imgscale = value; this.Refresh(); }
        }
        #endregion

        #region Colors
        private Color _baseColor = Color.FromArgb(209, 209, 209);
        private Color _strokeColor = Color.FromArgb(80, 80, 80);
        private Color _hoverColor = Color.FromArgb(255, 255, 255);
        private Color _onColor = Color.FromArgb(255, 255, 255);
        private Color _onColorlight = Color.FromArgb(255, 255, 255);
        private Color _pressColor = Color.FromArgb(255, 255, 255);

        public Color ColourBase
        {
            get { return _baseColor; }
            set
            {
                _baseColor = value;
                R0 = _baseColor.R;
                B0 = _baseColor.B;
                G0 = _baseColor.G;
            }
        }
        public Color ColourStroke
        {
            get { return _strokeColor; }
            set { _strokeColor = value; }
        }
        public Color ColourOver
        {
            get { return _hoverColor; }
            set { _hoverColor = value; }
        }
        public Color ColourOn
        {
            get { return _onColor; }
            set { _onColor = value; }
        }
        public Color ColourPress
        {
            get { return _pressColor; }
            set { _pressColor = value; }
        }
        public Color GetLightColor()
        {
            int _r0 = R0 + 127, _g0 = G0 + 196, _b0 = B0 + 111;
            if (_r0 > 255)
                _r0 = 255;
            if (_g0 > 255)
                _g0 = 255;
            if (_b0 > 255)
                _b0 = 255;

            return Color.FromArgb(_r0, _g0, _b0);

        }

        #endregion

        private int regionoffset = 1;
        protected override void OnPaint(PaintEventArgs pevent)
        {
            #region Variables & Conf
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.High;
            Rectangle r = new Rectangle(0, 0, this.Width - regionoffset, this.Height - regionoffset);
            #endregion

            #region Transform to Circle Region
            GraphicsPath path = new GraphicsPath();
            if (this.Size != null)
            {
                path.AddEllipse(0, 0, this.Width - 1, this.Height - 1);
                this.Region = new Region(path);

            }
            #endregion

            #region Paint
            FillShadow(g, r);
            FillStroke(g, r, 2, Color.FromArgb(R0, G0, B0));
            FillGradient(g, r, GetLightColor(), Color.FromArgb(R0, G0, B0));


            FillBeizer(g, r, 1, ColourOver, ColourBase);
            DrawImage(g, r, ImgOffset, ImgScale);
            DrawStroke(g, r, 1, ColourStroke, GetLightColor());


            #endregion

        }

        #region Paint Methods
        public void FillStroke(Graphics gr, Rectangle re, int stroke, Color incolor)
        {
            Rectangle _re = new Rectangle(stroke, stroke, this.Width - 2 * stroke - regionoffset, this.Height - 2 * stroke - regionoffset);
            gr.FillEllipse(new SolidBrush(incolor), _re);
        }

        public void DrawStroke(Graphics gr, Rectangle re, int stroke, Color incolor, Color outcolor)
        {
            Rectangle _re = new Rectangle(stroke, stroke, this.Width - 3 * stroke - regionoffset, this.Height - 3 * stroke - regionoffset);
            gr.DrawEllipse(new Pen(incolor, stroke), _re);
        }

        public void FillGradient(Graphics gr, Rectangle re, Color incolor, Color outcolor)
        {
            try
            {
                Rectangle _re = new Rectangle((int)(re.Width * -0.15), (int)(re.Height * 0.12), (int)(re.Width * 1.26) - regionoffset, (int)(re.Height * 0.875) - regionoffset);
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(_re);
                PathGradientBrush brush = new PathGradientBrush(path);
                brush.CenterPoint = new PointF(this.Width / 2, this.Height);
                float[] pos = new float[5];
                pos[0] = 0.0F; pos[1] = 0.2F; pos[2] = 0.3F; pos[3] = 0.7F; pos[4] = 1.0F;
                Color[] colors = new Color[5];
                colors[0] = Color.FromArgb(10, incolor);
                colors[1] = Color.FromArgb(10, incolor);
                colors[2] = Color.FromArgb(40, outcolor);
                colors[3] = incolor;
                colors[4] = incolor;

                ColorBlend mix = new ColorBlend();
                mix.Colors = colors;
                mix.Positions = pos;
                brush.InterpolationColors = mix;
                gr.FillPath(brush, path);
                brush.Dispose();
            }
            catch { }



        }

        public void DrawImage(Graphics gr, Rectangle re, Point off, int scale)
        {
            if (this.Image != null)
            {
                gr.DrawImage(this.Image, off.X, off.Y, re.Width * scale / 100, re.Height * scale / 100);
            }
        }

        public void FillBeizer(Graphics gr, Rectangle re, int stroke, Color incolor, Color basecolor)
        {
            Rectangle _re = new Rectangle(stroke, stroke, re.Width - 2 * stroke - regionoffset, re.Height - 2 * stroke - regionoffset);
            GraphicsPath path = new GraphicsPath();
            Point[] points = new Point[4];
            points[0] = new Point(re.Width / 2, 1);
            points[1] = new Point(2, re.Height / 2);
            points[2] = new Point(re.Width / 2, (int)(re.Height / 2 * 0.9));
            points[3] = new Point(re.Width - 2, re.Height / 2);
            path.AddClosedCurve(points, 1.16F);

            PathGradientBrush brush = new PathGradientBrush(path);
            brush.CenterPoint = new PointF(this.Width / 2, this.Height);
            float[] pos = new float[4];
            pos[0] = 0.0F; pos[1] = 0.018F; pos[2] = 0.15F; pos[3] = 1.0F;
            Color[] colors = new Color[4];
            colors[0] = Color.FromArgb(10, incolor);
            colors[1] = Color.FromArgb(200, incolor);
            colors[2] = Color.FromArgb(30, incolor);
            colors[3] = Color.FromArgb(10, incolor);

            ColorBlend mix = new ColorBlend();
            mix.Colors = colors;
            mix.Positions = pos;
            brush.InterpolationColors = mix;
            gr.CompositingQuality = CompositingQuality.HighQuality;
            gr.FillPath(brush, path);
            brush.Dispose();

        }

        public void FillShadow(Graphics gr, Rectangle re)
        {
            int stroke = 1;
            Color incolor = Color.Black;
            Rectangle _re = new Rectangle(stroke, stroke, re.Width - 2 * stroke, re.Height - 2 * stroke);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(1, 1, this.Width - 2, this.Height - 2, 270, 210);

            PathGradientBrush brush = new PathGradientBrush(path);
            brush.CenterPoint = new PointF(this.Width / 2, this.Height / 2);
            float[] pos = new float[4];
            pos[0] = 0.0F; pos[1] = 0.01F; pos[2] = 0.5F; pos[3] = 1.0F;
            Color[] colors = new Color[4];
            colors[0] = Color.FromArgb(0, incolor);
            colors[1] = Color.FromArgb(100, incolor);
            colors[2] = Color.FromArgb(0, incolor);
            colors[3] = Color.FromArgb(0, incolor);

            ColorBlend mix = new ColorBlend();
            mix.Colors = colors;
            mix.Positions = pos;
            brush.InterpolationColors = mix;
            gr.CompositingQuality = CompositingQuality.HighQuality;
            gr.FillPath(brush, path);
            brush.Dispose();
        }
        #endregion

        #region About Fading
        private Timer timer1 = new Timer();
        private int i_mode = 0; //0 Entering, 1 Leaving, 2 Pressing, 3 Up
        private int i_factor = 20;
        private int i_fR = 1;
        private int i_fG = 1;
        private int i_fB = 1;
        private int R0 = 0;
        private int G0 = 0;
        private int B0 = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region Entering
            if (i_mode == 0 | i_mode == 3)
            {
                if (System.Math.Abs(ColourOn.R - R0) > i_factor)
                { i_fR = i_factor; }
                else { i_fR = 1; }
                if (System.Math.Abs(ColourOn.G - G0) > i_factor)
                { i_fG = i_factor; }
                else { i_fG = 1; }
                if (System.Math.Abs(ColourOn.B - B0) > i_factor)
                { i_fB = i_factor; }
                else { i_fB = 1; }

                if (ColourOn.R < R0)
                {
                    R0 -= i_fR;
                }
                else if (ColourOn.R > R0)
                {
                    R0 += i_fR;
                }

                if (ColourOn.G < G0)
                {
                    G0 -= i_fG;
                }
                else if (ColourOn.G > G0)
                {
                    G0 += i_fG;
                }

                if (ColourOn.B < B0)
                {
                    B0 -= i_fB;
                }
                else if (ColourOn.B > B0)
                {
                    B0 += i_fB;
                }

                if (ColourOn == Color.FromArgb(R0, G0, B0))
                {
                    timer1.Stop();
                }
                else
                {
                    this.Refresh();
                }
            }
            #endregion

            #region Pressing
            if (i_mode == 2)
            {
                if (System.Math.Abs(ColourPress.R - R0) > i_factor)
                { i_fR = i_factor; }
                else { i_fR = 1; }
                if (System.Math.Abs(ColourPress.G - G0) > i_factor)
                { i_fG = i_factor; }
                else { i_fG = 1; }
                if (System.Math.Abs(ColourPress.B - B0) > i_factor)
                { i_fB = i_factor; }
                else { i_fB = 1; }

                if (ColourPress.R < R0)
                {
                    R0 -= i_fR;
                }
                else if (ColourPress.R > R0)
                {
                    R0 += i_fR;
                }

                if (ColourPress.G < G0)
                {
                    G0 -= i_fG;
                }
                else if (ColourPress.G > G0)
                {
                    G0 += i_fG;
                }

                if (ColourPress.B < B0)
                {
                    B0 -= i_fB;
                }
                else if (ColourPress.B > B0)
                {
                    B0 += i_fB;
                }

                if (ColourPress == Color.FromArgb(R0, G0, B0))
                {
                    timer1.Stop();
                }
                else
                {
                    this.Refresh();
                }
            }
            #endregion

            #region Leaving
            if (i_mode == 1)
            {
                if (System.Math.Abs(ColourBase.R - R0) < i_factor)
                { i_fR = 1; }
                else { i_fR = i_factor; }
                if (System.Math.Abs(ColourBase.G - G0) < i_factor)
                { i_fG = 1; }
                else { i_fG = i_factor; }
                if (System.Math.Abs(ColourBase.B - B0) < i_factor)
                { i_fB = 1; }
                else { i_fB = i_factor; }

                if (ColourBase.R < R0)
                {
                    R0 -= i_fR;
                }
                else if (ColourBase.R > R0)
                {
                    R0 += i_fR;
                }
                if (ColourBase.G < G0)
                {
                    G0 -= i_fG;
                }
                else if (ColourBase.G > G0)
                {
                    G0 += i_fG;
                }
                if (ColourBase.B < B0)
                {
                    B0 -= i_fB;
                }
                else if (ColourBase.B > B0)
                {
                    B0 += i_fB;
                }

                if (ColourBase == Color.FromArgb(R0, G0, B0))
                {
                    timer1.Stop();
                }
                else
                {
                    this.Refresh();
                }

            }
            #endregion

        }
        #endregion

        #region About Mouse Events

        protected override void OnMouseEnter(EventArgs e)
        {
            i_mode = 0;
            timer1.Start();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            timer1.Stop(); i_mode = 2;
            timer1.Start();
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            timer1.Stop(); i_mode = 3;
            timer1.Start();
            base.OnMouseUp(mevent);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            i_mode = 1;
            timer1.Start();
            base.OnMouseLeave(e);
        }

        #endregion


    }
}