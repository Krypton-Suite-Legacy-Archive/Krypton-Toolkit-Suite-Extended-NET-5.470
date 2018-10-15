using ComponentFactory.Krypton.Toolkit;
using GlobalUtilities.Interfaces;
using KryptonExtendedToolkit.Base.Code;
using PaletteEditor.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Tooling.Classes.Other;
using Tooling.Settings.Classes;
using Tooling.UX;

namespace PaletteEditor.UX.New
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

            InitialiseVariables();
        }

        #region Methods
        private void InitialiseVariables()
        {
            _colourUpdateTimer = new Timer();

            _colourUpdateTimer.Interval = 250;

            _colourUpdateTimer.Tick += new EventHandler(Tick);

            DebugMode = _globalBooleanSettingsManager.GetDevelopmentMode();

            UseCircularPictureBoxes = _globalBooleanSettingsManager.GetUseCircularPictureBoxes();
        }

        private void InitialiseWindow()
        {
            New();

            _mostRecentlyUsedFileManager = new MostRecentlyUsedFileManager(recentPaletteDefinitionsToolStripMenuItem, "Palette Editor", MyOwnRecentPaletteFileGotClicked_Handler, MyOwnRecentPaletteFilesGotCleared_Handler);

            ColourUtilities.PropagateBasePaletteModes(kcmbBasePaletteMode);

            _colourSettingsManager.ResetSettings(DebugMode);

            if (UseCircularPictureBoxes)
            {
                ShowCircularPreviewBoxes(_globalBooleanSettingsManager.GetUseCircularPictureBoxes());
            }

            TextExtra = $"(Build: { _currentVersion.Build.ToString() } - experimental)";
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

            if (_globalBooleanSettingsManager.GetLoadColoursOnOpenPalette())
            {
                GrabPaletteColours(UseCircularPictureBoxes);
            }
        }

        /// <summary>
        /// Updates the colour palette.
        /// </summary>
        /// <param name="useCircularPictureBoxes">if set to <c>true</c> [use circular picture boxes].</param>
        private void UpdateColourPalette(bool useCircularPictureBoxes)
        {
            try
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
            catch (Exception exc)
            {
                KryptonMessageBox.Show($"Error: { exc.Message }", "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void GrabPaletteColours(bool useCircularPictureBoxes)
        {
            if (useCircularPictureBoxes)
            {
                UpdateColourPalette(useCircularPictureBoxes);

                ShowCircularPreviewBoxes(true);
            }
        }

        private void NullifyStatusText()
        {
            //lblColourOutput.Text = "";

            InformationControlManager.ResetColourValueInformation(lblColourOutput);
        }

        private void DisplayColourInformation(Control control, string colourDescription)
        {
            InformationControlManager.DisplayColourInformation(control, false, colourDescription, lblColourOutput);
        }

        private void ExitApplication(bool useFileName = false)
        {
            try
            {
                if (Dirty)
                {
                    if (useFileName)
                    {
                        string fileName = Path.GetFileName(_palette.GetFilePath());

                        DialogResult result = KryptonMessageBox.Show($"The current palette: { fileName } has not yet been saved. Save now?", "Unsaved Palette", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            Save();
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                    else
                    {
                        DialogResult result = KryptonMessageBox.Show("The current palette has not yet been saved. Save now?", "Unsaved Palette", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            Save();
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                }

                _globalBooleanSettingsManager.SaveBooleanSettings();
            }
            catch (Exception err)
            {
                KryptonMessageBox.Show($"Error: { err.Message }", "An Unexpected Error has Occurred0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        #region Mouse Picturebox Events
        private void pbxBaseColour_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxBaseColour_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxBaseColour_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxMiddleColour_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxMiddleColour_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxMiddleColour_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxLightColour_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxLightColour_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxLightColour_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxLightestColour_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxLightestColour_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxLightestColour_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxBorderColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxBorderColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxBorderColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxAlternativeNormalTextColour_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxAlternativeNormalTextColour_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxAlternativeNormalTextColour_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxNormalTextColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxNormalTextColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxNormalTextColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxDisabledTextColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxDisabledTextColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxDisabledTextColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxFocusedTextColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxFocusedTextColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxFocusedTextColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxPressedTextColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxPressedTextColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxPressedTextColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxDisabledColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxDisabledColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxDisabledColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxLinkNormalColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxLinkNormalColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxLinkNormalColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxLinkHoverColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxLinkHoverColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxLinkHoverColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxLinkVisitedColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxLinkVisitedColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxLinkVisitedColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxCustomColourOnePreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxCustomColourOnePreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxCustomColourOnePreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxCustomColourTwoPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxCustomColourTwoPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxCustomColourTwoPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxCustomColourThreePreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxCustomColourThreePreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxCustomColourThreePreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxCustomColourFourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxCustomColourFourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxCustomColourFourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxCustomColourFivePreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxCustomColourFivePreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxCustomColourFivePreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxCustomTextColourOnePreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxCustomTextColourOnePreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxCustomTextColourOnePreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxCustomTextColourTwoPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxCustomTextColourTwoPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxCustomTextColourTwoPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxCustomTextColourThreePreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxCustomTextColourThreePreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxCustomTextColourThreePreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxCustomTextColourFourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxCustomTextColourFourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxCustomTextColourFourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxCustomTextColourFivePreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxCustomTextColourFivePreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxCustomTextColourFivePreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxMenuTextColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxMenuTextColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxMenuTextColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxStatusTextColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxStatusTextColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxStatusTextColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbxDarkColour_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxDarkColour_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbxDarkColour_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion

        #region Mouse Circular Picturebox Events
        private void cbxBaseColourPreview_MouseEnter(object sender, EventArgs e)
        {
            DisplayColourInformation(cbxBaseColourPreview, "Base Colour");
        }

        private void cbxBaseColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxBaseColourPreview_MouseLeave(object sender, EventArgs e)
        {
            NullifyStatusText();
        }

        private void cbxMiddleColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxMiddleColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxMiddleColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxLightColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxLightColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxLightColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxLightestColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxLightestColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxLightestColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxBorderColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxBorderColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxBorderColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxAlternativeNormalTextColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxAlternativeNormalTextColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxAlternativeNormalTextColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxNormalTextColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxNormalTextColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxNormalTextColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxDisabledTextColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxDisabledTextColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxDisabledTextColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxFocusedTextColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxFocusedTextColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxFocusedTextColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxPressedTextColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxPressedTextColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxPressedTextColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxDisabledColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxDisabledColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxDisabledColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxLinkNormalColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxLinkNormalColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxLinkNormalColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxLinkHoverColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxLinkHoverColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxLinkHoverColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxLinkVisitedColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxLinkVisitedColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxLinkVisitedColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxCustomColourOnePreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxCustomColourOnePreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxCustomColourOnePreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxCustomColourTwoPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxCustomColourTwoPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxCustomColourTwoPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxCustomColourThreePreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxCustomColourThreePreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxCustomColourThreePreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxCustomColourFourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxCustomColourFourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxCustomColourFourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxCustomColourFivePreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxCustomColourFivePreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxCustomColourFivePreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxCustomTextColourOnePreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxCustomTextColourOnePreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxCustomTextColourOnePreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxCustomTextColourTwoPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxCustomTextColourTwoPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxCustomTextColourTwoPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxCustomTextColourThreePreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxCustomTextColourThreePreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxCustomTextColourThreePreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxCustomTextColourFourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxCustomTextColourFourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxCustomTextColourFourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxCustomTextColourFivePreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxCustomTextColourFivePreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxCustomTextColourFivePreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxMenuTextColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxMenuTextColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxMenuTextColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxStatusTextColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxStatusTextColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxStatusTextColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }

        private void cbxDarkColourPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void cbxDarkColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbxDarkColourPreview_MouseLeave(object sender, EventArgs e)
        {

        }
        #endregion

        #region Event Handlers
        private void MainWindow_Load(object sender, EventArgs e)
        {
            InitialiseWindow();
        }

        private void kcmbBasePaletteMode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tick(object sender, EventArgs e)
        {
            UpdateColourPalette(UseCircularPictureBoxes);

            ShowCircularPreviewBoxes(UseCircularPictureBoxes);
        }

        private void kbtnImportColourScheme_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void kbtnGetColourInformation_Click(object sender, EventArgs e)
        {
            ColourInformation colourInformation = new ColourInformation();

            colourInformation.Show();
        }

        private void newPaletteDefinitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
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

        private void kbtnGetColours_Click(object sender, EventArgs e)
        {
            GrabPaletteColours(UseCircularPictureBoxes);
        }

        private void tmrUpdateUI_Tick(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitApplication(true);
        }

        private void savePaletteDefinitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void kbtnExportPalette_Click(object sender, EventArgs e)
        {
            ExportPaletteColours(UseCircularPictureBoxes);
        }

        private void exportPaletteColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportPaletteColours(UseCircularPictureBoxes);
        }

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

        private void savePaletteDefinitionAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void resetColoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetColours(UseCircularPictureBoxes);
        }

        private void loadColoursOnOpenToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            _globalBooleanSettingsManager.SetLoadColoursOnOpenPalette(loadColoursOnOpenToolStripMenuItem.Checked);

            _globalBooleanSettingsManager.SaveBooleanSettings();
        }
        #endregion
    }
}