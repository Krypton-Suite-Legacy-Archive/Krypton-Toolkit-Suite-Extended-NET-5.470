#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using Core.Classes;
using KryptonApplicationUpdater.Classes.SettingsManager;
using KryptonApplicationUpdater.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace KryptonApplicationUpdater.Classes
{
    public class XMLFileParser : IXMLData, IUpdatable
    {
        #region Variables
        private string _xmlFilePath, _applicationIdentifier, _applicationName, _serverVersion, _updatePackageType, _updatePackageSeverity, _updatePackageName, _updatePackageDescription, _updatePackageServerURLDownloadLocation, _changelogServerURLDownloadLocation, _specialisedUpdateIconURL, _md5Checksum, _sha1Checksum, _sha256Checksum, _sha384Checksum, _sha512Checksum, _ripemd160Checksum, _updatePackageBuildString, _optionalArguments, _checksumFileURL, _virusTotalScanURL, _knowledgebaseArticleNumber, _knowledgebaseArticleNumberURL;

        private bool _betaFlag, _startUpdateInstallationUponDownloadCompletion;

        private DateTime _updatePackageReleaseDate, _updatePackageBuildDate;

        private long _updatePackageFileSize;

        private int _installCountdown;

        private TranslationMethods translationMethods = new TranslationMethods();

        private InternalApplicationUpdaterSettingsManager internalApplicationUpdaterSettingsManager = new InternalApplicationUpdaterSettingsManager();

        private XMLFileApplicationUpdaterSettingsManager xmlFileApplicationUpdaterSettingsManager = new XMLFileApplicationUpdaterSettingsManager();
        #endregion

        #region Constructors
        /// <summary>
        /// Initialises a new instance of the <see cref="XMLFileParser"/> class.
        /// </summary>
        public XMLFileParser()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XMLFileParser"/> class.
        /// </summary>
        /// <param name="xmlFilePath">The XML file path.</param>
        /// <param name="applicationIdentifier">The application identifier.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="serverVersion">The server version.</param>
        /// <param name="updatePackageType">Type of the update package.</param>
        /// <param name="updatePackageSeverity">The update package severity.</param>
        /// <param name="updatePackageName">Name of the update package.</param>
        /// <param name="updatePackageDescription">The update package description.</param>
        /// <param name="updatePackageServerURLDownloadLocation">The update package server URL download location.</param>
        /// <param name="changelogServerURLDownloadLocation">The changelog server URL download location.</param>
        /// <param name="specialisedUpdateIconURL">The specialised update icon URL.</param>
        /// <param name="knowledgebaseArticleNumber">The knowledgebase article number.</param>
        /// <param name="knowledgebaseArticleNumberURL">The knowledgebase article number URL.</param>
        /// <param name="md5Checksum">The MD5 checksum.</param>
        /// <param name="sha1Checksum">The sha1 checksum.</param>
        /// <param name="sha256Checksum">The sha256 checksum.</param>
        /// <param name="sha384Checksum">The sha384 checksum.</param>
        /// <param name="sha512Checksum">The sha512 checksum.</param>
        /// <param name="ripemd160Checksum">The ripemd160 checksum.</param>
        /// <param name="updatePackageBuildString">The update package build string.</param>
        /// <param name="optionalArguments">The optional arguments.</param>
        /// <param name="checksumFileURL">The checksum file URL.</param>
        /// <param name="virusTotalScanURL">The virus total scan URL.</param>
        /// <param name="betaFlag">if set to <c>true</c> [beta flag].</param>
        /// <param name="startUpdateInstallationUponDownloadCompletion">if set to <c>true</c> [start update installation upon download completion].</param>
        /// <param name="updatePackageReleaseDate">The update package release date.</param>
        /// <param name="updatePackageBuildDate">The update package build date.</param>
        /// <param name="updatePackageFileSize">Size of the update package file.</param>
        /// <param name="installCountdown">The install countdown.</param>
        public XMLFileParser(string xmlFilePath, string applicationIdentifier, string applicationName, string serverVersion, string updatePackageType, string updatePackageSeverity, string updatePackageName, string updatePackageDescription, string updatePackageServerURLDownloadLocation, string changelogServerURLDownloadLocation, string specialisedUpdateIconURL, string knowledgebaseArticleNumber, string knowledgebaseArticleNumberURL, string md5Checksum, string sha1Checksum, string sha256Checksum, string sha384Checksum, string sha512Checksum, string ripemd160Checksum, string updatePackageBuildString, string optionalArguments, string checksumFileURL, string virusTotalScanURL, bool betaFlag, bool startUpdateInstallationUponDownloadCompletion, DateTime updatePackageReleaseDate, DateTime updatePackageBuildDate, long updatePackageFileSize, int installCountdown)
        {
            WriteData(xmlFilePath, applicationIdentifier, applicationName, serverVersion, updatePackageType, updatePackageSeverity, updatePackageName, updatePackageDescription, updatePackageServerURLDownloadLocation, changelogServerURLDownloadLocation, specialisedUpdateIconURL, knowledgebaseArticleNumber, knowledgebaseArticleNumberURL, md5Checksum, sha1Checksum, sha256Checksum, sha384Checksum, sha512Checksum, ripemd160Checksum, updatePackageBuildString, optionalArguments, checksumFileURL, virusTotalScanURL, betaFlag, startUpdateInstallationUponDownloadCompletion, updatePackageReleaseDate, updatePackageBuildDate, updatePackageFileSize, installCountdown);
        }
        #endregion

        #region IXMLData Implementation
        public string ApplicationIdentifier { get { return _applicationIdentifier; } set { _applicationIdentifier = value; } }
        public string ServerVersion { get { return _serverVersion; } set { _serverVersion = value; } }
        public string UpdatePackageType { get { return _updatePackageType; } set { _updatePackageType = value; } }
        public string UpdatePackageSeverity { get { return _updatePackageSeverity; } set { _updatePackageSeverity = value; } }
        public string UpdatePackageName { get { return _updatePackageName; } set { _updatePackageName = value; } }
        public string UpdatePackageServerURLDownloadLocation { get { return _updatePackageServerURLDownloadLocation; } set { _updatePackageServerURLDownloadLocation = value; } }
        public string ChangelogServerURLDownloadLocation { get { return _changelogServerURLDownloadLocation; } set { _changelogServerURLDownloadLocation = value; } }
        public string SpecialisedUpdateIconURL { get { return _specialisedUpdateIconURL; } set { _specialisedUpdateIconURL = value; } }
        public string MD5Checksum { get { return _md5Checksum; } set { _md5Checksum = value; } }
        public string SHA1Checksum { get { return _sha1Checksum; } set { _sha1Checksum = value; } }
        public string SHA256Checksum { get { return _sha256Checksum; } set { _sha256Checksum = value; } }
        public string SHA384Checksum { get { return _sha384Checksum; } set { _sha384Checksum = value; } }
        public string SHA512Checksum { get { return _sha512Checksum; } set { _sha512Checksum = value; } }
        public string RIPEMD160Checksum { get { return _ripemd160Checksum; } set { _ripemd160Checksum = value; } }
        public bool StartUpdateInstallationUponDownloadCompletion { get { return _startUpdateInstallationUponDownloadCompletion; } set { _startUpdateInstallationUponDownloadCompletion = value; } }
        public DateTime UpdatePackageReleaseDate { get { return _updatePackageReleaseDate; } set { _updatePackageReleaseDate = value; } }
        public long UpdatePackageFileSize { get { return _updatePackageFileSize; } set { _updatePackageFileSize = value; } }
        public string OptionalArguments { get { return _optionalArguments; } set { _optionalArguments = value; } }
        public DateTime UpdatePackageBuildDate { get { return _updatePackageBuildDate; } set { _updatePackageBuildDate = value; } }
        public string UpdatePackageBuildString { get { return _updatePackageBuildString; } set { _updatePackageBuildString = value; } }
        public bool BetaFlag { get { return _betaFlag; } set { _betaFlag = value; } }
        public string ChecksumFileURL { get { return _checksumFileURL; } set { _checksumFileURL = value; } }
        public int InstallCountdown { get { return _installCountdown; } set { _installCountdown = value; } }
        public string VirusTotalScanURL { get { return _virusTotalScanURL; } set { _virusTotalScanURL = value; } }
        public string KnowledgebaseArticleNumber { get { return _knowledgebaseArticleNumber; } set { _knowledgebaseArticleNumber = value; } }
        public string KnowledgebaseArticleNumberURL { get { return _knowledgebaseArticleNumberURL; } set { _knowledgebaseArticleNumberURL = value; } }
        public string UpdatePackageDescription { get { return _updatePackageDescription; } set { _updatePackageDescription = value; } }
        #endregion

        #region IUpdatable Implementation
        public string ServerXMLFileURL { get { return _xmlFilePath; } set { _xmlFilePath = value; } }
        public string ApplicationName { get { return _applicationName; } set { _applicationName = value; } }

        /// <summary>
        /// Not used.
        /// </summary>
        public Icon ApplicationIcon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Form ParentForm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CurrentApplicationVersion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ApplicationIdentification { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        #region Methods
        /// <summary>
        /// Parses the XML file.
        /// </summary>
        /// <param name="xmlFilePath">The XML file path.</param>
        /// <param name="applicationIdentification">The application identification.</param>
        /// <param name="createConfigurationFile">if set to <c>true</c> [create configuration file].</param>
        /// <param name="configurationFilePath">The configuration file path.</param>
        /// <returns></returns>
        public XMLFileParser ParseXMLFile(Uri xmlFilePath, string applicationIdentification, bool createConfigurationFile = false, string configurationFilePath = null)
        {
            #region Internal Variables
            string _applicationIdentifier = "", _applicationName = "", _serverVersion = "", _updatePackageType = "", _updatePackageSeverity = "", _updatePackageName = "", _updatePackageDescription = "", _updatePackageServerURLDownloadLocation = "", _changelogServerURLDownloadLocation = "", _specialisedUpdateIconURL = "", _md5Checksum = "", _sha1Checksum = "", _sha256Checksum = "", _sha384Checksum = "", _sha512Checksum = "", _ripemd160Checksum = "", _updatePackageBuildString = "", _optionalArguments = "", _checksumFileURL = "", _virusTotalScanURL = "", _knowledgebaseArticleNumber = "", _knowledgebaseArticleNumberURL = "";

            bool _betaFlag, _startUpdateInstallationUponDownloadCompletion;

            DateTime _updatePackageReleaseDate, _updatePackageBuildDate;

            long _updatePackageFileSize;

            int _installCountdown;
            #endregion

            try
            {
                XmlDocument xmlDocument = new XmlDocument();

                xmlDocument.Load(xmlFilePath.AbsoluteUri);

                // Sets up 'node' variable, (VERY IMPORTANT!!!!!!)
                XmlNode node = xmlDocument.DocumentElement.SelectSingleNode($"//update[@applicationIdentification='{ _applicationIdentifier }']");

                if (node == null)
                {
                    return null;
                }

                #region Booleans
                _betaFlag = translationMethods.ParseBoolean(node["betaFlag"].InnerText);

                _startUpdateInstallationUponDownloadCompletion = translationMethods.ParseBoolean(node["startUpdateInstallationUponDownloadCompletion"].InnerText);
                #endregion

                #region Date and Time
                _updatePackageBuildDate = translationMethods.ParseDateTime(node["updatePackageBuildDate"].InnerText);

                _updatePackageReleaseDate = translationMethods.ParseDateTime(node["updatePackageReleaseDate"].InnerText);
                #endregion

                #region Integers
                _installCountdown = translationMethods.ParseInteger(node["installCountdown"].InnerText);
                #endregion

                #region Longs
                _updatePackageFileSize = translationMethods.ParseLong(node["updatePackageFileSize"].InnerText);
                #endregion

                #region Strings
                _applicationName = node["applicationName"].InnerText;

                _serverVersion = node["serverVersion"].InnerText;

                _updatePackageType = node["updatePackageType"].InnerText;

                _updatePackageSeverity = node["updatePackageSeverity"].InnerText;

                _updatePackageName = node["updatePackageName"].InnerText;

                _updatePackageDescription = node["updatePackageDescription"].InnerText;

                _updatePackageServerURLDownloadLocation = node["updatePackageServerURLDownloadLocation"].InnerText;

                _changelogServerURLDownloadLocation = node["changelogServerURLDownloadLocation"].InnerText;

                _specialisedUpdateIconURL = node["specialisedUpdateIconURL"].InnerText;

                _knowledgebaseArticleNumber = node["knowledgebaseArticleNumber"].InnerText;

                _knowledgebaseArticleNumberURL = node["knowledgebaseArticleNumberURL"].InnerText;

                _md5Checksum = node["md5CheckSum"].InnerText;

                _sha1Checksum = node["sha1CheckSum"].InnerText;

                _sha256Checksum = node["sha256CheckSum"].InnerText;

                _sha384Checksum = node["sha384CheckSum"].InnerText;

                _sha512Checksum = node["sha512CheckSum"].InnerText;

                _ripemd160Checksum = node["ripemd160CheckSum"].InnerText;

                _updatePackageBuildString = node["updatePackageBuildString"].InnerText;

                _optionalArguments = node["optionalArguments"].InnerText;

                _checksumFileURL = node["checkSumFileURL"].InnerText;

                _virusTotalScanURL = node["virusTotalScanURL"].InnerText;
                #endregion

                return new XMLFileParser(xmlFilePath.ToString(), _applicationIdentifier, _applicationName, _serverVersion, _updatePackageType, _updatePackageSeverity, _updatePackageName, _updatePackageDescription, _updatePackageServerURLDownloadLocation, _changelogServerURLDownloadLocation, _specialisedUpdateIconURL, _knowledgebaseArticleNumber, _knowledgebaseArticleNumberURL, _md5Checksum, _sha1Checksum, _sha256Checksum, _sha384Checksum, _sha512Checksum, _ripemd160Checksum, _updatePackageBuildString, _optionalArguments, _checksumFileURL, _virusTotalScanURL, _betaFlag, _startUpdateInstallationUponDownloadCompletion, _updatePackageReleaseDate, _updatePackageBuildDate, _updatePackageFileSize, _installCountdown);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Writes the data.
        /// </summary>
        /// <param name="xmlFilePath">The XML file path.</param>
        /// <param name="applicationIdentifier">The application identifier.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="serverVersion">The server version.</param>
        /// <param name="updatePackageType">Type of the update package.</param>
        /// <param name="updatePackageName">Name of the update package.</param>
        /// <param name="updatePackageSeverity">The update package severity.</param>
        /// <param name="updatePackageDescription">The update package description.</param>
        /// <param name="updatePackageServerURLDownloadLocation">The update package server URL download location.</param>
        /// <param name="changelogServerURLDownloadLocation">The changelog server URL download location.</param>
        /// <param name="specialisedUpdateIconURL">The specialised update icon URL.</param>
        /// <param name="knowledgebaseArticleNumber">The knowledgebase article number.</param>
        /// <param name="knowledgebaseArticleNumberURL">The knowledgebase article number URL.</param>
        /// <param name="md5Checksum">The MD5 checksum.</param>
        /// <param name="sha1Checksum">The sha1 checksum.</param>
        /// <param name="sha256Checksum">The sha256 checksum.</param>
        /// <param name="sha384Checksum">The sha384 checksum.</param>
        /// <param name="sha512Checksum">The sha512 checksum.</param>
        /// <param name="ripemd160Checksum">The ripemd160 checksum.</param>
        /// <param name="updatePackageBuildString">The update package build string.</param>
        /// <param name="optionalArguments">The optional arguments.</param>
        /// <param name="checksumFileURL">The checksum file URL.</param>
        /// <param name="virusTotalScanURL">The virus total scan URL.</param>
        /// <param name="betaFlag">if set to <c>true</c> [beta flag].</param>
        /// <param name="startUpdateInstallationUponDownloadCompletion">if set to <c>true</c> [start update installation upon download completion].</param>
        /// <param name="updatePackageReleaseDate">The update package release date.</param>
        /// <param name="updatePackageBuildDate">The update package build date.</param>
        /// <param name="updatePackageFileSize">Size of the update package file.</param>
        /// <param name="installCountdown">The install countdown.</param>
        public void WriteData(string xmlFilePath, string applicationIdentifier, string applicationName, string serverVersion, string updatePackageType, string updatePackageName, string updatePackageSeverity, string updatePackageDescription, string updatePackageServerURLDownloadLocation, string changelogServerURLDownloadLocation, string specialisedUpdateIconURL, string knowledgebaseArticleNumber, string knowledgebaseArticleNumberURL, string md5Checksum, string sha1Checksum, string sha256Checksum, string sha384Checksum, string sha512Checksum, string ripemd160Checksum, string updatePackageBuildString, string optionalArguments, string checksumFileURL, string virusTotalScanURL, bool betaFlag, bool startUpdateInstallationUponDownloadCompletion, DateTime updatePackageReleaseDate, DateTime updatePackageBuildDate, long updatePackageFileSize, int installCountdown)
        {
            ServerXMLFileURL = xmlFilePath;

            ApplicationIdentifier = applicationIdentifier;

            ApplicationName = applicationName;

            ServerVersion = serverVersion;

            UpdatePackageType = updatePackageType;

            UpdatePackageSeverity = updatePackageSeverity;

            UpdatePackageName = updatePackageName;

            UpdatePackageDescription = updatePackageDescription;

            UpdatePackageServerURLDownloadLocation = updatePackageServerURLDownloadLocation;

            ChangelogServerURLDownloadLocation = changelogServerURLDownloadLocation;

            SpecialisedUpdateIconURL = specialisedUpdateIconURL;

            KnowledgebaseArticleNumber = knowledgebaseArticleNumber;

            KnowledgebaseArticleNumberURL = knowledgebaseArticleNumberURL;

            MD5Checksum = md5Checksum;

            SHA1Checksum = sha1Checksum;

            SHA256Checksum = sha256Checksum;

            SHA384Checksum = sha384Checksum;

            SHA512Checksum = sha512Checksum;

            RIPEMD160Checksum = ripemd160Checksum;

            UpdatePackageBuildString = updatePackageBuildString;

            OptionalArguments = optionalArguments;

            ChecksumFileURL = checksumFileURL;

            VirusTotalScanURL = virusTotalScanURL;

            BetaFlag = betaFlag;

            StartUpdateInstallationUponDownloadCompletion = startUpdateInstallationUponDownloadCompletion;

            UpdatePackageReleaseDate = updatePackageReleaseDate;

            UpdatePackageBuildDate = updatePackageBuildDate;

            UpdatePackageFileSize = updatePackageFileSize;

            SaveDataToSettings(ServerXMLFileURL, ApplicationIdentifier, ApplicationName, ServerVersion, UpdatePackageType, UpdatePackageSeverity, UpdatePackageName, UpdatePackageDescription, UpdatePackageServerURLDownloadLocation, ChangelogServerURLDownloadLocation, SpecialisedUpdateIconURL, KnowledgebaseArticleNumber, KnowledgebaseArticleNumberURL, MD5Checksum, SHA1Checksum, SHA256Checksum, SHA384Checksum, SHA512Checksum, RIPEMD160Checksum, UpdatePackageBuildString, OptionalArguments, ChecksumFileURL, VirusTotalScanURL, BetaFlag, StartUpdateInstallationUponDownloadCompletion, UpdatePackageReleaseDate, UpdatePackageBuildDate, UpdatePackageFileSize, InstallCountdown);
        }

        /// <summary>
        /// Saves the data to settings.
        /// </summary>
        /// <param name="xmlFilePath">The XML file path.</param>
        /// <param name="applicationIdentifier">The application identifier.</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="serverVersion">The server version.</param>
        /// <param name="updatePackageType">Type of the update package.</param>
        /// <param name="updatePackageSeverity">The update package severity.</param>
        /// <param name="updatePackageName">Name of the update package.</param>
        /// <param name="updatePackageDescription">The update package description.</param>
        /// <param name="updatePackageServerURLDownloadLocation">The update package server URL download location.</param>
        /// <param name="changelogServerURLDownloadLocation">The changelog server URL download location.</param>
        /// <param name="specialisedUpdateIconURL">The specialised update icon URL.</param>
        /// <param name="knowledgebaseArticleNumber">The knowledgebase article number.</param>
        /// <param name="knowledgebaseArticleNumberURL">The knowledgebase article number URL.</param>
        /// <param name="md5Checksum">The MD5 checksum.</param>
        /// <param name="sha1Checksum">The sha1 checksum.</param>
        /// <param name="sha256Checksum">The sha256 checksum.</param>
        /// <param name="sha384Checksum">The sha384 checksum.</param>
        /// <param name="sha512Checksum">The sha512 checksum.</param>
        /// <param name="ripemd160Checksum">The ripemd160 checksum.</param>
        /// <param name="updatePackageBuildString">The update package build string.</param>
        /// <param name="optionalArguments">The optional arguments.</param>
        /// <param name="checksumFileURL">The checksum file URL.</param>
        /// <param name="virusTotalScanURL">The virus total scan URL.</param>
        /// <param name="betaFlag">if set to <c>true</c> [beta flag].</param>
        /// <param name="startUpdateInstallationUponDownloadCompletion">if set to <c>true</c> [start update installation upon download completion].</param>
        /// <param name="updatePackageReleaseDate">The update package release date.</param>
        /// <param name="updatePackageBuildDate">The update package build date.</param>
        /// <param name="updatePackageFileSize">Size of the update package file.</param>
        /// <param name="installCountdown">The install countdown.</param>
        private void SaveDataToSettings(string xmlFilePath, string applicationIdentifier, string applicationName, string serverVersion, string updatePackageType, string updatePackageSeverity, string updatePackageName, string updatePackageDescription, string updatePackageServerURLDownloadLocation, string changelogServerURLDownloadLocation, string specialisedUpdateIconURL, string knowledgebaseArticleNumber, string knowledgebaseArticleNumberURL, string md5Checksum, string sha1Checksum, string sha256Checksum, string sha384Checksum, string sha512Checksum, string ripemd160Checksum, string updatePackageBuildString, string optionalArguments, string checksumFileURL, string virusTotalScanURL, bool betaFlag, bool startUpdateInstallationUponDownloadCompletion, DateTime updatePackageReleaseDate, DateTime updatePackageBuildDate, long updatePackageFileSize, int installCountdown)
        {
            internalApplicationUpdaterSettingsManager.SetXMLFileURL(xmlFilePath);

            xmlFileApplicationUpdaterSettingsManager.SetApplicationIdentifier(applicationIdentifier);

            internalApplicationUpdaterSettingsManager.SetApplicationName(applicationName);

            xmlFileApplicationUpdaterSettingsManager.SetServerVersion(serverVersion);

            xmlFileApplicationUpdaterSettingsManager.SetUpdatePackageType(updatePackageType);

            xmlFileApplicationUpdaterSettingsManager.SetUpdatePackageSeverity(updatePackageSeverity);

            xmlFileApplicationUpdaterSettingsManager.SetUpdatePackageName(updatePackageName);

            xmlFileApplicationUpdaterSettingsManager.SetUpdatePackageDescription(updatePackageDescription);

            xmlFileApplicationUpdaterSettingsManager.SetUpdatePackageServerURLDownloadLocation(updatePackageServerURLDownloadLocation);

            xmlFileApplicationUpdaterSettingsManager.SetChangelogServerURLDownloadLocation(changelogServerURLDownloadLocation);

            xmlFileApplicationUpdaterSettingsManager.SetSpecialisedUpdateIconURL(specialisedUpdateIconURL);

            xmlFileApplicationUpdaterSettingsManager.SetKnowledgebaseArticleNumber(knowledgebaseArticleNumber);

            xmlFileApplicationUpdaterSettingsManager.SetKnowledgebaseArticleNumberURL(knowledgebaseArticleNumberURL);

            xmlFileApplicationUpdaterSettingsManager.SetMD5CheckSum(md5Checksum);

            xmlFileApplicationUpdaterSettingsManager.SetSHA1CheckSum(sha1Checksum);

            xmlFileApplicationUpdaterSettingsManager.SetSHA256CheckSum(sha256Checksum);

            xmlFileApplicationUpdaterSettingsManager.SetSHA384CheckSum(sha384Checksum);

            xmlFileApplicationUpdaterSettingsManager.SetSHA512CheckSum(sha512Checksum);

            xmlFileApplicationUpdaterSettingsManager.SetRIPEMD160CheckSum(ripemd160Checksum);

            xmlFileApplicationUpdaterSettingsManager.SetUpdatePackageBuildString(updatePackageBuildString);

            xmlFileApplicationUpdaterSettingsManager.SetOptionalArguments(optionalArguments);

            xmlFileApplicationUpdaterSettingsManager.SetCheckSumFileURL(checksumFileURL);

            xmlFileApplicationUpdaterSettingsManager.SetVirusTotalScanURL(virusTotalScanURL);

            xmlFileApplicationUpdaterSettingsManager.SetBetaFlag(betaFlag);

            xmlFileApplicationUpdaterSettingsManager.SetStartUpdateInstallationUponDownloadCompletion(startUpdateInstallationUponDownloadCompletion);

            xmlFileApplicationUpdaterSettingsManager.SetUpdatePackageBuildDate(updatePackageBuildDate);

            xmlFileApplicationUpdaterSettingsManager.SetUpdatePackageReleaseDate(updatePackageReleaseDate);

            xmlFileApplicationUpdaterSettingsManager.SetUpdatePackageFileSize(updatePackageFileSize);

            xmlFileApplicationUpdaterSettingsManager.SetInstallCountdown(installCountdown);

            internalApplicationUpdaterSettingsManager.SaveInternalApplicationUpdaterSettings();

            xmlFileApplicationUpdaterSettingsManager.SaveXMLFileApplicationUpdaterSettings();
        }

        /// <summary>
        /// Creates the configuration file.
        /// </summary>
        /// <param name="configurationFilePath">The configuration file path.</param>
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
        /// <param name="knowledgebaseArticleNumber">The knowledgebase article number.</param>
        /// <param name="knowledgebaseArticleNumberURL">The knowledgebase article number URL.</param>
        /// <param name="md5Checksum">The MD5 checksum.</param>
        /// <param name="sha1Checksum">The sha1 checksum.</param>
        /// <param name="sha256Checksum">The sha256 checksum.</param>
        /// <param name="sha384Checksum">The sha384 checksum.</param>
        /// <param name="sha512Checksum">The sha512 checksum.</param>
        /// <param name="ripemd160Checksum">The ripemd160 checksum.</param>
        /// <param name="updatePackageBuildString">The update package build string.</param>
        /// <param name="optionalArguments">The optional arguments.</param>
        /// <param name="checksumFileURL">The checksum file URL.</param>
        /// <param name="virusTotalScanURL">The virus total scan URL.</param>
        /// <param name="betaFlag">if set to <c>true</c> [beta flag].</param>
        /// <param name="startUpdateInstallationUponDownloadCompletion">if set to <c>true</c> [start update installation upon download completion].</param>
        /// <param name="updatePackageReleaseDate">The update package release date.</param>
        /// <param name="updatePackageBuildDate">The update package build date.</param>
        /// <param name="updatePackageFileSize">Size of the update package file.</param>
        /// <param name="installCountdown">The install countdown.</param>
        private void CreateConfigurationFile(string configurationFilePath, string xmlFilePath, string applicationIdentifier, string applicationName, string serverVersion, string updatePackageType, string updatePackageSeverity, string updatePackageName, string updatePackageServerURLDownloadLocation, string changelogServerURLDownloadLocation, string specialisedUpdateIconURL, string knowledgebaseArticleNumber, string knowledgebaseArticleNumberURL, string md5Checksum, string sha1Checksum, string sha256Checksum, string sha384Checksum, string sha512Checksum, string ripemd160Checksum, string updatePackageBuildString, string optionalArguments, string checksumFileURL, string virusTotalScanURL, bool betaFlag, bool startUpdateInstallationUponDownloadCompletion, DateTime updatePackageReleaseDate, DateTime updatePackageBuildDate, long updatePackageFileSize, int installCountdown)
        {

        }
        #endregion
    }
}