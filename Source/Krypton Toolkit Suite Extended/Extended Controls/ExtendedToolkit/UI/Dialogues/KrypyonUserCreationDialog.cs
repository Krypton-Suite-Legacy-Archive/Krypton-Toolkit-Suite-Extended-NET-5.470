using ComponentFactory.Krypton.Toolkit;
using System;

namespace ExtendedControls.ExtendedToolkit.UI.Dialogues
{
    public class KrypyonUserCreationDialog : KryptonForm
    {
        private KryptonPanel kpnlContent;
        private KryptonPanel kpnlControls;
        private System.Windows.Forms.Panel pnlSplitter;

        private void InitializeComponent()
        {
            this.kpnlContent = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kpnlControls = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlSplitter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlControls)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnlContent
            // 
            this.kpnlContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.kpnlContent.Location = new System.Drawing.Point(0, 0);
            this.kpnlContent.Name = "kpnlContent";
            this.kpnlContent.Size = new System.Drawing.Size(705, 457);
            this.kpnlContent.TabIndex = 0;
            // 
            // kpnlControls
            // 
            this.kpnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpnlControls.Location = new System.Drawing.Point(0, 459);
            this.kpnlControls.Name = "kpnlControls";
            this.kpnlControls.Size = new System.Drawing.Size(705, 55);
            this.kpnlControls.TabIndex = 0;
            // 
            // pnlSplitter
            // 
            this.pnlSplitter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSplitter.Location = new System.Drawing.Point(0, 457);
            this.pnlSplitter.Name = "pnlSplitter";
            this.pnlSplitter.Size = new System.Drawing.Size(705, 2);
            this.pnlSplitter.TabIndex = 1;
            // 
            // KrypyonUserCreationDialog
            // 
            this.ClientSize = new System.Drawing.Size(705, 514);
            this.Controls.Add(this.pnlSplitter);
            this.Controls.Add(this.kpnlControls);
            this.Controls.Add(this.kpnlContent);
            this.Name = "KrypyonUserCreationDialog";
            this.Load += new System.EventHandler(this.KrypyonUserCreationDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlControls)).EndInit();
            this.ResumeLayout(false);

        }

        private void KrypyonUserCreationDialog_Load(object sender, EventArgs e)
        {

        }
    }
}