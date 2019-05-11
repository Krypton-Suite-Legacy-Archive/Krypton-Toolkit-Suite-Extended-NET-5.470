#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.Development;
using ExtendedControls.Base.Code.Settings;
using ExtendedControls.Base.Enumerations;
using System;

namespace ExtendedControls.ExtendedToolkit.UI.Dialogues
{
    public class KryptonCredentialDialog : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kpnlControls;
        private KryptonPanel kpnlContents;
        private KryptonButton btnCreate;
        private KryptonButton kbtnAuthenticate;
        private KryptonButton kbtnCancel;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Panel pnlSplitter;

        private void InitializeComponent()
        {
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues3 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues2 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues1 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonCredentialDialog));
            this.kpnlControls = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kpnlContents = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlSplitter = new System.Windows.Forms.Panel();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnAuthenticate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCreate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlControls)).BeginInit();
            this.kpnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlContents)).BeginInit();
            this.kpnlContents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnlControls
            // 
            this.kpnlControls.Controls.Add(this.btnCreate);
            this.kpnlControls.Controls.Add(this.kbtnAuthenticate);
            this.kpnlControls.Controls.Add(this.kbtnCancel);
            this.kpnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpnlControls.Location = new System.Drawing.Point(0, 356);
            this.kpnlControls.Name = "kpnlControls";
            this.kpnlControls.Size = new System.Drawing.Size(775, 50);
            this.kpnlControls.TabIndex = 0;
            // 
            // kpnlContents
            // 
            this.kpnlContents.Controls.Add(this.pbxImage);
            this.kpnlContents.Dock = System.Windows.Forms.DockStyle.Top;
            this.kpnlContents.Location = new System.Drawing.Point(0, 0);
            this.kpnlContents.Name = "kpnlContents";
            this.kpnlContents.Size = new System.Drawing.Size(775, 355);
            this.kpnlContents.TabIndex = 1;
            // 
            // pnlSplitter
            // 
            this.pnlSplitter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSplitter.Location = new System.Drawing.Point(0, 355);
            this.pnlSplitter.Name = "pnlSplitter";
            this.pnlSplitter.Size = new System.Drawing.Size(775, 1);
            this.pnlSplitter.TabIndex = 2;
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(646, 9);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(117, 29);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 12;
            popupPositionValues3.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues3.PlacementTarget = null;
            this.kbtnCancel.ToolTipValues.ToolTipPosition = popupPositionValues3;
            this.kbtnCancel.Values.Text = "&Cancel";
            // 
            // kbtnAuthenticate
            // 
            this.kbtnAuthenticate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnAuthenticate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnAuthenticate.Enabled = false;
            this.kbtnAuthenticate.Location = new System.Drawing.Point(490, 9);
            this.kbtnAuthenticate.Name = "kbtnAuthenticate";
            this.kbtnAuthenticate.Size = new System.Drawing.Size(150, 29);
            this.kbtnAuthenticate.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnAuthenticate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnAuthenticate.TabIndex = 13;
            popupPositionValues2.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues2.PlacementTarget = null;
            this.kbtnAuthenticate.ToolTipValues.ToolTipPosition = popupPositionValues2;
            this.kbtnAuthenticate.Values.Text = "A&uthenticate";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCreate.Location = new System.Drawing.Point(12, 9);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(141, 29);
            this.btnCreate.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.TabIndex = 14;
            popupPositionValues1.PlacementRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            popupPositionValues1.PlacementTarget = null;
            this.btnCreate.ToolTipValues.ToolTipPosition = popupPositionValues1;
            this.btnCreate.Values.Text = "Create &New User";
            // 
            // pbxImage
            // 
            this.pbxImage.BackColor = System.Drawing.Color.Transparent;
            this.pbxImage.Location = new System.Drawing.Point(12, 12);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(128, 128);
            this.pbxImage.TabIndex = 0;
            this.pbxImage.TabStop = false;
            // 
            // KryptonCredentialDialog
            // 
            this.ClientSize = new System.Drawing.Size(775, 406);
            this.Controls.Add(this.pnlSplitter);
            this.Controls.Add(this.kpnlContents);
            this.Controls.Add(this.kpnlControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonCredentialDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.KryptonCredentialDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlControls)).EndInit();
            this.kpnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlContents)).EndInit();
            this.kpnlContents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        public KryptonCredentialDialog()
        {
            InitializeComponent();
        }

        private void KryptonCredentialDialog_Load(object sender, EventArgs e)
        {
            if (SettingsManager.GetDebugMode())
            {
                DevelopmentInformation.SetBuildInformation(this, DevelopmentState.PREALPHA);
            }
        }
    }
}