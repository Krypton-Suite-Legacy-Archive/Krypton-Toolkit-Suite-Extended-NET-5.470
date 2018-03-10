namespace KryptonApplicationUpdater.UI.Advanced.XMLBased
{
    partial class ValidateChecksumsForm
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
            this.ktdImportChecksumFile = new ComponentFactory.Krypton.Toolkit.KryptonTaskDialog();
            this.ktdbtnImport = new ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand();
            this.kpnlBackground = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonCheckBox1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.klblRIPEMD160 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblSHA256 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblSHA384 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblSHA512 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblSHA1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblMD5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonCheckBox2 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox3 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox4 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox5 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox6 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kbtnValidateChecksums = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).BeginInit();
            this.kpnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // ktdImportChecksumFile
            // 
            this.ktdImportChecksumFile.CheckboxText = null;
            this.ktdImportChecksumFile.CommandButtons.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand[] {
            this.ktdbtnImport});
            this.ktdImportChecksumFile.CommonButtons = ComponentFactory.Krypton.Toolkit.TaskDialogButtons.Cancel;
            this.ktdImportChecksumFile.Content = null;
            this.ktdImportChecksumFile.DefaultRadioButton = null;
            this.ktdImportChecksumFile.FooterHyperlink = null;
            this.ktdImportChecksumFile.FooterText = null;
            this.ktdImportChecksumFile.MainInstruction = null;
            this.ktdImportChecksumFile.WindowTitle = null;
            // 
            // ktdbtnImport
            // 
            this.ktdbtnImport.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ktdbtnImport.Text = "&Import";
            // 
            // kpnlBackground
            // 
            this.kpnlBackground.Controls.Add(this.kryptonButton1);
            this.kpnlBackground.Controls.Add(this.kbtnValidateChecksums);
            this.kpnlBackground.Controls.Add(this.kbtnCancel);
            this.kpnlBackground.Controls.Add(this.kryptonCheckBox6);
            this.kpnlBackground.Controls.Add(this.kryptonCheckBox5);
            this.kpnlBackground.Controls.Add(this.kryptonCheckBox4);
            this.kpnlBackground.Controls.Add(this.kryptonCheckBox3);
            this.kpnlBackground.Controls.Add(this.kryptonCheckBox2);
            this.kpnlBackground.Controls.Add(this.klblRIPEMD160);
            this.kpnlBackground.Controls.Add(this.klblSHA256);
            this.kpnlBackground.Controls.Add(this.klblSHA384);
            this.kpnlBackground.Controls.Add(this.klblSHA512);
            this.kpnlBackground.Controls.Add(this.klblSHA1);
            this.kpnlBackground.Controls.Add(this.klblMD5);
            this.kpnlBackground.Controls.Add(this.kryptonCheckBox1);
            this.kpnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlBackground.Location = new System.Drawing.Point(0, 0);
            this.kpnlBackground.Name = "kpnlBackground";
            this.kpnlBackground.Size = new System.Drawing.Size(1275, 530);
            this.kpnlBackground.TabIndex = 0;
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.Location = new System.Drawing.Point(12, 23);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Size = new System.Drawing.Size(19, 13);
            this.kryptonCheckBox1.TabIndex = 0;
            this.kryptonCheckBox1.Values.Text = "";
            // 
            // klblRIPEMD160
            // 
            this.klblRIPEMD160.Location = new System.Drawing.Point(37, 349);
            this.klblRIPEMD160.Name = "klblRIPEMD160";
            this.klblRIPEMD160.Size = new System.Drawing.Size(130, 26);
            this.klblRIPEMD160.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.klblRIPEMD160.TabIndex = 15;
            this.klblRIPEMD160.Values.Text = "RIPEMD-160: {0}";
            // 
            // klblSHA256
            // 
            this.klblSHA256.Location = new System.Drawing.Point(37, 151);
            this.klblSHA256.Name = "klblSHA256";
            this.klblSHA256.Size = new System.Drawing.Size(103, 26);
            this.klblSHA256.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.klblSHA256.TabIndex = 14;
            this.klblSHA256.Values.Text = "SHA-256: {0}";
            // 
            // klblSHA384
            // 
            this.klblSHA384.Location = new System.Drawing.Point(37, 217);
            this.klblSHA384.Name = "klblSHA384";
            this.klblSHA384.Size = new System.Drawing.Size(103, 26);
            this.klblSHA384.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.klblSHA384.TabIndex = 13;
            this.klblSHA384.Values.Text = "SHA-384: {0}";
            // 
            // klblSHA512
            // 
            this.klblSHA512.Location = new System.Drawing.Point(37, 283);
            this.klblSHA512.Name = "klblSHA512";
            this.klblSHA512.Size = new System.Drawing.Size(103, 26);
            this.klblSHA512.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.klblSHA512.TabIndex = 12;
            this.klblSHA512.Values.Text = "SHA-512: {0}";
            // 
            // klblSHA1
            // 
            this.klblSHA1.Location = new System.Drawing.Point(37, 85);
            this.klblSHA1.Name = "klblSHA1";
            this.klblSHA1.Size = new System.Drawing.Size(85, 26);
            this.klblSHA1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.klblSHA1.TabIndex = 11;
            this.klblSHA1.Values.Text = "SHA-1: {0}";
            // 
            // klblMD5
            // 
            this.klblMD5.Location = new System.Drawing.Point(37, 19);
            this.klblMD5.Name = "klblMD5";
            this.klblMD5.Size = new System.Drawing.Size(74, 26);
            this.klblMD5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.klblMD5.TabIndex = 10;
            this.klblMD5.Values.Text = "MD5: {0}";
            // 
            // kryptonCheckBox2
            // 
            this.kryptonCheckBox2.Location = new System.Drawing.Point(12, 222);
            this.kryptonCheckBox2.Name = "kryptonCheckBox2";
            this.kryptonCheckBox2.Size = new System.Drawing.Size(19, 13);
            this.kryptonCheckBox2.TabIndex = 16;
            this.kryptonCheckBox2.Values.Text = "";
            // 
            // kryptonCheckBox3
            // 
            this.kryptonCheckBox3.Location = new System.Drawing.Point(12, 158);
            this.kryptonCheckBox3.Name = "kryptonCheckBox3";
            this.kryptonCheckBox3.Size = new System.Drawing.Size(19, 13);
            this.kryptonCheckBox3.TabIndex = 17;
            this.kryptonCheckBox3.Values.Text = "";
            // 
            // kryptonCheckBox4
            // 
            this.kryptonCheckBox4.Location = new System.Drawing.Point(12, 290);
            this.kryptonCheckBox4.Name = "kryptonCheckBox4";
            this.kryptonCheckBox4.Size = new System.Drawing.Size(19, 13);
            this.kryptonCheckBox4.TabIndex = 18;
            this.kryptonCheckBox4.Values.Text = "";
            // 
            // kryptonCheckBox5
            // 
            this.kryptonCheckBox5.Location = new System.Drawing.Point(12, 357);
            this.kryptonCheckBox5.Name = "kryptonCheckBox5";
            this.kryptonCheckBox5.Size = new System.Drawing.Size(19, 13);
            this.kryptonCheckBox5.TabIndex = 19;
            this.kryptonCheckBox5.Values.Text = "";
            // 
            // kryptonCheckBox6
            // 
            this.kryptonCheckBox6.Location = new System.Drawing.Point(12, 92);
            this.kryptonCheckBox6.Name = "kryptonCheckBox6";
            this.kryptonCheckBox6.Size = new System.Drawing.Size(19, 13);
            this.kryptonCheckBox6.TabIndex = 20;
            this.kryptonCheckBox6.Values.Text = "";
            // 
            // kbtnValidateChecksums
            // 
            this.kbtnValidateChecksums.Location = new System.Drawing.Point(967, 480);
            this.kbtnValidateChecksums.Name = "kbtnValidateChecksums";
            this.kbtnValidateChecksums.Size = new System.Drawing.Size(179, 38);
            this.kbtnValidateChecksums.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnValidateChecksums.TabIndex = 22;
            this.kbtnValidateChecksums.Values.Text = "&Validate Checksums";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Location = new System.Drawing.Point(1152, 480);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(111, 38);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 21;
            this.kbtnCancel.Values.Text = "&Cancel";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(714, 480);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(247, 38);
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 23;
            this.kryptonButton1.Values.Text = "&Import Checksums from File";
            // 
            // ValidateChecksumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 530);
            this.Controls.Add(this.kpnlBackground);
            this.Name = "ValidateChecksumsForm";
            this.Text = "ValidateChecksumsForm";
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).EndInit();
            this.kpnlBackground.ResumeLayout(false);
            this.kpnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTaskDialog ktdImportChecksumFile;
        private ComponentFactory.Krypton.Toolkit.KryptonTaskDialogCommand ktdbtnImport;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnlBackground;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox6;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox5;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox4;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblRIPEMD160;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblSHA256;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblSHA384;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblSHA512;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblSHA1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblMD5;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnValidateChecksums;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}