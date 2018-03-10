using KryptonApplicationUpdater.Interfaces;
using System;

namespace KryptonApplicationUpdater.Classes
{
    public class XMLFileParser
    {
        #region Variables
        private string _xmlFilePath, _applicationIdentifier, _applicationName, _serverVersion, _updatePackageType, _updatePackageSeverity, _updatePackageName, _updatePackageServerURLDownloadLocation, _changelogServerURLDownloadLocation, _specialisedUpdateIconURL, _md5Checksum, _sha1Checksum, _sha256Checksum, _sha384Checksum, _sha512Checksum, _ripemd160Checksum, _updatePackageBuildString, _optionalArguments, _checksumFileURL;

        private bool _betaFlag, _startUpdateInstallationUponDownloadCompletion;

        private DateTime _updatePackageReleaseDate, _updatePackageBuildDate;

        private long _updatePackageFileSize;

        private IUpdatable _updatable;

        private IXMLData _data;
        #endregion

        #region Constructors
        public XMLFileParser()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Parses the XML file.
        /// </summary>
        /// <param name="xmlFilePath">The XML file path.</param>
        public void ParseXMLFile(string xmlFilePath)
        {

        }

        /// <summary>
        /// Parses the XML file.
        /// </summary>
        /// <param name="xmlFilePath">The XML file path.</param>
        /// <param name="applicationIdentifier">The application identifier.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="serverVersion">The server version.</param>
        /// <param name="updatePackageType">Type of the update package.</param>
        /// <param name="updatePackageSeverity">The update package severity.</param>
        /// <param name="updatePackageName">Name of the update package.</param>
        /// <param name="updatePackageServerURLDownloadLocation">The update package server URL download location.</param>
        /// <param name="changelogServerURLDownloadLocation">The changelog server URL download location.</param>
        /// <param name="specialisedUpdateIconURL">The specialised update icon URL.</param>
        /// <param name="md5Checksum">The MD5 checksum.</param>
        /// <param name="sha1Checksum">The sha1 checksum.</param>
        /// <param name="sha256Checksum">The sha256 checksum.</param>
        /// <param name="sha384Checksum">The sha384 checksum.</param>
        /// <param name="sha512Checksum">The sha512 checksum.</param>
        /// <param name="ripemd160Checksum">The ripemd160 checksum.</param>
        /// <param name="updatePackageBuildString">The update package build string.</param>
        /// <param name="optionalArguments">The optional arguments.</param>
        /// <param name="checksumFileURL">The checksum file URL.</param>
        /// <param name="betaFlag">if set to <c>true</c> [beta flag].</param>
        /// <param name="startUpdateInstallationUponDownloadCompletion">if set to <c>true</c> [start update installation upon download completion].</param>
        /// <param name="updatePackageReleaseDate">The update package release date.</param>
        /// <param name="updatePackageBuildDate">The update package build date.</param>
        /// <param name="updatePackageFileSize">Size of the update package file.</param>
        public void ParseXMLFile(string xmlFilePath, string applicationIdentifier, string applicationName, string serverVersion, string updatePackageType, string updatePackageSeverity, string updatePackageName, string updatePackageServerURLDownloadLocation, string changelogServerURLDownloadLocation, string specialisedUpdateIconURL, string md5Checksum, string sha1Checksum, string sha256Checksum, string sha384Checksum, string sha512Checksum, string ripemd160Checksum, string updatePackageBuildString, string optionalArguments, string checksumFileURL, bool betaFlag, bool startUpdateInstallationUponDownloadCompletion, DateTime updatePackageReleaseDate, DateTime updatePackageBuildDate, long updatePackageFileSize)
        {
            _xmlFilePath = xmlFilePath;

            _applicationIdentifier = applicationIdentifier;

            _applicationName = applicationName;

            _serverVersion = serverVersion;
        }
        #endregion
    }
}