using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls
{
    [ToolboxBitmap(typeof(KryptonMonthCalendar))]
    public class KryptonMonthCalendarExtended : KryptonMonthCalendar
    {
        #region Variables
        private Color _commonBackgroundColourOne, _commonBackgroundColourTwo, _dayBackgroundColourOne, _dayBackgroundColourTwo, _dayLongTextColourOne, _dayLongTextColourTwo, _dayShortTextColourOne, _dayShortTextColourTwo, _dayOfWeekBackgroundColourOne, _dayOfWeekBackgroundColourTwo, _dayOfWeekLongTextColourOne, _dayOfWeekLongTextColourTwo, _dayOfWeekShortTextColourOne, _dayOfWeekShortTextColourTwo, _headerBackgroundColourOne, _headerBackgroundColourTwo, _headerLongTextColourOne, _headerLongTextColourTwo, _headerShortTextColourOne, _headerShortTextColourTwo;

        private Font _typeface;
        #endregion

        #region Properties
        public Color CommonBackgroundColourOne { get => _commonBackgroundColourOne; set { _commonBackgroundColourOne = value; Invalidate(); } }

        public Color CommonBackgroundColourTwo { get => _commonBackgroundColourTwo; set { _commonBackgroundColourTwo = value; Invalidate(); } }

        public Color DayBackgroundColourOne { get => _dayBackgroundColourOne; set { _dayBackgroundColourOne = value; Invalidate(); } }

        public Color DayBackgroundColourTwo { get => _dayBackgroundColourTwo; set { _dayBackgroundColourTwo = value; Invalidate(); } }

        public Color DayLongTextColourOne { get => _dayLongTextColourOne; set { _dayLongTextColourOne = value; Invalidate(); } }

        public Color DayLongTextColourTwo { get => _dayLongTextColourTwo; set { _dayLongTextColourTwo = value; Invalidate(); } }

        public Color DayShortTextColourOne { get => _dayShortTextColourOne; set { _dayShortTextColourOne = value; Invalidate(); } }

        public Color DayShortTextColourTwo { get => _dayShortTextColourTwo; set { _dayShortTextColourTwo = value; Invalidate(); } }

        public Color DayOfWeekBackgroundColourOne { get => _dayOfWeekBackgroundColourOne; set { _dayBackgroundColourOne = value; Invalidate(); } }

        public Color DayOfWeekBackgroundColourTwo { get => _dayOfWeekBackgroundColourTwo; set { _dayOfWeekBackgroundColourTwo = value; Invalidate(); } }

        public Color DayOfWeekLongTextColourOne { get => _dayOfWeekLongTextColourOne; set { _dayOfWeekLongTextColourOne = value; Invalidate(); } }

        public Color DayOfWeekLongTextColourTwo { get => _dayOfWeekLongTextColourTwo; set { _dayOfWeekLongTextColourTwo = value; Invalidate(); } }

        public Color DayOfWeekShortTextColourOne { get => _dayOfWeekShortTextColourOne; set { _dayOfWeekShortTextColourOne = value; Invalidate(); } }

        public Color DayOfWeekShortTextColourTwo { get => _dayOfWeekShortTextColourTwo; set { _dayOfWeekShortTextColourTwo = value; Invalidate(); } }

        public Color HeaderBackgroundColourOne { get => _headerBackgroundColourOne; set { _headerBackgroundColourOne = value; Invalidate(); } }

        public Color HeaderBackgroundColourTwo { get => _headerBackgroundColourTwo; set { _headerBackgroundColourTwo = value; Invalidate(); } }

        public Color HeaderLongTextColourOne { get => _headerLongTextColourOne; set { _headerLongTextColourOne = value; Invalidate(); } }

        public Color HeaderLongTextColourTwo { get => _headerLongTextColourTwo; set { _headerLongTextColourTwo = value; Invalidate(); } }

        public Color HeaderShortTextColourOne { get => _headerShortTextColourOne; set { _headerShortTextColourOne = value; Invalidate(); } }

        public Color HeaderShortTextColourTwo { get => _headerShortTextColourTwo; set { _headerShortTextColourTwo = value; Invalidate(); } }

        public Font Typeface { get => _typeface; set { _typeface = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonMonthCalendarExtended()
        {
            CommonBackgroundColourOne = Color.Empty;

            CommonBackgroundColourTwo = Color.Empty;

            DayBackgroundColourOne = Color.Empty;

            DayBackgroundColourTwo = Color.Empty;

            DayLongTextColourOne = Color.Empty;

            DayLongTextColourTwo = Color.Empty;

            DayShortTextColourOne = Color.Empty;

            DayShortTextColourTwo = Color.Empty;

            DayOfWeekBackgroundColourOne = Color.Empty;

            DayOfWeekBackgroundColourTwo = Color.Empty;

            DayOfWeekLongTextColourOne = Color.Empty;

            DayOfWeekLongTextColourTwo = Color.Empty;

            DayOfWeekShortTextColourOne = Color.Empty;

            DayOfWeekShortTextColourTwo = Color.Empty;

            HeaderBackgroundColourOne = Color.Empty;

            HeaderBackgroundColourTwo = Color.Empty;

            HeaderLongTextColourOne = Color.Empty;

            HeaderLongTextColourTwo = Color.Empty;

            HeaderShortTextColourOne = Color.Empty;

            HeaderShortTextColourTwo = Color.Empty;

            Typeface = null;

            UpdateAppearanceValues(CommonBackgroundColourOne, CommonBackgroundColourTwo, DayBackgroundColourOne, DayBackgroundColourTwo, DayLongTextColourOne, DayLongTextColourTwo, DayShortTextColourOne, DayShortTextColourTwo, DayOfWeekBackgroundColourOne, DayOfWeekBackgroundColourTwo, DayOfWeekLongTextColourOne, DayOfWeekLongTextColourTwo, DayOfWeekShortTextColourOne, DayOfWeekShortTextColourTwo, HeaderBackgroundColourOne, HeaderBackgroundColourTwo, HeaderLongTextColourOne, HeaderLongTextColourTwo, HeaderShortTextColourOne, HeaderShortTextColourTwo, Typeface);
        }
        #endregion

        #region Methods
        /// <summary>Updates the appearance values.</summary>
        /// <param name="commonBackgroundColourOne">The common background colour one.</param>
        /// <param name="commonBackgroundColourTwo">The common background colour two.</param>
        /// <param name="dayBackgroundColourOne">The day background colour one.</param>
        /// <param name="dayBackgroundColourTwo">The day background colour two.</param>
        /// <param name="dayLongTextColourOne">The day long text colour one.</param>
        /// <param name="dayLongTextColourTwo">The day long text colour two.</param>
        /// <param name="dayShortTextColourOne">The day short text colour one.</param>
        /// <param name="dayShortTextColourTwo">The day short text colour two.</param>
        /// <param name="dayOfWeekBackgroundColourOne">The day of week background colour one.</param>
        /// <param name="dayOfWeekBackgroundColourTwo">The day of week background colour two.</param>
        /// <param name="dayOfWeekLongTextColourOne">The day of week long text colour one.</param>
        /// <param name="dayOfWeekLongTextColourTwo">The day of week long text colour two.</param>
        /// <param name="dayOfWeekShortTextColourOne">The day of week short text colour one.</param>
        /// <param name="dayOfWeekShortTextColourTwo">The day of week short text colour two.</param>
        /// <param name="headerBackgroundColourOne">The header background colour one.</param>
        /// <param name="headerBackgroundColourTwo">The header background colour two.</param>
        /// <param name="headerLongTextColourOne">The header long text colour one.</param>
        /// <param name="headerLongTextColourTwo">The header long text colour two.</param>
        /// <param name="headerShortTextColourOne">The header short text colour one.</param>
        /// <param name="headerShortTextColourTwo">The header short text colour two.</param>
        /// <param name="typeface">The typeface.</param>
        private void UpdateAppearanceValues(Color commonBackgroundColourOne, Color commonBackgroundColourTwo, Color dayBackgroundColourOne, Color dayBackgroundColourTwo, Color dayLongTextColourOne, Color dayLongTextColourTwo, Color dayShortTextColourOne, Color dayShortTextColourTwo, Color dayOfWeekBackgroundColourOne, Color dayOfWeekBackgroundColourTwo, Color dayOfWeekLongTextColourOne, Color dayOfWeekLongTextColourTwo, Color dayOfWeekShortTextColourOne, Color dayOfWeekShortTextColourTwo, Color headerBackgroundColourOne, Color headerBackgroundColourTwo, Color headerLongTextColourOne, Color headerLongTextColourTwo, Color headerShortTextColourOne, Color headerShortTextColourTwo, Font typeface)
        {
            StateCommon.Back.Color1 = commonBackgroundColourOne;

            StateCommon.Back.Color2 = commonBackgroundColourTwo;

            StateCommon.Day.Back.Color1 = dayBackgroundColourOne;

            StateCommon.Day.Back.Color2 = dayBackgroundColourTwo;

            StateCommon.Day.Content.LongText.Color1 = dayLongTextColourOne;

            StateCommon.Day.Content.LongText.Color2 = dayLongTextColourTwo;

            StateCommon.Day.Content.LongText.Font = typeface;

            StateCommon.Day.Content.ShortText.Color1 = dayShortTextColourOne;

            StateCommon.Day.Content.ShortText.Color2 = dayShortTextColourTwo;

            StateCommon.Day.Content.ShortText.Font = typeface;

            StateCommon.DayOfWeek.Back.Color1 = dayOfWeekBackgroundColourOne;

            StateCommon.DayOfWeek.Back.Color2 = dayOfWeekBackgroundColourTwo;

            StateCommon.DayOfWeek.Content.LongText.Color1 = dayOfWeekLongTextColourOne;

            StateCommon.DayOfWeek.Content.LongText.Color2 = dayOfWeekLongTextColourTwo;

            StateCommon.DayOfWeek.Content.LongText.Font = typeface;

            StateCommon.DayOfWeek.Content.ShortText.Color1 = dayOfWeekShortTextColourOne;

            StateCommon.DayOfWeek.Content.ShortText.Color2 = dayOfWeekShortTextColourTwo;

            StateCommon.DayOfWeek.Content.ShortText.Font = typeface;

            StateCommon.Header.Back.Color1 = headerBackgroundColourOne;

            StateCommon.Header.Back.Color2 = headerBackgroundColourTwo;

            StateCommon.Header.Content.LongText.Color1 = headerLongTextColourOne;

            StateCommon.Header.Content.LongText.Color2 = headerLongTextColourTwo;

            StateCommon.Header.Content.LongText.Font = typeface;

            StateCommon.Header.Content.ShortText.Color1 = headerShortTextColourOne;

            StateCommon.Header.Content.ShortText.Color2 = headerShortTextColourTwo;

            StateCommon.Header.Content.ShortText.Font = typeface;
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateAppearanceValues(CommonBackgroundColourOne, CommonBackgroundColourTwo, DayBackgroundColourOne, DayBackgroundColourTwo, DayLongTextColourOne, DayLongTextColourTwo, DayShortTextColourOne, DayShortTextColourTwo, DayOfWeekBackgroundColourOne, DayOfWeekBackgroundColourTwo, DayOfWeekLongTextColourOne, DayOfWeekLongTextColourTwo, DayOfWeekShortTextColourOne, DayOfWeekShortTextColourTwo, HeaderBackgroundColourOne, HeaderBackgroundColourTwo, HeaderLongTextColourOne, HeaderLongTextColourTwo, HeaderShortTextColourOne, HeaderShortTextColourTwo, Typeface);

            base.OnPaint(e);
        }
        #endregion
    }
}