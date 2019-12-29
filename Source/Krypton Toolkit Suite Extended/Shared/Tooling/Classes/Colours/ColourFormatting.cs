#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;
using System.Drawing;

namespace Classes.Colours
{
    public class ColourFormatting
    {
        #region Formatting Methods
        public static string FormatColourAsString(Color chosenColour)
        {
            return chosenColour.ToArgb().ToString();
        }

        public static string FormatColourAsRGBString(Color chosenColour)
        {
            return $"Red: { chosenColour.R }, Green: { chosenColour.G }, Blue: { chosenColour.B }";
        }

        public static Color FormatStringColourAsColour(string colourString)
        {
            Color outputColour = Color.FromArgb(Convert.ToInt32(colourString));

            return outputColour;
        }
        #endregion
    }
}