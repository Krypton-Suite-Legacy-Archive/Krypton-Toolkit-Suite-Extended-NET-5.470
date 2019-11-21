using ComponentFactory.Krypton.Toolkit;
using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace ExtendedDialogs.Dialogs.Run
{
    public class KryptonRunArguments : KryptonForm
    {
        private ExtendedStandardControls.KryptonPanelExtended kpnlButtons;
        private System.Windows.Forms.Panel panel1;
        private ExtendedStandardControls.KryptonPanelExtended kryptonPanelExtended1;
        private ExtendedStandardControls.KryptonTextBoxExtended ktxtAdditionalArguements;
        private ExtendedStandardControls.KryptonLabelExtended klblRun;
        private ExtendedStandardControls.KryptonLabelExtended kryptonLabelExtended1;
        private ExtendedStandardControls.KryptonButtonExtended kbtnRun;
        private ExtendedStandardControls.KryptonButtonExtended kbtnCancel;

        private void InitializeComponent()
        {
            this.kpnlButtons = new ExtendedStandardControls.KryptonPanelExtended();
            this.kbtnCancel = new ExtendedStandardControls.KryptonButtonExtended();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanelExtended1 = new ExtendedStandardControls.KryptonPanelExtended();
            this.kryptonLabelExtended1 = new ExtendedStandardControls.KryptonLabelExtended();
            this.klblRun = new ExtendedStandardControls.KryptonLabelExtended();
            this.ktxtAdditionalArguements = new ExtendedStandardControls.KryptonTextBoxExtended();
            this.kbtnRun = new ExtendedStandardControls.KryptonButtonExtended();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlButtons)).BeginInit();
            this.kpnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelExtended1)).BeginInit();
            this.kryptonPanelExtended1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kpnlButtons
            // 
            this.kpnlButtons.Controls.Add(this.kbtnRun);
            this.kpnlButtons.Controls.Add(this.kbtnCancel);
            this.kpnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpnlButtons.Image = null;
            this.kpnlButtons.Location = new System.Drawing.Point(0, 119);
            this.kpnlButtons.Name = "kpnlButtons";
            this.kpnlButtons.Size = new System.Drawing.Size(743, 57);
            this.kpnlButtons.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kpnlButtons.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kpnlButtons.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kpnlButtons.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kpnlButtons.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kpnlButtons.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kpnlButtons.TabIndex = 2;
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.Image = null;
            this.kbtnCancel.Location = new System.Drawing.Point(641, 7);
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 3);
            this.panel1.TabIndex = 4;
            // 
            // kryptonPanelExtended1
            // 
            this.kryptonPanelExtended1.Controls.Add(this.ktxtAdditionalArguements);
            this.kryptonPanelExtended1.Controls.Add(this.klblRun);
            this.kryptonPanelExtended1.Controls.Add(this.kryptonLabelExtended1);
            this.kryptonPanelExtended1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelExtended1.Image = null;
            this.kryptonPanelExtended1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelExtended1.Name = "kryptonPanelExtended1";
            this.kryptonPanelExtended1.Size = new System.Drawing.Size(743, 116);
            this.kryptonPanelExtended1.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonPanelExtended1.TabIndex = 5;
            // 
            // kryptonLabelExtended1
            // 
            this.kryptonLabelExtended1.Image = null;
            this.kryptonLabelExtended1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabelExtended1.LongTextTypeface = null;
            this.kryptonLabelExtended1.Name = "kryptonLabelExtended1";
            this.kryptonLabelExtended1.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.Size = new System.Drawing.Size(111, 26);
            this.kryptonLabelExtended1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateDisabled.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.StateDisabledTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateDisabledTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.StateNormalTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateNormalTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.TabIndex = 2;
            this.kryptonLabelExtended1.Values.Text = "Arguements:";
            // 
            // klblRun
            // 
            this.klblRun.Image = null;
            this.klblRun.Location = new System.Drawing.Point(12, 60);
            this.klblRun.LongTextTypeface = null;
            this.klblRun.Name = "klblRun";
            this.klblRun.ShortTextTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRun.Size = new System.Drawing.Size(6, 2);
            this.klblRun.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRun.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.klblRun.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.klblRun.StateDisabled.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRun.StateDisabledTextColourOne = System.Drawing.Color.Empty;
            this.klblRun.StateDisabledTextColourTwo = System.Drawing.Color.Empty;
            this.klblRun.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRun.StateNormalTextColourOne = System.Drawing.Color.Empty;
            this.klblRun.StateNormalTextColourTwo = System.Drawing.Color.Empty;
            this.klblRun.TabIndex = 3;
            this.klblRun.Values.Text = "";
            // 
            // ktxtAdditionalArguements
            // 
            this.ktxtAdditionalArguements.Hint = "Please type additional arguements here...";
            this.ktxtAdditionalArguements.Location = new System.Drawing.Point(130, 13);
            this.ktxtAdditionalArguements.Name = "ktxtAdditionalArguements";
            this.ktxtAdditionalArguements.Size = new System.Drawing.Size(601, 29);
            this.ktxtAdditionalArguements.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtAdditionalArguements.StateActive.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtAdditionalArguements.StateActiveBackGroundColour = System.Drawing.Color.Empty;
            this.ktxtAdditionalArguements.StateActiveBorderColourOne = System.Drawing.Color.Empty;
            this.ktxtAdditionalArguements.StateActiveBorderColourTwo = System.Drawing.Color.Empty;
            this.ktxtAdditionalArguements.StateActiveTextColour = System.Drawing.Color.Empty;
            this.ktxtAdditionalArguements.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtAdditionalArguements.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtAdditionalArguements.StateCommonBackGroundColour = System.Drawing.Color.Empty;
            this.ktxtAdditionalArguements.StateCommonBorderColourOne = System.Drawing.Color.Empty;
            this.ktxtAdditionalArguements.StateCommonBorderColourTwo = System.Drawing.Color.Empty;
            this.ktxtAdditionalArguements.StateCommonTextColour = System.Drawing.Color.Empty;
            this.ktxtAdditionalArguements.StateDisabled.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtAdditionalArguements.StateDisabled.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtAdditionalArguements.StateDisabledBackGroundColour = System.Drawing.Color.Empty;
            this.ktxtAdditionalArguements.StateDisabledBorderColourOne = System.Drawing.Color.Empty;
            this.ktxtAdditionalArguements.StateDisabledBorderColourTwo = System.Drawing.Color.Empty;
            this.ktxtAdditionalArguements.StateDisabledTextColour = System.Drawing.Color.Empty;
            this.ktxtAdditionalArguements.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtAdditionalArguements.StateNormal.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtAdditionalArguements.StateNormalBackgroundColour = System.Drawing.Color.Empty;
            this.ktxtAdditionalArguements.StateNormalBorderColourOne = System.Drawing.Color.Empty;
            this.ktxtAdditionalArguements.StateNormalBorderColourTwo = System.Drawing.Color.Empty;
            this.ktxtAdditionalArguements.StateNormalTextColour = System.Drawing.Color.Empty;
            this.ktxtAdditionalArguements.TabIndex = 4;
            this.ktxtAdditionalArguements.Typeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtAdditionalArguements.TextChanged += new System.EventHandler(this.ktxtAdditionalArguements_TextChanged);
            // 
            // kbtnRun
            // 
            this.kbtnRun.Enabled = false;
            this.kbtnRun.Image = null;
            this.kbtnRun.Location = new System.Drawing.Point(545, 7);
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
            this.kbtnRun.TabIndex = 4;
            this.kbtnRun.Values.Text = "&Run";
            this.kbtnRun.Click += new System.EventHandler(this.kbtnRun_Click);
            // 
            // KryptonRunArguments
            // 
            this.ClientSize = new System.Drawing.Size(743, 176);
            this.Controls.Add(this.kryptonPanelExtended1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kpnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonRunArguments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KryptonRunArguments_FormClosing);
            this.Load += new System.EventHandler(this.KryptonRunArguments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlButtons)).EndInit();
            this.kpnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelExtended1)).EndInit();
            this.kryptonPanelExtended1.ResumeLayout(false);
            this.kryptonPanelExtended1.PerformLayout();
            this.ResumeLayout(false);

        }

        #region Variables
        private string _processToRun;

        private KryptonRunDialog _runDialog;
        #endregion

        #region Properties
        public string ProcessToRun { get => _processToRun; set => _processToRun = value; }

        public KryptonRunDialog RunDialog { get => _runDialog; set => _runDialog = value; }
        #endregion

        #region Constructor
        public KryptonRunArguments(string processToRun, KryptonRunDialog runDialog)
        {
            InitializeComponent();

            ProcessToRun = processToRun;

            RunDialog = runDialog;
        }
        #endregion

        private void kbtnRun_Click(object sender, EventArgs e)
        {
            ProcessStartInfo process = new ProcessStartInfo { Arguments = ktxtAdditionalArguements.Text, FileName = ProcessToRun };

            try
            {
                Process.Start(process);

                Application.Exit();
            }
            catch (Exception exc)
            {

                throw;
            }
        }

        private void KryptonRunArguments_Load(object sender, EventArgs e)
        {
            RunDialog.Enabled = false;

            RunDialog.EnableBlur();
        }

        private void KryptonRunArguments_FormClosing(object sender, FormClosingEventArgs e)
        {
            RunDialog.DisableBlur();

            RunDialog.Enabled = true;
        }

        private void ktxtAdditionalArguements_TextChanged(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(ktxtAdditionalArguements.Text);

            klblRun.Text = $"Run: { ProcessToRun } { stringBuilder.ToString() }";

            kbtnRun.Enabled = string.IsNullOrEmpty(ktxtAdditionalArguements.Text);
        }
    }
}