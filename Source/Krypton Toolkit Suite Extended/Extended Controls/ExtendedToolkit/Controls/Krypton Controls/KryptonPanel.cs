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
    public class KryptonPanel : Panel
    {
        private static IPalette _palette;
        private static PaletteRedirect _paletteRedirect;
        private int _borderWidth = 0;
        [Browsable(true), Category("Appearance-Extended")]
        public int BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value; Invalidate(); }
        }

        private Color _borderColor = Color.Gray;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(true), Category("Appearance-Extended")]
        public Color BorderColour
        {
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
        }

        private Color _gradientStartColor = Color.White;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(true), Category("Appearance-Extended")]
        public Color GradientStartColour
        {
            get { return _gradientStartColor; }
            set { _gradientStartColor = value; Invalidate(); }
        }

        private Color _gradientEndColor = Color.Gray;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(true), Category("Appearance-Extended")]
        public Color GradientEndColour
        {
            get { return _gradientEndColor; }
            set { _gradientEndColor = value; Invalidate(); }
        }

        private Color _gradientSolidColor = Color.Gray;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(true), Category("Appearance-Extended")]
        public Color GradientSolidColour
        {
            get { return _gradientSolidColor; }
            set { _gradientSolidColor = value; Invalidate(); }
        }

        private Boolean _persistentColors = false;
        [Browsable(true), Category("Appearance-Extended")]
        public Boolean PersistentColours
        {
            get { return _persistentColors; }
            set { _persistentColors = value; Invalidate(); }
        }

        private LinearGradientMode _gradientDirection = LinearGradientMode.Vertical;
        [Browsable(true), Category("Appearance-Extended")]
        public LinearGradientMode GradientDirection
        {
            get { return _gradientDirection; }
            set { _gradientDirection = value; Invalidate(); }
        }

        private Boolean _gradientToogleColors = false;
        [Browsable(true), Category("Appearance-Extended")]
        public Boolean GradientToogleColours
        {
            get { return _gradientToogleColors; }
            set { _gradientToogleColors = value; Invalidate(); }
        }

        private Boolean _gradientUseBlend = false;
        [Browsable(true), Category("Appearance-Extended")]
        public Boolean GradientUseBlend
        {
            get { return _gradientUseBlend; }
            set { _gradientUseBlend = value; Invalidate(); }
        }

        private Boolean _gradientUseSolid = true;
        [Browsable(true), Category("Appearance-Extended")]
        public Boolean GradientUseSolid
        {
            get { return _gradientUseSolid; }
            set { _gradientUseSolid = value; Invalidate(); }
        }

        public KryptonPanel()
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
        private void InitColors()
        {
            _gradientSolidColor = _palette.ColorTable.MenuStripGradientEnd;
            _gradientStartColor = _palette.ColorTable.StatusStripGradientBegin;
            _gradientEndColor = _palette.ColorTable.StatusStripGradientEnd;
            _borderColor = _palette.ColorTable.ToolStripGradientEnd;
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
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height); // e.ClipRectangle;
            Rectangle borderrect = new Rectangle(0, 0, this.Width - 1, this.Height - 1); // e.ClipRectangle;

            // Draw background
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

            if (_gradientUseSolid == false)
            {
                if (_gradientUseBlend == false)
                {
                    using (LinearGradientBrush brush = new LinearGradientBrush(rect,
                    gradStartColor,
                    gradEndColor,
                    GradientDirection))
                    {
                        e.Graphics.FillRectangle(brush, rect);
                    }
                }
                else
                {
                    DrawingMethods.DrawGradient(e.Graphics, rect, gradStartColor, gradEndColor, 90F, false, Color.White, 0);
                }
            }
            else
            //Solid Color
            {
                using (Brush brush = new SolidBrush(GradientSolidColour))
                {
                    e.Graphics.FillRectangle(brush, rect);
                }
            }

            if (this._borderWidth > 0)
            {
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(180, this._borderColor), _borderWidth), borderrect);
            }

        }
    }

}