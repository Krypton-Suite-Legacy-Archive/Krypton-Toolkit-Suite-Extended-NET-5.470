using ComponentFactory.Krypton.Toolkit;
using System;
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
    }
}
