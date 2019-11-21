#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using PaletteExplorer.Settings;
using System.Drawing;

namespace PaletteExplorer.Classes
{
    public class InternalColourSettingsManager
    {
        #region Variables
        private PersistentColourSettings _persistentColourSettings = new PersistentColourSettings();
        #endregion

        #region Constructors
        public InternalColourSettingsManager()
        {

        }
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the BaseColour to the value of baseColour.
        /// </summary>
        /// <param name="baseColour">The value of baseColour.</param>
        public void SetBaseColour(Color baseColour)
        {
            _persistentColourSettings.BaseColour = baseColour;
        }

        /// <summary>
        /// Gets the BaseColour value.
        /// </summary>
        /// <returns>The value of baseColour.</returns>
        public Color GetBaseColour()
        {
            return _persistentColourSettings.BaseColour;
        }

        /// <summary>
        /// Sets the DarkestColour to the value of darkestColour.
        /// </summary>
        /// <param name="darkestColour">The value of darkestColour.</param>
        public void SetDarkestColour(Color darkestColour)
        {
            _persistentColourSettings.DarkestColour = darkestColour;
        }

        /// <summary>
        /// Gets the DarkestColour value.
        /// </summary>
        /// <returns>The value of darkestColour.</returns>
        public Color GetDarkestColour()
        {
            return _persistentColourSettings.DarkestColour;
        }

        /// <summary>
        /// Sets the MediumColour to the value of mediumColour.
        /// </summary>
        /// <param name="mediumColour">The value of mediumColour.</param>
        public void SetMediumColour(Color mediumColour)
        {
            _persistentColourSettings.MediumColour = mediumColour;
        }

        /// <summary>
        /// Gets the MediumColour value.
        /// </summary>
        /// <returns>The value of mediumColour.</returns>
        public Color GetMediumColour()
        {
            return _persistentColourSettings.MediumColour;
        }

        /// <summary>
        /// Sets the LightColour to the value of lightColour.
        /// </summary>
        /// <param name="lightColour">The value of lightColour.</param>
        public void SetLightColour(Color lightColour)
        {
            _persistentColourSettings.LightColour = lightColour;
        }

        /// <summary>
        /// Gets the LightColour value.
        /// </summary>
        /// <returns>The value of lightColour.</returns>
        public Color GetLightColour()
        {
            return _persistentColourSettings.LightColour;
        }

        /// <summary>
        /// Sets the LightestColour to the value of lightestColour.
        /// </summary>
        /// <param name="lightestColour">The value of lightestColour.</param>
        public void SetLightestColour(Color lightestColour)
        {
            _persistentColourSettings.LightestColour = lightestColour;
        }

        /// <summary>
        /// Gets the LightestColour value.
        /// </summary>
        /// <returns>The value of lightestColour.</returns>
        public Color GetLightestColour()
        {
            return _persistentColourSettings.LightestColour;
        }

        /// <summary>
        /// Sets the BorderColour to the value of borderColour.
        /// </summary>
        /// <param name="borderColour">The value of borderColour.</param>
        public void SetBorderColour(Color borderColour)
        {
            _persistentColourSettings.BorderColour = borderColour;
        }

        /// <summary>
        /// Gets the BorderColour value.
        /// </summary>
        /// <returns>The value of borderColour.</returns>
        public Color GetBorderColour()
        {
            return _persistentColourSettings.BorderColour;
        }

        /// <summary>
        /// Sets the NormalTextColour to the value of normalTextColour.
        /// </summary>
        /// <param name="normalTextColour">The value of normalTextColour.</param>
        public void SetNormalTextColour(Color normalTextColour)
        {
            _persistentColourSettings.NormalTextColour = normalTextColour;
        }

        /// <summary>
        /// Gets the NormalTextColour value.
        /// </summary>
        /// <returns>The value of normalTextColour.</returns>
        public Color GetNormalTextColour()
        {
            return _persistentColourSettings.NormalTextColour;
        }

