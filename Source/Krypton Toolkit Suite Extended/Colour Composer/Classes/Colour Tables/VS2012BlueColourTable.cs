using System.Drawing;

namespace ColourComposer.Classes.ColourTables
{
    sealed class VS2012BlueColourTable : PresetColourTable
    {
        public VS2012BlueColourTable()
            : base("Visual Studio 2012 Blue")
        {
        }

        public override Color ButtonSelectedHighlight
        {
            get { return ButtonSelectedGradientMiddle; }
        }
        public override Color ButtonSelectedHighlightBorder
        {
            get { return ButtonSelectedBorder; }
        }
        public override Color ButtonPressedHighlight
        {
            get { return ButtonPressedGradientMiddle; }
        }
        public override Color ButtonPressedHighlightBorder
        {
            get { return ButtonPressedBorder; }
        }
        public override Color ButtonCheckedHighlight
        {
            get { return ButtonCheckedGradientMiddle; }
        }
        public override Color ButtonCheckedHighlightBorder
        {
            get { return ButtonSelectedBorder; }
        }
        public override Color ButtonPressedBorder
        {
            get { return ButtonSelectedBorder; }
        }
        public override Color ButtonSelectedBorder
        {
            get { return Color.FromArgb(255, 229, 195, 101); }
        }
        public override Color ButtonCheckedGradientBegin
        {
            get { return Color.FromArgb(255, 255, 240, 208); }
        }
        public override Color ButtonCheckedGradientMiddle
        {
            get { return Color.FromArgb(255, 255, 240, 208); }
        }
        public override Color ButtonCheckedGradientEnd
        {
            get { return Color.FromArgb(255, 255, 240, 208); }
        }
        public override Color ButtonSelectedGradientBegin
        {
            get { return Color.FromArgb(255, 255, 240, 208); }
        }
        public override Color ButtonSelectedGradientMiddle
        {
            get { return Color.FromArgb(255, 255, 240, 208); }
        }
        public override Color ButtonSelectedGradientEnd
        {
            get { return Color.FromArgb(255, 255, 240, 208); }
        }
        public override Color ButtonPressedGradientBegin
        {
            get { return Color.FromArgb(255, 255, 230, 176); }
        }
        public override Color ButtonPressedGradientMiddle
        {
            get { return Color.FromArgb(255, 255, 230, 176); }
        }
        public override Color ButtonPressedGradientEnd
        {
            get { return Color.FromArgb(255, 255, 230, 176); }
        }
        public override Color CheckBackground
        {
            get { return Color.FromArgb(255, 255, 240, 208); }
        }
        public override Color CheckSelectedBackground
        {
            get { return Color.FromArgb(255, 255, 240, 208); }
        }
        public override Color CheckPressedBackground
        {
            get { return Color.FromArgb(255, 255, 230, 176); }
        }
        public override Color GripDark
        {
            get { return Color.FromArgb(0, 0, 0, 0); }
        }
        public override Color GripLight
        {
            get { return Color.FromArgb(255, 96, 114, 140); }
        }
        public override Color ImageMarginGradientBegin
        {
            get { return Color.FromArgb(255, 232, 236, 238); }
        }
        public override Color ImageMarginGradientMiddle
        {
            get { return Color.FromArgb(255, 232, 236, 238); }
        }
        public override Color ImageMarginGradientEnd
        {
            get { return Color.FromArgb(255, 232, 236, 238); }
        }
        public override Color ImageMarginRevealedGradientBegin
        {
            get { return Color.FromArgb(255, 232, 236, 238); }
        }
        public override Color ImageMarginRevealedGradientMiddle
        {
            get { return Color.FromArgb(255, 232, 236, 238); }
        }
        public override Color ImageMarginRevealedGradientEnd
        {
            get { return Color.FromArgb(255, 232, 236, 238); }
        }
        public override Color MenuStripGradientBegin
        {
            get { return Color.FromArgb(255, 214, 219, 233); }
        }
        public override Color MenuStripGradientEnd
        {
            get { return Color.FromArgb(255, 214, 219, 233); }
        }
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(255, 255, 240, 208); }
        }
        public override Color MenuItemBorder
        {
            get { return Color.FromArgb(255, 229, 195, 101); }
        }
        public override Color MenuBorder
        {
            get { return Color.FromArgb(255, 155, 167, 183); }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.FromArgb(255, 255, 240, 208); }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.FromArgb(255, 255, 240, 208); }
        }
        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.FromArgb(255, 232, 236, 238); }
        }
        public override Color MenuItemPressedGradientMiddle
        {
            get { return Color.FromArgb(255, 232, 236, 238); }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.FromArgb(255, 232, 236, 238); }
        }
        public override Color RaftingContainerGradientBegin
        {
            get { return Color.FromArgb(255, 220, 224, 236); }
        }
        public override Color RaftingContainerGradientEnd
        {
            get { return Color.FromArgb(255, 220, 224, 236); }
        }
        public override Color SeparatorDark
        {
            get { return Color.FromArgb(255, 204, 206, 219); }
        }
        public override Color SeparatorLight
        {
            get { return Color.FromArgb(255, 246, 246, 246); }
        }
        public override Color StatusStripGradientBegin
        {
            get { return Color.FromArgb(255, 111, 145, 196); }
        }
        public override Color StatusStripGradientEnd
        {
            get { return Color.FromArgb(255, 111, 145, 196); }
        }
        public override Color ToolStripBorder
        {
            get { return Color.FromArgb(255, 220, 224, 236); }
        }
        public override Color ToolStripDropDownBackground
        {
            get { return Color.FromArgb(255, 232, 236, 238); }
        }
        public override Color ToolStripGradientBegin
        {
            get { return Color.FromArgb(255, 214, 219, 233); }
        }
        public override Color ToolStripGradientMiddle
        {
            get { return Color.FromArgb(255, 214, 219, 233); }
        }
        public override Color ToolStripGradientEnd
        {
            get { return Color.FromArgb(255, 214, 219, 233); }
        }
        public override Color ToolStripContentPanelGradientBegin
        {
            get { return Color.FromArgb(255, 220, 224, 236); }
        }
        public override Color ToolStripContentPanelGradientEnd
        {
            get { return Color.FromArgb(255, 220, 224, 236); }
        }
        public override Color ToolStripPanelGradientBegin
        {
            get { return Color.FromArgb(255, 214, 219, 233); }
        }
        public override Color ToolStripPanelGradientEnd
        {
            get { return Color.FromArgb(255, 214, 219, 233); }
        }
        public override Color OverflowButtonGradientBegin
        {
            get { return Color.FromArgb(255, 220, 224, 236); }
        }
        public override Color OverflowButtonGradientMiddle
        {
            get { return Color.FromArgb(255, 220, 224, 236); }
        }
        public override Color OverflowButtonGradientEnd
        {
            get { return Color.FromArgb(255, 220, 224, 236); }
        }
    }
}