#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using Core.Classes.Other;
using System;
using System.Drawing;

namespace Core.UX
{
    public partial class ColourRGBToHexadecimalConverter : KryptonForm
    {
        #region Variables
        ConversionMethods conversionMethods = new ConversionMethods();

        private bool _enableAlphaChannel = false;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets a value indicating whether [enable alpha channel].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable alpha channel]; otherwise, <c>false</c>.
        /// </value>
        public bool EnableAlphaChannel { get { return _enableAlphaChannel; } set { _enableAlphaChannel = value; } }
        #endregion

        #region Setters & Getters        
        /// <summary>
        /// Sets the enable alpha channel.
        /// </summary>
        /// <param name="value">if set to <c>true</c> [value].</param>
        public void SetEnableAlphaChannel(bool value)
        {
            EnableAlphaChannel = value;
        }

        /// <summary>
        /// Gets the enable alpha channel.
        /// </summary>
        /// <returns></returns>
        public bool GetEnableAlphaChannel()
        {
            return EnableAlphaChannel;
        }
        #endregion

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

            klblAlpha.Enabled = GetEnableAlphaChannel();

            numAlpha.Enabled = GetEnableAlphaChannel();
        }

        private void pnlPreview_MouseEnter(object sender, EventArgs e)
        {
            string knownName = pnlPreview.BackColor.ToKnownColor().ToString();

            ttInformation.SetToolTip(pnlPreview, $"This colour is: { knownName }");
        }

        private void kchkEnableAlphaChannel_CheckedChanged(object sender, EventArgs e)
        {
            SetEnableAlphaChannel(kchkEnableAlphaChannel.Checked);
        }

        private void ColourRGBToHexadecimalConverter_Load(object sender, EventArgs e)
        {
            tmrUpdateValues.Enabled = kchkAutoUpdate.Checked;
        }
    }
}