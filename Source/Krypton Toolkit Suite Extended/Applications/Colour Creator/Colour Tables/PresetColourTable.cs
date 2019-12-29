using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColourCreator.ColourTables
{
    abstract class PresetColourTable : ProfessionalColorTable
    {
        protected PresetColourTable(string name)
        {
            if (name == null) throw new ArgumentNullException("name");
            Name = name;
        }

        public string Name
        {
            get;
            protected set;
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
    }
}