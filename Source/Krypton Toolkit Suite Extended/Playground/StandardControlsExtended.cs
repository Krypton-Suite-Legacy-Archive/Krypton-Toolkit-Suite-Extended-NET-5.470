using ComponentFactory.Krypton.Toolkit;
using System;

namespace Playground
{
    public class StandardControlsExtended : KryptonForm
    {
        private KryptonManager kryptonManager1;
        private ExtendedStandardControls.KryptonCheckBoxExtended kryptonCheckBoxExtended1;
        private ExtendedStandardControls.Controls.Toolkit.Textural.KryptonListBoxExtended kryptonListBoxExtended1;
        private System.ComponentModel.IContainer components;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonCheckBoxExtended1 = new ExtendedStandardControls.KryptonCheckBoxExtended();
            this.kryptonListBoxExtended1 = new ExtendedStandardControls.Controls.Toolkit.Textural.KryptonListBoxExtended();
            this.SuspendLayout();
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue;
            // 
            // kryptonCheckBoxExtended1
            // 
            this.kryptonCheckBoxExtended1.Image = null;
            this.kryptonCheckBoxExtended1.Location = new System.Drawing.Point(515, 219);
            this.kryptonCheckBoxExtended1.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckBoxExtended1.Name = "kryptonCheckBoxExtended1";
            this.kryptonCheckBoxExtended1.OverrideFocus.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckBoxExtended1.OverrideFocus.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckBoxExtended1.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.ShortTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckBoxExtended1.Size = new System.Drawing.Size(166, 16);
            this.kryptonCheckBoxExtended1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckBoxExtended1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckBoxExtended1.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateDisabled.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckBoxExtended1.StateDisabled.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckBoxExtended1.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateNormal.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckBoxExtended1.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonCheckBoxExtended1.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonCheckBoxExtended1.TabIndex = 0;
            this.kryptonCheckBoxExtended1.Values.Text = "kryptonCheckBoxExtended1";
            // 
            // kryptonListBoxExtended1
            // 
            this.kryptonListBoxExtended1.CommonBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonListBoxExtended1.CommonBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonListBoxExtended1.ItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonListBoxExtended1.ItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonListBoxExtended1.Location = new System.Drawing.Point(176, 296);
            this.kryptonListBoxExtended1.LongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonListBoxExtended1.LongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonListBoxExtended1.LongTextTypeface = null;
            this.kryptonListBoxExtended1.Name = "kryptonListBoxExtended1";
            this.kryptonListBoxExtended1.ShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonListBoxExtended1.ShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonListBoxExtended1.ShortTextTypeface = null;
            this.kryptonListBoxExtended1.Size = new System.Drawing.Size(120, 96);
            this.kryptonListBoxExtended1.TabIndex = 1;
            // 
            // StandardControlsExtended
            // 
            this.ClientSize = new System.Drawing.Size(1369, 636);
            this.Controls.Add(this.kryptonListBoxExtended1);
            this.Controls.Add(this.kryptonCheckBoxExtended1);
            this.Name = "StandardControlsExtended";
            this.Load += new System.EventHandler(this.StandardControlsExtended_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public StandardControlsExtended()
        {
            InitializeComponent();
        }

        private void StandardControlsExtended_Load(object sender, EventArgs e)
        {

        }
    }
}