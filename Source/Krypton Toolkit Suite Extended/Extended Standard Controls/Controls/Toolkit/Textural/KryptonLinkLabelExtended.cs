using ComponentFactory.Krypton.Toolkit;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls
{
    [ToolboxBitmap(typeof(KryptonLinkLabel))]
    public class KryptonLinkLabelExtended : KryptonLinkLabel
    {
        #region Variables
        private Color _overrideFocusLongTextColourOne, _overrideFocusLongTextColourTwo, _overrideFocusShortTextColourOne, _overrideFocusShortTextColourTwo, _overrideNotVisitedLongTextColourOne, _overrideNotVisitedLongTextColourTwo, _overrideNotVisitedShortTextColourOne, _overrideNotVisitedShortTextColourTwo, _overridePressedLongTextColourOne, _overridePressedLongTextColourTwo, _overridePressedShortTextColourOne, _overridePressedShortTextColourTwo, _overrideVisitedLongTextColourOne, _overrideVisitedLongTextColourTwo, _overrideVisitedShortTextColourOne, _overrideVisitedShortTextColourTwo, _commonLongTextColourOne, _commonLongTextColourTwo, _commonShortTextColourOne, _commonShortTextColourTwo;

        private Font _longTextTypeface, _shortTextTypeface;
        #endregion

        #region Properties

        #region Override Focus
        public Color OverrideFocusLongTextColourOne { get => _overrideFocusLongTextColourOne; set { _overrideFocusLongTextColourOne = value; Invalidate(); } }

        public Color OverrideFocusLongTextColourTwo { get => _overrideFocusLongTextColourTwo; set { _overrideFocusLongTextColourTwo = value; Invalidate(); } }

        public Color OverrideFocusShortTextColourOne { get => _overrideFocusShortTextColourOne; set { _overrideFocusShortTextColourOne = value; Invalidate(); } }

        public Color OverrideFocusShortTextColourTwo { get => _overrideFocusShortTextColourTwo; set { _overrideFocusShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region Override Not Visited
        public Color OverrideNotVisitedLongTextColourOne { get => _overrideNotVisitedLongTextColourOne; set { _overrideNotVisitedLongTextColourOne = value; Invalidate(); } }

        public Color OverrideNotVisitedLongTextColourTwo { get => _overrideNotVisitedLongTextColourOne; set { _overrideNotVisitedLongTextColourOne = value; Invalidate(); } }

        public Color OverrideNotVisitedShortTextColourOne { get => _overrideNotVisitedShortTextColourOne; set { _overrideNotVisitedShortTextColourOne = value; Invalidate(); } }

        public Color OverrideNotVisitedShortTextColourTwo { get => _overrideNotVisitedShortTextColourTwo; set { _overrideNotVisitedShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region Override Pressed
        public Color OverridePressedLongTextColourOne { get => _overridePressedLongTextColourOne; set { _overridePressedLongTextColourOne = value; Invalidate(); } }

        public Color OverridePressedLongTextColourTwo { get => _overridePressedLongTextColourTwo; set { _overridePressedLongTextColourTwo = value; Invalidate(); } }

        public Color OverridePressedShortTextColourOne { get => _overridePressedShortTextColourOne; set { _overridePressedShortTextColourOne = value; Invalidate(); } }

        public Color OverridePressedShortTextColourTwo { get => _overridePressedShortTextColourTwo; set { _overridePressedShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region Override Visited
        public Color OverrideVisitedLongTextColourOne { get => _overrideVisitedLongTextColourOne; set { _overrideVisitedLongTextColourOne = value; Invalidate(); } }

        public Color OverrideVisitedLongTextColourTwo { get => _overrideVisitedLongTextColourTwo; set { _overrideVisitedLongTextColourTwo = value; Invalidate(); } }

        public Color OverrideVisitedShortTextColourOne { get => _overrideVisitedShortTextColourOne; set { _overrideVisitedShortTextColourOne = value; Invalidate(); } }

        public Color OverrideVisitedShortTextColourTwo { get => _overrideVisitedShortTextColourTwo; set { _overrideVisitedShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #region Common
        public Color CommonLongTextColourOne { get => _commonLongTextColourOne; set { _commonLongTextColourOne = value; Invalidate(); } }

        public Color CommonLongTextColourTwo { get => _commonLongTextColourTwo; set { _commonLongTextColourTwo = value; Invalidate(); } }

        public Color CommonShortTextColourOne { get => _commonShortTextColourOne; set { _commonShortTextColourOne = value; Invalidate(); } }

        public Color CommonShortTextColourTwo { get => _commonShortTextColourTwo; set { _commonShortTextColourTwo = value; Invalidate(); } }
        #endregion

        [Category("Appearance"), Description("The 'Long Text' typeface.")]
        public Font LongTextTypeface { get => _longTextTypeface; set { _longTextTypeface = value; Invalidate(); } }

        [Category("Appearance"), Description("The 'Short Text' typeface.")]
        public Font ShortTextTypeface { get => _shortTextTypeface; set { _shortTextTypeface = value; Invalidate(); } }

        #endregion

        #region Constructor
        /// <summary>Initializes a new instance of the <see cref="KryptonLinkLabelExtended"/> class.</summary>
        public KryptonLinkLabelExtended()
        {
            #region Common
            CommonLongTextColourOne = Color.Empty;

            CommonLongTextColourTwo = Color.Empty;

            CommonShortTextColourOne = Color.Empty;

            CommonShortTextColourTwo = Color.Empty;
            #endregion

            #region Override Focus
            OverrideFocusLongTextColourOne = Color.Empty;

            OverrideFocusLongTextColourTwo = Color.Empty;

            OverrideFocusShortTextColourOne = Color.Empty;

            OverrideFocusShortTextColourTwo = Color.Empty;
            #endregion

            #region Override Not Visited
            OverrideNotVisitedLongTextColourOne = Color.Empty;

            OverrideNotVisitedLongTextColourTwo = Color.Empty;

            OverrideNotVisitedShortTextColourOne = Color.Empty;

            OverrideNotVisitedShortTextColourTwo = Color.Empty;
            #endregion

            #region Override Pressed
            OverridePressedLongTextColourOne = Color.Empty;

            OverridePressedLongTextColourTwo = Color.Empty;

            OverridePressedShortTextColourOne = Color.Empty;

            OverridePressedShortTextColourTwo = Color.Empty;
            #endregion

            #region Override Visited
            OverrideVisitedLongTextColourOne = Color.Empty;

            OverrideVisitedLongTextColourTwo = Color.Empty;

            OverrideVisitedShortTextColourOne = Color.Empty;

            OverrideVisitedShortTextColourTwo = Color.Empty;
            #endregion

            LongTextTypeface = null;

            ShortTextTypeface = null;

            UpdateCommonAppearanceValues(CommonLongTextColourOne, CommonLongTextColourTwo, CommonShortTextColourOne, CommonShortTextColourTwo, OverrideFocusLongTextColourOne, OverrideFocusLongTextColourTwo, OverrideFocusShortTextColourOne, OverrideFocusShortTextColourTwo, OverrideNotVisitedLongTextColourOne, OverrideNotVisitedLongTextColourTwo, OverrideNotVisitedShortTextColourOne, OverrideNotVisitedShortTextColourTwo, OverridePressedLongTextColourOne, OverridePressedLongTextColourTwo, OverridePressedShortTextColourOne, OverridePressedShortTextColourTwo, OverrideVisitedLongTextColourOne, OverrideVisitedLongTextColourTwo, OverrideVisitedShortTextColourOne, OverrideVisitedShortTextColourTwo, LongTextTypeface, ShortTextTypeface);
        }
        #endregion

        #region Method
        /// <summary>Updates the appearance values.</summary>
        /// <param name="commonLongTextColourOne">The common long text colour one.</param>
        /// <param name="commonLongTextColourTwo">The common long text colour two.</param>
        /// <param name="commonShortTextColourOne">The common short text colour one.</param>
        /// <param name="commonShortTextColourTwo">The common short text colour two.</param>
        /// <param name="overrideFocusLongTextColourOne">The override focus long text colour one.</param>
        /// <param name="overrideFocusLongTextColourTwo">The override focus long text colour two.</param>
        /// <param name="overrideFocusShortTextColourOne">The override focus short text colour one.</param>
        /// <param name="overrideFocusShortTextColourTwo">The override focus short text colour two.</param>
        /// <param name="overrideNotVisitedLongTextColourOne">The override not visited long text colour one.</param>
        /// <param name="overrideNotVisitedLongTextColourTwo">The override not visited long text colour two.</param>
        /// <param name="overrideNotVisitedShortTextColourOne">The override not visited short text colour one.</param>
        /// <param name="overrideNotVisitedShortTextColourTwo">The override not visited short text colour two.</param>
        /// <param name="overridePressedLongTextColourOne">The override pressed long text colour one.</param>
        /// <param name="overridePressedLongTextColourTwo">The override pressed long text colour two.</param>
        /// <param name="overridePressedShortTextColourOne">The override pressed short text colour one.</param>
        /// <param name="overridePressedShortTextColourTwo">The override pressed short text colour two.</param>
        /// <param name="overrideVisitedLongTextColourOne">The override visited long text colour one.</param>
        /// <param name="overrideVisitedLongTextColourTwo">The override visited long text colour two.</param>
        /// <param name="overrideVisitedShortTextColourOne">The override visited short text colour one.</param>
        /// <param name="overrideVisitedShortTextColourTwo">The override visited short text colour two.</param>
        /// <param name="typeface">The typeface.</param>
        private void UpdateCommonAppearanceValues(Color commonLongTextColourOne, Color commonLongTextColourTwo, Color commonShortTextColourOne, Color commonShortTextColourTwo, Color overrideFocusLongTextColourOne, Color overrideFocusLongTextColourTwo, Color overrideFocusShortTextColourOne, Color overrideFocusShortTextColourTwo, Color overrideNotVisitedLongTextColourOne, Color overrideNotVisitedLongTextColourTwo, Color overrideNotVisitedShortTextColourOne, Color overrideNotVisitedShortTextColourTwo, Color overridePressedLongTextColourOne, Color overridePressedLongTextColourTwo, Color overridePressedShortTextColourOne, Color overridePressedShortTextColourTwo, Color overrideVisitedLongTextColourOne, Color overrideVisitedLongTextColourTwo, Color overrideVisitedShortTextColourOne, Color overrideVisitedShortTextColourTwo, Font longTextTypeface, Font shortTextTypeface)
        {
            #region Common
            StateCommon.LongText.Color1 = commonLongTextColourOne;

            StateCommon.LongText.Color2 = commonLongTextColourTwo;

            StateCommon.LongText.Font = longTextTypeface;

            StateCommon.ShortText.Color1 = commonShortTextColourOne;

            StateCommon.ShortText.Color2 = commonShortTextColourTwo;

            StateCommon.ShortText.Font = shortTextTypeface;
            #endregion

            #region Override Focus
            OverrideFocus.LongText.Color1 = overrideFocusLongTextColourOne;

            OverrideFocus.LongText.Color2 = overrideFocusLongTextColourTwo;

            OverrideFocus.LongText.Font = longTextTypeface;

            OverrideFocus.ShortText.Color1 = overrideFocusShortTextColourOne;

            OverrideFocus.ShortText.Color2 = overrideFocusShortTextColourTwo;

            OverrideFocus.ShortText.Font = shortTextTypeface;
            #endregion

            #region Override Not Visited
            OverrideNotVisited.LongText.Color1 = overrideNotVisitedLongTextColourOne;

            OverrideNotVisited.LongText.Color2 = overrideNotVisitedLongTextColourTwo;

            OverrideNotVisited.LongText.Font = longTextTypeface;

            OverrideNotVisited.ShortText.Color1 = overrideNotVisitedShortTextColourOne;

            OverrideNotVisited.ShortText.Color2 = overrideNotVisitedShortTextColourTwo;

            OverrideNotVisited.ShortText.Font = shortTextTypeface;
            #endregion

            #region Override Pressed
            OverridePressed.LongText.Color1 = overridePressedLongTextColourOne;

            OverridePressed.LongText.Color2 = overridePressedLongTextColourTwo;

            OverridePressed.LongText.Font = longTextTypeface;

            OverridePressed.ShortText.Color1 = overridePressedShortTextColourOne;

            OverridePressed.ShortText.Color2 = overridePressedShortTextColourTwo;

            OverridePressed.ShortText.Font = shortTextTypeface;
            #endregion

            #region Override Visited
            OverrideVisited.LongText.Color1 = overrideVisitedLongTextColourOne;

            OverrideVisited.LongText.Color2 = overrideVisitedLongTextColourTwo;

            OverrideVisited.LongText.Font = longTextTypeface;

            OverrideVisited.ShortText.Color1 = overrideVisitedShortTextColourOne;

            OverrideVisited.ShortText.Color2 = overrideVisitedShortTextColourTwo;

            OverrideVisited.ShortText.Font = shortTextTypeface;
            #endregion
        }
        #endregion

        #region Overrides
        /// <summary>Raises the Paint event.</summary>
        /// <param name="e">A PaintEventArgs that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateCommonAppearanceValues(CommonLongTextColourOne, CommonLongTextColourTwo, CommonShortTextColourOne, CommonShortTextColourTwo, OverrideFocusLongTextColourOne, OverrideFocusLongTextColourTwo, OverrideFocusShortTextColourOne, OverrideFocusShortTextColourTwo, OverrideNotVisitedLongTextColourOne, OverrideNotVisitedLongTextColourTwo, OverrideNotVisitedShortTextColourOne, OverrideNotVisitedShortTextColourTwo, OverridePressedLongTextColourOne, OverridePressedLongTextColourTwo, OverridePressedShortTextColourOne, OverridePressedShortTextColourTwo, OverrideVisitedLongTextColourOne, OverrideVisitedLongTextColourTwo, OverrideVisitedShortTextColourOne, OverrideVisitedShortTextColourTwo, LongTextTypeface, ShortTextTypeface);

            base.OnPaint(e);
        }
        #endregion
    }
}