using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;
using Tooling.Enumerations;
using Tooling.Settings.Classes;

namespace Tooling.Classes.Other
{
    public class ColourSettingsManagementEngine
    {
        #region Constructor
        public ColourSettingsManagementEngine()
        {

        }
        #endregion

        #region Methods
        public static void SetColourSettingsAsColour(AllAvailableColourTypes colourType, Color colour)
        {
            ColourSettingsManager colourSettingsManager = new ColourSettingsManager();

            switch (colourType)
            {
                case AllAvailableColourTypes.ALTERNATIVENORMALTEXTCOLOUR:
                    break;
                case AllAvailableColourTypes.BASECOLOUR:
                    break;
                case AllAvailableColourTypes.BORDERCOLOUR:
                    break;
                case AllAvailableColourTypes.CUSTOMCOLOURONE:
                    break;
                case AllAvailableColourTypes.CUSTOMCOLOURTWO:
                    break;
                case AllAvailableColourTypes.CUSTOMCOLOURTHREE:
                    break;
                case AllAvailableColourTypes.CUSTOMCOLOURFOUR:
                    break;
                case AllAvailableColourTypes.CUSTOMCOLOURFIVE:
                    break;
                case AllAvailableColourTypes.CUSTOMTEXTCOLOURONE:
                    break;
                case AllAvailableColourTypes.CUSTOMTEXTCOLOURTWO:
                    break;
                case AllAvailableColourTypes.CUSTOMTEXTCOLOURTHREE:
                    break;
                case AllAvailableColourTypes.CUSTOMTEXTCOLOURFOUR:
                    break;
                case AllAvailableColourTypes.CUSTOMTEXTCOLOURFIVE:
                    break;
                case AllAvailableColourTypes.DARKESTCOLOUR:
                    break;
                case AllAvailableColourTypes.DISABLEDCOLOUR:
                    break;
                case AllAvailableColourTypes.DISABLEDTEXTCOLOUR:
                    break;
                case AllAvailableColourTypes.FOCUSEDTEXTCOLOUR:
                    break;
                case AllAvailableColourTypes.LIGHTCOLOUR:
                    break;
                case AllAvailableColourTypes.LIGHTESTCOLOUR:
                    break;
                case AllAvailableColourTypes.LINKDISABLEDCOLOUR:
                    break;
                case AllAvailableColourTypes.LINKHOVERCOLOUR:
                    break;
                case AllAvailableColourTypes.LINKNORMALCOLOUR:
                    break;
                case AllAvailableColourTypes.LINKVISITEDCOLOUR:
                    break;
                case AllAvailableColourTypes.MEDIUMCOLOUR:
                    break;
                case AllAvailableColourTypes.MENUTEXTCOLOUR:
                    break;
                case AllAvailableColourTypes.NORMALTEXTCOLOUR:
                    break;
                case AllAvailableColourTypes.PRESSEDTEXTCOLOUR:
                    break;
                case AllAvailableColourTypes.STATUSTEXTCOLOUR:
                    break;
                default:
                    break;
            }
        }

        public static void SetColourSettingsAsString(AllAvailableColourTypes colourType, Color colour)
        {
            ColourStringSettingsManager colourStringSettingsManager = new ColourStringSettingsManager();

            switch (colourType)
            {
                case AllAvailableColourTypes.ALTERNATIVENORMALTEXTCOLOUR:
                    break;
                case AllAvailableColourTypes.BASECOLOUR:
                    break;
                case AllAvailableColourTypes.BORDERCOLOUR:
                    break;
                case AllAvailableColourTypes.CUSTOMCOLOURONE:
                    break;
                case AllAvailableColourTypes.CUSTOMCOLOURTWO:
                    break;
                case AllAvailableColourTypes.CUSTOMCOLOURTHREE:
                    break;
                case AllAvailableColourTypes.CUSTOMCOLOURFOUR:
                    break;
                case AllAvailableColourTypes.CUSTOMCOLOURFIVE:
                    break;
                case AllAvailableColourTypes.CUSTOMTEXTCOLOURONE:
                    break;
                case AllAvailableColourTypes.CUSTOMTEXTCOLOURTWO:
                    break;
                case AllAvailableColourTypes.CUSTOMTEXTCOLOURTHREE:
                    break;
                case AllAvailableColourTypes.CUSTOMTEXTCOLOURFOUR:
                    break;
                case AllAvailableColourTypes.CUSTOMTEXTCOLOURFIVE:
                    break;
                case AllAvailableColourTypes.DARKESTCOLOUR:
                    break;
                case AllAvailableColourTypes.DISABLEDCOLOUR:
                    break;
                case AllAvailableColourTypes.DISABLEDTEXTCOLOUR:
                    break;
                case AllAvailableColourTypes.FOCUSEDTEXTCOLOUR:
                    break;
                case AllAvailableColourTypes.LIGHTCOLOUR:
                    break;
                case AllAvailableColourTypes.LIGHTESTCOLOUR:
                    break;
                case AllAvailableColourTypes.LINKDISABLEDCOLOUR:
                    break;
                case AllAvailableColourTypes.LINKHOVERCOLOUR:
                    break;
                case AllAvailableColourTypes.LINKNORMALCOLOUR:
                    break;
                case AllAvailableColourTypes.LINKVISITEDCOLOUR:
                    break;
                case AllAvailableColourTypes.MEDIUMCOLOUR:
                    break;
                case AllAvailableColourTypes.MENUTEXTCOLOUR:
                    break;
                case AllAvailableColourTypes.NORMALTEXTCOLOUR:
                    break;
                case AllAvailableColourTypes.PRESSEDTEXTCOLOUR:
                    break;
                case AllAvailableColourTypes.STATUSTEXTCOLOUR:
                    break;
                default:
                    break;
            }
        }

