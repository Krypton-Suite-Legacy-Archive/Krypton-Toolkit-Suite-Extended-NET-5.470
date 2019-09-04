using ComponentFactory.Krypton.Toolkit;
using KryptonSparkle.Classes;
using KryptonSparkle.Interfaces;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;

namespace KryptonSparkle.UX
{
    public class KryptonSparkleDownloadProgress : KryptonForm, IKryptonSparkleDownloadProgress
    {
        #region Designer Code
        private ExtendedStandardControls.KryptonLabelExtended klblSecurityHint;
        private ExtendedStandardControls.KryptonButtonExtended kbtnInstall;
        private System.Windows.Forms.ProgressBar progressDownload;
        private ExtendedStandardControls.KryptonLabelExtended klblHeader;
        private System.Windows.Forms.PictureBox pbxAppIcon;
        private ExtendedStandardControls.KryptonPanelExtended kryptonPanelExtended1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonSparkleDownloadProgress));
            this.kryptonPanelExtended1 = new ExtendedStandardControls.KryptonPanelExtended();
            this.klblSecurityHint = new ExtendedStandardControls.KryptonLabelExtended();
            this.kbtnInstall = new ExtendedStandardControls.KryptonButtonExtended();
            this.progressDownload = new System.Windows.Forms.ProgressBar();
            this.klblHeader = new ExtendedStandardControls.KryptonLabelExtended();
            this.pbxAppIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelExtended1)).BeginInit();
            this.kryptonPanelExtended1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanelExtended1
            // 
            this.kryptonPanelExtended1.BackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.BackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.Controls.Add(this.klblSecurityHint);
            this.kryptonPanelExtended1.Controls.Add(this.kbtnInstall);
            this.kryptonPanelExtended1.Controls.Add(this.progressDownload);
            this.kryptonPanelExtended1.Controls.Add(this.klblHeader);
            this.kryptonPanelExtended1.Controls.Add(this.pbxAppIcon);
            this.kryptonPanelExtended1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelExtended1.Image = null;
            this.kryptonPanelExtended1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelExtended1.Name = "kryptonPanelExtended1";
            this.kryptonPanelExtended1.Size = new System.Drawing.Size(617, 114);
            this.kryptonPanelExtended1.TabIndex = 0;
            // 
            // klblSecurityHint
            // 
            this.klblSecurityHint.AutoSize = false;
            this.klblSecurityHint.Image = null;
            this.klblSecurityHint.Location = new System.Drawing.Point(67, 66);
            this.klblSecurityHint.LongTextTypeface = null;
            this.klblSecurityHint.Name = "klblSecurityHint";
            this.klblSecurityHint.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblSecurityHint.Size = new System.Drawing.Size(536, 36);
            this.klblSecurityHint.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblSecurityHint.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblSecurityHint.StateCommon.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.klblSecurityHint.TabIndex = 1;
            this.klblSecurityHint.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.klblSecurityHint.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.klblSecurityHint.Values.Text = "The update was affected by not verified changes, it could be unsafe to install it" +
    "!";
            // 
            // kbtnInstall
            // 
            this.kbtnInstall.Image = null;
            this.kbtnInstall.Location = new System.Drawing.Point(264, 39);
            this.kbtnInstall.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnInstall.Name = "kbtnInstall";
            this.kbtnInstall.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnInstall.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnInstall.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnInstall.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnInstall.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnInstall.Size = new System.Drawing.Size(143, 25);
            this.kbtnInstall.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnInstall.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnInstall.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnInstall.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnInstall.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnInstall.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnInstall.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnInstall.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnInstall.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnInstall.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnInstall.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.TabIndex = 1;
            this.kbtnInstall.Values.Text = "I&nstall && Relaunch";
            this.kbtnInstall.Click += new System.EventHandler(this.KbtnInstall_Click);
            // 
            // progressDownload
            // 
            this.progressDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressDownload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressDownload.Location = new System.Drawing.Point(67, 39);
            this.progressDownload.Name = "progressDownload";
            this.progressDownload.Size = new System.Drawing.Size(536, 23);
            this.progressDownload.TabIndex = 10;
            // 
            // klblHeader
            // 
            this.klblHeader.Image = null;
            this.klblHeader.Location = new System.Drawing.Point(67, 12);
            this.klblHeader.LongTextTypeface = null;
            this.klblHeader.Name = "klblHeader";
            this.klblHeader.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblHeader.Size = new System.Drawing.Size(117, 21);
            this.klblHeader.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblHeader.TabIndex = 2;
            this.klblHeader.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.klblHeader.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.klblHeader.Values.Text = "Downloading {0}";
            // 
            // pbxAppIcon
            // 
            this.pbxAppIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxAppIcon.Image = global::KryptonSparkle.Properties.Resources.software_update_available1;
            this.pbxAppIcon.Location = new System.Drawing.Point(12, 12);
            this.pbxAppIcon.Name = "pbxAppIcon";
            this.pbxAppIcon.Size = new System.Drawing.Size(48, 48);
            this.pbxAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxAppIcon.TabIndex = 1;
            this.pbxAppIcon.TabStop = false;
            // 
            // KryptonSparkleDownloadProgress
            // 
            this.ClientSize = new System.Drawing.Size(617, 114);
            this.Controls.Add(this.kryptonPanelExtended1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonSparkleDownloadProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software Download";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelExtended1)).EndInit();
            this.kryptonPanelExtended1.ResumeLayout(false);
            this.kryptonPanelExtended1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAppIcon)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private String _tempName;
        private readonly KryptonSparkleAppCastItem _item;
        private readonly Sparkle _sparkle;
        private readonly bool _unattend;
        private bool _isDownloadDSAValid;
        #endregion

        #region Event
        public event EventHandler InstallAndRelaunch;
        #endregion

        #region Constructor
        public KryptonSparkleDownloadProgress(Sparkle sparkle, KryptonSparkleAppCastItem item, Image applicationIcon, Icon icon, bool unattended)
        {
            InitializeComponent();

            if (applicationIcon != null)
                pbxAppIcon.Image = applicationIcon;

            if (icon != null)
                Icon = icon;

            // store the item
            _sparkle = sparkle;
            _item = item;
            //_referencedAssembly = referencedAssembly;
            _unattend = unattended;

            // init ui
            kbtnInstall.Visible = false;
            klblHeader.Text = $"Downloading: { item.AppName }, { item.Version }";
            progressDownload.Maximum = 100;
            progressDownload.Minimum = 0;
            progressDownload.Step = 1;

            // show the right 
            Size = new Size(Size.Width, 107);
            klblSecurityHint.Visible = false;
        }
        #endregion

        public string TempFileName { get => _tempName; set => _tempName = value; }
        public bool IsDownloadDSAValid { get => _isDownloadDSAValid; set { _isDownloadDSAValid = value; UpdateDownloadValid(); } }

        public void OnClientDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled || e.Error != null)
            {
                return;
            }
            progressDownload.Visible = false;
            kbtnInstall.Visible = true;

            // this should move to Sparkle itself.
            // report message            
            _sparkle.ReportDiagnosticMessage("Finished downloading file to: " + _tempName);

            // check if we have a dsa signature in appcast            
            if (string.IsNullOrEmpty(_item.DSASignature))
            {
                _sparkle.ReportDiagnosticMessage("No DSA check needed");
            }
            else
            {
                this.IsDownloadDSAValid = false;

                // report
                _sparkle.ReportDiagnosticMessage("Performing DSA check");

                // get the assembly
                if (File.Exists(_tempName))
                {
                    // check if the file was downloaded successfully
                    String absolutePath = Path.GetFullPath(_tempName);
                    if (!File.Exists(absolutePath))
                        throw new FileNotFoundException();

                    // get the assembly reference from which we start the update progress
                    // only from this trusted assembly the public key can be used
                    Assembly refassembly = Assembly.GetEntryAssembly();
                    if (refassembly != null)
                    {
                        // Check if we found the public key in our entry assembly
                        if (NetSparkleDSAVerificator.ExistsPublicKey("NetSparkle_DSA.pub"))
                        {
                            // check the DSA Code and modify the back color            
                            NetSparkleDSAVerificator dsaVerifier = new NetSparkleDSAVerificator("NetSparkle_DSA.pub");
                            this.IsDownloadDSAValid = dsaVerifier.VerifyDSASignature(_item.DSASignature, _tempName);
                        }
                    }
                }

                UpdateDownloadValid();
            }

            // Check the unattended mode
            if (_unattend) KbtnInstall_Click(null, null);
        }

        public void OnClientDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressDownload.Value = e.ProgressPercentage;
        }

        void IKryptonSparkleDownloadProgress.ShowDialog()
        {
            ShowDialog();
        }

        /// <summary>
        /// Updates the UI to indicate if the download is valid
        /// </summary>
        private void UpdateDownloadValid()
        {
            if (this.IsDownloadDSAValid)
            {
                return;
            }
            Size = new Size(Size.Width, 137);
            klblSecurityHint.Visible = true;
            BackColor = Color.Tomato;
        }

        private void KbtnInstall_Click(object sender, EventArgs e)
        {
            if (InstallAndRelaunch != null) InstallAndRelaunch(this, new EventArgs());
        }
    }
}