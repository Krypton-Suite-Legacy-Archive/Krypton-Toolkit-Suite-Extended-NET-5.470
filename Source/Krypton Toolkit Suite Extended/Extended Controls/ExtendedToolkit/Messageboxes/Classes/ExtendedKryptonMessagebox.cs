using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Messageboxes.Classes
{
    public class ExtendedKryptonMessagebox : KryptonForm
    {
        #region Designer Code
        private void InitializeComponent()
        {
            this.kpnlBackdrop = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klblMessage = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.kchkOptionalCheck = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kbtnButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kpnlBottom = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pbxDivider = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackdrop)).BeginInit();
            this.kpnlBackdrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBottom)).BeginInit();
            this.kpnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDivider)).BeginInit();
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
            // kryptonPanel1
            // 
            this.kpnlBottom.Controls.Add(this.kchkOptionalCheck);
            this.kpnlBottom.Controls.Add(this.kbtnButton3);
            this.kpnlBottom.Controls.Add(this.kbtnButton1);
            this.kpnlBottom.Controls.Add(this.kbtnButton2);
            this.kpnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpnlBottom.Location = new System.Drawing.Point(0, 401);
            this.kpnlBottom.Name = "kryptonPanel1";
            this.kpnlBottom.Size = new System.Drawing.Size(800, 49);
            this.kpnlBottom.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pbxDivider.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbxDivider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbxDivider.Location = new System.Drawing.Point(0, 399);
            this.pbxDivider.Name = "pictureBox1";
            this.pbxDivider.Size = new System.Drawing.Size(800, 2);
            this.pbxDivider.TabIndex = 2;
            this.pbxDivider.TabStop = false;
            // 
            // ExtendedKryptonMessagebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxDivider);
            this.Controls.Add(this.kpnlBottom);
            this.Controls.Add(this.kpnlBackdrop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtendedKryptonMessagebox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExtendedKryptonMessagebox";
            this.Load += new System.EventHandler(this.ExtendedKryptonMessagebox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackdrop)).EndInit();
            this.kpnlBackdrop.ResumeLayout(false);
            this.kpnlBackdrop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBottom)).EndInit();
            this.kpnlBottom.ResumeLayout(false);
            this.kpnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDivider)).EndInit();
            this.ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private KryptonPanel kpnlBackdrop;
        private PictureBox pbxIcon;
        private KryptonCheckBox kchkOptionalCheck;
        private KryptonButton kbtnButton3;
        private KryptonButton kbtnButton2;
        private KryptonButton kbtnButton1;
        private KryptonLabel klblMessage;
        private KryptonPanel kpnlBottom;
        private PictureBox pbxDivider;
        private IContainer components = null;
        #endregion

        private void ExtendedKryptonMessagebox_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}