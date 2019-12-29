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
    /// Class that provides data for the <see cref="TaskDialog.HyperlinkClicked"/> event.
    /// </summary>
    /// <threadsafety instance="false" static="true" />
    public class HyperlinkClickedEventArgs : EventArgs
    {
        private string _href;

        /// <summary>
        /// Creates a new instance of the <see cref="HyperlinkClickedEventArgs"/> class with the specified URL.
        /// </summary>
        /// <param name="href">The URL of the hyperlink.</param>
        public HyperlinkClickedEventArgs(string href)
        {
            _href = href;
        }

        /// <summary>
        /// Gets the URL of the hyperlink that was clicked.
        /// </summary>
        /// <value>
        /// The value of the href attribute of the hyperlink.
        /// </value>
        public string Href
        {
            get { return _href; }
        }
    }
}