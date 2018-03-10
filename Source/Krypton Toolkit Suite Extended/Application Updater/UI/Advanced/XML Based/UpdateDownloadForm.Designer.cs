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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDownloadForm));
            this.kpnlBackground = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kuacbtnInstallUpdate = new ExtendedControls.ExtendedToolkit.Controls.KryptonUACShieldButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.klblFilename = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblDownloaded = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblMD5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).BeginInit();
            this.kpnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // kpnlBackground
            // 
            this.kpnlBackground.Controls.Add(this.progressBar1);
            this.kpnlBackground.Controls.Add(this.klblMD5);
            this.kpnlBackground.Controls.Add(this.kryptonLabel2);
            this.kpnlBackground.Controls.Add(this.klblDownloaded);
            this.kpnlBackground.Controls.Add(this.kryptonLabel1);
            this.kpnlBackground.Controls.Add(this.klblFilename);
            this.kpnlBackground.Controls.Add(this.kuacbtnInstallUpdate);
            this.kpnlBackground.Controls.Add(this.kbtnCancel);
            this.kpnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlBackground.Location = new System.Drawing.Point(0, 0);
            this.kpnlBackground.Name = "kpnlBackground";
            this.kpnlBackground.Size = new System.Drawing.Size(800, 450);
            this.kpnlBackground.TabIndex = 0;
            // 
            // kuacbtnInstallUpdate
            // 
            this.kuacbtnInstallUpdate.Enabled = false;
            this.kuacbtnInstallUpdate.Location = new System.Drawing.Point(472, 400);
            this.kuacbtnInstallUpdate.Name = "kuacbtnInstallUpdate";
            this.kuacbtnInstallUpdate.Size = new System.Drawing.Size(199, 38);
            this.kuacbtnInstallUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kuacbtnInstallUpdate.TabIndex = 2;
            this.kuacbtnInstallUpdate.Values.Image = ((System.Drawing.Image)(resources.GetObject("kuacbtnApply.Values.Image")));
            this.kuacbtnInstallUpdate.Values.Text = "&Install Update";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Location = new System.Drawing.Point(677, 400);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(111, 38);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 1;
            this.kbtnCancel.Values.Text = "&Cancel";
            // 
            // klblFilename
            // 
            this.klblFilename.AutoSize = false;
            this.klblFilename.Location = new System.Drawing.Point(12, 12);
            this.klblFilename.Name = "klblFilename";
            this.klblFilename.Size = new System.Drawing.Size(776, 26);
            this.klblFilename.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblFilename.TabIndex = 3;
            this.klblFilename.Values.Text = "These are the checksum values for the file: {0}";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.AutoSize = false;
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 73);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(776, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Values.Text = "These are the checksum values for the file: {0}";
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
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(538, 127);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(250, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 6;
            this.kryptonLabel2.Values.Text = "Downloaded: {0} MB of {1} MB";
            // 
            // klblMD5
            // 
            this.klblMD5.Location = new System.Drawing.Point(736, 204);
            this.klblMD5.Name = "klblMD5";
            this.klblMD5.Size = new System.Drawing.Size(52, 26);
            this.klblMD5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.klblMD5.TabIndex = 7;
            this.klblMD5.Values.Text = "100%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 204);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(718, 26);
            this.progressBar1.TabIndex = 8;
            // 
            // UpdateDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblDownloaded;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblFilename;
        private System.Windows.Forms.ProgressBar progressBar1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblMD5;
    }
}