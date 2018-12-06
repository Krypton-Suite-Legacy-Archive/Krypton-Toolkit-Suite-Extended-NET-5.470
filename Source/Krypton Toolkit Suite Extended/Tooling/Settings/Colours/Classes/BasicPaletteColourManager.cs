using ComponentFactory.Krypton.Toolkit;
using Core.Settings.Colours.Settings;
using System.Drawing;
using System.Windows.Forms;

namespace Core.Settings.Colours.Classes
{
    public class BasicPaletteColourManager
    {
        #region Variables
        private BasicPaletteColours _basicPaletteColours = new BasicPaletteColours();
        #endregion

        #region Constructors
        public BasicPaletteColourManager()
        {

        }
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the BaseColour to the value of baseColour.
        /// </summary>
        /// <param name="baseColour">The value of baseColour.</param>
        public void SetBaseColour(Color baseColour)
        {
            _basicPaletteColours.BaseColour = baseColour;
        }

        /// <summary>
        /// Gets the BaseColour value.
        /// </summary>
        /// <returns>The value of baseColour.</returns>
        public Color GetBaseColour()
        {
            return _basicPaletteColours.BaseColour;
        }

        /// <summary>
        /// Sets the DarkestColour to the value of darkestColour.
        /// </summary>
        /// <param name="darkestColour">The value of darkestColour.</param>
        public void SetDarkestColour(Color darkestColour)
        {
            _basicPaletteColours.DarkestColour = darkestColour;
        }

        /// <summary>
        /// Gets the DarkestColour value.
        /// </summary>
        /// <returns>The value of darkestColour.</returns>
        public Color GetDarkestColour()
        {
            return _basicPaletteColours.DarkestColour;
        }

        /// <summary>
        /// Sets the MediumColour to the value of mediumColour.
        /// </summary>
        /// <param name="mediumColour">The value of mediumColour.</param>
        public void SetMediumColour(Color mediumColour)
        {
            _basicPaletteColours.MediumColour = mediumColour;
        }

        /// <summary>
        /// Gets the MediumColour value.
        /// </summary>
        /// <returns>The value of mediumColour.</returns>
        public Color GetMediumColour()
        {
            return _basicPaletteColours.MediumColour;
        }

        /// <summary>
        /// Sets the LightColour to the value of lightColour.
        /// </summary>
        /// <param name="lightColour">The value of lightColour.</param>
        public void SetLightColour(Color lightColour)
        {
            _basicPaletteColours.MediumColour = lightColour;
        }

        /// <summary>
        /// Gets the LightColour value.
        /// </summary>
        /// <returns>The value of lightColour.</returns>
        public Color GetLightColour()
        {
            return _basicPaletteColours.MediumColour;
        }

        /// <summary>
        /// Sets the LightestColour to the value of lightestColour.
        /// </summary>
        /// <param name="lightestColour">The value of lightestColour.</param>
        public void SetLightestColour(Color lightestColour)
        {
            _basicPaletteColours.LightColour = lightestColour;
        }

        /// <summary>
        /// Gets the LightestColour value.
        /// </summary>
        /// <returns>The value of lightestColour.</returns>
        public Color GetLightestColour()
        {
            return _basicPaletteColours.LightColour;
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
                DialogResult result = KryptonMessageBox.Show("Do you want to save the current basic colour settings?", "Save Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _basicPaletteColours.Save();
                }
                else
                {
                    ResetSettings(usePrompt);
                }
            }
            else
            {
                _basicPaletteColours.Save();
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
                DialogResult result = KryptonMessageBox.Show("This action will reset the base palette colour values. Do you want to continue?", "Reset Base Palette Colour Values", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
            SetBaseColour(Color.White);

            SetDarkestColour(Color.White);

            SetMediumColour(Color.White);

            SetLightColour(Color.White);

            SetLightestColour(Color.White);
        }
        #endregion

        #region Detection        
        /// <summary>
        /// Are the basic palette colours empty.
        /// </summary>
        /// <returns></returns>
        public static bool AreBasicPaletteColoursEmpty()
        {
            BasicPaletteColourManager basicPaletteColourManager = new BasicPaletteColourManager();

            if (basicPaletteColourManager.GetBaseColour() == Color.Empty || basicPaletteColourManager.GetDarkestColour() == Color.Empty || basicPaletteColourManager.GetMediumColour() == Color.Empty || basicPaletteColourManager.GetLightColour() == Color.Empty || basicPaletteColourManager.GetLightestColour() == Color.Empty)
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