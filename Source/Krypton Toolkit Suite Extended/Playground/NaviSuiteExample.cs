using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class NaviSuiteExample : KryptonForm
    {
        private KryptonPanel kryptonPanel1;
        private NaviSuite.Main.Controls.NaviBar naviBar1;
        private System.ComponentModel.IContainer components;
        private NaviSuite.Main.Controls.NaviGroup naviGroup1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.naviBar1 = new NaviSuite.Main.Controls.NaviBar(this.components);
            this.naviGroup1 = new NaviSuite.Main.Controls.NaviGroup(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naviGroup1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1150, 736);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // naviBar1
            // 
            this.naviBar1.ActiveBand = null;
            this.naviBar1.Location = new System.Drawing.Point(0, 0);
            this.naviBar1.Name = "naviBar1";
            this.naviBar1.TabIndex = 0;
            // 
            // naviGroup1
            // 
            this.naviGroup1.Caption = null;
            this.naviGroup1.HeaderContextMenuStrip = null;
            this.naviGroup1.Location = new System.Drawing.Point(0, 0);
            this.naviGroup1.Name = "naviGroup1";
            this.naviGroup1.Padding = new System.Windows.Forms.Padding(1);
            this.naviGroup1.TabIndex = 0;
            // 
            // NaviSuiteExample
            // 
            this.ClientSize = new System.Drawing.Size(1150, 736);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "NaviSuiteExample";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naviGroup1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}