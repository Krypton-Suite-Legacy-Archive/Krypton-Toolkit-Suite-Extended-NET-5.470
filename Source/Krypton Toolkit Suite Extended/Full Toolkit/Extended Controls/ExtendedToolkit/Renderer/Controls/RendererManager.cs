#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ExtendedControls.ExtendedToolkit.Renderer.Classes;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Renderer.Controls
{
    [ToolboxBitmap(typeof(ColorDialog)), ToolboxItem(false)]
    public partial class RendererManager : Component
    {
        #region Inialization
        public RendererManager()
        {
            components = new System.ComponentModel.Container();
            pal = Palette.Office2007Blue;
            rnd = Renderer.Standard;
        }

        public RendererManager(IContainer container)
        {
            container.Add(this);

            components = new System.ComponentModel.Container();
            pal = Palette.Office2007Blue;
            rnd = Renderer.Standard;
        }
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Variables
        private Palette pal = Palette.Office2007Blue;
        private Renderer rnd = Renderer.Standard;


        #endregion

        #region Properties
        public Palette Palettes
        {
            get { return pal; }
            set
            {
                pal = value;
                switch (rnd)
                {
                    case Renderer.Standard:
                        switch (pal)
                        {
                            case Palette.Office2007Blue:
                                ToolStripManager.Renderer = new Office2007Renderer(new Office2007BlueColourTable());
                                break;
                            case Palette.Office2007Black:
                                ToolStripManager.Renderer = new Office2007Renderer(new Office2007BlackColourTable());
                                break;
                            case Palette.Office2007Silver:
                                ToolStripManager.Renderer = new Office2007Renderer(new Office2007SilverColourTable());
                                break;
                            case Palette.AquaGreen:
                                ToolStripManager.Renderer = new Office2007Renderer(new AquaGreenColorTable());
                                break;
                            case Palette.Professional:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripProfessionalRenderer();
                                break;
                            case Palette.System:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripSystemRenderer();
                                break;
                            case Palette.Red:
                                ToolStripManager.Renderer = new Office2007Renderer(new ColourTableRed());
                                break;
                        }
                        break;
                    case Renderer.Flat:
                        switch (pal)
                        {
                            case Palette.Office2007Blue:
                                ToolStripManager.Renderer = new Office2007FlatRenderer(new Office2007BlueColourTable());
                                break;
                            case Palette.Office2007Black:
                                ToolStripManager.Renderer = new Office2007FlatRenderer(new Office2007BlackColourTable());
                                break;
                            case Palette.Office2007Silver:
                                ToolStripManager.Renderer = new Office2007FlatRenderer(new Office2007SilverColourTable());
                                break;
                            case Palette.AquaGreen:
                                ToolStripManager.Renderer = new Office2007FlatRenderer(new AquaGreenColorTable());
                                break;
                            case Palette.Professional:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripProfessionalRenderer();
                                break;
                            case Palette.System:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripSystemRenderer();
                                break;
                            case Palette.Red:
                                ToolStripManager.Renderer = new Office2007FlatRenderer(new ColourTableRed());
                                break;
                        }
                        break;
                    case Renderer.Aqua:
                        switch (pal)
                        {
                            case Palette.Office2007Blue:
                                ToolStripManager.Renderer = new AquaRenderer(new Office2007BlueColourTable());
                                break;
                            case Palette.Office2007Black:
                                ToolStripManager.Renderer = new AquaRenderer(new Office2007BlackColourTable());
                                break;
                            case Palette.Office2007Silver:
                                ToolStripManager.Renderer = new AquaRenderer(new Office2007SilverColourTable());
                                break;
                            case Palette.AquaGreen:
                                ToolStripManager.Renderer = new AquaRenderer(new AquaGreenColorTable());
                                break;
                            case Palette.Professional:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripProfessionalRenderer();
                                break;
                            case Palette.System:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripSystemRenderer();
                                break;
                            case Palette.Red:
                                ToolStripManager.Renderer = new AquaRenderer(new ColourTableRed());
                                break;
                        }
                        break;
                }
                if (ToolStripManager.Renderer.GetType().BaseType == typeof(Office2007Renderer))
                {
                    Office2007Renderer br = (Office2007Renderer)ToolStripManager.Renderer;
                }
            }
        }
        public Renderer Renderers
        {
            get { return rnd; }
            set
            {
                rnd = value;
                switch (rnd)
                {
                    case Renderer.Standard:
                        switch (pal)
                        {
                            case Palette.Office2007Blue:
                                ToolStripManager.Renderer = new Office2007Renderer(new Office2007BlueColourTable());
                                break;
                            case Palette.Office2007Black:
                                ToolStripManager.Renderer = new Office2007Renderer(new Office2007BlackColourTable());
                                break;
                            case Palette.Office2007Silver:
                                ToolStripManager.Renderer = new Office2007Renderer(new Office2007SilverColourTable());
                                break;
                            case Palette.AquaGreen:
                                ToolStripManager.Renderer = new Office2007Renderer(new AquaGreenColorTable());
                                break;
                            case Palette.Professional:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripProfessionalRenderer();
                                break;
                            case Palette.System:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripSystemRenderer();
                                break;
                            case Palette.Red:
                                ToolStripManager.Renderer = new Office2007Renderer(new ColourTableRed());
                                break;
                        }
                        break;
                    case Renderer.Flat:
                        switch (pal)
                        {
                            case Palette.Office2007Blue:
                                ToolStripManager.Renderer = new Office2007FlatRenderer(new Office2007BlueColourTable());
                                break;
                            case Palette.Office2007Black:
                                ToolStripManager.Renderer = new Office2007FlatRenderer(new Office2007BlackColourTable());
                                break;
                            case Palette.Office2007Silver:
                                ToolStripManager.Renderer = new Office2007FlatRenderer(new Office2007SilverColourTable());
                                break;
                            case Palette.AquaGreen:
                                ToolStripManager.Renderer = new Office2007FlatRenderer(new AquaGreenColorTable());
                                break;
                            case Palette.Professional:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripProfessionalRenderer();
                                break;
                            case Palette.System:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripSystemRenderer();
                                break;
                            case Palette.Red:
                                ToolStripManager.Renderer = new Office2007FlatRenderer(new ColourTableRed());
                                break;
                        }
                        break;
                    case Renderer.Aqua:
                        switch (pal)
                        {
                            case Palette.Office2007Blue:
                                ToolStripManager.Renderer = new AquaRenderer(new Office2007BlueColourTable());
                                break;
                            case Palette.Office2007Black:
                                ToolStripManager.Renderer = new AquaRenderer(new Office2007BlackColourTable());
                                break;
                            case Palette.Office2007Silver:
                                ToolStripManager.Renderer = new AquaRenderer(new Office2007SilverColourTable());
                                break;
                            case Palette.AquaGreen:
                                ToolStripManager.Renderer = new AquaRenderer(new AquaGreenColorTable());
                                break;
                            case Palette.Professional:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripProfessionalRenderer();
                                break;
                            case Palette.System:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripSystemRenderer();
                                break;
                            case Palette.Red:
                                ToolStripManager.Renderer = new AquaRenderer(new ColourTableRed());
                                break;
                        }
                        break;
                }
                if (ToolStripManager.Renderer.GetType().BaseType == typeof(Office2007Renderer))
                {
                    Office2007Renderer br = (Office2007Renderer)ToolStripManager.Renderer;
                }
            }
        }
        /*[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        private Office2007Renderer CustomRendererData
        {
            get { return (Office2007Renderer)ToolStripManager.Renderer; }
        }
         */
        #endregion
    }

    public enum Palette
    {
        Office2007Blue,
        Office2007Black,
        Office2007Silver,
        AquaGreen,
        Red,
        Professional,
        System
    }

    public enum Renderer
    {
        Standard,
        Flat,
        Aqua
    }
}