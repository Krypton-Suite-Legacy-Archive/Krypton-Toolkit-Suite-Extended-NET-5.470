using Core.Classes;
using PaletteExplorer.Enumerations;
using System.IO;
using ToolkitSettings.Classes.PaletteExplorer.Colours;

namespace PaletteExplorer.Classes
{
    public class ColourConfigurationFileManager
    {
        #region Constructor
        public ColourConfigurationFileManager()
        {

        }
        #endregion

        #region Methods               
        /// <summary>
        /// Saves the colour configuration file.
        /// </summary>
        /// <param name="settingsType">Type of the settings.</param>
        /// <param name="basePath">The base path.</param>
        /// <param name="useConfirmationDialog">if set to <c>true</c> [use confirmation dialog].</param>
        public static void SaveColourConfigurationFile(ColourSettingsType settingsType, string basePath, bool useConfirmationDialog = false)
        {
            #region Variables
            string path = null;
            #endregion

            if (useConfirmationDialog)
            {
                #region Stuff
                switch (settingsType)
                {
                    case ColourSettingsType.ALLCOLOURSETTINGS:
                        path = $"{ basePath }\\All Colours Configuration File - { TranslationMethods.ReturnSafeFileNameDateTimeString() }";

                        File.Create(path);

                        AllMergedColourSettingsManager.WriteRGBColoursToFile(path);
                        break;
                    case ColourSettingsType.BASICCOLOURSETTINGS:
                        path = $"{ basePath }\\Basic Colours Configuration File - { TranslationMethods.ReturnSafeFileNameDateTimeString() }";

                        File.Create(path);

                        BasicColourSettingsManager.WriteRGBColoursToFile(path);
                        break;
                    case ColourSettingsType.CUSTOMCOLOURSETTINGS:
                        path = $"{ basePath }\\Custom Colours Configuration File - { TranslationMethods.ReturnSafeFileNameDateTimeString() }";

                        File.Create(path);

                        CustomColourSettingsManager.WriteRGBColoursToFile(path);
                        break;
                    case ColourSettingsType.CUSTOMTEXTCOLOURSETTINGS:
                        path = $"{ basePath }\\Custom Text Colours Configuration File - { TranslationMethods.ReturnSafeFileNameDateTimeString() }";

                        File.Create(path);

                        CustomTextColourSettingsManager.WriteRGBColoursToFile(path);
                        break;
                    case ColourSettingsType.LINKTEXTCOLOURSETTINGS:
                        path = $"{ basePath }\\Link Text Colours Configuration File - { TranslationMethods.ReturnSafeFileNameDateTimeString() }";

                        File.Create(path);

                        LinkTextColourSettingsManager.WriteRGBColoursToFile(path);
                        break;
                    case ColourSettingsType.MISCELLANEOUSCOLOURSETTINGS:
                        path = $"{ basePath }\\Miscellaneous Colours Configuration File - { TranslationMethods.ReturnSafeFileNameDateTimeString() }";

                        File.Create(path);

                        MiscellaneousColourSettingsManager.WriteRGBColoursToFile(path);
                        break;
                    case ColourSettingsType.STANDARDCONTROLTEXTCOLOURSETTINGS:
                        path = $"{ basePath }\\Standard Control Text Colours Configuration File - { TranslationMethods.ReturnSafeFileNameDateTimeString() }";

                        File.Create(path);

                        StandardControlTextColourSettingsManager.WriteRGBColoursToFile(path);
                        break;
                    case ColourSettingsType.TEXTCOLOURSETTINGS:
                        path = $"{ basePath }\\Text Colours Configuration File - { TranslationMethods.ReturnSafeFileNameDateTimeString() }";

                        File.Create(path);

                        TextColourSettingsManager.WriteRGBColoursToFile(path);
                        break;
                }
                #endregion
            }
            else
            {
                #region Stuff
                switch (settingsType)
                {
                    case ColourSettingsType.ALLCOLOURSETTINGS:
                        path = $"{ basePath }\\All Colours Configuration File - { TranslationMethods.ReturnSafeFileNameDateTimeString() }";

                        File.Create(path);

                        AllMergedColourSettingsManager.WriteRGBColoursToFile(path);
                        break;
                    case ColourSettingsType.BASICCOLOURSETTINGS:
                        path = $"{ basePath }\\Basic Colours Configuration File - { TranslationMethods.ReturnSafeFileNameDateTimeString() }";

                        File.Create(path);

                        BasicColourSettingsManager.WriteRGBColoursToFile(path);
                        break;
                    case ColourSettingsType.CUSTOMCOLOURSETTINGS:
                        path = $"{ basePath }\\Custom Colours Configuration File - { TranslationMethods.ReturnSafeFileNameDateTimeString() }";

                        File.Create(path);

                        CustomColourSettingsManager.WriteRGBColoursToFile(path);
                        break;
                    case ColourSettingsType.CUSTOMTEXTCOLOURSETTINGS:
                        path = $"{ basePath }\\Custom Text Colours Configuration File - { TranslationMethods.ReturnSafeFileNameDateTimeString() }";

                        File.Create(path);

                        CustomTextColourSettingsManager.WriteRGBColoursToFile(path);
                        break;
                    case ColourSettingsType.LINKTEXTCOLOURSETTINGS:
                        path = $"{ basePath }\\Link Text Colours Configuration File - { TranslationMethods.ReturnSafeFileNameDateTimeString() }";

                        File.Create(path);

                        LinkTextColourSettingsManager.WriteRGBColoursToFile(path);
                        break;
                    case ColourSettingsType.MISCELLANEOUSCOLOURSETTINGS:
                        path = $"{ basePath }\\Miscellaneous Colours Configuration File - { TranslationMethods.ReturnSafeFileNameDateTimeString() }";

                        File.Create(path);

                        MiscellaneousColourSettingsManager.WriteRGBColoursToFile(path);
                        break;
                    case ColourSettingsType.STANDARDCONTROLTEXTCOLOURSETTINGS:
                        path = $"{ basePath }\\Standard Control Text Colours Configuration File - { TranslationMethods.ReturnSafeFileNameDateTimeString() }";

                        File.Create(path);

                        StandardControlTextColourSettingsManager.WriteRGBColoursToFile(path);
                        break;
                    case ColourSettingsType.TEXTCOLOURSETTINGS:
                        path = $"{ basePath }\\Text Colours Configuration File - { TranslationMethods.ReturnSafeFileNameDateTimeString() }";

                        File.Create(path);

                        TextColourSettingsManager.WriteRGBColoursToFile(path);
                        break;
                }
                #endregion
            }
        }
        #endregion
    }
}