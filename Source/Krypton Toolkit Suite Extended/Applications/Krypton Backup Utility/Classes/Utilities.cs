using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Text;

namespace KryptonBackupUtility.Classes
{
    public sealed class Utilities
    {
        public delegate string ShowTotalFileSizeDelegate(long bytes);

        /// <summary>
        /// A formatting function to return the number of bytes using common names for units of measure.
        /// </summary>
        /// <param name="bytes">The size (type Long) of the file.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static string ShowTotalFileSize(long bytes)
        {
            string stringToReturn = "";

            if (bytes < 1024)
                stringToReturn = bytes.ToString("n0") + " bytes";
            else if (bytes < 1024 * 1024)
                stringToReturn = (bytes / (double)1024).ToString("n0") + " kB";
            else if (bytes >= 1024 * 1024 && bytes < 1024 * 1024 * 1024)
                stringToReturn = (bytes / (double)(1024 * 1024)).ToString("n1") + " Megs";
            else if (bytes >= 1024 * 1024 * 1024 && bytes < 1099511627776)
                stringToReturn = (bytes / (double)(1024 * 1024 * 1024)).ToString("n2") + " Gigs";
            else
                stringToReturn = (bytes / (double)1099511627776).ToString("n1") + " TeraBytes";

            return stringToReturn;
        }

        /// <summary>
        /// A formatting function to return the number of bytes using common names for units of measure.
        /// </summary>
        /// <param name="bytes">The size (type Double) of the file.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static string ShowTotalFileSize(double bytes)
        {
            string stringToReturn = "";

            if (bytes < 1024)
                stringToReturn = bytes.ToString("n1") + " bytes";
            else if (bytes < 1024 * 1024)
                stringToReturn = (bytes / 1024).ToString("n0") + " kB";
            else if (bytes >= 1024 * 1024 && bytes < 1024 * 1024 * 1024)
                stringToReturn = (bytes / (1024 * 1024)).ToString("n1") + " Megs";
            else if (bytes >= 1024 * 1024 * 1024 && bytes < 1099511627776)
                stringToReturn = (bytes / (1024 * 1024 * 1024)).ToString("n2") + " Gigs";
            else
                stringToReturn = (bytes / 1099511627776).ToString("n1") + " TeraBytes";

            return stringToReturn;
        }

        public delegate string ConvertSecsToStringDelegate(double totalSeconds, bool showDays, bool showHours);

        /// <summary>
        /// A formatting function to return the amount of time elapsed, based on the number of seconds entered.
        /// </summary>
        /// <param name="totalSeconds">The number of seconds to evaluate (type: Double).</param>
        /// <param name="showDays">Indicate whether or not to show the number of days in the result.</param>
        /// <param name="showHours">Indicate whether or not to show the number of hours in the result.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static string ConvertSecsToString(double totalSeconds, bool showDays, bool showHours)
        {
            string returnString = "";

            if (totalSeconds >= 0 & totalSeconds <= double.MaxValue)
            {
                var totalTime = TimeSpan.FromSeconds(totalSeconds);
                string daysString = "";
                string hoursString = "";
                string minutesString = "";
                string secondsString = "";

                if (showDays)
                {
                    daysString = totalTime.Days.ToString("f0");
                    hoursString = totalTime.Hours.ToString("00");
                    minutesString = totalTime.Minutes.ToString("00");
                    secondsString = totalTime.Seconds.ToString("00");
                    returnString = string.Format("{0}:{1}:{2}:{3}", daysString, hoursString, minutesString, secondsString);
                }
                else if (showHours)
                {
                    hoursString = (totalTime.Days * 24 + totalTime.Hours).ToString("00");
                    minutesString = totalTime.Minutes.ToString("00");
                    secondsString = totalTime.Seconds.ToString("00");
                    returnString = string.Format("{0}:{1}:{2}", hoursString, minutesString, secondsString);
                }
                else
                {
                    int additionalMinutes = (totalTime.Days * 24 + totalTime.Hours) * 60;
                    minutesString = (totalTime.Minutes + additionalMinutes).ToString("00");
                    secondsString = totalTime.Seconds.ToString("00");
                    returnString = string.Format("{0}:{1}", minutesString, secondsString);
                }
            }
            else
                returnString = "N/A";

            return returnString;
        }

        public delegate string ReturnShortStringDelegate(string str, int maxLength);

        /// <summary>
        /// This will return a shortened version of your string based on the maxLength you specify.
        /// </summary>
        /// <param name="str">The string to shorten.</param>
        /// <param name="maxLength">The maximum characters to return.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static string ReturnShortString(string str, int maxLength)
        {
            if (str == null)
                return "";
            else if (str.Length <= maxLength)
                return str;
            else
            {
                int leftEndPosition = Conversions.ToInteger(maxLength / (double)2 - 2.5);
                int rightStartPosition = str.Length - Conversions.ToInteger(maxLength / (double)2 - 2.5);

                StringBuilder sb = new StringBuilder();

                sb.AppendFormat("{0} ... {1}", str.Substring(0, leftEndPosition), str.Substring(rightStartPosition));

                return sb.ToString();
            }
        }
    }
}