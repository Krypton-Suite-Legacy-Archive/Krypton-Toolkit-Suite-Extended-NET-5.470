#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using Core.Classes;
using GlobalUtilities.Classes;
using KryptonApplicationUpdater.Classes;
using KryptonApplicationUpdater.Classes.SettingsManager;
using KryptonApplicationUpdater.Interfaces;
using KryptonExtendedToolkit.Base.Code;
using System;

namespace KryptonApplicationUpdater.UI.Advanced.XMLBased
{
    public partial class StartupForm : KryptonForm
    {
        #region Variables
        private bool _isRunning = false;

        private string _serverURL, _xmlServerFileURL;

        private Version _currentApplicationVersion;

        private GlobalMethods _globalMethods = new GlobalMethods();

        private ExceptionHandler _exceptionHandler = new ExceptionHandler();

        private UpdaterLogic _updaterLogic = new UpdaterLogic();

        private InternalApplicationUpdaterSettingsManager internalApplicationUpdaterSettingsManager = new InternalApplicationUpdaterSettingsManager();

        private XMLFileApplicationUpdaterSettingsManager xmlFileApplicationUpdaterSettingsManager = new XMLFileApplicationUpdaterSettingsManager();

        private XMLFileParser xmlFileParser = new XMLFileParser();

        private TranslationMethods translationMethods = new TranslationMethods();

        private IUpdatable _updatable;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets a value indicating whether this instance is running.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is running; otherwise, <c>false</c>.
        /// </value>
        public bool IsRunning
        {
            get
            {
                return _isRunning;
            }

            set
            {
                _isRunning = value;
            }
        }

        /// <summary>
        /// Gets or sets the server URL.
        /// </summary>
        /// <value>
        /// The server URL.
        /// </value>
        public string ServerURL
        {
            get
            {
                return _serverURL;
            }

            set
            {
                _serverURL = value;
            }
        }

        /// <summary>
        /// Gets or sets the XML server file URL.
        /// </summary>
        /// <value>
        /// The XML server file URL.
        /// </value>
        public string XMLServerFileURL
        {
            get
            {
                return _xmlServerFileURL;
            }

            set
            {
                _xmlServerFileURL = value;
            }
        }

        /// <summary>
        /// Gets or sets the current application version.
        /// </summary>
        /// <value>
        /// The current application version.
        /// </value>
        public Version CurrentApplicationVersion
        {
            get
            {
                return _currentApplicationVersion;
            }

            set
            {
                _currentApplicationVersion = value;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Initialises a new instance of the <see cref="StartupForm"/> class.
        /// </summary>
        /// <param name="xmlServerFileURL">The XML server file URL.</param>
        /// <param name="currentApplicationVersion">The current application version.</param>
        /// <param name="useUACElevation">if set to <c>true</c> [use uac elevation].</param>
        /// <param name="serverURL">The server URL.</param>
        public StartupForm(string xmlServerFileURL, Version currentApplicationVersion, bool useUACElevation = false, string serverURL = null)
        {
            InitializeComponent();

            SetServerURL(serverURL);

            ServerURL = serverURL;

            if (useUACElevation)
            {
                kbtnCheckForUpdates.Visible = false;

                kuacsbtnCheckForUpdates.Visible = true;
            }
            else
            {
                kbtnCheckForUpdates.Visible = true;

                kuacsbtnCheckForUpdates.Visible = false;
            }
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Handles the Click event of the kbtnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            if (IsRunning)
            {

            }
        }

        /// <summary>
        /// Handles the Click event of the kbtnCheckForUpdates control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void kbtnCheckForUpdates_Click(object sender, EventArgs e)
        {
            if (_updaterLogic.CheckForUpdates(ServerURL, CurrentApplicationVersion, internalApplicationUpdaterSettingsManager.GetXMLFileURL()))
            {
                UpdateAvailableForm updateAvailable = new UpdateAvailableForm(internalApplicationUpdaterSettingsManager.GetApplicationName(), Version.Parse(internalApplicationUpdaterSettingsManager.GetCurrentApplicationVersion()), Version.Parse(xmlFileApplicationUpdaterSettingsManager.GetServerVersion()), xmlFileApplicationUpdaterSettingsManager.GetChangelogServerURLDownloadLocation());

                updateAvailable.Show();

                Hide();
            }
            else
            {
                klblDetails.Text = $"No new updates are available.\nYour version: { CurrentApplicationVersion.ToString() }\nServer version: { xmlFileApplicationUpdaterSettingsManager.GetServerVersion() }";
            }
        }

        /// <summary>
        /// Handles the Click event of the kuacsbtnCheckForUpdates control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void kuacsbtnCheckForUpdates_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Methods

        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the ServerURL to the value of value.
        /// </summary>
        /// <param name="value">The desired value of ServerURL.</param>
        private void SetServerURL(string value)
        {
            ServerURL = value;
        }

        /// <summary>
        /// Returns the value of the ServerURL.
        /// </summary>
        /// <returns>The value of the ServerURL.</returns>
        private string GetServerURL()
        {
            return ServerURL;
        }
        #endregion

        private void tmrWaiting_Tick(object sender, EventArgs e)
        {
            pbWait.Value = pbWait.Value + 1;
        }

        private void kbtOptions_Click(object sender, EventArgs e)
        {
            UpdaterOptionsForm updaterOptions = new UpdaterOptionsForm();

            updaterOptions.Show();
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (XMLServerFileURL != null)
                {
                    xmlFileParser.ParseXMLFile(new Uri(XMLServerFileURL), null);
                }
            }
            catch (Exception exc)
            {

                throw;
            }
        }
    }
}