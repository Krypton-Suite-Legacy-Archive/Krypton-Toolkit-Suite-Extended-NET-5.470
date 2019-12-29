using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls
{
    public class ColourComboBox : ComboBox
    {
        public ColourComboBox()
        {
            DrawItem += new DrawItemEventHandler(DrawCustomItem);
        }

        protected void DrawCustomItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            Type colourType = typeof(Color);

            PropertyInfo[] propertyInfo = colourType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);

            Graphics gfx = e.Graphics;

            Rectangle rectangle = e.Bounds;

            foreach (PropertyInfo item in propertyInfo)
            {
                base.Items.Add(item);
            }

            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();

                Font typeface = new Font(base.Font.FontFamily, 9, FontStyle.Regular);

                Color c = Color.FromName(n);

                Brush brush = new SolidBrush(c);

                gfx.DrawString(n, typeface, Brushes.Black, rectangle.X, rectangle.Top);

                gfx.FillRectangle(brush, rectangle.X + 110, rectangle.Y + 5, rectangle.Width - 10, rectangle.Height - 10);
            }

            gfx.Dispose();

            e.DrawFocusRectangle();
        }
    }
}