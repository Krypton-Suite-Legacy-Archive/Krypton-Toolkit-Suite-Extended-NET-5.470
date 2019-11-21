using Common;
using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitSuiteExtendedCore;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ExtendedDialogs.Dialogs.Run
{
    public class KryptonRunDialog : KryptonForm
    {
        #region Designer Code
        private System.Windows.Forms.Panel panel1;
        private ExtendedStandardControls.KryptonPanelExtended kryptonPanelExtended1;
        private ExtendedStandardControls.KryptonButtonExtended kbtnSettings;
        private ExtendedStandardControls.KryptonButtonExtended kbtnRun;
        private ExtendedStandardControls.KryptonButtonExtended kbtnCancel;
        private ExtendedStandardControls.KryptonButtonExtended kbtnBrowse;
        private ExtendedStandardControls.Controls.ExtendedToolkit.KryptonUACElevatedButtonExtended kbtnUACRun;
        private System.Windows.Forms.PictureBox pbxApplicationIcon;
        private ExtendedStandardControls.KryptonLabelExtended kryptonLabelExtended1;
        private ExtendedStandardControls.KryptonComboBoxExtended kcbxProcessPath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ExtendedStandardControls.KryptonLabelExtended kryptonLabelExtended2;
        private ExtendedStandardControls.KryptonButtonExtended kbtneLocate;
        private ExtendedStandardControls.KryptonPanelExtended kpnlButtons;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonRunDialog));
            this.kpnlButtons = new ExtendedStandardControls.KryptonPanelExtended();
            this.kbtnSettings = new ExtendedStandardControls.KryptonButtonExtended();
            this.kbtnRun = new ExtendedStandardControls.KryptonButtonExtended();
            this.kbtnCancel = new ExtendedStandardControls.KryptonButtonExtended();
            this.kbtnBrowse = new ExtendedStandardControls.KryptonButtonExtended();
            this.kbtnUACRun = new ExtendedStandardControls.Controls.ExtendedToolkit.KryptonUACElevatedButtonExtended();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanelExtended1 = new ExtendedStandardControls.KryptonPanelExtended();
            this.kryptonLabelExtended2 = new ExtendedStandardControls.KryptonLabelExtended();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxApplicationIcon = new System.Windows.Forms.PictureBox();
            this.kryptonLabelExtended1 = new ExtendedStandardControls.KryptonLabelExtended();
            this.kcbxProcessPath = new ExtendedStandardControls.KryptonComboBoxExtended();
            this.kbtneLocate = new ExtendedStandardControls.KryptonButtonExtended();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlButtons)).BeginInit();
            this.kpnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelExtended1)).BeginInit();
            this.kryptonPanelExtended1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxApplicationIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcbxProcessPath)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnlButtons
            // 
            this.kpnlButtons.Controls.Add(this.kbtneLocate);
            this.kpnlButtons.Controls.Add(this.kbtnSettings);
            this.kpnlButtons.Controls.Add(this.kbtnRun);
            this.kpnlButtons.Controls.Add(this.kbtnCancel);
            this.kpnlButtons.Controls.Add(this.kbtnBrowse);
            this.kpnlButtons.Controls.Add(this.kbtnUACRun);
            this.kpnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpnlButtons.Image = null;
            this.kpnlButtons.Location = new System.Drawing.Point(0, 204);
            this.kpnlButtons.Name = "kpnlButtons";
            this.kpnlButtons.Size = new System.Drawing.Size(648, 57);
            this.kpnlButtons.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kpnlButtons.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kpnlButtons.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kpnlButtons.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kpnlButtons.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kpnlButtons.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kpnlButtons.TabIndex = 0;
            // 
            // kbtnSettings
            // 
            this.kbtnSettings.Image = null;
            this.kbtnSettings.Location = new System.Drawing.Point(12, 7);
            this.kbtnSettings.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnSettings.Name = "kbtnSettings";
            this.kbtnSettings.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnSettings.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSettings.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.OverrideDefaultBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.OverrideDefaultBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnSettings.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSettings.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.OverrideFocusBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.OverrideFocusBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSettings.Size = new System.Drawing.Size(90, 38);
            this.kbtnSettings.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnSettings.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSettings.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.StateCommonBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.StateCommonBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnSettings.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSettings.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.StateDisabledBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.StateDisabledBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnSettings.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSettings.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.StateNormalBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.StateNormalBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnSettings.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSettings.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.StatePressedBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.StatePressedBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnSettings.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSettings.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.StateTrackingBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.StateTrackingBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSettings.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSettings.TabIndex = 4;
            this.kbtnSettings.Values.Text = "Sett&ings";
            this.kbtnSettings.Click += new System.EventHandler(this.kbtnSettings_Click);
            // 
            // kbtnRun
            // 
            this.kbtnRun.Enabled = false;
            this.kbtnRun.Image = null;
            this.kbtnRun.Location = new System.Drawing.Point(354, 7);
            this.kbtnRun.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRun.Name = "kbtnRun";
            this.kbtnRun.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRun.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRun.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.OverrideDefaultBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.OverrideDefaultBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRun.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRun.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.OverrideFocusBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.OverrideFocusBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRun.Size = new System.Drawing.Size(90, 38);
            this.kbtnRun.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRun.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRun.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.StateCommonBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.StateCommonBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRun.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRun.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.StateDisabledBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.StateDisabledBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRun.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRun.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.StateNormalBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.StateNormalBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRun.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRun.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.StatePressedBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.StatePressedBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRun.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRun.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.StateTrackingBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.StateTrackingBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRun.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRun.TabIndex = 3;
            this.kbtnRun.Values.Text = "&Run";
            this.kbtnRun.Click += new System.EventHandler(this.kbtnRun_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Image = null;
            this.kbtnCancel.Location = new System.Drawing.Point(450, 7);
            this.kbtnCancel.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCancel.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideDefaultBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideDefaultBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCancel.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideFocusBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideFocusBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.Size = new System.Drawing.Size(90, 38);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateCommonBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateCommonBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCancel.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateDisabledBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateDisabledBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCancel.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateNormalBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateNormalBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCancel.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StatePressedBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StatePressedBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCancel.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateTrackingBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateTrackingBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.TabIndex = 2;
            this.kbtnCancel.Values.Text = "Ca&ncel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // kbtnBrowse
            // 
            this.kbtnBrowse.Image = null;
            this.kbtnBrowse.Location = new System.Drawing.Point(546, 7);
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
            this.kbtnBrowse.Size = new System.Drawing.Size(90, 38);
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
            this.kbtnBrowse.TabIndex = 1;
            this.kbtnBrowse.Values.Text = "&Browse...";
            this.kbtnBrowse.Click += new System.EventHandler(this.kbtnBrowse_Click);
            // 
            // kbtnUACRun
            // 
            this.kbtnUACRun.Enabled = false;
            this.kbtnUACRun.Image = null;
            this.kbtnUACRun.Location = new System.Drawing.Point(354, 7);
            this.kbtnUACRun.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnUACRun.Name = "kbtnUACRun";
            this.kbtnUACRun.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnUACRun.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnUACRun.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.OverrideDefaultBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.OverrideDefaultBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnUACRun.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnUACRun.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.OverrideFocusBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.OverrideFocusBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.ProcessToElevate = null;
            this.kbtnUACRun.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnUACRun.ShowUACShield = true;
            this.kbtnUACRun.Size = new System.Drawing.Size(90, 38);
            this.kbtnUACRun.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnUACRun.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnUACRun.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateCommonBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateCommonBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnUACRun.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnUACRun.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateDisabledBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateDisabledBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnUACRun.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnUACRun.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateNormalBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateNormalBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnUACRun.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnUACRun.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.StatePressedBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.StatePressedBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnUACRun.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnUACRun.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateTrackingBorderColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateTrackingBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnUACRun.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnUACRun.TabIndex = 0;
            this.kbtnUACRun.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnUACRun.Values.Image")));
            this.kbtnUACRun.Values.Text = "&Run";
            this.kbtnUACRun.Click += new System.EventHandler(this.kbtnUACRun_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 3);
            this.panel1.TabIndex = 2;
            // 
            // kryptonPanelExtended1
            // 
            this.kryptonPanelExtended1.Controls.Add(this.kryptonLabelExtended2);
            this.kryptonPanelExtended1.Controls.Add(this.pictureBox1);
            this.kryptonPanelExtended1.Controls.Add(this.pbxApplicationIcon);
            this.kryptonPanelExtended1.Controls.Add(this.kryptonLabelExtended1);
            this.kryptonPanelExtended1.Controls.Add(this.kcbxProcessPath);
            this.kryptonPanelExtended1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelExtended1.Image = null;
            this.kryptonPanelExtended1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelExtended1.Name = "kryptonPanelExtended1";
            this.kryptonPanelExtended1.Size = new System.Drawing.Size(648, 201);
            this.kryptonPanelExtended1.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.TabIndex = 3;
            // 
            // kryptonLabelExtended2
            // 
            this.kryptonLabelExtended2.AutoSize = false;
            this.kryptonLabelExtended2.Image = null;
            this.kryptonLabelExtended2.Location = new System.Drawing.Point(66, 13);
            this.kryptonLabelExtended2.LongTextTypeface = null;
            this.kryptonLabelExtended2.Name = "kryptonLabelExtended2";
            this.kryptonLabelExtended2.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.kryptonLabelExtended2.Size = new System.Drawing.Size(570, 90);
            this.kryptonLabelExtended2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.kryptonLabelExtended2.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended2.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended2.StateDisabled.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.kryptonLabelExtended2.StateDisabledTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended2.StateDisabledTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended2.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.kryptonLabelExtended2.StateNormalTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended2.StateNormalTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended2.TabIndex = 4;
            this.kryptonLabelExtended2.Values.Text = "Type the name of a application, file, directory or internet\r\nresource, and Window" +
    "s will open it for you.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ExtendedDialogs.Properties.Resources.Run_481;
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pbxApplicationIcon
            // 
            this.pbxApplicationIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxApplicationIcon.Location = new System.Drawing.Point(604, 144);
            this.pbxApplicationIcon.Name = "pbxApplicationIcon";
            this.pbxApplicationIcon.Size = new System.Drawing.Size(32, 32);
            this.pbxApplicationIcon.TabIndex = 2;
            this.pbxApplicationIcon.TabStop = false;
            this.pbxApplicationIcon.MouseEnter += new System.EventHandler(this.pbxApplicationIcon_MouseEnter);
            // 
            // kryptonLabelExtended1
            // 
            this.kryptonLabelExtended1.Image = null;
            this.kryptonLabelExtended1.Location = new System.Drawing.Point(12, 144);
            this.kryptonLabelExtended1.LongTextTypeface = null;
            this.kryptonLabelExtended1.Name = "kryptonLabelExtended1";
            this.kryptonLabelExtended1.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.Size = new System.Drawing.Size(47, 26);
            this.kryptonLabelExtended1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateDisabled.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.StateDisabledTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateDisabledTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.StateNormalTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateNormalTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.TabIndex = 1;
            this.kryptonLabelExtended1.Values.Text = "Run:";
            // 
            // kcbxProcessPath
            // 
            this.kcbxProcessPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.kcbxProcessPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.kcbxProcessPath.ComboBoxContentTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbxProcessPath.ComboBoxItemContentLongTextTypeface = new System.Drawing.Font("Segoe UI", 12F);
            this.kcbxProcessPath.ComboBoxItemContentShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F);
            this.kcbxProcessPath.DropDownWidth = 533;
            this.kcbxProcessPath.Image = null;
            this.kcbxProcessPath.IntegralHeight = false;
            this.kcbxProcessPath.Location = new System.Drawing.Point(65, 144);
            this.kcbxProcessPath.Name = "kcbxProcessPath";
            this.kcbxProcessPath.Size = new System.Drawing.Size(533, 27);
            this.kcbxProcessPath.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbxProcessPath.StateActive.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kcbxProcessPath.StateActiveComboBoxBackColour = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateActiveComboBoxBorderColourOne = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateActiveComboBoxBorderColourTwo = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateActiveComboBoxContentColour = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbxProcessPath.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcbxProcessPath.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.kcbxProcessPath.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.kcbxProcessPath.StateCommonComboBoxBackColour = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateCommonComboBoxBorderColourOne = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateCommonComboBoxBorderColourTwo = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateCommonComboBoxContentColour = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateCommonComboBoxDropBackColourOne = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateCommonComboBoxDropBackColourTwo = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateCommonComboBoxItemBackColourOne = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateCommonComboBoxItemBackColourTwo = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateCommonComboBoxItemContentLongTextColourOne = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateCommonComboBoxItemContentLongTextColourTwo = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateCommonComboBoxItemContentShortTextColourOne = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateCommonComboBoxItemContentShortTextColourTwo = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateDisabled.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbxProcessPath.StateDisabled.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kcbxProcessPath.StateDisabled.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.kcbxProcessPath.StateDisabled.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.kcbxProcessPath.StateDisabledComboBoxBackColour = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateDisabledComboBoxBorderColourOne = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateDisabledComboBoxBorderColourTwo = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateDisabledComboBoxContentColour = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateDisabledComboBoxItemBackColourOne = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateDisabledComboBoxItemBackColourTwo = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateDisabledComboBoxItemContentLongTextColourOne = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateDisabledComboBoxItemContentLongTextColourTwo = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateDisabledComboBoxItemContentShortTextColourOne = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateDisabledComboBoxItemContentShortTextColourTwo = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateNormal.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbxProcessPath.StateNormal.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kcbxProcessPath.StateNormal.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.kcbxProcessPath.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.kcbxProcessPath.StateNormalComboBoxBackColour = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateNormalComboBoxBorderColourOne = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateNormalComboBoxBorderColourTwo = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateNormalComboBoxContentColour = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateNormalComboBoxItemBackColourOne = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateNormalComboBoxItemBackColourTwo = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateNormalComboBoxItemContentLongTextColourOne = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateNormalComboBoxItemContentLongTextColourTwo = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateNormalComboBoxItemContentShortTextColourOne = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateNormalComboBoxItemContentShortTextColourTwo = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateTracking.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.kcbxProcessPath.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.kcbxProcessPath.StateTrackingComboBoxItemBackColourOne = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateTrackingComboBoxItemBackColourTwo = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateTrackingComboBoxItemContentLongTextColourOne = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateTrackingComboBoxItemContentLongTextColourTwo = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateTrackingComboBoxItemContentShortTextColourOne = System.Drawing.Color.Empty;
            this.kcbxProcessPath.StateTrackingComboBoxItemContentShortTextColourTwo = System.Drawing.Color.Empty;
            this.kcbxProcessPath.TabIndex = 0;
            this.kcbxProcessPath.TextChanged += new System.EventHandler(this.kcbxProcessPath_TextChanged);
            // 
            // kbtneLocate
            // 
            this.kbtneLocate.Enabled = false;
            this.kbtneLocate.Image = null;
            this.kbtneLocate.Location = new System.Drawing.Point(108, 7);
            this.kbtneLocate.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneLocate.Name = "kbtneLocate";
            this.kbtneLocate.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneLocate.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneLocate.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.OverrideDefaultBorderColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.OverrideDefaultBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneLocate.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneLocate.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.OverrideFocusBorderColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.OverrideFocusBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneLocate.Size = new System.Drawing.Size(90, 38);
            this.kbtneLocate.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneLocate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneLocate.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.StateCommonBorderColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.StateCommonBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneLocate.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneLocate.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.StateDisabledBorderColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.StateDisabledBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneLocate.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneLocate.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.StateNormalBorderColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.StateNormalBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneLocate.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneLocate.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.StatePressedBorderColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.StatePressedBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtneLocate.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtneLocate.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.StateTrackingBorderColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.StateTrackingBorderColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtneLocate.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtneLocate.TabIndex = 5;
            this.kbtneLocate.Values.Text = "Lo&cate";
            this.kbtneLocate.Click += new System.EventHandler(this.kbtneLocate_Click);
            // 
            // KryptonRunDialog
            // 
            this.ClientSize = new System.Drawing.Size(648, 261);
            this.Controls.Add(this.kryptonPanelExtended1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kpnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonRunDialog";
            this.Text = "Run";
            this.Load += new System.EventHandler(this.KryptonRunDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlButtons)).EndInit();
            this.kpnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelExtended1)).EndInit();
            this.kryptonPanelExtended1.ResumeLayout(false);
            this.kryptonPanelExtended1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxApplicationIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcbxProcessPath)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Enums
        public enum ViewType
        {
            NORMAL,
            ELEVATED,
            ENHANCED,
            SETTINGS,
            APPLICATIONICONIMAGE
        }
        #endregion

        #region Constructors
        public KryptonRunDialog()
        {
            InitializeComponent();
        }

        public KryptonRunDialog(ViewType viewType)
        {
            InitializeComponent();

            AlterUI(viewType);
        }
        #endregion

        private void KryptonRunDialog_Load(object sender, EventArgs e)
        {
            pbxApplicationIcon.Visible = false;

            kcbxProcessPath.Size = new Size(571, 27);

            // Locate window bottom left
            Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Bottom - Height);
        }

        private void kcbxProcessPath_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(kcbxProcessPath.Text))
            {
                pbxApplicationIcon.Visible = true;

                kcbxProcessPath.Size = new Size(533, 27);

                kbtnRun.Enabled = true;

                kbtneLocate.Enabled = true;

                string fileExtension = Path.GetExtension(kcbxProcessPath.Text);

                //try
                //{

                if (kcbxProcessPath.Text.Contains(fileExtension))
                {
                    pbxApplicationIcon.Image = Icon.ExtractAssociatedIcon(kcbxProcessPath.Text).ToBitmap();
                }
                else
                {
                    pbxApplicationIcon.Visible = false;

                    kcbxProcessPath.Size = new Size(571, 27);
                }
                //}
                //catch (Exception exc)
                //{

                //    throw;
                //}
            }
            else
            {
                pbxApplicationIcon.Visible = false;

                kcbxProcessPath.Size = new Size(571, 27);

                kbtnRun.Enabled = false;
            }
        }

        private void pbxApplicationIcon_MouseEnter(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(kcbxProcessPath.Text);

            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(kcbxProcessPath.Text);

            string toolTipContent = $"Name: { fileInfo.Name }\nVersion: { fileVersionInfo.FileVersion }\nCreated: { fileInfo.CreationTime.ToString() }\nModified: { fileInfo.LastWriteTime.ToString() }";

            ToolTip tt = new ToolTip();

            tt.SetToolTip(pbxApplicationIcon, toolTipContent);
        }

        private void kbtnSettings_Click(object sender, EventArgs e)
        {
            KryptonRunSettings runSettings = new KryptonRunSettings();

            runSettings.Show();
        }

        private void kbtnRun_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Process.Start(kcbxProcessPath.Text);
            //}
            //catch (Exception exc)
            //{
            //    KryptonMessageBoxExtended.Show($"An error has occurred: { exc.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            KryptonRunArguments arguments = new KryptonRunArguments(kcbxProcessPath.Text, this);

            arguments.Show();
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kbtnBrowse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();

            cofd.Title = "Browse";

            cofd.Filters.Add(new CommonFileDialogFilter("Applications", "exe, pif, com, bat, cmd"));

            cofd.Filters.Add(new CommonFileDialogFilter("All Files", "*"));

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                kcbxProcessPath.Text = Path.GetFullPath(cofd.FileName);
            }
        }

        private void kbtnUACRun_Click(object sender, EventArgs e)
        {
            kbtnUACRun.ProcessName = kcbxProcessPath.Text;
        }

        #region Methods
        private void AlterUI(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.NORMAL:
                    break;
                case ViewType.ELEVATED:
                    break;
                case ViewType.ENHANCED:
                    break;
                case ViewType.SETTINGS:
                    break;
                case ViewType.APPLICATIONICONIMAGE:
                    break;
                default:
                    break;
            }
        }

        private void OpenResourceInExplorer(string path)
        {
            string argument = "/select, \"" + path + "\"";

            try
            {
                Process.Start("explorer.exe", argument);
            }
            catch (Exception e)
            {
                ExceptionHandler.CaptureException(e);
            }
        }
        #endregion

        private void kbtneLocate_Click(object sender, EventArgs e)
        {
            OpenResourceInExplorer(kcbxProcessPath.Text);
        }
    }
}