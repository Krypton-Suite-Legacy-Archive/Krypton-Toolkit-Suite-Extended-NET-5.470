#region License and Copyright
/*
 
Copyright (c) Guifreaks - Jacob Mesu
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
    * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
    * Neither the name of the Guifreaks nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

*/
#endregion


using ExtendedControls.ExtendedToolkit.NaviSuite.Common.EventArguments;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.NaviSuite.Common.Classes
{
    /// <summary>
    /// A Message Loop filter which detect mouse events whilst the popup form is shown
    /// and notifies the owning <see cref="PopupWindowHelper"/> class when a mouse
    /// click outside the popup occurs.
    /// </summary>
    public class PopupWindowHelperMessageFilter : IMessageFilter
    {
        /// <summary>
        /// Raised when the Popup Window is about to be cancelled.  The
        /// <see cref="PopupCancelEventArgs.Cancel"/> property can be
        /// set to <c>true</c> to prevent the form from being cancelled.
        /// </summary>
        public event PopupCancelEventHandler PopupCancel;

        /// <summary>
        /// The popup form
        /// </summary>
        private Form popup = null;
        /// <summary>
        /// The owning <see cref="PopupWindowHelper"/> object.
        /// </summary>
        private PopupWindowHelper owner = null;

        /// <summary>
        /// Constructs a new instance of this class and sets the owning
        /// object.
        /// </summary>
        /// <param name="owner">The <see cref="PopupWindowHelper"/> object
        /// which owns this class.</param>
        public PopupWindowHelperMessageFilter(PopupWindowHelper owner)
        {
            this.owner = owner;
        }

        /// <summary>
        /// Gets/sets the popup form which is being displayed.
        /// </summary>
        public Form Popup
        {
            get
            {
                return this.popup;
            }
            set
            {
                this.popup = value;
            }
        }

        /// <summary>
        /// Checks the message loop for mouse messages whilst the popup
        /// window is displayed.  If one is detected the position is
        /// checked to see if it is outside the form, and the owner
        /// is notified if so.
        /// </summary>
        /// <param name="m">Windows Message about to be processed by the
        /// message loop</param>
        /// <returns><c>true</c> to filter the message, <c>false</c> otherwise.
        /// This implementation always returns <c>false</c>.</returns>
        public bool PreFilterMessage(ref Message m)
        {
            if (this.popup != null)
            {
                switch (m.Msg)
                {
                    case NativeMethods.WM_LBUTTONDOWN:
                    case NativeMethods.WM_RBUTTONDOWN:
                    case NativeMethods.WM_MBUTTONDOWN:
                    case NativeMethods.WM_NCLBUTTONDOWN:
                    case NativeMethods.WM_NCRBUTTONDOWN:
                    case NativeMethods.WM_NCMBUTTONDOWN:
                        OnMouseDown();
                        break;
                }
            }
            return false;
        }

        /// <summary>
        /// Checks the mouse location and calls the OnCancelPopup method
        /// if the mouse is outside the popup form.		
        /// </summary>
        private void OnMouseDown()
        {
            // Get the cursor location
            Point cursorPos = Cursor.Position;
            // Check if it is within the popup form
            if (!popup.Bounds.Contains(cursorPos))
            {
                // If not, then call to see if it should be closed
                OnCancelPopup(new PopupCancelEventArgs(popup, cursorPos));
            }
        }

        /// <summary>
        /// Raises the <see cref="PopupCancel"/> event.
        /// </summary>
        /// <param name="e">The <see cref="PopupCancelEventArgs"/> associated 
        /// with the cancel event.</param>
        protected virtual void OnCancelPopup(PopupCancelEventArgs e)
        {
            if (this.PopupCancel != null)
            {
                this.PopupCancel(this, e);
            }
            if (!e.Cancel)
            {
                owner.ClosePopup();
                // Clear reference for GC
                popup = null;
            }
        }
    }
}