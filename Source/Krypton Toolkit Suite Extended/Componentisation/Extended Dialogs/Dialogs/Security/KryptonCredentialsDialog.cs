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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedDialogs.Dialogs.Security
{
    public class KryptonCredentialsDialog : KryptonForm
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // KryptonCredentialsDialog
            // 
            this.ClientSize = new System.Drawing.Size(719, 338);
            this.Name = "KryptonCredentialsDialog";
            this.ResumeLayout(false);

        }
    }
}