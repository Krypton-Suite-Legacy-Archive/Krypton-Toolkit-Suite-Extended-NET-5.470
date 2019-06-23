using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.CustomTreeView
{
    [ToolboxBitmap(typeof(System.Windows.Forms.TreeView))]
    public class FileSystemTreeView : System.Windows.Forms.TreeView
    {
        #region Designer Code
        private ImageList ilIcons;
        private System.ComponentModel.IContainer components;

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
            this.ilIcons.Images.SetKeyName(0, "Folder_16_x16.ico");
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private bool _showFiles = true;

        private ImageList _imageList = new ImageList();

        private Hashtable _systemIcons = new Hashtable();

        public static readonly int FOLDER = 0;
        #endregion

        #region Property
        public bool ShowFiles { get => _showFiles; set => _showFiles = value; }
        #endregion

        #region Constructor
        public FileSystemTreeView()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            ImageList = _imageList;

            ImageList.ColorDepth = ColorDepth.Depth32Bit;

            MouseDown += FileSystemTreeView_MouseDown;

            BeforeExpand += FileSystemTreeView_BeforeExpand;
        }
        #endregion

        #region Event Handler
        private void FileSystemTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node is FileNode) return;

            DirectoryNode directoryNode = (DirectoryNode)e.Node;

            if (!directoryNode.Loaded)
            {
                directoryNode.Nodes[0].Remove();

                directoryNode.LoadDirectory();

                if (!_showFiles) directoryNode.LoadFiles();
            }
        }

        private void FileSystemTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            TreeNode node = GetNodeAt(e.X, e.Y);

            if (node == null) return;

            SelectedNode = node;
        }
        #endregion

        #region Methods
        public void Load(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                throw new DirectoryNotFoundException("Directory Not Found");
            }

            _systemIcons.Clear();

            _imageList.Images.Clear();

            Nodes.Clear();

            _imageList.Images.Add(ilIcons.Images[0]);

            _systemIcons.Add(FOLDER, 0);

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
        #endregion
    }
}