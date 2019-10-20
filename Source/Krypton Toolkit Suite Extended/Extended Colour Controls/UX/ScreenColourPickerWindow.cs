using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedColourControls.UX
{
    public class ScreenColourPickerWindow : KryptonForm
    {
        private Controls.KryptonScreenColourPicker kryptonScreenColourPicker1;
        #region Designer Code

        private void InitializeComponent()
        {
            this.kryptonScreenColourPicker1 = new ExtendedColourControls.Controls.KryptonScreenColourPicker();
            this.SuspendLayout();
            // 
            // kryptonScreenColourPicker1
            // 
            this.kryptonScreenColourPicker1.AutoSize = true;
            this.kryptonScreenColourPicker1.BackColor = System.Drawing.Color.Transparent;
            this.kryptonScreenColourPicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonScreenColourPicker1.Location = new System.Drawing.Point(0, 0);
            this.kryptonScreenColourPicker1.MinimumSize = new System.Drawing.Size(479, 505);
            this.kryptonScreenColourPicker1.Name = "kryptonScreenColourPicker1";
            this.kryptonScreenColourPicker1.Owner = null;
            this.kryptonScreenColourPicker1.SelectedColour = System.Drawing.Color.Empty;
            this.kryptonScreenColourPicker1.Size = new System.Drawing.Size(479, 507);
            this.kryptonScreenColourPicker1.TabIndex = 0;
            // 
            // ScreenColourPickerWindow
            // 
            this.ClientSize = new System.Drawing.Size(477, 507);
            this.Controls.Add(this.kryptonScreenColourPicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScreenColourPickerWindow";
            this.Text = "Screen Colour Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Constructor
        public ScreenColourPickerWindow()
        {
            InitializeComponent();
        }
        #endregion
    }
}