using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitSuiteExtendedCore;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace IOComponents
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    [ToolboxBitmap(typeof(KryptonTreeView)), DefaultEvent("PathChanged")]
    public class KryptonFileSystemUserControl : UserControl
    {
        #region Designer Code
        private ContextMenuStrip cmsShortcuts;
        private ToolStripMenuItem removeShortcutToolStripMenuItem;
        private ImageList ilSystemIcons;
        private System.ComponentModel.IContainer components;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxtPath;
        private KryptonButton kbtnInfo;
        private KryptonButton kbtnNext;
        private KryptonButton kbtnUp;
        private KryptonButton kbtnRefresh;
        private KryptonButton kbtnHome;
        private KryptonButton kbtnGo;
        private KryptonButton kbtnAdd;
        private KryptonButton kbtnBack;
        private KryptonTreeView ktvFileSystem;
        private Panel pnlTop;
        private ColumnHeader clmnPath;
        private ColumnHeader clmnStatus;
        private ListView listView1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonFileSystemUserControl));
            this.cmsShortcuts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeShortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilSystemIcons = new System.Windows.Forms.ImageList(this.components);
            this.ktxtPath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kbtnInfo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnNext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnUp = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnHome = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnBack = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmnPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ktvFileSystem = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.cmsShortcuts.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsShortcuts
            // 
            this.cmsShortcuts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsShortcuts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeShortcutToolStripMenuItem});
            this.cmsShortcuts.Name = "cmsShortcuts";
            this.cmsShortcuts.Size = new System.Drawing.Size(166, 26);
            // 
            // removeShortcutToolStripMenuItem
            // 
            this.removeShortcutToolStripMenuItem.Name = "removeShortcutToolStripMenuItem";
            this.removeShortcutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeShortcutToolStripMenuItem.Text = "&Remove Shortcut";
            this.removeShortcutToolStripMenuItem.Click += new System.EventHandler(this.RemoveShortcutToolStripMenuItem_Click);
            // 
            // ilSystemIcons
            // 
            this.ilSystemIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSystemIcons.ImageStream")));
            this.ilSystemIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSystemIcons.Images.SetKeyName(0, "");
            this.ilSystemIcons.Images.SetKeyName(1, "");
            this.ilSystemIcons.Images.SetKeyName(2, "");
            this.ilSystemIcons.Images.SetKeyName(3, "");
            this.ilSystemIcons.Images.SetKeyName(4, "");
            this.ilSystemIcons.Images.SetKeyName(5, "");
            this.ilSystemIcons.Images.SetKeyName(6, "");
            this.ilSystemIcons.Images.SetKeyName(7, "");
            this.ilSystemIcons.Images.SetKeyName(8, "");
            this.ilSystemIcons.Images.SetKeyName(9, "");
            this.ilSystemIcons.Images.SetKeyName(10, "");
            this.ilSystemIcons.Images.SetKeyName(11, "");
            this.ilSystemIcons.Images.SetKeyName(12, "");
            this.ilSystemIcons.Images.SetKeyName(13, "");
            this.ilSystemIcons.Images.SetKeyName(14, "");
            this.ilSystemIcons.Images.SetKeyName(15, "");
            this.ilSystemIcons.Images.SetKeyName(16, "");
            this.ilSystemIcons.Images.SetKeyName(17, "");
            this.ilSystemIcons.Images.SetKeyName(18, "");
            this.ilSystemIcons.Images.SetKeyName(19, "");
            this.ilSystemIcons.Images.SetKeyName(20, "");
            this.ilSystemIcons.Images.SetKeyName(21, "");
            this.ilSystemIcons.Images.SetKeyName(22, "");
            this.ilSystemIcons.Images.SetKeyName(23, "");
            this.ilSystemIcons.Images.SetKeyName(24, "");
            this.ilSystemIcons.Images.SetKeyName(25, "");
            this.ilSystemIcons.Images.SetKeyName(26, "");
            this.ilSystemIcons.Images.SetKeyName(27, "");
            this.ilSystemIcons.Images.SetKeyName(28, "");
            // 
            // ktxtPath
            // 
            this.ktxtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ktxtPath.Hint = "Type a path here... (e.g. C:\\Windows)";
            this.ktxtPath.Location = new System.Drawing.Point(12, 44);
            this.ktxtPath.Name = "ktxtPath";
            this.ktxtPath.Size = new System.Drawing.Size(465, 29);
            this.ktxtPath.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtPath.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtPath.TabIndex = 1;
            this.ktxtPath.TextChanged += new System.EventHandler(this.KtxtPath_TextChanged);
            this.ktxtPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KtxtPath_KeyPress);
            this.ktxtPath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KtxtPath_KeyUp);
            // 
            // kbtnInfo
            // 
            this.kbtnInfo.Location = new System.Drawing.Point(246, 12);
            this.kbtnInfo.Name = "kbtnInfo";
            this.kbtnInfo.Size = new System.Drawing.Size(33, 26);
            this.kbtnInfo.TabIndex = 79;
            this.kbtnInfo.ToolTipValues.Description = "Information";
            this.kbtnInfo.ToolTipValues.Heading = "Information";
            this.kbtnInfo.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnInfo.Values.Image")));
            this.kbtnInfo.Values.Text = "";
            this.kbtnInfo.Click += new System.EventHandler(this.KbtnInfo_Click);
            // 
            // kbtnNext
            // 
            this.kbtnNext.Location = new System.Drawing.Point(90, 12);
            this.kbtnNext.Name = "kbtnNext";
            this.kbtnNext.Size = new System.Drawing.Size(33, 26);
            this.kbtnNext.TabIndex = 80;
            this.kbtnNext.ToolTipValues.Description = "Go forward";
            this.kbtnNext.ToolTipValues.Heading = "Forward";
            this.kbtnNext.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnNext.Values.Image")));
            this.kbtnNext.Values.Text = "";
            this.kbtnNext.Click += new System.EventHandler(this.KbtnNext_Click);
            // 
            // kbtnUp
            // 
            this.kbtnUp.Location = new System.Drawing.Point(129, 12);
            this.kbtnUp.Name = "kbtnUp";
            this.kbtnUp.Size = new System.Drawing.Size(33, 26);
            this.kbtnUp.TabIndex = 81;
            this.kbtnUp.ToolTipValues.Description = "Go up";
            this.kbtnUp.ToolTipValues.Heading = "Parent Directory";
            this.kbtnUp.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnUp.Values.Image")));
            this.kbtnUp.Values.Text = "";
            this.kbtnUp.Click += new System.EventHandler(this.KbtnUp_Click);
            // 
            // kbtnRefresh
            // 
            this.kbtnRefresh.Location = new System.Drawing.Point(168, 12);
            this.kbtnRefresh.Name = "kbtnRefresh";
            this.kbtnRefresh.Size = new System.Drawing.Size(33, 26);
            this.kbtnRefresh.TabIndex = 82;
            this.kbtnRefresh.ToolTipValues.Description = "Refresh explorer tree";
            this.kbtnRefresh.ToolTipValues.Heading = "Refresh";
            this.kbtnRefresh.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnRefresh.Values.Image")));
            this.kbtnRefresh.Values.Text = "";
            this.kbtnRefresh.Click += new System.EventHandler(this.KbtnRefresh_Click);
            // 
            // kbtnHome
            // 
            this.kbtnHome.Location = new System.Drawing.Point(207, 12);
            this.kbtnHome.Name = "kbtnHome";
            this.kbtnHome.Size = new System.Drawing.Size(33, 26);
            this.kbtnHome.TabIndex = 83;
            this.kbtnHome.ToolTipValues.Description = "Home directory";
            this.kbtnHome.ToolTipValues.Heading = "Home";
            this.kbtnHome.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnHome.Values.Image")));
            this.kbtnHome.Values.Text = "";
            this.kbtnHome.Click += new System.EventHandler(this.KbtnHome_Click);
            // 
            // kbtnGo
            // 
            this.kbtnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnGo.Location = new System.Drawing.Point(483, 44);
            this.kbtnGo.Name = "kbtnGo";
            this.kbtnGo.Size = new System.Drawing.Size(33, 29);
            this.kbtnGo.TabIndex = 84;
            this.kbtnGo.ToolTipValues.Description = "Go to the directory";
            this.kbtnGo.ToolTipValues.Heading = "Go";
            this.kbtnGo.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnGo.Values.Image")));
            this.kbtnGo.Values.Text = "";
            this.kbtnGo.Click += new System.EventHandler(this.KbtnGo_Click);
            // 
            // kbtnAdd
            // 
            this.kbtnAdd.Location = new System.Drawing.Point(12, 12);
            this.kbtnAdd.Name = "kbtnAdd";
            this.kbtnAdd.Size = new System.Drawing.Size(33, 26);
            this.kbtnAdd.TabIndex = 85;
            this.kbtnAdd.ToolTipValues.Description = "Add shortcut to frequently used folders";
            this.kbtnAdd.ToolTipValues.Heading = "Add Shortcut";
            this.kbtnAdd.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnAdd.Values.Image")));
            this.kbtnAdd.Values.Text = "";
            this.kbtnAdd.Click += new System.EventHandler(this.KbtnAdd_Click);
            // 
            // kbtnBack
            // 
            this.kbtnBack.Location = new System.Drawing.Point(51, 12);
            this.kbtnBack.Name = "kbtnBack";
            this.kbtnBack.Size = new System.Drawing.Size(33, 26);
            this.kbtnBack.TabIndex = 86;
            this.kbtnBack.ToolTipValues.Description = "Go backwards";
            this.kbtnBack.ToolTipValues.Heading = "Backward";
            this.kbtnBack.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnBack.Values.Image")));
            this.kbtnBack.Values.Text = "";
            this.kbtnBack.Click += new System.EventHandler(this.KbtnBack_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnPath,
            this.clmnStatus});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 357);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(459, 97);
            this.listView1.TabIndex = 89;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // ktvFileSystem
            // 
            this.ktvFileSystem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ktvFileSystem.ImageIndex = 0;
            this.ktvFileSystem.ImageList = this.ilSystemIcons;
            this.ktvFileSystem.Location = new System.Drawing.Point(0, 88);
            this.ktvFileSystem.Name = "ktvFileSystem";
            this.ktvFileSystem.SelectedImageIndex = 0;
            this.ktvFileSystem.Size = new System.Drawing.Size(519, 460);
            this.ktvFileSystem.TabIndex = 90;
            this.ktvFileSystem.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.KtvFileSystem_AfterExpand);
            this.ktvFileSystem.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.KtvFileSystem_AfterSelect);
            this.ktvFileSystem.DoubleClick += new System.EventHandler(this.KtvFileSystem_DoubleClick);
            this.ktvFileSystem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KtvFileSystem_MouseUp);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.kbtnAdd);
            this.pnlTop.Controls.Add(this.ktxtPath);
            this.pnlTop.Controls.Add(this.kbtnGo);
            this.pnlTop.Controls.Add(this.kbtnInfo);
            this.pnlTop.Controls.Add(this.kbtnRefresh);
            this.pnlTop.Controls.Add(this.kbtnBack);
            this.pnlTop.Controls.Add(this.kbtnHome);
            this.pnlTop.Controls.Add(this.kbtnNext);
            this.pnlTop.Controls.Add(this.kbtnUp);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(519, 82);
            this.pnlTop.TabIndex = 91;
            // 
            // KryptonFileSystemUserControl
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.ktvFileSystem);
            this.Name = "KryptonFileSystemUserControl";
            this.Size = new System.Drawing.Size(519, 548);
            this.Load += new System.EventHandler(this.KryptonFileSystemUserControl_Load);
            this.cmsShortcuts.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private bool goflag = false, showMyDocuments = true, showMyFavorites = true, showMyNetwork = true, showAddressbar = true, showToolbar = true;

        private string selectedPath = "home";

        private KryptonTreeNode node, thisComputerNode, rootNode;
        #endregion

        #region Properties
        private bool GoFlag
        {
            get
            {
                return goflag;
            }
            set
            {
                goflag = value;
            }
        }

        public bool ShowAddressbar
        {
            get
            {
                return showAddressbar;
            }
            set
            {
                showAddressbar = value;
            }
        }

        public bool ShowToolbar
        {
            get
            {
                return showToolbar;
            }
            set
            {
                showToolbar = value;
            }
        }

        public bool ShowMyDocuments
        {
            get
            {
                return showMyDocuments;
            }
            set
            {
                showMyDocuments = value;
                this.Refresh();
            }
        }

        public bool ShowMyFavorites
        {
            get
            {
                return showMyFavorites;
            }
            set
            {
                showMyFavorites = value;
                this.Refresh();
            }
        }

        public bool ShowMyNetwork
        {
            get
            {
                return showMyNetwork;
            }
            set
            {
                showMyNetwork = value;
                this.Refresh();
            }
        }

        [
        Category("Appearance"),
        Description("Selected Path of Image")
        ]
        public string SelectedPath
        {
            get
            {
                return this.selectedPath;
            }
            set
            {
                this.selectedPath = value;
                this.Invalidate();
            }
        }
        #endregion

        #region Custom Event
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public delegate void PathChangedEventHandler(object sender, EventArgs e);

        /// <summary>
        /// The path changed event
        /// </summary>
        private PathChangedEventHandler PathChangedEvent;

        /// <summary>
        /// Occurs when [path changed].
        /// </summary>
        public event PathChangedEventHandler PathChanged
        {
            add => PathChangedEvent = (PathChangedEventHandler)Delegate.Combine(PathChangedEvent, value);

            remove => PathChangedEvent = (PathChangedEventHandler)Delegate.Remove(PathChangedEvent, value);
        }
        #endregion

        #region Constructor
        public KryptonFileSystemUserControl()
        {
            InitializeComponent();
        }
        #endregion

        #region Disposal
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }

            base.Dispose(disposing);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Refreshes the view.
        /// </summary>
        public void RefreshView()
        {
            if ((!ShowAddressbar) && (!ShowToolbar))
            {
                SetTopVisibility(false);

                ktvFileSystem.Dock = DockStyle.Fill;
            }
            else
            {
                if (ShowToolbar && (!ShowAddressbar))
                {
                    ResizeTopPanel(new Size(519, 43));

                    SetToolbarVisibility(true);

                    ktxtPath.Visible = false;

                    kbtnGo.Visible = false;

                    ktvFileSystem.Size = new Size(519, 499);
                }
                else if (ShowAddressbar && (!ShowToolbar))
                {
                    ResizeTopPanel(new Size(519, 43));

                    SetToolbarVisibility(false);

                    ktxtPath.Visible = true;

                    ktxtPath.Location = new Point(12, 12);

                    kbtnGo.Visible = true;

                    RelocateButton(kbtnGo, new Point(483, 12));

                    ktvFileSystem.Size = new Size(519, 499);
                }
                else
                {
                    ResetKryptonFileSystemUserControlUI();
                }
            }
        }

        public void GetDirectory()
        {
            ktvFileSystem.Nodes.Clear();

            string[] allDrives = Environment.GetLogicalDrives();

            KryptonTreeNode nodeDesktop, nodeDocuments, nodeFavorites, nodeThisPC, nodeNC, nodeNetwork, nodeEN, nodeNN;

            nodeDesktop = new KryptonTreeNode();

            nodeDesktop.Tag = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            nodeDesktop.Text = "Desktop";

            nodeDesktop.ImageIndex = 10;

            nodeDesktop.SelectedImageIndex = 10;

            ktvFileSystem.Nodes.Add(nodeDesktop);

            rootNode = nodeDesktop;

            if (ShowMyDocuments)
            {
                nodeDocuments = new KryptonTreeNode();

                nodeDocuments.Tag = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

                if (Environment.OSVersion.Version.Major >= 6)
                {
                    nodeDocuments.Text = "Documents";
                }
                else if (Environment.OSVersion.Version.Major < 6)
                {
                    nodeDocuments.Text = "My Documents";
                }

                nodeDocuments.ImageIndex = 9;

                nodeDocuments.SelectedImageIndex = 9;

                nodeDesktop.Nodes.Add(nodeDocuments);

                FillFilesAndDirectories(nodeDocuments);
            }

            nodeThisPC = new KryptonTreeNode();

            if (Environment.OSVersion.Version.Major == 10) // Windows 10
            {
                nodeThisPC.Tag = "This PC";

                nodeThisPC.Text = "This PC";
            }
            else if (Environment.OSVersion.Version.Major == 6) // Windows Vista, 7, 8 & 8.1
            {
                nodeThisPC.Tag = "Computer";

                nodeThisPC.Text = "Computer";
            }
            else if (Environment.OSVersion.Version.Major < 6) // Windows XP and earlier
            {
                nodeThisPC.Tag = "My Computer";

                nodeThisPC.Text = "My Computer";
            }

            nodeThisPC.ImageIndex = 12;

            nodeThisPC.SelectedImageIndex = 12;

            nodeDesktop.Nodes.Add(nodeThisPC);

            nodeThisPC.EnsureVisible();

            thisComputerNode = nodeThisPC;

            nodeNC = new KryptonTreeNode();

            nodeNC.Tag = "my Node";

            nodeNC.Text = "my Node";

            nodeNC.ImageIndex = 12;

            nodeNC.SelectedImageIndex = 12;

            nodeThisPC.Nodes.Add(nodeNC);

            if (ShowMyNetwork)
            {

                nodeNetwork = new KryptonTreeNode();
                nodeNetwork.Tag = "My Network Places";
                nodeNetwork.Text = "My Network Places";
                nodeNetwork.ImageIndex = 13;
                nodeNetwork.SelectedImageIndex = 13;
                nodeDesktop.Nodes.Add(nodeNetwork);
                nodeNetwork.EnsureVisible();

                nodeEN = new KryptonTreeNode();
                nodeEN.Tag = "Entire Network";
                nodeEN.Text = "Entire Network";
                nodeEN.ImageIndex = 14;
                nodeEN.SelectedImageIndex = 14;
                nodeNetwork.Nodes.Add(nodeEN);

                nodeNN = new KryptonTreeNode();
                nodeNN.Tag = "Network Node";
                nodeNN.Text = "Network Node";
                nodeNN.ImageIndex = 15;
                nodeNN.SelectedImageIndex = 15;
                nodeEN.Nodes.Add(nodeNN);

                nodeEN.EnsureVisible();
            }

            if (ShowMyFavorites)
            {
                nodeFavorites = new KryptonTreeNode();
                nodeFavorites.Tag = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
                nodeFavorites.Text = "My Favorites";
                nodeFavorites.ImageIndex = 26;
                nodeFavorites.SelectedImageIndex = 26;
                nodeDesktop.Nodes.Add(nodeFavorites);
                FillFilesAndDirectories(nodeFavorites);
            }

            ExploreTreeNode(nodeDesktop);
        }

        private void ExploreTreeNode(KryptonTreeNode node)
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                //get dirs
                FillFilesAndDirectories(node);

                //get dirs one more level deep in current dir so user can see there is
                //more dirs underneath current dir
                foreach (KryptonTreeNode nodes in node.Nodes)
                {
                    if (String.Compare(node.Text, "Desktop") == 0)
                    {
                        if ((String.Compare(nodes.Text, "My Documents") == 0) || (String.Compare(nodes.Text, "My Computer") == 0) || (String.Compare(nodes.Text, "Microsoft Windows Network") == 0) || (String.Compare(nodes.Text, "My Network Places") == 0))
                        { }
                        else
                        {
                            FillFilesAndDirectories(nodes);
                        }
                    }
                    else
                    {
                        FillFilesAndDirectories(nodes);
                    }
                }
            }

            catch
            { }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void GetDirectories(KryptonTreeNode parentNode)
        {
            // added after suggestion
            string[] dirList;

            dirList = Directory.GetDirectories(parentNode.Tag.ToString());
            Array.Sort(dirList);

            //check if dir already exists in case click same dir twice
            if (dirList.Length == parentNode.Nodes.Count)
                return;
            //add each dir in selected dir
            for (int i = 0; i < dirList.Length; i++)
            {
                node = new KryptonTreeNode();
                node.Tag = dirList[i]; //store path in tag
                node.Text = dirList[i].Substring(dirList[i].LastIndexOf(@"\") + 1);
                node.ImageIndex = 1;
                parentNode.Nodes.Add(node);
            }
        }

        private void FillFilesAndDirectories(KryptonTreeNode node)
        {
            try
            {
                GetDirectories(node);
            }
            catch (Exception)
            {
                return;
            }
        }

        public void SetCurrentPath(string path)
        {
            SelectedPath = path;

            if (String.Compare(path, "home") == 0)
            {
                ktxtPath.Text = Application.StartupPath;
            }
            else
            {
                DirectoryInfo inf = new DirectoryInfo(path);

                if (inf.Exists)
                {
                    ktxtPath.Text = path;

                }
                else
                {
                    ktxtPath.Text = Application.StartupPath;
                }
            }
        }

        public void RefreshFolders()
        {
            listView1.Items.Clear();

            ktvFileSystem.Nodes.Clear();

            SetCurrentPath(Environment.GetFolderPath(Environment.SpecialFolder.Personal));

            GetDirectory();
        }

        private void ExploreThisPC()
        {
            string[] drives = Environment.GetLogicalDrives();
            string dir2 = "";

            Cursor.Current = Cursors.WaitCursor;
            KryptonTreeNode nodeDrive;

            if (thisComputerNode.GetNodeCount(true) < 2)
            {
                thisComputerNode.FirstNode.Remove();

                foreach (string drive in drives)
                {
                    nodeDrive = new KryptonTreeNode();
                    nodeDrive.Tag = drive;

                    nodeDrive.Text = drive;

                    switch (Win32.GetDriveType(drive))
                    {
                        case 2:
                            nodeDrive.ImageIndex = 17;
                            nodeDrive.SelectedImageIndex = 17;
                            break;
                        case 3:
                            nodeDrive.ImageIndex = 0;
                            nodeDrive.SelectedImageIndex = 0;
                            break;
                        case 4:
                            nodeDrive.ImageIndex = 8;
                            nodeDrive.SelectedImageIndex = 8;
                            break;
                        case 5:
                            nodeDrive.ImageIndex = 7;
                            nodeDrive.SelectedImageIndex = 7;
                            break;
                        default:
                            nodeDrive.ImageIndex = 0;
                            nodeDrive.SelectedImageIndex = 0;
                            break;
                    }

                    thisComputerNode.Nodes.Add(nodeDrive);
                    try
                    {
                        //add dirs under drive
                        if (Directory.Exists(drive))
                        {
                            foreach (string dir in Directory.GetDirectories(drive))
                            {
                                dir2 = dir;
                                node = new KryptonTreeNode();
                                node.Tag = dir;
                                node.Text = dir.Substring(dir.LastIndexOf(@"\") + 1);
                                node.ImageIndex = 1;
                                nodeDrive.Nodes.Add(node);
                            }
                        }


                    }
                    catch (Exception ex)    //error just add blank dir
                    {
                        KryptonMessageBoxExtended.Show("Error while Filling the Explorer:" + ex.Message);
                    }
                }
            }

            thisComputerNode.Expand();
        }

        private void UpdateListAddCurrent()
        {
            int i = 0;
            int j = 0;

            int icount = 0;
            icount = listView1.Items.Count + 1;

            for (i = 0; i < listView1.Items.Count - 1; i++)
            {
                if (String.Compare(listView1.Items[i].SubItems[1].Text, "Selected") == 0)
                {
                    for (j = listView1.Items.Count - 1; j > i + 1; j--)
                        listView1.Items[j].Remove();
                    break;
                }

            }
        }
        private void UpdateListGoBack()
        {
            if ((listView1.Items.Count > 0) && (String.Compare(listView1.Items[0].SubItems[1].Text, "Selected") == 0))
                return;
            int i = 0;
            for (i = 0; i < listView1.Items.Count; i++)
            {
                if (String.Compare(listView1.Items[i].SubItems[1].Text, "Selected") == 0)
                {
                    if (i != 0)
                    {
                        listView1.Items[i - 1].SubItems[1].Text = "Selected";
                        ktxtPath.Text = listView1.Items[i - 1].Text;
                    }
                }
                if (i != 0)
                {
                    listView1.Items[i].SubItems[1].Text = " -/- ";
                }
            }
        }
        private void UpdateListGoForward()
        {
            if ((listView1.Items.Count > 0) && (String.Compare(listView1.Items[listView1.Items.Count - 1].SubItems[1].Text, "Selected") == 0))
                return;
            int i = 0;
            for (i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (String.Compare(listView1.Items[i].SubItems[1].Text, "Selected") == 0)
                {
                    if (i != listView1.Items.Count)
                    {
                        listView1.Items[i + 1].SubItems[1].Text = "Selected";
                        ktxtPath.Text = listView1.Items[i + 1].Text;
                    }
                }

                if (i != listView1.Items.Count - 1) listView1.Items[i].SubItems[1].Text = " -/- ";
            }
        }
        private void UpdateList(string f)
        {
            int i = 0;
            ListViewItem listviewitem;      // Used for creating listview items.

            int icount = 0;
            UpdateListAddCurrent();
            icount = listView1.Items.Count + 1;
            try
            {
                if (listView1.Items.Count > 0)
                {
                    if (String.Compare(listView1.Items[listView1.Items.Count - 1].Text, f) == 0)
                    {
                        return;
                    }
                }

                for (i = 0; i < listView1.Items.Count; i++)
                {
                    listView1.Items[i].SubItems[1].Text = " -/- ";
                }
                listviewitem = new ListViewItem(f);
                listviewitem.SubItems.Add("Selected");
                listviewitem.Tag = f;
                this.listView1.Items.Add(listviewitem);
            }
            catch (Exception e)
            {
                KryptonMessageBoxExtended.Show(e.Message);
            }
        }

        private void AddFolderNode(string name, string path)
        {

            try
            {
                KryptonTreeNode nodemyC = new KryptonTreeNode();

                nodemyC.Tag = path;
                nodemyC.Text = name;

                nodemyC.ImageIndex = 18;
                nodemyC.SelectedImageIndex = 18;

                rootNode.Nodes.Add(nodemyC);

                try
                {
                    //add dirs under drive
                    if (Directory.Exists(path))
                    {
                        foreach (string dir in Directory.GetDirectories(path))
                        {
                            KryptonTreeNode node = new KryptonTreeNode();
                            node.Tag = dir;
                            node.Text = dir.Substring(dir.LastIndexOf(@"\") + 1);
                            node.ImageIndex = 1;
                            nodemyC.Nodes.Add(node);
                        }
                    }
                }
                catch (Exception ex)    //error just add blank dir
                {
                    KryptonMessageBoxExtended.Show("Error while Filling the Explorer:" + ex.Message);
                }
            }
            catch (Exception e)
            {
                KryptonMessageBoxExtended.Show(e.Message);
            }
        }

        public void AboutExplorerTree()
        {
            //frmOptions form = new frmOptions(showMyDocuments, showMyFavorites, showMyNetwork, showAddressbar, showToolbar);
            //if (form.ShowDialog() == DialogResult.OK)
            //{
            //    showMyDocuments = form.myDocument;
            //    showMyNetwork = form.myNetwork;
            //    ShowMyFavorites = form.myFavorite;
            //    ShowAddressbar = form.myAddressbar;
            //    ShowToolbar = form.myToolbar;

            //    btnRefresh_Click(this, null);
            //}
        }

        #region UI Elements
        /// <summary>
        /// Resets the tree location.
        /// </summary>
        private void ResetTreeLocation()
        {
            ktvFileSystem.Dock = DockStyle.Bottom;

            ktvFileSystem.Size = new Size(519, 460);
        }

        /// <summary>
        /// Resets the top panel location.
        /// </summary>
        private void ResetTopPanelLocation() => pnlTop.Size = new Size(519, 82);

        /// <summary>
        /// Relocates the toolbar items.
        /// </summary>
        /// <param name="searchBarLocation">The search bar location.</param>
        /// <param name="goButtonLocation">The go button location.</param>
        /// <param name="topPanelSize">Size of the top panel.</param>
        /// <param name="treeViewSize">Size of the tree view.</param>
        private void RelocateToolbarItems(Point searchBarLocation, Point goButtonLocation, Size topPanelSize, Size treeViewSize)
        {
            pnlTop.Size = topPanelSize;

            ktxtPath.Location = searchBarLocation;

            kbtnGo.Location = goButtonLocation;

            ktvFileSystem.Size = treeViewSize;
        }

        /// <summary>
        /// Sets the toolbar visibility.
        /// </summary>
        /// <param name="visibleValue">if set to <c>true</c> [visible value].</param>
        private void SetToolbarVisibility(bool visibleValue)
        {
            kbtnAdd.Visible = visibleValue;

            kbtnBack.Visible = visibleValue;

            kbtnNext.Visible = visibleValue;

            kbtnUp.Visible = visibleValue;

            kbtnRefresh.Visible = visibleValue;

            kbtnHome.Visible = visibleValue;

            kbtnInfo.Visible = visibleValue;
        }

        private void SetTopVisibility(bool visibleValue)
        {
            pnlTop.Visible = visibleValue;
        }

        private void ResizeTopPanel(Size topPanelSize) => pnlTop.Size = topPanelSize;

        private void ResizeTreeView(Size treeViewSize) => ktvFileSystem.Size = treeViewSize;

        /// <summary>
        /// Relocates the button.
        /// </summary>
        /// <param name="targetButton">The target button.</param>
        /// <param name="location">The location.</param>
        private void RelocateButton(KryptonButton targetButton, Point location) => targetButton.Location = location;

        public void ResetKryptonFileSystemUserControlUI()
        {
            #region Toolbar Buttons
            RelocateButton(kbtnAdd, new Point(12, 12));

            RelocateButton(kbtnBack, new Point(51, 12));

            RelocateButton(kbtnNext, new Point(90, 12));

            RelocateButton(kbtnUp, new Point(129, 12));

            RelocateButton(kbtnRefresh, new Point(168, 12));

            RelocateButton(kbtnHome, new Point(207, 12));

            RelocateButton(kbtnInfo, new Point(246, 12));
            #endregion

            #region Top Panel
            ResizeTopPanel(new Size(519, 82));
            #endregion

            #region Search Elements
            ktxtPath.Location = new Point(12, 44);

            RelocateButton(kbtnGo, new Point(483, 44));
            #endregion

            #region Tree View
            ResizeTreeView(new Size(519, 460));
            #endregion
        }
        #endregion

        #endregion

        /// <summary>
        /// Handles the Load event of the KryptonFileSystemUserControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void KryptonFileSystemUserControl_Load(object sender, EventArgs e)
        {
            GetDirectory();

            if (Directory.Exists(SelectedPath))
            {
                SetCurrentPath(SelectedPath);
            }
            else
            {
                SetCurrentPath("home");
            }

            KbtnGo_Click(this, e);

            RefreshView();
        }

        private void KtvFileSystem_AfterExpand(object sender, TreeViewEventArgs e)
        {
            string[] drives = Environment.GetLogicalDrives();

            string dir2 = "";

            Cursor.Current = Cursors.WaitCursor;

            KryptonTreeNode node, nodeNetwork, nodeMN, nodeThisPC, nodeNetworkNode, nodeDrive;

            nodeThisPC = (KryptonTreeNode)e.Node;

            node = (KryptonTreeNode)e.Node;

            if (node.Text.IndexOf(":", 1) > 0)
            {
                ExploreTreeNode(node);
            }
            else
            {//(String.Compare(node.Text ,"My Documents")==0) || (String.Compare(node.Text,"Desktop")==0) || 

                if ((String.Compare(node.Text, "Desktop") == 0) || (String.Compare(node.Text, "Microsoft Windows Network") == 0) || (String.Compare(node.Text, "My Computer") == 0) || (String.Compare(node.Text, "My Network Places") == 0) || (String.Compare(node.Text, "Entire Network") == 0) || ((node.Parent != null) && (String.Compare(node.Parent.Text, "Microsoft Windows Network") == 0)))
                {
                    if ((String.Compare(node.Text, "My Computer") == 0) && (nodeThisPC.GetNodeCount(true) < 2))
                    ///////////
                    //add each drive and files and dirs
                    {
                        nodeThisPC.FirstNode.Remove();

                        foreach (string drive in drives)
                        {

                            nodeDrive = new KryptonTreeNode();
                            nodeDrive.Tag = drive;

                            nodeDrive.Text = drive;

                            //Determine icon to display by drive
                            switch (Win32.GetDriveType(drive))
                            {
                                case 2:
                                    nodeDrive.ImageIndex = 17;
                                    nodeDrive.SelectedImageIndex = 17;
                                    break;
                                case 3:
                                    nodeDrive.ImageIndex = 0;
                                    nodeDrive.SelectedImageIndex = 0;
                                    break;
                                case 4:
                                    nodeDrive.ImageIndex = 8;
                                    nodeDrive.SelectedImageIndex = 8;
                                    break;
                                case 5:
                                    nodeDrive.ImageIndex = 7;
                                    nodeDrive.SelectedImageIndex = 7;
                                    break;
                                default:
                                    nodeDrive.ImageIndex = 0;
                                    nodeDrive.SelectedImageIndex = 0;
                                    break;
                            }

                            nodeThisPC.Nodes.Add(nodeDrive);
                            nodeDrive.EnsureVisible();
                            ktvFileSystem.Refresh();
                            try
                            {
                                //add dirs under drive
                                if (Directory.Exists(drive))
                                {
                                    foreach (string dir in Directory.GetDirectories(drive))
                                    {
                                        dir2 = dir;
                                        node = new KryptonTreeNode();
                                        node.Tag = dir;
                                        node.Text = dir.Substring(dir.LastIndexOf(@"\") + 1);
                                        node.ImageIndex = 1;
                                        nodeDrive.Nodes.Add(node);
                                    }
                                }

                                //fill those dirs
                                //					foreach(TreeNode curNode in 
                                //						tvwMainode.Nodes[tvwMainode.Nodes.Count - 1].Nodes)
                                //					{
                                //						FillFilesandDirs(curNode);
                                //					}
                            }
                            catch (Exception)   //error just add blank dir
                            {
                                // KryptonMessageBoxExtended.Show ("Error while Filling the Explorer:" + ex.Message );
                                //					node = new TreeNode();
                                //					node.Tag = dir2;
                                //					node.Text = dir2.Substring(dir2.LastIndexOf(@"\") + 1);
                                //					node.ImageIndex = 1;
                                //					tvwMainode.Nodes.Add(node);
                            }
                            nodeThisPC.Expand();
                        }

                    }
                    if ((String.Compare(node.Text, "Entire Network") == 0))
                    {
                        if (node.FirstNode.Text == "Network Node")
                        {
                            node.FirstNode.Remove();
                            //NETRESOURCE netRoot = new NETRESOURCE();

                            ServerEnum servers = new ServerEnum(ResourceScope.RESOURCE_GLOBALNET, ResourceType.RESOURCETYPE_DISK, ResourceUsage.RESOURCEUSAGE_ALL, ResourceDisplayType.RESOURCEDISPLAYTYPE_NETWORK, "");

                            foreach (string s1 in servers)
                            {
                                string s2 = "";
                                s2 = s1.Substring(0, s1.IndexOf("|", 1));

                                if (s1.IndexOf("NETWORK", 1) > 0)
                                {
                                    nodeNetwork = new KryptonTreeNode();
                                    nodeNetwork.Tag = s2;
                                    nodeNetwork.Text = s2;//dir.Substring(dir.LastIndexOf(@"\") + 1);
                                    nodeNetwork.ImageIndex = 15;
                                    nodeNetwork.SelectedImageIndex = 15;
                                    node.Nodes.Add(nodeNetwork);
                                }
                                else
                                {
                                    KryptonTreeNode nodemNc;
                                    nodeMN = new KryptonTreeNode();
                                    nodeMN.Tag = s2;//"my Node";
                                    nodeMN.Text = s2;//"my Node";//dir.Substring(dir.LastIndexOf(@"\") + 1);
                                    nodeMN.ImageIndex = 16;
                                    nodeMN.SelectedImageIndex = 16;
                                    node.LastNode.Nodes.Add(nodeMN);

                                    nodemNc = new KryptonTreeNode();
                                    nodemNc.Tag = "my netNode";
                                    nodemNc.Text = "my netNode";//dir.Substring(dir.LastIndexOf(@"\") + 1);
                                    nodemNc.ImageIndex = 12;
                                    nodemNc.SelectedImageIndex = 12;
                                    nodeMN.Nodes.Add(nodemNc);
                                }
                            }
                        }
                    }
                    if ((node.Parent != null) && (String.Compare(node.Parent.Text, "Microsoft Windows Network") == 0))

                    {
                        if (node.FirstNode.Text == "my netNode")
                        {
                            node.FirstNode.Remove();

                            string pS = node.Text;

                            //NETRESOURCE netRoot = new NETRESOURCE();

                            ServerEnum servers = new ServerEnum(ResourceScope.RESOURCE_GLOBALNET,
                                ResourceType.RESOURCETYPE_DISK,
                                ResourceUsage.RESOURCEUSAGE_ALL,
                                ResourceDisplayType.RESOURCEDISPLAYTYPE_SERVER, pS);


                            foreach (string s1 in servers)
                            {
                                string s2 = "";


                                if ((s1.Length < 6) || (String.Compare(s1.Substring(s1.Length - 6, 6), "-share") != 0))
                                {
                                    s2 = s1;//.Substring(s1.IndexOf("\\",2));
                                    nodeNetworkNode = new KryptonTreeNode();
                                    nodeNetworkNode.Tag = s2;
                                    nodeNetworkNode.Text = s2.Substring(2);
                                    nodeNetworkNode.ImageIndex = 12;
                                    nodeNetworkNode.SelectedImageIndex = 12;
                                    node.Nodes.Add(nodeNetworkNode);
                                    foreach (string s1node in servers)
                                    {
                                        if (s1node.Length > 6)
                                        {
                                            if (String.Compare(s1node.Substring(s1node.Length - 6, 6), "-share") == 0)
                                            {
                                                if (s2.Length <= s1node.Length)
                                                {
                                                    try
                                                    {
                                                        if (String.Compare(s1node.Substring(0, s2.Length + 1), s2 + @"\") == 0)
                                                        {
                                                            nodeNetworkNode = new KryptonTreeNode();
                                                            nodeNetworkNode.Tag = s1node.Substring(0, s1node.Length - 6);
                                                            nodeNetworkNode.Text = s1node.Substring(s2.Length + 1, s1node.Length - s2.Length - 7);
                                                            nodeNetworkNode.ImageIndex = 28;
                                                            nodeNetworkNode.SelectedImageIndex = 28;
                                                            nodeNetworkNode.Nodes.Add(nodeNetworkNode);
                                                        }
                                                    }
                                                    catch (Exception)
                                                    { }
                                                }
                                            }
                                        }

                                    }
                                }

                            }
                        }
                    }
                }
                else
                {
                    ExploreTreeNode(node);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void KtvFileSystem_MouseUp(object sender, MouseEventArgs e)
        {
            UpdateList(ktxtPath.Text);

            if (ktvFileSystem.SelectedNode != null)
            {

                if ((ktvFileSystem.SelectedNode.ImageIndex == 18) && (e.Button == MouseButtons.Right))
                {
                    cmsShortcuts.Show(ktvFileSystem, new Point(e.X, e.Y));
                }
            }
        }

        private void KbtnUp_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo MYINFO = new DirectoryInfo(ktxtPath.Text);

                if (MYINFO.Parent.Exists)
                {
                    ktxtPath.Text = MYINFO.Parent.FullName;
                }

                UpdateList(ktxtPath.Text);
                KbtnGo_Click(sender, e);
            }
            catch (Exception)
            {
                //KryptonMessageBoxExtended.Show ("Parent directory does not exists","Directory Not Found",KryptonMessageBoxExtendedButtons.OK,KryptonMessageBoxExtendedIcon.Information ); 
            }
        }

        private void KbtnAdd_Click(object sender, EventArgs e)
        {
            string myname = "";
            string mypath = "";


            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Add Folder in Explorer Tree";
            dialog.ShowNewFolderButton = true;
            dialog.SelectedPath = ktxtPath.Text;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                mypath = dialog.SelectedPath;
                myname = mypath.Substring(mypath.LastIndexOf("\\") + 1);

                AddFolderNode(myname, mypath);

            }
        }

        private void RemoveShortcutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ktvFileSystem.SelectedNode.ImageIndex == 18)
            {
                ktvFileSystem.SelectedNode.Remove();
            }
        }

        private void KtxtPath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(ktxtPath.Text))
                {
                    SelectedPath = ktxtPath.Text;
                    PathChangedEvent(this, EventArgs.Empty);
                }
            }
            catch (Exception)
            { }
        }

        private void KtxtPath_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void KtxtPath_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                KbtnGo_Click(sender, e);

                ktxtPath.Focus();
            }
        }

        private void KbtnInfo_Click(object sender, EventArgs e)
        {
            AboutExplorerTree();
        }

        private void KtvFileSystem_AfterSelect(object sender, TreeViewEventArgs e)
        {
            KryptonTreeNode node;

            node = (KryptonTreeNode)e.Node;

            try
            {
                if ((String.Compare(node.Text, "My Computer") == 0) || (String.Compare(node.Text, "My Network Places") == 0) || (String.Compare(node.Text, "Entire Network") == 0))
                {
                }
                else
                {
                    ktxtPath.Text = node.Tag.ToString();
                }
            }
            catch { }
        }



        private void KtvFileSystem_DoubleClick(object sender, EventArgs e)
        {
            KryptonTreeNode node;

            node = (KryptonTreeNode)ktvFileSystem.SelectedNode;

            if (!ktvFileSystem.SelectedNode.IsExpanded)
            {
                ktvFileSystem.SelectedNode.Collapse();
            }
            else
            {
                ExploreTreeNode(node);
            }
        }

        private void KbtnRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            RefreshView();

            try
            {
                RefreshFolders();
            }
            catch (Exception exc)
            {
                KryptonMessageBoxExtended.Show($"Error: { exc.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetCurrentPath("Home");

                Cursor.Current = Cursors.Default;

                ExploreThisPC();
            }
        }

        private void KbtnGo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                ExploreThisPC();
                string myString = "";
                int h = 1;
                myString = ktxtPath.Text.ToLower();
                //if (String.Compare(myString.Substring(myString.Length-1,1),@"\")==0)
                //{
                //	myString = myString.Substring(0,myString.Length-1);
                //	txtPath.Text = myString	;

                //}
                KryptonTreeNode tn = thisComputerNode;

            StartAgain:

                do
                {
                    //Strom = (tvwMain.GetNodeCount(true)).ToString() ;	

                    foreach (KryptonTreeNode t in tn.Nodes)
                    {
                        string mypath = t.Tag.ToString();
                        //mypath =  mypath.Replace("Desktop\\","") ;
                        //mypath =  mypath.Replace("My Computer\\","") ;
                        //mypath =  mypath.Replace(@"\\",@"\") ;

                        //mypath =  mypath.Replace("My Documents\\",Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\") ;
                        mypath = mypath.ToLower();
                        string mypathf = mypath;
                        if (!mypath.EndsWith(@"\"))
                        {
                            if (myString.Length > mypathf.Length) mypathf = mypath + @"\";
                        }

                        if (myString.StartsWith(mypathf))
                        {
                            t.TreeView.Focus();
                            t.TreeView.SelectedNode = t;
                            t.EnsureVisible();
                            t.Expand();
                            if (t.Nodes.Count >= 1)
                            {
                                t.Expand();
                                tn = t;
                            }
                            else
                            {
                                if (String.Compare(myString, mypath) == 0)
                                {
                                    h = -1;
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }

                            if (mypathf.StartsWith(myString))
                            {
                                h = -1;
                                break;
                            }
                            else
                            {
                                goto StartAgain;
                                //return;
                            }
                        }
                    }

                    try
                    {
                        tn = (KryptonTreeNode)tn.NextNode;
                    }
                    catch (Exception)
                    { }

                } while (h >= 0);

            }
            catch (Exception e1)
            {
                KryptonMessageBoxExtended.Show("Error: " + e1.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void KbtnHome_Click(object sender, EventArgs e)
        {
            SetCurrentPath("home");

            ExploreThisPC();

            KbtnGo_Click(sender, e);
        }

        private void KbtnNext_Click(object sender, EventArgs e)
        {
            GoFlag = true;
            string cpath = ktxtPath.Text;
            UpdateListGoForward();

            if (String.Compare(cpath, ktxtPath.Text) == 0)
            { }
            else
            {
                KbtnGo_Click(sender, e);
            }
            GoFlag = false;
        }

        private void KbtnBack_Click(object sender, EventArgs e)
        {
            GoFlag = true;
            string cpath = ktxtPath.Text;
            UpdateListGoBack();

            if (String.Compare(cpath, ktxtPath.Text) == 0)
            { }
            else
            {
                KbtnGo_Click(sender, e);
            }
            GoFlag = false;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct SHQUERYRBINFO
    {
        public uint cbSize;
        public ulong i64Size;
        public ulong i64NumItems;
    };

    //Shell functions
    public class Win32
    {
        public const uint SHGFI_ICON = 0x100;
        //public const uint SHGFI_LARGEICON = 0x0;    // 'Large icon
        public const uint SHGFI_SMALLICON = 0x1;    // 'Small icon

        [DllImport("shell32.dll")]
        public static extern IntPtr SHGetFileInfo(
            string pszPath,
            uint dwFileAttributes,
            ref SHFILEINFO psfi,
            uint cbSizeFileInfo,
            uint uFlags);

        [DllImport("kernel32")]
        public static extern uint GetDriveType(
            string lpRootPathName);

        [DllImport("shell32.dll")]
        public static extern bool SHGetDiskFreeSpaceEx(
            string pszVolume,
            ref ulong pqwFreeCaller,
            ref ulong pqwTot,
            ref ulong pqwFree);

        [DllImport("shell32.Dll")]
        public static extern int SHQueryRecycleBin(
            string pszRootPath,
            ref SHQUERYRBINFO pSHQueryRBInfo);

        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };



        [StructLayout(LayoutKind.Sequential)]
        public class BITMAPINFO
        {
            public Int32 biSize;
            public Int32 biWidth;
            public Int32 biHeight;
            public Int16 biPlanes;
            public Int16 biBitCount;
            public Int32 biCompression;
            public Int32 biSizeImage;
            public Int32 biXPelsPerMeter;
            public Int32 biYPelsPerMeter;
            public Int32 biClrUsed;
            public Int32 biClrImportant;
            public Int32 colors;
        };
        [DllImport("comctl32.dll")]
        public static extern bool ImageList_Add(IntPtr hImageList, IntPtr hBitmap, IntPtr hMask);
        [DllImport("kernel32.dll")]
        private static extern bool RtlMoveMemory(IntPtr dest, IntPtr source, int dwcount);
        [DllImport("shell32.dll")]
        public static extern IntPtr DestroyIcon(IntPtr hIcon);
        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateDIBSection(IntPtr hdc, [In, MarshalAs(UnmanagedType.LPStruct)]BITMAPINFO pbmi, uint iUsage, out IntPtr ppvBits, IntPtr hSection, uint dwOffset);


    }

    public enum ResourceScope
    {
        RESOURCE_CONNECTED = 1,
        RESOURCE_GLOBALNET,
        RESOURCE_REMEMBERED,
        RESOURCE_RECENT,
        RESOURCE_CONTEXT
    };

    public enum ResourceType
    {
        RESOURCETYPE_ANY,
        RESOURCETYPE_DISK,
        RESOURCETYPE_PRINT,
        RESOURCETYPE_RESERVED
    };

    public enum ResourceUsage
    {
        RESOURCEUSAGE_CONNECTABLE = 0x00000001,
        RESOURCEUSAGE_CONTAINER = 0x00000002,
        RESOURCEUSAGE_NOLOCALDEVICE = 0x00000004,
        RESOURCEUSAGE_SIBLING = 0x00000008,
        RESOURCEUSAGE_ATTACHED = 0x00000010,
        RESOURCEUSAGE_ALL = (RESOURCEUSAGE_CONNECTABLE | RESOURCEUSAGE_CONTAINER | RESOURCEUSAGE_ATTACHED),
    };

    public enum ResourceDisplayType
    {
        RESOURCEDISPLAYTYPE_GENERIC,
        RESOURCEDISPLAYTYPE_DOMAIN,
        RESOURCEDISPLAYTYPE_SERVER,
        RESOURCEDISPLAYTYPE_SHARE,
        RESOURCEDISPLAYTYPE_FILE,
        RESOURCEDISPLAYTYPE_GROUP,
        RESOURCEDISPLAYTYPE_NETWORK,
        RESOURCEDISPLAYTYPE_ROOT,
        RESOURCEDISPLAYTYPE_SHAREADMIN,
        RESOURCEDISPLAYTYPE_DIRECTORY,
        RESOURCEDISPLAYTYPE_TREE,
        RESOURCEDISPLAYTYPE_NDSCONTAINER
    };

    public class ServerEnum : IEnumerable
    {
        enum ErrorCodes
        {
            NO_ERROR = 0,
            ERROR_NO_MORE_ITEMS = 259
        };

        [StructLayout(LayoutKind.Sequential)]
        private class NETRESOURCE
        {
            public ResourceScope dwScope = 0;
            public ResourceType dwType = 0;
            public ResourceDisplayType dwDisplayType = 0;
            public ResourceUsage dwUsage = 0;
            public string lpLocalName = null;
            public string lpRemoteName = null;
            public string lpComment = null;
            public string lpProvider = null;
        };


        private ArrayList aData = new ArrayList();


        public int Count
        {
            get { return aData.Count; }
        }

        [DllImport("Mpr.dll", EntryPoint = "WNetOpenEnumA", CallingConvention = CallingConvention.Winapi)]
        private static extern ErrorCodes WNetOpenEnum(ResourceScope dwScope, ResourceType dwType, ResourceUsage dwUsage, NETRESOURCE p, out IntPtr lphEnum);

        [DllImport("Mpr.dll", EntryPoint = "WNetCloseEnum", CallingConvention = CallingConvention.Winapi)]
        private static extern ErrorCodes WNetCloseEnum(IntPtr hEnum);

        [DllImport("Mpr.dll", EntryPoint = "WNetEnumResourceA", CallingConvention = CallingConvention.Winapi)]
        private static extern ErrorCodes WNetEnumResource(IntPtr hEnum, ref uint lpcCount, IntPtr buffer, ref uint lpBufferSize);


        private void EnumerateServers(NETRESOURCE pRsrc, ResourceScope scope, ResourceType type, ResourceUsage usage, ResourceDisplayType displayType, string kPath)
        {
            uint bufferSize = 16384;
            IntPtr buffer = Marshal.AllocHGlobal((int)bufferSize);
            IntPtr handle = IntPtr.Zero;
            ErrorCodes result;
            uint cEntries = 1;
            bool serverenum = false;

            result = WNetOpenEnum(scope, type, usage, pRsrc, out handle);

            if (result == ErrorCodes.NO_ERROR)
            {
                do
                {
                    result = WNetEnumResource(handle, ref cEntries, buffer, ref bufferSize);

                    if ((result == ErrorCodes.NO_ERROR))
                    {
                        Marshal.PtrToStructure(buffer, pRsrc);

                        if (String.Compare(kPath, "") == 0)
                        {
                            if ((pRsrc.dwDisplayType == displayType) || (pRsrc.dwDisplayType == ResourceDisplayType.RESOURCEDISPLAYTYPE_DOMAIN))
                                aData.Add(pRsrc.lpRemoteName + "|" + pRsrc.dwDisplayType);

                            if ((pRsrc.dwUsage & ResourceUsage.RESOURCEUSAGE_CONTAINER) == ResourceUsage.RESOURCEUSAGE_CONTAINER)
                            {
                                if ((pRsrc.dwDisplayType == displayType))
                                {
                                    EnumerateServers(pRsrc, scope, type, usage, displayType, kPath);

                                }

                            }
                        }
                        else
                        {
                            if (pRsrc.dwDisplayType == displayType)
                            {
                                aData.Add(pRsrc.lpRemoteName);
                                EnumerateServers(pRsrc, scope, type, usage, displayType, kPath);
                                //return;
                                serverenum = true;
                            }
                            if (!serverenum)
                            {
                                if (pRsrc.dwDisplayType == ResourceDisplayType.RESOURCEDISPLAYTYPE_SHARE)
                                {
                                    aData.Add(pRsrc.lpRemoteName + "-share");
                                }
                            }
                            else
                            {
                                serverenum = false;
                            }
                            if ((kPath.IndexOf(pRsrc.lpRemoteName) >= 0) || (String.Compare(pRsrc.lpRemoteName, "Microsoft Windows Network") == 0))
                            {
                                EnumerateServers(pRsrc, scope, type, usage, displayType, kPath);
                                //return;

                            }
                            //}
                        }

                    }
                    else if (result != ErrorCodes.ERROR_NO_MORE_ITEMS)
                        break;
                } while (result != ErrorCodes.ERROR_NO_MORE_ITEMS);

                WNetCloseEnum(handle);
            }

            Marshal.FreeHGlobal((IntPtr)buffer);
        }

        public ServerEnum(ResourceScope scope, ResourceType type, ResourceUsage usage, ResourceDisplayType displayType, string kPath)
        {

            NETRESOURCE netRoot = new NETRESOURCE();
            EnumerateServers(netRoot, scope, type, usage, displayType, kPath);

        }
        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return aData.GetEnumerator();
        }

        #endregion
    }
}