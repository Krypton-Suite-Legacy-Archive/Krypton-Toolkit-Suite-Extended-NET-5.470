using ComponentFactory.Krypton.Toolkit;
using System;

namespace Playground
{
    public class StandardControlsExtended : KryptonForm
    {
        private KryptonManager kryptonManager1;
        private ExtendedStandardControls.KryptonComboBoxExtended kryptonComboBoxExtended1;
        private ExtendedStandardControls.KryptonCheckButtonExtended kryptonCheckButtonExtended1;
        private ExtendedStandardControls.KryptonCheckedListBoxExtended kryptonCheckedListBoxExtended1;
        private System.ComponentModel.IContainer components;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonComboBoxExtended1 = new ExtendedStandardControls.KryptonComboBoxExtended();
            this.kryptonCheckButtonExtended1 = new ExtendedStandardControls.KryptonCheckButtonExtended();
            this.kryptonCheckedListBoxExtended1 = new ExtendedStandardControls.KryptonCheckedListBoxExtended();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBoxExtended1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // kryptonComboBoxExtended1
            // 
            this.kryptonComboBoxExtended1.ComboBoxContentTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.ComboBoxItemContentLongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.ComboBoxItemContentShortTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.DropDownWidth = 121;
            this.kryptonComboBoxExtended1.Image = null;
            this.kryptonComboBoxExtended1.IntegralHeight = false;
            this.kryptonComboBoxExtended1.Location = new System.Drawing.Point(291, 79);
            this.kryptonComboBoxExtended1.Name = "kryptonComboBoxExtended1";
            this.kryptonComboBoxExtended1.Size = new System.Drawing.Size(121, 18);
            this.kryptonComboBoxExtended1.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.StateActive.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonComboBoxExtended1.StateActiveComboBoxBackColour = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateActiveComboBoxContentColour = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonComboBoxExtended1.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.StateCommonComboBoxBackColour = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateCommonComboBoxContentColour = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateCommonComboBoxDropBackColourOne = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateCommonComboBoxDropBackColourTwo = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateCommonComboBoxItemBackColourOne = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateCommonComboBoxItemBackColourTwo = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateCommonComboBoxItemContentLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateCommonComboBoxItemContentLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateCommonComboBoxItemContentShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateCommonComboBoxItemContentShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateDisabled.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.StateDisabled.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonComboBoxExtended1.StateDisabled.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.StateDisabled.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.StateDisabledComboBoxBackColour = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateDisabledComboBoxContentColour = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateDisabledComboBoxItemBackColourOne = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateDisabledComboBoxItemBackColourTwo = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateDisabledComboBoxItemContentLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateDisabledComboBoxItemContentLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateDisabledComboBoxItemContentShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateDisabledComboBoxItemContentShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateNormal.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.StateNormal.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonComboBoxExtended1.StateNormal.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.StateNormalComboBoxBackColour = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateNormalComboBoxContentColour = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateNormalComboBoxItemBackColourOne = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateNormalComboBoxItemBackColourTwo = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateNormalComboBoxItemContentLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateNormalComboBoxItemContentLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateNormalComboBoxItemContentShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateNormalComboBoxItemContentShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateTracking.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.StateTrackingComboBoxItemBackColourOne = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateTrackingComboBoxItemBackColourTwo = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateTrackingComboBoxItemContentLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateTrackingComboBoxItemContentLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateTrackingComboBoxItemContentShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.StateTrackingComboBoxItemContentShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.TabIndex = 0;
            this.kryptonComboBoxExtended1.Text = "kryptonComboBoxExtended1";
            // 
            // kryptonCheckButtonExtended1
            // 
            this.kryptonCheckButtonExtended1.Image = null;
            this.kryptonCheckButtonExtended1.Location = new System.Drawing.Point(655, 246);
            this.kryptonCheckButtonExtended1.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckButtonExtended1.Name = "kryptonCheckButtonExtended1";
            this.kryptonCheckButtonExtended1.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckButtonExtended1.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckButtonExtended1.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckButtonExtended1.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckButtonExtended1.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.ShortTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckButtonExtended1.Size = new System.Drawing.Size(90, 25);
            this.kryptonCheckButtonExtended1.StateCheckedNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckButtonExtended1.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckButtonExtended1.StateCheckedNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCheckedNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCheckedNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCheckedNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCheckedNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCheckedNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCheckedPressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckButtonExtended1.StateCheckedPressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckButtonExtended1.StateCheckedPressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCheckedPressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCheckedPressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCheckedPressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCheckedPressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCheckedPressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCheckedTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckButtonExtended1.StateCheckedTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckButtonExtended1.StateCheckedTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCheckedTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCheckedTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCheckedTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCheckedTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCheckedTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckButtonExtended1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckButtonExtended1.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckButtonExtended1.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckButtonExtended1.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckButtonExtended1.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckButtonExtended1.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckButtonExtended1.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckButtonExtended1.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckButtonExtended1.TabIndex = 1;
            this.kryptonCheckButtonExtended1.Values.Text = "kryptonCheckButtonExtended1";
            // 
            // kryptonCheckedListBoxExtended1
            // 
            this.kryptonCheckedListBoxExtended1.Image = null;
            this.kryptonCheckedListBoxExtended1.Location = new System.Drawing.Point(532, 296);
            this.kryptonCheckedListBoxExtended1.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.Name = "kryptonCheckedListBoxExtended1";
            this.kryptonCheckedListBoxExtended1.OverrideFocus.Item.Content.LongText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.OverrideFocus.Item.Content.LongText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.OverrideFocus.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.OverrideFocus.Item.Content.ShortText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.OverrideFocus.Item.Content.ShortText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.OverrideFocus.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.OverrideFocusItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.OverrideFocusItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.OverrideFocusLongTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.OverrideFocusLongTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.OverrideFocusShortTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.OverrideFocusShortTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.ShortTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.Size = new System.Drawing.Size(120, 96);
            this.kryptonCheckedListBoxExtended1.StateActiveBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateActiveBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateCheckedNormal.Item.Content.LongText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedNormal.Item.Content.LongText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedNormal.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.StateCheckedNormal.Item.Content.ShortText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedNormal.Item.Content.ShortText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.StateCheckedNormalItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateCheckedNormalItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateCheckedNormalLongTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedNormalLongTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedNormalShortTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedNormalShortTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedPressed.Item.Content.LongText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedPressed.Item.Content.LongText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedPressed.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.StateCheckedPressed.Item.Content.ShortText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedPressed.Item.Content.ShortText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedPressed.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.StateCheckedPressedItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateCheckedPressedItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateCheckedPressedLongTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedPressedLongTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedPressedShortTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedPressedShortTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedTracking.Item.Content.LongText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedTracking.Item.Content.LongText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedTracking.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.StateCheckedTracking.Item.Content.ShortText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedTracking.Item.Content.ShortText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.StateCheckedTrackingItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateCheckedTrackingItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateCheckedTrackingLongTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedTrackingLongTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedTrackingShortTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCheckedTrackingShortTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCommon.Item.Content.LongText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCommon.Item.Content.LongText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.StateCommonBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateCommonBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateCommonItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateCommonItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateCommonLongTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCommonLongTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCommonShortTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCommonShortTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateDisabled.Item.Content.LongText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateDisabled.Item.Content.LongText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateDisabled.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.StateDisabled.Item.Content.ShortText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateDisabled.Item.Content.ShortText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateDisabled.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.StateDisabledBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateDisabledBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateDisabledItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateDisabledItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateDisabledLongTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateDisabledLongTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateDisabledShortTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateDisabledShortTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateNormal.Item.Content.LongText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateNormal.Item.Content.LongText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateNormal.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.StateNormal.Item.Content.ShortText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateNormal.Item.Content.ShortText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.StateNormalBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateNormalBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateNormalItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateNormalItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateNormalLongTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateNormalLongTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateNormalShortTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateNormalShortTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StatePressed.Item.Content.LongText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StatePressed.Item.Content.LongText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StatePressed.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.StatePressed.Item.Content.ShortText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StatePressed.Item.Content.ShortText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StatePressed.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.StatePressedItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StatePressedItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StatePressedLongTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StatePressedLongTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StatePressedShortTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StatePressedShortTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateTracking.Item.Content.LongText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateTracking.Item.Content.LongText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateTracking.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.StateTracking.Item.Content.ShortText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateTracking.Item.Content.ShortText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.StateTrackingItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateTrackingItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateTrackingLongTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateTrackingLongTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateTrackingShortTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateTrackingShortTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.TabIndex = 2;
            // 
            // StandardControlsExtended
            // 
            this.ClientSize = new System.Drawing.Size(1369, 636);
            this.Controls.Add(this.kryptonCheckedListBoxExtended1);
            this.Controls.Add(this.kryptonCheckButtonExtended1);
            this.Controls.Add(this.kryptonComboBoxExtended1);
            this.Name = "StandardControlsExtended";
            this.Load += new System.EventHandler(this.StandardControlsExtended_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBoxExtended1)).EndInit();
            this.ResumeLayout(false);

        }

        public StandardControlsExtended()
        {
            InitializeComponent();
        }

        private void StandardControlsExtended_Load(object sender, EventArgs e)
        {

        }
    }
}