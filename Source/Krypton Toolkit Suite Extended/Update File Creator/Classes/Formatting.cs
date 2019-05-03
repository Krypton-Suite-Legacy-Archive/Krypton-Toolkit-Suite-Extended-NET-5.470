#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;

namespace UpdateFileCreator.Classes
{
    /// <summary>
    /// Formats certain elements, so the developer doesn't have to.
    /// </summary>
    public class Formatting
    {
        #region Constructor        
        /// <summary>
        /// Initialises a new instance of the <see cref="Formatting"/> class.
        /// </summary>
        public Formatting()
        {

        }
        #endregion

        #region Methods        
        /// <summary>
        /// Formats the version string.
        /// </summary>
        /// <param name="major">The major.</param>
        /// <param name="minor">The minor.</param>
        /// <param name="build">The build.</param>
        /// <param name="revision">The revision.</param>
        /// <returns></returns>
        public Version FormatVersionString(string major, string minor, string build, string revision)
        {
            string tempVersionString = null;

            Version tempVersion = null;

            tempVersionString = $"{ major }.{ minor }.{ build }.{ revision }";

            tempVersion = Version.Parse(tempVersionString);

            return tempVersion;
        }
        #endregion
    }
}