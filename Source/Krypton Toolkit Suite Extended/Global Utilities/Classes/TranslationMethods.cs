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

namespace Core.Classes
{
    /// <summary>
    /// Some translation methods.
    /// </summary>
    public class TranslationMethods
    {
        #region Constructors        
        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationMethods"/> class.
        /// </summary>
        public TranslationMethods()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Parses the boolean.
        /// </summary>
        /// <param name="booleanInput">The boolean input.</param>
        /// <returns></returns>
        public bool ParseBoolean(string booleanInput)
        {
            return bool.Parse(booleanInput.ToLower());
        }

        /// <summary>
        /// Parses the date time.
        /// </summary>
        /// <param name="dateTimeInput">The date time input.</param>
        /// <returns></returns>
        public DateTime ParseDateTime(string dateTimeInput)
        {
            return DateTime.Parse(dateTimeInput);
        }

        /// <summary>
        /// Parses the long.
        /// </summary>
        /// <param name="longInput">The long input.</param>
        /// <returns></returns>
        public long ParseLong(string longInput)
        {
            return long.Parse(longInput);
        }

        /// <summary>
        /// Parses the integer.
        /// </summary>
        /// <param name="integerInput">The integer input.</param>
        /// <returns></returns>
        public int ParseInteger(string integerInput)
        {
            return int.Parse(integerInput);
        }

        /// <summary>
        /// Parses the version.
        /// </summary>
        /// <param name="versionInput">The version input.</param>
        /// <returns></returns>
        public Version ParseVersion(string versionInput)
        {
            return Version.Parse(versionInput);
        }

        /// <summary>
        /// Translates the colour to ARGB.
        /// </summary>
        /// <param name="colour">The colour.</param>
        /// <returns></returns>
        public static string TranslateColourToARGB(Color colour)
        {
            return $"ARGB: ({ colour.A }, { colour.R }, { colour.G }, { colour.B })";
        }

        /// <summary>
        /// Translates the colour to RGB.
        /// </summary>
        /// <param name="colour">The colour.</param>
        /// <returns></returns>
        public static string TranslateColourToRGB(Color colour)
        {
            return $"RGB: ({ colour.R }, { colour.G }, { colour.B })";
        }

        /// <summary>
        /// Translates the colour to hexadecinal.
        /// </summary>
        /// <param name="colour">The colour.</param>
        /// <returns></returns>
        public static string TranslateColourToHexadecimal(Color colour)
        {
            return $"Hexadecimal Value: #{ ConvertRGBToHexadecimal(Convert.ToInt32(colour.R), Convert.ToInt32(colour.G), Convert.ToInt32(colour.B)).ToUpper() }";
        }

        /// <summary>
        /// Gets the colour brightness.
        /// </summary>
        /// <param name="colour">The colour.</param>
        /// <returns></returns>
        public static string GetColourBrightness(Color colour)
        {
            return $"Brightness: { Convert.ToInt32(colour.GetBrightness()).ToString() }";
        }

        /// <summary>
        /// Gets the colour hue.
        /// </summary>
        /// <param name="colour">The colour.</param>
        /// <returns></returns>
        public static string GetColourHue(Color colour)
        {
            return $"Hue: { colour.GetHue().ToString() }";
        }

        /// <summary>
        /// Gets the colour saturation.
        /// </summary>
        /// <param name="colour">The colour.</param>
        /// <returns></returns>
        public static string GetColourSaturation(Color colour)
        {
            return $"Saturation: { colour.GetSaturation().ToString() }";
        }

        /// <summary>
        /// Converts the RGB to hexadecimal.
        /// </summary>
        /// <param name="red">The red.</param>
        /// <param name="green">The green.</param>
        /// <param name="blue">The blue.</param>
        /// <returns></returns>
        private static string ConvertRGBToHexadecimal(int red, int green, int blue)
        {
            return ColorTranslator.FromHtml(String.Format("#{0:X2}{1:X2}{2:X2}", red, green, blue)).Name.Remove(0, 1);
        }

        public static string GetKnownColourName(Color colour)
        {
            return colour.ToKnownColor().ToString();
        }

        public static string GetColourName(Color colour)
        {
            return colour.Name;
        }
        #endregion
    }
}