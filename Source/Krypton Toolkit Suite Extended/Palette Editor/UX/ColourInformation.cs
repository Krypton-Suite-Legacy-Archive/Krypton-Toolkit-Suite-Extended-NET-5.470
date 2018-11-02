using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections;
using System.Windows.Forms;
using Tooling.Classes.Other;
using Tooling.Settings.Classes;

namespace PaletteEditor.UX
{
    public partial class ColourInformation : KryptonForm
    {
        #region Variables
        private ArrayList _colourSettingsArray;
        private ColourSettingsManager _colourSettingsManager = new ColourSettingsManager();
        #endregion

        public ColourInformation(bool debugMode = false)
        {
            InitializeComponent();

            if (debugMode)
            {
                TextExtra = "(Debug Console)";
            }
        }

        private void kbtnGetColourInformation_Click(object sender, EventArgs e)
        {
            PropagateColourSettingsArray();

            foreach (String item in _colourSettingsArray)
            {
                klbColourInformation.Items.Add(item);
            }
        }

        private void PropagateColourSettingsArray()
        {
            _colourSettingsArray = new ArrayList();

            _colourSettingsArray.Add($"Base Colour: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetBaseColour()) }");

            _colourSettingsArray.Add($"Dark Colour: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetDarkestColour()) }");

            _colourSettingsArray.Add($"Middle Colour: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetMediumColour()) }");

            _colourSettingsArray.Add($"Light Colour: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetLightColour()) }");

            _colourSettingsArray.Add($"Lightest Colour: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetLightestColour()) }");

            _colourSettingsArray.Add($"Border Colour: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetBorderColour()) }");

            _colourSettingsArray.Add($"Disabled Colour: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetDisabledColour()) }");

            _colourSettingsArray.Add($"Alternative Normal Text Colour: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetAlternativeNormalTextColour()) }");

            _colourSettingsArray.Add($"Disabled Text Colour: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetDisabledTextColour()) }");

            _colourSettingsArray.Add($"Normal Text Colour: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetNormalTextColour()) }");

            _colourSettingsArray.Add($"Focused Text Colour: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetFocusedTextColour()) }");

            _colourSettingsArray.Add($"Pressed Text Colour: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetPressedTextColour()) }");

            _colourSettingsArray.Add($"Link Disabled Colour: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetLinkDisabledColour()) }");

            _colourSettingsArray.Add($"Link Normal Colour: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetLinkNormalColour()) }");

            _colourSettingsArray.Add($"Link Hover Colour: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetLinkHoverColour()) }");

            _colourSettingsArray.Add($"Link Visited Colour: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetLinkVisitedColour()) }");

            _colourSettingsArray.Add($"Custom Colour One: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetCustomColourOne()) }");

            _colourSettingsArray.Add($"Custom Colour Two: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetCustomColourTwo()) }");

            _colourSettingsArray.Add($"Custom Colour Three: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetCustomColourThree()) }");

            _colourSettingsArray.Add($"Custom Colour Four: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetCustomColourFour()) }");

            _colourSettingsArray.Add($"Custom Colour Five: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetCustomColourFive()) }");

            _colourSettingsArray.Add($"Custom Text Colour One: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetCustomTextColourOne()) }");

            _colourSettingsArray.Add($"Custom Text Colour Two: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetCustomTextColourTwo()) }");

            _colourSettingsArray.Add($"Custom Text Colour Three: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetCustomTextColourThree()) }");

            _colourSettingsArray.Add($"Custom Text Colour Four: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetCustomTextColourFour()) }");

            _colourSettingsArray.Add($"Custom Text Colour Five: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetCustomTextColourFive()) }");

            _colourSettingsArray.Add($"Menu Text Colour: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetMenuTextColour()) }");

            _colourSettingsArray.Add($"Status Text Colour: { ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetStatusTextColour()) }");
        }

        private void AddColourDetails(string colourDescription, string colour)
        {
            string[] colourInformationArray = new string[2];

            ListViewItem colourInformationItem;

            colourInformationArray[0] = $"{ colourDescription } Colour";

            colourInformationArray[1] = $"({ colour })";

            colourInformationItem = new ListViewItem(colourInformationArray);

            lvColourInformation.Items.Add(colourInformationItem);
        }

        private void ColourInformation_Load(object sender, EventArgs e)
        {
            AddColourDetails("Base", ColourUtilities.FormatColourRGBString(_colourSettingsManager.GetBaseColour()));
        }

        private void useAsBaseColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] contentArray = new string[2];

            //KryptonListItem selectedItem = klbColourInformation.SelectedItem;

            //ListViewItem selectedItem = lvColourInformation.SelectedItems;
        }

        private void tmrUpgradeUI_Tick(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            if (krbUseDatagridView.Checked)
            {
                kogColourInformation.Visible = true;

                klbColourInformation.Visible = false;

                lvColourInformation.Visible = false;
            }
            else if (krbUseKryptonListBox.Checked)
            {
                kogColourInformation.Visible = false;

                klbColourInformation.Visible = true;

                lvColourInformation.Visible = false;
            }
            else if (krbUseSystemListBox.Checked)
            {
                kogColourInformation.Visible = false;

                klbColourInformation.Visible = false;

                lvColourInformation.Visible = true;
            }
        }
    }
}