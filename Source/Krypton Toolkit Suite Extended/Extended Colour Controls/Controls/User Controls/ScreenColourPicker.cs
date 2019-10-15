using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedColourControls.Controls
{
    public class ScreenColourPicker : UserControl
    {
        #region Designer Code
        private ExtendedStandardControls.KryptonPanelExtended kryptonPanelExtended1;
        private ExtendedStandardControls.KryptonButtonExtended kbtnOk;
        private Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private KryptonBlueValueNumericBox knumBlue;
        private KryptonGreenValueNumericBox knumGreen;
        private KryptonRedValueNumericBox knumRed;
        private KryptonBlueTrackBar ktrkBlue;
        private KryptonGreenTrackBar ktrkGreen;
        private KryptonRedTrackBar ktrkRed;
        private Labels.KryptonBlueValueLabel kryptonBlueValueLabel1;
        private Labels.KryptonGreenValueLabel kryptonGreenValueLabel1;
        private Labels.KryptonRedValueLabel kryptonRedValueLabel1;
        private KryptonToolkitSuiteExtendedCore.CircularPictureBox cpbSelectedColour;
        private Cyotek.Windows.Forms.ScreenColorPicker scp1;
        private ExtendedStandardControls.KryptonButtonExtended kbtnCancel;

        private void InitializeComponent()
        {
            this.kryptonPanelExtended1 = new ExtendedStandardControls.KryptonPanelExtended();
            this.kbtnOk = new ExtendedStandardControls.KryptonButtonExtended();
            this.kbtnCancel = new ExtendedStandardControls.KryptonButtonExtended();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.knumBlue = new ExtendedColourControls.KryptonBlueValueNumericBox();
            this.knumGreen = new ExtendedColourControls.KryptonGreenValueNumericBox();
            this.knumRed = new ExtendedColourControls.KryptonRedValueNumericBox();
            this.ktrkBlue = new ExtendedColourControls.KryptonBlueTrackBar();
            this.ktrkGreen = new ExtendedColourControls.KryptonGreenTrackBar();
            this.ktrkRed = new ExtendedColourControls.KryptonRedTrackBar();
            this.kryptonBlueValueLabel1 = new ExtendedColourControls.Controls.Labels.KryptonBlueValueLabel();
            this.kryptonGreenValueLabel1 = new ExtendedColourControls.Controls.Labels.KryptonGreenValueLabel();
            this.kryptonRedValueLabel1 = new ExtendedColourControls.Controls.Labels.KryptonRedValueLabel();
            this.cpbSelectedColour = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            this.scp1 = new Cyotek.Windows.Forms.ScreenColorPicker();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelExtended1)).BeginInit();
            this.kryptonPanelExtended1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbSelectedColour)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanelExtended1
            // 
            this.kryptonPanelExtended1.Controls.Add(this.kbtnOk);
            this.kryptonPanelExtended1.Controls.Add(this.kbtnCancel);
            this.kryptonPanelExtended1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanelExtended1.Image = null;
            this.kryptonPanelExtended1.Location = new System.Drawing.Point(0, 455);
            this.kryptonPanelExtended1.Name = "kryptonPanelExtended1";
            this.kryptonPanelExtended1.Size = new System.Drawing.Size(479, 50);
            this.kryptonPanelExtended1.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.TabIndex = 1;
            // 
            // kbtnOk
            // 
            this.kbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnOk.Image = null;
            this.kbtnOk.Location = new System.Drawing.Point(281, 13);
            this.kbtnOk.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnOk.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnOk.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.Size = new System.Drawing.Size(90, 25);
            this.kbtnOk.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnOk.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnOk.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnOk.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kbtnOk.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kbtnOk.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kbtnOk.TabIndex = 1;
            this.kbtnOk.Values.Text = "&Ok";
            this.kbtnOk.Click += new System.EventHandler(this.kbtnOk_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Image = null;
            this.kbtnCancel.Location = new System.Drawing.Point(377, 13);
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
            this.panel1.Location = new System.Drawing.Point(0, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 3);
            this.panel1.TabIndex = 2;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.knumBlue);
            this.kryptonPanel1.Controls.Add(this.knumGreen);
            this.kryptonPanel1.Controls.Add(this.knumRed);
            this.kryptonPanel1.Controls.Add(this.ktrkBlue);
            this.kryptonPanel1.Controls.Add(this.ktrkGreen);
            this.kryptonPanel1.Controls.Add(this.ktrkRed);
            this.kryptonPanel1.Controls.Add(this.kryptonBlueValueLabel1);
            this.kryptonPanel1.Controls.Add(this.kryptonGreenValueLabel1);
            this.kryptonPanel1.Controls.Add(this.kryptonRedValueLabel1);
            this.kryptonPanel1.Controls.Add(this.cpbSelectedColour);
            this.kryptonPanel1.Controls.Add(this.scp1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(479, 452);
            this.kryptonPanel1.TabIndex = 3;
            // 
            // knumBlue
            // 
            this.knumBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.knumBlue.Location = new System.Drawing.Point(401, 409);
            this.knumBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumBlue.Name = "knumBlue";
            this.knumBlue.Size = new System.Drawing.Size(64, 26);
            this.knumBlue.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.knumBlue.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumBlue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.knumBlue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumBlue.TabIndex = 10;
            this.knumBlue.ValueChanged += new System.EventHandler(this.knumBlue_ValueChanged);
            // 
            // knumGreen
            // 
            this.knumGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.knumGreen.Location = new System.Drawing.Point(286, 409);
            this.knumGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumGreen.Name = "knumGreen";
            this.knumGreen.Size = new System.Drawing.Size(64, 26);
            this.knumGreen.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.knumGreen.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumGreen.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.knumGreen.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumGreen.TabIndex = 9;
            this.knumGreen.ValueChanged += new System.EventHandler(this.knumGreen_ValueChanged);
            // 
            // knumRed
            // 
            this.knumRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.knumRed.Location = new System.Drawing.Point(159, 409);
            this.knumRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumRed.Name = "knumRed";
            this.knumRed.Size = new System.Drawing.Size(64, 26);
            this.knumRed.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.knumRed.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumRed.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.knumRed.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumRed.TabIndex = 8;
            this.knumRed.ValueChanged += new System.EventHandler(this.knumRed_ValueChanged);
            // 
            // ktrkBlue
            // 
            this.ktrkBlue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ktrkBlue.DrawBackground = true;
            this.ktrkBlue.Location = new System.Drawing.Point(429, 44);
            this.ktrkBlue.Maximum = 255;
            this.ktrkBlue.Name = "ktrkBlue";
            this.ktrkBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ktrkBlue.Size = new System.Drawing.Size(21, 359);
            this.ktrkBlue.StateCommon.Tick.Color1 = System.Drawing.Color.Blue;
            this.ktrkBlue.StateCommon.Track.Color1 = System.Drawing.Color.Blue;
            this.ktrkBlue.StateCommon.Track.Color2 = System.Drawing.Color.Blue;
            this.ktrkBlue.StateCommon.Track.Color3 = System.Drawing.Color.Blue;
            this.ktrkBlue.StateCommon.Track.Color4 = System.Drawing.Color.Blue;
            this.ktrkBlue.StateCommon.Track.Color5 = System.Drawing.Color.Blue;
            this.ktrkBlue.TabIndex = 7;
            this.ktrkBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ktrkBlue.Value = 255;
            this.ktrkBlue.ValueChanged += new System.EventHandler(this.ktrkBlue_ValueChanged);
            // 
            // ktrkGreen
            // 
            this.ktrkGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ktrkGreen.DrawBackground = true;
            this.ktrkGreen.Location = new System.Drawing.Point(303, 44);
            this.ktrkGreen.Maximum = 255;
            this.ktrkGreen.Name = "ktrkGreen";
            this.ktrkGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ktrkGreen.Size = new System.Drawing.Size(21, 359);
            this.ktrkGreen.StateCommon.Tick.Color1 = System.Drawing.Color.Green;
            this.ktrkGreen.StateCommon.Track.Color1 = System.Drawing.Color.Green;
            this.ktrkGreen.StateCommon.Track.Color2 = System.Drawing.Color.Green;
            this.ktrkGreen.StateCommon.Track.Color3 = System.Drawing.Color.Green;
            this.ktrkGreen.StateCommon.Track.Color4 = System.Drawing.Color.Green;
            this.ktrkGreen.StateCommon.Track.Color5 = System.Drawing.Color.Green;
            this.ktrkGreen.TabIndex = 6;
            this.ktrkGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ktrkGreen.Value = 255;
            this.ktrkGreen.ValueChanged += new System.EventHandler(this.ktrkGreen_ValueChanged);
            // 
            // ktrkRed
            // 
            this.ktrkRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ktrkRed.DrawBackground = true;
            this.ktrkRed.Location = new System.Drawing.Point(174, 44);
            this.ktrkRed.Maximum = 255;
            this.ktrkRed.Name = "ktrkRed";
            this.ktrkRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ktrkRed.Size = new System.Drawing.Size(21, 359);
            this.ktrkRed.StateCommon.Tick.Color1 = System.Drawing.Color.Red;
            this.ktrkRed.StateCommon.Track.Color1 = System.Drawing.Color.Red;
            this.ktrkRed.StateCommon.Track.Color2 = System.Drawing.Color.Red;
            this.ktrkRed.StateCommon.Track.Color3 = System.Drawing.Color.Red;
            this.ktrkRed.StateCommon.Track.Color4 = System.Drawing.Color.Red;
            this.ktrkRed.StateCommon.Track.Color5 = System.Drawing.Color.Red;
            this.ktrkRed.TabIndex = 5;
            this.ktrkRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ktrkRed.Value = 255;
            this.ktrkRed.ValueChanged += new System.EventHandler(this.ktrkRed_ValueChanged);
            // 
            // kryptonBlueValueLabel1
            // 
            this.kryptonBlueValueLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonBlueValueLabel1.Location = new System.Drawing.Point(415, 12);
            this.kryptonBlueValueLabel1.Name = "kryptonBlueValueLabel1";
            this.kryptonBlueValueLabel1.RedValue = 255;
            this.kryptonBlueValueLabel1.Size = new System.Drawing.Size(46, 26);
            this.kryptonBlueValueLabel1.StateCommon.LongText.Color1 = System.Drawing.Color.Blue;
            this.kryptonBlueValueLabel1.StateCommon.LongText.Color2 = System.Drawing.Color.Blue;
            this.kryptonBlueValueLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonBlueValueLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Blue;
            this.kryptonBlueValueLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Blue;
            this.kryptonBlueValueLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonBlueValueLabel1.TabIndex = 4;
            this.kryptonBlueValueLabel1.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonBlueValueLabel1.Values.Text = "Blue";
            // 
            // kryptonGreenValueLabel1
            // 
            this.kryptonGreenValueLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonGreenValueLabel1.Location = new System.Drawing.Point(282, 12);
            this.kryptonGreenValueLabel1.Name = "kryptonGreenValueLabel1";
            this.kryptonGreenValueLabel1.RedValue = 255;
            this.kryptonGreenValueLabel1.Size = new System.Drawing.Size(58, 26);
            this.kryptonGreenValueLabel1.StateCommon.LongText.Color1 = System.Drawing.Color.Green;
            this.kryptonGreenValueLabel1.StateCommon.LongText.Color2 = System.Drawing.Color.Green;
            this.kryptonGreenValueLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonGreenValueLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Green;
            this.kryptonGreenValueLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Green;
            this.kryptonGreenValueLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonGreenValueLabel1.TabIndex = 3;
            this.kryptonGreenValueLabel1.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonGreenValueLabel1.Values.Text = "Green";
            // 
            // kryptonRedValueLabel1
            // 
            this.kryptonRedValueLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonRedValueLabel1.Location = new System.Drawing.Point(165, 12);
            this.kryptonRedValueLabel1.Name = "kryptonRedValueLabel1";
            this.kryptonRedValueLabel1.RedValue = 255;
            this.kryptonRedValueLabel1.Size = new System.Drawing.Size(42, 26);
            this.kryptonRedValueLabel1.StateCommon.LongText.Color1 = System.Drawing.Color.Red;
            this.kryptonRedValueLabel1.StateCommon.LongText.Color2 = System.Drawing.Color.Red;
            this.kryptonRedValueLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonRedValueLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonRedValueLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Red;
            this.kryptonRedValueLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonRedValueLabel1.TabIndex = 2;
            this.kryptonRedValueLabel1.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonRedValueLabel1.Values.Text = "Red";
            // 
            // cpbSelectedColour
            // 
            this.cpbSelectedColour.BackColor = System.Drawing.SystemColors.Control;
            this.cpbSelectedColour.Location = new System.Drawing.Point(12, 12);
            this.cpbSelectedColour.Name = "cpbSelectedColour";
            this.cpbSelectedColour.Size = new System.Drawing.Size(115, 115);
            this.cpbSelectedColour.TabIndex = 1;
            this.cpbSelectedColour.TabStop = false;
            // 
            // scp1
            // 
            this.scp1.Color = System.Drawing.Color.Empty;
            this.scp1.Image = global::ExtendedColourControls.Properties.Resources.dropper;
            this.scp1.Location = new System.Drawing.Point(12, 156);
            this.scp1.Name = "scp1";
            this.scp1.Size = new System.Drawing.Size(115, 115);
            this.scp1.ColorChanged += new System.EventHandler(this.scp1_ColorChanged);
            // 
            // ScreenColourPicker
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanelExtended1);
            this.MinimumSize = new System.Drawing.Size(479, 505);
            this.Name = "ScreenColourPicker";
            this.Size = new System.Drawing.Size(479, 505);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelExtended1)).EndInit();
            this.kryptonPanelExtended1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbSelectedColour)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private Color _selectedColour = Color.Empty;

        private KryptonForm _owner;
        #endregion

        #region Properties
        public Color SelectedColour { get => _selectedColour; set { _selectedColour = value; Invalidate(); } }

        public KryptonForm Owner { get => _owner; set { _owner = value; Invalidate(); } }
        #endregion

        #region Constructor
        public ScreenColourPicker()
        {
            InitializeComponent();

            if (Owner != null)
            {
                Owner.AcceptButton = kbtnOk;

                Owner.CancelButton = kbtnCancel;
            }
        }

        public ScreenColourPicker(KryptonForm owner)
        {
            InitializeComponent();

            owner.CancelButton = kbtnCancel;

            owner.AcceptButton = kbtnOk;
        }
        #endregion

        #region Methods
        /// <summary>Updates the selected colour.</summary>
        /// <param name="colour">The colour.</param>
        public void UpdateSelectedColour(Color colour)
        {
            int r = colour.R, g = colour.G, b = colour.B;

            ktrkRed.Value = r;

            ktrkGreen.Value = g;

            ktrkBlue.Value = b;

            knumRed.Value = r;

            knumGreen.Value = g;

            knumBlue.Value = b;

            cpbSelectedColour.BackColor = colour;

            SetSelectedColour(colour);
        }


        /// <summary>Updates the selected colour.</summary>
        /// <param name="red">The red.</param>
        /// <param name="green">The green.</param>
        /// <param name="blue">The blue.</param>
        public void UpdateSelectedColour(byte red, byte green, byte blue)
        {
            Color output = Color.FromArgb(red, green, blue);

            ktrkRed.Value = red;

            ktrkGreen.Value = green;

            ktrkBlue.Value = blue;

            knumRed.Value = red;

            knumGreen.Value = green;

            knumBlue.Value = blue;

            cpbSelectedColour.BackColor = output;

            SetSelectedColour(output);
        }
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the SelectedColour.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetSelectedColour(Color value) => SelectedColour = value;

        /// <summary>
        /// Gets the SelectedColour.
        /// </summary>
        /// <returns>The value of SelectedColour.</returns>
        public Color GetSelectedColour() => SelectedColour;
        #endregion

        #region Event Handlers
        private void kbtnOk_Click(object sender, EventArgs e)
        {

        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void ktrkRed_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ktrkGreen_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ktrkBlue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void knumRed_ValueChanged(object sender, EventArgs e)
        {

        }

        private void knumGreen_ValueChanged(object sender, EventArgs e)
        {

        }

        private void knumBlue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void scp1_ColorChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
        #endregion
    }
}