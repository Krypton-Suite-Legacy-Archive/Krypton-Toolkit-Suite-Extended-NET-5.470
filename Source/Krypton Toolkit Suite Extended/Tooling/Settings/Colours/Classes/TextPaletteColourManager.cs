using ComponentFactory.Krypton.Toolkit;
using Core.Settings.Colours.Settings;
using System.Drawing;
using System.Windows.Forms;

namespace Core.Settings.Colours.Classes
{
    public class TextPaletteColourManager
    {
        #region Variables
        private TextPaletteColours _textPaletteColours = new TextPaletteColours();
        #endregion

        #region Constructor
        public TextPaletteColourManager()
        {

        }
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the AlternativeNormalTextColour to the value of alternativeNormalTextColour.
        /// </summary>
        /// <param name="alternativeNormalTextColour">The value of alternativeNormalTextColour.</param>
        public void SetAlternativeNormalTextColour(Color alternativeNormalTextColour)
        {
            _textPaletteColours.AlternativeNormalTextColour = alternativeNormalTextColour;
        }

        /// <summary>
        /// Gets the AlternativeNormalTextColour value.
        /// </summary>
        /// <returns>The value of alternativeNormalTextColour.</returns>
        public Color GetAlternativeNormalTextColour()
        {
            return _textPaletteColours.AlternativeNormalTextColour;
        }

        /// <summary>
        /// Sets the DisabledTextColour to the value of disabledTextColour.
        /// </summary>
        /// <param name="disabledTextColour">The value of disabledTextColour.</param>
        public void SetDisabledTextColour(Color disabledTextColour)
        {
            _textPaletteColours.DisabledTextColour = disabledTextColour;
        }

        /// <summary>
        /// Gets the DisabledTextColour value.
        /// </summary>
        /// <returns>The value of disabledTextColour.</returns>
        public Color GetDisabledTextColour()
        {
            return _textPaletteColours.DisabledTextColour;
        }

        /// <summary>
        /// Sets the NormalTextColour to the value of normalTextColour.
        /// </summary>
        /// <param name="normalTextColour">The value of normalTextColour.</param>
        public void SetNormalTextColour(Color normalTextColour)
        {
            _textPaletteColours.NormalTextColour = normalTextColour;
        }

        /// <summary>
        /// Gets the NormalTextColour value.
        /// </summary>
        /// <returns>The value of normalTextColour.</returns>
        public Color GetNormalTextColour()
        {
            return _textPaletteColours.NormalTextColour;
        }

        /// <summary>
        /// Sets the FocusedTextColour to the value of focusedTextColour.
        /// </summary>
        /// <param name="focusedTextColour">The value of focusedTextColour.</param>
        public void SetFocusedTextColour(Color focusedTextColour)
        {
            _textPaletteColours.FocusedTextColour = focusedTextColour;
        }

        /// <summary>
        /// Gets the FocusedTextColour value.
        /// </summary>
        /// <returns>The value of focusedTextColour.</returns>
        public Color GetFocusedTextColour()
        {
            return _textPaletteColours.FocusedTextColour;
        }

        /// <summary>
        /// Sets the PressedTextColour to the value of pressedTextColour.
        /// </summary>
        /// <param name="pressedTextColour">The value of pressedTextColour.</param>
        public void SetPressedTextColour(Color pressedTextColour)
        {
            _textPaletteColours.PressedTextColour = pressedTextColour;
        }

        /// <summary>
        /// Gets the PressedTextColour value.
        /// </summary>
        /// <returns>The value of pressedTextColour.</returns>
        public Color GetPressedTextColour()
        {
            return _textPaletteColours.PressedTextColour;
        }

        /// <summary>
        /// Sets the RibbonTabTextColour to the value of ribbonTabTextColour.
        /// </summary>
        /// <param name="ribbonTabTextColour">The value of ribbonTabTextColour.</param>
        public void SetRibbonTabTextColour(Color ribbonTabTextColour)
        {
            _textPaletteColours.RibbonTabTextColour = ribbonTabTextColour;
        }

