namespace ExtendedControls.ExtendedToolkit.ErrorReporting.Classes.DrDump
{
    /// <summary>
    /// Adapted from CrashReporter .NET.
    /// </summary>
    internal class DrDumpService
    {
        #region Delegates & Events
        public delegate void SendRequestCompletedEventHandler(object sender, SendRequestCompletedEventArgs e);

        public event SendRequestCompletedEventHandler SendRequestCompleted;
        #endregion

        #region Variables
        //private SendRequestState _sendRequestState;
        #endregion
    }
}