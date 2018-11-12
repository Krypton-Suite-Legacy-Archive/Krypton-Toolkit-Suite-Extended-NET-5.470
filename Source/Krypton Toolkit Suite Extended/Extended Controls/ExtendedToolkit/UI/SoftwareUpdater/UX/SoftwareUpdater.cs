using ComponentFactory.Krypton.Toolkit;
using KryptonExtendedToolkit.Base.Code;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.UI.SoftwareUpdater.UX
{
    public partial class SoftwareUpdater : KryptonForm
    {
        #region System
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton kuacbtnInstallUpdate;
        private KryptonLabel klblCurrentState;
        private KryptonManager kryptonManager1;
        private System.ComponentModel.IContainer components;
        private KryptonPalette kryptonPalette1;
        private KryptonLabel klblCurrentDownloadSpeed;
        private KryptonLabel klblUpdateDownloadSize;
        private KryptonLabel klblUpdateType;
        private KryptonLinkLabel kllblDownloadingTo;
        private KryptonLabel klblDownloadingFrom;
        private KryptonButton kbtnOptions;
        private KryptonButton kbtnCancel;
        private KryptonButton kbtnCheckForUpdates;
        private KryptonButton kbtnDownloadUpdate;
        private KryptonButton kbtnViewChecksums;
        private KryptonLabel klblDownloadProgressPercenta;
        private System.Windows.Forms.ProgressBar pbDownloadProgress;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftwareUpdater));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.klblCurrentState = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kuacbtnInstallUpdate = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.kbtnDownloadUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCheckForUpdates = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnOptions = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.klblDownloadingFrom = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kllblDownloadingTo = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.klblUpdateType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblUpdateDownloadSize = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblCurrentDownloadSpeed = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnViewChecksums = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pbDownloadProgress = new System.Windows.Forms.ProgressBar();
            this.klblDownloadProgressPercenta = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.klblDownloadProgressPercenta);
            this.kryptonPanel1.Controls.Add(this.pbDownloadProgress);
            this.kryptonPanel1.Controls.Add(this.kbtnViewChecksums);
            this.kryptonPanel1.Controls.Add(this.klblCurrentDownloadSpeed);
            this.kryptonPanel1.Controls.Add(this.klblUpdateDownloadSize);
            this.kryptonPanel1.Controls.Add(this.klblUpdateType);
            this.kryptonPanel1.Controls.Add(this.kllblDownloadingTo);
            this.kryptonPanel1.Controls.Add(this.klblDownloadingFrom);
            this.kryptonPanel1.Controls.Add(this.kbtnOptions);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Controls.Add(this.kbtnCheckForUpdates);
            this.kryptonPanel1.Controls.Add(this.kbtnDownloadUpdate);
            this.kryptonPanel1.Controls.Add(this.kuacbtnInstallUpdate);
            this.kryptonPanel1.Controls.Add(this.klblCurrentState);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1059, 409);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FilePath = "";
            // 
            // klblCurrentState
            // 
            this.klblCurrentState.Location = new System.Drawing.Point(12, 12);
            this.klblCurrentState.Name = "klblCurrentState";
            this.klblCurrentState.Size = new System.Drawing.Size(33, 26);
            this.klblCurrentState.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCurrentState.TabIndex = 0;
            this.klblCurrentState.Values.Text = "{0}";
            // 
            // kuacbtnInstallUpdate
            // 
            this.kuacbtnInstallUpdate.AutoSize = true;
            this.kuacbtnInstallUpdate.Location = new System.Drawing.Point(825, 251);
            this.kuacbtnInstallUpdate.Name = "kuacbtnInstallUpdate";
            this.kuacbtnInstallUpdate.Size = new System.Drawing.Size(156, 30);
            this.kuacbtnInstallUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kuacbtnInstallUpdate.TabIndex = 1;
            this.kuacbtnInstallUpdate.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonUACElevatedButton1.Values.Image")));
            this.kuacbtnInstallUpdate.Values.Text = "Inst&all Update";
            this.kuacbtnInstallUpdate.Click += new System.EventHandler(this.kuacbtnInstallUpdate_Click);
            // 
            // kbtnDownloadUpdate
            // 
            this.kbtnDownloadUpdate.AutoSize = true;
            this.kbtnDownloadUpdate.Location = new System.Drawing.Point(825, 251);
            this.kbtnDownloadUpdate.Name = "kbtnDownloadUpdate";
            this.kbtnDownloadUpdate.Size = new System.Drawing.Size(156, 30);
            this.kbtnDownloadUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnDownloadUpdate.TabIndex = 1;
            this.kbtnDownloadUpdate.Values.Text = "&Download Update...";
            this.kbtnDownloadUpdate.Click += new System.EventHandler(this.kbtnDownloadUpdate_Click);
            // 
            // kbtnCheckForUpdates
            // 
            this.kbtnCheckForUpdates.AutoSize = true;
            this.kbtnCheckForUpdates.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnCheckForUpdates.Location = new System.Drawing.Point(825, 251);
            this.kbtnCheckForUpdates.Name = "kbtnCheckForUpdates";
            this.kbtnCheckForUpdates.Size = new System.Drawing.Size(156, 30);
            this.kbtnCheckForUpdates.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCheckForUpdates.TabIndex = 2;
            this.kbtnCheckForUpdates.Values.Text = "C&heck for Updates...";
            this.kbtnCheckForUpdates.Click += new System.EventHandler(this.kbtnCheckForUpdates_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.AutoSize = true;
            this.kbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnCancel.Location = new System.Drawing.Point(987, 251);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(60, 30);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 3;
            this.kbtnCancel.Values.Text = "C&ancel";
            // 
            // kbtnOptions
            // 
            this.kbtnOptions.AutoSize = true;
            this.kbtnOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnOptions.Location = new System.Drawing.Point(750, 251);
            this.kbtnOptions.Name = "kbtnOptions";
            this.kbtnOptions.Size = new System.Drawing.Size(69, 30);
            this.kbtnOptions.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOptions.TabIndex = 4;
            this.kbtnOptions.Values.Text = "Op&tions";
            // 
            // klblDownloadingFrom
            // 
            this.klblDownloadingFrom.Location = new System.Drawing.Point(12, 61);
            this.klblDownloadingFrom.Name = "klblDownloadingFrom";
            this.klblDownloadingFrom.Size = new System.Drawing.Size(33, 26);
            this.klblDownloadingFrom.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblDownloadingFrom.TabIndex = 5;
            this.klblDownloadingFrom.Values.Text = "{0}";
            // 
            // kllblDownloadingTo
            // 
            this.kllblDownloadingTo.Location = new System.Drawing.Point(12, 110);
            this.kllblDownloadingTo.Name = "kllblDownloadingTo";
            this.kllblDownloadingTo.Size = new System.Drawing.Size(33, 26);
            this.kllblDownloadingTo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kllblDownloadingTo.TabIndex = 6;
            this.kllblDownloadingTo.Values.Text = "{0}";
            this.kllblDownloadingTo.LinkClicked += new System.EventHandler(this.kllblDownloadingTo_LinkClicked);
            // 
            // klblUpdateType
            // 
            this.klblUpdateType.Location = new System.Drawing.Point(12, 159);
            this.klblUpdateType.Name = "klblUpdateType";
            this.klblUpdateType.Size = new System.Drawing.Size(33, 26);
            this.klblUpdateType.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblUpdateType.TabIndex = 7;
            this.klblUpdateType.Values.Text = "{0}";
            // 
            // klblUpdateDownloadSize
            // 
            this.klblUpdateDownloadSize.Location = new System.Drawing.Point(406, 159);
            this.klblUpdateDownloadSize.Name = "klblUpdateDownloadSize";
            this.klblUpdateDownloadSize.Size = new System.Drawing.Size(33, 26);
            this.klblUpdateDownloadSize.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblUpdateDownloadSize.TabIndex = 8;
            this.klblUpdateDownloadSize.Values.Text = "{0}";
            // 
            // klblCurrentDownloadSpeed
            // 
            this.klblCurrentDownloadSpeed.Location = new System.Drawing.Point(790, 159);
            this.klblCurrentDownloadSpeed.Name = "klblCurrentDownloadSpeed";
            this.klblCurrentDownloadSpeed.Size = new System.Drawing.Size(33, 26);
            this.klblCurrentDownloadSpeed.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCurrentDownloadSpeed.TabIndex = 9;
            this.klblCurrentDownloadSpeed.Values.Text = "{0}";
            // 
            // kbtnViewChecksums
            // 
            this.kbtnViewChecksums.AutoSize = true;
            this.kbtnViewChecksums.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnViewChecksums.Location = new System.Drawing.Point(611, 251);
            this.kbtnViewChecksums.Name = "kbtnViewChecksums";
            this.kbtnViewChecksums.Size = new System.Drawing.Size(133, 30);
            this.kbtnViewChecksums.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnViewChecksums.TabIndex = 10;
            this.kbtnViewChecksums.Values.Text = "&View Checksums";
            // 
            // pbDownloadProgress
            // 
            this.pbDownloadProgress.Location = new System.Drawing.Point(12, 205);
            this.pbDownloadProgress.Name = "pbDownloadProgress";
            this.pbDownloadProgress.Size = new System.Drawing.Size(974, 26);
            this.pbDownloadProgress.TabIndex = 11;
            // 
            // klblDownloadProgressPercenta
            // 
            this.klblDownloadProgressPercenta.Location = new System.Drawing.Point(992, 205);
            this.klblDownloadProgressPercenta.Name = "klblDownloadProgressPercenta";
            this.klblDownloadProgressPercenta.Size = new System.Drawing.Size(33, 26);
            this.klblDownloadProgressPercenta.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblDownloadProgressPercenta.TabIndex = 12;
            this.klblDownloadProgressPercenta.Target = this.pbDownloadProgress;
            this.klblDownloadProgressPercenta.Values.Text = "{0}";
            // 
            // SoftwareUpdater
            // 
            this.ClientSize = new System.Drawing.Size(1059, 409);
            this.Controls.Add(this.kryptonPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SoftwareUpdater";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "{0} Software Updater";
            this.Load += new System.EventHandler(this.SoftwareUpdater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private string _applicationName, _serverURL, _updateXMLLocation, _updatePakageLocation, _localDestination;
        private Version _currentApplicationVersion, _serverVersion;
        #endregion

        #region Properties
        public string ApplicationName { get { return _applicationName; } set { _applicationName = value; } }

        public string ServerURL { get { return _serverURL; } set { _serverURL = value; } }

        public string UpdateXMLLocation { get { return _updateXMLLocation; } set { _updateXMLLocation = value; } }

        public string UpdatePakageLocation { get { return _updatePakageLocation; } set { _updatePakageLocation = value; } }

        public string LocalDestination { get { return _localDestination; } set { _localDestination = value; } }

        public Version CurrentApplicationVersion { get { return _currentApplicationVersion; } set { _currentApplicationVersion = value; } }

        public Version ServerVersion { get { return _serverVersion; } set { _serverVersion = value; } }
        #endregion

        #region Constructors        
        /// <summary>
        /// Initializes a new instance of the <see cref="SoftwareUpdater"/> class.
        /// </summary>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="currentApplicationVersion">The current application version.</param>
        /// <param name="serverURL">The server URL.</param>
        /// <param name="icon">The icon.</param>
        public SoftwareUpdater(string applicationName, Version currentApplicationVersion, string serverURL, Icon icon = null)
        {
            ApplicationName = applicationName;

            CurrentApplicationVersion = currentApplicationVersion;

            ServerURL = serverURL;

            if (icon != null)
            {
                Icon = icon;
            }
        }
        #endregion

        private void SoftwareUpdater_Load(object sender, EventArgs e)
        {

        }

        private void kbtnCheckForUpdates_Click(object sender, EventArgs e)
        {
            CheckForUpdates(CurrentApplicationVersion);
        }

        private void kllblDownloadingTo_LinkClicked(object sender, EventArgs e)
        {
            if (File.Exists(LocalDestination))
            {
                Process.Start(LocalDestination);
            }
        }
        private void kuacbtnInstallUpdate_Click(object sender, EventArgs e)
        {
            UtilityMethods.ElevateProcessWithAdministrativeRights(LocalDestination);

            Application.Exit();
        }
        private void kbtnDownloadUpdate_Click(object sender, EventArgs e)
        {
            DownloadUpdate(ServerURL, LocalDestination);
        }

        private void DownloadUpdate(string serverURL, string localDestination)
        {
            throw new NotImplementedException();
        }

        private void CheckForUpdates(Version currentApplicationVersion)
        {
            throw new NotImplementedException();
        }

        private bool IsNewerThan(Version currentApplicationVersion)
        {
            return ServerVersion > currentApplicationVersion;
        }
    }
}