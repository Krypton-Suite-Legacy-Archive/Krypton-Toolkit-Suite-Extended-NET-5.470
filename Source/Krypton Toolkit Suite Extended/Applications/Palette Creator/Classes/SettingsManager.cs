#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using PaletteCreator.Properties;
using System.Drawing;

namespace PaletteCreator.Classes
{
    public class SettingsManager
    {
        #region Variables
        private Settings _settings = new Settings();
        #endregion

        #region Constructor
        public SettingsManager()
        {

        }
        #endregion

        #region Setters & Getters        
        /// <summary>
        /// Sets the BaseColour to the value of colourValue.
        /// </summary>
        /// <param name="colourValue">The value of colourValue.</param>
        public void SetBaseColour(Color colourValue)
        {
            _settings.BaseColour = colourValue;
        }

        /// <summary>
        /// Gets the BaseColour value.
        /// </summary>
        /// <returns>The value of colourValue.</returns>
        public Color GetBaseColour()
        {
            return _settings.BaseColour;
        }

        /// <summary>
        /// Sets the DarkestColour to the value of colourValue.
        /// </summary>
        /// <param name="colourValue">The value of colourValue.</param>
        public void SetDarkestColour(Color colourValue)
        {
            _settings.DarkColour = colourValue;
        }

        /// <summary>
        /// Gets the DarkestColour value.
        /// </summary>
        /// <returns>The value of colourValue.</returns>
        public Color GetDarkestColour()
        {
            return _settings.DarkColour;
        }

        /// <summary>
        /// Sets the MediumColour to the value of colourValue.
        /// </summary>
        /// <param name="colourValue">The value of colourValue.</param>
        public void SetMediumColour(Color colourValue)
        {
            _settings.MediumColour = colourValue;
        }

        /// <summary>
        /// Gets the MediumColour value.
        /// </summary>
        /// <returns>The value of colourValue.</returns>
        public Color GetMediumColour()
        {
            return _settings.MediumColour;
        }

        /// <summary>
        /// Sets the LightColour to the value of colourValue.
        /// </summary>
        /// <param name="colourValue">The value of colourValue.</param>
        public void SetLightColour(Color colourValue)
        {
            _settings.LightColour = colourValue;
        }

        /// <summary>
        /// Gets the LightColour value.
        /// </summary>
        /// <returns>The value of colourValue.</returns>
        public Color GetLightColour()
        {
            return _settings.LightColour;
        }

        /// <summary>
        /// Sets the LightestColour to the value of colourValue.
        /// </summary>
        /// <param name="colourValue">The value of colourValue.</param>
        public void SetLightestColour(Color colourValue)
        {
            _settings.LightestColour = colourValue;
        }

        /// <summary>
        /// Gets the LightestColour value.
        /// </summary>
        /// <returns>The value of colourValue.</returns>
        public Color GetLightestColour()
        {
            return _settings.LightestColour;
        }
        #endregion
    }
}