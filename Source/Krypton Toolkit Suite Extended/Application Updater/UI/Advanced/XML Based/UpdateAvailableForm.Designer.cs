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
            this.pbxAppIcon = new System.Windows.Forms.PictureBox();
            this.klblNewUpdate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblCurrentVersion = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.klblServerVersion = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.wbChangelog = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).BeginInit();
            this.kpnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnlBackground
            // 
            this.kpnlBackground.Controls.Add(this.wbChangelog);
            this.kpnlBackground.Controls.Add(this.kryptonButton4);
            this.kpnlBackground.Controls.Add(this.kryptonButton3);
            this.kpnlBackground.Controls.Add(this.kryptonButton2);
            this.kpnlBackground.Controls.Add(this.kryptonButton1);
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
            // klblNewUpdate
            // 
            this.klblNewUpdate.Location = new System.Drawing.Point(162, 12);
            this.klblNewUpdate.Name = "klblNewUpdate";
            this.klblNewUpdate.Size = new System.Drawing.Size(316, 30);
            this.klblNewUpdate.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblNewUpdate.TabIndex = 3;
            this.klblNewUpdate.Values.Text = "A new update is available for: {0}";
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
            // kbtnCancel
            // 
            this.kbtnCancel.Location = new System.Drawing.Point(820, 745);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(89, 40);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 5;
            this.kbtnCancel.Values.Text = "&Cancel";
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
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(656, 745);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(158, 40);
            this.kryptonButton1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 7;
            this.kryptonButton1.Values.Text = "&Download Update";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(492, 745);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(158, 40);
            this.kryptonButton2.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.TabIndex = 8;
            this.kryptonButton2.Values.Text = "R&emind me Later";
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(12, 745);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(158, 40);
            this.kryptonButton3.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.TabIndex = 9;
            this.kryptonButton3.Values.Text = "More De&tails...";
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Location = new System.Drawing.Point(176, 745);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Size = new System.Drawing.Size(158, 40);
            this.kryptonButton4.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton4.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton4.TabIndex = 10;
            this.kryptonButton4.Values.Text = "&Skip Update";
            // 
            // wbChangelog
            // 
            this.wbChangelog.Location = new System.Drawing.Point(162, 146);
            this.wbChangelog.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbChangelog.Name = "wbChangelog";
            this.wbChangelog.Size = new System.Drawing.Size(747, 593);
            this.wbChangelog.TabIndex = 11;
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblServerVersion;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnCancel;
    }
}