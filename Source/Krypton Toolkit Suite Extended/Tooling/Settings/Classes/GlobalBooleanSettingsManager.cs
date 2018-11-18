using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace Tooling.Settings.Classes
{
    public class GlobalBooleanSettingsManager
    {
        #region Variables
        private GlobalBooleanSettings _globalBooleanSettings = new GlobalBooleanSettings();
        #endregion

        #region Constructors
        public GlobalBooleanSettingsManager()
        {

        }
        #endregion

        #region Setters & Getters
        /// <summary>
        /// Sets the AutomaticallyUpdateColours to the value of value.
        /// </summary>
        /// <param name="value">The value of value.</param>
        public void SetAutomaticallyUpdateColours(bool value)
        {
            _globalBooleanSettings.AutomaticallyUpdateColours = value;
        }

        /// <summary>
        /// Gets the AutomaticallyUpdateColours value.
        /// </summary>
        /// <returns>The value of value.</returns>
        public bool GetAutomaticallyUpdateColours()
        {
            return _globalBooleanSettings.AutomaticallyUpdateColours;
        }

        /// <summary>
        /// Sets the DevelopmentMode to the value of value.
        /// </summary>
        /// <param name="value">The value of value.</param>
        public void SetDevelopmentMode(bool value)
        {
            _globalBooleanSettings.DevelopmentMode = value;
        }

        /// <summary>
        /// Gets the DevelopmentMode value.
        /// </summary>
        /// <returns>The value of value.</returns>
        public bool GetDevelopmentMode()
        {
            return _globalBooleanSettings.DevelopmentMode;
        }

        /// <summary>
        /// Sets the DisableListItem to the value of value.
        /// </summary>
        /// <param name="value">The value of value.</param>
        public void SetDisableListItem(bool value)
        {
            _globalBooleanSettings.DisableListItem = value;
        }

        /// <summary>
        /// Gets the DisableListItem value.
        /// </summary>
        /// <returns>The value of value.</returns>
        public bool GetDisableListItem()
        {
            return _globalBooleanSettings.DisableListItem;
        }

        /// <summary>
        /// Sets the UseCircularPictureBoxes to the value of value.
        /// </summary>
        /// <param name="value">The value of value.</param>
        public void SetUseCircularPictureBoxes(bool value)
        {
            _globalBooleanSettings.UseCircularPictureBoxes = value;
        }

        /// <summary>
        /// Gets the UseCircularPictureBoxes value.
        /// </summary>
        /// <returns>The value of value.</returns>
        public bool GetUseCircularPictureBoxes()
        {
            return _globalBooleanSettings.UseCircularPictureBoxes;
        }

        /// <summary>
        /// Sets the LoadColoursOnOpenPalette to the value of value.
        /// </summary>
        /// <param name="value">The value of value.</param>
        public void SetLoadColoursOnOpenPalette(bool value)
        {
            _globalBooleanSettings.LoadColoursOnOpenPalette = value;
        }

        /// <summary>
        /// Gets the LoadColoursOnOpenPalette value.
        /// </summary>
        /// <returns>The value of value.</returns>
        public bool GetLoadColoursOnOpenPalette()
        {
            return _globalBooleanSettings.LoadColoursOnOpenPalette;
        }

        /// <summary>
        /// Sets the IsInBetaMode to the value of value.
        /// </summary>
        /// <param name="value">The value of value.</param>
        public void SetIsInBetaMode(bool value)
        {
            _globalBooleanSettings.IsInBetaMode = value;
        }

        /// <summary>
        /// Gets the IsInBetaMode value.
        /// </summary>
        /// <returns>The value of value.</returns>
        public bool GetIsInBetaMode()
        {
            return _globalBooleanSettings.IsInBetaMode;
        }

        /// <summary>
        /// Sets the HidePropertiesPane to the value of value.
        /// </summary>
        /// <param name="value">The value of value.</param>
        public void SetHidePropertiesPane(bool value)
        {
            _globalBooleanSettings.HidePropertiesPane = value;
        }

        /// <summary>
        /// Gets the HidePropertiesPane value.
        /// </summary>
        /// <returns>The value of value.</returns>
        public bool GetHidePropertiesPane()
        {
            return _globalBooleanSettings.HidePropertiesPane;
        }

        /// <summary>
        /// Sets the UsePromptFeedback to the value of value.
        /// </summary>
        /// <param name="value">The value of value.</param>
        public void SetUsePromptFeedback(bool value)
        {
            _globalBooleanSettings.UsePromptFeedback = value;
        }

        /// <summary>
        /// Gets the UsePromptFeedback value.
        /// </summary>
        /// <returns>The value of value.</returns>
        public bool GetUsePromptFeedback()
        {
            return _globalBooleanSettings.UsePromptFeedback;
        }
        #endregion

        #region Methods 
        /// <summary>
        /// Saves the boolean settings.
        /// </summary>
        /// <param name="usePrompt">if set to <c>true</c> [use prompt].</param>
        public void SaveBooleanSettings(bool usePrompt = false)
        {
            if (usePrompt)
            {
                DialogResult result = KryptonMessageBox.Show("Do you want to save the current boolean settings?", "Save Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _globalBooleanSettings.Save();
                }
                else
                {
                    ResetSettings(usePrompt);
                }
            }
            else
            {
                _globalBooleanSettings.Save();
            }
        }

        /// <summary>
        /// Resets the settings.
        /// </summary>
        /// <param name="usePrompt">if set to <c>true</c> [use prompt].</param>
        public void ResetSettings(bool usePrompt = false)
        {
            if (usePrompt)
            {
                DialogResult result = KryptonMessageBox.Show("This action will reset the boolean values. Do you want to continue?", "Reset Boolean Values", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ResetBooleanSettings();

                    SaveBooleanSettings(usePrompt);
                }
                else
                {
                    ResetBooleanSettings();

                    SaveBooleanSettings();
                }
            }
        }

        private void ResetBooleanSettings()
        {
            SetAutomaticallyUpdateColours(true);

            SetDevelopmentMode(false);

            SetDisableListItem(false);

            SetUseCircularPictureBoxes(true);

            SetLoadColoursOnOpenPalette(true);

            SetIsInBetaMode(false);

            SetHidePropertiesPane(false);

            SetUsePromptFeedback(true);
        }
        #endregion
    }
}