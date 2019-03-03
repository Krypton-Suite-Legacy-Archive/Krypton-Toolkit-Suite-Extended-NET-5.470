using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Utilities.Controls
{
    public class ToolStripUserControlHost : ToolStripControlHost
    {
        public ToolStripUserControlHost() : base(new UserControl())
        {

        }

        public ToolStripUserControlHost(UserControl c) : base(c)
        { }
    }
}