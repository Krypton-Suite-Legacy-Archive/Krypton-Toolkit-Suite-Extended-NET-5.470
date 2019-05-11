#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code.Colours;
using ExtendedControls.ExtendedToolkit.Controls.Colours;
using ExtendedControls.Interfaces.Colours;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.UI.Colours
{
    public partial class ColourEditorForm : KryptonForm
    {
        #region System

        /// <summary>
        /// Required designer variable.
        /// </summary>
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColourEditorForm));
            this.colourEditorControl = new ColourEditorUserControl();
            this.buttonCancel = new KryptonButton();
            this.buttonOK = new KryptonButton();
            this.buttonNoColour = new KryptonButton();
            this.SuspendLayout();
            // 
            // colorEditorControl
            // 
            this.colourEditorControl.AccessibleDescription = null;
            this.colourEditorControl.AccessibleName = null;
            resources.ApplyResources(this.colourEditorControl, "colourEditorControl");
            this.colourEditorControl.BackgroundImage = null;
            this.colourEditorControl.ExternalColourEditorInformationProvider = null;
            this.colourEditorControl.Font = null;
            this.colourEditorControl.MinimumSize = new System.Drawing.Size(372, 398);
            this.colourEditorControl.Name = "colourEditorControl";
            this.colourEditorControl.SelectedColour = System.Drawing.Color.Empty;
            this.colourEditorControl.NeedUpdateUI += new System.EventHandler(this.ColourEditorUserControl1_NeedUpdateUI);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AccessibleDescription = null;
            this.buttonCancel.AccessibleName = null;
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.BackgroundImage = null;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = null;
            this.buttonCancel.Name = "buttonCancel";
            //this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.AccessibleDescription = null;
            this.buttonOK.AccessibleName = null;
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.BackgroundImage = null;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = null;
            this.buttonOK.Name = "buttonOK";
            //this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonNoColor
            // 
            this.buttonNoColour.AccessibleDescription = null;
            this.buttonNoColour.AccessibleName = null;
            resources.ApplyResources(this.buttonNoColour, "buttonNoColour");
            this.buttonNoColour.BackgroundImage = null;
            this.buttonNoColour.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonNoColour.Font = null;
            this.buttonNoColour.Name = "buttonNoColour";
            //this.buttonNoColour.UseVisualStyleBackColor = true;
            this.buttonNoColour.Click += new System.EventHandler(this.ButtonNoColor_Click);
            // 
            // ColorEditorForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.CancelButton = this.buttonCancel;
            this.Controls.Add(this.buttonNoColour);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.colourEditorControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorEditorForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ColourEditorForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColourEditorForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private ColourEditorUserControl colourEditorControl;
        private KryptonButton buttonCancel;
        private KryptonButton buttonOK;
        private KryptonButton buttonNoColour;

        #endregion

        private Color _selectedColor;

#if DEBUG
        public static void Test()
        {
            Color c1 = Color.OrangeRed;
            Color c2 = Color.GreenYellow;
            Color c3 = ColorTranslator.FromHtml(@"#0066CC");
            Color c4 = ColorTranslator.FromHtml(@"#FF0000");

            RGBColour colour01 = new RGBColour(255, 0, 0);
            RGBColour colour02 = new RGBColour(0, 255, 0);
            RGBColour colour03 = new RGBColour(0, 0, 255);

            RGBColour colour04 = new RGBColour(255, 255, 0);
            RGBColour colour05 = new RGBColour(255, 0, 255);
            RGBColour colour06 = new RGBColour(0, 255, 255);

            RGBColour colour07 = new RGBColour(0, 0, 0);
            RGBColour colour08 = new RGBColour(255, 255, 255);

            // --

            //HsbColor hsb01 = HsbColor.FromColor( color01 );
            //HsbColor hsb02 = new HsbColor( 
            //(int)color01.GetHue(), 
            //(int)(color01.GetSaturation()*100), 
            //(int)(color01.GetBrightness()*100) );

            HSLColour hsl02 = HSLColour.FromRGBColour(colour02);
            HSBColour hsb01 = HSBColour.FromRGBColour(colour01);

            //HslColor hsl02 = new HslColor( 
            //    (int)color01.GetHue(), 
            //    (int)(color01.GetSaturation() * 100), 
            //    (int)(color01.GetBrightness() * 100) );

            RGBColour r = hsl02.ToRGBColour();

            RGBColour o1 = new RGBColour(115, 72, 50);
            HSLColour o2 = o1.ToHSLColour();
            RGBColour o3 = o2.ToRGBColour();

            // --

            int i = 0;
        }
#endif

        /// <summary>
        /// Initializes a new instance of the <see cref="ColourEditorForm"/> class.
        /// </summary>
        public ColourEditorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the selected color.
        /// </summary>
        /// <value>The color of the selected.</value>
        [Browsable(false)]
        public Color SelectedColour
        {
            get
            {
                return _selectedColor;
            }
            set
            {
                _selectedColor = value;
                if (!DesignMode)
                {
                    colourEditorControl.SelectedColour = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the external provider.
        /// </summary>
        /// <value>The external provider.</value>
        [Browsable(false)]
        public IExternalColourEditorInformationProvider ExternalColourEditorInformationProvider
        {
            get
            {
                return colourEditorControl.ExternalColourEditorInformationProvider;
            }
            set
            {
                colourEditorControl.ExternalColourEditorInformationProvider = value;
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            _selectedColor = colourEditorControl.SelectedColour;
        }

        private void ButtonNoColor_Click(object sender, EventArgs e)
        {
            _selectedColor = Color.Empty;
        }

        /// <summary>
        /// Gets the store ID.
        /// </summary>
        /// <value>The store ID.</value>
        internal string StoreID
        {
            get
            {
                return string.Format(
                    @"{0}.{1}.{2}",
                    GetType().Name,
                    Name,
                    Text);
            }
        }

        /// <summary>
        /// Handles the Load event of the <see cref="ColourEditorForm"/> control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance 
        /// containing the event data.</param>
        private void ColourEditorForm_Load(object sender, EventArgs e)
        {
            if (ExternalColourEditorInformationProvider != null)
            {
                Width = Convert.ToInt32(
                    ExternalColourEditorInformationProvider.RestorePerUserPerWorkstationValue(
                        StoreID + @".Width",
                        Width.ToString()));
                Height = Convert.ToInt32(
                    ExternalColourEditorInformationProvider.RestorePerUserPerWorkstationValue(
                        StoreID + @".Height",
                        Height.ToString()));
            }
            CenterToParent();

            buttonNoColour.Visible = ExternalColourEditorInformationProvider == null || ExternalColourEditorInformationProvider.AllowNoColourSelectable;
        }

        /// <summary>
        /// Handles the FormClosing event of the <see cref="ColourEditorForm"/> control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.FormClosingEventArgs"/> 
        /// instance containing the event data.</param>
        private void ColourEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ExternalColourEditorInformationProvider != null)
            {
                ExternalColourEditorInformationProvider.SavePerUserPerWorkstationValue(
                    StoreID + @".Width",
                    Width.ToString());
                ExternalColourEditorInformationProvider.SavePerUserPerWorkstationValue(
                    StoreID + @".Height",
                    Height.ToString());
            }
        }

        private void ColourEditorUserControl1_NeedUpdateUI(object sender, EventArgs e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Updates the UI.
        /// </summary>
        private void UpdateUI()
        {
            buttonOK.Enabled = colourEditorControl.SelectedColour != Color.Empty;
        }
    }
}