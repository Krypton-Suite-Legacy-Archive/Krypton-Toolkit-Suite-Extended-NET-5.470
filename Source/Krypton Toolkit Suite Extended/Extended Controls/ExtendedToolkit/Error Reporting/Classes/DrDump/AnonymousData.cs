using System;

namespace ExtendedControls.ExtendedToolkit.ErrorReporting.Classes.DrDump
{
    /// <summary>
    /// Adapted from CrashReporter .NET.
    /// </summary>
    internal class AnonymousData
    {
        public Exception Exception { get; set; }

        public string ToEMail { get; set; }

        public Guid? ApplicationID { get; set; }
    }
}