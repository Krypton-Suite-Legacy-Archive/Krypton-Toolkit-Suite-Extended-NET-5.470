using ComponentFactory.Krypton.Toolkit;
using ExtendedStandardControls.Classes;
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
        public Color LongTextColourOne { get => _longTextColourOne; set { _longTextColourOne = value; Invalidate(); } }

        public Color LongTextColourTwo { get => _longTextColourTwo; set { _longTextColourTwo = value; Invalidate(); } }

        public Color ShortTextColourOne { get => _shortTextColourOne; set { _shortTextColourOne = value; Invalidate(); } }

        public Color ShortTextColourTwo { get => _shortTextColourTwo; set { _shortTextColourTwo = value; Invalidate(); } }

        public Font LongTextTypeface { get => _longTextTypeface; set { _longTextTypeface = value; Invalidate(); } }

        public Font ShortTextTypeface { get => _shortTextTypeface; set { _shortTextTypeface = value; Invalidate(); } }

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

            UpdateAppearanceValues(LongTextColourOne, LongTextColourTwo, LongTextTypeface, ShortTextColourOne, ShortTextColourTwo, ShortTextTypeface, Image);
        }
        #endregion

        #region Method
        private void UpdateAppearanceValues(Color longTextColourOne, Color longTextColourTwo, Font longTextTypeface, Color shortTextColourOne, Color shortTextColourTwo, Font shortTextTypeface, Image image)
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
            UpdateAppearanceValues(LongTextColourOne, LongTextColourTwo, LongTextTypeface, ShortTextColourOne, ShortTextColourTwo, ShortTextTypeface, Image);

            base.OnPaint(e);
        }
        #endregion
    }
}