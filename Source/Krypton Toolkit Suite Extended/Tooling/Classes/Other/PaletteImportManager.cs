using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;
using Tooling.Settings.Classes;

namespace Tooling.Classes.Other
{
    public class PaletteImportManager
    {
        #region Variables
        private KryptonPalette _palette;

        private ColourSettingsManager _colourSettingsManager = new ColourSettingsManager();

        private GlobalStringSettingsManager _globalStringSettingsManager = new GlobalStringSettingsManager();
        #endregion

        #region Constructors
        public PaletteImportManager()
        {

        }
        #endregion

        #region Methods
        public void ImportColourScheme(KryptonPalette palette)
        {
            try
            {
                //palette = new KryptonPalette();

                //palette.Import();

                _colourSettingsManager.SetBaseColour(palette.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color1);

                _colourSettingsManager.SetDarkestColour(palette.ButtonStyles.ButtonCluster.StatePressed.Back.Color1);

                _colourSettingsManager.SetMediumColour(palette.ButtonStyles.ButtonCluster.StateNormal.Back.Color1);

                _colourSettingsManager.SetLightColour(palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color2);

                _colourSettingsManager.SetLightestColour(palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1);

                _colourSettingsManager.SetBorderColour(Color.Gray); // Need work

                _colourSettingsManager.SetAlternativeNormalTextColour(palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.LongText.Color1);

                _colourSettingsManager.SetNormalTextColour(palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.LongText.Color1);

                _colourSettingsManager.SetDisabledTextColour(palette.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Color1);

                _colourSettingsManager.SetDisabledColour(palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1);

                _colourSettingsManager.SetLinkNormalColour(palette.LabelStyles.LabelNormalControl.OverrideNotVisited.LongText.Color1);

                _colourSettingsManager.SetLinkHoverColour(palette.LabelStyles.LabelNormalControl.OverridePressed.LongText.Color1);

                _colourSettingsManager.SetLinkVisitedColour(palette.LabelStyles.LabelNormalControl.OverrideVisited.LongText.Color1);



                _colourSettingsManager.SetMenuTextColour(palette.ToolMenuStatus.Menu.MenuItemText);

                _colourSettingsManager.SetStatusTextColour(palette.ToolMenuStatus.StatusStrip.StatusStripText);

                _colourSettingsManager.SaveColourSettings();

                _globalStringSettingsManager.SetBasePaletteMode(palette.BasePaletteMode.ToString());

                _globalStringSettingsManager.SetFeedbackText("The import was successful.");

                _globalStringSettingsManager.SaveStringSettings();
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show($"Error: { exc.Message }", "Palette Import Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _globalStringSettingsManager.SetFeedbackText("Failed to import colours!");

                _globalStringSettingsManager.SaveStringSettings();
            }
        }

        public void ImportColourScheme()
        {
            try
            {
                _palette = new KryptonPalette();

                _palette.Import();

                _colourSettingsManager.SetBaseColour(_palette.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color1);

                _colourSettingsManager.SetDarkestColour(_palette.ButtonStyles.ButtonCluster.StatePressed.Back.Color1);

                _colourSettingsManager.SetMediumColour(_palette.ButtonStyles.ButtonCluster.StateNormal.Back.Color1);

                _colourSettingsManager.SetLightColour(_palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color2);

                _colourSettingsManager.SetLightestColour(_palette.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1);

                _colourSettingsManager.SetBorderColour(Color.Gray); // Need work

                _colourSettingsManager.SetAlternativeNormalTextColour(_palette.ButtonStyles.ButtonCommon.OverrideDefault.Content.LongText.Color1);

                _colourSettingsManager.SetNormalTextColour(_palette.ButtonStyles.ButtonCommon.StateCheckedNormal.Content.LongText.Color1);

                _colourSettingsManager.SetDisabledTextColour(_palette.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Color1);

                _colourSettingsManager.SetDisabledColour(_palette.ButtonStyles.ButtonCommon.StateDisabled.Back.Color1);

                _colourSettingsManager.SetLinkNormalColour(_palette.LabelStyles.LabelNormalControl.OverrideNotVisited.LongText.Color1);

                _colourSettingsManager.SetLinkHoverColour(_palette.LabelStyles.LabelNormalControl.OverridePressed.LongText.Color1);

                _colourSettingsManager.SetLinkVisitedColour(_palette.LabelStyles.LabelNormalControl.OverrideVisited.LongText.Color1);



                _colourSettingsManager.SetMenuTextColour(_palette.ToolMenuStatus.Menu.MenuItemText);

                _colourSettingsManager.SetStatusTextColour(_palette.ToolMenuStatus.StatusStrip.StatusStripText);

                _colourSettingsManager.SaveColourSettings();

                _globalStringSettingsManager.SetBasePaletteMode(_palette.BasePaletteMode.ToString());

                _globalStringSettingsManager.SetFeedbackText("The import was successful.");

                _globalStringSettingsManager.SaveStringSettings();
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show($"Error: { exc.Message }", "_palette Import Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _globalStringSettingsManager.SetFeedbackText("Failed to import colours!");

                _globalStringSettingsManager.SaveStringSettings();
            }
        }
        #endregion
    }
}