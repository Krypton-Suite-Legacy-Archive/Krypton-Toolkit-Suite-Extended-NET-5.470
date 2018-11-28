using Classes.Colours;
using ComponentFactory.Krypton.Toolkit;
using GlobalUtilities.Interfaces;
using PaletteEditor.Classes;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Tooling.Classes.Other;
using Tooling.Settings.Classes;
using Tooling.UX;

namespace PaletteEditor.UX.New
{
    public partial class RibbonWindow : KryptonForm
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

        public RibbonWindow()
        {
            InitializeComponent();

            _colourUpdateTimer = new Timer();

            _colourUpdateTimer.Interval = 250;

            _colourUpdateTimer.Tick += new EventHandler(ColourUpdateTimer_Tick);

            DebugMode = _globalBooleanSettingsManager.GetDevelopmentMode();

            UseCircularPictureBoxes = _globalBooleanSettingsManager.GetUseCircularPictureBoxes();
        }

        #region Event Handlers
        private void RibbonWindow_Load(object sender, EventArgs e)
        {
            New();

            ColourUtilities.PropagateBasePaletteModes(krgcbBasePaletteMode);

            _colourSettingsManager.ResetSettings(DebugMode);

            if (UseCircularPictureBoxes)
            {
                ShowCircularPreviewBoxes(_globalBooleanSettingsManager.GetUseCircularPictureBoxes());
            }

            TextExtra = $"(Build: { _currentVersion.Build.ToString() })";
        }

        private void ColourUpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateColourPalette(UseCircularPictureBoxes);

