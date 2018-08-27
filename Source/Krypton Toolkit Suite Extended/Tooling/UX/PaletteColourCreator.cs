using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tooling.Classes.Colours.Extended;
using Tooling.Classes.Other;
using Tooling.Settings.Classes;

namespace Tooling.UX
{
    public partial class PaletteColourCreator : KryptonForm
    {
        #region Variables
        private ConversionMethods _conversionMethods = new ConversionMethods();

        private RandomNumberGenerator _randomNumberGenerator = new RandomNumberGenerator();

        private HSLColour _hslColour = new HSLColour();

        private ColourControlManager _colourControlManager = new ColourControlManager();

        private GlobalBooleanSettingsManager _globalBooleanSettingsManager = new GlobalBooleanSettingsManager();

        private Color _baseColour, _colourDark, _colourNormal, _colourLight, _colourLightness;
        #endregion

        #region Properties
        public Color BaseColour { get { return _baseColour; } set { _baseColour = value; } }
        #endregion

        #region Constructors
        public PaletteColourCreator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaletteColourCreator"/> class.
        /// </summary>
        /// <param name="alphaValue">The alpha value.</param>
        /// <param name="redValue">The red value.</param>
        /// <param name="greenValue">The green value.</param>
        /// <param name="blueValue">The blue value.</param>
        public PaletteColourCreator(int alphaValue, int redValue, int greenValue, int blueValue)
        {
            InitializeComponent();

            knumAlphaChannelValue.Value = alphaValue;

            knumRedChannelValue.Value = redValue;

            knumGreenChannelValue.Value = greenValue;

            knumBlueChannelValue.Value = blueValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaletteColourCreator"/> class.
        /// </summary>
        /// <param name="baseColour">The base colour.</param>
        public PaletteColourCreator(Color baseColour)
        {
            InitializeComponent();

            BaseColour = baseColour;

            cpbBaseColourPreview.BackColor = baseColour;
        }
        #endregion

        private void PaletteColourCreator_Load(object sender, EventArgs e)
        {
            foreach (KnownColor colour in Enum.GetValues(typeof(KnownColor)))
            {
                kcmbNormalTextColour.AutoCompleteCustomSource.Add(colour.ToString());

                kcmbNormalTextColour.Items.Add(colour);

                kcmbDisabledTextColour.AutoCompleteCustomSource.Add(colour.ToString());

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
            ttInformation.SetToolTip(pbxDarkColour, $"Dark Colour\nARGB: ({ pbxDarkColour.BackColor.A.ToString() }, { pbxDarkColour.BackColor.R.ToString() }, { pbxDarkColour.BackColor.G.ToString() }, { pbxDarkColour.BackColor.B.ToString() })\nRGB: ({ pbxDarkColour.BackColor.R.ToString() }, { pbxDarkColour.BackColor.G.ToString() }, { pbxDarkColour.BackColor.B.ToString() })\nHexadecimal Value: #{ _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(pbxDarkColour.BackColor.R), Convert.ToInt32(pbxDarkColour.BackColor.G), Convert.ToInt32(pbxDarkColour.BackColor.B)).ToUpper() }\nHue: { pbxDarkColour.BackColor.GetHue().ToString() }\nSaturation: { pbxDarkColour.BackColor.GetSaturation().ToString() }\nBrightness: { pbxDarkColour.BackColor.GetBrightness().ToString() }");
        }

        private void pbxMiddleColour_MouseEnter(object sender, EventArgs e)
        {
            ttInformation.SetToolTip(pbxMiddleColour, $"Middle Colour\nARGB: ({ pbxMiddleColour.BackColor.A.ToString() }, { pbxMiddleColour.BackColor.R.ToString() }, { pbxMiddleColour.BackColor.G.ToString() }, { pbxMiddleColour.BackColor.B.ToString() })\nRGB: ({ pbxMiddleColour.BackColor.R.ToString() }, { pbxMiddleColour.BackColor.G.ToString() }, { pbxMiddleColour.BackColor.B.ToString() })\nHexadecimal Value: #{ _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(pbxMiddleColour.BackColor.R), Convert.ToInt32(pbxMiddleColour.BackColor.G), Convert.ToInt32(pbxMiddleColour.BackColor.B)).ToUpper() }\nHue: { pbxMiddleColour.BackColor.GetHue().ToString() }\nSaturation: { pbxMiddleColour.BackColor.GetSaturation().ToString() }\nBrightness: { pbxMiddleColour.BackColor.GetBrightness().ToString() }");
        }

        private void pbxLightColour_MouseEnter(object sender, EventArgs e)
        {
            ttInformation.SetToolTip(pbxLightColour, $"Light Colour\nARGB: ({ pbxLightColour.BackColor.A.ToString() }, { pbxLightColour.BackColor.R.ToString() }, { pbxLightColour.BackColor.G.ToString() }, { pbxLightColour.BackColor.B.ToString() })\nRGB: ({ pbxLightColour.BackColor.R.ToString() }, { pbxLightColour.BackColor.G.ToString() }, { pbxLightColour.BackColor.B.ToString() })\nHexadecimal Value: #{ _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(pbxLightColour.BackColor.R), Convert.ToInt32(pbxLightColour.BackColor.G), Convert.ToInt32(pbxLightColour.BackColor.B)).ToUpper() }\nHue: { pbxLightColour.BackColor.GetHue().ToString() }\nSaturation: { pbxLightColour.BackColor.GetSaturation().ToString() }\nBrightness: { pbxLightColour.BackColor.GetBrightness().ToString() }");
        }

        private void pbxLightestColour_MouseEnter(object sender, EventArgs e)
        {
            ttInformation.SetToolTip(pbxLightestColour, $"Lightest Colour\nARGB: ({ pbxLightestColour.BackColor.A.ToString() }, { pbxLightestColour.BackColor.R.ToString() }, { pbxLightestColour.BackColor.G.ToString() }, { pbxLightestColour.BackColor.B.ToString() })\nRGB: ({ pbxLightestColour.BackColor.R.ToString() }, { pbxLightestColour.BackColor.G.ToString() }, { pbxLightestColour.BackColor.B.ToString() })\nHexadecimal Value: #{ _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(pbxLightestColour.BackColor.R), Convert.ToInt32(pbxLightestColour.BackColor.G), Convert.ToInt32(pbxLightestColour.BackColor.B)).ToUpper() }\nHue: { pbxLightestColour.BackColor.GetHue().ToString() }\nSaturation: { pbxLightestColour.BackColor.GetSaturation().ToString() }\nBrightness: { pbxLightestColour.BackColor.GetBrightness().ToString() }");
        }

        private void pbxNormalTextColour_MouseEnter(object sender, EventArgs e)
        {
            ttInformation.SetToolTip(pbxNormalTextColour, $"Normal Text Colour\nARGB: ({ pbxNormalTextColour.BackColor.A.ToString() }, { pbxNormalTextColour.BackColor.R.ToString() }, { pbxNormalTextColour.BackColor.G.ToString() }, { pbxNormalTextColour.BackColor.B.ToString() })\nRGB: ({ pbxNormalTextColour.BackColor.R.ToString() }, { pbxNormalTextColour.BackColor.G.ToString() }, { pbxNormalTextColour.BackColor.B.ToString() })\nHexadecimal Value: #{ _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(pbxNormalTextColour.BackColor.R), Convert.ToInt32(pbxNormalTextColour.BackColor.G), Convert.ToInt32(pbxNormalTextColour.BackColor.B)).ToUpper() }");
        }

        private void pbxDisabledTextColour_MouseEnter(object sender, EventArgs e)
        {
            ttInformation.SetToolTip(pbxDisabledTextColour, $"Disabled Text Colour\nARGB: ({ pbxDisabledTextColour.BackColor.A.ToString() }, { pbxDisabledTextColour.BackColor.R.ToString() }, { pbxDisabledTextColour.BackColor.G.ToString() }, { pbxDisabledTextColour.BackColor.B.ToString() })\nRGB: ({ pbxDisabledTextColour.BackColor.R.ToString() }, { pbxDisabledTextColour.BackColor.G.ToString() }, { pbxDisabledTextColour.BackColor.B.ToString() })\nHexadecimal Value: #{ _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(pbxDisabledTextColour.BackColor.R), Convert.ToInt32(pbxDisabledTextColour.BackColor.G), Convert.ToInt32(pbxDisabledTextColour.BackColor.B)).ToUpper() }");
        }

        private void knumRedChannelValue_ValueChanged(object sender, EventArgs e)
        {
            pbxBaseColour.BackColor = Color.FromArgb(Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value));
        }

        private void knumGreenChannelValue_ValueChanged(object sender, EventArgs e)
        {
            pbxBaseColour.BackColor = Color.FromArgb(Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value));
        }

