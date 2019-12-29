#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.Common
{
    [ToolboxBitmap(typeof(ComboBox)), ToolboxItem(false)]
    public class ImageCombo : ComboBox
    {
        private ImageList imgs = new ImageList();

        // constructor
        public ImageCombo()
        {
            // set draw mode to owner draw
            this.DrawMode = DrawMode.OwnerDrawFixed;
        }

        // ImageList property
        public ImageList ImageList
        {
            get
            {
                return imgs;
            }
            set
            {
                imgs = value;
            }
        }

        // customized drawing process
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // draw background & focus rect
            e.DrawBackground();
            e.DrawFocusRectangle();

            // check if it is an item from the Items collection
            if (e.Index < 0)

                // not an item, draw the text (indented)
                e.Graphics.DrawString(this.Text, e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + imgs.ImageSize.Width, e.Bounds.Top);

            else
            {

                // check if item is an ImageComboItem
                if (this.Items[e.Index].GetType() == typeof(ImageComboItem))
                {

                    // get item to draw
                    ImageComboItem item = (ImageComboItem)this.Items[e.Index];

                    // get forecolor & font
                    Color forecolor = (item.ForeColour != Color.FromKnownColor(KnownColor.Transparent)) ? item.ForeColour : e.ForeColor;
                    Font font = item.Mark ? new Font(e.Font, FontStyle.Bold) : e.Font;

                    // -1: no image
                    if (item.ImageIndex != -1)
                    {
                        // draw image, then draw text next to it
                        this.ImageList.Draw(e.Graphics, e.Bounds.Left, e.Bounds.Top, item.ImageIndex);
                        e.Graphics.DrawString(item.Text, font, new SolidBrush(forecolor), e.Bounds.Left + imgs.ImageSize.Width, e.Bounds.Top);
                    }
                    else
                        // draw text (indented)
                        e.Graphics.DrawString(item.Text, font, new SolidBrush(forecolor), e.Bounds.Left + imgs.ImageSize.Width, e.Bounds.Top);

                }
                else

                    // it is not an ImageComboItem, draw it
                    e.Graphics.DrawString(this.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + imgs.ImageSize.Width, e.Bounds.Top);

            }

            base.OnDrawItem(e);
        }

    }

}