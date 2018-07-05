using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;
using Tooling.Classes.Other;

namespace Tooling.UX
{
    public partial class ColourHexadecimalToRGBConverter : KryptonForm
    {
        #region Variables
        private string[] _disallowedCharacters = { "\\", "\"", "!", "`", "¬", "¦", "£", "$", "€", "%", "^", "&", "*", "(", ")", "_", "-", "+", "=",
                                           "[", "]", "{", "}", ":", ";", "@", "'", "~", "#", "|", "<", ">", ",", ".", "?", "/", "g", "h", "i",
                                           "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "G", "H",
                                           "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        private ConversionMethods _conversionMethods = new ConversionMethods();
        #endregion

        #region Properties
        public string[] DisallowedCharacters
        {
            get
            {
                return _disallowedCharacters;
            }
        }
        #endregion

        public ColourHexadecimalToRGBConverter()
        {
            InitializeComponent();
        }

        private void kbtnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                int[] rgb = ConversionMethods.ConvertHexadecimalToRGBTest(ktxtHexColourValue.Text);

                pnlPreview.BackColor = Color.FromArgb(rgb[0], rgb[1], rgb[2]);
            }
            catch (Exception)
            {

            }

            //UpdateUI();
        }

        private void ktxtHexColourValue_TextChanged(object sender, EventArgs e)
        {
            string content = ktxtHexColourValue.Text;

            string[] contentArray = new string[6];

            //foreach (string character in content.Length)
            //{

            //}

            foreach (string disqualifiedCharacter in DisallowedCharacters)
            {
                if (content.Contains(disqualifiedCharacter))
                {
                    ep1.SetError((Control)ktxtHexColourValue, $"Cannot accept values: { DisallowedCharacters.ToString() }");
                }
            }
        }

        private void kchkAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            tmrUpdateValues.Enabled = kchkAutoUpdate.Checked;
        }

        private void tmrUpdateValues_Tick(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void pnlPreview_MouseEnter(object sender, EventArgs e)
        {

        }

        private void UpdateUI()
        {
            _conversionMethods.ConvertHexadecimalToRGB("#" + ktxtHexColourValue.Text);

            klblRGBOutput.Text = $"RGB Value: Red: { _conversionMethods.GetRed() }, Green: { _conversionMethods.GetGreen() }, Blue: { _conversionMethods.GetBlue() }";

            pnlPreview.BackColor = Color.FromArgb(_conversionMethods.GetRed(), _conversionMethods.GetGreen(), _conversionMethods.GetBlue());
        }

        private void ColourHexadecimalToRGBConverter_Load(object sender, EventArgs e)
        {
            tmrUpdateValues.Enabled = kchkAutoUpdate.Checked;
        }
    }
}