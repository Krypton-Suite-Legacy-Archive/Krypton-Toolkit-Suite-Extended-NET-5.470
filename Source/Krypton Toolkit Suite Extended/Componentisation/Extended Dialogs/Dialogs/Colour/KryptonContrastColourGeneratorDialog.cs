using System;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace ExtendedDialogs
{
    public class KryptonContrastColourGeneratorDialog : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kryptonPanel1;
        private KryptonCheckBox kchkKeepOpacityValues;
        private KryptonCheckBox kchkAutomateColourContrastValues;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private KryptonButton kbtnUtiliseContrastColour;
        private KryptonButton kbtnUtiliseBaseColour;
        private KryptonButton kbtnContrastColourGenerateBlue;
        private KryptonButton kbtnContrastColourGenerateGreen;
        private KryptonButton kbtnContrastColourGenerateRed;
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
        private KryptonToolkitSuiteExtendedCore.CircularPictureBox cpbContrastColour;
        private KryptonToolkitSuiteExtendedCore.CircularPictureBox cpbBaseColour;
        private KryptonButton kbtnContrastColourGenerateAlpha;
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
            this.kbtnContrastColourGenerateBlue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnContrastColourGenerateGreen = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnContrastColourGenerateRed = new ComponentFactory.Krypton.Toolkit.KryptonButton();
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
            this.cpbBaseColour = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            this.cpbContrastColour = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            this.kbtnContrastColourGenerateAlpha = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbBaseColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpbContrastColour)).BeginInit();
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
            this.kchkKeepOpacityValues.TabIndex = 94;
            this.kchkKeepOpacityValues.Values.Text = "Keep &Opacity Values";
            this.kchkKeepOpacityValues.CheckedChanged += new System.EventHandler(this.KchkKeepOpacityValues_CheckedChanged);
            // 
            // kchkAutomateColourContrastValues
            // 
            this.kchkAutomateColourContrastValues.Location = new System.Drawing.Point(12, 14);
            this.kchkAutomateColourContrastValues.Name = "kchkAutomateColourContrastValues";
            this.kchkAutomateColourContrastValues.Size = new System.Drawing.Size(268, 26);
            this.kchkAutomateColourContrastValues.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kchkAutomateColourContrastValues.TabIndex = 93;
            this.kchkAutomateColourContrastValues.Values.Text = "&Automate Colour Contrast Values";
            this.kchkAutomateColourContrastValues.CheckedChanged += new System.EventHandler(this.KchkAutomateColourContrastValues_CheckedChanged);
            // 
            // kbtnOk
            // 
            this.kbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnOk.AutoSize = true;
            this.kbtnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnOk.Location = new System.Drawing.Point(839, 10);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(32, 30);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 92;
            this.kbtnOk.Values.Text = "&Ok";
            this.kbtnOk.Click += new System.EventHandler(this.KbtnOk_Click);
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
            this.kryptonPanel2.Controls.Add(this.kbtnContrastColourGenerateAlpha);
            this.kryptonPanel2.Controls.Add(this.cpbContrastColour);
            this.kryptonPanel2.Controls.Add(this.cpbBaseColour);
            this.kryptonPanel2.Controls.Add(this.kbtnUtiliseContrastColour);
            this.kryptonPanel2.Controls.Add(this.kbtnUtiliseBaseColour);
            this.kryptonPanel2.Controls.Add(this.kbtnContrastColourGenerateBlue);
            this.kryptonPanel2.Controls.Add(this.kbtnContrastColourGenerateGreen);
            this.kryptonPanel2.Controls.Add(this.kbtnContrastColourGenerateRed);
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
            this.kbtnUtiliseContrastColour.TabIndex = 93;
            this.kbtnUtiliseContrastColour.Values.Text = "Utilise &Contrast Colour for Palette";
            this.kbtnUtiliseContrastColour.Click += new System.EventHandler(this.KbtnUtiliseContrastColour_Click);
            // 
            // kbtnUtiliseBaseColour
            // 
            this.kbtnUtiliseBaseColour.AutoSize = true;
            this.kbtnUtiliseBaseColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnUtiliseBaseColour.Location = new System.Drawing.Point(57, 516);
            this.kbtnUtiliseBaseColour.Name = "kbtnUtiliseBaseColour";
            this.kbtnUtiliseBaseColour.Size = new System.Drawing.Size(227, 30);
            this.kbtnUtiliseBaseColour.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnUtiliseBaseColour.TabIndex = 92;
            this.kbtnUtiliseBaseColour.Values.Text = "Utilise &Base Colour for Palette";
            this.kbtnUtiliseBaseColour.Click += new System.EventHandler(this.KbtnUtiliseBaseColour_Click);
            // 
            // kbtnContrastColourGenerateBlue
            // 
            this.kbtnContrastColourGenerateBlue.AutoSize = true;
            this.kbtnContrastColourGenerateBlue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnContrastColourGenerateBlue.Location = new System.Drawing.Point(740, 480);
            this.kbtnContrastColourGenerateBlue.Name = "kbtnContrastColourGenerateBlue";
            this.kbtnContrastColourGenerateBlue.Size = new System.Drawing.Size(114, 30);
            this.kbtnContrastColourGenerateBlue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnContrastColourGenerateBlue.TabIndex = 91;
            this.kbtnContrastColourGenerateBlue.Values.Text = "Generate &Blue";
            this.kbtnContrastColourGenerateBlue.Click += new System.EventHandler(this.KbtnContrastColourGenerateBlue_Click);
            // 
            // kbtnContrastColourGenerateGreen
            // 
            this.kbtnContrastColourGenerateGreen.AutoSize = true;
            this.kbtnContrastColourGenerateGreen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnContrastColourGenerateGreen.Location = new System.Drawing.Point(740, 437);
            this.kbtnContrastColourGenerateGreen.Name = "kbtnContrastColourGenerateGreen";
            this.kbtnContrastColourGenerateGreen.Size = new System.Drawing.Size(126, 30);
            this.kbtnContrastColourGenerateGreen.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnContrastColourGenerateGreen.TabIndex = 90;
            this.kbtnContrastColourGenerateGreen.Values.Text = "Generate &Green";
            this.kbtnContrastColourGenerateGreen.Click += new System.EventHandler(this.KbtnContrastColourGenerateGreen_Click);
            // 
            // kbtnContrastColourGenerateRed
            // 
            this.kbtnContrastColourGenerateRed.AutoSize = true;
            this.kbtnContrastColourGenerateRed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnContrastColourGenerateRed.Location = new System.Drawing.Point(740, 393);
            this.kbtnContrastColourGenerateRed.Name = "kbtnContrastColourGenerateRed";
            this.kbtnContrastColourGenerateRed.Size = new System.Drawing.Size(111, 30);
            this.kbtnContrastColourGenerateRed.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnContrastColourGenerateRed.TabIndex = 89;
            this.kbtnContrastColourGenerateRed.Values.Text = "Generate &Red";
            this.kbtnContrastColourGenerateRed.Click += new System.EventHandler(this.KbtnContrastColourGenerateRed_Click);
            // 
            // kbtnGenerateBaseAlphaValue
            // 
            this.kbtnGenerateBaseAlphaValue.AutoSize = true;
            this.kbtnGenerateBaseAlphaValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateBaseAlphaValue.Location = new System.Drawing.Point(222, 348);
            this.kbtnGenerateBaseAlphaValue.Name = "kbtnGenerateBaseAlphaValue";
            this.kbtnGenerateBaseAlphaValue.Size = new System.Drawing.Size(125, 30);
            this.kbtnGenerateBaseAlphaValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateBaseAlphaValue.TabIndex = 88;
            this.kbtnGenerateBaseAlphaValue.Values.Text = "Generate &Alpha";
            this.kbtnGenerateBaseAlphaValue.Click += new System.EventHandler(this.KbtnGenerateBaseAlphaValue_Click);
            // 
            // kbtnInvertColours
            // 
            this.kbtnInvertColours.AutoSize = true;
            this.kbtnInvertColours.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnInvertColours.Location = new System.Drawing.Point(430, 173);
            this.kbtnInvertColours.Name = "kbtnInvertColours";
            this.kbtnInvertColours.Size = new System.Drawing.Size(36, 30);
            this.kbtnInvertColours.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnInvertColours.TabIndex = 87;
            this.kbtnInvertColours.Values.Text = "<&--";
            this.kbtnInvertColours.Click += new System.EventHandler(this.KbtnInvertColours_Click);
            // 
            // kbtnGenerateComplementaryColour
            // 
            this.kbtnGenerateComplementaryColour.AutoSize = true;
            this.kbtnGenerateComplementaryColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateComplementaryColour.Location = new System.Drawing.Point(430, 109);
            this.kbtnGenerateComplementaryColour.Name = "kbtnGenerateComplementaryColour";
            this.kbtnGenerateComplementaryColour.Size = new System.Drawing.Size(36, 30);
            this.kbtnGenerateComplementaryColour.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateComplementaryColour.TabIndex = 86;
            this.kbtnGenerateComplementaryColour.Values.Text = "--&>";
            this.kbtnGenerateComplementaryColour.Click += new System.EventHandler(this.KbtnGenerateComplementaryColour_Click);
            // 
            // kbtnGenerateBlueValue
            // 
            this.kbtnGenerateBlueValue.AutoSize = true;
            this.kbtnGenerateBlueValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateBlueValue.Location = new System.Drawing.Point(222, 480);
            this.kbtnGenerateBlueValue.Name = "kbtnGenerateBlueValue";
            this.kbtnGenerateBlueValue.Size = new System.Drawing.Size(114, 30);
            this.kbtnGenerateBlueValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateBlueValue.TabIndex = 85;
            this.kbtnGenerateBlueValue.Values.Text = "Generate &Blue";
            this.kbtnGenerateBlueValue.Click += new System.EventHandler(this.KbtnGenerateBlueValue_Click);
            // 
            // kbtnGenerateGreenValue
            // 
            this.kbtnGenerateGreenValue.AutoSize = true;
            this.kbtnGenerateGreenValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateGreenValue.Location = new System.Drawing.Point(222, 437);
            this.kbtnGenerateGreenValue.Name = "kbtnGenerateGreenValue";
            this.kbtnGenerateGreenValue.Size = new System.Drawing.Size(126, 30);
            this.kbtnGenerateGreenValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateGreenValue.TabIndex = 84;
            this.kbtnGenerateGreenValue.Values.Text = "Generate &Green";
            this.kbtnGenerateGreenValue.Click += new System.EventHandler(this.KbtnGenerateGreenValue_Click);
            // 
            // kbtnGenerateRedValue
            // 
            this.kbtnGenerateRedValue.AutoSize = true;
            this.kbtnGenerateRedValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateRedValue.Location = new System.Drawing.Point(222, 393);
            this.kbtnGenerateRedValue.Name = "kbtnGenerateRedValue";
            this.kbtnGenerateRedValue.Size = new System.Drawing.Size(111, 30);
            this.kbtnGenerateRedValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateRedValue.TabIndex = 83;
            this.kbtnGenerateRedValue.Values.Text = "Generate &Red";
            this.kbtnGenerateRedValue.Click += new System.EventHandler(this.KbtnGenerateRedValue_Click);
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
            this.kryptonLabel6.TabIndex = 77;
            this.kryptonLabel6.Values.Text = "Blue:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(546, 437);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 76;
            this.kryptonLabel7.Values.Text = "Green:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(546, 395);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(46, 26);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.kryptonLabel4.TabIndex = 69;
            this.kryptonLabel4.Values.Text = "Blue:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(28, 435);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 68;
            this.kryptonLabel3.Values.Text = "Green:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(28, 393);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(46, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 67;
            this.kryptonLabel2.Values.Text = "Red:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(633, 21);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(174, 33);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 66;
            this.kryptonLabel1.Values.Text = "Contrast Colour";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(96, 21);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(134, 33);
            this.kryptonLabel12.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel12.TabIndex = 64;
            this.kryptonLabel12.Values.Text = "Base Colour";
            // 
            // cpbBaseColour
            // 
            this.cpbBaseColour.BackColor = System.Drawing.SystemColors.Control;
            this.cpbBaseColour.Location = new System.Drawing.Point(28, 60);
            this.cpbBaseColour.Name = "cpbBaseColour";
            this.cpbBaseColour.Size = new System.Drawing.Size(285, 280);
            this.cpbBaseColour.TabIndex = 4;
            this.cpbBaseColour.TabStop = false;
            // 
            // cpbContrastColour
            // 
            this.cpbContrastColour.BackColor = System.Drawing.SystemColors.Control;
            this.cpbContrastColour.Location = new System.Drawing.Point(580, 60);
            this.cpbContrastColour.Name = "cpbContrastColour";
            this.cpbContrastColour.Size = new System.Drawing.Size(285, 280);
            this.cpbContrastColour.TabIndex = 5;
            this.cpbContrastColour.TabStop = false;
            // 
            // kbtnContrastColourGenerateAlpha
            // 
            this.kbtnContrastColourGenerateAlpha.AutoSize = true;
            this.kbtnContrastColourGenerateAlpha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnContrastColourGenerateAlpha.Location = new System.Drawing.Point(740, 348);
            this.kbtnContrastColourGenerateAlpha.Name = "kbtnContrastColourGenerateAlpha";
            this.kbtnContrastColourGenerateAlpha.Size = new System.Drawing.Size(125, 30);
            this.kbtnContrastColourGenerateAlpha.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnContrastColourGenerateAlpha.TabIndex = 94;
            this.kbtnContrastColourGenerateAlpha.Values.Text = "Generate &Alpha";
            this.kbtnContrastColourGenerateAlpha.Click += new System.EventHandler(this.KbtnContrastColourGenerateAlpha_Click);
            // 
            // KryptonContrastColourGeneratorDialog
            // 
            this.AcceptButton = this.kbtnOk;
            this.ClientSize = new System.Drawing.Size(883, 616);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonContrastColourGeneratorDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.KryptonContrastColourGeneratorDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbBaseColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpbContrastColour)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private bool _useForPalettes;

        private Color _baseColour, _contrastColour;

        private Timer _updateUI;
        #endregion

        #region Properties
        public bool UseForPalettes { get => _useForPalettes; set => _useForPalettes = value; }

        public Color BaseColour { get => _baseColour; set => _baseColour = value; }

        public Color ContrastColour { get => _contrastColour; set => _contrastColour = value; }
        #endregion

        #region Constructor
        public KryptonContrastColourGeneratorDialog()
        {
            InitializeComponent();
        }

        public KryptonContrastColourGeneratorDialog(bool useForPalettes)
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        private void KryptonContrastColourGeneratorDialog_Load(object sender, EventArgs e)
        {
            #region Timer
            _updateUI = new Timer();

            _updateUI.Enabled = true;

            _updateUI.Interval = 250;

            _updateUI.Tick += UpdateUI_Tick;
            #endregion
        }

        private void KbtnGenerateComplementaryColour_Click(object sender, EventArgs e)
        {

        }

        private void KbtnInvertColours_Click(object sender, EventArgs e)
        {

        }

        private void KbtnGenerateBaseAlphaValue_Click(object sender, EventArgs e)
        {

        }

        private void KbtnGenerateRedValue_Click(object sender, EventArgs e)
        {

        }

        private void KbtnGenerateGreenValue_Click(object sender, EventArgs e)
        {

        }

        private void KbtnGenerateBlueValue_Click(object sender, EventArgs e)
        {

        }

        private void KbtnContrastColourGenerateAlpha_Click(object sender, EventArgs e)
        {

        }

        private void KbtnContrastColourGenerateRed_Click(object sender, EventArgs e)
        {

        }

        private void KbtnContrastColourGenerateGreen_Click(object sender, EventArgs e)
        {

        }

        private void KbtnContrastColourGenerateBlue_Click(object sender, EventArgs e)
        {

        }

        private void KbtnUtiliseBaseColour_Click(object sender, EventArgs e)
        {

        }

        private void KbtnUtiliseContrastColour_Click(object sender, EventArgs e)
        {

        }

        private void KchkAutomateColourContrastValues_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void KchkKeepOpacityValues_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void KbtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Close();
        }

        private void UpdateUI_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}