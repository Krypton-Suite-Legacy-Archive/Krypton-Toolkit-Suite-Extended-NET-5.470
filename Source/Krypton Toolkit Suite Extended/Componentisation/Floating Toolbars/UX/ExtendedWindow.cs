using ComponentFactory.Krypton.Toolkit;
using FloatingToolbars.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingToolbars.UX
{
    public class ExtendedWindow : KryptonForm
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ExtendedWindow
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "ExtendedWindow";
            this.ResumeLayout(false);

        }

        #region Variables
        private FloatableMenuStrip _floatableMenuStrip;
        #endregion
    }
}