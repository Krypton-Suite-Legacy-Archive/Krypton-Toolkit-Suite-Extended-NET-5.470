using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace IOComponents
{
    public class KryptonFileSystemUserControl : UserControl
    {
        private ContextMenuStrip cmsShortcuts;
        private ToolStripMenuItem removeShortcutToolStripMenuItem;
        private ImageList ilSystemIcons;
        private System.ComponentModel.IContainer components;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ktxtPath;
        private Button btnInfo;
        private Button btnRefresh;
        private Button btnHome;
        private Button btnBack;
        private Button btnNext;
        private Button btnUp;
        private Button btnAdd;
        private KryptonButton kbtnInfo;
        private KryptonButton kbtnNext;
        private KryptonButton kbtnUp;
        private KryptonButton kbtnRefresh;
        private KryptonButton kbtnHome;
        private KryptonButton kbtnGo;
        private KryptonButton kbtnAdd;
        private KryptonButton kbtnBack;
        private Button btnGo;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView ktvFileSystem;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonFileSystemUserControl));
            this.ktvFileSystem = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.cmsShortcuts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeShortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilSystemIcons = new System.Windows.Forms.ImageList(this.components);
            this.ktxtPath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.kbtnInfo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnNext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnUp = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnHome = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnBack = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnGo = new System.Windows.Forms.Button();
            this.cmsShortcuts.SuspendLayout();
            this.SuspendLayout();
            // 
            // ktvFileSystem
            // 
            this.ktvFileSystem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ktvFileSystem.Location = new System.Drawing.Point(0, 71);
            this.ktvFileSystem.Name = "ktvFileSystem";
            this.ktvFileSystem.Size = new System.Drawing.Size(519, 477);
            this.ktvFileSystem.TabIndex = 0;
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
            this.removeShortcutToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.removeShortcutToolStripMenuItem.Text = "&Remove Shortcut";
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
            this.ktxtPath.Location = new System.Drawing.Point(3, 35);
            this.ktxtPath.Name = "ktxtPath";
            this.ktxtPath.Size = new System.Drawing.Size(474, 29);
            this.ktxtPath.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtPath.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtPath.TabIndex = 1;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.SystemColors.Control;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(237, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(33, 26);
            this.btnInfo.TabIndex = 78;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(159, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(33, 26);
            this.btnRefresh.TabIndex = 72;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Control;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(198, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(33, 26);
            this.btnHome.TabIndex = 73;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(42, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(33, 26);
            this.btnBack.TabIndex = 74;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.ForeColor = System.Drawing.Color.Transparent;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(81, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(33, 26);
            this.btnNext.TabIndex = 75;
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.Control;
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.ForeColor = System.Drawing.Color.Transparent;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Location = new System.Drawing.Point(120, 3);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(33, 26);
            this.btnUp.TabIndex = 76;
            this.btnUp.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 26);
            this.btnAdd.TabIndex = 77;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // kbtnInfo
            // 
            this.kbtnInfo.Location = new System.Drawing.Point(237, 3);
            this.kbtnInfo.Name = "kbtnInfo";
            this.kbtnInfo.Size = new System.Drawing.Size(33, 26);
            this.kbtnInfo.TabIndex = 79;
            this.kbtnInfo.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnInfo.Values.Image")));
            this.kbtnInfo.Values.Text = "";
            // 
            // kbtnNext
            // 
            this.kbtnNext.Location = new System.Drawing.Point(81, 3);
            this.kbtnNext.Name = "kbtnNext";
            this.kbtnNext.Size = new System.Drawing.Size(33, 26);
            this.kbtnNext.TabIndex = 80;
            this.kbtnNext.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnNext.Values.Image")));
            this.kbtnNext.Values.Text = "";
            // 
            // kbtnUp
            // 
            this.kbtnUp.Location = new System.Drawing.Point(120, 3);
            this.kbtnUp.Name = "kbtnUp";
            this.kbtnUp.Size = new System.Drawing.Size(33, 26);
            this.kbtnUp.TabIndex = 81;
            this.kbtnUp.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnUp.Values.Image")));
            this.kbtnUp.Values.Text = "";
            // 
            // kbtnRefresh
            // 
            this.kbtnRefresh.Location = new System.Drawing.Point(159, 3);
            this.kbtnRefresh.Name = "kbtnRefresh";
            this.kbtnRefresh.Size = new System.Drawing.Size(33, 26);
            this.kbtnRefresh.TabIndex = 82;
            this.kbtnRefresh.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnRefresh.Values.Image")));
            this.kbtnRefresh.Values.Text = "";
            // 
            // kbtnHome
            // 
            this.kbtnHome.Location = new System.Drawing.Point(198, 3);
            this.kbtnHome.Name = "kbtnHome";
            this.kbtnHome.Size = new System.Drawing.Size(33, 26);
            this.kbtnHome.TabIndex = 83;
            this.kbtnHome.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnHome.Values.Image")));
            this.kbtnHome.Values.Text = "";
            // 
            // kbtnGo
            // 
            this.kbtnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnGo.Location = new System.Drawing.Point(483, 35);
            this.kbtnGo.Name = "kbtnGo";
            this.kbtnGo.Size = new System.Drawing.Size(33, 29);
            this.kbtnGo.TabIndex = 84;
            this.kbtnGo.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnGo.Values.Image")));
            this.kbtnGo.Values.Text = "";
            // 
            // kbtnAdd
            // 
            this.kbtnAdd.Location = new System.Drawing.Point(3, 3);
            this.kbtnAdd.Name = "kbtnAdd";
            this.kbtnAdd.Size = new System.Drawing.Size(33, 26);
            this.kbtnAdd.TabIndex = 85;
            this.kbtnAdd.ToolTipValues.Description = "Add shortcut to frequently used folders";
            this.kbtnAdd.ToolTipValues.Heading = "Add Shortcut";
            this.kbtnAdd.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnAdd.Values.Image")));
            this.kbtnAdd.Values.Text = "";
            // 
            // kbtnBack
            // 
            this.kbtnBack.Location = new System.Drawing.Point(42, 3);
            this.kbtnBack.Name = "kbtnBack";
            this.kbtnBack.Size = new System.Drawing.Size(33, 26);
            this.kbtnBack.TabIndex = 86;
            this.kbtnBack.Values.Image = ((System.Drawing.Image)(resources.GetObject("kbtnBack.Values.Image")));
            this.kbtnBack.Values.Text = "";
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
            this.btnGo.Location = new System.Drawing.Point(483, 35);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(33, 26);
            this.btnGo.TabIndex = 87;
            // 
            // KryptonFileSystemUserControl
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.kbtnBack);
            this.Controls.Add(this.kbtnAdd);
            this.Controls.Add(this.kbtnGo);
            this.Controls.Add(this.kbtnHome);
            this.Controls.Add(this.kbtnRefresh);
            this.Controls.Add(this.kbtnUp);
            this.Controls.Add(this.kbtnNext);
            this.Controls.Add(this.kbtnInfo);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ktxtPath);
            this.Controls.Add(this.ktvFileSystem);
            this.Controls.Add(this.btnGo);
            this.Name = "KryptonFileSystemUserControl";
            this.Size = new System.Drawing.Size(519, 548);
            this.cmsShortcuts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}