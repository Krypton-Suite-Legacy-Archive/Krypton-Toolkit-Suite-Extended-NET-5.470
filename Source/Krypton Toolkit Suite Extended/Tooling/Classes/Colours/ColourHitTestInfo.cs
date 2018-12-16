using System.Drawing;
using Core.Enumerations;

namespace Core.Classes.Colours
{
    public class ColourHitTestInfo
    {
        #region Properties

        public Color Colour { get; set; }

        public int Index { get; set; }

        public ColourSource Source { get; set; }

        #endregion
    }
}