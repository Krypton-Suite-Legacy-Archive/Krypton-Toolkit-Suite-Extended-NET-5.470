using ComponentFactory.Krypton.Toolkit;

namespace Playground
{
    public class ExtendedStandardControls : KryptonForm
    {
        private ExtendedStandardControls.KryptonComboBoxExtended kryptonComboBoxExtended1;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonComboBoxExtended1 = new ExtendedStandardControls.KryptonComboBoxExtended();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBoxExtended1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonComboBoxExtended1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1527, 744);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonComboBoxExtended1
            // 
            this.kryptonComboBoxExtended1.ComboBoxBackColour = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.ComboBoxContentColour = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.ComboBoxContentTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.ComboBoxDropBackColourOne = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.ComboBoxDropBackColourTwo = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.ComboBoxItemBackColourOne = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.ComboBoxItemBackColourTwo = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.ComboBoxItemContentLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.ComboBoxItemContentLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.ComboBoxItemContentLongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.ComboBoxItemContentShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.ComboBoxItemContentShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonComboBoxExtended1.ComboBoxItemContentShortTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.DropDownWidth = 121;
            this.kryptonComboBoxExtended1.Image = null;
            this.kryptonComboBoxExtended1.IntegralHeight = false;
            this.kryptonComboBoxExtended1.Location = new System.Drawing.Point(12, 21);
            this.kryptonComboBoxExtended1.Name = "kryptonComboBoxExtended1";
            this.kryptonComboBoxExtended1.Size = new System.Drawing.Size(121, 18);
            this.kryptonComboBoxExtended1.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonComboBoxExtended1.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonComboBoxExtended1.TabIndex = 1;
            this.kryptonComboBoxExtended1.Text = "kryptonComboBoxExtended1";
            // 
            // ExtendedStandardControls
            // 
            this.ClientSize = new System.Drawing.Size(1527, 744);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ExtendedStandardControls";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBoxExtended1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}