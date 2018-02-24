using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace GlobalUtilities.Classes
{
    public class GlobalMethods
    {
        #region Variables
        private bool _isTargetPlatformSupported = false, _isTargetPlatform64BIT = false, _isAssemblies64BIT = false;
        #endregion

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public bool IsTargetPlatformSupported
        {
            get
            {
                return _isTargetPlatformSupported;
            }

            set
            {
                _isTargetPlatformSupported = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsTargetPlatform64BIT
        {
            get
            {
                return _isTargetPlatform64BIT;
            }

            set
            {
                _isTargetPlatform64BIT = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsAssemblies64BIT
        {
            get
            {
                return _isAssemblies64BIT;
            }

            set
            {
                _isAssemblies64BIT = value;
            }

        }
        #endregion

        #region Constructor
        /// <summary>
        /// The default constructor.
        /// </summary>
        public GlobalMethods()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="useLegacyVistaSupport"></param>
        /// <returns></returns>
        public bool CheckIfTargetPlatformIsSupported(bool useLegacyVistaSupport = false)
        {
            try
            {
                if (useLegacyVistaSupport)
                {
                    if (Environment.OSVersion.Version.Major >= 6)
                    {
                        IsTargetPlatformSupported = true;
                    }
                    else
                    {
                        IsTargetPlatformSupported = false;
                    }
                }
                else
                {
                    if (Environment.Version.Major >= 6 && Environment.Version.Minor >= 1)
                    {
                        IsTargetPlatformSupported = true;
                    }
                    else
                    {
                        IsTargetPlatformSupported = false;
                    }
                }
            }
            catch (Exception exc)
            {
                KryptonMessageBox.Show("Error: " + exc.Message, "Error Thrown", MessageBoxButtons.OK, MessageBoxIcon.Error);

                IsTargetPlatformSupported = false;
            }

            return IsTargetPlatformSupported;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsTargetPlatformRunningIn64BITMode()
        {
            if (Environment.Is64BitOperatingSystem)
            {
                IsTargetPlatform64BIT = true;
            }
            else
            {
                IsTargetPlatform64BIT = false;
            }

            return IsTargetPlatform64BIT;
        }
        #endregion

        #region De-constructor
        ~GlobalMethods()
        {
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}