using ComponentFactory.Krypton.Toolkit;
using ExtendedStandardControls.Classes;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls
{
    [ToolboxBitmap(typeof(KryptonComboBox))]
    public class KryptonComboBoxExtended : KryptonComboBox
    {
        #region Variables
        private Color _comboBoxBackColour, _comboBoxContentColour, _comboBoxDropBackColourOne, _comboBoxDropBackColourTwo, _comboBoxItemBackColourOne, _comboBoxItemBackColourTwo, _comboBoxItemContentLongTextColourOne, _comboBoxItemContentLongTextColourTwo, _comboBoxItemContentShortTextColourOne, _comboBoxItemContentShortTextColourTwo;

        private Font _comboBoxContentTypeface, _comboBoxItemContentLongTextTypeface, _comboBoxItemContentShortTextTypeface;

        private Image _image;
        #endregion

        #region Properties
        public Color ComboBoxBackColour { get => _comboBoxBackColour; set { _comboBoxBackColour = value; Invalidate(); } }

        public Color ComboBoxContentColour { get => _comboBoxContentColour; set { _comboBoxContentColour = value; Invalidate(); } }

        public Color ComboBoxDropBackColourOne { get => _comboBoxDropBackColourOne; set { _comboBoxDropBackColourOne = value; Invalidate(); } }

        public Color ComboBoxDropBackColourTwo { get => _comboBoxDropBackColourTwo; set { _comboBoxDropBackColourTwo = value; Invalidate(); } }

        public Color ComboBoxItemBackColourOne { get => _comboBoxItemBackColourOne; set { _comboBoxItemBackColourOne = value; Invalidate(); } }

        public Color ComboBoxItemBackColourTwo { get => _comboBoxItemBackColourTwo; set { _comboBoxItemBackColourTwo = value; Invalidate(); } }

        public Color ComboBoxItemContentLongTextColourOne { get => _comboBoxItemContentLongTextColourOne; set { _comboBoxItemContentLongTextColourOne = value; Invalidate(); } }

        public Color ComboBoxItemContentLongTextColourTwo { get => _comboBoxItemContentLongTextColourTwo; set { _comboBoxItemContentLongTextColourTwo = value; Invalidate(); } }

        public Color ComboBoxItemContentShortTextColourOne { get => _comboBoxItemContentShortTextColourOne; set { _comboBoxItemContentShortTextColourOne = value; Invalidate(); } }

        public Color ComboBoxItemContentShortTextColourTwo { get => _comboBoxItemContentShortTextColourTwo; set { _comboBoxItemContentShortTextColourTwo = value; Invalidate(); } }

        public Font ComboBoxContentTypeface { get => _comboBoxContentTypeface; set { _comboBoxContentTypeface = value; Invalidate(); } }

        public Font ComboBoxItemContentLongTextTypeface { get => _comboBoxItemContentLongTextTypeface; set { _comboBoxItemContentLongTextTypeface = value; Invalidate(); } }

        public Font ComboBoxItemContentShortTextTypeface { get => _comboBoxItemContentShortTextTypeface; set { _comboBoxItemContentShortTextTypeface = value; Invalidate(); } }

        public Image Image { get => _image; set { _image = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonComboBoxExtended()
        {
            ComboBoxBackColour = Color.Empty;

            ComboBoxContentColour = Color.Empty;

            ComboBoxDropBackColourOne = Color.Empty;

            ComboBoxDropBackColourTwo = Color.Empty;

            ComboBoxItemBackColourOne = Color.Empty;

            ComboBoxItemBackColourTwo = Color.Empty;

            ComboBoxItemContentLongTextColourOne = Color.Empty;

            ComboBoxItemContentLongTextColourTwo = Color.Empty;

            ComboBoxItemContentShortTextColourOne = Color.Empty;

            ComboBoxItemContentShortTextColourTwo = Color.Empty;

            ComboBoxContentTypeface = Typeface.DefaultTypeface();

            ComboBoxItemContentLongTextTypeface = Typeface.DefaultTypeface();

            ComboBoxItemContentShortTextTypeface = Typeface.DefaultTypeface();

            Image = null;

            UpdateAppearenceValues(ComboBoxBackColour, ComboBoxContentColour, ComboBoxDropBackColourOne, ComboBoxDropBackColourTwo, ComboBoxItemBackColourOne, ComboBoxItemBackColourTwo, ComboBoxItemContentLongTextColourOne, ComboBoxItemContentLongTextColourTwo, ComboBoxItemContentShortTextColourOne, ComboBoxItemContentShortTextColourTwo, ComboBoxContentTypeface, ComboBoxItemContentLongTextTypeface, ComboBoxItemContentShortTextTypeface, Image);
        }
        #endregion

        #region Method
        /// <summary>Updates the appearence values.</summary>
        /// <param name="comboBoxBackColour">The combo box back colour.</param>
        /// <param name="comboBoxContentColour">The combo box content colour.</param>
        /// <param name="comboBoxDropBackColourOne">The combo box drop back colour one.</param>
        /// <param name="comboBoxDropBackColourTwo">The combo box drop back colour two.</param>
        /// <param name="comboBoxItemBackColourOne">The combo box item back colour one.</param>
        /// <param name="comboBoxItemBackColourTwo">The combo box item back colour two.</param>
        /// <param name="comboBoxItemContentLongTextColourOne">The combo box item content long text colour one.</param>
        /// <param name="comboBoxItemContentLongTextColourTwo">The combo box item content long text colour two.</param>
        /// <param name="comboBoxItemContentShortTextColourOne">The combo box item content short text colour one.</param>
        /// <param name="comboBoxItemContentShortTextColourTwo">The combo box item content short text colour two.</param>
        /// <param name="comboBoxContentTypeface">The combo box content typeface.</param>
        /// <param name="comboBoxItemContentLongTextTypeface">The combo box item content long text typeface.</param>
        /// <param name="comboBoxItemContentShortTextTypeface">The combo box item content short text typeface.</param>
        /// <param name="image">The image.</param>
        private void UpdateAppearenceValues(Color comboBoxBackColour, Color comboBoxContentColour, Color comboBoxDropBackColourOne, Color comboBoxDropBackColourTwo, Color comboBoxItemBackColourOne, Color comboBoxItemBackColourTwo, Color comboBoxItemContentLongTextColourOne, Color comboBoxItemContentLongTextColourTwo, Color comboBoxItemContentShortTextColourOne, Color comboBoxItemContentShortTextColourTwo, Font comboBoxContentTypeface, Font comboBoxItemContentLongTextTypeface, Font comboBoxItemContentShortTextTypeface, Image image)
        {
            StateCommon.ComboBox.Back.Color1 = comboBoxBackColour;

            StateCommon.ComboBox.Content.Color1 = comboBoxContentColour;

            StateCommon.ComboBox.Content.Font = comboBoxContentTypeface;

            StateCommon.DropBack.Color1 = comboBoxDropBackColourOne;

            StateCommon.DropBack.Color2 = comboBoxDropBackColourTwo;

            StateCommon.Item.Back.Color1 = comboBoxItemBackColourOne;

            StateCommon.Item.Back.Color2 = comboBoxItemBackColourTwo;

            StateCommon.Item.Content.LongText.Color1 = comboBoxItemContentLongTextColourOne;

            StateCommon.Item.Content.LongText.Color2 = comboBoxItemContentLongTextColourTwo;

            StateCommon.Item.Content.LongText.Font = comboBoxItemContentLongTextTypeface;

            StateCommon.Item.Content.LongText.Image = image;

            StateCommon.Item.Content.ShortText.Color1 = comboBoxItemContentShortTextColourOne;

            StateCommon.Item.Content.ShortText.Color2 = comboBoxItemContentShortTextColourTwo;

            StateCommon.Item.Content.ShortText.Font = comboBoxItemContentShortTextTypeface;

            StateCommon.Item.Content.ShortText.Image = image;
        }
        #endregion

        #region Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateAppearenceValues(ComboBoxBackColour, ComboBoxContentColour, ComboBoxDropBackColourOne, ComboBoxDropBackColourTwo, ComboBoxItemBackColourOne, ComboBoxItemBackColourTwo, ComboBoxItemContentLongTextColourOne, ComboBoxItemContentLongTextColourTwo, ComboBoxItemContentShortTextColourOne, ComboBoxItemContentShortTextColourTwo, ComboBoxContentTypeface, ComboBoxItemContentLongTextTypeface, ComboBoxItemContentShortTextTypeface, Image);

            base.OnPaint(e);
        }
        #endregion
    }
}