using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class TreeViewExamples : KryptonForm
    {
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonTreeViewExtended kryptonTreeViewExtended1;
        private KryptonPanel kryptonPanel1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonTreeView kryptonTreeView1;

        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node3");
            this.kryptonTreeView1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonTreeView();
            this.kryptonTreeViewExtended1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonTreeViewExtended();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonTreeView1
            // 
            this.kryptonTreeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.kryptonTreeView1.Location = new System.Drawing.Point(12, 12);
            this.kryptonTreeView1.Name = "kryptonTreeView1";
            treeNode1.Name = "Node4";
            treeNode1.Text = "Node4";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Node5";
            treeNode3.Name = "Node6";
            treeNode3.Text = "Node6";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Node0";
            treeNode5.Name = "Node1";
            treeNode5.Text = "Node1";
            treeNode6.Name = "Node2";
            treeNode6.Text = "Node2";
            treeNode7.Name = "Node3";
            treeNode7.Text = "Node3";
            this.kryptonTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            this.kryptonTreeView1.Size = new System.Drawing.Size(275, 440);
            this.kryptonTreeView1.TabIndex = 0;
            // 
            // kryptonTreeViewExtended1
            // 
            this.kryptonTreeViewExtended1.DrawFocus = false;
            this.kryptonTreeViewExtended1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.kryptonTreeViewExtended1.EnableSelectionBorder = true;
            this.kryptonTreeViewExtended1.EnableVistaCheckBoxes = true;
            this.kryptonTreeViewExtended1.EnableVistaSigns = true;
            this.kryptonTreeViewExtended1.EnableVisualSigns = true;
            this.kryptonTreeViewExtended1.FlatDesign = false;
            this.kryptonTreeViewExtended1.FlatDesignColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(157)))), ((int)(((byte)(189)))));
            this.kryptonTreeViewExtended1.FlatDesignColorLostFocus = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.kryptonTreeViewExtended1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonTreeViewExtended1.GradientEndColorLostFocus = System.Drawing.Color.LightGray;
            this.kryptonTreeViewExtended1.GradientEndColorStyled = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(77)))));
            this.kryptonTreeViewExtended1.GradientStartColorLostFocus = System.Drawing.Color.WhiteSmoke;
            this.kryptonTreeViewExtended1.GradientStartColorStyled = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(215)))));
            this.kryptonTreeViewExtended1.Location = new System.Drawing.Point(293, 12);
            this.kryptonTreeViewExtended1.Name = "kryptonTreeViewExtended1";
            this.kryptonTreeViewExtended1.NodeFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            treeNode8.Name = "Node4";
            treeNode8.Text = "Node4";
            treeNode9.Name = "Node5";
            treeNode9.Text = "Node5";
            treeNode10.Name = "Node6";
            treeNode10.Text = "Node6";
            treeNode11.Name = "Node0";
            treeNode11.Text = "Node0";
            treeNode12.Name = "Node1";
            treeNode12.Text = "Node1";
            treeNode13.Name = "Node2";
            treeNode13.Text = "Node2";
            treeNode14.Name = "Node3";
            treeNode14.Text = "Node3";
            this.kryptonTreeViewExtended1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            this.kryptonTreeViewExtended1.NodeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonTreeViewExtended1.PersistentColors = false;
            this.kryptonTreeViewExtended1.Size = new System.Drawing.Size(304, 440);
            this.kryptonTreeViewExtended1.TabIndex = 1;
            this.kryptonTreeViewExtended1.UseKryptonRenderer = true;
            this.kryptonTreeViewExtended1.UseStyledColors = false;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1188, 704);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // TreeViewExamples
            // 
            this.ClientSize = new System.Drawing.Size(1188, 704);
            this.Controls.Add(this.kryptonTreeViewExtended1);
            this.Controls.Add(this.kryptonTreeView1);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "TreeViewExamples";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}