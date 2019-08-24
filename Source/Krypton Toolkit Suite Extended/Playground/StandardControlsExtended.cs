using ComponentFactory.Krypton.Toolkit;
using System;

namespace Playground
{
    public class StandardControlsExtended : KryptonForm
    {
        private KryptonManager kryptonManager1;
        private ExtendedStandardControls.KryptonCheckBoxExtended kryptonCheckBoxExtended1;
        private ExtendedStandardControls.KryptonCheckButtonExtended kryptonCheckButtonExtended1;
        private ExtendedStandardControls.KryptonCheckedListBoxExtended kryptonCheckedListBoxExtended1;
        private ExtendedStandardControls.KryptonButtonExtended kryptonButtonExtended1;
        private ExtendedStandardControls.KryptonColourButtonExtended kryptonColourButtonExtended1;
        private System.ComponentModel.IContainer components;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonButtonExtended1 = new ExtendedStandardControls.KryptonButtonExtended();
            this.kryptonCheckedListBoxExtended1 = new ExtendedStandardControls.KryptonCheckedListBoxExtended();
            this.kryptonCheckButtonExtended1 = new ExtendedStandardControls.KryptonCheckButtonExtended();
            this.kryptonCheckBoxExtended1 = new ExtendedStandardControls.KryptonCheckBoxExtended();
            this.kryptonColourButtonExtended1 = new ExtendedStandardControls.KryptonColourButtonExtended();
            this.SuspendLayout();
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // kryptonButtonExtended1
            // 
            this.kryptonButtonExtended1.Image = null;
            this.kryptonButtonExtended1.Location = new System.Drawing.Point(590, 274);
            this.kryptonButtonExtended1.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonButtonExtended1.Name = "kryptonButtonExtended1";
            this.kryptonButtonExtended1.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonButtonExtended1.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonButtonExtended1.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonButtonExtended1.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonButtonExtended1.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.ShortTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonButtonExtended1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonExtended1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonButtonExtended1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonButtonExtended1.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonButtonExtended1.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonButtonExtended1.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonButtonExtended1.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonButtonExtended1.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonButtonExtended1.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonButtonExtended1.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonButtonExtended1.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonButtonExtended1.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonButtonExtended1.TabIndex = 7;
            this.kryptonButtonExtended1.Values.Text = "kryptonButtonExtended1";
            // 
            // kryptonCheckedListBoxExtended1
            // 
            this.kryptonCheckedListBoxExtended1.Image = null;
            this.kryptonCheckedListBoxExtended1.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f"});
            this.kryptonCheckedListBoxExtended1.Location = new System.Drawing.Point(40, 117);
            this.kryptonCheckedListBoxExtended1.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.Name = "kryptonCheckedListBoxExtended1";
            this.kryptonCheckedListBoxExtended1.OverrideFocus.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonCheckedListBoxExtended1.OverrideFocus.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.kryptonCheckedListBoxExtended1.OverrideFocus.Item.Content.LongText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.OverrideFocus.Item.Content.LongText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.OverrideFocus.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.OverrideFocus.Item.Content.ShortText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.OverrideFocus.Item.Content.ShortText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.OverrideFocus.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.OverrideFocusItemBackgroundColourOne = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonCheckedListBoxExtended1.OverrideFocusItemBackgroundColourTwo = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.kryptonCheckedListBoxExtended1.OverrideFocusLongTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.OverrideFocusLongTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.OverrideFocusShortTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.OverrideFocusShortTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.ShortTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.Size = new System.Drawing.Size(227, 145);
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
            this.kryptonCheckedListBoxExtended1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonCheckedListBoxExtended1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonCheckedListBoxExtended1.StateCommon.Item.Content.LongText.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCommon.Item.Content.LongText.Color2 = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonCheckedListBoxExtended1.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonCheckedListBoxExtended1.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckedListBoxExtended1.StateCommonBackgroundColourOne = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonCheckedListBoxExtended1.StateCommonBackgroundColourTwo = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonCheckedListBoxExtended1.StateCommonItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateCommonItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckedListBoxExtended1.StateCommonLongTextColourOne = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCommonLongTextColourTwo = System.Drawing.SystemColors.ControlText;
            this.kryptonCheckedListBoxExtended1.StateCommonShortTextColourOne = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonCheckedListBoxExtended1.StateCommonShortTextColourTwo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.kryptonCheckedListBoxExtended1.TabIndex = 5;
            // 
            // kryptonCheckButtonExtended1
            // 
            this.kryptonCheckButtonExtended1.Image = null;
            this.kryptonCheckButtonExtended1.Location = new System.Drawing.Point(273, 117);
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
            this.kryptonCheckButtonExtended1.Size = new System.Drawing.Size(178, 25);
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
            this.kryptonCheckButtonExtended1.TabIndex = 3;
            this.kryptonCheckButtonExtended1.Values.Text = "kryptonCheckButtonExtended1";
            // 
            // kryptonCheckBoxExtended1
            // 
            this.kryptonCheckBoxExtended1.Image = null;
            this.kryptonCheckBoxExtended1.Location = new System.Drawing.Point(193, 67);
            this.kryptonCheckBoxExtended1.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckBoxExtended1.Name = "kryptonCheckBoxExtended1";
            this.kryptonCheckBoxExtended1.OverrideFocus.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckBoxExtended1.OverrideFocus.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckBoxExtended1.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.ShortTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckBoxExtended1.Size = new System.Drawing.Size(51, 16);
            this.kryptonCheckBoxExtended1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckBoxExtended1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckBoxExtended1.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateDisabled.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckBoxExtended1.StateDisabled.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckBoxExtended1.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateNormal.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckBoxExtended1.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckBoxExtended1.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.TabIndex = 4;
            // 
            // kryptonColourButtonExtended1
            // 
            this.kryptonColourButtonExtended1.Image = null;
            this.kryptonColourButtonExtended1.Location = new System.Drawing.Point(590, 320);
            this.kryptonColourButtonExtended1.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonColourButtonExtended1.Name = "kryptonColourButtonExtended1";
            this.kryptonColourButtonExtended1.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonColourButtonExtended1.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonColourButtonExtended1.OverrideDefaultBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.OverrideDefaultBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.OverrideDefaultLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.OverrideDefaultLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.OverrideDefaultShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.OverrideDefaultShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonColourButtonExtended1.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonColourButtonExtended1.OverrideFocusBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.OverrideFocusBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.ShortTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonColourButtonExtended1.Size = new System.Drawing.Size(90, 25);
            this.kryptonColourButtonExtended1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonColourButtonExtended1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonColourButtonExtended1.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonColourButtonExtended1.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonColourButtonExtended1.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonColourButtonExtended1.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonColourButtonExtended1.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonColourButtonExtended1.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonColourButtonExtended1.StatePressedBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StatePressedBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StatePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StatePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StatePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StatePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonColourButtonExtended1.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonColourButtonExtended1.StateTrackingBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateTrackingBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateTrackingLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateTrackingLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateTrackingShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.StateTrackingShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonColourButtonExtended1.TabIndex = 8;
            this.kryptonColourButtonExtended1.Values.Text = "kryptonColourButtonExtended1";
            // 
            // StandardControlsExtended
            // 
            this.ClientSize = new System.Drawing.Size(1369, 636);
            this.Controls.Add(this.kryptonColourButtonExtended1);
            this.Controls.Add(this.kryptonButtonExtended1);
            this.Controls.Add(this.kryptonCheckedListBoxExtended1);
            this.Controls.Add(this.kryptonCheckButtonExtended1);
            this.Controls.Add(this.kryptonCheckBoxExtended1);
            this.Name = "StandardControlsExtended";
            this.Load += new System.EventHandler(this.StandardControlsExtended_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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