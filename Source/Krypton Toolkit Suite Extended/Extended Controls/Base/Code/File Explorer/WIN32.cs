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
using System.IO;
using System.Runtime.InteropServices;

namespace ExtendedControls.Base.Code.FileExplorer
{
    public class WIN32
    {
        [StructLayout(LayoutKind.Sequential)]
        struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        static class FILE_ATTRIBUTE
        {
            public const uint FILE_ATTRIBUTE_NORMAL = 0x80;
        }

        static class SHGFI
        {
            public const uint SHGFI_TYPENAME = 0x000000400;
            public const uint SHGFI_USEFILEATTRIBUTES = 0x000000010;
        }

        public const uint SHGFI_ICON = 0x100;
        public const uint SHGFI_LARGEICON = 0x0;    // 'Large icon
        public const uint SHGFI_SMALLICON = 0x1;    // 'Small icon

        [DllImport("shell32.dll")]
        static extern IntPtr SHGetFileInfo(string pszPath,
                                    uint dwFileAttributes,
                                    ref SHFILEINFO psfi,
                                    uint cbSizeFileInfo,
                                    uint uFlags);

        [DllImport("user32")]
        public static extern int DestroyIcon(IntPtr hIcon);

        public string GetFileSize(string fullpath)
        {
            FileInfo fi = new FileInfo(fullpath);
            long size = fi.Length;
            string sizeString = String.Format(new FileSizeFormatProvider(), "{0:fs}", size);

            return sizeString;
        }

        public string GetFileType(string fullpath)
        {
            uint dwFileAttributes = FILE_ATTRIBUTE.FILE_ATTRIBUTE_NORMAL;
            uint uFlags = (uint)(SHGFI.SHGFI_TYPENAME | SHGFI.SHGFI_USEFILEATTRIBUTES);
            SHFILEINFO shinfo = new SHFILEINFO();
            IntPtr n = WIN32.SHGetFileInfo(fullpath, dwFileAttributes, ref shinfo, (uint)Marshal.SizeOf(shinfo), uFlags);

            return shinfo.szTypeName;
        }

        public Icon GetIcon(string fullpath, bool use16)
        {
            Icon ico = null;
            IntPtr hImgSmall;
            IntPtr hImgLarge;
            SHFILEINFO shinfo = new SHFILEINFO();

            if (use16)
            {
                //Use this to get the small Icon
                hImgSmall = WIN32.SHGetFileInfo(fullpath, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), WIN32.SHGFI_ICON | WIN32.SHGFI_SMALLICON);
                ico = Icon.FromHandle(shinfo.hIcon);
            }
            else
            {
                //Use this to get the large Icon
                hImgLarge = SHGetFileInfo(fullpath, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), WIN32.SHGFI_ICON | WIN32.SHGFI_LARGEICON);
                ico = Icon.FromHandle(shinfo.hIcon);
            }

            return ico;
        }
    }
}