#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.Controls.Drawing.Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    [ToolboxBitmap(typeof(Panel))]
    public class KryptonPanelEx : Panel
    {
        private static IPalette _palette;
        private static PaletteRedirect _paletteRedirect;
        private int _borderWidth = 1;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue(1)]
        public int BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value; Invalidate(); }
        }

        private int _shadowOffSet = 0;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue(0)]
        public int ShadowOffSet
        {
            get
            {
                return _shadowOffSet;
            }
            set { _shadowOffSet = Math.Abs(value); Invalidate(); }
        }

        private int _roundCornerRadius = 1;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue(1)]
        public int RoundCornerRadius
        {
            get { return _roundCornerRadius; }
            set
            {
                if (value <= 0) // to void errors set minimun = 1
                {
                    _roundCornerRadius = 1;
                }
                else
                {
                    _roundCornerRadius = Math.Abs(value);
                }

                Invalidate();
            }
        }

        private Image _image;
        [Browsable(true), Category("Appearance-Extended")]
        public Image Image
        {
            get { return _image; }
            set { _image = value; Invalidate(); }
        }

        private Point _imageLocation = new Point(4, 4);
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("4,4")]
        public Point ImageLocation
        {
            get { return _imageLocation; }
            set { _imageLocation = value; Invalidate(); }
        }

        private Color _borderColor = Color.Gray;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("Color.Gray")]
        public Color BorderColour
        {
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
        }

        private Color _gradientStartColor = Color.White;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("Color.White")]
        public Color GradientStartColour
        {
            get { return _gradientStartColor; }
            set { _gradientStartColor = value; Invalidate(); }
        }

        private Color _gradientEndColor = Color.Gray;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("Color.Gray")]
        public Color GradientEndColour
        {
            get { return _gradientEndColor; }
            set { _gradientEndColor = value; Invalidate(); }
        }

        private Boolean _persistentColors = false;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("False")]
        public Boolean PersistentColours
        {
            get { return _persistentColors; }
            set { _persistentColors = value; }
        }

        private LinearGradientMode _gradientDirection = LinearGradientMode.Vertical;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("Vertical")]
        public LinearGradientMode GradientDirection
        {
            get { return _gradientDirection; }
            set { _gradientDirection = value; Invalidate(); }
        }

        private Boolean _gradientToogleColors = false;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("False")]
        public Boolean GradientToogleColours
        {
            get { return _gradientToogleColors; }
            set { _gradientToogleColors = value; }
        }

        private Boolean _gradientUseBlend = false;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("False")]
        public Boolean GradientUseBlend
        {
            get { return _gradientUseBlend; }
            set { _gradientUseBlend = value; }
        }


        public KryptonPanelEx()
        {
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            UpdateStyles();

            // add Palette Handler
            if (_palette != null)
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            KryptonManager.GlobalPaletteChanged += new EventHandler(OnGlobalPaletteChanged);

            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect = new PaletteRedirect(_palette);

            //init values
            InitColors();
        }


        private void OnGlobalPaletteChanged(object sender, EventArgs e)
        {

            if (_palette != null)
                _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);


            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect.Target = _palette;


            if (_palette != null)
            {
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
                //repaint with new values

                if (_persistentColors == false)
                {
                    InitColors();
                }
            }

            Invalidate();
        }

        private void InitColors()
        {
            _gradientStartColor = _palette.ColorTable.StatusStripGradientBegin;
            _gradientEndColor = _palette.ColorTable.StatusStripGradientEnd; ;
            _borderColor = _palette.ColorTable.ToolStripGradientEnd;
        }


        private void OnPalettePaint(object sender, PaletteLayoutEventArgs e)
        {
            Invalidate();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {

                if (_palette != null)
                {
                    _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
                    _palette = null;
                }


                KryptonManager.GlobalPaletteChanged -= new EventHandler(OnGlobalPaletteChanged);
            }

            base.Dispose(disposing);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            int tmpShadowOffSet = Math.Min(Math.Min(_shadowOffSet, this.Width - 2), this.Height - 2);
            int tmpSoundCornerRadius = Math.Min(Math.Min(_roundCornerRadius, this.Width - 2), this.Height - 2);
            if (this.Width > 1 && this.Height > 1)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(0, 0, this.Width - tmpShadowOffSet - 1,
                                   this.Height - tmpShadowOffSet - 1);

                Rectangle rectShadow = new Rectangle(tmpShadowOffSet, tmpShadowOffSet,
                                   this.Width - tmpShadowOffSet - 1, this.Height - tmpShadowOffSet - 1);

                GraphicsPath graphPathShadow = GetRoundPath(rectShadow, tmpSoundCornerRadius);
                GraphicsPath graphPath = GetRoundPath(rect, tmpSoundCornerRadius);

                if (tmpSoundCornerRadius > 0)
                {
                    using (PathGradientBrush gBrush = new PathGradientBrush(graphPathShadow))
                    {
                        gBrush.WrapMode = WrapMode.Clamp;
                        ColorBlend colorBlend = new ColorBlend(3);
                        colorBlend.Colors = new Color[]{Color.Transparent,
                Color.FromArgb(180, Color.DimGray),
                Color.FromArgb(180, Color.DimGray)};

                        colorBlend.Positions = new float[] { 0f, .1f, 1f };

                        gBrush.InterpolationColors = colorBlend;
                        e.Graphics.FillPath(gBrush, graphPathShadow);
                    }
                }

                // Draw backgroup
                Color gradStartColor;
                Color gradEndColor;
                if (_gradientToogleColors == false)
                {
                    gradStartColor = _gradientStartColor;
                    gradEndColor = _gradientEndColor;
                }
                else
                {
                    gradStartColor = _gradientEndColor;
                    gradEndColor = _gradientStartColor;
                }


                if (_gradientUseBlend == false)
                {
                    using (LinearGradientBrush brush = new LinearGradientBrush(rect,
                    gradStartColor,
                    gradEndColor,
                    GradientDirection))
                    {
                        e.Graphics.FillPath(brush, graphPath);
                    }
                }
                else
                {
                    DrawingMethods.DrawGradient(e.Graphics, rect, gradStartColor, gradEndColor, 90F, false, Color.White, 0);
                }

                if (this._borderWidth > 0)
                {
                    e.Graphics.DrawPath(new Pen(Color.FromArgb(180, this._borderColor), _borderWidth), graphPath);
                }
                // Draw Image
                if (_image != null)
                {
                    e.Graphics.DrawImageUnscaled(_image, _imageLocation);
                }
            }
        }


        public static GraphicsPath GetRoundPath(Rectangle r, int depth)
        {
            GraphicsPath graphPath = new GraphicsPath();

            graphPath.AddArc(r.X, r.Y, depth, depth, 180, 90);
            graphPath.AddArc(r.X + r.Width - depth, r.Y, depth, depth, 270, 90);
            graphPath.AddArc(r.X + r.Width - depth, r.Y + r.Height - depth, depth, depth, 0, 90);
            graphPath.AddArc(r.X, r.Y + r.Height - depth, depth, depth, 90, 90);
            graphPath.AddLine(r.X, r.Y + r.Height - depth, r.X, r.Y + depth / 2);
            return graphPath;
        }

        /*protected override void OnPaintBackground(PaintEventArgs e)
        {
            //base.OnPaintBackground(e);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(83,83,83)),e.ClipRectangle);
           // Rendering.DrawingMethods.DrawGlassBackGround(ClientRectangle, e.Graphics);
        }*/
    }
}