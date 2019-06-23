using System.IO;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.CustomTreeView
{
    public class FileNode : TreeNode
    {
        #region Variables
        private FileInfo _fileInfo;

        private DirectoryNode _directoryNode;
        #endregion

        #region Properties
        public FileInfo FileInformation { get => _fileInfo; set => _fileInfo = value; }

        public string FileName { get => FileInformation.FullName; }
        #endregion

        #region Constructor
        public FileNode(DirectoryNode directoryNode, FileInfo fileInfo) : base(fileInfo.Name)
        {
            _directoryNode = directoryNode;

            _fileInfo = fileInfo;

            ImageIndex = ((FileSystemTreeView)_directoryNode.FileSystemTreeView).GetIconImageIndex(_fileInfo.FullName);

            SelectedImageIndex = ImageIndex;

            _directoryNode.Nodes.Add(this);
        }
        #endregion
    }
}