            ShowCircularPreviewBoxes(UseCircularPictureBoxes);
        }

        private void kcStandardPictureboxes_Execute(object sender, EventArgs e)
        {
            kcCircularPictureboxes.Checked = false;

            kcStandardPictureboxes.Checked = true;

            kgbCircularColourPreviewPane.Visible = false;

            kgbPreviewPane.Visible = true;
        }

        private void kcCircularPictureboxes_Execute(object sender, EventArgs e)
        {
            kcCircularPictureboxes.Checked = true;

            kcStandardPictureboxes.Checked = false;

            kgbCircularColourPreviewPane.Visible = true;

            kgbPreviewPane.Visible = false;
        }

        private void krgbNewPalette_Click(object sender, EventArgs e)
        {
            New();
        }

        private void krgbOpenPalette_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void kcNewPalette_Execute(object sender, EventArgs e)
        {
            New();
        }

        private void tmrUpdateUI_Tick(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void kcExitApplication_Execute(object sender, EventArgs e)
        {
            Exit();
        }

        private void kcSavePaletteAs_Execute(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void kcSavePalette_Execute(object sender, EventArgs e)
        {
            Save();
        }

        private void kcOpenPalette_Execute(object sender, EventArgs e)
        {
            Open();
        }

        private void krgbGenerateColours_Click(object sender, EventArgs e)
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

        private void krgbGetColours_Click(object sender, EventArgs e)
        {
            GrabPaletteColours(UseCircularPictureBoxes);
        }

        private void krbViewPaletteFile_Click(object sender, EventArgs e)
        {
            UserInterfaceManager.ViewPaletteFile();
        }

        private void krgbGenerateContrastColours_Click(object sender, EventArgs e)
        {
            ContrastColourGenerator contrastColourGenerator = new ContrastColourGenerator();

            contrastColourGenerator.Show();
        }

        private void krgcbBasePaletteMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SwitchPalette();
        }

        private void krgbGetColourInformation_Click(object sender, EventArgs e)
        {
            UserInterfaceManager.GetColourInformation();
        }
        #endregion

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

            PaletteImportManager.ImportPaletteColourScheme(palette);

            krgbUpdateColours.Enabled = true;

            krgcbBasePaletteMode.Text = _globalStringSettingsManager.GetBasePaletteMode();

            tslStatus.Text = _globalStringSettingsManager.GetFeedbackText();

            krgbUpdateColours.Checked = true;

            krgbInvert.Enabled = true;
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

        #region Miscellaneous
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

        private void RevertColours(bool useCircularPictureBoxes)
        {
            if (useCircularPictureBoxes)
            {
                ColourUtilities.RevertColours(cbxBaseColourPreview, cbxDarkColourPreview, cbxMiddleColourPreview, cbxLightColourPreview, cbxLightestColourPreview, cbxBorderColourPreview, cbxAlternativeNormalTextColourPreview, cbxNormalTextColourPreview, cbxDisabledTextColourPreview, cbxFocusedTextColourPreview, cbxPressedTextColourPreview, cbxDisabledColourPreview, cbxLinkNormalColourPreview, cbxLinkHoverColourPreview, cbxLinkVisitedColourPreview, cbxCustomColourOnePreview, cbxCustomColourTwoPreview, cbxCustomColourThreePreview, cbxCustomColourFourPreview, cbxCustomColourFivePreview, cbxCustomTextColourOnePreview, cbxCustomTextColourTwoPreview, cbxCustomTextColourThreePreview, cbxCustomTextColourFourPreview, cbxCustomTextColourFivePreview, cbxMenuTextColourPreview, cbxStatusTextColourPreview);

                krgbInvert.Checked = false;
            }
        }

        private void InvertColours(bool useCircularPictureBoxes)
        {
            if (useCircularPictureBoxes)
            {
                ColourUtilities.InvertColours(cbxBaseColourPreview, cbxDarkColourPreview, cbxMiddleColourPreview, cbxLightColourPreview, cbxLightestColourPreview, cbxBorderColourPreview, cbxAlternativeNormalTextColourPreview, cbxNormalTextColourPreview, cbxDisabledTextColourPreview, cbxFocusedTextColourPreview, cbxPressedTextColourPreview, cbxDisabledColourPreview, cbxLinkNormalColourPreview, cbxLinkHoverColourPreview, cbxLinkVisitedColourPreview, cbxCustomColourOnePreview, cbxCustomColourTwoPreview, cbxCustomColourThreePreview, cbxCustomColourFourPreview, cbxCustomColourFivePreview, cbxCustomTextColourOnePreview, cbxCustomTextColourTwoPreview, cbxCustomTextColourThreePreview, cbxCustomTextColourFourPreview, cbxCustomTextColourFivePreview, cbxMenuTextColourPreview, cbxStatusTextColourPreview);

                krgbInvert.Checked = true;
            }
            else
            {
                ColourUtilities.InvertColours(pbxBaseColour, pbxDarkColour, pbxMiddleColour, pbxLightColour, pbxLightestColour, pbxBorderColourPreview, pbxAlternativeNormalTextColour, pbxNormalTextColourPreview, pbxDisabledTextColourPreview, pbxFocusedTextColourPreview, pbxPressedTextColourPreview, pbxDisabledColourPreview, pbxLinkNormalColourPreview, pbxLinkHoverColourPreview, pbxLinkVisitedColourPreview, pbxCustomColourOnePreview, pbxCustomColourTwoPreview, pbxCustomColourThreePreview, pbxCustomColourFourPreview, pbxCustomColourFivePreview, pbxCustomTextColourOnePreview, pbxCustomTextColourTwoPreview, pbxCustomTextColourThreePreview, pbxCustomTextColourFourPreview, pbxCustomTextColourFivePreview, pbxMenuTextColourPreview, pbxStatusTextColourPreview);

                krgbInvert.Checked = true;
            }
        }

        /// <summary>
        /// Updates the UI.
        /// </summary>
        private void UpdateUI()
        {
            if (krgcbBasePaletteMode.Text != string.Empty)
            {
                krqatbSave.Enabled = true;
            }
            else
            {
                krqatbSave.Enabled = false;
            }

            if (UseCircularPictureBoxes && krgbShowHidePropertiesPane.Checked)
            {
                CircularPictureboxHiddenPropertiesLocation();
            }
            else if (UseCircularPictureBoxes && !krgbShowHidePropertiesPane.Checked)
            {
                FactoryCircularPictureboxLocation();
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

        /// <summary>
        /// Shows or hides the circular preview boxes.
        /// </summary>
        /// <param name="value">if set to <c>true</c> [value].</param>
        private void ShowCircularPreviewBoxes(bool value)
        {
            GlobalBooleanSettingsManager globalBooleanSettingsManager = new GlobalBooleanSettingsManager();

            if (value)
            {
                kgbCircularColourPreviewPane.Visible = true;

                kgbPreviewPane.Visible = false;

                standardPictureboxesToolStripMenuItem.Checked = false;

                circularPictureboxesToolStripMenuItem.Checked = true;
            }
            else
            {
                kgbCircularColourPreviewPane.Visible = false;

                kgbPreviewPane.Visible = true;

                standardPictureboxesToolStripMenuItem.Checked = true;

                circularPictureboxesToolStripMenuItem.Checked = false;
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

        private void SwitchPalette()
        {
            if (krgcbBasePaletteMode.Text == "Global")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Global);
            }
            else if (krgcbBasePaletteMode.Text == "ProfessionalSystem")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.ProfessionalSystem);
            }
            else if (krgcbBasePaletteMode.Text == "ProfessionalOffice2003")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.ProfessionalOffice2003);
            }
            else if (krgcbBasePaletteMode.Text == "Office2007Black")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2007Black);
            }
            else if (krgcbBasePaletteMode.Text == "Office2007Blue")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2007Blue);
            }
            else if (krgcbBasePaletteMode.Text == "Office2007Silver")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2007Silver);
            }
            else if (krgcbBasePaletteMode.Text == "Office2010Black")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2010Black);
            }
            else if (krgcbBasePaletteMode.Text == "Office2010Blue")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2010Blue);
            }
            else if (krgcbBasePaletteMode.Text == "Office2010Silver")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2010Silver);
            }
            else if (krgcbBasePaletteMode.Text == "Office2013")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2013);
            }
            else if (krgcbBasePaletteMode.Text == "Office2013White")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Office2013White);
            }
            else if (krgcbBasePaletteMode.Text == "SparkleBlue")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.SparkleBlue);
            }
            else if (krgcbBasePaletteMode.Text == "SparkleOrange")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.SparkleOrange);
            }
            else if (krgcbBasePaletteMode.Text == "SparklePurple")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.SparklePurple);
            }
            else if (krgcbBasePaletteMode.Text == "Custom")
            {
                _globalMethods.SetSelectedPaletteMode(PaletteMode.Custom);
            }

            GetCurrentSavedPaletteMode();
        }

        private void GrabPaletteColours(bool useCircularPictureBoxes)
        {
            if (useCircularPictureBoxes)
            {
                UpdateColourPalette(useCircularPictureBoxes);

                ShowCircularPreviewBoxes(true);
            }
        }
        #endregion

        #region Location
        private void FactoryCircularPictureboxLocation()
        {
            UserInterfaceManager.FactoryCircularPictureboxLocation(kgbCircularColourPreviewPane, cbxBaseColourPreview, cbxDarkColourPreview, cbxMiddleColourPreview, cbxLightColourPreview, cbxLightestColourPreview, cbxBorderColourPreview, cbxAlternativeNormalTextColourPreview, cbxNormalTextColourPreview, cbxDisabledTextColourPreview, cbxFocusedTextColourPreview, cbxPressedTextColourPreview, cbxDisabledColourPreview, cbxLinkNormalColourPreview, cbxLinkHoverColourPreview, cbxLinkVisitedColourPreview, cbxCustomColourOnePreview, cbxCustomColourTwoPreview, cbxCustomColourThreePreview, cbxCustomColourFourPreview, cbxCustomColourFivePreview, cbxCustomTextColourOnePreview, cbxCustomTextColourTwoPreview, cbxCustomTextColourThreePreview, cbxCustomTextColourFourPreview, cbxCustomTextColourFivePreview, cbxMenuTextColourPreview, cbxStatusTextColourPreview, cbxExtra1, cbxExtra2, cbxExtra3);
        }

        private void CircularPictureboxHiddenPropertiesLocation()
        {
            UserInterfaceManager.CircularPictureboxHiddenPropertiesLocation(kgbCircularColourPreviewPane, cbxBaseColourPreview, cbxDarkColourPreview, cbxMiddleColourPreview, cbxLightColourPreview, cbxLightestColourPreview, cbxBorderColourPreview, cbxAlternativeNormalTextColourPreview, cbxNormalTextColourPreview, cbxDisabledTextColourPreview, cbxFocusedTextColourPreview, cbxPressedTextColourPreview, cbxDisabledColourPreview, cbxLinkNormalColourPreview, cbxLinkHoverColourPreview, cbxLinkVisitedColourPreview, cbxCustomColourOnePreview, cbxCustomColourTwoPreview, cbxCustomColourThreePreview, cbxCustomColourFourPreview, cbxCustomColourFivePreview, cbxCustomTextColourOnePreview, cbxCustomTextColourTwoPreview, cbxCustomTextColourThreePreview, cbxCustomTextColourFourPreview, cbxCustomTextColourFivePreview, cbxMenuTextColourPreview, cbxStatusTextColourPreview, cbxExtra1, cbxExtra2, cbxExtra3);
        }
        #endregion
    }
}