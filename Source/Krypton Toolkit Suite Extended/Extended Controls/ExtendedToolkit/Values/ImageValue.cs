using System.Drawing;

using ComponentFactory.Krypton.Toolkit;

namespace ExtendedControls.ExtendedToolkit.Values
{
    public class ImageValue : NullContentValues
    {
        #region Static Fields
        private static readonly Image defaultImage = Properties.Resources.Question_32_x_32;
        #endregion

        #region Instance Fields

        public Image Image { get; set; }
        #endregion


        #region IContentValues
        /// <summary>
        /// Gets the content short text.
        /// </summary>
        /// <returns>String value.</returns>
        public override Image GetImage(PaletteState state)
        {
            return Image ?? defaultImage;
        }
        #endregion
    }
}
