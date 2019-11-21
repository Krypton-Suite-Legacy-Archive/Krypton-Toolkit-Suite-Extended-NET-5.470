using ComponentFactory.Krypton.Toolkit;
using PaletteExplorer.Classes;
using PaletteExplorer.Enumerations;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PaletteExplorer.UX.Colour
{
    public class ColourEditor : KryptonForm
    {
        #region Designer Code
        private KryptonLabel kryptonLabel10;
        private KryptonLabel kryptonLabel1;
        private KryptonLabel kryptonLabel9;
        private KryptonLabel kryptonLabel8;
        private KryptonTrackBar ktrkAlphaValue;
        private KryptonTrackBar ktrkBlueValue;
        private KryptonTrackBar ktrkGreenValue;
        private KryptonTrackBar ktrkRedValue;
        private KryptonNumericUpDown knudBlueChannelValue;
        private KryptonNumericUpDown knudGreenChannelValue;
        private KryptonNumericUpDown knudRedChannelValue;
        private KryptonNumericUpDown knumAlpaValue;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxColourSample;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cbxColourSample = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.ktrkBlueValue = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.ktrkGreenValue = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.ktrkRedValue = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.knudBlueChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knudGreenChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knudRedChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumAlpaValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.ktrkAlphaValue = new ComponentFactory.Krypton.Toolkit.KryptonTrackBar();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxColourSample)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.cbxColourSample);
            this.kryptonPanel1.Controls.Add(this.ktrkBlueValue);
            this.kryptonPanel1.Controls.Add(this.ktrkGreenValue);
            this.kryptonPanel1.Controls.Add(this.ktrkRedValue);
            this.kryptonPanel1.Controls.Add(this.knudBlueChannelValue);
            this.kryptonPanel1.Controls.Add(this.knudGreenChannelValue);
            this.kryptonPanel1.Controls.Add(this.knudRedChannelValue);
            this.kryptonPanel1.Controls.Add(this.knumAlpaValue);
            this.kryptonPanel1.Controls.Add(this.ktrkAlphaValue);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel10);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(841, 308);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // cbxColourSample
            // 
            this.cbxColourSample.BackColor = System.Drawing.Color.Black;
            this.cbxColourSample.Location = new System.Drawing.Point(583, 41);
            this.cbxColourSample.Name = "cbxColourSample";
            this.cbxColourSample.Size = new System.Drawing.Size(241, 226);
            this.cbxColourSample.TabIndex = 1;
            this.cbxColourSample.TabStop = false;
            this.cbxColourSample.BackColorChanged += new System.EventHandler(this.CbxColourSample_BackColorChanged);
            this.cbxColourSample.MouseEnter += new System.EventHandler(this.CbxColourSample_MouseEnter);
            // 
            // ktrkBlueValue
            // 
            this.ktrkBlueValue.DrawBackground = true;
            this.ktrkBlueValue.Location = new System.Drawing.Point(223, 234);
            this.ktrkBlueValue.Maximum = 255;
            this.ktrkBlueValue.Name = "ktrkBlueValue";
            this.ktrkBlueValue.Size = new System.Drawing.Size(340, 33);
            this.ktrkBlueValue.StateCommon.Tick.Color1 = System.Drawing.Color.Blue;
            this.ktrkBlueValue.StateCommon.Tick.Color2 = System.Drawing.Color.Blue;
            this.ktrkBlueValue.StateCommon.Tick.Color3 = System.Drawing.Color.Blue;
            this.ktrkBlueValue.StateCommon.Tick.Color4 = System.Drawing.Color.Blue;
            this.ktrkBlueValue.StateCommon.Tick.Color5 = System.Drawing.Color.Blue;
            this.ktrkBlueValue.StateCommon.Track.Color1 = System.Drawing.Color.Blue;
            this.ktrkBlueValue.StateCommon.Track.Color2 = System.Drawing.Color.Blue;
            this.ktrkBlueValue.StateCommon.Track.Color3 = System.Drawing.Color.Blue;
            this.ktrkBlueValue.StateCommon.Track.Color4 = System.Drawing.Color.Blue;
            this.ktrkBlueValue.StateCommon.Track.Color5 = System.Drawing.Color.Blue;
            this.ktrkBlueValue.TabIndex = 33;
            this.ktrkBlueValue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ktrkBlueValue.ValueChanged += new System.EventHandler(this.KtrkBlueValue_ValueChanged);
            // 
            // ktrkGreenValue
            // 
            this.ktrkGreenValue.DrawBackground = true;
            this.ktrkGreenValue.Location = new System.Drawing.Point(223, 172);
            this.ktrkGreenValue.Maximum = 255;
            this.ktrkGreenValue.Name = "ktrkGreenValue";
            this.ktrkGreenValue.Size = new System.Drawing.Size(340, 33);
            this.ktrkGreenValue.StateCommon.Tick.Color1 = System.Drawing.Color.Green;
            this.ktrkGreenValue.StateCommon.Tick.Color2 = System.Drawing.Color.Green;
            this.ktrkGreenValue.StateCommon.Tick.Color3 = System.Drawing.Color.Green;
            this.ktrkGreenValue.StateCommon.Tick.Color4 = System.Drawing.Color.Green;
            this.ktrkGreenValue.StateCommon.Tick.Color5 = System.Drawing.Color.Green;
            this.ktrkGreenValue.StateCommon.Track.Color1 = System.Drawing.Color.Green;
            this.ktrkGreenValue.StateCommon.Track.Color2 = System.Drawing.Color.Green;
            this.ktrkGreenValue.StateCommon.Track.Color3 = System.Drawing.Color.Green;
            this.ktrkGreenValue.StateCommon.Track.Color4 = System.Drawing.Color.Green;
            this.ktrkGreenValue.StateCommon.Track.Color5 = System.Drawing.Color.Green;
            this.ktrkGreenValue.TabIndex = 32;
            this.ktrkGreenValue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ktrkGreenValue.ValueChanged += new System.EventHandler(this.KtrkGreenValue_ValueChanged);
            // 
            // ktrkRedValue
            // 
            this.ktrkRedValue.DrawBackground = true;
            this.ktrkRedValue.Location = new System.Drawing.Point(223, 110);
            this.ktrkRedValue.Maximum = 255;
            this.ktrkRedValue.Name = "ktrkRedValue";
            this.ktrkRedValue.Size = new System.Drawing.Size(340, 33);
            this.ktrkRedValue.StateCommon.Tick.Color1 = System.Drawing.Color.Red;
            this.ktrkRedValue.StateCommon.Tick.Color2 = System.Drawing.Color.Red;
            this.ktrkRedValue.StateCommon.Tick.Color3 = System.Drawing.Color.Red;
            this.ktrkRedValue.StateCommon.Tick.Color4 = System.Drawing.Color.Red;
            this.ktrkRedValue.StateCommon.Tick.Color5 = System.Drawing.Color.Red;
            this.ktrkRedValue.StateCommon.Track.Color1 = System.Drawing.Color.Red;
            this.ktrkRedValue.StateCommon.Track.Color2 = System.Drawing.Color.Red;
            this.ktrkRedValue.StateCommon.Track.Color3 = System.Drawing.Color.Red;
            this.ktrkRedValue.StateCommon.Track.Color4 = System.Drawing.Color.Red;
            this.ktrkRedValue.StateCommon.Track.Color5 = System.Drawing.Color.Red;
            this.ktrkRedValue.TabIndex = 31;
            this.ktrkRedValue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ktrkRedValue.ValueChanged += new System.EventHandler(this.KtrkRedValue_ValueChanged);
            // 
            // knudBlueChannelValue
            // 
            this.knudBlueChannelValue.DecimalPlaces = 99;
            this.knudBlueChannelValue.Location = new System.Drawing.Point(97, 233);
            this.knudBlueChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knudBlueChannelValue.Name = "knudBlueChannelValue";
            this.knudBlueChannelValue.Size = new System.Drawing.Size(120, 32);
            this.knudBlueChannelValue.StateCommon.Content.Color1 = System.Drawing.Color.Blue;
            this.knudBlueChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knudBlueChannelValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.knudBlueChannelValue.TabIndex = 30;
            this.knudBlueChannelValue.ValueChanged += new System.EventHandler(this.KnudBlueChannelValue_ValueChanged);
            // 
            // knudGreenChannelValue
            // 
            this.knudGreenChannelValue.DecimalPlaces = 99;
            this.knudGreenChannelValue.Location = new System.Drawing.Point(97, 171);
            this.knudGreenChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knudGreenChannelValue.Name = "knudGreenChannelValue";
            this.knudGreenChannelValue.Size = new System.Drawing.Size(120, 32);
            this.knudGreenChannelValue.StateCommon.Content.Color1 = System.Drawing.Color.Green;
            this.knudGreenChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knudGreenChannelValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.knudGreenChannelValue.TabIndex = 29;
            this.knudGreenChannelValue.ValueChanged += new System.EventHandler(this.KnudGreenChannelValue_ValueChanged);
            // 
            // knudRedChannelValue
            // 
            this.knudRedChannelValue.DecimalPlaces = 99;
            this.knudRedChannelValue.Location = new System.Drawing.Point(97, 109);
            this.knudRedChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knudRedChannelValue.Name = "knudRedChannelValue";
            this.knudRedChannelValue.Size = new System.Drawing.Size(120, 32);
            this.knudRedChannelValue.StateCommon.Content.Color1 = System.Drawing.Color.Red;
            this.knudRedChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knudRedChannelValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.knudRedChannelValue.TabIndex = 28;
            this.knudRedChannelValue.ValueChanged += new System.EventHandler(this.KnudRedChannelValue_ValueChanged);
            // 
            // knumAlpaValue
            // 
            this.knumAlpaValue.DecimalPlaces = 99;
            this.knumAlpaValue.Location = new System.Drawing.Point(97, 42);
            this.knumAlpaValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumAlpaValue.Name = "knumAlpaValue";
            this.knumAlpaValue.Size = new System.Drawing.Size(120, 32);
            this.knumAlpaValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumAlpaValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.knumAlpaValue.TabIndex = 27;
            this.knumAlpaValue.ValueChanged += new System.EventHandler(this.KnumAlpaValue_ValueChanged);
            // 
            // ktrkAlphaValue
            // 
            this.ktrkAlphaValue.DrawBackground = true;
            this.ktrkAlphaValue.Location = new System.Drawing.Point(223, 41);
            this.ktrkAlphaValue.Maximum = 255;
            this.ktrkAlphaValue.Name = "ktrkAlphaValue";
            this.ktrkAlphaValue.Size = new System.Drawing.Size(340, 33);
            this.ktrkAlphaValue.TabIndex = 25;
            this.ktrkAlphaValue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ktrkAlphaValue.ValueChanged += new System.EventHandler(this.KtrkAlphaValue_ValueChanged);
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(12, 110);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(59, 33);
            this.kryptonLabel10.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 24;
            this.kryptonLabel10.Values.Text = "Red:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 41);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(79, 33);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 21;
            this.kryptonLabel1.Values.Text = "Alpha:";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(12, 172);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(80, 33);
            this.kryptonLabel9.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 23;
            this.kryptonLabel9.Values.Text = "Green:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(12, 234);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(64, 33);
            this.kryptonLabel8.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 22;
            this.kryptonLabel8.Values.Text = "Blue:";
            // 
            // ColourEditor
            // 
            this.ClientSize = new System.Drawing.Size(841, 308);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ColourEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColourEditor_FormClosing);
            this.Load += new System.EventHandler(this.ColourEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxColourSample)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private bool _viewable;

        private Color _colour = Color.Empty;

        private int _alphaValue, _redValue, _greenValue, _blueValue;

        private Timer _colourUpdateTimer = new Timer();

        private ToolTip _trackBarToolTip = new ToolTip();
        #endregion

        #region Property
        public bool Viewable { get => _viewable; set => _viewable = value; }

        public Color Colour { get => _colour; set => _colour = value; }

        public int AlphaValue { get => _alphaValue; set => _alphaValue = value; }

        public int RedValue { get => _redValue; set => _redValue = value; }

        public int GreenValue { get => _greenValue; set => _greenValue = value; }

        public int BlueValue { get => _blueValue; set => _blueValue = value; }
        #endregion

        #region Constructor
        public ColourEditor()
        {
            InitializeComponent();
        }

        public ColourEditor(Color colour)
        {
            InitializeComponent();

            UpdateUI(colour);
        }
        #endregion

        #region Event Handlers
        private void ColourEditor_Load(object sender, EventArgs e)
        {

        }

        private void ColourEditor_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void KnumAlpaValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KnudRedChannelValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KnudGreenChannelValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KnudBlueChannelValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KtrkAlphaValue_ValueChanged(object sender, EventArgs e)
        {
            ShowToolTip(ktrkAlphaValue, ColourChannelType.ALPHACHANNEL, ktrkAlphaValue.Value);

            SetAlphaValue(ktrkAlphaValue.Value);

            cbxColourSample.BackColor = CreateNewColour(GetRedValue(), GetGreenValue(), GetBlueValue(), GetAlphaValue());
        }

        private void KtrkRedValue_ValueChanged(object sender, EventArgs e)
        {
            ShowToolTip(ktrkRedValue, ColourChannelType.REDCHANNEL, ktrkRedValue.Value);

            SetRedValue(ktrkRedValue.Value);

            cbxColourSample.BackColor = CreateNewColour(GetRedValue(), GetGreenValue(), GetBlueValue(), GetAlphaValue());
        }

        private void KtrkGreenValue_ValueChanged(object sender, EventArgs e)
        {
            ShowToolTip(ktrkGreenValue, ColourChannelType.GREENCHANNEL, ktrkGreenValue.Value);

            SetGreenValue(ktrkGreenValue.Value);

            cbxColourSample.BackColor = CreateNewColour(GetRedValue(), GetGreenValue(), GetBlueValue(), GetAlphaValue());
        }

        private void KtrkBlueValue_ValueChanged(object sender, EventArgs e)
        {
            ShowToolTip(ktrkBlueValue, ColourChannelType.BLUECHANNEL, ktrkBlueValue.Value);

            SetBlueValue(ktrkBlueValue.Value);

            cbxColourSample.BackColor = CreateNewColour(GetRedValue(), GetGreenValue(), GetBlueValue(), GetAlphaValue());
        }

        private void CbxColourSample_BackColorChanged(object sender, EventArgs e)
        {
            SetColour(cbxColourSample.BackColor);
        }

        private void CbxColourSample_MouseEnter(object sender, EventArgs e)
        {
            UserInterfaceManager.DisplayToolTipInformation(cbxColourSample, cbxColourSample.BackColor, "Colour Sample", true);
        }
        #endregion

        #region Methods
        private Color CreateNewColour(int red, int green, int blue, int alpha = 255)
        {
            return Color.FromArgb(alpha, red, green, blue);
        }

        /// <summary>
        /// Updates the UI.
        /// </summary>
        /// <param name="colour">The colour.</param>
        private void UpdateUI(Color colour)
        {
            cbxColourSample.BackColor = colour;

            knumAlpaValue.Value = colour.A;

            knudRedChannelValue.Value = colour.R;

            knudGreenChannelValue.Value = colour.G;

            knudBlueChannelValue.Value = colour.B;

            ktrkAlphaValue.Value = colour.A;

            ktrkRedValue.Value = colour.R;

            ktrkGreenValue.Value = colour.G;

            ktrkBlueValue.Value = colour.B;
        }

        /// <summary>
        /// Shows the tool tip.
        /// </summary>
        /// <param name="trackBar">The track bar.</param>
        /// <param name="channelType">Type of the channel.</param>
        /// <param name="value">The value.</param>
        private void ShowToolTip(KryptonTrackBar trackBar, ColourChannelType channelType, int value)
        {
            switch (channelType)
            {
                case ColourChannelType.ALPHACHANNEL:
                    _trackBarToolTip.SetToolTip(trackBar, $"Alpha Value: { value }");
                    break;
                case ColourChannelType.REDCHANNEL:
                    _trackBarToolTip.SetToolTip(trackBar, $"Red Value: { value }");
                    break;
                case ColourChannelType.GREENCHANNEL:
                    _trackBarToolTip.SetToolTip(trackBar, $"Green Value: { value }");
                    break;
                case ColourChannelType.BLUECHANNEL:
                    _trackBarToolTip.SetToolTip(trackBar, $"Blue Value: { value }");
                    break;
            }
        }
        #endregion

        #region Setters and Getters

        #region Booleans
        /// <summary>
        /// Sets the Viewable.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetViewable(bool value) => Viewable = value;

        /// <summary>
        /// Gets the Viewable.
        /// </summary>
        /// <returns>The value of Viewable.</returns>
        public bool GetViewable() => Viewable;
        #endregion

        #region Colour
        /// <summary>
        /// Sets the Colour.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetColour(Color value) => Colour = value;

        /// <summary>
        /// Gets the Colour.
        /// </summary>
        /// <returns>The value of Colour.</returns>
        public Color GetColour() => Colour;
        #endregion

        #region Integers
        /// <summary>
        /// Sets the AlphaValue.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetAlphaValue(int value) => AlphaValue = value;

        /// <summary>
        /// Gets the AlphaValue.
        /// </summary>
        /// <returns>The value of AlphaValue.</returns>
        public int GetAlphaValue() => AlphaValue;

        /// <summary>
        /// Sets the RedValue.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetRedValue(int value) => RedValue = value;

        /// <summary>
        /// Gets the RedValue.
        /// </summary>
        /// <returns>The value of RedValue.</returns>
        public int GetRedValue() => RedValue;

        /// <summary>
        /// Sets the GreenValue.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetGreenValue(int value) => GreenValue = value;

        /// <summary>
        /// Gets the GreenValue.
        /// </summary>
        /// <returns>The value of GreenValue.</returns>
        public int GetGreenValue() => GreenValue;

        /// <summary>
        /// Sets the BlueValue.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetBlueValue(int value) => BlueValue = value;

        /// <summary>
        /// Gets the BlueValue.
        /// </summary>
        /// <returns>The value of BlueValue.</returns>
        public int GetBlueValue() => BlueValue;
        #endregion

        #endregion

        #region Overrides        
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.VisibleChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            SetViewable(Visible);
        }
        #endregion
    }
}