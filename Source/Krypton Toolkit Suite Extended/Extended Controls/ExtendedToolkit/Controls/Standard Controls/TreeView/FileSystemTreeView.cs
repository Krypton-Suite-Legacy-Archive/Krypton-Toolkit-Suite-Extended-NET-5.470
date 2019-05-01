#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.TreeView
{
    /// <summary>
    /// Summary description for DirectoryTreeView.
    /// </summary> 
    ///    
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.TreeView))]
    public class FileSystemTreeView : System.Windows.Forms.TreeView
    {
        private bool _showFiles = true;
        private ImageList _imageList = new ImageList();
        private Hashtable _systemIcons = new Hashtable();
        private ImageList ilIcons;
        private IContainer components;

        public static readonly int Folder = 0;

        public FileSystemTreeView()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.ImageList = _imageList;
            this.ImageList.ColorDepth = ColorDepth.Depth32Bit;

            this.MouseDown += new MouseEventHandler(FileSystemTreeView_MouseDown);
            this.BeforeExpand += new TreeViewCancelEventHandler(FileSystemTreeView_BeforeExpand);
        }

        private void FileSystemTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            TreeNode node = this.GetNodeAt(e.X, e.Y);

            if (node == null)
                return;

            this.SelectedNode = node; //select the node under the mouse         
        }

        private void FileSystemTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node is FileNode) return;

            DirectoryNode node = (DirectoryNode)e.Node;

            if (!node.Loaded)
            {
                node.Nodes[0].Remove(); //remove the fake child node used for virtualization
                node.LoadDirectory();
                if (this._showFiles == true)
                    node.LoadFiles();
            }
        }

        public void Load(string directoryPath)
        {
            if (Directory.Exists(directoryPath) == false)
                throw new DirectoryNotFoundException("Directory Not Found");

            _systemIcons.Clear();
            _imageList.Images.Clear();
            Nodes.Clear();

            //Icon folderIcon = new Icon(typeof(FileSystemTreeView), "icons.folder.ico");

            _imageList.Images.Add(ilIcons.Images[0]);
            _systemIcons.Add(FileSystemTreeView.Folder, 0);

            DirectoryNode node = new DirectoryNode(this, new DirectoryInfo(directoryPath));
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



        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileSystemTreeView));
            this.ilIcons = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // ilIcons
            // 
            this.ilIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIcons.ImageStream")));
            this.ilIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIcons.Images.SetKeyName(0, "folder.ico");
            this.ResumeLayout(false);

        }
    }

    public class DirectoryNode : TreeNode
    {
        private DirectoryInfo _directoryInfo;

        public DirectoryNode(DirectoryNode parent, DirectoryInfo directoryInfo)
            : base(directoryInfo.Name)
        {
            this._directoryInfo = directoryInfo;

            this.ImageIndex = FileSystemTreeView.Folder;
            this.SelectedImageIndex = this.ImageIndex;

            parent.Nodes.Add(this);

            Virtualize();
        }

        public DirectoryNode(FileSystemTreeView treeView, DirectoryInfo directoryInfo)
            : base(directoryInfo.Name)
        {
            this._directoryInfo = directoryInfo;

            this.ImageIndex = FileSystemTreeView.Folder;
            this.SelectedImageIndex = this.ImageIndex;

            treeView.Nodes.Add(this);

            Virtualize();

        }

        private void Virtualize()
        {
            int fileCount = 0;

            try
            {
                if (this.TreeView.ShowFiles == true)
                    fileCount = this._directoryInfo.GetFiles().Length;

                if ((fileCount + this._directoryInfo.GetDirectories().Length) > 0)
                    new FakeChildNode(this);
            }
            catch
            {
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
            foreach (FileInfo file in _directoryInfo.GetFiles())
            {
                new FileNode(this, file);
            }
        }

        public bool Loaded
        {
            get
            {
                if (this.Nodes.Count != 0)
                {
                    if (this.Nodes[0] is FakeChildNode)
                        return false;
                }

                return true;
            }
        }

        public new FileSystemTreeView TreeView
        {
            get { return (FileSystemTreeView)base.TreeView; }
        }
    }

    public class FileNode : TreeNode
    {

        public FileInfo FileInfos
        {
            get { return this._fileInfo; }
            set { this._fileInfo = value; }
        }

        public string Filename
        {
            get { return _fileInfo.FullName; }
        }

        private FileInfo _fileInfo;
        private DirectoryNode _directoryNode;

        public FileNode(DirectoryNode directoryNode, FileInfo fileInfo)
            : base(fileInfo.Name)
        {
            this._directoryNode = directoryNode;
            this._fileInfo = fileInfo;

            this.ImageIndex = ((FileSystemTreeView)_directoryNode.TreeView).GetIconImageIndex(_fileInfo.FullName);
            this.SelectedImageIndex = this.ImageIndex;

            _directoryNode.Nodes.Add(this);
        }
    }

    public class FakeChildNode : TreeNode
    {
        public FakeChildNode(TreeNode parent)
            : base()
        {
            parent.Nodes.Add(this);
        }
    }

}