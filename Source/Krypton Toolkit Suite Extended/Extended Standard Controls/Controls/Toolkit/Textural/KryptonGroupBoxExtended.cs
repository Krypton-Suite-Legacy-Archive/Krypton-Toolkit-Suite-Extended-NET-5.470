using ComponentFactory.Krypton.Toolkit;
using ExtendedStandardControls.Classes;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls
{
    [ToolboxBitmap(typeof(KryptonGroupBox))]
    public class KryptonGroupBoxExtended : KryptonGroupBox
    {
        #region Variables
        private Color _backGroundColourOne, _backGroundColourTwo, _longTextColourOne, _longTextColourTwo, _shortTextColourOne, _shortTextColourTwo;

        private Font _longTextTypeface, _shortTextTypeface;

        private Image _image;
        #endregion

        #region Properties
        [Category("Appearance"), Description("The first background colour.")]
        public Color BackGroundColourOne { get => _backGroundColourOne; set { _backGroundColourOne = value; Invalidate(); } }

        [Category("Appearance"), Description("The second background colour.")]
        public Color BackGroundColourTwo { get => _backGroundColourTwo; set { _backGroundColourTwo = value; Invalidate(); } }

        [Category("Appearance"), Description("The first long text colour.")]
        public Color LongTextColourOne { get => _longTextColourOne; set { _longTextColourOne = value; Invalidate(); } }

        [Category("Appearance"), Description("The second long text colour.")]
        public Color LongTextColourTwo { get => _longTextColourTwo; set { _longTextColourTwo = value; Invalidate(); } }

        [Category("Appearance"), Description("The first short text colour.")]
        public Color ShortTextColourOne { get => _shortTextColourOne; set { _shortTextColourOne = value; Invalidate(); } }

        [Category("Appearance"), Description("The second short text colour.")]
        public Color ShortTextColourTwo { get => _shortTextColourTwo; set { _shortTextColourTwo = value; Invalidate(); } }

        [Category("Appearance"), Description("The 'Long Text' typeface.")]
        public Font LongTextTypeface { get => _longTextTypeface; set { _longTextTypeface = value; Invalidate(); } }

        [Category("Appearance"), Description("The 'Short Text' typeface.")]
        public Font ShortTextTypeface { get => _shortTextTypeface; set { _shortTextTypeface = value; Invalidate(); } }

        [Category("Appearance"), Description("The chosen image.")]
        public Image Image { get => _image; set { _image = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonGroupBoxExtended()
        {
            BackGroundColourOne = Color.Empty;

            BackGroundColourTwo = Color.Empty;

            LongTextColourOne = Color.Empty;

            LongTextColourTwo = Color.Empty;

            LongTextTypeface = Typeface.DefaultTypeface();

            ShortTextColourOne = Color.Empty;

            ShortTextColourTwo = Color.Empty;

            ShortTextTypeface = Typeface.DefaultTypeface();

            Image = null;

            UpdateCommonAppearanceValues(BackGroundColourOne, BackGroundColourTwo, LongTextColourOne, LongTextColourTwo, LongTextTypeface, ShortTextColourOne, ShortTextColourTwo, ShortTextTypeface, Image);
        }
        #endregion

        #region Method
        private void UpdateCommonAppearanceValues(Color backGroundColourOne, Color backGroundColourTwo, Color longTextColourOne, Color longTextColourTwo, Font longTextTypeface, Color shortTextColourOne, Color shortTextColourTwo, Font shortTextTypeface, Image image)
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
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateCommonAppearanceValues(BackGroundColourOne, BackGroundColourTwo, LongTextColourOne, LongTextColourTwo, LongTextTypeface, ShortTextColourOne, ShortTextColourTwo, ShortTextTypeface, Image);

            base.OnPaint(e);
        }
        #endregion
    }
}