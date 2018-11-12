using ComponentFactory.Krypton.Toolkit;
using System;
using Tooling.Settings.Classes;

namespace Tooling.UX.Options
{
    public partial class ColourBlendingOptions : KryptonForm
    {
        #region Variables
        ColourBlendingSettingsManager _colourBlendingSettingsManager = new ColourBlendingSettingsManager();

        GlobalBooleanSettingsManager _globalBooleanSettingsManager = new GlobalBooleanSettingsManager();
        #endregion

        #region System
        private KryptonButton kbtnResetValues;
        private KryptonButton kbtnOk;
        private KryptonButton kbtnCancel;
        private KryptonButton kbtnApply;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private KryptonButton kbtnLightestColourIntensityValuePlus;
        private KryptonButton kbtnLightestColourIntensityValueMinus;
        private KryptonButton kbtLightColourIntensityValuePlus;
        private KryptonButton kbtnLightColourIntensityValueMinus;
        private KryptonButton kbtnMiddleColourIntensityValuePlus;
        private KryptonButton kbtnMiddleColourIntensityValueMinus;
        private KryptonButton kbnDarkestColourIntensityValuePlus;
        private KryptonButton kbtnDarkColourIntensityValueMinus;
        private KryptonLabel kryptonLabel8;
        private KryptonLabel kryptonLabel7;
        private KryptonLabel kryptonLabel6;
        private KryptonLabel kryptonLabel5;
        private KryptonNumericUpDown knumLightestColourIntensityValue;
        private KryptonNumericUpDown knumLightColourIntensityValue;
        private KryptonNumericUpDown knumMiddleColourIntensityValue;
        private KryptonNumericUpDown knumDarkColourIntensityValue;
        private KryptonLabel kryptonLabel4;
        private KryptonLabel kryptonLabel3;
        private KryptonLabel kryptonLabel2;
        private KryptonLabel kryptonLabel1;
        private KryptonLabel klblLightestColourIntensityValueOutput;
        private KryptonLabel klblLightColourIntensityValueOutput;
        private KryptonLabel klblMiddleColourIntensityValueOutput;
        private KryptonLabel klblDarkColourIntensityValueOutput;
        private KryptonCheckBox kchkAutomaticallyUpdateValues;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxLightestColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxLightColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxMediumColourPreview;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxDarkColourPreview;
        private KryptonColorButton kcbBaseColour;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnResetValues = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnApply = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kchkAutomaticallyUpdateValues = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.klblLightestColourIntensityValueOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblLightColourIntensityValueOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblMiddleColourIntensityValueOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblDarkColourIntensityValueOutput = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnLightestColourIntensityValuePlus = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnLightestColourIntensityValueMinus = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtLightColourIntensityValuePlus = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnLightColourIntensityValueMinus = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnMiddleColourIntensityValuePlus = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnMiddleColourIntensityValueMinus = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbnDarkestColourIntensityValuePlus = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnDarkColourIntensityValueMinus = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.knumLightestColourIntensityValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumLightColourIntensityValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumMiddleColourIntensityValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumDarkColourIntensityValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbxDarkColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxMediumColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxLightColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxLightestColourPreview = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.kcbBaseColour = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDarkColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMediumColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLightColourPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLightestColourPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnResetValues);
            this.kryptonPanel1.Controls.Add(this.kbtnOk);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Controls.Add(this.kbtnApply);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 399);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(664, 53);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnResetValues
            // 
            this.kbtnResetValues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kbtnResetValues.AutoSize = true;
            this.kbtnResetValues.Enabled = false;
            this.kbtnResetValues.Location = new System.Drawing.Point(12, 11);
            this.kbtnResetValues.Name = "kbtnResetValues";
            this.kbtnResetValues.Size = new System.Drawing.Size(144, 30);
            this.kbtnResetValues.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnResetValues.TabIndex = 1;
            this.kbtnResetValues.Values.Text = "Re&set Values";
            // 
            // kbtnOk
            // 
            this.kbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnOk.AutoSize = true;
            this.kbtnOk.Location = new System.Drawing.Point(370, 11);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(90, 30);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 2;
            this.kbtnOk.Values.Text = "&Ok";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.AutoSize = true;
            this.kbtnCancel.Location = new System.Drawing.Point(466, 11);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(90, 30);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 3;
            this.kbtnCancel.Values.Text = "Ca&ncel";
            // 
            // kbtnApply
            // 
            this.kbtnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnApply.AutoSize = true;
            this.kbtnApply.Enabled = false;
            this.kbtnApply.Location = new System.Drawing.Point(562, 11);
            this.kbtnApply.Name = "kbtnApply";
            this.kbtnApply.Size = new System.Drawing.Size(90, 30);
            this.kbtnApply.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnApply.TabIndex = 0;
            this.kbtnApply.Values.Text = "&Apply";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 2);
            this.panel1.TabIndex = 1;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kcbBaseColour);
            this.kryptonPanel2.Controls.Add(this.cbxLightestColourPreview);
            this.kryptonPanel2.Controls.Add(this.cbxLightColourPreview);
            this.kryptonPanel2.Controls.Add(this.cbxMediumColourPreview);
            this.kryptonPanel2.Controls.Add(this.cbxDarkColourPreview);
            this.kryptonPanel2.Controls.Add(this.kchkAutomaticallyUpdateValues);
            this.kryptonPanel2.Controls.Add(this.klblLightestColourIntensityValueOutput);
            this.kryptonPanel2.Controls.Add(this.klblLightColourIntensityValueOutput);
            this.kryptonPanel2.Controls.Add(this.klblMiddleColourIntensityValueOutput);
            this.kryptonPanel2.Controls.Add(this.klblDarkColourIntensityValueOutput);
            this.kryptonPanel2.Controls.Add(this.kbtnLightestColourIntensityValuePlus);
            this.kryptonPanel2.Controls.Add(this.kbtnLightestColourIntensityValueMinus);
            this.kryptonPanel2.Controls.Add(this.kbtLightColourIntensityValuePlus);
            this.kryptonPanel2.Controls.Add(this.kbtnLightColourIntensityValueMinus);
            this.kryptonPanel2.Controls.Add(this.kbtnMiddleColourIntensityValuePlus);
            this.kryptonPanel2.Controls.Add(this.kbtnMiddleColourIntensityValueMinus);
            this.kryptonPanel2.Controls.Add(this.kbnDarkestColourIntensityValuePlus);
            this.kryptonPanel2.Controls.Add(this.kbtnDarkColourIntensityValueMinus);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel2.Controls.Add(this.knumLightestColourIntensityValue);
            this.kryptonPanel2.Controls.Add(this.knumLightColourIntensityValue);
            this.kryptonPanel2.Controls.Add(this.knumMiddleColourIntensityValue);
            this.kryptonPanel2.Controls.Add(this.knumDarkColourIntensityValue);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(664, 397);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // kchkAutomaticallyUpdateValues
            // 
            this.kchkAutomaticallyUpdateValues.Location = new System.Drawing.Point(12, 361);
            this.kchkAutomaticallyUpdateValues.Name = "kchkAutomaticallyUpdateValues";
            this.kchkAutomaticallyUpdateValues.Size = new System.Drawing.Size(234, 26);
            this.kchkAutomaticallyUpdateValues.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kchkAutomaticallyUpdateValues.TabIndex = 27;
            this.kchkAutomaticallyUpdateValues.Values.Text = "&Automatically Update Values";
            // 
            // klblLightestColourIntensityValueOutput
            // 
            this.klblLightestColourIntensityValueOutput.Location = new System.Drawing.Point(425, 297);
            this.klblLightestColourIntensityValueOutput.Name = "klblLightestColourIntensityValueOutput";
            this.klblLightestColourIntensityValueOutput.Size = new System.Drawing.Size(98, 26);
            this.klblLightestColourIntensityValueOutput.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblLightestColourIntensityValueOutput.TabIndex = 26;
            this.klblLightestColourIntensityValueOutput.Values.Text = "Output: {0}";
            // 
            // klblLightColourIntensityValueOutput
            // 
            this.klblLightColourIntensityValueOutput.Location = new System.Drawing.Point(425, 202);
            this.klblLightColourIntensityValueOutput.Name = "klblLightColourIntensityValueOutput";
            this.klblLightColourIntensityValueOutput.Size = new System.Drawing.Size(98, 26);
            this.klblLightColourIntensityValueOutput.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblLightColourIntensityValueOutput.TabIndex = 25;
            this.klblLightColourIntensityValueOutput.Values.Text = "Output: {0}";
            // 
            // klblMiddleColourIntensityValueOutput
            // 
            this.klblMiddleColourIntensityValueOutput.Location = new System.Drawing.Point(425, 107);
            this.klblMiddleColourIntensityValueOutput.Name = "klblMiddleColourIntensityValueOutput";
            this.klblMiddleColourIntensityValueOutput.Size = new System.Drawing.Size(98, 26);
            this.klblMiddleColourIntensityValueOutput.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblMiddleColourIntensityValueOutput.TabIndex = 24;
            this.klblMiddleColourIntensityValueOutput.Values.Text = "Output: {0}";
            // 
            // klblDarkColourIntensityValueOutput
            // 
            this.klblDarkColourIntensityValueOutput.Location = new System.Drawing.Point(425, 12);
            this.klblDarkColourIntensityValueOutput.Name = "klblDarkColourIntensityValueOutput";
            this.klblDarkColourIntensityValueOutput.Size = new System.Drawing.Size(98, 26);
            this.klblDarkColourIntensityValueOutput.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblDarkColourIntensityValueOutput.TabIndex = 23;
            this.klblDarkColourIntensityValueOutput.Values.Text = "Output: {0}";
            // 
            // kbtnLightestColourIntensityValuePlus
            // 
            this.kbtnLightestColourIntensityValuePlus.AutoSize = true;
            this.kbtnLightestColourIntensityValuePlus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnLightestColourIntensityValuePlus.Location = new System.Drawing.Point(378, 293);
            this.kbtnLightestColourIntensityValuePlus.Name = "kbtnLightestColourIntensityValuePlus";
            this.kbtnLightestColourIntensityValuePlus.Size = new System.Drawing.Size(23, 30);
            this.kbtnLightestColourIntensityValuePlus.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnLightestColourIntensityValuePlus.TabIndex = 22;
            this.kbtnLightestColourIntensityValuePlus.Values.Text = "+";
            this.kbtnLightestColourIntensityValuePlus.Click += new System.EventHandler(this.kbtnLightestColourIntensityValuePlus_Click);
            // 
            // kbtnLightestColourIntensityValueMinus
            // 
            this.kbtnLightestColourIntensityValueMinus.AutoSize = true;
            this.kbtnLightestColourIntensityValueMinus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnLightestColourIntensityValueMinus.Location = new System.Drawing.Point(342, 293);
            this.kbtnLightestColourIntensityValueMinus.Name = "kbtnLightestColourIntensityValueMinus";
            this.kbtnLightestColourIntensityValueMinus.Size = new System.Drawing.Size(18, 30);
            this.kbtnLightestColourIntensityValueMinus.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnLightestColourIntensityValueMinus.TabIndex = 21;
            this.kbtnLightestColourIntensityValueMinus.Values.Text = "-";
            this.kbtnLightestColourIntensityValueMinus.Click += new System.EventHandler(this.kbtnLightestColourIntensityValueMinus_Click);
            // 
            // kbtLightColourIntensityValuePlus
            // 
            this.kbtLightColourIntensityValuePlus.AutoSize = true;
            this.kbtLightColourIntensityValuePlus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtLightColourIntensityValuePlus.Location = new System.Drawing.Point(378, 198);
            this.kbtLightColourIntensityValuePlus.Name = "kbtLightColourIntensityValuePlus";
            this.kbtLightColourIntensityValuePlus.Size = new System.Drawing.Size(23, 30);
            this.kbtLightColourIntensityValuePlus.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtLightColourIntensityValuePlus.TabIndex = 20;
            this.kbtLightColourIntensityValuePlus.Values.Text = "+";
            this.kbtLightColourIntensityValuePlus.Click += new System.EventHandler(this.kbtLightColourIntensityValuePlus_Click);
            // 
            // kbtnLightColourIntensityValueMinus
            // 
            this.kbtnLightColourIntensityValueMinus.AutoSize = true;
            this.kbtnLightColourIntensityValueMinus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnLightColourIntensityValueMinus.Location = new System.Drawing.Point(342, 198);
            this.kbtnLightColourIntensityValueMinus.Name = "kbtnLightColourIntensityValueMinus";
            this.kbtnLightColourIntensityValueMinus.Size = new System.Drawing.Size(18, 30);
            this.kbtnLightColourIntensityValueMinus.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnLightColourIntensityValueMinus.TabIndex = 19;
            this.kbtnLightColourIntensityValueMinus.Values.Text = "-";
            this.kbtnLightColourIntensityValueMinus.Click += new System.EventHandler(this.kbtnLightColourIntensityValueMinus_Click);
            // 
            // kbtnMiddleColourIntensityValuePlus
            // 
            this.kbtnMiddleColourIntensityValuePlus.AutoSize = true;
            this.kbtnMiddleColourIntensityValuePlus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnMiddleColourIntensityValuePlus.Location = new System.Drawing.Point(378, 103);
            this.kbtnMiddleColourIntensityValuePlus.Name = "kbtnMiddleColourIntensityValuePlus";
            this.kbtnMiddleColourIntensityValuePlus.Size = new System.Drawing.Size(23, 30);
            this.kbtnMiddleColourIntensityValuePlus.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnMiddleColourIntensityValuePlus.TabIndex = 18;
            this.kbtnMiddleColourIntensityValuePlus.Values.Text = "+";
            this.kbtnMiddleColourIntensityValuePlus.Click += new System.EventHandler(this.kbtnMiddleColourIntensityValuePlus_Click);
            // 
            // kbtnMiddleColourIntensityValueMinus
            // 
            this.kbtnMiddleColourIntensityValueMinus.AutoSize = true;
            this.kbtnMiddleColourIntensityValueMinus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnMiddleColourIntensityValueMinus.Location = new System.Drawing.Point(342, 103);
            this.kbtnMiddleColourIntensityValueMinus.Name = "kbtnMiddleColourIntensityValueMinus";
            this.kbtnMiddleColourIntensityValueMinus.Size = new System.Drawing.Size(18, 30);
            this.kbtnMiddleColourIntensityValueMinus.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnMiddleColourIntensityValueMinus.TabIndex = 17;
            this.kbtnMiddleColourIntensityValueMinus.Values.Text = "-";
            this.kbtnMiddleColourIntensityValueMinus.Click += new System.EventHandler(this.kbtnMiddleColourIntensityValueMinus_Click);
            // 
            // kbnDarkestColourIntensityValuePlus
            // 
            this.kbnDarkestColourIntensityValuePlus.AutoSize = true;
            this.kbnDarkestColourIntensityValuePlus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbnDarkestColourIntensityValuePlus.Location = new System.Drawing.Point(378, 12);
            this.kbnDarkestColourIntensityValuePlus.Name = "kbnDarkestColourIntensityValuePlus";
            this.kbnDarkestColourIntensityValuePlus.Size = new System.Drawing.Size(23, 30);
            this.kbnDarkestColourIntensityValuePlus.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbnDarkestColourIntensityValuePlus.TabIndex = 16;
            this.kbnDarkestColourIntensityValuePlus.Values.Text = "+";
            this.kbnDarkestColourIntensityValuePlus.Click += new System.EventHandler(this.kbnDarkestColourIntensityValuePlus_Click);
            // 
            // kbtnDarkColourIntensityValueMinus
            // 
            this.kbtnDarkColourIntensityValueMinus.AutoSize = true;
            this.kbtnDarkColourIntensityValueMinus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnDarkColourIntensityValueMinus.Location = new System.Drawing.Point(342, 12);
            this.kbtnDarkColourIntensityValueMinus.Name = "kbtnDarkColourIntensityValueMinus";
            this.kbtnDarkColourIntensityValueMinus.Size = new System.Drawing.Size(18, 30);
            this.kbtnDarkColourIntensityValueMinus.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnDarkColourIntensityValueMinus.TabIndex = 15;
            this.kbtnDarkColourIntensityValueMinus.Values.Text = "-";
            this.kbtnDarkColourIntensityValueMinus.Click += new System.EventHandler(this.kbtnDarkColourIntensityValueMinus_Click);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(310, 297);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(26, 26);
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 14;
            this.kryptonLabel8.Values.Text = "%";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(310, 202);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(26, 26);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 13;
            this.kryptonLabel7.Values.Text = "%";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(310, 107);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(26, 26);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 12;
            this.kryptonLabel6.Values.Text = "%";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(310, 12);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(26, 26);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 11;
            this.kryptonLabel5.Values.Text = "%";
            // 
            // knumLightestColourIntensityValue
            // 
            this.knumLightestColourIntensityValue.DecimalPlaces = 2;
            this.knumLightestColourIntensityValue.Location = new System.Drawing.Point(222, 297);
            this.knumLightestColourIntensityValue.Name = "knumLightestColourIntensityValue";
            this.knumLightestColourIntensityValue.Size = new System.Drawing.Size(82, 28);
            this.knumLightestColourIntensityValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumLightestColourIntensityValue.TabIndex = 10;
            this.knumLightestColourIntensityValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.knumLightestColourIntensityValue.ValueChanged += new System.EventHandler(this.knumLightestColourIntensityValue_ValueChanged);
            // 
            // knumLightColourIntensityValue
            // 
            this.knumLightColourIntensityValue.DecimalPlaces = 2;
            this.knumLightColourIntensityValue.Location = new System.Drawing.Point(222, 200);
            this.knumLightColourIntensityValue.Name = "knumLightColourIntensityValue";
            this.knumLightColourIntensityValue.Size = new System.Drawing.Size(82, 28);
            this.knumLightColourIntensityValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumLightColourIntensityValue.TabIndex = 9;
            this.knumLightColourIntensityValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.knumLightColourIntensityValue.ValueChanged += new System.EventHandler(this.knumLightColourIntensityValue_ValueChanged);
            // 
            // knumMiddleColourIntensityValue
            // 
            this.knumMiddleColourIntensityValue.DecimalPlaces = 2;
            this.knumMiddleColourIntensityValue.Location = new System.Drawing.Point(222, 105);
            this.knumMiddleColourIntensityValue.Name = "knumMiddleColourIntensityValue";
            this.knumMiddleColourIntensityValue.Size = new System.Drawing.Size(82, 28);
            this.knumMiddleColourIntensityValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumMiddleColourIntensityValue.TabIndex = 8;
            this.knumMiddleColourIntensityValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.knumMiddleColourIntensityValue.ValueChanged += new System.EventHandler(this.knumMiddleColourIntensityValue_ValueChanged);
            // 
            // knumDarkColourIntensityValue
            // 
            this.knumDarkColourIntensityValue.DecimalPlaces = 2;
            this.knumDarkColourIntensityValue.Location = new System.Drawing.Point(222, 12);
            this.knumDarkColourIntensityValue.Name = "knumDarkColourIntensityValue";
            this.knumDarkColourIntensityValue.Size = new System.Drawing.Size(82, 28);
            this.knumDarkColourIntensityValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumDarkColourIntensityValue.TabIndex = 7;
            this.knumDarkColourIntensityValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.knumDarkColourIntensityValue.ValueChanged += new System.EventHandler(this.knumDarkColourIntensityValue_ValueChanged);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 297);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(207, 26);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 6;
            this.kryptonLabel4.Values.Text = "Lightest Colour Intensity:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 202);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(184, 26);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 5;
            this.kryptonLabel3.Values.Text = "Light Colour Intensity:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 107);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(199, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Middle Colour Intensity:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(204, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Darkest Colour Intensity:";
            // 
            // cbxDarkColourPreview
            // 
            this.cbxDarkColourPreview.BackColor = System.Drawing.Color.Black;
            this.cbxDarkColourPreview.Location = new System.Drawing.Point(562, 12);
            this.cbxDarkColourPreview.Name = "cbxDarkColourPreview";
            this.cbxDarkColourPreview.Size = new System.Drawing.Size(32, 32);
            this.cbxDarkColourPreview.TabIndex = 28;
            this.cbxDarkColourPreview.TabStop = false;
            // 
            // cbxMediumColourPreview
            // 
            this.cbxMediumColourPreview.BackColor = System.Drawing.Color.Black;
            this.cbxMediumColourPreview.Location = new System.Drawing.Point(562, 105);
            this.cbxMediumColourPreview.Name = "cbxMediumColourPreview";
            this.cbxMediumColourPreview.Size = new System.Drawing.Size(32, 32);
            this.cbxMediumColourPreview.TabIndex = 29;
            this.cbxMediumColourPreview.TabStop = false;
            // 
            // cbxLightColourPreview
            // 
            this.cbxLightColourPreview.BackColor = System.Drawing.Color.Black;
            this.cbxLightColourPreview.Location = new System.Drawing.Point(562, 198);
            this.cbxLightColourPreview.Name = "cbxLightColourPreview";
            this.cbxLightColourPreview.Size = new System.Drawing.Size(32, 32);
            this.cbxLightColourPreview.TabIndex = 30;
            this.cbxLightColourPreview.TabStop = false;
            // 
            // cbxLightestColourPreview
            // 
            this.cbxLightestColourPreview.BackColor = System.Drawing.Color.Black;
            this.cbxLightestColourPreview.Location = new System.Drawing.Point(562, 293);
            this.cbxLightestColourPreview.Name = "cbxLightestColourPreview";
            this.cbxLightestColourPreview.Size = new System.Drawing.Size(32, 32);
            this.cbxLightestColourPreview.TabIndex = 31;
            this.cbxLightestColourPreview.TabStop = false;
            // 
            // kcbBaseColour
            // 
            this.kcbBaseColour.AutoSize = true;
            this.kcbBaseColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kcbBaseColour.Location = new System.Drawing.Point(425, 357);
            this.kcbBaseColour.Name = "kcbBaseColour";
            this.kcbBaseColour.Size = new System.Drawing.Size(199, 30);
            this.kcbBaseColour.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbBaseColour.TabIndex = 32;
            this.kcbBaseColour.Values.Text = "&Choose a Base Colour";
            // 
            // ColourBlendingOptions
            // 
            this.ClientSize = new System.Drawing.Size(664, 452);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColourBlendingOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Colour Blending Options";
            this.Load += new System.EventHandler(this.ColourBlendingOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDarkColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMediumColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLightColourPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLightestColourPreview)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Constructors
        public ColourBlendingOptions()
        {
            InitializeComponent();
        }
        #endregion

        private void ColourBlendingOptions_Load(object sender, EventArgs e)
        {
            InitialiseWindow();
        }

        private void knumDarkColourIntensityValue_ValueChanged(object sender, EventArgs e)
        {
            UpdateFeedback(klblDarkColourIntensityValueOutput, knumDarkColourIntensityValue.Value);
        }

        private void knumMiddleColourIntensityValue_ValueChanged(object sender, EventArgs e)
        {
            SetApplyButton(true);
        }

        private void knumLightColourIntensityValue_ValueChanged(object sender, EventArgs e)
        {
            SetApplyButton(true);
        }

        private void knumLightestColourIntensityValue_ValueChanged(object sender, EventArgs e)
        {
            SetApplyButton(true);
        }

        private void kbtnDarkColourIntensityValueMinus_Click(object sender, EventArgs e)
        {
            knumDarkColourIntensityValue.Increment = -1;
        }

        private void kbtnMiddleColourIntensityValueMinus_Click(object sender, EventArgs e)
        {
            knumMiddleColourIntensityValue.Increment = -1;
        }

        private void kbtnLightColourIntensityValueMinus_Click(object sender, EventArgs e)
        {
            knumLightColourIntensityValue.Increment = -1;
        }

        private void kbtnLightestColourIntensityValueMinus_Click(object sender, EventArgs e)
        {
            knumLightestColourIntensityValue.Increment = -1;
        }

        private void kbnDarkestColourIntensityValuePlus_Click(object sender, EventArgs e)
        {
            knumDarkColourIntensityValue.Increment = knumDarkColourIntensityValue.Value + 1;
        }

        private void kbtnMiddleColourIntensityValuePlus_Click(object sender, EventArgs e)
        {
            knumMiddleColourIntensityValue.Increment = knumMiddleColourIntensityValue.Value + 1;
        }

        private void kbtLightColourIntensityValuePlus_Click(object sender, EventArgs e)
        {
            knumLightColourIntensityValue.Increment = knumLightColourIntensityValue.Value + 1;
        }

        private void kbtnLightestColourIntensityValuePlus_Click(object sender, EventArgs e)
        {
            knumLightestColourIntensityValue.Increment = knumLightestColourIntensityValue.Value + 1;
        }

        #region Methods
        private void UpdateFeedback(KryptonLabel output, decimal intensityPercentage)
        {
            float temp = Decimal.ToSingle(intensityPercentage);

            output.Text = $"Output: { temp.ToString() }";
        }

        private void SetApplyButton(bool enabled)
        {
            kbtnApply.Enabled = enabled;
        }

        private void InitialiseWindow()
        {
            knumDarkColourIntensityValue.Value = (decimal)_colourBlendingSettingsManager.GetDarkestColourIntensity();

            knumMiddleColourIntensityValue.Value = (decimal)_colourBlendingSettingsManager.GetMediumColourIntensity();

            knumLightColourIntensityValue.Value = (decimal)_colourBlendingSettingsManager.GetLightColourIntensity();

            knumLightestColourIntensityValue.Value = (decimal)_colourBlendingSettingsManager.GetLightestColourIntensity();

            kchkAutomaticallyUpdateValues.Checked = _globalBooleanSettingsManager.GetAutomaticallyUpdateColours();
        }
        #endregion
    }
}