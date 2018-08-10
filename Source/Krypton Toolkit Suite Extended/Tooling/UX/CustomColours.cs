using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using Tooling.Classes.Other;
using Tooling.Enumerations;

namespace Tooling.UX
{
    public partial class CustomColours : KryptonForm
    {
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
            if (kcmbCustomColours.Text == "Border Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.BORDERCOLOUR, pbxColourPreview.BackColor);
            }
            else if (kcmbCustomColours.Text == "Alternative Normal Text Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.ALTERNATIVENORMALTEXTCOLOUR, pbxColourPreview.BackColor);
            }
            else if (kcmbCustomColours.Text == "Normal Text Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.NORMALTEXTCOLOUR, pbxColourPreview.BackColor);
            }
            else if (kcmbCustomColours.Text == "Disabled Text Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.DISABLEDTEXTCOLOUR, pbxColourPreview.BackColor);
            }
            else if (kcmbCustomColours.Text == "Focused Text Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.FOCUSEDTEXTCOLOUR, pbxColourPreview.BackColor);
            }
            else if (kcmbCustomColours.Text == "Pressed Text Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.PRESSEDTEXTCOLOUR, pbxColourPreview.BackColor);
            }
            else if (kcmbCustomColours.Text == "Link Normal Text Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.LINKNORMALTEXTCOLOUR, pbxColourPreview.BackColor);
            }
            else if (kcmbCustomColours.Text == "Link Hover Text Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.LINKHOVERTEXTCOLOUR, pbxColourPreview.BackColor);
            }
            else if (kcmbCustomColours.Text == "Link Visited Text Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.LINKVISITEDTEXTCOLOUR, pbxColourPreview.BackColor);
            }
            else if (kcmbCustomColours.Text == "Disabled Control Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.DISABLEDCONTROLCOLOUR, pbxColourPreview.BackColor);
            }
            else if (kcmbCustomColours.Text == "Custom Colour One")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.CUSTOMCOLOURONE, pbxColourPreview.BackColor);
            }
            else if (kcmbCustomColours.Text == "Custom Colour Two")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.CUSTOMCOLOURTWO, pbxColourPreview.BackColor);
            }
            else if (kcmbCustomColours.Text == "Custom Colour Three")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.CUSTOMCOLOURTHREE, pbxColourPreview.BackColor);
            }
            else if (kcmbCustomColours.Text == "Custom Colour Four")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.CUSTOMCOLOURFOUR, pbxColourPreview.BackColor);
            }
            else if (kcmbCustomColours.Text == "Custom Colour Five")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.CUSTOMCOLOURFIVE, pbxColourPreview.BackColor);
            }
            else if (kcmbCustomColours.Text == "Menu Text Colour")
            {
                ColourUtilities.DefineCustomColour(MiscellaneousColourDefinitions.MENUTEXTCOLOUR, pbxColourPreview.BackColor);
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
    }
}
