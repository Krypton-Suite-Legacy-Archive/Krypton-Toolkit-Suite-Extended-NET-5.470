using ExtendedControls.Components.ScintillaNET.Classes;
using System;

namespace ExtendedControls.Components.ScintillaNET.EventArgumentHandlers
{
    // For internal use only
    internal sealed class SCNotificationEventArgs : EventArgs
    {
        public NativeMethods.SCNotification SCNotification { get; private set; }

        public SCNotificationEventArgs(NativeMethods.SCNotification scn)
        {
            SCNotification = scn;
        }
    }
}