using System.ComponentModel;
using System.Drawing;

namespace ExtendedControls.Base.Code.Colours
{
    public class ColourTypeDialogConverter : ColorConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return false;
        }
    }
}