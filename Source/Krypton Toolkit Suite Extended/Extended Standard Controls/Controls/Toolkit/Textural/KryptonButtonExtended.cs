using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls
{
    [ToolboxBitmap(typeof(KryptonButton))]
    public class KryptonButtonExtended : KryptonButton
    {
        #region Variables
        private Color _backGroundColourOne, _backGroundColourTwo, _longTextColourOne, _longTextColourTwo, _shortTextColourOne, _shortTextColourTwo;

        private Font _longTextTypeface, _shortTextTypeface;

        private Image _image;
        #endregion

        #region Properties
        public Color BackGroundColourOne { get => _backGroundColourOne; set { _backGroundColourOne = value; Invalidate(); } }

        public Color BackGroundColourTwo { get => _backGroundColourTwo; set { _backGroundColourTwo = value; Invalidate(); } }

        public Color LongTextColourOne { get => _longTextColourOne; set { _longTextColourOne = value; Invalidate(); } }

        public Color LongTextColourTwo { get => _longTextColourTwo; set { _longTextColourTwo = value; Invalidate(); } }

        public Color ShortTextColourOne { get => _shortTextColourOne; set { _shortTextColourOne = value; Invalidate(); } }

        public Color ShortTextColourTwo { get => _shortTextColourTwo; set { _shortTextColourTwo = value; Invalidate(); } }

        public Font LongTextTypeface { get => _longTextTypeface; set { _longTextTypeface = value; Invalidate(); } }

        public Font ShortTextTypeface { get => _shortTextTypeface; set { _shortTextTypeface = value; Invalidate(); } }

        public Image Image { get => _image; set { _image = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonButtonExtended()
        {
            BackGroundColourOne = Color.Empty;

            BackGroundColourTwo = Color.Empty;

            LongTextColourOne = Color.Empty;

            LongTextColourTwo = Color.Empty;

            LongTextTypeface = new Font("Microsoft Sans Serif", 8.25F);

            ShortTextColourOne = Color.Empty;

            ShortTextColourTwo = Color.Empty;

            ShortTextTypeface = new Font("Microsoft Sans Serif", 8.25F);

            Image = null;

            UpdateAppearanceValues(BackGroundColourOne, BackGroundColourTwo, LongTextColourOne, LongTextColourTwo, LongTextTypeface, ShortTextColourOne, ShortTextColourTwo, ShortTextTypeface, Image);
        }
        #endregion

        #region Method
        private void UpdateAppearanceValues(Color backGroundColourOne, Color backGroundColourTwo, Color longTextColourOne, Color longTextColourTwo, Font longTextTypeface, Color shortTextColourOne, Color shortTextColourTwo, Font shortTextTypeface, Image image)
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

        #region Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateAppearanceValues(BackGroundColourOne, BackGroundColourTwo, LongTextColourOne, LongTextColourTwo, LongTextTypeface, ShortTextColourOne, ShortTextColourTwo, ShortTextTypeface, Image);

            base.OnPaint(e);
        }
        #endregion
    }
}