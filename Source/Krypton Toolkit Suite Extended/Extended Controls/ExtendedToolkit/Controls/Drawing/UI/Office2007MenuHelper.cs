#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.Controls.Drawing.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.Drawing.UI
{
    internal partial class Office2007MenuHelper : KryptonForm
    {
        #region Designer Code
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

        // Define the CS_DROPSHADOW constant
        private const int CS_DROPSHADOW = 0x00020000;

        // Override the CreateParams property
        protected override CreateParams CreateParams
        {
            get
            {
                System.Version OSVer = System.Environment.OSVersion.Version;
                //Check OS Before using XP drop shadow
                CreateParams cp = base.CreateParams;

                if (OSVer.Major == 5)
                {
                    //Feature Present?, more thant win2000?
                    if ((OSVer.Minor > 0) && (OSFeature.IsPresent(SystemParameter.DropShadow)))
                    {
                        cp.ClassStyle |= CS_DROPSHADOW;
                    }
                }
                else if (OSVer.Major >= 5)
                {
                    //Feature Present?
                    if (OSFeature.IsPresent(SystemParameter.DropShadow))
                    {
                        cp.ClassStyle |= CS_DROPSHADOW;
                    }
                }
                else
                {
                }

                return cp;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.office2007ColourPlate1 = new Office2007ColourPlate();
            this.SuspendLayout();
            // 
            // office2007ColorPlate1
            // 
            this.office2007ColourPlate1.Location = new System.Drawing.Point(0, 0);
            this.office2007ColourPlate1.Name = "office2007ColourPlate1";
            this.office2007ColourPlate1.SelectedColour = System.Drawing.Color.Black;
            this.office2007ColourPlate1.Size = new System.Drawing.Size(155, 143);
            this.office2007ColourPlate1.TabIndex = 0;
            this.office2007ColourPlate1.SelectedColourChanged += new System.EventHandler(this.office2007ColourPlate1_SelectedColourChanged);
            this.office2007ColourPlate1.ColourPaletteSelected += new Office2007ColourPlate.ColourPaletteSelectedHandler(this.office2007ColourPlate1_ColourPaletteSelected);
            // 
            // Office2007MenuHelper
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(155, 143);
            this.Controls.Add(this.office2007ColourPlate1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Office2007MenuHelper";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Office2007MenuHelper";
            this.Deactivate += new System.EventHandler(this.Office2007MenuHelper_Deactivate);
            this.Shown += new System.EventHandler(this.Office2007MenuHelper_Shown);
            this.Leave += new System.EventHandler(this.Office2007MenuHelper_Leave);
            this.ResumeLayout(false);

        }

        #endregion

        private Office2007ColourPlate office2007ColourPlate1;
        #endregion

        private Control _parentControl;

        private bool _freeze = false;
        public bool Freeze
        {
            get { return _freeze; }
            set { _freeze = value; }
        }

        public Office2007ColourPlate ColourPlate
        {
            get { return this.office2007ColourPlate1; }
        }

        public Office2007MenuHelper()
        {
            InitializeComponent();
        }

        public void Show(Control parent, Point location)
        {
            _parentControl = parent;
            this.Location = parent.PointToScreen(location);
            this.Show();
        }

        public new void Hide()
        {
            base.Hide();
            if (_parentControl != null)
            {
                Form parentForm = _parentControl.FindForm();
                if (parentForm != null)
                {
                    parentForm.BringToFront();
                }
            }
        }

        private void Office2007MenuHelper_Deactivate(object sender, EventArgs e)
        {
            if (!_freeze)
            {
                Hide();
            }
        }

        private void Office2007MenuHelper_Leave(object sender, EventArgs e)
        {
            if (!_freeze)
            {
                Hide();
            }
        }

        private void office2007ColourPlate1_SelectedColourChanged(object sender, EventArgs e)
        {
            if (!_freeze)
            {
                Hide();
            }
        }

        private DialogResult office2007ColourPlate1_ColourPaletteSelected(ref Color color)
        {
            _freeze = true;
            try
            {
                ColorDialog dlg = new ColorDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    color = dlg.Color;
                    _freeze = false;
                    return DialogResult.OK;
                }
            }
            finally
            {
                _freeze = false;
            }
            return DialogResult.Cancel;
        }

        private void Office2007MenuHelper_Shown(object sender, EventArgs e)
        {

        }

    }
}