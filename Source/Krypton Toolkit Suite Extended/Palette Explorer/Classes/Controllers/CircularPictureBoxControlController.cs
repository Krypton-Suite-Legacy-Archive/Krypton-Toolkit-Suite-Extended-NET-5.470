#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using PaletteExplorer.Controls;
using System;
using System.Drawing;

namespace PaletteExplorer.Classes.Controllers
{
    /// <summary>
    /// This class will control the size & layout of the <see cref="CircularPictureBoxControl"/> control.
    /// </summary>
    public class CircularPictureBoxControlController
    {
        #region Constructors        
        /// <summary>
        /// Initializes a new instance of the <see cref="CircularPictureBoxControlController"/> class.
        /// </summary>
        public CircularPictureBoxControlController()
        {

        }
        #endregion

        #region Methods
        public static void CustomColourLayout(CircularPictureBoxControl control)
        {

        }

        public static void CustomTextColourLayout(CircularPictureBoxControl control)
        {

        }

        public static void NormalLayout(CircularPictureBoxControl control)
        {
            #region Size
            control.Size = new Size(1625, 660);
            #endregion

            #region Basic Colour Location
            control.GetBaseColourPreview().Location = new Point(19, 15);

            control.GetDarkColourPreview().Location = new Point(272, 15);

            control.GetMiddleColourPreview().Location = new Point(525, 15);

            control.GetLightColourPreview().Location = new Point(778, 15);

            control.GetLightestColourPreview().Location = new Point(1031, 15);
            #endregion

            #region Rest of First Row
            control.GetBorderColourPreview().Location = new Point(1284, 18);

            control.GetAlternativeNormalTextColourPreview().Location = new Point(1537, 18);
            #endregion

            #region Second Row
            control.GetDisabledTextColourPreview().Location = new Point(19, 147);

            control.GetFocusedTextColourPreview().Location = new Point(272, 147);

            control.GetNormalTextColourPreview().Location = new Point(525, 147);

            control.GetPressedTextColourPreview().Location = new Point(778, 147);

            control.GetDisabledControlColourPreview().Location = new Point(1031, 147);

            control.GetLinkDisabledColourPreview().Location = new Point(1284, 147);

            control.GetLinkFocusedColourPreview().Location = new Point(1537, 147);
            #endregion

            #region Third Row
            control.GetLinkHoverColourPreview().Location = new Point(19, 280);

            control.GetLinkNormalColourPreview().Location = new Point(272, 280);

            control.GetLinkVisitedColourPreview().Location = new Point(525, 280);

            control.GetCustomColourOneColourPreview().Visible = true;

            control.GetCustomColourOneColourPreview().Location = new Point(778, 280);

            control.GetCustomColourTwoColourPreview().Visible = true;

            control.GetCustomColourTwoColourPreview().Location = new Point(1031, 280);

            control.GetCustomColourThreeColourPreview().Visible = true;

            control.GetCustomColourThreeColourPreview().Location = new Point(1284, 280);

            control.GetCustomColourFourColourPreview().Visible = true;

            control.GetCustomColourFourColourPreview().Location = new Point(1537, 280);
            #endregion

            #region Fourth Row
            control.GetCustomColourFiveColourPreview().Visible = true;

            control.GetCustomColourFiveColourPreview().Location = new Point(19, 413);

            control.GetCustomColourSixColourPreview().Visible = true;

            control.GetCustomColourSixColourPreview().Location = new Point(272, 413);

            control.GetCustomTextColourOneColourPreview().Visible = true;

            control.GetCustomTextColourOneColourPreview().Location = new Point(525, 413);

            control.GetCustomTextColourTwoColourPreview().Visible = true;

            control.GetCustomTextColourTwoColourPreview().Location = new Point(778, 413);

            control.GetCustomTextColourThreeColourPreview().Visible = true;

            control.GetCustomTextColourThreeColourPreview().Location = new Point(1031, 413);

            control.GetCustomTextColourFourColourPreview().Visible = true;

            control.GetCustomTextColourFourColourPreview().Location = new Point(1284, 413);

            control.GetCustomTextColourFiveColourPreview().Visible = true;

            control.GetCustomTextColourFiveColourPreview().Location = new Point(1537, 413);
            #endregion

            #region Final Row
            control.GetCustomTextColourSixColourPreview().Visible = true;

            control.GetCustomTextColourSixColourPreview().Location = new Point(19, 549);

            control.GetMenuTextColourPreview().Location = new Point(272, 549);

            control.GetStatusTextColourPreview().Location = new Point(525, 549);

            control.GetRibbonTabTextColourPreview().Location = new Point(778, 549);
            #endregion
        }

        public static void NoCustomColoursLayout(CircularPictureBoxControl control)
        {

        }
        #endregion

        #region Disposal        
        /// <summary>
        /// Finalizes an instance of the <see cref="CircularPictureBoxControlController"/> class.
        /// </summary>
        ~CircularPictureBoxControlController()
        {
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}