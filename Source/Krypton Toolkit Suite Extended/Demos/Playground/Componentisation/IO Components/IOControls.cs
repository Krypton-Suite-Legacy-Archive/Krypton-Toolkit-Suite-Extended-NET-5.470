#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System;

namespace Playground.Componentisation.IOComponents
{
    public class IOControls : KryptonForm
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // IOControls
            // 
            this.ClientSize = new System.Drawing.Size(1257, 617);
            this.Name = "IOControls";
            this.Load += new System.EventHandler(this.IOControls_Load);
            this.ResumeLayout(false);

        }

        private void IOControls_Load(object sender, EventArgs e)
        {

        }
    }
}