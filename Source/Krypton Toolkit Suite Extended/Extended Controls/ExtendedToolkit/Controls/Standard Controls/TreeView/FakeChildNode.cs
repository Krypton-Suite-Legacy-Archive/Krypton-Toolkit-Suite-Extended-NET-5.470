using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.CustomTreeView
{
    public class FakeChildNode : TreeNode
    {
        #region Constructor
        public FakeChildNode(TreeNode parent) : base()
        {
            parent.Nodes.Add(this);
        }
        #endregion
    }
}