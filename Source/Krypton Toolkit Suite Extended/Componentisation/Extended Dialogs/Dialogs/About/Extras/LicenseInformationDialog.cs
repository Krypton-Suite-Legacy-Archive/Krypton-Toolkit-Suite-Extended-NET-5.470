using Common;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;

namespace ExtendedDialogs.Dialogs.About
{
    internal class LicenseInformationDialog : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private KryptonRichTextBox krtLicense;
        private ExtendedStandardControls.KryptonButtonExtended kbeClose;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbeClose = new ExtendedStandardControls.KryptonButtonExtended();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.krtLicense = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbeClose);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 611);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1022, 50);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kbeClose
            // 
            this.kbeClose.AutoSize = true;
            this.kbeClose.Image = null;
            this.kbeClose.Location = new System.Drawing.Point(464, 10);
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
            this.panel1.Location = new System.Drawing.Point(0, 608);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 3);
            this.panel1.TabIndex = 2;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.krtLicense);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1022, 608);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // krtLicense
            // 
            this.krtLicense.Location = new System.Drawing.Point(12, 12);
            this.krtLicense.Name = "krtLicense";
            this.krtLicense.ReadOnly = true;
            this.krtLicense.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.krtLicense.Size = new System.Drawing.Size(994, 570);
            this.krtLicense.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krtLicense.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.krtLicense.TabIndex = 0;
            this.krtLicense.Text = "";
            // 
            // LicenseInformationDialog
            // 
            this.ClientSize = new System.Drawing.Size(1022, 661);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicenseInformationDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        #region Constructor
        public LicenseInformationDialog(string productName, Icon productIcon, string licenseFilePath)
        {
            InitializeComponent();

            Text = $"{ productName } License";

            Icon = productIcon;

            try
            {
                krtLicense.LoadFile(licenseFilePath);
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc);

                Close();
            }
        }
        #endregion

        private void kbeClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}