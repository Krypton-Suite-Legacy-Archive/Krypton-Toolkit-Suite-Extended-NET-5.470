using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.Exceptions;
using ExtendedControls.ExtendedToolkit.MessageBoxes.UI;
using System;
using System.Windows.Forms;

namespace ExtendedControls.Base.Code.Settings
{
    public class SettingsManager
    {
        #region Variables
        private Properties.Settings _settings = new Properties.Settings();
        #endregion

        #region Properties
        //public Properties.Settings CurrentSettings { get => _settings; set => _settings = value; }
        #endregion

        #region Setters and Getters            
        /// <summary>
        /// Sets the debug mode.
        /// </summary>
        /// <param name="debugMode">if set to <c>true</c> [debug mode].</param>
        public static void SetDebugMode(bool debugMode)
        {
            SettingsManager manager = new SettingsManager();

            manager._settings.DebugMode = debugMode;
        }

        /// <summary>
        /// Gets the debug mode.
        /// </summary>
        /// <returns></returns>
        public static bool GetDebugMode()
        {
            SettingsManager manager = new SettingsManager();

            return manager._settings.DebugMode;
        }

        /// <summary>
        /// Sets the palette explorer location.
        /// </summary>
        /// <param name="paletteExplorerLocation">The palette explorer location.</param>
        public static void SetPaletteExplorerLocation(string paletteExplorerLocation)
        {
            SettingsManager manager = new SettingsManager();

            manager._settings.PaletteExplorerLocation = paletteExplorerLocation;
        }

        /// <summary>
        /// Gets the palette explorer location.
        /// </summary>
        /// <returns></returns>
        public static string GetPaletteExplorerLocation()
        {
            SettingsManager manager = new SettingsManager();

            return manager._settings.PaletteExplorerLocation;
        }

        /// <summary>
        /// Sets the global manager.
        /// </summary>
        /// <param name="manager">The manager.</param>
        public static void SetGlobalManager(KryptonManager manager)
        {
            SettingsManager settingsManager = new SettingsManager();

            settingsManager._settings.GlobalManager = manager;
        }

        /// <summary>
        /// Gets the global manager.
        /// </summary>
        /// <returns></returns>
        public static KryptonManager GetGlobalManager()
        {
            SettingsManager manager = new SettingsManager();

            return manager._settings.GlobalManager;
        }

        /// <summary>
        /// Sets the default theme.
        /// </summary>
        /// <param name="mode">The mode.</param>
        public static void SetDefaultTheme(PaletteMode mode)
        {
            SettingsManager settingsManager = new SettingsManager();

            settingsManager._settings.DefaultTheme = mode;
        }

        /// <summary>
        /// Gets the default theme.
        /// </summary>
        /// <returns></returns>
        public static PaletteMode GetDefaultTheme()
        {
            SettingsManager settingsManager = new SettingsManager();

            return settingsManager._settings.DefaultTheme;
        }

        public static void SetVirusTotalAPIKey(string apiKey)
        {
            SettingsManager settingsManager = new SettingsManager();

            settingsManager._settings.VirusTotalAPIKey = apiKey;
        }

        public static string GetVirusTotalAPIKey()
        {
            SettingsManager settingsManager = new SettingsManager();

            return settingsManager._settings.VirusTotalAPIKey;
        }

        public static void SetVirusTotalUseTLS(bool value)
        {
            SettingsManager settingsManager = new SettingsManager();

            settingsManager._settings.VirusTotalUseTLS = value;
        }

        public static bool GetVirusTotalUseTLS()
        {
            SettingsManager settingsManager = new SettingsManager();

            return settingsManager._settings.VirusTotalUseTLS;
        }
        #endregion

        #region Methods        
        /// <summary>
        /// Saves the properties.
        /// </summary>
        /// <param name="usePrompt">if set to <c>true</c> [use prompt].</param>
        public static void SaveProperties(bool usePrompt = false)
        {
            SettingsManager manager = new SettingsManager();

            try
            {
                if (usePrompt)
                {
                    DialogResult result = ExtendedKryptonMessageBox.Show("Do you want to save your current settings?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes)
                    {
                        manager._settings.Save();
                    }
                }
                else
                {
                    manager._settings.Save();
                }
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc);
            }
        }

        /// <summary>
        /// Resets the settings.
        /// </summary>
        /// <param name="usePrompt">if set to <c>true</c> [use prompt].</param>
        public static void ResetSettings(bool usePrompt = false)
        {
            try
            {
                if (usePrompt)
                {
                    DialogResult result = ExtendedKryptonMessageBox.Show("Do you want to reset your current settings?", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes)
                    {
                        SetDebugMode(false);

                        SetPaletteExplorerLocation(string.Empty);

                        SetGlobalManager(null);
                    }
                }
                else
                {
                    SetDebugMode(false);

                    SetPaletteExplorerLocation(string.Empty);

                    SetGlobalManager(null);
                }

                SaveProperties(usePrompt);
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc);
            }
            #endregion
        }
    }
}