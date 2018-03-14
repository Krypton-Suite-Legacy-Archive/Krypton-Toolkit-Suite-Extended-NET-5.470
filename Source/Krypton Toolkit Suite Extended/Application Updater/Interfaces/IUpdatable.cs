using System;
using System.Drawing;
using System.Windows.Forms;

namespace KryptonApplicationUpdater.Interfaces
{
    /// <summary>
    /// Basic updater information.
    /// </summary>
    public interface IUpdatable
    {
        /// <summary>
        /// Gets or sets the application icon.
        /// </summary>
        /// <value>
        /// The application icon.
        /// </value>
        Icon ApplicationIcon { get; set; }

        /// <summary>
        /// Gets or sets the server XML file URL.
        /// </summary>
        /// <value>
        /// The server XML file URL.
        /// </value>
        String ServerXMLFileURL { get; set; }

        /// <summary>
        /// Gets or sets the name of the application.
        /// </summary>
        /// <value>
        /// The name of the application.
        /// </value>
        String ApplicationName { get; set; }

        /// <summary>
        /// Gets or sets the current application version.
        /// </summary>
        /// <value>
        /// The current application version.
        /// </value>
        String CurrentApplicationVersion { get; set; }

        /// <summary>
        /// Gets or sets the parent form.
        /// </summary>
        /// <value>
        /// The parent form.
        /// </value>
        Form ParentForm { get; set; }

        /// <summary>
        /// Gets or sets the application identification.
        /// </summary>
        /// <value>
        /// The application identification.
        /// </value>
        String ApplicationIdentification { get; set; }
    }
}