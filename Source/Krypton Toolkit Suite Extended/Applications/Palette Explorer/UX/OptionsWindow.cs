#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using Core;
using Core.Classes.IO;
using Core.Classes.Other;
using PaletteExplorer.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;
using ToolkitSettings.Classes.PaletteExplorer;

namespace PaletteExplorer.UX
{
    public class OptionsWindow : KryptonForm
    {
        #region System Functions
        private KryptonManager kMan;
        private System.ComponentModel.IContainer components;
        private KryptonPalette kryptonPalette1;
        private KryptonPanel kryptonPanel1;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton ksbApply;
        private KryptonPanel kryptonPanel2;
        private KryptonButton kbtnCancel;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator knOptions;
        private ComponentFactory.Krypton.Navigator.KryptonPage kpGeneral;
        private ComponentFactory.Krypton.Navigator.KryptonPage kpTheme;
        private KryptonGroupBox kryptonGroupBox1;
        private KryptonComboBox kcbTheme;
        private KryptonLabel kryptonLabel1;
        private KryptonButton kbtnLoadTheme;
        private KryptonButton kbtnCustomThemeFileBrowse;
        private KryptonTextBox ktxtCustomThemePath;
        private KryptonLabel klblCustomThemeFilePath;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private KryptonLabel kryptonLabel7;
        private KryptonLabel kryptonLabel5;
        private KryptonLabel kryptonLabel4;
        private KryptonLabel kryptonLabel2;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxLightestColour;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxLightColour;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxMediumColour;
        private ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox cbxDarkColour;
        private KryptonLabel klblMediumColourFloatValue;
        private KryptonLabel klblLightColourFloatValue;
        private KryptonLabel klblDarkColourFloatValue;
        private KryptonLabel klblLightestColourFloatValue;
        private KryptonNumericUpDown knumDarkValue;
        private KryptonNumericUpDown knumMediumValue;
        private KryptonNumericUpDown knumLightValue;
        private KryptonNumericUpDown knumLightestValue;
        private KryptonColorButton kcbTest;
        private System.Windows.Forms.Panel panel1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsWindow));
            this.kMan = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ksbApply = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.knOptions = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kpGeneral = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kpTheme = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kbtnLoadTheme = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCustomThemeFileBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ktxtCustomThemePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.klblCustomThemeFilePath = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kcbTheme = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kcbTest = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            this.klblMediumColourFloatValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblLightColourFloatValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblDarkColourFloatValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.klblLightestColourFloatValue = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.knumDarkValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumMediumValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumLightValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.knumLightestValue = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.cbxLightestColour = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxLightColour = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxMediumColour = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.cbxDarkColour = new ExtendedControls.ExtendedToolkit.Controls.CircularPictureBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knOptions)).BeginInit();
            this.knOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpTheme)).BeginInit();
            this.kpTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcbTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLightestColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLightColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMediumColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDarkColour)).BeginInit();
            this.SuspendLayout();
            // 
            // kMan
            // 
            this.kMan.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.CustomisedKryptonPaletteFilePath = null;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Controls.Add(this.ksbApply);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 797);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(906, 55);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.AutoSize = true;
            this.kbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnCancel.Location = new System.Drawing.Point(757, 13);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(60, 30);
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 1;
            this.kbtnCancel.Values.Text = "Can&cel";
            // 
            // ksbApply
            // 
            this.ksbApply.AutoSize = true;
            this.ksbApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ksbApply.Enabled = false;
            this.ksbApply.Location = new System.Drawing.Point(823, 13);
            this.ksbApply.Name = "ksbApply";
            this.ksbApply.Size = new System.Drawing.Size(71, 30);
            this.ksbApply.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ksbApply.TabIndex = 0;
            this.ksbApply.Values.Image = ((System.Drawing.Image)(resources.GetObject("ksbApply.Values.Image")));
            this.ksbApply.Values.Text = "&Apply";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.knOptions);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(906, 797);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // knOptions
            // 
            this.knOptions.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.knOptions.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.knOptions.Location = new System.Drawing.Point(12, 12);
            this.knOptions.Name = "knOptions";
            this.knOptions.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kpGeneral,
            this.kpTheme,
            this.kryptonPage1});
            this.knOptions.SelectedIndex = 0;
            this.knOptions.Size = new System.Drawing.Size(882, 776);
            this.knOptions.StateCommon.Tab.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knOptions.TabIndex = 0;
            this.knOptions.Text = "kryptonNavigator1";
            // 
            // kpGeneral
            // 
            this.kpGeneral.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kpGeneral.Flags = 65534;
            this.kpGeneral.LastVisibleSet = true;
            this.kpGeneral.MinimumSize = new System.Drawing.Size(50, 50);
            this.kpGeneral.Name = "kpGeneral";
            this.kpGeneral.Size = new System.Drawing.Size(880, 745);
            this.kpGeneral.Text = "General";
            this.kpGeneral.ToolTipTitle = "Page ToolTip";
            this.kpGeneral.UniqueName = "8CF4DE8AD8A6433C038CBF6707BB28B6";
            // 
            // kpTheme
            // 
            this.kpTheme.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kpTheme.Controls.Add(this.kryptonGroupBox1);
            this.kpTheme.Flags = 65534;
            this.kpTheme.LastVisibleSet = true;
            this.kpTheme.MinimumSize = new System.Drawing.Size(50, 50);
            this.kpTheme.Name = "kpTheme";
            this.kpTheme.Size = new System.Drawing.Size(880, 745);
            this.kpTheme.Text = "Theme";
            this.kpTheme.ToolTipTitle = "Page ToolTip";
            this.kpTheme.UniqueName = "A80439CDD42845E10BA62B98A827DD36";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(20, 16);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnLoadTheme);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kbtnCustomThemeFileBrowse);
            this.kryptonGroupBox1.Panel.Controls.Add(this.ktxtCustomThemePath);
            this.kryptonGroupBox1.Panel.Controls.Add(this.klblCustomThemeFilePath);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kcbTheme);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(840, 169);
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Theme Selector";
            // 
            // kbtnLoadTheme
            // 
            this.kbtnLoadTheme.AutoSize = true;
            this.kbtnLoadTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnLoadTheme.Enabled = false;
            this.kbtnLoadTheme.Location = new System.Drawing.Point(668, 97);
            this.kbtnLoadTheme.Name = "kbtnLoadTheme";
            this.kbtnLoadTheme.Size = new System.Drawing.Size(152, 28);
            this.kbtnLoadTheme.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.kbtnLoadTheme.TabIndex = 5;
            this.kbtnLoadTheme.Values.Text = "&Load Custom Theme";
            // 
            // kbtnCustomThemeFileBrowse
            // 
            this.kbtnCustomThemeFileBrowse.AutoSize = true;
            this.kbtnCustomThemeFileBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnCustomThemeFileBrowse.Enabled = false;
            this.kbtnCustomThemeFileBrowse.Location = new System.Drawing.Point(798, 53);
            this.kbtnCustomThemeFileBrowse.Name = "kbtnCustomThemeFileBrowse";
            this.kbtnCustomThemeFileBrowse.Size = new System.Drawing.Size(22, 28);
            this.kbtnCustomThemeFileBrowse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.kbtnCustomThemeFileBrowse.TabIndex = 4;
            this.kbtnCustomThemeFileBrowse.Values.Text = ".&..";
            // 
            // ktxtCustomThemePath
            // 
            this.ktxtCustomThemePath.Enabled = false;
            this.ktxtCustomThemePath.Location = new System.Drawing.Point(231, 54);
            this.ktxtCustomThemePath.Name = "ktxtCustomThemePath";
            this.ktxtCustomThemePath.Size = new System.Drawing.Size(561, 27);
            this.ktxtCustomThemePath.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ktxtCustomThemePath.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.ktxtCustomThemePath.TabIndex = 3;
            // 
            // klblCustomThemeFilePath
            // 
            this.klblCustomThemeFilePath.Enabled = false;
            this.klblCustomThemeFilePath.Location = new System.Drawing.Point(34, 55);
            this.klblCustomThemeFilePath.Name = "klblCustomThemeFilePath";
            this.klblCustomThemeFilePath.Size = new System.Drawing.Size(191, 24);
            this.klblCustomThemeFilePath.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblCustomThemeFilePath.TabIndex = 2;
            this.klblCustomThemeFilePath.Values.Text = "Custom Theme File Path:";
            // 
            // kcbTheme
            // 
            this.kcbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcbTheme.DropDownWidth = 182;
            this.kcbTheme.Location = new System.Drawing.Point(124, 12);
            this.kcbTheme.Name = "kcbTheme";
            this.kcbTheme.Size = new System.Drawing.Size(182, 25);
            this.kcbTheme.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbTheme.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcbTheme.TabIndex = 1;
            this.kcbTheme.SelectedIndexChanged += new System.EventHandler(this.KcbTheme_SelectedIndexChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(14, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(104, 24);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Theme Type:";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.kcbTest);
            this.kryptonPage1.Controls.Add(this.klblMediumColourFloatValue);
            this.kryptonPage1.Controls.Add(this.klblLightColourFloatValue);
            this.kryptonPage1.Controls.Add(this.klblDarkColourFloatValue);
            this.kryptonPage1.Controls.Add(this.klblLightestColourFloatValue);
            this.kryptonPage1.Controls.Add(this.knumDarkValue);
            this.kryptonPage1.Controls.Add(this.knumMediumValue);
            this.kryptonPage1.Controls.Add(this.knumLightValue);
            this.kryptonPage1.Controls.Add(this.knumLightestValue);
            this.kryptonPage1.Controls.Add(this.cbxLightestColour);
            this.kryptonPage1.Controls.Add(this.cbxLightColour);
            this.kryptonPage1.Controls.Add(this.cbxMediumColour);
            this.kryptonPage1.Controls.Add(this.cbxDarkColour);
            this.kryptonPage1.Controls.Add(this.kryptonLabel7);
            this.kryptonPage1.Controls.Add(this.kryptonLabel5);
            this.kryptonPage1.Controls.Add(this.kryptonLabel4);
            this.kryptonPage1.Controls.Add(this.kryptonLabel2);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(880, 745);
            this.kryptonPage1.Text = "Colour Intensity";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "e0550eb663f7425e99be7d6b7761bd8e";
            // 
            // kcbTest
            // 
            this.kcbTest.Location = new System.Drawing.Point(36, 462);
            this.kcbTest.Name = "kcbTest";
            this.kcbTest.Size = new System.Drawing.Size(178, 25);
            this.kcbTest.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbTest.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcbTest.TabIndex = 34;
            this.kcbTest.Values.Text = "&Test Colour";
            this.kcbTest.SelectedColorChanged += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ColorEventArgs>(this.KcbTest_SelectedColorChanged);
            // 
            // klblMediumColourFloatValue
            // 
            this.klblMediumColourFloatValue.Location = new System.Drawing.Point(366, 172);
            this.klblMediumColourFloatValue.Name = "klblMediumColourFloatValue";
            this.klblMediumColourFloatValue.Size = new System.Drawing.Size(42, 33);
            this.klblMediumColourFloatValue.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblMediumColourFloatValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblMediumColourFloatValue.TabIndex = 33;
            this.klblMediumColourFloatValue.Values.Text = "{0}";
            // 
            // klblLightColourFloatValue
            // 
            this.klblLightColourFloatValue.Location = new System.Drawing.Point(366, 290);
            this.klblLightColourFloatValue.Name = "klblLightColourFloatValue";
            this.klblLightColourFloatValue.Size = new System.Drawing.Size(42, 33);
            this.klblLightColourFloatValue.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblLightColourFloatValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblLightColourFloatValue.TabIndex = 32;
            this.klblLightColourFloatValue.Values.Text = "{0}";
            // 
            // klblDarkColourFloatValue
            // 
            this.klblDarkColourFloatValue.Location = new System.Drawing.Point(366, 54);
            this.klblDarkColourFloatValue.Name = "klblDarkColourFloatValue";
            this.klblDarkColourFloatValue.Size = new System.Drawing.Size(42, 33);
            this.klblDarkColourFloatValue.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblDarkColourFloatValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblDarkColourFloatValue.TabIndex = 31;
            this.klblDarkColourFloatValue.Values.Text = "{0}";
            // 
            // klblLightestColourFloatValue
            // 
            this.klblLightestColourFloatValue.Location = new System.Drawing.Point(366, 408);
            this.klblLightestColourFloatValue.Name = "klblLightestColourFloatValue";
            this.klblLightestColourFloatValue.Size = new System.Drawing.Size(42, 33);
            this.klblLightestColourFloatValue.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblLightestColourFloatValue.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblLightestColourFloatValue.TabIndex = 30;
            this.klblLightestColourFloatValue.Values.Text = "{0}";
            // 
            // knumDarkValue
            // 
            this.knumDarkValue.DecimalPlaces = 99;
            this.knumDarkValue.Location = new System.Drawing.Point(217, 54);
            this.knumDarkValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumDarkValue.Name = "knumDarkValue";
            this.knumDarkValue.Size = new System.Drawing.Size(120, 32);
            this.knumDarkValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumDarkValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.knumDarkValue.TabIndex = 29;
            this.knumDarkValue.ValueChanged += new System.EventHandler(this.KnumDarkValue_ValueChanged);
            // 
            // knumMediumValue
            // 
            this.knumMediumValue.DecimalPlaces = 99;
            this.knumMediumValue.Location = new System.Drawing.Point(217, 172);
            this.knumMediumValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumMediumValue.Name = "knumMediumValue";
            this.knumMediumValue.Size = new System.Drawing.Size(120, 32);
            this.knumMediumValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumMediumValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.knumMediumValue.TabIndex = 28;
            this.knumMediumValue.ValueChanged += new System.EventHandler(this.KnumMediumValue_ValueChanged);
            // 
            // knumLightValue
            // 
            this.knumLightValue.DecimalPlaces = 99;
            this.knumLightValue.Location = new System.Drawing.Point(217, 290);
            this.knumLightValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumLightValue.Name = "knumLightValue";
            this.knumLightValue.Size = new System.Drawing.Size(120, 32);
            this.knumLightValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumLightValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.knumLightValue.TabIndex = 27;
            this.knumLightValue.ValueChanged += new System.EventHandler(this.KnumLightValue_ValueChanged);
            // 
            // knumLightestValue
            // 
            this.knumLightestValue.DecimalPlaces = 99;
            this.knumLightestValue.Location = new System.Drawing.Point(217, 408);
            this.knumLightestValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.knumLightestValue.Name = "knumLightestValue";
            this.knumLightestValue.Size = new System.Drawing.Size(120, 32);
            this.knumLightestValue.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knumLightestValue.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.knumLightestValue.TabIndex = 26;
            this.knumLightestValue.ValueChanged += new System.EventHandler(this.KnumLightestValue_ValueChanged);
            // 
            // cbxLightestColour
            // 
            this.cbxLightestColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxLightestColour.BackColor = System.Drawing.Color.Black;
            this.cbxLightestColour.Location = new System.Drawing.Point(765, 374);
            this.cbxLightestColour.Name = "cbxLightestColour";
            this.cbxLightestColour.Size = new System.Drawing.Size(95, 95);
            this.cbxLightestColour.TabIndex = 25;
            this.cbxLightestColour.TabStop = false;
            // 
            // cbxLightColour
            // 
            this.cbxLightColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxLightColour.BackColor = System.Drawing.Color.Black;
            this.cbxLightColour.Location = new System.Drawing.Point(765, 258);
            this.cbxLightColour.Name = "cbxLightColour";
            this.cbxLightColour.Size = new System.Drawing.Size(95, 95);
            this.cbxLightColour.TabIndex = 24;
            this.cbxLightColour.TabStop = false;
            // 
            // cbxMediumColour
            // 
            this.cbxMediumColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMediumColour.BackColor = System.Drawing.Color.Black;
            this.cbxMediumColour.Location = new System.Drawing.Point(765, 142);
            this.cbxMediumColour.Name = "cbxMediumColour";
            this.cbxMediumColour.Size = new System.Drawing.Size(95, 95);
            this.cbxMediumColour.TabIndex = 23;
            this.cbxMediumColour.TabStop = false;
            // 
            // cbxDarkColour
            // 
            this.cbxDarkColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDarkColour.BackColor = System.Drawing.Color.Black;
            this.cbxDarkColour.Location = new System.Drawing.Point(765, 26);
            this.cbxDarkColour.Name = "cbxDarkColour";
            this.cbxDarkColour.Size = new System.Drawing.Size(95, 95);
            this.cbxDarkColour.TabIndex = 22;
            this.cbxDarkColour.TabStop = false;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(36, 172);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(178, 33);
            this.kryptonLabel7.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 21;
            this.kryptonLabel7.Values.Text = "Medium Colour:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(36, 408);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(175, 33);
            this.kryptonLabel5.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 20;
            this.kryptonLabel5.Values.Text = "Lightest Colour:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(36, 290);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(145, 33);
            this.kryptonLabel4.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 19;
            this.kryptonLabel4.Values.Text = "Light Colour:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(36, 54);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(141, 33);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 18;
            this.kryptonLabel2.Values.Text = "Dark Colour:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 794);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 3);
            this.panel1.TabIndex = 2;
            // 
            // OptionsWindow
            // 
            this.ClientSize = new System.Drawing.Size(906, 852);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Palette Explorer Options";
            this.Load += new System.EventHandler(this.OptionsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.knOptions)).EndInit();
            this.knOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpTheme)).EndInit();
            this.kpTheme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kcbTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            this.kryptonPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLightestColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLightColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMediumColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDarkColour)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        ColourIntensitySettingsManager _colourIntensitySettingsManager = new ColourIntensitySettingsManager();
        #endregion

        public OptionsWindow()
        {
            InitializeComponent();
        }

        private void OptionsWindow_Load(object sender, EventArgs e)
        {
            InitialiseWindow();
        }

        private void InitialiseWindow()
        {
            try
            {
                ThemeManager.PropagateThemeSelector(kcbTheme);

                knumDarkValue.Value = ConversionMethods.ConvertFloatToDecimal(_colourIntensitySettingsManager.GetDarkestColourIntensity());

                knumMediumValue.Value = ConversionMethods.ConvertFloatToDecimal(_colourIntensitySettingsManager.GetMediumColourIntensity());

                knumLightValue.Value = ConversionMethods.ConvertFloatToDecimal(_colourIntensitySettingsManager.GetLightColourIntensity());

                knumLightestValue.Value = ConversionMethods.ConvertFloatToDecimal(_colourIntensitySettingsManager.GetLightestColourIntensity());

                klblDarkColourFloatValue.Text = ColourHelpers.ReturnFloatAsString(_colourIntensitySettingsManager.GetDarkestColourIntensity());

                klblMediumColourFloatValue.Text = ColourHelpers.ReturnFloatAsString(_colourIntensitySettingsManager.GetMediumColourIntensity());

                klblLightColourFloatValue.Text = ColourHelpers.ReturnFloatAsString(_colourIntensitySettingsManager.GetLightColourIntensity());

                klblLightestColourFloatValue.Text = ColourHelpers.ReturnFloatAsString(_colourIntensitySettingsManager.GetLightestColourIntensity());
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc, icon: MessageBoxIcon.Error, methodSignature: Helpers.GetCurrentMethod());
            }
        }

        private void KcbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThemeManager.SetTheme(kcbTheme.Text, kMan);
        }

        private void KnumDarkValue_ValueChanged(object sender, EventArgs e)
        {
            klblDarkColourFloatValue.Text = ColourHelpers.ReturnFloatAsString((float)knumDarkValue.Value);

            cbxDarkColour.BackColor = ColourHelpers.Darken(cbxDarkColour.BackColor, (float)knumDarkValue.Value);
        }

        private void KnumMediumValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KnumLightValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KnumLightestValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KcbTest_SelectedColorChanged(object sender, ColorEventArgs e)
        {
            SetColour(kcbTest.SelectedColor);
        }

        private void SetColour(Color selectedColour)
        {
            throw new NotImplementedException();
        }
    }
}