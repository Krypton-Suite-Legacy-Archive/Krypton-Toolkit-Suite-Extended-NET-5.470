#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedDialogs.Dialogs.About.Extras;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace ExtendedDialogs.Dialogs.About.Custom
{
    public class KryptonAboutBox : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private ExtendedStandardControls.KryptonLabelExtended klbleCompanyName;
        private ExtendedStandardControls.KryptonLabelExtended klbleVersion;
        private ExtendedStandardControls.KryptonLabelExtended klbleProductName;
        private ExtendedStandardControls.KryptonButtonExtended kbtnTechnicalInformation;
        private ExtendedStandardControls.KryptonButtonExtended kbtnLicenseInformation;
        private ExtendedStandardControls.KryptonButtonExtended kbtnApplicationInformation;
        private ExtendedStandardControls.KryptonButtonExtended kbtnCopyrightInformation;
        private ExtendedStandardControls.KryptonButtonExtended kbeClose;
        private KryptonToolkitSuiteExtendedCore.CircularPictureBox cbxApplicationIcon;
        private System.Windows.Forms.PictureBox pbxApplicationLogo;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnTechnicalInformation = new ExtendedStandardControls.KryptonButtonExtended();
            this.kbtnLicenseInformation = new ExtendedStandardControls.KryptonButtonExtended();
            this.kbtnApplicationInformation = new ExtendedStandardControls.KryptonButtonExtended();
            this.kbtnCopyrightInformation = new ExtendedStandardControls.KryptonButtonExtended();
            this.kbeClose = new ExtendedStandardControls.KryptonButtonExtended();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cbxApplicationIcon = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            this.klbleCompanyName = new ExtendedStandardControls.KryptonLabelExtended();
            this.klbleVersion = new ExtendedStandardControls.KryptonLabelExtended();
            this.klbleProductName = new ExtendedStandardControls.KryptonLabelExtended();
            this.pbxApplicationLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxApplicationIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxApplicationLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnTechnicalInformation);
            this.kryptonPanel1.Controls.Add(this.kbtnLicenseInformation);
            this.kryptonPanel1.Controls.Add(this.kbtnApplicationInformation);
            this.kryptonPanel1.Controls.Add(this.kbtnCopyrightInformation);
            this.kryptonPanel1.Controls.Add(this.kbeClose);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 604);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1391, 50);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnTechnicalInformation
            // 
            this.kbtnTechnicalInformation.AutoSize = true;
            this.kbtnTechnicalInformation.Image = null;
            this.kbtnTechnicalInformation.Location = new System.Drawing.Point(617, 11);
            this.kbtnTechnicalInformation.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnTechnicalInformation.Name = "kbtnTechnicalInformation";
            this.kbtnTechnicalInformation.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnTechnicalInformation.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnTechnicalInformation.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnTechnicalInformation.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnTechnicalInformation.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnTechnicalInformation.Size = new System.Drawing.Size(159, 28);
            this.kbtnTechnicalInformation.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnTechnicalInformation.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnTechnicalInformation.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnTechnicalInformation.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnTechnicalInformation.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnTechnicalInformation.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnTechnicalInformation.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnTechnicalInformation.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnTechnicalInformation.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnTechnicalInformation.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnTechnicalInformation.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnTechnicalInformation.TabIndex = 5;
            this.kbtnTechnicalInformation.Values.Text = "Technical &Information";
            this.kbtnTechnicalInformation.Click += new System.EventHandler(this.kbtnTechnicalInformation_Click);
            // 
            // kbtnLicenseInformation
            // 
            this.kbtnLicenseInformation.AutoSize = true;
            this.kbtnLicenseInformation.Image = null;
            this.kbtnLicenseInformation.Location = new System.Drawing.Point(191, 10);
            this.kbtnLicenseInformation.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnLicenseInformation.Name = "kbtnLicenseInformation";
            this.kbtnLicenseInformation.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnLicenseInformation.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnLicenseInformation.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnLicenseInformation.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnLicenseInformation.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnLicenseInformation.Size = new System.Drawing.Size(145, 28);
            this.kbtnLicenseInformation.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnLicenseInformation.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnLicenseInformation.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnLicenseInformation.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnLicenseInformation.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnLicenseInformation.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnLicenseInformation.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnLicenseInformation.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnLicenseInformation.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnLicenseInformation.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnLicenseInformation.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnLicenseInformation.TabIndex = 4;
            this.kbtnLicenseInformation.Values.Text = "&License Information";
            this.kbtnLicenseInformation.Click += new System.EventHandler(this.kbtnLicenseInformation_Click);
            // 
            // kbtnApplicationInformation
            // 
            this.kbtnApplicationInformation.AutoSize = true;
            this.kbtnApplicationInformation.Image = null;
            this.kbtnApplicationInformation.Location = new System.Drawing.Point(12, 10);
            this.kbtnApplicationInformation.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnApplicationInformation.Name = "kbtnApplicationInformation";
            this.kbtnApplicationInformation.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnApplicationInformation.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnApplicationInformation.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnApplicationInformation.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnApplicationInformation.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnApplicationInformation.Size = new System.Drawing.Size(173, 28);
            this.kbtnApplicationInformation.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnApplicationInformation.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnApplicationInformation.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnApplicationInformation.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnApplicationInformation.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnApplicationInformation.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnApplicationInformation.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnApplicationInformation.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnApplicationInformation.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnApplicationInformation.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnApplicationInformation.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnApplicationInformation.TabIndex = 3;
            this.kbtnApplicationInformation.Values.Text = "Application &Information";
            this.kbtnApplicationInformation.Click += new System.EventHandler(this.kbtnApplicationInformation_Click);
            // 
            // kbtnCopyrightInformation
            // 
            this.kbtnCopyrightInformation.AutoSize = true;
            this.kbtnCopyrightInformation.Image = null;
            this.kbtnCopyrightInformation.Location = new System.Drawing.Point(1120, 10);
            this.kbtnCopyrightInformation.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCopyrightInformation.Name = "kbtnCopyrightInformation";
            this.kbtnCopyrightInformation.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCopyrightInformation.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCopyrightInformation.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCopyrightInformation.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCopyrightInformation.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCopyrightInformation.Size = new System.Drawing.Size(163, 28);
            this.kbtnCopyrightInformation.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCopyrightInformation.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCopyrightInformation.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCopyrightInformation.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCopyrightInformation.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCopyrightInformation.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCopyrightInformation.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCopyrightInformation.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCopyrightInformation.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCopyrightInformation.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCopyrightInformation.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCopyrightInformation.TabIndex = 2;
            this.kbtnCopyrightInformation.Values.Text = "&Copyright Information";
            this.kbtnCopyrightInformation.Click += new System.EventHandler(this.kbtnCopyrightInformation_Click);
            // 
            // kbeClose
            // 
            this.kbeClose.AutoSize = true;
            this.kbeClose.Image = null;
            this.kbeClose.Location = new System.Drawing.Point(1289, 10);
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
            this.kbeClose.TabIndex = 1;
            this.kbeClose.Values.Text = "Cl&ose";
            this.kbeClose.Click += new System.EventHandler(this.kbeClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 601);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1391, 3);
            this.panel1.TabIndex = 1;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.cbxApplicationIcon);
            this.kryptonPanel2.Controls.Add(this.klbleCompanyName);
            this.kryptonPanel2.Controls.Add(this.klbleVersion);
            this.kryptonPanel2.Controls.Add(this.klbleProductName);
            this.kryptonPanel2.Controls.Add(this.pbxApplicationLogo);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1391, 601);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // cbxApplicationIcon
            // 
            this.cbxApplicationIcon.BackColor = System.Drawing.Color.Transparent;
            this.cbxApplicationIcon.Location = new System.Drawing.Point(433, 24);
            this.cbxApplicationIcon.Name = "cbxApplicationIcon";
            this.cbxApplicationIcon.Size = new System.Drawing.Size(512, 512);
            this.cbxApplicationIcon.TabIndex = 4;
            this.cbxApplicationIcon.TabStop = false;
            // 
            // klbleCompanyName
            // 
            this.klbleCompanyName.AutoSize = false;
            this.klbleCompanyName.Image = null;
            this.klbleCompanyName.Location = new System.Drawing.Point(962, 558);
            this.klbleCompanyName.LongTextTypeface = null;
            this.klbleCompanyName.Name = "klbleCompanyName";
            this.klbleCompanyName.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klbleCompanyName.Size = new System.Drawing.Size(417, 25);
            this.klbleCompanyName.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klbleCompanyName.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.klbleCompanyName.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.klbleCompanyName.StateDisabled.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klbleCompanyName.StateDisabledTextColourOne = System.Drawing.Color.Empty;
            this.klbleCompanyName.StateDisabledTextColourTwo = System.Drawing.Color.Empty;
            this.klbleCompanyName.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klbleCompanyName.StateNormalTextColourOne = System.Drawing.Color.Empty;
            this.klbleCompanyName.StateNormalTextColourTwo = System.Drawing.Color.Empty;
            this.klbleCompanyName.TabIndex = 3;
            this.klbleCompanyName.Values.Text = "<#COMPANY-NAME#>";
            // 
            // klbleVersion
            // 
            this.klbleVersion.AutoSize = false;
            this.klbleVersion.Image = null;
            this.klbleVersion.Location = new System.Drawing.Point(435, 558);
            this.klbleVersion.LongTextTypeface = null;
            this.klbleVersion.Name = "klbleVersion";
            this.klbleVersion.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klbleVersion.Size = new System.Drawing.Size(417, 25);
            this.klbleVersion.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klbleVersion.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.klbleVersion.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.klbleVersion.StateDisabled.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klbleVersion.StateDisabledTextColourOne = System.Drawing.Color.Empty;
            this.klbleVersion.StateDisabledTextColourTwo = System.Drawing.Color.Empty;
            this.klbleVersion.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klbleVersion.StateNormalTextColourOne = System.Drawing.Color.Empty;
            this.klbleVersion.StateNormalTextColourTwo = System.Drawing.Color.Empty;
            this.klbleVersion.TabIndex = 2;
            this.klbleVersion.Values.Text = "<#VERSION#>";
            // 
            // klbleProductName
            // 
            this.klbleProductName.AutoSize = false;
            this.klbleProductName.Image = null;
            this.klbleProductName.Location = new System.Drawing.Point(12, 558);
            this.klbleProductName.LongTextTypeface = null;
            this.klbleProductName.Name = "klbleProductName";
            this.klbleProductName.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klbleProductName.Size = new System.Drawing.Size(417, 25);
            this.klbleProductName.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klbleProductName.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.klbleProductName.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.klbleProductName.StateDisabled.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klbleProductName.StateDisabledTextColourOne = System.Drawing.Color.Empty;
            this.klbleProductName.StateDisabledTextColourTwo = System.Drawing.Color.Empty;
            this.klbleProductName.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klbleProductName.StateNormalTextColourOne = System.Drawing.Color.Empty;
            this.klbleProductName.StateNormalTextColourTwo = System.Drawing.Color.Empty;
            this.klbleProductName.TabIndex = 1;
            this.klbleProductName.Values.Text = "<#PRODUCT-NAME#>";
            // 
            // pbxApplicationLogo
            // 
            this.pbxApplicationLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxApplicationLogo.Location = new System.Drawing.Point(433, 24);
            this.pbxApplicationLogo.Name = "pbxApplicationLogo";
            this.pbxApplicationLogo.Size = new System.Drawing.Size(512, 512);
            this.pbxApplicationLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxApplicationLogo.TabIndex = 0;
            this.pbxApplicationLogo.TabStop = false;
            // 
            // KryptonAboutBox
            // 
            this.ClientSize = new System.Drawing.Size(1391, 654);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonAboutBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxApplicationIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxApplicationLogo)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private bool _useStandardPictureBox, _useCircularPictureBox;

        private Image _applicationLogo, _applicationLogo128x128;

        private string _licenseFilePath;

        private KryptonAboutBoxLayoutButtonType _layoutButtonType;

        private IAbout _about;
        #endregion

        #region Properties
        public bool UseCircularPictureBox { get => _useCircularPictureBox; set { _useCircularPictureBox = value; Invalidate(); } }

        public bool UseStandardPictureBox { get => _useStandardPictureBox; set { _useStandardPictureBox = value; Invalidate(); } }

        public Image ApplicationLogo { get => _applicationLogo; set { _applicationLogo = value; Invalidate(); } }

        public string LicenseFilePath { get => _licenseFilePath; set => _licenseFilePath = value; }

        public KryptonAboutBoxLayoutButtonType KryptonAboutBoxLayoutButtonType { get => _layoutButtonType; set { _layoutButtonType = value; Invalidate(); } }
        #endregion

        #region Assembly Attribute Accessors
        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        #region Constructor
        /// <summary>Initializes a new instance of the <see cref="KryptonAboutBox"/> class.</summary>
        /// <param name="icon">The icon.</param>
        /// <param name="useStandardPictureBox">if set to <c>true</c> [use standard PictureBox].</param>
        /// <param name="useCircularPictureBox">if set to <c>true</c> [use circular PictureBox].</param>
        /// <param name="applicationLogo">The application logo.</param>
        /// <param name="licenseFilePath">The license file path.</param>
        /// <param name="layoutButtonType">Type of the layout button.</param>
        public KryptonAboutBox(Icon icon, bool useStandardPictureBox = true, bool useCircularPictureBox = false, Image applicationLogo = null, string licenseFilePath = "", KryptonAboutBoxLayoutButtonType layoutButtonType = KryptonAboutBoxLayoutButtonType.ALL)
        {
            InitializeComponent();

            Icon = icon;

            UseCircularPictureBox = useCircularPictureBox;

            UseStandardPictureBox = useStandardPictureBox;

            ApplicationLogo = applicationLogo;

            LicenseFilePath = licenseFilePath;

            KryptonAboutBoxLayoutButtonType = layoutButtonType;

            AdaptWindow(KryptonAboutBoxLayoutButtonType);

            PropagateInformation();
        }
        #endregion

        private void kbeClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kbtnCopyrightInformation_Click(object sender, EventArgs e)
        {
            CopyrightInformationDialog copyrightInformationDialog = new CopyrightInformationDialog(_about.ProductImage64x64, _about.CopyrightHoldersName, _about.StartYear, _about.CurrentCopyrightYear);

            copyrightInformationDialog.Show();
        }

        private void kbtnTechnicalInformation_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("msinfo32.exe");
            }
            catch (Exception exc)
            {
                return;
            }
        }

        private void kbtnLicenseInformation_Click(object sender, EventArgs e)
        {
            LicenseInformationDialog licenseInformationDialog = new LicenseInformationDialog(ProductName, Icon, LicenseFilePath);

            licenseInformationDialog.Show();
        }

        private void kbtnApplicationInformation_Click(object sender, EventArgs e)
        {
            ApplicationDescriptionDialog descriptionDialog = new ApplicationDescriptionDialog(ProductName, Icon, null, AssemblyDescription);

            descriptionDialog.Show();
        }

        #region Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            AdaptWindow(KryptonAboutBoxLayoutButtonType);

            base.OnPaint(e);
        }
        #endregion

        #region Methods
        private void PropagateInformation()
        {
            Text = $"About { ProductName }";

            if (UseCircularPictureBox)
            {
                cbxApplicationIcon.Visible = true;

                pbxApplicationLogo.Visible = false;

                cbxApplicationIcon.Image = ApplicationLogo;
            }
            else if (UseStandardPictureBox)
            {
                cbxApplicationIcon.Visible = false;

                pbxApplicationLogo.Visible = true;

                pbxApplicationLogo.Image = ApplicationLogo;
            }

            klbleProductName.Text = ProductName;

            klbleVersion.Text = $"Version: { AssemblyVersion }";

            klbleCompanyName.Text = AssemblyCopyright;
        }

        private void AdaptWindow(KryptonAboutBoxLayoutButtonType layoutButtonType)
        {
            switch (layoutButtonType)
            {
                case KryptonAboutBoxLayoutButtonType.CLOSEONLY:
                    break;
                case KryptonAboutBoxLayoutButtonType.CLOSEANDCOPYRIGHT:
                    break;
                case KryptonAboutBoxLayoutButtonType.CLOSECOPYRIGHTANDTECHNICAL:
                    break;
                case KryptonAboutBoxLayoutButtonType.CLOSECOPYRIGHTTECHNICALANDLICENSE:
                    break;
                case KryptonAboutBoxLayoutButtonType.CLOSECOPYRIGHTTECHNICALANDDESCRIPTION:
                    break;
                case KryptonAboutBoxLayoutButtonType.CLOSEANDTECHNICAL:
                    break;
                case KryptonAboutBoxLayoutButtonType.CLOSETECHNICALANDLICENSE:
                    break;
                case KryptonAboutBoxLayoutButtonType.CLOSETECHNICALANDDESCRIPTION:
                    break;
                case KryptonAboutBoxLayoutButtonType.CLOSEANDLICENSE:
                    break;
                case KryptonAboutBoxLayoutButtonType.CLOSELICENSEANDDESCRIPTION:
                    break;
                case KryptonAboutBoxLayoutButtonType.CLOSEANDDESCRIPTION:
                    break;
                case KryptonAboutBoxLayoutButtonType.ALL:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Relocates the control.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="newLocation">The new location.</param>
        private void RelocateControl(Control control, Point newLocation) => control.Location = newLocation;
        #endregion
    }
}