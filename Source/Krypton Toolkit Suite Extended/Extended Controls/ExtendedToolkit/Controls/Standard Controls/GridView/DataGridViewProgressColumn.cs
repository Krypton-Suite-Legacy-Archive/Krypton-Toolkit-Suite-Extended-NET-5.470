using ExtendedControls.ExtendedToolkit.Controls.Drawing.Classes;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.GridView
{
    public class DataGridViewProgressColumn : DataGridViewImageColumn
    {
        // Methods
        public DataGridViewProgressColumn()
        {
            this.CellTemplate = new DataGridViewProgressCell();
        }
    }

    public class DataGridViewProgressCell : DataGridViewImageCell
    {
        // Methods
        public DataGridViewProgressCell()
        {
            this.ValueType = Type.GetType("Integer");
        }

        // Method required to make the Progress Cell consistent with the default Image Cell.
        // The default Image Cell assumes an Image as a value, although the value of the Progress Cell is an Integer.
        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
        {
            return emptyImage;
        }

        private static Bitmap emptyImage = new Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, System.Windows.Forms.DataGridViewElementStates cellState, object value, object formattedValue, string errorText, System.Windows.Forms.DataGridViewCellStyle cellStyle, System.Windows.Forms.DataGridViewAdvancedBorderStyle advancedBorderStyle,
        System.Windows.Forms.DataGridViewPaintParts paintParts)
        {
            Single progressVal;
            try
            {
                progressVal = Conversions.ToSingle(value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                progressVal = 0;
            }

            float percentage = (float)(progressVal / 100);
            Brush backBrush = new SolidBrush(cellStyle.BackColor);
            Brush foreBrush = new SolidBrush(cellStyle.ForeColor);

            // Call the base Class method to paint the default cell appearance.
            base.Paint(g, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle,
            paintParts);

            if (percentage > 0.0)
            {
                if (percentage > 1)
                {
                    percentage = 1;
                }
                // Draw the progress bar and the text
                Rectangle rect = new Rectangle(cellBounds.X + 1, cellBounds.Y + 1, Convert.ToInt32((percentage * cellBounds.Width - 3)), cellBounds.Height - 3);
                DrawingMethods.DrawGradient(g, rect, Color.FromArgb(205, 255, 205), Color.FromArgb(10, 209, 48), 90F, false, Color.White, 0);
                g.DrawRectangle(new Pen(Color.FromArgb(28, 220, 56)), rect.X, rect.Y, rect.Width - 1, rect.Height - 1);
                //g.FillRectangle(New SolidBrush(Color.FromArgb(163, 189, 242)), cellBounds.X + 2, cellBounds.Y + 2, Convert.ToInt32((percentage * cellBounds.Width - 4)), cellBounds.Height - 4)
                g.DrawString(progressVal.ToString() + "%", cellStyle.Font, foreBrush, cellBounds.X + 6, cellBounds.Y + 4);

            }
            else
            {
                //draw the text
                if ((this.DataGridView.CurrentCell != null) && this.DataGridView.CurrentCell.RowIndex == rowIndex)
                {
                    g.DrawString(progressVal.ToString() + "%", cellStyle.Font, new SolidBrush(cellStyle.SelectionForeColor), cellBounds.X + 6, cellBounds.Y + 4);
                }
                else
                {
                    g.DrawString(progressVal.ToString() + "%", cellStyle.Font, foreBrush, cellBounds.X + 6, cellBounds.Y + 4);
                }
            }
        }




    }
}