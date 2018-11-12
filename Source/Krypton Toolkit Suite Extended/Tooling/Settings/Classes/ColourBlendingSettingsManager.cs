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
        #endregion
    }
}