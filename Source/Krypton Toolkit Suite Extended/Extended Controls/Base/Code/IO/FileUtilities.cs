using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedControls.Base.Code.IO
{
    public class FileUtilities
    {
        #region Constructor        
        /// <summary>
        /// Initializes a new instance of the <see cref="FileUtilities"/> class.
        /// </summary>
        public FileUtilities()
        {

        }
        #endregion

        #region Methods        
        /// <summary>
        /// Gets the file information.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static FileInfo GetFileInformation(string filePath)
        {
            return new FileInfo(filePath);
        }

        /// <summary>
        /// Gets the readable size of the file.
        /// https://stackoverflow.com/questions/281640/how-do-i-get-a-human-readable-file-size-in-bytes-abbreviation-using-net
        /// </summary>
        /// <param name="fileLength">Length of the file.</param>
        /// <returns></returns>
        public static string GetReadableFileSize(long fileLength)
        {
            // Get absolute value
            long absolute_i = (fileLength < 0 ? -fileLength : fileLength);

            // Determine the suffix and readable value
            string suffix;

            double readable;

            if (absolute_i >= 0x1000000000000000) // Exabyte
            {
                suffix = "EB";

                readable = (fileLength >> 50);
            }
            else if (absolute_i >= 0x4000000000000) // Petabyte
            {
                suffix = "PB";

                readable = (fileLength >> 40);
            }
            else if (absolute_i >= 0x10000000000) // Terabyte
            {
                suffix = "TB";

                readable = (fileLength >> 30);
            }
            else if (absolute_i >= 0x40000000) // Gigabyte
            {
                suffix = "GB";

                readable = (fileLength >> 20);
            }
            else if (absolute_i >= 0x100000) // Megabyte
            {
                suffix = "MB";

                readable = (fileLength >> 10);
            }
            else if (absolute_i >= 0x400) // Kilobyte
            {
                suffix = "KB";

                readable = fileLength;
            }
            else
            {
                return fileLength.ToString("0 B"); // Byte
            }
            
            // Divide by 1024 to get fractional value
            readable = (readable / 1024);
            
            // Return formatted number with suffix
            return readable.ToString("0.### ") + suffix;
        }
        #endregion
    }
}