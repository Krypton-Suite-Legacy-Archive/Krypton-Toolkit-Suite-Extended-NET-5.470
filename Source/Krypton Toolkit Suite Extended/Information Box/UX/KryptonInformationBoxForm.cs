using ComponentFactory.Krypton.Toolkit;

namespace InformationBox.UX
{
    public class KryptonInformationBoxForm : KryptonForm
    {
        private KryptonCheckBox kchkDoNotShow;
        private KryptonPanel kpnlButtons;
        private KryptonPanel kpnlForm;
        private KryptonPanel kpnlMain;
        private KryptonPanel knplIcon;
        private System.Windows.Forms.PictureBox pbIcon;
        private KryptonLabel klblTitle;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kpnlTest;
        private KryptonPanel kpnlScrollText;
        private KryptonLabel kryptonLabel1;
        private KryptonPanel kpnlBottom;

        private void InitializeComponent()
        {
            this.kpnlBottom = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kchkDoNotShow = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kpnlButtons = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kpnlForm = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kpnlMain = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.knplIcon = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.kpnlTest = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kpnlScrollText = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klblTitle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBottom)).BeginInit();
            this.kpnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlForm)).BeginInit();
            this.kpnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlMain)).BeginInit();
            this.kpnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knplIcon)).BeginInit();
            this.knplIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlTest)).BeginInit();
            this.kpnlTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlScrollText)).BeginInit();
            this.kpnlScrollText.SuspendLayout();
            this.SuspendLayout();
            // 
            // kpnlBottom
            // 
            this.kpnlBottom.Controls.Add(this.kchkDoNotShow);
            this.kpnlBottom.Controls.Add(this.kpnlButtons);
            this.kpnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpnlBottom.Location = new System.Drawing.Point(0, 135);
            this.kpnlBottom.Name = "kpnlBottom";
            this.kpnlBottom.Size = new System.Drawing.Size(487, 88);
            this.kpnlBottom.TabIndex = 0;
            // 
            // kchkDoNotShow
            // 
            this.kchkDoNotShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.kchkDoNotShow.Location = new System.Drawing.Point(0, 0);
            this.kchkDoNotShow.Name = "kchkDoNotShow";
            this.kchkDoNotShow.Size = new System.Drawing.Size(487, 24);
            this.kchkDoNotShow.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kchkDoNotShow.TabIndex = 1;
            this.kchkDoNotShow.Values.Text = "kryptonCheckBox1";
            // 
            // kpnlButtons
            // 
            this.kpnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpnlButtons.Location = new System.Drawing.Point(0, 30);
            this.kpnlButtons.Name = "kpnlButtons";
            this.kpnlButtons.Size = new System.Drawing.Size(487, 58);
            this.kpnlButtons.TabIndex = 0;
            // 
            // kpnlForm
            // 
            this.kpnlForm.Controls.Add(this.kpnlMain);
            this.kpnlForm.Controls.Add(this.klblTitle);
            this.kpnlForm.Controls.Add(this.panel1);
            this.kpnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlForm.Location = new System.Drawing.Point(0, 0);
            this.kpnlForm.Name = "kpnlForm";
            this.kpnlForm.Size = new System.Drawing.Size(487, 135);
            this.kpnlForm.TabIndex = 1;
            // 
            // kpnlMain
            // 
            this.kpnlMain.Controls.Add(this.knplIcon);
            this.kpnlMain.Controls.Add(this.kpnlTest);
            this.kpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlMain.Location = new System.Drawing.Point(0, 24);
            this.kpnlMain.Name = "kpnlMain";
            this.kpnlMain.Size = new System.Drawing.Size(487, 108);
            this.kpnlMain.TabIndex = 2;
            // 
            // knplIcon
            // 
            this.knplIcon.Controls.Add(this.pbIcon);
            this.knplIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.knplIcon.Location = new System.Drawing.Point(0, 0);
            this.knplIcon.Name = "knplIcon";
            this.knplIcon.Size = new System.Drawing.Size(100, 108);
            this.knplIcon.TabIndex = 0;
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbIcon.Location = new System.Drawing.Point(18, 17);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(64, 64);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // kpnlTest
            // 
            this.kpnlTest.Controls.Add(this.kpnlScrollText);
            this.kpnlTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpnlTest.Location = new System.Drawing.Point(0, 0);
            this.kpnlTest.Name = "kpnlTest";
            this.kpnlTest.Size = new System.Drawing.Size(487, 108);
            this.kpnlTest.TabIndex = 1;
            // 
            // kpnlScrollText
            // 
            this.kpnlScrollText.AutoScroll = true;
            this.kpnlScrollText.Controls.Add(this.kryptonLabel1);
            this.kpnlScrollText.Dock = System.Windows.Forms.DockStyle.Right;
            this.kpnlScrollText.Location = new System.Drawing.Point(122, 0);
            this.kpnlScrollText.Name = "kpnlScrollText";
            this.kpnlScrollText.Size = new System.Drawing.Size(365, 108);
            this.kpnlScrollText.TabIndex = 0;
            // 
            // klblTitle
            // 
            this.klblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.klblTitle.Location = new System.Drawing.Point(0, 0);
            this.klblTitle.Name = "klblTitle";
            this.klblTitle.Size = new System.Drawing.Size(487, 24);
            this.klblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTitle.TabIndex = 1;
            this.klblTitle.Values.Text = "kryptonLabel1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 3);
            this.panel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.AutoSize = false;
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(365, 108);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "kryptonLabel1";
            // 
            // KryptonInformationBoxForm
            // 
            this.ClientSize = new System.Drawing.Size(487, 223);
            this.Controls.Add(this.kpnlForm);
            this.Controls.Add(this.kpnlBottom);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonInformationBoxForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.kpnlBottom)).EndInit();
            this.kpnlBottom.ResumeLayout(false);
            this.kpnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlForm)).EndInit();
            this.kpnlForm.ResumeLayout(false);
            this.kpnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlMain)).EndInit();
            this.kpnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.knplIcon)).EndInit();
            this.knplIcon.ResumeLayout(false);
            this.knplIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlTest)).EndInit();
            this.kpnlTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlScrollText)).EndInit();
            this.kpnlScrollText.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}