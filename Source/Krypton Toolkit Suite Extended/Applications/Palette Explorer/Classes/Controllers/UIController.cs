#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using PaletteExplorer.Controls;
using PaletteExplorer.Enumerations;
using System.Windows.Forms;

namespace PaletteExplorer.Classes.Controllers
{
    public class UIController
    {
        #region Constructors
        public UIController()
        {

        }
        #endregion

        #region Methods        
        /// <summary>
        /// Controls the circular PictureBox control view.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="customColours">The custom colours.</param>
        /// <param name="customTextColours">The custom text colours.</param>
        /// <param name="noCustomColours">The no custom colours.</param>
        /// <param name="normal">The normal.</param>
        public static void ControlCircularPictureBoxControlView(CircularPictureBoxControl control, ToolStripMenuItem customColours, ToolStripMenuItem customTextColours, ToolStripMenuItem noCustomColours, ToolStripMenuItem normal)
        {
            if (customColours.Checked)
            {
                ChangeViewTypes(ViewLayoutType.CUSTOMCOLOURVIEW, customColours, customTextColours, noCustomColours, normal);

                control.ChangeViewLayout(ViewLayoutType.CUSTOMCOLOURVIEW);
            }
            else if (customTextColours.Checked)
            {
                ChangeViewTypes(ViewLayoutType.CUSTOMTEXTCOLOURVIEW, customColours, customTextColours, noCustomColours, normal);

                control.ChangeViewLayout(ViewLayoutType.CUSTOMTEXTCOLOURVIEW);
            }
            else if (noCustomColours.Checked)
            {
                ChangeViewTypes(ViewLayoutType.NOCUSTOMCOLOURS, customColours, customTextColours, noCustomColours, normal);

                control.ChangeViewLayout(ViewLayoutType.NOCUSTOMCOLOURS);
            }
            else if (normal.Checked)
            {
                ChangeViewTypes(ViewLayoutType.NORMALVIEW, customColours, customTextColours, noCustomColours, normal);

                control.ChangeViewLayout(ViewLayoutType.NORMALVIEW);
            }
        }

        /// <summary>
        /// Controls the standard PictureBox control view.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="customColours">The custom colours.</param>
        /// <param name="customTextColours">The custom text colours.</param>
        /// <param name="noCustomColours">The no custom colours.</param>
        /// <param name="normal">The normal.</param>
        public static void ControlStandardPictureBoxControlView(StandardPictureBoxControl control, ToolStripMenuItem customColours, ToolStripMenuItem customTextColours, ToolStripMenuItem noCustomColours, ToolStripMenuItem normal)
        {

        }

        /// <summary>
        /// Changes the view types.
        /// </summary>
        /// <param name="layoutType">Type of the layout.</param>
        /// <param name="customColours">The custom colours.</param>
        /// <param name="customTextColours">The custom text colours.</param>
        /// <param name="noCustomColours">The no custom colours.</param>
        /// <param name="normal">The normal.</param>
        private static void ChangeViewTypes(ViewLayoutType layoutType, ToolStripMenuItem customColours, ToolStripMenuItem customTextColours, ToolStripMenuItem noCustomColours, ToolStripMenuItem normal)
        {
            switch (layoutType)
            {
                case ViewLayoutType.CUSTOMCOLOURVIEW:
                    customColours.Checked = true;

                    customTextColours.Checked = false;

                    noCustomColours.Checked = false;

                    normal.Checked = false;
                    break;
                case ViewLayoutType.CUSTOMTEXTCOLOURVIEW:
                    customColours.Checked = false;

                    customTextColours.Checked = true;

                    noCustomColours.Checked = false;

                    normal.Checked = false;
                    break;
                case ViewLayoutType.NORMALVIEW:
                    customColours.Checked = false;

                    customTextColours.Checked = false;

                    noCustomColours.Checked = false;

                    normal.Checked = true;
                    break;
                case ViewLayoutType.NOCUSTOMCOLOURS:
                    customColours.Checked = false;

                    customTextColours.Checked = false;

                    noCustomColours.Checked = true;

                    normal.Checked = false;
                    break;
            }
        }
        #endregion
    }
}