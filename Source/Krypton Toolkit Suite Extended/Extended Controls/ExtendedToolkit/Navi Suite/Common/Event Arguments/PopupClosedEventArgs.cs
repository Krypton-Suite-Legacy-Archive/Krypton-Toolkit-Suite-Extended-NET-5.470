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

using System;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.NaviSuite.Common.EventArguments
{
    /// <summary>
    /// Contains event information for a <see cref="PopupClosed"/> event.
    /// </summary>
    public class PopupClosedEventArgs : EventArgs
    {
        /// <summary>
        /// The popup form.
        /// </summary>
        private Form popup = null;

        /// <summary>
        /// Gets the popup form which is being closed.
        /// </summary>
        public Form Popup
        {
            get { return popup; }
        }

        /// <summary>
        /// Constructs a new instance of this class for the specified
        /// popup form.
        /// </summary>
        /// <param name="popup">Popup Form which is being closed.</param>
        public PopupClosedEventArgs(Form popup)
        {
            this.popup = popup;
        }
    }

    /// <summary>
    /// Represents the method which responds to a <see cref="PopupClosed"/> event.
    /// </summary>
    public delegate void PopupClosedEventHandler(object sender, PopupClosedEventArgs e);
}