using System;
using System.Drawing;

namespace Tooling.Classes.Other
{
    /// <summary>
    /// Some colour extension methods (https://github.com/sanjayatpilcrow/SharpSnippets/blob/master/POCs/POCs/Sanjay/SharpSnippets/Drawing/ColorExtensions.cs)
    /// </summary>
    public static class ColourExtensions
    {
        #region Variables
        private static Random _randomiser = new Random();
        #endregion

        #region Methods        
        /// <summary>
        /// Retrieves the contrast colour.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="preserveOpacity">if set to <c>true</c> [preserve opacity].</param>
        /// <returns></returns>
        public static Color RetrieveContrastColour(this Color source, bool preserveOpacity = true)
        {
            Color inputColour = source;

            //if RGB values are close to each other by a diff less than 10%, then if RGB values are lighter side, decrease the blue by 50% (eventually it will increase in conversion below), if RBB values are on darker side, decrease yellow by about 50% (it will increase in conversion)
            byte avgColourValue = (byte)((source.R + source.G + source.B) / 3);

            int diff_r = Math.Abs(source.R - avgColourValue), diff_g = Math.Abs(source.G - avgColourValue), diff_b = Math.Abs(source.B - avgColourValue);

            // Shade of gray
            if (diff_r < 20 && diff_g < 20 && diff_b < 20)
            {
                if (avgColourValue < 123)
                {
                    inputColour = Color.FromArgb(source.A, 220, 230, 50);
                }
                else
                {
                    inputColour = Color.FromArgb(source.A, 255, 225, 50);
                }
            }

            byte sourceAlphaValue = source.A;

            if (!preserveOpacity)
            {
                sourceAlphaValue = Math.Max(source.A, (byte)127);
            }

            RGB rgb = new RGB { R = inputColour.R, G = inputColour.G, B = inputColour.B };

            HSB hsb = ConvertToHSB(rgb);

            hsb.H = hsb.H < 180 ? hsb.H + 180 : hsb.H - 180;

            //_hsb.B = _isColorDark ? 240 : 50; //Added to create dark on light, and light on dark

            rgb = ConvertToRGB(hsb);

            return Color.FromArgb((int)sourceAlphaValue, (int)rgb.R, (int)rgb.G, (int)rgb.B);
        }
        #endregion

        #region Code from MSDN
        internal static RGB ConvertToRGB(HSB hsb)
        {
            // Following code is taken as it is from MSDN. See link below.
            // By: <a href="http://blogs.msdn.com/b/codefx/archive/2012/02/09/create-a-color-picker-for-windows-phone.aspx" title="MSDN" target="_blank">Yi-Lun Luo</a>
            double chroma = hsb.S * hsb.B, hue2 = hsb.H / 60, x = chroma * (1 - Math.Abs(hue2 % 2 - 1)), r1 = 0d, g1 = 0d, b1 = 0d;

            if (hue2 >= 0 && hue2 < 1)
            {
                r1 = chroma;
                g1 = x;
            }
            else if (hue2 >= 1 && hue2 < 2)
            {
                r1 = x;
                g1 = chroma;
            }
            else if (hue2 >= 2 && hue2 < 3)
            {
                g1 = chroma;
                b1 = x;
            }
            else if (hue2 >= 3 && hue2 < 4)
            {
                g1 = x;
                b1 = chroma;
            }
            else if (hue2 >= 4 && hue2 < 5)
            {
                r1 = x;
                b1 = chroma;
            }
            else if (hue2 >= 5 && hue2 <= 6)
            {
                r1 = chroma;
                b1 = x;
            }

            double m = hsb.B - chroma;

            return new RGB()
            {
                R = r1 + m,
                G = g1 + m,
                B = b1 + m
            };
        }

        /// <summary>
        /// Converts to HSB.
        /// </summary>
        /// <param name="rgb">The RGB.</param>
        /// <returns></returns>
        internal static HSB ConvertToHSB(RGB rgb)
        {
            // Following code is taken as it is from MSDN. See link below.
            // By: <a href="http://blogs.msdn.com/b/codefx/archive/2012/02/09/create-a-color-picker-for-windows-phone.aspx" title="MSDN" target="_blank">Yi-Lun Luo</a>
            double r = rgb.R, g = rgb.G, b = rgb.B, max = Max(r, g, b), min = Min(r, g, b), chroma = max - min, hue2 = 0d;

            if (chroma != 0)
            {
                if (max == r)
                {
                    hue2 = (g - b) / chroma;
                }
                else if (max == g)
                {
                    hue2 = (b - r) / chroma + 2;
                }
                else
                {
                    hue2 = (r - g) / chroma + 4;
                }
            }

            double hue = hue2 * 60;

            if (hue < 0)
            {
                hue += 360;
            }

            double brightness = max, saturation = 0;

            if (chroma != 0)
            {
                saturation = chroma / brightness;
            }

            return new HSB()
            {
                H = hue,
                S = saturation,
                B = brightness
            };
        }

        private static double Max(double d1, double d2, double d3)
        {
            if (d1 > d2)
            {
                return Math.Max(d1, d3);
            }
            return Math.Max(d2, d3);
        }

        private static double Min(double d1, double d2, double d3)
        {
            if (d1 < d2)
            {
                return Math.Min(d1, d3);
            }
            return Math.Min(d2, d3);
        }

        internal struct RGB
        {
            internal double R;
            internal double G;
            internal double B;
        }

        internal struct HSB
        {
            internal double H;
            internal double S;
            internal double B;
        }
        #endregion
    }
}