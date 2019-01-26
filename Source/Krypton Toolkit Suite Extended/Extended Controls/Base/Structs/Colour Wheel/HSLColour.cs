using System;
using System.Drawing;

namespace ExtendedControls.Base.Structs.ColourWheel
{
    public struct HSLColour
    {
        #region Variables
        private double _hue, _saturation, _luminosity;
        #endregion

        #region Properties
        public double Hue { get { return _hue; } set { _hue = value; } }

        public double Saturation { get { return _saturation; } set { _saturation = value; } }

        public double Luminosity
        {
            get
            {
                return _luminosity;
            }

            set
            {
                _luminosity = value;

                if (_luminosity < 0)
                {
                    _luminosity = 0;
                }

                if (_luminosity > 1)
                {
                    _luminosity = 1;
                }
            }
        }

        public Color Colour { get { return ToRGB(); } set { FromRGB(value); } }
        #endregion

        #region Constructors 
        /// <summary>
        /// Initializes a new instance of the <see cref="HSLColour"/> struct.
        /// </summary>
        /// <param name="hue">The hue.</param>
        /// <param name="saturation">The saturation.</param>
        /// <param name="luminosity">The luminosity.</param>
        public HSLColour(double hue, double saturation, double luminosity)
        {
            _hue = Math.Min(360, hue);

            _saturation = Math.Min(1, saturation);

            _luminosity = Math.Min(1, luminosity);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HSLColour"/> struct.
        /// </summary>
        /// <param name="colour">The colour.</param>
        public HSLColour(Color colour)
        {
            _hue = 0;

            _saturation = 1;

            _luminosity = 1;

            FromRGB(colour);
        }
        #endregion

        #region Methods
        public void FromRGB(Color colour)
        {
            double r = (double)colour.R / 255d, g = (double)colour.G / 255d, b = (double)colour.B / 255d;

            double min = Math.Min(Math.Min(r, g), b), max = Math.Max(Math.Max(r, g), b);

            Hue = 0;

            if (min != max)
            {
                if (r == max && g >= b)
                {
                    Hue = 60 * ((g - b) / (max - min)) + 0;
                }
                else if (r == max && g < b)
                {
                    Hue = 60 * ((g - b) / (max - min)) + 360;
                }
                else if (g == max)
                {
                    Hue = 60 * ((b - r) / (max - min)) + 120;
                }
                else if (b == max)
                {
                    Hue = 60 * ((r - g) / (max - min)) + 240;
                }
            }

            // find lightness
            Luminosity = (min + max) / 2;

            // find saturation
            if (Luminosity == 0 || min == max)
            {
                Saturation = 0;
            }
            else if (Luminosity > 0 && Luminosity <= 0.5)
            {
                Saturation = (max - min) / (2 * Luminosity);
            }
            else if (Luminosity > 0.5)
            {
                Saturation = (max - min) / (2 - 2 * Luminosity);
            }
        }

        public Color ToRGB()
        {
            double r = Luminosity, g = Luminosity, b = Luminosity;

            if (Saturation == 0)
            {
                return Color.FromArgb(255, (int)(r * 255), (int)(g * 255), (int)(b * 255));
            }

            double q = 0;

            if (Luminosity < 0.5)
            {
                q = Luminosity * (1 + Saturation);
            }
            else
            {
                q = Luminosity + Saturation - (Luminosity * Saturation);
            }

            double p = 2 * Luminosity - q, hk = Hue / 360;

            double[] tc = new double[3] { hk + (1d / 3d), hk, hk - (1d / 3d) }, colours = new double[3] { 0, 0, 0 };

            for (int colour = 0; colour < colours.Length; colour++)
            {
                if (tc[colour] < 0)
                {
                    tc[colour] += 1;
                }

                if (tc[colour] > 1)
                {
                    tc[colour] -= 1;
                }

                if (tc[colour] < (1d / 6d))
                {
                    colours[colour] = p + ((q - p) * 6 * tc[colour]);
                }
                else if (tc[colour] >= (1d / 6d) && tc[colour] < (1d / 2d))
                {
                    colours[colour] = q;
                }
                else if (tc[colour] >= (1d / 2d) && tc[colour] < (2d / 3d))
                {
                    colours[colour] = p + ((q - p) * 6 * (2d / 3d - tc[colour]));
                }
                else
                {
                    colours[colour] = p;
                }

                colours[colour] *= 255;
            }

            return Color.FromArgb(255, (int)colours[0], (int)colours[1], (int)colours[2]);
        }
        #endregion

        #region Operators
        public static bool operator != (HSLColour left, HSLColour right)
        {
            return !(left == right);
        }

        public static bool operator == (HSLColour left, HSLColour right)
        {
            return (left.Hue == right.Hue && left.Luminosity == right.Luminosity && left.Saturation == right.Saturation);
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            string s = string.Format("HSL: ({0:f2}, {1:f2}, {2:f2})", Hue, Saturation, Luminosity);

            return s;
        }
        #endregion

        #region Setters and Getters        
        /// <summary>
        /// Sets the hue.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetHue(double value)
        {
            Hue = value;
        }

        /// <summary>
        /// Gets the hue.
        /// </summary>
        /// <returns></returns>
        public double GetHue()
        {
            return Hue;
        }

        /// <summary>
        /// Sets the satuation.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetSatuation(double value)
        {
            Saturation = value;
        }

        /// <summary>
        /// Gets the saturation.
        /// </summary>
        /// <returns></returns>
        public double GetSaturation()
        {
            return Saturation;
        }

        /// <summary>
        /// Sets the luminosity.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetLuminosity(double value)
        {
            Luminosity = value;
        }

        /// <summary>
        /// Gets the luminosity.
        /// </summary>
        /// <returns></returns>
        public double GetLuminosity()
        {
            return Luminosity;
        }
        #endregion
    }
}