#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

namespace ExtendedDialogs.Dialogs.About
{
    /// <summary>
    /// The button layout type.
    /// </summary>
    public enum KryptonAboutBoxLayoutButtonType
    {
        /// <summary>The close button only.</summary>
        CLOSEONLY = 0,
        /// <summary>The close and copyright buttons.</summary>
        CLOSEANDCOPYRIGHT = 1,
        /// <summary>The close, copyright and technical buttons.</summary>
        CLOSECOPYRIGHTANDTECHNICAL = 2,
        /// <summary>The close, copyright, technical, and license buttons.</summary>
        CLOSECOPYRIGHTTECHNICALANDLICENSE = 3,
        /// <summary>The close, copyright, technical, and, description buttons.</summary>
        CLOSECOPYRIGHTTECHNICALANDDESCRIPTION = 4,
        /// <summary>The close and technical buttons.</summary>
        CLOSEANDTECHNICAL = 5,
        /// <summary>The close, technical, and license buttons.</summary>
        CLOSETECHNICALANDLICENSE = 6,
        /// <summary>The close, technical and description buttons.</summary>
        CLOSETECHNICALANDDESCRIPTION = 7,
        /// <summary>The close and license buttons.</summary>
        CLOSEANDLICENSE = 8,
        /// <summary>The close, license and description buttons.</summary>
        CLOSELICENSEANDDESCRIPTION = 9,
        /// <summary>The close and description buttons.</summary>
        CLOSEANDDESCRIPTION = 10,
        /// <summary>All buttons.</summary>
        ALL = 11
    }
}