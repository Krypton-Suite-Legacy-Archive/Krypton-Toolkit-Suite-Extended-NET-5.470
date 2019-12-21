#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using KryptonApplicationUpdater.Settings;

namespace KryptonApplicationUpdater.Classes.SettingsManager
{
    /// <summary>
    /// Manages the settings for <see cref="ThemeSettings"/>.
    /// </summary>
    public class ThemeSettingsManager
    {
        #region Variables
        private bool _alwaysUsePrompt = false, _settingsModified = false;

        private ThemeSettings themeSettings = new ThemeSettings();
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
        /// Gets or sets a value indicating whether [settings modifed].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [settings modifed]; otherwise, <c>false</c>.
        /// </value>
        public bool SettingsModifed
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
    }
}