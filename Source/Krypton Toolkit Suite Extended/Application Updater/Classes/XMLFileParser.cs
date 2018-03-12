using KryptonApplicationUpdater.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KryptonApplicationUpdater.Classes
{
    public class XMLFileParser : IXMLData, IUpdatable
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

        #region IXMLData Implementation
        public string ApplicationIdentifier { get { return _applicationIdentifier; } set { _applicationIdentifier = value; } }
        public string ServerVersion { get { return _serverVersion; } set { _serverVersion = value; } }
        public string UpdatePackageType { get { return _updatePackageType; } set { _updatePackageType = value; } }
        public string UpdatePackageSeverity { get { return _updatePackageSeverity; } set { _updatePackageSeverity = value; } }
        public string UpdatePackageName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UpdatePackageServerURLDownloadLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ChangelogServerURLDownloadLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SpecialisedUpdateIconURL { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MD5Checksum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SHA1Checksum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SHA256Checksum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SHA384Checksum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SHA512Checksum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string RIPEMD160Checksum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool StartUpdateInstallationUponDownloadCompletion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UpdatePackageReleaseDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long UpdatePackageFileSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OptionalArguments { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UpdatePackageBuildDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UpdatePackageBuildString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool BetaFlag { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ChecksumFileURL { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        #region IUpdatable Implementation
        public Icon ApplicationIcon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ServerXMLFileURL { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CurrentApplicationVersion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Form ParentForm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
        /// Writes the data.
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
        public void WriteData(string xmlFilePath, string applicationIdentifier, string applicationName, string serverVersion, string updatePackageType, string updatePackageSeverity, string updatePackageName, string updatePackageServerURLDownloadLocation, string changelogServerURLDownloadLocation, string specialisedUpdateIconURL, string md5Checksum, string sha1Checksum, string sha256Checksum, string sha384Checksum, string sha512Checksum, string ripemd160Checksum, string updatePackageBuildString, string optionalArguments, string checksumFileURL, bool betaFlag, bool startUpdateInstallationUponDownloadCompletion, DateTime updatePackageReleaseDate, DateTime updatePackageBuildDate, long updatePackageFileSize)
        {
            _xmlFilePath = xmlFilePath;

            _applicationIdentifier = applicationIdentifier;

            _applicationName = applicationName;

            _serverVersion = serverVersion;

            _updatePackageType = updatePackageType;

            _updatePackageSeverity = updatePackageSeverity;

            _updatePackageName = updatePackageName;

            _updatePackageServerURLDownloadLocation = updatePackageServerURLDownloadLocation;

            _changelogServerURLDownloadLocation = changelogServerURLDownloadLocation;

            _specialisedUpdateIconURL = specialisedUpdateIconURL;

            _md5Checksum = md5Checksum;

            _sha1Checksum = sha1Checksum;

            _sha256Checksum = sha256Checksum;

            _sha384Checksum = sha384Checksum;

            _sha512Checksum = sha512Checksum;

            _ripemd160Checksum = ripemd160Checksum;

            _updatePackageBuildString = updatePackageBuildString;

            _optionalArguments = optionalArguments;

            _checksumFileURL = checksumFileURL;

            _betaFlag = betaFlag;

            _startUpdateInstallationUponDownloadCompletion = startUpdateInstallationUponDownloadCompletion;

            _updatePackageReleaseDate = updatePackageReleaseDate;

            _updatePackageBuildDate = updatePackageBuildDate;

            _updatePackageFileSize = updatePackageFileSize;
        }
        #endregion
    }
}