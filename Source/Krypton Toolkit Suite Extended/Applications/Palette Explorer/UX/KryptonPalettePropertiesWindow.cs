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
using System.IO;

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
            this.VisibleChanged += new System.EventHandler(this.KryptonPalettePropertiesWindow_VisibleChanged);
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private bool _viewable;
        #endregion

        #region Property
        public bool Viewable { get => _viewable; set => _viewable = value; }
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

            if (palette.GetCustomisedKryptonPaletteFilePath() != string.Empty)
            {
                UpdateTitle(palette.GetCustomisedKryptonPaletteFilePath());
            }
            else
            {
                Text = "Palette Properties";
            }
        }
        #endregion

        #region Methods
        public void CaptureCurrentPalette(KryptonPalette palette) => ppgPaletteProperties.PalettePropertyGridControl.SelectedObject = palette;

        public void UpdateTitle(string paletteFilePath, bool shortName = true, bool displayExtention = false)
        {
            if (shortName)
            {
                if (displayExtention)
                {
                    string fileNameWithExtension = Path.GetFileName(paletteFilePath);

                    UpdateTitle(fileNameWithExtension);
                }
                else
                {
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(paletteFilePath);

                    UpdateTitle(fileNameWithoutExtension);
                }
            }
            else
            {
                if (displayExtention)
                {
                    UpdateTitle(paletteFilePath);
                }
                else
                {
                    string pathWithoutExtention = PathHelper.GetFullPathWithoutExtension(paletteFilePath);

                    UpdateTitle(pathWithoutExtention);
                }
            }
        }

        private void UpdateTitle(string text)
        {
            Text = $"Palette Properties for - [{ text }]";
        }
        #endregion

        #region Overrides
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            SetViewable(Visible);
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

        private void KryptonPalettePropertiesWindow_VisibleChanged(object sender, EventArgs e)
        {
            SetViewable(Visible);
        }
    }
}