        /// <summary>
        /// Sets the AlternativeNormalTextColour to the value of alternativeNormalTextColour.
        /// </summary>
        /// <param name="alternativeNormalTextColour">The value of alternativeNormalTextColour.</param>
        public void SetAlternativeNormalTextColour(Color alternativeNormalTextColour)
        {
            _persistentColourSettings.AlternativeNormalTextColour = alternativeNormalTextColour;
        }

        /// <summary>
        /// Gets the AlternativeNormalTextColour value.
        /// </summary>
        /// <returns>The value of alternativeNormalTextColour.</returns>
        public Color GetAlternativeNormalTextColour()
        {
            return _persistentColourSettings.AlternativeNormalTextColour;
        }

        /// <summary>
        /// Sets the DisabledTextColour to the value of disabledTextColur.
        /// </summary>
        /// <param name="disabledTextColur">The value of disabledTextColur.</param>
        public void SetDisabledTextColour(Color disabledTextColur)
        {
            _persistentColourSettings.DisabledTextColour = disabledTextColur;
        }

        /// <summary>
        /// Gets the DisabledTextColour value.
        /// </summary>
        /// <returns>The value of disabledTextColur.</returns>
        public Color GetDisabledTextColour()
        {
            return _persistentColourSettings.DisabledTextColour;
        }

        /// <summary>
        /// Sets the DisabledControlColour to the value of disabledControlColour.
        /// </summary>
        /// <param name="disabledControlColour">The value of disabledControlColour.</param>
        public void SetDisabledControlColour(Color disabledControlColour)
        {
            _persistentColourSettings.DisabledControlColour = disabledControlColour;
        }

        /// <summary>
        /// Gets the DisabledControlColour value.
        /// </summary>
        /// <returns>The value of disabledControlColour.</returns>
        public Color GetDisabledControlColour()
        {
            return _persistentColourSettings.DisabledControlColour;
        }

        /// <summary>
        /// Sets the LinkNormalColour to the value of linkNormalColour.
        /// </summary>
        /// <param name="linkNormalColour">The value of linkNormalColour.</param>
        public void SetLinkNormalColour(Color linkNormalColour)
        {
            _persistentColourSettings.LinkNormalColour = linkNormalColour;
        }

        /// <summary>
        /// Gets the LinkNormalColour value.
        /// </summary>
        /// <returns>The value of linkNormalColour.</returns>
        public Color GetLinkNormalColour()
        {
            return _persistentColourSettings.LinkNormalColour;
        }

        /// <summary>
        /// Sets the LinkFocusedColour to the value of linkFocusedColour.
        /// </summary>
        /// <param name="linkFocusedColour">The value of linkFocusedColour.</param>
        public void SetLinkFocusedColour(Color linkFocusedColour)
        {
            _persistentColourSettings.LinkFocusedColour = linkFocusedColour;
        }

        /// <summary>
        /// Gets the LinkFocusedColour value.
        /// </summary>
        /// <returns>The value of linkFocusedColour.</returns>
        public Color GetLinkFocusedColour()
        {
            return _persistentColourSettings.LinkFocusedColour;
        }

        /// <summary>
        /// Sets the FocusTextColour to the value of focusTextColour.
        /// </summary>
        /// <param name="focusedTextColour">The value of focusTextColour.</param>
        public void SetFocusedTextColour(Color focusedTextColour)
        {
            _persistentColourSettings.FocusedTextColour = focusedTextColour;
        }

        /// <summary>
        /// Gets the FocusTextColour value.
        /// </summary>
        /// <returns>The value of focusTextColour.</returns>
        public Color GetFocusedTextColour()
        {
            return _persistentColourSettings.FocusedTextColour;
        }

