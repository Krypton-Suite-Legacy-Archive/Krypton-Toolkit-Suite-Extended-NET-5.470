#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ExtendedControls.Base.Code.Colours;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.Colours
{
    public partial class ColourAreaAndSliderUserControl : UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colourSliderControl = new ColourSliderUserControl();
            this.colourAreaControl = new ColourAreaUserControl();
            this.SuspendLayout();
            // 
            // colorSliderControl
            // 
            this.colourSliderControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.colourSliderControl.Location = new System.Drawing.Point(397, 0);
            this.colourSliderControl.Name = "colourSliderControl";
            this.colourSliderControl.Size = new System.Drawing.Size(38, 417);
            this.colourSliderControl.TabIndex = 3;
            this.colourSliderControl.ValueChangedByUser += new System.EventHandler(this.ColourSliderControl_ValueChangedByUser);
            this.colourSliderControl.LightChanged += new System.EventHandler(this.ColourSliderControl_BrightnessChanged);
            // 
            // colorAreaControl
            // 
            this.colourAreaControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.colourAreaControl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.colourAreaControl.Location = new System.Drawing.Point(0, 0);
            this.colourAreaControl.Name = "colourAreaControl";
            this.colourAreaControl.Size = new System.Drawing.Size(382, 417);
            this.colourAreaControl.TabIndex = 2;
            this.colourAreaControl.ValueChangedByUser += new System.EventHandler(this.ColourAreaControl_ValueChangedByUser);
            this.colourAreaControl.HueSaturationChanged += new System.EventHandler(this.ColourAreaControl_HueSaturationChanged);
            // 
            // ColorAreaAndSliderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colourSliderControl);
            this.Controls.Add(this.colourAreaControl);
            this.Name = "ColorAreaAndSliderUserControl";
            this.Size = new System.Drawing.Size(435, 417);
            this.ResumeLayout(false);

        }

        #endregion

        private ColourSliderUserControl colourSliderControl;
        private ColourAreaUserControl colourAreaControl;
        #endregion

        public ColourAreaAndSliderUserControl()
        {
            InitializeComponent();
        }

        private void ColourAreaControl_HueSaturationChanged(object sender, EventArgs e)
        {
            double h, s;
            colourAreaControl.GetHueSaturation(out h, out s);

            colourSliderControl.SetHueSaturation(h, s);
            NotifyColourChanged();
        }

        /// <summary>
        /// Occurs when the user changed the color.
        /// </summary>
        public event EventHandler ColorChanged;

        /// <summary>
        /// Occurs when a value has been changed.
        /// </summary>
        public event EventHandler ValueChangedByUser;

        private void NotifyColourChanged()
        {
            if (ColorChanged != null)
            {
                ColorChanged(this, EventArgs.Empty);
            }
        }

        private void NotifyValueChangedByUser()
        {
            if (ValueChangedByUser != null)
            {
                ValueChangedByUser(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets or sets the color of the selected.
        /// </summary>
        /// <value>The color of the selected.</value>
        public Color SelectedColour
        {
            get
            {
                return colourSliderControl.GetSelectedColour();
            }
            set
            {
                HSLColour hslColour = HSLColour.FromColour(value);

                colourAreaControl.SetHueSaturation(hslColour.PreciseHue, hslColour.PreciseSaturation);

                colourSliderControl.SetHueSaturation(hslColour.PreciseHue, hslColour.PreciseSaturation);

                colourSliderControl.SetLight(hslColour.PreciseLight);

                NotifyColourChanged();
            }
        }

        private void ColourSliderControl_BrightnessChanged(object sender, EventArgs e)
        {
            NotifyColourChanged();
        }

        private void ColourAreaControl_ValueChangedByUser(object sender, EventArgs e)
        {
            NotifyColourChanged();
            NotifyValueChangedByUser();
        }

        private void ColourSliderControl_ValueChangedByUser(object sender, EventArgs e)
        {
            NotifyColourChanged();
            NotifyValueChangedByUser();
        }
    }
}