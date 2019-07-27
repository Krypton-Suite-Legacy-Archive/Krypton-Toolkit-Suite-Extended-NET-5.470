using System.Drawing;
using ComponentFactory.Krypton.Toolkit;

namespace ExtendedDialogs
{
    public class KryptonColourButtonCustomColourDialog : KryptonForm
    {
        #region Designer Code
        private KryptonPanel kryptonPanel1;
        private KryptonButton kbtnOk;
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private ExtendedColourControls.ColourWheel colourWheel1;
        private Cyotek.Windows.Forms.ColorGrid colorGrid1;
        private KryptonButton kbtnCancel;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.colourWheel1 = new ExtendedColourControls.ColourWheel();
            this.colorGrid1 = new Cyotek.Windows.Forms.ColorGrid();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtnOk);
            this.kryptonPanel1.Controls.Add(this.kbtnCancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 395);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(611, 48);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kbtnOk
            // 
            this.kbtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnOk.Location = new System.Drawing.Point(405, 8);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(94, 28);
            this.kbtnOk.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 1;
            this.kbtnOk.Values.Text = "&Ok";
            // 
            // kbtnCancel
            // 
            this.kbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kbtnCancel.Location = new System.Drawing.Point(505, 8);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(94, 28);
            this.kbtnCancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnCancel.TabIndex = 0;
            this.kbtnCancel.Values.Text = "C&ancel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 3);
            this.panel1.TabIndex = 3;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.colorGrid1);
            this.kryptonPanel2.Controls.Add(this.colourWheel1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(611, 392);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // colourWheel1
            // 
            this.colourWheel1.BackColor = System.Drawing.Color.Transparent;
            this.colourWheel1.Location = new System.Drawing.Point(12, 12);
            this.colourWheel1.Name = "colourWheel1";
            this.colourWheel1.Size = new System.Drawing.Size(202, 195);
            this.colourWheel1.TabIndex = 5;
            // 
            // colorGrid1
            // 
            this.colorGrid1.BackColor = System.Drawing.Color.Transparent;
            this.colorGrid1.Location = new System.Drawing.Point(12, 213);
            this.colorGrid1.Name = "colorGrid1";
            this.colorGrid1.Size = new System.Drawing.Size(247, 165);
            this.colorGrid1.TabIndex = 5;
            // 
            // KryptonColourButtonCustomColourDialog
            // 
            this.ClientSize = new System.Drawing.Size(611, 443);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonColourButtonCustomColourDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Variables
        private Color _colour;
        #endregion

        #region Properties
        public Color Colour { get => _colour; set => _colour = value; }
        #endregion

        #region Constructors
        public KryptonColourButtonCustomColourDialog()
        {
            InitializeComponent();
        }

        public KryptonColourButtonCustomColourDialog(Color colour)
        {
            InitializeComponent();
        }
        #endregion
    }
}