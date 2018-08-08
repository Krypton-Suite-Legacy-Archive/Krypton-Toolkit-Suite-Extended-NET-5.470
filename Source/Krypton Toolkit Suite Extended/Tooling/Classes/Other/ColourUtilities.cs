using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Tooling.Classes.Other
{
    public static class ColourUtilities
    {
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
        /// Tints the color by the given percent.
        /// </summary>
        /// <param name="color">The color being tinted.</param>
        /// <param name="percent">The percent to tint. Ex: 0.1 will make the color 10% lighter.</param>
        /// <returns>The new tinted color.</returns>
        public static Color Lighten(this Color color, float percent)
        {
            var lighting = color.GetBrightness();
            lighting = lighting + lighting * percent;
            if (lighting > 1.0)
            {
                lighting = 1;
            }
            else if (lighting <= 0)
            {
                lighting = 0.1f;
            }
            var tintedColor = FromHsl(color.A, color.GetHue(), color.GetSaturation(), lighting);

            return tintedColor;
        }

        /// <summary>
        /// Tints the color by the given percent.
        /// </summary>
        /// <param name="color">The color being tinted.</param>
        /// <param name="percent">The percent to tint. Ex: 0.1 will make the color 10% darker.</param>
        /// <returns>The new tinted color.</returns>
        public static Color Darken(this Color color, float percent)
        {
            var lighting = color.GetBrightness();
            lighting = lighting - lighting * percent;
            if (lighting > 1.0)
            {
                lighting = 1;
            }
            else if (lighting <= 0)
            {
                lighting = 0;
            }
            var tintedColor = FromHsl(color.A, color.GetHue(), color.GetSaturation(), lighting);

            return tintedColor;
        }

        /// <summary>
        /// Generates the colour shades.
        /// </summary>
        /// <param name="baseColour">The base colour.</param>
        /// <param name="darkestColour">The darkest colour.</param>
        /// <param name="mediumColour">The medium colour.</param>
        /// <param name="lightColour">The light colour.</param>
        /// <param name="lightestColour">The lightest colour.</param>
        public static void GenerateColourShades(Color baseColour, PictureBox darkestColour, PictureBox mediumColour, PictureBox lightColour, PictureBox lightestColour)
        {
            if (baseColour != null)
            {
                darkestColour.BackColor = Darken(baseColour, 0.5f);

                mediumColour.BackColor = Darken(baseColour, 0.25f);

                lightColour.BackColor = Lighten(baseColour, 0.25f);

                lightestColour.BackColor = Lighten(baseColour, 0.5f);
            }
        }

        /// <summary>
        /// Formats the colour ARGB string.
        /// </summary>
        /// <param name="colourInput">The colour input.</param>
        /// <returns>A string containing the alpha, red, green and blue colour values of the selected <paramref name="colourInput"/>.</returns>
        public static string FormatColourARGBString(Color colourInput)
        {
            return $"{ colourInput.A.ToString() }, { colourInput.R.ToString() }, { colourInput.G.ToString() }, { colourInput.B.ToString() }";
        }

        /// <summary>
        /// Formats the colour RGB string.
        /// </summary>
        /// <param name="colourInput">The colour input.</param>
        /// <returns>A string containing the red, green and blue colour values of the selected <paramref name="colourInput"/>.</returns>
        public static string FormatColourRGBString(Color colourInput)
        {
            return $"{ colourInput.R.ToString() }, { colourInput.G.ToString() }, { colourInput.B.ToString() }";
        }

        /// <summary>
        /// Propagates the HSB values.
        /// </summary>
        /// <param name="hueValue">The hue value.</param>
        /// <param name="saturationValue">The saturation value.</param>
        /// <param name="brightnessValue">The brightness value.</param>
        /// <param name="hue">The hue.</param>
        /// <param name="saturation">The saturation.</param>
        /// <param name="brightness">The brightness.</param>
        public static void PropagateHSBValues(KryptonNumericUpDown hueValue, KryptonNumericUpDown saturationValue, KryptonNumericUpDown brightnessValue, decimal hue, decimal saturation, decimal brightness)
        {
            hueValue.Value = hue;

            saturationValue.Value = saturation;

            brightnessValue.Value = brightness;
        }

        /// <summary>
        /// Propagates the standard colours.
        /// </summary>
        /// <param name="standardColourSelection">The standard colour selection.</param>
        public static void PropagateStandardColours(KryptonComboBox standardColourSelection)
        {
            List<Color> allColours = new List<Color>();

            foreach (KnownColor colour in Enum.GetValues(typeof(KnownColor)))
            {
                Color standardColour = Color.FromKnownColor(colour);

                if (!allColours.Contains(standardColour))
                {
                    standardColourSelection.Items.Add(standardColour.Name);

                    standardColourSelection.AutoCompleteCustomSource.Add(standardColour.Name);

                    allColours.Add(standardColour);
                }
            }
        }

        /// <summary>
        /// Propagates the system colours.
        /// </summary>
        /// <param name="systemColourSelection">The system colour selection.</param>
        public static void PropagateSystemColours(KryptonComboBox systemColourSelection)
        {
            List<Color> allSystemColours = new List<Color>();

            PropertyInfo[] systemColourProperties = typeof(SystemColors).GetProperties();

            foreach (PropertyInfo propertyInfo in systemColourProperties)
            {
                object colourObject = propertyInfo.GetValue(null, null);

                Color systemColour = (Color)colourObject;

                if (!allSystemColours.Contains(systemColour))
                {
                    systemColourSelection.Items.Add(systemColour.Name);

                    systemColourSelection.AutoCompleteCustomSource.Add(systemColour.Name);

                    allSystemColours.Add(systemColour);
                }
            }
        }

        public static void PropagateBasePaletteModes(KryptonComboBox basePaletteModeSelection)
        {
            List<PaletteMode> allPaletteModes = new List<PaletteMode>();

            basePaletteModeSelection.Items.Add(Enum.GetValues(typeof(PaletteMode)).ToString());
        }
    }
}