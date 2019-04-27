using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls
{
    [ToolboxBitmap(typeof(KryptonComboBox))]
    public class KryptonColourComboBox : KryptonComboBox
    {
        #region Event Handlers
        public event DrawItemEventHandler DrawItem;
        #endregion

        public KryptonColourComboBox()
        {
            DrawItem += KryptonColourComboBox_DrawItem;
        }

        private void KryptonColourComboBox_DrawItem(object sender, DrawItemEventArgs e)
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
                string n = ((KryptonComboBox)sender).Items[e.Index].ToString();

                Font typeface = new Font(base.Font.FontFamily, 9, FontStyle.Regular);

                Color c = Color.FromName(n);

                Brush brush = new SolidBrush(c);

                gfx.DrawString(n, typeface, Brushes.Black, rectangle.X, rectangle.Top);

                gfx.FillRectangle(brush, rectangle.X + 110, rectangle.Y + 5, rectangle.Width - 10, rectangle.Height - 10);
            }

            gfx.Dispose();

            e.DrawFocusRectangle();
        }

        #region Protected Events

        #endregion
    }
}