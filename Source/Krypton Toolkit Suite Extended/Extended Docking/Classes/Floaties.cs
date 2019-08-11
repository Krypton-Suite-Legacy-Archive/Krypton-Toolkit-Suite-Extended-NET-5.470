using System.Collections.Generic;
using System.Windows.Forms;

namespace ExtendedDocking
{
    public class Floaties : List<IFloatingWindow>
    {
        public IFloatingWindow Find(Control control)
        {
            foreach (FloatingWindow window in this)
            {
                if (window.DockState.Container.Equals(control)) return window;
            }

            return null;
        }
    }
}