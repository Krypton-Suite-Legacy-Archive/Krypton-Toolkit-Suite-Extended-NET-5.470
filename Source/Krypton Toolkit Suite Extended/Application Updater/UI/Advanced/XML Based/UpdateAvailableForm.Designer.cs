namespace KryptonApplicationUpdater.UI.Advanced.XMLBased
{
    partial class UpdateAvailableForm
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
            this.kMan = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kpnlBackground = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.wbChangelog = new System.Windows.Forms.WebBrowser();
            this.kbtnSkipUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnMoreDetails = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnRemindLater = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnDownloadUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.klblServerVersion = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.klblCurrentVersion = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblNewUpdate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pbxAppIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).BeginInit();
            this.kpnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnlBackground
            // 
            this.kpnlBackground.Controls.Add(this.wbChangelog);
            this.kpnlBackground.Controls.Add(this.kbtnSkipUpdate);
            this.kpnlBackground.Controls.Add(this.kbtnMoreDetails);
            this.kpnlBackground.Controls.Add(this.kbtnRemindLater);
            this.kpnlBackground.Controls.Add(this.kbtnDownloadUpdate);
            this.kpnlBackground.Controls.Add(this.klblServerVersion);
            this.kpnlBackground.Controls.Add(this.kbtnCancel);
            this.kpnlBackground.Controls.Add(this.klblCurrentVersion);
            this.kpnlBackground.Controls.Add(this.klblNewUpdate);
            this.kpnlBackground.Controls.Add(this.pbxAppIcon);
            this.kpnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlBackground.Location = new System.Drawing.Point(0, 0);
            this.kpnlBackground.Name = "kpnlBackground";
            this.kpnlBackground.Size = new System.Drawing.Size(921, 797);
            this.kpnlBackground.TabIndex = 0;
            // 
            // wbChangelog
            // 
            this.wbChangelog.Location = new System.Drawing.Point(162, 146);
            this.wbChangelog.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbChangelog.Name = "wbChangelog";
            this.wbChangelog.Size = new System.Drawing.Size(747, 593);
            this.wbChangelog.TabIndex = 11;
            // 
            // kbtnSkipUpdate
            // 
            this.kbtnSkipUpdate.Location = new System.Drawing.Point(176, 745);
            this.kbtnSkipUpdate.Name = "kbtnSkipUpdate";
            this.kbtnSkipUpdate.Size = new System.Drawing.Size(158, 40);
            this.kbtnSkipUpdate.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSkipUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSkipUpdate.TabIndex = 10;
            this.kbtnSkipUpdate.Values.Text = "&Skip Update";
            this.kbtnSkipUpdate.Click += new System.EventHandler(this.kbtnSkipUpdate_Click);
            // 
            // kbtnMoreDetails
            // 
            this.kbtnMoreDetails.Location = new System.Drawing.Point(12, 745);
            this.kbtnMoreDetails.Name = "kbtnMoreDetails";
            this.kbtnMoreDetails.Size = new System.Drawing.Size(158, 40);
            this.kbtnMoreDetails.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnMoreDetails.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnMoreDetails.TabIndex = 9;
            this.kbtnMoreDetails.Values.Text = "More De&tails...";
            this.kbtnMoreDetails.Click += new System.EventHandler(this.kbtnMoreDetails_Click);
            // 
            // kbtnRemindLater
            // 
            this.kbtnRemindLater.Location = new System.Drawing.Point(492, 745);
            this.kbtnRemindLater.Name = "kbtnRemindLater";
            this.kbtnRemindLater.Size = new System.Drawing.Size(158, 40);
            this.kbtnRemindLater.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRemindLater.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRemindLater.TabIndex = 8;
            this.kbtnRemindLater.Values.Text = "R&emind me Later";
            this.kbtnRemindLater.Click += new System.EventHandler(this.kbtnRemindLater_Click);
            // 
            // kbtnDownloadUpdate
            // 
            this.kbtnDownloadUpdate.Location = new System.Drawing.Point(656, 745);
            this.kbtnDownloadUpdate.Name = "kbtnDownloadUpdate";
            this.kbtnDownloadUpdate.Size = new System.Drawing.Size(158, 40);
            this.kbtnDownloadUpdate.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnDownloadUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnDownloadUpdate.TabIndex = 7;
            this.kbtnDownloadUpdate.Values.Text = "&Download Update";
            this.kbtnDownloadUpdate.Click += new System.EventHandler(this.kbtnDownloadUpdate_Click);
            // 
            // klblServerVersion
            // 
            this.klblServerVersion.Location = new System.Drawing.Point(162, 114);
            this.klblServerVersion.Name = "klblServerVersion";
            this.klblServerVersion.Size = new System.Drawing.Size(155, 26);
            this.klblServerVersion.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblServerVersion.TabIndex = 6;
            this.klblServerVersion.Values.Text = "Server Version: {0}";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Location = new System.Drawing.Point(820, 745);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(89, 40);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 5;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // klblCurrentVersion
            // 
            this.klblCurrentVersion.Location = new System.Drawing.Point(162, 65);
            this.klblCurrentVersion.Name = "klblCurrentVersion";
            this.klblCurrentVersion.Size = new System.Drawing.Size(164, 26);
            this.klblCurrentVersion.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCurrentVersion.TabIndex = 4;
            this.klblCurrentVersion.Values.Text = "Current Version: {0}";
            // 
            // klblNewUpdate
            // 
            this.klblNewUpdate.Location = new System.Drawing.Point(162, 12);
            this.klblNewUpdate.Name = "klblNewUpdate";
            this.klblNewUpdate.Size = new System.Drawing.Size(316, 30);
            this.klblNewUpdate.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblNewUpdate.TabIndex = 3;
            this.klblNewUpdate.Values.Text = "A new update is available for: {0}";
            // 
            // pbxAppIcon
            // 
            this.pbxAppIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxAppIcon.Location = new System.Drawing.Point(12, 12);
            this.pbxAppIcon.Name = "pbxAppIcon";
            this.pbxAppIcon.Size = new System.Drawing.Size(128, 128);
            this.pbxAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxAppIcon.TabIndex = 0;
            this.pbxAppIcon.TabStop = false;
            // 
            // UpdateAvailableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 797);
            this.Controls.Add(this.kpnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateAvailableForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Available";
            this.Load += new System.EventHandler(this.UpdateAvailableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).EndInit();
            this.kpnlBackground.ResumeLayout(false);
            this.kpnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAppIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kMan;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnlBackground;
        private System.Windows.Forms.PictureBox pbxAppIcon;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblCurrentVersion;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblNewUpdate;
        private System.Windows.Forms.WebBrowser wbChangelog;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnSkipUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnMoreDetails;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnRemindLater;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnDownloadUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblServerVersion;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnCancel;
    }
}