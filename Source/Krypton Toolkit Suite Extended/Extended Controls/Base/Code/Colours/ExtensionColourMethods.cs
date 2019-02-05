using System.Drawing;

namespace ExtendedControls.Base.Code.Colours
{
    public static class ExtensionColourMethods
    {
        public static Color FromHex(this string hex)
        {
            return ColorTranslator.FromHtml(hex);
        }
    }
}