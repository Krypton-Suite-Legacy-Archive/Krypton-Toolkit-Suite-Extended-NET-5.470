using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace KryptonToolkitSuiteExtendedCore
{
    [ToolboxBitmap(typeof(KryptonTextBox))]
    public class KryptonTextBoxExtended : KryptonTextBox
    {
        #region Variables
        private Color _backgroundColour, _textColour;

        private Font _typeface;
        #endregion

        #region Properties
        //[DefaultValue(typeof(Color)Color.White)]
        public Color BackgroundColour { get => _backgroundColour; set { _backgroundColour = value; Invalidate(); } }

        public Color TextColour { get => _textColour; set { _textColour = value; Invalidate(); } }

        public Font Typeface { get => _typeface; set { _typeface = value; Invalidate(); } }
        #endregion

        #region Constructors
        public KryptonTextBoxExtended()
        {
            BackgroundColour = Color.White;

            TextColour = SystemColors.ControlText;

            Typeface = new Font("Segoe UI", 12F);

            UpdateAppearance(BackgroundColour, TextColour, Typeface);
        }

        public KryptonTextBoxExtended(Color backgroundColour, Color textColour, Font typeface, Point location)
        {
            UpdateAppearance(backgroundColour, textColour, typeface, location);
        }
        #endregion

        #region Methods
        public void UpdateAppearance(Color backgroundColour, Color textColour, Font typeface)
        {
            StateCommon.Back.Color1 = backgroundColour;

            StateCommon.Content.Color1 = textColour;

            StateCommon.Content.Font = typeface;
        }

        public void UpdateAppearance(Color backgroundColour, Color textColour, Font typeface, Point location)
        {

        }
        #endregion

        #region Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateAppearance(BackgroundColour, TextColour, Typeface);

            base.OnPaint(e);
        }
        #endregion
    }
}