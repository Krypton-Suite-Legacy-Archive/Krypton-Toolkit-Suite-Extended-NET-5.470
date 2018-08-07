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
        /// Sets the AlphaChannelValue to the value of alphaChannelValue.
        /// </summary>
        /// <param name="alphaChannelValue">The value of alphaChannelValue.</param>
        public void SetAlphaChannelValue(int alphaChannelValue)
        {
            _colourSettings.AlphaChannelValue = alphaChannelValue;
        }

        /// <summary>
        /// Gets the AlphaChannelValue value.
        /// </summary>
        /// <returns>The value of alphaChannelValue.</returns>
        public int GetAlphaChannelValue()
        {
            return _colourSettings.AlphaChannelValue;
        }

        /// <summary>
        /// Sets the RedChannelValue to the value of redChannelValue.
        /// </summary>
        /// <param name="redChannelValue">The value of redChannelValue.</param>
        public void SetRedChannelValue(int redChannelValue)
        {
            _colourSettings.RedChannelValue = redChannelValue;
        }

        /// <summary>
        /// Gets the RedChannelValue value.
        /// </summary>
        /// <returns>The value of redChannelValue.</returns>
        public int GetRedChannelValue()
        {
            return _colourSettings.RedChannelValue;
        }

        /// <summary>
        /// Sets the GreenChannelValue to the value of greenChannelValue.
        /// </summary>
        /// <param name="greenChannelValue">The value of greenChannelValue.</param>
        public void SetGreenChannelValue(int greenChannelValue)
        {
            _colourSettings.GreenChannelValue = greenChannelValue;
        }

        /// <summary>
        /// Gets the GreenChannelValue value.
        /// </summary>
        /// <returns>The value of greenChannelValue.</returns>
        public int GetGreenChannelValue()
        {
            return _colourSettings.GreenChannelValue;
        }

        /// <summary>
        /// Sets the BlueChannelValue to the value of blueChannelValue.
        /// </summary>
        /// <param name="blueChannelValue">The value of blueChannelValue.</param>
        public void SetBlueChannelValue(int blueChannelValue)
        {
            _colourSettings.BlueChannelValue = blueChannelValue;
        }

        /// <summary>
        /// Gets the BlueChannelValue value.
        /// </summary>
        /// <returns>The value of blueChannelValue.</returns>
        public int GetBlueChannelValue()
        {
            return _colourSettings.BlueChannelValue;
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

            SetDisabledTextColour(Color.Gray);

            SetDisabledColour(Color.Silver);

            SetLinkNormalColour(Color.Blue);

            SetAlphaChannelValue(255);

            SetRedChannelValue(0);

            SetGreenChannelValue(0);

            SetBlueChannelValue(0);
        }
        #endregion
    }
}