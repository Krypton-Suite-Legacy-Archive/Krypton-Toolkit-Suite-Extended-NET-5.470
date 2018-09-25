using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using Tooling.Classes.Other;
using Tooling.Enumerations;

namespace Tooling.UX
{
    public partial class DefineIndividualColoursDialog : KryptonForm
    {
        #region Variables
        private ConversionMethods _conversionMethods = new ConversionMethods();

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

        }

        private void knumAlphaChannelValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ktbRed_ValueChanged(object sender, EventArgs e)
        {

        }

        private void knumRedChannelValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ktbGreen_ValueChanged(object sender, EventArgs e)
        {

        }

        private void knumGreenChannelValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ktbBlue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void knumBlueChannelValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void kbtnGenerateAlpha_Click(object sender, EventArgs e)
        {

        }

        private void kbtnGenerateRedValue_Click(object sender, EventArgs e)
        {

        }

        private void kbtnGenerateGreenValue_Click(object sender, EventArgs e)
        {

        }

        private void kbtnGenerateBlueValue_Click(object sender, EventArgs e)
        {

        }

        private void kcmbDefinedColour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kcmbDefinedColour_TextChanged(object sender, EventArgs e)
        {

        }

        private void kbtnExportSelectedColour_Click(object sender, EventArgs e)
        {

        }

        private void ktbHexadecimal_TextChanged(object sender, EventArgs e)
        {

        }

        private void ktbHexadecimal_MouseHover(object sender, EventArgs e)
        {

        }

        private void kbtnOk_Click(object sender, EventArgs e)
        {

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
                knumRedChannelValue.Value = cpbBaseColourPreview.BackColor.R;

                knumGreenChannelValue.Value = cpbBaseColourPreview.BackColor.G;

                knumBlueChannelValue.Value = cpbBaseColourPreview.BackColor.B;

                ktbHexadecimal.Text = _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value)).ToUpper();

                cpbBaseColourPreview.BackColor = Color.FromArgb(Convert.ToInt32(knumAlphaChannelValue.Value), Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value));
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