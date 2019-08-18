using ComponentFactory.Krypton.Toolkit;
using System.Drawing;

namespace ExtendedStandardControls
{
    [ToolboxBitmap(typeof(KryptonLinkLabel))]
    public class KryptonLinkLabelExtended : KryptonLinkLabel
    {
        #region Variables
        private Color _overrideFocusLongTextColourOne, _overrideFocusLongTextColourTwo, _overrideFocusShortTextColourOne, _overrideFocusShortTextColourTwo, _overrideNotVisitedLongTextColourOne, _overrideNotVisitedLongTextColourTwo, _overrideNotVisitedShortTextColourOne, _overrideNotVisitedShortTextColourTwo, _overridePressedLongTextColourOne, _overridePressedLongTextColourTwo, _overridePressedShortTextColourOne, _overridePressedShortTextColourTwo, _overrideVisitedLongTextColourOne, _overrideVisitedLongTextColourTwo, _overrideVisitedShortTextColourOne, _overrideVisitedShortTextColourTwo, _commonLongTextColourOne, _commonLongTextColourTwo, _commonShortTextColourOne, _commonShortTextColourTwo;

        private Font _typeface;
        #endregion

        #region Properties

        #region Override Focus
        public Color OverrideFocusLongTextColourOne { get => _overrideFocusLongTextColourOne; set { _overrideFocusLongTextColourOne = value; Invalidate(); } }

        public Color OverrideFocusLongTextColourTwo { get => _overrideFocusLongTextColourTwo; set { _overrideFocusLongTextColourTwo = value; Invalidate(); } }

        public Color OverrideFocusShortTextColourOne { get => _overrideFocusShortTextColourOne; set { _overrideFocusShortTextColourOne = value; Invalidate(); } }

        public Color OverrideFocusShortTextColourTwo { get => _overrideFocusShortTextColourTwo; set { _overrideFocusShortTextColourTwo = value; Invalidate(); } }
        #endregion

        #endregion
    }
}