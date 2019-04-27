using System;
using System.ComponentModel;

namespace ExtendedControls.ExtendedToolkit.ErrorReporting.Classes.DrDump
{
    internal class SendRequestCompletedEventArgs : AsyncCompletedEventArgs
    {
        //private readonly Response _result;

        public SendRequestCompletedEventArgs(Exception error, bool cancelled, object userState) : base(error, cancelled, userState)
        {
        }
    }
}