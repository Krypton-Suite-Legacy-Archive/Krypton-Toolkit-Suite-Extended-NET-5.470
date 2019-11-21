#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using Persistence.Classes.Colours;
using Persistence.Classes.Other;
using System;
using System.Drawing;

namespace Persistence.UX
{
    public partial class ContrastColourGenerator : KryptonForm
    {
        #region Variables
        private RandomNumberGenerator _rng = new RandomNumberGenerator();
        #endregion

        #region Constructors
        public ContrastColourGenerator()
        {
            InitializeComponent();
        }

        public ContrastColourGenerator(Color baseColour)
        {
            InitializeComponent();

            cpbBaseColour.BackColor = baseColour;
        }
        #endregion

        private void ContrastColourGenerator_Load(object sender, EventArgs e)
        {

        }

        private void kbtnGenerateComplementaryColour_Click(object sender, EventArgs e)
        {
            cpbContrastColour.BackColor = ColourExtensions.GetContrast(cpbBaseColour.BackColor, kchkKeepOpacityValues.Checked);
        }

        private void tmrUpdateUI_Tick(object sender, EventArgs e)
        {
            cpbBaseColour.BackColor = Color.FromArgb(Convert.ToInt32(knumBaseAlphaChannelValue.Value), Convert.ToInt32(knumBaseRedChannelValue.Value), Convert.ToInt32(knumBaseGreenChannelValue.Value), Convert.ToInt32(knumBaseBlueChannelValue.Value));

            if (kchkAutomateColourContrastValues.Checked)
            {
                cpbContrastColour.BackColor = ColourExtensions.GetContrast(cpbBaseColour.BackColor, kchkKeepOpacityValues.Checked);
            }
        }

        private void cpbContrastColour_BackColorChanged(object sender, EventArgs e)
        {
            knumContrastAlphaChannelValue.Value = cpbContrastColour.BackColor.A;

            knumContrastRedChannelValue.Value = cpbContrastColour.BackColor.R;

            knumContrastGreenChannelValue.Value = cpbContrastColour.BackColor.G;

            knumContrastBlueChannelValue.Value = cpbContrastColour.BackColor.B;
        }

        private void kbtnInvertColours_Click(object sender, EventArgs e)
        {
            cpbBaseColour.BackColor = cpbContrastColour.BackColor;
        }

        private void cpbBaseColour_BackColorChanged(object sender, EventArgs e)
        {
            knumBaseAlphaChannelValue.Value = cpbBaseColour.BackColor.A;

            knumBaseRedChannelValue.Value = cpbBaseColour.BackColor.R;

            knumBaseGreenChannelValue.Value = cpbBaseColour.BackColor.G;

            knumBaseBlueChannelValue.Value = cpbBaseColour.BackColor.B;
        }

        private void kbtnGenerateBaseAlphaValue_Click(object sender, EventArgs e)
        {
            knumBaseAlphaChannelValue.Value = _rng.RandomlyGenerateAlphaNumberBetween(0, 255);
        }

        private void kbtnGenerateRedValue_Click(object sender, EventArgs e)
        {
            knumBaseRedChannelValue.Value = _rng.RandomlyGenerateARedNumberBetween(0, 255);
        }

        private void kbtnGenerateGreenValue_Click(object sender, EventArgs e)
        {
            knumBaseGreenChannelValue.Value = _rng.RandomlyGenerateAGreenNumberBetween(0, 255);
        }

        private void kbtnGenerateBlueValue_Click(object sender, EventArgs e)
        {
            knumBaseBlueChannelValue.Value = _rng.RandomlyGenerateABlueNumberBetween(0, 255);
        }

        private void kbtnUtiliseBaseColour_Click(object sender, EventArgs e)
        {
            PaletteColourCreator paletteColourCreator = new PaletteColourCreator(cpbBaseColour.BackColor);

            paletteColourCreator.Show();
        }
    }
}