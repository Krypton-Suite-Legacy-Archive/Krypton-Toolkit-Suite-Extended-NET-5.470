using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace PaletteExplorer.Classes
{
    public class UserInterfaceManager
    {
        public static void FactoryCircularPictureboxLocation(KryptonGroupBox circularColourPreviewPane, CircularPictureBox baseColourPreview, CircularPictureBox darkColourPreview, CircularPictureBox middleColourPreview, CircularPictureBox lightColourPreview, CircularPictureBox lightestColourPreview, CircularPictureBox borderColourPreview, CircularPictureBox alternativeNormalTextColourPreview, CircularPictureBox normalTextColourPreview, CircularPictureBox disabledTextColourPreview, CircularPictureBox focusedTextColourPreview, CircularPictureBox pressedTextColourPreview, CircularPictureBox disabledColourPreview, CircularPictureBox linkNormalColourPreview, CircularPictureBox linkFocusedColourPreview, CircularPictureBox linkHoverColourPreview, CircularPictureBox linkVisitedColourPreview, CircularPictureBox customColourOne, CircularPictureBox customColourTwo, CircularPictureBox customColourThree, CircularPictureBox customColourFour, CircularPictureBox customColourFive, CircularPictureBox customTextColourOne, CircularPictureBox customTextColourTwo, CircularPictureBox customTextColourThree, CircularPictureBox customTextColourFour, CircularPictureBox customTextColourFive, CircularPictureBox menuTextColourPreview, CircularPictureBox statusTextColourPreview)
        {
            circularColourPreviewPane.Size = new Size(708, 467);

            baseColourPreview.Location = new Point(19, 13); // 14);

            darkColourPreview.Location = new Point(118, 13);

            middleColourPreview.Location = new Point(217, 13);

            lightColourPreview.Location = new Point(316, 13);

            lightestColourPreview.Location = new Point(415, 13);

            borderColourPreview.Location = new Point(514, 13); // 16;

            alternativeNormalTextColourPreview.Location = new Point(613, 13); // 15);

            normalTextColourPreview.Location = new Point(19, 127);

            disabledTextColourPreview.Location = new Point(118, 127);

            focusedTextColourPreview.Location = new Point(217, 127);

            pressedTextColourPreview.Location = new Point(316, 127);

            disabledColourPreview.Location = new Point(415, 127);

            linkNormalColourPreview.Location = new Point(514, 127);

            linkFocusedColourPreview.Location = new Point(613, 127);

            linkHoverColourPreview.Location = new Point(19, 239);

            linkVisitedColourPreview.Location = new Point(118, 239);

            customColourOne.Location = new Point(217, 239);

            customColourTwo.Location = new Point(316, 239);

            customColourThree.Location = new Point(415, 239);

            customColourFour.Location = new Point(514, 239);

            customColourFive.Location = new Point(613, 239);

            customTextColourOne.Location = new Point(19, 351);

            customTextColourTwo.Location = new Point(118, 351);

            customTextColourThree.Location = new Point(217, 351);

            customTextColourFour.Location = new Point(316, 351);

            customTextColourFive.Location = new Point(415, 351);

            menuTextColourPreview.Location = new Point(514, 351);

            statusTextColourPreview.Location = new Point(613, 351);
        }

        /// <summary>
        /// Circulars the picturebox hidden properties location.
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
        /// <param name="linkFocusedColourPreview">The link focused colour preview.</param>
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
        public static void CircularPictureboxHiddenPropertiesLocation(KryptonGroupBox circularColourPreviewPane, CircularPictureBox baseColourPreview, CircularPictureBox darkColourPreview, CircularPictureBox middleColourPreview, CircularPictureBox lightColourPreview, CircularPictureBox lightestColourPreview, CircularPictureBox borderColourPreview, CircularPictureBox alternativeNormalTextColourPreview, CircularPictureBox normalTextColourPreview, CircularPictureBox disabledTextColourPreview, CircularPictureBox focusedTextColourPreview, CircularPictureBox pressedTextColourPreview, CircularPictureBox disabledColourPreview, CircularPictureBox linkNormalColourPreview, CircularPictureBox linkFocusedColourPreview, CircularPictureBox linkHoverColourPreview, CircularPictureBox linkVisitedColourPreview, CircularPictureBox customColourOne, CircularPictureBox customColourTwo, CircularPictureBox customColourThree, CircularPictureBox customColourFour, CircularPictureBox customColourFive, CircularPictureBox customTextColourOne, CircularPictureBox customTextColourTwo, CircularPictureBox customTextColourThree, CircularPictureBox customTextColourFour, CircularPictureBox customTextColourFive, CircularPictureBox menuTextColourPreview, CircularPictureBox statusTextColourPreview)
        {
            circularColourPreviewPane.Size = new Size(1195, 467);

            baseColourPreview.Location = new Point(19, 13); // 14);

            darkColourPreview.Location = new Point(127, 13);

            middleColourPreview.Location = new Point(235, 13);

            lightColourPreview.Location = new Point(343, 13);

            lightestColourPreview.Location = new Point(451, 13);

            borderColourPreview.Location = new Point(559, 13); // 16;

            alternativeNormalTextColourPreview.Location = new Point(667, 13); // 15);

            normalTextColourPreview.Location = new Point(775, 13);

            disabledTextColourPreview.Location = new Point(883, 13);

            focusedTextColourPreview.Location = new Point(991, 13);

            pressedTextColourPreview.Location = new Point(1099, 13);

            disabledColourPreview.Location = new Point(19, 182);

            linkNormalColourPreview.Location = new Point(127, 182);

            linkFocusedColourPreview.Location = new Point(235, 182);

            linkHoverColourPreview.Location = new Point(343, 182);

            linkVisitedColourPreview.Location = new Point(451, 182);

            customColourOne.Location = new Point(559, 182);

            customColourTwo.Location = new Point(667, 182);

            customColourThree.Location = new Point(775, 182);

            customColourFour.Location = new Point(883, 182);

            customColourFive.Location = new Point(991, 182);

            customTextColourOne.Location = new Point(1099, 182);

            customTextColourTwo.Location = new Point(19, 350);

            customTextColourThree.Location = new Point(127, 350);

            customTextColourFour.Location = new Point(235, 350);

            customTextColourFive.Location = new Point(343, 350);

            menuTextColourPreview.Location = new Point(451, 350);

            statusTextColourPreview.Location = new Point(551, 350);
        }

        /// <summary>
        /// Factories the picturebox location.
        /// </summary>
        /// <param name="standardColourPreviewPane">The standard colour preview pane.</param>
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
        /// <param name="linkFocusedColourPreview">The link focused colour preview.</param>
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
        public static void FactoryPictureboxLocation(KryptonGroupBox standardColourPreviewPane, PictureBox baseColourPreview, PictureBox darkColourPreview, PictureBox middleColourPreview, PictureBox lightColourPreview, PictureBox lightestColourPreview, PictureBox borderColourPreview, PictureBox alternativeNormalTextColourPreview, PictureBox normalTextColourPreview, PictureBox disabledTextColourPreview, PictureBox focusedTextColourPreview, PictureBox pressedTextColourPreview, PictureBox disabledColourPreview, PictureBox linkNormalColourPreview, PictureBox linkFocusedColourPreview, PictureBox linkHoverColourPreview, PictureBox linkVisitedColourPreview, PictureBox customColourOne, PictureBox customColourTwo, PictureBox customColourThree, PictureBox customColourFour, PictureBox customColourFive, PictureBox customTextColourOne, PictureBox customTextColourTwo, PictureBox customTextColourThree, PictureBox customTextColourFour, PictureBox customTextColourFive, PictureBox menuTextColourPreview, PictureBox statusTextColourPreview)
        {
            standardColourPreviewPane.Size = new Size(708, 467);

            baseColourPreview.Location = new Point(19, 15);

            darkColourPreview.Location = new Point(107, 15);

            middleColourPreview.Location = new Point(193, 15);

            lightColourPreview.Location = new Point(279, 15);

            lightestColourPreview.Location = new Point(365, 15);

            borderColourPreview.Location = new Point(451, 15);

            alternativeNormalTextColourPreview.Location = new Point(537, 15);

            normalTextColourPreview.Location = new Point(623, 15);

            disabledColourPreview.Location = new Point(19, 127);

            focusedTextColourPreview.Location = new Point(107, 127);

            pressedTextColourPreview.Location = new Point(193, 127);

            disabledColourPreview.Location = new Point(279, 127);

            linkNormalColourPreview.Location = new Point(365, 127);

            linkFocusedColourPreview.Location = new Point(451, 127);

            linkHoverColourPreview.Location = new Point(537, 127);

            linkVisitedColourPreview.Location = new Point(623, 127);

            customColourOne.Location = new Point(19, 239);

            customColourTwo.Location = new Point(107, 239);

            customColourThree.Location = new Point(193, 239);

            customColourFour.Location = new Point(279, 239);

            customColourFive.Location = new Point(365, 239);

            customTextColourOne.Location = new Point(451, 239);

            customTextColourTwo.Location = new Point(537, 239);

            customTextColourThree.Location = new Point(623, 239);

            customTextColourFour.Location = new Point(19, 351);

            customTextColourFive.Location = new Point(107, 351);

            menuTextColourPreview.Location = new Point(193, 351);

            statusTextColourPreview.Location = new Point(279, 351);
        }

        /// <summary>
        /// Pictureboxes the hidden properties location.
        /// </summary>
        /// <param name="standardColourPreviewPane">The standard colour preview pane.</param>
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
        /// <param name="linkFocusedColourPreview">The link focused colour preview.</param>
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
        public static void PictureboxHiddenPropertiesLocation(KryptonGroupBox standardColourPreviewPane, PictureBox baseColourPreview, PictureBox darkColourPreview, PictureBox middleColourPreview, PictureBox lightColourPreview, PictureBox lightestColourPreview, PictureBox borderColourPreview, PictureBox alternativeNormalTextColourPreview, PictureBox normalTextColourPreview, PictureBox disabledTextColourPreview, PictureBox focusedTextColourPreview, PictureBox pressedTextColourPreview, PictureBox disabledColourPreview, PictureBox linkNormalColourPreview, PictureBox linkFocusedColourPreview, PictureBox linkHoverColourPreview, PictureBox linkVisitedColourPreview, PictureBox customColourOne, PictureBox customColourTwo, PictureBox customColourThree, PictureBox customColourFour, PictureBox customColourFive, PictureBox customTextColourOne, PictureBox customTextColourTwo, PictureBox customTextColourThree, PictureBox customTextColourFour, PictureBox customTextColourFive, PictureBox menuTextColourPreview, PictureBox statusTextColourPreview)
        {
            standardColourPreviewPane.Size = new Size(1189, 467);
        }
    }
}