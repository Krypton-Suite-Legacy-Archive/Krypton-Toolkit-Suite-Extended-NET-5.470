#region License
/*
    Copyright(c) 2010 2011 2012 唐锐(also tr0217)
     mailto:tr0217@163.com
     The earliest release time: 2010-12-18
     Last modification time:
     Accompanying files of necessity:
            * ToolStripContainerForm.cs
            * ToolStripPanelEx.cs
            * ExistingComponentChooser.cs
            * ExistingComponentChooser.Designer.cs
            * ExistingComponentChooser.resx
            * ToolStripPanelCollectionEditor.cs

     This file and the accompanying files of this project may be freely used provided the following
     conditions are met:
            * This copyright statement is not removed or modified.
            * The code is not sold in uncompiled form.  (Release as a compiled binary which is part
              of an application is fine)
            * The design, code, or compiled binaries are not "Re-branded".
        
     Optional:
            * Redistributions in binary form must reproduce the above copyright notice.
            * I receive a fully licensed copy of the product (regardless of whether the product is
              is free, shrinkwrap, or commercial).  This is optional, though if you release products
              which use code I've contributed to, I would appreciate a fully licensed copy.

     In addition, you may not:
            * Publicly release modified versions of the code or publicly release works derived from
              the code without express written authorization.

     NO WARRANTY:
            THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
            ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
            WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
            IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT,
            INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
            NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, 
            OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY,
            WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT(INCLUDING NEGLIGENCE OR OTHERWISE)
            ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY
            OF SUCH DAMAGE.
*/
#endregion

using ExtendedControls.ExtendedToolkit.FloatingFramework.Classes;
using ExtendedControls.ExtendedToolkit.FloatingFramework.UX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.FloatingFramework.Controls
{
    [ToolboxBitmap(typeof(FloatableToolStrip), "ToolboxBitmaps.FloatableToolStrip.bmp")]
    public class FloatableToolStrip : ToolStrip
    {
        #region Variables
        private ToolStripContainerWindow _toolStripContainerWindow;

        private Control _originalParent = null;

        private bool _aboutToFloat = false, _isFloating = false, _parentChanged = false;

        private List<ToolStripPanelExtened> _toolStripPanelExtenedList = new List<ToolStripPanelExtened>();
        #endregion

        #region Properties
        internal Control OriginalParent { get => _originalParent; }

        [Editor(typeof(ToolStripPanelCollectionEditor), typeof(UITypeEditor)), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<ToolStripPanelExtened> ToolStripPanelExtenedList { get => _toolStripPanelExtenedList; set => _toolStripPanelExtenedList = value; }

        public bool IsFloating { get => _isFloating; }

        public new bool Visible
        {
            get => base.Visible;

            set
            {
                if (_isFloating)
                {
                    _toolStripContainerWindow.Visible = value;
                }
                else
                {
                    base.Visible = value;
                }
            }
        }
        #endregion

        #region Overrides
        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);

            if (Parent != null)
            {
                if (!(Parent is ToolStripContainerWindow))
                {
                    _originalParent = Parent;

                    if (_aboutToFloat)
                    {
                        _parentChanged = true;
                    }
                }
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            Focus();
        }

        protected override void OnMouseDown(MouseEventArgs mea)
        {
            base.OnMouseDown(mea);

            if (!_isFloating && GripRectangle.Contains(mea.Location))
            {
                _aboutToFloat = true;
            }
        }

        protected override void OnMouseUp(MouseEventArgs mea)
        {
            base.OnMouseUp(mea);

            if (_parentChanged)
            {
                _parentChanged = false;

                _aboutToFloat = false;

                return;
            }

            Point p0 = PointToScreen(mea.Location), p1 = _originalParent.PointToClient(p0);

            if (_aboutToFloat && !_originalParent.ClientRectangle.Contains(p1))
            {
                if (_toolStripContainerWindow == null)
                {
                    _toolStripContainerWindow = new ToolStripContainerWindow();

                    _toolStripContainerWindow.NCLBUTTONDBLCLK += _toolStripContainerWindow_NCLBUTTONDBLCLK;

                    _toolStripContainerWindow.LocationChanged += _toolStripContainerWindow_LocationChanged;

                    _toolStripContainerWindow.FormClosing += _toolStripContainerWindow_FormClosing;
                }

                _originalParent.Controls.Remove(this);

                _toolStripContainerWindow.ToolStrip = this;

                _toolStripContainerWindow.Location = p0;

                _toolStripContainerWindow.Show(Parent.Parent);

                _aboutToFloat = false;

                _isFloating = true;
            }
        }
        #endregion

        #region Runtime Methods
        [DllImport("User32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void GetCursorPosition(out Point point);
        #endregion

        #region Event Handlers
        private void _toolStripContainerWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;

                _toolStripContainerWindow.Visible = false;

                base.OnVisibleChanged(new EventArgs());
            }
        }

        private void _toolStripContainerWindow_LocationChanged(object sender, EventArgs e)
        {
            Point point;

            if (_parentChanged)
            {
                _parentChanged = false;
            }

            GetCursorPosition(out point);

            foreach (ToolStripPanelExtened item in _toolStripPanelExtenedList)
            {
                if (item.ActiveRectangle.Contains(item.PointToClient(point)))
                {
                    _toolStripContainerWindow.Controls.Remove(this);

                    item.SuspendLayout();

                    base.Dock = DockStyle.None;

                    base.Anchor = AnchorStyles.Top | AnchorStyles.Left;

                    item.Controls.Add(this);

                    item.ResumeLayout();

                    _toolStripContainerWindow.Hide();

                    _isFloating = false;

                    _parentChanged = false;

                    if (_originalParent.Parent != null)
                    {
                        _originalParent.Parent.Focus();
                    }
                    else
                    {
                        _originalParent.Focus();
                    }

                    return;
                }
            }
        }

        private void _toolStripContainerWindow_NCLBUTTONDBLCLK(object sender, EventArgs e)
        {
            _toolStripContainerWindow.Controls.Remove(this);

            _toolStripContainerWindow.Visible = false;

            _originalParent.SuspendLayout();

            base.Dock = DockStyle.None;

            base.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            _originalParent.Controls.Add(this);

            _originalParent.ResumeLayout();

            _isFloating = false;
        }
        #endregion
    }
}