namespace Playground
{
    partial class CalandarAndControls
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ExtendedControls.ExtendedToolkit.Calendar.Classes.CalendarHighlightRange calendarHighlightRange1 = new ExtendedControls.ExtendedToolkit.Calendar.Classes.CalendarHighlightRange();
            ExtendedControls.ExtendedToolkit.Calendar.Classes.CalendarHighlightRange calendarHighlightRange2 = new ExtendedControls.ExtendedToolkit.Calendar.Classes.CalendarHighlightRange();
            ExtendedControls.ExtendedToolkit.Calendar.Classes.CalendarHighlightRange calendarHighlightRange3 = new ExtendedControls.ExtendedToolkit.Calendar.Classes.CalendarHighlightRange();
            ExtendedControls.ExtendedToolkit.Calendar.Classes.CalendarHighlightRange calendarHighlightRange4 = new ExtendedControls.ExtendedToolkit.Calendar.Classes.CalendarHighlightRange();
            ExtendedControls.ExtendedToolkit.Calendar.Classes.CalendarHighlightRange calendarHighlightRange5 = new ExtendedControls.ExtendedToolkit.Calendar.Classes.CalendarHighlightRange();
            this.kryptonCalendar1 = new ExtendedControls.ExtendedToolkit.Calendar.Controls.KryptonCalendar();
            this.monthView1 = new ExtendedControls.ExtendedToolkit.Calendar.Controls.MonthView();
            this.SuspendLayout();
            // 
            // kryptonCalendar1
            // 
            this.kryptonCalendar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            calendarHighlightRange1.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange1.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange1.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange2.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange2.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange2.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange3.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange3.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange3.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange4.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange4.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange4.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange5.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange5.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange5.StartTime = System.TimeSpan.Parse("08:00:00");
            this.kryptonCalendar1.HighlightRanges = new ExtendedControls.ExtendedToolkit.Calendar.Classes.CalendarHighlightRange[] {
        calendarHighlightRange1,
        calendarHighlightRange2,
        calendarHighlightRange3,
        calendarHighlightRange4,
        calendarHighlightRange5};
            this.kryptonCalendar1.Location = new System.Drawing.Point(12, 12);
            this.kryptonCalendar1.Name = "kryptonCalendar1";
            this.kryptonCalendar1.Size = new System.Drawing.Size(75, 23);
            this.kryptonCalendar1.TabIndex = 0;
            this.kryptonCalendar1.Text = "kryptonCalendar1";
            // 
            // monthView1
            // 
            this.monthView1.ArrowsColour = System.Drawing.SystemColors.Window;
            this.monthView1.ArrowsSelectedColour = System.Drawing.Color.Gold;
            this.monthView1.DayBackgroundColour = System.Drawing.Color.Empty;
            this.monthView1.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.monthView1.DaySelectedBackgroundColour = System.Drawing.SystemColors.Highlight;
            this.monthView1.DaySelectedColour = System.Drawing.SystemColors.WindowText;
            this.monthView1.DaySelectedTextColour = System.Drawing.SystemColors.HighlightText;
            this.monthView1.ItemPadding = new System.Windows.Forms.Padding(2);
            this.monthView1.Location = new System.Drawing.Point(487, 127);
            this.monthView1.MonthTitleColour = System.Drawing.SystemColors.ActiveCaption;
            this.monthView1.MonthTitleColourInactive = System.Drawing.SystemColors.InactiveCaption;
            this.monthView1.MonthTitleTextColour = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthView1.MonthTitleTextColourInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.monthView1.Name = "monthView1";
            this.monthView1.Size = new System.Drawing.Size(236, 171);
            this.monthView1.TabIndex = 1;
            this.monthView1.Text = "monthView1";
            this.monthView1.TodayBorderColour = System.Drawing.Color.Maroon;
            // 
            // CalandarAndControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthView1);
            this.Controls.Add(this.kryptonCalendar1);
            this.Name = "CalandarAndControls";
            this.Text = "CalandarAndControls";
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendedControls.ExtendedToolkit.Calendar.Controls.KryptonCalendar kryptonCalendar1;
        private ExtendedControls.ExtendedToolkit.Calendar.Controls.MonthView monthView1;
    }
}