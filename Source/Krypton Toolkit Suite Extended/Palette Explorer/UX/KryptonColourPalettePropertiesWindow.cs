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
using System.Windows.Forms;
using ToolkitSettings.Classes.PaletteExplorer;

namespace PaletteExplorer.UX
{
    public class KryptonColourPalettePropertiesWindow : KryptonForm
    {
        #region Designer Code
        private Controls.PalettePropertyGrid ppgColours;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ppgColours = new PaletteExplorer.Controls.PalettePropertyGrid();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KryptonColourPalettePropertiesWindow_FormClosing);
            this.Load += new System.EventHandler(this.KryptonColourPalettePropertiesWindow_Load);
            this.LocationChanged += new System.EventHandler(this.KryptonColourPalettePropertiesWindow_LocationChanged);
            this.ResumeLayout(false);

        }

        private ToolTip ttInfo;
        private System.ComponentModel.IContainer components;
        #endregion

        #region Variables
        private WindowLocationSettingsManager _locationSettingsManager = new WindowLocationSettingsManager();
        private GeneralPaletteExplorerSettingsManager _generalPaletteExplorerSettingsManager = new GeneralPaletteExplorerSettingsManager();
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

        private void KryptonColourPalettePropertiesWindow_LocationChanged(object sender, EventArgs e)
        {
            ttInfo.SetToolTip(this, $"Current Location: (X: { Location.X.ToString() }, Y: { Location.Y.ToString() })");

            ttInfo.Show($"Current Location: (X: { Location.X.ToString() }, Y: { Location.Y.ToString() })", this, Location.X, Location.Y);

            _locationSettingsManager.SetColourPropertiesWindowLocation(Location);
        }

        private void KryptonColourPalettePropertiesWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _locationSettingsManager.SaveWindowLocationSettings();

            _generalPaletteExplorerSettingsManager.SetShowColourPropertiesPane(false);

            _generalPaletteExplorerSettingsManager.SaveGeneralPaletteExplorerSettings();
        }

        private void KryptonColourPalettePropertiesWindow_Load(object sender, EventArgs e)
        {
            Location = _locationSettingsManager.GetColourPropertiesWindowLocation();

            _generalPaletteExplorerSettingsManager.SetShowColourPropertiesPane(true);

            _generalPaletteExplorerSettingsManager.SaveGeneralPaletteExplorerSettings();
        }
    }
}