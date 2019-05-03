#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using Core;
using System;

namespace PaletteExplorer.Classes
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
                ExceptionHandler.CaptureException(exc);
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