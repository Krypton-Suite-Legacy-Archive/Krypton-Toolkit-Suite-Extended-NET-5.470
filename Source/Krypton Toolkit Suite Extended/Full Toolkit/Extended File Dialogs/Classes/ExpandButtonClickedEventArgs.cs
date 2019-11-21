#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;

namespace ExtendedFileDialogs.Classes
{
    /// <summary>
    /// Provides data for the <see cref="TaskDialog.ExpandButtonClicked"/> event.
    /// </summary>
    /// <threadsafety instance="false" static="true" />
    public class ExpandButtonClickedEventArgs : EventArgs
    {
        private bool _expanded;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpandButtonClickedEventArgs"/> class with the specified expanded state.
        /// </summary>
        /// <param name="expanded"><see langword="true" /> if the the expanded content on the dialog is shown; otherwise, <see langword="false" />.</param>
        public ExpandButtonClickedEventArgs(bool expanded)
        {
            _expanded = expanded;
        }

        /// <summary>
        /// Gets a value that indicates if the expanded content on the dialog is shown.
        /// </summary>
        /// <value><see langword="true" /> if the expanded content on the dialog is shown; otherwise, <see langword="false" />.</value>
        public bool Expanded
        {
            get { return _expanded; }
        }
    }
}