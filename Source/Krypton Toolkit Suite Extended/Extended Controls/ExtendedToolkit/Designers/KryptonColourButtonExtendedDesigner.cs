using System.ComponentModel.Design;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.Designers
{
    internal class KryptonColourButtonExtendedDesigner : ControlDesigner
    {
        #region Constructor
        public KryptonColourButtonExtendedDesigner()
        {
            AutoResizeHandles = true;
        }
        #endregion

        #region Overrides
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                DesignerActionItemCollection actionList = new DesignerActionItemCollection { new KryptonColourButtonExtendedActionList(this) };

                return actionList;
            }
        }
        #endregion
    }
}