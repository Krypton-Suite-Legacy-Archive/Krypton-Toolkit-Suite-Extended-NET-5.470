using ComponentFactory.Krypton.Toolkit;
using Core.Settings.Colours.Settings;
using System.Drawing;
using System.Windows.Forms;

namespace Core.Settings.Colours.Classes
{
    public class MiscellaneousPaletteColourManager
    {
        #region Variables
        private MiscellaneousPaletteColours _miscellaneousPaletteColours = new MiscellaneousPaletteColours();
        #endregion

        #region Constructors
        public MiscellaneousPaletteColourManager()
        {

        }
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the BorderColour to the value of borderColour.
        /// </summary>
        /// <param name="borderColour">The value of borderColour.</param>
        public void SetBorderColour(Color borderColour)
        {
            _miscellaneousPaletteColours.BorderColour = borderColour;
        }

        /// <summary>
        /// Gets the BorderColour value.
        /// </summary>
        /// <returns>The value of borderColour.</returns>
        public Color GetBorderColour()
        {
            return _miscellaneousPaletteColours.BorderColour;
        }

        /// <summary>
        /// Sets the DisabledControlColour to the value of disabledControlColour.
        /// </summary>
        /// <param name="disabledControlColour">The value of disabledControlColour.</param>
        public void SetDisabledControlColour(Color disabledControlColour)
        {
            _miscellaneousPaletteColours.DisabledControlColour = disabledControlColour;
        }

        /// <summary>
        /// Gets the DisabledControlColour value.
        /// </summary>
        /// <returns>The value of disabledControlColour.</returns>
        public Color GetDisabledControlColour()
        {
            return _miscellaneousPaletteColours.DisabledControlColour;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Saves the colour settings.
        /// </summary>
        /// <param name="usePrompt">If set to <c>true</c> [use prompt].</param>
        public void SaveColourSettings(bool usePrompt = false)
        {
            if (usePrompt)
            {
                DialogResult result = KryptonMessageBox.Show("Do you want to save the current colour settings?", "Save Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _miscellaneousPaletteColours.Save();
                }
                else
                {
                    ResetSettings(usePrompt);
                }
            }
            else
            {
                _miscellaneousPaletteColours.Save();
            }
        }


        /// <summary>
        /// Resets the settings.
        /// </summary>
        /// <param name="usePrompt">If set to <c>true</c> [use prompt].</param>
        public void ResetSettings(bool usePrompt = false)
        {
            if (usePrompt)
            {
                DialogResult result = KryptonMessageBox.Show("This action will reset the colour values. Do you want to continue?", "Reset Colour Values", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ResetColourSettings();

                    SaveColourSettings(usePrompt);
                }
                else
                {
                    ResetColourSettings();

                    SaveColourSettings();
                }
            }
        }

        /// <summary>
        /// Resets the colour settings.
        /// </summary>
        private void ResetColourSettings()
        {
            SetBorderColour(SystemColors.Control);

            SetDisabledControlColour(Color.Gray);
        }
        #endregion

        #region Detection
        public static bool AreMiscellaneousPaletteColoursEmpty()
        {
            MiscellaneousPaletteColourManager miscellaneousPaletteColourManager = new MiscellaneousPaletteColourManager();

            if (miscellaneousPaletteColourManager.GetBorderColour() == Color.Empty || miscellaneousPaletteColourManager.GetDisabledControlColour() == Color.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}