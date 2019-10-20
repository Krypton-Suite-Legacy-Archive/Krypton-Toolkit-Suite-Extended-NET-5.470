using ComponentFactory.Krypton.Toolkit;
using KryptonToolkitSuiteExtendedCore;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Utilities.Components
{
    public class ControlContainer : UserControl
    {
        #region Designer Code
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnlButtons;
        private Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private KryptonToolkitSuiteExtendedCore.KryptonPropertyGrid kpgControlProperties;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnlInstructions;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtnClose;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel klblInstructions;

        private void InitializeComponent()
        {
            this.kpnlButtons = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.kpgControlProperties = new KryptonToolkitSuiteExtendedCore.KryptonPropertyGrid();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kpnlInstructions = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.klblInstructions = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbtnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlButtons)).BeginInit();
            this.kpnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlInstructions)).BeginInit();
            this.kpnlInstructions.SuspendLayout();
            this.SuspendLayout();
            // 
            // kpnlButtons
            // 
            this.kpnlButtons.Controls.Add(this.kbtnClose);
            this.kpnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kpnlButtons.Location = new System.Drawing.Point(0, 725);
            this.kpnlButtons.Name = "kpnlButtons";
            this.kpnlButtons.Size = new System.Drawing.Size(1196, 50);
            this.kpnlButtons.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 722);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 3);
            this.panel1.TabIndex = 1;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonSplitContainer1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1196, 722);
            this.kryptonPanel1.TabIndex = 2;
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
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonPanel2);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kpnlInstructions);
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1196, 722);
            this.kryptonSplitContainer1.SplitterDistance = 398;
            this.kryptonSplitContainer1.TabIndex = 1;
            // 
            // kpgControlProperties
            // 
            this.kpgControlProperties.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kpgControlProperties.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgControlProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpgControlProperties.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kpgControlProperties.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kpgControlProperties.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(196)))), ((int)(((byte)(216)))));
            this.kpgControlProperties.Location = new System.Drawing.Point(0, 0);
            this.kpgControlProperties.Name = "kpgControlProperties";
            this.kpgControlProperties.Size = new System.Drawing.Size(398, 722);
            this.kpgControlProperties.TabIndex = 0;
            this.kpgControlProperties.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 113);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(793, 609);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // kpnlInstructions
            // 
            this.kpnlInstructions.Controls.Add(this.klblInstructions);
            this.kpnlInstructions.Dock = System.Windows.Forms.DockStyle.Top;
            this.kpnlInstructions.Location = new System.Drawing.Point(0, 0);
            this.kpnlInstructions.Name = "kpnlInstructions";
            this.kpnlInstructions.Size = new System.Drawing.Size(793, 113);
            this.kpnlInstructions.TabIndex = 1;
            // 
            // klblInstructions
            // 
            this.klblInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klblInstructions.Location = new System.Drawing.Point(0, 0);
            this.klblInstructions.Name = "klblInstructions";
            this.klblInstructions.Size = new System.Drawing.Size(793, 113);
            this.klblInstructions.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblInstructions.TabIndex = 0;
            this.klblInstructions.Values.Text = "kryptonLabel1";
            // 
            // kbtnClose
            // 
            this.kbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnClose.Location = new System.Drawing.Point(1091, 11);
            this.kbtnClose.Name = "kbtnClose";
            this.kbtnClose.Size = new System.Drawing.Size(90, 25);
            this.kbtnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnClose.TabIndex = 0;
            this.kbtnClose.Values.Text = "&Close";
            this.kbtnClose.Click += new System.EventHandler(this.kbtnClose_Click);
            // 
            // ControlContainer
            // 
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kpnlButtons);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ControlContainer";
            this.Size = new System.Drawing.Size(1196, 775);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlButtons)).EndInit();
            this.kpnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlInstructions)).EndInit();
            this.kpnlInstructions.ResumeLayout(false);
            this.kpnlInstructions.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private bool _showInstructionsPane;

        private Control _selectedControl;

        private string _instructionsText;

        //private KryptonFormExtended _parent;
        #endregion

        #region Properties
        public bool ShowInstructionsPane { get => _showInstructionsPane; set { _showInstructionsPane = value; Invalidate(); } }

        public Control SelectedControl { get => _selectedControl; set { _selectedControl = value; Invalidate(); } }

        public string InstructionsText { get => _instructionsText; set { _instructionsText = value; Invalidate(); } }

        //public KryptonFormExtended ParentForm { get => _parent; set => _parent = value; }

        public KryptonPropertyGrid PropertyGrid { get => kpgControlProperties; }
        #endregion

        #region Constructors
        public ControlContainer()
        {
            InitializeComponent();

            ShowInstructionsPane = true;

            SelectedControl = null;

            InstructionsText = "To view the properties of a control, just click on the desired control.";

            Dock = DockStyle.Fill;
        }
        #endregion

        #region Methods
        private void ShowInstructionsPanel(bool visible)
        {
            if (visible)
            {
                kpnlInstructions.Size = new Size(kpnlInstructions.Width, 133);
            }
            else
            {
                kpnlInstructions.Size = new Size(kpnlInstructions.Width, 0);
            }
        }

        private void UpdateProperties(Control control)
        {
            if (control != null) PropertyGrid.SelectedObject = control;
        }

        private void SetInstructionsText(string value) => klblInstructions.Text = value;
        #endregion

        #region Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            ShowInstructionsPanel(ShowInstructionsPane);

            UpdateProperties(SelectedControl);

            SetInstructionsText(InstructionsText);

            base.OnPaint(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }
        #endregion

        private void kbtnClose_Click(object sender, EventArgs e)
        {
            ((KryptonForm)TopLevelControl).Close();
        }
    }
}