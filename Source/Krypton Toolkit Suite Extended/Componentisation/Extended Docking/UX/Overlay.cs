using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace ExtendedDocking
{
    /// <summary>
    /// this is the overlay preview control
    /// </summary>
    internal sealed class Overlay : KryptonForm
    {
        public Overlay()
        {
            InitializeComponent();
        }

        // override Dockstate.
        public new DockStyle Dock;
        public Control DockHostControl;

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
            this.SuspendLayout();
            // 
            // Overlay
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Overlay";
            this.Opacity = 0.3;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Overlay";
            this.ResumeLayout(false);
        }

        #endregion
    }
}