#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

namespace ExtendedControls.Enumerations
{
    /// <summary>
    /// Text alignment options.
    /// </summary>
    public enum TextAlignment
    {
        /// <summary>
        /// Align text to the left.
        /// </summary>
        LEFT = 1,
        /// <summary>
        /// Align text to the right.
        /// </summary>
        RIGHT = 2,
        /// <summary>
        /// Centre the text.
        /// </summary>
        CENTRE = 3,
        /// <summary>
        /// Justify the text.
        /// </summary>
        JUSTIFY = 4
    }

    /// <summary>
    /// The elements to look up when setting a color.
    /// </summary>
    public enum ColourLookupElement
    {
        #region Enum members.
        // ------------------------------------------------------------------

        CUSTOMCOLOURS,
        BROWSERSAFECOLOURS,
        WEBCOLOURS,
        SYSTEMCOLOURS,
        SCHEMECOLOURS

        // ------------------------------------------------------------------
        #endregion
    }

    public enum SupportedIconSizes : int
    {
        LARGEICONS32X32 = 0,
        SMALLICONS16X16 = 1
    }
}