#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.Controls;
using PaletteEditor.UX;
using Persistence.UX;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PaletteEditor.Classes
{
    public class UserInterfaceManager
    {
        public UserInterfaceManager()
        {

        }

        #region Methods        
        /// <summary>
        /// Factories the circular picturebox location.
        /// </summary>
        /// <param name="circularColourPreviewPane">The circular colour preview pane.</param>
        /// <param name="baseColourPreview">The base colour preview.</param>
        /// <param name="darkColourPreview">The dark colour preview.</param>
        /// <param name="middleColourPreview">The middle colour preview.</param>
        /// <param name="lightColourPreview">The light colour preview.</param>
        /// <param name="lightestColourPreview">The lightest colour preview.</param>
        /// <param name="borderColourPreview">The border colour preview.</param>
        /// <param name="alternativeNormalTextColourPreview">The alternative normal text colour preview.</param>
        /// <param name="normalTextColourPreview">The normal text colour preview.</param>
        /// <param name="disabledTextColourPreview">The disabled text colour preview.</param>
        /// <param name="focusedTextColourPreview">The focused text colour preview.</param>
        /// <param name="pressedTextColourPreview">The pressed text colour preview.</param>
        /// <param name="disabledColourPreview">The disabled colour preview.</param>
        /// <param name="linkNormalColourPreview">The link normal colour preview.</param>
        /// <param name="linkHoverColourPreview">The link hover colour preview.</param>
        /// <param name="linkVisitedColourPreview">The link visited colour preview.</param>
        /// <param name="customColourOne">The custom colour one.</param>
        /// <param name="customColourTwo">The custom colour two.</param>
        /// <param name="customColourThree">The custom colour three.</param>
        /// <param name="customColourFour">The custom colour four.</param>
        /// <param name="customColourFive">The custom colour five.</param>
        /// <param name="customTextColourOne">The custom text colour one.</param>
        /// <param name="customTextColourTwo">The custom text colour two.</param>
        /// <param name="customTextColourThree">The custom text colour three.</param>
        /// <param name="customTextColourFour">The custom text colour four.</param>
        /// <param name="customTextColourFive">The custom text colour five.</param>
        /// <param name="menuTextColourPreview">The menu text colour preview.</param>
        /// <param name="statusTextColourPreview">The status text colour preview.</param>
        /// <param name="extra1">The extra1.</param>
        /// <param name="extra2">The extra2.</param>
        /// <param name="extra3">The extra3.</param>
        public static void FactoryCircularPictureboxLocation(KryptonGroupBox circularColourPreviewPane, CircularPictureBox baseColourPreview, CircularPictureBox darkColourPreview, CircularPictureBox middleColourPreview, CircularPictureBox lightColourPreview, CircularPictureBox lightestColourPreview, CircularPictureBox borderColourPreview, CircularPictureBox alternativeNormalTextColourPreview, CircularPictureBox normalTextColourPreview, CircularPictureBox disabledTextColourPreview, CircularPictureBox focusedTextColourPreview, CircularPictureBox pressedTextColourPreview, CircularPictureBox disabledColourPreview, CircularPictureBox linkNormalColourPreview, CircularPictureBox linkHoverColourPreview, CircularPictureBox linkVisitedColourPreview, CircularPictureBox customColourOne, CircularPictureBox customColourTwo, CircularPictureBox customColourThree, CircularPictureBox customColourFour, CircularPictureBox customColourFive, CircularPictureBox customTextColourOne, CircularPictureBox customTextColourTwo, CircularPictureBox customTextColourThree, CircularPictureBox customTextColourFour, CircularPictureBox customTextColourFive, CircularPictureBox menuTextColourPreview, CircularPictureBox statusTextColourPreview, CircularPictureBox extra1, CircularPictureBox extra2, CircularPictureBox extra3)
        {
            circularColourPreviewPane.Size = new Size(708, 467);

            baseColourPreview.Location = new Point(21, 16);

            darkColourPreview.Location = new Point(107, 15);

            middleColourPreview.Location = new Point(193, 15);

            lightColourPreview.Location = new Point(279, 15);

            lightestColourPreview.Location = new Point(365, 15);

            borderColourPreview.Location = new Point(451, 15);

            alternativeNormalTextColourPreview.Location = new Point(537, 14);

            normalTextColourPreview.Location = new Point(623, 14);

            disabledTextColourPreview.Location = new Point(19, 127);

            focusedTextColourPreview.Location = new Point(107, 127);

            pressedTextColourPreview.Location = new Point(193, 127);

            disabledColourPreview.Location = new Point(279, 127);

            linkNormalColourPreview.Location = new Point(365, 129);

            linkHoverColourPreview.Location = new Point(451, 129);

            linkVisitedColourPreview.Location = new Point(537, 129);

            customColourOne.Location = new Point(623, 127);

            customColourTwo.Location = new Point(19, 238);

            customColourThree.Location = new Point(107, 238);

            customColourFour.Location = new Point(193, 238);

            customColourFive.Location = new Point(279, 238);

            customTextColourOne.Location = new Point(365, 238);

            customTextColourTwo.Location = new Point(451, 238);

            customTextColourThree.Location = new Point(537, 238);

            customTextColourFour.Location = new Point(623, 238);

            customTextColourFive.Location = new Point(19, 349);

            menuTextColourPreview.Location = new Point(107, 349);

            statusTextColourPreview.Location = new Point(193, 349);

            extra1.Location = new Point(279, 349);

            extra2.Location = new Point(365, 349);

            extra3.Location = new Point(451, 349);
        }

        public static void CircularPictureboxHiddenPropertiesLocation(KryptonGroupBox circularColourPreviewPane, CircularPictureBox baseColourPreview, CircularPictureBox darkColourPreview, CircularPictureBox middleColourPreview, CircularPictureBox lightColourPreview, CircularPictureBox lightestColourPreview, CircularPictureBox borderColourPreview, CircularPictureBox alternativeNormalTextColourPreview, CircularPictureBox normalTextColourPreview, CircularPictureBox disabledTextColourPreview, CircularPictureBox focusedTextColourPreview, CircularPictureBox pressedTextColourPreview, CircularPictureBox disabledColourPreview, CircularPictureBox linkNormalColourPreview, CircularPictureBox linkHoverColourPreview, CircularPictureBox linkVisitedColourPreview, CircularPictureBox customColourOne, CircularPictureBox customColourTwo, CircularPictureBox customColourThree, CircularPictureBox customColourFour, CircularPictureBox customColourFive, CircularPictureBox customTextColourOne, CircularPictureBox customTextColourTwo, CircularPictureBox customTextColourThree, CircularPictureBox customTextColourFour, CircularPictureBox customTextColourFive, CircularPictureBox menuTextColourPreview, CircularPictureBox statusTextColourPreview, CircularPictureBox extra1, CircularPictureBox extra2, CircularPictureBox extra3)
        {
            circularColourPreviewPane.Size = new Size(1212, 467);

            baseColourPreview.Location = new Point(19, 16);

            darkColourPreview.Location = new Point(111, 15);

            middleColourPreview.Location = new Point(203, 15);

            lightColourPreview.Location = new Point(295, 15);

            lightestColourPreview.Location = new Point(387, 15);

            borderColourPreview.Location = new Point(479, 15);

            alternativeNormalTextColourPreview.Location = new Point(571, 14);

            normalTextColourPreview.Location = new Point(663, 14);

            disabledTextColourPreview.Location = new Point(755, 16);

            focusedTextColourPreview.Location = new Point(847, 16);

            pressedTextColourPreview.Location = new Point(939, 15);

            disabledColourPreview.Location = new Point(1031, 16);

            linkNormalColourPreview.Location = new Point(1123, 15);

            linkHoverColourPreview.Location = new Point(19, 127);

            linkVisitedColourPreview.Location = new Point(111, 127);

            customColourOne.Location = new Point(203, 127);

            customColourTwo.Location = new Point(295, 127);

            customColourThree.Location = new Point(387, 127);

            customColourFour.Location = new Point(479, 127);

            customColourFive.Location = new Point(571, 127);

            customTextColourOne.Location = new Point(663, 127);

            customTextColourTwo.Location = new Point(755, 127);

            customTextColourThree.Location = new Point(847, 127);

            customTextColourFour.Location = new Point(939, 127);

            customTextColourFive.Location = new Point(1031, 127);

            menuTextColourPreview.Location = new Point(1123, 127);

            statusTextColourPreview.Location = new Point(19, 239);

            extra1.Location = new Point(111, 239);

            extra2.Location = new Point(203, 239);

            extra3.Location = new Point(295, 239);
        }
        #endregion

        #region Methods
        public static void ViewPaletteFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Title = "Open A Palette File:";

            openFile.Filter = "Krypton Palette Files (*.xml)|*.xml";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                PaletteFileEditor paletteFileEditor = new PaletteFileEditor(Path.GetFullPath(openFile.FileName));

                paletteFileEditor.Show();
            }
        }

        public static void GetColourInformation()
        {
            ColourInformation colourInformation = new ColourInformation();

            colourInformation.Show();
        }
        #endregion
    }
}