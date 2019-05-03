#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;
using System.Drawing;

namespace Core.Classes
{
    /// <summary>
    /// Provides a method for extracting images from the system via LoadImage
    /// Modified from the AeroSuite project.
    /// </summary>
    public static class IconExtractor
    {
        /// <summary>
        /// Loads the icon.
        /// </summary>
        /// <param name="type">The type of icon.</param>
        /// <param name="size">The size.</param>
        /// <returns>The icon.</returns>
        /// <exception cref="System.PlatformNotSupportedException"></exception>
        public static Icon LoadIcon(IconType type, Size size)
        {
            IntPtr hIcon = GlobalNativeMethods.LoadImage(IntPtr.Zero, "#" + (int)type, 1, size.Width, size.Height, 0);

            return hIcon == IntPtr.Zero ? null : Icon.FromHandle(hIcon);
        }

        /// <summary>
        /// 
        /// </summary>
        public enum IconType
        {
            /// <summary>
            /// The warning
            /// </summary>
            WARNING = 101,
            /// <summary>
            /// The help
            /// </summary>
            HELP = 102,
            /// <summary>
            /// The error
            /// </summary>
            ERROR = 103,
            /// <summary>
            /// The information
            /// </summary>
            INFO = 104,
            /// <summary>
            /// The shield
            /// </summary>
            SHIELD = 106
        }
    }
}