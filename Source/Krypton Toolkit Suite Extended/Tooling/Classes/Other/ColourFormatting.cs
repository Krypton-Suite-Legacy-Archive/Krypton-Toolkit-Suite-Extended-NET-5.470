using System;
using System.Drawing;

namespace Tooling.Classes.Other
{
    public class ColourFormatting
    {
        #region Formatting Methods
        public static string FormatColourAsString(Color chosenColour)
        {
            return chosenColour.ToArgb().ToString();
        }

        public static Color FormatStringColourAsColour(string colourString)
        {
            Color outputColour = Color.FromArgb(Convert.ToInt32(colourString));

            return outputColour;
        }
        #endregion
    }
}