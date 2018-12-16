using System;
using System.Runtime.InteropServices;

namespace PaletteRenderer.Classes
{
    public static class Utilities
    {
        #region DLL Import
        [DllImport("dwmapi.dll")]
        private static extern void DwmIsCompositionEnabled(ref bool pfEnabled);
        #endregion

        #region Properties
        /// <summary>
        /// Gets a value indicating whether this instance is composition enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is composition enabled; otherwise, <c>false</c>.
        /// </value>
        public static bool IsCompositionEnabled
        {
            get
            {
                if (Environment.OSVersion.Version.Major < 6)
                {
                    return false;
                }

                bool _compositionEnabled = false;

                DwmIsCompositionEnabled(ref _compositionEnabled);

                return _compositionEnabled;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Formats the specified arguments.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="args">The arguments.</param>
        /// <returns></returns>
        public static String Frmt(this string value, params object[] args)
        {
            return String.Format(value, args);
        }

        /// <summary>
        /// Uppercases the first.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static String UppercaseFirst(this string value)
        {
            if (value.Length <= 1)
            {
                return value.ToUpper();
            }

            Char[] _letterArray = value.ToCharArray();

            return new String(_letterArray);
        }
        #endregion
    }
}