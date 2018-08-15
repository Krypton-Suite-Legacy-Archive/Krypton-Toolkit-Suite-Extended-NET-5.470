using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Tooling.Enumerations;
using Tooling.Settings.Classes;

namespace Tooling.Classes.Other
{
    public static class ColourUtilities
    {
        /// <summary>
        /// Converts the HSL values to a Color.
        /// </summary>
        /// <param name="alpha">The alpha.</param>
        /// <param name="hue">The hue.</param>
        /// <param name="saturation">The saturation.</param>
        /// <param name="lighting">The lighting.</param>
        /// <returns></returns>
        public static Color FromHsl(int alpha, float hue, float saturation, float lighting)
        {
            if (0 > alpha || 255 < alpha)
            {
                throw new ArgumentOutOfRangeException("alpha");
            }
            if (0f > hue || 360f < hue)
            {
                throw new ArgumentOutOfRangeException("hue");
            }
            if (0f > saturation || 1f < saturation)
            {
                throw new ArgumentOutOfRangeException("saturation");
            }
            if (0f > lighting || 1f < lighting)
            {
                throw new ArgumentOutOfRangeException("lighting");
            }

            if (0 == saturation)
            {
                return Color.FromArgb(alpha, Convert.ToInt32(lighting * 255), Convert.ToInt32(lighting * 255), Convert.ToInt32(lighting * 255));
            }

            float fMax, fMid, fMin;
            int iSextant, iMax, iMid, iMin;

            if (0.5 < lighting)
            {
                fMax = lighting - (lighting * saturation) + saturation;
                fMin = lighting + (lighting * saturation) - saturation;
            }
            else
            {
                fMax = lighting + (lighting * saturation);
                fMin = lighting - (lighting * saturation);
            }

            iSextant = (int)Math.Floor(hue / 60f);
            if (300f <= hue)
            {
                hue -= 360f;
            }
            hue /= 60f;
            hue -= 2f * (float)Math.Floor(((iSextant + 1f) % 6f) / 2f);
            if (0 == iSextant % 2)
            {
                fMid = hue * (fMax - fMin) + fMin;
            }
            else
            {
                fMid = fMin - hue * (fMax - fMin);
            }

            iMax = Convert.ToInt32(fMax * 255);
            iMid = Convert.ToInt32(fMid * 255);
            iMin = Convert.ToInt32(fMin * 255);

            switch (iSextant)
            {
                case 1:
                    return Color.FromArgb(alpha, iMid, iMax, iMin);
                case 2:
                    return Color.FromArgb(alpha, iMin, iMax, iMid);
                case 3:
                    return Color.FromArgb(alpha, iMin, iMid, iMax);
                case 4:
                    return Color.FromArgb(alpha, iMid, iMin, iMax);
                case 5:
                    return Color.FromArgb(alpha, iMax, iMin, iMid);
                default:
                    return Color.FromArgb(alpha, iMax, iMid, iMin);
            }
        }

        /// <summary>
        /// Tints the color by the given percent.
        /// </summary>
        /// <param name="color">The color being tinted.</param>
        /// <param name="percent">The percent to tint. Ex: 0.1 will make the color 10% lighter.</param>
        /// <returns>The new tinted color.</returns>
        public static Color Lighten(this Color color, float percent)
        {
            var lighting = color.GetBrightness();
            lighting = lighting + lighting * percent;
            if (lighting > 1.0)
            {
                lighting = 1;
            }
            else if (lighting <= 0)
            {
                lighting = 0.1f;
            }
            var tintedColor = FromHsl(color.A, color.GetHue(), color.GetSaturation(), lighting);

            return tintedColor;
        }

        /// <summary>
        /// Tints the color by the given percent.
        /// </summary>
        /// <param name="color">The color being tinted.</param>
        /// <param name="percent">The percent to tint. Ex: 0.1 will make the color 10% darker.</param>
        /// <returns>The new tinted color.</returns>
        public static Color Darken(this Color color, float percent)
        {
            var lighting = color.GetBrightness();
            lighting = lighting - lighting * percent;
            if (lighting > 1.0)
            {
                lighting = 1;
            }
            else if (lighting <= 0)
            {
                lighting = 0;
            }
            var tintedColor = FromHsl(color.A, color.GetHue(), color.GetSaturation(), lighting);

            return tintedColor;
        }

