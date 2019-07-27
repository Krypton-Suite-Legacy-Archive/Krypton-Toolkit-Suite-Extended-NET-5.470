#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

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
        private KryptonLabel kryptonLabel1;
        private KryptonBreadCrumb kbcFilePath;
        private ColumnHeader colSize;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonSplitButton kryptonSplitButton1;
        private KryptonButton kbtnCancel;
        private KryptonPanel kryptonPanel2;
        private KryptonButton kbtnAccept;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonFileSystemTreeView kryptonFileSystemTreeView1;
        private System.ComponentModel.IContainer components;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonListView kryptonListView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private KryptonTextBox kryptonTextBox1;
        private Panel panel1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonFileExplorer));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lvExplorer = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbcFilePath = new ComponentFactory.Krypton.Toolkit.KryptonBreadCrumb();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnAccept = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonSplitButton1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonSplitButton();
            this.kryptonListView1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kryptonFileSystemTreeView1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonFileSystemTreeView();
            this.circularPictureBox3 = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.circularPictureBox2 = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.circularPictureBox1 = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kbcFilePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonTextBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonListView1);
            this.kryptonPanel1.Controls.Add(this.kryptonFileSystemTreeView1);
            this.kryptonPanel1.Controls.Add(this.lvExplorer);
            this.kryptonPanel1.Controls.Add(this.circularPictureBox3);
            this.kryptonPanel1.Controls.Add(this.circularPictureBox2);
            this.kryptonPanel1.Controls.Add(this.circularPictureBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.kbcFilePath);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1039, 577);
            this.kryptonPanel1.TabIndex = 0;
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
            // kryptonListView1
            // 
            this.kryptonListView1.AlternateRowColour = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kryptonListView1.AlternateRowColourEnabled = true;
            this.kryptonListView1.AutoSizeLastColumn = true;
            this.kryptonListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.kryptonListView1.EnableDragDrop = false;
            this.kryptonListView1.EnableHeaderGlow = false;
            this.kryptonListView1.EnableHeaderHotTrack = false;
            this.kryptonListView1.EnableHeaderRendering = true;
            this.kryptonListView1.EnableSelectionBorder = false;
            this.kryptonListView1.EnableSorting = true;
            this.kryptonListView1.EnableVistaCheckBoxes = true;
            this.kryptonListView1.ForceLeftAlign = false;
            this.kryptonListView1.FullRowSelect = true;
            this.kryptonListView1.HideSelection = false;
            this.kryptonListView1.ItemHeight = 0;
            this.kryptonListView1.LineAfter = -1;
            this.kryptonListView1.LineBefore = -1;
            this.kryptonListView1.Location = new System.Drawing.Point(332, 50);
            this.kryptonListView1.Name = "kryptonListView1";
            this.kryptonListView1.OwnerDraw = true;
            this.kryptonListView1.PersistentColours = false;
            this.kryptonListView1.SelectEntireRowOnSubItem = true;
            this.kryptonListView1.Size = new System.Drawing.Size(695, 442);
            this.kryptonListView1.TabIndex = 2;
            this.kryptonListView1.UseCompatibleStateImageBehavior = false;
            this.kryptonListView1.UseKryptonRenderer = true;
            this.kryptonListView1.UseStyledColours = true;
            this.kryptonListView1.View = System.Windows.Forms.View.Details;
            // 
            // kryptonFileSystemTreeView1
            // 
            this.kryptonFileSystemTreeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.kryptonFileSystemTreeView1.FolderIcon = ((System.Drawing.Icon)(resources.GetObject("kryptonFileSystemTreeView1.FolderIcon")));
            this.kryptonFileSystemTreeView1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonFileSystemTreeView1.ImageIndex = 0;
            this.kryptonFileSystemTreeView1.Location = new System.Drawing.Point(12, 50);
            this.kryptonFileSystemTreeView1.Name = "kryptonFileSystemTreeView1";
            this.kryptonFileSystemTreeView1.SelectedImageIndex = 0;
            this.kryptonFileSystemTreeView1.ShowFiles = true;
            this.kryptonFileSystemTreeView1.Size = new System.Drawing.Size(314, 442);
            this.kryptonFileSystemTreeView1.TabIndex = 2;
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
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Hint = "Enter fileneame...";
            this.kryptonTextBox1.Location = new System.Drawing.Point(106, 498);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(921, 29);
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonTextBox1.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)(this.kbcFilePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
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
        //    fbExplorer.DefaultPath = path;

        //    fbExplorer.Load();

        //    InitialiseFileBrowserComponentEvents(fbExplorer);
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