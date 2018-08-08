using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace Tooling.Settings.Classes
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
        /// Sets the DisabledColour to the value of disabledColour.
        /// </summary>
        /// <param name="disabledColour">The value of disabledColour.</param>
        public void SetDisabledColour(Color disabledColour)
        {
            _colourSettings.DisabledColour = disabledColour;
        }

        /// <summary>
        /// Gets the DisabledColour value.
        /// </summary>
        /// <returns>The value of disabledColour.</returns>
        public Color GetDisabledColour()
        {
            return _colourSettings.DisabledColour;
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
        /// Sets the FocusTextColour to the value of focusTextColour.
        /// </summary>
        /// <param name="focusTextColour">The value of focusTextColour.</param>
        public void SetFocusTextColour(Color focusTextColour)
        {
            _colourSettings.FocusTextColour = focusTextColour;
        }

        /// <summary>
        /// Gets the FocusTextColour value.
        /// </summary>
        /// <returns>The value of focusTextColour.</returns>
        public Color GetFocusTextColour()
        {
            return _colourSettings.FocusTextColour;
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
        #endregion

        #region Methods
        /// <summary>
        /// Saves the colour settings.
        /// </summary>
        /// <param name="usePrompt">if set to <c>true</c> [use prompt].</param>
        public void SaveColourSettings(bool usePrompt = false)
        {
            if (usePrompt)
            {
                DialogResult result = KryptonMessageBox.Show("Do you want to save the current colour settings?", "Save Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
        /// <param name="usePrompt">if set to <c>true</c> [use prompt].</param>
        private void ResetSettings(bool usePrompt = false)
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

            SetBorderColour(Color.Black);

            SetNormalTextColour(Color.Black);

            SetFocusTextColour(Color.White);

            SetPressedTextColour(Color.Black);

            SetDisabledTextColour(Color.Gray);

            SetDisabledColour(Color.Silver);

            SetLinkNormalColour(Color.Blue);
        }
        #endregion
    }
}