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