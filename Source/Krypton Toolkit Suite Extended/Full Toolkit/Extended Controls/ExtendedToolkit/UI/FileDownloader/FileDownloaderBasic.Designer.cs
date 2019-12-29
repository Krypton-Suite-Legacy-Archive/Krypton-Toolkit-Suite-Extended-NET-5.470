namespace ExtendedControls.ExtendedToolkit.UI.FileDownloader
{
    partial class FileDownloaderBasic
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klblCurrentDownloadSpeed = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnStop = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnSaveFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.klblDownloaded = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblDownloadPercentage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pbDownload = new System.Windows.Forms.ProgressBar();
            this.ktxtDownloadFileURL = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.klblCurrentDownloadSpeed);
            this.kryptonPanel1.Controls.Add(this.kbtnStop);
            this.kryptonPanel1.Controls.Add(this.kbtnSaveFile);
            this.kryptonPanel1.Controls.Add(this.klblDownloaded);
            this.kryptonPanel1.Controls.Add(this.klblDownloadPercentage);
            this.kryptonPanel1.Controls.Add(this.pbDownload);
            this.kryptonPanel1.Controls.Add(this.ktxtDownloadFileURL);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 248);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // klblCurrentDownloadSpeed
            // 
            this.klblCurrentDownloadSpeed.Location = new System.Drawing.Point(361, 212);
            this.klblCurrentDownloadSpeed.Name = "klblCurrentDownloadSpeed";
            this.klblCurrentDownloadSpeed.Size = new System.Drawing.Size(70, 26);
            this.klblCurrentDownloadSpeed.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCurrentDownloadSpeed.TabIndex = 5;
            this.klblCurrentDownloadSpeed.Values.Text = "{0} KB/s";
            // 
            // kbtnStop
            // 
            this.kbtnStop.AutoSize = true;
            this.kbtnStop.Enabled = false;
            this.kbtnStop.Location = new System.Drawing.Point(461, 162);
            this.kbtnStop.Name = "kbtnStop";
            this.kbtnStop.Size = new System.Drawing.Size(90, 30);
            this.kbtnStop.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnStop.TabIndex = 6;
            this.kbtnStop.Values.Text = "St&op";
            // 
            // kbtnSaveFile
            // 
            this.kbtnSaveFile.AutoSize = true;
            this.kbtnSaveFile.Location = new System.Drawing.Point(259, 162);
            this.kbtnSaveFile.Name = "kbtnSaveFile";
            this.kbtnSaveFile.Size = new System.Drawing.Size(90, 30);
            this.kbtnSaveFile.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSaveFile.TabIndex = 5;
            this.kbtnSaveFile.Values.Text = "&Save File";
            // 
            // klblDownloaded
            // 
            this.klblDownloaded.Location = new System.Drawing.Point(321, 82);
            this.klblDownloaded.Name = "klblDownloaded";
            this.klblDownloaded.Size = new System.Drawing.Size(148, 26);
            this.klblDownloaded.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblDownloaded.TabIndex = 4;
            this.klblDownloaded.Values.Text = "{0} MB\'s / {1} MB\'s";
            // 
            // klblDownloadPercentage
            // 
            this.klblDownloadPercentage.Location = new System.Drawing.Point(377, 114);
            this.klblDownloadPercentage.Name = "klblDownloadPercentage";
            this.klblDownloadPercentage.Size = new System.Drawing.Size(46, 26);
            this.klblDownloadPercentage.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblDownloadPercentage.TabIndex = 3;
            this.klblDownloadPercentage.Values.Text = "{0}%";
            // 
            // pbDownload
            // 
            this.pbDownload.Location = new System.Drawing.Point(12, 47);
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(776, 29);
            this.pbDownload.TabIndex = 2;
            // 
            // ktxtDownloadFileURL
            // 
            this.ktxtDownloadFileURL.Location = new System.Drawing.Point(12, 12);
            this.ktxtDownloadFileURL.Name = "ktxtDownloadFileURL";
            this.ktxtDownloadFileURL.Size = new System.Drawing.Size(776, 29);
            this.ktxtDownloadFileURL.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtDownloadFileURL.TabIndex = 1;
            // 
            // FileDownloaderBasic
            // 
            this.AcceptButton = this.kbtnSaveFile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 248);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileDownloaderBasic";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "File Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kMan;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxtDownloadFileURL;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblCurrentDownloadSpeed;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnStop;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnSaveFile;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblDownloaded;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblDownloadPercentage;
        private System.Windows.Forms.ProgressBar pbDownload;
    }
}