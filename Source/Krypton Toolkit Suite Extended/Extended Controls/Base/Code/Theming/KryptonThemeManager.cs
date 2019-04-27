using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.MessageBoxes.UI;
using System;
using System.Collections;
using System.Windows.Forms;

namespace ExtendedControls.Base.Code.Theming
{
    /// <summary>
    /// 
    /// </summary>
    public class KryptonThemeManager
    {
        #region Variables
        /// <summary>
        /// The supported themes
        /// </summary>
        private static string[] _supportedThemes = new string[]
        {
             "Professional - System",

            "Professional - Office 2003",

            "Office 2007 - Black",

            "Office 2007 - Blue",

            "Office 2007 - Silver",

            "Office 2007 - White",

            "Office 2010 - Black",

            "Office 2010 - Blue",

            "Office 2010 - Silver",

            "Office 2010 - White",

            "Office 2013",

            "Office 2013 - White",

            "Office 365 - Black",

            "Office 365 - Blue",

            "Office 365 - Silver",

            "Office 365 - White",

            "Sparkle - Blue",

            "Sparkle - Orange",

            "Sparkle - Purple",

            "Custom"
        };
        #endregion

        #region Methods
        /// <summary>
        /// Propagates the theme array.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="sort">if set to <c>true</c> [sort].</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void PropagateThemeArray(ArrayList list, bool sort = true)
        {
            if (list == null)
            {
                throw new ArgumentNullException();
            }

            foreach (string theme in KryptonThemeManager._supportedThemes)
            {
                list.Add(theme);
            }

            if (sort)
            {
                list.Sort();
            }
        }

        /// <summary>
        /// Propagates the theme ComboBox.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void PropagateThemeComboBox(KryptonComboBox target, ArrayList list)
        {
            if (list == null)
            {
                throw new ArgumentNullException();
            }
            else if (list.Count <= 0)
            {
                ExtendedKryptonMessageBox.Show($"Error, there is no items contained in the array.", "No items available", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (string theme in list)
            {
                target.Items.Add(theme);
            }
        }

        /// <summary>
        /// Gets the current style item text.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <returns></returns>
        public static string GetCurrentStyleItemText(KryptonComboBox target)
        {
            return target.Text;
        }

        /// <summary>
        /// Switches the theme style.
        /// </summary>
        /// <param name="mode">The mode.</param>
        /// <param name="manager">The manager.</param>
        public static void SwitchThemeStyle(PaletteMode mode, KryptonManager manager)
        {
            switch (mode)
            {
                case PaletteMode.Global:
                    manager.GlobalPaletteMode = (PaletteModeManager)PaletteMode.Global;
                    break;
                case PaletteMode.ProfessionalSystem:
                    manager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
                    break;
                case PaletteMode.ProfessionalOffice2003:
                    manager.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
                    break;
                case PaletteMode.Office2007Blue:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
                    break;
                case PaletteMode.Office2007Silver:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
                    break;
                case PaletteMode.Office2007White:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2007White;
                    break;
                case PaletteMode.Office2007Black:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2007Black;
                    break;
                case PaletteMode.Office2010Blue:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
                    break;
                case PaletteMode.Office2010Silver:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
                    break;
                case PaletteMode.Office2010White:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2010White;
                    break;
                case PaletteMode.Office2010Black:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
                    break;
                case PaletteMode.Office2013:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2013;
                    break;
                case PaletteMode.Office2013White:
                    manager.GlobalPaletteMode = PaletteModeManager.Office2013White;
                    break;
                case PaletteMode.Office365Black:
                    manager.GlobalPaletteMode = PaletteModeManager.Office365Black;
                    break;
                case PaletteMode.Office365Blue:
                    manager.GlobalPaletteMode = PaletteModeManager.Office365Blue;
                    break;
                case PaletteMode.Office365Silver:
                    manager.GlobalPaletteMode = PaletteModeManager.Office365Silver;
                    break;
                case PaletteMode.Office365White:
                    manager.GlobalPaletteMode = PaletteModeManager.Office365White;
                    break;
                case PaletteMode.SparkleBlue:
                    manager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
                    break;
                case PaletteMode.SparkleOrange:
                    manager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
                    break;
                case PaletteMode.SparklePurple:
                    manager.GlobalPaletteMode = PaletteModeManager.SparklePurple;
                    break;
                case PaletteMode.Custom:
                    manager.GlobalPaletteMode = PaletteModeManager.Custom;
                    break;
            }
        }

        /// <summary>
        /// Gets the palette mode.
        /// </summary>
        /// <param name="themeName">Name of the theme.</param>
        /// <returns></returns>
        public static PaletteMode GetPaletteMode(string themeName)
        {
            if (themeName == "Custom")
            {
                return PaletteMode.Custom;
            }
            else if (themeName == "Global")
            {
                return PaletteMode.Global;
            }
            else if (themeName == "Professional - System")
            {
                return PaletteMode.ProfessionalSystem;
            }
            else if (themeName == "Professional - Office 2003")
            {
                return PaletteMode.ProfessionalOffice2003;
            }
            else if (themeName == "Office 2007 - Black")
            {
                return PaletteMode.Office2007Black;
            }
            else if (themeName == "Office 2007 - Blue")
            {
                return PaletteMode.Office2007Blue;
            }
            else if (themeName == "Office 2007 - Silver")
            {
                return PaletteMode.Office2007Silver;
            }
            else if (themeName == "Office 2007 - White")
            {
                return PaletteMode.Office2007White;
            }
            else if (themeName == "Office 2010 - Black")
            {
                return PaletteMode.Office2010Black;
            }
            else if (themeName == "Office 2010 - Blue")
            {
                return PaletteMode.Office2010Blue;
            }
            else if (themeName == "Office 2010 - Silver")
            {
                return PaletteMode.Office2010Silver;
            }
            else if (themeName == "Office 2010 - White")
            {
                return PaletteMode.Office2010White;
            }
            else if (themeName == "Office 2013")
            {
                return PaletteMode.Office2013;
            }
            else if (themeName == "Office 2013 - White")
            {
                return PaletteMode.Office2013White;
            }
            else if (themeName == "Office 365 - Black")
            {
                return PaletteMode.Office365Black;
            }
            else if (themeName == "Office 365 - Blue")
            {
                return PaletteMode.Office365Blue;
            }
            else if (themeName == "Office 365 - Silver")
            {
                return PaletteMode.Office365Silver;
            }
            else if (themeName == "Office 365 - White")
            {
                return PaletteMode.Office365White;
            }
            else if (themeName == "Sparkle - Blue")
            {
                return PaletteMode.SparkleBlue;
            }
            else if (themeName == "Sparkle - Orange")
            {
                return PaletteMode.SparkleOrange;
            }
            else if (themeName == "Sparkle - Purple")
            {
                return PaletteMode.SparklePurple;
            }

            return PaletteMode.Office2010Blue;
        }
        #endregion
    }
}