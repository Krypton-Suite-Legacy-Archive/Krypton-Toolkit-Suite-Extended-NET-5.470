using ColourCreator.ColourTables;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ColourCreator.Classes
{
    sealed class CustomisableColourTable : PresetColourTable, ICloneable
    {
        private static readonly ProfessionalColorTable professionalColourTable =
            new ProfessionalColorTable();

        private Dictionary<ColourTableGroup, Color> defaultColours;

        private Dictionary<ColourTableGroup, Color> colours =
            new Dictionary<ColourTableGroup, Color>();

        public CustomisableColourTable()
            : base(string.Empty)
        {
            InitFromBase(true);
        }

        public Color ResetColour(ColourTableGroup colourGroup)
        {
            Color baseColor = defaultColours[colourGroup];
            colours[colourGroup] = baseColor;
            return baseColor;
        }

        public Color OverrideColour(ColourTableGroup colourGroup, Color colour)
        {
            var old = colours[colourGroup];
            colours[colourGroup] = colour;
            return old;
        }

        public void InitFrom(ProfessionalColorTable colourTable, bool makeColoursDefault)
        {
            // Instead of "colors[ColorTableGroup.ButtonSelectedBorder] = colorTable.ButtonSelectedBorder"...
            // use reflection.
            Type colorTableType = colourTable.GetType();
            Type colorTableGroupType = typeof(ColourTableGroup);
            foreach (ColourTableGroup colorTableGroup in Enum.GetValues(colorTableGroupType))
            {
                var prop = colorTableType.GetProperty(Enum.GetName(colorTableGroupType, colorTableGroup));
                if (prop != null)
                    colours[colorTableGroup] = (Color)prop.GetValue(colourTable, null);
            }

            if (makeColoursDefault)
                MakeColorsDefault();
        }

        public void InitFromBase(bool makeColoursDefault)
        {
            // Instead of " colors[ColorTableGroup.ButtonSelectedBorder] = base.ButtonSelectedBorder"...
            // use reflection.
            Type colorTableType = professionalColourTable.GetType();
            Type colorTableGroupType = typeof(ColourTableGroup);
            foreach (ColourTableGroup colorTableGroup in Enum.GetValues(colorTableGroupType))
            {
                switch (colorTableGroup)
                {
                    case ColourTableGroup.FormForeColour:
                    case ColourTableGroup.FormBackColour:
                    case ColourTableGroup.GridGridColour:
                    case ColourTableGroup.GridBackColour:
                        {
                            var name = Enum.GetName(colorTableGroupType, colorTableGroup);
                            try
                            {
                                var prop = colorTableType.GetProperty(name);
                                colours[colorTableGroup] = (Color)prop.GetValue(professionalColourTable, null);
                            }
                            catch
                            {
                                colours[colorTableGroup] = Color.Black;
                            }
                            break;
                        }
                    default:
                        {
                            var prop = colorTableType.GetProperty(Enum.GetName(colorTableGroupType, colorTableGroup));
                            colours[colorTableGroup] = (Color)prop.GetValue(professionalColourTable, null);
                            break;
                        }
                }
            }

            if (makeColoursDefault)
                MakeColorsDefault();
        }

        public void MakeColorsDefault()
        {
            defaultColours = new Dictionary<ColourTableGroup, Color>(colours);
        }

        public Color this[ColourTableGroup colourGroup]
        {
            get { return colours[colourGroup]; }
            set { colours[colourGroup] = value; }
        }

        public Color FormForeColour { get { return colours[ColourTableGroup.FormForeColour]; } }
        public Color FormBackColour { get { return colours[ColourTableGroup.FormBackColour]; } }
        public Color GridGridColour { get { return colours[ColourTableGroup.GridGridColour]; } }
        public Color GridBackColour { get { return colours[ColourTableGroup.GridBackColour]; } }

        public override Color ButtonSelectedBorder
        {
            get
            {
                return colours[ColourTableGroup.ButtonSelectedBorder];
            }
        }

        public override Color ButtonCheckedGradientBegin
        {
            get
            {
                return colours[ColourTableGroup.ButtonCheckedGradientBegin];
            }
        }

        public override Color ButtonCheckedGradientMiddle
        {
            get
            {
                return colours[ColourTableGroup.ButtonCheckedGradientMiddle];
            }
        }

        public override Color ButtonCheckedGradientEnd
        {
            get
            {
                return colours[ColourTableGroup.ButtonCheckedGradientEnd];
            }
        }

        public override Color ButtonSelectedGradientBegin
        {
            get
            {
                return colours[ColourTableGroup.ButtonSelectedGradientBegin];
            }
        }

        public override Color ButtonSelectedGradientMiddle
        {
            get
            {
                return colours[ColourTableGroup.ButtonSelectedGradientMiddle];
            }
        }

        public override Color ButtonSelectedGradientEnd
        {
            get
            {
                return colours[ColourTableGroup.ButtonSelectedGradientEnd];
            }
        }

        public override Color ButtonPressedGradientBegin
        {
            get
            {
                return colours[ColourTableGroup.ButtonPressedGradientBegin];
            }
        }

        public override Color ButtonPressedGradientMiddle
        {
            get
            {
                return colours[ColourTableGroup.ButtonPressedGradientMiddle];
            }
        }

        public override Color ButtonPressedGradientEnd
        {
            get
            {
                return colours[ColourTableGroup.ButtonPressedGradientEnd];
            }
        }

        public override Color CheckBackground
        {
            get
            {
                return colours[ColourTableGroup.CheckBackground];
            }
        }

        public override Color CheckSelectedBackground
        {
            get
            {
                return colours[ColourTableGroup.CheckSelectedBackground];
            }
        }

        public override Color CheckPressedBackground
        {
            get
            {
                return colours[ColourTableGroup.CheckPressedBackground];
            }
        }

        public override Color GripDark
        {
            get
            {
                return colours[ColourTableGroup.GripDark];
            }
        }

        public override Color GripLight
        {
            get
            {
                return colours[ColourTableGroup.GripLight];
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return colours[ColourTableGroup.ImageMarginGradientBegin];
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return colours[ColourTableGroup.ImageMarginGradientMiddle];
            }
        }

        public override Color ImageMarginGradientEnd
        {
            get
            {
                return colours[ColourTableGroup.ImageMarginGradientEnd];
            }
        }

        public override Color ImageMarginRevealedGradientBegin
        {
            get
            {
                return colours[ColourTableGroup.ImageMarginRevealedGradientBegin];
            }
        }

        public override Color ImageMarginRevealedGradientMiddle
        {
            get
            {
                return colours[ColourTableGroup.ImageMarginRevealedGradientMiddle];
            }
        }

        public override Color ImageMarginRevealedGradientEnd
        {
            get
            {
                return colours[ColourTableGroup.ImageMarginRevealedGradientEnd];
            }
        }

        public override Color MenuStripGradientBegin
        {
            get
            {
                return colours[ColourTableGroup.MenuStripGradientBegin];
            }
        }

        public override Color MenuStripGradientEnd
        {
            get
            {
                return colours[ColourTableGroup.MenuStripGradientEnd];
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return colours[ColourTableGroup.MenuItemSelected];
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return colours[ColourTableGroup.MenuItemBorder];
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return colours[ColourTableGroup.MenuBorder];
            }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return colours[ColourTableGroup.MenuItemSelectedGradientBegin];
            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return colours[ColourTableGroup.MenuItemSelectedGradientEnd];
            }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return colours[ColourTableGroup.MenuItemPressedGradientBegin];
            }
        }

        public override Color MenuItemPressedGradientMiddle
        {
            get
            {
                return colours[ColourTableGroup.MenuItemPressedGradientMiddle];
            }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return colours[ColourTableGroup.MenuItemPressedGradientEnd];
            }
        }

        public override Color RaftingContainerGradientBegin
        {
            get
            {
                return colours[ColourTableGroup.RaftingContainerGradientBegin];
            }
        }

        public override Color RaftingContainerGradientEnd
        {
            get
            {
                return colours[ColourTableGroup.RaftingContainerGradientEnd];
            }
        }

        public override Color SeparatorDark
        {
            get
            {
                return colours[ColourTableGroup.SeparatorDark];
            }
        }

        public override Color SeparatorLight
        {
            get
            {
                return colours[ColourTableGroup.SeparatorLight];
            }
        }

        public override Color StatusStripGradientBegin
        {
            get
            {
                return colours[ColourTableGroup.StatusStripGradientBegin];
            }
        }

        public override Color StatusStripGradientEnd
        {
            get
            {
                return colours[ColourTableGroup.StatusStripGradientEnd];
            }
        }

        public override Color ToolStripBorder
        {
            get
            {
                return colours[ColourTableGroup.ToolStripBorder];
            }
        }

        public override Color ToolStripDropDownBackground
        {
            get
            {
                return colours[ColourTableGroup.ToolStripDropDownBackground];
            }
        }

        public override Color ToolStripGradientBegin
        {
            get
            {
                return colours[ColourTableGroup.ToolStripGradientBegin];
            }
        }

        public override Color ToolStripGradientMiddle
        {
            get
            {
                return colours[ColourTableGroup.ToolStripGradientMiddle];
            }
        }

        public override Color ToolStripGradientEnd
        {
            get
            {
                return colours[ColourTableGroup.ToolStripGradientEnd];
            }
        }

        public override Color ToolStripContentPanelGradientBegin
        {
            get
            {
                return colours[ColourTableGroup.ToolStripContentPanelGradientBegin];
            }
        }

        public override Color ToolStripContentPanelGradientEnd
        {
            get
            {
                return colours[ColourTableGroup.ToolStripContentPanelGradientEnd];
            }
        }

        public override Color ToolStripPanelGradientBegin
        {
            get
            {
                return colours[ColourTableGroup.ToolStripPanelGradientBegin];
            }
        }

        public override Color ToolStripPanelGradientEnd
        {
            get
            {
                return colours[ColourTableGroup.ToolStripPanelGradientEnd];
            }
        }

        public override Color OverflowButtonGradientBegin
        {
            get
            {
                return colours[ColourTableGroup.OverflowButtonGradientBegin];
            }
        }

        public override Color OverflowButtonGradientMiddle
        {
            get
            {
                return colours[ColourTableGroup.OverflowButtonGradientMiddle];
            }
        }

        public override Color OverflowButtonGradientEnd
        {
            get
            {
                return colours[ColourTableGroup.OverflowButtonGradientEnd];
            }
        }

        #region Implementation of ICloneable

        public object Clone()
        {
            CustomisableColourTable clone = (CustomisableColourTable)MemberwiseClone();
            clone.colours = new Dictionary<ColourTableGroup, Color>(clone.colours);
            return clone;
        }

        #endregion
    }

    enum ColourTableGroup
    {
        ButtonSelectedBorder,
        ButtonCheckedGradientBegin,
        ButtonCheckedGradientMiddle,
        ButtonCheckedGradientEnd,
        ButtonSelectedGradientBegin,
        ButtonSelectedGradientMiddle,
        ButtonSelectedGradientEnd,
        ButtonPressedGradientBegin,
        ButtonPressedGradientMiddle,
        ButtonPressedGradientEnd,
        CheckBackground,
        CheckSelectedBackground,
        CheckPressedBackground,
        GripDark,
        GripLight,
        ImageMarginGradientBegin,
        ImageMarginGradientMiddle,
        ImageMarginGradientEnd,
        ImageMarginRevealedGradientBegin,
        ImageMarginRevealedGradientMiddle,
        ImageMarginRevealedGradientEnd,
        MenuStripGradientBegin,
        MenuStripGradientEnd,
        MenuItemSelected,
        MenuItemBorder,
        MenuBorder,
        MenuItemSelectedGradientBegin,
        MenuItemSelectedGradientEnd,
        MenuItemPressedGradientBegin,
        MenuItemPressedGradientMiddle,
        MenuItemPressedGradientEnd,
        RaftingContainerGradientBegin,
        RaftingContainerGradientEnd,
        SeparatorDark,
        SeparatorLight,
        StatusStripGradientBegin,
        StatusStripGradientEnd,
        ToolStripBorder,
        ToolStripDropDownBackground,
        ToolStripGradientBegin,
        ToolStripGradientMiddle,
        ToolStripGradientEnd,
        ToolStripContentPanelGradientBegin,
        ToolStripContentPanelGradientEnd,
        ToolStripPanelGradientBegin,
        ToolStripPanelGradientEnd,
        OverflowButtonGradientBegin,
        OverflowButtonGradientMiddle,
        OverflowButtonGradientEnd,

        FormForeColour,
        FormBackColour,
        GridGridColour,
        GridBackColour,
    }
}