        /// <summary>
        /// Gets the RibbonTabTextColour value.
        /// </summary>
        /// <returns>The value of ribbonTabTextColour.</returns>
        public Color GetRibbonTabTextColour()
        {
            return _textPaletteColours.RibbonTabTextColour;
        }

        /// <summary>
        /// Sets the MenuTextColour to the value of menuTextColour.
        /// </summary>
        /// <param name="menuTextColour">The value of menuTextColour.</param>
        public void SetMenuTextColour(Color menuTextColour)
        {
            _textPaletteColours.MenuTextColour = menuTextColour;
        }

        /// <summary>
        /// Gets the MenuTextColour value.
        /// </summary>
        /// <returns>The value of menuTextColour.</returns>
        public Color GetMenuTextColour()
        {
            return _textPaletteColours.MenuTextColour;
        }

        /// <summary>
        /// Sets the StatusStripTextColour to the value of statusStripTextColour.
        /// </summary>
        /// <param name="statusStripTextColour">The value of statusStripTextColour.</param>
        public void SetStatusStripTextColour(Color statusStripTextColour)
        {
            _textPaletteColours.StatusStripTextColour = statusStripTextColour;
        }

        /// <summary>
        /// Gets the StatusStripTextColour value.
        /// </summary>
        /// <returns>The value of statusStripTextColour.</returns>
        public Color GetStatusStripTextColour()
        {
            return _textPaletteColours.StatusStripTextColour;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Saves the colour settings.
        /// </summary>
        /// <param name="usePrompt">If set to <c>true</c> [use prompt].</param>
        public void SaveColourSettings(bool usePrompt = false)
        {
            if (usePrompt)
            {
                DialogResult result = KryptonMessageBox.Show("Do you want to save the current colour settings?", "Save Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _textPaletteColours.Save();
                }
                else
                {
                    ResetSettings(usePrompt);
                }
            }
            else
            {
                _textPaletteColours.Save();
            }
        }


        /// <summary>
        /// Resets the settings.
        /// </summary>
        /// <param name="usePrompt">If set to <c>true</c> [use prompt].</param>
        public void ResetSettings(bool usePrompt = false)
        {
            if (usePrompt)
            {
                DialogResult result = KryptonMessageBox.Show("This action will reset the colour values. Do you want to continue?", "Reset Colour Values", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ResetColourSettings();

                    SaveColourSettings(usePrompt);
                }
                else
                {
                    ResetColourSettings();

                    SaveColourSettings();
                }
            }
        }

        /// <summary>
        /// Resets the colour settings.
        /// </summary>
        private void ResetColourSettings()
        {
            SetAlternativeNormalTextColour(Color.White);

            SetNormalTextColour(Color.Black);

            SetFocusedTextColour(Color.White);

            SetPressedTextColour(Color.Black);

            SetDisabledTextColour(Color.Gray);

            SetMenuTextColour(Color.Black);

            SetRibbonTabTextColour(Color.Black);
        }
        #endregion

        #region Detection
        public static bool AreTextPaletteColoursEmpty()
        {
            TextPaletteColourManager textPaletteColourManager = new TextPaletteColourManager();

            if (textPaletteColourManager.GetAlternativeNormalTextColour() == Color.Empty || textPaletteColourManager.GetDisabledTextColour() == Color.Empty || textPaletteColourManager.GetFocusedTextColour() == Color.Empty || textPaletteColourManager.GetMenuTextColour() == Color.Empty || textPaletteColourManager.GetNormalTextColour() == Color.Empty || textPaletteColourManager.GetPressedTextColour() == Color.Empty || textPaletteColourManager.GetRibbonTabTextColour() == Color.Empty || textPaletteColourManager.GetStatusStripTextColour() == Color.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}