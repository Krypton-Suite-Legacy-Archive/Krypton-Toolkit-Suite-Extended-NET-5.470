using Classes.Colours;
using ComponentFactory.Krypton.Toolkit;
using Core.Classes.Colours.Extended;
using Core.Classes.Other;
using Core.Classes.Theming;
using Core.Settings.Classes;
using Core.UX.Debugging;
using Core.UX.Options;
using System;
using System.Drawing;

namespace Core.UX
{
    public partial class PaletteColourCreator : KryptonForm
    {
        #region Variables
        private ConversionMethods _conversionMethods = new ConversionMethods();

        private RandomNumberGenerator _randomNumberGenerator = new RandomNumberGenerator();

        private HSLColour _hslColour = new HSLColour();

        private ColourControlManager _colourControlManager = new ColourControlManager();

        private GlobalBooleanSettingsManager _globalBooleanSettingsManager = new GlobalBooleanSettingsManager();

        private ColourSettingsManager _colourSettingsManager = new ColourSettingsManager();

        private Color _baseColour, _colourDark, _colourNormal, _colourLight, _colourLightness;

        private bool _paletteColourSelector;
        #endregion

        #region Properties
        public Color BaseColour { get { return _baseColour; } set { _baseColour = value; } }

        public bool PaletteColourSelector { get { return _paletteColourSelector; } set { _paletteColourSelector = value; } }
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

            cpbBaseColourPreview.BackColor = BaseColour;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaletteColourCreator"/> class.
        /// </summary>
        /// <param name="paletteColourSelector">if set to <c>true</c> [palette colour selector].</param>
        public PaletteColourCreator(bool paletteColourSelector)
        {
            InitializeComponent();

            PaletteColourSelector = paletteColourSelector;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaletteColourCreator"/> class.
        /// </summary>
        /// <param name="paletteColourSelector">if set to <c>true</c> [palette colour selector].</param>
        /// <param name="alphaValue">The alpha value.</param>
        /// <param name="redValue">The red value.</param>
        /// <param name="greenValue">The green value.</param>
        /// <param name="blueValue">The blue value.</param>
        public PaletteColourCreator(bool paletteColourSelector, int alphaValue, int redValue, int greenValue, int blueValue)
        {
            InitializeComponent();

            PaletteColourSelector = paletteColourSelector;

            knumAlphaChannelValue.Value = alphaValue;

            knumRedChannelValue.Value = redValue;

            knumGreenChannelValue.Value = greenValue;

            knumBlueChannelValue.Value = blueValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaletteColourCreator"/> class.
        /// </summary>
        /// <param name="paletteColourSelector">if set to <c>true</c> [palette colour selector].</param>
        /// <param name="baseColour">The base colour.</param>
        public PaletteColourCreator(bool paletteColourSelector, Color baseColour)
        {
            InitializeComponent();

            PaletteColourSelector = paletteColourSelector;

            BaseColour = BaseColour;

            cpbBaseColourPreview.BackColor = BaseColour;
        }
        #endregion

        private void PaletteColourCreator_Load(object sender, EventArgs e)
        {
            _colourSettingsManager.ResetSettings();

            if (PaletteColourSelector)
            {
                kbtnDefineIndividualColours.Visible = true;

                kbtnDefineIndividualColours.Enabled = true;

                kbtnOptions.Location = new Point(609, 7);

                kbtnDebugConsole.Location = new Point(684, 7);
            }
            else
            {
                kbtnDefineIndividualColours.Visible = false;

                kbtnDefineIndividualColours.Enabled = false;

                kbtnOptions.Location = new Point(409, 7);

                kbtnDebugConsole.Location = new Point(484, 7);
            }

            tmrAutomateColourSwatchValues.Enabled = _globalBooleanSettingsManager.GetAutomaticallyUpdateColours();
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
            //ttInformation.SetToolTip(pbxNormalTextColour, $"Normal Text Colour\nARGB: ({ pbxNormalTextColour.BackColor.A.ToString() }, { pbxNormalTextColour.BackColor.R.ToString() }, { pbxNormalTextColour.BackColor.G.ToString() }, { pbxNormalTextColour.BackColor.B.ToString() })\nRGB: ({ pbxNormalTextColour.BackColor.R.ToString() }, { pbxNormalTextColour.BackColor.G.ToString() }, { pbxNormalTextColour.BackColor.B.ToString() })\nHexadecimal Value: #{ _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(pbxNormalTextColour.BackColor.R), Convert.ToInt32(pbxNormalTextColour.BackColor.G), Convert.ToInt32(pbxNormalTextColour.BackColor.B)).ToUpper() }");
        }

        private void pbxDisabledTextColour_MouseEnter(object sender, EventArgs e)
        {
            //ttInformation.SetToolTip(pbxDisabledTextColour, $"Disabled Text Colour\nARGB: ({ pbxDisabledTextColour.BackColor.A.ToString() }, { pbxDisabledTextColour.BackColor.R.ToString() }, { pbxDisabledTextColour.BackColor.G.ToString() }, { pbxDisabledTextColour.BackColor.B.ToString() })\nRGB: ({ pbxDisabledTextColour.BackColor.R.ToString() }, { pbxDisabledTextColour.BackColor.G.ToString() }, { pbxDisabledTextColour.BackColor.B.ToString() })\nHexadecimal Value: #{ _conversionMethods.ConvertRGBToHexadecimal(Convert.ToInt32(pbxDisabledTextColour.BackColor.R), Convert.ToInt32(pbxDisabledTextColour.BackColor.G), Convert.ToInt32(pbxDisabledTextColour.BackColor.B)).ToUpper() }");
        }

        private void knumRedChannelValue_ValueChanged(object sender, EventArgs e)
        {
            pbxBaseColour.BackColor = Color.FromArgb(Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value));

            ktbRed.Value = Convert.ToInt32(knumRedChannelValue.Value);
        }

        private void knumGreenChannelValue_ValueChanged(object sender, EventArgs e)
        {
            pbxBaseColour.BackColor = Color.FromArgb(Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value));

            ktbGreen.Value = Convert.ToInt32(knumGreenChannelValue.Value);
        }

