#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ExtendedDialogs.Enumerations;
using System;
using System.Windows.Forms;

namespace ExtendedDialogs.Classes
{
    public class EnumerationTranslator
    {
        public EnumerationTranslator()
        {

        }

        public static InputBoxButtons TranslateInputBoxButtons(string value) => (InputBoxButtons)Enum.Parse(typeof(InputBoxButtons), ConvertToUpper(value));

        public static InputBoxDefaultButton TranslateInputBoxDefaultButton(string value) => (InputBoxDefaultButton)Enum.Parse(typeof(InputBoxDefaultButton), ConvertToUpper(value));

        public static InputBoxIcon TranslateInputBoxIcon(string value) => (InputBoxIcon)Enum.Parse(typeof(InputBoxIcon), ConvertToUpper(value));

        public static InputBoxIconImageSize TranslateInputBoxIconImageSize(string value) => (InputBoxIconImageSize)Enum.Parse(typeof(InputBoxIconImageSize), ConvertToUpper(value));

        public static InputBoxMessageRightToLeft TranslateInputBoxMessageRightToLeft(string value) => (InputBoxMessageRightToLeft)Enum.Parse(typeof(InputBoxMessageRightToLeft), ConvertToUpper(value));

        public static InputBoxMessageTextAlignment TranslateInputBoxMessageTextAlignment(string value) => (InputBoxMessageTextAlignment)Enum.Parse(typeof(InputBoxMessageTextAlignment), ConvertToUpper(value));

        public static InputBoxType TranslateInputBoxType(string value) => (InputBoxType)Enum.Parse(typeof(InputBoxType), ConvertToUpper(value));

        public static InputBoxUserInputTextAlignment TranslateInputBoxUserInputTextAlignment(string value) => (InputBoxUserInputTextAlignment)Enum.Parse(typeof(InputBoxUserInputTextAlignment), ConvertToUpper(value));

        public static InputBoxUserSelectionTextAlignment TranslateInputBoxUserSelectionTextAlignment(string value) => (InputBoxUserSelectionTextAlignment)Enum.Parse(typeof(InputBoxUserSelectionTextAlignment), ConvertToUpper(value));

        public static FormStartPosition TranslateFormStartPosition(string value) => (FormStartPosition)Enum.Parse(typeof(FormStartPosition), value);

        private static string ConvertToUpper(string value) => value.ToUpper();

        public static Language TranslateInputLanguage(string value) => (Language)Enum.Parse(typeof(Language), value);
    }
}