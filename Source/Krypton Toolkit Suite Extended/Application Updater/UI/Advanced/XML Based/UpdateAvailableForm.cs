using System;

using ComponentFactory.Krypton.Toolkit;

namespace KryptonApplicationUpdater.UI.Advanced.XMLBased
{
    public partial class UpdateAvailableForm : KryptonForm
    {
        #region Constructors
        /// <summary>
        /// Initialises a new instance of the <see cref="UpdateAvailableForm"/> class.
        /// </summary>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="currentApplicationVersion">The current application version.</param>
        /// <param name="serverVersion">The server version.</param>
        /// <param name="changelogURL">The changelog URL.</param>
        /// <param name="enableMoreDetailsButton">if set to <c>true</c> [enable more details button].</param>
        /// <param name="enableSkipUpdateButton">if set to <c>true</c> [enable skip update button].</param>
        /// <param name="enableRemindLaterButton">if set to <c>true</c> [enable remind later button].</param>
        public UpdateAvailableForm(string applicationName, Version currentApplicationVersion, Version serverVersion, string changelogURL, bool enableMoreDetailsButton = true, bool enableSkipUpdateButton = true, bool enableRemindLaterButton = true)
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        private void UpdateAvailableForm_Load(object sender, System.EventArgs e)
        {

        }

        private void kbtnCancel_Click(object sender, System.EventArgs e)
        {

        }

        private void kbtnDownloadUpdate_Click(object sender, System.EventArgs e)
        {

        }

        private void kbtnMoreDetails_Click(object sender, System.EventArgs e)
        {

        }

        private void kbtnRemindLater_Click(object sender, System.EventArgs e)
        {

        }

        private void kbtnSkipUpdate_Click(object sender, System.EventArgs e)
        {

        }
        #endregion
    }
}