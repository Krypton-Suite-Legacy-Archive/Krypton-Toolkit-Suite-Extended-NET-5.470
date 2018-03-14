using System;
namespace KryptonApplicationUpdater.Interfaces
{
    /// <summary>
    /// XML update file data.
    /// </summary>
    public interface IXMLData
    {
        /// <summary>
        /// Gets or sets the application identifier.
        /// </summary>
        /// <value>
        /// The application identifier.
        /// </value>
        String ApplicationIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the server version.
        /// </summary>
        /// <value>
        /// The server version.
        /// </value>
        String ServerVersion { get; set; }

        /// <summary>
        /// Gets or sets the type of the update package.
        /// </summary>
        /// <value>
        /// The type of the update package.
        /// </value>
        String UpdatePackageType { get; set; }

        /// <summary>
        /// Gets or sets the update package severity.
        /// </summary>
        /// <value>
        /// The update package severity.
        /// </value>
        String UpdatePackageSeverity { get; set; }

        /// <summary>
        /// Gets or sets the name of the update package.
        /// </summary>
        /// <value>
        /// The name of the update package.
        /// </value>
        String UpdatePackageName { get; set; }

        /// <summary>
        /// Gets or sets the update package server URL download location.
        /// </summary>
        /// <value>
        /// The update package server URL download location.
        /// </value>
        String UpdatePackageServerURLDownloadLocation { get; set; }

        /// <summary>
        /// Gets or sets the changelog server URL download location.
        /// </summary>
        /// <value>
        /// The changelog server URL download location.
        /// </value>
        String ChangelogServerURLDownloadLocation { get; set; }

        /// <summary>
        /// Gets or sets the specialised update icon URL.
        /// </summary>
        /// <value>
        /// The specialised update icon URL.
        /// </value>
        String SpecialisedUpdateIconURL { get; set; }

        /// <summary>
        /// Gets or sets the MD5 checksum.
        /// </summary>
        /// <value>
        /// The MD5 checksum.
        /// </value>
        String MD5Checksum { get; set; }

        /// <summary>
        /// Gets or sets the SHA1 checksum.
        /// </summary>
        /// <value>
        /// The SHA1 checksum.
        /// </value>
        String SHA1Checksum { get; set; }

        /// <summary>
        /// Gets or sets the SHA256 checksum.
        /// </summary>
        /// <value>
        /// The SHA256 checksum.
        /// </value>
        String SHA256Checksum { get; set; }

        /// <summary>
        /// Gets or sets the SHA384 checksum.
        /// </summary>
        /// <value>
        /// The SHA384 checksum.
        /// </value>
        String SHA384Checksum { get; set; }

        /// <summary>
        /// Gets or sets the SHA512 checksum.
        /// </summary>
        /// <value>
        /// The SHA512 checksum.
        /// </value>
        String SHA512Checksum { get; set; }

        /// <summary>
        /// Gets or sets the RIPEMD160 checksum.
        /// </summary>
        /// <value>
        /// The RIPEMD160 checksum.
        /// </value>
        String RIPEMD160Checksum { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [start update installation upon download completion].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [start update installation upon download completion]; otherwise, <c>false</c>.
        /// </value>
        bool StartUpdateInstallationUponDownloadCompletion { get; set; }

        /// <summary>
        /// Gets or sets the update package release date.
        /// </summary>
        /// <value>
        /// The update package release date.
        /// </value>
        DateTime UpdatePackageReleaseDate { get; set; }

        /// <summary>
        /// Gets or sets the size of the update package file.
        /// </summary>
        /// <value>
        /// The size of the update package file.
        /// </value>
        long UpdatePackageFileSize { get; set; }

        /// <summary>
        /// Gets or sets the optional arguments.
        /// </summary>
        /// <value>
        /// The optional arguments.
        /// </value>
        String OptionalArguments { get; set; }

        /// <summary>
        /// Gets or sets the update package build date.
        /// </summary>
        /// <value>
        /// The update package build date.
        /// </value>
        DateTime UpdatePackageBuildDate { get; set; }

        /// <summary>
        /// Gets or sets the update package build string.
        /// </summary>
        /// <value>
        /// The update package build string.
        /// </value>
        String UpdatePackageBuildString { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [beta flag].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [beta flag]; otherwise, <c>false</c>.
        /// </value>
        bool BetaFlag { get; set; }

        /// <summary>
        /// Gets or sets the checksum file URL.
        /// </summary>
        /// <value>
        /// The checksum file URL.
        /// </value>
        String ChecksumFileURL { get; set; }

        /// <summary>
        /// Gets or sets the install countdown.
        /// </summary>
        /// <value>
        /// The install countdown.
        /// </value>
        int InstallCountdown { get; set; }

        /// <summary>
        /// Gets or sets the virus total scan URL.
        /// </summary>
        /// <value>
        /// The virus total scan URL.
        /// </value>
        String VirusTotalScanURL { get; set; }
    }
}