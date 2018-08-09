using ComponentFactory.Krypton.Toolkit;
using PaletteEditor.Classes;
using System;
using System.Windows.Forms;
using Tooling.Classes.Other;
using Tooling.Settings.Classes;
using Tooling.UX;

namespace PaletteEditor.UX
{
    public partial class MainWindow : KryptonForm
    {
        #region Variables
        private bool _dirty, _loaded, _debugMode = true;

        private string _filename;

        private KryptonPalette _palette;

        private ConversionMethods _conversionMethods = new ConversionMethods();

        private ColourSettingsManager _colourSettingsManager = new ColourSettingsManager();
        #endregion
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Operations
        private void New()
        {
            // If the current palette has been changed
            if (_dirty)
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
            // If the current palette has been changed
            if (_dirty)
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
                if (_palette != null)
                    _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

                // Use the new instance instead
                _palette = palette;

                // We need to know when a change occurs to the palette settings
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

                // Hook up the property grid to the palette
                labelGridNormal.SelectedObject = _palette;

                // Use the loaded filename
                _filename = filename;

                // Reset the state flags
                _loaded = true;
                _dirty = false;

                // Define the initial title bar string
                UpdateTitlebar();
            }
        }

        private void Save()
        {
            // If we already have a file associated with the palette...
            if (_loaded)
            {
                // ...then just save it straight away
                Cursor = Cursors.WaitCursor;
                Application.DoEvents();
                _palette.Export(_filename, true, false);
                Cursor = Cursors.Default;

                // No longer dirty
                _dirty = false;

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
            string filename = _palette.Export();
            Cursor = Cursors.Default;

            // If the save succeeded
            if (filename.Length > 0)
            {
                // Remember associated file details
                _filename = filename;
                _loaded = true;

                // No longer dirty
                _dirty = false;

                // Define the initial title bar string
                UpdateTitlebar();
            }
        }

        private void Exit()
        {
            // If the current palette has been changed
            if (_dirty)
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
            if (_palette != null)
                _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            // Create a fresh palette instance
            _palette = new KryptonPalette();

            // We need to know when a change occurs to the palette settings
            _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            // Hook up the property grid to the palette
            labelGridNormal.SelectedObject = _palette;

            // Does not have a filename as yet
            _filename = "(New Palette)";

            // Reset the state flags
            _dirty = false;
            _loaded = false;

            // Define the initial title bar string
            UpdateTitlebar();
        }

        private void OnPalettePaint(object sender, PaletteLayoutEventArgs e)
        {
            // Only interested the first time the palette is changed
            if (!_dirty)
            {
                _dirty = true;
                UpdateTitlebar();
            }

        }
        #endregion

        #region Implementation
        private void UpdateTitlebar()
        {
            // Mark a changed file with a star
            Text = "Palette Editor - " + _filename + (_dirty ? "*" : string.Empty);
        }
        #endregion

        private void MainWindow_Load(object sender, EventArgs e)
        {
            New();

            ColourUtilities.PropagateBasePaletteModes(kcmbBasePaletteMode);

            _colourSettingsManager.ResetSettings(_debugMode);
        }

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
            ttInformation.SetToolTip(pbxMiddleColour, $"Middle Colour\nARGB: ({ ColourUtilities.FormatColourARGBString(pbxMiddleColour.BackColor) })\nRGB: ({ ColourUtilities.FormatColourRGBString(pbxMiddleColour.BackColor) })\nHexadecimal Value: #{ _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(pbxMiddleColour.BackColor.R), Convert.ToInt32(pbxMiddleColour.BackColor.G), Convert.ToInt32(pbxMiddleColour.BackColor.B)).ToUpper() }\nHue: { pbxMiddleColour.BackColor.GetHue().ToString() }\nSaturation: { pbxMiddleColour.BackColor.GetSaturation().ToString() }\nBrightness: { pbxMiddleColour.BackColor.GetBrightness().ToString() }");
        }

        private void pbxLightColour_MouseEnter(object sender, EventArgs e)
        {
            ttInformation.SetToolTip(pbxLightColour, $"Light Colour\nARGB: ({ ColourUtilities.FormatColourARGBString(pbxLightColour.BackColor) })\nRGB: ({ ColourUtilities.FormatColourRGBString(pbxLightColour.BackColor) })\nHexadecimal Value: #{ _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(pbxLightColour.BackColor.R), Convert.ToInt32(pbxLightColour.BackColor.G), Convert.ToInt32(pbxLightColour.BackColor.B)).ToUpper() }\nHue: { pbxLightColour.BackColor.GetHue().ToString() }\nSaturation: { pbxLightColour.BackColor.GetSaturation().ToString() }\nBrightness: { pbxLightColour.BackColor.GetBrightness().ToString() }");
        }

