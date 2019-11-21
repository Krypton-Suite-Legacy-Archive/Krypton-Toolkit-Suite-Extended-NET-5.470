#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System.Drawing;

namespace Persistence.Classes.Colours
{
    public class ColourManager
    {
        #region Constructors
        public ColourManager()
        {

        }
        #endregion

        #region Methods
        public static Color ChangeColour(decimal alphaValue, decimal redValue, decimal greenValue, decimal blueValue)
        {
            Color outputColour = Color.FromArgb((int)alphaValue, (int)redValue, (int)greenValue, (int)blueValue);

            return outputColour;
        }
        #endregion
    }
}