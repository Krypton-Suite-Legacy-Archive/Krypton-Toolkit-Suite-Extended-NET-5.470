using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;
using ToolkitSettings.Settings.Global;

namespace ToolkitSettings.Classes.Global
{
    public class GlobalStringSettingsManager
    {
        #region Variables
        private GlobalStringSettings _globalStringSettings = new GlobalStringSettings();
        #endregion

        #region Constructor
        public GlobalStringSettingsManager()
        {

        }
        #endregion

        #region Setters and Getters        
        public void SetBasePaletteMode(string value)
        {
            _globalStringSettings.BasePaletteMode = value;
        }

        public string GetBasePaletteMode()
        {
            return _globalStringSettings.BasePaletteMode;
        }

        public void SetFeedbackText(string value)
        {
            _globalStringSettings.FeedbackText = value;
        }

        public string GetFeedbackText()
        {
            return _globalStringSettings.FeedbackText;
        }

        /// <summary>
        /// Sets the PaletteExportPath to the value of pathValue.
        /// </summary>
        /// <param name="pathValue">The value of pathValue.</param>
        public void SetPaletteExportPath(string pathValue)
        {
            _globalStringSettings.PaletteExportPath = pathValue;
        }

        /// <summary>
        /// Gets the PaletteExportPath value.
        /// </summary>
        /// <returns>The value of pathValue.</returns>
        public string GetPaletteExportPath()
        {
            return _globalStringSettings.PaletteExportPath;
        }
        #endregion

        #region Save & Reset Methods
        public void SaveStringSettings(bool usePrompt = false)
        {
            if (usePrompt)
            {
                DialogResult result = KryptonMessageBox.Show("Do you want to save the current string settings?", "Save Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //KryptonMessageBoxExtendedResult result = ExtendedKryptonMessageBox.Show("Do you want to save the current colour settings?", "Save Confirmation", KryptonMessageBoxExtendedButtons.YESNO, KryptonMessageBoxExtendedIcon.QUESTION);

                if (result == DialogResult.Yes)
                {
                    _globalStringSettings.Save();
                }
                else
                {
                    ResetSettings(usePrompt);
                }
            }
            else
            {
                _globalStringSettings.Save();
            }
        }

        public void ResetSettings(bool usePrompt = false)
        {
            if (usePrompt)
            {
                DialogResult result = KryptonMessageBox.Show("Are you sure that you want to reset the current string settings back to their defaults?", "Reset String Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ResetSettings();
                }
                else
                {
                    ResetSettings();
                }
            }
        }

        private void ResetSettings()
        {
            SetBasePaletteMode(string.Empty);

            SetFeedbackText("This will become informative...");

            SetPaletteExportPath(Environment.SpecialFolder.MyDocuments + "\\Krypton Palettes");
        }
        #endregion
    }
}