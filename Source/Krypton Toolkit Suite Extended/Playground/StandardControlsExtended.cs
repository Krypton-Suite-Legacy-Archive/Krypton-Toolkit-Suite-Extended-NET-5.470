using ComponentFactory.Krypton.Toolkit;
using System;

namespace Playground
{
    public class StandardControlsExtended : KryptonForm
    {
        private ExtendedStandardControls.KryptonLabelExtended kryptonLabelExtended1;
        private ExtendedStandardControls.KryptonLinkLabelExtended kryptonLinkLabelExtended1;
        private ExtendedStandardControls.KryptonMaskedTextBoxExtended kryptonMaskedTextBoxExtended1;
        private KryptonMonthCalendar kryptonMonthCalendar1;
        private ExtendedStandardControls.KryptonTextBoxExtended kryptonTextBoxExtended1;

        private void InitializeComponent()
        {
            this.kryptonTextBoxExtended1 = new ExtendedStandardControls.KryptonTextBoxExtended();
            this.kryptonLinkLabelExtended1 = new ExtendedStandardControls.KryptonLinkLabelExtended();
            this.kryptonLabelExtended1 = new ExtendedStandardControls.KryptonLabelExtended();
            this.kryptonMaskedTextBoxExtended1 = new ExtendedStandardControls.KryptonMaskedTextBoxExtended();
            this.kryptonMonthCalendar1 = new ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar();
            this.SuspendLayout();
            // 
            // kryptonTextBoxExtended1
            // 
            this.kryptonTextBoxExtended1.BackgroundColour = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonTextBoxExtended1.Location = new System.Drawing.Point(376, 44);
            this.kryptonTextBoxExtended1.Name = "kryptonTextBoxExtended1";
            this.kryptonTextBoxExtended1.Size = new System.Drawing.Size(401, 29);
            this.kryptonTextBoxExtended1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kryptonTextBoxExtended1.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.kryptonTextBoxExtended1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBoxExtended1.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonTextBoxExtended1.TabIndex = 5;
            this.kryptonTextBoxExtended1.Text = "kryptonTextBoxExtended1";
            this.kryptonTextBoxExtended1.TextColour = System.Drawing.Color.White;
            this.kryptonTextBoxExtended1.Typeface = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // kryptonLinkLabelExtended1
            // 
            this.kryptonLinkLabelExtended1.CommonLongTextColourOne = System.Drawing.Color.Olive;
            this.kryptonLinkLabelExtended1.CommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.CommonShortTextColourOne = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.kryptonLinkLabelExtended1.CommonShortTextColourTwo = System.Drawing.Color.Teal;
            this.kryptonLinkLabelExtended1.Location = new System.Drawing.Point(708, 157);
            this.kryptonLinkLabelExtended1.Name = "kryptonLinkLabelExtended1";
            this.kryptonLinkLabelExtended1.OverrideFocus.LongText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLinkLabelExtended1.OverrideFocus.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLinkLabelExtended1.OverrideFocusLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideFocusLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideFocusShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideFocusShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideNotVisited.LongText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLinkLabelExtended1.OverrideNotVisited.ShortText.Color1 = System.Drawing.Color.Teal;
            this.kryptonLinkLabelExtended1.OverrideNotVisited.ShortText.Color2 = System.Drawing.Color.Green;
            this.kryptonLinkLabelExtended1.OverrideNotVisited.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLinkLabelExtended1.OverrideNotVisitedLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideNotVisitedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideNotVisitedShortTextColourOne = System.Drawing.Color.Teal;
            this.kryptonLinkLabelExtended1.OverrideNotVisitedShortTextColourTwo = System.Drawing.Color.Green;
            this.kryptonLinkLabelExtended1.OverridePressed.LongText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLinkLabelExtended1.OverridePressed.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLinkLabelExtended1.OverridePressedLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverridePressedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverridePressedShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverridePressedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideVisited.LongText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLinkLabelExtended1.OverrideVisited.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLinkLabelExtended1.OverrideVisitedLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideVisitedLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideVisitedShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.OverrideVisitedShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.Size = new System.Drawing.Size(280, 29);
            this.kryptonLinkLabelExtended1.StateCommon.LongText.Color1 = System.Drawing.Color.Olive;
            this.kryptonLinkLabelExtended1.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLinkLabelExtended1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.kryptonLinkLabelExtended1.StateCommon.ShortText.Color2 = System.Drawing.Color.Teal;
            this.kryptonLinkLabelExtended1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLinkLabelExtended1.TabIndex = 4;
            this.kryptonLinkLabelExtended1.Typeface = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLinkLabelExtended1.Values.Text = "kryptonLinkLabelExtended1";
            // 
            // kryptonLabelExtended1
            // 
            this.kryptonLabelExtended1.Image = global::Playground.Properties.Resources.KR_32_x_32_Orange;
            this.kryptonLabelExtended1.Location = new System.Drawing.Point(430, 148);
            this.kryptonLabelExtended1.Name = "kryptonLabelExtended1";
            this.kryptonLabelExtended1.Size = new System.Drawing.Size(234, 29);
            this.kryptonLabelExtended1.StateCommon.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabelExtended1.StateCommon.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kryptonLabelExtended1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.StateCommon.LongText.Image = global::Playground.Properties.Resources.KR_32_x_32_Orange;
            this.kryptonLabelExtended1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabelExtended1.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kryptonLabelExtended1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.StateCommon.ShortText.Image = global::Playground.Properties.Resources.KR_32_x_32_Orange;
            this.kryptonLabelExtended1.TabIndex = 2;
            this.kryptonLabelExtended1.TextColourOne = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabelExtended1.TextColourTwo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kryptonLabelExtended1.Typeface = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.Values.Text = "kryptonLabelExtended1";
            // 
            // kryptonMaskedTextBoxExtended1
            // 
            this.kryptonMaskedTextBoxExtended1.BackgroundColour = System.Drawing.Color.White;
            this.kryptonMaskedTextBoxExtended1.Location = new System.Drawing.Point(801, 44);
            this.kryptonMaskedTextBoxExtended1.Name = "kryptonMaskedTextBoxExtended1";
            this.kryptonMaskedTextBoxExtended1.Size = new System.Drawing.Size(100, 20);
            this.kryptonMaskedTextBoxExtended1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonMaskedTextBoxExtended1.StateCommon.Content.Color1 = System.Drawing.SystemColors.ControlText;
            this.kryptonMaskedTextBoxExtended1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.kryptonMaskedTextBoxExtended1.StateCommon.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.kryptonMaskedTextBoxExtended1.TabIndex = 6;
            this.kryptonMaskedTextBoxExtended1.Text = "kryptonMaskedTextBoxExtended1";
            this.kryptonMaskedTextBoxExtended1.TextColour = System.Drawing.SystemColors.ControlText;
            this.kryptonMaskedTextBoxExtended1.Typeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // kryptonMonthCalendar1
            // 
            this.kryptonMonthCalendar1.Location = new System.Drawing.Point(279, 224);
            this.kryptonMonthCalendar1.Name = "kryptonMonthCalendar1";
            this.kryptonMonthCalendar1.Size = new System.Drawing.Size(230, 184);
            this.kryptonMonthCalendar1.TabIndex = 7;
            // 
            // StandardControlsExtended
            // 
            this.ClientSize = new System.Drawing.Size(1369, 636);
            this.Controls.Add(this.kryptonMonthCalendar1);
            this.Controls.Add(this.kryptonMaskedTextBoxExtended1);
            this.Controls.Add(this.kryptonTextBoxExtended1);
            this.Controls.Add(this.kryptonLinkLabelExtended1);
            this.Controls.Add(this.kryptonLabelExtended1);
            this.Name = "StandardControlsExtended";
            this.Load += new System.EventHandler(this.StandardControlsExtended_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void StandardControlsExtended_Load(object sender, EventArgs e)
        {

        }
    }
}