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
        private Core.Controls.Colours.ColourWheel colourWheel1;
        private KryptonOutlookGrid.Controls.KryptonOutlookGridGroupBox kryptonOutlookGridGroupBox1;
        private KryptonOutlookGrid.Classes.KryptonOutlookGrid kryptonOutlookGrid1;
        private Core.Controls.Colours.ColourEditorManager colourEditorManager1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.PromptRoundedTextbox promptRoundedTextbox1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.RoundedTextbox roundedTextbox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.ToggleSwitch toggleSwitch1;
        private KryptonPanel kryptonPanel1;

        public MoreControls()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            KryptonOutlookGrid.Classes.OutlookGridGroupCollection outlookGridGroupCollection2 = new KryptonOutlookGrid.Classes.OutlookGridGroupCollection();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node3");
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.toggleSwitch1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.ToggleSwitch();
            this.promptRoundedTextbox1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.PromptRoundedTextbox();
            this.roundedTextbox1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.RoundedTextbox();
            this.colourWheel1 = new Core.Controls.Colours.ColourWheel();
            this.kryptonOutlookGridGroupBox1 = new KryptonOutlookGrid.Controls.KryptonOutlookGridGroupBox();
            this.kryptonOutlookGrid1 = new KryptonOutlookGrid.Classes.KryptonOutlookGrid();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.office2007ColourPicker1 = new ExtendedControls.ExtendedToolkit.Controls.Drawing.Controls.Office2007ColourPicker(this.components);
            this.scrollBarExtended1 = new ExtendedControls.ExtendedToolkit.Controls.ScrollBar.CustomScrollBar.ScrollBarExtended();
            this.kryptonGrid1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonBorderedLabel1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel();
            this.kryptonCollapseContainer1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonCollapseContainer();
            this.dataBar1 = new ExtendedControls.ExtendedToolkit.Controls.Charting.DataBar();
            this.dataChart1 = new ExtendedControls.ExtendedToolkit.Controls.Charting.DataChart();
            this.kryptonDomainUpDown1 = new ComponentFactory.Krypton.Toolkit.KryptonDomainUpDown();
            this.kryptonSplitButton1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonSplitButton();
            this.webColourEditorUserControl1 = new ExtendedControls.ExtendedToolkit.Controls.Colours.WebColourEditorUserControl();
            this.kryptonKnobControl1 = new ExtendedControls.ExtendedToolkit.Controls.Charting.KryptonKnobControl();
            this.outlookBar1 = new ExtendedControls.ExtendedToolkit.Controls.Navigator.Controls.OutlookBar();
            this.kryptonLxLedControl1 = new ExtendedControls.ExtendedToolkit.Controls.Charting.KryptonLxLedControl();
            this.starRatingControl1 = new ExtendedControls.ExtendedToolkit.Controls.Charting.StarRatingControl();
            this.kryptonVirtualListBox1 = new ExtendedControls.ExtendedToolkit.Controls.StandardControls.ListBox.KryptonVirtualListBox();
            this.kryptonImageComboBox1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonImageComboBox();
            this.kryptonTreeView1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonTreeView();
            this.loadingCircle1 = new ExtendedControls.ExtendedToolkit.Controls.StandardControls.Common.LoadingCircle();
            this.ribbonRoundButton1 = new ExtendedControls.ExtendedToolkit.Ribbon.RibbonRoundButton();
            this.kryptonCueComboBox1 = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonCueComboBox();
            this.kryptonComboBoxEnhanced1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonComboBoxEnhanced();
            this.kryptonPropertyGrid1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPropertyGrid();
            this.kryptonShadowLabel1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonShadowLabel();
            this.kryptonProgressBar1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonProgressBar();
            this.colourEditorManager1 = new Core.Controls.Colours.ColourEditorManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonOutlookGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLxLedControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCueComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBoxEnhanced1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.toggleSwitch1);
            this.kryptonPanel1.Controls.Add(this.promptRoundedTextbox1);
            this.kryptonPanel1.Controls.Add(this.roundedTextbox1);
            this.kryptonPanel1.Controls.Add(this.colourWheel1);
            this.kryptonPanel1.Controls.Add(this.kryptonOutlookGridGroupBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonOutlookGrid1);
            this.kryptonPanel1.Controls.Add(this.kryptonButton2);
            this.kryptonPanel1.Controls.Add(this.kryptonButton1);
            this.kryptonPanel1.Controls.Add(this.office2007ColourPicker1);
            this.kryptonPanel1.Controls.Add(this.scrollBarExtended1);
            this.kryptonPanel1.Controls.Add(this.kryptonGrid1);
            this.kryptonPanel1.Controls.Add(this.kryptonBorderedLabel1);
            this.kryptonPanel1.Controls.Add(this.kryptonCollapseContainer1);
            this.kryptonPanel1.Controls.Add(this.dataBar1);
            this.kryptonPanel1.Controls.Add(this.dataChart1);
            this.kryptonPanel1.Controls.Add(this.kryptonDomainUpDown1);
            this.kryptonPanel1.Controls.Add(this.kryptonSplitButton1);
            this.kryptonPanel1.Controls.Add(this.webColourEditorUserControl1);
            this.kryptonPanel1.Controls.Add(this.kryptonKnobControl1);
            this.kryptonPanel1.Controls.Add(this.outlookBar1);
            this.kryptonPanel1.Controls.Add(this.kryptonLxLedControl1);
            this.kryptonPanel1.Controls.Add(this.starRatingControl1);
            this.kryptonPanel1.Controls.Add(this.kryptonVirtualListBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonImageComboBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonTreeView1);
            this.kryptonPanel1.Controls.Add(this.loadingCircle1);
            this.kryptonPanel1.Controls.Add(this.ribbonRoundButton1);
            this.kryptonPanel1.Controls.Add(this.kryptonCueComboBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonComboBoxEnhanced1);
            this.kryptonPanel1.Controls.Add(this.kryptonPropertyGrid1);
            this.kryptonPanel1.Controls.Add(this.kryptonShadowLabel1);
            this.kryptonPanel1.Controls.Add(this.kryptonProgressBar1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1450, 777);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.toggleSwitch1.BorderColour = System.Drawing.Color.LightGray;
            this.toggleSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleSwitch1.DisabledColour = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.toggleSwitch1.DisabledKnobColour = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.toggleSwitch1.EndGradientColour = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(157)))), ((int)(((byte)(189)))));
            this.toggleSwitch1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.toggleSwitch1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.toggleSwitch1.IsOn = true;
            this.toggleSwitch1.KnobColour = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.toggleSwitch1.Location = new System.Drawing.Point(616, 504);
            this.toggleSwitch1.MiddleGradientColour = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.OffColour = System.Drawing.Color.Red;
            this.toggleSwitch1.OffTextColour = System.Drawing.Color.White;
            this.toggleSwitch1.OnColour = System.Drawing.Color.LightGreen;
            this.toggleSwitch1.OnTextColour = System.Drawing.Color.Gray;
            this.toggleSwitch1.PenColour = System.Drawing.Color.Transparent;
            this.toggleSwitch1.Size = new System.Drawing.Size(168, 86);
            this.toggleSwitch1.StartGradientColour = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.toggleSwitch1.TabIndex = 86;
            this.toggleSwitch1.Text = "toggleSwitch1";
            this.toggleSwitch1.TextEnabled = true;
            this.toggleSwitch1.UseGradientOnKnob = true;
            // 
            // promptRoundedTextbox1
            // 
            this.promptRoundedTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.promptRoundedTextbox1.Brush = System.Drawing.Color.White;
            this.promptRoundedTextbox1.DrawPrompt = true;
            this.promptRoundedTextbox1.FocusSelect = true;
            this.promptRoundedTextbox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.promptRoundedTextbox1.ForeColor = System.Drawing.Color.DimGray;
            this.promptRoundedTextbox1.Location = new System.Drawing.Point(270, 504);
            this.promptRoundedTextbox1.Name = "promptRoundedTextbox1";
            this.promptRoundedTextbox1.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.promptRoundedTextbox1.PromptText = "This is a test...";
            this.promptRoundedTextbox1.PromptTypeface = new System.Drawing.Font("Segoe UI", 11F);
            this.promptRoundedTextbox1.Size = new System.Drawing.Size(323, 33);
            this.promptRoundedTextbox1.TabIndex = 85;
            this.promptRoundedTextbox1.Text = "promptRoundedTextbox1";
            // 
            // roundedTextbox1
            // 
            this.roundedTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextbox1.Brush = System.Drawing.Color.White;
            this.roundedTextbox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.roundedTextbox1.ForeColor = System.Drawing.Color.Black;
            this.roundedTextbox1.Location = new System.Drawing.Point(13, 342);
            this.roundedTextbox1.Name = "roundedTextbox1";
            this.roundedTextbox1.Size = new System.Drawing.Size(223, 33);
            this.roundedTextbox1.TabIndex = 84;
            this.roundedTextbox1.Text = "Hello World!";
            // 
            // colourWheel1
            // 
            this.colourWheel1.Location = new System.Drawing.Point(1098, 425);
            this.colourWheel1.Name = "colourWheel1";
            this.colourWheel1.Size = new System.Drawing.Size(263, 302);
            this.colourWheel1.TabIndex = 1;
            // 
            // kryptonOutlookGridGroupBox1
            // 
            this.kryptonOutlookGridGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonOutlookGridGroupBox1.Location = new System.Drawing.Point(270, 450);
            this.kryptonOutlookGridGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kryptonOutlookGridGroupBox1.Name = "kryptonOutlookGridGroupBox1";
            this.kryptonOutlookGridGroupBox1.Size = new System.Drawing.Size(744, 46);
            this.kryptonOutlookGridGroupBox1.TabIndex = 83;
            // 
            // kryptonOutlookGrid1
            // 
            this.kryptonOutlookGrid1.FillMode = KryptonOutlookGrid.Classes.FillMode.GROUPSONLY;
            this.kryptonOutlookGrid1.GroupCollection = outlookGridGroupCollection2;
            this.kryptonOutlookGrid1.Location = new System.Drawing.Point(12, 382);
            this.kryptonOutlookGrid1.Name = "kryptonOutlookGrid1";
            this.kryptonOutlookGrid1.PreviousSelectedGroupRow = -1;
            this.kryptonOutlookGrid1.ShowLines = false;
            this.kryptonOutlookGrid1.Size = new System.Drawing.Size(240, 150);
            this.kryptonOutlookGrid1.TabIndex = 82;
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
            // office2007ColourPicker1
            // 
            this.office2007ColourPicker1.Color = System.Drawing.Color.Black;
            this.office2007ColourPicker1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.office2007ColourPicker1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.office2007ColourPicker1.FormattingEnabled = true;
            this.office2007ColourPicker1.Items.AddRange(new object[] {
            "Color"});
            this.office2007ColourPicker1.Location = new System.Drawing.Point(993, 12);
            this.office2007ColourPicker1.Name = "office2007ColourPicker1";
            this.office2007ColourPicker1.Size = new System.Drawing.Size(208, 21);
            this.office2007ColourPicker1.TabIndex = 78;
            // 
            // scrollBarExtended1
            // 
            this.scrollBarExtended1.Location = new System.Drawing.Point(1032, 255);
            this.scrollBarExtended1.Name = "scrollBarExtended1";
            this.scrollBarExtended1.Size = new System.Drawing.Size(19, 200);
            this.scrollBarExtended1.TabIndex = 77;
            // 
            // kryptonGrid1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.kryptonGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.kryptonGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kryptonGrid1.DefaultCellStyle = dataGridViewCellStyle4;
            this.kryptonGrid1.Location = new System.Drawing.Point(774, 276);
            this.kryptonGrid1.Name = "kryptonGrid1";
            this.kryptonGrid1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.kryptonGrid1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Navy;
            this.kryptonGrid1.Size = new System.Drawing.Size(240, 150);
            this.kryptonGrid1.TabIndex = 76;
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
            // kryptonBorderedLabel1
            // 
            this.kryptonBorderedLabel1.BackColor = System.Drawing.Color.Transparent;
            this.kryptonBorderedLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(214)))));
            this.kryptonBorderedLabel1.Location = new System.Drawing.Point(616, 276);
            this.kryptonBorderedLabel1.Name = "kryptonBorderedLabel1";
            this.kryptonBorderedLabel1.Size = new System.Drawing.Size(139, 20);
            this.kryptonBorderedLabel1.TabIndex = 75;
            this.kryptonBorderedLabel1.Values.Text = "kryptonBorderedLabel1";
            // 
            // kryptonCollapseContainer1
            // 
            this.kryptonCollapseContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.kryptonCollapseContainer1.Collapsable = true;
            this.kryptonCollapseContainer1.HeaderText = "";
            this.kryptonCollapseContainer1.Location = new System.Drawing.Point(242, 276);
            this.kryptonCollapseContainer1.Name = "kryptonCollapseContainer1";
            this.kryptonCollapseContainer1.OpenHeight = 100;
            this.kryptonCollapseContainer1.PanelOpen = true;
            this.kryptonCollapseContainer1.Size = new System.Drawing.Size(200, 100);
            this.kryptonCollapseContainer1.TabIndex = 73;
            // 
            // dataBar1
            // 
            this.dataBar1.BackColor = System.Drawing.Color.Silver;
            this.dataBar1.BarColour = System.Drawing.Color.DarkBlue;
            this.dataBar1.Location = new System.Drawing.Point(12, 308);
            this.dataBar1.Name = "dataBar1";
            this.dataBar1.Size = new System.Drawing.Size(128, 16);
            this.dataBar1.TabIndex = 72;
            this.dataBar1.Value = 0;
            // 
            // dataChart1
            // 
            this.dataChart1.BackColor = System.Drawing.Color.Silver;
            this.dataChart1.ChartType = ExtendedControls.ExtendedToolkit.Controls.Charting.ChartType.Stick;
            this.dataChart1.GridColour = System.Drawing.Color.Yellow;
            this.dataChart1.GridPixels = 0;
            this.dataChart1.InitialHeight = 1000;
            this.dataChart1.LineColour = System.Drawing.Color.DarkBlue;
            this.dataChart1.Location = new System.Drawing.Point(12, 276);
            this.dataChart1.Name = "dataChart1";
            this.dataChart1.Size = new System.Drawing.Size(150, 16);
            this.dataChart1.TabIndex = 71;
            // 
            // kryptonDomainUpDown1
            // 
            this.kryptonDomainUpDown1.Location = new System.Drawing.Point(1057, 152);
            this.kryptonDomainUpDown1.Name = "kryptonDomainUpDown1";
            this.kryptonDomainUpDown1.Size = new System.Drawing.Size(158, 22);
            this.kryptonDomainUpDown1.TabIndex = 70;
            this.kryptonDomainUpDown1.Text = "kryptonDomainUpDown1";
            // 
            // kryptonSplitButton1
            // 
            this.kryptonSplitButton1.AutoSize = true;
            this.kryptonSplitButton1.Location = new System.Drawing.Point(1057, 122);
            this.kryptonSplitButton1.Name = "kryptonSplitButton1";
            this.kryptonSplitButton1.Size = new System.Drawing.Size(158, 24);
            this.kryptonSplitButton1.TabIndex = 58;
            this.kryptonSplitButton1.Values.Text = "kryptonSplitButton1";
            // 
            // webColourEditorUserControl1
            // 
            this.webColourEditorUserControl1.Location = new System.Drawing.Point(889, 59);
            this.webColourEditorUserControl1.Name = "webColourEditorUserControl1";
            this.webColourEditorUserControl1.SelectedColour = System.Drawing.Color.Empty;
            this.webColourEditorUserControl1.Size = new System.Drawing.Size(162, 179);
            this.webColourEditorUserControl1.TabIndex = 69;
            // 
            // kryptonKnobControl1
            // 
            this.kryptonKnobControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonKnobControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.kryptonKnobControl1.LargeChange = 20;
            this.kryptonKnobControl1.Location = new System.Drawing.Point(1232, 59);
            this.kryptonKnobControl1.Maximum = 100;
            this.kryptonKnobControl1.Minimum = 0;
            this.kryptonKnobControl1.Name = "kryptonKnobControl1";
            this.kryptonKnobControl1.ShowLargeScale = true;
            this.kryptonKnobControl1.ShowSmallScale = false;
            this.kryptonKnobControl1.Size = new System.Drawing.Size(133, 128);
            this.kryptonKnobControl1.SizeLargeScaleMarker = 6;
            this.kryptonKnobControl1.SizeSmallScaleMarker = 3;
            this.kryptonKnobControl1.SmallChange = 5;
            this.kryptonKnobControl1.TabIndex = 57;
            this.kryptonKnobControl1.Value = 0;
            // 
            // outlookBar1
            // 
            this.outlookBar1.ButtonColourHoveringBottom = System.Drawing.Color.Empty;
            this.outlookBar1.ButtonColourHoveringTop = System.Drawing.Color.Empty;
            this.outlookBar1.ButtonColourPassiveBottom = System.Drawing.Color.Empty;
            this.outlookBar1.ButtonColourPassiveTop = System.Drawing.Color.Empty;
            this.outlookBar1.ButtonColourSelectedAndHoveringBottom = System.Drawing.Color.Empty;
            this.outlookBar1.ButtonColourSelectedAndHoveringTop = System.Drawing.Color.Empty;
            this.outlookBar1.ButtonColourSelectedBottom = System.Drawing.Color.Empty;
            this.outlookBar1.ButtonColourSelectedTop = System.Drawing.Color.Empty;
            this.outlookBar1.ButtonHeight = 35;
            this.outlookBar1.ForeColourSelected = System.Drawing.Color.Empty;
            this.outlookBar1.Location = new System.Drawing.Point(1057, 59);
            this.outlookBar1.MinimumSize = new System.Drawing.Size(16, 43);
            this.outlookBar1.Name = "outlookBar1";
            this.outlookBar1.OutlookBarLineColour = System.Drawing.Color.Empty;
            this.outlookBar1.Renderer = ExtendedControls.ExtendedToolkit.Controls.Navigator.Controls.Renderer.Custom;
            this.outlookBar1.Size = new System.Drawing.Size(151, 43);
            this.outlookBar1.TabIndex = 56;
            this.outlookBar1.Text = "outlookBar1";
            // 
            // kryptonLxLedControl1
            // 
            this.kryptonLxLedControl1.BackColor = System.Drawing.Color.Transparent;
            this.kryptonLxLedControl1.BackColour_1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.kryptonLxLedControl1.BackColour_2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.kryptonLxLedControl1.BevelRate = 0.5F;
            this.kryptonLxLedControl1.BorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(157)))), ((int)(((byte)(189)))));
            this.kryptonLxLedControl1.FadedColour = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.kryptonLxLedControl1.FocusedBorderColour = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(157)))), ((int)(((byte)(189)))));
            this.kryptonLxLedControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonLxLedControl1.HighlightOpaque = ((byte)(75));
            this.kryptonLxLedControl1.Location = new System.Drawing.Point(282, 139);
            this.kryptonLxLedControl1.Name = "kryptonLxLedControl1";
            this.kryptonLxLedControl1.Size = new System.Drawing.Size(146, 32);
            this.kryptonLxLedControl1.TabIndex = 68;
            this.kryptonLxLedControl1.Text = "12:00";
            // 
            // starRatingControl1
            // 
            this.starRatingControl1.CurrentStarValue = 0;
            this.starRatingControl1.FirstColour = System.Drawing.Color.Red;
            this.starRatingControl1.FirstColourQuantity = 2;
            this.starRatingControl1.Location = new System.Drawing.Point(282, 177);
            this.starRatingControl1.Name = "starRatingControl1";
            this.starRatingControl1.SecondColour = System.Drawing.Color.Blue;
            this.starRatingControl1.SecondColourQuantity = 1;
            this.starRatingControl1.Size = new System.Drawing.Size(75, 15);
            this.starRatingControl1.StarCount = 5;
            this.starRatingControl1.StartSize = 15;
            this.starRatingControl1.TabIndex = 67;
            this.starRatingControl1.ThirdColour = System.Drawing.Color.Green;
            this.starRatingControl1.ThirdColourQuantity = 2;
            // 
            // kryptonVirtualListBox1
            // 
            this.kryptonVirtualListBox1.Count = 0;
            this.kryptonVirtualListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.kryptonVirtualListBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.kryptonVirtualListBox1.Location = new System.Drawing.Point(676, 59);
            this.kryptonVirtualListBox1.Name = "kryptonVirtualListBox1";
            this.kryptonVirtualListBox1.Size = new System.Drawing.Size(207, 179);
            this.kryptonVirtualListBox1.TabIndex = 66;
            // 
            // kryptonImageComboBox1
            // 
            this.kryptonImageComboBox1.DropDownWidth = 208;
            this.kryptonImageComboBox1.Location = new System.Drawing.Point(1207, 12);
            this.kryptonImageComboBox1.Name = "kryptonImageComboBox1";
            this.kryptonImageComboBox1.Size = new System.Drawing.Size(208, 21);
            this.kryptonImageComboBox1.TabIndex = 65;
            this.kryptonImageComboBox1.Text = "kryptonImageComboBox1";
            // 
            // kryptonTreeView1
            // 
            this.kryptonTreeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.kryptonTreeView1.FullRowSelect = true;
            this.kryptonTreeView1.Location = new System.Drawing.Point(481, 59);
            this.kryptonTreeView1.Name = "kryptonTreeView1";
            treeNode7.Name = "Node4";
            treeNode7.Text = "Node4";
            treeNode8.Name = "Node5";
            treeNode8.Text = "Node5";
            treeNode9.Name = "Node0";
            treeNode9.Text = "Node0";
            treeNode10.Name = "Node1";
            treeNode10.Text = "Node1";
            treeNode11.Name = "Node2";
            treeNode11.Text = "Node2";
            treeNode12.Name = "Node3";
            treeNode12.Text = "Node3";
            this.kryptonTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.kryptonTreeView1.Size = new System.Drawing.Size(189, 179);
            this.kryptonTreeView1.TabIndex = 63;
            // 
            // loadingCircle1
            // 
            this.loadingCircle1.Active = false;
            this.loadingCircle1.BackColor = System.Drawing.Color.Transparent;
            this.loadingCircle1.Color = System.Drawing.Color.Maroon;
            this.loadingCircle1.InnerCircleRadius = 5;
            this.loadingCircle1.Location = new System.Drawing.Point(328, 70);
            this.loadingCircle1.Name = "loadingCircle1";
            this.loadingCircle1.NumberSpoke = 12;
            this.loadingCircle1.OuterCircleRadius = 11;
            this.loadingCircle1.RotationSpeed = 100;
            this.loadingCircle1.Size = new System.Drawing.Size(114, 51);
            this.loadingCircle1.SpokeThickness = 2;
            this.loadingCircle1.StylePreset = ExtendedControls.ExtendedToolkit.Controls.StandardControls.Common.LoadingCircle.StylePresets.MacOSX;
            this.loadingCircle1.TabIndex = 62;
            this.loadingCircle1.Text = "loadingCircle1";
            // 
            // ribbonRoundButton1
            // 
            this.ribbonRoundButton1.BackColor = System.Drawing.Color.Transparent;
            this.ribbonRoundButton1.ColourBase = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.ribbonRoundButton1.ColourOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ribbonRoundButton1.ColourOver = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ribbonRoundButton1.ColourPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ribbonRoundButton1.ColourStroke = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ribbonRoundButton1.FlatAppearance.BorderSize = 0;
            this.ribbonRoundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ribbonRoundButton1.ImgOffset = new System.Drawing.Point(0, 0);
            this.ribbonRoundButton1.ImgScale = 100;
            this.ribbonRoundButton1.Location = new System.Drawing.Point(282, 70);
            this.ribbonRoundButton1.Name = "ribbonRoundButton1";
            this.ribbonRoundButton1.Size = new System.Drawing.Size(40, 40);
            this.ribbonRoundButton1.TabIndex = 61;
            this.ribbonRoundButton1.Text = "ribbonRoundButton1";
            this.ribbonRoundButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ribbonRoundButton1.UseVisualStyleBackColor = false;
            // 
            // kryptonCueComboBox1
            // 
            this.kryptonCueComboBox1.CueText = "Cue text...";
            this.kryptonCueComboBox1.DropDownWidth = 250;
            this.kryptonCueComboBox1.Location = new System.Drawing.Point(737, 12);
            this.kryptonCueComboBox1.Name = "kryptonCueComboBox1";
            this.kryptonCueComboBox1.Size = new System.Drawing.Size(250, 21);
            this.kryptonCueComboBox1.TabIndex = 60;
            // 
            // kryptonComboBoxEnhanced1
            // 
            this.kryptonComboBoxEnhanced1.DropDownWidth = 250;
            this.kryptonComboBoxEnhanced1.Location = new System.Drawing.Point(481, 12);
            this.kryptonComboBoxEnhanced1.Name = "kryptonComboBoxEnhanced1";
            this.kryptonComboBoxEnhanced1.PersistentColours = false;
            this.kryptonComboBoxEnhanced1.Size = new System.Drawing.Size(250, 21);
            this.kryptonComboBoxEnhanced1.TabIndex = 59;
            this.kryptonComboBoxEnhanced1.Text = "kryptonComboBoxEnhanced1";
            this.kryptonComboBoxEnhanced1.UseStyledColours = false;
            // 
            // kryptonPropertyGrid1
            // 
            this.kryptonPropertyGrid1.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonPropertyGrid1.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kryptonPropertyGrid1.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonPropertyGrid1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.kryptonPropertyGrid1.Location = new System.Drawing.Point(12, 70);
            this.kryptonPropertyGrid1.Name = "kryptonPropertyGrid1";
            this.kryptonPropertyGrid1.Size = new System.Drawing.Size(264, 200);
            this.kryptonPropertyGrid1.TabIndex = 58;
            // 
            // kryptonShadowLabel1
            // 
            this.kryptonShadowLabel1.BackColor = System.Drawing.Color.Transparent;
            this.kryptonShadowLabel1.Location = new System.Drawing.Point(292, 12);
            this.kryptonShadowLabel1.Name = "kryptonShadowLabel1";
            this.kryptonShadowLabel1.Size = new System.Drawing.Size(118, 23);
            this.kryptonShadowLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonShadowLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonShadowLabel1.TabIndex = 48;
            this.kryptonShadowLabel1.Values.Text = "This is a test...";
            // 
            // kryptonProgressBar1
            // 
            this.kryptonProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.kryptonProgressBar1.BackgroundColour = System.Drawing.Color.Teal;
            this.kryptonProgressBar1.DisplayText = "50%";
            this.kryptonProgressBar1.EndColour = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kryptonProgressBar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonProgressBar1.ForeColor = System.Drawing.Color.White;
            this.kryptonProgressBar1.GlowColour = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kryptonProgressBar1.Location = new System.Drawing.Point(12, 12);
            this.kryptonProgressBar1.Name = "kryptonProgressBar1";
            this.kryptonProgressBar1.Size = new System.Drawing.Size(264, 32);
            this.kryptonProgressBar1.StartColour = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kryptonProgressBar1.TabIndex = 47;
            this.kryptonProgressBar1.Value = 50;
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
            // MoreControls
            // 
            this.ClientSize = new System.Drawing.Size(1450, 777);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "MoreControls";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonOutlookGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLxLedControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCueComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBoxEnhanced1)).EndInit();
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