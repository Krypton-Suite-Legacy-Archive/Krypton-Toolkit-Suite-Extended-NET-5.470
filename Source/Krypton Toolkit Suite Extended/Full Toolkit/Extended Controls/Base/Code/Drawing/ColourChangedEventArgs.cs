#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;

namespace ExtendedControls.Base.Code.Drawing
{
    public class ColourChangedEventArgs : EventArgs
    {
        private ColourHandler.RGB rGB;

        private ColourHandler.HSV hSV;

        public ColourHandler.RGB RGB { get { return rGB; } }

        public ColourHandler.HSV HSV { get { return hSV; } }

        public ColourChangedEventArgs(ColourHandler.RGB RGB, ColourHandler.HSV HSV)
        {
            rGB = RGB;

            hSV = HSV;
        }
    }
}