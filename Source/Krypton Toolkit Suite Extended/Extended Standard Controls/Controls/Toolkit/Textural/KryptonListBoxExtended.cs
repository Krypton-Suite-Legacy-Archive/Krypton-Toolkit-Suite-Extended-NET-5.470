using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls.Controls.Toolkit.Textural
{
    [ToolboxBitmap(typeof(KryptonListBox))]
    public class KryptonListBoxExtended : KryptonListBox
    {
        #region Variables
        private Color _commonBackgroundColourOne, _commonBackgroundColourTwo, _itemBackgroundColourOne, _itemBackgroundColourTwo, _longTextBackgroundColourOne, _longTextBackgroundColourTwo, _shortTextBackgroundColourOne, _shortTextBackgroundColourTwo;

        private Font _typeface;
        #endregion

        #region Properties
        public Color CommonBackgroundColourOne { get => _commonBackgroundColourOne; set { _commonBackgroundColourOne = value; Invalidate(); } }

        public Color CommonBackgroundColourTwo { get => _commonBackgroundColourTwo; set { _commonBackgroundColourTwo = value; Invalidate(); } }

        public Color ItemBackgroundColourOne { get => _itemBackgroundColourOne; set { _itemBackgroundColourOne = value; Invalidate(); } }

        public Color ItemBackgroundColourTwo { get => _itemBackgroundColourTwo; set { _itemBackgroundColourTwo = value; Invalidate(); } }

        public Color LongTextBackgroundColourOne { get => _longTextBackgroundColourOne; set { _longTextBackgroundColourOne = value; Invalidate(); } }

        public Color LongTextBackgroundColourTwo { get => _longTextBackgroundColourTwo; set { _longTextBackgroundColourTwo = value; Invalidate(); } }

        public Color ShortTextBackgroundColourOne { get => _shortTextBackgroundColourOne; set { _shortTextBackgroundColourOne = value; Invalidate(); } }

        public Color ShortTextBackgroundColourTwo { get => _shortTextBackgroundColourTwo; set { _shortTextBackgroundColourTwo = value; Invalidate(); } }

        public Font Typeface { get => _typeface; set { _typeface = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonListBoxExtended()
        {
            CommonBackgroundColourOne = Color.Empty;

            CommonBackgroundColourTwo = Color.Empty;

            ItemBackgroundColourOne = Color.Empty;

            ItemBackgroundColourTwo = Color.Empty;

            LongTextBackgroundColourOne = Color.Empty;

            LongTextBackgroundColourTwo = Color.Empty;

            ShortTextBackgroundColourOne = Color.Empty;

            ShortTextBackgroundColourTwo = Color.Empty;

            Typeface = null;

            UpdateAppearanceValues(CommonBackgroundColourOne, CommonBackgroundColourTwo, ItemBackgroundColourOne, ItemBackgroundColourTwo, LongTextBackgroundColourOne, LongTextBackgroundColourTwo, ShortTextBackgroundColourOne, ShortTextBackgroundColourTwo, Typeface);
        }
        #endregion

        #region Method
        private void UpdateAppearanceValues(Color commonBackgroundColourOne, Color commonBackgroundColourTwo, Color itemBackgroundColourOne, Color itemBackgroundColourTwo, Color longTextBackgroundColourOne, Color longTextBackgroundColourTwo, Color shortTextBackgroundColourOne, Color shortTextBackgroundColourTwo, Font typeface)
        {
            StateCommon.Back.Color1 = commonBackgroundColourOne;

            StateCommon.Back.Color2 = commonBackgroundColourTwo;

            StateCommon.Item.Back.Color1 = itemBackgroundColourOne;

            StateCommon.Item.Back.Color2 = itemBackgroundColourTwo;

            StateCommon.Item.Content.LongText.Color1 = longTextBackgroundColourOne;

            StateCommon.Item.Content.LongText.Color2 = longTextBackgroundColourTwo;

            StateCommon.Item.Content.LongText.Font = typeface;

            StateCommon.Item.Content.ShortText.Color1 = shortTextBackgroundColourOne;

            StateCommon.Item.Content.ShortText.Color2 = shortTextBackgroundColourTwo;

            StateCommon.Item.Content.ShortText.Font = typeface;
        }
        #endregion

        #region Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateAppearanceValues(CommonBackgroundColourOne, CommonBackgroundColourTwo, ItemBackgroundColourOne, ItemBackgroundColourTwo, LongTextBackgroundColourOne, LongTextBackgroundColourTwo, ShortTextBackgroundColourOne, ShortTextBackgroundColourTwo, Typeface);

            base.OnPaint(e);
        }
        #endregion
    }
}