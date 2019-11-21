#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ExtendedFileDialogs.Enumerations;

namespace ExtendedFileDialogs.Interop
{
    public static class ComDlgResources
    {
        #region Variables
        private static Win32Resources _resources = new Win32Resources("comdlg32.dll");
        #endregion

        #region Methods
        public static string LoadString(ComDlgResourceId id)
        {
            return _resources.LoadString((uint)id);
        }

        public static string FormatString(ComDlgResourceId id, params string[] args)
        {
            return _resources.FormatString((uint)id, args);
        }
        #endregion
    }
}