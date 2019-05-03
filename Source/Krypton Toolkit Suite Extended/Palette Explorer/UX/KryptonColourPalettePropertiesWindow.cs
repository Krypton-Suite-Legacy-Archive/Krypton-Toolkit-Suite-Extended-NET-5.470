#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace PaletteExplorer.UX
{
    public class KryptonColourPalettePropertiesWindow : KryptonForm
    {
        #region Designer Code
        private Controls.PalettePropertyGrid ppgColours;

        private void InitializeComponent()
        {
            this.ppgColours = new PaletteExplorer.Controls.PalettePropertyGrid();
            this.SuspendLayout();
            // 
            // ppgColours
            // 
            this.ppgColours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ppgColours.Location = new System.Drawing.Point(0, 0);
            this.ppgColours.Name = "ppgColours";
            this.ppgColours.Size = new System.Drawing.Size(534, 755);
            this.ppgColours.TabIndex = 0;
            // 
            // KryptonColourPalettePropertiesWindow
            // 
            this.ClientSize = new System.Drawing.Size(534, 755);
            this.Controls.Add(this.ppgColours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KryptonColourPalettePropertiesWindow";
            this.ShowInTaskbar = false;
            this.Text = "Colour Properties for - {0}";
            this.ResumeLayout(false);

        }
        #endregion

        #region Constructor
        public KryptonColourPalettePropertiesWindow()
        {
            InitializeComponent();
        }

        public KryptonColourPalettePropertiesWindow(Control control)
        {
            InitializeComponent();

            ppgColours.PalettePropertyGridControl.SelectedObject = control;

            UpdateText("Colour Properties");
        }
        #endregion

        #region Methods
        public void UpdateUI(Control control, string text = null)
        {
            ppgColours.PalettePropertyGridControl.SelectedObject = control;

            if (text != null)
            {
                UpdateText($"Colour Properties for - { text }");
            }
            else
            {
                UpdateText("Colour Properties");
            }
        }

        private void UpdateText(string text)
        {
            Text = text;
        }
        #endregion
    }
}