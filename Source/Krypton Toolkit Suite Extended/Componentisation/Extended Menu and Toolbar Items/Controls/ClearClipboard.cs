#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System.Windows.Forms;

namespace ExtendedMenuToolbarItems.Controls
{
    public class ClearClipboard : MenuItem
    {
        #region Variables

        #endregion

        #region Constructor
        public ClearClipboard()
        {
            Text = "Clear &&Clipboard";
        }
        #endregion

        #region Methods
        private bool IsClipboardEmpty() => Clipboard.ContainsText();
        #endregion
    }
}