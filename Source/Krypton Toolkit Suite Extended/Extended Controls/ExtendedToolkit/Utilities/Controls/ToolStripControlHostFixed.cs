using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Utilities.Controls
{
    public class ToolStripControlHostFixed : ToolStripControlHost
    {
        public ToolStripControlHostFixed() : base(new Control())
        {

        }

        public ToolStripControlHostFixed(Control c) : base(c)
        {

        }
    }
}