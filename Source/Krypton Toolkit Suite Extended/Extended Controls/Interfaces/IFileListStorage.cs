using System.Collections.Generic;

namespace ExtendedControls.Interfaces
{
    /// <summary>
    /// A interface for managing files in the MRU file list. Adapted from (https://www.codeproject.com/Articles/1020671/MRU-File-Manager-Component)
    /// </summary>
    public interface IFileListStorage
    {
        /// <summary>
        /// Gets or sets the files declared in this storage instance.
        /// </summary>
        /// <value>
        /// The file listing. Each file should declare its full path.
        /// </value>
        IEnumerable<string> Files
        {
            get;

            set;
        }

        /// <summary>
        /// Adds a new file to the list.
        /// </summary>
        /// <param name="fullFilePath">The file name with full path.</param>
        void AddFileToRecentsList(string fullFilePath);

        /// <summary>
        /// Initialises this instance and sets up any local settings required for execution.
        /// </summary>
        void Initialise();

        /// <summary>
        /// Removes the file from the list.
        /// </summary>
        /// <param name="fullFilePath">The file name with full path.</param>
        void RemoveFileFromRecentsList(string fullFilePath);
    }
}