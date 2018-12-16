using System.Diagnostics;
using System.Drawing;

namespace ExtendedControls.Base.Code.Colours
{
    public sealed class HSLColour
    {
        #region Public static methods.
        // ------------------------------------------------------------------

        /// <summary>
        /// Creates from a given color.
        /// </summary>
        /// <param name="colour">The color.</param>
        /// <returns></returns>
        public static HSLColour FromColour(Color colour)
        {
            return ColourConverting.RGBToHSL(ColourConverting.ColourToRGB(colour));
        }

        /// <summary>
        /// Creates from a given color.
        /// </summary>
        /// <param name="colour">The color.</param>
        /// <returns></returns>
        public static HSLColour FromRGBColour(RGBColour colour)
        {
            return colour.ToHSLColour();
        }

        /// <summary>
        /// Creates from a given color.
        /// </summary>
        /// <param name="colour">The color.</param>
        /// <returns></returns>
        public static HSLColour FromHSLColour(HSLColour colour)
        {
            return new HSLColour(colour.PreciseHue, colour.PreciseSaturation, colour.PreciseLight);
        }

        /// <summary>
        /// Creates from a given color.
        /// </summary>
        /// <param name="colour">The color.</param>
        /// <returns></returns>
        public static HSLColour FromHSBColour(HSBColour colour)
        {
            return FromRGBColour(colour.ToRGBColour());
        }

        // ------------------------------------------------------------------
        #endregion

        #region Public methods.
        // ------------------------------------------------------------------

        /// <summary>
        /// Initializes a new instance of the <see cref="HSLColour"/> class.
        /// </summary>
        /// <param name="hue">The hue. Values from 0 to 360.</param>
        /// <param name="saturation">The saturation. Values from 0 to 100.</param>
        /// <param name="light">The light. Values from 0 to 100.</param>
        public HSLColour(
            double hue,
            double saturation,
            double light)
        {
            _hue = hue;
            _saturation = saturation;
            _light = light;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HSLColour"/> class.
        /// </summary>
        /// <param name="hue">The hue. Values from 0 to 360.</param>
        /// <param name="saturation">The saturation. Values from 0 to 100.</param>
        /// <param name="light">The light. Values from 0 to 100.</param>
        public HSLColour(
            int hue,
            int saturation,
            int light)
        {
            _hue = hue;
            _saturation = saturation;
            _light = light;
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current 
        /// <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current 
        /// <see cref="T:System.Object"/>.
        /// </returns>
        public override string ToString()
        {
            return string.Format(
                @"Hue: {0}; saturation: {1}; light: {2}.",
                Hue,
                Saturation,
                Light);
        }

        /// <summary>
        /// Returns the underlying .NET color.
        /// </summary>
        /// <returns></returns>
        public Color ToColour()
        {
            return ColourConverting.HSLToRGB(this).ToColour();
        }

        /// <summary>
        /// Returns the RGB color.
        /// </summary>
        /// <returns></returns>
        public RGBColour ToRGBColour()
        {
            return ColourConverting.HSLToRGB(this);
        }

        /// <summary>
        /// Returns the HSL color.
        /// </summary>
        /// <returns></returns>
        public HSLColour ToHSLColour()
        {
            return this;
        }

        /// <summary>
        /// Returns the HSB color.
        /// </summary>
        /// <returns></returns>
        public HSBColour ToHSBColour()
        {
            return ColourConverting.RGBToHSB(ToRGBColour());
        }

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is 
        /// equal to the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <param name="obj">The <see cref="T:System.Object"/> to compare with 
        /// the current <see cref="T:System.Object"/>.</param>
        /// <returns>
        /// true if the specified <see cref="T:System.Object"/> is equal to the 
        /// current <see cref="T:System.Object"/>; otherwise, false.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">The 
        /// <paramref name="obj"/> parameter is null.</exception>
        public override bool Equals(
            object obj)
        {
            var equal = false;

            if (obj is HSLColour)
            {
                var hsb = (HSLColour)obj;

                if (Hue == hsb.PreciseHue && Saturation == hsb.PreciseSaturation &&
                    Light == hsb.PreciseLight)
                {
                    equal = true;
                }
            }

            return equal;
        }

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>
        /// A hash code for the current <see cref="T:System.Object"/>.
        /// </returns>
        public override int GetHashCode()
        {
            Debug.Assert(1 == 1);
            return base.GetHashCode();
        }

        // ------------------------------------------------------------------
        #endregion

        #region Public properties.
        // ------------------------------------------------------------------

        /// <summary>
        /// Gets or sets the hue. Values from 0 to 360.
        /// </summary>
        /// <value>The hue.</value>
        public int Hue
        {
            get
            {
                return (int)_hue;
            }
            set
            {
                _hue = value;
            }
        }

        /// <summary>
        /// Gets or sets the precise hue. Values from 0 to 360.
        /// </summary>
        /// <value>The precise hue.</value>
        public double PreciseHue
        {
            get
            {
                return _hue;
            }
            set
            {
                _hue = value;
            }
        }

        /// <summary>
        /// Gets or sets the saturation. Values from 0 to 100.
        /// </summary>
        /// <value>The saturation.</value>
        public int Saturation
        {
            get
            {
                return (int)_saturation;
            }
            set
            {
                _saturation = value;
            }
        }

        /// <summary>
        /// Gets or sets the precise saturation. Values from 0 to 100.
        /// </summary>
        /// <value>The precise saturation.</value>
        public double PreciseSaturation
        {
            get
            {
                return _saturation;
            }
            set
            {
                _saturation = value;
            }
        }

        /// <summary>
        /// Gets or sets the light. Values from 0 to 100.
        /// </summary>
        /// <value>The light.</value>
        public int Light
        {
            get
            {
                return (int)_light;
            }
            set
            {
                _light = value;
            }
        }

        /// <summary>
        /// Gets or sets the precise light. Values from 0 to 100.
        /// </summary>
        /// <value>The precise light.</value>
        public double PreciseLight
        {
            get
            {
                return _light;
            }
            set
            {
                _light = value;
            }
        }

        // ------------------------------------------------------------------
        #endregion

        #region Private variables.
        // ------------------------------------------------------------------

        private double _hue;
        private double _saturation;
        private double _light;

        // ------------------------------------------------------------------
        #endregion
    }
}