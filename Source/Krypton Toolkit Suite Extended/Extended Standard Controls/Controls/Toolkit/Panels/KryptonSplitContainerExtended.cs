using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls
{
    [ToolboxBitmap(typeof(KryptonSplitContainer))]
    public class KryptonSplitContainerExtended : KryptonSplitContainer
    {
        #region Variables
        private Color _commonBackGroundColourOne, _commonBackGroundColourTwo, _commonSplitterColourOne, _commonSplitterColourTwo;
        #endregion

        #region Properties
        public Color CommonBackGroundColourOne { get => _commonBackGroundColourOne; set { _commonBackGroundColourOne = value; Invalidate(); } }

        public Color CommonBackGroundColourTwo { get => _commonBackGroundColourTwo; set { _commonBackGroundColourTwo = value; Invalidate(); } }

        public Color CommonSplitterColourOne { get => _commonSplitterColourOne; set { _commonSplitterColourOne = value; Invalidate(); } }

        public Color CommonSplitterColourTwo { get => _commonSplitterColourTwo; set { _commonSplitterColourTwo = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonSplitContainerExtended()
        {
            CommonBackGroundColourOne = Color.Empty;

            CommonBackGroundColourTwo = Color.Empty;

            CommonSplitterColourOne = Color.Empty;

            CommonSplitterColourTwo = Color.Empty;

            UpdateCommonAppearanceValues(CommonBackGroundColourOne, CommonBackGroundColourTwo, CommonSplitterColourOne, CommonSplitterColourTwo);
        }
        #endregion

        #region Method
        private void UpdateCommonAppearanceValues(Color commonBackGroundColourOne, Color commonBackGroundColourTwo, Color commonSplitterColourOne, Color commonSplitterColourTwo)
        {
            StateCommon.Back.Color1 = commonBackGroundColourOne;

            StateCommon.Back.Color2 = commonBackGroundColourTwo;

            StateCommon.Separator.Back.Color1 = commonSplitterColourOne;

            StateCommon.Separator.Back.Color2 = commonSplitterColourTwo;
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateCommonAppearanceValues(CommonBackGroundColourOne, CommonBackGroundColourTwo, CommonSplitterColourOne, CommonSplitterColourTwo);

            base.OnPaint(e);
        }
        #endregion
    }
}