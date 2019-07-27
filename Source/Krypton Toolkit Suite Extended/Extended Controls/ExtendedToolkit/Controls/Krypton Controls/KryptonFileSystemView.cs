using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    public class KryptonFileSystemView : UserControl
    {
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView kryptonTreeView1;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox kryptonListBox1;
        private ImageList ilSystemIcons;
        private ContextMenuStrip cmsShortcuts;
        private ToolStripMenuItem removeShortcutToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.ComponentModel.IContainer components;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonFileSystemView));
            this.kryptonTreeView1 = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.kryptonListBox1 = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.ilSystemIcons = new System.Windows.Forms.ImageList(this.components);
            this.cmsShortcuts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeShortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmsShortcuts.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonTreeView1
            // 
            this.kryptonTreeView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonTreeView1.Location = new System.Drawing.Point(0, 82);
            this.kryptonTreeView1.Name = "kryptonTreeView1";
            this.kryptonTreeView1.Size = new System.Drawing.Size(481, 470);
            this.kryptonTreeView1.TabIndex = 0;
            // 
            // kryptonListBox1
            // 
            this.kryptonListBox1.Location = new System.Drawing.Point(67, 326);
            this.kryptonListBox1.Name = "kryptonListBox1";
            this.kryptonListBox1.Size = new System.Drawing.Size(120, 96);
            this.kryptonListBox1.TabIndex = 1;
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
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(3, 49);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(416, 27);
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonTextBox1.TabIndex = 2;
            this.kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.AutoSize = true;
            this.kryptonButton1.Location = new System.Drawing.Point(12, 3);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(32, 32);
            this.kryptonButton1.StateCommon.Content.LongText.Image = global::ExtendedControls.Properties.Resources.Class_16x;
            this.kryptonButton1.StateCommon.Content.ShortText.Image = global::ExtendedControls.Properties.Resources.arrowControl_Image;
            this.kryptonButton1.TabIndex = 3;
            this.kryptonButton1.Values.Image = global::ExtendedControls.Properties.Resources.Class_16x;
            this.kryptonButton1.Values.Text = "";
            // 
            // KryptonFileSystemView
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.kryptonTextBox1);
            this.Controls.Add(this.kryptonListBox1);
            this.Controls.Add(this.kryptonTreeView1);
            this.Name = "KryptonFileSystemView";
            this.Size = new System.Drawing.Size(481, 552);
            this.cmsShortcuts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}