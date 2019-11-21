#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls
{
    public class KryptonSlideButton : Control
    {
        #region Variables
        private float diameter;
        //private RoundedRectangleF rect;
        private RectangleF circle;
        private bool isOn;
        private float artis;
        private Color borderColour;
        private bool textEnabled;
        private Timer paintTicker = new Timer();
        private KryptonPalette palette = new KryptonPalette();
        #endregion
    }
}