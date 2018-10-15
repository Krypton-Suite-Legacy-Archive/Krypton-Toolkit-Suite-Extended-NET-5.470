using ComponentFactory.Krypton.Toolkit;
using GlobalUtilities.Interfaces;
using KryptonExtendedToolkit.Base.Code;
using PaletteEditor.Classes;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Tooling.Classes.Other;
using Tooling.Settings.Classes;
using Tooling.UX;

namespace PaletteEditor.UX
{
    public partial class MainWindow : KryptonForm
    {
        #region Variables
        private bool _dirty, _loaded, _debugMode, _useCircularPictureBoxes;

        private string _fileName;

        private KryptonPalette _palette;

        private PaletteMode _paletteMode;

        private ConversionMethods _conversionMethods = new ConversionMethods();

        private ColourSettingsManager _colourSettingsManager = new ColourSettingsManager();

        private Classes.GlobalMethods _globalMethods = new Classes.GlobalMethods();

        private GlobalStringSettingsManager _globalStringSettingsManager = new GlobalStringSettingsManager();

        private GlobalBooleanSettingsManager _globalBooleanSettingsManager = new GlobalBooleanSettingsManager();

        private MostRecentlyUsedFileManager _mostRecentlyUsedFileManager;

        private Version _currentVersion = Assembly.GetExecutingAssembly().GetName().Version;

        private Timer _colourUpdateTimer;

        private IAbout _about;
        #endregion

        #region Properties
        public bool DebugMode { get { return _debugMode; } set { _debugMode = value; } }

        public bool Dirty { get { return _dirty; } set { _dirty = value; } }

        public bool Loaded { get { return _loaded; } set { _loaded = value; } }

        public bool UseCircularPictureBoxes { get { return _useCircularPictureBoxes; } set { _useCircularPictureBoxes = value; } }

        public string FileName { get { return _fileName; } set { _fileName = value; } }

        public new KryptonPalette Palette { get { return _palette; } set { _palette = value; } }

        public new PaletteMode PaletteMode { get { return _paletteMode; } set { _paletteMode = value; } }
        #endregion

        public MainWindow()
        {
            InitializeComponent();

            _colourUpdateTimer = new Timer();

            _colourUpdateTimer.Interval = 250;

            _colourUpdateTimer.Tick += new EventHandler(ColourUpdateTimer_Tick);

            DebugMode = _globalBooleanSettingsManager.GetDevelopmentMode();

            UseCircularPictureBoxes = _globalBooleanSettingsManager.GetUseCircularPictureBoxes();

            //IAbout.ApplicationIcon = Icon;

            //IAbout.ApplicationIconImage = new Bitmap("Resources\\PE Icon 512 x 512.png");

            //IAbout.ApplicationName = "Palette Editor";
        }

        private void ColourUpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateColourPalette(UseCircularPictureBoxes);

            ShowCircularPreviewBoxes(UseCircularPictureBoxes);
        }

