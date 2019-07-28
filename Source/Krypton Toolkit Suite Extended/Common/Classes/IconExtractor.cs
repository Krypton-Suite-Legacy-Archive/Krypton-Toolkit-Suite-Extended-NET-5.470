using System.Drawing;

namespace Common.Classes
{
    public class IconExtractor
    {
        #region Constructor
        public IconExtractor()
        {

        }
        #endregion

        #region Methods        
        /// <summary>
        /// Extracts the icon.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public static Bitmap ExtractIcon(string path) => Icon.ExtractAssociatedIcon(path).ToBitmap();

        /// <summary>
        /// Extracts the icon from file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public static Icon ExtractIconFromFile(string path) => Icon.ExtractAssociatedIcon(path);
        #endregion
    }
}