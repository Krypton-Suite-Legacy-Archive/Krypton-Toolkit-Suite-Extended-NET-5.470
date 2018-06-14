using System.Drawing;
using Tooling.Enumerations;

namespace Tooling.Classes.Colours
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