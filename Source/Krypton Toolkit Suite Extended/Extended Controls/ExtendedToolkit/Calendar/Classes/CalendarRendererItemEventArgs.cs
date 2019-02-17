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