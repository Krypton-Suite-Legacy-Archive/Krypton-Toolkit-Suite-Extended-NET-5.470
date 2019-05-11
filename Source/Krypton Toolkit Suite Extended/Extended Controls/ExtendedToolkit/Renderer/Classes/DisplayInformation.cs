#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using Microsoft.Win32;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ExtendedControls.ExtendedToolkit.Renderer.Classes
{
    internal static class DisplayInformation
    {
        #region FieldsPrivate

        [ThreadStatic]
        private static string m_strColourScheme;
        [ThreadStatic]
        private static bool m_bIsLunaTheme;
        private const string m_strLunaFileName = "luna.msstyles";
        private static bool m_bIsAeroTheme;
        private const string m_strAeroFileName = "aero.msstyles";

        #endregion

        #region Properties

        public static string ColourScheme
        {
            get { return m_strColourScheme; }
        }

        internal static bool IsLunaTheme
        {
            get { return m_bIsLunaTheme; }
        }

        internal static bool IsAeroTheme
        {
            get { return m_bIsAeroTheme; }
        }

        internal static bool IsTerminalServerSession
        {
            get { return SystemInformation.TerminalServerSession; }
        }
        #endregion

        #region MethodsPrivate

        static DisplayInformation()
        {
            SystemEvents.UserPreferenceChanged += new UserPreferenceChangedEventHandler(DisplayInformation.OnUserPreferenceChanged);
            DisplayInformation.SetScheme();
        }

        private static void OnUserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            DisplayInformation.SetScheme();
        }

        private static void SetScheme()
        {
            DisplayInformation.m_bIsLunaTheme = false;
            if (VisualStyleRenderer.IsSupported)
            {
                m_strColourScheme = VisualStyleInformation.ColorScheme;

                if (!VisualStyleInformation.IsEnabledByUser)
                {
                    return;
                }
                StringBuilder stringBuilder = new StringBuilder(0x200);
                NativeMethods.GetCurrentThemeName(stringBuilder, stringBuilder.Capacity, null, 0, null, 0);
                m_bIsLunaTheme = string.Equals(m_strLunaFileName, Path.GetFileName(stringBuilder.ToString()), StringComparison.InvariantCultureIgnoreCase);
                m_bIsAeroTheme = string.Equals(m_strAeroFileName, Path.GetFileName(stringBuilder.ToString()), StringComparison.InvariantCultureIgnoreCase);
            }
            else
            {
                DisplayInformation.m_strColourScheme = null;
            }
        }
        #endregion

        private static class NativeMethods
        {
            [DllImport("uxtheme.dll", CharSet = CharSet.Auto)]
            public static extern int GetCurrentThemeName(StringBuilder pszThemeFileName, int dwMaxNameChars, StringBuilder pszColorBuff, int dwMaxColorChars, StringBuilder pszSizeBuff, int cchMaxSizeChars);
        }
    }
}