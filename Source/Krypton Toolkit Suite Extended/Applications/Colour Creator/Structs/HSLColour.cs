using System;
using System.Drawing;

namespace ColourCreator.Structs
{
    struct HSLColour
    {
        private const double Epsilon = 0.0001;

        // Hue in range [0..1].
        private readonly double hue;

        public HSLColour(int alpha, double hue, double saturation, double luminosity)
            : this()
        {
            this.hue = NormaliseRange(hue);
            Hue = Convert.ToInt32(this.hue * 360);

            Alpha = alpha;
            Saturation = NormaliseRange(saturation);
            Luminosity = NormaliseRange(luminosity);
        }

        public HSLColour(int alpha, int hue, double saturation, double luminosity)
            : this(alpha, NormaliseAngle(hue) / 360.0, saturation, luminosity)
        {

        }

        public int Alpha { get; private set; }

        public int Hue { get; private set; }

        public double Saturation { get; private set; }

        public double Luminosity { get; private set; }

        public Color ToColour()
        {
            int r, g, b;
            Hsl2Rgb(hue, Saturation, Luminosity, out r, out g, out b);
            return Color.FromArgb(Alpha, r, g, b);
        }

        public static HSLColour FromColour(Color colour)
        {
            double h, s, l;
            Rgb2Hsl(colour.R, colour.G, colour.B, out h, out s, out l);
            return new HSLColour(colour.A, h, s, l);
        }

        private static int NormaliseAngle(int angle)
        {
            int result = angle % 360;
            return result < 0 ? result + 360 : result;
        }

        private static double NormaliseRange(double value)
        {
            return Math.Min(Math.Max(value, 0.0), 1.0);
        }

        #region Conversion Routines

        private static void Hsl2Rgb(double hue, double sat, double lum, out int red, out int green, out int blue)
        {
            double r = lum;
            double g = lum;
            double b = lum;
            double v = (lum <= 0.5) ? (lum * (1.0 + sat)) : (lum + sat - lum * sat);

            if (v > 0)
            {
                double m = lum + lum - v;
                double sv = (v - m) / v;

                hue *= 6.0;
                int sextant = (int)hue;
                double fract = hue - sextant;

                double vsf = v * sv * fract;
                double mid1 = m + vsf;
                double mid2 = v - vsf;

                switch (sextant)
                {
                    case 0:
                        r = v;
                        g = mid1;
                        b = m;
                        break;
                    case 1:
                        r = mid2;
                        g = v;
                        b = m;
                        break;
                    case 2:
                        r = m;
                        g = v;
                        b = mid1;
                        break;
                    case 3:
                        r = m;
                        g = mid2;
                        b = v;
                        break;
                    case 4:
                        r = mid1;
                        g = m;
                        b = v;
                        break;
                    case 5:
                        r = v;
                        g = m;
                        b = mid2;
                        break;
                }
            }

            red = (int)(r * 255.0f);
            green = (int)(g * 255.0f);
            blue = (int)(b * 255.0f);
        }

        private static void Rgb2Hsl(int red, int green, int blue, out double hue, out double sat, out double lum)
        {
            double r = red / 255.0;
            double g = green / 255.0;
            double b = blue / 255.0;

            hue = 0;
            sat = 0;

            double v = Math.Max(r, g);
            v = Math.Max(v, b);

            double m = Math.Min(r, g);
            m = Math.Min(m, b);

            lum = (m + v) / 2.0;
            if (lum <= 0.0)
            {
                return;
            }

            double vm = v - m;
            sat = vm;
            if (sat > 0.0)
            {
                sat /= (lum <= 0.5) ? (v + m) : (2.0 - v - m);
            }
            else
            {
                return;
            }

            double r2 = (v - r) / vm;
            double g2 = (v - g) / vm;
            double b2 = (v - b) / vm;

            if (Math.Abs(r - v) < Epsilon)
            {
                hue = (Math.Abs(g - m) < Epsilon ? 5.0 + b2 : 1.0 - g2);
            }
            else if (Math.Abs(g - v) < Epsilon)
            {
                hue = (Math.Abs(b - m) < Epsilon ? 1.0 + r2 : 3.0 - b2);
            }
            else
            {
                hue = (Math.Abs(r - m) < Epsilon ? 3.0 + g2 : 5.0 - r2);
            }

            hue /= 6.0;
        }

        #endregion
    }
}