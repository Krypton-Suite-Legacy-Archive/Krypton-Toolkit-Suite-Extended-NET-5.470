#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;

namespace ExtendedDialogs.Dialogs.About.Extras
{
    internal class CopyrightInformationDialog : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private KryptonPanel kpnlLogos;
        private System.Windows.Forms.PictureBox pbxApplicationLogo;
        private System.Windows.Forms.PictureBox pbxCopyright;
        private KryptonPanel kryptonPanel3;
        private ExtendedStandardControls.KryptonLabelExtended klblCopyright;
        private ExtendedStandardControls.KryptonButtonExtended kbeClose;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbeClose = new ExtendedStandardControls.KryptonButtonExtended();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klblCopyright = new ExtendedStandardControls.KryptonLabelExtended();
            this.kpnlLogos = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pbxCopyright = new System.Windows.Forms.PictureBox();
            this.pbxApplicationLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlLogos)).BeginInit();
            this.kpnlLogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCopyright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxApplicationLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbeClose);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 160);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(533, 50);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kbeClose
            // 
            this.kbeClose.AutoSize = true;
            this.kbeClose.Image = null;
            this.kbeClose.Location = new System.Drawing.Point(220, 10);
            this.kbeClose.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbeClose.Name = "kbeClose";
            this.kbeClose.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbeClose.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbeClose.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbeClose.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbeClose.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbeClose.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbeClose.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbeClose.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbeClose.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbeClose.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbeClose.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbeClose.Size = new System.Drawing.Size(90, 28);
            this.kbeClose.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbeClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbeClose.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbeClose.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbeClose.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbeClose.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbeClose.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbeClose.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbeClose.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbeClose.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbeClose.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbeClose.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbeClose.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbeClose.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbeClose.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbeClose.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbeClose.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbeClose.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbeClose.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbeClose.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbeClose.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbeClose.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbeClose.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbeClose.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbeClose.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbeClose.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbeClose.TabIndex = 0;
            this.kbeClose.Values.Text = "Cl&ose";
            this.kbeClose.Click += new System.EventHandler(this.kbeClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 3);
            this.panel1.TabIndex = 3;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel2.Controls.Add(this.kpnlLogos);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(533, 157);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.klblCopyright);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(149, 0);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(384, 157);
            this.kryptonPanel3.TabIndex = 8;
            // 
            // klblCopyright
            // 
            this.klblCopyright.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.klblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klblCopyright.Image = null;
            this.klblCopyright.Location = new System.Drawing.Point(0, 0);
            this.klblCopyright.LongTextTypeface = null;
            this.klblCopyright.Name = "klblCopyright";
            this.klblCopyright.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCopyright.Size = new System.Drawing.Size(384, 157);
            this.klblCopyright.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCopyright.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.klblCopyright.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.klblCopyright.StateDisabled.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCopyright.StateDisabledTextColourOne = System.Drawing.Color.Empty;
            this.klblCopyright.StateDisabledTextColourTwo = System.Drawing.Color.Empty;
            this.klblCopyright.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCopyright.StateNormalTextColourOne = System.Drawing.Color.Empty;
            this.klblCopyright.StateNormalTextColourTwo = System.Drawing.Color.Empty;
            this.klblCopyright.TabIndex = 0;
            this.klblCopyright.Values.Text = "(c) Copyright {0}";
            // 
            // kpnlLogos
            // 
            this.kpnlLogos.Controls.Add(this.pbxCopyright);
            this.kpnlLogos.Controls.Add(this.pbxApplicationLogo);
            this.kpnlLogos.Dock = System.Windows.Forms.DockStyle.Left;
            this.kpnlLogos.Location = new System.Drawing.Point(0, 0);
            this.kpnlLogos.Name = "kpnlLogos";
            this.kpnlLogos.Size = new System.Drawing.Size(149, 157);
            this.kpnlLogos.TabIndex = 7;
            // 
            // pbxCopyright
            // 
            this.pbxCopyright.BackColor = System.Drawing.Color.Transparent;
            this.pbxCopyright.Location = new System.Drawing.Point(76, 76);
            this.pbxCopyright.Name = "pbxCopyright";
            this.pbxCopyright.Size = new System.Drawing.Size(64, 64);
            this.pbxCopyright.TabIndex = 6;
            this.pbxCopyright.TabStop = false;
            // 
            // pbxApplicationLogo
            // 
            this.pbxApplicationLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxApplicationLogo.Location = new System.Drawing.Point(12, 12);
            this.pbxApplicationLogo.Name = "pbxApplicationLogo";
            this.pbxApplicationLogo.Size = new System.Drawing.Size(128, 128);
            this.pbxApplicationLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxApplicationLogo.TabIndex = 5;
            this.pbxApplicationLogo.TabStop = false;
            // 
            // CopyrightInformationDialog
            // 
            this.ClientSize = new System.Drawing.Size(533, 210);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CopyrightInformationDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlLogos)).EndInit();
            this.kpnlLogos.ResumeLayout(false);
            this.kpnlLogos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCopyright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxApplicationLogo)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Constructor
        public CopyrightInformationDialog(Image applicationLogo, string copyrightHolderName, string startYear, string currentCopyrightYear, bool showCopyrightIcon = true)
        {
            InitializeComponent();

            pbxApplicationLogo.Image = applicationLogo;

            klblCopyright.Text = $"(c) Copyright { copyrightHolderName }, { startYear } - { currentCopyrightYear }";

            pbxCopyright.Visible = showCopyrightIcon;
        }
        #endregion

        private void kbeClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}