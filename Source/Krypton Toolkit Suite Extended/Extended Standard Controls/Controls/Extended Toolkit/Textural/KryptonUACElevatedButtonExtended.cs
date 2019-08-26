using ExtendedStandardControls.Classes;
using KryptonToolkitSuiteExtendedCore.Components;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls.Controls.ExtendedToolkit
{
    public class KryptonUACElevatedButtonExtended : KryptonUACElevatedButton
    {
        #region Variables
        private Color _stateCommonBackGroundColourOne, _stateCommonBackGroundColourTwo, _stateCommonLongTextColourOne, _stateCommonLongTextColourTwo, _stateCommonShortTextColourOne, _stateCommonShortTextColourTwo,
                     _stateDisabledBackGroundColourOne, _stateDisabledBackGroundColourTwo, _stateDisabledLongTextColourOne, _stateDisabledLongTextColourTwo, _stateDisabledShortTextColourOne, _stateDisabledShortTextColourTwo,
                     _stateNormalBackGroundColourOne, _stateNormalBackGroundColourTwo, _stateNormalLongTextColourOne, _stateNormalLongTextColourTwo, _stateNormalShortTextColourOne, _stateNormalShortTextColourTwo,
                     _statePressedBackGroundColourOne, _statePressedBackGroundColourTwo, _statePressedLongTextColourOne, _statePressedLongTextColourTwo, _statePressedShortTextColourOne, _statePressedShortTextColourTwo,
                     _stateTrackingBackGroundColourOne, _stateTrackingBackGroundColourTwo, _stateTrackingLongTextColourOne, _stateTrackingLongTextColourTwo, _stateTrackingShortTextColourOne, _stateTrackingShortTextColourTwo,
                     _overrideDefaultBackGroundColourOne, _overrideDefaultBackGroundColourTwo, _overrideDefaultLongTextColourOne, _overrideDefaultLongTextColourTwo, _overrideDefaultShortTextColourOne, _overrideDefaultShortTextColourTwo,
                     _overrideFocusBackGroundColourOne, _overrideFocusBackGroundColourTwo, _overrideFocusLongTextColourOne, _overrideFocusLongTextColourTwo, _overrideFocusShortTextColourOne, _overrideFocusShortTextColourTwo;

        private Font _longTextTypeface, _shortTextTypeface;

        private Image _image;
        #endregion

        #region Properties

        #region Disabled Properties
        /// <summary>Gets or sets the state disabled back ground colour one.</summary>
        /// <value>The state disabled back ground colour one.</value>
        public Color StateDisabledBackGroundColourOne { get => _stateDisabledBackGroundColourOne; set { _stateDisabledBackGroundColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state disabled back ground colour two.</summary>
        /// <value>The state disabled back ground colour two.</value>
        public Color StateDisabledBackGroundColourTwo { get => _stateDisabledBackGroundColourTwo; set { _stateDisabledBackGroundColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the state disabled long text colour one.</summary>
        /// <value>The state disabled long text colour one.</value>
        public Color StateDisabledLongTextColourOne { get => _stateDisabledLongTextColourOne; set { _stateDisabledLongTextColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state disabled long text colour two.</summary>
        /// <value>The state disabled long text colour two.</value>
        public Color StateDisabledLongTextColourTwo { get => _stateDisabledLongTextColourTwo; set { _stateDisabledLongTextColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the state disabled short text colour one.</summary>
        /// <value>The state disabled short text colour one.</value>
        public Color StateDisabledShortTextColourOne { get => _stateDisabledShortTextColourOne; set { _stateDisabledShortTextColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state disabled short text colour two.</summary>
        /// <value>The state disabled short text colour two.</value>
        public Color StateDisabledShortTextColourTwo { get => _stateDisabledShortTextColourTwo; set { _stateDisabledShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region Common Properties
        /// <summary>Gets or sets the state common back ground colour one.</summary>
        /// <value>The state common back ground colour one.</value>
        [Category("Appearance"), Description("The first background colour.")]
        public Color StateCommonBackGroundColourOne { get => _stateCommonBackGroundColourOne; set { _stateCommonBackGroundColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the back ground colour two.</summary>
        /// <value>The back ground colour two.</value>
        [Category("Appearance"), Description("The second background colour.")]
        public Color StateCommonBackGroundColourTwo { get => _stateCommonBackGroundColourTwo; set { _stateCommonBackGroundColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the long text colour one.</summary>
        /// <value>The long text colour one.</value>
        [Category("Appearance"), Description("The first long text colour.")]
        public Color StateCommonLongTextColourOne { get => _stateCommonLongTextColourOne; set { _stateCommonLongTextColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the long text colour two.</summary>
        /// <value>The long text colour two.</value>
        [Category("Appearance"), Description("The second long text colour.")]
        public Color StateCommonLongTextColourTwo { get => _stateCommonLongTextColourTwo; set { _stateCommonLongTextColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the short text colour one.</summary>
        /// <value>The short text colour one.</value>
        [Category("Appearance"), Description("The first short text colour.")]
        public Color StateCommonShortTextColourOne { get => _stateCommonShortTextColourOne; set { _stateCommonShortTextColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state common short text colour two.</summary>
        /// <value>The state common short text colour two.</value>
        [Category("Appearance"), Description("The second short text colour.")]
        public Color StateCommonShortTextColourTwo { get => _stateCommonShortTextColourTwo; set { _stateCommonShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region Normal Properties
        /// <summary>Gets or sets the state normal back ground colour one.</summary>
        /// <value>The state normal back ground colour one.</value>
        public Color StateNormalBackGroundColourOne { get => _stateNormalBackGroundColourOne; set { _stateNormalBackGroundColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state normal back ground colour two.</summary>
        /// <value>The state normal back ground colour two.</value>
        public Color StateNormalBackGroundColourTwo { get => _stateNormalBackGroundColourTwo; set { _stateNormalBackGroundColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the state normal long text colour one.</summary>
        /// <value>The state normal long text colour one.</value>
        public Color StateNormalLongTextColourOne { get => _stateNormalLongTextColourOne; set { _stateNormalLongTextColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state normal long text colour two.</summary>
        /// <value>The state normal long text colour two.</value>
        public Color StateNormalLongTextColourTwo { get => _stateNormalLongTextColourTwo; set { _stateNormalLongTextColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the state normal short text colour one.</summary>
        /// <value>The state normal short text colour one.</value>
        public Color StateNormalShortTextColourOne { get => _stateNormalShortTextColourOne; set { _stateNormalShortTextColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state normal short text colour two.</summary>
        /// <value>The state normal short text colour two.</value>
        public Color StateNormalShortTextColourTwo { get => _stateNormalShortTextColourTwo; set { _stateNormalShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region Pressed Properties
        /// <summary>Gets or sets the state pressed back ground colour one.</summary>
        /// <value>The state pressed back ground colour one.</value>
        public Color StatePressedBackGroundColourOne { get => _statePressedBackGroundColourOne; set { _statePressedBackGroundColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state pressed back ground colour two.</summary>
        /// <value>The state pressed back ground colour two.</value>
        public Color StatePressedBackGroundColourTwo { get => _statePressedBackGroundColourTwo; set { _statePressedBackGroundColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the state pressed long text colour one.</summary>
        /// <value>The state pressed long text colour one.</value>
        public Color StatePressedLongTextColourOne { get => _statePressedLongTextColourOne; set { _statePressedLongTextColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state pressed long text colour two.</summary>
        /// <value>The state pressed long text colour two.</value>
        public Color StatePressedLongTextColourTwo { get => _statePressedLongTextColourTwo; set { _statePressedLongTextColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the state pressed short text colour one.</summary>
        /// <value>The state pressed short text colour one.</value>
        public Color StatePressedShortTextColourOne { get => _statePressedShortTextColourOne; set { _statePressedShortTextColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state pressed short text colour two.</summary>
        /// <value>The state pressed short text colour two.</value>
        public Color StatePressedShortTextColourTwo { get => _statePressedShortTextColourTwo; set { _statePressedShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region Tracking Properties
        /// <summary>Gets or sets the state tracking back ground colour one.</summary>
        /// <value>The state tracking back ground colour one.</value>
        public Color StateTrackingBackGroundColourOne { get => _stateTrackingBackGroundColourOne; set { _stateTrackingBackGroundColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state tracking back ground colour two.</summary>
        /// <value>The state tracking back ground colour two.</value>
        public Color StateTrackingBackGroundColourTwo { get => _stateTrackingBackGroundColourTwo; set { _stateTrackingBackGroundColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the state tracking long text colour one.</summary>
        /// <value>The state tracking long text colour one.</value>
        public Color StateTrackingLongTextColourOne { get => _stateTrackingLongTextColourOne; set { _stateTrackingLongTextColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state tracking long text colour two.</summary>
        /// <value>The state tracking long text colour two.</value>
        public Color StateTrackingLongTextColourTwo { get => _stateTrackingLongTextColourTwo; set { _stateTrackingLongTextColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the state tracking short text colour one.</summary>
        /// <value>The state tracking short text colour one.</value>
        public Color StateTrackingShortTextColourOne { get => _stateTrackingShortTextColourOne; set { _stateTrackingShortTextColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the state tracking short text colour two.</summary>
        /// <value>The state tracking short text colour two.</value>
        public Color StateTrackingShortTextColourTwo { get => _stateTrackingShortTextColourTwo; set { _stateTrackingShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region Override Default Properties
        /// <summary>Gets or sets the override default back ground colour one.</summary>
        /// <value>The override default back ground colour one.</value>
        public Color OverrideDefaultBackGroundColourOne { get => _overrideDefaultBackGroundColourOne; set { _overrideDefaultBackGroundColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the override default back ground colour two.</summary>
        /// <value>The override default back ground colour two.</value>
        public Color OverrideDefaultBackGroundColourTwo { get => _overrideDefaultBackGroundColourTwo; set { _overrideDefaultBackGroundColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the override default long text colour one.</summary>
        /// <value>The override default long text colour one.</value>
        public Color OverrideDefaultLongTextColourOne { get => _overrideDefaultLongTextColourOne; set { _overrideDefaultLongTextColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the override default long text colour two.</summary>
        /// <value>The override default long text colour two.</value>
        public Color OverrideDefaultLongTextColourTwo { get => _overrideDefaultLongTextColourTwo; set { _overrideDefaultLongTextColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the override default short text colour one.</summary>
        /// <value>The override default short text colour one.</value>
        public Color OverrideDefaultShortTextColourOne { get => _overrideDefaultShortTextColourOne; set { _overrideDefaultShortTextColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the override default short text colour two.</summary>
        /// <value>The override default short text colour two.</value>
        public Color OverrideDefaultShortTextColourTwo { get => _overrideDefaultShortTextColourTwo; set { _overrideDefaultShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region Override Focus Properties
        /// <summary>Gets or sets the override focus back ground colour one.</summary>
        /// <value>The override focus back ground colour one.</value>
        public Color OverrideFocusBackGroundColourOne { get => _overrideFocusBackGroundColourOne; set { _overrideFocusBackGroundColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the override focus back ground colour two.</summary>
        /// <value>The override focus back ground colour two.</value>
        public Color OverrideFocusBackGroundColourTwo { get => _overrideFocusBackGroundColourTwo; set { _overrideFocusBackGroundColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the override focus long text colour one.</summary>
        /// <value>The override focus long text colour one.</value>
        public Color OverrideFocusLongTextColourOne { get => _overrideFocusLongTextColourOne; set { _overrideFocusLongTextColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the override focus long text colour two.</summary>
        /// <value>The override focus long text colour two.</value>
        public Color OverrideFocusLongTextColourTwo { get => _overrideFocusLongTextColourTwo; set { _overrideFocusLongTextColourTwo = value; Invalidate(); } }

        /// <summary>Gets or sets the override focus short text colour one.</summary>
        /// <value>The override focus short text colour one.</value>
        public Color OverrideFocusShortTextColourOne { get => _overrideFocusShortTextColourOne; set { _overrideFocusShortTextColourOne = value; Invalidate(); } }

        /// <summary>Gets or sets the override focus short text colour two.</summary>
        /// <value>The override focus short text colour two.</value>
        public Color OverrideFocusShortTextColourTwo { get => _overrideFocusShortTextColourTwo; set { _overrideFocusShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region Globals
        /// <summary>Gets or sets the long text typeface.</summary>
        /// <value>The long text typeface.</value>
        [Category("Appearance"), Description("The 'Long Text' typeface.")]
        public Font LongTextTypeface { get => _longTextTypeface; set { _longTextTypeface = value; Invalidate(); } }

        /// <summary>Gets or sets the short text typeface.</summary>
        /// <value>The short text typeface.</value>
        [Category("Appearance"), Description("The 'Short Text' typeface.")]
        public Font ShortTextTypeface { get => _shortTextTypeface; set { _shortTextTypeface = value; Invalidate(); } }

        /// <summary>Gets or sets the image.</summary>
        /// <value>The image.</value>
        [Category("Appearance"), Description("The chosen image.")]
        public Image Image { get => _image; set { _image = value; Invalidate(); } }
        #endregion

        #endregion

        #region Constructor
        /// <summary>Initializes a new instance of the <see cref="KryptonUACElevatedButtonExtended"/> class.</summary>
        public KryptonUACElevatedButtonExtended()
        {
            #region State Disabled
            StateDisabledBackGroundColourOne = Color.Empty;

            StateDisabledBackGroundColourTwo = Color.Empty;

            StateDisabledLongTextColourOne = Color.Empty;

            StateDisabledLongTextColourTwo = Color.Empty;

            StateDisabledShortTextColourOne = Color.Empty;

            StateDisabledShortTextColourTwo = Color.Empty;
            #endregion

            #region State Common
            StateCommonBackGroundColourOne = Color.Empty;

            StateCommonBackGroundColourTwo = Color.Empty;

            StateCommonLongTextColourOne = Color.Empty;

            StateCommonLongTextColourTwo = Color.Empty;

            StateCommonShortTextColourOne = Color.Empty;

            StateCommonShortTextColourTwo = Color.Empty;
            #endregion

            #region State Normal
            StateNormalBackGroundColourOne = Color.Empty;

            StateNormalBackGroundColourTwo = Color.Empty;

            StateNormalLongTextColourOne = Color.Empty;

            StateNormalLongTextColourTwo = Color.Empty;

            StateNormalShortTextColourOne = Color.Empty;

            StateNormalShortTextColourTwo = Color.Empty;
            #endregion

            #region State Pressed
            StatePressedBackGroundColourOne = Color.Empty;

            StatePressedBackGroundColourTwo = Color.Empty;

            StatePressedLongTextColourOne = Color.Empty;

            StatePressedLongTextColourTwo = Color.Empty;

            StatePressedShortTextColourOne = Color.Empty;

            StatePressedShortTextColourTwo = Color.Empty;
            #endregion

            #region State Tracking
            StateTrackingBackGroundColourOne = Color.Empty;

            StateTrackingBackGroundColourTwo = Color.Empty;

            StateTrackingLongTextColourOne = Color.Empty;

            StateTrackingLongTextColourTwo = Color.Empty;

            StateTrackingShortTextColourOne = Color.Empty;

            StateTrackingShortTextColourTwo = Color.Empty;
            #endregion

            #region Override Default
            OverrideDefaultBackGroundColourOne = Color.Empty;

            OverrideDefaultBackGroundColourTwo = Color.Empty;

            OverrideDefaultLongTextColourOne = Color.Empty;

            OverrideDefaultLongTextColourTwo = Color.Empty;

            OverrideDefaultShortTextColourOne = Color.Empty;

            OverrideDefaultShortTextColourTwo = Color.Empty;
            #endregion

            #region Override Focus
            OverrideFocusBackGroundColourOne = Color.Empty;

            OverrideFocusBackGroundColourTwo = Color.Empty;

            OverrideFocusLongTextColourOne = Color.Empty;

            OverrideFocusLongTextColourTwo = Color.Empty;

            OverrideFocusShortTextColourOne = Color.Empty;

            OverrideFocusShortTextColourTwo = Color.Empty;
            #endregion

            #region Globals
            LongTextTypeface = Typeface.DefaultTypeface();

            ShortTextTypeface = Typeface.DefaultTypeface();

            Image = null;
            #endregion

            UpdateStateCommonAppearanceValues(StateCommonBackGroundColourOne, StateCommonBackGroundColourTwo, StateCommonLongTextColourOne, StateCommonLongTextColourTwo, LongTextTypeface, StateCommonShortTextColourOne, StateCommonShortTextColourTwo, ShortTextTypeface, Image);

            UpdateStateDisabledAppearanceValues(StateDisabledBackGroundColourOne, StateDisabledBackGroundColourTwo, StateDisabledLongTextColourOne, StateDisabledLongTextColourTwo, StateDisabledShortTextColourOne, StateDisabledShortTextColourTwo, LongTextTypeface, ShortTextTypeface, Image);

            UpdateStateNormalAppearanceValues(StateNormalBackGroundColourOne, StateNormalBackGroundColourTwo, StateNormalLongTextColourOne, StateNormalLongTextColourTwo, StateNormalShortTextColourOne, StateNormalShortTextColourTwo, LongTextTypeface, ShortTextTypeface, Image);

            UpdateStatePressedAppearanceValues(StatePressedBackGroundColourOne, StatePressedBackGroundColourTwo, StatePressedLongTextColourOne, StatePressedLongTextColourTwo, StatePressedShortTextColourOne, StatePressedShortTextColourTwo, LongTextTypeface, ShortTextTypeface, Image);

            UpdateStateTrackingAppearanceValues(StateTrackingBackGroundColourOne, StateTrackingBackGroundColourTwo, StateTrackingLongTextColourOne, StateTrackingLongTextColourTwo, StateTrackingShortTextColourOne, StateTrackingShortTextColourTwo, LongTextTypeface, ShortTextTypeface, Image);

            UpdateOverrideDefaultAppearanceValues(OverrideDefaultBackGroundColourOne, OverrideDefaultBackGroundColourTwo, OverrideDefaultLongTextColourOne, OverrideDefaultLongTextColourTwo, OverrideDefaultShortTextColourOne, OverrideDefaultShortTextColourTwo, LongTextTypeface, ShortTextTypeface, Image);

            UpdateOverrideFocusAppearanceValues(OverrideFocusBackGroundColourOne, OverrideFocusBackGroundColourTwo, OverrideFocusLongTextColourOne, OverrideFocusLongTextColourTwo, OverrideFocusShortTextColourOne, OverrideFocusShortTextColourTwo, LongTextTypeface, ShortTextTypeface, Image);
        }
        #endregion

        #region Method
        /// <summary>Updates the state common appearance values.</summary>
        /// <param name="backGroundColourOne">The back ground colour one.</param>
        /// <param name="backGroundColourTwo">The back ground colour two.</param>
        /// <param name="longTextColourOne">The long text colour one.</param>
        /// <param name="longTextColourTwo">The long text colour two.</param>
        /// <param name="longTextTypeface">The long text typeface.</param>
        /// <param name="shortTextColourOne">The short text colour one.</param>
        /// <param name="shortTextColourTwo">The short text colour two.</param>
        /// <param name="shortTextTypeface">The short text typeface.</param>
        /// <param name="image">The image.</param>
        private void UpdateStateCommonAppearanceValues(Color backGroundColourOne, Color backGroundColourTwo, Color longTextColourOne, Color longTextColourTwo, Font longTextTypeface, Color shortTextColourOne, Color shortTextColourTwo, Font shortTextTypeface, Image image)
        {
            StateCommon.Back.Color1 = backGroundColourOne;

            StateCommon.Back.Color2 = backGroundColourTwo;

            StateCommon.Content.LongText.Color1 = longTextColourOne;

            StateCommon.Content.LongText.Color2 = longTextColourTwo;

            StateCommon.Content.LongText.Font = longTextTypeface;

            StateCommon.Content.LongText.Image = image;

            StateCommon.Content.ShortText.Color1 = shortTextColourOne;

            StateCommon.Content.ShortText.Color2 = shortTextColourTwo;

            StateCommon.Content.ShortText.Font = shortTextTypeface;

            StateCommon.Content.ShortText.Image = image;
        }

        /// <summary>Updates the state disabled appearance values.</summary>
        /// <param name="stateDisabledBackGroundColourOne">The state disabled back ground colour one.</param>
        /// <param name="stateDisabledBackGroundColourTwo">The state disabled back ground colour two.</param>
        /// <param name="stateDisabledLongTextColourOne">The state disabled long text colour one.</param>
        /// <param name="stateDisabledLongTextColourTwo">The state disabled long text colour two.</param>
        /// <param name="stateDisabledShortTextColourOne">The state disabled short text colour one.</param>
        /// <param name="stateDisabledShortTextColourTwo">The state disabled short text colour two.</param>
        /// <param name="longTextTypeface">The long text typeface.</param>
        /// <param name="shortTextTypeface">The short text typeface.</param>
        /// <param name="image">The image.</param>
        private void UpdateStateDisabledAppearanceValues(Color stateDisabledBackGroundColourOne, Color stateDisabledBackGroundColourTwo, Color stateDisabledLongTextColourOne, Color stateDisabledLongTextColourTwo, Color stateDisabledShortTextColourOne, Color stateDisabledShortTextColourTwo, Font longTextTypeface, Font shortTextTypeface, Image image)
        {
            StateDisabled.Back.Color1 = stateDisabledBackGroundColourOne;

            StateDisabled.Back.Color2 = stateDisabledBackGroundColourTwo;

            StateDisabled.Content.LongText.Color1 = stateDisabledLongTextColourOne;

            StateDisabled.Content.LongText.Color2 = stateDisabledLongTextColourTwo;

            StateDisabled.Content.LongText.Font = longTextTypeface;

            StateDisabled.Content.LongText.Image = image;

            StateDisabled.Content.ShortText.Color1 = stateDisabledShortTextColourOne;

            StateDisabled.Content.ShortText.Color2 = stateDisabledShortTextColourTwo;

            StateDisabled.Content.ShortText.Font = shortTextTypeface;

            StateDisabled.Content.ShortText.Image = image;
        }

        /// <summary>Updates the state normal appearance values.</summary>
        /// <param name="stateNormalBackGroundColourOne">The state normal back ground colour one.</param>
        /// <param name="stateNormalBackGroundColourTwo">The state normal back ground colour two.</param>
        /// <param name="stateNormalLongTextColourOne">The state normal long text colour one.</param>
        /// <param name="stateNormalLongTextColourTwo">The state normal long text colour two.</param>
        /// <param name="stateNormalShortTextColourOne">The state normal short text colour one.</param>
        /// <param name="stateNormalShortTextColourTwo">The state normal short text colour two.</param>
        /// <param name="longTextTypeface">The long text typeface.</param>
        /// <param name="shortTextTypeface">The short text typeface.</param>
        /// <param name="image">The image.</param>
        private void UpdateStateNormalAppearanceValues(Color stateNormalBackGroundColourOne, Color stateNormalBackGroundColourTwo, Color stateNormalLongTextColourOne, Color stateNormalLongTextColourTwo, Color stateNormalShortTextColourOne, Color stateNormalShortTextColourTwo, Font longTextTypeface, Font shortTextTypeface, Image image)
        {
            StateNormal.Back.Color1 = stateNormalBackGroundColourOne;

            StateNormal.Back.Color2 = stateNormalBackGroundColourTwo;

            StateNormal.Content.LongText.Color1 = stateNormalLongTextColourOne;

            StateNormal.Content.LongText.Color2 = stateNormalLongTextColourTwo;

            StateNormal.Content.LongText.Font = longTextTypeface;

            StateNormal.Content.LongText.Image = image;

            StateNormal.Content.ShortText.Color1 = stateNormalShortTextColourOne;

            StateNormal.Content.ShortText.Color2 = stateNormalShortTextColourTwo;

            StateNormal.Content.ShortText.Font = shortTextTypeface;

            StateNormal.Content.ShortText.Image = image;
        }

        /// <summary>Updates the state pressed appearance values.</summary>
        /// <param name="statePressedBackGroundColourOne">The state pressed back ground colour one.</param>
        /// <param name="statePressedBackGroundColourTwo">The state pressed back ground colour two.</param>
        /// <param name="statePressedLongTextColourOne">The state pressed long text colour one.</param>
        /// <param name="statePressedLongTextColourTwo">The state pressed long text colour two.</param>
        /// <param name="statePressedShortTextColourOne">The state pressed short text colour one.</param>
        /// <param name="statePressedShortTextColourTwo">The state pressed short text colour two.</param>
        /// <param name="longTextTypeface">The long text typeface.</param>
        /// <param name="shortTextTypeface">The short text typeface.</param>
        /// <param name="image">The image.</param>
        private void UpdateStatePressedAppearanceValues(Color statePressedBackGroundColourOne, Color statePressedBackGroundColourTwo, Color statePressedLongTextColourOne, Color statePressedLongTextColourTwo, Color statePressedShortTextColourOne, Color statePressedShortTextColourTwo, Font longTextTypeface, Font shortTextTypeface, Image image)
        {
            StatePressed.Back.Color1 = statePressedBackGroundColourOne;

            StatePressed.Back.Color2 = statePressedBackGroundColourTwo;

            StatePressed.Content.LongText.Color1 = statePressedLongTextColourOne;

            StatePressed.Content.LongText.Color2 = statePressedLongTextColourTwo;

            StatePressed.Content.LongText.Font = longTextTypeface;

            StatePressed.Content.LongText.Image = image;

            StatePressed.Content.ShortText.Color1 = statePressedShortTextColourOne;

            StatePressed.Content.ShortText.Color2 = statePressedShortTextColourTwo;

            StatePressed.Content.ShortText.Font = shortTextTypeface;

            StatePressed.Content.ShortText.Image = image;
        }

        /// <summary>Updates the state tracking appearance values.</summary>
        /// <param name="stateTrackingBackGroundColourOne">The state tracking back ground colour one.</param>
        /// <param name="stateTrackingBackGroundColourTwo">The state tracking back ground colour two.</param>
        /// <param name="stateTrackingLongTextColourOne">The state tracking long text colour one.</param>
        /// <param name="stateTrackingLongTextColourTwo">The state tracking long text colour two.</param>
        /// <param name="stateTrackingShortTextColourOne">The state tracking short text colour one.</param>
        /// <param name="stateTrackingShortTextColourTwo">The state tracking short text colour two.</param>
        /// <param name="longTextTypeface">The long text typeface.</param>
        /// <param name="shortTextTypeface">The short text typeface.</param>
        /// <param name="image">The image.</param>
        private void UpdateStateTrackingAppearanceValues(Color stateTrackingBackGroundColourOne, Color stateTrackingBackGroundColourTwo, Color stateTrackingLongTextColourOne, Color stateTrackingLongTextColourTwo, Color stateTrackingShortTextColourOne, Color stateTrackingShortTextColourTwo, Font longTextTypeface, Font shortTextTypeface, Image image)
        {
            StateTracking.Back.Color1 = stateTrackingBackGroundColourOne;

            StateTracking.Back.Color2 = stateTrackingBackGroundColourTwo;

            StateTracking.Content.LongText.Color1 = stateTrackingLongTextColourOne;

            StateTracking.Content.LongText.Color2 = stateTrackingLongTextColourTwo;

            StateTracking.Content.LongText.Font = longTextTypeface;

            StateTracking.Content.LongText.Image = image;

            StateTracking.Content.ShortText.Color1 = stateTrackingShortTextColourOne;

            StateTracking.Content.ShortText.Color2 = stateTrackingShortTextColourTwo;

            StateTracking.Content.ShortText.Font = shortTextTypeface;

            StateTracking.Content.ShortText.Image = image;
        }

        /// <summary>Updates the override default appearance values.</summary>
        /// <param name="overrideDefaultBackGroundColourOne">The override default back ground colour one.</param>
        /// <param name="overrideDefaultBackGroundColourTwo">The override default back ground colour two.</param>
        /// <param name="overrideDefaultLongTextColourOne">The override default long text colour one.</param>
        /// <param name="overrideDefaultLongTextColourTwo">The override default long text colour two.</param>
        /// <param name="overrideDefaultShortTextColourOne">The override default short text colour one.</param>
        /// <param name="overrideDefaultShortTextColourTwo">The override default short text colour two.</param>
        /// <param name="longTextTypeface">The long text typeface.</param>
        /// <param name="shortTextTypeface">The short text typeface.</param>
        /// <param name="image">The image.</param>
        private void UpdateOverrideDefaultAppearanceValues(Color overrideDefaultBackGroundColourOne, Color overrideDefaultBackGroundColourTwo, Color overrideDefaultLongTextColourOne, Color overrideDefaultLongTextColourTwo, Color overrideDefaultShortTextColourOne, Color overrideDefaultShortTextColourTwo, Font longTextTypeface, Font shortTextTypeface, Image image)
        {
            OverrideDefault.Back.Color1 = overrideDefaultBackGroundColourOne;

            OverrideDefault.Back.Color2 = overrideDefaultBackGroundColourTwo;

            OverrideDefault.Content.LongText.Color1 = overrideDefaultLongTextColourOne;

            OverrideDefault.Content.LongText.Color2 = overrideDefaultLongTextColourTwo;

            OverrideDefault.Content.LongText.Font = longTextTypeface;

            OverrideDefault.Content.LongText.Image = image;

            OverrideDefault.Content.ShortText.Color1 = overrideDefaultShortTextColourOne;

            OverrideDefault.Content.ShortText.Color2 = overrideDefaultShortTextColourTwo;

            OverrideDefault.Content.ShortText.Font = shortTextTypeface;

            OverrideDefault.Content.ShortText.Image = image;
        }

        /// <summary>Updates the override focus appearance values.</summary>
        /// <param name="overrideFocusBackGroundColourOne">The override focus back ground colour one.</param>
        /// <param name="overrideFocusBackGroundColourTwo">The override focus back ground colour two.</param>
        /// <param name="overrideFocusLongTextColourOne">The override focus long text colour one.</param>
        /// <param name="overrideFocusLongTextColourTwo">The override focus long text colour two.</param>
        /// <param name="overrideFocusShortTextColourOne">The override focus short text colour one.</param>
        /// <param name="overrideFocusShortTextColourTwo">The override focus short text colour two.</param>
        /// <param name="longTextTypeface">The long text typeface.</param>
        /// <param name="shortTextTypeface">The short text typeface.</param>
        /// <param name="image">The image.</param>
        private void UpdateOverrideFocusAppearanceValues(Color overrideFocusBackGroundColourOne, Color overrideFocusBackGroundColourTwo, Color overrideFocusLongTextColourOne, Color overrideFocusLongTextColourTwo, Color overrideFocusShortTextColourOne, Color overrideFocusShortTextColourTwo, Font longTextTypeface, Font shortTextTypeface, Image image)
        {
            OverrideFocus.Back.Color1 = overrideFocusBackGroundColourOne;

            OverrideFocus.Back.Color2 = overrideFocusBackGroundColourTwo;

            OverrideFocus.Content.LongText.Color1 = overrideFocusLongTextColourOne;

            OverrideFocus.Content.LongText.Color2 = overrideFocusLongTextColourTwo;

            OverrideFocus.Content.LongText.Font = longTextTypeface;

            OverrideFocus.Content.LongText.Image = image;

            OverrideFocus.Content.ShortText.Color1 = overrideFocusShortTextColourOne;

            OverrideFocus.Content.ShortText.Color2 = overrideFocusShortTextColourTwo;

            OverrideFocus.Content.ShortText.Font = shortTextTypeface;

            OverrideFocus.Content.ShortText.Image = image;
        }
        #endregion

        #region Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateStateCommonAppearanceValues(StateCommonBackGroundColourOne, StateCommonBackGroundColourTwo, StateCommonLongTextColourOne, StateCommonLongTextColourTwo, LongTextTypeface, StateCommonShortTextColourOne, StateCommonShortTextColourTwo, ShortTextTypeface, Image);

            UpdateStateDisabledAppearanceValues(StateDisabledBackGroundColourOne, StateDisabledBackGroundColourTwo, StateDisabledLongTextColourOne, StateDisabledLongTextColourTwo, StateDisabledShortTextColourOne, StateDisabledShortTextColourTwo, LongTextTypeface, ShortTextTypeface, Image);

            UpdateStateNormalAppearanceValues(StateNormalBackGroundColourOne, StateNormalBackGroundColourTwo, StateNormalLongTextColourOne, StateNormalLongTextColourTwo, StateNormalShortTextColourOne, StateNormalShortTextColourTwo, LongTextTypeface, ShortTextTypeface, Image);

            UpdateStatePressedAppearanceValues(StatePressedBackGroundColourOne, StatePressedBackGroundColourTwo, StatePressedLongTextColourOne, StatePressedLongTextColourTwo, StatePressedShortTextColourOne, StatePressedShortTextColourTwo, LongTextTypeface, ShortTextTypeface, Image);

            UpdateStateTrackingAppearanceValues(StateTrackingBackGroundColourOne, StateTrackingBackGroundColourTwo, StateTrackingLongTextColourOne, StateTrackingLongTextColourTwo, StateTrackingShortTextColourOne, StateTrackingShortTextColourTwo, LongTextTypeface, ShortTextTypeface, Image);

            UpdateOverrideDefaultAppearanceValues(OverrideDefaultBackGroundColourOne, OverrideDefaultBackGroundColourTwo, OverrideDefaultLongTextColourOne, OverrideDefaultLongTextColourTwo, OverrideDefaultShortTextColourOne, OverrideDefaultShortTextColourTwo, LongTextTypeface, ShortTextTypeface, Image);

            UpdateOverrideFocusAppearanceValues(OverrideFocusBackGroundColourOne, OverrideFocusBackGroundColourTwo, OverrideFocusLongTextColourOne, OverrideFocusLongTextColourTwo, OverrideFocusShortTextColourOne, OverrideFocusShortTextColourTwo, LongTextTypeface, ShortTextTypeface, Image);

            base.OnPaint(e);
        }
        #endregion
    }
}