namespace KryptonApplicationUpdater.UI.Advanced.XMLBased
{
    partial class ChecksumViewerForm
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
            this.kpnlBackground = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klblRIPEMD160 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblSHA256 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblSHA384 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblSHA512 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblSHA1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kcbtnToggle = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.klblMD5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblFilename = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnValidateChecksums = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kMan = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).BeginInit();
            this.kpnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // kpnlBackground
            // 
            this.kpnlBackground.Controls.Add(this.klblRIPEMD160);
            this.kpnlBackground.Controls.Add(this.klblSHA256);
            this.kpnlBackground.Controls.Add(this.klblSHA384);
            this.kpnlBackground.Controls.Add(this.klblSHA512);
            this.kpnlBackground.Controls.Add(this.klblSHA1);
            this.kpnlBackground.Controls.Add(this.kcbtnToggle);
            this.kpnlBackground.Controls.Add(this.klblMD5);
            this.kpnlBackground.Controls.Add(this.klblFilename);
            this.kpnlBackground.Controls.Add(this.kbtnValidateChecksums);
            this.kpnlBackground.Controls.Add(this.kbtnCancel);
            this.kpnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlBackground.Location = new System.Drawing.Point(0, 0);
            this.kpnlBackground.Name = "kpnlBackground";
            this.kpnlBackground.Size = new System.Drawing.Size(1250, 633);
            this.kpnlBackground.TabIndex = 0;
            // 
            // klblRIPEMD160
            // 
            this.klblRIPEMD160.Location = new System.Drawing.Point(12, 397);
            this.klblRIPEMD160.Name = "klblRIPEMD160";
            this.klblRIPEMD160.Size = new System.Drawing.Size(130, 26);
            this.klblRIPEMD160.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.klblRIPEMD160.TabIndex = 9;
            this.klblRIPEMD160.Values.Text = "RIPEMD-160: {0}";
            // 
            // klblSHA256
            // 
            this.klblSHA256.Location = new System.Drawing.Point(12, 199);
            this.klblSHA256.Name = "klblSHA256";
            this.klblSHA256.Size = new System.Drawing.Size(103, 26);
            this.klblSHA256.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.klblSHA256.TabIndex = 8;
            this.klblSHA256.Values.Text = "SHA-256: {0}";
            // 
            // klblSHA384
            // 
            this.klblSHA384.Location = new System.Drawing.Point(12, 265);
            this.klblSHA384.Name = "klblSHA384";
            this.klblSHA384.Size = new System.Drawing.Size(103, 26);
            this.klblSHA384.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.klblSHA384.TabIndex = 7;
            this.klblSHA384.Values.Text = "SHA-384: {0}";
            // 
            // klblSHA512
            // 
            this.klblSHA512.Location = new System.Drawing.Point(12, 331);
            this.klblSHA512.Name = "klblSHA512";
            this.klblSHA512.Size = new System.Drawing.Size(103, 26);
            this.klblSHA512.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.klblSHA512.TabIndex = 6;
            this.klblSHA512.Values.Text = "SHA-512: {0}";
            // 
            // klblSHA1
            // 
            this.klblSHA1.Location = new System.Drawing.Point(12, 133);
            this.klblSHA1.Name = "klblSHA1";
            this.klblSHA1.Size = new System.Drawing.Size(85, 26);
            this.klblSHA1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.klblSHA1.TabIndex = 5;
            this.klblSHA1.Values.Text = "SHA-1: {0}";
            // 
            // kcbtnToggle
            // 
            this.kcbtnToggle.Location = new System.Drawing.Point(12, 583);
            this.kcbtnToggle.Name = "kcbtnToggle";
            this.kcbtnToggle.Size = new System.Drawing.Size(224, 38);
            this.kcbtnToggle.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbtnToggle.TabIndex = 4;
            this.kcbtnToggle.Values.Text = "&Toggle UPPERCASE";
            this.kcbtnToggle.Click += new System.EventHandler(this.kcbtnToggle_Click);
            // 
            // klblMD5
            // 
            this.klblMD5.Location = new System.Drawing.Point(12, 67);
            this.klblMD5.Name = "klblMD5";
            this.klblMD5.Size = new System.Drawing.Size(74, 26);
            this.klblMD5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.klblMD5.TabIndex = 3;
            this.klblMD5.Values.Text = "MD5: {0}";
            // 
            // klblFilename
            // 
            this.klblFilename.Location = new System.Drawing.Point(12, 12);
            this.klblFilename.Name = "klblFilename";
            this.klblFilename.Size = new System.Drawing.Size(366, 26);
            this.klblFilename.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblFilename.TabIndex = 2;
            this.klblFilename.Values.Text = "These are the checksum values for the file: {0}";
            // 
            // kbtnValidateChecksums
            // 
            this.kbtnValidateChecksums.Location = new System.Drawing.Point(942, 583);
            this.kbtnValidateChecksums.Name = "kbtnValidateChecksums";
            this.kbtnValidateChecksums.Size = new System.Drawing.Size(179, 38);
            this.kbtnValidateChecksums.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnValidateChecksums.TabIndex = 1;
            this.kbtnValidateChecksums.Values.Text = "&Validate Checksums";
            this.kbtnValidateChecksums.Click += new System.EventHandler(this.kbtnValidateChecksums_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Location = new System.Drawing.Point(1127, 583);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(111, 38);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 0;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // ChecksumViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 633);
            this.Controls.Add(this.kpnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChecksumViewerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checksum Viewer";
            this.Load += new System.EventHandler(this.ChecksumViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).EndInit();
            this.kpnlBackground.ResumeLayout(false);
            this.kpnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnlBackground;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblRIPEMD160;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblSHA256;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblSHA384;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblSHA512;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblSHA1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton kcbtnToggle;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblMD5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblFilename;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnValidateChecksums;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kMan;
    }
}