        private void knumBlueChannelValue_ValueChanged(object sender, EventArgs e)
        {
            pbxBaseColour.BackColor = Color.FromArgb(Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value));
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
            //ColourUtilities.GenerateColourShades(pbxBaseColour.BackColor, pbxDarkColour, pbxMiddleColour, pbxLightColour, pbxLightestColour);

            ColourUtilities.GenerateColourShades(cpbBaseColourPreview.BackColor, cpbDarkestColourPreview, cpbMiddleColourPreview, cpbLightColourPreview, cpbLightestColourPreview);
        }

        private void kbtnExport_Click(object sender, EventArgs e)
        {
            ColourSettingsManager colourSettingsManager = new ColourSettingsManager();

            if (_globalBooleanSettingsManager.GetUseCircularPictureBoxes())
            {
                colourSettingsManager.SetBaseColour(cpbBaseColourPreview.BackColor);

                colourSettingsManager.SetDarkestColour(cpbDarkestColourPreview.BackColor);

                colourSettingsManager.SetMediumColour(cpbMiddleColourPreview.BackColor);

                colourSettingsManager.SetLightColour(cpbLightColourPreview.BackColor);

                colourSettingsManager.SetLightestColour(cpbLightestColourPreview.BackColor);
            }
            else
            {
                colourSettingsManager.SetBaseColour(pbxBaseColour.BackColor);

                colourSettingsManager.SetDarkestColour(pbxDarkColour.BackColor);

                colourSettingsManager.SetMediumColour(pbxMiddleColour.BackColor);

                colourSettingsManager.SetLightColour(pbxLightColour.BackColor);

                colourSettingsManager.SetLightestColour(pbxLightestColour.BackColor);
            }

            colourSettingsManager.SaveColourSettings();
        }

