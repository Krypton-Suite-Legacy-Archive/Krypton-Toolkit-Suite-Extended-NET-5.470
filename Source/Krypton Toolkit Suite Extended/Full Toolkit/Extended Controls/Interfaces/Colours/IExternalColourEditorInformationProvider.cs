#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ExtendedControls.Enumerations;
using ExtendedControls.Interfaces.ColourSchemes;
using System.Collections.Generic;
using System.Drawing;

namespace ExtendedControls.Interfaces.Colours
{
    /// <summary>
    /// Externally provide additional functions.
    /// </summary>
    public interface IExternalColourEditorInformationProvider
    {
        #region Colour related.
        // ------------------------------------------------------------------

        /// <summary>
        /// Gets the color schemes.
        /// </summary>
        /// <value>The color schemes. Return NULL or empty to disable 
        /// color schemes.</value>
        IColourScheme[] ColourSchemes
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether [allow no color selectable].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [allow no color selectable]; otherwise, <c>false</c>.
        /// </value>
        bool AllowNoColourSelectable
        {
            get;
        }

        /// <summary>
        /// Formats the display text.
        /// Allows externally to configure what to display.
        /// Simply do nothing when you want the default behavior.
        /// </summary>
        /// <param name="colour">The color.</param>
        /// <param name="displayText">The display text.</param>
        void FormatDisplayText(Color colour, ref string displayText);

        /// <summary>
        /// Gives implementors of this interface a chance to adjust the
        /// order where colors are looked up when setting the initial
        /// color for the color editor control/form.
        /// </summary>
        /// <param name="lookupOrder">The lookup order.</param>
        void AdjustColourSettingLookupOrder(IList<ColourLookupElement> lookupOrder);

        // ------------------------------------------------------------------
        #endregion

        #region Persistence.
        // ------------------------------------------------------------------

        /// <summary>
        /// Saves a per user per workstation value.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        void SavePerUserPerWorkstationValue(string name, string value);

        /// <summary>
        /// Restores a per user per workstation value.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="fallBackTo">The fall back to.</param>
        /// <returns></returns>
        string RestorePerUserPerWorkstationValue(string name, string fallBackTo);

        // ------------------------------------------------------------------
        #endregion
    }
}