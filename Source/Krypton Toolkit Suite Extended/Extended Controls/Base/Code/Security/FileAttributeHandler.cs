using ComponentFactory.Krypton.Toolkit;
using System.IO;

namespace ExtendedControls.Base.Code.Security
{
    public class FileAttributeHandler
    {
        #region Constructor
        public FileAttributeHandler()
        {

        }
        #endregion

        #region Methods        
        /// <summary>
        /// Sets the file attributes.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="attributes">The attributes.</param>
        public static void SetFileAttributes(string filePath, FileAttributes attributes)
        {
            File.SetAttributes(filePath, attributes);
        }

        /// <summary>
        /// Gets the file attributes.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static FileAttributes GetFileAttributes(string filePath)
        {
            return File.GetAttributes(filePath);
        }

        /// <summary>
        /// Adds the new attributes.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="attributes">The attributes.</param>
        public static void AddNewAttributes(string filePath, FileAttributes attributes)
        {
            File.SetAttributes(filePath, GetFileAttributes(filePath) | attributes);
        }

        /// <summary>
        /// Clears the attributes.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="attributes">The attributes.</param>
        public static void ClearAttributes(string filePath, FileAttributes attributes)
        {
            File.SetAttributes(filePath, GetFileAttributes(filePath) & ~attributes);
        }

        /// <summary>
        /// Clears all attributes.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public static void ClearAllAttributes(string filePath)
        {
            File.SetAttributes(filePath, GetFileAttributes(filePath) & ~FileAttributes.Archive | ~FileAttributes.Compressed | ~FileAttributes.Device | ~FileAttributes.Directory | ~FileAttributes.Encrypted | ~FileAttributes.Hidden | ~FileAttributes.IntegrityStream | ~FileAttributes.Normal | ~FileAttributes.NoScrubData | ~FileAttributes.NotContentIndexed | ~FileAttributes.Offline | ~FileAttributes.ReadOnly | ~FileAttributes.ReparsePoint | ~FileAttributes.SparseFile | ~FileAttributes.System | ~FileAttributes.Temporary);
        }

        /// <summary>
        /// Gets the selected file attributes.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="archive">The archive.</param>
        /// <param name="compressed">The compressed.</param>
        /// <param name="device">The device.</param>
        /// <param name="directory">The directory.</param>
        /// <param name="encrypted">The encrypted.</param>
        /// <param name="hidden">The hidden.</param>
        /// <param name="integrityStream">The integrity stream.</param>
        /// <param name="normal">The normal.</param>
        /// <param name="noScrubData">The no scrub data.</param>
        /// <param name="notContextIndexed">The not context indexed.</param>
        /// <param name="offline">The offline.</param>
        /// <param name="readOnly">The read only.</param>
        /// <param name="reparsePoint">The reparse point.</param>
        /// <param name="sparseFile">The sparse file.</param>
        /// <param name="system">The system.</param>
        /// <param name="temporary">The temporary.</param>
        public static void GetSelectedFileAttributes(string filePath, KryptonCheckBox archive, KryptonCheckBox compressed, KryptonCheckBox device, KryptonCheckBox directory, KryptonCheckBox encrypted, KryptonCheckBox hidden, KryptonCheckBox integrityStream, KryptonCheckBox normal, KryptonCheckBox noScrubData, KryptonCheckBox notContextIndexed, KryptonCheckBox offline, KryptonCheckBox readOnly, KryptonCheckBox reparsePoint, KryptonCheckBox sparseFile, KryptonCheckBox system, KryptonCheckBox temporary)
        {
            archive.Checked = GetArchivedAttributeState(filePath);

            compressed.Checked = GetCompressedAttributeState(filePath);

            device.Checked = GetDeviceAttributeState(filePath);

            directory.Checked = GetDirectoryAttributeState(filePath);

            encrypted.Checked = GetEncryptedAttributeState(filePath);

            hidden.Checked = GetHiddenAttributeState(filePath);

            integrityStream.Checked = GetIntegrityStreamAttributeState(filePath);

            normal.Checked = GetNormalAttributeState(filePath);

            noScrubData.Checked = GetNoScrubDataAttributeState(filePath);

            notContextIndexed.Checked = GetNotContextIndexedAttributeState(filePath);

            offline.Checked = GetOfflineAttributeState(filePath);

            readOnly.Checked = GetReadOnlyAttributeState(filePath);

            reparsePoint.Checked = GetReparsePointAttributeState(filePath);

            sparseFile.Checked = GetSparseFileAttributeState(filePath);

            system.Checked = GetSystemAttributeState(filePath);

            temporary.Checked = GetTemporaryAttributeState(filePath);
        }
        #endregion

        #region Booleans        
        /// <summary>
        /// Gets the state of the archived attribute.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static bool GetArchivedAttributeState(string filePath)
        {
            if (GetFileAttributes(filePath) == FileAttributes.Archive)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the state of the compressed attribute.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static bool GetCompressedAttributeState(string filePath)
        {
            if (GetFileAttributes(filePath) == FileAttributes.Compressed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the state of the device attribute.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static bool GetDeviceAttributeState(string filePath)
        {
            if (GetFileAttributes(filePath) == FileAttributes.Device)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the state of the directory attribute.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static bool GetDirectoryAttributeState(string filePath)
        {
            if (GetFileAttributes(filePath) == FileAttributes.Directory)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the state of the encrypted attribute.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static bool GetEncryptedAttributeState(string filePath)
        {
            if (GetFileAttributes(filePath) == FileAttributes.Encrypted)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the state of the hidden attribute.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static bool GetHiddenAttributeState(string filePath)
        {
            if (GetFileAttributes(filePath) == FileAttributes.Hidden)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the state of the integrity stream attribute.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static bool GetIntegrityStreamAttributeState(string filePath)
        {
            if (GetFileAttributes(filePath) == FileAttributes.IntegrityStream)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the state of the normal attribute.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static bool GetNormalAttributeState(string filePath)
        {
            if (GetFileAttributes(filePath) == FileAttributes.Normal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the state of the no scrub data attribute.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static bool GetNoScrubDataAttributeState(string filePath)
        {
            if (GetFileAttributes(filePath) == FileAttributes.NoScrubData)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the state of the not context indexed attribute.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static bool GetNotContextIndexedAttributeState(string filePath)
        {
            if (GetFileAttributes(filePath) == FileAttributes.NotContentIndexed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the state of the offline attribute.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static bool GetOfflineAttributeState(string filePath)
        {
            if (GetFileAttributes(filePath) == FileAttributes.Offline)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the state of the read only attribute.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static bool GetReadOnlyAttributeState(string filePath)
        {
            if (GetFileAttributes(filePath) == FileAttributes.ReadOnly)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the state of the reparse point attribute.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static bool GetReparsePointAttributeState(string filePath)
        {
            if (GetFileAttributes(filePath) == FileAttributes.ReparsePoint)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the state of the sparse file attribute.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static bool GetSparseFileAttributeState(string filePath)
        {
            if (GetFileAttributes(filePath) == FileAttributes.SparseFile)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the state of the system attribute.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static bool GetSystemAttributeState(string filePath)
        {
            if (GetFileAttributes(filePath) == FileAttributes.System)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the state of the temporary attribute.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static bool GetTemporaryAttributeState(string filePath)
        {
            if (GetFileAttributes(filePath) == FileAttributes.Temporary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}