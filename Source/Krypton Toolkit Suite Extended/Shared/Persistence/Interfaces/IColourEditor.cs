#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;
using System.Drawing;

namespace Persistence.Interfaces
{
    /// <summary>
    /// Provides functionality required by colour editors that are bindable
    /// </summary>
    public interface IColourEditor
    {
        #region Events

        /// <summary>
        /// Occurs when the <see cref="Color"/> property is changed.
        /// </summary>
        event EventHandler ColourChanged;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the component colour.
        /// </summary>
        /// <value>The component colour.</value>
        Color Colour { get; set; }

        #endregion
    }
}