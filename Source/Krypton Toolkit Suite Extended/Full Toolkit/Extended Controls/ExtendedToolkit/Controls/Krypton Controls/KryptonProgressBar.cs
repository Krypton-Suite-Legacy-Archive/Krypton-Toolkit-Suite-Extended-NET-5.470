#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    [ToolboxBitmap(typeof(ProgressBar)), ToolboxItem(true), ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class KryptonProgressBar : StandardControls.Common.ProgressBar
    {
        private Color _foreColour = Color.Empty;
        private IPalette _palette;
        private PaletteRedirect _paletteRedirect;

        public Color ForeColour { get => _foreColour; set { _foreColour = value; Invalidate(); } }

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

            if (ForeColour != Color.Empty || ForeColour != Color.Transparent)
            {
                ForeColor = ForeColour;
            }
            else
            {
                ForeColor = _palette.ColorTable.MenuItemText;
            }

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