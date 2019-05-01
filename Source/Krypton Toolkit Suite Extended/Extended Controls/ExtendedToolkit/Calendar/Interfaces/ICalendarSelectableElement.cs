#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ExtendedControls.ExtendedToolkit.Calendar.Controls;
using System;

namespace ExtendedControls.ExtendedToolkit.Calendar.Interfaces
{
    /// <summary>
    /// Interface implemented by every selectable element of the calendar
    /// </summary>
    public interface ICalendarSelectableElement : ISelectableElement, IComparable<ICalendarSelectableElement>
    {

        /// <summary>
        /// Gets the calendar this element belongs to
        /// </summary>
        KryptonCalendar Calendar { get; }

        /// <summary>
        /// Gets the calendar
        /// </summary>
        DateTime Date { get; }

    }
}
