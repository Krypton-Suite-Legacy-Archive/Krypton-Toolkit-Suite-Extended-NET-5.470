using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.GridView
{
    public class DataGridViewOkFailImageColumn : DataGridViewTextBoxColumn
    {
        // Methods
        public DataGridViewOkFailImageColumn()
        {
            this.CellTemplate = new DataGridViewOkFailImage();
        }
    }

    public class DataGridViewOkFailImage : DataGridViewTextBoxCell
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

                base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, "", "", errorText, cellStyle, advancedBorderStyle,
                paintParts);

                //load Icons from resources
                //arrows
                ImageList GridIcons = new ImageList();
                GridIcons.ColorDepth = ColorDepth.Depth32Bit;

                string iconOkName;
                string iconFailName;
                string iconNoneName;
                //Icon icon;
                //Bitmap icon;

                //Ok
                iconOkName = "AC.ExtendedRenderer.Toolkit.StdControls.Images.Up.png";

                //Fail
                iconFailName = "AC.ExtendedRenderer.Toolkit.StdControls.Images.Down.png";

                //None
                iconNoneName = "AC.ExtendedRenderer.Toolkit.StdControls.Images.Question.png";


                int ngXlocation = (cellBounds.Width - 16);
                int ngYlocation = (cellBounds.Height - 16);
                if (ngXlocation < 0)
                {
                    ngXlocation = 0;
                }
                if (ngYlocation < 0)
                {
                    ngYlocation = 0;
                }
                ngXlocation = ngXlocation / 2;
                ngYlocation = ngYlocation / 2;

                Rectangle ng = new Rectangle(cellBounds.X + ngXlocation, cellBounds.Y + ngYlocation, 16, 16);

                if ((((o) != null)))
                {
                    Single c;
                    c = Conversions.ToSingle(o);
                    //Debug
                    //MessageBox.Show(c)

                    Brush backBrush = new SolidBrush(cellStyle.BackColor);

                    if (elementState == DataGridViewElementStates.Selected)
                    {
                        backBrush = new SolidBrush(Color.Gold);
                    }

                    //erase background
                    if (c == 1)
                    {
                        //graphics.FillRectangle(backBrush, cellBounds.X, cellBounds.Y, cellBounds.Width, cellBounds.Height)
                        using (Bitmap tmpBitmap = new Bitmap(this.GetType().Assembly.GetManifestResourceStream(iconOkName)))
                        {
                            tmpBitmap.MakeTransparent();
                            graphics.DrawImage(tmpBitmap, ng);
                        }
                    }
                    else if (c == 0)
                    {
                        //graphics.FillRectangle(backBrush, cellBounds.X, cellBounds.Y, cellBounds.Width, cellBounds.Height)
                        using (Bitmap tmpBitmap = new Bitmap(this.GetType().Assembly.GetManifestResourceStream(iconFailName)))
                        {
                            tmpBitmap.MakeTransparent();
                            graphics.DrawImage(tmpBitmap, ng);
                        }
                    }
                    else
                    {
                        //graphics.FillRectangle(backBrush, cellBounds.X, cellBounds.Y, cellBounds.Width, cellBounds.Height)
                        using (Bitmap tmpBitmap = new Bitmap(this.GetType().Assembly.GetManifestResourceStream(iconNoneName)))
                        {
                            tmpBitmap.MakeTransparent();
                            graphics.DrawImage(tmpBitmap, ng);
                        }
                    }
                }

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

        //public property
        public override object DefaultNewRowValue
        {
            get { return "1"; }
        }
    }
}