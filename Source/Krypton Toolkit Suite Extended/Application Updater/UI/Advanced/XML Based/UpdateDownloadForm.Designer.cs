namespace KryptonApplicationUpdater.UI.Advanced.XMLBased
{
    partial class UpdateDownloadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDownloadForm));
            this.kpnlBackground = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kuacbtnInstallUpdate = new ExtendedControls.ExtendedToolkit.Controls.KryptonUACShieldButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.klblDownloadingFrom = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblDownloadingTo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblDownloaded = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblCurrentSpeed = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblDownloadPercent = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pbDownloadIndicator = new System.Windows.Forms.ProgressBar();
            this.kMan = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.ttHelp = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).BeginInit();
            this.kpnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // kpnlBackground
            // 
            this.kpnlBackground.Controls.Add(this.pbDownloadIndicator);
            this.kpnlBackground.Controls.Add(this.klblDownloadPercent);
            this.kpnlBackground.Controls.Add(this.klblCurrentSpeed);
            this.kpnlBackground.Controls.Add(this.klblDownloaded);
            this.kpnlBackground.Controls.Add(this.klblDownloadingTo);
            this.kpnlBackground.Controls.Add(this.klblDownloadingFrom);
            this.kpnlBackground.Controls.Add(this.kuacbtnInstallUpdate);
            this.kpnlBackground.Controls.Add(this.kbtnCancel);
            this.kpnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlBackground.Location = new System.Drawing.Point(0, 0);
            this.kpnlBackground.Name = "kpnlBackground";
            this.kpnlBackground.Size = new System.Drawing.Size(800, 298);
            this.kpnlBackground.TabIndex = 0;
            // 
            // kuacbtnInstallUpdate
            // 
            this.kuacbtnInstallUpdate.Enabled = false;
            this.kuacbtnInstallUpdate.Location = new System.Drawing.Point(472, 247);
            this.kuacbtnInstallUpdate.Name = "kuacbtnInstallUpdate";
            this.kuacbtnInstallUpdate.Size = new System.Drawing.Size(199, 38);
            this.kuacbtnInstallUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kuacbtnInstallUpdate.TabIndex = 2;
            this.kuacbtnInstallUpdate.Values.Image = ((System.Drawing.Image)(resources.GetObject("kuacbtnApply.Values.Image")));
            this.kuacbtnInstallUpdate.Values.Text = "&Install Update";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Location = new System.Drawing.Point(677, 247);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(111, 38);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 1;
            this.kbtnCancel.Values.Text = "&Cancel";
            // 
            // klblDownloadingFrom
            // 
            this.klblDownloadingFrom.AutoSize = false;
            this.klblDownloadingFrom.Location = new System.Drawing.Point(12, 12);
            this.klblDownloadingFrom.Name = "klblDownloadingFrom";
            this.klblDownloadingFrom.Size = new System.Drawing.Size(776, 26);
            this.klblDownloadingFrom.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblDownloadingFrom.TabIndex = 3;
            this.klblDownloadingFrom.Values.Text = "Downloading from: {0}";
            // 
            // klblDownloadingTo
            // 
            this.klblDownloadingTo.AutoSize = false;
            this.klblDownloadingTo.Location = new System.Drawing.Point(12, 73);
            this.klblDownloadingTo.Name = "klblDownloadingTo";
            this.klblDownloadingTo.Size = new System.Drawing.Size(776, 26);
            this.klblDownloadingTo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblDownloadingTo.TabIndex = 4;
            this.klblDownloadingTo.Values.Text = "Downloading to: {0}";
            // 
            // klblDownloaded
            // 
            this.klblDownloaded.Location = new System.Drawing.Point(12, 127);
            this.klblDownloaded.Name = "klblDownloaded";
            this.klblDownloaded.Size = new System.Drawing.Size(250, 26);
            this.klblDownloaded.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblDownloaded.TabIndex = 5;
            this.klblDownloaded.Values.Text = "Downloaded: {0} MB of {1} MB";
            // 
            // klblCurrentSpeed
            // 
            this.klblCurrentSpeed.Location = new System.Drawing.Point(538, 127);
            this.klblCurrentSpeed.Name = "klblCurrentSpeed";
            this.klblCurrentSpeed.Size = new System.Drawing.Size(189, 26);
            this.klblCurrentSpeed.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCurrentSpeed.TabIndex = 6;
            this.klblCurrentSpeed.Values.Text = "Current Speed: {0}KB/s";
            // 
            // klblDownloadPercent
            // 
            this.klblDownloadPercent.Location = new System.Drawing.Point(736, 204);
            this.klblDownloadPercent.Name = "klblDownloadPercent";
            this.klblDownloadPercent.Size = new System.Drawing.Size(44, 26);
            this.klblDownloadPercent.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.klblDownloadPercent.TabIndex = 7;
            this.klblDownloadPercent.Values.Text = "{0}%";
            // 
            // pbDownloadIndicator
            // 
            this.pbDownloadIndicator.Location = new System.Drawing.Point(12, 204);
            this.pbDownloadIndicator.Name = "pbDownloadIndicator";
            this.pbDownloadIndicator.Size = new System.Drawing.Size(718, 26);
            this.pbDownloadIndicator.TabIndex = 8;
            // 
            // UpdateDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 298);
            this.Controls.Add(this.kpnlBackground);
            this.Name = "UpdateDownloadForm";
            this.Text = "Downloading Update";
            this.Load += new System.EventHandler(this.UpdateDownloadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).EndInit();
            this.kpnlBackground.ResumeLayout(false);
            this.kpnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnlBackground;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnCancel;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonUACShieldButton kuacbtnInstallUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblCurrentSpeed;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblDownloaded;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblDownloadingTo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblDownloadingFrom;
        private System.Windows.Forms.ProgressBar pbDownloadIndicator;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblDownloadPercent;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kMan;
        private System.Windows.Forms.ToolTip ttHelp;
    }
}