using System.Drawing;
using ComponentFactory.Krypton.Toolkit;

namespace ExtendedColourControls
{
    public class KryptonColourButtonCustomColourDialog : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kryptonPanel1;
        private KryptonButton kbtnOk;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private Cyotek.Windows.Forms.ColorGrid cgColours;
        private ColourWheel cwColours;
        private KryptonToolkitSuiteExtendedCore.CircularPictureBox cpbSelectedColour;
        private KryptonTextBox ktbHexadecimalColourValue;
        private KryptonLabel kryptonLabel1;
        private KryptonAlphaValueNumericBox knumBrightness;
        private KryptonAlphaValueNumericBox knumHue;
        private KryptonAlphaValueNumericBox knumSaturation;
        private KryptonBlueValueNumericBox knumBlue;
        private KryptonGreenValueNumericBox knumGreen;
        private KryptonRedValueNumericBox knumRed;
        private KryptonAlphaValueNumericBox knumAlpha;
        private KryptonLabel kryptonLabel2;
        private Controls.Labels.KryptonBlueValueLabel kryptonBlueValueLabel1;
        private Controls.Labels.KryptonGreenValueLabel kryptonGreenValueLabel1;
        private Controls.Labels.KryptonRedValueLabel kryptonRedValueLabel1;
        private KryptonLabel kryptonLabel6;
        private KryptonLabel kryptonLabel5;
        private KryptonLabel kryptonLabel4;
        private KryptonLabel kryptonLabel3;
        private KryptonButton kbtnCancel;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cgColours = new Cyotek.Windows.Forms.ColorGrid();
            this.cwColours = new ExtendedColourControls.ColourWheel();
            this.cpbSelectedColour = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            this.ktbHexadecimalColourValue = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.knumAlpha = new ExtendedColourControls.KryptonAlphaValueNumericBox();
            this.knumRed = new ExtendedColourControls.KryptonRedValueNumericBox();
            this.knumGreen = new ExtendedColourControls.KryptonGreenValueNumericBox();
            this.knumBlue = new ExtendedColourControls.KryptonBlueValueNumericBox();
            this.knumHue = new ExtendedColourControls.KryptonAlphaValueNumericBox();
            this.knumSaturation = new ExtendedColourControls.KryptonAlphaValueNumericBox();
            this.knumBrightness = new ExtendedColourControls.KryptonAlphaValueNumericBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonRedValueLabel1 = new ExtendedColourControls.Controls.Labels.KryptonRedValueLabel();
            this.kryptonGreenValueLabel1 = new ExtendedColourControls.Controls.Labels.KryptonGreenValueLabel();
            this.kryptonBlueValueLabel1 = new ExtendedColourControls.Controls.Labels.KryptonBlueValueLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbSelectedColour)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnOk);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 395);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(611, 48);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kbtnOk
            // 
            this.kbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnOk.Location = new System.Drawing.Point(405, 8);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(94, 28);
            this.kbtnOk.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnOk.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnOk.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnOk.TabIndex = 1;
            this.kbtnOk.Values.Text = "&Ok";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(505, 8);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(94, 28);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnCancel.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnCancel.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnCancel.TabIndex = 0;
            this.kbtnCancel.Values.Text = "C&ancel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 3);
            this.panel1.TabIndex = 3;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonBlueValueLabel1);
            this.kryptonPanel2.Controls.Add(this.kryptonGreenValueLabel1);
            this.kryptonPanel2.Controls.Add(this.kryptonRedValueLabel1);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.knumBrightness);
            this.kryptonPanel2.Controls.Add(this.knumHue);
            this.kryptonPanel2.Controls.Add(this.knumSaturation);
            this.kryptonPanel2.Controls.Add(this.knumBlue);
            this.kryptonPanel2.Controls.Add(this.knumGreen);
            this.kryptonPanel2.Controls.Add(this.knumRed);
            this.kryptonPanel2.Controls.Add(this.knumAlpha);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.ktbHexadecimalColourValue);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Controls.Add(this.cpbSelectedColour);
            this.kryptonPanel2.Controls.Add(this.cwColours);
            this.kryptonPanel2.Controls.Add(this.cgColours);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(611, 392);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // cgColours
            // 
            this.cgColours.BackColor = System.Drawing.Color.Transparent;
            this.cgColours.Location = new System.Drawing.Point(12, 208);
            this.cgColours.Name = "cgColours";
            this.cgColours.Size = new System.Drawing.Size(247, 165);
            this.cgColours.TabIndex = 5;
            // 
            // cwColours
            // 
            this.cwColours.BackColor = System.Drawing.Color.Transparent;
            this.cwColours.Location = new System.Drawing.Point(12, 12);
            this.cwColours.Name = "cwColours";
            this.cwColours.Size = new System.Drawing.Size(247, 190);
            this.cwColours.TabIndex = 5;
            // 
            // cpbSelectedColour
            // 
            this.cpbSelectedColour.BackColor = System.Drawing.Color.Transparent;
            this.cpbSelectedColour.Location = new System.Drawing.Point(485, 12);
            this.cpbSelectedColour.Name = "cpbSelectedColour";
            this.cpbSelectedColour.Size = new System.Drawing.Size(114, 114);
            this.cpbSelectedColour.TabIndex = 5;
            this.cpbSelectedColour.TabStop = false;
            // 
            // ktbHexadecimalColourValue
            // 
            this.ktbHexadecimalColourValue.Hint = "#000000";
            this.ktbHexadecimalColourValue.Location = new System.Drawing.Point(423, 152);
            this.ktbHexadecimalColourValue.MaxLength = 7;
            this.ktbHexadecimalColourValue.Name = "ktbHexadecimalColourValue";
            this.ktbHexadecimalColourValue.Size = new System.Drawing.Size(176, 29);
            this.ktbHexadecimalColourValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktbHexadecimalColourValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktbHexadecimalColourValue.TabIndex = 87;
            this.ktbHexadecimalColourValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(245, 154);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(172, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 86;
            this.kryptonLabel1.Values.Text = "Hexadecimal Colour:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(341, 56);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(138, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 88;
            this.kryptonLabel2.Values.Text = "Selected Colour:";
            // 
            // knumAlpha
            // 
            this.knumAlpha.Location = new System.Drawing.Point(505, 208);
            this.knumAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumAlpha.Name = "knumAlpha";
            this.knumAlpha.Size = new System.Drawing.Size(94, 26);
            this.knumAlpha.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.knumAlpha.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.knumAlpha.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.knumAlpha.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumAlpha.TabIndex = 5;
            // 
            // knumRed
            // 
            this.knumRed.Location = new System.Drawing.Point(505, 249);
            this.knumRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumRed.Name = "knumRed";
            this.knumRed.Size = new System.Drawing.Size(94, 26);
            this.knumRed.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.knumRed.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumRed.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.knumRed.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumRed.TabIndex = 89;
            // 
            // knumGreen
            // 
            this.knumGreen.Location = new System.Drawing.Point(505, 294);
            this.knumGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumGreen.Name = "knumGreen";
            this.knumGreen.Size = new System.Drawing.Size(94, 26);
            this.knumGreen.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.knumGreen.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumGreen.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.knumGreen.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumGreen.TabIndex = 90;
            // 
            // knumBlue
            // 
            this.knumBlue.Location = new System.Drawing.Point(505, 336);
            this.knumBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumBlue.Name = "knumBlue";
            this.knumBlue.Size = new System.Drawing.Size(94, 26);
            this.knumBlue.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.knumBlue.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumBlue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.knumBlue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumBlue.TabIndex = 5;
            // 
            // knumHue
            // 
            this.knumHue.Location = new System.Drawing.Point(341, 249);
            this.knumHue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumHue.Name = "knumHue";
            this.knumHue.Size = new System.Drawing.Size(91, 26);
            this.knumHue.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.knumHue.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.knumHue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.knumHue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumHue.TabIndex = 91;
            // 
            // knumSaturation
            // 
            this.knumSaturation.Location = new System.Drawing.Point(341, 294);
            this.knumSaturation.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumSaturation.Name = "knumSaturation";
            this.knumSaturation.Size = new System.Drawing.Size(91, 26);
            this.knumSaturation.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.knumSaturation.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.knumSaturation.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.knumSaturation.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumSaturation.TabIndex = 92;
            // 
            // knumBrightness
            // 
            this.knumBrightness.Location = new System.Drawing.Point(341, 336);
            this.knumBrightness.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumBrightness.Name = "knumBrightness";
            this.knumBrightness.Size = new System.Drawing.Size(91, 26);
            this.knumBrightness.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.knumBrightness.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.knumBrightness.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.knumBrightness.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumBrightness.TabIndex = 93;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(306, 249);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(29, 26);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 94;
            this.kryptonLabel3.Values.Text = "H:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(306, 294);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(26, 26);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 95;
            this.kryptonLabel4.Values.Text = "S:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(306, 336);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(27, 26);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 96;
            this.kryptonLabel5.Values.Text = "B:";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(437, 208);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 97;
            this.kryptonLabel6.Values.Text = "Alpha:";
            // 
            // kryptonRedValueLabel1
            // 
            this.kryptonRedValueLabel1.Location = new System.Drawing.Point(453, 249);
            this.kryptonRedValueLabel1.Name = "kryptonRedValueLabel1";
            this.kryptonRedValueLabel1.RedValue = 255;
            this.kryptonRedValueLabel1.Size = new System.Drawing.Size(46, 26);
            this.kryptonRedValueLabel1.StateCommon.LongText.Color1 = System.Drawing.Color.Red;
            this.kryptonRedValueLabel1.StateCommon.LongText.Color2 = System.Drawing.Color.Red;
            this.kryptonRedValueLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonRedValueLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonRedValueLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Red;
            this.kryptonRedValueLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonRedValueLabel1.TabIndex = 5;
            this.kryptonRedValueLabel1.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonRedValueLabel1.Values.Text = "Red:";
            // 
            // kryptonGreenValueLabel1
            // 
            this.kryptonGreenValueLabel1.Location = new System.Drawing.Point(437, 294);
            this.kryptonGreenValueLabel1.Name = "kryptonGreenValueLabel1";
            this.kryptonGreenValueLabel1.RedValue = 255;
            this.kryptonGreenValueLabel1.Size = new System.Drawing.Size(62, 26);
            this.kryptonGreenValueLabel1.StateCommon.LongText.Color1 = System.Drawing.Color.Green;
            this.kryptonGreenValueLabel1.StateCommon.LongText.Color2 = System.Drawing.Color.Green;
            this.kryptonGreenValueLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonGreenValueLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Green;
            this.kryptonGreenValueLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Green;
            this.kryptonGreenValueLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonGreenValueLabel1.TabIndex = 5;
            this.kryptonGreenValueLabel1.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonGreenValueLabel1.Values.Text = "Green:";
            // 
            // kryptonBlueValueLabel1
            // 
            this.kryptonBlueValueLabel1.Location = new System.Drawing.Point(449, 336);
            this.kryptonBlueValueLabel1.Name = "kryptonBlueValueLabel1";
            this.kryptonBlueValueLabel1.RedValue = 255;
            this.kryptonBlueValueLabel1.Size = new System.Drawing.Size(50, 26);
            this.kryptonBlueValueLabel1.StateCommon.LongText.Color1 = System.Drawing.Color.Blue;
            this.kryptonBlueValueLabel1.StateCommon.LongText.Color2 = System.Drawing.Color.Blue;
            this.kryptonBlueValueLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonBlueValueLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Blue;
            this.kryptonBlueValueLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Blue;
            this.kryptonBlueValueLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonBlueValueLabel1.TabIndex = 5;
            this.kryptonBlueValueLabel1.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonBlueValueLabel1.Values.Text = "Blue:";
            // 
            // KryptonColourButtonCustomColourDialog
            // 
            this.ClientSize = new System.Drawing.Size(611, 443);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonColourButtonCustomColourDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbSelectedColour)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private Color _colour;
        #endregion

        #region Properties
        public Color Colour { get => _colour; set => _colour = value; }
        #endregion

        #region Constructors
        public KryptonColourButtonCustomColourDialog()
        {
            InitializeComponent();
        }

        public KryptonColourButtonCustomColourDialog(Color colour)
        {
            InitializeComponent();
        }
        #endregion
    }
}