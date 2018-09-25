using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;

namespace ExtendedControls.Base.Code
{
    public static class TypefaceHelper
    {
        #region Methods
        public static void InitialiseTypefaceFamilies(KryptonComboBox typefaceSelection)
        {
            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                typefaceSelection.Items.Add(fontFamily.Name);
            }
        }

        public static void InitialiseTypefaceStyles(KryptonListBox typefaceStyleSelection)
        {
            foreach (FontStyle style in Enum.GetValues(typeof(FontStyle)))
            {
                typefaceStyleSelection.Items.Add(style.ToString());
            }
        }

        public static void UpdateTypefaceStyles()
        {

        }
        #endregion
    }
}