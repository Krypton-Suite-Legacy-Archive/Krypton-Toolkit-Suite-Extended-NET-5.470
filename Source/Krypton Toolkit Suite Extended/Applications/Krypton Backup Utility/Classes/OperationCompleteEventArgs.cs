using System;

namespace KryptonBackupUtility.Classes
{
    public class OperationCompleteEventArgs : EventArgs
    {
        private Copy _copy = new Copy();

        /// <summary>
        /// Gets the exception which was thrown (if any) during the operation.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public Exception OperationException
        {
            get
            {
                return Copy._operationException;
            }
        }

        /// <summary>
        /// Gets a boolean value indicating whether or not the user cancelled the operation.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool UserCancelledOperation
        {
            get
            {
                return Copy._userCancel;
            }
        }

        /// <summary>
        /// Gets the total number of files found in all directory paths
        /// based on your specifications for finding them.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int TotalFileCount
        {
            get
            {
                return Copy._totalFileCount;
            }
        }

        /// <summary>
        /// Gets a formatted string showing the total number of files found
        /// in all directory paths based on your specifications for finding them.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string TotalFileCountString
        {
            get
            {
                if (Copy._totalFileCount == 0)
                {
                    return "Unknown";
                }
                else
                {
                    return Copy._totalFileCount.ToString("n0");
                }
            }
        }

        /// <summary>
        /// Gets the total number of directories found in all directory paths
        /// based on your specifications for finding them.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int TotalDirectoryCount
        {
            get
            {
                return Copy._totalDirectoryCount;
            }
        }

        /// <summary>
        /// Gets a formatted string showing the total number of directories
        /// found in all directory paths based on your specifications for finding them.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string TotalDirectoryCountString
        {
            get
            {
                if (Copy._totalDirectoryCount == 0)
                {
                    return "Unknown";
                }
                else
                {
                    return Copy._totalDirectoryCount.ToString("n0");
                }
            }
        }

        public long TotalFilesSize
        {
            get
            {
                return Copy._totalFilesSize;
            }
        }

        public string TotalFilesSizeString
        {
            get
            {
                return Utilities.ShowTotalFileSize(Copy._totalFilesSize);
            }
        }

        /// <summary>
        /// Gets the amount of time which has elapsed since the operation began.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public TimeSpan Elapsed
        {
            get
            {
                return Copy._operationSW.Elapsed;
            }
        }

        /// <summary>
        /// Gets a formatted string showing the amount of time which has elapsed
        /// since the operation began.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks>
        /// <para>Note that this function is set up to return the string
        /// formatted as mm:ss if the value is less than one hour, or as hh:mm:ss
        /// if the value is an hour or greater.</para>
        /// </remarks>
        public string ElapsedString
        {
            get
            {
                if (Copy._operationSW.Elapsed.TotalSeconds > 3600)
                {
                    return Utilities.ConvertSecsToString(Elapsed.TotalSeconds, false, true);
                }
                else
                {
                    return Utilities.ConvertSecsToString(Elapsed.TotalSeconds, false, false);
                }
            }
        }

        public void Dispose()
        {
            if (_copy.BackgroundWorker != null)
            {
                _copy.BackgroundWorker.Dispose();

                _copy.BackgroundWorker = null;
            }

            if (_copy.Timer != null)
            {
                _copy.Timer.Dispose();

                _copy.Timer = null;
            }
        }
    }
}