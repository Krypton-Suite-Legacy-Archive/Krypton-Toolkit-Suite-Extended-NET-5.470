using ComponentFactory.Krypton.Toolkit;
using ExtendedStandardControls.Classes;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls
{
    [ToolboxBitmap(typeof(KryptonCheckBox))]
    public class KryptonCheckBoxExtended : KryptonCheckBox
    {
        #region Variables
        private Color _longTextColourOne, _longTextColourTwo, _shortTextColourOne, _shortTextColourTwo;

        private Font _longTextTypeface, _shortTextTypeface;

        private Image _image;
        #endregion

        #region Properties
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
        public KryptonCheckBoxExtended()
        {
            LongTextColourOne = Color.Empty;

            LongTextColourTwo = Color.Empty;

            LongTextTypeface = Typeface.DefaultTypeface();

            ShortTextColourOne = Color.Empty;

            ShortTextColourTwo = Color.Empty;

            ShortTextTypeface = Typeface.DefaultTypeface();

            Image = null;

            UpdateCommonAppearanceValues(LongTextColourOne, LongTextColourTwo, LongTextTypeface, ShortTextColourOne, ShortTextColourTwo, ShortTextTypeface, Image);
        }
        #endregion

        #region Method
        private void UpdateCommonAppearanceValues(Color longTextColourOne, Color longTextColourTwo, Font longTextTypeface, Color shortTextColourOne, Color shortTextColourTwo, Font shortTextTypeface, Image image)
        {
            StateCommon.LongText.Color1 = longTextColourOne;

            StateCommon.LongText.Color2 = longTextColourTwo;

            StateCommon.LongText.Font = longTextTypeface;

            StateCommon.LongText.Image = image;

            StateCommon.ShortText.Color1 = shortTextColourOne;

            StateCommon.ShortText.Color2 = shortTextColourTwo;

            StateCommon.ShortText.Font = shortTextTypeface;

            StateCommon.ShortText.Image = image;
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateCommonAppearanceValues(LongTextColourOne, LongTextColourTwo, LongTextTypeface, ShortTextColourOne, ShortTextColourTwo, ShortTextTypeface, Image);

            base.OnPaint(e);
        }
        #endregion
    }
}