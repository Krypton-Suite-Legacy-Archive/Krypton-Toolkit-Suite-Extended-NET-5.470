using ComponentFactory.Krypton.Toolkit;
using Core.Settings.Colours.Settings;
using System.Drawing;
using System.Windows.Forms;

namespace Core.Settings.Colours.Classes
{
    public class LinkTextPaletteColourManager
    {
        #region Variables
        private LinkTextPaletteColours _linkTextPaletteColours = new LinkTextPaletteColours();
        #endregion

        #region Constructor
        public LinkTextPaletteColourManager()
        {

        }
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the LinkHoverColour to the value of linkHoverColour.
        /// </summary>
        /// <param name="linkHoverColour">The value of linkHoverColour.</param>
        public void SetLinkHoverColour(Color linkHoverColour)
        {
            _linkTextPaletteColours.LinkHoverColour = linkHoverColour;
        }

        /// <summary>
        /// Gets the LinkHoverColour value.
        /// </summary>
        /// <returns>The value of linkHoverColour.</returns>
        public Color GetLinkHoverColour()
        {
            return _linkTextPaletteColours.LinkHoverColour;
        }

        /// <summary>
        /// Sets the LinkVisitedColour to the value of linkVisitedColour.
        /// </summary>
        /// <param name="linkVisitedColour">The value of linkVisitedColour.</param>
        public void SetLinkVisitedColour(Color linkVisitedColour)
        {
            _linkTextPaletteColours.LinkVisitedColour = linkVisitedColour;
        }

        /// <summary>
        /// Gets the LinkVisitedColour value.
        /// </summary>
        /// <returns>The value of linkVisitedColour.</returns>
        public Color GetLinkVisitedColour()
        {
            return _linkTextPaletteColours.LinkVisitedColour;
        }

        /// <summary>
        /// Sets the LinkDisabledColour to the value of linkDisabledColour.
        /// </summary>
        /// <param name="linkDisabledColour">The value of linkDisabledColour.</param>
        public void SetLinkDisabledColour(Color linkDisabledColour)
        {
            _linkTextPaletteColours.LinkDisabledColour = linkDisabledColour;
        }

        /// <summary>
        /// Gets the LinkDisabledColour value.
        /// </summary>
        /// <returns>The value of linkDisabledColour.</returns>
        public Color GetLinkDisabledColour()
        {
            return _linkTextPaletteColours.LinkDisabledColour;
        }

        /// <summary>
        /// Sets the LinkFocusedColour to the value of linkFocusedColour.
        /// </summary>
        /// <param name="linkFocusedColour">The value of linkFocusedColour.</param>
        public void SetLinkFocusedColour(Color linkFocusedColour)
        {
            _linkTextPaletteColours.LinkFocusedColour = linkFocusedColour;
        }

        /// <summary>
        /// Gets the LinkFocusedColour value.
        /// </summary>
        /// <returns>The value of linkFocusedColour.</returns>
        public Color GetLinkFocusedColour()
        {
            return _linkTextPaletteColours.LinkFocusedColour;
        }

        /// <summary>
        /// Sets the LinkNormalColour to the value of linkNormalColour.
        /// </summary>
        /// <param name="linkNormalColour">The value of linkNormalColour.</param>
        public void SetLinkNormalColour(Color linkNormalColour)
        {
            _linkTextPaletteColours.LinkNormalColour = linkNormalColour;
        }

        /// <summary>
        /// Gets the LinkNormalColour value.
        /// </summary>
        /// <returns>The value of linkNormalColour.</returns>
        public Color GetLinkNormalColour()
        {
            return _linkTextPaletteColours.LinkNormalColour;
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
                    _linkTextPaletteColours.Save();
                }
                else
                {
                    ResetSettings(usePrompt);
                }
            }
            else
            {
                _linkTextPaletteColours.Save();
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
                DialogResult result = KryptonMessageBox.Show("This action will reset the link text colour values. Do you want to continue?", "Reset Colour Values", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
            SetLinkNormalColour(Color.Blue);

            SetLinkFocusedColour(SystemColors.ActiveCaption);

            SetLinkHoverColour(Color.Red);

            SetLinkVisitedColour(Color.Purple);

            SetLinkNormalColour(SystemColors.HighlightText);

            SetLinkDisabledColour(Color.Gray);
        }
        #endregion

        #region Detection
        public static bool AreLinkTextPaletteColoursEmpty()
        {
            LinkTextPaletteColourManager linkTextPaletteColourManager = new LinkTextPaletteColourManager();

            if (linkTextPaletteColourManager.GetLinkNormalColour() == Color.Empty || linkTextPaletteColourManager.GetLinkFocusedColour() == Color.Empty || linkTextPaletteColourManager.GetLinkHoverColour() == Color.Empty || linkTextPaletteColourManager.GetLinkNormalColour() == Color.Empty || linkTextPaletteColourManager.GetLinkVisitedColour() == Color.Empty)
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