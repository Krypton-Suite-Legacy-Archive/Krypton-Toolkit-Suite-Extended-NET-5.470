using System.Drawing;

namespace Core.Settings.Classes
{
    public class PaletteTypefaceSettingsManager
    {
        #region Variables
        private PaletteTypefaceSettings _paletteTypefaceSettings = new PaletteTypefaceSettings();
        #endregion

        #region Constructors
        public PaletteTypefaceSettingsManager()
        {

        }
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the GlobalPaletteTypeface to the value of value.
        /// </summary>
        /// <param name="value">The value of GlobalPaletteTypeface.</param>
        public void SetGlobalPaletteTypeface(Font value)
        {
            _paletteTypefaceSettings.GlobalPaletteTypeface = value;
        }

        /// <summary>
        /// Gets the GlobalPaletteTypeface value.
        /// </summary>
        /// <returns>The value of GlobalPaletteTypeface.</returns>
        public Font GetGlobalPaletteTypeface()
        {
            return _paletteTypefaceSettings.GlobalPaletteTypeface;
        }
        #endregion

        #region Save Settings
        public void SavePaletteTypefaceSettings(bool usePrompt = false)
        {

        }
        #endregion

        #region Reset Settings
        public void ResetPaletteTypefaceSettings(bool usePrompt = false)
        {

        }

        private void ResetPaletteTypefaceSettings()
        {
            SetGlobalPaletteTypeface(new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular));
        }
        #endregion
    }
}