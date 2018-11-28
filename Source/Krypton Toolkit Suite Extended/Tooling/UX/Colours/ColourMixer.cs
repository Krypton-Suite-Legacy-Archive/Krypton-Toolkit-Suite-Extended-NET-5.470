using Classes.Colours;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using Tooling.Classes.Other;
using Tooling.Settings.Classes;

namespace Tooling.UX
{
    public partial class ColourMixer : KryptonForm
    {
        #region Variables
        private int _alphaChannelValue, _redColourChannelValue, _greenColourChannelValue, _blueColourChannelValue, _max = byte.MaxValue + 1;

        private ConversionMethods _conversionMethods = new ConversionMethods();

        private RandomNumberGenerator _randomNumberGenerator = new RandomNumberGenerator();

        private ColourSettingsManager _colourSettingsManager = new ColourSettingsManager();

        private ColourIntegerSettingsManager _colourIntegerSettingsManager = new ColourIntegerSettingsManager();

        private Random randomColour = new Random();

        private ColourUtility _colourUtility = new ColourUtility();

        private bool _paletteColourSelector;
        #endregion

        #region Properties
        public int AlphaChannelValue { get { return _alphaChannelValue; } set { _alphaChannelValue = value; } }

        public int RedColourChannelValue { get { return _redColourChannelValue; } set { _redColourChannelValue = value; } }

        public int GreenColourChannelValue { get { return _greenColourChannelValue; } set { _greenColourChannelValue = value; } }

        public int BlueColourChannelValue { get { return _blueColourChannelValue; } set { _blueColourChannelValue = value; } }

        public bool PaletteColourSelector { get { return _paletteColourSelector; } set { _paletteColourSelector = value; } }
        #endregion

