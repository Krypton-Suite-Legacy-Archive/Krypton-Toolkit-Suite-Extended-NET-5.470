using ColourComposer.Classes.ColourTables;
using ColourComposer.Enumerations;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ColourComposer.Classes
{
    sealed class CustomisableColourTable : PresetColourTable, ICloneable
    {
        private static readonly ProfessionalColorTable _professionalColourTable =
            new ProfessionalColorTable();

        private Dictionary<ColourTableGroup, Color> _defaultColours;

        private Dictionary<ColourTableGroup, Color> _colours =
            new Dictionary<ColourTableGroup, Color>();

        public CustomisableColourTable()
            : base(string.Empty)
        {
            InitFromBase(true);
        }

        public Color ResetColour(ColourTableGroup colourGroup)
        {
            Color baseColour = _defaultColours[colourGroup];
            _colours[colourGroup] = baseColour;
            return baseColour;
        }

        public Color OverrideColour(ColourTableGroup colourGroup, Color colour)
        {
            var old = _colours[colourGroup];
            _colours[colourGroup] = colour;
            return old;
        }

        public void InitFrom(ProfessionalColorTable colourTable, bool makeColoursDefault)
        {
            // Instead of "colors[ColorTableGroup.ButtonSelectedBorder] = colorTable.ButtonSelectedBorder"...
            // use reflection.
            Type colourTableType = colourTable.GetType();
            Type colourTableGroupType = typeof(ColourTableGroup);
            foreach (ColourTableGroup colourTableGroup in Enum.GetValues(colourTableGroupType))
            {
                var prop = colourTableType.GetProperty(Enum.GetName(colourTableGroupType, colourTableGroup));
                if (prop != null)
                    _colours[colourTableGroup] = (Color)prop.GetValue(colourTable, null);
            }

            if (makeColoursDefault)
                MakeColorsDefault();
        }

        public void InitFromBase(bool makeColoursDefault)
        {
            // Instead of " colors[ColorTableGroup.ButtonSelectedBorder] = base.ButtonSelectedBorder"...
            // use reflection.
            Type colourTableType = _professionalColourTable.GetType();
            Type colourTableGroupType = typeof(ColourTableGroup);
            foreach (ColourTableGroup colourTableGroup in Enum.GetValues(colourTableGroupType))
            {
                switch (colourTableGroup)
                {
                    case ColourTableGroup.FormForeColour:
                    case ColourTableGroup.FormBackColour:
                    case ColourTableGroup.GridGridColour:
                    case ColourTableGroup.GridBackColour:
                        {
                            var name = Enum.GetName(colourTableGroupType, colourTableGroup);
                            try
                            {
                                var prop = colourTableType.GetProperty(name);
                                _colours[colourTableGroup] = (Color)prop.GetValue(_professionalColourTable, null);
                            }
                            catch
                            {
                                _colours[colourTableGroup] = Color.Black;
                            }
                            break;
                        }
                    default:
                        {
                            var prop = colourTableType.GetProperty(Enum.GetName(colourTableGroupType, colourTableGroup));
                            _colours[colourTableGroup] = (Color)prop.GetValue(_professionalColourTable, null);
                            break;
                        }
                }
            }

            if (makeColoursDefault)
                MakeColorsDefault();
        }

        public void MakeColorsDefault()
        {
            _defaultColours = new Dictionary<ColourTableGroup, Color>(_colours);
        }

        public Color this[ColourTableGroup colourGroup]
        {
            get { return _colours[colourGroup]; }
            set { _colours[colourGroup] = value; }
        }

        public Color FormForeColour { get { return _colours[ColourTableGroup.FormForeColour]; } }
        public Color FormBackColour { get { return _colours[ColourTableGroup.FormBackColour]; } }
        public Color GridGridColour { get { return _colours[ColourTableGroup.GridGridColour]; } }
        public Color GridBackColour { get { return _colours[ColourTableGroup.GridBackColour]; } }

        public override Color ButtonSelectedBorder
        {
            get
            {
                return _colours[ColourTableGroup.ButtonSelectedBorder];
            }
        }

        public override Color ButtonCheckedGradientBegin
        {
            get
            {
                return _colours[ColourTableGroup.ButtonCheckedGradientBegin];
            }
        }

        public override Color ButtonCheckedGradientMiddle
        {
            get
            {
                return _colours[ColourTableGroup.ButtonCheckedGradientMiddle];
            }
        }

        public override Color ButtonCheckedGradientEnd
        {
            get
            {
                return _colours[ColourTableGroup.ButtonCheckedGradientEnd];
            }
        }

        public override Color ButtonSelectedGradientBegin
        {
            get
            {
                return _colours[ColourTableGroup.ButtonSelectedGradientBegin];
            }
        }

        public override Color ButtonSelectedGradientMiddle
        {
            get
            {
                return _colours[ColourTableGroup.ButtonSelectedGradientMiddle];
            }
        }

        public override Color ButtonSelectedGradientEnd
        {
            get
            {
                return _colours[ColourTableGroup.ButtonSelectedGradientEnd];
            }
        }

        public override Color ButtonPressedGradientBegin
        {
            get
            {
                return _colours[ColourTableGroup.ButtonPressedGradientBegin];
            }
        }

        public override Color ButtonPressedGradientMiddle
        {
            get
            {
                return _colours[ColourTableGroup.ButtonPressedGradientMiddle];
            }
        }

        public override Color ButtonPressedGradientEnd
        {
            get
            {
                return _colours[ColourTableGroup.ButtonPressedGradientEnd];
            }
        }

        public override Color CheckBackground
        {
            get
            {
                return _colours[ColourTableGroup.CheckBackground];
            }
        }

        public override Color CheckSelectedBackground
        {
            get
            {
                return _colours[ColourTableGroup.CheckSelectedBackground];
            }
        }

        public override Color CheckPressedBackground
        {
            get
            {
                return _colours[ColourTableGroup.CheckPressedBackground];
            }
        }

        public override Color GripDark
        {
            get
            {
                return _colours[ColourTableGroup.GripDark];
            }
        }

        public override Color GripLight
        {
            get
            {
                return _colours[ColourTableGroup.GripLight];
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return _colours[ColourTableGroup.ImageMarginGradientBegin];
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return _colours[ColourTableGroup.ImageMarginGradientMiddle];
            }
        }

        public override Color ImageMarginGradientEnd
        {
            get
            {
                return _colours[ColourTableGroup.ImageMarginGradientEnd];
            }
        }

        public override Color ImageMarginRevealedGradientBegin
        {
            get
            {
                return _colours[ColourTableGroup.ImageMarginRevealedGradientBegin];
            }
        }

        public override Color ImageMarginRevealedGradientMiddle
        {
            get
            {
                return _colours[ColourTableGroup.ImageMarginRevealedGradientMiddle];
            }
        }

        public override Color ImageMarginRevealedGradientEnd
        {
            get
            {
                return _colours[ColourTableGroup.ImageMarginRevealedGradientEnd];
            }
        }

        public override Color MenuStripGradientBegin
        {
            get
            {
                return _colours[ColourTableGroup.MenuStripGradientBegin];
            }
        }

        public override Color MenuStripGradientEnd
        {
            get
            {
                return _colours[ColourTableGroup.MenuStripGradientEnd];
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return _colours[ColourTableGroup.MenuItemSelected];
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return _colours[ColourTableGroup.MenuItemBorder];
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return _colours[ColourTableGroup.MenuBorder];
            }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return _colours[ColourTableGroup.MenuItemSelectedGradientBegin];
            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return _colours[ColourTableGroup.MenuItemSelectedGradientEnd];
            }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return _colours[ColourTableGroup.MenuItemPressedGradientBegin];
            }
        }

        public override Color MenuItemPressedGradientMiddle
        {
            get
            {
                return _colours[ColourTableGroup.MenuItemPressedGradientMiddle];
            }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return _colours[ColourTableGroup.MenuItemPressedGradientEnd];
            }
        }

        public override Color RaftingContainerGradientBegin
        {
            get
            {
                return _colours[ColourTableGroup.RaftingContainerGradientBegin];
            }
        }

        public override Color RaftingContainerGradientEnd
        {
            get
            {
                return _colours[ColourTableGroup.RaftingContainerGradientEnd];
            }
        }

        public override Color SeparatorDark
        {
            get
            {
                return _colours[ColourTableGroup.SeparatorDark];
            }
        }

        public override Color SeparatorLight
        {
            get
            {
                return _colours[ColourTableGroup.SeparatorLight];
            }
        }

        public override Color StatusStripGradientBegin
        {
            get
            {
                return _colours[ColourTableGroup.StatusStripGradientBegin];
            }
        }

        public override Color StatusStripGradientEnd
        {
            get
            {
                return _colours[ColourTableGroup.StatusStripGradientEnd];
            }
        }

        public override Color ToolStripBorder
        {
            get
            {
                return _colours[ColourTableGroup.ToolStripBorder];
            }
        }

        public override Color ToolStripDropDownBackground
        {
            get
            {
                return _colours[ColourTableGroup.ToolStripDropDownBackground];
            }
        }

        public override Color ToolStripGradientBegin
        {
            get
            {
                return _colours[ColourTableGroup.ToolStripGradientBegin];
            }
        }

        public override Color ToolStripGradientMiddle
        {
            get
            {
                return _colours[ColourTableGroup.ToolStripGradientMiddle];
            }
        }

        public override Color ToolStripGradientEnd
        {
            get
            {
                return _colours[ColourTableGroup.ToolStripGradientEnd];
            }
        }

        public override Color ToolStripContentPanelGradientBegin
        {
            get
            {
                return _colours[ColourTableGroup.ToolStripContentPanelGradientBegin];
            }
        }

        public override Color ToolStripContentPanelGradientEnd
        {
            get
            {
                return _colours[ColourTableGroup.ToolStripContentPanelGradientEnd];
            }
        }

        public override Color ToolStripPanelGradientBegin
        {
            get
            {
                return _colours[ColourTableGroup.ToolStripPanelGradientBegin];
            }
        }

        public override Color ToolStripPanelGradientEnd
        {
            get
            {
                return _colours[ColourTableGroup.ToolStripPanelGradientEnd];
            }
        }

        public override Color OverflowButtonGradientBegin
        {
            get
            {
                return _colours[ColourTableGroup.OverflowButtonGradientBegin];
            }
        }

        public override Color OverflowButtonGradientMiddle
        {
            get
            {
                return _colours[ColourTableGroup.OverflowButtonGradientMiddle];
            }
        }

        public override Color OverflowButtonGradientEnd
        {
            get
            {
                return _colours[ColourTableGroup.OverflowButtonGradientEnd];
            }
        }

        #region Implementation of ICloneable

        public object Clone()
        {
            CustomisableColourTable clone = (CustomisableColourTable)MemberwiseClone();
            clone._colours = new Dictionary<ColourTableGroup, Color>(clone._colours);
            return clone;
        }

        #endregion
    }
}
