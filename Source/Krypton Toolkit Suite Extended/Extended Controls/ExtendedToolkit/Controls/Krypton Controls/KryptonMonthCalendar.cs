using System;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.KryptonControls
{
    [System.Drawing.ToolboxBitmap(typeof(MonthCalendar))]
    public class KryptonMonthCalendar : ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar
    {

        public KryptonMonthCalendar()
        {
            //set some Styles
            SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();

            //Init today date
            this.TodayDate = DateTime.Today;
        }

    }
}