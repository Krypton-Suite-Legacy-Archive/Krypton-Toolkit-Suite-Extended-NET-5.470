namespace ExtendedControls.ExtendedToolkit.FileBrowserExtensions.UserControl
{
    partial class Browser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.browseSplitter = new System.Windows.Forms.SplitContainer();
            this.folderView = new FileBrowser.BrowserTreeView();
            this.viewSplitContainer = new System.Windows.Forms.SplitContainer();
            this.fileView = new FileBrowser.BrowserListView();
            this.browseToolStrip = new System.Windows.Forms.ToolStripContainer();
            this.navigationBar = new System.Windows.Forms.ToolStrip();
            this.navBackButton = new System.Windows.Forms.ToolStripSplitButton();
            this.navForwardButton = new System.Windows.Forms.ToolStripSplitButton();
            this.navUpButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.navFoldersButton = new System.Windows.Forms.ToolStripButton();
            this.navAddressLabel = new System.Windows.Forms.ToolStripLabel();
            this.navAddressBox = new FileBrowser.BrowserComboBox();
            this.browseSplitter.Panel1.SuspendLayout();
            this.browseSplitter.Panel2.SuspendLayout();
            this.browseSplitter.SuspendLayout();
            this.viewSplitContainer.Panel2.SuspendLayout();
            this.viewSplitContainer.SuspendLayout();
            this.browseToolStrip.ContentPanel.SuspendLayout();
            this.browseToolStrip.TopToolStripPanel.SuspendLayout();
            this.browseToolStrip.SuspendLayout();
            this.navigationBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseSplitter
            // 
            this.browseSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browseSplitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.browseSplitter.Location = new System.Drawing.Point(0, 0);
            this.browseSplitter.Name = "browseSplitter";
            // 
            // browseSplitter.Panel1
            // 
            this.browseSplitter.Panel1.Controls.Add(this.folderView);
            // 
            // browseSplitter.Panel2
            // 
            this.browseSplitter.Panel2.Controls.Add(this.viewSplitContainer);
            this.browseSplitter.Size = new System.Drawing.Size(536, 408);
            this.browseSplitter.SplitterDistance = 162;
            this.browseSplitter.SplitterWidth = 3;
            this.browseSplitter.TabIndex = 0;
            this.browseSplitter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitter_MouseDown);
            this.browseSplitter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitter_MouseMove);
            this.browseSplitter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitter_MouseUp);
            // 
            // folderView
            // 
            this.folderView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderView.HideSelection = false;
            this.folderView.HotTracking = true;
            this.folderView.Location = new System.Drawing.Point(0, 0);
            this.folderView.Name = "folderView";
            this.folderView.ShowLines = false;
            this.folderView.ShowRootLines = false;
            this.folderView.Size = new System.Drawing.Size(162, 408);
            this.folderView.TabIndex = 0;
            // 
            // viewSplitContainer
            // 
            this.viewSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.viewSplitContainer.IsSplitterFixed = true;
            this.viewSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.viewSplitContainer.Name = "viewSplitContainer";
            this.viewSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // viewSplitContainer.Panel1
            // 
            this.viewSplitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.viewSplitContainer.Panel1Collapsed = true;
            this.viewSplitContainer.Panel1MinSize = 0;
            // 
            // viewSplitContainer.Panel2
            // 
            this.viewSplitContainer.Panel2.Controls.Add(this.fileView);
            this.viewSplitContainer.Panel2MinSize = 0;
            this.viewSplitContainer.Size = new System.Drawing.Size(371, 408);
            this.viewSplitContainer.SplitterDistance = 300;
            this.viewSplitContainer.TabIndex = 1;
            this.viewSplitContainer.Resize += new System.EventHandler(this.viewSplitContainer_Resize);
            // 
            // fileView
            // 
            this.fileView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.fileView.AllowColumnReorder = true;
            this.fileView.ColumnHeaderContextMenu = null;
            this.fileView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileView.HideSelection = false;
            this.fileView.Location = new System.Drawing.Point(0, 0);
            this.fileView.Name = "fileView";
            this.fileView.OwnerDraw = true;
            this.fileView.Size = new System.Drawing.Size(371, 408);
            this.fileView.SuspendHeaderContextMenu = false;
            this.fileView.TabIndex = 0;
            this.fileView.UseCompatibleStateImageBehavior = false;
            this.fileView.View = System.Windows.Forms.View.List;
            // 
            // browseToolStrip
            // 
            // 
            // browseToolStrip.ContentPanel
            // 
            this.browseToolStrip.ContentPanel.Controls.Add(this.browseSplitter);
            this.browseToolStrip.ContentPanel.Size = new System.Drawing.Size(536, 408);
            this.browseToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browseToolStrip.LeftToolStripPanelVisible = false;
            this.browseToolStrip.Location = new System.Drawing.Point(0, 0);
            this.browseToolStrip.Name = "browseToolStrip";
            this.browseToolStrip.RightToolStripPanelVisible = false;
            this.browseToolStrip.Size = new System.Drawing.Size(536, 439);
            this.browseToolStrip.TabIndex = 1;
            this.browseToolStrip.Text = "browseToolStrip";
            // 
            // browseToolStrip.TopToolStripPanel
            // 
            this.browseToolStrip.TopToolStripPanel.Controls.Add(this.navigationBar);
            // 
            // navigationBar
            // 
            this.navigationBar.CanOverflow = false;
            this.navigationBar.Dock = System.Windows.Forms.DockStyle.None;
            this.navigationBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.navigationBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.navigationBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navBackButton,
            this.navForwardButton,
            this.navUpButton,
            this.toolStripSeparator1,
            this.navFoldersButton,
            this.navAddressLabel,
            this.navAddressBox});
            this.navigationBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.navigationBar.Location = new System.Drawing.Point(0, 0);
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Size = new System.Drawing.Size(536, 31);
            this.navigationBar.Stretch = true;
            this.navigationBar.TabIndex = 0;
            this.navigationBar.Resize += new System.EventHandler(this.navigationBar_Resize);
            // 
            // navBackButton
            // 
            this.navBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navBackButton.Enabled = false;
            this.navBackButton.Image = global::FileBrowser.Properties.Resources.BrowserBack;
            this.navBackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navBackButton.Name = "navBackButton";
            this.navBackButton.Size = new System.Drawing.Size(40, 28);
            this.navBackButton.Text = "Back";
            this.navBackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.navBackButton.ButtonClick += new System.EventHandler(this.navBackForwardButton_ButtonClick);
            this.navBackButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.navBackForwardButton_DropDownItemClicked);
            // 
            // navForwardButton
            // 
            this.navForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navForwardButton.Enabled = false;
            this.navForwardButton.Image = global::FileBrowser.Properties.Resources.BrowserForward;
            this.navForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navForwardButton.Name = "navForwardButton";
            this.navForwardButton.Size = new System.Drawing.Size(40, 28);
            this.navForwardButton.Text = "Forward";
            this.navForwardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.navForwardButton.ButtonClick += new System.EventHandler(this.navBackForwardButton_ButtonClick);
            this.navForwardButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.navBackForwardButton_DropDownItemClicked);
            // 
            // navUpButton
            // 
            this.navUpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navUpButton.Image = ((System.Drawing.Image)(resources.GetObject("navUpButton.Image")));
            this.navUpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navUpButton.Name = "navUpButton";
            this.navUpButton.Size = new System.Drawing.Size(28, 28);
            this.navUpButton.Text = "Up";
            this.navUpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.navUpButton.Click += new System.EventHandler(this.navUpButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // navFoldersButton
            // 
            this.navFoldersButton.Checked = true;
            this.navFoldersButton.CheckOnClick = true;
            this.navFoldersButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.navFoldersButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navFoldersButton.Image = ((System.Drawing.Image)(resources.GetObject("navFoldersButton.Image")));
            this.navFoldersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navFoldersButton.Name = "navFoldersButton";
            this.navFoldersButton.Size = new System.Drawing.Size(28, 28);
            this.navFoldersButton.Text = "Folders";
            this.navFoldersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.navFoldersButton.CheckedChanged += new System.EventHandler(this.navFoldersButton_CheckedChanged);
            // 
            // navAddressLabel
            // 
            this.navAddressLabel.MergeIndex = 0;
            this.navAddressLabel.Name = "navAddressLabel";
            this.navAddressLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.navAddressLabel.Size = new System.Drawing.Size(46, 28);
            this.navAddressLabel.Text = "Address";
            // 
            // navAddressBox
            // 
            this.navAddressBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.navAddressBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.navAddressBox.AutoSize = false;
            this.navAddressBox.CurrentItem = null;
            this.navAddressBox.MaxDropDownItems = 14;
            this.navAddressBox.MergeIndex = 0;
            this.navAddressBox.Name = "navAddressBox";
            this.navAddressBox.Size = new System.Drawing.Size(200, 22);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.browseToolStrip);
            this.Name = "Browser";
            this.Size = new System.Drawing.Size(536, 439);
            this.browseSplitter.Panel1.ResumeLayout(false);
            this.browseSplitter.Panel2.ResumeLayout(false);
            this.browseSplitter.ResumeLayout(false);
            this.viewSplitContainer.Panel2.ResumeLayout(false);
            this.viewSplitContainer.ResumeLayout(false);
            this.browseToolStrip.ContentPanel.ResumeLayout(false);
            this.browseToolStrip.TopToolStripPanel.ResumeLayout(false);
            this.browseToolStrip.TopToolStripPanel.PerformLayout();
            this.browseToolStrip.ResumeLayout(false);
            this.browseToolStrip.PerformLayout();
            this.navigationBar.ResumeLayout(false);
            this.navigationBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.SplitContainer browseSplitter;
        private BrowserTreeView folderView;
        private BrowserListView fileView;
        private System.Windows.Forms.ToolStripContainer browseToolStrip;
        private System.Windows.Forms.ToolStrip navigationBar;
        private System.Windows.Forms.ToolStripLabel navAddressLabel;
        private BrowserComboBox navAddressBox;
        private System.Windows.Forms.ToolStripButton navUpButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton navFoldersButton;
        private System.Windows.Forms.ToolStripSplitButton navBackButton;
        private System.Windows.Forms.ToolStripSplitButton navForwardButton;
        private System.Windows.Forms.SplitContainer viewSplitContainer;
    }
}
