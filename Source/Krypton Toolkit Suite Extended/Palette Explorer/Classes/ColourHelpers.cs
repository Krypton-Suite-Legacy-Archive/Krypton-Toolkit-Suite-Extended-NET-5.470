using Core.UX;
using ExtendedControls.ExtendedToolkit.Controls;

namespace PaletteExplorer.Classes
{
    public class ColourHelpers
    {
        #region Constructors
        public ColourHelpers()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Recreates the palette colours.
        /// </summary>
        /// <param name="control">The control.</param>
        public static void RecreatePaletteColours(CircularPictureBox control)
        {
            PaletteColourCreator paletteColourCreator = new PaletteColourCreator(control.BackColor);

            paletteColourCreator.Show();
        }
        #endregion
    }
}