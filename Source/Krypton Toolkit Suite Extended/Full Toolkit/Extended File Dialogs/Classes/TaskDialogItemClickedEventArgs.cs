#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ExtendedFileDialogs.Controls;
using System.ComponentModel;

namespace ExtendedFileDialogs.Classes
{
    /// <summary>
    /// Provides data for the <see cref="TaskDialog.ButtonClicked"/> event.
    /// </summary>
    /// <threadsafety instance="false" static="true" />
    public class TaskDialogItemClickedEventArgs : CancelEventArgs
    {
        private readonly TaskDialogItem _item;

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDialogItemClickedEventArgs"/> class with the specified item.
        /// </summary>
        /// <param name="item">The <see cref="TaskDialogItem"/> that was clicked.</param>
        public TaskDialogItemClickedEventArgs(TaskDialogItem item)
        {
            _item = item;
        }

        /// <summary>
        /// Gets the item that was clicked.
        /// </summary>
        /// <value>
        /// The <see cref="TaskDialogItem"/> that was clicked.
        /// </value>
        public TaskDialogItem Item
        {
            get { return _item; }
        }
    }
}