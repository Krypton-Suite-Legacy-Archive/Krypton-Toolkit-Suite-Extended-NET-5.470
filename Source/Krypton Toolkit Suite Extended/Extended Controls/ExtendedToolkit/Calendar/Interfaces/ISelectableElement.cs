#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ExtendedControls.ExtendedToolkit.Calendar.Controls;
using System.Drawing;

namespace ExtendedControls.ExtendedToolkit.Calendar.Interfaces
{
    /// <summary>
    /// Represents a clickable element of <see cref="MonthView"/> control
    /// </summary>
    public interface ISelectableElement
    {

        /// <summary>
        /// Gets the bounds of the element
        /// </summary>
        Rectangle Bounds { get; }

        /// <summary>
        /// Gets if the element is currently selected
        /// </summary>
        bool Selected { get; }
    }
}