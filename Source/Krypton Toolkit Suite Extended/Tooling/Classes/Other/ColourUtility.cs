using System;
using System.CodeDom.Compiler;
using System.Drawing;

namespace Tooling.Classes.Other
{
    /// <summary>
    /// https://stackoverflow.com/questions/7255514/generating-colours-after-applying-opacity-of-black-and-white
    /// </summary>
    public class ColourUtility
    {
        #region Variables
        private Color _colour;
        #endregion

        #region Constructor
        public ColourUtility(Color originalColour)
        {
            _colour = originalColour;
        }
        #endregion

        #region Methods
        public Color GetTransformedColour(Color overlay)
        {
            using (var bitmap = new Bitmap(1, 1))
            {
                var g = Graphics.FromImage(bitmap);

                using (Brush baseBrush = new SolidBrush(_colour))
                {
                    g.FillRectangle(baseBrush, 0, 0, 1, 1);
                }

                using (Brush overlayBrush = new SolidBrush(Color.FromArgb(127, overlay)))
                {
                    g.FillRectangle(overlayBrush, 0, 0, 1, 1);
                }

                return bitmap.GetPixel(0, 0);
            }
        }

        public static Color SetHue(Color baseColour)
        {
            var tmpColour = new HSV();

            tmpColour.hue = baseColour.GetHue();

            tmpColour.saturation = baseColour.GetSaturation();

            tmpColour.brightness = baseColour.GetBrightness();

            return ColourFromHSL(tmpColour);
        }

        private static Color ColourFromHSL(HSV hsl)
        {
            if (hsl.saturation == 0)
            {
                int l = (int)hsl.brightness;

                return Color.FromArgb(255, l, l, l);
            }

            double min, max, h;

            h = hsl.hue / 360d;

            max = hsl.brightness < 0.5 ? hsl.brightness * (1 + hsl.saturation) : (hsl.brightness + hsl.saturation) - (hsl.brightness * hsl.saturation);

            min = (hsl.brightness * 2d) - max;

            Color c = Color.FromArgb(255, (int)(255 * RGBChannelFromHue(min, max, h + 1 / 3d)), (int)(255 * RGBChannelFromHue(min, max, h)), (int)(255 * RGBChannelFromHue(min, max, h - 1 / 3d)));

            return c;
        }

        public static double RGBChannelFromHue(double m1, double m2, double h)
        {
            h = (h + 1d) % 1d;

            if (h < 0)
            {
                h += 1;
            }

            if (h * 6 < 1) return m1 + (m2 - m1) * 6 * h;
            else if (h * 2 < 1) return m2;
            else if (h * 3 < 2) return m1 + (m2 - m1) * 6 * (2d / 3d - h);
            else return m1;
        }
        #endregion

        #region Structs
        public struct HSV
        {
            public float hue, saturation, brightness;
        }
        #endregion
    }
}