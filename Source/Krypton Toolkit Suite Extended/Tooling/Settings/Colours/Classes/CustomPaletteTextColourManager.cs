using ComponentFactory.Krypton.Toolkit;
using Core.Settings.Colours.Settings;
using System.Drawing;
using System.Windows.Forms;

namespace Core.Settings.Colours.Classes
{
    public class CustomPaletteTextColourManager
    {
        #region Variables
        private CustomPaletteTextColours _customPaletteTextColours = new CustomPaletteTextColours();
        #endregion

        #region Constructors
        public CustomPaletteTextColourManager()
        {

        }
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the CustomTextColourOne to the value of customTextColourOne.
        /// </summary>
        /// <param name="customTextColourOne">The value of customTextColourOne.</param>
        public void SetCustomTextColourOne(Color customTextColourOne)
        {
            _customPaletteTextColours.CustomTextColourOne = customTextColourOne;
        }

        /// <summary>
        /// Gets the CustomTextColourOne value.
        /// </summary>
        /// <returns>The value of customTextColourOne.</returns>
        public Color GetCustomTextColourOne()
        {
            return _customPaletteTextColours.CustomTextColourOne;
        }

        /// <summary>
        /// Sets the CustomTextColourTwo to the value of customTextColourTwo.
        /// </summary>
        /// <param name="customTextColourTwo">The value of customTextColourTwo.</param>
        public void SetCustomTextColourTwo(Color customTextColourTwo)
        {
            _customPaletteTextColours.CustomTextColourTwo = customTextColourTwo;
        }

        /// <summary>
        /// Gets the CustomTextColourTwo value.
        /// </summary>
        /// <returns>The value of customTextColourTwo.</returns>
        public Color GetCustomTextColourTwo()
        {
            return _customPaletteTextColours.CustomTextColourTwo;
        }

        /// <summary>
        /// Sets the CustomTextColourThree to the value of customTextColourThree.
        /// </summary>
        /// <param name="customTextColourThree">The value of customTextColourThree.</param>
        public void SetCustomTextColourThree(Color customTextColourThree)
        {
            _customPaletteTextColours.CustomTextColourThree = customTextColourThree;
        }

        /// <summary>
        /// Gets the CustomTextColourThree value.
        /// </summary>
        /// <returns>The value of customTextColourThree.</returns>
        public Color GetCustomTextColourThree()
        {
            return _customPaletteTextColours.CustomTextColourThree;
        }

        /// <summary>
        /// Sets the CustomTextColourFour to the value of customTextColourFour.
        /// </summary>
        /// <param name="customTextColourFour">The value of customTextColourFour.</param>
        public void SetCustomTextColourFour(Color customTextColourFour)
        {
            _customPaletteTextColours.CustomTextColourFour = customTextColourFour;
        }

        /// <summary>
        /// Gets the CustomTextColourFour value.
        /// </summary>
        /// <returns>The value of customTextColourFour.</returns>
        public Color GetCustomTextColourFour()
        {
            return _customPaletteTextColours.CustomTextColourFour;
        }

        /// <summary>
        /// Sets the CustomTextColourFive to the value of customTextColourFive.
        /// </summary>
        /// <param name="customTextColourFive">The value of customTextColourFive.</param>
        public void SetCustomTextColourFive(Color customTextColourFive)
        {
            _customPaletteTextColours.CustomTextColourFive = customTextColourFive;
        }

        /// <summary>
        /// Gets the CustomTextColourFive value.
        /// </summary>
        /// <returns>The value of customTextColourFive.</returns>
        public Color GetCustomTextColourFive()
        {
            return _customPaletteTextColours.CustomTextColourFive;
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
                    _customPaletteTextColours.Save();
                }
                else
                {
                    ResetSettings(usePrompt);
                }
            }
            else
            {
                _customPaletteTextColours.Save();
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
                DialogResult result = KryptonMessageBox.Show("This action will reset the custom text colour values. Do you want to continue?", "Reset Colour Values", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
            SetCustomTextColourOne(Color.Black);

            SetCustomTextColourTwo(Color.White);

            SetCustomTextColourThree(Color.Black);

            SetCustomTextColourFour(Color.FromArgb(230, 230, 230));

            SetCustomTextColourFive(Color.MintCream);
        }
        #endregion

        #region Detection
        public static bool AreCustomPaletteTextColoursEmpty()
        {
            CustomPaletteTextColourManager customPaletteTextColourManager = new CustomPaletteTextColourManager();

            if (customPaletteTextColourManager.GetCustomTextColourOne() == Color.Empty || customPaletteTextColourManager.GetCustomTextColourTwo() == Color.Empty || customPaletteTextColourManager.GetCustomTextColourThree() == Color.Empty || customPaletteTextColourManager.GetCustomTextColourFour() == Color.Empty || customPaletteTextColourManager.GetCustomTextColourFive() == Color.Empty)
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