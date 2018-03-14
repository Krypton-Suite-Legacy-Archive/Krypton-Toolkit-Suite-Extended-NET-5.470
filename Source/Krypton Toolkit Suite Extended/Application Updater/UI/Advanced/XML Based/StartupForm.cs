using KryptonApplicationUpdater.Classes.SettingsManager;
using System.Deployment.Internal;
using ComponentFactory.Krypton.Toolkit;
using GlobalUtilities.Classes;
using KryptonApplicationUpdater.Classes;
using KryptonApplicationUpdater.Interfaces;
using System;

namespace KryptonApplicationUpdater.UI.Advanced.XMLBased
{
    public partial class StartupForm : KryptonForm
    {
        #region Variables
        private bool _isRunning = false;

        private string _serverURL;

        private GlobalMethods _globalMethods = new GlobalMethods();

        private ExceptionHandler _exceptionHandler = new ExceptionHandler();

        private UpdaterLogic _updaterLogic = new UpdaterLogic();

        private InternalApplicationUpdaterSettingsManager internalApplicationUpdaterSettingsManager = new InternalApplicationUpdaterSettingsManager();

        private XMLFileApplicationUpdaterSettingsManager xmlFileApplicationUpdaterSettingsManager = new XMLFileApplicationUpdaterSettingsManager();

        private XMLFileParser xmlFileParser = new XMLFileParser();

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
        #endregion

        #region Constructor
        /// <summary>
        /// Initialises a new instance of the <see cref="StartupForm"/> class.
        /// </summary>
        /// <param name="useUACElevation">if set to <c>true</c> [use uac elevation].</param>
        /// <param name="serverURL">The server URL.</param>
        public StartupForm(bool useUACElevation = false, string serverURL = null)
        {
            InitializeComponent();

            SetServerURL(serverURL);

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
            if (_updaterLogic.CheckForUpdates(internalApplicationUpdaterSettingsManager.GetXMLFileURL(), Version.Parse(internalApplicationUpdaterSettingsManager.GetCurrentApplicationVersion()), internalApplicationUpdaterSettingsManager.GetXMLFileURL()))
            {
                UpdateAvailableForm updateAvailable = new UpdateAvailableForm(internalApplicationUpdaterSettingsManager.GetApplicationName(), Version.Parse(internalApplicationUpdaterSettingsManager.GetCurrentApplicationVersion()), Version.Parse(xmlFileApplicationUpdaterSettingsManager.GetServerVersion()), xmlFileApplicationUpdaterSettingsManager.GetChangelogServerURLDownloadLocation());

                updateAvailable.Show();

                Hide();
            }
            else
            {
                
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
            xmlFileParser.ParseXMLFile(new Uri(internalApplicationUpdaterSettingsManager.GetXMLFileURL()), internalApplicationUpdaterSettingsManager.GetApplicationIdentification());
        }
    }
}