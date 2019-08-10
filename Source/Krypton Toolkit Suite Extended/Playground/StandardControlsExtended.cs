using ComponentFactory.Krypton.Toolkit;
using System;

namespace Playground
{
    public class StandardControlsExtended : KryptonForm
    {
        private KryptonHeaderGroup kryptonHeaderGroup1;

        private void InitializeComponent()
        {
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(150, 150);
            this.kryptonHeaderGroup1.TabIndex = 0;
            // 
            // StandardControlsExtended
            // 
            this.ClientSize = new System.Drawing.Size(1369, 636);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Name = "StandardControlsExtended";
            this.Load += new System.EventHandler(this.StandardControlsExtended_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void StandardControlsExtended_Load(object sender, EventArgs e)
        {

        }
    }
}