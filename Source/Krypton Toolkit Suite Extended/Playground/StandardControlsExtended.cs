using ComponentFactory.Krypton.Toolkit;
using System;

namespace Playground
{
    public class StandardControlsExtended : KryptonForm
    {
        private KryptonManager kryptonManager1;
        private System.ComponentModel.IContainer components;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.SuspendLayout();
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // StandardControlsExtended
            // 
            this.ClientSize = new System.Drawing.Size(1369, 636);
            this.Name = "StandardControlsExtended";
            this.Load += new System.EventHandler(this.StandardControlsExtended_Load);
            this.ResumeLayout(false);

        }

        private void StandardControlsExtended_Load(object sender, EventArgs e)
        {

        }
    }
}