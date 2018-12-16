using ComponentFactory.Krypton.Toolkit;
using System.Drawing;

namespace PaletteCreator.Classes
{
    public class PaletteExporter
    {
        #region Variables
        private KryptonPalette _palette;
        #endregion

        #region Constructor
        public PaletteExporter()
        {

        }
        #endregion

        #region Methods        
        /// <summary>
        /// Exports the palette.
        /// </summary>
        /// <param name="colour0">The colour0.</param>
        /// <param name="colour1">The colour1.</param>
        /// <param name="colour2">The colour2.</param>
        /// <param name="colour3">The colour3.</param>
        /// <param name="colour4">The colour4.</param>
        /// <param name="normalTextColour">The normal text colour.</param>
        /// <param name="disabledTextColour">The disabled text colour.</param>
        public void ExportPalette(Color colour0, Color colour1, Color colour2, Color colour3, Color colour4, Color normalTextColour, Color disabledTextColour)
        {
            _palette = new KryptonPalette();

            //_palette.BasePalette.

            _palette.Export();
        }
        #endregion
    }
}