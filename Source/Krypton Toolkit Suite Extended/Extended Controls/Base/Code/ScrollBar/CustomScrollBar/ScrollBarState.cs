#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

namespace ExtendedControls.Base.Code.ScrollBar.CustomScrollBar
{
    /// <summary>
    /// The scrollbar states.
    /// </summary>
    internal enum ScrollBarState
    {
        /// <summary>
        /// Indicates a normal scrollbar state.
        /// </summary>
        NORMAL,

        /// <summary>
        /// Indicates a hot scrollbar state.
        /// </summary>
        HOT,

        /// <summary>
        /// Indicates an active scrollbar state.
        /// </summary>
        ACTIVE,

        /// <summary>
        /// Indicates a pressed scrollbar state.
        /// </summary>
        PRESSED,

        /// <summary>
        /// Indicates a disabled scrollbar state.
        /// </summary>
        DISABLED
    }
}