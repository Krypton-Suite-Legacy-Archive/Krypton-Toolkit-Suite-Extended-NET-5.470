using ComponentFactory.Krypton.Toolkit;
using ExtendedStandardControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class RibbonWindow : KryptonForm //Extended
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // RibbonWindow
            // 
            this.ClientSize = new System.Drawing.Size(1467, 628);
            this.Name = "RibbonWindow";
            this.ResumeLayout(false);

        }
    }
}