        #region Operations
        private void New()
        {
            // If the current palette has been changed
            if (Dirty)
            {
                // Ask user if the current palette should be saved
                switch (KryptonMessageBox.Show(this,
                                        "Save changes to the current palette?",
                                        "Palette Changed",
                                        MessageBoxButtons.YesNoCancel,
                                        MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        // Use existing save method
                        Save();
                        break;
                    case DialogResult.Cancel:
                        // Cancel out entirely
                        return;
                }
            }

            // Generate a fresh palette from scratch
            CreateNewPalette();
        }

        private void Open()
        {
            tslStatus.Text = "Attempting to inport colours from selected palette. Please wait...";

            // If the current palette has been changed
            if (Dirty)
            {
                // Ask user if the current palette should be saved
                switch (KryptonMessageBox.Show(this,
                                        "Save changes to the current palette?",
                                        "Palette Changed",
                                        MessageBoxButtons.YesNoCancel,
                                        MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        // Use existing save method
                        Save();
                        break;
                    case DialogResult.Cancel:
                        // Cancel out entirely
                        return;
                }
            }

            // Create a fresh palette instance for loading into
            KryptonPalette palette = new KryptonPalette();

            // Get the name of the file we imported from
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            string filename = palette.Import();
            Cursor = Cursors.Default;

            // If the load succeeded
            if (filename.Length > 0)
            {
                // Need to unhook from any existing palette
                if (Palette != null)
                    Palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

                // Use the new instance instead
                Palette = palette;

                // We need to know when a change occurs to the palette settings
                Palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

                // Hook up the property grid to the palette
                labelGridNormal.SelectedObject = Palette;

                // Use the loaded filename
                FileName = filename;

                // Reset the state flags
                Loaded = true;
                Dirty = false;

                // Define the initial title bar string
                UpdateTitlebar();
            }

            PaletteImportManager paletteImportManager = new PaletteImportManager();

            paletteImportManager.ImportColourScheme(palette);

            kchkUpdateColours.Enabled = true;

            kcmbBasePaletteMode.Text = _globalStringSettingsManager.GetBasePaletteMode();

            tslStatus.Text = _globalStringSettingsManager.GetFeedbackText();

            kchkUpdateColours.Checked = true;

            invertColoursToolStripMenuItem.Enabled = true;

            kchkInvertColours.Enabled = true;

            _mostRecentlyUsedFileManager.AddRecentFile(filename);
        }

        private void Save()
        {
            // If we already have a file associated with the palette...
            if (Loaded)
            {
                // ...then just save it straight away
                Cursor = Cursors.WaitCursor;
                Application.DoEvents();
                Palette.Export(FileName, true, false);
                Cursor = Cursors.Default;

                // No longer dirty
                Dirty = false;

                // Define the initial title bar string
                UpdateTitlebar();
            }
            else
            {
                // No association and so perform a save as instead
                SaveAs();
            }
        }

        private void SaveAs()
        {
            // Get back the filename selected by the user
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            string filename = Palette.Export();
            Cursor = Cursors.Default;

            // If the save succeeded
            if (filename.Length > 0)
            {
                // Remember associated file details
                FileName = filename;
                Loaded = true;

                // No longer dirty
                Dirty = false;

                // Define the initial title bar string
                UpdateTitlebar();
            }
        }

        private void Exit()
        {
            // If the current palette has been changed
            if (Dirty)
            {
                // Ask user if the current palette should be saved
                switch (KryptonMessageBox.Show(this,
                                        "Save changes to the current palette?",
                                        "Palette Changed",
                                        MessageBoxButtons.YesNoCancel,
                                        MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        // Use existing save method
                        Save();
                        break;
                    case DialogResult.Cancel:
                        // Cancel out entirely
                        return;
                }
            }

            Close();
        }
        #endregion

        #region Palettes
        private void CreateNewPalette()
        {
            // Need to unhook from any existing palette
            if (Palette != null)
                Palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            // Create a fresh palette instance
            Palette = new KryptonPalette();

            // We need to know when a change occurs to the palette settings
            Palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            // Hook up the property grid to the palette
            labelGridNormal.SelectedObject = Palette;

            // Does not have a filename as yet
            FileName = "(New Palette)";

            // Reset the state flags
            Dirty = false;
            Loaded = false;

            // Define the initial title bar string
            UpdateTitlebar();
        }

        private void OnPalettePaint(object sender, PaletteLayoutEventArgs e)
        {
            // Only interested the first time the palette is changed
            if (!Dirty)
            {
                Dirty = true;
                UpdateTitlebar();
            }

        }
        #endregion

        #region Implementation
        private void UpdateTitlebar()
        {
            // Mark a changed file with a star
            Text = "Palette Editor - " + FileName + (Dirty ? "*" : string.Empty);
        }
        #endregion

        private void MainWindow_Load(object sender, EventArgs e)
        {
            New();

            _mostRecentlyUsedFileManager = new MostRecentlyUsedFileManager(recentPaletteDefinitionsToolStripMenuItem, "Palette Editor", MyOwnRecentPaletteFileGotClicked_Handler, MyOwnRecentPaletteFilesGotCleared_Handler);

            ColourUtilities.PropagateBasePaletteModes(kcmbBasePaletteMode);

            _colourSettingsManager.ResetSettings(DebugMode);

            if (UseCircularPictureBoxes)
            {
                ShowCircularPreviewBoxes(_globalBooleanSettingsManager.GetUseCircularPictureBoxes());
            }

            TextExtra = $"(Build: { _currentVersion.Build.ToString() })";
        }

        #region Picture Box Mouse Enter Events
        private void pbxBaseColour_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxBaseColour, false, "Base Colour", lblColourOutput);
        }

        private void pbxDarkColour_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxDarkColour, false, "Dark Colour", lblColourOutput);

        }

        private void pbxMiddleColour_MouseEnter(object sender, EventArgs e)
        {
            //ttInformation.SetToolTip(pbxMiddleColour, $"Middle Colour\nARGB: ({ ColourUtilities.FormatColourARGBString(pbxMiddleColour.BackColor) })\nRGB: ({ ColourUtilities.FormatColourRGBString(pbxMiddleColour.BackColor) })\nHexadecimal Value: #{ _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(pbxMiddleColour.BackColor.R), Convert.ToInt32(pbxMiddleColour.BackColor.G), Convert.ToInt32(pbxMiddleColour.BackColor.B)).ToUpper() }\nHue: { pbxMiddleColour.BackColor.GetHue().ToString() }\nSaturation: { pbxMiddleColour.BackColor.GetSaturation().ToString() }\nBrightness: { pbxMiddleColour.BackColor.GetBrightness().ToString() }");

            InformationControlManager.DisplayColourInformation(pbxMiddleColour, false, "Middle Colour", lblColourOutput);
        }

        private void pbxLightColour_MouseEnter(object sender, EventArgs e)
        {
            //ttInformation.SetToolTip(pbxLightColour, $"Light Colour\nARGB: ({ ColourUtilities.FormatColourARGBString(pbxLightColour.BackColor) })\nRGB: ({ ColourUtilities.FormatColourRGBString(pbxLightColour.BackColor) })\nHexadecimal Value: #{ _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(pbxLightColour.BackColor.R), Convert.ToInt32(pbxLightColour.BackColor.G), Convert.ToInt32(pbxLightColour.BackColor.B)).ToUpper() }\nHue: { pbxLightColour.BackColor.GetHue().ToString() }\nSaturation: { pbxLightColour.BackColor.GetSaturation().ToString() }\nBrightness: { pbxLightColour.BackColor.GetBrightness().ToString() }");

            InformationControlManager.DisplayColourInformation(pbxLightColour, false, "Light Colour", lblColourOutput);
        }

        private void pbxLightestColour_MouseEnter(object sender, EventArgs e)
        {
            //ttInformation.SetToolTip(pbxLightestColour, $"Lightest Colour\nARGB: ({ ColourUtilities.FormatColourARGBString(pbxLightestColour.BackColor) })\nRGB: ({ ColourUtilities.FormatColourRGBString(pbxLightestColour.BackColor) })\nHexadecimal Value: #{ _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(pbxLightestColour.BackColor.R), Convert.ToInt32(pbxLightestColour.BackColor.G), Convert.ToInt32(pbxLightestColour.BackColor.B)).ToUpper() }\nHue: { pbxLightestColour.BackColor.GetHue().ToString() }\nSaturation: { pbxLightestColour.BackColor.GetSaturation().ToString() }\nBrightness: { pbxLightestColour.BackColor.GetBrightness().ToString() }");

            InformationControlManager.DisplayColourInformation(pbxLightestColour, false, "Lightest Colour", lblColourOutput);
        }

        private void pbxBorderColourPreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxBorderColourPreview, false, "Border Colour", lblColourOutput);
        }

        private void pbxAlternativeNormalTextColour_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxAlternativeNormalTextColour, false, "Alternative Text Colour", lblColourOutput);
        }

        private void pbxNormalTextColourPreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxNormalTextColourPreview, false, "Normal Text Colour", lblColourOutput);
        }

        private void pbxDisabledTextColourPreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxDisabledTextColourPreview, false, "Disabled Text Colour", lblColourOutput);
        }

        private void pbxFocusedTextColourPreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxFocusedTextColourPreview, false, "Focused Text Colour", lblColourOutput);
        }

        private void pbxPressedTextColourPreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxPressedTextColourPreview, false, "Pressed Text Colour", lblColourOutput);
        }

        private void pbxDisabledColourPreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxDisabledColourPreview, false, "Disabled Colour", lblColourOutput);
        }

        private void pbxLinkNormalColourPreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxLinkNormalColourPreview, false, "Link Normal Text Colour", lblColourOutput);
        }

        private void pbxLinkHoverColourPreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxLinkHoverColourPreview, false, "Link Hover Text Colour", lblColourOutput);
        }

        private void pbxLinkVisitedColourPreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxLinkVisitedColourPreview, false, "Link Visited Text Colour", lblColourOutput);
        }

        private void pbxCustomColourOnePreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxCustomColourOnePreview, false, "Custom One Colour", lblColourOutput);
        }

        private void pbxCustomColourTwoPreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxCustomColourTwoPreview, false, "Custom Two Colour", lblColourOutput);
        }

        private void pbxCustomColourThreePreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxCustomColourThreePreview, false, "Custom Three Colour", lblColourOutput);
        }

        private void pbxCustomColourFourPreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxCustomColourFourPreview, false, "Custom Four Colour", lblColourOutput);
        }

        private void pbxCustomColourFivePreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxCustomColourFivePreview, false, "Custom Five Colour", lblColourOutput);
        }

        private void pbxCustomTextColourOnePreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxCustomTextColourOnePreview, false, "Custom One Text Colour", lblColourOutput);
        }

        private void pbxCustomTextColourTwoPreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxCustomTextColourTwoPreview, false, "Custom Two Text Colour", lblColourOutput);
        }

        private void pbxCustomTextColourThreePreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxCustomTextColourThreePreview, false, "Custom Three Text Colour", lblColourOutput);
        }

        private void pbxCustomTextColourFourPreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxCustomTextColourFourPreview, false, "Custom Four Text Colour", lblColourOutput);
        }

        private void pbxCustomTextColourFivePreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxCustomTextColourFivePreview, false, "Custom Five Text Colour", lblColourOutput);
        }

        private void pbxMenuTextColourPreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxMenuTextColourPreview, false, "Menu Text Colour", lblColourOutput);
        }

        private void pbxStatusTextColourPreview_MouseEnter(object sender, EventArgs e)
        {
            InformationControlManager.DisplayColourInformation(pbxStatusTextColourPreview, false, "Status Text Colour", lblColourOutput);
        }
        #endregion

        private void kbtnGenerate_Click(object sender, EventArgs e)
        {
            if (UseCircularPictureBoxes)
            {
                GenerateColourScheme(cbxBaseColourPreview.BackColor);
            }
            else
            {
                GenerateColourScheme(pbxBaseColour.BackColor);
            }
        }

        private void newPaletteDefinitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }

        private void openExistingPaletteDefinitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void savePaletteDefinitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void savePaletteDefinitionAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void kbtnExport_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void kbtnGetColours_Click(object sender, EventArgs e)
        {
            GrabPaletteColours(UseCircularPictureBoxes);
        }

        private void pbxBaseColour_MouseLeave(object sender, EventArgs e)
        {
            InformationControlManager.ResetColourValueInformation(lblColourOutput);
        }

        private void pbxDarkColour_MouseLeave(object sender, EventArgs e)
        {
            InformationControlManager.ResetColourValueInformation(lblColourOutput);
        }

        private void pbxMiddleColour_MouseLeave(object sender, EventArgs e)
        {
            InformationControlManager.ResetColourValueInformation(lblColourOutput);
        }

        private void pbxLightColour_MouseLeave(object sender, EventArgs e)
        {
            InformationControlManager.ResetColourValueInformation(lblColourOutput);
        }

        private void kbtnClose_Click(object sender, EventArgs e)
        {
            ExitPaletteEditor();
        }

        private void ExitPaletteEditor()
        {
            if (Dirty)
            {
                DialogResult result = KryptonMessageBox.Show("The palette has not yet been saved.\nDo you want to save now?", "Palette Editor Save Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (Loaded)
                    {
                        Save();

                        Application.Exit();
                    }
                    else
                    {
                        Save();

                        Application.Exit();
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void pbxLightestColour_MouseLeave(object sender, EventArgs e)
        {
            InformationControlManager.ResetColourValueInformation(lblColourOutput);
        }

        private void pbxBorderColourPreview_MouseLeave(object sender, EventArgs e)
        {
            InformationControlManager.ResetColourValueInformation(lblColourOutput);
        }

        private void pbxAlternativeNormalTextColour_MouseLeave(object sender, EventArgs e)
        {
            InformationControlManager.ResetColourValueInformation(lblColourOutput);
        }

        private void pbxNormalTextColourPreview_MouseLeave(object sender, EventArgs e)
        {
            InformationControlManager.ResetColourValueInformation(lblColourOutput);
        }

        private void pbxDisabledTextColourPreview_MouseLeave(object sender, EventArgs e)
        {
            InformationControlManager.ResetColourValueInformation(lblColourOutput);
        }

        private void pbxFocusedTextColourPreview_MouseLeave(object sender, EventArgs e)
        {
            InformationControlManager.ResetColourValueInformation(lblColourOutput);
        }

        private void pbxPressedTextColourPreview_MouseLeave(object sender, EventArgs e)
        {
            InformationControlManager.ResetColourValueInformation(lblColourOutput);
        }

        private void pbxDisabledColourPreview_MouseHover(object sender, EventArgs e)
        {
            InformationControlManager.ResetColourValueInformation(lblColourOutput);
        }

        private void kbtnViewPaletteFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Title = "Open A Palette File:";

            openFile.Filter = "Krypton Palette Files (*.xml)|*.xml";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                PaletteFileEditor paletteFileEditor = new PaletteFileEditor(Path.GetFullPath(openFile.FileName));

                paletteFileEditor.Show();
            }
        }

        private void kbtnGenerateContrastColours_Click(object sender, EventArgs e)
        {
            ContrastColourGenerator contrastColourGenerator = new ContrastColourGenerator();

            contrastColourGenerator.Show();
        }

        private void cbxBaseColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxBaseColourPreview_MouseEnter(object sender, EventArgs e)
        {
            Tooling.Classes.Other.ToolTipManager.DisplayToolTip(ttInformation, cbxBaseColourPreview, "Base", cbxBaseColourPreview.BackColor, true);
        }

        private void kcmbBasePaletteMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kcmbBasePaletteMode.Text == "Global")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Global);
            }
            else if (kcmbBasePaletteMode.Text == "ProfessionalSystem")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.ProfessionalSystem);
            }
            else if (kcmbBasePaletteMode.Text == "ProfessionalOffice2003")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.ProfessionalOffice2003);
            }
            else if (kcmbBasePaletteMode.Text == "Office2007Black")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2007Black);
            }
            else if (kcmbBasePaletteMode.Text == "Office2007Blue")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2007Blue);
            }
            else if (kcmbBasePaletteMode.Text == "Office2007Silver")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2007Silver);
            }
            else if (kcmbBasePaletteMode.Text == "Office2010Black")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2010Black);
            }
            else if (kcmbBasePaletteMode.Text == "Office2010Blue")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2010Blue);
            }
            else if (kcmbBasePaletteMode.Text == "Office2010Silver")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2010Silver);
            }
            else if (kcmbBasePaletteMode.Text == "Office2013")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2013);
            }
            else if (kcmbBasePaletteMode.Text == "Office2013White")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2013White);
            }
            else if (kcmbBasePaletteMode.Text == "SparkleBlue")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.SparkleBlue);
            }
            else if (kcmbBasePaletteMode.Text == "SparkleOrange")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.SparkleOrange);
            }
            else if (kcmbBasePaletteMode.Text == "SparklePurple")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.SparklePurple);
            }
            else if (kcmbBasePaletteMode.Text == "Custom")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Custom);
            }

            GetCurrentSavedPaletteMode();
        }

        private void tmrUpdateUI_Tick(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void kbtnExportPalette_Click(object sender, EventArgs e)
        {
            //PaletteEditorEngine.ExportPaletteTheme(palette, PaletteMode.Office2007Silver, pbxBaseColour, pbxDarkColour, pbxMiddleColour, pbxLightColour, pbxLightestColour, pbxBorderColourPreview, pbxAlternativeNormalTextColour, pbxNormalTextColourPreview, pbxDisabledTextColourPreview, pbxFocusedTextColourPreview, pbxPressedTextColourPreview, pbxDisabledColourPreview, pbxLinkNormalColourPreview, pbxLinkHoverColourPreview, pbxLinkVisitedColourPreview, tslStatus);

            ExportPaletteColours(UseCircularPictureBoxes);
        }

        #region Misc        
        /// <summary>
        /// Gets the current saved palette mode.
        /// </summary>
        private void GetCurrentSavedPaletteMode()
        {
            tslStatus.Text = $"The current palette mode is: { _globalMethods.GetSelectedPaletteMode() }";
        }

        private void ExportPaletteColours(bool useCircularPictureBoxes)
        {
            if (useCircularPictureBoxes)
            {
                PaletteEditorEngine.ExportPalette(_globalMethods.GetSelectedPaletteMode(), cbxBaseColourPreview, cbxDarkColourPreview, cbxMiddleColourPreview, cbxLightColourPreview, cbxLightestColourPreview, cbxBorderColourPreview, cbxAlternativeNormalTextColourPreview, cbxNormalTextColourPreview, cbxDisabledTextColourPreview, cbxFocusedTextColourPreview, cbxPressedTextColourPreview, cbxDisabledColourPreview, cbxLinkNormalColourPreview, cbxLinkHoverColourPreview, cbxLinkVisitedColourPreview, cbxCustomColourOnePreview, cbxCustomColourTwoPreview, cbxCustomColourThreePreview, cbxCustomColourFourPreview, cbxCustomColourFivePreview, cbxCustomTextColourOnePreview, cbxCustomTextColourTwoPreview, cbxCustomTextColourThreePreview, cbxCustomTextColourFourPreview, cbxCustomTextColourFivePreview, cbxMenuTextColourPreview, cbxStatusTextColourPreview, tslStatus);
            }
            else
            {
                PaletteEditorEngine.ExportPalette(_globalMethods.GetSelectedPaletteMode(), pbxBaseColour, pbxDarkColour, pbxMiddleColour, pbxLightColour, pbxLightestColour, pbxBorderColourPreview, pbxAlternativeNormalTextColour, pbxNormalTextColourPreview, pbxDisabledTextColourPreview, pbxFocusedTextColourPreview, pbxPressedTextColourPreview, pbxDisabledColourPreview, pbxLinkNormalColourPreview, pbxLinkHoverColourPreview, pbxLinkVisitedColourPreview, pbxCustomColourOnePreview, pbxCustomColourTwoPreview, pbxCustomColourThreePreview, pbxCustomColourFourPreview, pbxCustomColourFivePreview, pbxCustomTextColourOnePreview, pbxCustomTextColourTwoPreview, pbxCustomTextColourThreePreview, pbxCustomTextColourFourPreview, pbxCustomTextColourFivePreview, pbxMenuTextColourPreview, pbxStatusTextColourPreview, tslStatus);
            }
        }

        private void kbtnGetColourInformation_Click(object sender, EventArgs e)
        {
            ColourInformation colourInformation = new ColourInformation();

            colourInformation.Show();
        }

        private void kbtnImportColourScheme_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void kchkUpdateColours_CheckedChanged(object sender, EventArgs e)
        {
            _colourUpdateTimer.Enabled = kchkUpdateColours.Checked;
        }

        private void ResetColours(bool useCircularPictureBoxes)
        {
            if (useCircularPictureBoxes)
            {
                kgbPreviewPane.Visible = false;

                kgbCircularColourPreviewPane.Visible = true;

                ColourUtilities.ResetColourDefinitions(cbxBaseColourPreview, cbxDarkColourPreview, cbxMiddleColourPreview, cbxLightColourPreview, cbxLightestColourPreview, cbxBorderColourPreview, cbxAlternativeNormalTextColourPreview, cbxNormalTextColourPreview, cbxDisabledTextColourPreview, cbxFocusedTextColourPreview, cbxPressedTextColourPreview, cbxDisabledColourPreview, cbxLinkNormalColourPreview, cbxLinkHoverColourPreview, cbxLinkVisitedColourPreview, cbxCustomColourOnePreview, cbxCustomColourTwoPreview, cbxCustomColourThreePreview, cbxCustomColourFourPreview, cbxCustomColourFivePreview, cbxCustomTextColourOnePreview, cbxCustomTextColourTwoPreview, cbxCustomTextColourThreePreview, cbxCustomTextColourFourPreview, cbxCustomTextColourFivePreview, cbxMenuTextColourPreview, cbxStatusTextColourPreview);
            }
            else
            {
                kgbPreviewPane.Visible = true;

                kgbCircularColourPreviewPane.Visible = false;

                ColourUtilities.ResetColourDefinitions(pbxBaseColour, pbxDarkColour, pbxMiddleColour, pbxLightColour, pbxLightestColour, pbxBorderColourPreview, pbxAlternativeNormalTextColour, pbxNormalTextColourPreview, pbxDisabledTextColourPreview, pbxFocusedTextColourPreview, pbxPressedTextColourPreview, pbxDisabledColourPreview, pbxLinkNormalColourPreview, pbxLinkHoverColourPreview, pbxLinkVisitedColourPreview, pbxCustomColourOnePreview, pbxCustomColourTwoPreview, pbxCustomColourThreePreview, pbxCustomColourFourPreview, pbxCustomColourFivePreview, pbxCustomTextColourOnePreview, pbxCustomTextColourTwoPreview, pbxCustomTextColourThreePreview, pbxCustomTextColourFourPreview, pbxCustomTextColourFivePreview, pbxMenuTextColourPreview, pbxStatusTextColourPreview);
            }
        }

        private void kchkInvertColours_CheckedChanged(object sender, EventArgs e)
        {
            if (kchkInvertColours.Checked)
            {
                InvertColours(UseCircularPictureBoxes);
            }
            else
            {
                RevertColours(UseCircularPictureBoxes);
            }
        }

        private void RevertColours(bool useCircularPictureBoxes)
        {
            if (useCircularPictureBoxes)
            {
                ColourUtilities.RevertColours(cbxBaseColourPreview, cbxDarkColourPreview, cbxMiddleColourPreview, cbxLightColourPreview, cbxLightestColourPreview, cbxBorderColourPreview, cbxAlternativeNormalTextColourPreview, cbxNormalTextColourPreview, cbxDisabledTextColourPreview, cbxFocusedTextColourPreview, cbxPressedTextColourPreview, cbxDisabledColourPreview, cbxLinkNormalColourPreview, cbxLinkHoverColourPreview, cbxLinkVisitedColourPreview, cbxCustomColourOnePreview, cbxCustomColourTwoPreview, cbxCustomColourThreePreview, cbxCustomColourFourPreview, cbxCustomColourFivePreview, cbxCustomTextColourOnePreview, cbxCustomTextColourTwoPreview, cbxCustomTextColourThreePreview, cbxCustomTextColourFourPreview, cbxCustomTextColourFivePreview, cbxMenuTextColourPreview, cbxStatusTextColourPreview);

                invertColoursToolStripMenuItem.Checked = false;

                kchkInvertColours.Checked = false;
            }
        }

        private void InvertColours(bool useCircularPictureBoxes)
        {
            if (useCircularPictureBoxes)
            {
                ColourUtilities.InvertColours(cbxBaseColourPreview, cbxDarkColourPreview, cbxMiddleColourPreview, cbxLightColourPreview, cbxLightestColourPreview, cbxBorderColourPreview, cbxAlternativeNormalTextColourPreview, cbxNormalTextColourPreview, cbxDisabledTextColourPreview, cbxFocusedTextColourPreview, cbxPressedTextColourPreview, cbxDisabledColourPreview, cbxLinkNormalColourPreview, cbxLinkHoverColourPreview, cbxLinkVisitedColourPreview, cbxCustomColourOnePreview, cbxCustomColourTwoPreview, cbxCustomColourThreePreview, cbxCustomColourFourPreview, cbxCustomColourFivePreview, cbxCustomTextColourOnePreview, cbxCustomTextColourTwoPreview, cbxCustomTextColourThreePreview, cbxCustomTextColourFourPreview, cbxCustomTextColourFivePreview, cbxMenuTextColourPreview, cbxStatusTextColourPreview);

                invertColoursToolStripMenuItem.Checked = true;

                kchkInvertColours.Checked = true;
            }
            else
            {
                ColourUtilities.InvertColours(pbxBaseColour, pbxDarkColour, pbxMiddleColour, pbxLightColour, pbxLightestColour, pbxBorderColourPreview, pbxAlternativeNormalTextColour, pbxNormalTextColourPreview, pbxDisabledTextColourPreview, pbxFocusedTextColourPreview, pbxPressedTextColourPreview, pbxDisabledColourPreview, pbxLinkNormalColourPreview, pbxLinkHoverColourPreview, pbxLinkVisitedColourPreview, pbxCustomColourOnePreview, pbxCustomColourTwoPreview, pbxCustomColourThreePreview, pbxCustomColourFourPreview, pbxCustomColourFivePreview, pbxCustomTextColourOnePreview, pbxCustomTextColourTwoPreview, pbxCustomTextColourThreePreview, pbxCustomTextColourFourPreview, pbxCustomTextColourFivePreview, pbxMenuTextColourPreview, pbxStatusTextColourPreview);

                invertColoursToolStripMenuItem.Checked = true;

                kchkInvertColours.Checked = true;
            }
        }

        private void generateColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UseCircularPictureBoxes)
            {
                GenerateColourScheme(cbxBaseColourPreview.BackColor);
            }
            else
            {
                GenerateColourScheme(pbxBaseColour.BackColor);
            }
        }

        private void getColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrabPaletteColours(UseCircularPictureBoxes);
        }

        private void exportPaletteColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportPaletteColours(UseCircularPictureBoxes);
        }

        private void viewPaletteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tooling.Classes.Other.GlobalMethods.NotImplementedYet();
        }

        private void generateContrastColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tooling.Classes.Other.GlobalMethods.NotImplementedYet();
        }

        private void getColourInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tooling.Classes.Other.GlobalMethods.NotImplementedYet();
        }

        private void importColourSchemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void invertColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertColours(UseCircularPictureBoxes);
        }

        private void updateColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tooling.Classes.Other.GlobalMethods.NotImplementedYet();
        }

        private void resetColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetColours(UseCircularPictureBoxes);
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCircularPreviewBoxes(false);

            standardToolStripMenuItem.Checked = true;

            circularToolStripMenuItem.Checked = UseCircularPictureBoxes;
        }

        private void circularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCircularPreviewBoxes(true);

            standardToolStripMenuItem.Checked = false;

            circularToolStripMenuItem.Checked = UseCircularPictureBoxes;
        }

        private void submitFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/issues/35");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog aboutDialog = new AboutDialog();

            aboutDialog.Show();
        }

        /// <summary>
        /// Updates the UI.
        /// </summary>
        private void UpdateUI()
        {
            if (kcmbBasePaletteMode.Text != string.Empty)
            {
                kbtnExportPalette.Enabled = true;
            }
            else
            {
                kbtnExportPalette.Enabled = false;
            }
        }

        /// <summary>
        /// Updates the colour palette.
        /// </summary>
        /// <param name="useCircularPictureBoxes">if set to <c>true</c> [use circular picture boxes].</param>
        private void UpdateColourPalette(bool useCircularPictureBoxes)
        {
            if (useCircularPictureBoxes)
            {
                kgbPreviewPane.Visible = false;

                kgbCircularColourPreviewPane.Visible = true;

                ColourUtilities.GrabColourDefinitions(cbxBaseColourPreview, cbxDarkColourPreview, cbxMiddleColourPreview, cbxLightColourPreview, cbxLightestColourPreview, cbxBorderColourPreview, cbxAlternativeNormalTextColourPreview, cbxNormalTextColourPreview, cbxDisabledTextColourPreview, cbxFocusedTextColourPreview, cbxPressedTextColourPreview, cbxDisabledColourPreview, cbxLinkNormalColourPreview, cbxLinkHoverColourPreview, cbxLinkVisitedColourPreview, cbxCustomColourOnePreview, cbxCustomColourTwoPreview, cbxCustomColourThreePreview, cbxCustomColourFourPreview, cbxCustomColourFivePreview, cbxCustomTextColourOnePreview, cbxCustomTextColourTwoPreview, cbxCustomTextColourThreePreview, cbxCustomTextColourFourPreview, cbxCustomTextColourFivePreview, cbxMenuTextColourPreview, cbxStatusTextColourPreview);
            }
            else
            {
                kgbPreviewPane.Visible = true;

                kgbCircularColourPreviewPane.Visible = false;

                ColourUtilities.GrabColourDefinitions(pbxBaseColour, pbxDarkColour, pbxMiddleColour, pbxLightColour, pbxLightestColour, pbxBorderColourPreview, pbxAlternativeNormalTextColour, pbxNormalTextColourPreview, pbxDisabledTextColourPreview, pbxFocusedTextColourPreview, pbxPressedTextColourPreview, pbxDisabledColourPreview, pbxLinkNormalColourPreview, pbxLinkHoverColourPreview, pbxLinkVisitedColourPreview, pbxCustomColourOnePreview, pbxCustomColourTwoPreview, pbxCustomColourThreePreview, pbxCustomColourFourPreview, pbxCustomColourFivePreview, pbxCustomTextColourOnePreview, pbxCustomTextColourTwoPreview, pbxCustomTextColourThreePreview, pbxCustomTextColourFourPreview, pbxCustomTextColourFivePreview, pbxMenuTextColourPreview, pbxStatusTextColourPreview);
            }
        }

        private void utiliseAsBaseColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UseCircularPictureBoxes)
            {
                GenerateColourScheme(cbxBaseColourPreview.BackColor);
            }
            else
            {
                GenerateColourScheme(pbxBaseColour.BackColor);
            }
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            if (UseCircularPictureBoxes)
            {
                GenerateColourScheme(cbxDarkColourPreview.BackColor);
            }
            else
            {
                GenerateColourScheme(pbxDarkColour.BackColor);
            }
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            if (UseCircularPictureBoxes)
            {
                GenerateColourScheme(cbxMiddleColourPreview.BackColor);
            }
            else
            {
                GenerateColourScheme(pbxMiddleColour.BackColor);
            }
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            if (UseCircularPictureBoxes)
            {
                GenerateColourScheme(cbxLightColourPreview.BackColor);
            }
            else
            {
                GenerateColourScheme(pbxLightColour.BackColor);
            }
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            if (UseCircularPictureBoxes)
            {
                GenerateColourScheme(cbxLightestColourPreview.BackColor);
            }
            else
            {
                GenerateColourScheme(pbxLightestColour.BackColor);
            }
        }

        /// <summary>
        /// Shows or hides the circular preview boxes.
        /// </summary>
        /// <param name="value">if set to <c>true</c> [value].</param>
        private void ShowCircularPreviewBoxes(bool value)
        {
            GlobalBooleanSettingsManager globalBooleanSettingsManager = new GlobalBooleanSettingsManager();

            #region Old Code
            //pbxBaseColour.Visible = value;

            //pbxDarkColour.Visible = value;

            //pbxMiddleColour.Visible = value;

            //pbxLightColour.Visible = value;

            //pbxLightestColour.Visible = value;

            //pbxBorderColourPreview.Visible = value;

            //pbxAlternativeNormalTextColour.Visible = value;

            //pbxNormalTextColourPreview.Visible = value;

            //pbxDisabledTextColourPreview.Visible = value;

            //pbxFocusedTextColourPreview.Visible = value;

            //pbxPressedTextColourPreview.Visible = value;

            //pbxDisabledColourPreview.Visible = value;

            //pbxLinkNormalColourPreview.Visible = value;

            //pbxLinkHoverColourPreview.Visible = value;

            //pbxLinkVisitedColourPreview.Visible = value;

            //pbxCustomColourOnePreview.Visible = value;

            //pbxCustomColourTwoPreview.Visible = value;

            //pbxCustomColourThreePreview.Visible = value;

            //pbxCustomColourFourPreview.Visible = value;

            //pbxCustomColourFivePreview.Visible = value;

            //pbxCustomTextColourOnePreview.Visible = value;

            //pbxCustomTextColourTwoPreview.Visible = value;

            //pbxCustomTextColourThreePreview.Visible = value;

            //pbxCustomTextColourFourPreview.Visible = value;

            //pbxCustomTextColourFivePreview.Visible = value;

            //pbxMenuTextColourPreview.Visible = value;

            //pbxStatusTextColourPreview.Visible = value;
            #endregion

            if (value)
            {
                kgbCircularColourPreviewPane.Visible = true;

                kgbPreviewPane.Visible = false;

                standardToolStripMenuItem.Checked = false;

                circularToolStripMenuItem.Checked = true;
            }
            else
            {
                kgbCircularColourPreviewPane.Visible = false;

                kgbPreviewPane.Visible = true;

                standardToolStripMenuItem.Checked = true;

                circularToolStripMenuItem.Checked = false;
            }

            _globalBooleanSettingsManager.SetUseCircularPictureBoxes(value);

            UseCircularPictureBoxes = _globalBooleanSettingsManager.GetUseCircularPictureBoxes();

            _globalBooleanSettingsManager.SaveBooleanSettings();
        }

        private void GenerateColourScheme(Color baseColour)
        {
            ColourMixer colourMixer = new ColourMixer(true, baseColour);

            colourMixer.Show();
        }

        private void newUXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New.MainWindow mainWindow = new New.MainWindow();

            mainWindow.Show();
        }

        private void GrabPaletteColours(bool useCircularPictureBoxes)
        {
            if (useCircularPictureBoxes)
            {
                UpdateColourPalette(useCircularPictureBoxes);

                ShowCircularPreviewBoxes(true);
            }
        }

        private void MyOwnRecentPaletteFileGotClicked_Handler(object sender, EventArgs e)
        {
            string fileName = (sender as ToolStripItem).Text;

            if (!File.Exists(fileName))
            {
                if (KryptonMessageBox.Show($"{ fileName } doesn't exist. Remove from recent workspaces?", "File not found", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _mostRecentlyUsedFileManager.RemoveRecentFile(fileName);
                }
                else
                {
                    return;
                }
            }

            _palette.Import(fileName);

            //OpenFile(fileName);
        }

        private void MyOwnRecentPaletteFilesGotCleared_Handler(object sender, EventArgs e)
        {

        }
        #endregion
    }
}