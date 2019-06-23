using System;
using System.IO;
using System.Windows.Forms;
using ToolkitSettings.BackEnd;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.CustomTreeView
{
    public class DirectoryNode : TreeNode
    {
        #region Variable
        private DirectoryInfo _directoryInfo;
        #endregion

        #region Properties
        public bool Loaded
        {
            get
            {
                if (Nodes.Count != 0)
                {
                    if (Nodes[0] is FakeChildNode)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        public new FileSystemTreeView FileSystemTreeView { get => (FileSystemTreeView)TreeView; }
        #endregion

        #region Constructors
        public DirectoryNode(DirectoryNode parent, DirectoryInfo directoryInfo) : base(directoryInfo.Name)
        {
            _directoryInfo = directoryInfo;

            ImageIndex = FileSystemTreeView.FOLDER;

            SelectedImageIndex = ImageIndex;

            parent.Nodes.Add(this);

            Virtualise();
        }

        public DirectoryNode(FileSystemTreeView treeView, DirectoryInfo directoryInfo) : base(directoryInfo.Name)
        {
            _directoryInfo = directoryInfo;

            ImageIndex = FileSystemTreeView.FOLDER;

            SelectedImageIndex = ImageIndex;

            treeView.Nodes.Add(this);

            Virtualise();
        }
        #endregion

        #region Methods
        private void Virtualise()
        {
            int fileCount = 0;

            try
            {
                if (FileSystemTreeView.ShowFiles)
                {
                    fileCount = _directoryInfo.GetFiles().Length;
                }

                if ((fileCount + _directoryInfo.GetDirectories().Length) > 0)
                {
                    new FakeChildNode(this);
                }
            }
            catch (Exception exc)
            {
                Base.Code.Exceptions.ExceptionHandler.CaptureException(exc, icon: MessageBoxIcon.Error, methodSignature: MethodHelpers.GetCurrentMethod());
            }
        }

        public void LoadDirectory()
        {
            foreach (DirectoryInfo directoryInfo in _directoryInfo.GetDirectories())
            {
                new DirectoryNode(this, directoryInfo);
            }
        }

        public void LoadFiles()
        {
            foreach (FileInfo fileInfo in _directoryInfo.GetFiles())
            {
                new FileNode(this, fileInfo);
            }
        }
        #endregion
    }
}