        #region Constructors        
        /// <summary>
        /// Initializes a new instance of the <see cref="ColourMixer"/> class.
        /// </summary>
        public ColourMixer()
        {
            InitializeComponent();

            SetAlphaChannelValue(_colourIntegerSettingsManager.GetAlphaChannelValue());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColourMixer"/> class.
        /// </summary>
        /// <param name="alpha">The alpha.</param>
        /// <param name="red">The red.</param>
        /// <param name="green">The green.</param>
        /// <param name="blue">The blue.</param>
        public ColourMixer(int alpha, int red, int green, int blue)
        {
            InitializeComponent();

            SetAlphaChannelValue(alpha);

            SetRedColourChannelValue(red);

            SetGreenColourChannelValue(green);

            SetBlueColourChannelValue(blue);
        }

        public ColourMixer(Color baseColour)
        {
            InitializeComponent();

            cpbColourPreview.BackColor = baseColour;

            SetAlphaChannelValue(cpbColourPreview.BackColor.A);

            SetRedColourChannelValue(cpbColourPreview.BackColor.R);

            SetGreenColourChannelValue(cpbColourPreview.BackColor.G);

            SetBlueColourChannelValue(cpbColourPreview.BackColor.B);
        }

        public ColourMixer(bool paletteColourSelector)
        {
            InitializeComponent();

            PaletteColourSelector = paletteColourSelector;
        }

        public ColourMixer(bool paletteColourSelector, int alpha, int red, int green, int blue)
        {
            InitializeComponent();

            PaletteColourSelector = paletteColourSelector;

            SetAlphaChannelValue(alpha);

            SetRedColourChannelValue(red);

            SetGreenColourChannelValue(green);

            SetBlueColourChannelValue(blue);
        }

        public ColourMixer(bool paletteColourSelector, Color baseColour)
        {
            InitializeComponent();

            PaletteColourSelector = paletteColourSelector;

            cpbColourPreview.BackColor = baseColour;

            SetAlphaChannelValue(cpbColourPreview.BackColor.A);

            SetRedColourChannelValue(cpbColourPreview.BackColor.R);

            SetGreenColourChannelValue(cpbColourPreview.BackColor.G);

            SetBlueColourChannelValue(cpbColourPreview.BackColor.B);
        }
        #endregion

        #region Setters & Getters        
        /// <summary>
        /// Sets the AlphaChannelValue to value of value.
        /// </summary>
        /// <param name="value">The value of the AlphaChannelValue.</param>
        public void SetAlphaChannelValue(int value)
        {
            AlphaChannelValue = value;
        }

        /// <summary>
        /// Gets the AlphaChannelValue current value.
        /// </summary>
        /// <returns>The AlphaChannelValue current value.</returns>
        public int GetAlphaChannelValue()
        {
            return AlphaChannelValue;
        }

        /// <summary>
        /// Sets the RedColourChannelValue to value of value.
        /// </summary>
        /// <param name="value">The value of the RedColourChannelValue.</param>
        public void SetRedColourChannelValue(int value)
        {
            RedColourChannelValue = value;
        }

        /// <summary>
        /// Gets the RedColourChannelValue current value.
        /// </summary>
        /// <returns>The RedColourChannelValue current value.</returns>
        public int GetRedColourChannelValue()
        {
            return RedColourChannelValue;
        }

        /// <summary>
        /// Sets the GreenColourChannelValue to value of value.
        /// </summary>
        /// <param name="value">The value of the GreenColourChannelValue.</param>
        public void SetGreenColourChannelValue(int value)
        {
            GreenColourChannelValue = value;
        }

        /// <summary>
        /// Gets the GreenColourChannelValue current value.
        /// </summary>
        /// <returns>The GreenColourChannelValue current value.</returns>
        public int GetGreenColourChannelValue()
        {
            return GreenColourChannelValue;
        }

        /// <summary>
        /// Sets the BlueColourChannelValue to value of value.
        /// </summary>
        /// <param name="value">The value of the BlueColourChannelValue.</param>
        public void SetBlueColourChannelValue(int value)
        {
            BlueColourChannelValue = value;
        }

        /// <summary>
        /// Gets the BlueColourChannelValue current value.
        /// </summary>
        /// <returns>The BlueColourChannelValue current value.</returns>
        public int GetBlueColourChannelValue()
        {
            return BlueColourChannelValue;
        }
        #endregion

        #region Event Handlers
        private void ColourMixer_Load(object sender, EventArgs e)
        {
            ktbAlpha.Value = GetAlphaChannelValue();

            ktbRed.Value = GetRedColourChannelValue();

            ktbGreen.Value = GetGreenColourChannelValue();

            ktbBlue.Value = GetGreenColourChannelValue();
        }

        private void ktbAlpha_ValueChanged(object sender, EventArgs e)
        {
            knumAlphaChannelValue.Value = ktbAlpha.Value;

            SetAlphaChannelValue(ktbAlpha.Value);
        }

        private void ktbRed_ValueChanged(object sender, EventArgs e)
        {
            knumRedChannelValue.Value = ktbRed.Value;

            SetRedColourChannelValue(ktbRed.Value);
        }

        private void ktbGreen_ValueChanged(object sender, EventArgs e)
        {
            knumGreenChannelValue.Value = ktbGreen.Value;

            SetGreenColourChannelValue(ktbGreen.Value);
        }

        private void ktbBlue_ValueChanged(object sender, EventArgs e)
        {
            knumBlueChannelValue.Value = ktbBlue.Value;

            SetBlueColourChannelValue(ktbBlue.Value);
        }

        private void knumAlphaChannelValue_ValueChanged(object sender, EventArgs e)
        {
            ktbAlpha.Value = Convert.ToInt32(knumAlphaChannelValue.Value);
        }

        private void knumRedChannelValue_ValueChanged(object sender, EventArgs e)
        {
            ktbRed.Value = Convert.ToInt32(knumRedChannelValue.Value);
        }

        private void knumGreenChannelValue_ValueChanged(object sender, EventArgs e)
        {
            ktbGreen.Value = Convert.ToInt32(knumGreenChannelValue.Value);
        }

        private void knumBlueChannelValue_ValueChanged(object sender, EventArgs e)
        {
            ktbBlue.Value = Convert.ToInt32(knumBlueChannelValue.Value);
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            DisplayColour();

            SetHexadecimalValue();
        }

        #endregion

        #region CONVERSION FROM DECIMAL TO HEXADECIMAL AND VICE VERSA

        private int HexadecimaltoDecimal(string hexadecimal)
        {
            int result = 0;

            for (int i = 0; i < hexadecimal.Length; i++)
            {
                result += Convert.ToInt32(GetNumberFromNotation(hexadecimal[i]) * Math.Pow(16, Convert.ToInt32(hexadecimal.Length) - (i + 1)));
            }

            return Convert.ToInt32(result);
        }

        private string DeciamlToHexadeciaml(int number)
        {
            string[] hexvalues = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

            string result = null, final = null;

            int rem = 0, div = 0;

            while (true)
            {
                rem = (number % 16);

                result += hexvalues[rem].ToString();

                if (number < 16)
                {
                    break;
                }

                number = (number / 16);

            }

            for (int i = (result.Length - 1); i >= 0; i--)
            {
                final += result[i];
            }

            return final;
        }
        #endregion

        #region Methods
        private void SetHexadecimalValue()
        {
            ktxtHexValue.Text = _conversionMethods.ConvertRGBToHexadecimal(GetRedColourChannelValue(), GetGreenColourChannelValue(), GetBlueColourChannelValue()).ToUpper(); //DeciamlToHexadeciaml(Convert.ToInt32(knumRedChannelValue.Value + knumGreenChannelValue.Value + knumBlueChannelValue.Value));
        }

        private int GetNumberFromNotation(char c)
        {
            if (c == 'A')
            {
                return 10;
            }
            else if (c == 'B')
            {
                return 11;
            }
            else if (c == 'C')
            {
                return 12;
            }
            else if (c == 'D')
            {
                return 13;
            }
            else if (c == 'E')
            {
                return 14;
            }
            else if (c == 'F')
            {
                return 15;
            }

            return Convert.ToInt32(c.ToString());
        }

        private void kbtnGenerate_Click(object sender, EventArgs e)
        {
            kbtnGenerateRedValue.PerformClick();

            kbtnGenerateGreenValue.PerformClick();

            kbtnGenerateBlueValue.PerformClick();
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

        private void kbtnUtiliseAsBaseColour_Click(object sender, EventArgs e)
        {
            PaletteColourCreator paletteColourCreator = new PaletteColourCreator(PaletteColourSelector, Convert.ToInt32(knumAlphaChannelValue.Value), Convert.ToInt32(knumRedChannelValue.Value), Convert.ToInt32(knumGreenChannelValue.Value), Convert.ToInt32(knumBlueChannelValue.Value));

            paletteColourCreator.Show();
        }

        private void kbtnDefineCustomColours_Click(object sender, EventArgs e)
        {
            CustomColours customColours = new CustomColours();

            customColours.Show();
        }

        private void kbtnGenerateColour_Click(object sender, EventArgs e)
        {
            pbColourPreview.BackColor = _colourUtility.GenerateRandomColour(kchkGenerateAlphaValue.Checked);

            //int a = randomColour.Next(_max), r = randomColour.Next(_max), g = randomColour.Next(_max), b = randomColour.Next(_max); 

            //knumRedChannelValue.Value = r;

            //knumGreenChannelValue.Value = g;

            //knumBlueChannelValue.Value = b;
        }

        private void DisplayColour()
        {
            pbColourPreview.BackColor = Color.FromArgb(ktbAlpha.Value, ktbRed.Value, ktbGreen.Value, ktbBlue.Value);

            cpbColourPreview.BackColor = Color.FromArgb(ktbAlpha.Value, ktbRed.Value, ktbGreen.Value, ktbBlue.Value);
        }
        #endregion

        #region CHECKING TO FORMAT OF THE INPUT THAT WHETHER IT IS IN THE CORRECT FORMAT (DECIAML/HEXADECIMAL)

        private bool IsNumber(string number)
        {
            if (number.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < number.Length; i++)
            {
                if (!(Char.IsDigit(number[i])))
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsHexadecimal(string hexadecimal)
        {
            if (hexadecimal.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < hexadecimal.Length; i++)
            {
                if (!((Char.IsDigit(hexadecimal[i])) || (hexadecimal[i] == 'A') || (hexadecimal[i] == 'B') || (hexadecimal[i] == 'C') || (hexadecimal[i] == 'D') || (hexadecimal[i] == 'E') || (hexadecimal[i] == 'F')))
                {
                    return false;
                }
            }

            return true;
        }

        #endregion
    }
}
