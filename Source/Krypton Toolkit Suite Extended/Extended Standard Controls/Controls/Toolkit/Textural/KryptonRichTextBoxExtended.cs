using ComponentFactory.Krypton.Toolkit;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls
{
    [ToolboxBitmap(typeof(KryptonRichTextBox))]
    public class KryptonRichTextBoxExtended : KryptonRichTextBox
    {
        #region Variables
        private Color _stateActiveBackgroundColour, _stateActiveTextColour,
                      _stateCommonBackgroundColour, _stateCommonTextColour,
                      _stateDisabledBackgroundColour, _stateDisabledTextColour,
                      _stateNormalBackgroundColour, _stateNormalTextColour;

        private Font _typeface;

        private int _cornerRadius;
        #endregion

        #region Properties

        #region State Active
        public Color StateActiveBackgroundColour { get => _stateActiveBackgroundColour; set { _stateActiveBackgroundColour = value; Invalidate(); } }

        public Color StateActiveTextColour { get => _stateActiveTextColour; set { _stateActiveTextColour = value; Invalidate(); } }
        #endregion

        #region State Common
        [Category("Appearance"), Description("The back colour of the text box.")]
        public Color StateCommonBackgroundColour { get => _stateCommonBackgroundColour; set { _stateCommonBackgroundColour = value; Invalidate(); } }

        [Category("Appearance"), Description("The text colour.")]
        public Color StateCommonTextColour { get => _stateCommonTextColour; set { _stateCommonTextColour = value; Invalidate(); } }
        #endregion

        #region State Disabled
        public Color StateDisabledBackgroundColour { get => _stateDisabledBackgroundColour; set { _stateDisabledBackgroundColour = value; Invalidate(); } }

        public Color StateDisabledTextColour { get => _stateDisabledTextColour; set { _stateDisabledTextColour = value; Invalidate(); } }
        #endregion

        #region State Normal
        public Color StateNormalBackgroundColour { get => _stateNormalBackgroundColour; set { _stateNormalBackgroundColour = value; Invalidate(); } }

        public Color StateNormalTextColour { get => _stateNormalTextColour; set { _stateNormalTextColour = value; Invalidate(); } }
        #endregion

        [Category("Appearance"), Description("The typeface of the text box.")]
        public Font Typeface { get => _typeface; set { _typeface = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonRichTextBoxExtended()
        {
            StateActiveBackgroundColour = Color.Empty;

            StateActiveTextColour = Color.Empty;

            StateCommonBackgroundColour = Color.White;

            StateCommonTextColour = SystemColors.ControlText;

            StateDisabledBackgroundColour = Color.Empty;

            StateDisabledTextColour = Color.Empty;

            StateNormalBackgroundColour = Color.Empty;

            StateNormalTextColour = Color.Empty;

            Typeface = Classes.Typeface.DefaultTypeface();

            UpdateStateActiveAppearanceValues(StateActiveBackgroundColour, StateActiveTextColour, Typeface);

            UpdateStateCommonAppearanceValues(StateCommonBackgroundColour, StateCommonTextColour, Typeface);

            UpdateStateDisabledAppearanceValues(StateDisabledBackgroundColour, StateDisabledTextColour, Typeface);

            UpdateStateNormalAppearanceValues(StateNormalBackgroundColour, StateNormalTextColour, Typeface);
        }
        #endregion

        #region Method
        private void UpdateStateActiveAppearanceValues(Color backgroundColour, Color textColour, Font typeface)
        {
            StateActive.Back.Color1 = backgroundColour;

            StateActive.Content.Color1 = textColour;

            StateActive.Content.Font = typeface;
        }

        private void UpdateStateCommonAppearanceValues(Color backgroundColour, Color textColour, Font typeface)
        {
            StateCommon.Back.Color1 = backgroundColour;

            StateCommon.Content.Color1 = textColour;

            StateCommon.Content.Font = typeface;
        }

        private void UpdateStateDisabledAppearanceValues(Color backgroundColour, Color textColour, Font typeface)
        {
            StateDisabled.Back.Color1 = backgroundColour;

            StateDisabled.Content.Color1 = textColour;

            StateDisabled.Content.Font = typeface;
        }

        private void UpdateStateNormalAppearanceValues(Color backgroundColour, Color textColour, Font typeface)
        {
            StateNormal.Back.Color1 = backgroundColour;

            StateNormal.Content.Color1 = textColour;

            StateNormal.Content.Font = typeface;
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateStateActiveAppearanceValues(StateActiveBackgroundColour, StateActiveTextColour, Typeface);

            UpdateStateCommonAppearanceValues(StateCommonBackgroundColour, StateCommonTextColour, Typeface);

            UpdateStateDisabledAppearanceValues(StateDisabledBackgroundColour, StateDisabledTextColour, Typeface);

            UpdateStateNormalAppearanceValues(StateNormalBackgroundColour, StateNormalTextColour, Typeface);

            base.OnPaint(e);
        }

        #endregion
    }
}