using ComponentFactory.Krypton.Toolkit;

namespace KryptonExtendedToolkit.ExtendedToolkit.SystemDialogs
{
    public partial class KryptonSaveFileDialog : KryptonForm
    {
        private Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser explorerBrowser1;
        private KryptonBreadCrumb kryptonBreadCrumb1;
        private KryptonComboBox kryptonComboBox1;
        private KryptonTextBox kryptonTextBox1;
        private KryptonLabel kryptonLabel1;
        private KryptonPanel kpnlBackground;

        private void InitializeComponent()
        {
            this.kpnlBackground = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.explorerBrowser1 = new Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonBreadCrumb1 = new ComponentFactory.Krypton.Toolkit.KryptonBreadCrumb();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).BeginInit();
            this.kpnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonBreadCrumb1)).BeginInit();
            this.SuspendLayout();
            // 
            // kpnlBackground
            // 
            this.kpnlBackground.Controls.Add(this.kryptonBreadCrumb1);
            this.kpnlBackground.Controls.Add(this.kryptonComboBox1);
            this.kpnlBackground.Controls.Add(this.kryptonTextBox1);
            this.kpnlBackground.Controls.Add(this.kryptonLabel1);
            this.kpnlBackground.Controls.Add(this.explorerBrowser1);
            this.kpnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlBackground.Location = new System.Drawing.Point(0, 0);
            this.kpnlBackground.Name = "kpnlBackground";
            this.kpnlBackground.Size = new System.Drawing.Size(813, 477);
            this.kpnlBackground.TabIndex = 0;
            // 
            // explorerBrowser1
            // 
            this.explorerBrowser1.Location = new System.Drawing.Point(12, 37);
            this.explorerBrowser1.Name = "explorerBrowser1";
            this.explorerBrowser1.PropertyBagName = "Microsoft.WindowsAPICodePack.Controls.WindowsForms.ExplorerBrowser";
            this.explorerBrowser1.Size = new System.Drawing.Size(789, 378);
            this.explorerBrowser1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 422);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(88, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "File Name:";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(107, 422);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(388, 29);
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.TabIndex = 2;
            this.kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox1.DropDownWidth = 300;
            this.kryptonComboBox1.Location = new System.Drawing.Point(501, 424);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(300, 27);
            this.kryptonComboBox1.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox1.TabIndex = 3;
            // 
            // kryptonBreadCrumb1
            // 
            this.kryptonBreadCrumb1.AutoSize = false;
            this.kryptonBreadCrumb1.Location = new System.Drawing.Point(12, 3);
            this.kryptonBreadCrumb1.Name = "kryptonBreadCrumb1";
            // 
            // 
            // 
            this.kryptonBreadCrumb1.RootItem.ShortText = "Root";
            this.kryptonBreadCrumb1.Size = new System.Drawing.Size(789, 28);
            this.kryptonBreadCrumb1.TabIndex = 4;
            // 
            // KryptonSaveFileDialog
            // 
            this.ClientSize = new System.Drawing.Size(813, 477);
            this.Controls.Add(this.kpnlBackground);
            this.Name = "KryptonSaveFileDialog";
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBackground)).EndInit();
            this.kpnlBackground.ResumeLayout(false);
            this.kpnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonBreadCrumb1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}