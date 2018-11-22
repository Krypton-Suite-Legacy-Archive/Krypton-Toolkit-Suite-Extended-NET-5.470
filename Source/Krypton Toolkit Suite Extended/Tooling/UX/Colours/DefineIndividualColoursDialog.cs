using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;
using Tooling.Classes.Other;
using Tooling.Enumerations;

namespace Tooling.UX
{
    public partial class DefineIndividualColoursDialog : KryptonForm
    {
        #region Variables
        private ConversionMethods _conversionMethods = new ConversionMethods();

        private RandomNumberGenerator _randomNumberGenerator = new RandomNumberGenerator();

        private BasicPaletteColourDefinitions _basicPaletteColourDefinitions;
        #endregion

        #region Properties
        public BasicPaletteColourDefinitions BasicPaletteColourDefinition { get { return _basicPaletteColourDefinitions; } set { _basicPaletteColourDefinitions = value; } }
        #endregion

        public DefineIndividualColoursDialog()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void DefineIndividualColoursDialog_Load(object sender, EventArgs e)
        {

        }

        private void cpbBaseColourPreview_Click(object sender, EventArgs e)
        {

        }

        private void cpbBaseColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cpbDarkestColourPreview_Click(object sender, EventArgs e)
        {

        }

        private void cpbDarkestColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cpbMiddleColourPreview_Click(object sender, EventArgs e)
        {

        }

        private void cpbMiddleColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cpbLightColourPreview_Click(object sender, EventArgs e)
        {

        }

        private void cpbLightColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void cpbLightestColourPreview_Click(object sender, EventArgs e)
        {

        }

        private void cpbLightestColourPreview_MouseHover(object sender, EventArgs e)
        {

        }

        private void ktbAlpha_ValueChanged(object sender, EventArgs e)
        {
            knumAlphaChannelValue.Value = ktbAlpha.Value;

            SetExportSelectedColourEnabledState(true);
        }

        private void knumAlphaChannelValue_ValueChanged(object sender, EventArgs e)
        {
            ktbAlpha.Value = Convert.ToInt32(knumAlphaChannelValue.Value);

            SetExportSelectedColourEnabledState(true);
        }

        private void ktbRed_ValueChanged(object sender, EventArgs e)
        {
            knumRedChannelValue.Value = ktbRed.Value;

            SetExportSelectedColourEnabledState(true);
        }

        private void knumRedChannelValue_ValueChanged(object sender, EventArgs e)
        {
            ktbRed.Value = Convert.ToInt32(knumRedChannelValue.Value);

            SetExportSelectedColourEnabledState(true);
        }

        private void ktbGreen_ValueChanged(object sender, EventArgs e)
        {
            knumGreenChannelValue.Value = ktbGreen.Value;

            SetExportSelectedColourEnabledState(true);
        }

        private void knumGreenChannelValue_ValueChanged(object sender, EventArgs e)
        {
            ktbGreen.Value = Convert.ToInt32(knumGreenChannelValue.Value);

            SetExportSelectedColourEnabledState(true);
        }

        private void ktbBlue_ValueChanged(object sender, EventArgs e)
        {
            knumBlueChannelValue.Value = ktbBlue.Value;

            SetExportSelectedColourEnabledState(true);
        }

        private void knumBlueChannelValue_ValueChanged(object sender, EventArgs e)
        {
            ktbBlue.Value = Convert.ToInt32(knumBlueChannelValue.Value);

            SetExportSelectedColourEnabledState(true);
        }

        private void kbtnGenerateAlpha_Click(object sender, EventArgs e)
        {
            ktbAlpha.Value = _randomNumberGenerator.RandomlyGenerateAlphaNumberBetween(0, 255);
        }

        private void kbtnGenerateRedValue_Click(object sender, EventArgs e)
        {
            ktbRed.Value = _randomNumberGenerator.RandomlyGenerateARedNumberBetween(0, 255);
        }

        private void kbtnGenerateGreenValue_Click(object sender, EventArgs e)
        {
            ktbGreen.Value = _randomNumberGenerator.RandomlyGenerateAGreenNumberBetween(0, 255);
        }

        private void kbtnGenerateBlueValue_Click(object sender, EventArgs e)
        {
            ktbBlue.Value = _randomNumberGenerator.RandomlyGenerateABlueNumberBetween(0, 255);
        }

