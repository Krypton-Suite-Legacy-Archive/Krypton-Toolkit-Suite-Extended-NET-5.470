#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

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