using ComponentFactory.Krypton.Toolkit;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls
{
    [ToolboxBitmap(typeof(KryptonMaskedTextBox))]
    public class KryptonMaskedTextBoxExtended : KryptonMaskedTextBox
    {
        #region Variables
        private Color _backgroundColour, _textColour;

        private Font _typeface;
        #endregion

        #region Properties
        [Category("Appearance"), Description("The back colour of the text box.")]
        public Color BackgroundColour { get => _backgroundColour; set { _backgroundColour = value; Invalidate(); } }

        [Category("Appearance"), Description("The text colour.")]
        public Color TextColour { get => _textColour; set { _textColour = value; Invalidate(); } }

        [Category("Appearance"), Description("The typeface of the text box.")]
        public Font Typeface { get => _typeface; set { _typeface = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonMaskedTextBoxExtended()
        {
            BackgroundColour = Color.White;

            TextColour = SystemColors.ControlText;

            Typeface = Classes.Typeface.DefaultTypeface();

            UpdateCommonAppearanceValues(BackgroundColour, TextColour, Typeface);
        }
        #endregion

        #region Methods
        private void UpdateCommonAppearanceValues(Color backgroundColour, Color textColour, Font typeface)
        {
            StateCommon.Back.Color1 = backgroundColour;

            StateCommon.Content.Color1 = textColour;

            StateCommon.Content.Font = typeface;
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateCommonAppearanceValues(BackgroundColour, TextColour, Typeface);

            base.OnPaint(e);
        }
        #endregion
    }
}