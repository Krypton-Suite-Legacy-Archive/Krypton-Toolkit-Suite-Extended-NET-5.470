#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;

namespace PaletteCreator.UX
{
    public partial class RibbonChromeForm : KryptonForm
    {
        public RibbonChromeForm()
        {
            InitializeComponent();
        }

        #region Public
        public KryptonPalette OverridePalette
        {
            set
            {
                Palette = value;

                kryptonPanel1.Palette = value;

                kryptonRibbon1.Palette = value;
            }
        }
        #endregion
    }
}