        private void knumBlueChannelValue_ValueChanged(object sender, EventArgs e)
        {
            pbxBaseColour.BackColor = Color.FromArgb(Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value));

            ktbBlue.Value = Convert.ToInt32(knumBlueChannelValue.Value);
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

            kbtnExport.Enabled = true;
        }

        private void kbtnExport_Click(object sender, EventArgs e)
        {
            if (_globalBooleanSettingsManager.GetUseCircularPictureBoxes())
            {
                PaletteColourManagementEngine.SetBasicPaletteColours(cpbBaseColourPreview, cpbDarkestColourPreview, cpbMiddleColourPreview, cpbLightColourPreview, cpbLightestColourPreview);
            }
            else
            {
                PaletteColourManagementEngine.SetBasicPaletteColours(pbxBaseColour, pbxDarkColour, pbxMiddleColour, pbxLightColour, pbxLightestColour);
            }
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
            tmrAutomateColourSwatchValues.Enabled = _globalBooleanSettingsManager.GetAutomaticallyUpdateColours();
        }

        private void tmrAutomateColourSwatchValues_Tick(object sender, EventArgs e)
        {
            //ColourUtilities.GenerateColourShades(pbxBaseColour.BackColor, pbxDarkColour, pbxMiddleColour, pbxLightColour, pbxLightestColour);

            ColourUtilities.GenerateColourShades(cpbBaseColourPreview.BackColor, cpbDarkestColourPreview, cpbMiddleColourPreview, cpbLightColourPreview, cpbLightestColourPreview);
        }

        private void pbxDarkColour_Click(object sender, EventArgs e)
        {
            //ColourUtilities.PropagateHSBValues(knumHueValue, knumSaturation, knumBrightness, (decimal)Math.Round(pbxDarkColour.BackColor.GetHue()), (decimal)Math.Round(pbxDarkColour.BackColor.GetSaturation()), (decimal)Math.Round(pbxDarkColour.BackColor.GetBrightness()));
        }

        private void kbtnFileExport_Click(object sender, EventArgs e)
        {

        }

        private void kbtnDefineCustomColours_Click(object sender, EventArgs e)
        {
            CustomColours customColours = new CustomColours();

            customColours.Show();
        }

        private void kbtnImportColours_Click(object sender, EventArgs e)
        {
            PaletteImportManager paletteImportManager = new PaletteImportManager();

            paletteImportManager.ImportColourScheme();
        }

        private void knumAlphaChannelValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cpbBaseColourPreview_Click(object sender, EventArgs e)
        {
            knumAlphaChannelValue.Value = Convert.ToInt32(cpbBaseColourPreview.BackColor.A);

            knumRedChannelValue.Value = Convert.ToInt32(cpbBaseColourPreview.BackColor.R);

            knumGreenChannelValue.Value = Convert.ToInt32(cpbBaseColourPreview.BackColor.G);

            knumBlueChannelValue.Value = Convert.ToInt32(cpbBaseColourPreview.BackColor.B);
        }

        private void cpbDarkestColourPreview_Click(object sender, EventArgs e)
        {
            knumAlphaChannelValue.Value = Convert.ToInt32(cpbDarkestColourPreview.BackColor.A);

            knumRedChannelValue.Value = Convert.ToInt32(cpbDarkestColourPreview.BackColor.R);

            knumGreenChannelValue.Value = Convert.ToInt32(cpbDarkestColourPreview.BackColor.G);

            knumBlueChannelValue.Value = Convert.ToInt32(cpbDarkestColourPreview.BackColor.B);
        }

