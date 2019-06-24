using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.TreeView.FileSystem.Classes
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
        #region Constructor
        public ShellIcon()
        {

        }
        #endregion

        #region Methods
        public static Icon GetSmallIcon(string fileName)
        {
            IntPtr hImgSmall;

            SHFILEINFO shInfo = new SHFILEINFO();

            hImgSmall = Win32.SHGetFileInfo(fileName, 0, ref shInfo, (uint)Marshal.SizeOf(shInfo), Win32.SHGFI_ICON | Win32.SHGFI_SMALLICON);

            return Icon.FromHandle(shInfo.hIcon);
        }

        public static Icon GetLargeIcon(string fileName)
        {
            IntPtr hImgLarge; //the handle to the system image list

            SHFILEINFO shinfo = new SHFILEINFO();


            //Use this to get the large Icon
            hImgLarge = Win32.SHGetFileInfo(fileName, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), Win32.SHGFI_ICON | Win32.SHGFI_LARGEICON);


            //The icon is returned in the hIcon member of the shinfo struct
            return Icon.FromHandle(shinfo.hIcon);
        }
        #endregion

        #region Structs
        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon, iIcon;

            public uint dwAttributes;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }
        #endregion

        #region Classes
        private class Win32
        {
            #region Constants
            public const uint SHGFI_ICON = 0x100, SHGFI_LARGEICON = 0x0, SHGFI_SMALLICON = 0x1;
            #endregion

            [DllImport("shell32.dll")]
            public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);
        }
        #endregion
    }
}