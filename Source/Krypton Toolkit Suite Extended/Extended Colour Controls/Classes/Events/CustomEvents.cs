using System;
using System.Drawing;

namespace ExtendedColourControls.Classes.Events
{
    public class SelectedColourEventArgs : EventArgs
    {
        public Color SelectedColour { get; set; }
    }
}