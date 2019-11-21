using ComponentFactory.Krypton.Toolkit;
using ExtendedStandardControls.Classes;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls
{
    public class KryptonFormExtended : KryptonForm
    {
        #region Variables
        public Color _stateActiveBackgroundColourOne, _stateActiveBackgroundColourTwo, _stateActiveHeaderBackgroundColourOne, _stateActiveHeaderBackgroundColourTwo, _stateActiveHeaderContentLongTextColourOne, _stateActiveHeaderContentLongTextColourTwo, _stateActiveHeaderContentShortTextColourOne, _stateActiveHeaderContentShortTextColourTwo,
                     _stateCommonBackgroundColourOne, _stateCommonBackgroundColourTwo, _stateCommonHeaderBackgroundColourOne, _stateCommonHeaderBackgroundColourTwo, _stateCommonHeaderContentLongTextColourOne, _stateCommonHeaderContentLongTextColourTwo, _stateCommonHeaderContentShortTextColourOne, _stateCommonHeaderContentShortTextColourTwo,
                     _stateInactiveBackgroundColourOne, _stateInactiveBackgroundColourTwo, _stateInactiveHeaderBackgroundColourOne, _stateInactiveHeaderBackgroundColourTwo, _stateInactiveHeaderContentLongTextColourOne, _stateInactiveHeaderContentLongTextColourTwo, _stateInactiveHeaderContentShortTextColourOne, _stateInactiveHeaderContentShortTextColourTwo;

        private int _cornerRoundingRadius;

        private Font _longTextTypeface, _shortTextTypeface;
        #endregion

        #region Properties

        #region State Active
        /// <summary>Gets or sets the state active background colour one.</summary>
        /// <value>The state active background colour one.</value>
        public Color StateActiveBackgroundColourOne { get => _stateActiveBackgroundColourOne; set { _stateActiveBackgroundColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state active background colour two.</summary>
        /// <value>The state active background colour two.</value>
        public Color StateActiveBackgroundColourTwo { get => _stateActiveBackgroundColourTwo; set { _stateActiveBackgroundColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the state active header background colour one.</summary>
        /// <value>The state active header background colour one.</value>
        public Color StateActiveHeaderBackgroundColourOne { get => _stateActiveHeaderBackgroundColourOne; set { _stateActiveHeaderBackgroundColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state active header background colour two.</summary>
        /// <value>The state active header background colour two.</value>
        public Color StateActiveHeaderBackgroundColourTwo { get => _stateActiveHeaderBackgroundColourTwo; set { _stateActiveHeaderBackgroundColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the state active header content long text colour one.</summary>
        /// <value>The state active header content long text colour one.</value>
        public Color StateActiveHeaderContentLongTextColourOne { get => _stateActiveHeaderContentLongTextColourOne; set { _stateActiveHeaderContentLongTextColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state active header content long text colour two.</summary>
        /// <value>The state active header content long text colour two.</value>
        public Color StateActiveHeaderContentLongTextColourTwo { get => _stateActiveHeaderContentLongTextColourTwo; set { _stateActiveHeaderContentLongTextColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the state active header content short text colour one.</summary>
        /// <value>The state active header content short text colour one.</value>
        public Color StateActiveHeaderContentShortTextColourOne { get => _stateActiveHeaderContentShortTextColourOne; set { _stateActiveHeaderContentShortTextColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state active header content short text colour two.</summary>
        /// <value>The state active header content short text colour two.</value>
        public Color StateActiveHeaderContentShortTextColourTwo { get => _stateActiveHeaderContentShortTextColourTwo; set { _stateActiveHeaderContentShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region State Common
        /// <summary>Gets or sets the state common background colour one.</summary>
        /// <value>The state common background colour one.</value>
        public Color StateCommonBackgroundColourOne { get => _stateCommonBackgroundColourOne; set { _stateCommonBackgroundColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state common background colour two.</summary>
        /// <value>The state common background colour two.</value>
        public Color StateCommonBackgroundColourTwo { get => _stateCommonBackgroundColourTwo; set { _stateCommonBackgroundColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the state common header background colour one.</summary>
        /// <value>The state common header background colour one.</value>
        public Color StateCommonHeaderBackgroundColourOne { get => _stateCommonHeaderBackgroundColourOne; set { _stateCommonHeaderBackgroundColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state common header background colour two.</summary>
        /// <value>The state common header background colour two.</value>
        public Color StateCommonHeaderBackgroundColourTwo { get => _stateCommonHeaderBackgroundColourTwo; set { _stateCommonHeaderBackgroundColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the state common header content long text colour one.</summary>
        /// <value>The state common header content long text colour one.</value>
        public Color StateCommonHeaderContentLongTextColourOne { get => _stateCommonHeaderContentLongTextColourOne; set { _stateCommonHeaderContentLongTextColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state common header content long text colour two.</summary>
        /// <value>The state common header content long text colour two.</value>
        public Color StateCommonHeaderContentLongTextColourTwo { get => _stateCommonHeaderContentLongTextColourTwo; set { _stateCommonHeaderContentLongTextColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the state common header content short text colour one.</summary>
        /// <value>The state common header content short text colour one.</value>
        public Color StateCommonHeaderContentShortTextColourOne { get => _stateCommonHeaderContentShortTextColourOne; set { _stateCommonHeaderContentShortTextColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state common header content short text colour two.</summary>
        /// <value>The state common header content short text colour two.</value>
        public Color StateCommonHeaderContentShortTextColourTwo { get => _stateCommonHeaderContentShortTextColourTwo; set { _stateCommonHeaderContentShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region State Inactive
        /// <summary>Gets or sets the state inactive background colour one.</summary>
        /// <value>The state inactive background colour one.</value>
        public Color StateInactiveBackgroundColourOne { get => _stateInactiveBackgroundColourOne; set { _stateInactiveBackgroundColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state inactive background colour two.</summary>
        /// <value>The state inactive background colour two.</value>
        public Color StateInactiveBackgroundColourTwo { get => _stateInactiveBackgroundColourTwo; set { _stateInactiveBackgroundColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the state inactive header background colour one.</summary>
        /// <value>The state inactive header background colour one.</value>
        public Color StateInactiveHeaderBackgroundColourOne { get => _stateInactiveHeaderBackgroundColourOne; set { _stateInactiveHeaderBackgroundColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state inactive header background colour two.</summary>
        /// <value>The state inactive header background colour two.</value>
        public Color StateInactiveHeaderBackgroundColourTwo { get => _stateInactiveHeaderBackgroundColourTwo; set { _stateInactiveHeaderBackgroundColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the state inactive header content long text colour one.</summary>
        /// <value>The state inactive header content long text colour one.</value>
        public Color StateInactiveHeaderContentLongTextColourOne { get => _stateInactiveHeaderContentLongTextColourOne; set { _stateInactiveHeaderContentLongTextColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state inactive header content long text colour two.</summary>
        /// <value>The state inactive header content long text colour two.</value>
        public Color StateInactiveHeaderContentLongTextColourTwo { get => _stateInactiveHeaderContentLongTextColourTwo; set { _stateInactiveHeaderContentLongTextColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the state inactive header content short text colour one.</summary>
        /// <value>The state inactive header content short text colour one.</value>
        public Color StateInactiveHeaderContentShortTextColourOne { get => _stateInactiveHeaderContentShortTextColourOne; set { _stateInactiveHeaderContentShortTextColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state inactive header content short text colour two.</summary>
        /// <value>The state inactive header content short text colour two.</value>
        public Color StateInactiveHeaderContentShortTextColourTwo { get => _stateInactiveHeaderContentShortTextColourTwo; set { _stateInactiveHeaderContentShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region Globals
        /// <summary>
        /// Gets or sets the corner rounding radius.
        /// </summary>
        /// <value>
        /// The corner rounding radius.
        /// </value>
        [DefaultValue(-1), Description("Defines the corner roundness on the current window (-1 is the default look).")]
        public int CornerRoundingRadius { get => _cornerRoundingRadius; set { _cornerRoundingRadius = value; Invalidate(); } }

        /// <summary>Gets or sets the long text typeface.</summary>
        /// <value>The long text typeface.</value>
        public Font LongTextTypeface { get => _longTextTypeface; set { _longTextTypeface = value; Invalidate(); } }

        /// <summary>Gets or sets the short text typeface.</summary>
        /// <value>The short text typeface.</value>
        public Font ShortTextTypeface { get => _shortTextTypeface; set { _shortTextTypeface = value; Invalidate(); } }
        #endregion

        #endregion

        #region Constructor
        public KryptonFormExtended()
        {
            #region State Active
            StateActiveBackgroundColourOne = Colour.DefaultColour();

            StateActiveBackgroundColourTwo = Colour.DefaultColour();

            StateActiveHeaderBackgroundColourOne = Colour.DefaultColour();

            StateActiveHeaderBackgroundColourTwo = Colour.DefaultColour();

            StateActiveHeaderContentLongTextColourOne = Colour.DefaultColour();

            StateActiveHeaderContentLongTextColourTwo = Colour.DefaultColour();

            StateActiveHeaderContentShortTextColourOne = Colour.DefaultColour();

            StateActiveHeaderContentShortTextColourTwo = Colour.DefaultColour();
            #endregion

            #region State Common
            StateCommonBackgroundColourOne = Colour.DefaultColour();

            StateCommonBackgroundColourTwo = Colour.DefaultColour();

            StateCommonHeaderBackgroundColourOne = Colour.DefaultColour();

            StateCommonHeaderBackgroundColourTwo = Colour.DefaultColour();

            StateCommonHeaderContentLongTextColourOne = Colour.DefaultColour();

            StateCommonHeaderContentLongTextColourTwo = Colour.DefaultColour();

            StateCommonHeaderContentShortTextColourOne = Colour.DefaultColour();

            StateCommonHeaderContentShortTextColourTwo = Colour.DefaultColour();
            #endregion

            #region State Inactive
            StateInactiveBackgroundColourOne = Colour.DefaultColour();

            StateInactiveBackgroundColourTwo = Colour.DefaultColour();

            StateInactiveHeaderBackgroundColourOne = Colour.DefaultColour();

            StateInactiveHeaderBackgroundColourTwo = Colour.DefaultColour();

            StateInactiveHeaderContentLongTextColourOne = Colour.DefaultColour();

            StateInactiveHeaderContentLongTextColourTwo = Colour.DefaultColour();

            StateInactiveHeaderContentShortTextColourOne = Colour.DefaultColour();

            StateInactiveHeaderContentShortTextColourTwo = Colour.DefaultColour();
            #endregion

            CornerRoundingRadius = -1;

            LongTextTypeface = Typeface.DefaultTypeface();

            ShortTextTypeface = Typeface.DefaultTypeface();

            UpdateStateActiveValues(StateActiveBackgroundColourOne, StateActiveBackgroundColourTwo, StateActiveHeaderBackgroundColourOne, StateActiveHeaderBackgroundColourTwo, StateActiveHeaderContentLongTextColourOne, StateActiveHeaderContentLongTextColourTwo, StateActiveHeaderContentShortTextColourOne, StateActiveHeaderContentShortTextColourTwo, LongTextTypeface, ShortTextTypeface);

            UpdateStateCommonValues(StateCommonBackgroundColourOne, StateCommonBackgroundColourTwo, StateCommonHeaderBackgroundColourOne, StateCommonHeaderBackgroundColourTwo, StateCommonHeaderContentLongTextColourOne, StateCommonHeaderContentLongTextColourTwo, StateCommonHeaderContentShortTextColourOne, StateCommonHeaderContentShortTextColourTwo, LongTextTypeface, ShortTextTypeface);

            UpdateCornerRoundingRadius(CornerRoundingRadius);

            UpdateStateInactiveValues(StateInactiveBackgroundColourOne, StateInactiveBackgroundColourTwo, StateInactiveHeaderBackgroundColourOne, StateInactiveHeaderBackgroundColourTwo, StateInactiveHeaderContentLongTextColourOne, StateInactiveHeaderContentLongTextColourTwo, StateInactiveHeaderContentShortTextColourOne, StateInactiveHeaderContentShortTextColourTwo, LongTextTypeface, ShortTextTypeface);
        }
        #endregion

        #region Methods

        private void UpdateStateCommonValues(Color stateCommonBackgroundColourOne, Color stateCommonBackgroundColourTwo, Color stateCommonHeaderBackgroundColourOne, Color stateCommonHeaderBackgroundColourTwo, Color stateCommonHeaderContentLongTextColourOne, Color stateCommonHeaderContentLongTextColourTwo, Color stateCommonHeaderContentShortTextColourOne, Color stateCommonHeaderContentShortTextColourTwo, Font longTextTypeface, Font shortTextTypeface)
        {
            StateCommon.Back.Color1 = stateCommonBackgroundColourOne;

            StateCommon.Back.Color2 = stateCommonBackgroundColourTwo;

            StateCommon.Header.Back.Color1 = stateCommonHeaderBackgroundColourOne;

            StateCommon.Header.Back.Color2 = stateCommonHeaderBackgroundColourTwo;

            StateCommon.Header.Content.LongText.Color1 = stateCommonHeaderContentLongTextColourOne;

            StateCommon.Header.Content.LongText.Color2 = stateCommonHeaderContentLongTextColourTwo;

            StateCommon.Header.Content.LongText.Font = longTextTypeface;

            StateCommon.Header.Content.ShortText.Color1 = stateCommonHeaderContentShortTextColourOne;

            StateCommon.Header.Content.ShortText.Color2 = stateCommonHeaderContentShortTextColourTwo;

            StateCommon.Header.Content.ShortText.Font = shortTextTypeface;
        }

        private void UpdateStateActiveValues(Color stateActiveBackgroundColourOne, Color stateActiveBackgroundColourTwo, Color stateActiveHeaderBackgroundColourOne, Color stateActiveHeaderBackgroundColourTwo, Color stateActiveHeaderContentLongTextColourOne, Color stateActiveHeaderContentLongTextColourTwo, Color stateActiveHeaderContentShortTextColourOne, Color stateActiveHeaderContentShortTextColourTwo, Font longTextTypeface, Font shortTextTypeface)
        {
            StateActive.Back.Color1 = stateActiveBackgroundColourOne;

            StateActive.Back.Color2 = stateActiveBackgroundColourTwo;

            StateActive.Header.Back.Color1 = stateActiveHeaderBackgroundColourOne;

            StateActive.Header.Back.Color2 = stateActiveHeaderBackgroundColourTwo;

            StateActive.Header.Content.LongText.Color1 = stateActiveHeaderContentLongTextColourOne;

            StateActive.Header.Content.LongText.Color2 = stateActiveHeaderContentLongTextColourTwo;

            StateActive.Header.Content.LongText.Font = longTextTypeface;

            StateActive.Header.Content.ShortText.Color1 = stateActiveHeaderContentShortTextColourOne;

            StateActive.Header.Content.ShortText.Color2 = stateActiveHeaderContentShortTextColourTwo;

            StateActive.Header.Content.ShortText.Font = shortTextTypeface;
        }

        private void UpdateCornerRoundingRadius(int roundnessValue) => StateCommon.Border.Rounding = roundnessValue;

        private void UpdateStateInactiveValues(Color stateInactiveBackgroundColourOne, Color stateInactiveBackgroundColourTwo, Color stateInactiveHeaderBackgroundColourOne, Color stateInactiveHeaderBackgroundColourTwo, Color stateInactiveHeaderContentLongTextColourOne, Color stateInactiveHeaderContentLongTextColourTwo, Color stateInactiveHeaderContentShortTextColourOne, Color stateInactiveHeaderContentShortTextColourTwo, Font longTextTypeface, Font shortTextTypeface)
        {
            StateInactive.Back.Color1 = stateInactiveBackgroundColourOne;

            StateInactive.Back.Color2 = stateInactiveBackgroundColourTwo;

            StateInactive.Header.Back.Color1 = stateInactiveHeaderBackgroundColourOne;

            StateInactive.Header.Back.Color2 = stateInactiveHeaderBackgroundColourTwo;

            StateInactive.Header.Content.LongText.Color1 = stateInactiveHeaderContentLongTextColourOne;

            StateInactive.Header.Content.LongText.Color2 = stateInactiveHeaderContentLongTextColourTwo;

            StateInactive.Header.Content.LongText.Font = longTextTypeface;

            StateInactive.Header.Content.ShortText.Color1 = stateInactiveHeaderContentShortTextColourOne;

            StateInactive.Header.Content.ShortText.Color2 = stateInactiveHeaderContentShortTextColourTwo;

            StateInactive.Header.Content.ShortText.Font = shortTextTypeface;
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateStateActiveValues(StateActiveBackgroundColourOne, StateActiveBackgroundColourTwo, StateActiveHeaderBackgroundColourOne, StateActiveHeaderBackgroundColourTwo, StateActiveHeaderContentLongTextColourOne, StateActiveHeaderContentLongTextColourTwo, StateActiveHeaderContentShortTextColourOne, StateActiveHeaderContentShortTextColourTwo, LongTextTypeface, ShortTextTypeface);

            UpdateStateCommonValues(StateCommonBackgroundColourOne, StateCommonBackgroundColourTwo, StateCommonHeaderBackgroundColourOne, StateCommonHeaderBackgroundColourTwo, StateCommonHeaderContentLongTextColourOne, StateCommonHeaderContentLongTextColourTwo, StateCommonHeaderContentShortTextColourOne, StateCommonHeaderContentShortTextColourTwo, LongTextTypeface, ShortTextTypeface);

            UpdateCornerRoundingRadius(CornerRoundingRadius);

            UpdateStateInactiveValues(StateInactiveBackgroundColourOne, StateInactiveBackgroundColourTwo, StateInactiveHeaderBackgroundColourOne, StateInactiveHeaderBackgroundColourTwo, StateInactiveHeaderContentLongTextColourOne, StateInactiveHeaderContentLongTextColourTwo, StateInactiveHeaderContentShortTextColourOne, StateInactiveHeaderContentShortTextColourTwo, LongTextTypeface, ShortTextTypeface);

            base.OnPaint(e);
        }
        #endregion
    }
}