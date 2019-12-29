using System;
using System.Drawing;

namespace PaletteExplorer.Classes
{
    public class RandomisePaletteColours
    {
        #region Variables
        private Random _random = new Random();
        private int _red, _blue, _green, _yellow;
        #endregion

        #region Properties
        private new Random Random { get => _random; }

        #region Colours
        private int Red { get => _red; set => _red = value; }

        private int Blue { get => _blue; set => _blue = value; }

        private int Green { get => _green; set => _green = value; }

        private int Yellow { get => _yellow; set => _yellow = value; }
        #endregion

        #endregion

        #region Constructors
        public RandomisePaletteColours()
        {

        }
        #endregion

        #region Methods

        #region Basic Colours
        public static Color ReturnBaseColour()
        {
            return Color.FromArgb(GetRandomRedValue(), GetRandomGreenValue(), GetRandomBlueValue());
        }

        public static Color ReturnDarkColour()
        {
            Color darkColour = Color.FromArgb(GetRandomRedValue(), GetRandomGreenValue(), GetRandomBlueValue());

            if (AreColoursEqual(darkColour, ReturnBaseColour()))
            {
                darkColour = Color.FromArgb(GetRandomRedValue(), GetRandomGreenValue(), GetRandomBlueValue());
            }

            return darkColour;
        }

        public static Color ReturnMiddleColour()
        {
            return Color.FromArgb(GetRandomRedValue(), GetRandomGreenValue(), GetRandomBlueValue());
        }

        public static Color ReturnLightColour()
        {
            return Color.FromArgb(GetRandomRedValue(), GetRandomGreenValue(), GetRandomBlueValue());
        }

        public static Color ReturnLightestColour()
        {
            return Color.FromArgb(GetRandomRedValue(), GetRandomGreenValue(), GetRandomBlueValue());
        }
        #endregion


        #region Random Methods
        private static int GetRandomAlphaValue()
        {
            Random rnd = new Random();

            return rnd.Next(255);
        }

        private static int GetRandomRedValue()
        {
            RandomisePaletteColours randomisePaletteColours = new RandomisePaletteColours();

            return randomisePaletteColours.Random.Next(255);
        }

        private static int GetRandomBlueValue()
        {
            RandomisePaletteColours randomisePaletteColours = new RandomisePaletteColours();

            return randomisePaletteColours.Random.Next(255);
        }

        private static int GetRandomGreenValue()
        {
            RandomisePaletteColours randomisePaletteColours = new RandomisePaletteColours();

            return randomisePaletteColours.Random.Next(255);
        }

        private static bool AreColoursEqual(Color colourOne, Color colourTwo)
        {
            return colourOne.Equals(colourTwo);
        }
        #endregion

        #endregion
    }
}