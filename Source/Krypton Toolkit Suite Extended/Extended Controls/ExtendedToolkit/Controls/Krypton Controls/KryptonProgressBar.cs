using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    [System.Drawing.ToolboxBitmap(typeof(ProgressBar)), ToolboxItem(true)]
    public class KryptonProgressBar : StandardControls.Common.ProgressBar
    {
        private IPalette _palette;
        private PaletteRedirect _paletteRedirect;

        #region ... Constructor ...
        public KryptonProgressBar()
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

            InitColours();


        }
        #endregion

        private void InitColours()
        {
            this.StartColour = _palette.ColorTable.ButtonSelectedGradientEnd;
            this.EndColour = _palette.ColorTable.ButtonSelectedGradientEnd;
            this.ForeColor = _palette.ColorTable.MenuItemText;
            this.Font = _palette.ColorTable.MenuStripFont;
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

                InitColours();

            }

            Invalidate();
        }

        //Kripton Palette Events
        private void OnPalettePaint(object sender, PaletteLayoutEventArgs e)
        {
            Invalidate();
        }
        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // KryptonProgressBar
            // 
            this.Name = "KryptonProgressBar";
            this.ResumeLayout(false);

        }

    }
}