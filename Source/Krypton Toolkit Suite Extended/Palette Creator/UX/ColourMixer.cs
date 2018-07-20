using ComponentFactory.Krypton.Toolkit;
using PaletteCreator.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;
using Tooling.Classes.Other;

namespace PaletteCreator.UX
{
    public partial class ColourMixer : KryptonForm
    {
        #region Variables
        private RandomNumberGenerator _randomNumberGenerator = new RandomNumberGenerator();

        private Tooling.Classes.Other.ToolTipManager _toolTipManager = new Tooling.Classes.Other.ToolTipManager();

        private ConversionMethods _conversionMethods = new ConversionMethods();

        private SettingsManager _settingsManager = new SettingsManager();
        #endregion

        public ColourMixer()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void pbxBaseColour_MouseEnter(object sender, EventArgs e)
        {
            _toolTipManager.DisplayToolTip(ttInformation, pbxBaseColour, "Base", pbxBaseColour.BackColor.A, pbxBaseColour.BackColor.R, pbxBaseColour.BackColor.G, pbxBaseColour.BackColor.B, _conversionMethods.ConvertRGBToHexadecimal(pbxBaseColour.BackColor.R, pbxBaseColour.BackColor.G, pbxBaseColour.BackColor.B), 0);
        }

        private void knumAlphaChannelValue_ValueChanged(object sender, EventArgs e)
        {
            ktbAlphaChannelValue.Value = Convert.ToInt32(knumAlphaChannelValue.Value);

            UpdateAlphaChannelValue(Convert.ToInt32(knumAlphaChannelValue.Value));

        }

        private void knumRedChannelValue_ValueChanged(object sender, EventArgs e)
        {
            ktbRedChannelValue.Value = Convert.ToInt32(knumRedChannelValue.Value);

            UpdateRedChannelValue(Convert.ToInt32(knumRedChannelValue.Value));
        }

        private void knumGreenChannelValue_ValueChanged(object sender, EventArgs e)
        {
            ktbGreenChannelValue.Value = Convert.ToInt32(knumGreenChannelValue.Value);

            UpdateGreenChannelValue(Convert.ToInt32(knumGreenChannelValue.Value));
        }

        private void knumBlueChannelValue_ValueChanged(object sender, EventArgs e)
        {
            ktbBlueChannelValue.Value = Convert.ToInt32(ktbRedChannelValue.Value);

            UpdateBlueChannelValue(Convert.ToInt32(ktbBlueChannelValue.Value));
        }

        private void ktbAlphaChannelValue_ValueChanged(object sender, EventArgs e)
        {
            knumAlphaChannelValue.Value = ktbAlphaChannelValue.Value;

            UpdateAlphaChannelValue(ktbAlphaChannelValue.Value);
        }

        private void ktbRedChannelValue_ValueChanged(object sender, EventArgs e)
        {
            knumRedChannelValue.Value = ktbRedChannelValue.Value;

            UpdateRedChannelValue(ktbRedChannelValue.Value);
        }

        private void ktbGreenChannelValue_ValueChanged(object sender, EventArgs e)
        {
            knumGreenChannelValue.Value = ktbGreenChannelValue.Value;

            UpdateGreenChannelValue(ktbGreenChannelValue.Value);
        }

        private void ktbBlueChannelValue_ValueChanged(object sender, EventArgs e)
        {
            knumBlueChannelValue.Value = ktbAlphaChannelValue.Value;
        }

        private void kbtnGenerateAlphaChannelValue_Click(object sender, EventArgs e)
        {
            knumAlphaChannelValue.Value = _randomNumberGenerator.RandomlyGenerateAlphaNumberBetween(0, 255);
        }

        private void kbtnGenerateRedChannelValue_Click(object sender, EventArgs e)
        {
            knumRedChannelValue.Value = _randomNumberGenerator.RandomlyGenerateARedNumberBetween(0, 255);
        }

        private void kbtnGenerateGreenChannelValue_Click(object sender, EventArgs e)
        {
            knumGreenChannelValue.Value = _randomNumberGenerator.RandomlyGenerateAGreenNumberBetween(0, 255);
        }

        private void kbtnGenerateBlueChannelValue_Click(object sender, EventArgs e)
        {
            knumBlueChannelValue.Value = _randomNumberGenerator.RandomlyGenerateABlueNumberBetween(0, 255);
        }

        private void kbtnUseAsBaseColour_Click(object sender, EventArgs e)
        {
            DialogResult result = KryptonMessageBox.Show($"Are you sure that you want to use the colour ARGB: ({ pbxBaseColour.BackColor.A.ToString() }, { pbxBaseColour.BackColor.R.ToString() }, { pbxBaseColour.BackColor.G.ToString() }, { pbxBaseColour.BackColor.B.ToString() }) as a base colour?", "Confirm Base Colour", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _settingsManager.SetBaseColour(pbxBaseColour.BackColor);

                Hide();
            }
        }

        private void tmrUpdateUI_Tick(object sender, EventArgs e)
        {
            UpdateColour();
        }
        #endregion

        #region Methods
        private void UpdateAlphaChannelValue(int value)
        {
            //pbxBaseColour.BackColor
        }

        private void UpdateRedChannelValue(int value)
        {

        }

        private void UpdateGreenChannelValue(int value)
        {

        }

        private void UpdateBlueChannelValue(int value)
        {

        }

        private void UpdateColour()
        {
            pbxBaseColour.BackColor = Color.FromArgb(Convert.ToInt32(knumAlphaChannelValue.Value), Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value));
        }
        #endregion
    }
}