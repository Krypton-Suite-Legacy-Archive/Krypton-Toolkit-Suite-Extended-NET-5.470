#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;

namespace Playground
{
    public class Editor : KryptonForm
    {
        private ExtendedStandardControls.KryptonGroupBoxExtended kryptonGroupBoxExtended1;
        private ExtendedStandardControls.KryptonLabelExtended kryptonLabelExtended1;
        private ExtendedStandardControls.KryptonLinkLabelExtended kryptonLinkLabelExtended1;
        private ExtendedStandardControls.KryptonMaskedTextBoxExtended kryptonMaskedTextBoxExtended1;
        private ExtendedStandardControls.Controls.Toolkit.Textural.KryptonListBoxExtended kryptonListBoxExtended1;
        private KryptonPanel kryptonPanel1;

        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonMaskedTextBoxExtended1 = new ExtendedStandardControls.KryptonMaskedTextBoxExtended();
            this.kryptonLinkLabelExtended1 = new ExtendedStandardControls.KryptonLinkLabelExtended();
            this.kryptonLabelExtended1 = new ExtendedStandardControls.KryptonLabelExtended();
            this.kryptonGroupBoxExtended1 = new ExtendedStandardControls.KryptonGroupBoxExtended();
            this.kryptonListBoxExtended1 = new ExtendedStandardControls.Controls.Toolkit.Textural.KryptonListBoxExtended();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBoxExtended1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBoxExtended1.Panel)).BeginInit();
            this.kryptonGroupBoxExtended1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonMaskedTextBoxExtended1);
            this.kryptonPanel1.Controls.Add(this.kryptonLinkLabelExtended1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabelExtended1);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBoxExtended1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1410, 690);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonMaskedTextBoxExtended1
            // 
            this.kryptonMaskedTextBoxExtended1.BackgroundColour = System.Drawing.Color.White;
            this.kryptonMaskedTextBoxExtended1.Location = new System.Drawing.Point(856, 300);
            this.kryptonMaskedTextBoxExtended1.Name = "kryptonMaskedTextBoxExtended1";
            this.kryptonMaskedTextBoxExtended1.Size = new System.Drawing.Size(100, 20);
            this.kryptonMaskedTextBoxExtended1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonMaskedTextBoxExtended1.StateCommon.Content.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonMaskedTextBoxExtended1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonMaskedTextBoxExtended1.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonMaskedTextBoxExtended1.TabIndex = 3;
            this.kryptonMaskedTextBoxExtended1.Text = "kryptonMaskedTextBoxExtended1";
            this.kryptonMaskedTextBoxExtended1.TextColour = System.Drawing.SystemColors.ControlText;
            this.kryptonMaskedTextBoxExtended1.Typeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // kryptonLinkLabelExtended1
            // 
            this.kryptonLinkLabelExtended1.Location = new System.Drawing.Point(856, 245);
            this.kryptonLinkLabelExtended1.LongTextTypeface = null;
            this.kryptonLinkLabelExtended1.Name = "kryptonLinkLabelExtended1";
            this.kryptonLinkLabelExtended1.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideNotVisitedLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideNotVisitedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideNotVisitedShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideNotVisitedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverridePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverridePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverridePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverridePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideVisitedLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideVisitedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideVisitedShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideVisitedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.ShortTextTypeface = null;
            this.kryptonLinkLabelExtended1.Size = new System.Drawing.Size(161, 20);
            this.kryptonLinkLabelExtended1.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.TabIndex = 1;
            this.kryptonLinkLabelExtended1.Values.Text = "kryptonLinkLabelExtended1";
            // 
            // kryptonLabelExtended1
            // 
            this.kryptonLabelExtended1.Image = null;
            this.kryptonLabelExtended1.Location = new System.Drawing.Point(762, 134);
            this.kryptonLabelExtended1.LongTextTypeface = null;
            this.kryptonLabelExtended1.Name = "kryptonLabelExtended1";
            this.kryptonLabelExtended1.ShortTextTypeface = null;
            this.kryptonLabelExtended1.Size = new System.Drawing.Size(139, 20);
            this.kryptonLabelExtended1.StateCommonTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateCommonTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateDisabledTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateDisabledTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateNormalTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.StateNormalTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLabelExtended1.TabIndex = 2;
            this.kryptonLabelExtended1.Values.Text = "kryptonLabelExtended1";
            // 
            // kryptonGroupBoxExtended1
            // 
            this.kryptonGroupBoxExtended1.Image = null;
            this.kryptonGroupBoxExtended1.Location = new System.Drawing.Point(477, 191);
            this.kryptonGroupBoxExtended1.LongTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonGroupBoxExtended1.Name = "kryptonGroupBoxExtended1";
            this.kryptonGroupBoxExtended1.ShortTextTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonGroupBoxExtended1.Size = new System.Drawing.Size(150, 150);
            this.kryptonGroupBoxExtended1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonGroupBoxExtended1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonGroupBoxExtended1.StateCommonBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonGroupBoxExtended1.StateCommonBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonGroupBoxExtended1.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonGroupBoxExtended1.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonGroupBoxExtended1.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonGroupBoxExtended1.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonGroupBoxExtended1.StateDisabledBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonGroupBoxExtended1.StateDisabledBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonGroupBoxExtended1.StateDisabledLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonGroupBoxExtended1.StateDisabledLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonGroupBoxExtended1.StateDisabledShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonGroupBoxExtended1.StateDisabledShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonGroupBoxExtended1.StateNormalBackGroundColourOne = System.Drawing.Color.Empty;
            this.kryptonGroupBoxExtended1.StateNormalBackGroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonGroupBoxExtended1.StateNormalLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonGroupBoxExtended1.StateNormalLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonGroupBoxExtended1.StateNormalShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonGroupBoxExtended1.StateNormalShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonGroupBoxExtended1.TabIndex = 1;
            // 
            // kryptonListBoxExtended1
            // 
            this.kryptonListBoxExtended1.Location = new System.Drawing.Point(0, 0);
            this.kryptonListBoxExtended1.LongTextTypeface = null;
            this.kryptonListBoxExtended1.Name = "kryptonListBoxExtended1";
            this.kryptonListBoxExtended1.ShortTextTypeface = null;
            this.kryptonListBoxExtended1.Size = new System.Drawing.Size(120, 96);
            this.kryptonListBoxExtended1.StateCommonBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonListBoxExtended1.StateCommonBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonListBoxExtended1.StateCommonItemBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonListBoxExtended1.StateCommonItemBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonListBoxExtended1.StateCommonLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonListBoxExtended1.StateCommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonListBoxExtended1.StateCommonShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonListBoxExtended1.StateCommonShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonListBoxExtended1.TabIndex = 1;
            // 
            // Editor
            // 
            this.ClientSize = new System.Drawing.Size(1410, 690);
            this.Controls.Add(this.kryptonListBoxExtended1);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "Editor";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBoxExtended1.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBoxExtended1)).EndInit();
            this.kryptonGroupBoxExtended1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}