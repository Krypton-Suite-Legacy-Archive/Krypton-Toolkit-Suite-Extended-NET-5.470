#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.StandardControls.TreeView
{
    public class TreeViewPrintHelper
    {
        // Fields
        private Image _controlImage = null;
        private PrintDirection _currentDir;
        private DateTime _date;
        private Point _lastPrintPosition = new Point(0, 0);
        private int _nodeHeight = 0;
        private int _pageNumber = 0;
        private PrintDocument _printDoc = new PrintDocument();
        private int _scrollBarHeight = 0;
        private int _scrollBarWidth = 0;
        private string _title = string.Empty;
        private Font headerfont;

        // Methods
        public TreeViewPrintHelper()
        {
            this._printDoc.BeginPrint += new PrintEventHandler(this.printDoc_BeginPrint);
            this._printDoc.PrintPage += new PrintPageEventHandler(this.printDoc_PrintPage);
            this._printDoc.EndPrint += new PrintEventHandler(this._printDoc_EndPrint);
        }

        private void _printDoc_EndPrint(object sender, PrintEventArgs e)
        {
        }

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int width, int height);
        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hWnd);
        private Image GetImage(IntPtr handle, int width, int height)
        {
            IntPtr dC = GetDC(IntPtr.Zero);
            Image image = Image.FromHbitmap(CreateCompatibleBitmap(dC, width, height));
            Graphics graphics = Graphics.FromImage(image);
            IntPtr hdc = graphics.GetHdc();
            SendMessage(handle, 0x318, hdc, 0x16);
            graphics.ReleaseHdc(hdc);
            ReleaseDC(IntPtr.Zero, dC);
            return image;
        }

        private void PrepareTreeImage(System.Windows.Forms.TreeView tree)
        {
            this._scrollBarWidth = tree.Width - tree.ClientSize.Width;
            this._scrollBarHeight = tree.Height - tree.ClientSize.Height;
            tree.Nodes[0].EnsureVisible();
            int height = tree.Nodes[0].Bounds.Height;
            this._nodeHeight = height;
            int right = tree.Nodes[0].Bounds.Right;
            for (TreeNode node = tree.Nodes[0].NextVisibleNode; node != null; node = node.NextVisibleNode)
            {
                height += node.Bounds.Height;
                if (node.Bounds.Right > right)
                {
                    right = node.Bounds.Right;
                }
            }
            int num2 = tree.Height;
            int width = tree.Width;
            BorderStyle borderStyle = tree.BorderStyle;
            bool scrollable = tree.Scrollable;
            TreeNode selectedNode = tree.SelectedNode;
            tree.SelectedNode = null;
            DockStyle dock = tree.Dock;
            tree.Height = height + this._scrollBarHeight;
            tree.Width = right + this._scrollBarWidth;
            tree.BorderStyle = BorderStyle.None;
            tree.Dock = DockStyle.None;
            this._controlImage = this.GetImage(tree.Handle, tree.Width, tree.Height);
            tree.BorderStyle = borderStyle;
            tree.Width = width;
            tree.Height = num2;
            tree.Dock = dock;
            tree.Scrollable = scrollable;
            tree.SelectedNode = selectedNode;
            Application.DoEvents();
        }

        private void printDoc_BeginPrint(object sender, PrintEventArgs e)
        {
            this._lastPrintPosition = new Point(0, 0);
            this._currentDir = PrintDirection.Horizontal;
            this._pageNumber = 0;
            this._date = DateTime.Now;
        }

        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            this._pageNumber++;
            Graphics graphics = e.Graphics;
            Rectangle srcRect = new Rectangle(this._lastPrintPosition, e.MarginBounds.Size);
            Rectangle marginBounds = e.MarginBounds;
            if ((srcRect.Height % this._nodeHeight) > 0)
            {
                srcRect.Height -= srcRect.Height % this._nodeHeight;
            }
            graphics.DrawImage(this._controlImage, marginBounds, srcRect, GraphicsUnit.Pixel);
            if (((this._controlImage.Height - this._scrollBarHeight) > srcRect.Bottom) || ((this._controlImage.Width - this._scrollBarWidth) > srcRect.Right))
            {
                e.HasMorePages = true;
            }
            if (this._currentDir == PrintDirection.Horizontal)
            {
                if (srcRect.Right < (this._controlImage.Width - this._scrollBarWidth))
                {
                    this._lastPrintPosition.X += srcRect.Width + 1;
                }
                else
                {
                    this._lastPrintPosition.X = 0;
                    this._lastPrintPosition.Y += srcRect.Height + 1;
                    this._currentDir = PrintDirection.Vertical;
                }
            }
            else if ((this._currentDir == PrintDirection.Vertical) && (srcRect.Right < (this._controlImage.Width - this._scrollBarWidth)))
            {
                this._currentDir = PrintDirection.Horizontal;
                this._lastPrintPosition.X += srcRect.Width + 1;
            }
            else
            {
                this._lastPrintPosition.Y += srcRect.Height + 1;
            }
            Brush brush = new SolidBrush(Color.Black);
            string text = this._pageNumber.ToString(NumberFormatInfo.CurrentInfo);
            Font font = new Font(FontFamily.GenericSansSerif, 10f);
            SizeF ef = graphics.MeasureString(text, font);
            PointF tf2 = new PointF((float)(((double)e.PageBounds.Width) / 2.0), (float)(e.MarginBounds.Bottom + (((double)(e.PageBounds.Bottom - e.MarginBounds.Bottom)) / 2.0)));
            PointF point = new PointF(tf2.X - (ef.Width / 2f), tf2.Y - (ef.Height / 2f));
            graphics.DrawString(text, font, brush, point);
            if ((this._pageNumber == 1) && (this._title.Length > 0))
            {
                SizeF ef2 = graphics.MeasureString(this._title, this.headerfont);
                PointF tf3 = new PointF((float)e.MarginBounds.Left, ((float)(((double)(e.MarginBounds.Top - e.PageBounds.Top)) / 2.0)) - (ef2.Height / 2f));
                graphics.DrawString(this._title, this.headerfont, brush, tf3);
            }
        }

        public void PrintPreviewTree(System.Windows.Forms.TreeView tree, string title, Font fnt)
        {
            this._title = title;
            this.headerfont = new Font(FontFamily.GenericSansSerif, 16f, FontStyle.Bold, GraphicsUnit.Point);
            if (fnt != null)
            {
                this.headerfont = fnt;
            }
            this.PrepareTreeImage(tree);
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            dialog.Document = this._printDoc;
            dialog.Show();
        }

        public void PrintTree(System.Windows.Forms.TreeView tree, string title, Font fnt)
        {
            this._title = title;
            this.headerfont = new Font(FontFamily.GenericSansSerif, 16f, FontStyle.Bold, GraphicsUnit.Point);
            if (fnt != null)
            {
                this.headerfont = fnt;
            }
            this.PrepareTreeImage(tree);
            PrintDialog dialog = new PrintDialog();
            dialog.Document = this._printDoc;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this._printDoc.Print();
            }
        }

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, int lParam);

        // Nested Types
        private enum PrintDirection
        {
            Horizontal,
            Vertical
        }
    }


}