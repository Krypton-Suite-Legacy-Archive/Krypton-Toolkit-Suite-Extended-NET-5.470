#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Utilities.Controls
{
    public class ToolStripUserControlHost : ToolStripControlHost
    {
        public ToolStripUserControlHost() : base(new UserControl())
        {

        }

        public ToolStripUserControlHost(UserControl c) : base(c)
        { }
    }
}