        /// <summary>
        /// Sets the PressedTextColour to the value of pressedTextColour.
        /// </summary>
        /// <param name="pressedTextColour">The value of pressedTextColour.</param>
        public void SetPressedTextColour(Color pressedTextColour)
        {
            _persistentColourSettings.PressedTextColour = pressedTextColour;
        }

        /// <summary>
        /// Gets the PressedTextColour value.
        /// </summary>
        /// <returns>The value of pressedTextColour.</returns>
        public Color GetPressedTextColour()
        {
            return _persistentColourSettings.PressedTextColour;
        }

        /// <summary>
        /// Sets the LinkHoverColour to the value of linkHoverColour.
        /// </summary>
        /// <param name="linkHoverColour">The value of linkHoverColour.</param>
        public void SetLinkHoverColour(Color linkHoverColour)
        {
            _persistentColourSettings.LinkHoverColour = linkHoverColour;
        }

        /// <summary>
        /// Gets the LinkHoverColour value.
        /// </summary>
        /// <returns>The value of linkHoverColour.</returns>
        public Color GetLinkHoverColour()
        {
            return _persistentColourSettings.LinkHoverColour;
        }

        /// <summary>
        /// Sets the LinkVisitedColour to the value of linkVisitedColour.
        /// </summary>
        /// <param name="linkVisitedColour">The value of linkVisitedColour.</param>
        public void SetLinkVisitedColour(Color linkVisitedColour)
        {
            _persistentColourSettings.LinkVisitedColour = linkVisitedColour;
        }

        /// <summary>
        /// Gets the LinkVisitedColour value.
        /// </summary>
        /// <returns>The value of linkVisitedColour.</returns>
        public Color GetLinkVisitedColour()
        {
            return _persistentColourSettings.LinkVisitedColour;
        }

        /// <summary>
        /// Sets the LinkDisabledColour to the value of linkDisabledColour.
        /// </summary>
        /// <param name="linkDisabledColour">The value of linkDisabledColour.</param>
        public void SetLinkDisabledColour(Color linkDisabledColour)
        {
            _persistentColourSettings.LinkDisabledColour = linkDisabledColour;
        }

        /// <summary>
        /// Gets the LinkDisabledColour value.
        /// </summary>
        /// <returns>The value of linkDisabledColour.</returns>
        public Color GetLinkDisabledColour()
        {
            return _persistentColourSettings.LinkDisabledColour;
        }

        /// <summary>
        /// Sets the CustomColourOne to the value of customColourOne.
        /// </summary>
        /// <param name="customColourOne">The value of customColourOne.</param>
        public void SetCustomColourOne(Color customColourOne)
        {
            _persistentColourSettings.CustomColourOne = customColourOne;
        }

        /// <summary>
        /// Gets the CustomColourOne value.
        /// </summary>
        /// <returns>The value of customColourOne.</returns>
        public Color GetCustomColourOne()
        {
            return _persistentColourSettings.CustomColourOne;
        }

        /// <summary>
        /// Sets the CustomColourTwo to the value of customColourTwo.
        /// </summary>
        /// <param name="customColourTwo">The value of customColourTwo.</param>
        public void SetCustomColourTwo(Color customColourTwo)
        {
            _persistentColourSettings.CustomColourTwo = customColourTwo;
        }

        /// <summary>
        /// Gets the CustomColourTwo value.
        /// </summary>
        /// <returns>The value of customColourTwo.</returns>
        public Color GetCustomColourTwo()
        {
            return _persistentColourSettings.CustomColourTwo;
        }

        /// <summary>
        /// Sets the CustomColourThree to the value of customColourThree.
        /// </summary>
        /// <param name="customColourThree">The value of customColourThree.</param>
        public void SetCustomColourThree(Color customColourThree)
        {
            _persistentColourSettings.CustomColourThree = customColourThree;
        }

        /// <summary>
        /// Gets the CustomColourThree value.
        /// </summary>
        /// <returns>The value of customColourThree.</returns>
        public Color GetCustomColourThree()
        {
            return _persistentColourSettings.CustomColourThree;
        }

