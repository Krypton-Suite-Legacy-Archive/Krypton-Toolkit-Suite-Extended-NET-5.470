using ComponentFactory.Krypton.Toolkit;
using KryptonSparkle.Classes;
using KryptonSparkle.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KryptonSparkle.UX
{
    public class KryptonSparkleForm : KryptonForm, IKryptonSparkleForm
    {
        #region Designer Code
        private System.Windows.Forms.WebBrowser NetSparkleBrowser;
        private ExtendedStandardControls.KryptonLabelExtended kryptonLabelExtended1;
        private ExtendedStandardControls.KryptonLabelExtended klblDetails;
        private ExtendedStandardControls.KryptonLabelExtended klblHeader;
        private System.Windows.Forms.PictureBox pbxAppIcon;
        private ExtendedStandardControls.KryptonButtonExtended kbtnSkip;
        private ExtendedStandardControls.KryptonButtonExtended kbtnRemins;
        private ExtendedStandardControls.KryptonButtonExtended kbtnInstall;
        private ExtendedStandardControls.KryptonPanelExtended kryptonPanelExtended1;


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonSparkleForm));
            this.kryptonPanelExtended1 = new ExtendedStandardControls.KryptonPanelExtended();
            this.klblHeader = new ExtendedStandardControls.KryptonLabelExtended();
            this.pbxAppIcon = new System.Windows.Forms.PictureBox();
            this.klblDetails = new ExtendedStandardControls.KryptonLabelExtended();
            this.kryptonLabelExtended1 = new ExtendedStandardControls.KryptonLabelExtended();
            this.NetSparkleBrowser = new System.Windows.Forms.WebBrowser();
            this.kbtnInstall = new ExtendedStandardControls.KryptonButtonExtended();
            this.kbtnRemins = new ExtendedStandardControls.KryptonButtonExtended();
            this.kbtnSkip = new ExtendedStandardControls.KryptonButtonExtended();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelExtended1)).BeginInit();
            this.kryptonPanelExtended1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanelExtended1
            // 
            this.kryptonPanelExtended1.BackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.BackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.Controls.Add(this.kbtnSkip);
            this.kryptonPanelExtended1.Controls.Add(this.kbtnRemins);
            this.kryptonPanelExtended1.Controls.Add(this.kbtnInstall);
            this.kryptonPanelExtended1.Controls.Add(this.NetSparkleBrowser);
            this.kryptonPanelExtended1.Controls.Add(this.kryptonLabelExtended1);
            this.kryptonPanelExtended1.Controls.Add(this.klblDetails);
            this.kryptonPanelExtended1.Controls.Add(this.klblHeader);
            this.kryptonPanelExtended1.Controls.Add(this.pbxAppIcon);
            this.kryptonPanelExtended1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelExtended1.Image = null;
            this.kryptonPanelExtended1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelExtended1.Name = "kryptonPanelExtended1";
            this.kryptonPanelExtended1.Size = new System.Drawing.Size(575, 452);
            this.kryptonPanelExtended1.TabIndex = 0;
            // 
            // klblHeader
            // 
            this.klblHeader.Image = null;
            this.klblHeader.Location = new System.Drawing.Point(67, 12);
            this.klblHeader.LongTextTypeface = null;
            this.klblHeader.Name = "klblHeader";
            this.klblHeader.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblHeader.Size = new System.Drawing.Size(215, 21);
            this.klblHeader.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblHeader.TabIndex = 4;
            this.klblHeader.TextColourOne = System.Drawing.Color.Empty;
            this.klblHeader.TextColourTwo = System.Drawing.Color.Empty;
            this.klblHeader.Values.Text = "A new version of {0} is available!";
            // 
            // pbxAppIcon
            // 
            this.pbxAppIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxAppIcon.Image = global::KryptonSparkle.Properties.Resources.software_update_available1;
            this.pbxAppIcon.Location = new System.Drawing.Point(12, 12);
            this.pbxAppIcon.Name = "pbxAppIcon";
            this.pbxAppIcon.Size = new System.Drawing.Size(48, 48);
            this.pbxAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxAppIcon.TabIndex = 3;
            this.pbxAppIcon.TabStop = false;
            // 
            // klblDetails
            // 
            this.klblDetails.AutoSize = false;
            this.klblDetails.Image = null;
            this.klblDetails.Location = new System.Drawing.Point(67, 39);
            this.klblDetails.LongTextTypeface = null;
            this.klblDetails.Name = "klblDetails";
            this.klblDetails.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblDetails.Size = new System.Drawing.Size(496, 49);
            this.klblDetails.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblDetails.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.klblDetails.TabIndex = 1;
            this.klblDetails.TextColourOne = System.Drawing.Color.Empty;
            this.klblDetails.TextColourTwo = System.Drawing.Color.Empty;
            this.klblDetails.Values.Text = "APP is now available (you have OLDVERSION). \r\nWould you like to download it now?";
            // 
            // kryptonLabelExtended1
            // 
            this.kryptonLabelExtended1.Image = null;
            this.kryptonLabelExtended1.Location = new System.Drawing.Point(67, 94);
            this.kryptonLabelExtended1.LongTextTypeface = null;
            this.kryptonLabelExtended1.Name = "kryptonLabelExtended1";
            this.kryptonLabelExtended1.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.Size = new System.Drawing.Size(103, 21);
            this.kryptonLabelExtended1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.TabIndex = 5;
            this.kryptonLabelExtended1.TextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.TextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.Values.Text = "Release Notes:";
            // 
            // NetSparkleBrowser
            // 
            this.NetSparkleBrowser.IsWebBrowserContextMenuEnabled = false;
            this.NetSparkleBrowser.Location = new System.Drawing.Point(67, 121);
            this.NetSparkleBrowser.MinimumSize = new System.Drawing.Size(20, 28);
            this.NetSparkleBrowser.Name = "NetSparkleBrowser";
            this.NetSparkleBrowser.Size = new System.Drawing.Size(496, 290);
            this.NetSparkleBrowser.TabIndex = 6;
            // 
            // kbtnInstall
            // 
            this.kbtnInstall.Image = null;
            this.kbtnInstall.Location = new System.Drawing.Point(444, 417);
            this.kbtnInstall.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnInstall.Name = "kbtnInstall";
            this.kbtnInstall.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnInstall.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnInstall.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnInstall.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnInstall.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnInstall.Size = new System.Drawing.Size(119, 25);
            this.kbtnInstall.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnInstall.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnInstall.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnInstall.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnInstall.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnInstall.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnInstall.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnInstall.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnInstall.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnInstall.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnInstall.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnInstall.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnInstall.TabIndex = 2;
            this.kbtnInstall.Values.Text = "I&nstall Update";
            // 
            // kbtnRemins
            // 
            this.kbtnRemins.Image = null;
            this.kbtnRemins.Location = new System.Drawing.Point(295, 417);
            this.kbtnRemins.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRemins.Name = "kbtnRemins";
            this.kbtnRemins.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRemins.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRemins.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRemins.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRemins.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRemins.Size = new System.Drawing.Size(143, 25);
            this.kbtnRemins.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRemins.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRemins.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRemins.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRemins.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRemins.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRemins.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRemins.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRemins.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRemins.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRemins.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemins.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemins.TabIndex = 2;
            this.kbtnRemins.Values.Text = "Remind Me &Later";
            // 
            // kbtnSkip
            // 
            this.kbtnSkip.Image = null;
            this.kbtnSkip.Location = new System.Drawing.Point(67, 417);
            this.kbtnSkip.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnSkip.Name = "kbtnSkip";
            this.kbtnSkip.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnSkip.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSkip.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnSkip.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSkip.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSkip.Size = new System.Drawing.Size(143, 25);
            this.kbtnSkip.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnSkip.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSkip.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnSkip.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSkip.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnSkip.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSkip.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnSkip.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSkip.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnSkip.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSkip.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnSkip.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnSkip.TabIndex = 2;
            this.kbtnSkip.Values.Text = "&Skip this Version";
            // 
            // KryptonSparkleForm
            // 
            this.ClientSize = new System.Drawing.Size(575, 452);
            this.Controls.Add(this.kryptonPanelExtended1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonSparkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software Update";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelExtended1)).EndInit();
            this.kryptonPanelExtended1.ResumeLayout(false);
            this.kryptonPanelExtended1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAppIcon)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Constructor
        public KryptonSparkleForm(KryptonSparkleAppCastItem item, Image image, Icon icon)
        {
            InitializeComponent();

            // init ui 
            try
            {
                NetSparkleBrowser.AllowWebBrowserDrop = false;
                NetSparkleBrowser.AllowNavigation = false;
            }
            catch (Exception)
            { }

            _currentItem = item;

            klblHeader.Text = $"A new version of { item.AppName } is available!";
            klblDetails.Text = klblDetails.Text.Replace("APP", item.AppName + " " + item.Version);
            klblDetails.Text = klblDetails.Text.Replace("OLDVERSION", item.AppVersionInstalled);

            if (!string.IsNullOrEmpty(item.ReleaseNotesLink))
                NetSparkleBrowser.Navigate(item.ReleaseNotesLink);
            else
                RemoveReleaseNotesControls();

            if (image != null)
                pbxAppIcon.Image = image;

            if (icon != null)
                Icon = icon;

            this.TopMost = true;
        }
        #endregion

        public DialogResult Result => DialogResult;

        public KryptonSparkleAppCastItem CurrentItem { get => _currentItem; set => _currentItem = value; }

        public event EventHandler UserResponded;

        public void HideReleaseNotes()
        {
            RemoveReleaseNotesControls();
        }

        public void Show()
        {
            ShowDialog();

            if (UserResponded != null) UserResponded(this, new EventArgs());
        }

        /// <summary>
        /// Removes the release notes control
        /// </summary>
        public void RemoveReleaseNotesControls()
        {
            if (kryptonLabelExtended1.Parent == null)
                return;

            // calc new size
            Size newSize = new Size(this.Size.Width, this.Size.Height - kryptonLabelExtended1.Height - kryptonPanelExtended1.Height);

            // remove the no more needed controls            
            kryptonPanelExtended1.Parent.Controls.Remove(kryptonPanelExtended1);
            NetSparkleBrowser.Parent.Controls.Remove(NetSparkleBrowser);
            //? panel1.Parent.Controls.Remove(panel1);

            // resize the window
            /*this.MinimumSize = newSize;
            this.Size = this.MinimumSize;
            this.MaximumSize = this.MinimumSize;*/
            this.Size = newSize;
        }

    }
}