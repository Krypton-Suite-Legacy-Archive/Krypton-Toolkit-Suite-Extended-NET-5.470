#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using KryptonExtendedToolkit.Base.Code;
using System;
using System.Diagnostics;

namespace ExtendedControls.Base.Code.Utilities
{
    public class FileVersionUtility
    {
        /// <summary>
        /// Captures an assembly file version.
        /// </summary>
        /// <param name="assemblyPath">The assembly path.</param>
        /// <param name="showExceptionError">if set to <c>true</c> [show exception error].</param>
        /// <returns></returns>
        public static string CaptureAssemblyFileVersion(string assemblyPath, bool showExceptionError = false)
        {
            try
            {
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assemblyPath);

                return fvi.FileVersion;
            }
            catch (Exception e)
            {
                if (showExceptionError)
                {
                    ExceptionHandler.CaptureException(e, null);
                }

                return string.Empty;
            }
        }
    }
}