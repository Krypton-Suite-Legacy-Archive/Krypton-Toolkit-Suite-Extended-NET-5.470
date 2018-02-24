using System;
using System.Drawing;

namespace GlobalUtilities.Classes
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
            IntPtr hIcon = NativeMethods.LoadImage(IntPtr.Zero, "#" + (int)type, 1, size.Width, size.Height, 0);

            return hIcon == IntPtr.Zero ? null : Icon.FromHandle(hIcon);
        }

        public enum IconType
        {
            WARNING = 101,
            HELP = 102,
            ERROR = 103,
            INFO = 104,
            SHIELD = 106
        }
    }
}