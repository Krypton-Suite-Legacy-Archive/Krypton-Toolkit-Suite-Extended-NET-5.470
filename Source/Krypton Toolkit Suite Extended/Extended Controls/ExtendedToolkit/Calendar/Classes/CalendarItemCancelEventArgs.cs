using System.ComponentModel;

namespace ExtendedControls.ExtendedToolkit.Calendar.Classes
{
    public class CalendarItemCancelEventArgs : CancelEventArgs
    {
        #region Ctor

        /// <summary>
        /// Creates a new <see cref="CalendarItemEventArgs"/>
        /// </summary>
        /// <param name="item">Related Item</param>
        public CalendarItemCancelEventArgs(CalendarItem item)
        {
            _item = item;
        }

        #endregion

        #region Props

        private CalendarItem _item;

        /// <summary>
        /// Gets the <see cref="CalendarItem"/> related to the event
        /// </summary>
        public CalendarItem Item
        {
            get { return _item; }
        }


        #endregion
    }
}