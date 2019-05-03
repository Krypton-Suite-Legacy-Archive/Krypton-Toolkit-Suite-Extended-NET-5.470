#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;

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