using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Drawing;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    [ToolboxBitmap(typeof(System.Windows.Forms.Label))]
    public class KryptonLabel : System.Windows.Forms.Label
    {
        private IPalette _palette;
        private PaletteRedirect _paletteRedirect;
        private Font _startingFont;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override System.Drawing.Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
            }
        }

        private Boolean _useAlternateForeColor = false;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("false")]
        public Boolean UseAlternateForeColour
        {
            get { return _useAlternateForeColor; }
            set { _useAlternateForeColor = value; InitColors(); Invalidate(); }
        }

        private Boolean _useKryptonFont = false;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("false")]
        public Boolean UseKryptonFont
        {
            get { return _useKryptonFont; }
            set { _useKryptonFont = value; InitColors(); Invalidate(); }
        }

        public KryptonLabel()
        {

            //store default font
            _startingFont = base.Font;
            // add Palette Handler
            if (_palette != null)
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            KryptonManager.GlobalPaletteChanged += new EventHandler(OnGlobalPaletteChanged);

            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect = new PaletteRedirect(_palette);

            InitColors();

        }

        private void InitColors()
        {
            //base.ForeColor = _palette.ColorTable.MenuStripText;

            //set ForeColor
            if (!_useAlternateForeColor)
            {
                base.ForeColor = _palette.ColorTable.MenuStripText;
            }
            else
            {
                base.ForeColor = _palette.ColorTable.MenuItemText;
            }

            //set Font
            if (_useKryptonFont)
            {
                base.Font = _palette.GetContentShortTextFont(PaletteContentStyle.LabelNormalControl, PaletteState.Normal);
            }
            else
            {
                base.Font = _startingFont;
            }
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