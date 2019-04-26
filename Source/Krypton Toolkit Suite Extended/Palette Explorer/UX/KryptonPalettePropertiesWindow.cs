using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaletteExplorer.UX
{
    public class KryptonPalettePropertiesWindow : KryptonForm
    {
        #region Designer Code
        private Controls.PalettePropertyGrid ppgPaletteProperties;

        private void InitializeComponent()
        {
            this.ppgPaletteProperties = new PaletteExplorer.Controls.PalettePropertyGrid();
            this.SuspendLayout();
            // 
            // ppgPaletteProperties
            // 
            this.ppgPaletteProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ppgPaletteProperties.Location = new System.Drawing.Point(0, 0);
            this.ppgPaletteProperties.Name = "ppgPaletteProperties";
            this.ppgPaletteProperties.Size = new System.Drawing.Size(534, 755);
            this.ppgPaletteProperties.TabIndex = 0;
            // 
            // KryptonPalettePropertiesWindow
            // 
            this.ClientSize = new System.Drawing.Size(534, 755);
            this.Controls.Add(this.ppgPaletteProperties);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KryptonPalettePropertiesWindow";
            this.ShowInTaskbar = false;
            this.Text = "Palette Properties for - {0}";
            this.ResumeLayout(false);

        }
        #endregion

        #region Constructors
        public KryptonPalettePropertiesWindow()
        {
            InitializeComponent();
        }

        public KryptonPalettePropertiesWindow(KryptonPalette palette)
        {
            InitializeComponent();

            ppgPaletteProperties.PalettePropertyGridControl.SelectedObject = palette;
        }
        #endregion
    }
}