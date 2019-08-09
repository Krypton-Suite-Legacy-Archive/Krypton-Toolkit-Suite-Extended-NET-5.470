using ComponentFactory.Krypton.Toolkit;
using ExtendedStandardControls.Classes;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls
{
    [ToolboxBitmap(typeof(KryptonCheckedListBox))]
    public class KryptonCheckedListBoxExtended : KryptonCheckedListBox
    {
        #region Variables
        private Color _backgroundColourOne, _backgroundColourTwo, _itemBackgroundColourOne, _itemBackgroundColourTwo, _longTextColourOne, _longTextColourTwo, _shortTextColourOne, _shortTextColourTwo;

        private Font _longTextTypeface, _shortTextTypeface;

        private Image _image;
        #endregion

        #region Properties
        [Category("Appearance"), Description("The first background colour.")]
        public Color BackgroundColourOne { get => _backgroundColourOne; set { _backgroundColourOne = value; Invalidate(); } }

        [Category("Appearance"), Description("The second background colour.")]
        public Color BackgroundColourTwo { get => _backgroundColourTwo; set { _backgroundColourTwo = value; Invalidate(); } }

        [Category("Appearance"), Description("The first item background colour.")]
        public Color ItemBackgroundColourOne { get => _itemBackgroundColourOne; set { _itemBackgroundColourOne = value; Invalidate(); } }

        [Category("Appearance"), Description("The second item background colour.")]
        public Color ItemBackgroundColourTwo { get => _itemBackgroundColourTwo; set { _itemBackgroundColourTwo = value; Invalidate(); } }

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
        public KryptonCheckedListBoxExtended()
        {
            BackgroundColourOne = Color.Empty;

            BackgroundColourTwo = Color.Empty;

            ItemBackgroundColourOne = Color.Empty;

            ItemBackgroundColourTwo = Color.Empty;

            LongTextColourOne = SystemColors.ControlText;

            LongTextColourTwo = SystemColors.ControlText;

            ShortTextColourOne = SystemColors.ControlText;

            ShortTextColourTwo = SystemColors.ControlText;

            LongTextTypeface = Typeface.DefaultTypeface();

            ShortTextTypeface = Typeface.DefaultTypeface();

            Image = null;

            UpdateAppearanceValues(BackgroundColourOne, BackgroundColourTwo, ItemBackgroundColourOne, ItemBackgroundColourTwo, LongTextColourOne, LongTextColourTwo, ShortTextColourOne, ShortTextColourTwo, LongTextTypeface, ShortTextTypeface, Image);
        }
        #endregion
        #region Methods
        /// <summary>Updates the appearance values.</summary>
        /// <param name="backgroundColourOne">The background colour one.</param>
        /// <param name="backgroundColourTwo">The background colour two.</param>
        /// <param name="itemBackgroundColourOne">The item background colour one.</param>
        /// <param name="itemBackgroundColourTwo">The item background colour two.</param>
        /// <param name="longTextColourOne">The long text colour one.</param>
        /// <param name="longTextColourTwo">The long text colour two.</param>
        /// <param name="shortTextColourOne">The short text colour one.</param>
        /// <param name="shortTextColourTwo">The short text colour two.</param>
        /// <param name="longTextTypeface">The long text typeface.</param>
        /// <param name="shortTextTypeface">The short text typeface.</param>
        /// <param name="image">The image.</param>
        private void UpdateAppearanceValues(Color backgroundColourOne, Color backgroundColourTwo, Color itemBackgroundColourOne, Color itemBackgroundColourTwo, Color longTextColourOne, Color longTextColourTwo, Color shortTextColourOne, Color shortTextColourTwo, Font longTextTypeface, Font shortTextTypeface, Image image)
        {
            StateCommon.Back.Color1 = backgroundColourOne;

            StateCommon.Back.Color2 = backgroundColourTwo;

            StateCommon.Item.Back.Color1 = itemBackgroundColourOne;

            StateCommon.Item.Back.Color2 = itemBackgroundColourTwo;

            StateCommon.Item.Content.LongText.Color1 = longTextColourOne;

            StateCommon.Item.Content.LongText.Color2 = longTextColourTwo;

            StateCommon.Item.Content.LongText.Font = longTextTypeface;

            StateCommon.Item.Content.ShortText.Color1 = shortTextColourOne;

            StateCommon.Item.Content.ShortText.Color2 = shortTextColourTwo;

            StateCommon.Item.Content.ShortText.Font = shortTextTypeface;

            StateCommon.Item.Content.LongText.Image = image;

            StateCommon.Item.Content.ShortText.Image = image;
        }
        #endregion

        #region Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateAppearanceValues(BackgroundColourOne, BackgroundColourTwo, ItemBackgroundColourOne, ItemBackgroundColourTwo, LongTextColourOne, LongTextColourTwo, ShortTextColourOne, ShortTextColourTwo, LongTextTypeface, ShortTextTypeface, Image);

            base.OnPaint(e);
        }
        #endregion
    }
}