using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace Tooling.Settings.Classes
{
    public class ColourBlendingSettingsManager
    {
        #region Variables
        private ColourBlendingSettings _colourBlendingSettings = new ColourBlendingSettings();
        #endregion

        #region Constructors
        public ColourBlendingSettingsManager()
        {

        }

        public ColourBlendingSettingsManager(float darkestColourIntensity, float mediumColourIntensity, float lightColourIntensity, float lightestColourIntensity)
        {
            SetDarkestColourIntensity(darkestColourIntensity);

            SetMediumColourIntensity(mediumColourIntensity);

            SetLightColourIntensity(lightColourIntensity);

            SetLightestColourIntensity(lightestColourIntensity);
        }
        #endregion

        #region Setters/Getters
        /// <summary>
        /// Sets the DarkestColourIntensity to the value of value.
        /// </summary>
        /// <param name="value">The value of value.</param>
        public void SetDarkestColourIntensity(float value)
        {
            _colourBlendingSettings.DarkestColourIntensity = value;
        }

        /// <summary>
        /// Gets the DarkestColourIntensity value.
        /// </summary>
        /// <returns>The value of value.</returns>
        public float GetDarkestColourIntensity()
        {
            return _colourBlendingSettings.DarkestColourIntensity;
        }

        /// <summary>
        /// Sets the MediumColourIntensity to the value of value.
        /// </summary>
        /// <param name="value">The value of value.</param>
        public void SetMediumColourIntensity(float value)
        {
            _colourBlendingSettings.MediumColourIntensity = value;
        }

        /// <summary>
        /// Gets the MediumColourIntensity value.
        /// </summary>
        /// <returns>The value of value.</returns>
        public float GetMediumColourIntensity()
        {
            return _colourBlendingSettings.MediumColourIntensity;
        }

        /// <summary>
        /// Sets the LightColourIntensity to the value of value.
        /// </summary>
        /// <param name="value">The value of value.</param>
        public void SetLightColourIntensity(float value)
        {
            _colourBlendingSettings.LightColourIntensity = value;
        }

        /// <summary>
        /// Gets the LightColourIntensity value.
        /// </summary>
        /// <returns>The value of value.</returns>
        public float GetLightColourIntensity()
        {
            return _colourBlendingSettings.LightColourIntensity;
        }

        /// <summary>
        /// Sets the LightestColourIntensity to the value of value.
        /// </summary>
        /// <param name="value">The value of value.</param>
        public void SetLightestColourIntensity(float value)
        {
            _colourBlendingSettings.LightestColourIntensity = value;
        }

        /// <summary>
        /// Gets the LightestColourIntensity value.
        /// </summary>
        /// <returns>The value of value.</returns>
        public float GetLightestColourIntensity()
        {
            return _colourBlendingSettings.LightestColourIntensity;
        }

        /// <summary>
        /// Sets the BaseColour to the value of value.
        /// </summary>
        /// <param name="value">The value of value.</param>
        public void SetBaseColour(Color value)
        {
            _colourBlendingSettings.BaseColour = value;
        }

        /// <summary>
        /// Gets the BaseColour value.
        /// </summary>
        /// <returns>The value of value.</returns>
        public Color GetBaseColour()
        {
            return _colourBlendingSettings.BaseColour;
        }
        #endregion

        #region Methods        
        /// <summary>Resets the colour blending settings.</summary>
        /// <param name="usePrompt">Ask the user for confirmation.</param>
        public void ResetColourBlendingValues(bool usePrompt = false)
        {
            if (usePrompt)
            {
                DialogResult result = KryptonMessageBox.Show("This action will reset the colour blending values. Do you want to continue?", "Reset Colour Blending Values", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ResetColourBlendingValues();
                }
            }
            else
            {
                ResetColourBlendingValues();
            }

            SaveColourBlendingValues(usePrompt);
        }

        private void ResetColourBlendingValues()
        {
            SetDarkestColourIntensity(0.5f);

            SetMediumColourIntensity(0.25f);

            SetLightColourIntensity(0.25f);

            SetLightestColourIntensity(0.5f);

            SetBaseColour(Color.Black);
        }

        public void SaveColourBlendingValues(bool usePrompt = false)
        {
            if (usePrompt)
            {
                DialogResult result = KryptonMessageBox.Show("Do you want to save the current colour blending settings?", "Save Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _colourBlendingSettings.Save();
                }
                else
                {
                    ResetColourBlendingValues();
                }
            }
            else
            {
                _colourBlendingSettings.Save();
            }
        }
        #endregion
    }
}