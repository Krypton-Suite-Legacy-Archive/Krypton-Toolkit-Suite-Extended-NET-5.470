#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion 

using ExtendedControls.ExtendedToolkit.Controls;
using PaletteExplorer.UX.Colour;
using System;
using System.Drawing;
using ToolkitSettings.Classes.PaletteExplorer.Colours;

namespace PaletteExplorer.Classes
{
    public static class ColourHelpers
    {
        #region Methods
        /// <summary>
        /// Recreates the palette colours.
        /// </summary>
        /// <param name="control">The control.</param>
        public static void RecreatePaletteColours(CircularPictureBox control)
        {
            //PaletteColourCreator paletteColourCreator = new PaletteColourCreator(control.BackColor);

            //paletteColourCreator.Show();

            ColourMixerAdvanced colourMixerAdvanced = new ColourMixerAdvanced(control.BackColor);

            colourMixerAdvanced.Show();
        }

        internal static void GenerateColourShades(Color baseColour, CircularPictureBox darkColour, CircularPictureBox mediumColour, CircularPictureBox lightColour, CircularPictureBox lightestColour, float darkestColourIntensity, float mediumColourIntensity, float lightColourIntensity, float lightestColourIntensity)
        {
            if (baseColour != null || baseColour.IsEmpty || baseColour == Color.Transparent)
            {
                darkColour.BackColor = Darken(baseColour, darkestColourIntensity);

                mediumColour.BackColor = Darken(baseColour, mediumColourIntensity);

                lightColour.BackColor = Lighten(baseColour, lightColourIntensity);

                lightestColour.BackColor = Lighten(baseColour, lightestColourIntensity);
            }
        }

        /// <summary>
        /// Tints the color by the given percent.
        /// </summary>
        /// <param name="colour">The color being tinted.</param>
        /// <param name="percent">The percent to tint. Ex: 0.1 will make the color 10% lighter.</param>
        /// <returns>The new tinted color.</returns>
        public static Color Lighten(this Color colour, float percent)
        {
            var lighting = colour.GetBrightness();
            lighting = lighting + lighting * percent;
            if (lighting > 1.0)
            {
                lighting = 1;
            }
            else if (lighting <= 0)
            {
                lighting = 0.1f;
            }
            var tintedColor = FromHsl(colour.A, colour.GetHue(), colour.GetSaturation(), lighting);

            return tintedColor;
        }

        /// <summary>
        /// Tints the color by the given percent.
        /// </summary>
        /// <param name="colour">The color being tinted.</param>
        /// <param name="percent">The percent to tint. Ex: 0.1 will make the color 10% darker.</param>
        /// <returns>The new tinted color.</returns>
        public static Color Darken(this Color colour, float percent)
        {
            var lighting = colour.GetBrightness();
            lighting = lighting - lighting * percent;
            if (lighting > 1.0)
            {
                lighting = 1;
            }
            else if (lighting <= 0)
            {
                lighting = 0;
            }
            var tintedColor = FromHsl(colour.A, colour.GetHue(), colour.GetSaturation(), lighting);

            return tintedColor;
        }

