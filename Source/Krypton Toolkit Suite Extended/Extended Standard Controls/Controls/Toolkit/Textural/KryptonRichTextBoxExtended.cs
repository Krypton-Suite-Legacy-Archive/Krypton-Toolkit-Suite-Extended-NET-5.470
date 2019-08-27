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
        private Color _backgroundColour, _textColour;

        private Font _typeface;

        private int _cornerRadius;
        #endregion

        #region Properties
        [Category("Appearance"), Description("The back colour of the text box.")]
        public Color BackgroundColour { get => _backgroundColour; set { _backgroundColour = value; Invalidate(); } }

        [Category("Appearance"), Description("The text colour.")]
        public Color TextColour { get => _textColour; set { _textColour = value; Invalidate(); } }

        [Category("Appearance"), Description("The typeface of the text box.")]
        public Font Typeface { get => _typeface; set { _typeface = value; Invalidate(); } }

        [Category("Appearance"), DefaultValue(15), Description("Size of corner radius.")]
        public int CornerRadius { get => _cornerRadius; set { _cornerRadius = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonRichTextBoxExtended()
        {
            BackgroundColour = Color.White;

            TextColour = SystemColors.ControlText;

            Typeface = Classes.Typeface.DefaultTypeface();

            CornerRadius = 25;

            UpdateCommonAppearanceValues(BackgroundColour, TextColour, Typeface, CornerRadius);
        }
        #endregion

        #region Method
        private void UpdateCommonAppearanceValues(Color backgroundColour, Color textColour, Font typeface, int cornerRadius)
        {
            StateCommon.Back.Color1 = backgroundColour;

            StateCommon.Content.Color1 = textColour;

            StateCommon.Content.Font = typeface;

            StateCommon.Border.Rounding = cornerRadius;
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateCommonAppearanceValues(BackgroundColour, TextColour, Typeface, CornerRadius);

            base.OnPaint(e);
        }

        #endregion
    }
}