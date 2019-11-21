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
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls
{
    public class KryptonToolStripStatusLabelExtended : ToolStripStatusLabel
    {
        #region Variables
        KryptonPalette _palette;

        Color _textColour, _gradientBackColour1, _gradientBackColour2;

        Font _textTypeface;

        IPalette _kPalette;

        IRenderer _kRenderer;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the text colour.
        /// </summary>
        /// <value>
        /// The text colour.
        /// </value>
        public Color TextColour
        {
            get
            {
                return _textColour;
            }

            set
            {
                _textColour = value;

                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the first gradient back colour.
        /// </summary>
        /// <value>
        /// The gradient first back colour.
        /// </value>
        public Color GradientBackColour1
        {
            get
            {
                return _gradientBackColour1;
            }

            set
            {
                _gradientBackColour1 = value;

                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the second gradient back colour.
        /// </summary>
        /// <value>
        /// The second gradient back colour.
        /// </value>
        public Color GradientBackColour2
        {
            get
            {
                return _gradientBackColour2;
            }

            set
            {
                _gradientBackColour2 = value;

                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the palette.
        /// </summary>
        /// <value>
        /// The palette.
        /// </value>
        public KryptonPalette Palette
        {
            get
            {
                return _palette;
            }

            set
            {
                _palette = value;
            }
        }

        /// <summary>
        /// Gets or sets the text typeface.
        /// </summary>
        /// <value>
        /// The text typeface.
        /// </value>
        public Font TextTypeface
        {
            get
            {
                return _textTypeface;
            }

            set
            {
                _textTypeface = value;

                Invalidate();
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="KryptonToolStripStatusLabelExtended"/> class.
        /// </summary>
        public KryptonToolStripStatusLabelExtended()
        {
            Palette = new KryptonPalette();

            _kPalette = KryptonManager.CurrentGlobalPalette;

            if (_kPalette != null)
            {
                _kPalette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
            }

            KryptonManager.GlobalPaletteChanged += new EventHandler(OnGlobalPaletteChanged);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KryptonToolStripStatusLabelExtended"/> class.
        /// </summary>
        /// <param name="kryptonPalette">The krypton palette.</param>
        /// <param name="textColour">The text colour.</param>
        /// <param name="gradientBackColour1">The gradient back colour1.</param>
        /// <param name="gradientBackColour2">The gradient back colour2.</param>
        public KryptonToolStripStatusLabelExtended(KryptonPalette kryptonPalette, Color textColour, Color gradientBackColour1, Color gradientBackColour2)
        {
            Palette = kryptonPalette;

            TextColour = textColour;

            GradientBackColour1 = gradientBackColour1;

            GradientBackColour2 = gradientBackColour2;

            _kPalette = KryptonManager.CurrentGlobalPalette;

            if (_kPalette != null)
            {
                _kPalette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
            }

            KryptonManager.GlobalPaletteChanged += new EventHandler(OnGlobalPaletteChanged);
        }
        #endregion

        #region Overrides        
        /// <summary>
        /// Gets or sets the background color for the item.
        /// </summary>
        public override Color BackColor { get => new Color(); set {; } }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_kPalette != null)
            {
                PaletteState state = Enabled ? PaletteState.Normal : PaletteState.Disabled;

                GradientBackColour1 = _kPalette.GetBackColor1(PaletteBackStyle.ButtonStandalone, state);

                GradientBackColour2 = _kPalette.GetBackColor2(PaletteBackStyle.ButtonStandalone, state);

                TextColour = _kPalette.GetContentShortTextColor1(PaletteContentStyle.ButtonStandalone, state);

                TextTypeface = _kPalette.GetContentShortTextFont(PaletteContentStyle.ButtonStandalone, state);

                using (SolidBrush brush = new SolidBrush(GradientBackColour1))
                {
                    e.Graphics.FillRectangle(brush, e.ClipRectangle);
                }
            }

            base.OnPaint(e);
        }

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.ToolStripItem" /> and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing"><see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_kPalette != null)
                {
                    _kPalette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

                    _kPalette = null;
                }

                KryptonManager.GlobalPaletteChanged -= new EventHandler(OnGlobalPaletteChanged);
            }

            base.Dispose(disposing);
        }
        #endregion

        #region Events
        /// <summary>
        /// Called when [palette paint].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="PaletteLayoutEventArgs"/> instance containing the event data.</param>
        private void OnPalettePaint(object sender, PaletteLayoutEventArgs e)
        {
            Invalidate();
        }

        /// <summary>
        /// Called when [global palette changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnGlobalPaletteChanged(object sender, EventArgs e)
        {
            if (_kPalette != null)
            {
                _kPalette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
            }

            _kPalette = KryptonManager.CurrentGlobalPalette;

            if (_kPalette != null)
            {
                _kPalette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
            }

            Invalidate();
        }
        #endregion
    }
}