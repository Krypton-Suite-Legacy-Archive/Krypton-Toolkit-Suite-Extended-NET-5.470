using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using ComponentFactory.Krypton.Toolkit;

namespace ExtendedToolkit
{
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.PropertyGrid))]
    public class KryptonPropertyGrid : PropertyGrid
    {
        private IPalette _palette;
        private PaletteRedirect _paletteRedirect;

        #region ... Properties...
        Color _gradientMiddleColor = Color.Gray;
        [Browsable(true), Category("Appearance-Extended")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DefaultValue("Color.Gray")]
        public Color GradientMiddleColor
        {
            get { return _gradientMiddleColor; }
            set { _gradientMiddleColor = value; Invalidate(); }
        }
        #endregion

        #region ... Constructor ...
        public KryptonPropertyGrid()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            UpdateStyles();

            // add Palette Handler
            if (_palette != null)
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            KryptonManager.GlobalPaletteChanged += new EventHandler(OnGlobalPaletteChanged);

            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect = new PaletteRedirect(_palette);

            InitColors();


        }
        #endregion

        private void InitColors()
        {
            this.ToolStripRenderer = ToolStripManager.Renderer;
            _gradientMiddleColor = _palette.ColorTable.ToolStripGradientMiddle;
            this.HelpBackColor = _palette.ColorTable.MenuStripGradientBegin;
            this.HelpForeColor = _palette.ColorTable.StatusStripText;
            this.LineColor = _palette.ColorTable.ToolStripGradientMiddle;
            this.CategoryForeColor = _palette.ColorTable.StatusStripText;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(new SolidBrush(_gradientMiddleColor), e.ClipRectangle);
            //
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            //e.Graphics.FillRectangle(new SolidBrush(_gradientMiddleColor), e.ClipRectangle);
            //
        }

        #region ... Krypton ...

        //Kripton Palette Events
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

                InitColors();

            }

            Invalidate();
        }

        //Kripton Palette Events
        private void OnPalettePaint(object sender, PaletteLayoutEventArgs e)
        {
            Invalidate();
        }
        #endregion
    }
}
