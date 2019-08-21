using ComponentFactory.Krypton.Toolkit;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls
{
    [ToolboxBitmap(typeof(KryptonLabel))]
    public class KryptonLabelExtended : KryptonLabel
    {
        #region Variables
        private Color _textColourOne, _textColourTwo;

        private Font _longTextTypeface, _shortTextTypeface;

        private Image _image;
        #endregion

        #region Properties
        [Category("Appearance"), Description("The first text colour.")]
        public Color TextColourOne { get => _textColourOne; set { _textColourOne = value; Invalidate(); } }

        [Category("Appearance"), Description("The second text colour.")]
        public Color TextColourTwo { get => _textColourTwo; set { _textColourTwo = value; Invalidate(); } }

        [Category("Appearance"), Description("The 'Long Text' typeface.")]
        public Font LongTextTypeface { get => _longTextTypeface; set { _longTextTypeface = value; Invalidate(); } }

        [Category("Appearance"), Description("The 'Short Text' typeface.")]
        public Font ShortTextTypeface { get => _shortTextTypeface; set { _shortTextTypeface = value; Invalidate(); } }

        [Category("Appearance"), Description("The image.")]
        public Image Image { get => _image; set { _image = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonLabelExtended()
        {
            TextColourOne = Color.Empty;

            TextColourTwo = Color.Empty;

            LongTextTypeface = null;

            ShortTextTypeface = null;

            Image = null;

            UpdateCommonAppearanceValues(TextColourOne, TextColourTwo, LongTextTypeface, ShortTextTypeface, Image);
        }
        #endregion

        #region Method
        private void UpdateCommonAppearanceValues(Color textColourOne, Color textColourTwo, Font longTextTypeface, Font shortTextTypeface, Image image)
        {
            StateCommon.LongText.Color1 = textColourOne;

            StateCommon.LongText.Color2 = textColourTwo;

            StateCommon.LongText.Font = longTextTypeface;

            StateCommon.LongText.Image = image;

            StateCommon.ShortText.Color1 = textColourOne;

            StateCommon.ShortText.Color2 = textColourTwo;

            StateCommon.ShortText.Font = shortTextTypeface;

            StateCommon.ShortText.Image = image;
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateCommonAppearanceValues(TextColourOne, TextColourTwo, LongTextTypeface, ShortTextTypeface, Image);

            base.OnPaint(e);
        }
        #endregion
    }
}