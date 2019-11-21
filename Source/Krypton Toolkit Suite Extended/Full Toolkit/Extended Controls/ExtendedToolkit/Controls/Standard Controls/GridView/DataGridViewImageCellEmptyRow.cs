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

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.GridView
{
    public class DataGridViewImageCellEmptyRow : DataGridViewImageCell
    {
        // Methods
        public DataGridViewImageCellEmptyRow()
        {
        }

        public DataGridViewImageCellEmptyRow(bool valueIsIcon)
            : base(valueIsIcon)
        {
        }

        // Properties
        public override object DefaultNewRowValue
        {
            get
            {
                return DBNull.Value;
            }
        }
    }
}