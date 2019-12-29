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
using System.Globalization;
using System.Windows.Forms;

namespace ExtendedControls.Base.Code.Colours
{
    public static class ColourMethods
    {
        /// <summary>
        /// Colours to hexadecimal.
        /// </summary>
        /// <param name="colour">The colour.</param>
        /// <returns></returns>
        public static string ColourToHexadecimal(this Color colour) => $"{colour.R:X2}{colour.G:X2}{colour.B:X2}";

        /// <summary>
        /// Colours from hexadecimal.
        /// </summary>
        /// <param name="hexadecimalCode">The hexadecimal code.</param>
        /// <returns></returns>
        public static Color ColourFromHexadecimal(string hexadecimalCode) => ColorTranslator.FromHtml($"#{ hexadecimalCode }");

        /// <summary>
        /// Gets the colour from hexadecimal.
        /// </summary>
        /// <param name="hexadecimalCode">The hexadecimal code.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">Colour not valid!</exception>
        public static Color GetColourFromHexadecimal(string hexadecimalCode)
        {
            if (hexadecimalCode.StartsWith("#"))
            {
                hexadecimalCode = hexadecimalCode.Substring(1);
            }

            if (hexadecimalCode.Length > 6) throw new System.Exception("Colour not valid!");

            return Color.FromArgb(int.Parse(hexadecimalCode.Substring(0, 2), NumberStyles.HexNumber), int.Parse(hexadecimalCode.Substring(2, 2), NumberStyles.HexNumber), int.Parse(hexadecimalCode.Substring(4, 2), NumberStyles.HexNumber));
        }

        /// <summary>
        /// Displays the colour.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="colour">The colour.</param>
        public static void DisplayColour(Control control, Color colour) => control.BackColor = colour;

        /// <summary>
        /// Displays the colour.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="alpha">The alpha.</param>
        /// <param name="red">The red.</param>
        /// <param name="green">The green.</param>
        /// <param name="blue">The blue.</param>
        public static void DisplayColour(Control control, int alpha, int red, int green, int blue) => control.BackColor = Color.FromArgb(alpha, red, green, blue);

        /// <summary>
        /// Displays the colour.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="red">The red.</param>
        /// <param name="green">The green.</param>
        /// <param name="blue">The blue.</param>
        public static void DisplayColour(Control control, int red, int green, int blue) => control.BackColor = Color.FromArgb(red, green, blue);

        /// <summary>
        /// Displays the colour.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="alpha">The alpha.</param>
        /// <param name="red">The red.</param>
        /// <param name="green">The green.</param>
        /// <param name="blue">The blue.</param>
        public static void DisplayColour(Control control, string alpha, string red, string green, string blue) => control.BackColor = Color.FromArgb(Convert.ToInt32(alpha), Convert.ToInt32(red), Convert.ToInt32(green), Convert.ToInt32(blue));

        /// <summary>
        /// Displays the colour.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="red">The red.</param>
        /// <param name="green">The green.</param>
        /// <param name="blue">The blue.</param>
        public static void DisplayColour(Control control, string red, string green, string blue) => control.BackColor = Color.FromArgb(Convert.ToInt32(red), Convert.ToInt32(green), Convert.ToInt32(blue));
    }
}