        private void knumHueValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            UpdateBaseColour();
        }
        #endregion

        private void tmrUpdateUI_Tick(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateBaseColour()
        {
            //pbxBaseColour.BackColor = Color.FromArgb(255, Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value));

            cpbBaseColourPreview.BackColor = Color.FromArgb(255, Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value));
        }

        private void kchkAutomateColourSwatchValues_CheckedChanged(object sender, EventArgs e)
        {
            tmrAutomateColourSwatchValues.Enabled = kchkAutomateColourSwatchValues.Checked;
        }

        private void tmrAutomateColourSwatchValues_Tick(object sender, EventArgs e)
        {
            //ColourUtilities.GenerateColourShades(pbxBaseColour.BackColor, pbxDarkColour, pbxMiddleColour, pbxLightColour, pbxLightestColour);

            ColourUtilities.GenerateColourShades(cpbBaseColourPreview.BackColor, cpbDarkestColourPreview, cpbMiddleColourPreview, cpbLightColourPreview, cpbLightestColourPreview);
        }

        private void pbxDarkColour_Click(object sender, EventArgs e)
        {
            ColourUtilities.PropagateHSBValues(knumHueValue, knumSaturation, knumBrightness, (decimal)Math.Round(pbxDarkColour.BackColor.GetHue()), (decimal)Math.Round(pbxDarkColour.BackColor.GetSaturation()), (decimal)Math.Round(pbxDarkColour.BackColor.GetBrightness()));
        }

        private void kbtnBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.Yes)
            {
                kmtxtFilePath.Text = Path.GetFullPath(saveFileDialog.FileName);
            }
        }

        private void kbtnFileExport_Click(object sender, EventArgs e)
        {
            if (kmtxtFilePath.Text != "")
            {
                FileCreator fileCreator = new FileCreator();

                fileCreator.WriteColourFile("A:\\Test Colour.txt", ColourUtilities.FormatColourARGBString(pbxDarkColour.BackColor), ColourUtilities.FormatColourARGBString(pbxMiddleColour.BackColor), ColourUtilities.FormatColourARGBString(pbxLightColour.BackColor), ColourUtilities.FormatColourARGBString(pbxLightestColour.BackColor));
            }
        }

        private void kcmbSelectedColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kcmbSelectedColour.Text == "Base Colour")
            {
                lblColourOutput.Text = $"{ ColourUtilities.FormatColourARGBString(pbxBaseColour.BackColor) }";
            }
        }

        private void kbtnDefineCustomColours_Click(object sender, EventArgs e)
        {
            CustomColours customColours = new CustomColours();

            customColours.Show();
        }

        private void kbtnSaveValues_Click(object sender, EventArgs e)
        {

        }

        private void kbtnGenerateHue_Click(object sender, EventArgs e)
        {

        }

        private Color SetHue(Color baseColour, double hueValue)
        {
            HSLColour hslColour = new HSLColour(hue: hueValue * 240, saturation: 240, luminosity: 240);

            return hslColour;
        }

        private void UpdateUI()
        {

        }
    }
}