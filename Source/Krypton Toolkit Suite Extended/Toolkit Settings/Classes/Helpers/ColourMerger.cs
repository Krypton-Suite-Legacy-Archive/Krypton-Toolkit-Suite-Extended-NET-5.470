﻿using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using ToolkitSettings.Classes.PaletteExplorer.Colours;

namespace ToolkitSettings.Classes.Helpers
{
    public class ColourMerger
    {
        #region Variables
        AllMergedColourSettingsManager _amcsm = new AllMergedColourSettingsManager();

        Color baseColour, darkColour, middleColour, lightColour, lightestColour, borderColour, alternativeNormalTextColour, normalTextColour, disabledTextColour, focusedTextColour, pressedTextColour, disabledColour, linkNormalColour, linkFocusedColour, linkHoverColour, linkVisitedColour, customColourOne, customColourTwo, customColourThree, customColourFour, customColourFive, customColourSix, customTextColourOne, customTextColourTwo, customTextColourThree, customTextColourFour, customTextColourFive, customTextColourSix, menuTextColour, statusTextColour, ribbonTabTextColour;
        #endregion

        #region Properties

        #endregion

        #region Constructor

        #endregion

        #region Public Methods

        #endregion

        #region Internal Methods                
        /// <summary>
        /// Merges all palette colours.
        /// </summary>
        /// <param name="baseColour">The base colour.</param>
        /// <param name="darkColour">The dark colour.</param>
        /// <param name="middleColour">The middle colour.</param>
        /// <param name="lightColour">The light colour.</param>
        /// <param name="lightestColour">The lightest colour.</param>
        /// <param name="borderColour">The border colour.</param>
        /// <param name="alternativeNormalTextColour">The alternative normal text colour.</param>
        /// <param name="normalTextColour">The normal text colour.</param>
        /// <param name="disabledTextColour">The disabled text colour.</param>
        /// <param name="focusedTextColour">The focused text colour.</param>
        /// <param name="pressedTextColour">The pressed text colour.</param>
        /// <param name="disabledColour">The disabled colour.</param>
        /// <param name="linkNormalColour">The link normal colour.</param>
        /// <param name="linkFocusedColour">The link focused colour.</param>
        /// <param name="linkHoverColour">The link hover colour.</param>
        /// <param name="linkVisitedColour">The link visited colour.</param>
        /// <param name="customColourOne">The custom colour one.</param>
        /// <param name="customColourTwo">The custom colour two.</param>
        /// <param name="customColourThree">The custom colour three.</param>
        /// <param name="customColourFour">The custom colour four.</param>
        /// <param name="customColourFive">The custom colour five.</param>
        /// <param name="customColourSix">The custom colour six.</param>
        /// <param name="customTextColourOne">The custom text colour one.</param>
        /// <param name="customTextColourTwo">The custom text colour two.</param>
        /// <param name="customTextColourThree">The custom text colour three.</param>
        /// <param name="customTextColourFour">The custom text colour four.</param>
        /// <param name="customTextColourFive">The custom text colour five.</param>
        /// <param name="customTextColourSix">The custom text colour six.</param>
        /// <param name="menuTextColour">The menu text colour.</param>
        /// <param name="statusTextColour">The status text colour.</param>
        /// <param name="ribbonTabTextColour">The ribbon tab text colour.</param>
        /// <param name="askForConfirmation">if set to <c>true</c> [ask for confirmation].</param>
        internal static void MergeAllPaletteColours(Color baseColour, Color darkColour, Color middleColour, Color lightColour, Color lightestColour, Color borderColour, Color alternativeNormalTextColour, Color normalTextColour, Color disabledTextColour, Color focusedTextColour, Color pressedTextColour, Color disabledColour, Color linkNormalColour, Color linkFocusedColour, Color linkHoverColour, Color linkVisitedColour, Color customColourOne, Color customColourTwo, Color customColourThree, Color customColourFour, Color customColourFive, Color customColourSix, Color customTextColourOne, Color customTextColourTwo, Color customTextColourThree, Color customTextColourFour, Color customTextColourFive, Color customTextColourSix, Color menuTextColour, Color statusTextColour, Color ribbonTabTextColour, bool askForConfirmation = false)
        {
            try
            {
                AllMergedColourSettingsManager manager = new AllMergedColourSettingsManager();

                if (SettingsVarifier.AreAllMergedColourSettingsDefault())
                {
                    MergeAllPaletteColoursIntoOneSettingsFile(baseColour, darkColour, middleColour, lightColour, lightestColour, borderColour, alternativeNormalTextColour, normalTextColour, disabledTextColour, focusedTextColour, pressedTextColour, disabledColour, linkNormalColour, linkFocusedColour, linkHoverColour, linkVisitedColour, customColourOne, customColourTwo, customColourThree, customColourFour, customColourFive, customColourSix, customTextColourOne, customTextColourTwo, customTextColourThree, customTextColourFour, customTextColourFive, customTextColourSix, menuTextColour, statusTextColour, ribbonTabTextColour);
                }
                else
                {
                    manager.ResetToDefaults();

                    MergeAllPaletteColoursIntoOneSettingsFile(baseColour, darkColour, middleColour, lightColour, lightestColour, borderColour, alternativeNormalTextColour, normalTextColour, disabledTextColour, focusedTextColour, pressedTextColour, disabledColour, linkNormalColour, linkFocusedColour, linkHoverColour, linkVisitedColour, customColourOne, customColourTwo, customColourThree, customColourFour, customColourFive, customColourSix, customTextColourOne, customTextColourTwo, customTextColourThree, customTextColourFour, customTextColourFive, customTextColourSix, menuTextColour, statusTextColour, ribbonTabTextColour);
                }
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show($"An exeption was thrown: { exc.Message }");
            }
        }

