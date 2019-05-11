#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.Colours
{
    public partial class ColourSliderUserControl : UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColourSliderUserControl));
            this.arrowControl = new System.Windows.Forms.PictureBox();
            this.colourPanel = new ColourSliderPanel();
            ((System.ComponentModel.ISupportInitialize)(this.arrowControl)).BeginInit();
            this.SuspendLayout();
            // 
            // arrowControl
            // 
            this.arrowControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.arrowControl.Image = ExtendedControls.Properties.Resources.arrowControl_Image;
            this.arrowControl.Location = new System.Drawing.Point(23, 0);
            this.arrowControl.Name = "arrowControl";
            this.arrowControl.Size = new System.Drawing.Size(15, 14);
            this.arrowControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.arrowControl.TabIndex = 1;
            this.arrowControl.TabStop = false;
            this.arrowControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ArrowControl_MouseMove);
            this.arrowControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ArrowControl_MouseClick);
            this.arrowControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ArrowControl_MouseDown);
            // 
            // colorPanel
            // 
            this.colourPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.colourPanel.Location = new System.Drawing.Point(0, 0);
            this.colourPanel.Name = "colorPanel";
            this.colourPanel.Size = new System.Drawing.Size(17, 327);
            this.colourPanel.TabIndex = 0;
            this.colourPanel.ValueChangedByUser += new System.EventHandler(this.ColourPanel_ValueChangedByUser);
            this.colourPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ColourPanel_MouseClick);
            this.colourPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColourPanel_MouseDown);
            this.colourPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColourPanel_MouseMove);
            // 
            // ColorSliderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colourPanel);
            this.Controls.Add(this.arrowControl);
            this.Name = "ColourSliderUserControl";
            this.Size = new System.Drawing.Size(40, 327);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColourSliderUserControl_MouseMove);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorSliderUserControl_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColourSliderUserControl_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.arrowControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox arrowControl;
        private ColourSliderPanel colourPanel;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="ColourSliderUserControl"/> class.
        /// </summary>
        public ColourSliderUserControl()
        {
            InitializeComponent();

            SetStyle(
                ControlStyles.Selectable,
                true);
        }

        /// <summary>
        /// Occurs when the user changed the light.
        /// </summary>
        public event EventHandler LightChanged;

        /// <summary>
        /// Occurs when a value has been changed.
        /// </summary>
        public event EventHandler ValueChangedByUser;

        private void NotifyLightChanged()
        {
            if (LightChanged != null)
            {
                LightChanged(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Notifies the value changed.
        /// </summary>
        private void NotifyValueChangedByUser()
        {
            if (ValueChangedByUser != null)
            {
                ValueChangedByUser(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets the color.
        /// </summary>
        /// <returns></returns>
        public Color GetSelectedColour()
        {
            return colourPanel.GetColourAtY(arrowControl.Location.Y);
        }

        /// <summary>
        /// Sets the hue saturation.
        /// </summary>
        /// <param name="h">The h.</param>
        /// <param name="s">The s.</param>
        public void SetHueSaturation(double h, double s)
        {
            colourPanel.SetHueSaturation(h, s);

            NotifyLightChanged();
        }

        public void SetLight(double l)
        {
            colourPanel.SetLight(l);

            int caretPositionY;
            colourPanel.TranslateLightToCaretPositionY(out caretPositionY, l);

            RepositionArrow(caretPositionY);
            NotifyLightChanged();
        }

        /// <summary>
        /// Repositions the arrow.
        /// </summary>
        /// <param name="offsetY">The offset Y.</param>
        private void RepositionArrow(int offsetY)
        {
            offsetY = Math.Max(0, offsetY);
            offsetY = Math.Min(ClientSize.Height - 1, offsetY);

            arrowControl.Location = new Point(
                arrowControl.Location.X,
                offsetY - (arrowControl.Height / 2));

            double l;
            colourPanel.TranslateCaretPositionYToLight(offsetY, out l);

            colourPanel.SetLight(l);
        }

        private void colorSliderUserControl_MouseClick(object sender, MouseEventArgs e)
        {
            RepositionArrow(e.Location.Y);
            NotifyValueChangedByUser();
        }

        private void ArrowControl_MouseClick(object sender, MouseEventArgs e)
        {
            RepositionArrow(PointToClient(arrowControl.PointToScreen(e.Location)).Y);
            NotifyValueChangedByUser();
        }

        private void ColourPanel_MouseClick(object sender, MouseEventArgs e)
        {
            RepositionArrow(PointToClient(colourPanel.PointToScreen(e.Location)).Y);
            NotifyValueChangedByUser();
        }

        private void ColourSliderUserControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RepositionArrow(e.Location.Y);
                NotifyValueChangedByUser();
            }
        }

        private void ArrowControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RepositionArrow(PointToClient(arrowControl.PointToScreen(e.Location)).Y);
                NotifyValueChangedByUser();
            }
        }

        private void ColourPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RepositionArrow(PointToClient(colourPanel.PointToScreen(e.Location)).Y);
                NotifyValueChangedByUser();
            }
        }

        private void ColourSliderUserControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RepositionArrow(e.Location.Y);
                NotifyValueChangedByUser();
            }
        }

        private void ColourPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RepositionArrow(PointToClient(colourPanel.PointToScreen(e.Location)).Y);
                NotifyValueChangedByUser();
            }
        }

        private void ArrowControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RepositionArrow(PointToClient(arrowControl.PointToScreen(e.Location)).Y);
                NotifyValueChangedByUser();
            }
        }

        private void ColourPanel_ValueChangedByUser(object sender, EventArgs e)
        {
            NotifyValueChangedByUser();
        }
    }
}