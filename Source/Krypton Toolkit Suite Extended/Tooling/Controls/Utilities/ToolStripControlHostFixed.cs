using System.Windows.Forms;

namespace Core.Controls.Utilities
{
    public class ToolStripControlHostFixed : ToolStripControlHost
    {
        public ToolStripControlHostFixed() : base(new Control())
        {

        }

        public ToolStripControlHostFixed(Control control) : base(control)
        {

        }
    }
}