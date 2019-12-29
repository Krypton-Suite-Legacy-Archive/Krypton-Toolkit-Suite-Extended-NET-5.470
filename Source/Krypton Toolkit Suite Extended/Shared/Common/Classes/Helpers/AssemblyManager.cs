#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System.Diagnostics;

namespace Common
{
    public class AssemblyManager
    {
        public AssemblyManager()
        {

        }

        /// <summary>Gets the file version information.</summary>
        /// <param name="assemblyPath">The assembly path.</param>
        /// <returns>The file version of the selected assembly.</returns>
        public static FileVersionInfo GetFileVersionInformation(string assemblyPath) => FileVersionInfo.GetVersionInfo(assemblyPath);
    }
}