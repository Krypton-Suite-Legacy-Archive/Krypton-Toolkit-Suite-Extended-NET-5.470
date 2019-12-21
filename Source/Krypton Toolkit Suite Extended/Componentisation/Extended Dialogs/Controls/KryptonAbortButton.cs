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
using System.Windows.Forms;

namespace ExtendedDialogs.Controls
{
    public class KryptonAbortButton : KryptonButtonExtended
    {
        public KryptonAbortButton()
        {
            Text = "A&bort";

            DialogResult = DialogResult.Abort;
        }

        protected override void OnClick(EventArgs e)
        {
            DialogResult = DialogResult.Abort;

            base.OnClick(e);
        }
    }
}