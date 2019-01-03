using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace Core.Settings.Classes
{
    public class ColourSettingsManager
    {
        #region Variables
        private ColourSettings _colourSettings = new ColourSettings();
        #endregion

        #region Constructors
        public ColourSettingsManager()
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
            _colourSettings.BaseColour = baseColour;
        }

        /// <summary>
        /// Gets the BaseColour value.
        /// </summary>
        /// <returns>The value of baseColour.</returns>
        public Color GetBaseColour()
        {
            return _colourSettings.BaseColour;
        }

        /// <summary>
        /// Sets the DarkestColour to the value of darkestColour.
        /// </summary>
        /// <param name="darkestColour">The value of darkestColour.</param>
        public void SetDarkestColour(Color darkestColour)
        {
            _colourSettings.DarkestColour = darkestColour;
        }

        /// <summary>
        /// Gets the DarkestColour value.
        /// </summary>
        /// <returns>The value of darkestColour.</returns>
        public Color GetDarkestColour()
        {
            return _colourSettings.DarkestColour;
        }

        /// <summary>
        /// Sets the MediumColour to the value of mediumColour.
        /// </summary>
        /// <param name="mediumColour">The value of mediumColour.</param>
        public void SetMediumColour(Color mediumColour)
        {
            _colourSettings.MediumColour = mediumColour;
        }

        /// <summary>
        /// Gets the MediumColour value.
        /// </summary>
        /// <returns>The value of mediumColour.</returns>
        public Color GetMediumColour()
        {
            return _colourSettings.MediumColour;
        }

        /// <summary>
        /// Sets the LightColour to the value of lightColour.
        /// </summary>
        /// <param name="lightColour">The value of lightColour.</param>
        public void SetLightColour(Color lightColour)
        {
            _colourSettings.LightColour = lightColour;
        }

        /// <summary>
        /// Gets the LightColour value.
        /// </summary>
        /// <returns>The value of lightColour.</returns>
        public Color GetLightColour()
        {
            return _colourSettings.LightColour;
        }

        /// <summary>
        /// Sets the LightestColour to the value of lightestColour.
        /// </summary>
        /// <param name="lightestColour">The value of lightestColour.</param>
        public void SetLightestColour(Color lightestColour)
        {
            _colourSettings.LightestColour = lightestColour;
        }

        /// <summary>
        /// Gets the LightestColour value.
        /// </summary>
        /// <returns>The value of lightestColour.</returns>
        public Color GetLightestColour()
        {
            return _colourSettings.LightestColour;
        }

        /// <summary>
        /// Sets the BorderColour to the value of borderColour.
        /// </summary>
        /// <param name="borderColour">The value of borderColour.</param>
        public void SetBorderColour(Color borderColour)
        {
            _colourSettings.BorderColour = borderColour;
        }

        /// <summary>
        /// Gets the BorderColour value.
        /// </summary>
        /// <returns>The value of borderColour.</returns>
        public Color GetBorderColour()
        {
            return _colourSettings.BorderColour;
        }

        /// <summary>
        /// Sets the NormalTextColour to the value of normalTextColour.
        /// </summary>
        /// <param name="normalTextColour">The value of normalTextColour.</param>
        public void SetNormalTextColour(Color normalTextColour)
        {
            _colourSettings.NormalTextColour = normalTextColour;
        }

        /// <summary>
        /// Gets the NormalTextColour value.
        /// </summary>
        /// <returns>The value of normalTextColour.</returns>
        public Color GetNormalTextColour()
        {
            return _colourSettings.NormalTextColour;
        }

        /// <summary>
        /// Sets the AlternativeNormalTextColour to the value of alternativeNormalTextColour.
        /// </summary>
        /// <param name="alternativeNormalTextColour">The value of alternativeNormalTextColour.</param>
        public void SetAlternativeNormalTextColour(Color alternativeNormalTextColour)
        {
            _colourSettings.AlternativeNormalTextColour = alternativeNormalTextColour;
        }

        /// <summary>
        /// Gets the AlternativeNormalTextColour value.
        /// </summary>
        /// <returns>The value of alternativeNormalTextColour.</returns>
        public Color GetAlternativeNormalTextColour()
        {
            return _colourSettings.AlternativeNormalTextColour;
        }

        /// <summary>
        /// Sets the DisabledTextColour to the value of disabledTextColur.
        /// </summary>
        /// <param name="disabledTextColur">The value of disabledTextColur.</param>
        public void SetDisabledTextColour(Color disabledTextColur)
        {
            _colourSettings.DisabledTextColour = disabledTextColur;
        }

        /// <summary>
        /// Gets the DisabledTextColour value.
        /// </summary>
        /// <returns>The value of disabledTextColur.</returns>
        public Color GetDisabledTextColour()
        {
            return _colourSettings.DisabledTextColour;
        }

        /// <summary>
        /// Sets the DisabledControlColour to the value of disabledControlColour.
        /// </summary>
        /// <param name="disabledControlColour">The value of disabledControlColour.</param>
        public void SetDisabledControlColour(Color disabledControlColour)
        {
            _colourSettings.DisabledControlColour = disabledControlColour;
        }

        /// <summary>
        /// Gets the DisabledControlColour value.
        /// </summary>
        /// <returns>The value of disabledControlColour.</returns>
        public Color GetDisabledControlColour()
        {
            return _colourSettings.DisabledControlColour;
        }

        /// <summary>
        /// Sets the LinkNormalColour to the value of linkNormalColour.
        /// </summary>
        /// <param name="linkNormalColour">The value of linkNormalColour.</param>
        public void SetLinkNormalColour(Color linkNormalColour)
        {
            _colourSettings.LinkNormalColour = linkNormalColour;
        }

        /// <summary>
        /// Gets the LinkNormalColour value.
        /// </summary>
        /// <returns>The value of linkNormalColour.</returns>
        public Color GetLinkNormalColour()
        {
            return _colourSettings.LinkNormalColour;
        }

        /// <summary>
        /// Sets the LinkFocusedColour to the value of linkFocusedColour.
        /// </summary>
        /// <param name="linkFocusedColour">The value of linkFocusedColour.</param>
        public void SetLinkFocusedColour(Color linkFocusedColour)
        {
            _colourSettings.LinkFocusedColour = linkFocusedColour;
        }

        /// <summary>
        /// Gets the LinkFocusedColour value.
        /// </summary>
        /// <returns>The value of linkFocusedColour.</returns>
        public Color GetLinkFocusedColour()
        {
            return _colourSettings.LinkFocusedColour;
        }

        /// <summary>
        /// Sets the FocusTextColour to the value of focusTextColour.
        /// </summary>
        /// <param name="focusedTextColour">The value of focusTextColour.</param>
        public void SetFocusedTextColour(Color focusedTextColour)
        {
            _colourSettings.FocusedTextColour = focusedTextColour;
        }

        /// <summary>
        /// Gets the FocusTextColour value.
        /// </summary>
        /// <returns>The value of focusTextColour.</returns>
        public Color GetFocusedTextColour()
        {
            return _colourSettings.FocusedTextColour;
        }

        /// <summary>
        /// Sets the PressedTextColour to the value of pressedTextColour.
        /// </summary>
        /// <param name="pressedTextColour">The value of pressedTextColour.</param>
        public void SetPressedTextColour(Color pressedTextColour)
        {
            _colourSettings.PressedTextColour = pressedTextColour;
        }

        /// <summary>
        /// Gets the PressedTextColour value.
        /// </summary>
        /// <returns>The value of pressedTextColour.</returns>
        public Color GetPressedTextColour()
        {
            return _colourSettings.PressedTextColour;
        }

        /// <summary>
        /// Sets the LinkHoverColour to the value of linkHoverColour.
        /// </summary>
        /// <param name="linkHoverColour">The value of linkHoverColour.</param>
        public void SetLinkHoverColour(Color linkHoverColour)
        {
            _colourSettings.LinkHoverColour = linkHoverColour;
        }

        /// <summary>
        /// Gets the LinkHoverColour value.
        /// </summary>
        /// <returns>The value of linkHoverColour.</returns>
        public Color GetLinkHoverColour()
        {
            return _colourSettings.LinkHoverColour;
        }

        /// <summary>
        /// Sets the LinkVisitedColour to the value of linkVisitedColour.
        /// </summary>
        /// <param name="linkVisitedColour">The value of linkVisitedColour.</param>
        public void SetLinkVisitedColour(Color linkVisitedColour)
        {
            _colourSettings.LinkVisitedColour = linkVisitedColour;
        }

        /// <summary>
        /// Gets the LinkVisitedColour value.
        /// </summary>
        /// <returns>The value of linkVisitedColour.</returns>
        public Color GetLinkVisitedColour()
        {
            return _colourSettings.LinkVisitedColour;
        }

        /// <summary>
        /// Sets the LinkDisabledColour to the value of linkDisabledColour.
        /// </summary>
        /// <param name="linkDisabledColour">The value of linkDisabledColour.</param>
        public void SetLinkDisabledColour(Color linkDisabledColour)
        {
            _colourSettings.LinkDisabledColour = linkDisabledColour;
        }

        /// <summary>
        /// Gets the LinkDisabledColour value.
        /// </summary>
        /// <returns>The value of linkDisabledColour.</returns>
        public Color GetLinkDisabledColour()
        {
            return _colourSettings.LinkDisabledColour;
        }

        /// <summary>
        /// Sets the CustomColourOne to the value of customColourOne.
        /// </summary>
        /// <param name="customColourOne">The value of customColourOne.</param>
        public void SetCustomColourOne(Color customColourOne)
        {
            _colourSettings.CustomColourOne = customColourOne;
        }

        /// <summary>
        /// Gets the CustomColourOne value.
        /// </summary>
        /// <returns>The value of customColourOne.</returns>
        public Color GetCustomColourOne()
        {
            return _colourSettings.CustomColourOne;
        }

        /// <summary>
        /// Sets the CustomColourTwo to the value of customColourTwo.
        /// </summary>
        /// <param name="customColourTwo">The value of customColourTwo.</param>
        public void SetCustomColourTwo(Color customColourTwo)
        {
            _colourSettings.CustomColourTwo = customColourTwo;
        }

        /// <summary>
        /// Gets the CustomColourTwo value.
        /// </summary>
        /// <returns>The value of customColourTwo.</returns>
        public Color GetCustomColourTwo()
        {
            return _colourSettings.CustomColourTwo;
        }

        /// <summary>
        /// Sets the CustomColourThree to the value of customColourThree.
        /// </summary>
        /// <param name="customColourThree">The value of customColourThree.</param>
        public void SetCustomColourThree(Color customColourThree)
        {
            _colourSettings.CustomColourThree = customColourThree;
        }

        /// <summary>
        /// Gets the CustomColourThree value.
        /// </summary>
        /// <returns>The value of customColourThree.</returns>
        public Color GetCustomColourThree()
        {
            return _colourSettings.CustomColourThree;
        }

        /// <summary>
        /// Sets the CustomColourFour to the value of customColourFour.
        /// </summary>
        /// <param name="customColourFour">The value of customColourFour.</param>
        public void SetCustomColourFour(Color customColourFour)
        {
            _colourSettings.CustomColourFour = customColourFour;
        }

        /// <summary>
        /// Gets the CustomColourFour value.
        /// </summary>
        /// <returns>The value of customColourFour.</returns>
        public Color GetCustomColourFour()
        {
            return _colourSettings.CustomColourFour;
        }

        /// <summary>
        /// Sets the CustomColourFive to the value of customColourFive.
        /// </summary>
        /// <param name="customColourFive">The value of customColourFive.</param>
        public void SetCustomColourFive(Color customColourFive)
        {
            _colourSettings.CustomColourFive = customColourFive;
        }

        /// <summary>
        /// Gets the CustomColourFive value.
        /// </summary>
        /// <returns>The value of customColourFive.</returns>
        public Color GetCustomColourFive()
        {
            return _colourSettings.CustomColourFive;
        }

        /// <summary>
        /// Sets the MenuTextColour to the value of menuTextColour.
        /// </summary>
        /// <param name="menuTextColour">The value of menuTextColour.</param>
        public void SetMenuTextColour(Color menuTextColour)
        {
            _colourSettings.MenuTextColour = menuTextColour;
        }

        /// <summary>
        /// Gets the MenuTextColour value.
        /// </summary>
        /// <returns>The value of menuTextColour.</returns>
        public Color GetMenuTextColour()
        {
            return _colourSettings.MenuTextColour;
        }

        /// <summary>
        /// Sets the CustomTextColourOne to the value of customTextColourOne.
        /// </summary>
        /// <param name="customTextColourOne">The value of customTextColourOne.</param>
        public void SetCustomTextColourOne(Color customTextColourOne)
        {
            _colourSettings.CustomTextColourOne = customTextColourOne;
        }

        /// <summary>
        /// Gets the CustomTextColourOne value.
        /// </summary>
        /// <returns>The value of customTextColourOne.</returns>
        public Color GetCustomTextColourOne()
        {
            return _colourSettings.CustomTextColourOne;
        }

        /// <summary>
        /// Sets the CustomTextColourTwo to the value of customTextColourTwo.
        /// </summary>
        /// <param name="customTextColourTwo">The value of customTextColourTwo.</param>
        public void SetCustomTextColourTwo(Color customTextColourTwo)
        {
            _colourSettings.CustomTextColourTwo = customTextColourTwo;
        }

        /// <summary>
        /// Gets the CustomTextColourTwo value.
        /// </summary>
        /// <returns>The value of customTextColourTwo.</returns>
        public Color GetCustomTextColourTwo()
        {
            return _colourSettings.CustomTextColourTwo;
        }

        /// <summary>
        /// Sets the CustomTextColourThree to the value of customTextColourThree.
        /// </summary>
        /// <param name="customTextColourThree">The value of customTextColourThree.</param>
        public void SetCustomTextColourThree(Color customTextColourThree)
        {
            _colourSettings.CustomTextColourThree = customTextColourThree;
        }

        /// <summary>
        /// Gets the CustomTextColourThree value.
        /// </summary>
        /// <returns>The value of customTextColourThree.</returns>
        public Color GetCustomTextColourThree()
        {
            return _colourSettings.CustomTextColourThree;
        }

        /// <summary>
        /// Sets the CustomTextColourFour to the value of customTextColourFour.
        /// </summary>
        /// <param name="customTextColourFour">The value of customTextColourFour.</param>
        public void SetCustomTextColourFour(Color customTextColourFour)
        {
            _colourSettings.CustomTextColourFour = customTextColourFour;
        }

        /// <summary>
        /// Gets the CustomTextColourFour value.
        /// </summary>
        /// <returns>The value of customTextColourFour.</returns>
        public Color GetCustomTextColourFour()
        {
            return _colourSettings.CustomTextColourFour;
        }

        /// <summary>
        /// Sets the CustomTextColourFive to the value of customTextColourFive.
        /// </summary>
        /// <param name="customTextColourFive">The value of customTextColourFive.</param>
        public void SetCustomTextColourFive(Color customTextColourFive)
        {
            _colourSettings.CustomTextColourFive = customTextColourFive;
        }

        /// <summary>
        /// Gets the CustomTextColourFive value.
        /// </summary>
        /// <returns>The value of customTextColourFive.</returns>
        public Color GetCustomTextColourFive()
        {
            return _colourSettings.CustomTextColourFive;
        }

        /// <summary>
        /// Sets the StatusStripTextColour to the value of statusStripTextColour.
        /// </summary>
        /// <param name="statusStripTextColour">The value of statusStripTextColour.</param>
        public void SetStatusStripTextColour(Color statusStripTextColour)
        {
            _colourSettings.StatusStripTextColour = statusStripTextColour;
        }

        /// <summary>
        /// Gets the StatusStripTextColour value.
        /// </summary>
        /// <returns>The value of statusStripTextColour.</returns>
        public Color GetStatusStripTextColour()
        {
            return _colourSettings.StatusStripTextColour;
        }

        /// <summary>
        /// Sets the RibbonTabTextColour to the value of ribbonTabTextColour.
        /// </summary>
        /// <param name="ribbonTabTextColour">The value of ribbonTabTextColour.</param>
        public void SetRibbonTabTextColour(Color ribbonTabTextColour)
        {
            _colourSettings.RibbonTabTextColour = ribbonTabTextColour;
        }

        /// <summary>
        /// Gets the RibbonTabTextColour value.
        /// </summary>
        /// <returns>The value of ribbonTabTextColour.</returns>
        public Color GetRibbonTabTextColour()
        {
            return _colourSettings.RibbonTabTextColour;
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
                DialogResult result = KryptonMessageBox.Show("Do you want to save the current colour settings?", "Save Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //KryptonMessageBoxExtendedResult result = ExtendedKryptonMessageBox.Show("Do you want to save the current colour settings?", "Save Confirmation", KryptonMessageBoxExtendedButtons.YESNO, KryptonMessageBoxExtendedIcon.QUESTION);

                if (result == DialogResult.Yes)
                {
                    _colourSettings.Save();
                }
                else
                {
                    ResetSettings(usePrompt);
                }
            }
            else
            {
                _colourSettings.Save();
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
                DialogResult result = KryptonMessageBox.Show("This action will reset the colour values. Do you want to continue?", "Reset Colour Values", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

            SetBorderColour(SystemColors.Control);

            SetAlternativeNormalTextColour(Color.White);

            SetNormalTextColour(Color.Black);

            SetFocusedTextColour(Color.White);

            SetPressedTextColour(Color.Black);

            SetDisabledTextColour(Color.Gray);

            SetDisabledControlColour(Color.Silver);

            SetLinkNormalColour(Color.Blue);

            SetLinkFocusedColour(Color.Gray);

            SetLinkHoverColour(Color.Red);

            SetLinkVisitedColour(Color.Purple);

            SetCustomColourOne(Color.Black);

            SetCustomColourTwo(Color.White);

            SetCustomColourThree(Color.Black);

            SetCustomColourFour(Color.FromArgb(230, 230, 230));

            SetCustomColourFive(Color.MintCream);

            SetMenuTextColour(Color.Black);

            SetCustomTextColourOne(Color.Black);

            SetCustomTextColourTwo(Color.White);

            SetCustomTextColourThree(Color.Black);

            SetCustomTextColourFour(Color.FromArgb(230, 230, 230));

            SetCustomTextColourFive(Color.MintCream);

            SetStatusStripTextColour(Color.Black);

            SetRibbonTabTextColour(Color.Black);
        }
        #endregion

        #region Detection
        public static bool AreColoursEmpty()
        {
            ColourSettingsManager colourSettingsManager = new ColourSettingsManager();

            if (colourSettingsManager.GetBaseColour() == Color.Empty || colourSettingsManager.GetDarkestColour() == Color.Empty || colourSettingsManager.GetMediumColour() == Color.Empty || colourSettingsManager.GetLightColour() == Color.Empty || colourSettingsManager.GetLightestColour() == Color.Empty || colourSettingsManager.GetCustomColourOne() == Color.Empty || colourSettingsManager.GetCustomColourTwo() == Color.Empty || colourSettingsManager.GetCustomColourThree() == Color.Empty || colourSettingsManager.GetCustomColourFour() == Color.Empty || colourSettingsManager.GetCustomColourFive() == Color.Empty || colourSettingsManager.GetCustomTextColourOne() == Color.Empty || colourSettingsManager.GetCustomTextColourTwo() == Color.Empty || colourSettingsManager.GetCustomTextColourThree() == Color.Empty || colourSettingsManager.GetCustomTextColourFour() == Color.Empty || colourSettingsManager.GetCustomTextColourFive() == Color.Empty || colourSettingsManager.GetLinkNormalColour() == Color.Empty || colourSettingsManager.GetLinkFocusedColour() == Color.Empty || colourSettingsManager.GetLinkHoverColour() == Color.Empty || colourSettingsManager.GetLinkNormalColour() == Color.Empty || colourSettingsManager.GetLinkVisitedColour() == Color.Empty || colourSettingsManager.GetBorderColour() == Color.Empty || colourSettingsManager.GetDisabledControlColour() == Color.Empty || colourSettingsManager.GetAlternativeNormalTextColour() == Color.Empty || colourSettingsManager.GetDisabledTextColour() == Color.Empty || colourSettingsManager.GetFocusedTextColour() == Color.Empty || colourSettingsManager.GetMenuTextColour() == Color.Empty || colourSettingsManager.GetNormalTextColour() == Color.Empty || colourSettingsManager.GetPressedTextColour() == Color.Empty || colourSettingsManager.GetRibbonTabTextColour() == Color.Empty || colourSettingsManager.GetStatusStripTextColour() == Color.Empty)
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