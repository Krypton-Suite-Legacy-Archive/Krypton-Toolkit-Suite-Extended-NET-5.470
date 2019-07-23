using ComponentFactory.Krypton.Toolkit;

namespace ExtendedDialogs
{
    public class KryptonContrastColourGeneratorDialog : KryptonForm
    {
        private KryptonPanel kryptonPanel1;
        private KryptonCheckBox kchkKeepOpacityValues;
        private KryptonCheckBox kchkAutomateColourContrastValues;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private KryptonButton kbtnUtiliseContrastColour;
        private KryptonButton kbtnUtiliseBaseColour;
        private KryptonButton kryptonButton1;
        private KryptonButton kryptonButton3;
        private KryptonButton kryptonButton4;
        private KryptonButton kbtnGenerateBaseAlphaValue;
        private KryptonButton kbtnInvertColours;
        private KryptonButton kbtnGenerateComplementaryColour;
        private KryptonButton kbtnGenerateBlueValue;
        private KryptonButton kbtnGenerateGreenValue;
        private KryptonButton kbtnGenerateRedValue;
        private KryptonNumericUpDown knumContrastAlphaChannelValue;
        private KryptonLabel kryptonLabel5;
        private KryptonNumericUpDown knumContrastBlueChannelValue;
        private KryptonNumericUpDown knumContrastGreenChannelValue;
        private KryptonNumericUpDown knumContrastRedChannelValue;
        private KryptonLabel kryptonLabel6;
        private KryptonLabel kryptonLabel7;
        private KryptonLabel kryptonLabel8;
        private KryptonNumericUpDown knumBaseAlphaChannelValue;
        private KryptonLabel kryptonLabel10;
        private KryptonNumericUpDown knumBaseBlueChannelValue;
        private KryptonNumericUpDown knumBaseGreenChannelValue;
        private KryptonNumericUpDown knumBaseRedChannelValue;
        private KryptonLabel kryptonLabel4;
        private KryptonLabel kryptonLabel3;
        private KryptonLabel kryptonLabel2;
        private KryptonLabel kryptonLabel1;
        private KryptonLabel kryptonLabel12;
        private KryptonButton kbtnOk;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kchkKeepOpacityValues = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kchkAutomateColourContrastValues = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnUtiliseContrastColour = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnUtiliseBaseColour = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGenerateBaseAlphaValue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnInvertColours = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGenerateComplementaryColour = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGenerateBlueValue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGenerateGreenValue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGenerateRedValue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.knumContrastAlphaChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.knumContrastBlueChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumContrastGreenChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumContrastRedChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.knumBaseAlphaChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.knumBaseBlueChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumBaseGreenChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumBaseRedChannelValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kchkKeepOpacityValues);
            this.kryptonPanel1.Controls.Add(this.kchkAutomateColourContrastValues);
            this.kryptonPanel1.Controls.Add(this.kbtnOk);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 564);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(883, 52);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kchkKeepOpacityValues
            // 
            this.kchkKeepOpacityValues.Location = new System.Drawing.Point(286, 14);
            this.kchkKeepOpacityValues.Name = "kchkKeepOpacityValues";
            this.kchkKeepOpacityValues.Size = new System.Drawing.Size(174, 26);
            this.kchkKeepOpacityValues.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kchkKeepOpacityValues.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kchkKeepOpacityValues.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kchkKeepOpacityValues.TabIndex = 94;
            this.kchkKeepOpacityValues.Values.Text = "Keep &Opacity Values";
            // 
            // kchkAutomateColourContrastValues
            // 
            this.kchkAutomateColourContrastValues.Location = new System.Drawing.Point(12, 14);
            this.kchkAutomateColourContrastValues.Name = "kchkAutomateColourContrastValues";
            this.kchkAutomateColourContrastValues.Size = new System.Drawing.Size(268, 26);
            this.kchkAutomateColourContrastValues.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kchkAutomateColourContrastValues.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kchkAutomateColourContrastValues.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kchkAutomateColourContrastValues.TabIndex = 93;
            this.kchkAutomateColourContrastValues.Values.Text = "&Automate Colour Contrast Values";
            // 
            // kbtnOk
            // 
            this.kbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnOk.AutoSize = true;
            this.kbtnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnOk.Location = new System.Drawing.Point(839, 10);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(32, 30);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnOk.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnOk.TabIndex = 92;
            this.kbtnOk.Values.Text = "&Ok";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 561);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 3);
            this.panel1.TabIndex = 2;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kbtnUtiliseContrastColour);
            this.kryptonPanel2.Controls.Add(this.kbtnUtiliseBaseColour);
            this.kryptonPanel2.Controls.Add(this.kryptonButton1);
            this.kryptonPanel2.Controls.Add(this.kryptonButton3);
            this.kryptonPanel2.Controls.Add(this.kryptonButton4);
            this.kryptonPanel2.Controls.Add(this.kbtnGenerateBaseAlphaValue);
            this.kryptonPanel2.Controls.Add(this.kbtnInvertColours);
            this.kryptonPanel2.Controls.Add(this.kbtnGenerateComplementaryColour);
            this.kryptonPanel2.Controls.Add(this.kbtnGenerateBlueValue);
            this.kryptonPanel2.Controls.Add(this.kbtnGenerateGreenValue);
            this.kryptonPanel2.Controls.Add(this.kbtnGenerateRedValue);
            this.kryptonPanel2.Controls.Add(this.knumContrastAlphaChannelValue);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel2.Controls.Add(this.knumContrastBlueChannelValue);
            this.kryptonPanel2.Controls.Add(this.knumContrastGreenChannelValue);
            this.kryptonPanel2.Controls.Add(this.knumContrastRedChannelValue);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel2.Controls.Add(this.knumBaseAlphaChannelValue);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel10);
            this.kryptonPanel2.Controls.Add(this.knumBaseBlueChannelValue);
            this.kryptonPanel2.Controls.Add(this.knumBaseGreenChannelValue);
            this.kryptonPanel2.Controls.Add(this.knumBaseRedChannelValue);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel12);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(883, 561);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // kbtnUtiliseContrastColour
            // 
            this.kbtnUtiliseContrastColour.AutoSize = true;
            this.kbtnUtiliseContrastColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnUtiliseContrastColour.Location = new System.Drawing.Point(580, 516);
            this.kbtnUtiliseContrastColour.Name = "kbtnUtiliseContrastColour";
            this.kbtnUtiliseContrastColour.Size = new System.Drawing.Size(255, 30);
            this.kbtnUtiliseContrastColour.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnUtiliseContrastColour.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnUtiliseContrastColour.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnUtiliseContrastColour.TabIndex = 93;
            this.kbtnUtiliseContrastColour.Values.Text = "Utilise &Contrast Colour for Palette";
            // 
            // kbtnUtiliseBaseColour
            // 
            this.kbtnUtiliseBaseColour.AutoSize = true;
            this.kbtnUtiliseBaseColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnUtiliseBaseColour.Location = new System.Drawing.Point(57, 516);
            this.kbtnUtiliseBaseColour.Name = "kbtnUtiliseBaseColour";
            this.kbtnUtiliseBaseColour.Size = new System.Drawing.Size(227, 30);
            this.kbtnUtiliseBaseColour.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnUtiliseBaseColour.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnUtiliseBaseColour.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnUtiliseBaseColour.TabIndex = 92;
            this.kbtnUtiliseBaseColour.Values.Text = "Utilise &Base Colour for Palette";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.AutoSize = true;
            this.kryptonButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonButton1.Location = new System.Drawing.Point(740, 480);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(114, 30);
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton1.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonButton1.TabIndex = 91;
            this.kryptonButton1.Values.Text = "Generate &Blue";
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.AutoSize = true;
            this.kryptonButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonButton3.Location = new System.Drawing.Point(740, 437);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(126, 30);
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton3.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonButton3.TabIndex = 90;
            this.kryptonButton3.Values.Text = "Generate &Green";
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.AutoSize = true;
            this.kryptonButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonButton4.Location = new System.Drawing.Point(740, 393);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Size = new System.Drawing.Size(111, 30);
            this.kryptonButton4.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton4.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton4.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonButton4.TabIndex = 89;
            this.kryptonButton4.Values.Text = "Generate &Red";
            // 
            // kbtnGenerateBaseAlphaValue
            // 
            this.kbtnGenerateBaseAlphaValue.AutoSize = true;
            this.kbtnGenerateBaseAlphaValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateBaseAlphaValue.Location = new System.Drawing.Point(222, 348);
            this.kbtnGenerateBaseAlphaValue.Name = "kbtnGenerateBaseAlphaValue";
            this.kbtnGenerateBaseAlphaValue.Size = new System.Drawing.Size(125, 30);
            this.kbtnGenerateBaseAlphaValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateBaseAlphaValue.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnGenerateBaseAlphaValue.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnGenerateBaseAlphaValue.TabIndex = 88;
            this.kbtnGenerateBaseAlphaValue.Values.Text = "Generate &Alpha";
            // 
            // kbtnInvertColours
            // 
            this.kbtnInvertColours.AutoSize = true;
            this.kbtnInvertColours.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnInvertColours.Location = new System.Drawing.Point(430, 173);
            this.kbtnInvertColours.Name = "kbtnInvertColours";
            this.kbtnInvertColours.Size = new System.Drawing.Size(36, 30);
            this.kbtnInvertColours.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnInvertColours.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnInvertColours.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnInvertColours.TabIndex = 87;
            this.kbtnInvertColours.Values.Text = "<&--";
            // 
            // kbtnGenerateComplementaryColour
            // 
            this.kbtnGenerateComplementaryColour.AutoSize = true;
            this.kbtnGenerateComplementaryColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateComplementaryColour.Location = new System.Drawing.Point(430, 109);
            this.kbtnGenerateComplementaryColour.Name = "kbtnGenerateComplementaryColour";
            this.kbtnGenerateComplementaryColour.Size = new System.Drawing.Size(36, 30);
            this.kbtnGenerateComplementaryColour.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateComplementaryColour.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnGenerateComplementaryColour.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnGenerateComplementaryColour.TabIndex = 86;
            this.kbtnGenerateComplementaryColour.Values.Text = "--&>";
            // 
            // kbtnGenerateBlueValue
            // 
            this.kbtnGenerateBlueValue.AutoSize = true;
            this.kbtnGenerateBlueValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateBlueValue.Location = new System.Drawing.Point(222, 480);
            this.kbtnGenerateBlueValue.Name = "kbtnGenerateBlueValue";
            this.kbtnGenerateBlueValue.Size = new System.Drawing.Size(114, 30);
            this.kbtnGenerateBlueValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateBlueValue.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnGenerateBlueValue.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnGenerateBlueValue.TabIndex = 85;
            this.kbtnGenerateBlueValue.Values.Text = "Generate &Blue";
            // 
            // kbtnGenerateGreenValue
            // 
            this.kbtnGenerateGreenValue.AutoSize = true;
            this.kbtnGenerateGreenValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateGreenValue.Location = new System.Drawing.Point(222, 437);
            this.kbtnGenerateGreenValue.Name = "kbtnGenerateGreenValue";
            this.kbtnGenerateGreenValue.Size = new System.Drawing.Size(126, 30);
            this.kbtnGenerateGreenValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateGreenValue.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnGenerateGreenValue.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnGenerateGreenValue.TabIndex = 84;
            this.kbtnGenerateGreenValue.Values.Text = "Generate &Green";
            // 
            // kbtnGenerateRedValue
            // 
            this.kbtnGenerateRedValue.AutoSize = true;
            this.kbtnGenerateRedValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateRedValue.Location = new System.Drawing.Point(222, 393);
            this.kbtnGenerateRedValue.Name = "kbtnGenerateRedValue";
            this.kbtnGenerateRedValue.Size = new System.Drawing.Size(111, 30);
            this.kbtnGenerateRedValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateRedValue.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kbtnGenerateRedValue.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kbtnGenerateRedValue.TabIndex = 83;
            this.kbtnGenerateRedValue.Values.Text = "Generate &Red";
            // 
            // knumContrastAlphaChannelValue
            // 
            this.knumContrastAlphaChannelValue.Location = new System.Drawing.Point(614, 348);
            this.knumContrastAlphaChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumContrastAlphaChannelValue.Name = "knumContrastAlphaChannelValue";
            this.knumContrastAlphaChannelValue.Size = new System.Drawing.Size(120, 28);
            this.knumContrastAlphaChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumContrastAlphaChannelValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumContrastAlphaChannelValue.TabIndex = 82;
            this.knumContrastAlphaChannelValue.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(546, 348);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel5.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel5.TabIndex = 81;
            this.kryptonLabel5.Values.Text = "Alpha:";
            // 
            // knumContrastBlueChannelValue
            // 
            this.knumContrastBlueChannelValue.Location = new System.Drawing.Point(614, 480);
            this.knumContrastBlueChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumContrastBlueChannelValue.Name = "knumContrastBlueChannelValue";
            this.knumContrastBlueChannelValue.Size = new System.Drawing.Size(120, 28);
            this.knumContrastBlueChannelValue.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.knumContrastBlueChannelValue.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumContrastBlueChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumContrastBlueChannelValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumContrastBlueChannelValue.TabIndex = 80;
            // 
            // knumContrastGreenChannelValue
            // 
            this.knumContrastGreenChannelValue.Location = new System.Drawing.Point(614, 437);
            this.knumContrastGreenChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumContrastGreenChannelValue.Name = "knumContrastGreenChannelValue";
            this.knumContrastGreenChannelValue.Size = new System.Drawing.Size(120, 28);
            this.knumContrastGreenChannelValue.StateCommon.Back.Color1 = System.Drawing.Color.Lime;
            this.knumContrastGreenChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumContrastGreenChannelValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumContrastGreenChannelValue.TabIndex = 79;
            // 
            // knumContrastRedChannelValue
            // 
            this.knumContrastRedChannelValue.Location = new System.Drawing.Point(614, 393);
            this.knumContrastRedChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumContrastRedChannelValue.Name = "knumContrastRedChannelValue";
            this.knumContrastRedChannelValue.Size = new System.Drawing.Size(120, 28);
            this.knumContrastRedChannelValue.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.knumContrastRedChannelValue.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumContrastRedChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumContrastRedChannelValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumContrastRedChannelValue.TabIndex = 78;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(546, 482);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(50, 26);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel6.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel6.TabIndex = 77;
            this.kryptonLabel6.Values.Text = "Blue:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(546, 437);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel7.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel7.TabIndex = 76;
            this.kryptonLabel7.Values.Text = "Green:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(546, 395);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(46, 26);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel8.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel8.TabIndex = 75;
            this.kryptonLabel8.Values.Text = "Red:";
            // 
            // knumBaseAlphaChannelValue
            // 
            this.knumBaseAlphaChannelValue.Location = new System.Drawing.Point(96, 346);
            this.knumBaseAlphaChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumBaseAlphaChannelValue.Name = "knumBaseAlphaChannelValue";
            this.knumBaseAlphaChannelValue.Size = new System.Drawing.Size(120, 28);
            this.knumBaseAlphaChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumBaseAlphaChannelValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumBaseAlphaChannelValue.TabIndex = 74;
            this.knumBaseAlphaChannelValue.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(28, 346);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel10.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel10.TabIndex = 73;
            this.kryptonLabel10.Values.Text = "Alpha:";
            // 
            // knumBaseBlueChannelValue
            // 
            this.knumBaseBlueChannelValue.Location = new System.Drawing.Point(96, 478);
            this.knumBaseBlueChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumBaseBlueChannelValue.Name = "knumBaseBlueChannelValue";
            this.knumBaseBlueChannelValue.Size = new System.Drawing.Size(120, 28);
            this.knumBaseBlueChannelValue.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.knumBaseBlueChannelValue.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumBaseBlueChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumBaseBlueChannelValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumBaseBlueChannelValue.TabIndex = 72;
            // 
            // knumBaseGreenChannelValue
            // 
            this.knumBaseGreenChannelValue.Location = new System.Drawing.Point(96, 435);
            this.knumBaseGreenChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumBaseGreenChannelValue.Name = "knumBaseGreenChannelValue";
            this.knumBaseGreenChannelValue.Size = new System.Drawing.Size(120, 28);
            this.knumBaseGreenChannelValue.StateCommon.Back.Color1 = System.Drawing.Color.Lime;
            this.knumBaseGreenChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumBaseGreenChannelValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumBaseGreenChannelValue.TabIndex = 71;
            // 
            // knumBaseRedChannelValue
            // 
            this.knumBaseRedChannelValue.Location = new System.Drawing.Point(96, 391);
            this.knumBaseRedChannelValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumBaseRedChannelValue.Name = "knumBaseRedChannelValue";
            this.knumBaseRedChannelValue.Size = new System.Drawing.Size(120, 28);
            this.knumBaseRedChannelValue.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.knumBaseRedChannelValue.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.knumBaseRedChannelValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumBaseRedChannelValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.knumBaseRedChannelValue.TabIndex = 70;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(28, 480);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(50, 26);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel4.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel4.TabIndex = 69;
            this.kryptonLabel4.Values.Text = "Blue:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(28, 435);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel3.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel3.TabIndex = 68;
            this.kryptonLabel3.Values.Text = "Green:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(28, 393);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(46, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel2.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel2.TabIndex = 67;
            this.kryptonLabel2.Values.Text = "Red:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(633, 21);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(174, 33);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel1.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel1.TabIndex = 66;
            this.kryptonLabel1.Values.Text = "Contrast Colour";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(82, 21);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(134, 33);
            this.kryptonLabel12.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel12.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel12.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel12.TabIndex = 64;
            this.kryptonLabel12.Values.Text = "Base Colour";
            // 
            // KryptonContrastColourGeneratorDialog
            // 
            this.ClientSize = new System.Drawing.Size(883, 616);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "KryptonContrastColourGeneratorDialog";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}