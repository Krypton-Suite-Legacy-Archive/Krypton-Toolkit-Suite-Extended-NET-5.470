#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System.ComponentModel;
using System.Drawing;

namespace Core.Classes.Colours
{
    public class EditColourCancelEventArgs : CancelEventArgs
    {
        #region Constructors

        public EditColourCancelEventArgs(Color colour, int colourIndex)
        {
            this.Colour = colour;
            this.ColourIndex = colourIndex;
        }

        protected EditColourCancelEventArgs()
        { }

        #endregion

        #region Properties

        public Color Colour { get; protected set; }

        public int ColourIndex { get; protected set; }

        #endregion
    }
}