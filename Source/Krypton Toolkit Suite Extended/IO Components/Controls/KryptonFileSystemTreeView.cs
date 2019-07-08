#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IOComponents
{
    [ToolboxBitmap(typeof(KryptonTreeView)), Description("A directory and file browser.")]
    public class KryptonFileSystemTreeView : KryptonTreeView
    {
        private bool _showFiles = true;
        private ImageList _imageList = new ImageList();
        private Hashtable _systemIcons = new Hashtable();

        // Folder icon
        private Icon _folderIcon = null;

        public static readonly int Folder = 0;

        public Icon FolderIcon { get => _folderIcon; set => _folderIcon = value; }

        public KryptonFileSystemTreeView()
        {
            this.ImageList = _imageList;
            this.MouseDown += KryptonFileSystemTreeView_MouseDown;
            this.BeforeExpand += KryptonFileSystemTreeView_BeforeExpand;

            // Extracts the icon 
            try
            {
                string iconPath = "Icons\\Folder.ico";

                Icon appIcon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

                if (File.Exists(iconPath))
                {
                    FolderIcon = new Icon(iconPath);
                }
                else
                {
                    FolderIcon = appIcon;
                }
            }
            catch (Exception exc)
            {

                throw;
            }
        }

        private void KryptonFileSystemTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node is KryptonFileNode) return;

            KryptonDirectoryNode node = (KryptonDirectoryNode)e.Node;

            if (!node.Loaded)
            {
                node.Nodes[0].Remove(); //remove the fake child node used for virtualization
                node.LoadDirectory();
                if (this._showFiles == true)
                    node.LoadFiles();
            }
        }

        private void KryptonFileSystemTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            KryptonTreeNode node = (KryptonTreeNode)this.GetNodeAt(e.X, e.Y); //.GetNodeAt(e.X, e.Y);

            if (node == null)
                return;

            this.SelectedNode = node; //select the node under the mouse 
        }

        public void Load(string directoryPath)
        {
            if (Directory.Exists(directoryPath) == false)
                throw new DirectoryNotFoundException("Directory Not Found");

            _systemIcons.Clear();
            _imageList.Images.Clear();
            Nodes.Clear();

            Size iconSize = FolderIcon.Size;

            Icon folderIcon = new Icon(FolderIcon, new Size(iconSize.Width, iconSize.Height));

            _imageList.Images.Add(folderIcon);
            _systemIcons.Add(KryptonFileSystemTreeView.Folder, 0);

            KryptonDirectoryNode node = new KryptonDirectoryNode(this, new DirectoryInfo(directoryPath));
            node.Expand();
        }

        public int GetIconImageIndex(string path)
        {
            string extension = Path.GetExtension(path);

            if (_systemIcons.ContainsKey(extension) == false)
            {
                Icon icon = ShellIcon.GetSmallIcon(path);
                _imageList.Images.Add(icon);
                _systemIcons.Add(extension, _imageList.Images.Count - 1);
            }

            return (int)_systemIcons[Path.GetExtension(path)];
        }

        public bool ShowFiles
        {
            get { return this._showFiles; }
            set { this._showFiles = value; }
        }
    }

    public class KryptonDirectoryNode : KryptonTreeNode
    {
        private DirectoryInfo _directoryInfo;

        public new IOComponents.KryptonFileSystemTreeView TreeView { get => (IOComponents.KryptonFileSystemTreeView)base.TreeView; }

        public KryptonDirectoryNode(KryptonDirectoryNode parent, DirectoryInfo directoryInfo) : base(directoryInfo.Name)
        {
            _directoryInfo = directoryInfo;

            ImageIndex = KryptonFileSystemTreeView.Folder;

            SelectedImageIndex = ImageIndex;

            parent.Nodes.Add(this);

            Virtualize();
        }

        public KryptonDirectoryNode(KryptonFileSystemTreeView treeView, DirectoryInfo directoryInfo) : base(directoryInfo.Name)
        {
            _directoryInfo = directoryInfo;

            ImageIndex = KryptonFileSystemTreeView.Folder;

            SelectedImageIndex = ImageIndex;

            treeView.Nodes.Add(this);

            Virtualize();
        }

        private void Virtualize()
        {
            int fileCount = 0;

            try
            {
                if (TreeView.ShowFiles) fileCount = _directoryInfo.GetFiles().Length;

                if ((fileCount + _directoryInfo.GetDirectories().Length) > 0) new KryptonFakeChildNode(this);
            }
            catch
            {
            }
        }

        public void LoadDirectory()
        {
            foreach (DirectoryInfo directoryInfo in _directoryInfo.GetDirectories())
            {
                new KryptonDirectoryNode(this, directoryInfo);
            }
        }

        public void LoadFiles()
        {
            foreach (FileInfo file in _directoryInfo.GetFiles())
            {
                new KryptonFileNode(this, file);
            }
        }

        public bool Loaded
        {
            get
            {
                if (this.Nodes.Count != 0)
                {
                    if (this.Nodes[0] is KryptonFakeChildNode)
                        return false;
                }

                return true;
            }
        }
    }

    public class KryptonFakeChildNode : KryptonTreeNode
    {
        public KryptonFakeChildNode(KryptonTreeNode parent) : base()
        {
            parent.Nodes.Add(this);
        }
    }

    public class KryptonFileNode : KryptonTreeNode
    {
        private FileInfo _fileInfo;

        private KryptonDirectoryNode _kryptonDirectoryNode;

        public KryptonFileNode(KryptonDirectoryNode kryptonDirectoryNode, FileInfo fileInfo) : base(fileInfo.Name)
        {
            _kryptonDirectoryNode = kryptonDirectoryNode;

            _fileInfo = fileInfo;

            ImageIndex = ((KryptonFileSystemTreeView)_kryptonDirectoryNode.TreeView).GetIconImageIndex(_fileInfo.FullName);

            SelectedImageIndex = ImageIndex;

            _kryptonDirectoryNode.Nodes.Add(this);
        }
    }
}