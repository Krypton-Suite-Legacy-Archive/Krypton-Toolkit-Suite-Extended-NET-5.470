using ComponentFactory.Krypton.Toolkit;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls
{
    [ToolboxBitmap(typeof(KryptonRadioButton))]
    public class KryptonRadioButtonExtended : KryptonRadioButton
    {
        #region Variables
        private Color _longTextColourOne, _longTextColourTwo, _shortTextColourOne, _shortTextColourTwo;

        private Font _longTextTypeface, _shortTextTypeface;
        #endregion

        #region Properties
        public Color LongTextColourOne { get => _longTextColourOne; set { _longTextColourOne = value; Invalidate(); } }

        public Color LongTextColourTwo { get => _longTextColourTwo; set { _longTextColourTwo = value; Invalidate(); } }

        public Color ShortTextColourOne { get => _shortTextColourOne; set { _shortTextColourOne = value; Invalidate(); } }

        public Color ShortTextColourTwo { get => _shortTextColourTwo; set { _shortTextColourTwo = value; Invalidate(); } }

        [Category("Appearance"), Description("The 'Long Text' typeface.")]
        public Font LongTextTypeface { get => _longTextTypeface; set { _longTextTypeface = value; Invalidate(); } }

        [Category("Appearance"), Description("The 'Short Text' typeface.")]
        public Font ShortTextTypeface { get => _shortTextTypeface; set { _shortTextTypeface = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonRadioButtonExtended()
        {
            LongTextColourOne = Color.Empty;

            LongTextColourTwo = Color.Empty;

            ShortTextColourOne = Color.Empty;

            ShortTextColourTwo = Color.Empty;

            LongTextTypeface = null;

            ShortTextTypeface = null;

            UpdateAppearanceValues(LongTextColourOne, LongTextColourTwo, ShortTextColourOne, ShortTextColourTwo, LongTextTypeface, ShortTextTypeface);
        }
        #endregion

        #region Methods
        /// <summary>Updates the appearance values.</summary>
        /// <param name="longTextColourOne">The long text colour one.</param>
        /// <param name="longTextColourTwo">The long text colour two.</param>
        /// <param name="shortTextColourOne">The short text colour one.</param>
        /// <param name="shortTextColourTwo">The short text colour two.</param>
        /// <param name="typeface">The typeface.</param>
        private void UpdateAppearanceValues(Color longTextColourOne, Color longTextColourTwo, Color shortTextColourOne, Color shortTextColourTwo, Font longTextTypeface, Font shortTextTypeface)
        {
            StateCommon.LongText.Color1 = longTextColourOne;

            StateCommon.LongText.Color2 = longTextColourTwo;

            StateCommon.LongText.Font = longTextTypeface;

            StateCommon.ShortText.Color1 = shortTextColourOne;

            StateCommon.ShortText.Color2 = shortTextColourTwo;

            StateCommon.ShortText.Font = shortTextTypeface;
        }
        #endregion

        #region Override
        /// <summary>Raises the Paint event.</summary>
        /// <param name="e">A PaintEventArgs that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateAppearanceValues(LongTextColourOne, LongTextColourTwo, ShortTextColourOne, ShortTextColourTwo, LongTextTypeface, ShortTextTypeface);

            base.OnPaint(e);
        }
        #endregion
    }
}