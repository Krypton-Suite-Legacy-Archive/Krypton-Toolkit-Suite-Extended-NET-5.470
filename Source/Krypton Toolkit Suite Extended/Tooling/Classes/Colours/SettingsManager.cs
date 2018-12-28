using ComponentFactory.Krypton.Toolkit;
using Core.Settings.Classes;
using Core.Settings.Colours.Classes;
using GlobalUtilities.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Core.Classes.Colours
{
    public class SettingsManager
    {
        #region Variables

        #endregion

        #region Constructor
        public SettingsManager()
        {
        }
        #endregion

        #region Methods        
        /// <summary>
        /// Merges all colour settings together.
        /// </summary>
        /// <param name="usePrompt">if set to <c>true</c> [use prompt].</param>
        public static void MergeAllColourSettings(bool usePrompt = false)
        {
            #region Variables
            BasicPaletteColourManager basicPaletteColourManager = new BasicPaletteColourManager();

            CustomPaletteColourManager customPaletteColourManager = new CustomPaletteColourManager();

            CustomPaletteTextColourManager customPaletteTextColourManager = new CustomPaletteTextColourManager();

            LinkTextPaletteColourManager linkTextPaletteColourManager = new LinkTextPaletteColourManager();

            MiscellaneousPaletteColourManager miscellaneousPaletteColourManager = new MiscellaneousPaletteColourManager();

            TextPaletteColourManager textPaletteColourManager = new TextPaletteColourManager();

            ColourSettingsManager colourSettingsManager = new ColourSettingsManager();
            #endregion

            try
            {
                if (BasicPaletteColourManager.AreBasicPaletteColoursEmpty() || CustomPaletteColourManager.AreCustomPaletteColoursEmpty() || CustomPaletteTextColourManager.AreCustomPaletteTextColoursEmpty() || LinkTextPaletteColourManager.AreLinkTextPaletteColoursEmpty() || MiscellaneousPaletteColourManager.AreMiscellaneousPaletteColoursEmpty() || TextPaletteColourManager.AreTextPaletteColoursEmpty())
                {
                    KryptonMessageBox.Show("There are no colours to merge.", "Undefined Colours", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (usePrompt)
                    {
                        DialogResult result = KryptonMessageBox.Show("Do you want to merge all the colour settings together?", "Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            colourSettingsManager.SetAlternativeNormalTextColour(textPaletteColourManager.GetAlternativeNormalTextColour());

                            colourSettingsManager.SetBaseColour(basicPaletteColourManager.GetBaseColour());

                            colourSettingsManager.SetBorderColour(miscellaneousPaletteColourManager.GetBorderColour());

                            colourSettingsManager.SetCustomColourOne(customPaletteColourManager.GetCustomColourOne());

                            colourSettingsManager.SetCustomColourTwo(customPaletteColourManager.GetCustomColourTwo());

                            colourSettingsManager.SetCustomColourThree(customPaletteColourManager.GetCustomColourThree());

                            colourSettingsManager.SetCustomColourFour(customPaletteColourManager.GetCustomColourFour());

                            colourSettingsManager.SetCustomColourFive(customPaletteColourManager.GetCustomColourFive());

                            colourSettingsManager.SetCustomTextColourOne(customPaletteTextColourManager.GetCustomTextColourOne());

                            colourSettingsManager.SetCustomTextColourTwo(customPaletteTextColourManager.GetCustomTextColourTwo());

                            colourSettingsManager.SetCustomTextColourThree(customPaletteTextColourManager.GetCustomTextColourThree());

                            colourSettingsManager.SetCustomTextColourFour(customPaletteTextColourManager.GetCustomTextColourFour());

                            colourSettingsManager.SetCustomTextColourFive(customPaletteTextColourManager.GetCustomTextColourFive());

                            colourSettingsManager.SetDarkestColour(basicPaletteColourManager.GetDarkestColour());

                            colourSettingsManager.SetDisabledControlColour(miscellaneousPaletteColourManager.GetDisabledControlColour());

                            colourSettingsManager.SetDisabledTextColour(textPaletteColourManager.GetDisabledTextColour());

                            colourSettingsManager.SetFocusedTextColour(textPaletteColourManager.GetFocusedTextColour());

                            colourSettingsManager.SetLightColour(basicPaletteColourManager.GetLightColour());

                            colourSettingsManager.SetLightestColour(basicPaletteColourManager.GetLightestColour());

                            colourSettingsManager.SetLinkDisabledColour(linkTextPaletteColourManager.GetLinkDisabledColour());

                            colourSettingsManager.SetLinkFocusedColour(linkTextPaletteColourManager.GetLinkFocusedColour());

                            colourSettingsManager.SetLinkHoverColour(linkTextPaletteColourManager.GetLinkHoverColour());

                            colourSettingsManager.SetLinkNormalColour(linkTextPaletteColourManager.GetLinkNormalColour());

                            colourSettingsManager.SetLinkVisitedColour(linkTextPaletteColourManager.GetLinkVisitedColour());

                            colourSettingsManager.SetMediumColour(basicPaletteColourManager.GetMediumColour());

                            colourSettingsManager.SetMenuTextColour(textPaletteColourManager.GetMenuTextColour());

                            colourSettingsManager.SetNormalTextColour(textPaletteColourManager.GetNormalTextColour());

                            colourSettingsManager.SetPressedTextColour(textPaletteColourManager.GetPressedTextColour());

                            colourSettingsManager.SetRibbonTabTextColour(textPaletteColourManager.GetRibbonTabTextColour());

                            colourSettingsManager.SetStatusStripTextColour(textPaletteColourManager.GetStatusStripTextColour());

                            colourSettingsManager.SaveColourSettings(usePrompt);
                        }
                    }
                    else
                    {
                        colourSettingsManager.SetAlternativeNormalTextColour(textPaletteColourManager.GetAlternativeNormalTextColour());

                        colourSettingsManager.SetBaseColour(basicPaletteColourManager.GetBaseColour());

                        colourSettingsManager.SetBorderColour(miscellaneousPaletteColourManager.GetBorderColour());

                        colourSettingsManager.SetCustomColourOne(customPaletteColourManager.GetCustomColourOne());

                        colourSettingsManager.SetCustomColourTwo(customPaletteColourManager.GetCustomColourTwo());

                        colourSettingsManager.SetCustomColourThree(customPaletteColourManager.GetCustomColourThree());

                        colourSettingsManager.SetCustomColourFour(customPaletteColourManager.GetCustomColourFour());

                        colourSettingsManager.SetCustomColourFive(customPaletteColourManager.GetCustomColourFive());

                        colourSettingsManager.SetCustomTextColourOne(customPaletteTextColourManager.GetCustomTextColourOne());

                        colourSettingsManager.SetCustomTextColourTwo(customPaletteTextColourManager.GetCustomTextColourTwo());

                        colourSettingsManager.SetCustomTextColourThree(customPaletteTextColourManager.GetCustomTextColourThree());

                        colourSettingsManager.SetCustomTextColourFour(customPaletteTextColourManager.GetCustomTextColourFour());

                        colourSettingsManager.SetCustomTextColourFive(customPaletteTextColourManager.GetCustomTextColourFive());

                        colourSettingsManager.SetDarkestColour(basicPaletteColourManager.GetDarkestColour());

                        colourSettingsManager.SetDisabledControlColour(miscellaneousPaletteColourManager.GetDisabledControlColour());

                        colourSettingsManager.SetDisabledTextColour(textPaletteColourManager.GetDisabledTextColour());

                        colourSettingsManager.SetFocusedTextColour(textPaletteColourManager.GetFocusedTextColour());

                        colourSettingsManager.SetLightColour(basicPaletteColourManager.GetLightColour());

                        colourSettingsManager.SetLightestColour(basicPaletteColourManager.GetLightestColour());

                        colourSettingsManager.SetLinkDisabledColour(linkTextPaletteColourManager.GetLinkDisabledColour());

                        colourSettingsManager.SetLinkFocusedColour(linkTextPaletteColourManager.GetLinkFocusedColour());

                        colourSettingsManager.SetLinkHoverColour(linkTextPaletteColourManager.GetLinkHoverColour());

                        colourSettingsManager.SetLinkNormalColour(linkTextPaletteColourManager.GetLinkNormalColour());

                        colourSettingsManager.SetLinkVisitedColour(linkTextPaletteColourManager.GetLinkVisitedColour());

                        colourSettingsManager.SetMediumColour(basicPaletteColourManager.GetMediumColour());

                        colourSettingsManager.SetMenuTextColour(textPaletteColourManager.GetMenuTextColour());

                        colourSettingsManager.SetNormalTextColour(textPaletteColourManager.GetNormalTextColour());

                        colourSettingsManager.SetPressedTextColour(textPaletteColourManager.GetPressedTextColour());

                        colourSettingsManager.SetRibbonTabTextColour(textPaletteColourManager.GetRibbonTabTextColour());

                        colourSettingsManager.SetStatusStripTextColour(textPaletteColourManager.GetStatusStripTextColour());

                        colourSettingsManager.SaveColourSettings();
                    }
                }
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc, "Exception Caught", MessageBoxButtons.OK, MessageBoxIcon.Error, "SettingsManager", "MergeAllColourSetings(bool usePrompt = false)");
            }
        }

        /// <summary>
        /// Merges all colours.
        /// </summary>
        /// <param name="darkColour">The dark colour.</param>
        /// <param name="middleColour">The middle colour.</param>
        /// <param name="lightColour">The light colour.</param>
        /// <param name="lightestColour">The lightest colour.</param>
        /// <param name="borderColourPreview">The border colour preview.</param>
        /// <param name="alternativeNormalTextColourPreview">The alternative normal text colour preview.</param>
        /// <param name="normalTextColourPreview">The normal text colour preview.</param>
        /// <param name="disabledTextColourPreview">The disabled text colour preview.</param>
        /// <param name="focusedTextColourPreview">The focused text colour preview.</param>
        /// <param name="pressedTextColourPreview">The pressed text colour preview.</param>
        /// <param name="disabledColourPreview">The disabled colour preview.</param>
        /// <param name="linkNormalColourPreview">The link normal colour preview.</param>
        /// <param name="linkHoverColourPreview">The link hover colour preview.</param>
        /// <param name="linkVisitedColourPreview">The link visited colour preview.</param>
        /// <param name="customColourOne">The custom colour one.</param>
        /// <param name="customColourTwo">The custom colour two.</param>
        /// <param name="customColourThree">The custom colour three.</param>
        /// <param name="customColourFour">The custom colour four.</param>
        /// <param name="customColourFive">The custom colour five.</param>
        /// <param name="customTextColourOne">The custom text colour one.</param>
        /// <param name="customTextColourTwo">The custom text colour two.</param>
        /// <param name="customTextColourThree">The custom text colour three.</param>
        /// <param name="customTextColourFour">The custom text colour four.</param>
        /// <param name="customTextColourFive">The custom text colour five.</param>
        /// <param name="menuTextColour">The menu text colour.</param>
        /// <param name="statusTextColour">The status text colour.</param>
        /// <param name="ribbonTabTextColour">The ribbon tab text colour.</param>
        /// <param name="usePrompt">if set to <c>true</c> [use prompt].</param>
        public static void MergeAllColours(Color baseColour, Color darkColour, Color middleColour, Color lightColour, Color lightestColour, Color borderColour, Color alternativeNormalTextColour, Color normalTextColour, Color disabledTextColour, Color focusedTextColour, Color pressedTextColour, Color disabledControlColour, Color linkDisabledColour, Color linkFocusedColour, Color linkNormalColour, Color linkHoverColour, Color linkVisitedColour, Color customColourOne, Color customColourTwo, Color customColourThree, Color customColourFour, Color customColourFive, Color customTextColourOne, Color customTextColourTwo, Color customTextColourThree, Color customTextColourFour, Color customTextColourFive, Color menuTextColour, Color statusTextColour, Color ribbonTabTextColour, bool usePrompt = false)
        {
            #region Variables
            ColourSettingsManager colourSettingsManager = new ColourSettingsManager();
            #endregion

            try
            {
                if (BasicPaletteColourManager.AreBasicPaletteColoursEmpty() || CustomPaletteColourManager.AreCustomPaletteColoursEmpty() || CustomPaletteTextColourManager.AreCustomPaletteTextColoursEmpty() || LinkTextPaletteColourManager.AreLinkTextPaletteColoursEmpty() || MiscellaneousPaletteColourManager.AreMiscellaneousPaletteColoursEmpty() || TextPaletteColourManager.AreTextPaletteColoursEmpty())
                {
                    KryptonMessageBox.Show("There are no colours to merge.", "Undefined Colours", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (usePrompt)
                    {
                        DialogResult result = KryptonMessageBox.Show("Do you want to merge all the colour settings together?", "Confirm Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            colourSettingsManager.SetAlternativeNormalTextColour(alternativeNormalTextColour);

                            colourSettingsManager.SetBaseColour(baseColour);

                            colourSettingsManager.SetBorderColour(borderColour);

                            colourSettingsManager.SetCustomColourOne(customColourOne);

                            colourSettingsManager.SetCustomColourTwo(customColourTwo);

                            colourSettingsManager.SetCustomColourThree(customColourThree);

                            colourSettingsManager.SetCustomColourFour(customColourFour);

                            colourSettingsManager.SetCustomColourFive(customColourFive);

                            colourSettingsManager.SetCustomTextColourOne(customTextColourOne);

                            colourSettingsManager.SetCustomTextColourTwo(customTextColourTwo);

                            colourSettingsManager.SetCustomTextColourThree(customTextColourThree);

                            colourSettingsManager.SetCustomTextColourFour(customTextColourFour);

                            colourSettingsManager.SetCustomTextColourFive(customTextColourFive);

                            colourSettingsManager.SetDarkestColour(darkColour);

                            colourSettingsManager.SetDisabledControlColour(disabledControlColour);

                            colourSettingsManager.SetDisabledTextColour(disabledTextColour);

                            colourSettingsManager.SetFocusedTextColour(focusedTextColour);

                            colourSettingsManager.SetLightColour(lightColour);

                            colourSettingsManager.SetLightestColour(lightestColour);

                            colourSettingsManager.SetLinkDisabledColour(linkDisabledColour);

                            colourSettingsManager.SetLinkFocusedColour(linkFocusedColour);

                            colourSettingsManager.SetLinkHoverColour(linkHoverColour);

                            colourSettingsManager.SetLinkNormalColour(linkNormalColour);

                            colourSettingsManager.SetLinkVisitedColour(linkVisitedColour);

                            colourSettingsManager.SetMediumColour(middleColour);

                            colourSettingsManager.SetMenuTextColour(menuTextColour);

                            colourSettingsManager.SetNormalTextColour(normalTextColour);

                            colourSettingsManager.SetPressedTextColour(pressedTextColour);

                            colourSettingsManager.SetRibbonTabTextColour(ribbonTabTextColour);

                            colourSettingsManager.SetStatusStripTextColour(statusTextColour);

                            colourSettingsManager.SaveColourSettings(usePrompt);
                        }
                    }
                    else
                    {
                        colourSettingsManager.SetAlternativeNormalTextColour(alternativeNormalTextColour);

                        colourSettingsManager.SetBaseColour(baseColour);

                        colourSettingsManager.SetBorderColour(borderColour);

                        colourSettingsManager.SetCustomColourOne(customColourOne);

                        colourSettingsManager.SetCustomColourTwo(customColourTwo);

                        colourSettingsManager.SetCustomColourThree(customColourThree);

                        colourSettingsManager.SetCustomColourFour(customColourFour);

                        colourSettingsManager.SetCustomColourFive(customColourFive);

                        colourSettingsManager.SetCustomTextColourOne(customTextColourOne);

                        colourSettingsManager.SetCustomTextColourTwo(customTextColourTwo);

                        colourSettingsManager.SetCustomTextColourThree(customTextColourThree);

                        colourSettingsManager.SetCustomTextColourFour(customTextColourFour);

                        colourSettingsManager.SetCustomTextColourFive(customTextColourFive);

                        colourSettingsManager.SetDarkestColour(darkColour);

                        colourSettingsManager.SetDisabledControlColour(disabledControlColour);

                        colourSettingsManager.SetDisabledTextColour(disabledTextColour);

                        colourSettingsManager.SetFocusedTextColour(focusedTextColour);

                        colourSettingsManager.SetLightColour(lightColour);

                        colourSettingsManager.SetLightestColour(lightestColour);

                        colourSettingsManager.SetLinkDisabledColour(linkDisabledColour);

                        colourSettingsManager.SetLinkFocusedColour(linkFocusedColour);

                        colourSettingsManager.SetLinkHoverColour(linkHoverColour);

                        colourSettingsManager.SetLinkNormalColour(linkNormalColour);

                        colourSettingsManager.SetLinkVisitedColour(linkVisitedColour);

                        colourSettingsManager.SetMediumColour(middleColour);

                        colourSettingsManager.SetMenuTextColour(menuTextColour);

                        colourSettingsManager.SetNormalTextColour(normalTextColour);

                        colourSettingsManager.SetPressedTextColour(pressedTextColour);

                        colourSettingsManager.SetRibbonTabTextColour(ribbonTabTextColour);

                        colourSettingsManager.SetStatusStripTextColour(statusTextColour);

                        colourSettingsManager.SaveColourSettings();
                    }
                }
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc, "Exception Caught", MessageBoxButtons.OK, MessageBoxIcon.Error, "SettingsManager", "MergeAllColours(Color baseColour, Color darkColour, Color middleColour, Color lightColour, Color lightestColour, Color borderColour, Color alternativeNormalTextColour, Color normalTextColour, Color disabledTextColour, \nColor focusedTextColour, Color pressedTextColour, Color disabledControlColour, Color linkDisabledColour, Color linkFocusedColour, Color linkNormalColour, Color linkHoverColour, Color linkVisitedColour, Color customColourOne, Color customColourTwo, Color customColourThree, Color customColourFour, \nColor customColourFive, Color customTextColourOne, Color customTextColourTwo, Color customTextColourThree, Color customTextColourFour, Color customTextColourFive, Color menuTextColour, Color statusTextColour, Color ribbonTabTextColour, bool usePrompt = false)");
            }
        }
        #endregion
    }
}