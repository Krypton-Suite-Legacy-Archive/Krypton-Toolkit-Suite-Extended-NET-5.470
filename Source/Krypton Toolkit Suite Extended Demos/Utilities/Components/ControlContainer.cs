using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities.Components
{
    public class ControlContainer : UserControl
    {
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnlInstructions;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblInstructions;
        private KryptonToolkitSuiteExtendedCore.KryptonPropertyGrid kpgControlProperties;

        private void InitializeComponent()
        {
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kpgControlProperties = new KryptonToolkitSuiteExtendedCore.KryptonPropertyGrid();
            this.kpnlInstructions = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klblInstructions = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlInstructions)).BeginInit();
            this.kpnlInstructions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.kpgControlProperties);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonPanel1);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kpnlInstructions);
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(933, 636);
            this.kryptonSplitContainer1.SplitterDistance = 311;
            this.kryptonSplitContainer1.TabIndex = 0;
            // 
            // kpgControlProperties
            // 
            this.kpgControlProperties.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgControlProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpgControlProperties.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kpgControlProperties.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgControlProperties.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.kpgControlProperties.Location = new System.Drawing.Point(0, 0);
            this.kpgControlProperties.Name = "kpgControlProperties";
            this.kpgControlProperties.Size = new System.Drawing.Size(311, 636);
            this.kpgControlProperties.TabIndex = 0;
            // 
            // kpnlInstructions
            // 
            this.kpnlInstructions.Controls.Add(this.klblInstructions);
            this.kpnlInstructions.Dock = System.Windows.Forms.DockStyle.Top;
            this.kpnlInstructions.Location = new System.Drawing.Point(0, 0);
            this.kpnlInstructions.Name = "kpnlInstructions";
            this.kpnlInstructions.Size = new System.Drawing.Size(617, 113);
            this.kpnlInstructions.TabIndex = 1;
            // 
            // klblInstructions
            // 
            this.klblInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klblInstructions.Location = new System.Drawing.Point(0, 0);
            this.klblInstructions.Name = "klblInstructions";
            this.klblInstructions.Size = new System.Drawing.Size(617, 113);
            this.klblInstructions.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblInstructions.TabIndex = 0;
            this.klblInstructions.Values.Text = "kryptonLabel1";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 113);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(617, 523);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // ControlContainer
            // 
            this.Controls.Add(this.kryptonSplitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ControlContainer";
            this.Size = new System.Drawing.Size(933, 636);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlInstructions)).EndInit();
            this.kpnlInstructions.ResumeLayout(false);
            this.kpnlInstructions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}