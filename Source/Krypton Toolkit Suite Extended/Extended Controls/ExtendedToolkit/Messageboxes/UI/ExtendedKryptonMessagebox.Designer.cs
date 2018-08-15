namespace KryptonExtendedToolkit.ExtendedToolkit.Messageboxes.UI
{
    partial class ExtendedKryptonMessagebox
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
            this.kpnlBackdrop = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kchkOptionalCheck = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kbtnButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.klblMessage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackdrop)).BeginInit();
            this.kpnlBackdrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnlBackdrop
            // 
            this.kpnlBackdrop.Controls.Add(this.klblMessage);
            this.kpnlBackdrop.Controls.Add(this.pbxIcon);
            this.kpnlBackdrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlBackdrop.Location = new System.Drawing.Point(0, 0);
            this.kpnlBackdrop.Name = "kpnlBackdrop";
            this.kpnlBackdrop.Size = new System.Drawing.Size(800, 450);
            this.kpnlBackdrop.TabIndex = 0;
            // 
            // kchkOptionalCheck
            // 
            this.kchkOptionalCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kchkOptionalCheck.Location = new System.Drawing.Point(12, 11);
            this.kchkOptionalCheck.Name = "kchkOptionalCheck";
            this.kchkOptionalCheck.Size = new System.Drawing.Size(101, 26);
            this.kchkOptionalCheck.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kchkOptionalCheck.TabIndex = 5;
            this.kchkOptionalCheck.Values.Text = "Some Text";
            // 
            // kbtnButton3
            // 
            this.kbtnButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnButton3.AutoSize = true;
            this.kbtnButton3.Location = new System.Drawing.Point(679, 7);
            this.kbtnButton3.Name = "kbtnButton3";
            this.kbtnButton3.Size = new System.Drawing.Size(109, 30);
            this.kbtnButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnButton3.TabIndex = 4;
            this.kbtnButton3.Values.Text = "Button 3 Text";
            this.kbtnButton3.Click += new System.EventHandler(this.kbtnButton3_Click);
            // 
            // kbtnButton2
            // 
            this.kbtnButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnButton2.AutoSize = true;
            this.kbtnButton2.Location = new System.Drawing.Point(564, 7);
            this.kbtnButton2.Name = "kbtnButton2";
            this.kbtnButton2.Size = new System.Drawing.Size(109, 30);
            this.kbtnButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnButton2.TabIndex = 3;
            this.kbtnButton2.Values.Text = "Button 2 Text";
            this.kbtnButton2.Click += new System.EventHandler(this.kbtnButton2_Click);
            // 
            // kbtnButton1
            // 
            this.kbtnButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnButton1.AutoSize = true;
            this.kbtnButton1.Location = new System.Drawing.Point(449, 7);
            this.kbtnButton1.Name = "kbtnButton1";
            this.kbtnButton1.Size = new System.Drawing.Size(109, 30);
            this.kbtnButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnButton1.TabIndex = 2;
            this.kbtnButton1.Values.Text = "Button 1 Text";
            // 
            // klblMessage
            // 
            this.klblMessage.Location = new System.Drawing.Point(146, 12);
            this.klblMessage.Name = "klblMessage";
            this.klblMessage.Size = new System.Drawing.Size(215, 26);
            this.klblMessage.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblMessage.TabIndex = 1;
            this.klblMessage.Values.Text = "<#YOUR MESSAGE HERE#>";
            // 
            // pbxIcon
            // 
            this.pbxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxIcon.Location = new System.Drawing.Point(12, 12);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(128, 128);
            this.pbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxIcon.TabIndex = 0;
            this.pbxIcon.TabStop = false;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kchkOptionalCheck);
            this.kryptonPanel1.Controls.Add(this.kbtnButton3);
            this.kryptonPanel1.Controls.Add(this.kbtnButton1);
            this.kryptonPanel1.Controls.Add(this.kbtnButton2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 401);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(800, 49);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 399);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 2);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ExtendedKryptonMessagebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kpnlBackdrop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtendedKryptonMessagebox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExtendedKryptonMessagebox";
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackdrop)).EndInit();
            this.kpnlBackdrop.ResumeLayout(false);
            this.kpnlBackdrop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnlBackdrop;
        private System.Windows.Forms.PictureBox pbxIcon;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kchkOptionalCheck;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblMessage;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}