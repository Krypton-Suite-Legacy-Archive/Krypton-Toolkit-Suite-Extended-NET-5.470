#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using Core.UX;
using ExtendedControls.ExtendedToolkit.Controls;

namespace PaletteExplorer.Classes
{
    public class PaletteUtilities
    {
        #region Constructors
        public PaletteUtilities()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Uses the selected colour.
        /// </summary>
        /// <param name="colourControl">The colour control.</param>
        /// <param name="goStraightToPaletteShader">if set to <c>true</c> [go straight to palette shader].</param>
        public static void UseSelectedColour(CircularPictureBox colourControl, bool goStraightToPaletteShader = false)
        {
            if (goStraightToPaletteShader)
            {
                PaletteColourCreator colourCreator = new PaletteColourCreator(colourControl.BackColor);

                colourCreator.Show();
            }
            else
            {
                ColourMixer mixer = new ColourMixer(colourControl.BackColor);

                mixer.Show();
            }
        }
        #endregion
    }
}