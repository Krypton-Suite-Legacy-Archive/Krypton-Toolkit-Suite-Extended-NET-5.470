using System.Drawing;

namespace Tooling.Classes.Other
{
    /// <summary>
    /// https://stackoverflow.com/questions/7255514/generating-colours-after-applying-opacity-of-black-and-white
    /// </summary>
    public class ColourUtility
    {
        #region Variables
        private Color _colour;
        #endregion

        #region Constructor
        public ColourUtility(Color originalColour)
        {
            _colour = originalColour;
        }
        #endregion

        #region Methods
        public Color GetTransformedColour(Color overlay)
        {
            using (var bitmap = new Bitmap(1, 1))
            {
                var g = Graphics.FromImage(bitmap);

                using (Brush baseBrush = new SolidBrush(_colour))
                {
                    g.FillRectangle(baseBrush, 0, 0, 1, 1);
                }

                using (Brush overlayBrush = new SolidBrush(Color.FromArgb(127, overlay)))
                {
                    g.FillRectangle(overlayBrush, 0, 0, 1, 1);
                }

                return bitmap.GetPixel(0, 0);
            }
        }
        #endregion
    }
}