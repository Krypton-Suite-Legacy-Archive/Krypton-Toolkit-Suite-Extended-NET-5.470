#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ExtendedControls.ExtendedToolkit.Renderer.Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Renderer.ThemedControls
{
    [ToolboxBitmap(typeof(Label)), ToolboxItem(false)]
    public class ThemedLabel : Label
    {

        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
            }
        }

        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
            }
        }

        public ThemedLabel()
        {

            // Set the SystemEvents class to receive event notification when a user 
            // preference changes, the palette changes, or when display settings change.
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            ToolStripManager.RendererChanged += new EventHandler(ToolStripManager_RendererChanged);

            InitColors();
        }

        private void InitColors()
        {
            try
            //myCustom Renderer
            {
                Office2007Renderer renderer = (Office2007Renderer)ToolStripManager.Renderer;
                ProfessionalColourTable colourTable = (ProfessionalColourTable)renderer.ColorTable;
                //Set Colors
                base.ForeColor = colourTable.MenuItemText;
                base.BackColor = colourTable.ToolStripContentPanelGradientBegin;
            }
            catch (Exception ex)
            {
                //Standard Renderer
                try
                {
                    ToolStripProfessionalRenderer renderer = (ToolStripProfessionalRenderer)ToolStripManager.Renderer;
                    ProfessionalColourTable colourTable = (ProfessionalColourTable)renderer.ColorTable;
                    //Set Colors
                    base.ForeColor = colourTable.GripDark;
                    base.BackColor = colourTable.ToolStripContentPanelGradientBegin;
                }
                catch (Exception ex3)
                {
                    Console.WriteLine(ex3.Message);
                }
                Console.WriteLine(ex.Message);
            }
        }

        private void ToolStripManager_RendererChanged(object sender, EventArgs e)
        {
            InitColors();
            this.Invalidate();
        }

    }

}