using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.MessageBoxes.UI;
using GlobalUtilities.Classes;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.UI.SystemBrowser
{
    public class KryptonFileBrowser : KryptonForm
    {
        #region Designer Code
        private KryptonTreeView ktvFileList;
        private Panel panel1;
        private KryptonPanel kryptonPanel2;
        private TreeView tvFileList;
        private KryptonButton kbtnCancel;
        private KryptonTextBox ktxtFilePath;
        private KryptonButton kbtnOk;
        private TextBox txtFilePath;
        private Controls.KryptonPromptTextBox kptxtFilePath;
        private KryptonButton kbtnNewFolder;
        private ImageList ilSystemImages;
        private System.ComponentModel.IContainer components;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.ktxtFilePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tvFileList = new System.Windows.Forms.TreeView();
            this.ktvFileList = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnNewFolder = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ilSystemImages = new System.Windows.Forms.ImageList(this.components);
            this.kptxtFilePath = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txtFilePath);
            this.kryptonPanel1.Controls.Add(this.kptxtFilePath);
            this.kryptonPanel1.Controls.Add(this.ktxtFilePath);
            this.kryptonPanel1.Controls.Add(this.tvFileList);
            this.kryptonPanel1.Controls.Add(this.ktvFileList);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(491, 517);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(12, 13);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(466, 27);
            this.txtFilePath.TabIndex = 3;
            // 
            // ktxtFilePath
            // 
            this.ktxtFilePath.Location = new System.Drawing.Point(12, 13);
            this.ktxtFilePath.Name = "ktxtFilePath";
            this.ktxtFilePath.Size = new System.Drawing.Size(466, 27);
            this.ktxtFilePath.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtFilePath.TabIndex = 4;
            // 
            // tvFileList
            // 
            this.tvFileList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvFileList.Location = new System.Drawing.Point(11, 50);
            this.tvFileList.Name = "tvFileList";
            this.tvFileList.Size = new System.Drawing.Size(467, 450);
            this.tvFileList.TabIndex = 3;
            this.tvFileList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFileList_AfterSelect);
            // 
            // ktvFileList
            // 
            this.ktvFileList.Location = new System.Drawing.Point(12, 50);
            this.ktvFileList.Name = "ktvFileList";
            this.ktvFileList.Size = new System.Drawing.Size(467, 450);
            this.ktvFileList.StateNormal.Node.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktvFileList.StateNormal.Node.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktvFileList.TabIndex = 0;
            this.ktvFileList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ktvFileList_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 517);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 3);
            this.panel1.TabIndex = 1;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnNewFolder);
            this.kryptonPanel2.Controls.Add(this.kbtnOk);
            this.kryptonPanel2.Controls.Add(this.kbtnCancel);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 520);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(491, 47);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // kbtnNewFolder
            // 
            this.kbtnNewFolder.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnNewFolder.Location = new System.Drawing.Point(12, 7);
            this.kbtnNewFolder.Name = "kbtnNewFolder";
            this.kbtnNewFolder.Size = new System.Drawing.Size(118, 28);
            this.kbtnNewFolder.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnNewFolder.TabIndex = 2;
            this.kbtnNewFolder.Values.Text = "New &Folder";
            this.kbtnNewFolder.Click += new System.EventHandler(this.kbtnNewFolder_Click);
            // 
            // kbtnOk
            // 
            this.kbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnOk.Location = new System.Drawing.Point(292, 7);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(90, 28);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 1;
            this.kbtnOk.Values.Text = "&Ok";
            this.kbtnOk.Click += new System.EventHandler(this.kbtnOk_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(388, 7);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(90, 28);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 0;
            this.kbtnCancel.Values.Text = "&Cancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // ilSystemImages
            // 
            this.ilSystemImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilSystemImages.ImageSize = new System.Drawing.Size(16, 16);
            this.ilSystemImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // kptxtFilePath
            // 
            this.kptxtFilePath.DrawPrompt = true;
            this.kptxtFilePath.FocusSelect = true;
            this.kptxtFilePath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kptxtFilePath.Location = new System.Drawing.Point(12, 13);
            this.kptxtFilePath.Name = "kptxtFilePath";
            this.kptxtFilePath.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.kptxtFilePath.PromptText = "Enter directory path...";
            this.kptxtFilePath.PromptTypeface = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kptxtFilePath.Size = new System.Drawing.Size(466, 27);
            this.kptxtFilePath.TabIndex = 2;
            // 
            // KryptonFileBrowser
            // 
            this.ClientSize = new System.Drawing.Size(491, 567);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonFileBrowser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Browser";
            this.TextExtra = "(Beta)";
            this.Load += new System.EventHandler(this.KryptonFileBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private bool _showNewFolderButton, _useKryptonControls;
        private TreeNode _selectedDirectory;
        private KryptonTreeNode _kryptonSelectedDirectory;
        private string _filePath;
        #endregion

        #region Properties
        public bool UseKryptonControls { get => _useKryptonControls; set => _useKryptonControls = value; }

        public bool ShowNewFolderButton { get => _showNewFolderButton; set => _showNewFolderButton = value; }

        public string SelectedFilePath { get => _filePath; set => _filePath = value; }
        #endregion

        public KryptonFileBrowser(bool useKryptonControls = false, bool usePromptBox = false, FormStartPosition startPosition = FormStartPosition.CenterScreen)
        {
            InitializeComponent();

            StartPosition = startPosition;

            UseKryptonControls = useKryptonControls;

            UseKryptonControlsUI(UseKryptonControls);

            UsePromptBox(usePromptBox);

            PopulateFileSystem();
        }

        private void KryptonFileBrowser_Load(object sender, EventArgs e)
        {

        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void kbtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Close();
        }

        private void kbtnNewFolder_Click(object sender, EventArgs e)
        {
            GlobalMethodsStatic.NotImplementedYet();
        }

        #region Methods
        private void PopulateFileSystem()
        {
            if (UseKryptonControls)
            {

            }
            else
            {
                // Clear out all nodes
                tvFileList.Nodes.Clear();

                // Get all logical drives
                string[] logicalDrives = Directory.GetLogicalDrives();

                try
                {
                    foreach (string drive in logicalDrives)
                    {
                        TreeNode drives = tvFileList.Nodes.Add(drive, drive, 3);

                        CreateSubDirectory(drive, drives);
                    }
                }
                catch (Exception se)
                {
                    ExtendedKryptonMessageBox.Show($"Error: { se.Message }", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error, null, true, Font);
                }
            }
        }

        private void CreateSubDirectory(string drive, TreeNode drives)
        {
            foreach (string directory in Directory.GetDirectories(drive))
            {
                try
                {
                    string[] directoryName = directory.Split('\\');

                    TreeNode directoryNode = drives.Nodes.Add(directory, directoryName[directoryName.Count() - 1], 0, 1);

                    CreateSubDirectory(directory, directoryNode);
                }
                catch (Exception e)
                {
                    ExtendedKryptonMessageBox.Show($"Error: { e.Message }", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error, null, true, Font);
                }
            }
        }

        private void UseKryptonControlsUI(bool useKryptonControls)
        {
            if (useKryptonControls)
            {
                txtFilePath.Visible = false;

                tvFileList.Visible = false;

                kptxtFilePath.Visible = false;

                ktxtFilePath.Visible = true;

                ktvFileList.Visible = true;
            }
            else
            {
                txtFilePath.Visible = true;

                tvFileList.Visible = true;

                kptxtFilePath.Visible = false;

                ktxtFilePath.Visible = false;

                ktvFileList.Visible = false;
            }
        }

        private void UsePromptBox(bool usePromptBox)
        {
            kptxtFilePath.Visible = usePromptBox;
        }

        private void ReturnFilePath(TreeNode node)
        {
            try
            {
                SelectedFilePath = Path.GetFullPath(node.Text);
            }
            catch (Exception exc)
            {
                ExtendedKryptonMessageBox.Show($"Error: {exc.Message }", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error, null, true, Font);
            }
        }
        #endregion

        private void tvFileList_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void ktvFileList_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}