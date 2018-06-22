using System;
using System.Drawing;
using System.Globalization;

namespace Tooling.Classes.Other
{
    public class ConversionMethods
    {
        #region Variables
        int _red, _green, _blue;

        double _alpha;
        #endregion

        #region Properties
        public int Red
        {
            get
            {
                return _red;
            }

            set
            {
                _red = value;
            }
        }

        public int Green
        {
            get
            {
                return _green;
            }

            set
            {
                _green = value;
            }
        }

        public int Blue
        {
            get
            {
                return _blue;
            }

            set
            {
                _blue = value;
            }
        }

        public double Alpha
        {
            get
            {
                return _alpha;
            }

            set
            {
                _alpha = value;
            }
        }
        #endregion

        #region Constructor
        public ConversionMethods()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Converts the colour from RGB to hexadecimal.
        /// </summary>
        /// <param name="red">The red channel.</param>
        /// <param name="green">The green channel.</param>
        /// <param name="blue">The blue channel.</param>
        /// <returns></returns>
        public string ConvertRGBToHexadecimal(int red, int green, int blue)
        {
            return ColorTranslator.FromHtml(String.Format("#{0:X2}{1:X2}{2:X2}", red, green, blue)).Name.Remove(0, 1);
        }

        /// <summary>
        /// Converts the hexadecimal to RGB.
        /// </summary>
        /// <param name="hexColour">The hexadecimal colour.</param>
        /// <returns></returns>
        public Color ConvertHexadecimalToRGB(string hexColour)
        {
            int red = 0, green = 0, blue = 0;

            if (hexColour.IndexOf('#') != -1)
            {
                hexColour = hexColour.Replace("#", "");
            }

            if (hexColour.Length == 6)
            {
                red = int.Parse(hexColour.Substring(0, 2), NumberStyles.AllowHexSpecifier);

                green = int.Parse(hexColour.Substring(2, 2), NumberStyles.AllowHexSpecifier);

                blue = int.Parse(hexColour.Substring(4, 2), NumberStyles.AllowHexSpecifier);
            }
            else if (hexColour.Length == 3)
            {
                red = int.Parse(hexColour[0].ToString() + hexColour[0].ToString(), NumberStyles.AllowHexSpecifier);

                green = int.Parse(hexColour[1].ToString() + hexColour[1].ToString(), NumberStyles.AllowHexSpecifier);

                blue = int.Parse(hexColour[2].ToString() + hexColour[2].ToString(), NumberStyles.AllowHexSpecifier);
            }

            SetRGB(red, green, blue);

            return Color.FromArgb(red, green, blue);
        }

        /// <summary>
        /// Converts the decimal to integer.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public int ConvertDecimalToInteger(decimal value)
        {
            return Convert.ToInt32(value);
        }

        /// <summary>
        /// Sets the RGB.
        /// </summary>
        /// <param name="red">The red.</param>
        /// <param name="green">The green.</param>
        /// <param name="blue">The blue.</param>
        public void SetRGB(int red, int green, int blue)
        {
            Red = red;

            Green = green;

            Blue = blue;
        }

        /// <summary>
        /// Sets the rgba.
        /// </summary>
        /// <param name="red">The red.</param>
        /// <param name="green">The green.</param>
        /// <param name="blue">The blue.</param>
        /// <param name="alpha">The alpha.</param>
        public void SetRGBA(int red, int green, int blue, double alpha = 0.5)
        {
            Red = red;

            Green = green;

            Blue = blue;

            Alpha = alpha;
        }
        #endregion
    }
}