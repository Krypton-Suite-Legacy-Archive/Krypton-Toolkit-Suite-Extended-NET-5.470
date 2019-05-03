#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using Core.UX;
using Core.UX.Colours;
using Core.UX.Options;
using ExtendedControls.ExtendedToolkit.Controls;
using ExtendedControls.ExtendedToolkit.Controls.Drawing.UI;
using ExtendedControls.ExtendedToolkit.Controls.KryptonControls;
using ExtendedControls.ExtendedToolkit.MessageBoxes.UI;
using ExtendedControls.ExtendedToolkit.SystemDialogs.Typeface;
using ExtendedControls.ExtendedToolkit.UI.Colours;
using ExtendedControls.ExtendedToolkit.UI.GraphicsTools;
using ExtendedControls.ExtendedToolkit.UI.Security;
using ExtendedControls.ExtendedToolkit.UI.Security.FileHashing;
using ExtendedControls.ExtendedToolkit.UI.Security.VirusTotal;
using ExtendedControls.ExtendedToolkit.UI.SystemBrowser;
using ExtendedControls.ExtendedToolkit.UI.Theming;
using ExtendedFileDialogs.UI.SystemBrowser;
using Playground.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Playground
{
    public class Examples : KryptonForm
    {
        #region Designer Code
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private KryptonButton kbtnListView;
        private KryptonButton kbtnPropertyGrid;
        private KryptonButton kbtnMessageboxTest2;
        private KryptonButton kbtnFileExplorer;
        private KryptonButton kbtnFileBrowser;
        private KryptonButton kbtnAdobeColourDialog;
        private KryptonButton kbtnColourWheel;
        private KryptonButton kbtnMoreControls;
        private KryptonButton kbtnKryptonWizard;
        private KryptonButton kbtnRGBToHEX;
        private KryptonButton kbtnGlobalOptions;
        private KryptonButton kbtnThemeOptions;
        private KryptonButton kbtnSettings;
        private KryptonButton kbtnColourChooser1;
        private KryptonButton kbtnColourChooser2;
        private KryptonButton kbtnScrollbars;
        private KryptonButton kbtnToolstrips;
        private KryptonButton kbtnTypefaceSelectionDialogue;
        private KryptonButton kbtnPaletteEditor;
        private KryptonButton kbtnMessageboxTest;
        private KryptonButton kbtnFileCreator;
        private KryptonButton kbtnColourCreator;
        private KryptonButton kbtnColourMixer;
        private KryptonButton kbtnHexToRGB;
        private KryptonButton kbtnConvertColour;
        private KryptonButton kbtnAeroWizard;
        private KryptonButton kbtnThemeChooser;
        private KryptonButton Toast;
        private KryptonButton kbtnCircularProgressBar;
        private KryptonButton kbtnRandomPasswords;
        private KryptonButton kbtnScanFiles;
        private KryptonButton kbtnToastV2;
        private KryptonButton kbtnStatusStripItems;
        private KryptonButton kbtnKryptonCommandLinks;
        private KryptonButton kbtnCircularPictureBox;
        private KryptonButton kbtnFileHashValidator;
        private KryptonButton kbtnMRU;
        private KryptonButton kbtnResizeImages;
        private KryptonButton kryptonButton1;
        private System.ComponentModel.IContainer components;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Examples));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnResizeImages = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnMRU = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnFileHashValidator = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCircularPictureBox = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnKryptonCommandLinks = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnStatusStripItems = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnToastV2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnScanFiles = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnRandomPasswords = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCircularProgressBar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Toast = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnThemeChooser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnAeroWizard = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnListView = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnPropertyGrid = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnMessageboxTest2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnFileExplorer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnFileBrowser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnAdobeColourDialog = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnColourWheel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnMoreControls = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnKryptonWizard = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnRGBToHEX = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnGlobalOptions = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnThemeOptions = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnSettings = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnColourChooser1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnColourChooser2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnScrollbars = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnToolstrips = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnTypefaceSelectionDialogue = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnPaletteEditor = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnMessageboxTest = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnFileCreator = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnColourCreator = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnColourMixer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnHexToRGB = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnConvertColour = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonButton1);
            this.kryptonPanel1.Controls.Add(this.kbtnResizeImages);
            this.kryptonPanel1.Controls.Add(this.kbtnMRU);
            this.kryptonPanel1.Controls.Add(this.kbtnFileHashValidator);
            this.kryptonPanel1.Controls.Add(this.kbtnCircularPictureBox);
            this.kryptonPanel1.Controls.Add(this.kbtnKryptonCommandLinks);
            this.kryptonPanel1.Controls.Add(this.kbtnStatusStripItems);
            this.kryptonPanel1.Controls.Add(this.kbtnToastV2);
            this.kryptonPanel1.Controls.Add(this.kbtnScanFiles);
            this.kryptonPanel1.Controls.Add(this.kbtnRandomPasswords);
            this.kryptonPanel1.Controls.Add(this.kbtnCircularProgressBar);
            this.kryptonPanel1.Controls.Add(this.Toast);
            this.kryptonPanel1.Controls.Add(this.kbtnThemeChooser);
            this.kryptonPanel1.Controls.Add(this.kbtnAeroWizard);
            this.kryptonPanel1.Controls.Add(this.kbtnListView);
            this.kryptonPanel1.Controls.Add(this.kbtnPropertyGrid);
            this.kryptonPanel1.Controls.Add(this.kbtnMessageboxTest2);
            this.kryptonPanel1.Controls.Add(this.kbtnFileExplorer);
            this.kryptonPanel1.Controls.Add(this.kbtnFileBrowser);
            this.kryptonPanel1.Controls.Add(this.kbtnAdobeColourDialog);
            this.kryptonPanel1.Controls.Add(this.kbtnColourWheel);
            this.kryptonPanel1.Controls.Add(this.kbtnMoreControls);
            this.kryptonPanel1.Controls.Add(this.kbtnKryptonWizard);
            this.kryptonPanel1.Controls.Add(this.kbtnRGBToHEX);
            this.kryptonPanel1.Controls.Add(this.kbtnGlobalOptions);
            this.kryptonPanel1.Controls.Add(this.kbtnThemeOptions);
            this.kryptonPanel1.Controls.Add(this.kbtnSettings);
            this.kryptonPanel1.Controls.Add(this.kbtnColourChooser1);
            this.kryptonPanel1.Controls.Add(this.kbtnColourChooser2);
            this.kryptonPanel1.Controls.Add(this.kbtnScrollbars);
            this.kryptonPanel1.Controls.Add(this.kbtnToolstrips);
            this.kryptonPanel1.Controls.Add(this.kbtnTypefaceSelectionDialogue);
            this.kryptonPanel1.Controls.Add(this.kbtnPaletteEditor);
            this.kryptonPanel1.Controls.Add(this.kbtnMessageboxTest);
            this.kryptonPanel1.Controls.Add(this.kbtnFileCreator);
            this.kryptonPanel1.Controls.Add(this.kbtnColourCreator);
            this.kryptonPanel1.Controls.Add(this.kbtnColourMixer);
            this.kryptonPanel1.Controls.Add(this.kbtnHexToRGB);
            this.kryptonPanel1.Controls.Add(this.kbtnConvertColour);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(971, 597);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnResizeImages
            // 
            this.kbtnResizeImages.Location = new System.Drawing.Point(255, 368);
            this.kbtnResizeImages.Name = "kbtnResizeImages";
            this.kbtnResizeImages.Size = new System.Drawing.Size(218, 25);
            this.kbtnResizeImages.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnResizeImages.TabIndex = 88;
            this.kbtnResizeImages.Values.Text = "Resize Images";
            this.kbtnResizeImages.Click += new System.EventHandler(this.KbtnResizeImages_Click);
            // 
            // kbtnMRU
            // 
            this.kbtnMRU.Location = new System.Drawing.Point(12, 368);
            this.kbtnMRU.Name = "kbtnMRU";
            this.kbtnMRU.Size = new System.Drawing.Size(218, 25);
            this.kbtnMRU.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnMRU.TabIndex = 87;
            this.kbtnMRU.Values.Text = "MRU Example";
            this.kbtnMRU.Click += new System.EventHandler(this.KbtnMRU_Click);
            // 
            // kbtnFileHashValidator
            // 
            this.kbtnFileHashValidator.Location = new System.Drawing.Point(737, 326);
            this.kbtnFileHashValidator.Name = "kbtnFileHashValidator";
            this.kbtnFileHashValidator.Size = new System.Drawing.Size(218, 25);
            this.kbtnFileHashValidator.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnFileHashValidator.TabIndex = 86;
            this.kbtnFileHashValidator.Values.Text = "File Hash Validator";
            this.kbtnFileHashValidator.Click += new System.EventHandler(this.KbtnFileHashValidator_Click);
            // 
            // kbtnCircularPictureBox
            // 
            this.kbtnCircularPictureBox.Location = new System.Drawing.Point(497, 326);
            this.kbtnCircularPictureBox.Name = "kbtnCircularPictureBox";
            this.kbtnCircularPictureBox.Size = new System.Drawing.Size(218, 25);
            this.kbtnCircularPictureBox.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCircularPictureBox.TabIndex = 85;
            this.kbtnCircularPictureBox.Values.Text = "Circular Picturebox";
            this.kbtnCircularPictureBox.Click += new System.EventHandler(this.KbtnCircularPictureBox_Click);
            // 
            // kbtnKryptonCommandLinks
            // 
            this.kbtnKryptonCommandLinks.Location = new System.Drawing.Point(255, 326);
            this.kbtnKryptonCommandLinks.Name = "kbtnKryptonCommandLinks";
            this.kbtnKryptonCommandLinks.Size = new System.Drawing.Size(218, 25);
            this.kbtnKryptonCommandLinks.TabIndex = 84;
            this.kbtnKryptonCommandLinks.Values.Text = "Krypton Command Links";
            this.kbtnKryptonCommandLinks.Click += new System.EventHandler(this.KbtnKryptonCommandLinks_Click);
            // 
            // kbtnStatusStripItems
            // 
            this.kbtnStatusStripItems.Location = new System.Drawing.Point(12, 326);
            this.kbtnStatusStripItems.Name = "kbtnStatusStripItems";
            this.kbtnStatusStripItems.Size = new System.Drawing.Size(218, 25);
            this.kbtnStatusStripItems.TabIndex = 83;
            this.kbtnStatusStripItems.Values.Text = "Status Strip Items";
            this.kbtnStatusStripItems.Click += new System.EventHandler(this.KbtnStatusStripItems_Click);
            // 
            // kbtnToastV2
            // 
            this.kbtnToastV2.Location = new System.Drawing.Point(737, 285);
            this.kbtnToastV2.Name = "kbtnToastV2";
            this.kbtnToastV2.Size = new System.Drawing.Size(218, 25);
            this.kbtnToastV2.TabIndex = 82;
            this.kbtnToastV2.Values.Text = "Toast v2";
            this.kbtnToastV2.Click += new System.EventHandler(this.kbtnToastV2_Click);
            // 
            // kbtnScanFiles
            // 
            this.kbtnScanFiles.Location = new System.Drawing.Point(737, 246);
            this.kbtnScanFiles.Name = "kbtnScanFiles";
            this.kbtnScanFiles.Size = new System.Drawing.Size(218, 25);
            this.kbtnScanFiles.TabIndex = 81;
            this.kbtnScanFiles.Values.Text = "Scan Files";
            this.kbtnScanFiles.Click += new System.EventHandler(this.kbtnScanFiles_Click);
            // 
            // kbtnRandomPasswords
            // 
            this.kbtnRandomPasswords.Location = new System.Drawing.Point(737, 207);
            this.kbtnRandomPasswords.Name = "kbtnRandomPasswords";
            this.kbtnRandomPasswords.Size = new System.Drawing.Size(218, 25);
            this.kbtnRandomPasswords.TabIndex = 80;
            this.kbtnRandomPasswords.Values.Text = "Random Password Generator";
            this.kbtnRandomPasswords.Click += new System.EventHandler(this.kbtnRandomPasswords_Click);
            // 
            // kbtnCircularProgressBar
            // 
            this.kbtnCircularProgressBar.Location = new System.Drawing.Point(737, 168);
            this.kbtnCircularProgressBar.Name = "kbtnCircularProgressBar";
            this.kbtnCircularProgressBar.Size = new System.Drawing.Size(218, 25);
            this.kbtnCircularProgressBar.TabIndex = 79;
            this.kbtnCircularProgressBar.Values.Text = "Circular Progress Bar";
            this.kbtnCircularProgressBar.Click += new System.EventHandler(this.kbtnCircularProgressBar_Click);
            // 
            // Toast
            // 
            this.Toast.Location = new System.Drawing.Point(737, 129);
            this.Toast.Name = "Toast";
            this.Toast.Size = new System.Drawing.Size(218, 25);
            this.Toast.TabIndex = 78;
            this.Toast.Values.Text = "Toast";
            this.Toast.Click += new System.EventHandler(this.Toast_Click);
            // 
            // kbtnThemeChooser
            // 
            this.kbtnThemeChooser.Location = new System.Drawing.Point(737, 90);
            this.kbtnThemeChooser.Name = "kbtnThemeChooser";
            this.kbtnThemeChooser.Size = new System.Drawing.Size(218, 25);
            this.kbtnThemeChooser.TabIndex = 77;
            this.kbtnThemeChooser.Values.Text = "Theme Chooser";
            this.kbtnThemeChooser.Click += new System.EventHandler(this.kbtnThemeChooser_Click);
            // 
            // kbtnAeroWizard
            // 
            this.kbtnAeroWizard.Location = new System.Drawing.Point(737, 51);
            this.kbtnAeroWizard.Name = "kbtnAeroWizard";
            this.kbtnAeroWizard.Size = new System.Drawing.Size(218, 25);
            this.kbtnAeroWizard.TabIndex = 76;
            this.kbtnAeroWizard.Values.Text = "Aero Wizard";
            this.kbtnAeroWizard.Click += new System.EventHandler(this.KbtnAeroWizard_Click);
            // 
            // kbtnListView
            // 
            this.kbtnListView.Location = new System.Drawing.Point(737, 12);
            this.kbtnListView.Name = "kbtnListView";
            this.kbtnListView.Size = new System.Drawing.Size(218, 25);
            this.kbtnListView.TabIndex = 75;
            this.kbtnListView.Values.Text = "List View";
            this.kbtnListView.Click += new System.EventHandler(this.kbtnListView_Click);
            // 
            // kbtnPropertyGrid
            // 
            this.kbtnPropertyGrid.Location = new System.Drawing.Point(496, 285);
            this.kbtnPropertyGrid.Name = "kbtnPropertyGrid";
            this.kbtnPropertyGrid.Size = new System.Drawing.Size(218, 25);
            this.kbtnPropertyGrid.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnPropertyGrid.TabIndex = 74;
            this.kbtnPropertyGrid.Values.Text = "Property Grid";
            this.kbtnPropertyGrid.Click += new System.EventHandler(this.kbtnPropertyGrid_Click);
            // 
            // kbtnMessageboxTest2
            // 
            this.kbtnMessageboxTest2.Location = new System.Drawing.Point(496, 246);
            this.kbtnMessageboxTest2.Name = "kbtnMessageboxTest2";
            this.kbtnMessageboxTest2.Size = new System.Drawing.Size(218, 25);
            this.kbtnMessageboxTest2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnMessageboxTest2.TabIndex = 73;
            this.kbtnMessageboxTest2.Values.Text = "Messagebox Test 2";
            this.kbtnMessageboxTest2.Click += new System.EventHandler(this.kbtnMessageboxTest2_Click);
            // 
            // kbtnFileExplorer
            // 
            this.kbtnFileExplorer.Location = new System.Drawing.Point(496, 207);
            this.kbtnFileExplorer.Name = "kbtnFileExplorer";
            this.kbtnFileExplorer.Size = new System.Drawing.Size(218, 25);
            this.kbtnFileExplorer.TabIndex = 72;
            this.kbtnFileExplorer.Values.Text = "File Explorer";
            this.kbtnFileExplorer.Click += new System.EventHandler(this.kbtnFileExplorer_Click);
            // 
            // kbtnFileBrowser
            // 
            this.kbtnFileBrowser.Location = new System.Drawing.Point(496, 168);
            this.kbtnFileBrowser.Name = "kbtnFileBrowser";
            this.kbtnFileBrowser.Size = new System.Drawing.Size(218, 25);
            this.kbtnFileBrowser.TabIndex = 71;
            this.kbtnFileBrowser.Values.Text = "File Browser";
            this.kbtnFileBrowser.Click += new System.EventHandler(this.kbtnFileBrowser_Click);
            // 
            // kbtnAdobeColourDialog
            // 
            this.kbtnAdobeColourDialog.Location = new System.Drawing.Point(497, 129);
            this.kbtnAdobeColourDialog.Name = "kbtnAdobeColourDialog";
            this.kbtnAdobeColourDialog.Size = new System.Drawing.Size(218, 25);
            this.kbtnAdobeColourDialog.TabIndex = 70;
            this.kbtnAdobeColourDialog.Values.Text = "Adobe Colour Dialog";
            this.kbtnAdobeColourDialog.Click += new System.EventHandler(this.kbtnAdobeColourDialog_Click);
            // 
            // kbtnColourWheel
            // 
            this.kbtnColourWheel.Location = new System.Drawing.Point(497, 90);
            this.kbtnColourWheel.Name = "kbtnColourWheel";
            this.kbtnColourWheel.Size = new System.Drawing.Size(218, 25);
            this.kbtnColourWheel.TabIndex = 69;
            this.kbtnColourWheel.Values.Text = "Colour Wheel";
            this.kbtnColourWheel.Click += new System.EventHandler(this.kbtnColourWheel_Click);
            // 
            // kbtnMoreControls
            // 
            this.kbtnMoreControls.Location = new System.Drawing.Point(497, 51);
            this.kbtnMoreControls.Name = "kbtnMoreControls";
            this.kbtnMoreControls.Size = new System.Drawing.Size(218, 25);
            this.kbtnMoreControls.TabIndex = 68;
            this.kbtnMoreControls.Values.Text = "More Controls...";
            this.kbtnMoreControls.Click += new System.EventHandler(this.kbtnMoreControls_Click);
            // 
            // kbtnKryptonWizard
            // 
            this.kbtnKryptonWizard.Location = new System.Drawing.Point(497, 12);
            this.kbtnKryptonWizard.Name = "kbtnKryptonWizard";
            this.kbtnKryptonWizard.Size = new System.Drawing.Size(218, 25);
            this.kbtnKryptonWizard.TabIndex = 67;
            this.kbtnKryptonWizard.Values.Text = "Wizard";
            this.kbtnKryptonWizard.Click += new System.EventHandler(this.kbtnKryptonWizard_Click);
            // 
            // kbtnRGBToHEX
            // 
            this.kbtnRGBToHEX.Location = new System.Drawing.Point(255, 90);
            this.kbtnRGBToHEX.Name = "kbtnRGBToHEX";
            this.kbtnRGBToHEX.Size = new System.Drawing.Size(218, 25);
            this.kbtnRGBToHEX.TabIndex = 66;
            this.kbtnRGBToHEX.Values.Text = "Convert Colour (RGB to Hex)";
            this.kbtnRGBToHEX.Click += new System.EventHandler(this.kbtnRGBToHEX_Click);
            // 
            // kbtnGlobalOptions
            // 
            this.kbtnGlobalOptions.Location = new System.Drawing.Point(12, 285);
            this.kbtnGlobalOptions.Name = "kbtnGlobalOptions";
            this.kbtnGlobalOptions.Size = new System.Drawing.Size(218, 25);
            this.kbtnGlobalOptions.TabIndex = 65;
            this.kbtnGlobalOptions.Values.Text = "Global Options";
            this.kbtnGlobalOptions.Click += new System.EventHandler(this.kbtnGlobalOptions_Click);
            // 
            // kbtnThemeOptions
            // 
            this.kbtnThemeOptions.Location = new System.Drawing.Point(255, 285);
            this.kbtnThemeOptions.Name = "kbtnThemeOptions";
            this.kbtnThemeOptions.Size = new System.Drawing.Size(218, 25);
            this.kbtnThemeOptions.TabIndex = 64;
            this.kbtnThemeOptions.Values.Text = "Theme Options";
            this.kbtnThemeOptions.Click += new System.EventHandler(this.kbtnThemeOptions_Click);
            // 
            // kbtnSettings
            // 
            this.kbtnSettings.Location = new System.Drawing.Point(255, 246);
            this.kbtnSettings.Name = "kbtnSettings";
            this.kbtnSettings.Size = new System.Drawing.Size(218, 25);
            this.kbtnSettings.TabIndex = 63;
            this.kbtnSettings.Values.Text = "Settings Options";
            this.kbtnSettings.Click += new System.EventHandler(this.kbtnSettings_Click);
            // 
            // kbtnColourChooser1
            // 
            this.kbtnColourChooser1.Location = new System.Drawing.Point(12, 207);
            this.kbtnColourChooser1.Name = "kbtnColourChooser1";
            this.kbtnColourChooser1.Size = new System.Drawing.Size(218, 25);
            this.kbtnColourChooser1.TabIndex = 62;
            this.kbtnColourChooser1.Values.Text = "Colour Chooser 1";
            this.kbtnColourChooser1.Click += new System.EventHandler(this.kbtnColourChooser1_Click);
            // 
            // kbtnColourChooser2
            // 
            this.kbtnColourChooser2.Location = new System.Drawing.Point(12, 246);
            this.kbtnColourChooser2.Name = "kbtnColourChooser2";
            this.kbtnColourChooser2.Size = new System.Drawing.Size(218, 25);
            this.kbtnColourChooser2.TabIndex = 61;
            this.kbtnColourChooser2.Values.Text = "Colour Chooser 2";
            this.kbtnColourChooser2.Click += new System.EventHandler(this.kbtnColourChooser2_Click);
            // 
            // kbtnScrollbars
            // 
            this.kbtnScrollbars.Location = new System.Drawing.Point(12, 129);
            this.kbtnScrollbars.Name = "kbtnScrollbars";
            this.kbtnScrollbars.Size = new System.Drawing.Size(218, 25);
            this.kbtnScrollbars.TabIndex = 60;
            this.kbtnScrollbars.Values.Text = "Scrollbars";
            this.kbtnScrollbars.Click += new System.EventHandler(this.kbtnScrollbars_Click);
            // 
            // kbtnToolstrips
            // 
            this.kbtnToolstrips.Location = new System.Drawing.Point(12, 168);
            this.kbtnToolstrips.Name = "kbtnToolstrips";
            this.kbtnToolstrips.Size = new System.Drawing.Size(218, 25);
            this.kbtnToolstrips.TabIndex = 59;
            this.kbtnToolstrips.Values.Text = "Toolstrips";
            this.kbtnToolstrips.Click += new System.EventHandler(this.kbtnToolstrips_Click);
            // 
            // kbtnTypefaceSelectionDialogue
            // 
            this.kbtnTypefaceSelectionDialogue.Location = new System.Drawing.Point(255, 207);
            this.kbtnTypefaceSelectionDialogue.Name = "kbtnTypefaceSelectionDialogue";
            this.kbtnTypefaceSelectionDialogue.Size = new System.Drawing.Size(218, 25);
            this.kbtnTypefaceSelectionDialogue.TabIndex = 58;
            this.kbtnTypefaceSelectionDialogue.Values.Text = "Typeface Selection Dialogue";
            this.kbtnTypefaceSelectionDialogue.Click += new System.EventHandler(this.kbtnTypefaceSelectionDialogue_Click);
            // 
            // kbtnPaletteEditor
            // 
            this.kbtnPaletteEditor.Location = new System.Drawing.Point(12, 90);
            this.kbtnPaletteEditor.Name = "kbtnPaletteEditor";
            this.kbtnPaletteEditor.Size = new System.Drawing.Size(218, 25);
            this.kbtnPaletteEditor.TabIndex = 57;
            this.kbtnPaletteEditor.Values.Text = "Palette Editor";
            this.kbtnPaletteEditor.Click += new System.EventHandler(this.kbtnPaletteEditor_Click);
            // 
            // kbtnMessageboxTest
            // 
            this.kbtnMessageboxTest.Location = new System.Drawing.Point(12, 51);
            this.kbtnMessageboxTest.Name = "kbtnMessageboxTest";
            this.kbtnMessageboxTest.Size = new System.Drawing.Size(218, 25);
            this.kbtnMessageboxTest.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnMessageboxTest.TabIndex = 56;
            this.kbtnMessageboxTest.Values.Text = "Messagebox Test";
            this.kbtnMessageboxTest.Click += new System.EventHandler(this.kbtnMessageboxTest_Click);
            // 
            // kbtnFileCreator
            // 
            this.kbtnFileCreator.Location = new System.Drawing.Point(12, 12);
            this.kbtnFileCreator.Name = "kbtnFileCreator";
            this.kbtnFileCreator.Size = new System.Drawing.Size(218, 25);
            this.kbtnFileCreator.TabIndex = 55;
            this.kbtnFileCreator.Values.Text = "File Creator";
            this.kbtnFileCreator.Click += new System.EventHandler(this.kbtnFileCreator_Click);
            // 
            // kbtnColourCreator
            // 
            this.kbtnColourCreator.Location = new System.Drawing.Point(255, 168);
            this.kbtnColourCreator.Name = "kbtnColourCreator";
            this.kbtnColourCreator.Size = new System.Drawing.Size(218, 25);
            this.kbtnColourCreator.TabIndex = 54;
            this.kbtnColourCreator.Values.Text = "Colour Creator";
            this.kbtnColourCreator.Click += new System.EventHandler(this.kbtnColourCreator_Click);
            // 
            // kbtnColourMixer
            // 
            this.kbtnColourMixer.Location = new System.Drawing.Point(255, 129);
            this.kbtnColourMixer.Name = "kbtnColourMixer";
            this.kbtnColourMixer.Size = new System.Drawing.Size(218, 25);
            this.kbtnColourMixer.TabIndex = 53;
            this.kbtnColourMixer.Values.Text = "Colour Mixer";
            this.kbtnColourMixer.Click += new System.EventHandler(this.kbtnColourMixer_Click);
            // 
            // kbtnHexToRGB
            // 
            this.kbtnHexToRGB.Location = new System.Drawing.Point(255, 51);
            this.kbtnHexToRGB.Name = "kbtnHexToRGB";
            this.kbtnHexToRGB.Size = new System.Drawing.Size(218, 25);
            this.kbtnHexToRGB.TabIndex = 52;
            this.kbtnHexToRGB.Values.Text = "Convert Colour (Hex to RGB)";
            this.kbtnHexToRGB.Click += new System.EventHandler(this.kbtnHexToRGB_Click);
            // 
            // kbtnConvertColour
            // 
            this.kbtnConvertColour.Location = new System.Drawing.Point(255, 12);
            this.kbtnConvertColour.Name = "kbtnConvertColour";
            this.kbtnConvertColour.Size = new System.Drawing.Size(218, 25);
            this.kbtnConvertColour.TabIndex = 51;
            this.kbtnConvertColour.Values.Text = "Convert Colour";
            this.kbtnConvertColour.Click += new System.EventHandler(this.kbtnConvertColour_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(497, 368);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(218, 25);
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 89;
            this.kryptonButton1.Values.Text = "Resize Images";
            // 
            // Examples
            // 
            this.ClientSize = new System.Drawing.Size(971, 597);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Examples";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krypton Toolkit Suite Extended for .NET 4.7 - Examples";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        public Examples()
        {
            InitializeComponent();
        }

        private void kbtnFileCreator_Click(object sender, EventArgs e)
        {
            PaletteExplorer.UX.PaletteFileEditor paletteFileEditor = new PaletteExplorer.UX.PaletteFileEditor();

            paletteFileEditor.Show();
        }

        private void kbtnMessageboxTest_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show(this, @"Test KryptonMessagebox", @"Check Title Text Size", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ExtendedKryptonMessageBox.Show(this, @"Test ExtendedKryptonMessageBox Default 12", @"Check Title Text Size", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ExtendedKryptonMessageBox.Show(this, @"Test ExtendedKryptonMessageBox specified 20", @"Check Title Text Size", MessageBoxButtons.OK, MessageBoxIcon.Information, messageboxTypeface: new Font(@"Tahoma", 20F));
        }

        private void kbtnPaletteEditor_Click(object sender, EventArgs e)
        {
            PaletteExplorer.UX.MainWindow _mainWindow = new PaletteExplorer.UX.MainWindow();

            _mainWindow.Show();
        }

        private void kbtnScrollbars_Click(object sender, EventArgs e)
        {
            Scrollbars scrollbars = new Scrollbars();

            scrollbars.Show();
        }

        private void kbtnToolstrips_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();

            mainWindow.Show();
        }

        private void kbtnColourChooser1_Click(object sender, EventArgs e)
        {
            KryptonColourChooser1 kryptonColourChooser1 = new KryptonColourChooser1();

            kryptonColourChooser1.Show();
        }

        private void kbtnColourChooser2_Click(object sender, EventArgs e)
        {
            KryptonColourChooser2 kryptonColourChooser2 = new KryptonColourChooser2();

            kryptonColourChooser2.Show();
        }

        private void kbtnGlobalOptions_Click(object sender, EventArgs e)
        {
            GlobalOptionsMenu globalOptionsMenu = new GlobalOptionsMenu();

            globalOptionsMenu.Show();
        }

        private void kbtnSettings_Click(object sender, EventArgs e)
        {
            SettingsManagementOptions settingsManagementOptions = new SettingsManagementOptions();

            settingsManagementOptions.Show();
        }

        private void kbtnConvertColour_Click(object sender, EventArgs e)
        {
            ColourRGBToHexadecimalConverter colourRGBToHexadecimalConverter = new ColourRGBToHexadecimalConverter();

            colourRGBToHexadecimalConverter.Show();
        }

        private void kbtnHexToRGB_Click(object sender, EventArgs e)
        {
            ColourHexadecimalToRGBConverter colourHexadecimalToRGBConverter = new ColourHexadecimalToRGBConverter();

            colourHexadecimalToRGBConverter.Show();
        }

        private void kbtnRGBToHEX_Click(object sender, EventArgs e)
        {
            HexadecimalToRGBConverter hexadecimalToRGBConverter = new HexadecimalToRGBConverter();

            hexadecimalToRGBConverter.Show();
        }

        private void kbtnColourMixer_Click(object sender, EventArgs e)
        {
            ColourMixer colourMixer = new ColourMixer(255, 255, 255, 255);

            colourMixer.Show();
        }

        private void kbtnColourCreator_Click(object sender, EventArgs e)
        {
            PaletteColourCreator paletteColourCreator = new PaletteColourCreator();

            paletteColourCreator.Show();
        }

        private void kbtnTypefaceSelectionDialogue_Click(object sender, EventArgs e)
        {
            //TypefaceSelectionDialogue typefaceSelectionDialogue = new TypefaceSelectionDialogue();

            //typefaceSelectionDialogue.Show();

            TypefaceSelector typefaceSelector = new TypefaceSelector();

            typefaceSelector.Show();
        }

        private void kbtnThemeOptions_Click(object sender, EventArgs e)
        {
            ThemeOptions themeOptions = new ThemeOptions();

            themeOptions.Show();
        }

        private void kbtnKryptonWizard_Click(object sender, EventArgs e)
        {
            KryptonWizardExample wt = new KryptonWizardExample();

            wt.Show();
        }

        private void kbtnMoreControls_Click(object sender, EventArgs e)
        {
            MoreControls mc = new MoreControls();

            mc.Show();
        }

        private void kbtnColourWheel_Click(object sender, EventArgs e)
        {
            ColourTest ct = new ColourTest();

            ct.Show();
        }

        private void kbtnAdobeColourDialog_Click(object sender, EventArgs e)
        {
            AdobeColourDialog adobeColourDialog = new AdobeColourDialog(Color.White);

            adobeColourDialog.Show();
        }

        private void kbtnFileBrowser_Click(object sender, EventArgs e)
        {
            KryptonFileBrowser kryptonFileBrowser = new KryptonFileBrowser();

            kryptonFileBrowser.Show();
        }

        private void kbtnFileExplorer_Click(object sender, EventArgs e)
        {
            KryptonFileExplorer kfe = new KryptonFileExplorer();

            kfe.Show();
        }

        private void kbtnMessageboxTest2_Click(object sender, EventArgs e)
        {
            MessageBoxTest mbt = new MessageBoxTest();

            mbt.Show();
        }

        private void kbtnPropertyGrid_Click(object sender, EventArgs e)
        {
            PropertyGridTest pgt = new PropertyGridTest();

            pgt.Show();
        }

        private void kbtnListView_Click(object sender, EventArgs e)
        {
            Test test = new Test();

            test.Show();
        }

        private void kbtnThemeChooser_Click(object sender, EventArgs e)
        {
            ThemeChooser themeChooser = new ThemeChooser();

            themeChooser.Show();
        }

        private void Toast_Click(object sender, EventArgs e)
        {
            Image test = new Bitmap(Properties.Resources.Information_128_x_128);

            KryptonToastNotification kryptonToastNotification = new KryptonToastNotification(true, test, "Krypton Toast Notification", "Hello world!\n\nYou can use this area to show your messages.\n\nFeatures will be added in the future.\n\nThe supported maximum image size is 128 x 128.", true, ActionType.LAUCHPROCESS, Path.GetFullPath(Application.ExecutablePath));

            kryptonToastNotification.Seconds = 60;

            //kryptonToastNotification.ActionType = ActionType.LAUCHPROCESS;

            //kryptonToastNotification.ProcessName = Path.GetFullPath(Application.ExecutablePath);

            //kryptonToastNotification.ShowActionButton = true;

            kryptonToastNotification.Show();
        }

        private void kbtnCircularProgressBar_Click(object sender, EventArgs e)
        {
            CircularProgressBarTest cpbt = new CircularProgressBarTest();

            cpbt.Show();
        }

        private void kbtnRandomPasswords_Click(object sender, EventArgs e)
        {
            RandomPasswordGenerator rpg = new RandomPasswordGenerator(5, 20, 10);

            rpg.Show();
        }

        private void kbtnScanFiles_Click(object sender, EventArgs e)
        {
            VirusTotalUploader uploader = new VirusTotalUploader();

            uploader.Show();
        }

        private void kbtnToastV2_Click(object sender, EventArgs e)
        {
            KryptonToastNotificationPopup kryptonToast = new KryptonToastNotificationPopup();

            kryptonToast.TitleText = "Hello World";

            kryptonToast.ContentText = "Foo Bar";

            kryptonToast.ShowCloseButton = true;

            kryptonToast.ShowOptionsButton = true;

            kryptonToast.ShowGrip = true;

            kryptonToast.Delay = 1000;

            kryptonToast.AnimationInterval = 250;

            kryptonToast.AnimationDuration = 1000;

            kryptonToast.TitlePadding = new Padding(10);

            kryptonToast.ContentPadding = new Padding(10);

            kryptonToast.ImagePadding = new Padding(10);

            kryptonToast.Scroll = true;

            kryptonToast.Image = Resources.KR_32_x_32_Orange;

            kryptonToast.Popup();
        }

        private void KbtnStatusStripItems_Click(object sender, EventArgs e)
        {
            StatusStripControls ssc = new StatusStripControls();

            ssc.Show();
        }

        private void KbtnKryptonCommandLinks_Click(object sender, EventArgs e)
        {
            KryptonCommandLinks kcl = new KryptonCommandLinks();

            kcl.Show();
        }

        private void KbtnCircularPictureBox_Click(object sender, EventArgs e)
        {
            CircularPictureBox circularPictureBox = new CircularPictureBox();

            circularPictureBox.Show();
        }

        private void KbtnFileHashValidator_Click(object sender, EventArgs e)
        {
            HashFile hashFile = new HashFile();

            hashFile.Show();
        }

        private void KbtnMRU_Click(object sender, EventArgs e)
        {
            MRUExample mru = new MRUExample();

            mru.Show();
        }

        private void KbtnResizeImages_Click(object sender, EventArgs e)
        {
            KryptonImageResizingToolWindow window = new KryptonImageResizingToolWindow();

            window.Show();
        }

        private void KbtnAeroWizard_Click(object sender, EventArgs e)
        {

        }
    }
}