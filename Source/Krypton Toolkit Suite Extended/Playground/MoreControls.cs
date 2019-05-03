#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.Controls.Drawing.UI;

namespace Playground
{
    public class MoreControls : KryptonForm
    {
        private System.ComponentModel.IContainer components;
        private KryptonDomainUpDown kryptonDomainUpDown1;
        private KryptonButton kryptonButton1;
        private KryptonButton kryptonButton2;
        private KryptonManager kryptonManager1;
        private KryptonOutlookGrid.Classes.KryptonOutlookGrid kryptonOutlookGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.ModernProgressBar modernProgressBar1;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton kryptonUACElevatedButton1;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonCueComboBox kryptonCueComboBox1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonGrid kryptonGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private ExtendedControls.ExtendedToolkit.Controls.Navigator.Controls.OutlookBar outlookBar1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.RoundedTextbox roundedTextbox1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.CircularProgressBar circularProgressBar1;
        private ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.ColourComparer colourComparer1;
        private ExtendedControls.ExtendedToolkit.Controls.Colours.SchemesColourEditorUserControl schemesColourEditorUserControl1;
        private ExtendedControls.ExtendedToolkit.Controls.Charting.KryptonLxLedControl kryptonLxLedControl1;
        private ExtendedControls.ExtendedToolkit.Calendar.Controls.MonthView monthView1;
        private Core.Controls.Colours.ColourEditorManager colourEditorManager1;
        private KryptonPanel kryptonPanel1;