        public static void SetBasicColours(BasicPaletteColourDefinitions basicPaletteColourDefinition, Color colour)
        {
            ColourSettingsManager colourSettingsManager = new ColourSettingsManager();

            switch (basicPaletteColourDefinition)
            {
                case BasicPaletteColourDefinitions.BASECOLOUR:
                    break;
                case BasicPaletteColourDefinitions.DARKESTCOLOUR:
                    break;
                case BasicPaletteColourDefinitions.MIDDLECOLOUR:
                    break;
                case BasicPaletteColourDefinitions.LIGHTCOLOUR:
                    break;
                case BasicPaletteColourDefinitions.LIGHTESTCOLOUR:
                    break;
                default:
                    break;
            }
        }


        public static Color RetrieveSelectedColour(AllAvailableColourTypes colourType)
        {
            Color tempColour = Color.White;

            ColourSettingsManager colourSettingsManager = new ColourSettingsManager();

            try
            {
                switch (colourType)
                {
                    case AllAvailableColourTypes.ALTERNATIVENORMALTEXTCOLOUR:
                        tempColour = colourSettingsManager.GetAlternativeNormalTextColour();
                        break;
                    case AllAvailableColourTypes.BASECOLOUR:
                        break;
                    case AllAvailableColourTypes.BORDERCOLOUR:
                        break;
                    case AllAvailableColourTypes.CUSTOMCOLOURONE:
                        break;
                    case AllAvailableColourTypes.CUSTOMCOLOURTWO:
                        break;
                    case AllAvailableColourTypes.CUSTOMCOLOURTHREE:
                        break;
                    case AllAvailableColourTypes.CUSTOMCOLOURFOUR:
                        break;
                    case AllAvailableColourTypes.CUSTOMCOLOURFIVE:
                        break;
                    case AllAvailableColourTypes.CUSTOMTEXTCOLOURONE:
                        break;
                    case AllAvailableColourTypes.CUSTOMTEXTCOLOURTWO:
                        break;
                    case AllAvailableColourTypes.CUSTOMTEXTCOLOURTHREE:
                        break;
                    case AllAvailableColourTypes.CUSTOMTEXTCOLOURFOUR:
                        break;
                    case AllAvailableColourTypes.CUSTOMTEXTCOLOURFIVE:
                        break;
                    case AllAvailableColourTypes.DARKESTCOLOUR:
                        break;
                    case AllAvailableColourTypes.DISABLEDCOLOUR:
                        break;
                    case AllAvailableColourTypes.DISABLEDTEXTCOLOUR:
                        break;
                    case AllAvailableColourTypes.FOCUSEDTEXTCOLOUR:
                        break;
                    case AllAvailableColourTypes.LIGHTCOLOUR:
                        break;
                    case AllAvailableColourTypes.LIGHTESTCOLOUR:
                        break;
                    case AllAvailableColourTypes.LINKDISABLEDCOLOUR:
                        break;
                    case AllAvailableColourTypes.LINKHOVERCOLOUR:
                        break;
                    case AllAvailableColourTypes.LINKNORMALCOLOUR:
                        break;
                    case AllAvailableColourTypes.LINKVISITEDCOLOUR:
                        break;
                    case AllAvailableColourTypes.MEDIUMCOLOUR:
                        break;
                    case AllAvailableColourTypes.MENUTEXTCOLOUR:
                        break;
                    case AllAvailableColourTypes.NORMALTEXTCOLOUR:
                        break;
                    case AllAvailableColourTypes.PRESSEDTEXTCOLOUR:
                        break;
                    case AllAvailableColourTypes.STATUSTEXTCOLOUR:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show($"An unexpected error has occurred: { exc.Message }", "Retrieving Settings Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tempColour = Color.Black;
            }

            return tempColour;
        }

        public static void RetrieveAllColourSettingsAsColour()
        {
            ColourSettingsManager colourSettingsManager = new ColourSettingsManager();

            try
            {

            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show($"An unexpected error has occurred: { exc.Message }", "Retrieving Settings Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}