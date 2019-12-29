#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System.Drawing;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.Common
{
    public class ImageComboItem : object
    {
        // forecolor: transparent = inherit
        private Color forecolour = Color.FromKnownColor(KnownColor.Transparent);
        private bool mark = false;
        private int imageindex = -1;
        private object tag = null;
        private string text = null;

        // constructors
        public ImageComboItem()
        {
        }

        public ImageComboItem(string Text)
        {
            text = Text;
        }

        public ImageComboItem(string Text, int ImageIndex)
        {
            text = Text;
            imageindex = ImageIndex;
        }

        public ImageComboItem(string Text, int ImageIndex, bool Mark)
        {
            text = Text;
            imageindex = ImageIndex;
            mark = Mark;
        }

        public ImageComboItem(string Text, int ImageIndex, bool Mark, Color ForeColour)
        {
            text = Text;
            imageindex = ImageIndex;
            mark = Mark;
            forecolour = ForeColour;
        }

        public ImageComboItem(string Text, int ImageIndex, bool Mark, Color ForeColour, object Tag)
        {
            text = Text;
            imageindex = ImageIndex;
            mark = Mark;
            forecolour = ForeColour;
            tag = Tag;
        }

        // forecolor
        public Color ForeColour
        {
            get
            {
                return forecolour;
            }
            set
            {
                forecolour = value;
            }
        }

        // image index
        public int ImageIndex
        {
            get
            {
                return imageindex;
            }
            set
            {
                imageindex = value;
            }
        }

        // mark (bold)
        public bool Mark
        {
            get
            {
                return mark;
            }
            set
            {
                mark = value;
            }
        }

        // tag
        public object Tag
        {
            get
            {
                return tag;
            }
            set
            {
                tag = value;
            }
        }

        // item text
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }

        // ToString() should return item text
        public override string ToString()
        {
            return text;
        }

    }

}