using Core.Settings.Colours.Classes;

namespace Core.Settings.Classes
{
    public class GlobalSettingsManager
    {
        #region Constructor
        public GlobalSettingsManager()
        {

        }
        #endregion

        #region Methods        
        /// <summary>
        /// Merges all the colour settings together.
        /// </summary>
        /// <param name="usePrompt">if set to <c>true</c> [use prompt].</param>
        public static void MergeAllColourSettings(bool usePrompt = false)
        {
            #region Variables
            ColourSettingsManager colourSettingsManager = new ColourSettingsManager();

            BasicPaletteColourManager basicPaletteColourManager = new BasicPaletteColourManager();

            CustomPaletteColourManager customPaletteColourManager = new CustomPaletteColourManager();

            CustomPaletteTextColourManager customPaletteTextColourManager = new CustomPaletteTextColourManager();

            LinkTextPaletteColourManager linkTextPaletteColourManager = new LinkTextPaletteColourManager();

            MiscellaneousPaletteColourManager miscellaneousPaletteColourManager = new MiscellaneousPaletteColourManager();

            TextPaletteColourManager textPaletteColourManager = new TextPaletteColourManager();
            #endregion
        }
        #endregion
    }
}