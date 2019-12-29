using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace Utilities.UX
{
    public class StandardDemoWindow : KryptonForm
    {
        #region Designer Code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandardDemoWindow));
            this.controlContainer1 = new Utilities.Components.ControlContainer();
            this.kbtnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // controlContainer1
            // 
            this.controlContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlContainer1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlContainer1.InstructionsText = "To view the properties of a control, just click on the desired control.";
            this.controlContainer1.Location = new System.Drawing.Point(0, 0);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.ShowInstructionsPane = true;
            this.controlContainer1.Size = new System.Drawing.Size(1076, 737);
            this.controlContainer1.TabIndex = 0;
            // 
            // kbtnClose
            // 
            this.kbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnClose.AutoSize = true;
            this.kbtnClose.Location = new System.Drawing.Point(974, 695);
            this.kbtnClose.Name = "kbtnClose";
            this.kbtnClose.Size = new System.Drawing.Size(90, 30);
            this.kbtnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnClose.TabIndex = 2;
            this.kbtnClose.Values.Text = "Clos&e";
            this.kbtnClose.Click += new System.EventHandler(this.kbtnClose_Click);
            // 
            // StandardDemoWindow
            // 
            this.ClientSize = new System.Drawing.Size(1076, 737);
            this.Controls.Add(this.kbtnClose);
            this.Controls.Add(this.controlContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StandardDemoWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Variables
        private bool _showInstructions;
        private Components.ControlContainer controlContainer1;
        private KryptonButton kbtnClose;
        private Control _selectedControl;
        #endregion

        #region Properties
        public bool ShowInstructions { get => _showInstructions; set { _showInstructions = value; Invalidate(); } }

        //public Control SelectedControl { get => _selectedControl; set { _selectedControl = value; UpdateSelectedControl(value); } }
        #endregion

        #region Constructor
        public StandardDemoWindow()
        {
            InitializeComponent();

            ShowInstructions = true;

            //SelectedControl = null;
        }
        #endregion

        #region Methods
        //public void UpdateSelectedControl(Control value) => kpgControlProperties.SelectedObject = value;

        //public void UpdateInstructionsText(string text) => klblInstructions.Text = text;

        //private void SetInstructionsPanelVisibility(bool visibility) => kpnlInstructions.Visible = visibility;
        #endregion

        private void kbtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            //SetInstructionsPanelVisibility(ShowInstructions);

            base.OnPaint(e);
        }
        #endregion
    }
}