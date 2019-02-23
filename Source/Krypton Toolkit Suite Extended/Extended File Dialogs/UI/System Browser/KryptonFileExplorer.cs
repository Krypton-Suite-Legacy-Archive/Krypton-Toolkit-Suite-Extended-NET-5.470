using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.Controls.FileExplorer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedFileDialogs.UI.SystemBrowser
{
    public class KryptonFileExplorer : KryptonForm
    {
        private KryptonPanel kryptonPanel1;
        private ListView lvExplorer;
        private ColumnHeader colName;
        private ColumnHeader colDateModified;
        private ColumnHeader colType;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox circularPictureBox3;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox circularPictureBox2;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox circularPictureBox1;
        private KryptonTreeView ktvFileExplorer;
        private KryptonLabel kryptonLabel1;
        private KryptonBreadCrumb kbcFilePath;
        private ColumnHeader colSize;
        private ExtendedControls.ExtendedToolkit.Controls.FileExplorer.FileBrowser fbExplorer;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonSplitButton kryptonSplitButton1;
        private KryptonButton kbtnCancel;
        private KryptonPanel kryptonPanel2;
        private KryptonButton kbtnAccept;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox kryptonPromptTextBox1;
        private Panel panel1;

        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Node3");
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.fbExplorer = new ExtendedControls.ExtendedToolkit.Controls.FileExplorer.FileBrowser();
            this.lvExplorer = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.circularPictureBox3 = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.circularPictureBox2 = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.circularPictureBox1 = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ktvFileExplorer = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbcFilePath = new ComponentFactory.Krypton.Toolkit.KryptonBreadCrumb();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonSplitButton1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonSplitButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnAccept = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPromptTextBox1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbcFilePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPromptTextBox1);
            this.kryptonPanel1.Controls.Add(this.fbExplorer);
            this.kryptonPanel1.Controls.Add(this.lvExplorer);
            this.kryptonPanel1.Controls.Add(this.circularPictureBox3);
            this.kryptonPanel1.Controls.Add(this.circularPictureBox2);
            this.kryptonPanel1.Controls.Add(this.circularPictureBox1);
            this.kryptonPanel1.Controls.Add(this.ktvFileExplorer);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.kbcFilePath);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1039, 577);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // fbExplorer
            // 
            this.fbExplorer.DefaultPath = "C:\\";
            this.fbExplorer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbExplorer.HideSelection = false;
            this.fbExplorer.IsSoloFileBrowser = true;
            this.fbExplorer.Location = new System.Drawing.Point(332, 50);
            this.fbExplorer.Name = "fbExplorer";
            this.fbExplorer.SelectedPath = "";
            this.fbExplorer.Size = new System.Drawing.Size(695, 442);
            this.fbExplorer.TabIndex = 2;
            this.fbExplorer.UseCompatibleStateImageBehavior = false;
            // 
            // lvExplorer
            // 
            this.lvExplorer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colDateModified,
            this.colType,
            this.colSize});
            this.lvExplorer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvExplorer.HideSelection = false;
            this.lvExplorer.Location = new System.Drawing.Point(332, 50);
            this.lvExplorer.Name = "lvExplorer";
            this.lvExplorer.Size = new System.Drawing.Size(695, 442);
            this.lvExplorer.TabIndex = 7;
            this.lvExplorer.UseCompatibleStateImageBehavior = false;
            this.lvExplorer.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 265;
            // 
            // colDateModified
            // 
            this.colDateModified.Text = "Date Modified";
            this.colDateModified.Width = 207;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 145;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            this.colSize.Width = 110;
            // 
            // circularPictureBox3
            // 
            this.circularPictureBox3.BackColor = System.Drawing.Color.Black;
            this.circularPictureBox3.Location = new System.Drawing.Point(88, 12);
            this.circularPictureBox3.Name = "circularPictureBox3";
            this.circularPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.circularPictureBox3.TabIndex = 6;
            this.circularPictureBox3.TabStop = false;
            // 
            // circularPictureBox2
            // 
            this.circularPictureBox2.BackColor = System.Drawing.Color.Black;
            this.circularPictureBox2.Location = new System.Drawing.Point(50, 12);
            this.circularPictureBox2.Name = "circularPictureBox2";
            this.circularPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.circularPictureBox2.TabIndex = 5;
            this.circularPictureBox2.TabStop = false;
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.Black;
            this.circularPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.circularPictureBox1.TabIndex = 4;
            this.circularPictureBox1.TabStop = false;
            // 
            // ktvFileExplorer
            // 
            this.ktvFileExplorer.Location = new System.Drawing.Point(12, 50);
            this.ktvFileExplorer.Name = "ktvFileExplorer";
            treeNode10.Name = "Node0";
            treeNode10.Text = "Node0";
            treeNode11.Name = "Node4";
            treeNode11.Text = "Node4";
            treeNode12.Name = "Node5";
            treeNode12.Text = "Node5";
            treeNode13.Name = "Node6";
            treeNode13.Text = "Node6";
            treeNode14.Name = "Node1";
            treeNode14.Text = "Node1";
            treeNode15.Name = "Node7";
            treeNode15.Text = "Node7";
            treeNode16.Name = "Node8";
            treeNode16.Text = "Node8";
            treeNode17.Name = "Node2";
            treeNode17.Text = "Node2";
            treeNode18.Name = "Node3";
            treeNode18.Text = "Node3";
            this.ktvFileExplorer.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode14,
            treeNode17,
            treeNode18});
            this.ktvFileExplorer.Size = new System.Drawing.Size(314, 442);
            this.ktvFileExplorer.StateCommon.Node.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktvFileExplorer.StateCommon.Node.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktvFileExplorer.TabIndex = 3;
            this.ktvFileExplorer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ktvFileExplorer_AfterSelect);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 498);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(88, 24);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "File Name:";
            // 
            // kbcFilePath
            // 
            this.kbcFilePath.AutoSize = false;
            this.kbcFilePath.Location = new System.Drawing.Point(126, 12);
            this.kbcFilePath.Name = "kbcFilePath";
            // 
            // 
            // 
            this.kbcFilePath.RootItem.ShortText = "Root";
            this.kbcFilePath.SelectedItem = this.kbcFilePath.RootItem;
            this.kbcFilePath.Size = new System.Drawing.Size(901, 32);
            this.kbcFilePath.StateCommon.BreadCrumb.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbcFilePath.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 577);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 3);
            this.panel1.TabIndex = 1;
            // 
            // kryptonSplitButton1
            // 
            this.kryptonSplitButton1.AutoSize = true;
            this.kryptonSplitButton1.Location = new System.Drawing.Point(12, 12);
            this.kryptonSplitButton1.Name = "kryptonSplitButton1";
            this.kryptonSplitButton1.Size = new System.Drawing.Size(120, 36);
            this.kryptonSplitButton1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonSplitButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonSplitButton1.TabIndex = 0;
            this.kryptonSplitButton1.Values.Text = "V&iew Type";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(937, 12);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(90, 36);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 1;
            this.kbtnCancel.Values.Text = "&Cancel";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnAccept);
            this.kryptonPanel2.Controls.Add(this.kbtnCancel);
            this.kryptonPanel2.Controls.Add(this.kryptonSplitButton1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 580);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1039, 60);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // kbtnAccept
            // 
            this.kbtnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnAccept.Location = new System.Drawing.Point(817, 12);
            this.kbtnAccept.Name = "kbtnAccept";
            this.kbtnAccept.Size = new System.Drawing.Size(114, 36);
            this.kbtnAccept.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnAccept.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnAccept.TabIndex = 2;
            this.kbtnAccept.Values.Text = "O&k";
            // 
            // kryptonPromptTextBox1
            // 
            this.kryptonPromptTextBox1.DrawPrompt = true;
            this.kryptonPromptTextBox1.FocusSelect = true;
            this.kryptonPromptTextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPromptTextBox1.Location = new System.Drawing.Point(106, 498);
            this.kryptonPromptTextBox1.MaxLength = 256;
            this.kryptonPromptTextBox1.Name = "kryptonPromptTextBox1";
            this.kryptonPromptTextBox1.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.kryptonPromptTextBox1.PromptText = "Enter filename...";
            this.kryptonPromptTextBox1.PromptTypeface = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPromptTextBox1.Size = new System.Drawing.Size(921, 27);
            this.kryptonPromptTextBox1.TabIndex = 8;
            // 
            // KryptonFileExplorer
            // 
            this.ClientSize = new System.Drawing.Size(1039, 640);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "KryptonFileExplorer";
            this.Load += new System.EventHandler(this.KryptonFileExplorer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbcFilePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #region Constructors
        public KryptonFileExplorer(string defaultPath = "C:\\")
        {
            InitializeComponent();

            InitialiseFileBrowser(defaultPath);
        }
        #endregion

        private void ktvFileExplorer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Stack<int> indexes = new Stack<int>();

            // Stack the nodes
            //KryptonTreeNode node = (KryptonTreeNode)e.Node;
            TreeNode node = e.Node;

            while (node.Parent != null)
            {
                indexes.Push(node.Index);

                node = node.Parent;
            }

            KryptonBreadCrumbItem kbci = kbcFilePath.RootItem;

            while (indexes.Count > 0)
            {
                kbci = kbci.Items[indexes.Pop()];
            }

            kbcFilePath.SelectedItem = kbci;
        }

        //private void SwitchViewLayout(View view)
        //{
        //    fbExplorer.View = view;

        //    lvFileDetails.View = view;

        //    switch (view)
        //    {
        //        case View.LargeIcon:
        //            tsmiDetails.Checked = false;

        //            tsmiLargeIcon.Checked = true;

        //            tsmiList.Checked = false;

        //            tsmiSmallIcon.Checked = false;

        //            tsmiTile.Checked = false;
        //            break;
        //        case View.Details:
        //            tsmiDetails.Checked = true;

        //            tsmiLargeIcon.Checked = false;

        //            tsmiList.Checked = false;

        //            tsmiSmallIcon.Checked = false;

        //            tsmiTile.Checked = false;
        //            break;
        //        case View.SmallIcon:
        //            tsmiDetails.Checked = false;

        //            tsmiLargeIcon.Checked = false;

        //            tsmiList.Checked = false;

        //            tsmiSmallIcon.Checked = true;

        //            tsmiTile.Checked = false;
        //            break;
        //        case View.List:
        //            tsmiDetails.Checked = false;

        //            tsmiLargeIcon.Checked = false;

        //            tsmiList.Checked = true;

        //            tsmiSmallIcon.Checked = false;

        //            tsmiTile.Checked = false;
        //            break;
        //        case View.Tile:
        //            tsmiDetails.Checked = false;

        //            tsmiLargeIcon.Checked = false;

        //            tsmiList.Checked = false;

        //            tsmiSmallIcon.Checked = false;

        //            tsmiTile.Checked = true;
        //            break;
        //    }
        //}

        private void InitialiseWindow()
        {
            Location = new Point(0, 0);

            MaximizeBox = false;

            MinimizeBox = false;

            FormBorderStyle = FormBorderStyle.Fixed3D;

            AcceptButton = kbtnAccept;

            CancelButton = kbtnCancel;

            PopagateFileSystem();
        }


        private void InitialiseFileBrowser(string path)
        {
            fbExplorer.DefaultPath = path;

            fbExplorer.Load();

            InitialiseFileBrowserComponentEvents(fbExplorer);
        }

        private void InitialiseFileBrowserComponentEvents(FileBrowser browser)
        {
            browser.SelectedIndexChanged += Browser_SelectedIndexChanged;
        }

        private void Browser_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PopagateFileSystem()
        {

        }

        private void KryptonFileExplorer_Load(object sender, EventArgs e)
        {
            InitialiseWindow();
        }
    }
}