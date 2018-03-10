using GlobalUtilities.Classes;
using KryptonApplicationUpdater.Interfaces;
using System;

namespace KryptonApplicationUpdater.Classes
{
    /// <summary>
    /// Handles the logic of the application updater.
    /// </summary>
    public class UpdaterLogic
    {
        #region Variables
        private GlobalMethods _globalMethods = new GlobalMethods();

        private ExceptionHandler _exceptionHandler = new ExceptionHandler();

        private XMLFileParser _parser = new XMLFileParser();

        private IUpdatable _updatable;

        private IXMLData _xmlData;
        #endregion

        #region Constructors
        /// <summary>
        /// Initialises a new instance of the <see cref="UpdaterLogic"/> class.
        /// </summary>
        /// <param name="isVistaSupported">if set to <c>true</c> [is vista supported].</param>
        public UpdaterLogic(bool isVistaSupported = false)
        {
            _globalMethods.CheckIfTargetPlatformIsSupported(isVistaSupported);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Checks for updates.
        /// </summary>
        /// <param name="xmlFilePath">The XML file path.</param>
        /// <param name="pingURL">The ping URL.</param>
        public void CheckForUpdates(string xmlFilePath, string pingURL)
        {
            _globalMethods.CheckInternetConnectionState(pingURL);

            try
            {
                if (_globalMethods.GetInternetConnectionState())
                {

                }
                else
                {

                }
            }
            catch (Exception e)
            {
                if (_globalMethods.GetIsTargetPlatformSupported())
                {

                }
                else
                {

                }
            }
        }

        /// <summary>
        /// Downloads the file.
        /// </summary>
        /// <param name="sourcePath">The source path.</param>
        /// <param name="destinationPath">The destination path.</param>
        public void DownloadFile(string sourcePath, string destinationPath)
        {
            try
            {

            }
            catch (Exception e)
            {
                if (_globalMethods.GetIsTargetPlatformSupported())
                {

                }
                else
                {

                }
            }
        }
        #endregion
    }
}