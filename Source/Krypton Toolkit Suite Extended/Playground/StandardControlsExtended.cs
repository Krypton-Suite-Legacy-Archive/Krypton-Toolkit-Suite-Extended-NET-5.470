using ComponentFactory.Krypton.Toolkit;
using System;

namespace Playground
{
    public class StandardControlsExtended : KryptonForm
    {
        private ExtendedStandardControls.KryptonLabelExtended kryptonLabelExtended1;
        private ExtendedStandardControls.KryptonLinkLabelExtended kryptonLinkLabelExtended1;
        private ExtendedStandardControls.KryptonMonthCalendarExtended kryptonMonthCalendarExtended1;
        private KryptonRichTextBox kryptonRichTextBox1;
        private KryptonNumericUpDown kryptonNumericUpDown1;

        private void InitializeComponent()
        {
            this.kryptonNumericUpDown1 = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonMonthCalendarExtended1 = new ExtendedStandardControls.KryptonMonthCalendarExtended();
            this.kryptonLinkLabelExtended1 = new ExtendedStandardControls.KryptonLinkLabelExtended();
            this.kryptonLabelExtended1 = new ExtendedStandardControls.KryptonLabelExtended();
            this.kryptonRichTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.SuspendLayout();
            // 
            // kryptonNumericUpDown1
            // 
            this.kryptonNumericUpDown1.Location = new System.Drawing.Point(376, 193);
            this.kryptonNumericUpDown1.Name = "kryptonNumericUpDown1";
            this.kryptonNumericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.kryptonNumericUpDown1.TabIndex = 8;
            // 
            // kryptonMonthCalendarExtended1
            // 
            this.kryptonMonthCalendarExtended1.CommonBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonMonthCalendarExtended1.CommonBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonMonthCalendarExtended1.DayBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonMonthCalendarExtended1.DayBackgroundColourTwo = System.Drawing.Color.White;
            this.kryptonMonthCalendarExtended1.DayLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonMonthCalendarExtended1.DayLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonMonthCalendarExtended1.DayOfWeekBackgroundColourOne = System.Drawing.Color.Empty;
            this.kryptonMonthCalendarExtended1.DayOfWeekBackgroundColourTwo = System.Drawing.Color.Empty;
            this.kryptonMonthCalendarExtended1.DayOfWeekLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonMonthCalendarExtended1.DayOfWeekLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonMonthCalendarExtended1.DayOfWeekShortTextColourOne = System.Drawing.Color.Empty;
            this.kryptonMonthCalendarExtended1.DayOfWeekShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonMonthCalendarExtended1.DayShortTextColourOne = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.kryptonMonthCalendarExtended1.DayShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonMonthCalendarExtended1.HeaderBackgroundColourOne = System.Drawing.Color.Red;
            this.kryptonMonthCalendarExtended1.HeaderBackgroundColourTwo = System.Drawing.Color.Lime;
            this.kryptonMonthCalendarExtended1.HeaderLongTextColourOne = System.Drawing.Color.Empty;
            this.kryptonMonthCalendarExtended1.HeaderLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonMonthCalendarExtended1.HeaderShortTextColourOne = System.Drawing.Color.White;
            this.kryptonMonthCalendarExtended1.HeaderShortTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonMonthCalendarExtended1.Location = new System.Drawing.Point(28, 29);
            this.kryptonMonthCalendarExtended1.Name = "kryptonMonthCalendarExtended1";
            this.kryptonMonthCalendarExtended1.Size = new System.Drawing.Size(230, 184);
            this.kryptonMonthCalendarExtended1.StateCommon.Day.Back.Color2 = System.Drawing.Color.White;
            this.kryptonMonthCalendarExtended1.StateCommon.Day.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.kryptonMonthCalendarExtended1.StateCommon.Header.Back.Color1 = System.Drawing.Color.Red;
            this.kryptonMonthCalendarExtended1.StateCommon.Header.Back.Color2 = System.Drawing.Color.Lime;
            this.kryptonMonthCalendarExtended1.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonMonthCalendarExtended1.TabIndex = 7;
            this.kryptonMonthCalendarExtended1.Typeface = null;
            // 
            // kryptonLinkLabelExtended1
            // 
            this.kryptonLinkLabelExtended1.CommonLongTextColourOne = System.Drawing.Color.Olive;
            this.kryptonLinkLabelExtended1.CommonLongTextColourTwo = System.Drawing.Color.Empty;
            this.kryptonLinkLabelExtended1.CommonShortTextColourOne = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.kryptonLinkLabelExtended1.CommonShortTextColourTwo = System.Drawing.Color.Teal;
            this.kryptonLinkLabelExtended1.Location = new System.Drawing.Point(273, 64);
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
            this.kryptonLabelExtended1.Image = null;
            this.kryptonLabelExtended1.Location = new System.Drawing.Point(273, 29);
            this.kryptonLabelExtended1.Name = "kryptonLabelExtended1";
            this.kryptonLabelExtended1.Size = new System.Drawing.Size(234, 29);
            this.kryptonLabelExtended1.StateCommon.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabelExtended1.StateCommon.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kryptonLabelExtended1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabelExtended1.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kryptonLabelExtended1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.TabIndex = 2;
            this.kryptonLabelExtended1.TextColourOne = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabelExtended1.TextColourTwo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kryptonLabelExtended1.Typeface = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabelExtended1.Values.Text = "kryptonLabelExtended1";
            // 
            // kryptonRichTextBox1
            // 
            this.kryptonRichTextBox1.Location = new System.Drawing.Point(678, 240);
            this.kryptonRichTextBox1.Name = "kryptonRichTextBox1";
            this.kryptonRichTextBox1.Size = new System.Drawing.Size(100, 96);
            this.kryptonRichTextBox1.TabIndex = 10;
            this.kryptonRichTextBox1.Text = "kryptonRichTextBox1";
            // 
            // StandardControlsExtended
            // 
            this.ClientSize = new System.Drawing.Size(1369, 636);
            this.Controls.Add(this.kryptonRichTextBox1);
            this.Controls.Add(this.kryptonNumericUpDown1);
            this.Controls.Add(this.kryptonMonthCalendarExtended1);
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