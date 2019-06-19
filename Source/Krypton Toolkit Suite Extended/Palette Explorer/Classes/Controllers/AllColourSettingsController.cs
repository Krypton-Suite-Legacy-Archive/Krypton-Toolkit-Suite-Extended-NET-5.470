using Core;
using System;
using ToolkitSettings.Classes.PaletteExplorer.Colours;

namespace PaletteExplorer.Classes.Controllers
{
    public class AllColourSettingsController
    {
        #region Constructor
        public AllColourSettingsController()
        {

        }
        #endregion

        #region Methods
        public static void MergeAllColours()
        {
            #region Variables
            AllMergedColourSettingsManager allMergedColourSettingsManager = new AllMergedColourSettingsManager();

            BasicColourSettingsManager basicColourSettingsManager = new BasicColourSettingsManager();

            CustomColourSettingsManager customColourSettingsManager = new CustomColourSettingsManager();

            CustomTextColourSettingsManager customTextColourSettingsManager = new CustomTextColourSettingsManager();

            LinkTextColourSettingsManager linkTextColourSettingsManager = new LinkTextColourSettingsManager();

            MiscellaneousColourSettingsManager miscellaneousColourSettingsManager = new MiscellaneousColourSettingsManager();

            StandardControlTextColourSettingsManager standardControlTextColourSettingsManager = new StandardControlTextColourSettingsManager();

            TextColourSettingsManager textColourSettingsManager = new TextColourSettingsManager();
            #endregion

            try
            {
                #region Basic Colours
                if (!BasicColourSettingsManager.AreBasicPaletteColoursEmpty())
                {
                    allMergedColourSettingsManager.SetBaseColour(basicColourSettingsManager.GetBaseColour());

                    allMergedColourSettingsManager.SetDarkColour(basicColourSettingsManager.GetDarkColour());

                    allMergedColourSettingsManager.SetMediumColour(basicColourSettingsManager.GetMediumColour());

                    allMergedColourSettingsManager.SetLightColour(basicColourSettingsManager.GetLightColour());

                    allMergedColourSettingsManager.SetLightestColour(basicColourSettingsManager.GetLightestColour());
                }
                #endregion

                #region Custom Colours
                if (!CustomColourSettingsManager.AreCustomPaletteColoursEmpty())
                {
                    allMergedColourSettingsManager.SetCustomColourOne(customColourSettingsManager.GetCustomColourOne());

                    allMergedColourSettingsManager.SetCustomColourTwo(customColourSettingsManager.GetCustomColourTwo());

                    allMergedColourSettingsManager.SetCustomColourThree(customColourSettingsManager.GetCustomColourThree());

                    allMergedColourSettingsManager.SetCustomColourFour(customColourSettingsManager.GetCustomColourFour());

                    allMergedColourSettingsManager.SetCustomColourFive(customColourSettingsManager.GetCustomColourFive());

                    allMergedColourSettingsManager.SetCustomColourSix(customColourSettingsManager.GetCustomColourSix());
                }
                #endregion

                #region Custom Text Colours
                if (!CustomTextColourSettingsManager.AreCustomPaletteTextColoursEmpty())
                {
                    allMergedColourSettingsManager.SetCustomTextColourOne(customTextColourSettingsManager.GetCustomTextColourOne());

                    allMergedColourSettingsManager.SetCustomTextColourTwo(customTextColourSettingsManager.GetCustomTextColourTwo());

                    allMergedColourSettingsManager.SetCustomTextColourThree(customTextColourSettingsManager.GetCustomTextColourThree());

                    allMergedColourSettingsManager.SetCustomTextColourFour(customTextColourSettingsManager.GetCustomTextColourFour());

                    allMergedColourSettingsManager.SetCustomTextColourFive(customTextColourSettingsManager.GetCustomTextColourFive());

                    allMergedColourSettingsManager.SetCustomTextColourSix(customTextColourSettingsManager.GetCustomTextColourSix());
                }
                #endregion

                #region Link Colours
                allMergedColourSettingsManager.SetLinkDisabledColour(linkTextColourSettingsManager.GetLinkDisabledColour());

                allMergedColourSettingsManager.SetLinkFocusedColour(linkTextColourSettingsManager.GetLinkFocusedColour());

                allMergedColourSettingsManager.SetLinkHoverColour(linkTextColourSettingsManager.GetLinkHoverColour());

                allMergedColourSettingsManager.SetLinkNormalColour(linkTextColourSettingsManager.GetLinkNormalColour());

                allMergedColourSettingsManager.SetLinkVisitedColour(linkTextColourSettingsManager.GetLinkVisitedColour());
                #endregion

                allMergedColourSettingsManager.SaveAllMergedColourSettings();
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc);
            }
        }
        #endregion
    }
}