        private void kcmbDefinedColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kcmbDefinedColour.SelectedIndex == 0)
            {
                SetBasicPaletteColourDefinition(BasicPaletteColourDefinitions.BASECOLOUR);
            }
            else if (kcmbDefinedColour.SelectedIndex == 1)
            {
                SetBasicPaletteColourDefinition(BasicPaletteColourDefinitions.DARKESTCOLOUR);
            }
            else if (kcmbDefinedColour.SelectedIndex == 2)
            {
                SetBasicPaletteColourDefinition(BasicPaletteColourDefinitions.MIDDLECOLOUR);
            }
            else if (kcmbDefinedColour.SelectedIndex == 3)
            {
                SetBasicPaletteColourDefinition(BasicPaletteColourDefinitions.LIGHTCOLOUR);
            }
            else if (kcmbDefinedColour.SelectedIndex == 4)
            {
                SetBasicPaletteColourDefinition(BasicPaletteColourDefinitions.LIGHTESTCOLOUR);
            }
        }

        private void kcmbDefinedColour_TextChanged(object sender, EventArgs e)
        {
            if (kcmbDefinedColour.Text == "Basic Colour")
            {
                SetBasicPaletteColourDefinition(BasicPaletteColourDefinitions.BASECOLOUR);
            }
            else if (kcmbDefinedColour.Text == "Darkest Colour")
            {
                SetBasicPaletteColourDefinition(BasicPaletteColourDefinitions.DARKESTCOLOUR);
            }
            else if (kcmbDefinedColour.Text == "Middle Colour")
            {
                SetBasicPaletteColourDefinition(BasicPaletteColourDefinitions.MIDDLECOLOUR);
            }
            else if (kcmbDefinedColour.Text == "Light Colour")
            {
                SetBasicPaletteColourDefinition(BasicPaletteColourDefinitions.LIGHTCOLOUR);
            }
            else if (kcmbDefinedColour.Text == "Lightest Colour")
            {
                SetBasicPaletteColourDefinition(BasicPaletteColourDefinitions.LIGHTESTCOLOUR);
            }
        }

        private void kbtnExportSelectedColour_Click(object sender, EventArgs e)
        {
            if (GetPaletteColourDefinition() == BasicPaletteColourDefinitions.BASECOLOUR)
            {

            }
            else if (GetPaletteColourDefinition() == BasicPaletteColourDefinitions.DARKESTCOLOUR)
            {

            }
            else if (GetPaletteColourDefinition() == BasicPaletteColourDefinitions.MIDDLECOLOUR)
            {

            }
            else if (GetPaletteColourDefinition() == BasicPaletteColourDefinitions.LIGHTCOLOUR)
            {

            }
            else if (GetPaletteColourDefinition() == BasicPaletteColourDefinitions.LIGHTESTCOLOUR)
            {

            }

            SetExportSelectedColourEnabledState(false);
        }

        private void ktbHexadecimal_TextChanged(object sender, EventArgs e)
        {

        }

        private void ktbHexadecimal_MouseHover(object sender, EventArgs e)
        {
            ttInformation.SetToolTip(this, $"Hexadecimal Value: { ktbHexadecimal.Text.ToUpper() }");
        }

        private void kbtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void tmrUpdateUI_Tick(object sender, EventArgs e)
        {
            UpdateUI();
        }
        #endregion

        #region Methods
        private void UpdateUI()
        {
            if (GetPaletteColourDefinition() == BasicPaletteColourDefinitions.BASECOLOUR)
            {

                ktbHexadecimal.Text = _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value)).ToUpper();

                cpbBaseColourPreview.BackColor = Color.FromArgb(Convert.ToInt32(knumAlphaChannelValue.Value), Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value));
            }
            else if (GetPaletteColourDefinition() == BasicPaletteColourDefinitions.DARKESTCOLOUR)
            {
                ktbHexadecimal.Text = _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value)).ToUpper();

                cpbDarkestColourPreview.BackColor = Color.FromArgb(Convert.ToInt32(knumAlphaChannelValue.Value), Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value));
            }
            else if (GetPaletteColourDefinition() == BasicPaletteColourDefinitions.MIDDLECOLOUR)
            {
                ktbHexadecimal.Text = _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value)).ToUpper();

                cpbMiddleColourPreview.BackColor = Color.FromArgb(Convert.ToInt32(knumAlphaChannelValue.Value), Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value));
            }
            else if (GetPaletteColourDefinition() == BasicPaletteColourDefinitions.LIGHTCOLOUR)
            {
                ktbHexadecimal.Text = _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value)).ToUpper();

                cpbLightColourPreview.BackColor = Color.FromArgb(Convert.ToInt32(knumAlphaChannelValue.Value), Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value));
            }
            else if (GetPaletteColourDefinition() == BasicPaletteColourDefinitions.LIGHTESTCOLOUR)
            {
                ktbHexadecimal.Text = _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value)).ToUpper();

                cpbLightestColourPreview.BackColor = Color.FromArgb(Convert.ToInt32(knumAlphaChannelValue.Value), Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value));
            }
        }

        private void AlterColours(BasicPaletteColourDefinitions paletteColourDefinitions)
        {
            switch (paletteColourDefinitions)
            {
                case BasicPaletteColourDefinitions.BASECOLOUR:
                    SetBasicPaletteColourDefinition(BasicPaletteColourDefinitions.BASECOLOUR);
                    break;
                case BasicPaletteColourDefinitions.DARKESTCOLOUR:
                    SetBasicPaletteColourDefinition(BasicPaletteColourDefinitions.DARKESTCOLOUR);
                    break;
                case BasicPaletteColourDefinitions.MIDDLECOLOUR:
                    SetBasicPaletteColourDefinition(BasicPaletteColourDefinitions.MIDDLECOLOUR);
                    break;
                case BasicPaletteColourDefinitions.LIGHTCOLOUR:
                    SetBasicPaletteColourDefinition(BasicPaletteColourDefinitions.LIGHTCOLOUR);
                    break;
                case BasicPaletteColourDefinitions.LIGHTESTCOLOUR:
                    SetBasicPaletteColourDefinition(BasicPaletteColourDefinitions.LIGHTESTCOLOUR);
                    break;
                default:
                    break;
            }
        }

        private void SetExportSelectedColourEnabledState(bool enabledState)
        {
            kbtnExportSelectedColour.Enabled = enabledState;
        }
        #endregion

        #region Setters & Getters
        private void SetBasicPaletteColourDefinition(BasicPaletteColourDefinitions colourDefinition)
        {
            BasicPaletteColourDefinition = colourDefinition;
        }

        private BasicPaletteColourDefinitions GetPaletteColourDefinition()
        {
            return BasicPaletteColourDefinition;
        }
        #endregion
    }
}