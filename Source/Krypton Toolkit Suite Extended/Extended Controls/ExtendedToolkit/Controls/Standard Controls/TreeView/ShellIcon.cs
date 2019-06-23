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
using System.Runtime.InteropServices;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.CustomTreeView
{
    /// <summary>
	/// Summary description for ShellIcon.
	/// </summary>
	/// <summary>
	/// Summary description for ShellIcon.  Get a small or large Icon with an easy C# function call
	/// that returns a 32x32 or 16x16 System.Drawing.Icon depending on which function you call
	/// either GetSmallIcon(string fileName) or GetLargeIcon(string fileName)
	/// </summary>
	public class ShellIcon
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        private class Win32
        {
            public const uint SHGFI_ICON = 0x100;
            public const uint SHGFI_LARGEICON = 0x0; // 'Large icon
            public const uint SHGFI_SMALLICON = 0x1; // 'Small icon


            [DllImport("shell32.dll")]
            public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);
        }


        public ShellIcon()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        public static Icon GetSmallIcon(string fileName)
        {
            IntPtr hImgSmall; //the handle to the system image list
            SHFILEINFO shinfo = new SHFILEINFO();


            //Use this to get the small Icon
            hImgSmall = Win32.SHGetFileInfo(fileName, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), Win32.SHGFI_ICON | Win32.SHGFI_SMALLICON);


            //The icon is returned in the hIcon member of the shinfo struct
            return System.Drawing.Icon.FromHandle(shinfo.hIcon);
        }


        public static Icon GetLargeIcon(string fileName)
        {
            IntPtr hImgLarge; //the handle to the system image list
            SHFILEINFO shinfo = new SHFILEINFO();


            //Use this to get the large Icon
            hImgLarge = Win32.SHGetFileInfo(fileName, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), Win32.SHGFI_ICON | Win32.SHGFI_LARGEICON);


            //The icon is returned in the hIcon member of the shinfo struct
            return System.Drawing.Icon.FromHandle(shinfo.hIcon);
        }

        [DllImport("user32.dll", EntryPoint = "DestroyIcon")]
        private static extern bool DestroyIcon(IntPtr hIcon);

        public static Icon Convert(Image image)
        {
            Icon icon = null;

            Bitmap bitmap = new Bitmap(image);
            IntPtr UnmanagedIconHandle = bitmap.GetHicon();

            // Clone FromHandle result so we can destroy the unmanaged handle version of the icon before the converted object is passed out.
            icon = Icon.FromHandle(UnmanagedIconHandle).Clone() as Icon;

            //Unfortunately, GetHicon creates an unmanaged handle which must be manually destroyed otherwise a generic error will occur in GDI+.
            DestroyIcon(UnmanagedIconHandle);

            return icon;
        }
    }
}