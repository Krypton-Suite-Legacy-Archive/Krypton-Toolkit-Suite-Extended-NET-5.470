using KryptonExtendedToolkit.Base.Code;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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