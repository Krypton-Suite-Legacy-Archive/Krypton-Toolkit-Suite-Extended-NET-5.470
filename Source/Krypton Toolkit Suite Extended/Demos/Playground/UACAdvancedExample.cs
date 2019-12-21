#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.UAC;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Windows.Forms;

namespace Playground
{
    public class UACAdvancedExample : KryptonForm
    {
        private ExtendedStandardControls.Controls.ExtendedToolkit.KryptonUACElevatedButtonExtended keTest;
        private Panel panel1;
        private KryptonPanel kryptonPanel2;
        private ExtendedStandardControls.KryptonTextBoxExtended ktbProcessPath;
        private ExtendedStandardControls.KryptonLabelExtended kryptonLabelExtended1;
        private ExtendedStandardControls.KryptonButtonExtended kbtnBrowse;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UACAdvancedExample));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.keTest = new ExtendedStandardControls.Controls.ExtendedToolkit.KryptonUACElevatedButtonExtended();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabelExtended1 = new ExtendedStandardControls.KryptonLabelExtended();
            this.ktbProcessPath = new ExtendedStandardControls.KryptonTextBoxExtended();
            this.kbtnBrowse = new ExtendedStandardControls.KryptonButtonExtended();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 62);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(919, 57);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // keTest
            // 
            this.keTest.Image = null;
            this.keTest.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.keTest.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.keTest.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.keTest.OverrideDefaultBorderColourOne = System.Drawing.Color.Empty;
            this.keTest.OverrideDefaultBorderColourTwo = System.Drawing.Color.Empty;
            this.keTest.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.keTest.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.keTest.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.keTest.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.keTest.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.keTest.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.keTest.OverrideFocusBorderColourOne = System.Drawing.Color.Empty;
            this.keTest.OverrideFocusBorderColourTwo = System.Drawing.Color.Empty;
            this.keTest.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.keTest.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.keTest.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.keTest.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.keTest.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keTest.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.keTest.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.keTest.StateCommonBorderColourOne = System.Drawing.Color.Empty;
            this.keTest.StateCommonBorderColourTwo = System.Drawing.Color.Empty;
            this.keTest.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.keTest.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.keTest.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.keTest.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.keTest.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.keTest.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.keTest.StateDisabledBorderColourOne = System.Drawing.Color.Empty;
            this.keTest.StateDisabledBorderColourTwo = System.Drawing.Color.Empty;
            this.keTest.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.keTest.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.keTest.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.keTest.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.keTest.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.keTest.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.keTest.StateNormalBorderColourOne = System.Drawing.Color.Empty;
            this.keTest.StateNormalBorderColourTwo = System.Drawing.Color.Empty;
            this.keTest.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.keTest.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.keTest.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.keTest.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.keTest.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.keTest.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.keTest.StatePressedBorderColourOne = System.Drawing.Color.Empty;
            this.keTest.StatePressedBorderColourTwo = System.Drawing.Color.Empty;
            this.keTest.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.keTest.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.keTest.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.keTest.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.keTest.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.keTest.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.keTest.StateTrackingBorderColourOne = System.Drawing.Color.Empty;
            this.keTest.StateTrackingBorderColourTwo = System.Drawing.Color.Empty;
            this.keTest.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.keTest.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.keTest.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.keTest.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 3);
            this.panel1.TabIndex = 1;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnBrowse);
            this.kryptonPanel2.Controls.Add(this.ktbProcessPath);
            this.kryptonPanel2.Controls.Add(this.kryptonLabelExtended1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(919, 59);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // kryptonLabelExtended1
            // 
            this.kryptonLabelExtended1.Image = null;
            this.kryptonLabelExtended1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabelExtended1.LongTextTypeface = null;
            this.kryptonLabelExtended1.Name = "kryptonLabelExtended1";
            this.kryptonLabelExtended1.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.Size = new System.Drawing.Size(114, 26);
            this.kryptonLabelExtended1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateDisabled.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.StateDisabledTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateDisabledTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.StateNormalTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateNormalTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.TabIndex = 0;
            this.kryptonLabelExtended1.Values.Text = "Process Path:";
            // 
            // ktbProcessPath
            // 
            this.ktbProcessPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ktbProcessPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.ktbProcessPath.Location = new System.Drawing.Point(132, 10);
            this.ktbProcessPath.Name = "ktbProcessPath";
            this.ktbProcessPath.Size = new System.Drawing.Size(738, 29);
            this.ktbProcessPath.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktbProcessPath.StateActive.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktbProcessPath.StateActiveBackGroundColour = System.Drawing.Color.Empty;
            this.ktbProcessPath.StateActiveBorderColourOne = System.Drawing.Color.Empty;
            this.ktbProcessPath.StateActiveBorderColourTwo = System.Drawing.Color.Empty;
            this.ktbProcessPath.StateActiveTextColour = System.Drawing.Color.Empty;
            this.ktbProcessPath.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktbProcessPath.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktbProcessPath.StateCommonBackGroundColour = System.Drawing.Color.Empty;
            this.ktbProcessPath.StateCommonBorderColourOne = System.Drawing.Color.Empty;
            this.ktbProcessPath.StateCommonBorderColourTwo = System.Drawing.Color.Empty;
            this.ktbProcessPath.StateCommonTextColour = System.Drawing.Color.Empty;
            this.ktbProcessPath.StateDisabled.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktbProcessPath.StateDisabled.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktbProcessPath.StateDisabledBackGroundColour = System.Drawing.Color.Empty;
            this.ktbProcessPath.StateDisabledBorderColourOne = System.Drawing.Color.Empty;
            this.ktbProcessPath.StateDisabledBorderColourTwo = System.Drawing.Color.Empty;
            this.ktbProcessPath.StateDisabledTextColour = System.Drawing.Color.Empty;
            this.ktbProcessPath.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktbProcessPath.StateNormal.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktbProcessPath.StateNormalBackgroundColour = System.Drawing.Color.Empty;
            this.ktbProcessPath.StateNormalBorderColourOne = System.Drawing.Color.Empty;
            this.ktbProcessPath.StateNormalBorderColourTwo = System.Drawing.Color.Empty;
            this.ktbProcessPath.StateNormalTextColour = System.Drawing.Color.Empty;
            this.ktbProcessPath.TabIndex = 1;
            this.ktbProcessPath.Typeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktbProcessPath.TextChanged += new System.EventHandler(this.ktbProcessPath_TextChanged);
            // 
            // kbtnBrowse
            // 
            this.kbtnBrowse.Image = null;
            this.kbtnBrowse.Location = new System.Drawing.Point(876, 10);
            this.kbtnBrowse.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowse.Name = "kbtnBrowse";
            this.kbtnBrowse.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowse.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideDefaultBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideDefaultBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowse.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideFocusBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideFocusBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.Size = new System.Drawing.Size(31, 29);
            this.kbtnBrowse.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateCommonBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateCommonBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowse.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateDisabledBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateDisabledBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowse.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateNormalBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateNormalBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowse.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StatePressedBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StatePressedBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowse.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowse.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateTrackingBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateTrackingBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowse.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowse.TabIndex = 2;
            this.kbtnBrowse.Values.Text = "...";
            this.kbtnBrowse.Click += new System.EventHandler(this.kbtnBrowse_Click);
            // 
            // UACAdvancedExample
            // 
            this.ClientSize = new System.Drawing.Size(919, 119);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UACAdvancedExample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elevate a Process";
            this.Load += new System.EventHandler(this.UACAdvancedExample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        public UACAdvancedExample()
        {
            InitializeComponent();
        }

        private void UACAdvancedExample_Load(object sender, EventArgs e)
        {

        }
        
        private void kbtnBrowse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();

            cofd.Filters.Add(new CommonFileDialogFilter("Windows Executables", "exe"));

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                ktbProcessPath.Text = Path.GetFullPath(cofd.FileName);
            }
        }

        private void ktbProcessPath_TextChanged(object sender, EventArgs e)
        {
           
        }

        //private void KryptonUACElevatedButton1_Click(object sender, EventArgs e)
        //{
        //    string appPath = Path.GetFullPath(Application.ExecutablePath);

        //    UACHandler.ElevateProcessWithAdministrativeRights(appPath);
        //}
    }
}