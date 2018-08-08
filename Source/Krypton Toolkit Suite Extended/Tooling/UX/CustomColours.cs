using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using Tooling.Classes.Other;

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
            InformationControlManager.DisplayColourInformation(pbxColourPreview);
        }

        private void knumNormalTextRedChannelValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void knumNormalTextGreenChannelValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void knumNormalTextBlueChannelValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void kcmbNormalTextColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color temporyColour = Color.FromName(kcmbNormalTextColour.Text);

            pbxColourPreview.BackColor = Color.FromName(kcmbNormalTextColour.Text);

            knumNormalTextRedChannelValue.Value = temporyColour.R;

            knumNormalTextGreenChannelValue.Value = temporyColour.G;

            knumNormalTextBlueChannelValue.Value = temporyColour.B;
        }

        private void kcmbNormalTextSystemColours_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbxColourPreview.BackColor = Color.FromName(kcmbNormalTextSystemColours.Text);
        }
    }
}
