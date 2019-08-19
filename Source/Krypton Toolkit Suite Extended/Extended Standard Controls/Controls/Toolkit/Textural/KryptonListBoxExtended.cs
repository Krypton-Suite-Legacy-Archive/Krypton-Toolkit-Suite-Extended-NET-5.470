using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls.Controls.Toolkit.Textural
{
    [ToolboxBitmap(typeof(KryptonListBox))]
    public class KryptonListBoxExtended : KryptonListBox
    {
        #region Variables
        private Color _commonBackgroundColourOne, _commonBackgroundColourTwo, _itemBackgroundColourOne, _itemBackgroundColourTwo, _longTextBackgroundColourOne, _longTextBackgroundColourTwo, _shortTextBackgroundColourOne, _shortTextBackgroundColourTwo, _longTextColourOne, _longTextColourTwo, _shortTextColourOne, _shortTextColourTwo;

        private Font _typeface;
        #endregion

        #region Properties
        public Color CommonBackgroundColourOne { get => _commonBackgroundColourOne; set { _commonBackgroundColourOne = value; Invalidate(); } }

        public Color CommonBackgroundColourTwo { get => _commonBackgroundColourTwo; set { _commonBackgroundColourTwo = value; Invalidate(); } }

        public Color ItemBackgroundColourOne { get => _itemBackgroundColourOne; set { _itemBackgroundColourOne = value; Invalidate(); } }

        public Color ItemBackgroundColourTwo { get => _itemBackgroundColourTwo; set { _itemBackgroundColourTwo = value; Invalidate(); } }

        public Color LongTextColourOne { get => _longTextColourOne; set { _longTextColourOne = value; Invalidate(); } }

        public Color LongTextColourTwo { get => _longTextColourTwo; set { _longTextColourTwo = value; Invalidate(); } }

        public Color ShortTextColourOne { get => _shortTextColourOne; set { _shortTextColourOne = value; Invalidate(); } }

        public Color ShortTextColourTwo { get => _shortTextColourTwo; set { _shortTextColourTwo = value; Invalidate(); } }

        public Font Typeface { get => _typeface; set { _typeface = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonListBoxExtended()
        {
            CommonBackgroundColourOne = Color.Empty;

            CommonBackgroundColourTwo = Color.Empty;

            ItemBackgroundColourOne = Color.Empty;

            ItemBackgroundColourTwo = Color.Empty;

            LongTextColourOne = Color.Empty;

            LongTextColourTwo = Color.Empty;

            ShortTextColourOne = Color.Empty;

            ShortTextColourTwo = Color.Empty;

            Typeface = null;

            UpdateAppearanceValues(CommonBackgroundColourOne, CommonBackgroundColourTwo, ItemBackgroundColourOne, ItemBackgroundColourTwo, LongTextColourOne, LongTextColourTwo, ShortTextColourOne, ShortTextColourTwo, Typeface);
        }
        #endregion

        #region Method
        private void UpdateAppearanceValues(Color commonBackgroundColourOne, Color commonBackgroundColourTwo, Color itemBackgroundColourOne, Color itemBackgroundColourTwo, Color longTextColourOne, Color longTextColourTwo, Color shortTextColourOne, Color shortTextColourTwo, Font typeface)
        {
            StateCommon.Back.Color1 = commonBackgroundColourOne;

            StateCommon.Back.Color2 = commonBackgroundColourTwo;

            StateCommon.Item.Back.Color1 = itemBackgroundColourOne;

            StateCommon.Item.Back.Color2 = itemBackgroundColourTwo;

            StateCommon.Item.Content.LongText.Color1 = longTextColourOne;

            StateCommon.Item.Content.LongText.Color2 = longTextColourTwo;

            StateCommon.Item.Content.LongText.Font = typeface;

            StateCommon.Item.Content.ShortText.Color1 = shortTextColourOne;

            StateCommon.Item.Content.ShortText.Color2 = shortTextColourTwo;

            StateCommon.Item.Content.ShortText.Font = typeface;
        }
        #endregion

        #region Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateAppearanceValues(CommonBackgroundColourOne, CommonBackgroundColourTwo, ItemBackgroundColourOne, ItemBackgroundColourTwo, LongTextColourOne, LongTextColourTwo, ShortTextColourOne, ShortTextColourTwo, Typeface);

            base.OnPaint(e);
        }
        #endregion
    }
}