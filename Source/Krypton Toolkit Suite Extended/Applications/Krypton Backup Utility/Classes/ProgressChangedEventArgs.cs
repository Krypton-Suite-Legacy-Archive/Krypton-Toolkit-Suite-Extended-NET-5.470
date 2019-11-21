using KryptonBackupUtility.Enumerations;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace KryptonBackupUtility.Classes
{
    public class ProgressChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the value of the current activity as a member of the
        /// Activity enumerations.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public OperationType CurrentActivity
        {
            get
            {
                return Copy._currentOperation;
            }
        }

        /// <summary>
        /// Gets a formatted string indicating the current activity.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string CurrentActivityString
        {
            get
            {
                switch (Copy._currentOperation)
                {
                    case OperationType.COPYING:
                        return "Copying Directories/Files";
                    case OperationType.ENUMERATINGDIRECTORIES:

                        return "Enumerating Directories";
                    case OperationType.ENUMERATINGFILES:
                        return "Enumerating Files";
                    default:
                        return Copy._currentOperation.ToString();
                }
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
        public string GetTotalFileCountString(bool includeTotalSize = false)
        {
            if (Copy._totalFileCount == 0)
            {
                return "Unknown";
            }
            else if (includeTotalSize)
            {
                return string.Format("{0:n0} ({1})", Copy._totalFileCount, Utilities.ShowTotalFileSize(Copy._totalFilesSize));
            }
            else
            {
                return Copy._totalFileCount.ToString("n0");
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

        public int CurrentFileCount
        {
            get
            {
                return Copy._currentFileCount;
            }
        }

        public string CurrentFileCountString
        {
            get
            {
                return Copy._currentFileCount.ToString("n0");
            }
        }

        public long CumulativeFileSize
        {
            get
            {
                return Copy._cumulativeFileSize;
            }
        }

        public string CumulativeFileSizeString
        {
            get
            {
                return Utilities.ShowTotalFileSize(Copy._cumulativeFileSize);
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

        /// <summary>
        /// Gets the value of the current progress as a percentage.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public double CurrentProgress
        {
            get
            {
                if (Copy._totalFileCount == 0)
                {
                    return 0;
                }
                else
                {
                    return Copy._currentFileCount / (double)Copy._totalFileCount;
                }
            }
        }

        /// <summary>
        /// Gets the value of the current progress as a percentage, formatted for
        /// use with a ProgressBar control. Note that you need to set the ProgressBar's
        /// .Minimum to 0 and .Maximum to 100 in order to use this value directly.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int CurrentProgressForProgressBar
        {
            get
            {
                return Conversions.ToInteger(CurrentProgress * 100);
            }
        }

        /// <summary>
        /// Gets a formatted string showing the value of the current progress as a percentage.
        /// </summary>
        /// <param name="numberOfDecimalPlaces">OPTIONAL: The number of decimal places to show
        /// in the string returned. Default: 0.</param>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string GetCurrentProgressString(int numberOfDecimalPlaces = 0)
        {
            if (numberOfDecimalPlaces < 0 || numberOfDecimalPlaces > 8)
            {
                numberOfDecimalPlaces = 0;
            }

            string formatter = "p" + numberOfDecimalPlaces.ToString();

            return CurrentProgress.ToString(formatter);
        }

        /// <summary>
        /// Gets a boolean value indicating whether or not the user has elected to cancel the operation.
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
    }
}