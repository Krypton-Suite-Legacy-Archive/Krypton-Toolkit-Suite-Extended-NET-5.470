using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedStandardControls.Controls
{
    [ToolboxBitmap(typeof(KryptonTreeView))]
    public class KryptonTreeViewExtended : KryptonTreeView
    {
        #region Variables
        private Color _backGroundColour, _nodeBackgroundColourOne, _nodeBackgroundColourTwo, _nodeLongTextColourOne, _nodeLongTextColourTwo, _nodeShortTextColourOne, _nodeShortTextColourTwo;

        private Font _typeface;
        #endregion

        #region Properties
        public Color BackgroundColour { get => _backGroundColour; set { _backGroundColour = value; Invalidate(); } }

        public Color NodeBackgroundColourOne { get => _nodeBackgroundColourOne; set { _nodeBackgroundColourOne = value; Invalidate(); } }

        public Color NodeBackgroundColourTwo { get => _nodeBackgroundColourTwo; set { _nodeBackgroundColourTwo = value; Invalidate(); } }

        public Color NodeLongTextColourOne { get => _nodeLongTextColourOne; set { _nodeLongTextColourOne = value; Invalidate(); } }

        public Color NodeLongTextColourTwo { get => _nodeLongTextColourTwo; set { _nodeLongTextColourTwo = value; Invalidate(); } }

        public Color NodeShortTextColourOne { get => _nodeShortTextColourOne; set { _nodeShortTextColourOne = value; Invalidate(); } }

        public Color NodeShortTextColourTwo { get => _nodeShortTextColourTwo; set { _nodeShortTextColourTwo = value; Invalidate(); } }

        public Font Typeface { get => _typeface; set { _typeface = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonTreeViewExtended()
        {
            BackgroundColour = Color.Empty;

            NodeBackgroundColourOne = Color.Empty;

            NodeBackgroundColourTwo = Color.Empty;

            NodeLongTextColourOne = Color.Empty;

            NodeLongTextColourTwo = Color.Empty;

            NodeShortTextColourOne = Color.Empty;

            NodeShortTextColourTwo = Color.Empty;

            Typeface = null;

            UpdateAppearanceValues(BackgroundColour, NodeBackgroundColourOne, NodeBackgroundColourTwo, NodeLongTextColourOne, NodeLongTextColourTwo, NodeShortTextColourOne, NodeShortTextColourTwo, Typeface);
        }
        #endregion

        #region Method
        private void UpdateAppearanceValues(Color backgroundColour, Color nodeBackgroundColourOne, Color nodeBackgroundColourTwo, Color nodeLongTextColourOne, Color nodeLongTextColourTwo, Color nodeShortTextColourOne, Color nodeShortTextColourTwo, Font typeface)
        {
            StateCommon.Back.Color1 = backgroundColour;

            StateCommon.Node.Back.Color1 = nodeBackgroundColourOne;

            StateCommon.Node.Back.Color2 = nodeBackgroundColourTwo;

            StateCommon.Node.Content.LongText.Color1 = nodeLongTextColourOne;

            StateCommon.Node.Content.LongText.Color2 = nodeLongTextColourTwo;

            StateCommon.Node.Content.LongText.Font = typeface;

            StateCommon.Node.Content.ShortText.Color1 = nodeShortTextColourOne;

            StateCommon.Node.Content.ShortText.Color2 = nodeShortTextColourTwo;

            StateCommon.Node.Content.ShortText.Font = typeface;
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            UpdateAppearanceValues(BackgroundColour, NodeBackgroundColourOne, NodeBackgroundColourTwo, NodeLongTextColourOne, NodeLongTextColourTwo, NodeShortTextColourOne, NodeShortTextColourTwo, Typeface);

            base.OnPaint(e);
        }
        #endregion
    }
}