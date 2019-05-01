#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

namespace ExtendedControls.ExtendedToolkit.Calendar.Classes
{
    /// <summary>
    /// Contains information to render an item
    /// </summary>
    public class CalendarRendererItemEventArgs : CalendarRendererEventArgs
    {
        #region Fields
        private CalendarItem _item;
        #endregion

        #region Ctor


        public CalendarRendererItemEventArgs(CalendarRendererEventArgs original, CalendarItem item)
            : base(original)
        {
            _item = item;
        }

        #endregion

        #region Props

        /// <summary>
        /// Gets the Item being rendered
        /// </summary>
        public CalendarItem Item
        {
            get { return _item; }
        }


        #endregion
    }
}