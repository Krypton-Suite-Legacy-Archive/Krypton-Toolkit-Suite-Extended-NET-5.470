using System.Diagnostics;
using System.Drawing;

namespace ExtendedControls.Base.Code.Colours
{
    public sealed class HSBColour
    {
        #region Public static methods.
        // ------------------------------------------------------------------

        /// <summary>
        /// Creates from a given color.
        /// </summary>
        /// <param name="colour">The color.</param>
        /// <returns></returns>
        public static HSBColour FromColour(Color colour)
        {
            return ColourConverting.ColourToRGB(colour).ToHSBColour();
        }

        /// <summary>
        /// Creates from a given color.
        /// </summary>
        /// <param name="colour">The color.</param>
        /// <returns></returns>
        public static HSBColour FromRGBColour(RGBColour colour)
        {
            return colour.ToHSBColour();
        }

        /// <summary>
        /// Creates from a given color.
        /// </summary>
        /// <param name="colour">The color.</param>
        /// <returns></returns>
        public static HSBColour FromHSBColour(HSBColour colour)
        {
            return new HSBColour(colour.Hue, colour.Saturation, colour.Brightness);
        }

        /// <summary>
        /// Creates from a given color.
        /// </summary>
        /// <param name="colour">The color.</param>
        /// <returns></returns>
        public static HSBColour FromHSLColour(HSLColour colour)
        {
            return FromRGBColour(colour.ToRGBColour());
        }

        // ------------------------------------------------------------------
        #endregion

        #region Public methods.
        // ------------------------------------------------------------------

        /// <summary>
        /// Initializes a new instance of the <see cref="HSBColour"/> class.
        /// </summary>
        /// <param name="hue">The hue.</param>
        /// <param name="saturation">The saturation.</param>
        /// <param name="brightness">The brightness.</param>
        public HSBColour(
            int hue,
            int saturation,
            int brightness)
        {
            Hue = hue;
            Saturation = saturation;
            Brightness = brightness;
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current 
        /// <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current
        ///  <see cref="T:System.Object"/>.
        /// </returns>
        public override string ToString()
        {
            return string.Format(
                @"Hue: {0}; saturation: {1}; brightness: {2}.",
                Hue,
                Saturation,
                Brightness);
        }

        /// <summary>
        /// Returns the underlying .NET color.
        /// </summary>
        /// <returns></returns>
        public Color ToColour()
        {
            return ColourConverting.HSBToRGB(this).ToColour();
        }

        /// <summary>
        /// Returns a RGB color.
        /// </summary>
        /// <returns></returns>
        public RGBColour ToRGBColour()
        {
            return ColourConverting.HSBToRGB(this);
        }

        /// <summary>
        /// Returns a HSB color.
        /// </summary>
        /// <returns></returns>
        public HSBColour ToHsbColour()
        {
            return this;
        }

        /// <summary>
        /// Returns a HSL color.
        /// </summary>
        /// <returns></returns>
        public HSLColour ToHSLColour()
        {
            return ColourConverting.RGBToHSL(ToRGBColour());
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

            if (obj is HSBColour)
            {
                var hsb = (HSBColour)obj;

                if (Hue == hsb.Hue && Saturation == hsb.Saturation &&
                    Brightness == hsb.Brightness)
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
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the saturation. Values from 0 to 100.
        /// </summary>
        /// <value>The saturation.</value>
        public int Saturation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the brightness. Values from 0 to 100.
        /// </summary>
        /// <value>The brightness.</value>
        public int Brightness
        {
            get;
            set;
        }

        // ------------------------------------------------------------------
        #endregion
    }
}