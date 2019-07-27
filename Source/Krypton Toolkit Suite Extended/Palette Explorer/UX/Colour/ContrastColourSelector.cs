using ComponentFactory.Krypton.Toolkit;
using System;

namespace PaletteExplorer.UX.Colour
{
    public class ContrastColourSelector : KryptonForm
    {
        private System.Windows.Forms.Panel panel1;
        private KryptonPanel kryptonPanel2;
        private KryptonComboBox kcmbxColourContrastSelector;
        private KryptonLabel kryptonLabel2;
        private KryptonButton kbtCancel;
        private KryptonButton kbtnOk;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContrastColourSelector));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kbtCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kbtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kcmbxColourContrastSelector = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbxColourContrastSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kbtCancel);
            this.kryptonPanel1.Controls.Add(this.kbtnOk);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 134);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(680, 53);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kbtCancel
            // 
            this.kbtCancel.AutoSize = true;
            this.kbtCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtCancel.Location = new System.Drawing.Point(608, 11);
            this.kbtCancel.Name = "kbtCancel";
            this.kbtCancel.Size = new System.Drawing.Size(60, 30);
            this.kbtCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtCancel.TabIndex = 63;
            this.kbtCancel.Values.Text = "&Cancel";
            this.kbtCancel.Click += new System.EventHandler(this.KbtCancel_Click);
            // 
            // kbtnOk
            // 
            this.kbtnOk.AutoSize = true;
            this.kbtnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.kbtnOk.Enabled = false;
            this.kbtnOk.Location = new System.Drawing.Point(570, 11);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(32, 30);
            this.kbtnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnOk.TabIndex = 62;
            this.kbtnOk.Values.Text = "O&k";
            this.kbtnOk.Click += new System.EventHandler(this.KbtnOk_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 3);
            this.panel1.TabIndex = 3;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kcmbxColourContrastSelector);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(680, 131);
            this.kryptonPanel2.TabIndex = 4;
            // 
            // kcmbxColourContrastSelector
            // 
            this.kcmbxColourContrastSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kcmbxColourContrastSelector.DropDownWidth = 121;
            this.kcmbxColourContrastSelector.Items.AddRange(new object[] {
            "Custom Colours",
            "Custom Text Colours"});
            this.kcmbxColourContrastSelector.Location = new System.Drawing.Point(344, 49);
            this.kcmbxColourContrastSelector.Name = "kcmbxColourContrastSelector";
            this.kcmbxColourContrastSelector.Size = new System.Drawing.Size(327, 31);
            this.kcmbxColourContrastSelector.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbxColourContrastSelector.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kcmbxColourContrastSelector.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbxColourContrastSelector.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kcmbxColourContrastSelector.TabIndex = 55;
            this.kcmbxColourContrastSelector.SelectedIndexChanged += new System.EventHandler(this.KcmbxColourContrastSelector_SelectedIndexChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 46);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(326, 33);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 54;
            this.kryptonLabel2.Values.Text = "Generate Contrast Colours For:";
            // 
            // ContrastColourSelector
            // 
            this.ClientSize = new System.Drawing.Size(680, 187);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ContrastColourSelector";
            this.Load += new System.EventHandler(this.ContrastColourSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kcmbxColourContrastSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #region Constructor
        public ContrastColourSelector()
        {
            InitializeComponent();
        }
        #endregion

        private void ContrastColourSelector_Load(object sender, EventArgs e)
        {

        }

        private void KcmbxColourContrastSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kcmbxColourContrastSelector.Text != "")
            {
                kbtnOk.Enabled = true;
            }
            else
            {
                kbtnOk.Enabled = false;
            }
        }

        private void KbtnOk_Click(object sender, EventArgs e)
        {
            if (kcmbxColourContrastSelector.Text == "Custom Colours")
            {
                ColourContrastTool cccct = new ColourContrastTool(ContrastType.CUSTOMCOLOURS);

                cccct.Show();
            }
            else if (kcmbxColourContrastSelector.Text == "Custom Text Colours")
            {
                ColourContrastTool ccctct = new ColourContrastTool(ContrastType.CUSTOMTEXTCOLOURS);

                ccctct.Show();
            }

            Hide();
        }

        private void KbtCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}