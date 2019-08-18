using ComponentFactory.Krypton.Toolkit;
using System;
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

        private Font _typeface;

        private Image _image;
        #endregion

        #region Properties
        [Category("Appearance"), Description("The first text colour.")]
        public Color TextColourOne { get => _textColourOne; set { _textColourOne = value; Invalidate(); } }

        [Category("Appearance"), Description("The second text colour.")]
        public Color TextColourTwo { get => _textColourTwo; set { _textColourTwo = value; Invalidate(); } }

        [Category("Appearance"), Description("The typeface of the text box.")]
        public Font Typeface { get => _typeface; set { _typeface = value; Invalidate(); } }

        [Category("Appearance"), Description("The image.")]
        public Image Image { get => _image; set { _image = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonLabelExtended()
        {
            TextColourOne = Color.Empty;

            TextColourTwo = Color.Empty;

            Typeface = null;

            Image = null;

            UpdateAppearanceValues(TextColourOne, TextColourTwo, Typeface, Image);
        }
        #endregion

        #region Method
        private void UpdateAppearanceValues(Color textColourOne, Color textColourTwo, Font typeface, Image image)
        {
            StateCommon.LongText.Color1 = textColourOne;

            StateCommon.LongText.Color2 = textColourTwo;

            StateCommon.LongText.Font = typeface;

            StateCommon.LongText.Image = image;

            StateCommon.ShortText.Color1 = textColourOne;

            StateCommon.ShortText.Color2 = textColourTwo;

            StateCommon.ShortText.Font = typeface;

            StateCommon.ShortText.Image = image;
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateAppearanceValues(TextColourOne, TextColourTwo, Typeface, Image);

            base.OnPaint(e);
        }
        #endregion
    }
}