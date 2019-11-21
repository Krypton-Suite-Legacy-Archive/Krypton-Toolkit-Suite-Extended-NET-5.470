#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

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