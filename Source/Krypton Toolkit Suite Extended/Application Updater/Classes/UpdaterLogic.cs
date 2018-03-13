using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.Controls;
using GlobalUtilities.Classes;
using KryptonApplicationUpdater.Classes.SettingsManager;
using KryptonApplicationUpdater.Enumerations;
using KryptonApplicationUpdater.Interfaces;
using Microsoft.WindowsAPICodePack.Taskbar;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace KryptonApplicationUpdater.Classes
{
    /// <summary>
    /// Handles the logic of the application updater.
    /// </summary>
    public class UpdaterLogic
    {
        #region Variables
        private KryptonLabel downloadSource = null, downloadDestination = null, amountDownloaded = null, currentSpeed = null, downloadPercentage = null;

        private ProgressBar downloadProgress = null;

        private Button _installUpdateButton = null;

        private KryptonButton _kryptonInstallUpdateButton = null;

        private KryptonUACShieldButton _kryptonUACShieldInstallUpdateButton = null;

        private Stopwatch stopwatch = new Stopwatch();

        private WebClient downloadClient;

        private GlobalMethods _globalMethods = new GlobalMethods();

        private ExceptionHandler _exceptionHandler = new ExceptionHandler();

        private XMLFileParser _parser = new XMLFileParser();

        private InternalApplicationUpdaterSettingsManager internalApplicationUpdaterSettingsManager = new InternalApplicationUpdaterSettingsManager();

        private XMLFileApplicationUpdaterSettingsManager xmlFileApplicationUpdaterSettingsManager = new XMLFileApplicationUpdaterSettingsManager();

        private FileUtilityMethods fileUtilityMethods = new FileUtilityMethods();

        private TranslationMethods translationMethods = new TranslationMethods();

        private NetworkUtilities networkUtilities = new NetworkUtilities();

        private IUpdatable _updatable;

        private IXMLData _xmlData;
        #endregion

        #region Property
        /// <summary>
        /// Gets or sets DownloadSource.
        /// </summary>
        /// <value>
        /// downloadSource.
        /// </value>
        private KryptonLabel DownloadSource
        {
            get
            {
                return downloadSource;
            }


            set
            {
                downloadSource = value;
            }
        }

        /// <summary>
        /// Gets or sets DownloadDestination.
        /// </summary>
        /// <value>
        /// downloadDestination.
        /// </value>
        private KryptonLabel DownloadDestination
        {
            get
            {
                return downloadDestination;
            }


            set
            {
                downloadDestination = value;
            }
        }

        /// <summary>
        /// Gets or sets AmountDownloaded.
        /// </summary>
        /// <value>
        /// amountDownloaded.
        /// </value>
        private KryptonLabel AmountDownloaded
        {
            get
            {
                return amountDownloaded;
            }


            set
            {
                amountDownloaded = value;
            }
        }

        /// <summary>
        /// Gets or sets CurrentSpeed.
        /// </summary>
        /// <value>
        /// currentSpeed.
        /// </value>
        private KryptonLabel CurrentSpeed
        {
            get
            {
                return currentSpeed;
            }


            set
            {
                currentSpeed = value;
            }
        }

        /// <summary>
        /// Gets or sets DownloadPercentage.
        /// </summary>
        /// <value>
        /// downloadPercentage.
        /// </value>
        private KryptonLabel DownloadPercentage
        {
            get
            {
                return downloadPercentage;
            }


            set
            {
                downloadPercentage = value;
            }
        }

        /// <summary>
        /// Gets or sets DownloadProgress.
        /// </summary>
        /// <value>
        /// downloadProgress.
        /// </value>
        private ProgressBar DownloadProgress
        {
            get
            {
                return downloadProgress;
            }


            set
            {
                downloadProgress = value;
            }
        }

        /// <summary>
        /// Gets or sets the install update button.
        /// </summary>
        /// <value>
        /// The install update button.
        /// </value>
        private Button InstallUpdateButton
        {
            get
            {
                return _installUpdateButton;
            }

            set
            {
                _installUpdateButton = value;
            }
        }

        /// <summary>
        /// Gets or sets the krypton install update button.
        /// </summary>
        /// <value>
        /// The krypton install update button.
        /// </value>
        private KryptonButton KryptonInstallUpdateButton
        {
            get
            {
                return _kryptonInstallUpdateButton;
            }

            set
            {
                _kryptonInstallUpdateButton = value;
            }
        }

        /// <summary>
        /// Gets or sets the krypton UAC shield install update button.
        /// </summary>
        /// <value>
        /// The krypton UAC shield install update button.
        /// </value>
        private KryptonUACShieldButton KryptonUACShieldInstallUpdateButton
        {
            get
            {
                return _kryptonUACShieldInstallUpdateButton;
            }

            set
            {
                _kryptonUACShieldInstallUpdateButton = value;
            }
        }

        /// <summary>
        /// Gets or sets the download client.
        /// </summary>
        /// <value>
        /// The download client.
        /// </value>
        private WebClient DownloadClient
        {
            get
            {
                return downloadClient;
            }

            set
            {
                downloadClient = value;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initialises a new instance of the <see cref="UpdaterLogic"/> class.
        /// </summary>
        /// <param name="isVistaSupported">if set to <c>true</c> [is vista supported].</param>
        public UpdaterLogic(bool isVistaSupported = false)
        {
            _globalMethods.CheckIfTargetPlatformIsSupported(isVistaSupported);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Checks for updates.
        /// </summary>
        /// <param name="xmlFilePath">The XML file path.</param>
        /// <param name="pingURL">The ping URL.</param>
        public void CheckForUpdates(string xmlFilePath, string pingURL)
        {
            networkUtilities.CheckInternetConnectionState(pingURL);

            try
            {
                if (_globalMethods.GetInternetConnectionState())
                {

                }
                else
                {

                }
            }
            catch (Exception e)
            {
                if (_globalMethods.GetIsTargetPlatformSupported())
                {
                    _exceptionHandler.ShowException($"Error: { e.Message }", true, false, false, false, false, null, null, "An Error has Occurred", MessageBoxButtons.OK, MessageBoxDefaultButton.Button1, MessageBoxIcon.Error);
                }
                else
                {

                }
            }
        }

        /// <summary>
        /// Downloads the file.
        /// </summary>
        /// <param name="downloadClient">The download client.</param>
        /// <param name="sourcePath">The source path.</param>
        /// <param name="destinationPath">The destination path.</param>
        /// <param name="downloadSource">The download source.</param>
        /// <param name="downloadDestination">The download destination.</param>
        /// <param name="amountDownloaded">The amount downloaded.</param>
        /// <param name="currentSpeed">The current speed.</param>
        /// <param name="downloadPercentage">The download percentage.</param>
        /// <param name="downloadProgress">The download progress.</param>
        /// <param name="installUpdateButton">The install update button.</param>
        /// <param name="kryptonInstallUpdateButton">The krypton install update button.</param>
        /// <param name="kryptonUACShieldInstallUpdateButton">The krypton UAC shield install update button.</param>
        /// <param name="hypertextTransferProtocolType">Type of the hypertext transfer protocol.</param>
        public void DownloadFile(WebClient downloadClient, string sourcePath, string destinationPath, KryptonLabel downloadSource = null, KryptonLabel downloadDestination = null, KryptonLabel amountDownloaded = null, KryptonLabel currentSpeed = null, KryptonLabel downloadPercentage = null, ProgressBar downloadProgress = null, Button installUpdateButton = null, KryptonButton kryptonInstallUpdateButton = null, KryptonUACShieldButton kryptonUACShieldInstallUpdateButton = null, HypertextTransferProtocolType hypertextTransferProtocolType = HypertextTransferProtocolType.HYPERTEXTTRANSFERPROTOCOL)
        {
            try
            {
                xmlFileApplicationUpdaterSettingsManager.SetUpdatePackageServerURLDownloadLocation(sourcePath);

                internalApplicationUpdaterSettingsManager.SetDestinationDownloadPath(destinationPath);

                if (kryptonUACShieldInstallUpdateButton != null)
                {
                    if (destinationPath != null)
                    {
                        kryptonUACShieldInstallUpdateButton.ProcessName = destinationPath;
                    }
                }

                #region Setting Variables Up
                SetDownloadClient(downloadClient);

                SetDownloadSource(downloadSource);

                SetDownloadDestination(downloadDestination);

                SetAmountDownloaded(amountDownloaded);

                SetCurrentSpeed(currentSpeed);

                SetDownloadPercentage(downloadPercentage);

                SetDownloadProgress(downloadProgress);

                SetInstallUpdateButton(installUpdateButton);

                SetKryptonInstallUpdateButton(kryptonInstallUpdateButton);

                SetKryptonUACShieldInstallUpdateButton(kryptonUACShieldInstallUpdateButton);
                #endregion

                if (GetDownloadClient() != null)
                {
                    using (DownloadClient = new WebClient())
                    {
                        GetDownloadClient().DownloadFileCompleted += DownloadFileCompleted;

                        GetDownloadClient().DownloadProgressChanged += DownloadProgressChanged;

                        GetDownloadClient().Disposed += Disposed;

                        Uri uri = sourcePath.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ? new Uri(sourcePath) : new Uri("http://" + sourcePath);

                        try
                        {
                            GetDownloadClient().DownloadFile(uri, destinationPath);
                        }
                        catch (Exception e)
                        {
                            if (_globalMethods.GetIsTargetPlatformSupported())
                            {
                                _exceptionHandler.ShowException($"Error: { e.Message }", true, false, false, false, false, null, null, "An Error has Occurred", MessageBoxButtons.OK, MessageBoxDefaultButton.Button1, MessageBoxIcon.Error);
                            }
                            else
                            {

                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                if (_globalMethods.GetIsTargetPlatformSupported())
                {
                    _exceptionHandler.ShowException($"Error: { e.Message }", true, false, false, false, false, null, null, "An Error has Occurred", MessageBoxButtons.OK, MessageBoxDefaultButton.Button1, MessageBoxIcon.Error);
                }
                else
                {

                }
            }
        }

        /// <summary>
        /// Aborts the download.
        /// </summary>
        /// <param name="downloadDestinationPath">The download destination path.</param>
        public void AbortDownload(string downloadDestinationPath = null)
        {
            if (GetDownloadClient() != null)
            {
                if (GetDownloadClient().IsBusy)
                {
                    if (KryptonMessageBox.Show($"A download of file: '{ Path.GetFileName(internalApplicationUpdaterSettingsManager.GetDestinationDownloadPath()) } is currently in progress.\nQuit now?", "Abort Download", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        GetDownloadClient().Dispose();
                    }
                }
            }
        }

        /// <summary>
        /// Disposes the specified sender.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Disposed(object sender, EventArgs e)
        {
            if (File.Exists(internalApplicationUpdaterSettingsManager.GetDestinationDownloadPath()))
            {
                File.Delete(internalApplicationUpdaterSettingsManager.GetDestinationDownloadPath());
            }
        }

        /// <summary>
        /// Downloads the progress changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="DownloadProgressChangedEventArgs"/> instance containing the event data.</param>
        private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            if (_globalMethods.IsWindowsAPICodePackSupported())
            {
                GetDownloadSource().Text = $"Downloading from: { xmlFileApplicationUpdaterSettingsManager.GetUpdatePackageServerURLDownloadLocation() }";

                GetDownloadDestination().Text = $"Downloading to: { internalApplicationUpdaterSettingsManager.GetDestinationDownloadPath() }";

                GetCurrentSpeed().Text = $"Current speed: { (e.BytesReceived / 1024d / stopwatch.Elapsed.TotalSeconds).ToString("0.00") } KB/s";

                //GetAmountDownloaded().Text = $"Downloaded: { fileUtilityMethods.ReturnOnlineFileSize((e.BytesReceived / 1024d / 1024d).ToString("0.0"), GetAmountDownloaded()) } of { fileUtilityMethods.ReturnOnlineFileSize(xmlFileApplicationUpdaterSettingsManager.GetUpdatePackageServerURLDownloadLocation(), GetAmountDownloaded()) }";

                GetAmountDownloaded().Text = $"Downloaded: { (e.BytesReceived / 1024d / 1024d).ToString("0.0") } MB's / { (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00") } MB's";

                GetDownloadProgress().Value = e.ProgressPercentage;

                GetDownloadPercentage().Text = $"{ e.ProgressPercentage.ToString() }%";

                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);

                TaskbarManager.Instance.SetProgressValue(e.ProgressPercentage, GetDownloadProgress().Maximum);
            }
            else
            {
                GetDownloadSource().Text = $"Downloading from: { xmlFileApplicationUpdaterSettingsManager.GetUpdatePackageServerURLDownloadLocation() }";

                GetDownloadDestination().Text = $"Downloading to: { internalApplicationUpdaterSettingsManager.GetDestinationDownloadPath() }";

                GetCurrentSpeed().Text = $"Current speed: { (e.BytesReceived / 1024d / stopwatch.Elapsed.TotalSeconds).ToString("0.00") } KB/s";

                //GetAmountDownloaded().Text = $"Downloaded: { fileUtilityMethods.ReturnOnlineFileSize((e.BytesReceived / 1024d / 1024d).ToString("0.0"), GetAmountDownloaded()) } of { fileUtilityMethods.ReturnOnlineFileSize(xmlFileApplicationUpdaterSettingsManager.GetUpdatePackageServerURLDownloadLocation(), GetAmountDownloaded()) }";

                GetAmountDownloaded().Text = $"Downloaded: { (e.BytesReceived / 1024d / 1024d).ToString("0.0") } MB's / { (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00") } MB's";

                GetDownloadProgress().Value = e.ProgressPercentage;

                GetDownloadPercentage().Text = $"{ e.ProgressPercentage.ToString() }%";
            }
        }

        /// <summary>
        /// Downloads the file completed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="AsyncCompletedEventArgs"/> instance containing the event data.</param>
        /// <exception cref="NotImplementedException"></exception>
        private void DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines whether [is newer than] [the specified current application version].
        /// </summary>
        /// <param name="currentApplicationVersion">The current application version.</param>
        /// <returns>
        ///   <c>true</c> if [is newer than] [the specified current application version]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsNewerThan(Version currentApplicationVersion)
        {
            try
            {
                if (xmlFileApplicationUpdaterSettingsManager.GetServerVersion() != null)
                {
                    return translationMethods.ParseVersion(xmlFileApplicationUpdaterSettingsManager.GetServerVersion()) > currentApplicationVersion;
                }
            }
            catch (Exception e)
            {
                _exceptionHandler.ShowException($"Error: { e.Message }", true);

                return false;
            }

            return false;
        }
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the DownloadSource to the value of value.
        /// </summary>
        /// <param name="value">The desired value of DownloadSource.</param>
        private void SetDownloadSource(KryptonLabel value)
        {
            DownloadSource = value;
        }

        /// <summary>
        /// Returns the value of the DownloadSource.
        /// </summary>
        /// <returns>The value of the DownloadSource.</returns>
        private KryptonLabel GetDownloadSource()
        {
            return DownloadSource;
        }

        /// <summary>
        /// Sets the DownloadDestination to the value of value.
        /// </summary>
        /// <param name="value">The desired value of DownloadDestination.</param>
        private void SetDownloadDestination(KryptonLabel value)
        {
            DownloadDestination = value;
        }

        /// <summary>
        /// Returns the value of the DownloadDestination.
        /// </summary>
        /// <returns>The value of the DownloadDestination.</returns>
        private KryptonLabel GetDownloadDestination()
        {
            return DownloadDestination;
        }

        /// <summary>
        /// Sets the AmountDownloaded to the value of value.
        /// </summary>
        /// <param name="value">The desired value of AmountDownloaded.</param>
        private void SetAmountDownloaded(KryptonLabel value)
        {
            AmountDownloaded = value;
        }

        /// <summary>
        /// Returns the value of the AmountDownloaded.
        /// </summary>
        /// <returns>The value of the AmountDownloaded.</returns>
        private KryptonLabel GetAmountDownloaded()
        {
            return AmountDownloaded;
        }

        /// <summary>
        /// Sets the CurrentSpeed to the value of value.
        /// </summary>
        /// <param name="value">The desired value of CurrentSpeed.</param>
        private void SetCurrentSpeed(KryptonLabel value)
        {
            CurrentSpeed = value;
        }

        /// <summary>
        /// Returns the value of the CurrentSpeed.
        /// </summary>
        /// <returns>The value of the CurrentSpeed.</returns>
        private KryptonLabel GetCurrentSpeed()
        {
            return CurrentSpeed;
        }

        /// <summary>
        /// Sets the DownloadPercentage to the value of value.
        /// </summary>
        /// <param name="value">The desired value of DownloadPercentage.</param>
        private void SetDownloadPercentage(KryptonLabel value)
        {
            DownloadPercentage = value;
        }

        /// <summary>
        /// Returns the value of the DownloadPercentage.
        /// </summary>
        /// <returns>The value of the DownloadPercentage.</returns>
        private KryptonLabel GetDownloadPercentage()
        {
            return DownloadPercentage;
        }

        /// <summary>
        /// Sets the DownloadProgress to the value of value.
        /// </summary>
        /// <param name="value">The desired value of DownloadProgress.</param>
        private void SetDownloadProgress(ProgressBar value)
        {
            DownloadProgress = value;
        }

        /// <summary>
        /// Returns the value of the DownloadProgress.
        /// </summary>
        /// <returns>The value of the DownloadProgress.</returns>
        private ProgressBar GetDownloadProgress()
        {
            return DownloadProgress;
        }

        /// <summary>
        /// Sets the InstallUpdateButton to the value of value.
        /// </summary>
        /// <param name="value">The desired value of InstallUpdateButton.</param>
        private void SetInstallUpdateButton(Button value)
        {
            InstallUpdateButton = value;
        }

        /// <summary>
        /// Returns the value of the InstallUpdateButton.
        /// </summary>
        /// <returns>The value of the InstallUpdateButton.</returns>
        private Button GetInstallUpdateButton()
        {
            return InstallUpdateButton;
        }

        /// <summary>
        /// Sets the KryptonInstallUpdateButton to the value of value.
        /// </summary>
        /// <param name="value">The desired value of KryptonInstallUpdateButton.</param>
        private void SetKryptonInstallUpdateButton(KryptonButton value)
        {
            KryptonInstallUpdateButton = value;
        }

        /// <summary>
        /// Returns the value of the KryptonInstallUpdateButton.
        /// </summary>
        /// <returns>The value of the KryptonInstallUpdateButton.</returns>
        private KryptonButton GetKryptonInstallUpdateButton()
        {
            return KryptonInstallUpdateButton;
        }

        /// <summary>
        /// Sets the KryptonUACShieldInstallUpdateButton to the value of value.
        /// </summary>
        /// <param name="value">The desired value of KryptonUACShieldInstallUpdateButton.</param>
        private void SetKryptonUACShieldInstallUpdateButton(KryptonUACShieldButton value)
        {
            KryptonUACShieldInstallUpdateButton = value;
        }

        /// <summary>
        /// Returns the value of the KryptonUACShieldInstallUpdateButton.
        /// </summary>
        /// <returns>The value of the KryptonUACShieldInstallUpdateButton.</returns>
        private KryptonUACShieldButton GetKryptonUACShieldInstallUpdateButton()
        {
            return KryptonUACShieldInstallUpdateButton;
        }

        /// <summary>
        /// Sets the DownloadClient to the value of value.
        /// </summary>
        /// <param name="value">The desired value of DownloadClient.</param>
        private void SetDownloadClient(WebClient value)
        {
            DownloadClient = value;
        }

        /// <summary>
        /// Returns the value of the DownloadClient.
        /// </summary>
        /// <returns>The value of the DownloadClient.</returns>
        private WebClient GetDownloadClient()
        {
            return DownloadClient;
        }
        #endregion
    }
}