#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ExtendedStandardControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendedDialogs.Controls
{
    public class KryptonCancelButton : KryptonButtonExtended
    {
        public KryptonCancelButton()
        {
            Text = "C&ancel";

            DialogResult = DialogResult.Cancel;
        }

        protected override void OnClick(EventArgs e)
        {
            DialogResult = DialogResult.Cancel;


            base.OnClick(e);
        }
    }
}