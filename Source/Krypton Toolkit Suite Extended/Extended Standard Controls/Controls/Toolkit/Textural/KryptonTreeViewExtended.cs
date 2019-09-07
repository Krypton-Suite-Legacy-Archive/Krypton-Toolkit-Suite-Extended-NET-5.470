using ComponentFactory.Krypton.Toolkit;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls.Controls
{
    [ToolboxBitmap(typeof(KryptonTreeView))]
    public class KryptonTreeViewExtended : KryptonTreeView
    {
        #region Variables
        private Color _overrideFocusBackGroundColour, _overrideFocusNodeBackgroundColourOne, _overrideFocusNodeBackgroundColourTwo, _overrideFocusNodeLongTextColourOne, _overrideFocusNodeLongTextColourTwo, _overrideFocusNodeShortTextColourOne, _overrideFocusNodeShortTextColourTwo,
                      _stateCheckedNormalBackGroundColour, _stateCheckedNormalNodeBackgroundColourOne, _stateCheckedNormalNodeBackgroundColourTwo, _stateCheckedNormalNodeLongTextColourOne, _stateCheckedNormalNodeLongTextColourTwo, _stateCheckedNormalNodeShortTextColourOne, _stateCheckedNormalNodeShortTextColourTwo,
                      _stateCheckedPressedBackGroundColour, _stateCheckedPressedNodeBackgroundColourOne, _stateCheckedPressedNodeBackgroundColourTwo, _stateCheckedPressedNodeLongTextColourOne, _stateCheckedPressedNodeLongTextColourTwo, _stateCheckedPressedNodeShortTextColourOne, _stateCheckedPressedNodeShortTextColourTwo,
                      _stateCheckedTrackingBackGroundColour, _stateCheckedTrackingNodeBackgroundColourOne, _stateCheckedTrackingNodeBackgroundColourTwo, _stateCheckedTrackingNodeLongTextColourOne, _stateCheckedTrackingNodeLongTextColourTwo, _stateCheckedTrackingNodeShortTextColourOne, _stateCheckedTrackingNodeShortTextColourTwo,
                      _stateCommonBackGroundColour, _stateCommonNodeBackgroundColourOne, _stateCommonNodeBackgroundColourTwo, _stateCommonNodeLongTextColourOne, _stateCommonNodeLongTextColourTwo, _stateCommonNodeShortTextColourOne, _stateCommonNodeShortTextColourTwo,
                      _stateDisabledBackGroundColour, _stateDisabledNodeBackgroundColourOne, _stateDisabledNodeBackgroundColourTwo, _stateDisabledNodeLongTextColourOne, _stateDisabledNodeLongTextColourTwo, _stateDisabledNodeShortTextColourOne, _stateDisabledNodeShortTextColourTwo,
                      _stateNormalBackGroundColour, _stateNormalNodeBackgroundColourOne, _stateNormalNodeBackgroundColourTwo, _stateNormalNodeLongTextColourOne, _stateNormalNodeLongTextColourTwo, _stateNormalNodeShortTextColourOne, _stateNormalNodeShortTextColourTwo,
                      _statePressedBackGroundColour, _statePressedNodeBackgroundColourOne, _statePressedNodeBackgroundColourTwo, _statePressedNodeLongTextColourOne, _statePressedNodeLongTextColourTwo, _statePressedNodeShortTextColourOne, _statePressedNodeShortTextColourTwo,
                      _stateTrackingBackGroundColour, _stateTrackingNodeBackgroundColourOne, _stateTrackingNodeBackgroundColourTwo, _stateTrackingNodeLongTextColourOne, _stateTrackingNodeLongTextColourTwo, _stateTrackingNodeShortTextColourOne, _stateTrackingNodeShortTextColourTwo;

        private Font _longTextTypeface, _shortTextTypeface;
        #endregion

        #region Properties

        #region Override Focus
        public Color OverrideFocusBackgroundColour { get => _overrideFocusBackGroundColour; set { _overrideFocusBackGroundColour = value; Invalidate(); } }

        public Color OverrideFocusNodeBackgroundColourOne { get => _overrideFocusNodeBackgroundColourOne; set { _overrideFocusNodeBackgroundColourOne = value; Invalidate(); } }

        public Color OverrideFocusNodeBackgroundColourTwo { get => _overrideFocusNodeBackgroundColourTwo; set { _overrideFocusNodeBackgroundColourTwo = value; Invalidate(); } }

        public Color OverrideFocusNodeLongTextColourOne { get => _overrideFocusNodeLongTextColourOne; set { _overrideFocusNodeLongTextColourOne = value; Invalidate(); } }

        public Color OverrideFocusNodeLongTextColourTwo { get => _overrideFocusNodeLongTextColourTwo; set { _overrideFocusNodeLongTextColourTwo = value; Invalidate(); } }

        public Color OverrideFocusNodeShortTextColourOne { get => _overrideFocusNodeShortTextColourOne; set { _overrideFocusNodeShortTextColourOne = value; Invalidate(); } }

        public Color OverrideFocusNodeShortTextColourTwo { get => _overrideFocusNodeShortTextColourTwo; set { _overrideFocusNodeShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region State Checked Normal
        public Color StateCheckedNormalBackgroundColour { get => _stateCheckedNormalBackGroundColour; set { _stateCheckedNormalBackGroundColour = value; Invalidate(); } }

        public Color StateCheckedNormalNodeBackgroundColourOne { get => _stateCheckedNormalNodeBackgroundColourOne; set { _stateCheckedNormalNodeBackgroundColourOne = value; Invalidate(); } }

        public Color StateCheckedNormalNodeBackgroundColourTwo { get => _stateCheckedNormalNodeBackgroundColourTwo; set { _stateCheckedNormalNodeBackgroundColourTwo = value; Invalidate(); } }

        public Color StateCheckedNormalNodeLongTextColourOne { get => _stateCheckedNormalNodeLongTextColourOne; set { _stateCheckedNormalNodeLongTextColourOne = value; Invalidate(); } }

        public Color StateCheckedNormalNodeLongTextColourTwo { get => _stateCheckedNormalNodeLongTextColourTwo; set { _stateCheckedNormalNodeLongTextColourTwo = value; Invalidate(); } }

        public Color StateCheckedNormalNodeShortTextColourOne { get => _stateCheckedNormalNodeShortTextColourOne; set { _stateCheckedNormalNodeShortTextColourOne = value; Invalidate(); } }

        public Color StateCheckedNormalNodeShortTextColourTwo { get => _stateCheckedNormalNodeShortTextColourTwo; set { _stateCheckedNormalNodeShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region State Checked Pressed
        public Color StateCheckedPressedBackgroundColour { get => _stateCheckedPressedBackGroundColour; set { _stateCheckedPressedBackGroundColour = value; Invalidate(); } }

        public Color StateCheckedPressedNodeBackgroundColourOne { get => _stateCheckedPressedNodeBackgroundColourOne; set { _stateCheckedPressedNodeBackgroundColourOne = value; Invalidate(); } }

        public Color StateCheckedPressedNodeBackgroundColourTwo { get => _stateCheckedPressedNodeBackgroundColourTwo; set { _stateCheckedPressedNodeBackgroundColourTwo = value; Invalidate(); } }

        public Color StateCheckedPressedNodeLongTextColourOne { get => _stateCheckedPressedNodeLongTextColourOne; set { _stateCheckedPressedNodeLongTextColourOne = value; Invalidate(); } }

        public Color StateCheckedPressedNodeLongTextColourTwo { get => _stateCheckedPressedNodeLongTextColourTwo; set { _stateCheckedPressedNodeLongTextColourTwo = value; Invalidate(); } }

        public Color StateCheckedPressedNodeShortTextColourOne { get => _stateCheckedPressedNodeShortTextColourOne; set { _stateCheckedPressedNodeShortTextColourOne = value; Invalidate(); } }

        public Color StateCheckedPressedNodeShortTextColourTwo { get => _stateCheckedPressedNodeShortTextColourTwo; set { _stateCheckedPressedNodeShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region State Checked Tracking
        public Color StateCheckedTrackingBackgroundColour { get => _stateCheckedTrackingBackGroundColour; set { _stateCheckedTrackingBackGroundColour = value; Invalidate(); } }

        public Color StateCheckedTrackingNodeBackgroundColourOne { get => _stateCheckedTrackingNodeBackgroundColourOne; set { _stateCheckedTrackingNodeBackgroundColourOne = value; Invalidate(); } }

        public Color StateCheckedTrackingNodeBackgroundColourTwo { get => _stateCheckedTrackingNodeBackgroundColourTwo; set { _stateCheckedTrackingNodeBackgroundColourTwo = value; Invalidate(); } }

        public Color StateCheckedTrackingNodeLongTextColourOne { get => _stateCheckedTrackingNodeLongTextColourOne; set { _stateCheckedTrackingNodeLongTextColourOne = value; Invalidate(); } }

        public Color StateCheckedTrackingNodeLongTextColourTwo { get => _stateCheckedTrackingNodeLongTextColourTwo; set { _stateCheckedTrackingNodeLongTextColourTwo = value; Invalidate(); } }

        public Color StateCheckedTrackingNodeShortTextColourOne { get => _stateCheckedTrackingNodeShortTextColourOne; set { _stateCheckedTrackingNodeShortTextColourOne = value; Invalidate(); } }

        public Color StateCheckedTrackingNodeShortTextColourTwo { get => _stateCheckedTrackingNodeShortTextColourTwo; set { _stateCheckedTrackingNodeShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region State Common
        public Color StateCommonBackgroundColour { get => _stateCommonBackGroundColour; set { _stateCommonBackGroundColour = value; Invalidate(); } }

        public Color StateCommonNodeBackgroundColourOne { get => _stateCommonNodeBackgroundColourOne; set { _stateCommonNodeBackgroundColourOne = value; Invalidate(); } }

        public Color StateCommonNodeBackgroundColourTwo { get => _stateCommonNodeBackgroundColourTwo; set { _stateCommonNodeBackgroundColourTwo = value; Invalidate(); } }

        public Color StateCommonNodeLongTextColourOne { get => _stateCommonNodeLongTextColourOne; set { _stateCommonNodeLongTextColourOne = value; Invalidate(); } }

        public Color StateCommonNodeLongTextColourTwo { get => _stateCommonNodeLongTextColourTwo; set { _stateCommonNodeLongTextColourTwo = value; Invalidate(); } }

        public Color StateCommonNodeShortTextColourOne { get => _stateCommonNodeShortTextColourOne; set { _stateCommonNodeShortTextColourOne = value; Invalidate(); } }

        public Color StateCommonNodeShortTextColourTwo { get => _stateCommonNodeShortTextColourTwo; set { _stateCommonNodeShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region State Disabled
        public Color StateDisabledBackgroundColour { get => _stateDisabledBackGroundColour; set { _stateDisabledBackGroundColour = value; Invalidate(); } }

        public Color StateDisabledNodeBackgroundColourOne { get => _stateDisabledNodeBackgroundColourOne; set { _stateDisabledNodeBackgroundColourOne = value; Invalidate(); } }

        public Color StateDisabledNodeBackgroundColourTwo { get => _stateDisabledNodeBackgroundColourTwo; set { _stateDisabledNodeBackgroundColourTwo = value; Invalidate(); } }

        public Color StateDisabledNodeLongTextColourOne { get => _stateDisabledNodeLongTextColourOne; set { _stateDisabledNodeLongTextColourOne = value; Invalidate(); } }

        public Color StateDisabledNodeLongTextColourTwo { get => _stateDisabledNodeLongTextColourTwo; set { _stateDisabledNodeLongTextColourTwo = value; Invalidate(); } }

        public Color StateDisabledNodeShortTextColourOne { get => _stateDisabledNodeShortTextColourOne; set { _stateDisabledNodeShortTextColourOne = value; Invalidate(); } }

        public Color StateDisabledNodeShortTextColourTwo { get => _stateDisabledNodeShortTextColourTwo; set { _stateDisabledNodeShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region State Normal
        public Color StateNormalBackgroundColour { get => _stateNormalBackGroundColour; set { _stateNormalBackGroundColour = value; Invalidate(); } }

        public Color StateNormalNodeBackgroundColourOne { get => _stateNormalNodeBackgroundColourOne; set { _stateNormalNodeBackgroundColourOne = value; Invalidate(); } }

        public Color StateNormalNodeBackgroundColourTwo { get => _stateNormalNodeBackgroundColourTwo; set { _stateNormalNodeBackgroundColourTwo = value; Invalidate(); } }

        public Color StateNormalNodeLongTextColourOne { get => _stateNormalNodeLongTextColourOne; set { _stateNormalNodeLongTextColourOne = value; Invalidate(); } }

        public Color StateNormalNodeLongTextColourTwo { get => _stateNormalNodeLongTextColourTwo; set { _stateNormalNodeLongTextColourTwo = value; Invalidate(); } }

        public Color StateNormalNodeShortTextColourOne { get => _stateNormalNodeShortTextColourOne; set { _stateNormalNodeShortTextColourOne = value; Invalidate(); } }

        public Color StateNormalNodeShortTextColourTwo { get => _stateNormalNodeShortTextColourTwo; set { _stateNormalNodeShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region State Pressed
        public Color StatePressedBackgroundColour { get => _statePressedBackGroundColour; set { _statePressedBackGroundColour = value; Invalidate(); } }

        public Color StatePressedNodeBackgroundColourOne { get => _statePressedNodeBackgroundColourOne; set { _statePressedNodeBackgroundColourOne = value; Invalidate(); } }

        public Color StatePressedNodeBackgroundColourTwo { get => _statePressedNodeBackgroundColourTwo; set { _statePressedNodeBackgroundColourTwo = value; Invalidate(); } }

        public Color StatePressedNodeLongTextColourOne { get => _statePressedNodeLongTextColourOne; set { _statePressedNodeLongTextColourOne = value; Invalidate(); } }

        public Color StatePressedNodeLongTextColourTwo { get => _statePressedNodeLongTextColourTwo; set { _statePressedNodeLongTextColourTwo = value; Invalidate(); } }

        public Color StatePressedNodeShortTextColourOne { get => _statePressedNodeShortTextColourOne; set { _statePressedNodeShortTextColourOne = value; Invalidate(); } }

        public Color StatePressedNodeShortTextColourTwo { get => _statePressedNodeShortTextColourTwo; set { _statePressedNodeShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region State Tracking
        public Color StateTrackingBackgroundColour { get => _stateTrackingBackGroundColour; set { _stateTrackingBackGroundColour = value; Invalidate(); } }

        public Color StateTrackingNodeBackgroundColourOne { get => _stateTrackingNodeBackgroundColourOne; set { _stateTrackingNodeBackgroundColourOne = value; Invalidate(); } }

        public Color StateTrackingNodeBackgroundColourTwo { get => _stateTrackingNodeBackgroundColourTwo; set { _stateTrackingNodeBackgroundColourTwo = value; Invalidate(); } }

        public Color StateTrackingNodeLongTextColourOne { get => _stateTrackingNodeLongTextColourOne; set { _stateTrackingNodeLongTextColourOne = value; Invalidate(); } }

        public Color StateTrackingNodeLongTextColourTwo { get => _stateTrackingNodeLongTextColourTwo; set { _stateTrackingNodeLongTextColourTwo = value; Invalidate(); } }

        public Color StateTrackingNodeShortTextColourOne { get => _stateTrackingNodeShortTextColourOne; set { _stateTrackingNodeShortTextColourOne = value; Invalidate(); } }

        public Color StateTrackingNodeShortTextColourTwo { get => _stateTrackingNodeShortTextColourTwo; set { _stateTrackingNodeShortTextColourTwo = value; Invalidate(); } }
        #endregion

        [Category("Appearance"), Description("The 'Long Text' typeface.")]
        public Font LongTextTypeface { get => _longTextTypeface; set { _longTextTypeface = value; Invalidate(); } }

        [Category("Appearance"), Description("The 'Short Text' typeface.")]
        public Font ShortTextTypeface { get => _shortTextTypeface; set { _shortTextTypeface = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonTreeViewExtended()
        {
            StateCommonBackgroundColour = Color.Empty;

            StateCommonNodeBackgroundColourOne = Color.Empty;

            StateCommonNodeBackgroundColourTwo = Color.Empty;

            StateCommonNodeLongTextColourOne = Color.Empty;

            StateCommonNodeLongTextColourTwo = Color.Empty;

            StateCommonNodeShortTextColourOne = Color.Empty;

            StateCommonNodeShortTextColourTwo = Color.Empty;

            LongTextTypeface = null;

            ShortTextTypeface = null;

            UpdateStateCommonAppearanceValues(StateCommonBackgroundColour, StateCommonNodeBackgroundColourOne, StateCommonNodeBackgroundColourTwo, StateCommonNodeLongTextColourOne, StateCommonNodeLongTextColourTwo, StateCommonNodeShortTextColourOne, StateCommonNodeShortTextColourTwo, LongTextTypeface, ShortTextTypeface);
        }
        #endregion

        #region Method
        private void UpdateStateCommonAppearanceValues(Color backgroundColour, Color nodeBackgroundColourOne, Color nodeBackgroundColourTwo, Color nodeLongTextColourOne, Color nodeLongTextColourTwo, Color nodeShortTextColourOne, Color nodeShortTextColourTwo, Font longTextTypeface, Font shortTextTypeface)
        {
            StateCommon.Back.Color1 = backgroundColour;

            StateCommon.Node.Back.Color1 = nodeBackgroundColourOne;

            StateCommon.Node.Back.Color2 = nodeBackgroundColourTwo;

            StateCommon.Node.Content.LongText.Color1 = nodeLongTextColourOne;

            StateCommon.Node.Content.LongText.Color2 = nodeLongTextColourTwo;

            StateCommon.Node.Content.LongText.Font = LongTextTypeface;

            StateCommon.Node.Content.ShortText.Color1 = nodeShortTextColourOne;

            StateCommon.Node.Content.ShortText.Color2 = nodeShortTextColourTwo;

            StateCommon.Node.Content.ShortText.Font = ShortTextTypeface;
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateStateCommonAppearanceValues(StateCommonBackgroundColour, StateCommonNodeBackgroundColourOne, StateCommonNodeBackgroundColourTwo, StateCommonNodeLongTextColourOne, StateCommonNodeLongTextColourTwo, StateCommonNodeShortTextColourOne, StateCommonNodeShortTextColourTwo, LongTextTypeface, ShortTextTypeface);

            base.OnPaint(e);
        }
        #endregion
    }
}