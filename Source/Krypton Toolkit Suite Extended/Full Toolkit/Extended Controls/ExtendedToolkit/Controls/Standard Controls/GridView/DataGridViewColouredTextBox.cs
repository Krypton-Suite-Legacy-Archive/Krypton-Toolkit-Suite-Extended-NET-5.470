#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using Microsoft.VisualBasic.CompilerServices;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.GridView
{
    public class DataGridViewColouredTextBoxColumn : DataGridViewTextBoxColumn
    {
        // Methods
        public DataGridViewColouredTextBoxColumn()
        {
            this.CellTemplate = new DataGridViewColouredTextBox();
        }
    }

    public class DataGridViewColouredTextBox : DataGridViewTextBoxCell
    {
        protected override void PaintBorder(Graphics graphics, Rectangle clipBounds, Rectangle bounds, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle)
        {
            base.PaintBorder(graphics, clipBounds, bounds, cellStyle, advancedBorderStyle);
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            try
            {
                object o;
                o = value;

                if ((((o) != null)))
                {
                    double c;
                    c = Conversions.ToDouble(o);
                    //Debug
                    //MessageBox.Show(c)


                    //erase background
                    if (c < 0)
                    {
                        cellStyle.BackColor = Color.FromArgb(255, 200, 200);
                    }
                    else if (c == 0)
                    {
                        cellStyle.BackColor = Color.FromArgb(200, 200, 255);
                    }
                    else if (c > 0)
                    {
                        cellStyle.BackColor = Color.FromArgb(200, 255, 200);
                    }
                }

                base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle,
                paintParts);

                PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle);

            }
            catch
            {
                // empty catch 
                //MessageBox.Show(ex.Message)
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle,
                paintParts);
                PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle);
            }
        }


    }

}