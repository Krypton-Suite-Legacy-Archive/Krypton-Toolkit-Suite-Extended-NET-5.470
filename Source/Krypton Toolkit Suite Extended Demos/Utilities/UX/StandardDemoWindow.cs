using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace Utilities.UX
{
    public class StandardDemoWindow : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kryptonPanel1;
        private Panel panel1;
        private KryptonPanel kryptonPanel2;
        private KryptonSplitContainer kryptonSplitContainer1;
        private KryptonButton kbtnClose;
        private KryptonPanel kpnlInstructions;
        private KryptonLabel klblInstructions;
        private KryptonToolkitSuiteExtendedCore.KryptonPropertyGrid kpgControlProperties;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandardDemoWindow));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kpgControlProperties = new KryptonToolkitSuiteExtendedCore.KryptonPropertyGrid();
            this.kpnlInstructions = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klblInstructions = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlInstructions)).BeginInit();
            this.kpnlInstructions.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnClose);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 687);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1076, 50);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtnClose
            // 
            this.kbtnClose.AutoSize = true;
            this.kbtnClose.Location = new System.Drawing.Point(974, 8);
            this.kbtnClose.Name = "kbtnClose";
            this.kbtnClose.Size = new System.Drawing.Size(90, 30);
            this.kbtnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnClose.TabIndex = 0;
            this.kbtnClose.Values.Text = "Clos&e";
            this.kbtnClose.Click += new System.EventHandler(this.kbtnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 684);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 3);
            this.panel1.TabIndex = 1;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonSplitContainer1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1076, 684);
            this.kryptonPanel2.TabIndex = 2;
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
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kpnlInstructions);
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1076, 684);
            this.kryptonSplitContainer1.SplitterDistance = 358;
            this.kryptonSplitContainer1.TabIndex = 0;
            // 
            // kpgControlProperties
            // 
            this.kpgControlProperties.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgControlProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpgControlProperties.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kpgControlProperties.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kpgControlProperties.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgControlProperties.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.kpgControlProperties.Location = new System.Drawing.Point(0, 0);
            this.kpgControlProperties.Name = "kpgControlProperties";
            this.kpgControlProperties.Size = new System.Drawing.Size(358, 684);
            this.kpgControlProperties.TabIndex = 0;
            // 
            // kpnlInstructions
            // 
            this.kpnlInstructions.Controls.Add(this.klblInstructions);
            this.kpnlInstructions.Dock = System.Windows.Forms.DockStyle.Top;
            this.kpnlInstructions.Location = new System.Drawing.Point(0, 0);
            this.kpnlInstructions.Name = "kpnlInstructions";
            this.kpnlInstructions.Size = new System.Drawing.Size(713, 113);
            this.kpnlInstructions.TabIndex = 0;
            // 
            // klblInstructions
            // 
            this.klblInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klblInstructions.Location = new System.Drawing.Point(0, 0);
            this.klblInstructions.Name = "klblInstructions";
            this.klblInstructions.Size = new System.Drawing.Size(713, 113);
            this.klblInstructions.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblInstructions.TabIndex = 0;
            this.klblInstructions.Values.Text = "kryptonLabel1";
            // 
            // StandardDemoWindow
            // 
            this.ClientSize = new System.Drawing.Size(1076, 737);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StandardDemoWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlInstructions)).EndInit();
            this.kpnlInstructions.ResumeLayout(false);
            this.kpnlInstructions.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private bool _showInstructions;

        private Control _selectedControl;
        #endregion

        #region Properties
        public bool ShowInstructions { get => _showInstructions; set { _showInstructions = value; Invalidate(); } }

        public Control SelectedControl { get => _selectedControl; set { _selectedControl = value; UpdateSelectedControl(value); } }
        #endregion

        #region Constructor
        public StandardDemoWindow()
        {
            InitializeComponent();

            ShowInstructions = true;

            SelectedControl = null;
        }
        #endregion

        #region Methods
        public void UpdateSelectedControl(Control value) => kpgControlProperties.SelectedObject = value;

        public void UpdateInstructionsText(string text) => klblInstructions.Text = text;

        private void SetInstructionsPanelVisibility(bool visibility) => kpnlInstructions.Visible = visibility;
        #endregion

        private void kbtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            SetInstructionsPanelVisibility(ShowInstructions);

            base.OnPaint(e);
        }
        #endregion
    }
}