using ComponentFactory.Krypton.Toolkit;
using GlobalUtilities.Classes;
using KryptonApplicationUpdater.Classes;
using KryptonApplicationUpdater.Classes.SettingsManager;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace KryptonApplicationUpdater.UI.Advanced.XMLBased
{
    public partial class UpdateDownloadForm : KryptonForm
    {
        #region Variables
        private Stopwatch stopwatch = new Stopwatch();

        private WebClient downloadClient = new WebClient();

        private GlobalMethods globalMethods = new GlobalMethods();

        private InternalApplicationUpdaterSettingsManager internalApplicationUpdaterSettingsManager = new InternalApplicationUpdaterSettingsManager();

        private XMLFileApplicationUpdaterSettingsManager xmlFileApplicationUpdaterSettingsManager = new XMLFileApplicationUpdaterSettingsManager();

        private UpdaterLogic updaterLogic = new UpdaterLogic();
        #endregion

        public UpdateDownloadForm()
        {
            InitializeComponent();
        }

        private void UpdateDownloadForm_Load(object sender, EventArgs e)
        {
            kuacbtnInstallUpdate.ProcessName = internalApplicationUpdaterSettingsManager.GetDestinationDownloadPath();

            globalMethods.CheckInternetConnectionState(internalApplicationUpdaterSettingsManager.GetXMLFileURL());

            if (globalMethods.GetInternetConnectionState())
            {
                updaterLogic.DownloadFile(downloadClient, xmlFileApplicationUpdaterSettingsManager.GetUpdatePackageServerURLDownloadLocation(), internalApplicationUpdaterSettingsManager.GetDestinationDownloadPath(), klblDownloadingFrom, klblDownloadingTo, klblDownloaded, klblCurrentSpeed, klblDownloadPercent, pbDownloadIndicator, null, null, kuacbtnInstallUpdate);
            }
        }

        private void DownloadDisposed(object sender, EventArgs e)
        {
            if (File.Exists(internalApplicationUpdaterSettingsManager.GetDestinationDownloadPath()))
            {
                File.Delete(internalApplicationUpdaterSettingsManager.GetDestinationDownloadPath());
            }
        }

        private void klblDownloadingFrom_MouseHover(object sender, EventArgs e)
        {
            ttHelp.Tag = klblDownloadingFrom.Text;

            ttHelp.UseFading = true;
        }

        private void klblDownloadingTo_MouseHover(object sender, EventArgs e)
        {
            ttHelp.Tag = klblDownloadingTo.Text;

            ttHelp.UseFading = true;
        }

        private void klblDownloaded_MouseHover(object sender, EventArgs e)
        {
            ttHelp.Tag = klblDownloaded.Text;

            ttHelp.UseFading = true;
        }

        private void klblCurrentSpeed_MouseHover(object sender, EventArgs e)
        {
            ttHelp.Tag = klblCurrentSpeed.Text;

            ttHelp.UseFading = true;
        }

        private void pbDownloadIndicator_MouseHover(object sender, EventArgs e)
        {
            ttHelp.Tag = klblDownloadPercent.Text;

            ttHelp.UseFading = true;
        }

        private void klblDownloadPercent_MouseHover(object sender, EventArgs e)
        {
            ttHelp.Tag = klblDownloadPercent.Text;

            ttHelp.UseFading = true;
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            if (downloadClient.IsBusy)
            {
                if (KryptonMessageBox.Show("A download is currently in progress. Abort now?", "Abort Download", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    downloadClient.Dispose();

                    Hide();
                }
            }
            else
            {
                Hide();
            }
        }

        private void kuacbtnInstallUpdate_Click(object sender, EventArgs e)
        {
            Process.Start(kuacbtnInstallUpdate.ProcessName);
        }
    }
}