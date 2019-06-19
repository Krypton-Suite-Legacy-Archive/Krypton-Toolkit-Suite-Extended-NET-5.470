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
using ToolkitSettings.Classes.PaletteExplorer.Properties;

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
            this.VisibleChanged += new System.EventHandler(this.KryptonColourPalettePropertiesWindow_VisibleChanged);
            this.ResumeLayout(false);

        }

        private ToolTip ttInfo;
        private System.ComponentModel.IContainer components;
        #endregion

        #region Variables
        private bool _viewable;
        private Timer _uiUpdateTimer = null;
        private ColourPropertyWindowSettingsManager _colourPropertyWindowSettingsManager = new ColourPropertyWindowSettingsManager();
        private WindowLocationSettingsManager _locationSettingsManager = new WindowLocationSettingsManager();
        private GeneralPaletteExplorerSettingsManager _generalPaletteExplorerSettingsManager = new GeneralPaletteExplorerSettingsManager();
        #endregion

        #region Property
        public bool Viewable { get => _viewable; set => _viewable = value; }
        #endregion

        #region Constructor
        public KryptonColourPalettePropertiesWindow()
        {
            InitializeComponent();

            SetupUITimer();
        }

        public KryptonColourPalettePropertiesWindow(Control control)
        {
            InitializeComponent();

            SetupUITimer();

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

        #region Event Handlers
        private void UIUpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateUI(_colourPropertyWindowSettingsManager.GetHotColourControl(), _colourPropertyWindowSettingsManager.GetColourControlText());
        }

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


        private void KryptonColourPalettePropertiesWindow_VisibleChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Overrides
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
        }
        #endregion

        #region Methods
        private void SetupUITimer()
        {
            _uiUpdateTimer = new Timer();

            _uiUpdateTimer.Enabled = true;

            _uiUpdateTimer.Interval = 500;

            _uiUpdateTimer.Tick += UIUpdateTimer_Tick;
        }
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the Viewable.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetViewable(bool value) => Viewable = value;

        /// <summary>
        /// Gets the Viewable.
        /// </summary>
        /// <returns>The value of Viewable.</returns>
        public bool GetViewable() => Viewable;
        #endregion
    }
}