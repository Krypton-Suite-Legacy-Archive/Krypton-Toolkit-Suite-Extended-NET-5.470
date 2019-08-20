using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls
{
    [ToolboxBitmap(typeof(KryptonPanel))]
    public class KryptonPanelExtended : KryptonPanel
    {
        #region Variables
        private Color _backGroundColourOne, _backGroundColourTwo;

        private Image _image;
        #endregion

        #region Properties
        public Color BackGroundColourOne { get => _backGroundColourOne; set { _backGroundColourOne = value; Invalidate(); } }

        public Color BackGroundColourTwo { get => _backGroundColourTwo; set { _backGroundColourTwo = value; Invalidate(); } }

        public Image Image { get => _image; set { _image = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonPanelExtended()
        {
            BackGroundColourOne = Color.Empty;

            BackGroundColourTwo = Color.Empty;

            Image = null;

            UpdateAppearanceValues(BackGroundColourOne, BackGroundColourTwo, Image);
        }
        #endregion

        #region Method
        private void UpdateAppearanceValues(Color backGroundColourOne, Color backGroundColourTwo, Image image)
        {
            StateCommon.Color1 = backGroundColourOne;

            StateCommon.Color2 = backGroundColourTwo;

            StateCommon.Image = image;
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateAppearanceValues(BackGroundColourOne, BackGroundColourTwo, Image);

            base.OnPaint(e);
        }
        #endregion
    }
}