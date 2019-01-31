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