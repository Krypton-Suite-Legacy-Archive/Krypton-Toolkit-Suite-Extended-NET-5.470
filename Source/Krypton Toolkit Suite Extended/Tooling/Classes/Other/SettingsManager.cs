using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;
using Core.Properties;

namespace Core.Classes.Other
{
    public class SettingsManager
    {
        #region Variables
        private Core.Properties.Settings _mySettings = new Properties.Settings();
        #endregion

        #region Constructor
        public SettingsManager()
        {

        }
        #endregion

        #region Setters & Getters
        /// <summary>
        /// Sets the UpdateInRealTime to the value of value.
        /// </summary>
        /// <param name="value">The value of value.</param>
        public void SetUpdateInRealTime(bool value)
        {
            _mySettings.UpdateInRealTime = value;
        }

        /// <summary>
        /// Gets the UpdateInRealTime value.
        /// </summary>
        /// <returns>The value of value.</returns>
        public bool GetUpdateInRealTime()
        {
            return _mySettings.UpdateInRealTime;
        }
        #endregion

        #region Methods
        public void SaveSettings(bool useDialoguePrompt = false)
        {
            if (useDialoguePrompt)
            {
                DialogResult result = KryptonMessageBox.Show("Do you want to store and save the current setting values?", "Save Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _mySettings.Save();
                }
            }
            else
            {
                _mySettings.Save();
            }
        }
        #endregion
    }
}