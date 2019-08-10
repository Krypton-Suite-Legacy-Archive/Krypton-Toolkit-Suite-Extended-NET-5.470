using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls
{
    [ToolboxBitmap(typeof(KryptonDomainUpDown))]
    public class KryptonDomainUpDownExtended : KryptonDomainUpDown
    {
        #region Variables
        private Color _backgroundColour, _textColour;

        private Font _typeface;
        #endregion

        #region Properties
        public Color BackGroundColour { get => _backgroundColour; set { _backgroundColour = value; Invalidate(); } }

        public Color TextColour { get => _textColour; set { _textColour = value; Invalidate(); } }

        public Font Typeface { get => _typeface; set { _typeface = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonDomainUpDownExtended()
        {
            BackGroundColour = Color.Empty;

            TextColour = Color.Empty;

            Typeface = Classes.Typeface.DefaultTypeface();

            UpdateAppearanceValues(BackGroundColour, TextColour, Typeface);
        }
        #endregion

        #region Method
        private void UpdateAppearanceValues(Color backgroundColour, Color textColour, Font typeface)
        {
            StateCommon.Back.Color1 = backgroundColour;

            StateCommon.Content.Color1 = textColour;

            StateCommon.Content.Font = typeface;
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateAppearanceValues(BackGroundColour, TextColour, Typeface);

            base.OnPaint(e);
        }
        #endregion
    }
}