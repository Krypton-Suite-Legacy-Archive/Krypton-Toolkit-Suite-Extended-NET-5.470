using ComponentFactory.Krypton.Toolkit;
using System;

namespace Playground.Componentisation.IOComponents
{
    public class IOControls : KryptonForm
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // IOControls
            // 
            this.ClientSize = new System.Drawing.Size(1257, 617);
            this.Name = "IOControls";
            this.Load += new System.EventHandler(this.IOControls_Load);
            this.ResumeLayout(false);

        }

        private void IOControls_Load(object sender, EventArgs e)
        {

        }
    }
}