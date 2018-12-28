using System.Drawing;

namespace Core.Classes.Colours
{
    public class ColourManager
    {
        #region Constructors
        public ColourManager()
        {

        }
        #endregion

        #region Methods
        public static Color ChangeColour(decimal alphaValue, decimal redValue, decimal greenValue, decimal blueValue)
        {
            Color outputColour = Color.FromArgb((int)alphaValue, (int)redValue, (int)greenValue, (int)blueValue);

            return outputColour;
        }
        #endregion
    }
}