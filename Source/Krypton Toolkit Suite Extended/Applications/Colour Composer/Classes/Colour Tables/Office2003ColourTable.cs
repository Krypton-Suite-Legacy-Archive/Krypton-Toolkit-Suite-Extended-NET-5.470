using System.Drawing;

namespace ColourComposer.Classes.ColourTables
{
    sealed class Office2003ColourTable : PresetColourTable
    {
        public Office2003ColourTable() : base("Office 2003 Blue")
        {
        }

        public override Color ButtonSelectedBorder
        {
            get
            {
                return Color.FromArgb(255, 0, 0, 128);
            }
        }
        public override Color ButtonCheckedGradientBegin
        {
            get
            {
                return Color.FromArgb(255, 255, 223, 154);
            }
        }
        public override Color ButtonCheckedGradientMiddle
        {
            get
            {
                return Color.FromArgb(255, 255, 195, 116);
            }
        }
        public override Color ButtonCheckedGradientEnd
        {
            get
            {
                return Color.FromArgb(255, 255, 166, 76);
            }
        }
        public override Color ButtonSelectedGradientBegin
        {
            get
            {
                return Color.FromArgb(255, 255, 255, 222);
            }
        }
        public override Color ButtonSelectedGradientMiddle
        {
            get
            {
                return Color.FromArgb(255, 255, 225, 172);
            }
        }
        public override Color ButtonSelectedGradientEnd
        {
            get
            {
                return Color.FromArgb(255, 255, 203, 136);
            }
        }
        public override Color ButtonPressedGradientBegin
        {
            get
            {
                return Color.FromArgb(255, 254, 128, 62);
            }
        }
        public override Color ButtonPressedGradientMiddle
        {
            get
            {
                return Color.FromArgb(255, 255, 177, 109);
            }
        }
        public override Color ButtonPressedGradientEnd
        {
            get
            {
                return Color.FromArgb(255, 255, 223, 154);
            }
        }
        public override Color CheckBackground
        {
            get
            {
                return Color.FromArgb(255, 255, 192, 111);
            }
        }
        public override Color CheckSelectedBackground
        {
            get
            {
                return Color.FromArgb(255, 254, 128, 62);
            }
        }
        public override Color CheckPressedBackground
        {
            get
            {
                return Color.FromArgb(255, 254, 128, 62);
            }
        }
        public override Color GripDark
        {
            get
            {
                return Color.FromArgb(255, 39, 65, 118);
            }
        }
        public override Color GripLight
        {
            get
            {
                return Color.FromArgb(255, 255, 255, 255);
            }
        }
        public override Color ImageMarginGradientBegin
        {
            get
            {
                return Color.FromArgb(255, 227, 239, 255);
            }
        }
        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return Color.FromArgb(255, 203, 225, 252);
            }
        }
        public override Color ImageMarginGradientEnd
        {
            get
            {
                return Color.FromArgb(255, 123, 164, 224);
            }
        }
        public override Color ImageMarginRevealedGradientBegin
        {
            get
            {
                return Color.FromArgb(255, 203, 221, 246);
            }
        }
        public override Color ImageMarginRevealedGradientMiddle
        {
            get
            {
                return Color.FromArgb(255, 161, 197, 249);
            }
        }
        public override Color ImageMarginRevealedGradientEnd
        {
            get
            {
                return Color.FromArgb(255, 114, 155, 215);
            }
        }
        public override Color MenuStripGradientBegin
        {
            get
            {
                return Color.FromArgb(255, 158, 190, 245);
            }
        }
        public override Color MenuStripGradientEnd
        {
            get
            {
                return Color.FromArgb(255, 196, 218, 250);
            }
        }
        public override Color MenuItemSelected
        {
            get
            {
                return Color.FromArgb(255, 255, 238, 194);
            }
        }
        public override Color MenuItemBorder
        {
            get
            {
                return Color.FromArgb(255, 0, 0, 128);
            }
        }
        public override Color MenuBorder
        {
            get
            {
                return Color.FromArgb(255, 0, 45, 150);
            }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return Color.FromArgb(255, 255, 255, 222);
            }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return Color.FromArgb(255, 255, 203, 136);
            }
        }
        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return Color.FromArgb(255, 227, 239, 255);
            }
        }
        public override Color MenuItemPressedGradientMiddle
        {
            get
            {
                return Color.FromArgb(255, 161, 197, 249);
            }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return Color.FromArgb(255, 123, 164, 224);
            }
        }
        public override Color RaftingContainerGradientBegin
        {
            get
            {
                return Color.FromArgb(255, 158, 190, 245);
            }
        }
        public override Color RaftingContainerGradientEnd
        {
            get
            {
                return Color.FromArgb(255, 196, 218, 250);
            }
        }
        public override Color SeparatorDark
        {
            get
            {
                return Color.FromArgb(255, 106, 140, 203);
            }
        }
        public override Color SeparatorLight
        {
            get
            {
                return Color.FromArgb(255, 241, 249, 255);
            }
        }
        public override Color StatusStripGradientBegin
        {
            get
            {
                return Color.FromArgb(255, 158, 190, 245);
            }
        }
        public override Color StatusStripGradientEnd
        {
            get
            {
                return Color.FromArgb(255, 196, 218, 250);
            }
        }
        public override Color ToolStripBorder
        {
            get
            {
                return Color.FromArgb(255, 59, 97, 156);
            }
        }
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return Color.FromArgb(255, 246, 246, 246);
            }
        }
        public override Color ToolStripGradientBegin
        {
            get
            {
                return Color.FromArgb(255, 227, 239, 255);
            }
        }
        public override Color ToolStripGradientMiddle
        {
            get
            {
                return Color.FromArgb(255, 203, 225, 252);
            }
        }
        public override Color ToolStripGradientEnd
        {
            get
            {
                return Color.FromArgb(255, 123, 164, 224);
            }
        }
        public override Color ToolStripContentPanelGradientBegin
        {
            get
            {
                return Color.FromArgb(255, 158, 190, 245);
            }
        }
        public override Color ToolStripContentPanelGradientEnd
        {
            get
            {
                return Color.FromArgb(255, 196, 218, 250);
            }
        }
        public override Color ToolStripPanelGradientBegin
        {
            get
            {
                return Color.FromArgb(255, 158, 190, 245);
            }
        }
        public override Color ToolStripPanelGradientEnd
        {
            get
            {
                return Color.FromArgb(255, 196, 218, 250);
            }
        }
        public override Color OverflowButtonGradientBegin
        {
            get
            {
                return Color.FromArgb(255, 127, 177, 250);
            }
        }
        public override Color OverflowButtonGradientMiddle
        {
            get
            {
                return Color.FromArgb(255, 82, 127, 208);
            }
        }
        public override Color OverflowButtonGradientEnd
        {
            get
            {
                return Color.FromArgb(255, 0, 53, 145);
            }
        }
    }
}