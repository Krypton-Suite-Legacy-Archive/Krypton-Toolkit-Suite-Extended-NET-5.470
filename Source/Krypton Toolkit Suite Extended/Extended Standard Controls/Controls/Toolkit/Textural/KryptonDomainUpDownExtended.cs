using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls
{
    [ToolboxBitmap(typeof(KryptonDomainUpDown))]
    public class KryptonDomainUpDownExtended : KryptonDomainUpDown
    {
        #region Variables
        private Color _stateActiveBackgroundColour, _stateActiveTextColour,
                     _stateCommonBackgroundColour, _stateCommonTextColour,
                     _stateDisabledBackgroundColour, _stateDisabledTextColour,
                     _stateNormalBackgroundColour, _stateNormalTextColour;

        private Font _typeface;
        #endregion

        #region Properties

        #region State Active
        public Color StateActiveBackGroundColour { get => _stateActiveBackgroundColour; set { _stateActiveBackgroundColour = value; Invalidate(); } }

        public Color StateActiveTextColour { get => _stateActiveTextColour; set { _stateActiveTextColour = value; Invalidate(); } }
        #endregion

        #region State Common
        public Color StateCommonBackGroundColour { get => _stateCommonBackgroundColour; set { _stateCommonBackgroundColour = value; Invalidate(); } }

        public Color StateCommonTextColour { get => _stateCommonTextColour; set { _stateCommonTextColour = value; Invalidate(); } }
        #endregion

        #region State Disabled
        public Color StateDisabledBackGroundColour { get => _stateDisabledBackgroundColour; set { _stateDisabledBackgroundColour = value; Invalidate(); } }

        public Color StateDisabledTextColour { get => _stateDisabledTextColour; set { _stateDisabledTextColour = value; Invalidate(); } }
        #endregion

        #region State Normal
        public Color StateNormalBackgroundColour { get => _stateNormalBackgroundColour; set { _stateNormalBackgroundColour = value; Invalidate(); } }

        public Color StateNormalTextColour { get => _stateNormalTextColour; set { _stateNormalTextColour = value; Invalidate(); } }
        #endregion

        public Font Typeface { get => _typeface; set { _typeface = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonDomainUpDownExtended()
        {
            StateActiveBackGroundColour = Color.Empty;

            StateActiveTextColour = Color.Empty;

            StateCommonBackGroundColour = Color.Empty;

            StateCommonTextColour = Color.Empty;

            StateDisabledBackGroundColour = Color.Empty;

            StateDisabledTextColour = Color.Empty;

            StateNormalBackgroundColour = Color.Empty;

            StateNormalTextColour = Color.Empty;

            Typeface = Classes.Typeface.DefaultTypeface();

            UpdateStateActiveAppearanceValues(StateActiveBackGroundColour, StateActiveTextColour, Typeface);

            UpdateStateCommonAppearanceValues(StateCommonBackGroundColour, StateCommonTextColour, Typeface);

            UpdateStateDisabledAppearanceValues(StateDisabledBackGroundColour, StateDisabledTextColour, Typeface);

            UpdateStateNormalAppearanceValues(StateNormalBackgroundColour, StateNormalTextColour, Typeface);
        }
        #endregion

        #region Method
        private void UpdateStateActiveAppearanceValues(Color stateActiveBackGroundColour, Color stateActiveTextColour, Font typeface)
        {
            StateActive.Back.Color1 = stateActiveBackGroundColour;

            StateActive.Content.Color1 = stateActiveTextColour;

            StateActive.Content.Font = typeface;
        }

        private void UpdateStateCommonAppearanceValues(Color backgroundColour, Color textColour, Font typeface)
        {
            StateCommon.Back.Color1 = backgroundColour;

            StateCommon.Content.Color1 = textColour;

            StateCommon.Content.Font = typeface;
        }

        private void UpdateStateDisabledAppearanceValues(Color stateDisabledBackGroundColour, Color stateDisabledTextColour, Font typeface)
        {
            StateDisabled.Back.Color1 = stateDisabledBackGroundColour;

            StateDisabled.Content.Color1 = stateDisabledTextColour;

            StateDisabled.Content.Font = typeface;
        }

        private void UpdateStateNormalAppearanceValues(Color stateNormalBackgroundColour, Color stateNormalTextColour, Font typeface)
        {
            StateNormal.Back.Color1 = stateNormalBackgroundColour;

            StateNormal.Content.Color1 = stateNormalTextColour;

            StateNormal.Content.Font = typeface;
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateStateActiveAppearanceValues(StateActiveBackGroundColour, StateActiveTextColour, Typeface);

            UpdateStateCommonAppearanceValues(StateCommonBackGroundColour, StateCommonTextColour, Typeface);

            UpdateStateDisabledAppearanceValues(StateDisabledBackGroundColour, StateDisabledTextColour, Typeface);

            UpdateStateNormalAppearanceValues(StateNormalBackgroundColour, StateNormalTextColour, Typeface);

            base.OnPaint(e);
        }
        #endregion
    }
}