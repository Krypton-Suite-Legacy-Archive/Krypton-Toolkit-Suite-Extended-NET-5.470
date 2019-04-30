using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;
using ToolkitSettings.Settings.PaletteExplorer;

namespace ToolkitSettings.Classes.PaletteExplorer
{
    public class GeneralPaletteExplorerSettingsManager
    {
        #region Variables
        private bool _alwaysUsePrompt = false, _settingsModified = false;

        private GeneralPaletteExplorerSettings _generalPaletteExplorerSettings = new GeneralPaletteExplorerSettings();
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets a value indicating whether [always use prompt].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [always use prompt]; otherwise, <c>false</c>.
        /// </value>
        public bool AlwaysUsePrompt
        {
            get
            {
                return _alwaysUsePrompt;
            }

            set
            {
                _alwaysUsePrompt = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [settings modified].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [settings modified]; otherwise, <c>false</c>.
        /// </value>
        public bool SettingsModified
        {
            get
            {
                return _settingsModified;
            }

            set
            {
                _settingsModified = value;
            }
        }
        #endregion

        #region Settings Manipulation
        /// <summary>
        /// Sets the value of AlwaysUsePrompt to value.
        /// </summary>
        /// <param name="value">The value of AlwaysUsePrompt.</param>
        public void SetAlwaysUsePrompt(bool value)
        {
            AlwaysUsePrompt = value;
        }

        /// <summary>
        /// Returns the value of AlwaysUsePrompt.
        /// </summary>
        /// <returns>The value of AlwaysUsePrompt.</returns>
        public bool GetAlwaysUsePrompt()
        {
            return AlwaysUsePrompt;
        }

        /// <summary>
        /// Sets the value of SettingsModified to value.
        /// </summary>
        /// <param name="value">The value of SettingsModified.</param>
        public void SetSettingsModified(bool value)
        {
            SettingsModified = value;
        }

        /// <summary>
        /// Returns the value of SettingsModified.
        /// </summary>
        /// <returns>The value of SettingsModified.</returns>
        public bool GetSettingsModified()
        {
            return SettingsModified;
        }
        #endregion

        #region Constructors
        public GeneralPaletteExplorerSettingsManager()
        {

        }
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the value of ShowColourPropertiesPane to value.
        /// </summary>
        /// <param name="value">The value of ShowColourPropertiesPane.</param>
        public void SetShowColourPropertiesPane(bool value)
        {
            _generalPaletteExplorerSettings.ShowColourPropertiesPane = value;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of ShowColourPropertiesPane.
        /// </summary>
        /// <returns>The value of ShowColourPropertiesPane.</returns>
        public bool GetShowColourPropertiesPane()
        {
            return _generalPaletteExplorerSettings.ShowColourPropertiesPane;
        }

        /// <summary>
        /// Sets the value of ShowPalettePropertiesPane to value.
        /// </summary>
        /// <param name="value">The value of ShowPalettePropertiesPane.</param>
        public void SetShowPalettePropertiesPane(bool value)
        {
            _generalPaletteExplorerSettings.ShowPalettePropertiesPane = value;

            SetSettingsModified(true);
        }

        /// <summary>
        /// Returns the value of ShowPalettePropertiesPane.
        /// </summary>
        /// <returns>The value of ShowPalettePropertiesPane.</returns>
        public bool GetShowPalettePropertiesPane()
        {
            return _generalPaletteExplorerSettings.ShowPalettePropertiesPane;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Resets to defaults.
        /// </summary>
        public void ResetToDefaults()
        {
            if (KryptonMessageBox.Show("WARNING! You are about to reset these settings back to their original state. This action cannot be undone!\nDo you want to proceed?", "Reset Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                SetShowColourPropertiesPane(false);

                SetShowPalettePropertiesPane(false);

                if (KryptonMessageBox.Show($"Done! Do you want to restart the application now?", "Action Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }

        /// <summary>
        /// Saves the XML file application updater settings.
        /// </summary>
        /// <param name="alwaysUsePrompt">if set to <c>true</c> [always use prompt].</param>
        public void SaveXMLFileApplicationUpdaterSettings(bool alwaysUsePrompt = false)
        {
            if (alwaysUsePrompt)
            {
                if (KryptonMessageBox.Show("You have changed a setting value. Do you want to save these changes?", "Setting Values Changed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _generalPaletteExplorerSettings.Save();

                    SetSettingsModified(false);
                }
            }
            else
            {
                _generalPaletteExplorerSettings.Save();

                SetSettingsModified(false);
            }
        }
        #endregion
    }
}