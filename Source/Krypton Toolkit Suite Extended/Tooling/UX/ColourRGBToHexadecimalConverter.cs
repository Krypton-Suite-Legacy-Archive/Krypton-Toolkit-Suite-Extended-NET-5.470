using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using Tooling.Classes.Other;

namespace Tooling.UX
{
    public partial class ColourRGBToHexadecimalConverter : KryptonForm
    {
        ConversionMethods conversionMethods = new ConversionMethods();

        public ColourRGBToHexadecimalConverter()
        {
            InitializeComponent();
        }

        private void kbtnConvert_Click(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void kchkAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            tmrUpdateValues.Enabled = kchkAutoUpdate.Checked;
        }

        private void tmrUpdateValues_Tick(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            klblHexOutput.Text = $"Hex Value: #{ conversionMethods.ConvertRGBToHexadecimal(conversionMethods.ConvertDecimalToInteger(numRed.Value), conversionMethods.ConvertDecimalToInteger(numGreen.Value), conversionMethods.ConvertDecimalToInteger(numBlue.Value)).ToUpper() }";

            pnlPreview.BackColor = Color.FromArgb(conversionMethods.ConvertDecimalToInteger(numRed.Value), conversionMethods.ConvertDecimalToInteger(numGreen.Value), conversionMethods.ConvertDecimalToInteger(numBlue.Value));
        }
    }
}
