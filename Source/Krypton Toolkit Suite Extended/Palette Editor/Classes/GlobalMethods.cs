using ComponentFactory.Krypton.Toolkit;
using System;

namespace PaletteEditor.Classes
{
    public class GlobalMethods
    {
        #region Variables
        private PaletteMode _paletteMode;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the palette mode.
        /// </summary>
        /// <value>
        /// The palette mode.
        /// </value>
        public PaletteMode SelectedPaletteMode { get { return _paletteMode; } set { _paletteMode = value; } }
        #endregion

        #region Constructors
        public GlobalMethods()
        {

        }
        #endregion

        #region Methods
        public void PropagatePaletteModes(KryptonComboBox paletteModeSelection)
        {
            try
            {
                Array paletteModes = Enum.GetValues(typeof(PaletteMode));

                foreach (string item in paletteModes)
                {
                    paletteModeSelection.Items.Add(item);
                }
            }
            catch (Exception exc)
            {

                throw;
            }
        }
        #endregion

        #region Setters and Getters        
        /// <summary>
        /// Sets the selected palette mode.
        /// </summary>
        /// <param name="paletteModeValue">The palette mode value.</param>
        public void SetSelectedPaletteMode(PaletteMode paletteModeValue)
        {
            SelectedPaletteMode = paletteModeValue;
        }

        /// <summary>
        /// Gets the selected palette mode.
        /// </summary>
        /// <returns>The selected palette mode value.</returns>
        public PaletteMode GetSelectedPaletteMode()
        {
            return SelectedPaletteMode;
        }
        #endregion
    }
}