#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    public class KryptonPaletteChooserComboBox : ComponentFactory.Krypton.Toolkit.KryptonComboBox
    {
        #region Variables
        private ArrayList _styles = new ArrayList();
        private KryptonManager _manager = new KryptonManager();
        #endregion

        #region Properties
        public KryptonManager ParentKryptonManager { get => _manager; set => _manager = value; }
        #endregion

        public delegate void ChangePaletteEventHandler(object sender, EventArgs e);

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        public event ChangePaletteEventHandler PaletteChanged;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword

        #region Constructor
        public KryptonPaletteChooserComboBox(KryptonManager manager = null)
        {
            if (manager == null)
            {
                manager = new KryptonManager();
            }

            ParentKryptonManager = manager;

            PropagateStylesArray(_styles);

            foreach (string modeStyle in _styles)
            {
                // Add items to list
                Items.Add(modeStyle);
            }

            Text = string.Empty;

            DropDownStyle = ComboBoxStyle.DropDownList;


        }
        #endregion

        #region Methods
        private void PropagateStylesArray(ArrayList list = null)
        {
            if (list == null)
            {
                throw new ArgumentNullException();
            }

            list.Add("Professional - System");

            list.Add("Professional - Office 2003");

            list.Add("Office 2007 - Black");

            list.Add("Office 2007 - Blue");

            list.Add("Office 2007 - Silver");

            list.Add("Office 2007 - White");

            list.Add("Office 2010 - Black");

            list.Add("Office 2010 - Blue");

            list.Add("Office 2010 - Silver");

            list.Add("Office 2010 - White");

            list.Add("Office 365 - Black");

            list.Add("Office 365 - Blue");

            list.Add("Office 365 - Silver");

            list.Add("Office 365 - White");

            list.Add("Sparkle - Blue");

            list.Add("Sparkle - Orange");

            list.Add("Sparkle - Purple");

            //list.Sort()
        }

        public static string GetCurrentStyleItemText()
        {
            KryptonPaletteChooserComboBox kryptonPaletteChooserComboBox = new KryptonPaletteChooserComboBox();

            return kryptonPaletteChooserComboBox.Text;
        }

        public static void SwitchThemeStyle(PaletteMode mode, KryptonManager manager)
        {
            switch (mode)
            {
                case PaletteMode.Global:
                    break;
                case PaletteMode.ProfessionalSystem:
                    break;
                case PaletteMode.ProfessionalOffice2003:
                    break;
                case PaletteMode.Office2007Blue:
                    break;
                case PaletteMode.Office2007Silver:
                    break;
                case PaletteMode.Office2007White:
                    break;
                case PaletteMode.Office2007Black:
                    break;
                case PaletteMode.Office2010Blue:
                    break;
                case PaletteMode.Office2010Silver:
                    break;
                case PaletteMode.Office2010White:
                    break;
                case PaletteMode.Office2010Black:
                    break;
                case PaletteMode.Office2013:
                    break;
                case PaletteMode.Office2013White:
                    break;
                case PaletteMode.Office365Black:
                    break;
                case PaletteMode.Office365Blue:
                    break;
                case PaletteMode.Office365Silver:
                    break;
                case PaletteMode.Office365White:
                    break;
                case PaletteMode.SparkleBlue:
                    break;
                case PaletteMode.SparkleOrange:
                    break;
                case PaletteMode.SparklePurple:
                    break;
                case PaletteMode.Custom:
                    break;
                default:
                    break;
            }
        }
        #endregion
    }

    internal class ChangePaletteEventArgs : EventArgs
    {
        public PaletteModeManager PaletteModeManager { get; set; }
    }
}