        /// <summary>
        /// Generates the colour shades.
        /// </summary>
        /// <param name="baseColour">The base colour.</param>
        /// <param name="darkestColour">The darkest colour.</param>
        /// <param name="mediumColour">The medium colour.</param>
        /// <param name="lightColour">The light colour.</param>
        /// <param name="lightestColour">The lightest colour.</param>
        public static void GenerateColourShades(Color baseColour, PictureBox darkestColour, PictureBox mediumColour, PictureBox lightColour, PictureBox lightestColour)
        {
            if (baseColour != null)
            {
                darkestColour.BackColor = Darken(baseColour, 0.5f);

                mediumColour.BackColor = Darken(baseColour, 0.25f);

                lightColour.BackColor = Lighten(baseColour, 0.25f);

                lightestColour.BackColor = Lighten(baseColour, 0.5f);

                if (lightestColour.BackColor == lightColour.BackColor)
                {
                    lightestColour.BackColor = Color.Transparent;

                    lightestColour.Enabled = false;
                }
                else
                {
                    lightestColour.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Generates the colour shades.
        /// </summary>
        /// <param name="baseColour">The base colour.</param>
        /// <param name="darkestColour">The darkest colour.</param>
        /// <param name="middleColour">The middle colour.</param>
        /// <param name="lightColour">The light colour.</param>
        /// <param name="lightestColour">The lightest colour.</param>
        public static void GenerateColourShades(Color baseColour, CircularPictureBox darkestColour, CircularPictureBox middleColour, CircularPictureBox lightColour, CircularPictureBox lightestColour)
        {
            if (baseColour != null)
            {
                darkestColour.BackColor = Darken(baseColour, 0.5f);

                middleColour.BackColor = Darken(baseColour, 0.25f);

                lightColour.BackColor = Lighten(baseColour, 0.25f);

                lightestColour.BackColor = Lighten(baseColour, 0.5f);

                if (lightestColour.BackColor == lightColour.BackColor)
                {
                    lightestColour.BackColor = Color.Transparent;

                    lightestColour.Enabled = false;
                }
                else
                {
                    lightestColour.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Formats the colour ARGB string.
        /// </summary>
        /// <param name="colourInput">The colour input.</param>
        /// <returns>A string containing the alpha, red, green and blue colour values of the selected <paramref name="colourInput"/>.</returns>
        public static string FormatColourARGBString(Color colourInput)
        {
            return $"{ colourInput.A.ToString() }, { colourInput.R.ToString() }, { colourInput.G.ToString() }, { colourInput.B.ToString() }";
        }

        /// <summary>
        /// Formats the colour RGB string.
        /// </summary>
        /// <param name="colourInput">The colour input.</param>
        /// <returns>A string containing the red, green and blue colour values of the selected <paramref name="colourInput"/>.</returns>
        public static string FormatColourRGBString(Color colourInput)
        {
            return $"{ colourInput.R.ToString() }, { colourInput.G.ToString() }, { colourInput.B.ToString() }";
        }

        /// <summary>
        /// Propagates the HSB values.
        /// </summary>
        /// <param name="hueValue">The hue value.</param>
        /// <param name="saturationValue">The saturation value.</param>
        /// <param name="brightnessValue">The brightness value.</param>
        /// <param name="hue">The hue.</param>
        /// <param name="saturation">The saturation.</param>
        /// <param name="brightness">The brightness.</param>
        public static void PropagateHSBValues(KryptonNumericUpDown hueValue, KryptonNumericUpDown saturationValue, KryptonNumericUpDown brightnessValue, decimal hue, decimal saturation, decimal brightness)
        {
            hueValue.Value = hue;

            saturationValue.Value = saturation;

            brightnessValue.Value = brightness;
        }

        /// <summary>
        /// Propagates the standard colours.
        /// </summary>
        /// <param name="standardColourSelection">The standard colour selection.</param>
        public static void PropagateStandardColours(KryptonComboBox standardColourSelection)
        {
            List<Color> allColours = new List<Color>();

            foreach (KnownColor colour in Enum.GetValues(typeof(KnownColor)))
            {
                Color standardColour = Color.FromKnownColor(colour);

                if (!allColours.Contains(standardColour))
                {
                    standardColourSelection.Items.Add(standardColour.Name);

                    standardColourSelection.AutoCompleteCustomSource.Add(standardColour.Name);

                    allColours.Add(standardColour);
                }
            }
        }

        /// <summary>
        /// Propagates the system colours.
        /// </summary>
        /// <param name="systemColourSelection">The system colour selection.</param>
        public static void PropagateSystemColours(KryptonComboBox systemColourSelection)
        {
            List<Color> allSystemColours = new List<Color>();

            PropertyInfo[] systemColourProperties = typeof(SystemColors).GetProperties();

            foreach (PropertyInfo propertyInfo in systemColourProperties)
            {
                object colourObject = propertyInfo.GetValue(null, null);

                Color systemColour = (Color)colourObject;

                if (!allSystemColours.Contains(systemColour))
                {
                    systemColourSelection.Items.Add(systemColour.Name);

                    systemColourSelection.AutoCompleteCustomSource.Add(systemColour.Name);

                    allSystemColours.Add(systemColour);
                }
            }
        }

        public static void PropagateBasePaletteModes(KryptonComboBox basePaletteModeSelection)
        {
            List<PaletteMode> allPaletteModes = new List<PaletteMode>();

            foreach (string mode in Enum.GetNames(typeof(PaletteMode)))
            {
                basePaletteModeSelection.Items.Add(mode);
            }
        }

        /// <summary>
        /// Grabs the colour definitions.
        /// </summary>
        /// <param name="baseColour">The base colour.</param>
        /// <param name="darkColour">The dark colour.</param>
        /// <param name="middleColour">The middle colour.</param>
        /// <param name="lightColour">The light colour.</param>
        /// <param name="lightestColour">The lightest colour.</param>
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
        /// <param name="menuTextColour">The menu text colour.</param>
        /// <param name="statusTextColour">The status text colour.</param>
        public static void GrabColourDefinitions(PictureBox baseColour, PictureBox darkColour, PictureBox middleColour, PictureBox lightColour, PictureBox lightestColour, PictureBox borderColourPreview, PictureBox alternativeNormalTextColourPreview, PictureBox normalTextColourPreview, PictureBox disabledTextColourPreview, PictureBox focusedTextColourPreview, PictureBox pressedTextColourPreview, PictureBox disabledColourPreview, PictureBox linkNormalColourPreview, PictureBox linkHoverColourPreview, PictureBox linkVisitedColourPreview, PictureBox customColourOne, PictureBox customColourTwo, PictureBox customColourThree, PictureBox customColourFour, PictureBox customColourFive, PictureBox customTextColourOne, PictureBox customTextColourTwo, PictureBox customTextColourThree, PictureBox customTextColourFour, PictureBox customTextColourFive, PictureBox menuTextColour, PictureBox statusTextColour)
        {
            ColourSettingsManager colourSettingsManager = new ColourSettingsManager();

            baseColour.BackColor = colourSettingsManager.GetBaseColour();

            darkColour.BackColor = colourSettingsManager.GetDarkestColour();

            middleColour.BackColor = colourSettingsManager.GetMediumColour();

            lightColour.BackColor = colourSettingsManager.GetLightColour();

            lightestColour.BackColor = colourSettingsManager.GetLightestColour();

            borderColourPreview.BackColor = colourSettingsManager.GetBorderColour();

            alternativeNormalTextColourPreview.BackColor = colourSettingsManager.GetAlternativeNormalTextColour();

            normalTextColourPreview.BackColor = colourSettingsManager.GetNormalTextColour();

            disabledTextColourPreview.BackColor = colourSettingsManager.GetDisabledTextColour();

            focusedTextColourPreview.BackColor = colourSettingsManager.GetFocusTextColour();

            pressedTextColourPreview.BackColor = colourSettingsManager.GetPressedTextColour();

            disabledColourPreview.BackColor = colourSettingsManager.GetDisabledColour();

            linkNormalColourPreview.BackColor = colourSettingsManager.GetLinkNormalColour();

            linkHoverColourPreview.BackColor = colourSettingsManager.GetLinkHoverColour();

            linkVisitedColourPreview.BackColor = colourSettingsManager.GetLinkVisitedColour();

            customColourOne.BackColor = colourSettingsManager.GetCustomColourOne();

            customColourTwo.BackColor = colourSettingsManager.GetCustomColourTwo();

            customColourThree.BackColor = colourSettingsManager.GetCustomColourThree();

            customColourFour.BackColor = colourSettingsManager.GetCustomColourFour();

            customColourFive.BackColor = colourSettingsManager.GetCustomColourFive();

            menuTextColour.BackColor = colourSettingsManager.GetMenuTextColour();

            customTextColourOne.BackColor = colourSettingsManager.GetCustomTextColourOne();

            customTextColourTwo.BackColor = colourSettingsManager.GetCustomTextColourTwo();

            customTextColourThree.BackColor = colourSettingsManager.GetCustomTextColourThree();

            customTextColourFour.BackColor = colourSettingsManager.GetCustomTextColourFour();

            customTextColourFive.BackColor = colourSettingsManager.GetCustomTextColourFive();

            statusTextColour.BackColor = colourSettingsManager.GetStatusTextColour();
        }

        /// <summary>
        /// Defines the custom colour.
        /// </summary>
        /// <param name="colourDefinitions">The colour definitions.</param>
        /// <param name="definedColour">The defined colour.</param>
        /// <param name="usePrompt">if set to <c>true</c> [use prompt].</param>
        public static void DefineCustomColour(MiscellaneousColourDefinitions colourDefinitions, Color definedColour, bool usePrompt = false)
        {
            Color _baseColour, _darkestColour, _middleColour, _lightColour, _lightestColour;

            ColourSettingsManager colourSettingsManager = new ColourSettingsManager();

            switch (colourDefinitions)
            {
                case MiscellaneousColourDefinitions.BORDERCOLOUR:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetBorderColour(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.ALTERNATIVENORMALTEXTCOLOUR:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetAlternativeNormalTextColour(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.NORMALTEXTCOLOUR:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetNormalTextColour(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.DISABLEDTEXTCOLOUR:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetDisabledTextColour(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.FOCUSEDTEXTCOLOUR:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetFocusTextColour(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.PRESSEDTEXTCOLOUR:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetPressedTextColour(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.LINKNORMALTEXTCOLOUR:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetLinkNormalColour(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.LINKHOVERTEXTCOLOUR:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetLinkHoverColour(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.LINKVISITEDTEXTCOLOUR:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetLinkVisitedColour(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.DISABLEDCONTROLCOLOUR:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetDisabledColour(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.CUSTOMCOLOURONE:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetCustomColourOne(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.CUSTOMCOLOURTWO:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetCustomColourTwo(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.CUSTOMCOLOURTHREE:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetCustomColourThree(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.CUSTOMCOLOURFOUR:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetCustomColourFour(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.CUSTOMCOLOURFIVE:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetCustomColourFive(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.MENUTEXTCOLOUR:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetMenuTextColour(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.CUSTOMTEXTCOLOURONE:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetCustomTextColourOne(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.CUSTOMTEXTCOLOURTWO:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetCustomTextColourTwo(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.CUSTOMTEXTCOLOURTHREE:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetCustomTextColourThree(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.CUSTOMTEXTCOLOURFOUR:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetCustomTextColourFour(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.CUSTOMTEXTCOLOURFIVE:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetCustomTextColourFive(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                case MiscellaneousColourDefinitions.STATUSTEXTCOLOUR:
                    _baseColour = colourSettingsManager.GetBaseColour();

                    _darkestColour = colourSettingsManager.GetDarkestColour();

                    _middleColour = colourSettingsManager.GetMediumColour();

                    _lightColour = colourSettingsManager.GetLightColour();

                    _lightestColour = colourSettingsManager.GetLightestColour();

                    colourSettingsManager.SetBaseColour(_baseColour);

                    colourSettingsManager.SetDarkestColour(_darkestColour);

                    colourSettingsManager.SetMediumColour(_middleColour);

                    colourSettingsManager.SetLightColour(_lightColour);

                    colourSettingsManager.SetLightestColour(_lightestColour);

                    colourSettingsManager.SetStatusTextColour(definedColour);

                    colourSettingsManager.SaveColourSettings(usePrompt);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Updates the colour.
        /// </summary>
        /// <param name="colourPreview">The colour preview.</param>
        /// <param name="alpha">The alpha.</param>
        /// <param name="red">The red.</param>
        /// <param name="green">The green.</param>
        /// <param name="blue">The blue.</param>
        public static void UpdateColour(PictureBox colourPreview, int alpha, int red, int green, int blue)
        {
            colourPreview.BackColor = Color.FromArgb(alpha, red, green, blue);
        }
    }
}