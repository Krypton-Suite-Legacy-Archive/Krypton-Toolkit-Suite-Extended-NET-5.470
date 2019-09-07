using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls
{
    [ToolboxBitmap(typeof(KryptonNumericUpDown))]
    public class KryptonNumericUpDownExtended : KryptonNumericUpDown
    {
        #region Variables
        private Color _stateActiveBackColour, _stateActiveTextColour,
                      _stateCommonBackColour, _stateCommonTextColour,
                      _stateDisabledBackColour, _stateDisabledTextColour,
                      _stateNormalBackColour, _stateNormalTextColour;

        private Font _typeface;
        #endregion

        #region Properties

        #region State Active
        public Color StateActiveBackColour { get => _stateActiveBackColour; set { _stateActiveBackColour = value; Invalidate(); } }

        public Color StateActiveTextColour { get => _stateActiveTextColour; set { _stateActiveTextColour = value; Invalidate(); } }
        #endregion

        #region State Common
        public Color StateCommonBackColour { get => _stateCommonBackColour; set { _stateCommonBackColour = value; Invalidate(); } }

        public Color StateCommonTextColour { get => _stateCommonTextColour; set { _stateCommonTextColour = value; Invalidate(); } }
        #endregion

        #region State Disabled
        public Color StateDisabledBackColour { get => _stateDisabledBackColour; set { _stateDisabledBackColour = value; Invalidate(); } }

        public Color StateDisabledTextColour { get => _stateDisabledTextColour; set { _stateDisabledTextColour = value; Invalidate(); } }
        #endregion

        #region State Normal
        public Color StateNormalBackColour { get => _stateNormalBackColour; set { _stateNormalBackColour = value; Invalidate(); } }

        public Color StateNormalTextColour { get => _stateNormalTextColour; set { _stateNormalTextColour = value; Invalidate(); } }
        #endregion

        public Font Typeface { get => _typeface; set { _typeface = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonNumericUpDownExtended()
        {
            StateActiveBackColour = Color.Empty;

            StateActiveTextColour = Color.Empty;

            StateCommonBackColour = Color.Empty;

            StateCommonTextColour = Color.Empty;

            StateDisabledBackColour = Color.Empty;

            StateDisabledTextColour = Color.Empty;

            StateNormalBackColour = Color.Empty;

            StateNormalTextColour = Color.Empty;

            Typeface = null;

            UpdateStateActiveAppearanceValues(StateActiveBackColour, StateActiveTextColour, Typeface);

            UpdateStateCommonAppearanceValues(StateCommonBackColour, StateCommonTextColour, Typeface);

            UpdateStateDisabledAppearanceValues(StateDisabledBackColour, StateDisabledTextColour, Typeface);

            UpdateStateNormalAppearanceValues(StateNormalBackColour, StateNormalTextColour, Typeface);
        }
        #endregion

        #region Methods
        private void UpdateStateActiveAppearanceValues(Color backColour, Color textColour, Font typeface)
        {
            StateActive.Back.Color1 = backColour;

            StateActive.Content.Color1 = textColour;

            StateActive.Content.Font = typeface;
        }

        /// <summary>Updates the appearance values.</summary>
        /// <param name="backColour">The back colour.</param>
        /// <param name="textColour">The text colour.</param>
        /// <param name="typeface">The typeface.</param>
        private void UpdateStateCommonAppearanceValues(Color backColour, Color textColour, Font typeface)
        {
            StateCommon.Back.Color1 = backColour;

            StateCommon.Content.Color1 = textColour;

            StateCommon.Content.Font = typeface;
        }

        private void UpdateStateDisabledAppearanceValues(Color backColour, Color textColour, Font typeface)
        {
            StateDisabled.Back.Color1 = backColour;

            StateDisabled.Content.Color1 = textColour;

            StateDisabled.Content.Font = typeface;
        }

        private void UpdateStateNormalAppearanceValues(Color backColour, Color textColour, Font typeface)
        {
            StateNormal.Back.Color1 = backColour;

            StateNormal.Content.Color1 = textColour;

            StateNormal.Content.Font = typeface;
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateStateActiveAppearanceValues(StateActiveBackColour, StateActiveTextColour, Typeface);

            UpdateStateCommonAppearanceValues(StateCommonBackColour, StateCommonTextColour, Typeface);

            UpdateStateDisabledAppearanceValues(StateDisabledBackColour, StateDisabledTextColour, Typeface);

            UpdateStateNormalAppearanceValues(StateNormalBackColour, StateNormalTextColour, Typeface);

            base.OnPaint(e);
        }
        #endregion
    }
}