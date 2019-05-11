#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using Core.Settings.Colours.Classes;
using ExtendedControls.ExtendedToolkit.Controls;
using System;
using System.Windows.Forms;

namespace Core.Classes.Theming
{
    public class PaletteColourManagementEngine
    {
        #region Constructor
        public PaletteColourManagementEngine()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseColour"></param>
        /// <param name="darkestColour"></param>
        /// <param name="mediumColour"></param>
        /// <param name="lightColour"></param>
        /// <param name="lightestColour"></param>
        public static void SetBasicPaletteColours(CircularPictureBox baseColour, CircularPictureBox darkestColour, CircularPictureBox mediumColour, CircularPictureBox lightColour, CircularPictureBox lightestColour)
        {
            BasicPaletteColourManager basicPaletteColourManager = new BasicPaletteColourManager();

            try
            {
                if (!BasicPaletteColourManager.AreBasicPaletteColoursEmpty())
                {
                    basicPaletteColourManager.ResetSettings();

                    basicPaletteColourManager.SetBaseColour(baseColour.BackColor);

                    basicPaletteColourManager.SetDarkestColour(darkestColour.BackColor);

                    basicPaletteColourManager.SetMediumColour(mediumColour.BackColor);

                    basicPaletteColourManager.SetLightColour(lightColour.BackColor);

                    basicPaletteColourManager.SetLightestColour(lightestColour.BackColor);

                    basicPaletteColourManager.SaveColourSettings();
                }
                else
                {
                    basicPaletteColourManager.SetBaseColour(baseColour.BackColor);

                    basicPaletteColourManager.SetDarkestColour(darkestColour.BackColor);

                    basicPaletteColourManager.SetMediumColour(mediumColour.BackColor);

                    basicPaletteColourManager.SetLightColour(lightColour.BackColor);

                    basicPaletteColourManager.SetLightestColour(lightestColour.BackColor);

                    basicPaletteColourManager.SaveColourSettings();
                }
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show($"An unexpected error has occurred: { exc.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                basicPaletteColourManager.ResetSettings();
            }
        }

        public static void SetBasicPaletteColours(PictureBox baseColour, PictureBox darkestColour, PictureBox mediumColour, PictureBox lightColour, PictureBox lightestColour)
        {
            BasicPaletteColourManager basicPaletteColourManager = new BasicPaletteColourManager();

            try
            {
                if (!BasicPaletteColourManager.AreBasicPaletteColoursEmpty())
                {
                    basicPaletteColourManager.ResetSettings();

                    basicPaletteColourManager.SetBaseColour(baseColour.BackColor);

                    basicPaletteColourManager.SetDarkestColour(darkestColour.BackColor);

                    basicPaletteColourManager.SetMediumColour(mediumColour.BackColor);

                    basicPaletteColourManager.SetLightColour(lightColour.BackColor);

                    basicPaletteColourManager.SetLightestColour(lightestColour.BackColor);

                    basicPaletteColourManager.SaveColourSettings();
                }
                else
                {
                    basicPaletteColourManager.SetBaseColour(baseColour.BackColor);

                    basicPaletteColourManager.SetDarkestColour(darkestColour.BackColor);

                    basicPaletteColourManager.SetMediumColour(mediumColour.BackColor);

                    basicPaletteColourManager.SetLightColour(lightColour.BackColor);

                    basicPaletteColourManager.SetLightestColour(lightestColour.BackColor);

                    basicPaletteColourManager.SaveColourSettings();
                }
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show($"An unexpected error has occurred: { exc.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                basicPaletteColourManager.ResetSettings();
            }
        }
        #endregion
    }
}