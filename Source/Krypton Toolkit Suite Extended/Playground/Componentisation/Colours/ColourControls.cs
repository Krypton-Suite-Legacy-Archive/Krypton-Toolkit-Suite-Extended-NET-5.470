using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Componentisation.Colours
{
    public class ColourControls : KryptonForm
    {
        private ExtendedColourControls.ColourWheel colourWheel1;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ColourControls
            // 
            this.ClientSize = new System.Drawing.Size(1429, 725);
            this.Name = "ColourControls";
            this.ResumeLayout(false);

        }
    }
}