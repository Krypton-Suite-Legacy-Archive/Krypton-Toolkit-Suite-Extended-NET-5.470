#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;

namespace ExtendedControls.ExtendedToolkit.Controls.Drawing.Classes
{
    public class ColourChangedEventArgs : EventArgs
    {

        private ColourHandler.RGB mRGB;
        private ColourHandler.HSV mHSV;

        public ColourChangedEventArgs(ColourHandler.RGB RGB, ColourHandler.HSV HSV)
        {
            mRGB = RGB;
            mHSV = HSV;
        }

        public ColourHandler.RGB RGB
        {
            get
            {
                return mRGB;
            }
        }

        public ColourHandler.HSV HSV
        {
            get
            {
                return mHSV;
            }
        }
    }
}