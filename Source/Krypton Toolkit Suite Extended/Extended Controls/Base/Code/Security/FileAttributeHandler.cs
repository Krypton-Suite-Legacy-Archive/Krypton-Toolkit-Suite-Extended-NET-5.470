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
        public static void SetFileAttributes(string filePath, FileAttributes attributes)
        {
            File.SetAttributes(filePath, attributes);
        }

        public static FileAttributes GetFileAttributes(string filePath)
        {
            return File.GetAttributes(filePath);
        }

        public static void AddNewAttributes(string filePath, FileAttributes attributes)
        {
            File.SetAttributes(filePath, GetFileAttributes(filePath) | attributes);
        }

        public static void ClearAttributes(string filePath, FileAttributes attributes)
        {
            File.SetAttributes(filePath, GetFileAttributes(filePath) & ~attributes);
        }
        #endregion
    }
}