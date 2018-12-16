using System.Drawing;

namespace ColourComposer.Classes.ColourTables
{
    sealed class SystemColourTable : PresetColourTable
    {
        public SystemColourTable()
            : base("System Colours")
        {
        }

        public override Color ButtonSelectedBorder
        {
            get
            {
                return Color.FromName("ButtonShadow");
            }
        }
        public override Color ButtonCheckedGradientBegin
        {
            get
            {
                return Color.FromName("ButtonFace");
            }
        }
        public override Color ButtonCheckedGradientMiddle
        {
            get
            {
                return Color.FromName("ButtonFace");
            }
        }
        public override Color ButtonCheckedGradientEnd
        {
            get
            {
                return Color.FromName("ButtonHighlight");
            }
        }
        public override Color ButtonSelectedGradientBegin
        {
            get
            {
                return Color.FromName("ButtonHighlight");
            }
        }
        public override Color ButtonSelectedGradientMiddle
        {
            get
            {
                return Color.FromName("ButtonHighlight");
            }
        }
        public override Color ButtonSelectedGradientEnd
        {
            get
            {
                return Color.FromName("ButtonFace");
            }
        }
        public override Color ButtonPressedGradientBegin
        {
            get
            {
                return Color.FromName("ButtonFace");
            }
        }
        public override Color ButtonPressedGradientMiddle
        {
            get
            {
                return Color.FromName("ButtonFace");
            }
        }
        public override Color ButtonPressedGradientEnd
        {
            get
            {
                return Color.FromName("ButtonHighlight");
            }
        }
        public override Color CheckBackground
        {
            get
            {
                return Color.FromName("Menu");
            }
        }
        public override Color CheckSelectedBackground
        {
            get
            {
                return Color.FromName("Menu");
            }
        }
        public override Color CheckPressedBackground
        {
            get
            {
                return Color.FromName("MenuHighlight");
            }
        }
        public override Color GripDark
        {
            get
            {
                return Color.FromName("ControlDark");
            }
        }
        public override Color GripLight
        {
            get
            {
                return Color.FromName("ControlLight");
            }
        }
        public override Color ImageMarginGradientBegin
        {
            get
            {
                return Color.FromName("ControlLight");
            }
        }
        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return Color.FromName("ControlLight");
            }
        }
        public override Color ImageMarginGradientEnd
        {
            get
            {
                return Color.FromName("ControlLight");
            }
        }
        public override Color ImageMarginRevealedGradientBegin
        {
            get
            {
                return Color.FromName("ControlLightLight");
            }
        }
        public override Color ImageMarginRevealedGradientMiddle
        {
            get
            {
                return Color.FromName("ControlLightLight");
            }
        }
        public override Color ImageMarginRevealedGradientEnd
        {
            get
            {
                return Color.FromName("Menu");
            }
        }
        public override Color MenuStripGradientBegin
        {
            get
            {
                return Color.FromName("ControlLight");
            }
        }
        public override Color MenuStripGradientEnd
        {
            get
            {
                return Color.FromName("ControlLight");
            }
        }
        public override Color MenuItemSelected
        {
            get
            {
                return Color.FromName("MenuHighlight");
            }
        }
        public override Color MenuItemBorder
        {
            get
            {
                return Color.FromArgb(0, 0, 0, 0);
            }
        }
        public override Color MenuBorder
        {
            get
            {
                return Color.FromName("ControlDark");
            }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return Color.FromName("MenuHighlight");
            }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return Color.FromName("MenuHighlight");
            }
        }
        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return Color.FromName("Menu");
            }
        }
        public override Color MenuItemPressedGradientMiddle
        {
            get
            {
                return Color.FromName("Menu");
            }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return Color.FromName("Menu");
            }
        }
        public override Color RaftingContainerGradientBegin
        {
            get
            {
                return Color.FromName("Control");
            }
        }
        public override Color RaftingContainerGradientEnd
        {
            get
            {
                return Color.FromName("Control");
            }
        }
        public override Color SeparatorDark
        {
            get
            {
                return Color.FromName("ActiveBorder");
            }
        }
        public override Color SeparatorLight
        {
            get
            {
                return Color.FromName("Control");
            }
        }
        public override Color StatusStripGradientBegin
        {
            get
            {
                return Color.FromName("ControlLight");
            }
        }
        public override Color StatusStripGradientEnd
        {
            get
            {
                return Color.FromName("Control");
            }
        }
        public override Color ToolStripBorder
        {
            get
            {
                return Color.FromName("ControlDark");
            }
        }
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return Color.FromName("Menu");
            }
        }
        public override Color ToolStripGradientBegin
        {
            get
            {
                return Color.FromName("MenuBar");
            }
        }
        public override Color ToolStripGradientMiddle
        {
            get
            {
                return Color.FromName("MenuBar");
            }
        }
        public override Color ToolStripGradientEnd
        {
            get
            {
                return Color.FromName("MenuBar");
            }
        }
        public override Color ToolStripContentPanelGradientBegin
        {
            get
            {
                return Color.FromName("AppWorkspace");
            }
        }
        public override Color ToolStripContentPanelGradientEnd
        {
            get
            {
                return Color.FromName("AppWorkspace");
            }
        }
        public override Color ToolStripPanelGradientBegin
        {
            get
            {
                return Color.FromName("ControlLight");
            }
        }
        public override Color ToolStripPanelGradientEnd
        {
            get
            {
                return Color.FromName("Control");
            }
        }
        public override Color OverflowButtonGradientBegin
        {
            get
            {
                return Color.FromName("ControlLightLight");
            }
        }
        public override Color OverflowButtonGradientMiddle
        {
            get
            {
                return Color.FromName("ControlLight");
            }
        }
        public override Color OverflowButtonGradientEnd
        {
            get
            {
                return Color.FromName("Control");
            }
        }
    }
}