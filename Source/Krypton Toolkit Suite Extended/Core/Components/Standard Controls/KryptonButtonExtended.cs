using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace KryptonToolkitSuiteExtendedCore
{
    public class KryptonButtonExtended : KryptonButton
    {
        #region Variables
        private Color _backGroundColourOne, _backGroundColourTwo, _textColourOne, _textColourTwo;

        private Font _typeface;

        private Image _image;
        #endregion

        #region Properties
        public Color BackGroundColourOne { get => _backGroundColourOne; set { _backGroundColourOne = value; Invalidate(); } }

        public Color BackGroundColourTwo { get => _backGroundColourTwo; set { _backGroundColourTwo = value; Invalidate(); } }

        public Color TextColourOne { get => _textColourOne; set { _textColourOne = value; Invalidate(); } }

        public Color TextColourTwo { get => _textColourTwo; set { _textColourTwo = value; Invalidate(); } }

        public Font Typeface { get => _typeface; set { _typeface = value; Invalidate(); } }

        public Image Image { get => _image; set { _image = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonButtonExtended()
        {
            BackGroundColourOne = Color.Empty;

            BackGroundColourTwo = Color.Empty;

            TextColourOne = Color.Empty;

            TextColourTwo = Color.Empty;

            Typeface = new Font("Segoe UI", 9F);

            Image = null;

            UpdateAppearanceValues(BackGroundColourOne, BackGroundColourTwo, TextColourOne, TextColourTwo, Typeface, Image);
        }
        #endregion

        #region Methods
        private void UpdateAppearanceValues(Color backGroundColourOne, Color backGroundColourTwo, Color textColourOne, Color textColourTwo, Font typeface, Image image)
        {
            StateCommon.Back.Color1 = backGroundColourOne;

            StateCommon.Back.Color2 = backGroundColourTwo;

            StateCommon.Content.LongText.Color1 = textColourOne;

            StateCommon.Content.LongText.Color2 = textColourTwo;

            StateCommon.Content.LongText.Font = typeface;

            StateCommon.Content.LongText.Image = image;

            StateCommon.Content.ShortText.Color1 = textColourOne;

            StateCommon.Content.ShortText.Color2 = textColourTwo;

            StateCommon.Content.ShortText.Font = typeface;

            StateCommon.Content.ShortText.Image = image;
        }
        #endregion

        #region Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateAppearanceValues(BackGroundColourOne, BackGroundColourTwo, TextColourOne, TextColourTwo, Typeface, Image);

            base.OnPaint(e);
        }
        #endregion
    }
}