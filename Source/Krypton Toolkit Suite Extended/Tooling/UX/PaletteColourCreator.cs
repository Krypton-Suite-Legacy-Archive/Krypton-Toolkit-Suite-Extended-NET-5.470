using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using Tooling.Classes.Other;

namespace Tooling.UX
{
    public partial class PaletteColourCreator : KryptonForm
    {
        #region Variables
        private ConversionMethods _conversionMethods = new ConversionMethods();

        private RandomNumberGenerator _randomNumberGenerator = new RandomNumberGenerator();
        #endregion

        public PaletteColourCreator()
        {
            InitializeComponent();
        }

        private void PaletteColourCreator_Load(object sender, EventArgs e)
        {
            foreach (KnownColor colour in Enum.GetValues(typeof(KnownColor)))
            {
                kcmbNormalTextColour.Items.Add(colour);

                kcmbDisabledTextColour.Items.Add(colour);
            }
        }

        #region Event Handlers
        private void pbxBaseColour_MouseEnter(object sender, EventArgs e)
        {
            ttInformation.SetToolTip(pbxBaseColour, $"Base Colour\nARGB: ({ pbxBaseColour.BackColor.A.ToString() }, { pbxBaseColour.BackColor.R.ToString() }, { pbxBaseColour.BackColor.G.ToString() }, { pbxBaseColour.BackColor.B.ToString() })\nRGB: ({ pbxBaseColour.BackColor.R.ToString() }, { pbxBaseColour.BackColor.G.ToString() }, { pbxBaseColour.BackColor.B.ToString() })\nHexadecimal Value: #{ _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(pbxBaseColour.BackColor.R), Convert.ToInt32(pbxBaseColour.BackColor.G), Convert.ToInt32(pbxBaseColour.BackColor.B)).ToUpper() }");
        }

        private void pbxDarkColour_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxMiddleColour_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxLightColour_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxLightestColour_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbxNormalTextColour_MouseEnter(object sender, EventArgs e)
        {
            ttInformation.SetToolTip(pbxNormalTextColour, $"Normal Text Colour\nARGB: ({ pbxNormalTextColour.BackColor.A.ToString() }, { pbxNormalTextColour.BackColor.R.ToString() }, { pbxNormalTextColour.BackColor.G.ToString() }, { pbxNormalTextColour.BackColor.B.ToString() })\nRGB: ({ pbxNormalTextColour.BackColor.R.ToString() }, { pbxNormalTextColour.BackColor.G.ToString() }, { pbxNormalTextColour.BackColor.B.ToString() })\nHexadecimal Value: #{ _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(pbxNormalTextColour.BackColor.R), Convert.ToInt32(pbxNormalTextColour.BackColor.G), Convert.ToInt32(pbxNormalTextColour.BackColor.B)).ToUpper() }");
        }

        private void pbxDisabledTextColour_MouseEnter(object sender, EventArgs e)
        {

        }

        private void knumRedChannelValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void knumGreenChannelValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void knumBlueChannelValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void kcmbNormalTextColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbxNormalTextColour.BackColor = Color.FromName(kcmbNormalTextColour.SelectedItem.ToString());
        }

        private void kcmbDisabledTextColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbxDisabledTextColour.BackColor = Color.FromName(kcmbDisabledTextColour.SelectedItem.ToString());
        }

        private void kbtnGenerateRedValue_Click(object sender, EventArgs e)
        {
            knumRedChannelValue.Value = _randomNumberGenerator.RandomlyGenerateARedNumberBetween(0, 255);
        }

        private void kbtnGenerateGreenValue_Click(object sender, EventArgs e)
        {
            knumGreenChannelValue.Value = _randomNumberGenerator.RandomlyGenerateAGreenNumberBetween(0, 255);
        }

        private void kbtnGenerateBlueValue_Click(object sender, EventArgs e)
        {
            knumBlueChannelValue.Value = _randomNumberGenerator.RandomlyGenerateABlueNumberBetween(0, 255);
        }

        private void kbtnGenerate_Click(object sender, EventArgs e)
        {

        }

        private void kbtnExport_Click(object sender, EventArgs e)
        {

        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            UpdateBaseColour();
        }
        #endregion

        private void UpdateBaseColour()
        {
            pbxBaseColour.BackColor = Color.FromArgb(255, Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value));
        }
    }
}