#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.Controls.Drawing.Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.UI.Colours
{
    public partial class ColourWheelColourPickerDialog : KryptonForm
    {
        #region Variables
        private bool _isUpdating = false;

        private Color _selectedColour;

        private Timer _updateColour = new Timer(), _updateHexadecimalColourValues = new Timer(), _updateHSBColourValues = new Timer(), _updateARGBColourValues = new Timer(), _updateRGBColourValue = new Timer(), _updateSelectedColour = new Timer();
        #endregion

        #region Properties
        [Category("Appearance")]
        //[DefaultValue(Color.Transparent)]
        public Color SelectedColour { get { return _selectedColour; } set { _selectedColour = value; } }

        public Color Colour { get; set; }

        public bool IsUpdating { get { return _isUpdating; } set { _isUpdating = value; } }
        #endregion

        #region Designer Code
        private KryptonPanel kryptonPanel1;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonCueTextBox kryptonCueTextBox1;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbSelectedColour;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox kptxtHexColour;
        private KryptonLabel klblSaturation;
        private KryptonLabel klblHue;
        private KryptonLabel kryptonLabel2;
        private KryptonLabel kryptonLabel1;
        private KryptonButton kbtnCancel;
        private KryptonNumericUpDown knumAlpha;
        private KryptonNumericUpDown knumRed;
        private KryptonNumericUpDown knumGreen;
        private KryptonNumericUpDown knumBlue;
        private KryptonNumericUpDown knumBrightness;
        private KryptonNumericUpDown knumSaturation;
        private KryptonNumericUpDown knumHue;
        private KryptonLabel kryptonLabel9;
        private KryptonLabel kryptonLabel8;
        private KryptonLabel kryptonLabel7;
        private KryptonLabel kryptonLabel6;
        private KryptonLabel klblBrightness;


        private KryptonButton kbtnOk;
        private Panel panel1;
        private KryptonPanel kryptonPanel2;
        private ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.ColourWheel cwColourSelector;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColourWheelColourPickerDialog));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.knumAlpha = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumRed = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumGreen = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumBlue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumBrightness = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumSaturation = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumHue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblBrightness = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblSaturation = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblHue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kptxtHexColour = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.kryptonCueTextBox1 = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonCueTextBox();
            this.cbSelectedColour = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cwColourSelector = new ExtendedControls.ExtendedToolkit.Controls.Colours.Controls.ColourWheel();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSelectedColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.knumAlpha);
            this.kryptonPanel1.Controls.Add(this.knumRed);
            this.kryptonPanel1.Controls.Add(this.knumGreen);
            this.kryptonPanel1.Controls.Add(this.knumBlue);
            this.kryptonPanel1.Controls.Add(this.knumBrightness);
            this.kryptonPanel1.Controls.Add(this.knumSaturation);
            this.kryptonPanel1.Controls.Add(this.knumHue);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.klblBrightness);
            this.kryptonPanel1.Controls.Add(this.klblSaturation);
            this.kryptonPanel1.Controls.Add(this.klblHue);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.kptxtHexColour);
            this.kryptonPanel1.Controls.Add(this.kryptonCueTextBox1);
            this.kryptonPanel1.Controls.Add(this.cbSelectedColour);
            this.kryptonPanel1.Controls.Add(this.cwColourSelector);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(525, 357);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // knumAlpha
            // 
            this.knumAlpha.Location = new System.Drawing.Point(436, 171);
            this.knumAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumAlpha.Name = "knumAlpha";
            this.knumAlpha.Size = new System.Drawing.Size(74, 28);
            this.knumAlpha.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumAlpha.TabIndex = 22;
            this.knumAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.knumAlpha.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // knumRed
            // 
            this.knumRed.Location = new System.Drawing.Point(436, 228);
            this.knumRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumRed.Name = "knumRed";
            this.knumRed.Size = new System.Drawing.Size(74, 28);
            this.knumRed.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.knumRed.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumRed.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumRed.TabIndex = 21;
            this.knumRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumGreen
            // 
            this.knumGreen.Location = new System.Drawing.Point(436, 274);
            this.knumGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumGreen.Name = "knumGreen";
            this.knumGreen.Size = new System.Drawing.Size(74, 28);
            this.knumGreen.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.knumGreen.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumGreen.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumGreen.TabIndex = 20;
            this.knumGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumBlue
            // 
            this.knumBlue.Location = new System.Drawing.Point(436, 322);
            this.knumBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumBlue.Name = "knumBlue";
            this.knumBlue.Size = new System.Drawing.Size(74, 28);
            this.knumBlue.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.knumBlue.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumBlue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumBlue.TabIndex = 19;
            this.knumBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumBrightness
            // 
            this.knumBrightness.Location = new System.Drawing.Point(284, 322);
            this.knumBrightness.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumBrightness.Name = "knumBrightness";
            this.knumBrightness.Size = new System.Drawing.Size(74, 28);
            this.knumBrightness.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumBrightness.TabIndex = 18;
            this.knumBrightness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumSaturation
            // 
            this.knumSaturation.Location = new System.Drawing.Point(284, 274);
            this.knumSaturation.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumSaturation.Name = "knumSaturation";
            this.knumSaturation.Size = new System.Drawing.Size(74, 28);
            this.knumSaturation.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumSaturation.TabIndex = 17;
            this.knumSaturation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // knumHue
            // 
            this.knumHue.Location = new System.Drawing.Point(284, 228);
            this.knumHue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumHue.Name = "knumHue";
            this.knumHue.Size = new System.Drawing.Size(74, 28);
            this.knumHue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumHue.TabIndex = 16;
            this.knumHue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(375, 324);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(50, 26);
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 15;
            this.kryptonLabel9.Values.Text = "Blue:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(363, 274);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 14;
            this.kryptonLabel8.Values.Text = "Green:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(379, 228);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(46, 26);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 13;
            this.kryptonLabel7.Values.Text = "Red:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(363, 173);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 12;
            this.kryptonLabel6.Values.Text = "Alpha:";
            // 
            // klblBrightness
            // 
            this.klblBrightness.Location = new System.Drawing.Point(180, 324);
            this.klblBrightness.Name = "klblBrightness";
            this.klblBrightness.Size = new System.Drawing.Size(98, 26);
            this.klblBrightness.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblBrightness.TabIndex = 11;
            this.klblBrightness.Values.Text = "Brightness:";
            // 
            // klblSaturation
            // 
            this.klblSaturation.Location = new System.Drawing.Point(181, 274);
            this.klblSaturation.Name = "klblSaturation";
            this.klblSaturation.Size = new System.Drawing.Size(97, 26);
            this.klblSaturation.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblSaturation.TabIndex = 10;
            this.klblSaturation.Values.Text = "Saturation:";
            // 
            // klblHue
            // 
            this.klblHue.Location = new System.Drawing.Point(230, 228);
            this.klblHue.Name = "klblHue";
            this.klblHue.Size = new System.Drawing.Size(48, 26);
            this.klblHue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblHue.TabIndex = 9;
            this.klblHue.Values.Text = "Hue:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(232, 104);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(164, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "Hexadecimal Value: ";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(302, 33);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(138, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = "Selected Colour:";
            // 
            // kptxtHexColour
            // 
            this.kptxtHexColour.DrawPrompt = true;
            this.kptxtHexColour.FocusSelect = true;
            this.kptxtHexColour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kptxtHexColour.Location = new System.Drawing.Point(402, 101);
            this.kptxtHexColour.MaxLength = 7;
            this.kptxtHexColour.Name = "kptxtHexColour";
            this.kptxtHexColour.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.kptxtHexColour.PromptText = "#000000";
            this.kptxtHexColour.PromptTypeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kptxtHexColour.Size = new System.Drawing.Size(108, 29);
            this.kptxtHexColour.TabIndex = 5;
            this.kptxtHexColour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonCueTextBox1
            // 
            this.kryptonCueTextBox1.CueText = "000000";
            this.kryptonCueTextBox1.Location = new System.Drawing.Point(410, 101);
            this.kryptonCueTextBox1.MaxLength = 6;
            this.kryptonCueTextBox1.Name = "kryptonCueTextBox1";
            this.kryptonCueTextBox1.Size = new System.Drawing.Size(100, 29);
            this.kryptonCueTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCueTextBox1.TabIndex = 2;
            this.kryptonCueTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbSelectedColour
            // 
            this.cbSelectedColour.BackColor = System.Drawing.Color.White;
            this.cbSelectedColour.Location = new System.Drawing.Point(446, 12);
            this.cbSelectedColour.Name = "cbSelectedColour";
            this.cbSelectedColour.Size = new System.Drawing.Size(64, 64);
            this.cbSelectedColour.TabIndex = 1;
            this.cbSelectedColour.TabStop = false;
            this.cbSelectedColour.BackColorChanged += new System.EventHandler(this.cbSelectedColour_BackColorChanged);
            // 
            // cwColourSelector
            // 
            this.cwColourSelector.BackColor = System.Drawing.Color.Transparent;
            this.cwColourSelector.Location = new System.Drawing.Point(12, 12);
            this.cwColourSelector.Name = "cwColourSelector";
            this.cwColourSelector.Size = new System.Drawing.Size(202, 195);
            this.cwColourSelector.TabIndex = 0;
            this.cwColourSelector.ColourChanged += new System.EventHandler(this.cwColourSelector_ColourChanged);
            // 
            // kbtnOk
            // 
            this.kbtnOk.AutoSize = true;
            this.kbtnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnOk.Location = new System.Drawing.Point(412, 12);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(32, 30);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 23;
            this.kbtnOk.Values.Text = "O&k";
            this.kbtnOk.Click += new System.EventHandler(this.kbtnOk_Click);
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.AutoSize = true;
            this.kbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(450, 12);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(60, 30);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 6;
            this.kbtnCancel.Values.Text = "C&ancel";
            this.kbtnCancel.Click += new System.EventHandler(this.kbtnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 2);
            this.panel1.TabIndex = 3;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnOk);
            this.kryptonPanel2.Controls.Add(this.kbtnCancel);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 359);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(525, 54);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // ColourWheelColourPickerDialog
            // 
            this.AcceptButton = this.kbtnOk;
            this.CancelButton = this.kbtnCancel;
            this.ClientSize = new System.Drawing.Size(525, 413);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColourWheelColourPickerDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select {0}";
            this.Load += new System.EventHandler(this.ColourWheelColourPickerDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSelectedColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        public ColourWheelColourPickerDialog(bool showHSBUIComponents = false)
        {
            InitializeComponent();

            ShowHSBUIComponents(showHSBUIComponents);

            #region Timers

            #region Update Colour
            _updateColour.Interval = 250;

            _updateColour.Tick += UpdateColour_Tick;
            #endregion

            #region Hexadecimal
            _updateHexadecimalColourValues.Interval = 250;

            _updateHexadecimalColourValues.Tick += UpdateHexadecimalColourValues_Tick;
            #endregion

            #region HSB
            _updateHSBColourValues.Interval = 250;

            _updateHSBColourValues.Tick += UpdateHSBColourValues_Tick;
            #endregion

            #region ARGB
            _updateARGBColourValues.Interval = 250;

            _updateARGBColourValues.Tick += UpdateARGBColourValues_Tick;
            #endregion

            #region RGB
            _updateRGBColourValue.Interval = 250;

            _updateRGBColourValue.Tick += UpdateRGBColourValue_Tick;
            #endregion

            #region Update Selected Colour
            _updateSelectedColour.Enabled = true;

            _updateSelectedColour.Interval = 250;

            _updateSelectedColour.Tick += UpdateSelectedColour_Tick;
            #endregion

            #endregion
        }

        private void ColourWheelColourPickerDialog_Load(object sender, EventArgs e)
        {
            // Turn on double-buffering, so the form looks better. 
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);

            #region Regional Settings
            //if (CultureInfo.CurrentCulture == CultureInfo.CurrentCulture.)
            //{

            //}
            #endregion
        }

        #region Static Methods
        //public static DialogResult Show()
        //{
        //    // Temporary code
        //    return DialogResult.OK;
        //}
        #endregion

        #region Methods
        public bool IsSelectedColourNull()
        {
            //if (GetSelectedColour() != null)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return GetSelectedColour() != null;
        }
        private void RefreshValue(KryptonNumericUpDown target, int value)
        {
            if (target.Value != value)
            {
                target.Value = value;

                target.Refresh();
            }
        }

        private void SetARGB(ColourHandler.ARGB argb)
        {
            SetIsUpdating(true);

            RefreshValue(knumAlpha, argb.alpha);

            RefreshValue(knumRed, argb.red);

            RefreshValue(knumGreen, argb.green);

            RefreshValue(knumBlue, argb.blue);

            SetIsUpdating(false);

            kptxtHexColour.Text = ColorTranslator.ToHtml(Color.FromArgb(argb.alpha, argb.red, argb.green, argb.blue)).ToString();
        }

        private void SetRGB(ColourHandler.RGB rgb)
        {
            SetIsUpdating(true);

            RefreshValue(knumRed, rgb.Red);

            RefreshValue(knumGreen, rgb.Green);

            RefreshValue(knumBlue, rgb.Blue);

            SetIsUpdating(false);

            kptxtHexColour.Text = ColorTranslator.ToHtml(Color.FromArgb(rgb.Red, rgb.Green, rgb.Blue)).ToString();
        }

        private void SetHSV(ColourHandler.HSV hsv)
        {
            SetIsUpdating(true);

            RefreshValue(knumHue, hsv.Hue);

            RefreshValue(knumSaturation, hsv.Saturation);

            RefreshValue(knumBrightness, hsv.value);

            SetIsUpdating(false);
        }

        /// <summary>
        /// Shows the hsbui components.
        /// </summary>
        /// <param name="enabled">if set to <c>true</c> [enabled].</param>
        private void ShowHSBUIComponents(bool enabled)
        {
            klblHue.Visible = enabled;

            knumHue.Visible = enabled;

            klblSaturation.Visible = enabled;

            knumSaturation.Visible = enabled;

            klblBrightness.Visible = enabled;

            knumBrightness.Visible = enabled;
        }
        #endregion

        #region Event Handlers
        private void UpdateColour_Tick(object sender, EventArgs e)
        {
            cbSelectedColour.BackColor = cwColourSelector.Colour;

            RefreshValue(knumAlpha, cbSelectedColour.BackColor.A);

            RefreshValue(knumRed, cbSelectedColour.BackColor.R);

            RefreshValue(knumGreen, cbSelectedColour.BackColor.G);

            RefreshValue(knumBlue, cbSelectedColour.BackColor.B);

            kptxtHexColour.Text = ColorTranslator.ToHtml(cbSelectedColour.BackColor);

            _updateColour.Enabled = false;
        }

        private void UpdateHexadecimalColourValues_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UpdateHSBColourValues_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UpdateARGBColourValues_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UpdateRGBColourValue_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UpdateSelectedColour_Tick(object sender, EventArgs e)
        {
            if (cbSelectedColour.BackColor != null)
            {
                SetSelectedColour(cbSelectedColour.BackColor);
            }

            _updateSelectedColour.Stop();
        }

        private void kbtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Hide();
        }

        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Hide();
        }

        private void cbSelectedColour_BackColorChanged(object sender, EventArgs e)
        {
            _updateSelectedColour.Start();
        }

        private void cwColourSelector_ColourChanged(object sender, EventArgs e)
        {
            _updateColour.Enabled = true;
        }
        #endregion

        #region Setters and Getters
        private void SetIsUpdating(bool value) => IsUpdating = value;

        public bool GetIsUpdating() => IsUpdating;

        public void SetSelectedColour(Color colour) => SelectedColour = colour;

        public Color GetSelectedColour() => SelectedColour;
        #endregion
    }
}