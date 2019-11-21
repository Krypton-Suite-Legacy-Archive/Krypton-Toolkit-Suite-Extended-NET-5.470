using Common;
using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitSuiteExtendedCore;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;

namespace Playground
{
    public class FileVersion : KryptonForm
    {
        private ExtendedStandardControls.KryptonPanelExtended kryptonPanelExtended1;
        private ExtendedStandardControls.KryptonButtonExtended kbtnGetDetails;
        private ExtendedStandardControls.KryptonButtonExtended kbtnBrowse;
        private KryptonTextBox ktxtFilePath;
        private ExtendedStandardControls.KryptonLabelExtended kryptonLabelExtended1;

        private void InitializeComponent()
        {
            this.kryptonPanelExtended1 = new ExtendedStandardControls.KryptonPanelExtended();
            this.kryptonLabelExtended1 = new ExtendedStandardControls.KryptonLabelExtended();
            this.ktxtFilePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kbtnBrowse = new ExtendedStandardControls.KryptonButtonExtended();
            this.kbtnGetDetails = new ExtendedStandardControls.KryptonButtonExtended();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelExtended1)).BeginInit();
            this.kryptonPanelExtended1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanelExtended1
            // 
            this.kryptonPanelExtended1.Controls.Add(this.kbtnGetDetails);
            this.kryptonPanelExtended1.Controls.Add(this.kbtnBrowse);
            this.kryptonPanelExtended1.Controls.Add(this.ktxtFilePath);
            this.kryptonPanelExtended1.Controls.Add(this.kryptonLabelExtended1);
            this.kryptonPanelExtended1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelExtended1.Image = null;
            this.kryptonPanelExtended1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelExtended1.Name = "kryptonPanelExtended1";
            this.kryptonPanelExtended1.Size = new System.Drawing.Size(951, 92);
            this.kryptonPanelExtended1.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.TabIndex = 0;
            // 
            // kryptonLabelExtended1
            // 
            this.kryptonLabelExtended1.Image = null;
            this.kryptonLabelExtended1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabelExtended1.LongTextTypeface = null;
            this.kryptonLabelExtended1.Name = "kryptonLabelExtended1";
            this.kryptonLabelExtended1.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.Size = new System.Drawing.Size(97, 30);
            this.kryptonLabelExtended1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateDisabled.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.StateDisabledTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateDisabledTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.StateNormalTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateNormalTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.TabIndex = 1;
            this.kryptonLabelExtended1.Values.Text = "File Path:";
            // 
            // ktxtFilePath
            // 
            this.ktxtFilePath.Hint = "Path to file...";
            this.ktxtFilePath.Location = new System.Drawing.Point(115, 12);
            this.ktxtFilePath.Name = "ktxtFilePath";
            this.ktxtFilePath.Size = new System.Drawing.Size(775, 29);
            this.ktxtFilePath.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtFilePath.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtFilePath.TabIndex = 2;
            this.ktxtFilePath.TextChanged += new System.EventHandler(this.ktxtFilePath_TextChanged);
            // 
            // kbtnBrowse
            // 
            this.kbtnBrowse.Image = null;
            this.kbtnBrowse.Location = new System.Drawing.Point(896, 12);
            this.kbtnBrowse.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowse.Name = "kbtnBrowse";
            this.kbtnBrowse.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowse.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowse.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.Size = new System.Drawing.Size(43, 29);
            this.kbtnBrowse.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowse.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowse.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowse.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowse.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.TabIndex = 1;
            this.kbtnBrowse.Values.Text = "..&.";
            this.kbtnBrowse.Click += new System.EventHandler(this.kbtnBrowse_Click);
            // 
            // kbtnGetDetails
            // 
            this.kbtnGetDetails.Enabled = false;
            this.kbtnGetDetails.Image = null;
            this.kbtnGetDetails.Location = new System.Drawing.Point(714, 47);
            this.kbtnGetDetails.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnGetDetails.Name = "kbtnGetDetails";
            this.kbtnGetDetails.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnGetDetails.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGetDetails.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnGetDetails.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGetDetails.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGetDetails.Size = new System.Drawing.Size(225, 29);
            this.kbtnGetDetails.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnGetDetails.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGetDetails.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnGetDetails.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGetDetails.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnGetDetails.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGetDetails.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnGetDetails.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGetDetails.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnGetDetails.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGetDetails.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnGetDetails.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnGetDetails.TabIndex = 3;
            this.kbtnGetDetails.Values.Text = "&Get File Version Details";
            this.kbtnGetDetails.Click += new System.EventHandler(this.kbtnGetDetails_Click);
            // 
            // FileVersion
            // 
            this.ClientSize = new System.Drawing.Size(951, 92);
            this.Controls.Add(this.kryptonPanelExtended1);
            this.Name = "FileVersion";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelExtended1)).EndInit();
            this.kryptonPanelExtended1.ResumeLayout(false);
            this.kryptonPanelExtended1.PerformLayout();
            this.ResumeLayout(false);

        }

        public FileVersion()
        {
            InitializeComponent();
        }

        private void kbtnBrowse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                ktxtFilePath.Text = Path.GetFullPath(cofd.FileName);
            }
        }

        private void kbtnGetDetails_Click(object sender, EventArgs e)
        {
            KryptonMessageBoxExtended.Show(AssemblyManager.GetFileVersionInformation(ktxtFilePath.Text).ToString());
        }

        private void ktxtFilePath_TextChanged(object sender, EventArgs e)
        {
            if (ktxtFilePath.Text.Length > 0)
            {
                kbtnGetDetails.Enabled = true;
            }
            else
            {
                kbtnGetDetails.Enabled = false;
            }
        }
    }
}