using KryptonBackupUtility.Enumerations;
using System.Collections.Generic;
using System.IO;

namespace KryptonBackupUtility.Classes
{
    internal class BackgroundWorkerInstructions
    {
        #region Variables
        private DirectoryInfo _targetBaseDirectory;

        private DirectoryParsing _parsingType;

        private List<DirectoryInfo> _sourceDirectoryInfoList;
        #endregion

        #region Properties
        public DirectoryInfo TargetBaseDirectory { get => _targetBaseDirectory; set => _targetBaseDirectory = value; }

        public DirectoryParsing ParsingType { get => _parsingType; set => _parsingType = value; }

        public List<DirectoryInfo> SourceDirectoryInfoList { get => _sourceDirectoryInfoList; set => _sourceDirectoryInfoList = value; }
        #endregion

        #region Constructor
        public BackgroundWorkerInstructions()
        {

        }
        #endregion
    }
}