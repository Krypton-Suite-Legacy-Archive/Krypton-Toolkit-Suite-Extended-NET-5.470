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
        private KryptonPanel kryptonPanel1;
        private ExtendedStandardControls.KryptonLabelExtended klblHeader;
        private ExtendedStandardControls.KryptonLabelExtended klblDetails;
        private ExtendedStandardControls.KryptonLabelExtended kryptonLabelExtended1;
        private WebBrowser NetSparkleBrowser;
        private ExtendedStandardControls.KryptonButtonExtended kbtnSkip;
        private ExtendedStandardControls.KryptonButtonExtended kbtnInstall;
        private ExtendedStandardControls.KryptonButtonExtended kbtnRemind;
        private PictureBox pbxAppIcon;


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonSparkleForm));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klblHeader = new ExtendedStandardControls.KryptonLabelExtended();
            this.pbxAppIcon = new System.Windows.Forms.PictureBox();
            this.klblDetails = new ExtendedStandardControls.KryptonLabelExtended();
            this.kryptonLabelExtended1 = new ExtendedStandardControls.KryptonLabelExtended();
            this.NetSparkleBrowser = new System.Windows.Forms.WebBrowser();
            this.kbtnInstall = new ExtendedStandardControls.KryptonButtonExtended();
            this.kbtnRemind = new ExtendedStandardControls.KryptonButtonExtended();
            this.kbtnSkip = new ExtendedStandardControls.KryptonButtonExtended();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnSkip);
            this.kryptonPanel1.Controls.Add(this.kbtnInstall);
            this.kryptonPanel1.Controls.Add(this.kbtnRemind);
            this.kryptonPanel1.Controls.Add(this.NetSparkleBrowser);
            this.kryptonPanel1.Controls.Add(this.kryptonLabelExtended1);
            this.kryptonPanel1.Controls.Add(this.klblDetails);
            this.kryptonPanel1.Controls.Add(this.klblHeader);
            this.kryptonPanel1.Controls.Add(this.pbxAppIcon);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(679, 494);
            this.kryptonPanel1.TabIndex = 0;
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
            this.klblHeader.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.klblHeader.StateCommonTextColourTwo = System.Drawing.Color.Empty;
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
            this.klblDetails.Image = null;
            this.klblDetails.Location = new System.Drawing.Point(67, 39);
            this.klblDetails.LongTextTypeface = null;
            this.klblDetails.Name = "klblDetails";
            this.klblDetails.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblDetails.Size = new System.Drawing.Size(423, 19);
            this.klblDetails.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblDetails.TabIndex = 5;
            this.klblDetails.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.klblDetails.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.klblDetails.Values.Text = "APP is now available (you have OLDVERSION). Would you like to download it now?";
            // 
            // kryptonLabelExtended1
            // 
            this.kryptonLabelExtended1.Image = null;
            this.kryptonLabelExtended1.Location = new System.Drawing.Point(67, 64);
            this.kryptonLabelExtended1.LongTextTypeface = null;
            this.kryptonLabelExtended1.Name = "kryptonLabelExtended1";
            this.kryptonLabelExtended1.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.Size = new System.Drawing.Size(100, 21);
            this.kryptonLabelExtended1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.TabIndex = 6;
            this.kryptonLabelExtended1.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.Values.Text = "Release notes:";
            // 
            // NetSparkleBrowser
            // 
            this.NetSparkleBrowser.IsWebBrowserContextMenuEnabled = false;
            this.NetSparkleBrowser.Location = new System.Drawing.Point(67, 91);
            this.NetSparkleBrowser.MinimumSize = new System.Drawing.Size(20, 28);
            this.NetSparkleBrowser.Name = "NetSparkleBrowser";
            this.NetSparkleBrowser.Size = new System.Drawing.Size(600, 355);
            this.NetSparkleBrowser.TabIndex = 7;
            // 
            // kbtnInstall
            // 
            this.kbtnInstall.Image = null;
            this.kbtnInstall.Location = new System.Drawing.Point(577, 457);
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
            this.kbtnInstall.Size = new System.Drawing.Size(90, 25);
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
            this.kbtnInstall.Values.Text = "I&nstall";
            this.kbtnInstall.Click += new System.EventHandler(this.KbtnInstall_Click);
            // 
            // kbtnRemind
            // 
            this.kbtnRemind.Image = null;
            this.kbtnRemind.Location = new System.Drawing.Point(428, 457);
            this.kbtnRemind.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRemind.Name = "kbtnRemind";
            this.kbtnRemind.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRemind.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRemind.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRemind.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRemind.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRemind.Size = new System.Drawing.Size(143, 25);
            this.kbtnRemind.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRemind.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRemind.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRemind.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRemind.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRemind.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRemind.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRemind.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRemind.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnRemind.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnRemind.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnRemind.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnRemind.TabIndex = 3;
            this.kbtnRemind.Values.Text = "&Remind me Later";
            this.kbtnRemind.Click += new System.EventHandler(this.KbtnRemind_Click);
            // 
            // kbtnSkip
            // 
            this.kbtnSkip.Image = null;
            this.kbtnSkip.Location = new System.Drawing.Point(67, 457);
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
            this.kbtnSkip.TabIndex = 8;
            this.kbtnSkip.Values.Text = "&Skip this Version";
            this.kbtnSkip.Click += new System.EventHandler(this.KbtnSkip_Click);
            // 
            // KryptonSparkleForm
            // 
            this.ClientSize = new System.Drawing.Size(679, 494);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonSparkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software Update";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAppIcon)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private KryptonSparkleAppCastItem _currentItem;
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
            Size newSize = new Size(this.Size.Width, this.Size.Height - kryptonLabelExtended1.Height - kryptonPanel1.Height);

            // remove the no more needed controls            
            kryptonPanel1.Parent.Controls.Remove(kryptonPanel1);
            NetSparkleBrowser.Parent.Controls.Remove(NetSparkleBrowser);
            //? panel1.Parent.Controls.Remove(panel1);

            // resize the window
            /*this.MinimumSize = newSize;
            this.Size = this.MinimumSize;
            this.MaximumSize = this.MinimumSize;*/
            this.Size = newSize;
        }

        private void KbtnSkip_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;

            Close();
        }

        private void KbtnRemind_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;

            Close();
        }

        private void KbtnInstall_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;

            Close();
        }
    }
}