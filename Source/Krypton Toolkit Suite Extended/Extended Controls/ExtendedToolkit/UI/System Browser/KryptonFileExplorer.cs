using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;

namespace ExtendedControls.ExtendedToolkit.UI.SystemBrowser
{
    public class KryptonFileExplorer : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kpnlUserActions;
        private System.Windows.Forms.Panel pnlSplitter;
        private KryptonButton kbtnOk;
        private KryptonButton kbtnCancel;
        private Controls.KryptonControls.KryptonTreeView ktvFileSystem;
        private KryptonLabel kryptonLabel2;
        private KryptonLabel kryptonLabel1;
        private System.Windows.Forms.ListView lvFileDetails;
        private Controls.KryptonPromptTextBox kptxtFileName;
        private KryptonBreadCrumb kbcFilePath;
        private KryptonComboBox kryptonComboBox1;
        private Controls.CircularPictureBox cpbxForwardButton;
        private Controls.CircularPictureBox cpbxBackButton;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chDateModified;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chSize;
        private Controls.KryptonControls.KryptonSplitButton ksbtnViewOptions;
        private System.Windows.Forms.ContextMenuStrip ctxViewMode;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem tsmiLargeIcon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSmallIcon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiTile;
        private KryptonPanel kpnlContent;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kpnlContent = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cpbxForwardButton = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cpbxBackButton = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kbcFilePath = new ComponentFactory.Krypton.Toolkit.KryptonBreadCrumb();
            this.kptxtFileName = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.lvFileDetails = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ktvFileSystem = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonTreeView();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kpnlUserActions = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlSplitter = new System.Windows.Forms.Panel();
            this.ksbtnViewOptions = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonSplitButton();
            this.ctxViewMode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlContent)).BeginInit();
            this.kpnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbxForwardButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpbxBackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbcFilePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlUserActions)).BeginInit();
            this.kpnlUserActions.SuspendLayout();
            this.ctxViewMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // kpnlContent
            // 
            this.kpnlContent.Controls.Add(this.cpbxForwardButton);
            this.kpnlContent.Controls.Add(this.cpbxBackButton);
            this.kpnlContent.Controls.Add(this.kryptonComboBox1);
            this.kpnlContent.Controls.Add(this.kbcFilePath);
            this.kpnlContent.Controls.Add(this.kptxtFileName);
            this.kpnlContent.Controls.Add(this.lvFileDetails);
            this.kpnlContent.Controls.Add(this.ktvFileSystem);
            this.kpnlContent.Controls.Add(this.kryptonLabel2);
            this.kpnlContent.Controls.Add(this.kryptonLabel1);
            this.kpnlContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.kpnlContent.Location = new System.Drawing.Point(0, 0);
            this.kpnlContent.Name = "kpnlContent";
            this.kpnlContent.Size = new System.Drawing.Size(1076, 578);
            this.kpnlContent.TabIndex = 0;
            // 
            // cpbxForwardButton
            // 
            this.cpbxForwardButton.BackColor = System.Drawing.Color.Black;
            this.cpbxForwardButton.Location = new System.Drawing.Point(50, 11);
            this.cpbxForwardButton.Name = "cpbxForwardButton";
            this.cpbxForwardButton.Size = new System.Drawing.Size(32, 32);
            this.cpbxForwardButton.TabIndex = 7;
            this.cpbxForwardButton.TabStop = false;
            // 
            // cpbxBackButton
            // 
            this.cpbxBackButton.BackColor = System.Drawing.Color.Black;
            this.cpbxBackButton.Location = new System.Drawing.Point(12, 11);
            this.cpbxBackButton.Name = "cpbxBackButton";
            this.cpbxBackButton.Size = new System.Drawing.Size(32, 32);
            this.cpbxBackButton.TabIndex = 3;
            this.cpbxBackButton.TabStop = false;
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox1.DropDownWidth = 963;
            this.kryptonComboBox1.Location = new System.Drawing.Point(101, 536);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(963, 21);
            this.kryptonComboBox1.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox1.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox1.TabIndex = 6;
            // 
            // kbcFilePath
            // 
            this.kbcFilePath.AutoSize = false;
            this.kbcFilePath.Location = new System.Drawing.Point(88, 11);
            this.kbcFilePath.Name = "kbcFilePath";
            // 
            // 
            // 
            this.kbcFilePath.RootItem.ShortText = "Root";
            this.kbcFilePath.SelectedItem = this.kbcFilePath.RootItem;
            this.kbcFilePath.Size = new System.Drawing.Size(976, 32);
            this.kbcFilePath.TabIndex = 5;
            // 
            // kptxtFileName
            // 
            this.kptxtFileName.DrawPrompt = true;
            this.kptxtFileName.FocusSelect = true;
            this.kptxtFileName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kptxtFileName.Location = new System.Drawing.Point(101, 504);
            this.kptxtFileName.Name = "kptxtFileName";
            this.kptxtFileName.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.kptxtFileName.PromptText = "Type file name here...";
            this.kptxtFileName.PromptTypeface = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kptxtFileName.Size = new System.Drawing.Size(963, 27);
            this.kptxtFileName.TabIndex = 4;
            // 
            // lvFileDetails
            // 
            this.lvFileDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chDateModified,
            this.chType,
            this.chSize});
            this.lvFileDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvFileDetails.HideSelection = false;
            this.lvFileDetails.Location = new System.Drawing.Point(321, 49);
            this.lvFileDetails.Name = "lvFileDetails";
            this.lvFileDetails.Size = new System.Drawing.Size(743, 430);
            this.lvFileDetails.TabIndex = 3;
            this.lvFileDetails.UseCompatibleStateImageBehavior = false;
            this.lvFileDetails.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 210;
            // 
            // chDateModified
            // 
            this.chDateModified.Text = "Date Modified";
            this.chDateModified.Width = 237;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            this.chType.Width = 126;
            // 
            // chSize
            // 
            this.chSize.Text = "Size";
            this.chSize.Width = 96;
            // 
            // ktvFileSystem
            // 
            this.ktvFileSystem.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.ktvFileSystem.Location = new System.Drawing.Point(12, 49);
            this.ktvFileSystem.Name = "ktvFileSystem";
            this.ktvFileSystem.Size = new System.Drawing.Size(303, 430);
            this.ktvFileSystem.TabIndex = 2;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 536);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(75, 24);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "File Type:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 504);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(83, 24);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "File Name:";
            // 
            // kpnlUserActions
            // 
            this.kpnlUserActions.Controls.Add(this.ksbtnViewOptions);
            this.kpnlUserActions.Controls.Add(this.kbtnOk);
            this.kpnlUserActions.Controls.Add(this.kbtnCancel);
            this.kpnlUserActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlUserActions.Location = new System.Drawing.Point(0, 578);
            this.kpnlUserActions.Name = "kpnlUserActions";
            this.kpnlUserActions.Size = new System.Drawing.Size(1076, 57);
            this.kpnlUserActions.TabIndex = 1;
            // 
            // kbtnOk
            // 
            this.kbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnOk.Location = new System.Drawing.Point(878, 14);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(90, 31);
            this.kbtnOk.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 1;
            this.kbtnOk.Values.Text = "O&k";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(974, 14);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(90, 31);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 0;
            this.kbtnCancel.Values.Text = "C&ancel";
            // 
            // pnlSplitter
            // 
            this.pnlSplitter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSplitter.Location = new System.Drawing.Point(0, 578);
            this.pnlSplitter.Name = "pnlSplitter";
            this.pnlSplitter.Size = new System.Drawing.Size(1076, 3);
            this.pnlSplitter.TabIndex = 2;
            // 
            // ksbtnViewOptions
            // 
            this.ksbtnViewOptions.AutoSize = true;
            this.ksbtnViewOptions.Location = new System.Drawing.Point(12, 17);
            this.ksbtnViewOptions.Name = "ksbtnViewOptions";
            this.ksbtnViewOptions.Size = new System.Drawing.Size(130, 28);
            this.ksbtnViewOptions.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ksbtnViewOptions.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ksbtnViewOptions.TabIndex = 2;
            this.ksbtnViewOptions.Values.Text = "&View Options";
            // 
            // ctxViewMode
            // 
            this.ctxViewMode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLargeIcon,
            this.toolStripSeparator1,
            this.tsmiDetails,
            this.toolStripSeparator2,
            this.tsmiSmallIcon,
            this.toolStripSeparator3,
            this.tsmiList,
            this.toolStripSeparator4,
            this.tsmiTile});
            this.ctxViewMode.Name = "ctxViewMode";
            this.ctxViewMode.Size = new System.Drawing.Size(181, 160);
            // 
            // tsmiLargeIcon
            // 
            this.tsmiLargeIcon.CheckOnClick = true;
            this.tsmiLargeIcon.Name = "tsmiLargeIcon";
            this.tsmiLargeIcon.Size = new System.Drawing.Size(180, 22);
            this.tsmiLargeIcon.Text = "&Large Icon";
            this.tsmiLargeIcon.Click += TsmiLargeIcon_Click;
            // 
            // tsmiDetails
            // 
            this.tsmiDetails.CheckOnClick = true;
            this.tsmiDetails.Name = "tsmiDetails";
            this.tsmiDetails.Size = new System.Drawing.Size(180, 22);
            this.tsmiDetails.Text = "D&etails";
            this.tsmiDetails.Click += TsmiDetails_Click;
            // 
            // tsmiSmallIcon
            // 
            this.tsmiSmallIcon.CheckOnClick = true;
            this.tsmiSmallIcon.Name = "tsmiSmallIcon";
            this.tsmiSmallIcon.Size = new System.Drawing.Size(180, 22);
            this.tsmiSmallIcon.Text = "&Small Icon";
            this.tsmiSmallIcon.Click += TsmiSmallIcon_Click;
            // 
            // tsmiList
            // 
            this.tsmiList.CheckOnClick = true;
            this.tsmiList.Name = "tsmiList";
            this.tsmiList.Size = new System.Drawing.Size(180, 22);
            this.tsmiList.Text = "Lis&t";
            this.tsmiList.Click += TsmiList_Click;
            // 
            // tsmiTile
            // 
            this.tsmiTile.CheckOnClick = true;
            this.tsmiTile.Name = "tsmiTile";
            this.tsmiTile.Size = new System.Drawing.Size(180, 22);
            this.tsmiTile.Text = "&Tile";
            this.tsmiTile.Click += TsmiTile_Click;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // KryptonFileExplorer
            // 
            this.ClientSize = new System.Drawing.Size(1076, 635);
            this.Controls.Add(this.pnlSplitter);
            this.Controls.Add(this.kpnlUserActions);
            this.Controls.Add(this.kpnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonFileExplorer";
            this.ShowInTaskbar = false;
            this.Text = "{0}";
            this.TextExtra = "(Beta)";
            this.Load += new System.EventHandler(this.KryptonFileExplorer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlContent)).EndInit();
            this.kpnlContent.ResumeLayout(false);
            this.kpnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbxForwardButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpbxBackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbcFilePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlUserActions)).EndInit();
            this.kpnlUserActions.ResumeLayout(false);
            this.kpnlUserActions.PerformLayout();
            this.ctxViewMode.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Constructor
        public KryptonFileExplorer()
        {
            InitializeComponent();

            Location = new Point(0, 0);
        }
        #endregion

        private void KryptonFileExplorer_Load(object sender, EventArgs e)
        {

        }

        private void TsmiTile_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TsmiList_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TsmiSmallIcon_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TsmiDetails_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TsmiLargeIcon_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}