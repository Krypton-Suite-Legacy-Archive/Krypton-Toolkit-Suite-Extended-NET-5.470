#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;

namespace Core.Classes.Other
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