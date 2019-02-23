using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.Controls.Drawing.UI;

namespace Playground
{
    public class MoreControls : KryptonForm
    {
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonShadowLabel kryptonShadowLabel1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonProgressBar kryptonProgressBar1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPropertyGrid kryptonPropertyGrid1;
        private ExtendedControls.ExtendedToolkit.Controls.Colours.WebColourEditorUserControl webColourEditorUserControl1;
        private ExtendedControls.ExtendedToolkit.Controls.Charting.KryptonLxLedControl kryptonLxLedControl1;
        private ExtendedControls.ExtendedToolkit.Controls.Charting.StarRatingControl starRatingControl1;
        private ExtendedControls.ExtendedToolkit.Controls.StandardControls.ListBox.KryptonVirtualListBox kryptonVirtualListBox1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonImageComboBox kryptonImageComboBox1;
        private System.ComponentModel.IContainer components;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonTreeView kryptonTreeView1;
        private ExtendedControls.ExtendedToolkit.Controls.StandardControls.Common.LoadingCircle loadingCircle1;
        private ExtendedControls.ExtendedToolkit.Ribbon.RibbonRoundButton ribbonRoundButton1;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonCueComboBox kryptonCueComboBox1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonComboBoxEnhanced kryptonComboBoxEnhanced1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonSplitButton kryptonSplitButton1;
        private ExtendedControls.ExtendedToolkit.Controls.Charting.KryptonKnobControl kryptonKnobControl1;
        private ExtendedControls.ExtendedToolkit.Controls.Navigator.Controls.OutlookBar outlookBar1;
        private KryptonDomainUpDown kryptonDomainUpDown1;
        private ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.ScrollBarExtended scrollBarExtended1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonGrid kryptonGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel kryptonBorderedLabel1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonCollapseContainer kryptonCollapseContainer1;
        private ExtendedControls.ExtendedToolkit.Controls.Charting.DataBar dataBar1;
        private ExtendedControls.ExtendedToolkit.Controls.Charting.DataChart dataChart1;
        private ExtendedControls.ExtendedToolkit.Controls.Drawing.Controls.Office2007ColourPicker office2007ColourPicker1;
        private KryptonButton kryptonButton1;
        private KryptonButton kryptonButton2;
        private KryptonOutlookGrid.Controls.KryptonOutlookGridGroupBox kryptonOutlookGridGroupBox1;
        private KryptonOutlookGrid.Classes.KryptonOutlookGrid kryptonOutlookGrid1;
        private Core.Controls.Colours.ColourEditorManager colourEditorManager1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.RoundedTextbox roundedTextbox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonToggleSwitch kryptonToggleSwitch1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPaletteSelector kryptonPaletteSelector1;
        private KryptonManager kryptonManager1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPaletteSelector kryptonPaletteSelector2;
        private KryptonPanel kryptonPanel1;

        public MoreControls()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonDomainUpDown1 = new ComponentFactory.Krypton.Toolkit.KryptonDomainUpDown();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonPaletteSelector2 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPaletteSelector();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPaletteSelector2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1450, 777);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(1057, 211);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(158, 25);
            this.kryptonButton2.TabIndex = 80;
            this.kryptonButton2.Values.Text = "Colour Chooser 2";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(1057, 180);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(158, 25);
            this.kryptonButton1.TabIndex = 79;
            this.kryptonButton1.Values.Text = "Colour Chooser 1";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonDomainUpDown1
            // 
            this.kryptonDomainUpDown1.Location = new System.Drawing.Point(1057, 152);
            this.kryptonDomainUpDown1.Name = "kryptonDomainUpDown1";
            this.kryptonDomainUpDown1.Size = new System.Drawing.Size(158, 22);
            this.kryptonDomainUpDown1.TabIndex = 70;
            this.kryptonDomainUpDown1.Text = "kryptonDomainUpDown1";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // kryptonPaletteSelector2
            // 
            this.kryptonPaletteSelector2.AutoSize = true;
            this.kryptonPaletteSelector2.BackColor = System.Drawing.Color.Transparent;
            this.kryptonPaletteSelector2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteSelector2.LabelTypeface = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.kryptonPaletteSelector2.Location = new System.Drawing.Point(489, 419);
            this.kryptonPaletteSelector2.Name = "kryptonPaletteSelector2";
            this.kryptonPaletteSelector2.ParentKryptonManager = null;
            this.kryptonPaletteSelector2.Size = new System.Drawing.Size(476, 41);
            this.kryptonPaletteSelector2.TabIndex = 0;
            // 
            // MoreControls
            // 
            this.ClientSize = new System.Drawing.Size(1450, 777);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "MoreControls";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void kryptonButton1_Click(object sender, System.EventArgs e)
        {
            KryptonColourChooser1 kcc1 = new KryptonColourChooser1();

            kcc1.Show();
        }

        private void kryptonButton2_Click(object sender, System.EventArgs e)
        {
            KryptonColourChooser2 kcc2 = new KryptonColourChooser2();

            kcc2.Show();
        }
    }
}