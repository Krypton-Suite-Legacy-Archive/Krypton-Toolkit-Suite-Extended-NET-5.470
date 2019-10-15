using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedColourControls.UX
{
    public class ScreenColourPicker : KryptonForm
    {
        #region Designer Code

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ScreenColourPicker
            // 
            this.ClientSize = new System.Drawing.Size(477, 507);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScreenColourPicker";
            this.Text = "Screen Colour Picker";
            this.ResumeLayout(false);

        }
        #endregion

        #region Constructor
        public ScreenColourPicker()
        {
            InitializeComponent();
        }
        #endregion
    }
}