        private void pbxLightestColour_MouseEnter(object sender, EventArgs e)
        {
            ttInformation.SetToolTip(pbxLightestColour, $"Lightest Colour\nARGB: ({ ColourUtilities.FormatColourARGBString(pbxLightestColour.BackColor) })\nRGB: ({ ColourUtilities.FormatColourRGBString(pbxLightestColour.BackColor) })\nHexadecimal Value: #{ _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(pbxLightestColour.BackColor.R), Convert.ToInt32(pbxLightestColour.BackColor.G), Convert.ToInt32(pbxLightestColour.BackColor.B)).ToUpper() }\nHue: { pbxLightestColour.BackColor.GetHue().ToString() }\nSaturation: { pbxLightestColour.BackColor.GetSaturation().ToString() }\nBrightness: { pbxLightestColour.BackColor.GetBrightness().ToString() }");
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


        private void kbtnGenerate_Click(object sender, EventArgs e)
        {
            ColourMixer colourMixer = new ColourMixer();

            colourMixer.Show();
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
            ColourSettingsManager colourSettingsManager = new ColourSettingsManager();

            pbxBaseColour.BackColor = colourSettingsManager.GetBaseColour();

            pbxDarkColour.BackColor = colourSettingsManager.GetDarkestColour();

            pbxMiddleColour.BackColor = colourSettingsManager.GetMediumColour();

            pbxLightColour.BackColor = colourSettingsManager.GetLightColour();

            pbxLightestColour.BackColor = colourSettingsManager.GetLightestColour();

            pbxBorderColourPreview.BackColor = colourSettingsManager.GetBorderColour();

            pbxAlternativeNormalTextColour.BackColor = colourSettingsManager.GetAlternativeNormalTextColour();

            pbxNormalTextColourPreview.BackColor = colourSettingsManager.GetNormalTextColour();

            pbxDisabledTextColourPreview.BackColor = colourSettingsManager.GetDisabledTextColour();

            pbxFocusedTextColourPreview.BackColor = colourSettingsManager.GetFocusTextColour();

            pbxPressedTextColourPreview.BackColor = colourSettingsManager.GetPressedTextColour();

            pbxDisabledColourPreview.BackColor = colourSettingsManager.GetDisabledColour();

            pbxLinkNormalColourPreview.BackColor = colourSettingsManager.GetLinkNormalColour();

            pbxLinkHoverColourPreview.BackColor = colourSettingsManager.GetLinkHoverColour();

            pbxLinkVisitedColourPreview.BackColor = colourSettingsManager.GetLinkVisitedColour();

            pbxCustomColourOnePreview.BackColor = colourSettingsManager.GetCustomColourOne();

            pbxCustomColourTwoPreview.BackColor = colourSettingsManager.GetCustomColourTwo();

            pbxCustomColourThreePreview.BackColor = colourSettingsManager.GetCustomColourThree();

            pbxCustomColourFourPreview.BackColor = colourSettingsManager.GetCustomColourFour();

            pbxCustomColourFivePreview.BackColor = colourSettingsManager.GetCustomColourFive();

            pbxMenuTextColourPreview.BackColor = colourSettingsManager.GetMenuTextColour();

            pbxCustomTextColourOnePreview.BackColor = colourSettingsManager.GetCustomTextColourOne();

            pbxCustomTextColourTwoPreview.BackColor = colourSettingsManager.GetCustomTextColourTwo();

            pbxCustomTextColourThreePreview.BackColor = colourSettingsManager.GetCustomTextColourThree();

            pbxCustomTextColourFourPreview.BackColor = colourSettingsManager.GetCustomTextColourFour();

            pbxCustomTextColourFivePreview.BackColor = colourSettingsManager.GetCustomTextColourFive();
        }

        private void kbtnExportPalette_Click(object sender, EventArgs e)
        {
            //PaletteEditorEngine.ExportPaletteTheme(palette, PaletteMode.Office2007Silver, pbxBaseColour, pbxDarkColour, pbxMiddleColour, pbxLightColour, pbxLightestColour, pbxBorderColourPreview, pbxAlternativeNormalTextColour, pbxNormalTextColourPreview, pbxDisabledTextColourPreview, pbxFocusedTextColourPreview, pbxPressedTextColourPreview, pbxDisabledColourPreview, pbxLinkNormalColourPreview, pbxLinkHoverColourPreview, pbxLinkVisitedColourPreview, tslStatus);

            PaletteEditorEngine.ExportPalette(PaletteMode.Office2007Silver, pbxBaseColour, pbxDarkColour, pbxMiddleColour, pbxLightColour, pbxLightestColour, pbxBorderColourPreview, pbxAlternativeNormalTextColour, pbxNormalTextColourPreview, pbxDisabledTextColourPreview, pbxFocusedTextColourPreview, pbxPressedTextColourPreview, pbxDisabledColourPreview, pbxLinkNormalColourPreview, pbxLinkHoverColourPreview, pbxLinkVisitedColourPreview, tslStatus);
        }


        #region Misc
        private void ExportPaletteColours(KryptonPalette kryptonPalette, PaletteMode paletteMode)
        {

        }
        #endregion
    }
}