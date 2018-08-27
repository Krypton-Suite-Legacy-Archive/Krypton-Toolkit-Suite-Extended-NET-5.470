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

        public ColourInformation()
        {
            InitializeComponent();
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