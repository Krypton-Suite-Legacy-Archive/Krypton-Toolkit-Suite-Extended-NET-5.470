using ComponentFactory.Krypton.Toolkit;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;

namespace KryptonFileCopier.UX
{
    public class MainWindow : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kryptonPanel1;
        private ExtendedStandardControls.KryptonButtonExtended kbtnStartCopy;
        private ExtendedStandardControls.KryptonButtonExtended kbtnCancel;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private ExtendedStandardControls.Controls.Toolkit.Textural.KryptonListBoxExtended klstFileList;
        private ExtendedStandardControls.KryptonButtonExtended kbtnBrowseSourcePath;
        private KryptonTextBox ktxtSourcePath;
        private ExtendedStandardControls.KryptonButtonExtended kbtnBrowseDestinationPath;
        private KryptonTextBox ktxtDestinationPath;
        private ExtendedStandardControls.KryptonLabelExtended kryptonLabelExtended2;
        private ExtendedStandardControls.KryptonLabelExtended kryptonLabelExtended1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnStartCopy = new ExtendedStandardControls.KryptonButtonExtended();
            this.kbtnCancel = new ExtendedStandardControls.KryptonButtonExtended();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klstFileList = new ExtendedStandardControls.Controls.Toolkit.Textural.KryptonListBoxExtended();
            this.kryptonLabelExtended1 = new ExtendedStandardControls.KryptonLabelExtended();
            this.ktxtSourcePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kbtnBrowseSourcePath = new ExtendedStandardControls.KryptonButtonExtended();
            this.kbtnBrowseDestinationPath = new ExtendedStandardControls.KryptonButtonExtended();
            this.ktxtDestinationPath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabelExtended2 = new ExtendedStandardControls.KryptonLabelExtended();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnStartCopy);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 718);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1057, 46);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnStartCopy
            // 
            this.kbtnStartCopy.Enabled = false;
            this.kbtnStartCopy.Image = null;
            this.kbtnStartCopy.Location = new System.Drawing.Point(843, 9);
            this.kbtnStartCopy.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnStartCopy.Name = "kbtnStartCopy";
            this.kbtnStartCopy.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnStartCopy.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnStartCopy.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnStartCopy.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnStartCopy.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnStartCopy.Size = new System.Drawing.Size(106, 25);
            this.kbtnStartCopy.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnStartCopy.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnStartCopy.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnStartCopy.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnStartCopy.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnStartCopy.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnStartCopy.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnStartCopy.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnStartCopy.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnStartCopy.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnStartCopy.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnStartCopy.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnStartCopy.TabIndex = 1;
            this.kbtnStartCopy.Values.Text = "&Start Copy";
            this.kbtnStartCopy.Click += new System.EventHandler(this.kbtnStartCopy_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Image = null;
            this.kbtnCancel.Location = new System.Drawing.Point(955, 9);
            this.kbtnCancel.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCancel.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCancel.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.Size = new System.Drawing.Size(90, 25);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCancel.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCancel.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCancel.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnCancel.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnCancel.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnCancel.TabIndex = 0;
            this.kbtnCancel.Values.Text = "C&ancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 715);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 3);
            this.panel1.TabIndex = 1;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnBrowseDestinationPath);
            this.kryptonPanel2.Controls.Add(this.ktxtDestinationPath);
            this.kryptonPanel2.Controls.Add(this.kryptonLabelExtended2);
            this.kryptonPanel2.Controls.Add(this.kbtnBrowseSourcePath);
            this.kryptonPanel2.Controls.Add(this.ktxtSourcePath);
            this.kryptonPanel2.Controls.Add(this.klstFileList);
            this.kryptonPanel2.Controls.Add(this.kryptonLabelExtended1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1057, 715);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // klstFileList
            // 
            this.klstFileList.Location = new System.Drawing.Point(12, 44);
            this.klstFileList.LongTextTypeface = null;
            this.klstFileList.Name = "klstFileList";
            this.klstFileList.OverrideFocus.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klstFileList.OverrideFocusItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.klstFileList.OverrideFocusItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.klstFileList.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.klstFileList.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klstFileList.Size = new System.Drawing.Size(1033, 608);
            this.klstFileList.StateActiveBackgroundColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateActiveBackgroundColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateCheckedNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klstFileList.StateCheckedNormalItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateCheckedNormalItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateCheckedNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateCheckedNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateCheckedNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateCheckedNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateCheckedPressed.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klstFileList.StateCheckedPressedItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateCheckedPressedItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateCheckedPressedLongTextColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateCheckedPressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateCheckedPressedShortTextColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateCheckedPressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateCheckedTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klstFileList.StateCheckedTrackingItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateCheckedTrackingItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateCheckedTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateCheckedTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateCheckedTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateCheckedTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klstFileList.StateCommonBackgroundColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateCommonBackgroundColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateCommonItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateCommonItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateDisabled.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klstFileList.StateDisabledBackgroundColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateDisabledBackgroundColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateDisabledItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateDisabledItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klstFileList.StateNormalBackgroundColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateNormalBackgroundColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateNormalItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateNormalItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StatePressed.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klstFileList.StatePressedItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StatePressedItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klstFileList.StateTrackingItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateTrackingItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.klstFileList.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.klstFileList.TabIndex = 1;
            // 
            // kryptonLabelExtended1
            // 
            this.kryptonLabelExtended1.Image = null;
            this.kryptonLabelExtended1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabelExtended1.LongTextTypeface = null;
            this.kryptonLabelExtended1.Name = "kryptonLabelExtended1";
            this.kryptonLabelExtended1.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.Size = new System.Drawing.Size(109, 26);
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
            this.kryptonLabelExtended1.Values.Text = "Source Path:";
            // 
            // ktxtSourcePath
            // 
            this.ktxtSourcePath.Location = new System.Drawing.Point(127, 12);
            this.ktxtSourcePath.Name = "ktxtSourcePath";
            this.ktxtSourcePath.Size = new System.Drawing.Size(889, 29);
            this.ktxtSourcePath.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtSourcePath.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtSourcePath.TabIndex = 2;
            // 
            // kbtnBrowseSourcePath
            // 
            this.kbtnBrowseSourcePath.AutoSize = true;
            this.kbtnBrowseSourcePath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnBrowseSourcePath.Image = null;
            this.kbtnBrowseSourcePath.Location = new System.Drawing.Point(1022, 12);
            this.kbtnBrowseSourcePath.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseSourcePath.Name = "kbtnBrowseSourcePath";
            this.kbtnBrowseSourcePath.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseSourcePath.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseSourcePath.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseSourcePath.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseSourcePath.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseSourcePath.Size = new System.Drawing.Size(23, 30);
            this.kbtnBrowseSourcePath.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseSourcePath.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseSourcePath.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseSourcePath.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseSourcePath.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseSourcePath.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseSourcePath.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseSourcePath.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseSourcePath.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseSourcePath.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseSourcePath.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseSourcePath.TabIndex = 3;
            this.kbtnBrowseSourcePath.Values.Text = "&...";
            this.kbtnBrowseSourcePath.Click += new System.EventHandler(this.kbtnBrowseSourcePath_Click);
            // 
            // kbtnBrowseDestinationPath
            // 
            this.kbtnBrowseDestinationPath.AutoSize = true;
            this.kbtnBrowseDestinationPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnBrowseDestinationPath.Image = null;
            this.kbtnBrowseDestinationPath.Location = new System.Drawing.Point(1022, 668);
            this.kbtnBrowseDestinationPath.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseDestinationPath.Name = "kbtnBrowseDestinationPath";
            this.kbtnBrowseDestinationPath.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseDestinationPath.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseDestinationPath.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseDestinationPath.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseDestinationPath.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseDestinationPath.Size = new System.Drawing.Size(23, 30);
            this.kbtnBrowseDestinationPath.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseDestinationPath.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseDestinationPath.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseDestinationPath.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseDestinationPath.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseDestinationPath.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseDestinationPath.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseDestinationPath.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseDestinationPath.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnBrowseDestinationPath.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnBrowseDestinationPath.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnBrowseDestinationPath.TabIndex = 6;
            this.kbtnBrowseDestinationPath.Values.Text = "&...";
            this.kbtnBrowseDestinationPath.Click += new System.EventHandler(this.kbtnBrowseDestinationPath_Click);
            // 
            // ktxtDestinationPath
            // 
            this.ktxtDestinationPath.Location = new System.Drawing.Point(157, 668);
            this.ktxtDestinationPath.Name = "ktxtDestinationPath";
            this.ktxtDestinationPath.Size = new System.Drawing.Size(859, 29);
            this.ktxtDestinationPath.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtDestinationPath.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtDestinationPath.TabIndex = 5;
            // 
            // kryptonLabelExtended2
            // 
            this.kryptonLabelExtended2.Image = null;
            this.kryptonLabelExtended2.Location = new System.Drawing.Point(12, 668);
            this.kryptonLabelExtended2.LongTextTypeface = null;
            this.kryptonLabelExtended2.Name = "kryptonLabelExtended2";
            this.kryptonLabelExtended2.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended2.Size = new System.Drawing.Size(146, 26);
            this.kryptonLabelExtended2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended2.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended2.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended2.StateDisabled.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended2.StateDisabledTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended2.StateDisabledTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended2.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended2.StateNormalTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended2.StateNormalTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended2.TabIndex = 4;
            this.kryptonLabelExtended2.Values.Text = "Destination Path:";
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(1057, 764);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private List<string> _fileList = new List<string>();
        #endregion

        #region Properties
        public List<string> FileList { get => _fileList; set => _fileList = value; }
        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        private void kbtnBrowseSourcePath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();

            cofd.Title = "Select a source path:";

            cofd.IsFolderPicker = true;

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                ktxtSourcePath.Text = Path.GetFullPath(cofd.FileName);

                PropagateFileList(Path.GetFullPath(cofd.FileName), true);
            }
        }

        private void kbtnBrowseDestinationPath_Click(object sender, EventArgs e)
        {

        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void kbtnStartCopy_Click(object sender, EventArgs e)
        {

        }

        #region Methods
        private void PropagateFileList(string sourcePath, bool listFiles = false)
        {
            string[] files = Directory.GetFiles(sourcePath);

            foreach (string file in files)
            {
                FileList.Add(file);
            }

            if (listFiles)
            {
                foreach (string item in GetFileList())
                {
                    klstFileList.Items.Add(item);
                }
            }
        }

        private List<string> GetFileList() => FileList;
        #endregion
    }
}