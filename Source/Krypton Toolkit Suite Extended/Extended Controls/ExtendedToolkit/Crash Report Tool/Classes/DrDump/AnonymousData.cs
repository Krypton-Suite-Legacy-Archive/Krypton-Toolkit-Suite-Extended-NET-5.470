using System;

namespace ExtendedControls.ExtendedToolkit.CrashReportTool.Classes.DrDump
{
    internal class AnonymousData
    {
        /// <summary>
        /// Gets or sets the exception.
        /// </summary>
        /// <value>
        /// The exception.
        /// </value>
        public Exception Exception { get; set; }

        /// <summary>
        /// Converts to email.
        /// </summary>
        /// <value>
        /// To e mail.
        /// </value>
        public string ToEMail { get; set; }

        /// <summary>
        /// Gets or sets the application identifier.
        /// </summary>
        /// <value>
        /// The application identifier.
        /// </value>
        public Guid? ApplicationIdentifier { get; set; }
    }
}