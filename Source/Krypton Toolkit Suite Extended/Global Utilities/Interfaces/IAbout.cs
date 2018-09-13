using System;
using System.Drawing;

namespace GlobalUtilities.Interfaces
{
    public interface IAbout
    {
        /// <summary>
        /// Gets or sets a value indicating whether [use icon].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use icon]; otherwise, <c>false</c>.
        /// </value>
        bool UseIcon { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show system information button].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show system information button]; otherwise, <c>false</c>.
        /// </value>
        bool ShowSystemInformationButton { get; set; }

        /// <summary>
        /// Gets or sets the creation date time.
        /// </summary>
        /// <value>
        /// The creation date time.
        /// </value>
        DateTime CreationDateTime { get; set; }

        /// <summary>
        /// Gets or sets the name of the application.
        /// </summary>
        /// <value>
        /// The name of the application.
        /// </value>
        String ApplicationName { get; set; }

        /// <summary>
        /// Gets or sets the application version.
        /// </summary>
        /// <value>
        /// The application version.
        /// </value>
        Version ApplicationVersion { get; set; }

        /// <summary>
        /// Gets or sets the framework version.
        /// </summary>
        /// <value>
        /// The framework version.
        /// </value>
        Version FrameworkVersion { get; set; }

        Icon ApplicationIcon { get; set; }

        Bitmap ApplicationIconImage { get; set; }

        string AuthourName { get; set; }

        string InstallLocation { get; set; }
    }
}