        /// <summary>
        /// Sets the CustomColourFour to the value of customColourFour.
        /// </summary>
        /// <param name="customColourFour">The value of customColourFour.</param>
        public void SetCustomColourFour(Color customColourFour)
        {
            _persistentColourSettings.CustomColourFour = customColourFour;
        }

        /// <summary>
        /// Gets the CustomColourFour value.
        /// </summary>
        /// <returns>The value of customColourFour.</returns>
        public Color GetCustomColourFour()
        {
            return _persistentColourSettings.CustomColourFour;
        }

        /// <summary>
        /// Sets the CustomColourFive to the value of customColourFive.
        /// </summary>
        /// <param name="customColourFive">The value of customColourFive.</param>
        public void SetCustomColourFive(Color customColourFive)
        {
            _persistentColourSettings.CustomColourFive = customColourFive;
        }

        /// <summary>
        /// Gets the CustomColourFive value.
        /// </summary>
        /// <returns>The value of customColourFive.</returns>
        public Color GetCustomColourFive()
        {
            return _persistentColourSettings.CustomColourFive;
        }

        /// <summary>
        /// Sets the MenuTextColour to the value of menuTextColour.
        /// </summary>
        /// <param name="menuTextColour">The value of menuTextColour.</param>
        public void SetMenuTextColour(Color menuTextColour)
        {
            _persistentColourSettings.MenuTextColour = menuTextColour;
        }

        /// <summary>
        /// Gets the MenuTextColour value.
        /// </summary>
        /// <returns>The value of menuTextColour.</returns>
        public Color GetMenuTextColour()
        {
            return _persistentColourSettings.MenuTextColour;
        }

        /// <summary>
        /// Sets the CustomTextColourOne to the value of customTextColourOne.
        /// </summary>
        /// <param name="customTextColourOne">The value of customTextColourOne.</param>
        public void SetCustomTextColourOne(Color customTextColourOne)
        {
            _persistentColourSettings.CustomTextColourOne = customTextColourOne;
        }

        /// <summary>
        /// Gets the CustomTextColourOne value.
        /// </summary>
        /// <returns>The value of customTextColourOne.</returns>
        public Color GetCustomTextColourOne()
        {
            return _persistentColourSettings.CustomTextColourOne;
        }

        /// <summary>
        /// Sets the CustomTextColourTwo to the value of customTextColourTwo.
        /// </summary>
        /// <param name="customTextColourTwo">The value of customTextColourTwo.</param>
        public void SetCustomTextColourTwo(Color customTextColourTwo)
        {
            _persistentColourSettings.CustomTextColourTwo = customTextColourTwo;
        }

        /// <summary>
        /// Gets the CustomTextColourTwo value.
        /// </summary>
        /// <returns>The value of customTextColourTwo.</returns>
        public Color GetCustomTextColourTwo()
        {
            return _persistentColourSettings.CustomTextColourTwo;
        }

        /// <summary>
        /// Sets the CustomTextColourThree to the value of customTextColourThree.
        /// </summary>
        /// <param name="customTextColourThree">The value of customTextColourThree.</param>
        public void SetCustomTextColourThree(Color customTextColourThree)
        {
            _persistentColourSettings.CustomTextColourThree = customTextColourThree;
        }

        /// <summary>
        /// Gets the CustomTextColourThree value.
        /// </summary>
        /// <returns>The value of customTextColourThree.</returns>
        public Color GetCustomTextColourThree()
        {
            return _persistentColourSettings.CustomTextColourThree;
        }

        /// <summary>
        /// Sets the CustomTextColourFour to the value of customTextColourFour.
        /// </summary>
        /// <param name="customTextColourFour">The value of customTextColourFour.</param>
        public void SetCustomTextColourFour(Color customTextColourFour)
        {
            _persistentColourSettings.CustomTextColourFour = customTextColourFour;
        }

