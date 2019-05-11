#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System.Drawing;

namespace ExtendedControls.Interfaces.ColourSchemes
{
    public interface IColourScheme
    {
        /// <summary>
        /// Gets the colours.
        /// </summary>
        /// <value>
        /// The colours.
        /// </value>
        Color[] Colours { get; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string Name { get; }
    }
}