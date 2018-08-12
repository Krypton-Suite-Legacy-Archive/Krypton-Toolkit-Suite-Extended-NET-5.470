using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using Tooling.Classes.Other;
using Tooling.Enumerations;

namespace Tooling.UX
{
    public partial class CustomColours : KryptonForm
    {
        #region Variables
        private RandomNumberGenerator _randomNumberGenerator = new RandomNumberGenerator();
        #endregion

        public CustomColours()
        {
            InitializeComponent();
        }

        private void CustomColours_Load(object sender, EventArgs e)
        {
            ColourUtilities.PropagateStandardColours(kcmbNormalTextColour);

            ColourUtilities.PropagateSystemColours(kcmbNormalTextSystemColours);
        }

        private void pbxColourPreview_MouseEnter(object sender, EventArgs e)
        {
            //InformationControlManager.DisplayColourInformation(pbxColourPreview, false, "Colour Preview");
        }

        private void kcmbNormalTextColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color temporyColour = Color.FromName(kcmbNormalTextColour.Text);

            pbxColourPreview.BackColor = Color.FromName(kcmbNormalTextColour.Text);

            knumRedChannelValue.Value = temporyColour.R;

            knumGreenChannelValue.Value = temporyColour.G;

            knumBlueChannelValue.Value = temporyColour.B;
        }

        private void kcmbNormalTextSystemColours_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbxColourPreview.BackColor = Color.FromName(kcmbNormalTextSystemColours.Text);
        }

        private void kbtnSaveColour_Click(object sender, EventArgs e)
        {
            if (klstCustomColourSelector.SelectedItem.ToString() == "Border Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.BORDERCOLOUR, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Alternative Normal Text Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.ALTERNATIVENORMALTEXTCOLOUR, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Normal Text Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.NORMALTEXTCOLOUR, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Disabled Text Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.DISABLEDTEXTCOLOUR, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Focused Text Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.FOCUSEDTEXTCOLOUR, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Pressed Text Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.PRESSEDTEXTCOLOUR, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Link Normal Text Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.LINKNORMALTEXTCOLOUR, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Link Hover Text Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.LINKHOVERTEXTCOLOUR, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Link Visited Text Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.LINKVISITEDTEXTCOLOUR, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Disabled Control Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.DISABLEDCONTROLCOLOUR, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Custom Colour One")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.CUSTOMCOLOURONE, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Custom Colour Two")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.CUSTOMCOLOURTWO, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Custom Colour Three")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.CUSTOMCOLOURTHREE, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Custom Colour Four")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.CUSTOMCOLOURFOUR, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Custom Colour Five")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.CUSTOMCOLOURFIVE, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Menu Text Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.MENUTEXTCOLOUR, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Custom Text Colour One")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.CUSTOMTEXTCOLOURONE, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Custom Text Colour Two")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.CUSTOMTEXTCOLOURTWO, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Custom Text Colour Three")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.CUSTOMTEXTCOLOURTHREE, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Custom Text Colour Four")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.CUSTOMTEXTCOLOURFOUR, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Custom Text Colour Five")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.CUSTOMTEXTCOLOURFIVE, pbxColourPreview.BackColor);
            }
            else if (klstCustomColourSelector.SelectedItem.ToString() == "Status Text Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.STATUSTEXTCOLOUR, pbxColourPreview.BackColor);
            }
        }

        private void knumRedChannelValue_ValueChanged(object sender, EventArgs e)
        {
            ColourUtilities.UpdateColour(pbxColourPreview, 255, Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value));

            kbtnSaveColour.Enabled = true;
        }

        private void knumGreenChannelValue_ValueChanged(object sender, EventArgs e)
        {
            ColourUtilities.UpdateColour(pbxColourPreview, 255, Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value));

            kbtnSaveColour.Enabled = true;
        }

        private void knumBlueChannelValue_ValueChanged(object sender, EventArgs e)
        {
            ColourUtilities.UpdateColour(pbxColourPreview, 255, Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value));

            kbtnSaveColour.Enabled = true;
        }

        private void kbtnGenerateNormalTextRedValue_Click(object sender, EventArgs e)
        {
            knumRedChannelValue.Value = _randomNumberGenerator.RandomlyGenerateARedNumberBetween(0, 255);
        }

        private void kbtnGenerateNormalTextGreenValue_Click(object sender, EventArgs e)
        {
            knumGreenChannelValue.Value = _randomNumberGenerator.RandomlyGenerateAGreenNumberBetween(0, 255);
        }

        private void kbtnGenerateNormalTextBlueValue_Click(object sender, EventArgs e)
        {
            knumBlueChannelValue.Value = _randomNumberGenerator.RandomlyGenerateABlueNumberBetween(0, 255);
        }
    }
}