        public MoreControls()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues8 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues9 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues10 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            KryptonOutlookGrid.Classes.OutlookGridGroupCollection outlookGridGroupCollection2 = new KryptonOutlookGrid.Classes.OutlookGridGroupCollection();
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues6 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoreControls));
            ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues popupPositionValues7 = new ComponentFactory.Krypton.Toolkit.Values.PopupPositionValues();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonDomainUpDown1 = new ComponentFactory.Krypton.Toolkit.KryptonDomainUpDown();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonOutlookGrid1 = new KryptonOutlookGrid.Classes.KryptonOutlookGrid();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modernProgressBar1 = new KryptonExtendedToolkit.ExtendedToolkit.Controls.ModernProgressBar();
            this.kryptonUACElevatedButton1 = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.kryptonCueComboBox1 = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonCueComboBox();
            this.kryptonGrid1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outlookBar1 = new ExtendedControls.ExtendedToolkit.Controls.Navigator.Controls.OutlookBar();
            this.roundedTextbox1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.RoundedTextbox();
            this.circularProgressBar1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.CircularProgressBar();
            this.colourComparer1 = new ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.ColourComparer();
            this.schemesColourEditorUserControl1 = new ExtendedControls.ExtendedToolkit.Controls.Colours.SchemesColourEditorUserControl();
            this.kryptonLxLedControl1 = new ExtendedControls.ExtendedToolkit.Controls.Charting.KryptonLxLedControl();
            this.monthView1 = new ExtendedControls.ExtendedToolkit.Calendar.Controls.MonthView();
            this.colourEditorManager1 = new Core.Controls.Colours.ColourEditorManager();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonOutlookGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCueComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLxLedControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonOutlookGrid1);
            this.kryptonPanel1.Controls.Add(this.modernProgressBar1);
            this.kryptonPanel1.Controls.Add(this.kryptonUACElevatedButton1);
            this.kryptonPanel1.Controls.Add(this.kryptonCueComboBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonGrid1);
            this.kryptonPanel1.Controls.Add(this.outlookBar1);
            this.kryptonPanel1.Controls.Add(this.roundedTextbox1);
            this.kryptonPanel1.Controls.Add(this.circularProgressBar1);
            this.kryptonPanel1.Controls.Add(this.colourComparer1);
            this.kryptonPanel1.Controls.Add(this.schemesColourEditorUserControl1);
            this.kryptonPanel1.Controls.Add(this.kryptonLxLedControl1);
            this.kryptonPanel1.Controls.Add(this.monthView1);
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
            popupPositionValues8.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kryptonButton2.ToolTipValues.ToolTipPosition = popupPositionValues8;
            this.kryptonButton2.Values.Text = "Colour Chooser 2";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(1057, 180);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(158, 25);
            this.kryptonButton1.TabIndex = 79;
            popupPositionValues9.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kryptonButton1.ToolTipValues.ToolTipPosition = popupPositionValues9;
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
            popupPositionValues10.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kryptonDomainUpDown1.ToolTipValues.ToolTipPosition = popupPositionValues10;
            // 
            // kryptonOutlookGrid1
            // 
            this.kryptonOutlookGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.kryptonOutlookGrid1.FillMode = KryptonOutlookGrid.Classes.FillMode.GROUPSONLY;
            this.kryptonOutlookGrid1.GroupCollection = outlookGridGroupCollection2;
            this.kryptonOutlookGrid1.Location = new System.Drawing.Point(608, 252);
            this.kryptonOutlookGrid1.Name = "kryptonOutlookGrid1";
            this.kryptonOutlookGrid1.PreviousSelectedGroupRow = -1;
            this.kryptonOutlookGrid1.ShowLines = false;
            this.kryptonOutlookGrid1.Size = new System.Drawing.Size(687, 145);
            this.kryptonOutlookGrid1.TabIndex = 11;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            // 
            // modernProgressBar1
            // 
            this.modernProgressBar1.AutoSize = true;
            this.modernProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.modernProgressBar1.Location = new System.Drawing.Point(651, 189);
            this.modernProgressBar1.Name = "modernProgressBar1";
            this.modernProgressBar1.Size = new System.Drawing.Size(548, 15);
            this.modernProgressBar1.TabIndex = 10;
            // 
            // kryptonUACElevatedButton1
            // 
            this.kryptonUACElevatedButton1.Location = new System.Drawing.Point(340, 252);
            this.kryptonUACElevatedButton1.Name = "kryptonUACElevatedButton1";
            this.kryptonUACElevatedButton1.Size = new System.Drawing.Size(135, 26);
            this.kryptonUACElevatedButton1.TabIndex = 9;
            popupPositionValues6.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kryptonUACElevatedButton1.ToolTipValues.ToolTipPosition = popupPositionValues6;
            this.kryptonUACElevatedButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonUACElevatedButton1.Values.Image")));
            this.kryptonUACElevatedButton1.Values.Text = "Elevate Now!";
            // 
            // kryptonCueComboBox1
            // 
            this.kryptonCueComboBox1.CueText = "Test";
            this.kryptonCueComboBox1.DropDownWidth = 121;
            this.kryptonCueComboBox1.Location = new System.Drawing.Point(339, 210);
            this.kryptonCueComboBox1.Name = "kryptonCueComboBox1";
            this.kryptonCueComboBox1.Size = new System.Drawing.Size(121, 21);
            this.kryptonCueComboBox1.TabIndex = 8;
            popupPositionValues7.PlacementMode = ComponentFactory.Krypton.Toolkit.PlacementMode.Bottom;
            this.kryptonCueComboBox1.ToolTipValues.ToolTipPosition = popupPositionValues7;
            // 
            // kryptonGrid1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.kryptonGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.kryptonGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.kryptonGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kryptonGrid1.DefaultCellStyle = dataGridViewCellStyle4;
            this.kryptonGrid1.Location = new System.Drawing.Point(1076, 17);
            this.kryptonGrid1.Name = "kryptonGrid1";
            this.kryptonGrid1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.kryptonGrid1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Navy;
            this.kryptonGrid1.Size = new System.Drawing.Size(240, 150);
            this.kryptonGrid1.TabIndex = 7;
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
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
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
            this.outlookBar1.Location = new System.Drawing.Point(525, 161);
            this.outlookBar1.MinimumSize = new System.Drawing.Size(16, 43);
            this.outlookBar1.Name = "outlookBar1";
            this.outlookBar1.OutlookBarLineColour = System.Drawing.Color.Empty;
            this.outlookBar1.Renderer = ExtendedControls.ExtendedToolkit.Controls.Navigator.Controls.Renderer.Custom;
            this.outlookBar1.Size = new System.Drawing.Size(75, 43);
            this.outlookBar1.TabIndex = 6;
            this.outlookBar1.Text = "outlookBar1";
            // 
            // roundedTextbox1
            // 
            this.roundedTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextbox1.Brush = System.Drawing.Color.White;
            this.roundedTextbox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.roundedTextbox1.ForeColor = System.Drawing.Color.Black;
            this.roundedTextbox1.Location = new System.Drawing.Point(340, 164);
            this.roundedTextbox1.Name = "roundedTextbox1";
            this.roundedTextbox1.Size = new System.Drawing.Size(179, 40);
            this.roundedTextbox1.TabIndex = 5;
            this.roundedTextbox1.Text = "roundedTextbox1";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(13, 164);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(320, 320);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 4;
            this.circularProgressBar1.Text = "50";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // colourComparer1
            // 
            this.colourComparer1.BackColor = System.Drawing.Color.Transparent;
            this.colourComparer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colourComparer1.Location = new System.Drawing.Point(905, 17);
            this.colourComparer1.Name = "colourComparer1";
            this.colourComparer1.PrimaryColour = System.Drawing.Color.White;
            this.colourComparer1.SecondaryColour = System.Drawing.Color.Silver;
            this.colourComparer1.ShowHexadecimalValues = true;
            this.colourComparer1.Size = new System.Drawing.Size(146, 146);
            this.colourComparer1.TabIndex = 3;
            // 
            // schemesColourEditorUserControl1
            // 
            this.schemesColourEditorUserControl1.Location = new System.Drawing.Point(619, 13);
            this.schemesColourEditorUserControl1.Name = "schemesColourEditorUserControl1";
            this.schemesColourEditorUserControl1.SelectedColour = System.Drawing.Color.Empty;
            this.schemesColourEditorUserControl1.Size = new System.Drawing.Size(280, 150);
            this.schemesColourEditorUserControl1.TabIndex = 2;
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
            this.kryptonLxLedControl1.Location = new System.Drawing.Point(243, 12);
            this.kryptonLxLedControl1.Name = "kryptonLxLedControl1";
            this.kryptonLxLedControl1.Size = new System.Drawing.Size(369, 145);
            this.kryptonLxLedControl1.TabIndex = 1;
            this.kryptonLxLedControl1.Text = "12:00";
            // 
            // monthView1
            // 
            this.monthView1.ArrowsColour = System.Drawing.SystemColors.Window;
            this.monthView1.ArrowsSelectedColour = System.Drawing.Color.Gold;
            this.monthView1.DayBackgroundColour = System.Drawing.Color.Empty;
            this.monthView1.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.monthView1.DaySelectedBackgroundColour = System.Drawing.SystemColors.Highlight;
            this.monthView1.DaySelectedColour = System.Drawing.SystemColors.WindowText;
            this.monthView1.DaySelectedTextColour = System.Drawing.SystemColors.HighlightText;
            this.monthView1.ItemPadding = new System.Windows.Forms.Padding(2);
            this.monthView1.Location = new System.Drawing.Point(12, 12);
            this.monthView1.MonthTitleColour = System.Drawing.SystemColors.ActiveCaption;
            this.monthView1.MonthTitleColourInactive = System.Drawing.SystemColors.InactiveCaption;
            this.monthView1.MonthTitleTextColour = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthView1.MonthTitleTextColourInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.monthView1.Name = "monthView1";
            this.monthView1.Size = new System.Drawing.Size(224, 145);
            this.monthView1.TabIndex = 0;
            this.monthView1.Text = "monthView1";
            this.monthView1.TodayBorderColour = System.Drawing.Color.Maroon;
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
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCueComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonLxLedControl1)).EndInit();
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