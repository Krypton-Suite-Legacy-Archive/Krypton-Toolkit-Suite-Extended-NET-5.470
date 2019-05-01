#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ExtendedControls.ExtendedToolkit.Controls.StandardControls.Buttons;
using ExtendedControls.ExtendedToolkit.Renderer.Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Renderer.ThemedControls
{
    [ToolboxBitmap(typeof(Button)), ToolboxItem(false)]
    public class ThemedButton : CustomButton
    {
        public ThemedButton()
        {
            // Set the SystemEvents class to receive event notification when a user 
            // preference changes, the palette changes, or when display settings change.
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            ToolStripManager.RendererChanged += new EventHandler(ToolStripManager_RendererChanged);

            InitColours();
            ToolStripManager_RendererChanged(this, new EventArgs());
        }

        private void InitColours()
        {
            try
            //myCustom Renderer
            {
                Office2007Renderer renderer = (Office2007Renderer)ToolStripManager.Renderer;
                ProfessionalColourTable _colourTable = (ProfessionalColourTable)renderer.ColorTable;
                //Set Colors
                GradientTop = _colourTable.ToolStripGradientBegin;
                GradientBottom = _colourTable.ToolStripGradientMiddle;
                GradientBorderColour = _colourTable.ToolStripBorder;
                if (GradientBorderColour == Color.White)
                {
                    GradientBorderColour = Color.LightGray;
                }

                this.ForeColor = _colourTable.MenuItemText;
                HotForeColour = _colourTable.MenuItemText;
                PressedForeColour = _colourTable.MenuItemText;
            }
            catch (Exception ex)
            {
                try
                {
                    ToolStripProfessionalRenderer renderer = (ToolStripProfessionalRenderer)ToolStripManager.Renderer;
                    ProfessionalColorTable _colourTable = renderer.ColorTable;
                    //Set Colors
                    GradientTop = _colourTable.ToolStripGradientBegin;
                    GradientBottom = _colourTable.ToolStripGradientMiddle;
                    GradientBorderColour = _colourTable.ToolStripBorder;
                    if (GradientBorderColour == Color.White)
                    {
                        GradientBorderColour = Color.LightGray;
                    }

                    this.ForeColor = _colourTable.SeparatorDark;
                    HotForeColour = _colourTable.SeparatorDark;
                    PressedForeColour = _colourTable.SeparatorDark;
                }
                catch (Exception ex3)
                {
                    Console.WriteLine(ex3.Message);
                }
                Console.WriteLine(ex.Message);
            }
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            try
            {
                InitColours();
            }
            catch
            {
            }
        }

        private void ToolStripManager_RendererChanged(object sender, EventArgs e)
        {
            InitColours();
            this.Invalidate();
        }

    }

}