        /// <summary>
        /// Converts the HSL values to a Color.
        /// </summary>
        /// <param name="alpha">The alpha.</param>
        /// <param name="hue">The hue.</param>
        /// <param name="saturation">The saturation.</param>
        /// <param name="lighting">The lighting.</param>
        /// <returns></returns>
        public static Color FromHsl(int alpha, float hue, float saturation, float lighting)
        {
            if (0 > alpha || 255 < alpha)
            {
                throw new ArgumentOutOfRangeException("alpha");
            }
            if (0f > hue || 360f < hue)
            {
                throw new ArgumentOutOfRangeException("hue");
            }
            if (0f > saturation || 1f < saturation)
            {
                throw new ArgumentOutOfRangeException("saturation");
            }
            if (0f > lighting || 1f < lighting)
            {
                throw new ArgumentOutOfRangeException("lighting");
            }

            if (0 == saturation)
            {
                return Color.FromArgb(alpha, Convert.ToInt32(lighting * 255), Convert.ToInt32(lighting * 255), Convert.ToInt32(lighting * 255));
            }

            float fMax, fMid, fMin;
            int iSextant, iMax, iMid, iMin;

            if (0.5 < lighting)
            {
                fMax = lighting - (lighting * saturation) + saturation;
                fMin = lighting + (lighting * saturation) - saturation;
            }
            else
            {
                fMax = lighting + (lighting * saturation);
                fMin = lighting - (lighting * saturation);
            }

            iSextant = (int)Math.Floor(hue / 60f);
            if (300f <= hue)
            {
                hue -= 360f;
            }
            hue /= 60f;
            hue -= 2f * (float)Math.Floor(((iSextant + 1f) % 6f) / 2f);
            if (0 == iSextant % 2)
            {
                fMid = hue * (fMax - fMin) + fMin;
            }
            else
            {
                fMid = fMin - hue * (fMax - fMin);
            }

            iMax = Convert.ToInt32(fMax * 255);
            iMid = Convert.ToInt32(fMid * 255);
            iMin = Convert.ToInt32(fMin * 255);

            switch (iSextant)
            {
                case 1:
                    return Color.FromArgb(alpha, iMid, iMax, iMin);
                case 2:
                    return Color.FromArgb(alpha, iMin, iMax, iMid);
                case 3:
                    return Color.FromArgb(alpha, iMin, iMid, iMax);
                case 4:
                    return Color.FromArgb(alpha, iMid, iMin, iMax);
                case 5:
                    return Color.FromArgb(alpha, iMax, iMin, iMid);
                default:
                    return Color.FromArgb(alpha, iMax, iMid, iMin);
            }
        }

        /// <summary>
        /// Generates the random colour.
        /// Code adapted from: https://www.youtube.com/watch?v=4sWT9NEO114
        /// </summary>
        /// <returns>A random RGB colour.</returns>
        public static Color GenerateRandomColour()
        {
            Random randomColour = new Random();

            return Color.FromArgb(randomColour.Next(256), randomColour.Next(256), randomColour.Next(256));
        }

        /// <summary>
        /// Generates the random ARGB colour.
        /// Code adapted from: https://www.youtube.com/watch?v=4sWT9NEO114
        /// </summary>
        /// <returns>A random ARGB colour.</returns>
        public static Color GenerateRandomARGBColour()
        {
            Random randomColour = new Random();

            return Color.FromArgb(randomColour.Next(256), randomColour.Next(256), randomColour.Next(256), randomColour.Next(256));
        }

        /// <summary>
        /// Whites the wash all colours.
        /// </summary>
        public static void WhiteWashAllColours()
        {
            #region Variables

            #region Setting Managers
            AllMergedColourSettingsManager allMergedColourSettingsManager = new AllMergedColourSettingsManager();

            BasicColourSettingsManager basicColourSettingsManager = new BasicColourSettingsManager();

            CustomColourSettingsManager customColourSettingsManager = new CustomColourSettingsManager();

            CustomTextColourSettingsManager customTextColourSettingsManager = new CustomTextColourSettingsManager();

            LinkTextColourSettingsManager linkTextColourSettingsManager = new LinkTextColourSettingsManager();

            MiscellaneousColourSettingsManager miscellaneousColourSettingsManager = new MiscellaneousColourSettingsManager();

            StandardControlTextColourSettingsManager standardControlTextColourSettingsManager = new StandardControlTextColourSettingsManager();

            TextColourSettingsManager textColourSettingsManager = new TextColourSettingsManager();
            #endregion

            Color white = Color.White;
            #endregion
        }

        /// <summary>
        /// Converts the decimal to float.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static float ConvertDecimalToFloat(decimal value)
        {
            return (float)value;
        }

        /// <summary>
        /// Returns the float as string.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static string ReturnFloatAsString(float value)
        {
            return $"{ value }f";
        }

        public static void SetColour(string text, Color colour)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}