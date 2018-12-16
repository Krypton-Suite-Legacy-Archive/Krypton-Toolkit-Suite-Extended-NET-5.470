using ComponentFactory.Krypton.Toolkit;
using Core.Settings.Colours.Classes;
using System;
using System.Windows.Forms;

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

            if (usePrompt)
            {
                DialogResult response = KryptonMessageBox.Show("This action will merge all your colour settings together.\n\nDo you want to continue?", "Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (response == DialogResult.Yes)
                {
                    try
                    {
                        if (BasicPaletteColourManager.AreBasicPaletteColoursEmpty() != false)
                        {
                            colourSettingsManager.SetBaseColour(basicPaletteColourManager.GetBaseColour());

                            colourSettingsManager.SetDarkestColour(basicPaletteColourManager.GetDarkestColour());

                            colourSettingsManager.SetLightColour(basicPaletteColourManager.GetLightColour());

                            colourSettingsManager.SetLightestColour(basicPaletteColourManager.GetLightestColour());
                        }
                        else
                        {
                            basicPaletteColourManager.ResetSettings(true);

                            colourSettingsManager.SetBaseColour(basicPaletteColourManager.GetBaseColour());

                            colourSettingsManager.SetDarkestColour(basicPaletteColourManager.GetDarkestColour());

                            colourSettingsManager.SetLightColour(basicPaletteColourManager.GetLightColour());

                            colourSettingsManager.SetLightestColour(basicPaletteColourManager.GetLightestColour());
                        }

                        if (CustomPaletteColourManager.AreCustomPaletteColoursEmpty() != false)
                        {
                            colourSettingsManager.SetCustomColourOne(customPaletteColourManager.GetCustomColourOne());

                            colourSettingsManager.SetCustomColourTwo(customPaletteColourManager.GetCustomColourTwo());

                            colourSettingsManager.SetCustomColourThree(customPaletteColourManager.GetCustomColourThree());

                            colourSettingsManager.SetCustomColourFour(customPaletteColourManager.GetCustomColourFour());

                            colourSettingsManager.SetCustomColourFive(customPaletteColourManager.GetCustomColourFive());
                        }
                        else
                        {
                            customPaletteColourManager.ResetSettings(true);

                            colourSettingsManager.SetCustomColourOne(customPaletteColourManager.GetCustomColourOne());

                            colourSettingsManager.SetCustomColourTwo(customPaletteColourManager.GetCustomColourTwo());

                            colourSettingsManager.SetCustomColourThree(customPaletteColourManager.GetCustomColourThree());

                            colourSettingsManager.SetCustomColourFour(customPaletteColourManager.GetCustomColourFour());

                            colourSettingsManager.SetCustomColourFive(customPaletteColourManager.GetCustomColourFive());
                        }

                        if (CustomPaletteTextColourManager.AreCustomPaletteTextColoursEmpty() != false)
                        {
                            colourSettingsManager.SetCustomTextColourOne(customPaletteTextColourManager.GetCustomTextColourOne());

                            colourSettingsManager.SetCustomTextColourTwo(customPaletteTextColourManager.GetCustomTextColourTwo());

                            colourSettingsManager.SetCustomTextColourThree(customPaletteTextColourManager.GetCustomTextColourThree());

                            colourSettingsManager.SetCustomTextColourFour(customPaletteTextColourManager.GetCustomTextColourFour());

                            colourSettingsManager.SetCustomTextColourFive(customPaletteTextColourManager.GetCustomTextColourFive());
                        }
                        else
                        {
                            customPaletteTextColourManager.ResetSettings(true);

                            colourSettingsManager.SetCustomTextColourOne(customPaletteTextColourManager.GetCustomTextColourOne());

                            colourSettingsManager.SetCustomTextColourTwo(customPaletteTextColourManager.GetCustomTextColourTwo());

                            colourSettingsManager.SetCustomTextColourThree(customPaletteTextColourManager.GetCustomTextColourThree());

                            colourSettingsManager.SetCustomTextColourFour(customPaletteTextColourManager.GetCustomTextColourFour());

                            colourSettingsManager.SetCustomTextColourFive(customPaletteTextColourManager.GetCustomTextColourFive());
                        }

                        if (LinkTextPaletteColourManager.AreLinkTextPaletteColoursEmpty() != false)
                        {
                            colourSettingsManager.SetLinkDisabledColour(linkTextPaletteColourManager.GetLinkDisabledColour());

                            colourSettingsManager.SetLinkFocusedColour(linkTextPaletteColourManager.GetLinkFocusedColour());

                            colourSettingsManager.SetLinkHoverColour(linkTextPaletteColourManager.GetLinkHoverColour());

                            colourSettingsManager.SetLinkNormalColour(linkTextPaletteColourManager.GetLinkNormalColour());

                            colourSettingsManager.SetLinkVisitedColour(linkTextPaletteColourManager.GetLinkVisitedColour());
                        }
                        else
                        {
                            linkTextPaletteColourManager.ResetSettings(true);

                            colourSettingsManager.SetLinkDisabledColour(linkTextPaletteColourManager.GetLinkDisabledColour());

                            colourSettingsManager.SetLinkFocusedColour(linkTextPaletteColourManager.GetLinkFocusedColour());

                            colourSettingsManager.SetLinkHoverColour(linkTextPaletteColourManager.GetLinkHoverColour());

                            colourSettingsManager.SetLinkNormalColour(linkTextPaletteColourManager.GetLinkNormalColour());

                            colourSettingsManager.SetLinkVisitedColour(linkTextPaletteColourManager.GetLinkVisitedColour());
                        }

                        if (MiscellaneousPaletteColourManager.AreMiscellaneousPaletteColoursEmpty() != false)
                        {
                            colourSettingsManager.SetBorderColour(miscellaneousPaletteColourManager.GetBorderColour());

                            colourSettingsManager.SetDisabledControlColour(miscellaneousPaletteColourManager.GetDisabledControlColour());
                        }
                        else
                        {
                            miscellaneousPaletteColourManager.ResetSettings(true);

                            colourSettingsManager.SetBorderColour(miscellaneousPaletteColourManager.GetBorderColour());

                            colourSettingsManager.SetDisabledControlColour(miscellaneousPaletteColourManager.GetDisabledControlColour());
                        }

                        if (TextPaletteColourManager.AreTextPaletteColoursEmpty() != false)
                        {
                            colourSettingsManager.SetAlternativeNormalTextColour(textPaletteColourManager.GetAlternativeNormalTextColour());

                            colourSettingsManager.SetNormalTextColour(textPaletteColourManager.GetNormalTextColour());

                            colourSettingsManager.SetFocusedTextColour(textPaletteColourManager.GetFocusedTextColour());

                            colourSettingsManager.SetPressedTextColour(textPaletteColourManager.GetPressedTextColour());

                            colourSettingsManager.SetDisabledTextColour(textPaletteColourManager.GetDisabledTextColour());

                            colourSettingsManager.SetMenuTextColour(textPaletteColourManager.GetMenuTextColour());

                            colourSettingsManager.SetRibbonTabTextColour(textPaletteColourManager.GetRibbonTabTextColour());

                            colourSettingsManager.SetStatusStripTextColour(textPaletteColourManager.GetStatusStripTextColour());
                        }
                        else
                        {
                            textPaletteColourManager.ResetSettings(true);

                            colourSettingsManager.SetAlternativeNormalTextColour(textPaletteColourManager.GetAlternativeNormalTextColour());

                            colourSettingsManager.SetNormalTextColour(textPaletteColourManager.GetNormalTextColour());

                            colourSettingsManager.SetFocusedTextColour(textPaletteColourManager.GetFocusedTextColour());

                            colourSettingsManager.SetPressedTextColour(textPaletteColourManager.GetPressedTextColour());

                            colourSettingsManager.SetDisabledTextColour(textPaletteColourManager.GetDisabledTextColour());

                            colourSettingsManager.SetMenuTextColour(textPaletteColourManager.GetMenuTextColour());

                            colourSettingsManager.SetRibbonTabTextColour(textPaletteColourManager.GetRibbonTabTextColour());

                            colourSettingsManager.SetStatusStripTextColour(textPaletteColourManager.GetStatusStripTextColour());
                        }


                        colourSettingsManager.SaveColourSettings(true);
                    }
                    catch (Exception exc)
                    {
                        KryptonMessageBox.Show($"An unexpected error has occurred: { exc.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        colourSettingsManager.ResetSettings();
                    }
                }
                else
                {
                    try
                    {
                        if (BasicPaletteColourManager.AreBasicPaletteColoursEmpty() != false)
                        {
                            colourSettingsManager.SetBaseColour(basicPaletteColourManager.GetBaseColour());

                            colourSettingsManager.SetDarkestColour(basicPaletteColourManager.GetDarkestColour());

                            colourSettingsManager.SetLightColour(basicPaletteColourManager.GetLightColour());

                            colourSettingsManager.SetLightestColour(basicPaletteColourManager.GetLightestColour());
                        }
                        else
                        {
                            basicPaletteColourManager.ResetSettings();

                            colourSettingsManager.SetBaseColour(basicPaletteColourManager.GetBaseColour());

                            colourSettingsManager.SetDarkestColour(basicPaletteColourManager.GetDarkestColour());

                            colourSettingsManager.SetLightColour(basicPaletteColourManager.GetLightColour());

                            colourSettingsManager.SetLightestColour(basicPaletteColourManager.GetLightestColour());
                        }

                        if (CustomPaletteColourManager.AreCustomPaletteColoursEmpty() != false)
                        {
                            colourSettingsManager.SetCustomColourOne(customPaletteColourManager.GetCustomColourOne());

                            colourSettingsManager.SetCustomColourTwo(customPaletteColourManager.GetCustomColourTwo());

                            colourSettingsManager.SetCustomColourThree(customPaletteColourManager.GetCustomColourThree());

                            colourSettingsManager.SetCustomColourFour(customPaletteColourManager.GetCustomColourFour());

                            colourSettingsManager.SetCustomColourFive(customPaletteColourManager.GetCustomColourFive());
                        }
                        else
                        {
                            customPaletteColourManager.ResetSettings();

                            colourSettingsManager.SetCustomColourOne(customPaletteColourManager.GetCustomColourOne());

                            colourSettingsManager.SetCustomColourTwo(customPaletteColourManager.GetCustomColourTwo());

                            colourSettingsManager.SetCustomColourThree(customPaletteColourManager.GetCustomColourThree());

                            colourSettingsManager.SetCustomColourFour(customPaletteColourManager.GetCustomColourFour());

                            colourSettingsManager.SetCustomColourFive(customPaletteColourManager.GetCustomColourFive());
                        }

                        if (CustomPaletteTextColourManager.AreCustomPaletteTextColoursEmpty() != false)
                        {
                            colourSettingsManager.SetCustomTextColourOne(customPaletteTextColourManager.GetCustomTextColourOne());

                            colourSettingsManager.SetCustomTextColourTwo(customPaletteTextColourManager.GetCustomTextColourTwo());

                            colourSettingsManager.SetCustomTextColourThree(customPaletteTextColourManager.GetCustomTextColourThree());

                            colourSettingsManager.SetCustomTextColourFour(customPaletteTextColourManager.GetCustomTextColourFour());

                            colourSettingsManager.SetCustomTextColourFive(customPaletteTextColourManager.GetCustomTextColourFive());
                        }
                        else
                        {
                            customPaletteTextColourManager.ResetSettings();

                            colourSettingsManager.SetCustomTextColourOne(customPaletteTextColourManager.GetCustomTextColourOne());

                            colourSettingsManager.SetCustomTextColourTwo(customPaletteTextColourManager.GetCustomTextColourTwo());

                            colourSettingsManager.SetCustomTextColourThree(customPaletteTextColourManager.GetCustomTextColourThree());

                            colourSettingsManager.SetCustomTextColourFour(customPaletteTextColourManager.GetCustomTextColourFour());

                            colourSettingsManager.SetCustomTextColourFive(customPaletteTextColourManager.GetCustomTextColourFive());
                        }

                        if (LinkTextPaletteColourManager.AreLinkTextPaletteColoursEmpty() != false)
                        {
                            colourSettingsManager.SetLinkDisabledColour(linkTextPaletteColourManager.GetLinkDisabledColour());

                            colourSettingsManager.SetLinkFocusedColour(linkTextPaletteColourManager.GetLinkFocusedColour());

                            colourSettingsManager.SetLinkHoverColour(linkTextPaletteColourManager.GetLinkHoverColour());

                            colourSettingsManager.SetLinkNormalColour(linkTextPaletteColourManager.GetLinkNormalColour());

                            colourSettingsManager.SetLinkVisitedColour(linkTextPaletteColourManager.GetLinkVisitedColour());
                        }
                        else
                        {
                            linkTextPaletteColourManager.ResetSettings();

                            colourSettingsManager.SetLinkDisabledColour(linkTextPaletteColourManager.GetLinkDisabledColour());

                            colourSettingsManager.SetLinkFocusedColour(linkTextPaletteColourManager.GetLinkFocusedColour());

                            colourSettingsManager.SetLinkHoverColour(linkTextPaletteColourManager.GetLinkHoverColour());

                            colourSettingsManager.SetLinkNormalColour(linkTextPaletteColourManager.GetLinkNormalColour());

                            colourSettingsManager.SetLinkVisitedColour(linkTextPaletteColourManager.GetLinkVisitedColour());
                        }

                        if (MiscellaneousPaletteColourManager.AreMiscellaneousPaletteColoursEmpty() != false)
                        {
                            colourSettingsManager.SetBorderColour(miscellaneousPaletteColourManager.GetBorderColour());

                            colourSettingsManager.SetDisabledControlColour(miscellaneousPaletteColourManager.GetDisabledControlColour());
                        }
                        else
                        {
                            miscellaneousPaletteColourManager.ResetSettings();

                            colourSettingsManager.SetBorderColour(miscellaneousPaletteColourManager.GetBorderColour());

                            colourSettingsManager.SetDisabledControlColour(miscellaneousPaletteColourManager.GetDisabledControlColour());
                        }

                        if (TextPaletteColourManager.AreTextPaletteColoursEmpty() != false)
                        {
                            colourSettingsManager.SetAlternativeNormalTextColour(textPaletteColourManager.GetAlternativeNormalTextColour());

                            colourSettingsManager.SetNormalTextColour(textPaletteColourManager.GetNormalTextColour());

                            colourSettingsManager.SetFocusedTextColour(textPaletteColourManager.GetFocusedTextColour());

                            colourSettingsManager.SetPressedTextColour(textPaletteColourManager.GetPressedTextColour());

                            colourSettingsManager.SetDisabledTextColour(textPaletteColourManager.GetDisabledTextColour());

                            colourSettingsManager.SetMenuTextColour(textPaletteColourManager.GetMenuTextColour());

                            colourSettingsManager.SetRibbonTabTextColour(textPaletteColourManager.GetRibbonTabTextColour());

                            colourSettingsManager.SetStatusStripTextColour(textPaletteColourManager.GetStatusStripTextColour());
                        }
                        else
                        {
                            textPaletteColourManager.ResetSettings();

                            colourSettingsManager.SetAlternativeNormalTextColour(textPaletteColourManager.GetAlternativeNormalTextColour());

                            colourSettingsManager.SetNormalTextColour(textPaletteColourManager.GetNormalTextColour());

                            colourSettingsManager.SetFocusedTextColour(textPaletteColourManager.GetFocusedTextColour());

                            colourSettingsManager.SetPressedTextColour(textPaletteColourManager.GetPressedTextColour());

                            colourSettingsManager.SetDisabledTextColour(textPaletteColourManager.GetDisabledTextColour());

                            colourSettingsManager.SetMenuTextColour(textPaletteColourManager.GetMenuTextColour());

                            colourSettingsManager.SetRibbonTabTextColour(textPaletteColourManager.GetRibbonTabTextColour());

                            colourSettingsManager.SetStatusStripTextColour(textPaletteColourManager.GetStatusStripTextColour());
                        }


                        colourSettingsManager.SaveColourSettings(usePrompt);
                    }
                    catch (Exception exc)
                    {
                        KryptonMessageBox.Show($"An unexpected error has occurred: { exc.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        colourSettingsManager.ResetSettings();
                    }
                }
            }
        }
        #endregion
    }
}