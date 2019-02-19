using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class Test : KryptonForm
    {
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonListView kryptonListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.ComponentModel.IContainer components;
        private KryptonManager kryptonManager1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonListView1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.SuspendLayout();
            // 
            // kryptonListView1
            // 
            this.kryptonListView1.AlternateRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kryptonListView1.AlternateRowColorEnabled = true;
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
            this.kryptonListView1.Location = new System.Drawing.Point(479, 25);
            this.kryptonListView1.Name = "kryptonListView1";
            this.kryptonListView1.OwnerDraw = true;
            this.kryptonListView1.PersistentColors = false;
            this.kryptonListView1.SelectEntireRowOnSubItem = true;
            this.kryptonListView1.Size = new System.Drawing.Size(672, 383);
            this.kryptonListView1.TabIndex = 0;
            this.kryptonListView1.UseCompatibleStateImageBehavior = false;
            this.kryptonListView1.UseKryptonRenderer = true;
            this.kryptonListView1.UseStyledColors = false;
            this.kryptonListView1.View = System.Windows.Forms.View.Details;
            // 
            // Test
            // 
            this.ClientSize = new System.Drawing.Size(1245, 672);
            this.Controls.Add(this.kryptonListView1);
            this.Name = "Test";
            this.ResumeLayout(false);

        }

        public Test()
        {
            InitializeComponent();
        }
    }
}