        /// <summary>
        /// Merges all palette colours into one settings file.
        /// </summary>
        /// <param name="baseColour">The base colour.</param>
        /// <param name="darkColour">The dark colour.</param>
        /// <param name="middleColour">The middle colour.</param>
        /// <param name="lightColour">The light colour.</param>
        /// <param name="lightestColour">The lightest colour.</param>
        /// <param name="borderColour">The border colour.</param>
        /// <param name="alternativeNormalTextColour">The alternative normal text colour.</param>
        /// <param name="normalTextColour">The normal text colour.</param>
        /// <param name="disabledTextColour">The disabled text colour.</param>
        /// <param name="focusedTextColour">The focused text colour.</param>
        /// <param name="pressedTextColour">The pressed text colour.</param>
        /// <param name="disabledColour">The disabled colour.</param>
        /// <param name="linkNormalColour">The link normal colour.</param>
        /// <param name="linkFocusedColour">The link focused colour.</param>
        /// <param name="linkHoverColour">The link hover colour.</param>
        /// <param name="linkVisitedColour">The link visited colour.</param>
        /// <param name="customColourOne">The custom colour one.</param>
        /// <param name="customColourTwo">The custom colour two.</param>
        /// <param name="customColourThree">The custom colour three.</param>
        /// <param name="customColourFour">The custom colour four.</param>
        /// <param name="customColourFive">The custom colour five.</param>
        /// <param name="customColourSix">The custom colour six.</param>
        /// <param name="customTextColourOne">The custom text colour one.</param>
        /// <param name="customTextColourTwo">The custom text colour two.</param>
        /// <param name="customTextColourThree">The custom text colour three.</param>
        /// <param name="customTextColourFour">The custom text colour four.</param>
        /// <param name="customTextColourFive">The custom text colour five.</param>
        /// <param name="customTextColourSix">The custom text colour six.</param>
        /// <param name="menuTextColour">The menu text colour.</param>
        /// <param name="statusTextColour">The status text colour.</param>
        /// <param name="ribbonTabTextColour">The ribbon tab text colour.</param>
        private static void MergeAllPaletteColoursIntoOneSettingsFile(Color baseColour, Color darkColour, Color middleColour, Color lightColour, Color lightestColour, Color borderColour, Color alternativeNormalTextColour, Color normalTextColour, Color disabledTextColour, Color focusedTextColour, Color pressedTextColour, Color disabledColour, Color linkNormalColour, Color linkFocusedColour, Color linkHoverColour, Color linkVisitedColour, Color customColourOne, Color customColourTwo, Color customColourThree, Color customColourFour, Color customColourFive, Color customColourSix, Color customTextColourOne, Color customTextColourTwo, Color customTextColourThree, Color customTextColourFour, Color customTextColourFive, Color customTextColourSix, Color menuTextColour, Color statusTextColour, Color ribbonTabTextColour)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}