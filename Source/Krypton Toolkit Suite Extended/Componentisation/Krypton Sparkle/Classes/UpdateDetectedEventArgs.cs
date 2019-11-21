using KryptonSparkle.Enumerations;
using System;

namespace KryptonSparkle.Classes
{
    /// <summary>
    /// Contains all information for the update detected event
    /// </summary>
    public class UpdateDetectedEventArgs : EventArgs
    {
        /// <summary>
        /// The next action
        /// </summary>
        public NextUpdateAction NextAction { get; set; }
        /// <summary>
        /// The application configuration
        /// </summary>
        public KryptonSparkleConfiguration ApplicationConfig { get; set; }
        /// <summary>
        /// The latest available version
        /// </summary>
        public KryptonSparkleAppCastItem LatestVersion { get; set; }
    }
}