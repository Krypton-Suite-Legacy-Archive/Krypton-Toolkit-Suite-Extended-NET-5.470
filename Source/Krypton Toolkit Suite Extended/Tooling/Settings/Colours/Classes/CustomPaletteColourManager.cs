using ComponentFactory.Krypton.Toolkit;
using Core.Settings.Colours.Settings;
using System.Drawing;
using System.Windows.Forms;

namespace Core.Settings.Colours.Classes
{
    public class CustomPaletteColourManager
    {
        #region Variables
        private CustomPaletteColours _customPaletteColours = new CustomPaletteColours();
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the CustomColourOne to the value of customColourOne.
        /// </summary>
        /// <param name="customColourOne">The value of customColourOne.</param>
        public void SetCustomColourOne(Color customColourOne)
        {
            _customPaletteColours.CustomColourOne = customColourOne;
        }

        /// <summary>
        /// Gets the CustomColourOne value.
        /// </summary>
        /// <returns>The value of customColourOne.</returns>
        public Color GetCustomColourOne()
        {
            return _customPaletteColours.CustomColourOne;
        }

        /// <summary>
        /// Sets the CustomColourTwo to the value of customColourTwo.
        /// </summary>
        /// <param name="customColourTwo">The value of customColourTwo.</param>
        public void SetCustomColourTwo(Color customColourTwo)
        {
            _customPaletteColours.CustomColourTwo = customColourTwo;
        }

        /// <summary>
        /// Gets the CustomColourTwo value.
        /// </summary>
        /// <returns>The value of customColourTwo.</returns>
        public Color GetCustomColourTwo()
        {
            return _customPaletteColours.CustomColourTwo;
        }

        /// <summary>
        /// Sets the CustomColourThree to the value of customColourThree.
        /// </summary>
        /// <param name="customColourThree">The value of customColourThree.</param>
        public void SetCustomColourThree(Color customColourThree)
        {
            _customPaletteColours.CustomColourThree = customColourThree;
        }

        /// <summary>
        /// Gets the CustomColourThree value.
        /// </summary>
        /// <returns>The value of customColourThree.</returns>
        public Color GetCustomColourThree()
        {
            return _customPaletteColours.CustomColourThree;
        }

        /// <summary>
        /// Sets the CustomColourFour to the value of customColourFour.
        /// </summary>
        /// <param name="customColourFour">The value of customColourFour.</param>
        public void SetCustomColourFour(Color customColourFour)
        {
            _customPaletteColours.CustomColourFour = customColourFour;
        }

        /// <summary>
        /// Gets the CustomColourFour value.
        /// </summary>
        /// <returns>The value of customColourFour.</returns>
        public Color GetCustomColourFour()
        {
            return _customPaletteColours.CustomColourFour;
        }

        /// <summary>
        /// Sets the CustomColourFive to the value of customColourFive.
        /// </summary>
        /// <param name="customColourFive">The value of customColourFive.</param>
        public void SetCustomColourFive(Color customColourFive)
        {
            _customPaletteColours.CustomColourFive = customColourFive;
        }

        /// <summary>
        /// Gets the CustomColourFive value.
        /// </summary>
        /// <returns>The value of customColourFive.</returns>
        public Color GetCustomColourFive()
        {
            return _customPaletteColours.CustomColourFive;
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
                DialogResult result = KryptonMessageBox.Show("Do you want to save the current custom colour settings?", "Save Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _customPaletteColours.Save();
                }
                else
                {
                    ResetSettings(usePrompt);
                }
            }
            else
            {
                _customPaletteColours.Save();
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
                DialogResult result = KryptonMessageBox.Show("This action will reset the custom colour values. Do you want to continue?", "Reset Colour Values", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
            SetCustomColourOne(Color.Black);

            SetCustomColourTwo(Color.White);

            SetCustomColourThree(Color.Black);

            SetCustomColourFour(Color.FromArgb(230, 230, 230));

            SetCustomColourFive(Color.MintCream);
        }
        #endregion

        #region Detection
        public static bool AreCustomPaletteColoursEmpty()
        {
            CustomPaletteColourManager customPaletteColourManager = new CustomPaletteColourManager();

            if (customPaletteColourManager.GetCustomColourOne() == Color.Empty || customPaletteColourManager.GetCustomColourTwo() == Color.Empty || customPaletteColourManager.GetCustomColourThree() == Color.Empty || customPaletteColourManager.GetCustomColourFour() == Color.Empty || customPaletteColourManager.GetCustomColourFive() == Color.Empty)
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