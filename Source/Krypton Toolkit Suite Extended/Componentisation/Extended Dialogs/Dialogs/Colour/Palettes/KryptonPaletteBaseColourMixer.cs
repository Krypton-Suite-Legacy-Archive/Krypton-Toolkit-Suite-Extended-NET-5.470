#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ExtendedColourControls;

namespace ExtendedDialogs
{
    public class KryptonPaletteBaseColourMixer : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private KryptonLabel kryptonLabel15;
        private KryptonLabel kryptonLabel12;
        private KryptonLabel kryptonLabel13;
        private KryptonLabel kryptonLabel14;
        private KryptonLabel kryptonLabel16;
        private KryptonToolkitSuiteExtendedCore.CircularPictureBox cpbBaseColour;
        private KryptonToolkitSuiteExtendedCore.CircularPictureBox cpbLightestColour;
        private KryptonToolkitSuiteExtendedCore.CircularPictureBox cpbLightColour;
        private KryptonToolkitSuiteExtendedCore.CircularPictureBox cpbMiddleColour;
        private KryptonToolkitSuiteExtendedCore.CircularPictureBox cpbDarkestColour;
        private KryptonLabel kryptonLabel10;
        private KryptonLabel kryptonLabel4;
        private KryptonLabel kryptonLabel3;
        private KryptonLabel kryptonLabel2;
        private ExtendedColourControls.KryptonAlphaTrackBar kryptonAlphaTrackBar;
        private ExtendedColourControls.KryptonRedTrackBar kryptonRedTrackBar;
        private ExtendedColourControls.KryptonGreenTrackBar kryptonGreenTrackBar;
        private ExtendedColourControls.KryptonBlueTrackBar kryptonBlueTrackBar;
        private ExtendedColourControls.KryptonAlphaValueNumericBox kryptonAlphaValueNumericBox;
        private ExtendedColourControls.KryptonRedValueNumericBox kryptonRedValueNumericBox;
        private ExtendedColourControls.KryptonGreenValueNumericBox kryptonGreenValueNumericBox;
        private ExtendedColourControls.KryptonBlueValueNumericBox kryptonBlueValueNumericBox;
        private KryptonGroupBox kryptonGroupBox1;
        private KryptonButton kbtnGenerateAlpha;
        private KryptonButton kbtnGenerateRedValue;
        private KryptonButton kbtnGenerateGreenValue;
        private KryptonButton kbtnGenerateBlueValue;
        private KryptonComboBox kcmbDefinedColour;
        private KryptonButton kbtnExportSelectedColour;
        private KryptonButton kbtnOk;
        private KryptonButton kbtnChangeSelectedColour;
        private KryptonGroupBox kryptonGroupBox2;
        private KryptonTextBox ktxtHexValue;
        private ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel kryptonAlphaValueLabel6;
        private KryptonButton kbtnMoreColourOptions;
        private System.ComponentModel.IContainer components;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonPaletteBaseColourMixer));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ktxtHexValue = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonAlphaValueLabel6 = new ExtendedColourControls.Controls.Labels.KryptonAlphaValueLabel();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kcmbDefinedColour = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kbtnChangeSelectedColour = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnExportSelectedColour = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kbtnGenerateAlpha = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGenerateRedValue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGenerateGreenValue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGenerateBlueValue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonAlphaValueNumericBox = new ExtendedColourControls.KryptonAlphaValueNumericBox();
            this.kryptonRedValueNumericBox = new ExtendedColourControls.KryptonRedValueNumericBox();
            this.kryptonGreenValueNumericBox = new ExtendedColourControls.KryptonGreenValueNumericBox();
            this.kryptonBlueValueNumericBox = new ExtendedColourControls.KryptonBlueValueNumericBox();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel16 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel15 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cpbBaseColour = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            this.cpbLightestColour = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            this.cpbLightColour = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            this.cpbMiddleColour = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            this.cpbDarkestColour = new KryptonToolkitSuiteExtendedCore.CircularPictureBox();
            this.kryptonAlphaTrackBar = new ExtendedColourControls.KryptonAlphaTrackBar();
            this.kryptonRedTrackBar = new ExtendedColourControls.KryptonRedTrackBar();
            this.kryptonGreenTrackBar = new ExtendedColourControls.KryptonGreenTrackBar();
            this.kryptonBlueTrackBar = new ExtendedColourControls.KryptonBlueTrackBar();
            this.kbtnMoreColourOptions = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbDefinedColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbBaseColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpbLightestColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpbLightColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpbMiddleColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpbDarkestColour)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.ktxtHexValue);
            this.kryptonPanel1.Controls.Add(this.kryptonAlphaValueLabel6);
            this.kryptonPanel1.Controls.Add(this.kbtnOk);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 590);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(798, 45);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // ktxtHexValue
            // 
            this.ktxtHexValue.Hint = "#000000";
            this.ktxtHexValue.Location = new System.Drawing.Point(194, 7);
            this.ktxtHexValue.MaxLength = 7;
            this.ktxtHexValue.Name = "ktxtHexValue";
            this.ktxtHexValue.ReadOnly = true;
            this.ktxtHexValue.Size = new System.Drawing.Size(100, 29);
            this.ktxtHexValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktxtHexValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtHexValue.TabIndex = 104;
            this.ktxtHexValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonAlphaValueLabel6
            // 
            this.kryptonAlphaValueLabel6.AlphaValue = 255;
            this.kryptonAlphaValueLabel6.Location = new System.Drawing.Point(24, 10);
            this.kryptonAlphaValueLabel6.Name = "kryptonAlphaValueLabel6";
            this.kryptonAlphaValueLabel6.Size = new System.Drawing.Size(164, 26);
            this.kryptonAlphaValueLabel6.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel6.TabIndex = 103;
            this.kryptonAlphaValueLabel6.TextSize = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonAlphaValueLabel6.Values.Text = "Hexadecimal Value:";
            // 
            // kbtnOk
            // 
            this.kbtnOk.AutoSize = true;
            this.kbtnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnOk.Location = new System.Drawing.Point(754, 6);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(32, 30);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 102;
            this.kbtnOk.Values.Text = "&Ok";
            this.kbtnOk.Click += new System.EventHandler(this.KbtnOk_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 587);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 3);
            this.panel1.TabIndex = 1;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel2.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel2.Controls.Add(this.kryptonAlphaValueNumericBox);
            this.kryptonPanel2.Controls.Add(this.kryptonRedValueNumericBox);
            this.kryptonPanel2.Controls.Add(this.kryptonGreenValueNumericBox);
            this.kryptonPanel2.Controls.Add(this.kryptonBlueValueNumericBox);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel10);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel16);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel15);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel12);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel13);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel14);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(798, 587);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Enabled = false;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(576, 289);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.kbtnMoreColourOptions);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kcmbDefinedColour);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kbtnChangeSelectedColour);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kbtnExportSelectedColour);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(204, 212);
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.TabIndex = 105;
            this.kryptonGroupBox2.Values.Heading = "Define Colour";
            // 
            // kcmbDefinedColour
            // 
            this.kcmbDefinedColour.AutoCompleteCustomSource.AddRange(new string[] {
            "Base Colour",
            "Darkest Colour",
            "Middle Colour",
            "Light Colour",
            "Lightest Colour"});
            this.kcmbDefinedColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbDefinedColour.DropDownWidth = 173;
            this.kcmbDefinedColour.IntegralHeight = false;
            this.kcmbDefinedColour.Items.AddRange(new object[] {
            "Base Colour",
            "Darkest Colour",
            "Middle Colour",
            "Light Colour",
            "Lightest Colour"});
            this.kcmbDefinedColour.Location = new System.Drawing.Point(8, 11);
            this.kcmbDefinedColour.Name = "kcmbDefinedColour";
            this.kcmbDefinedColour.Size = new System.Drawing.Size(186, 27);
            this.kcmbDefinedColour.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbDefinedColour.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbDefinedColour.TabIndex = 33;
            this.kcmbDefinedColour.SelectedIndexChanged += new System.EventHandler(this.KcmbDefinedColour_SelectedIndexChanged);
            // 
            // kbtnChangeSelectedColour
            // 
            this.kbtnChangeSelectedColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnChangeSelectedColour.Enabled = false;
            this.kbtnChangeSelectedColour.Location = new System.Drawing.Point(8, 49);
            this.kbtnChangeSelectedColour.Name = "kbtnChangeSelectedColour";
            this.kbtnChangeSelectedColour.Size = new System.Drawing.Size(186, 30);
            this.kbtnChangeSelectedColour.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnChangeSelectedColour.TabIndex = 104;
            this.kbtnChangeSelectedColour.Values.Text = "&Change Selected Colour";
            this.kbtnChangeSelectedColour.Click += new System.EventHandler(this.KbtnChangeSelectedColour_Click);
            // 
            // kbtnExportSelectedColour
            // 
            this.kbtnExportSelectedColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnExportSelectedColour.Enabled = false;
            this.kbtnExportSelectedColour.Location = new System.Drawing.Point(8, 94);
            this.kbtnExportSelectedColour.Name = "kbtnExportSelectedColour";
            this.kbtnExportSelectedColour.Size = new System.Drawing.Size(186, 30);
            this.kbtnExportSelectedColour.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnExportSelectedColour.TabIndex = 101;
            this.kbtnExportSelectedColour.Values.Text = "&Export Selected Colour";
            this.kbtnExportSelectedColour.Click += new System.EventHandler(this.KbtnExportSelectedColour_Click);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Enabled = false;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(576, 65);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnGenerateAlpha);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnGenerateRedValue);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnGenerateGreenValue);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnGenerateBlueValue);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(204, 197);
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.TabIndex = 103;
            this.kryptonGroupBox1.Values.Heading = "Colour Options";
            // 
            // kbtnGenerateAlpha
            // 
            this.kbtnGenerateAlpha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateAlpha.Location = new System.Drawing.Point(13, 14);
            this.kbtnGenerateAlpha.Name = "kbtnGenerateAlpha";
            this.kbtnGenerateAlpha.Size = new System.Drawing.Size(181, 30);
            this.kbtnGenerateAlpha.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateAlpha.TabIndex = 101;
            this.kbtnGenerateAlpha.Values.Text = "Generate &Alpha";
            this.kbtnGenerateAlpha.Click += new System.EventHandler(this.KbtnGenerateAlpha_Click);
            // 
            // kbtnGenerateRedValue
            // 
            this.kbtnGenerateRedValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateRedValue.Location = new System.Drawing.Point(13, 52);
            this.kbtnGenerateRedValue.Name = "kbtnGenerateRedValue";
            this.kbtnGenerateRedValue.Size = new System.Drawing.Size(181, 30);
            this.kbtnGenerateRedValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateRedValue.TabIndex = 91;
            this.kbtnGenerateRedValue.Values.Text = "Generate &Red";
            this.kbtnGenerateRedValue.Click += new System.EventHandler(this.KbtnGenerateRedValue_Click);
            // 
            // kbtnGenerateGreenValue
            // 
            this.kbtnGenerateGreenValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateGreenValue.Location = new System.Drawing.Point(13, 90);
            this.kbtnGenerateGreenValue.Name = "kbtnGenerateGreenValue";
            this.kbtnGenerateGreenValue.Size = new System.Drawing.Size(181, 30);
            this.kbtnGenerateGreenValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateGreenValue.TabIndex = 92;
            this.kbtnGenerateGreenValue.Values.Text = "Generate &Green";
            this.kbtnGenerateGreenValue.Click += new System.EventHandler(this.KbtnGenerateGreenValue_Click);
            // 
            // kbtnGenerateBlueValue
            // 
            this.kbtnGenerateBlueValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnGenerateBlueValue.Location = new System.Drawing.Point(13, 128);
            this.kbtnGenerateBlueValue.Name = "kbtnGenerateBlueValue";
            this.kbtnGenerateBlueValue.Size = new System.Drawing.Size(181, 30);
            this.kbtnGenerateBlueValue.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerateBlueValue.TabIndex = 93;
            this.kbtnGenerateBlueValue.Values.Text = "Generate &Blue";
            this.kbtnGenerateBlueValue.Click += new System.EventHandler(this.KbtnGenerateBlueValue_Click);
            // 
            // kryptonAlphaValueNumericBox
            // 
            this.kryptonAlphaValueNumericBox.Location = new System.Drawing.Point(214, 535);
            this.kryptonAlphaValueNumericBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.kryptonAlphaValueNumericBox.Name = "kryptonAlphaValueNumericBox";
            this.kryptonAlphaValueNumericBox.Size = new System.Drawing.Size(62, 26);
            this.kryptonAlphaValueNumericBox.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonAlphaValueNumericBox.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonAlphaValueNumericBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.kryptonAlphaValueNumericBox.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonAlphaValueNumericBox.TabIndex = 12;
            this.kryptonAlphaValueNumericBox.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.kryptonAlphaValueNumericBox.ValueChanged += new System.EventHandler(this.KryptonAlphaValueNumericBox_ValueChanged);
            // 
            // kryptonRedValueNumericBox
            // 
            this.kryptonRedValueNumericBox.Location = new System.Drawing.Point(327, 535);
            this.kryptonRedValueNumericBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.kryptonRedValueNumericBox.Name = "kryptonRedValueNumericBox";
            this.kryptonRedValueNumericBox.Size = new System.Drawing.Size(62, 26);
            this.kryptonRedValueNumericBox.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.kryptonRedValueNumericBox.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.kryptonRedValueNumericBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.kryptonRedValueNumericBox.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonRedValueNumericBox.TabIndex = 13;
            this.kryptonRedValueNumericBox.ValueChanged += new System.EventHandler(this.KryptonRedValueNumericBox_ValueChanged);
            // 
            // kryptonGreenValueNumericBox
            // 
            this.kryptonGreenValueNumericBox.Location = new System.Drawing.Point(415, 535);
            this.kryptonGreenValueNumericBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.kryptonGreenValueNumericBox.Name = "kryptonGreenValueNumericBox";
            this.kryptonGreenValueNumericBox.Size = new System.Drawing.Size(62, 26);
            this.kryptonGreenValueNumericBox.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.kryptonGreenValueNumericBox.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.kryptonGreenValueNumericBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.kryptonGreenValueNumericBox.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonGreenValueNumericBox.TabIndex = 14;
            this.kryptonGreenValueNumericBox.ValueChanged += new System.EventHandler(this.KryptonGreenValueNumericBox_ValueChanged);
            // 
            // kryptonBlueValueNumericBox
            // 
            this.kryptonBlueValueNumericBox.Location = new System.Drawing.Point(513, 535);
            this.kryptonBlueValueNumericBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.kryptonBlueValueNumericBox.Name = "kryptonBlueValueNumericBox";
            this.kryptonBlueValueNumericBox.Size = new System.Drawing.Size(62, 26);
            this.kryptonBlueValueNumericBox.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.kryptonBlueValueNumericBox.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.kryptonBlueValueNumericBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.kryptonBlueValueNumericBox.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonBlueValueNumericBox.TabIndex = 15;
            this.kryptonBlueValueNumericBox.ValueChanged += new System.EventHandler(this.KryptonBlueValueNumericBox_ValueChanged);
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Enabled = false;
            this.kryptonLabel10.Location = new System.Drawing.Point(214, 12);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 98;
            this.kryptonLabel10.Values.Text = "Alpha:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Enabled = false;
            this.kryptonLabel4.Location = new System.Drawing.Point(513, 12);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(50, 26);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 97;
            this.kryptonLabel4.Values.Text = "Blue:";
            // 
            // kryptonLabel16
            // 
            this.kryptonLabel16.Location = new System.Drawing.Point(17, 460);
            this.kryptonLabel16.Name = "kryptonLabel16";
            this.kryptonLabel16.Size = new System.Drawing.Size(130, 26);
            this.kryptonLabel16.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel16.TabIndex = 87;
            this.kryptonLabel16.Values.Text = "Lightest Colour";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Enabled = false;
            this.kryptonLabel3.Location = new System.Drawing.Point(415, 12);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(62, 26);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 96;
            this.kryptonLabel3.Values.Text = "Green:";
            // 
            // kryptonLabel15
            // 
            this.kryptonLabel15.Location = new System.Drawing.Point(24, 348);
            this.kryptonLabel15.Name = "kryptonLabel15";
            this.kryptonLabel15.Size = new System.Drawing.Size(108, 26);
            this.kryptonLabel15.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel15.TabIndex = 86;
            this.kryptonLabel15.Values.Text = "Light Colour";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Enabled = false;
            this.kryptonLabel2.Location = new System.Drawing.Point(327, 12);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(46, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 95;
            this.kryptonLabel2.Values.Text = "Red:";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(28, 12);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(104, 26);
            this.kryptonLabel12.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel12.TabIndex = 83;
            this.kryptonLabel12.Values.Text = "Base Colour";
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Location = new System.Drawing.Point(17, 124);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(127, 26);
            this.kryptonLabel13.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel13.TabIndex = 84;
            this.kryptonLabel13.Values.Text = "Darkest Colour";
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(17, 236);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(122, 26);
            this.kryptonLabel14.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel14.TabIndex = 85;
            this.kryptonLabel14.Values.Text = "Middle Colour";
            // 
            // cpbBaseColour
            // 
            this.cpbBaseColour.BackColor = System.Drawing.Color.Transparent;
            this.cpbBaseColour.Location = new System.Drawing.Point(43, 49);
            this.cpbBaseColour.Name = "cpbBaseColour";
            this.cpbBaseColour.Size = new System.Drawing.Size(64, 64);
            this.cpbBaseColour.TabIndex = 3;
            this.cpbBaseColour.TabStop = false;
            // 
            // cpbLightestColour
            // 
            this.cpbLightestColour.BackColor = System.Drawing.Color.Transparent;
            this.cpbLightestColour.Location = new System.Drawing.Point(43, 497);
            this.cpbLightestColour.Name = "cpbLightestColour";
            this.cpbLightestColour.Size = new System.Drawing.Size(64, 64);
            this.cpbLightestColour.TabIndex = 4;
            this.cpbLightestColour.TabStop = false;
            // 
            // cpbLightColour
            // 
            this.cpbLightColour.BackColor = System.Drawing.Color.Transparent;
            this.cpbLightColour.Location = new System.Drawing.Point(43, 385);
            this.cpbLightColour.Name = "cpbLightColour";
            this.cpbLightColour.Size = new System.Drawing.Size(64, 64);
            this.cpbLightColour.TabIndex = 5;
            this.cpbLightColour.TabStop = false;
            // 
            // cpbMiddleColour
            // 
            this.cpbMiddleColour.BackColor = System.Drawing.Color.Transparent;
            this.cpbMiddleColour.Location = new System.Drawing.Point(43, 273);
            this.cpbMiddleColour.Name = "cpbMiddleColour";
            this.cpbMiddleColour.Size = new System.Drawing.Size(64, 64);
            this.cpbMiddleColour.TabIndex = 6;
            this.cpbMiddleColour.TabStop = false;
            // 
            // cpbDarkestColour
            // 
            this.cpbDarkestColour.BackColor = System.Drawing.Color.Transparent;
            this.cpbDarkestColour.Location = new System.Drawing.Point(43, 161);
            this.cpbDarkestColour.Name = "cpbDarkestColour";
            this.cpbDarkestColour.Size = new System.Drawing.Size(64, 64);
            this.cpbDarkestColour.TabIndex = 7;
            this.cpbDarkestColour.TabStop = false;
            // 
            // kryptonAlphaTrackBar
            // 
            this.kryptonAlphaTrackBar.DrawBackground = true;
            this.kryptonAlphaTrackBar.Location = new System.Drawing.Point(234, 44);
            this.kryptonAlphaTrackBar.Maximum = 255;
            this.kryptonAlphaTrackBar.Name = "kryptonAlphaTrackBar";
            this.kryptonAlphaTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kryptonAlphaTrackBar.Size = new System.Drawing.Size(21, 485);
            this.kryptonAlphaTrackBar.TabIndex = 8;
            this.kryptonAlphaTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.kryptonAlphaTrackBar.Value = 255;
            this.kryptonAlphaTrackBar.ValueChanged += new System.EventHandler(this.KryptonAlphaTrackBar_ValueChanged);
            // 
            // kryptonRedTrackBar
            // 
            this.kryptonRedTrackBar.DrawBackground = true;
            this.kryptonRedTrackBar.Location = new System.Drawing.Point(340, 44);
            this.kryptonRedTrackBar.Maximum = 255;
            this.kryptonRedTrackBar.Name = "kryptonRedTrackBar";
            this.kryptonRedTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kryptonRedTrackBar.Size = new System.Drawing.Size(21, 485);
            this.kryptonRedTrackBar.StateCommon.Tick.Color1 = System.Drawing.Color.Red;
            this.kryptonRedTrackBar.StateCommon.Track.Color1 = System.Drawing.Color.Red;
            this.kryptonRedTrackBar.StateCommon.Track.Color2 = System.Drawing.Color.Red;
            this.kryptonRedTrackBar.StateCommon.Track.Color3 = System.Drawing.Color.Red;
            this.kryptonRedTrackBar.StateCommon.Track.Color4 = System.Drawing.Color.Red;
            this.kryptonRedTrackBar.StateCommon.Track.Color5 = System.Drawing.Color.Red;
            this.kryptonRedTrackBar.TabIndex = 9;
            this.kryptonRedTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.kryptonRedTrackBar.ValueChanged += new System.EventHandler(this.KryptonRedTrackBar_ValueChanged);
            // 
            // kryptonGreenTrackBar
            // 
            this.kryptonGreenTrackBar.DrawBackground = true;
            this.kryptonGreenTrackBar.Location = new System.Drawing.Point(438, 44);
            this.kryptonGreenTrackBar.Maximum = 255;
            this.kryptonGreenTrackBar.Name = "kryptonGreenTrackBar";
            this.kryptonGreenTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kryptonGreenTrackBar.Size = new System.Drawing.Size(21, 485);
            this.kryptonGreenTrackBar.StateCommon.Tick.Color1 = System.Drawing.Color.Green;
            this.kryptonGreenTrackBar.StateCommon.Track.Color1 = System.Drawing.Color.Green;
            this.kryptonGreenTrackBar.StateCommon.Track.Color2 = System.Drawing.Color.Green;
            this.kryptonGreenTrackBar.StateCommon.Track.Color3 = System.Drawing.Color.Green;
            this.kryptonGreenTrackBar.StateCommon.Track.Color4 = System.Drawing.Color.Green;
            this.kryptonGreenTrackBar.StateCommon.Track.Color5 = System.Drawing.Color.Green;
            this.kryptonGreenTrackBar.TabIndex = 10;
            this.kryptonGreenTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.kryptonGreenTrackBar.ValueChanged += new System.EventHandler(this.KryptonGreenTrackBar_ValueChanged);
            // 
            // kryptonBlueTrackBar
            // 
            this.kryptonBlueTrackBar.DrawBackground = true;
            this.kryptonBlueTrackBar.Location = new System.Drawing.Point(529, 44);
            this.kryptonBlueTrackBar.Maximum = 255;
            this.kryptonBlueTrackBar.Name = "kryptonBlueTrackBar";
            this.kryptonBlueTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.kryptonBlueTrackBar.Size = new System.Drawing.Size(21, 485);
            this.kryptonBlueTrackBar.StateCommon.Tick.Color1 = System.Drawing.Color.Blue;
            this.kryptonBlueTrackBar.StateCommon.Track.Color1 = System.Drawing.Color.Blue;
            this.kryptonBlueTrackBar.StateCommon.Track.Color2 = System.Drawing.Color.Blue;
            this.kryptonBlueTrackBar.StateCommon.Track.Color3 = System.Drawing.Color.Blue;
            this.kryptonBlueTrackBar.StateCommon.Track.Color4 = System.Drawing.Color.Blue;
            this.kryptonBlueTrackBar.StateCommon.Track.Color5 = System.Drawing.Color.Blue;
            this.kryptonBlueTrackBar.TabIndex = 11;
            this.kryptonBlueTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.kryptonBlueTrackBar.ValueChanged += new System.EventHandler(this.KryptonBlueTrackBar_ValueChanged);
            // 
            // kbtnMoreColourOptions
            // 
            this.kbtnMoreColourOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnMoreColourOptions.Location = new System.Drawing.Point(8, 141);
            this.kbtnMoreColourOptions.Name = "kbtnMoreColourOptions";
            this.kbtnMoreColourOptions.Size = new System.Drawing.Size(186, 30);
            this.kbtnMoreColourOptions.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnMoreColourOptions.TabIndex = 105;
            this.kbtnMoreColourOptions.Values.Text = "&More Colour Options";
            // 
            // KryptonPaletteBaseColourMixer
            // 
            this.AcceptButton = this.kbtnOk;
            this.ClientSize = new System.Drawing.Size(798, 635);
            this.Controls.Add(this.kryptonBlueTrackBar);
            this.Controls.Add(this.kryptonGreenTrackBar);
            this.Controls.Add(this.kryptonRedTrackBar);
            this.Controls.Add(this.kryptonAlphaTrackBar);
            this.Controls.Add(this.cpbDarkestColour);
            this.Controls.Add(this.cpbMiddleColour);
            this.Controls.Add(this.cpbLightColour);
            this.Controls.Add(this.cpbLightestColour);
            this.Controls.Add(this.cpbBaseColour);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonPaletteBaseColourMixer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base Palette Mixer";
            this.Load += new System.EventHandler(this.KryptonPaletteBaseColourMixer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kcmbDefinedColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpbBaseColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpbLightestColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpbLightColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpbMiddleColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpbDarkestColour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Variables
        private BasicPaletteColours _basicPaletteColour;

        private Color _baseColour, _darkestColour, _middleColour, _lightColour, _lightestColour;

        private int _alphaValue, _redValue, _greenValue, _blueValue;

        private Timer _updateUI;

        private string _hexadecimalValue;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the basic palette colours.
        /// </summary>
        /// <value>
        /// The basic palette colours.
        /// </value>
        public BasicPaletteColours BasicPaletteColour { get => _basicPaletteColour; set => _basicPaletteColour = value; }

        /// <summary>
        /// Gets or sets the base colour.
        /// </summary>
        /// <value>
        /// The base colour.
        /// </value>
        public Color BaseColour { get => _baseColour; set => _baseColour = value; }

        /// <summary>
        /// Gets or sets the darkest colour.
        /// </summary>
        /// <value>
        /// The darkest colour.
        /// </value>
        public Color DarkestColour { get => _darkestColour; set => _darkestColour = value; }

        /// <summary>
        /// Gets or sets the middle colour.
        /// </summary>
        /// <value>
        /// The middle colour.
        /// </value>
        public Color MiddleColour { get => _middleColour; set => _middleColour = value; }

        /// <summary>
        /// Gets or sets the light colour.
        /// </summary>
        /// <value>
        /// The light colour.
        /// </value>
        public Color LightColour { get => _lightColour; set => _lightColour = value; }

        /// <summary>
        /// Gets or sets the lightest colour.
        /// </summary>
        /// <value>
        /// The lightest colour.
        /// </value>
        public Color LightestColour { get => _lightestColour; set => _lightestColour = value; }

        /// <summary>
        /// Gets or sets the alpha value.
        /// </summary>
        /// <value>
        /// The alpha value.
        /// </value>
        public int AlphaValue { get => _alphaValue; set => _alphaValue = value; }

        /// <summary>
        /// Gets or sets the red value.
        /// </summary>
        /// <value>
        /// The red value.
        /// </value>
        public int RedValue { get => _redValue; set => _redValue = value; }

        /// <summary>
        /// Gets or sets the green value.
        /// </summary>
        /// <value>
        /// The green value.
        /// </value>
        public int GreenValue { get => _greenValue; set => _greenValue = value; }

        /// <summary>
        /// Gets or sets the blue value.
        /// </summary>
        /// <value>
        /// The blue value.
        /// </value>
        public int BlueValue { get => _blueValue; set => _blueValue = value; }

        /// <summary>
        /// Gets or sets the hexadecimal value.
        /// </summary>
        /// <value>
        /// The hexadecimal value.
        /// </value>
        public string HexadecimalValue { get => _hexadecimalValue; set => _hexadecimalValue = value; }
        #endregion

        #region Constructor
        public KryptonPaletteBaseColourMixer()
        {
            InitializeComponent();

            SetBaseColour(Color.Transparent);

            _updateUI = new Timer();

            _updateUI.Enabled = true;

            _updateUI.Interval = 1000;

            _updateUI.Tick += UpdateUI_Tick;
        }

        public KryptonPaletteBaseColourMixer(Color colour)
        {
            InitializeComponent();

            SetBaseColour(colour);

            _updateUI = new Timer();

            _updateUI.Enabled = true;

            _updateUI.Interval = 1000;

            _updateUI.Tick += UpdateUI_Tick;
        }
        #endregion

        #region Event Handlers
        private void KcmbDefinedColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            SwitchBasicPaletteColour(kcmbDefinedColour.Text);

            kbtnChangeSelectedColour.Enabled = true;
        }

        private void KryptonPaletteBaseColourMixer_Load(object sender, EventArgs e)
        {

        }

        private void KryptonAlphaTrackBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KryptonRedTrackBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KryptonGreenTrackBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KryptonBlueTrackBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KryptonAlphaValueNumericBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KryptonRedValueNumericBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KryptonGreenValueNumericBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KryptonBlueValueNumericBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KbtnGenerateAlpha_Click(object sender, EventArgs e)
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

        private void KbtnChangeSelectedColour_Click(object sender, EventArgs e)
        {

        }

        private void KbtnExportSelectedColour_Click(object sender, EventArgs e)
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

        #region Methods
        /// <summary>
        /// Changes the specific colour.
        /// </summary>
        /// <param name="basicPaletteColours">The basic palette colours.</param>
        /// <param name="a">a.</param>
        /// <param name="r">The r.</param>
        /// <param name="g">The g.</param>
        /// <param name="b">The b.</param>
        private void ChangeSpecificColour(BasicPaletteColours basicPaletteColours, int a, int r, int g, int b)
        {
            Color temporaryColour = Color.FromArgb(a, r, g, b);

            switch (basicPaletteColours)
            {
                case BasicPaletteColours.BASECOLOUR:
                    cpbBaseColour.BackColor = temporaryColour;
                    break;
                case BasicPaletteColours.DARKESTCOLOUR:
                    cpbDarkestColour.BackColor = temporaryColour;
                    break;
                case BasicPaletteColours.MIDDLECOLOUR:
                    cpbMiddleColour.BackColor = temporaryColour;
                    break;
                case BasicPaletteColours.LIGHTCOLOUR:
                    cpbLightColour.BackColor = temporaryColour;
                    break;
                case BasicPaletteColours.LIGHTESTCOLOUR:
                    cpbLightestColour.BackColor = temporaryColour;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Changes the specific colour.
        /// </summary>
        /// <param name="basicPaletteColours">The basic palette colours.</param>
        /// <param name="colour">The colour.</param>
        private void ChangeSpecificColour(BasicPaletteColours basicPaletteColours, Color colour)
        {
            switch (basicPaletteColours)
            {
                case BasicPaletteColours.BASECOLOUR:
                    cpbBaseColour.BackColor = colour;
                    break;
                case BasicPaletteColours.DARKESTCOLOUR:
                    cpbDarkestColour.BackColor = colour;
                    break;
                case BasicPaletteColours.MIDDLECOLOUR:
                    cpbMiddleColour.BackColor = colour;
                    break;
                case BasicPaletteColours.LIGHTCOLOUR:
                    cpbLightColour.BackColor = colour;
                    break;
                case BasicPaletteColours.LIGHTESTCOLOUR:
                    cpbLightestColour.BackColor = colour;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Switches the basic palette colour.
        /// </summary>
        /// <param name="text">The text.</param>
        private void SwitchBasicPaletteColour(string text)
        {
            if (text == "Base Colour")
            {
                SetBasicPaletteColour(BasicPaletteColours.BASECOLOUR);
            }
            else if (text == "Darkest Colour")
            {
                SetBasicPaletteColour(BasicPaletteColours.DARKESTCOLOUR);
            }
            else if (text == "Middle Colour")
            {
                SetBasicPaletteColour(BasicPaletteColours.MIDDLECOLOUR);
            }
            else if (text == "Light Colour")
            {
                SetBasicPaletteColour(BasicPaletteColours.LIGHTCOLOUR);
            }
            else if (text == "Lightest Colour")
            {
                SetBasicPaletteColour(BasicPaletteColours.LIGHTESTCOLOUR);
            }
        }
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the BasicPaletteColour.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetBasicPaletteColour(BasicPaletteColours value) => BasicPaletteColour = value;

        /// <summary>
        /// Gets the BasicPaletteColour.
        /// </summary>
        /// <returns>The value of BasicPaletteColours.</returns>
        public BasicPaletteColours GetBasicPaletteColour() => BasicPaletteColour;

        /// <summary>
        /// Sets the BaseColour.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetBaseColour(Color value) => BaseColour = value;

        /// <summary>
        /// Gets the BaseColour.
        /// </summary>
        /// <returns>The value of BaseColour.</returns>
        public Color GetBaseColour() => BaseColour;

        /// <summary>
        /// Sets the DarkestColour.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetDarkestColour(Color value) => DarkestColour = value;

        /// <summary>
        /// Gets the DarkestColour.
        /// </summary>
        /// <returns>The value of DarkestColour.</returns>
        public Color GetDarkestColour() => DarkestColour;

        /// <summary>
        /// Sets the MiddleColour.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetMiddleColour(Color value) => MiddleColour = value;

        /// <summary>
        /// Gets the MiddleColour.
        /// </summary>
        /// <returns>The value of MiddleColour.</returns>
        public Color GetMiddleColour() => MiddleColour;

        /// <summary>
        /// Sets the LightColour.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetLightColour(Color value) => LightColour = value;

        /// <summary>
        /// Gets the LightColour.
        /// </summary>
        /// <returns>The value of LightColour.</returns>
        public Color GetLightColour() => LightColour;

        /// <summary>
        /// Sets the LightestColour.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetLightestColour(Color value) => LightestColour = value;

        /// <summary>
        /// Gets the LightestColour.
        /// </summary>
        /// <returns>The value of LightestColour.</returns>
        public Color GetLightestColour() => LightestColour;

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

        /// <summary>
        /// Sets the HexadecimalValue.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetHexadecimalValue(string value) => HexadecimalValue = value;

        /// <summary>
        /// Gets the HexadecimalValue.
        /// </summary>
        /// <returns>The value of HexadecimalValue.</returns>
        public string GetHexadecimalValue() => HexadecimalValue;
        #endregion
    }
}