        private void cpbMiddleColourPreview_Click(object sender, EventArgs e)
        {
            knumAlphaChannelValue.Value = Convert.ToInt32(cpbMiddleColourPreview.BackColor.A);

            knumRedChannelValue.Value = Convert.ToInt32(cpbMiddleColourPreview.BackColor.R);

            knumGreenChannelValue.Value = Convert.ToInt32(cpbMiddleColourPreview.BackColor.G);

            knumBlueChannelValue.Value = Convert.ToInt32(cpbMiddleColourPreview.BackColor.B);
        }

        private void cpbLightColourPreview_Click(object sender, EventArgs e)
        {
            knumAlphaChannelValue.Value = Convert.ToInt32(cpbLightColourPreview.BackColor.A);

            knumRedChannelValue.Value = Convert.ToInt32(cpbLightColourPreview.BackColor.R);

            knumGreenChannelValue.Value = Convert.ToInt32(cpbLightColourPreview.BackColor.G);

            knumBlueChannelValue.Value = Convert.ToInt32(cpbLightColourPreview.BackColor.B);
        }

        private void cpbLightestColourPreview_Click(object sender, EventArgs e)
        {
            knumAlphaChannelValue.Value = Convert.ToInt32(cpbLightestColourPreview.BackColor.A);

            knumRedChannelValue.Value = Convert.ToInt32(cpbLightestColourPreview.BackColor.R);

            knumGreenChannelValue.Value = Convert.ToInt32(cpbLightestColourPreview.BackColor.G);

            knumBlueChannelValue.Value = Convert.ToInt32(cpbLightestColourPreview.BackColor.B);
        }

        private void kbtnDefineIndividualColours_Click(object sender, EventArgs e)
        {
            DefineIndividualColoursDialog defineIndividualColours = new DefineIndividualColoursDialog();

            defineIndividualColours.Show();
        }

        private void kbtnOptions_Click(object sender, EventArgs e)
        {
            ColourBlendingOptions colourBlendingOptions = new ColourBlendingOptions();

            colourBlendingOptions.Show();
        }

        private void ktbAlpha_ValueChanged(object sender, EventArgs e)
        {
            knumAlphaChannelValue.Value = ktbAlpha.Value;

            ttInformation.SetToolTip(ktbAlpha, ktbAlpha.Value.ToString());
        }

        private void ktbRed_ValueChanged(object sender, EventArgs e)
        {
            knumRedChannelValue.Value = ktbRed.Value;

            ttInformation.SetToolTip(ktbRed, ktbRed.Value.ToString());
        }

        private void ktbGreen_ValueChanged(object sender, EventArgs e)
        {
            knumGreenChannelValue.Value = ktbGreen.Value;

            ttInformation.SetToolTip(ktbGreen, ktbGreen.Value.ToString());
        }

        private void ktbBlue_ValueChanged(object sender, EventArgs e)
        {
            knumBlueChannelValue.Value = ktbBlue.Value;

            ttInformation.SetToolTip(ktbBlue, ktbBlue.Value.ToString());
        }

        private void kcbBaseColour_SelectedColorChanged(object sender, ColorEventArgs e)
        {
            knumRedChannelValue.Value = kcbBaseColour.SelectedColor.R;

            knumGreenChannelValue.Value = kcbBaseColour.SelectedColor.G;

            knumBlueChannelValue.Value = kcbBaseColour.SelectedColor.B;
        }

        private void kbtnDebugConsole_Click(object sender, EventArgs e)
        {
            ColourSettingsViewer colourSettingsViewer = new ColourSettingsViewer();

            colourSettingsViewer.Show();
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
            cpbBaseColourPreview.BackColor = _colourSettingsManager.GetBaseColour();

            cpbDarkestColourPreview.BackColor = _colourSettingsManager.GetDarkestColour();

            cpbMiddleColourPreview.BackColor = _colourSettingsManager.GetMediumColour();

            cpbLightColourPreview.BackColor = _colourSettingsManager.GetLightColour();

            cpbLightestColourPreview.BackColor = _colourSettingsManager.GetLightestColour();

            if (cpbBaseColourPreview.BackColor != Color.Empty || cpbDarkestColourPreview.BackColor != Color.Empty || cpbMiddleColourPreview.BackColor != Color.Empty || cpbLightColourPreview.BackColor != Color.Empty)
            {
                kbtnExport.Enabled = true;
            }
            else
            {
                kbtnExport.Enabled = false;
            }
        }
    }
}