        /// <summary>
        /// Gets the CustomTextColourFour value.
        /// </summary>
        /// <returns>The value of customTextColourFour.</returns>
        public Color GetCustomTextColourFour()
        {
            return _persistentColourSettings.CustomTextColourFour;
        }

        /// <summary>
        /// Sets the CustomTextColourFive to the value of customTextColourFive.
        /// </summary>
        /// <param name="customTextColourFive">The value of customTextColourFive.</param>
        public void SetCustomTextColourFive(Color customTextColourFive)
        {
            _persistentColourSettings.CustomTextColourFive = customTextColourFive;
        }

        /// <summary>
        /// Gets the CustomTextColourFive value.
        /// </summary>
        /// <returns>The value of customTextColourFive.</returns>
        public Color GetCustomTextColourFive()
        {
            return _persistentColourSettings.CustomTextColourFive;
        }

        /// <summary>
        /// Sets the StatusTextColour to the value of statusTextColour.
        /// </summary>
        /// <param name="statusTextColour">The value of statusTextColour.</param>
        public void SetStatusTextColour(Color statusTextColour)
        {
            _persistentColourSettings.StatusTextColour = statusTextColour;
        }

        /// <summary>
        /// Gets the StatusTextColour value.
        /// </summary>
        /// <returns>The value of statusTextColour.</returns>
        public Color GetStatusTextColour()
        {
            return _persistentColourSettings.StatusTextColour;
        }
        #endregion

        #region Methods
        public static void SaveColourSettings(bool usePrompt = false)
        {

        }

        public static void InvalidateColourSettings()
        {
            InternalColourSettingsManager internalColourSettingsManager = new InternalColourSettingsManager();

            internalColourSettingsManager.SetDarkestColour(Color.White);

            internalColourSettingsManager.SetMediumColour(Color.White);

            internalColourSettingsManager.SetLightColour(Color.White);

            internalColourSettingsManager.SetLightestColour(Color.White);

            internalColourSettingsManager.SetBorderColour(SystemColors.Control);

            internalColourSettingsManager.SetAlternativeNormalTextColour(Color.White);

            internalColourSettingsManager.SetNormalTextColour(Color.Black);

            internalColourSettingsManager.SetFocusedTextColour(Color.White);

            internalColourSettingsManager.SetPressedTextColour(Color.Black);

            internalColourSettingsManager.SetDisabledTextColour(Color.Gray);

            internalColourSettingsManager.SetDisabledControlColour(Color.Silver);

            internalColourSettingsManager.SetLinkNormalColour(Color.Blue);

            internalColourSettingsManager.SetLinkFocusedColour(Color.Gray);

            internalColourSettingsManager.SetLinkHoverColour(Color.Red);

            internalColourSettingsManager.SetLinkVisitedColour(Color.Purple);

            internalColourSettingsManager.SetCustomColourOne(Color.Black);

            internalColourSettingsManager.SetCustomColourTwo(Color.White);

            internalColourSettingsManager.SetCustomColourThree(Color.Black);

            internalColourSettingsManager.SetCustomColourFour(Color.FromArgb(230, 230, 230));

            internalColourSettingsManager.SetCustomColourFive(Color.MintCream);

            internalColourSettingsManager.SetCustomTextColourOne(Color.Black);

            internalColourSettingsManager.SetCustomTextColourTwo(Color.White);

            internalColourSettingsManager.SetCustomTextColourThree(Color.Black);

            internalColourSettingsManager.SetCustomTextColourFour(Color.FromArgb(230, 230, 230));

            internalColourSettingsManager.SetCustomTextColourFive(Color.MintCream);

            internalColourSettingsManager.SetMenuTextColour(Color.Black);

            internalColourSettingsManager.SetStatusTextColour(Color.Black);
        }
        #endregion
    }
}