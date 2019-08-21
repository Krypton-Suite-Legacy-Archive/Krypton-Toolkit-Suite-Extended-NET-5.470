using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls
{
    [ToolboxBitmap(typeof(KryptonNumericUpDown))]
    public class KryptonNumericUpDownExtended : KryptonNumericUpDown
    {
        #region Variables
        private Color _backColour, _textColour;

        private Font _typeface;
        #endregion

        #region Properties
        public Color BackColour { get => _backColour; set { _backColour = value; Invalidate(); } }

        public Color TextColour { get => _textColour; set { _textColour = value; Invalidate(); } }

        public Font Typeface { get => _typeface; set { _typeface = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonNumericUpDownExtended()
        {
            BackColour = Color.Empty;

            TextColour = Color.Empty;

            Typeface = null;

            UpdateCommonAppearanceValues(BackColour, TextColour, Typeface);
        }
        #endregion

        #region Methods
        /// <summary>Updates the appearance values.</summary>
        /// <param name="backColour">The back colour.</param>
        /// <param name="textColour">The text colour.</param>
        /// <param name="typeface">The typeface.</param>
        private void UpdateCommonAppearanceValues(Color backColour, Color textColour, Font typeface)
        {
            StateCommon.Back.Color1 = backColour;

            StateCommon.Content.Color1 = textColour;

            StateCommon.Content.Font = typeface;
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateCommonAppearanceValues(BackColour, TextColour, Typeface);

            base.OnPaint(e);
        }
        #endregion
    }
}