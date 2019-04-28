using Core.UX;
using ExtendedControls.ExtendedToolkit.Controls;

namespace PaletteExplorer.Classes
{
    public class PaletteUtilities
    {
        #region Constructors
        public PaletteUtilities()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Uses the selected colour.
        /// </summary>
        /// <param name="colourControl">The colour control.</param>
        /// <param name="goStraightToPaletteShader">if set to <c>true</c> [go straight to palette shader].</param>
        public static void UseSelectedColour(CircularPictureBox colourControl, bool goStraightToPaletteShader = false)
        {
            if (goStraightToPaletteShader)
            {
                PaletteColourCreator colourCreator = new PaletteColourCreator(colourControl.BackColor);

                colourCreator.Show();
            }
            else
            {
                ColourMixer mixer = new ColourMixer(colourControl.BackColor);

                mixer.Show();
            }
        }
        #endregion
    }
}