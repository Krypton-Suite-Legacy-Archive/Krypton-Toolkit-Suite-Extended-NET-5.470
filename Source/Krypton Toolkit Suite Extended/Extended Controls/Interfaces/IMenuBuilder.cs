using System;
using System.Collections.Generic;

namespace ExtendedControls.Interfaces
{
    /// <summary>
    /// A interface for handling a MRU list. Adapted from (https://www.codeproject.com/Articles/1020671/MRU-File-Manager-Component).
    /// </summary>
    public interface IMenuBuilder
    {
        /// <summary>
        /// Clears the menu items of all files.
        /// </summary>
        void ClearRecentFiles();

        /// <summary>
        /// Rebuilds the menus.
        /// </summary>
        /// <param name="files">The file listing.</param>
        /// <param name="fileMenuItemClick">The handler for when one of the automatically added recent file menu items is clicked..</param>
        /// <param name="clearListMenuItemText">The clear list menu item text. A <c>null</c> value indicates that this menu items should not be shown.</param>
        /// <param name="clearListMenuItemClick">The handler for when the clear recent files menu item is clicked.</param>
        void RebuildMenus(IEnumerable<string> files, Action<string> fileMenuItemClick, string clearListMenuItemText = null, Action clearListMenuItemClick = null);
    }
}