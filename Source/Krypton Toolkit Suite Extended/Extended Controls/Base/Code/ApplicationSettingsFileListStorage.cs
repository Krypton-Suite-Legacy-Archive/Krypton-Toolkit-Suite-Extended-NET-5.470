using ExtendedControls.Interfaces;
using System;
using System.Collections.Generic;

namespace ExtendedControls.Base.Code
{
    /// <summary>
    /// Storage in the local application settings. Adapted from (https://www.codeproject.com/Articles/1020671/MRU-File-Manager-Component).
    /// </summary>
    public class ApplicationSettingsFileListStorage : IFileListStorage
    {
        public IEnumerable<string> Files { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddFileToRecentsList(string fullFilePath)
        {
            throw new NotImplementedException();
        }

        public void Initialise()
        {
            throw new NotImplementedException();
        }

        public void RemoveFileFromRecentsList(string fullFilePath)
        {
            throw new NotImplementedException();
        }
    }
}