#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using ExtendedControls.ExtendedToolkit.Controls.Drawing.UI;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.Controls.Drawing.Controls
{
    [ToolboxBitmap(typeof(ColorDialog))]
    public partial class Office2007ColourPicker : ComboBox
    {
        #region Designer Code
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }

        #endregion

        #endregion

        private Office2007MenuHelper _colourPlate;

        [Browsable(true)]
        public event EventHandler SelectedColourChanged;

        [Browsable(true)]
        public Color Color
        {
            get { return this._colourPlate.ColourPlate.SelectedColour; }
            set
            {
                this._colourPlate.ColourPlate.SelectedColour = value;
                //this.Refresh();
            }
        }

        public Office2007ColourPicker()
        {
            InitializeComponent();
            OnInit();
        }

        public Office2007ColourPicker(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            OnInit();
        }

        private void OnInit()
        {
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.Items.Add("Color");
            this.SelectedIndex = 0;

            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DropDownStyle = ComboBoxStyle.DropDownList;

            _colourPlate = new Office2007MenuHelper();
            _colourPlate.ColourPlate.SelectedColourChanged += new EventHandler(colourPlate_SelectedColourChanged);
        }

        private void colourPlate_SelectedColourChanged(object sender, EventArgs e)
        {
            if (SelectedColourChanged != null)
                SelectedColourChanged(this, new EventArgs());

        }

        private void ShowDropDown()
        {
            if (_colourPlate != null)
            {
                _colourPlate.Show(this, new Point(0, this.Height));
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            ShowDropDown();
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);
        }

        protected override void OnBindingContextChanged(EventArgs e)
        {
            base.OnBindingContextChanged(e);
            if (this.Items.Count != 1)
            {
                this.Items.Clear();
                this.Items.Add("Color");
                this.SelectedIndex = 0;
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                // Paints the rectangle by the current color.
                e.Graphics.FillRectangle(new SolidBrush(this.Color), e.Bounds);
                Rectangle rec = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1);

                if ((e.State & DrawItemState.Focus) == 0)
                {
                    // Draw the border rectangle
                    using (Pen pen = new Pen(Color.LightGray))
                    {
                        e.Graphics.DrawRectangle(pen, rec);
                    }
                }
                else
                {
                    // Draw the border rectangle
                    using (Pen borderPen = new Pen(Color.LightGray, 1))
                    {
                        e.Graphics.DrawRectangle(borderPen, rec);
                    }
                    // Draw the focus rectangle
                    Pen focusPen = new Pen(Color.Gray, 1);
                    focusPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    e.Graphics.DrawRectangle(focusPen, rec);
                    focusPen.Dispose();
                }
            }
        }

        #region WndProc Code

        protected override void WndProc(ref Message m)
        {
            /*
			 if (m.Msg == (WM_REFLECT + WM_COMMAND))
			{
				if (HIWord((int)m.WParam) == CBN_DROPDOWN)
				{
					ShowDropDown();
					return;
				}
			}
			 */
            base.WndProc(ref m);
        }

        private const int WM_USER = 0x0400;
        private const int WM_REFLECT = WM_USER + 0x1C00;
        private const int WM_COMMAND = 0x0111;
        private const int CBN_DROPDOWN = 7;

        public static int HIWord(int n)
        {
            return (n >> 16) & 0xffff;
        }

        #endregion
    }
}