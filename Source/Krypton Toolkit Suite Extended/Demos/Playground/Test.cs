#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System;

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
        private KryptonPanel kryptonPanel1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPaletteChooserComboBox kryptonPaletteChooserComboBox1;
        private KryptonManager kryptonManager1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("a");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("b");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("c");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("d");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("e");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("f");
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPaletteChooserComboBox1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPaletteChooserComboBox();
            this.kryptonListView1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPaletteChooserComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office365Black;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPaletteChooserComboBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonListView1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1245, 672);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kryptonPaletteChooserComboBox1
            // 
            this.kryptonPaletteChooserComboBox1.DropDownWidth = 121;
            this.kryptonPaletteChooserComboBox1.Items.AddRange(new object[] {
            "Global",
            "ProfessionalSystem",
            "ProfessionalOffice2003",
            "Office2007Blue",
            "Office2007Silver",
            "Office2007White",
            "Office2007Black",
            "Office2010Blue",
            "Office2010Silver",
            "Office2010White",
            "Office2010Black",
            "Office2013",
            "Office2013White",
            "Office365Black",
            "Office365Blue",
            "Office365Silver",
            "Office365White",
            "SparkleBlue",
            "SparkleOrange",
            "SparklePurple",
            "Custom"});
            this.kryptonPaletteChooserComboBox1.Location = new System.Drawing.Point(138, 28);
            this.kryptonPaletteChooserComboBox1.Name = "kryptonPaletteChooserComboBox1";
            this.kryptonPaletteChooserComboBox1.Size = new System.Drawing.Size(121, 21);
            this.kryptonPaletteChooserComboBox1.TabIndex = 1;
            this.kryptonPaletteChooserComboBox1.Text = "kryptonPaletteChooserComboBox1";
            this.kryptonPaletteChooserComboBox1.PaletteChanged += new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPaletteChooserComboBox.ChangePaletteEventHandler(this.kryptonPaletteChooserComboBox1_PaletteChanged);
            this.kryptonPaletteChooserComboBox1.SelectedIndexChanged += new System.EventHandler(this.kryptonPaletteChooserComboBox1_SelectedIndexChanged);
            // 
            // kryptonListView1
            // 
            this.kryptonListView1.AlternateRowColour = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
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
            this.kryptonListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.kryptonListView1.LineAfter = -1;
            this.kryptonListView1.LineBefore = -1;
            this.kryptonListView1.Location = new System.Drawing.Point(492, 28);
            this.kryptonListView1.Name = "kryptonListView1";
            this.kryptonListView1.OwnerDraw = true;
            this.kryptonListView1.PersistentColours = false;
            this.kryptonListView1.SelectEntireRowOnSubItem = true;
            this.kryptonListView1.Size = new System.Drawing.Size(741, 427);
            this.kryptonListView1.TabIndex = 0;
            this.kryptonListView1.UseCompatibleStateImageBehavior = false;
            this.kryptonListView1.UseKryptonRenderer = true;
            this.kryptonListView1.UseStyledColours = true;
            this.kryptonListView1.View = System.Windows.Forms.View.Details;
            // 
            // Test
            // 
            this.ClientSize = new System.Drawing.Size(1245, 672);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "Test";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPaletteChooserComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        public Test()
        {
            InitializeComponent();
        }

        private void kryptonPaletteChooserComboBox1_PaletteChanged(object sender, System.EventArgs e)
        {
            kryptonManager1.GlobalPaletteMode = (PaletteModeManager)Enum.Parse(typeof(PaletteMode), kryptonPaletteChooserComboBox1.Text);
        }

        private void kryptonPaletteChooserComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kryptonPaletteChooserComboBox1_PaletteChanged(sender, e);
        }
    }
}