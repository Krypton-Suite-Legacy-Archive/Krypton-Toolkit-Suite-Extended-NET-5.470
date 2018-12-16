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