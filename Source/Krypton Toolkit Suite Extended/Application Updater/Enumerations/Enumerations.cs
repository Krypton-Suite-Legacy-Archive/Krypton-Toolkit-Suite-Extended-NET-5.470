#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

namespace KryptonApplicationUpdater.Enumerations
{
    /// <summary>
    /// The supported checksums for <see cref="KryptonApplicationUpdater"/>.
    /// </summary>
    public enum SupportedHashSumList
    {
        //CRC32,        
        /// <summary>
        /// The  RIPEMD160
        /// </summary>
        RIPEMD160,
        //MD4,        
        /// <summary>
        /// The MD5
        /// </summary>
        MD5,
        /// <summary>
        /// The SHA1
        /// </summary>
        SHA1,
        //SHA224,        
        /// <summary>
        /// The SHA256
        /// </summary>
        SHA256,
        /// <summary>
        /// The SHA384
        /// </summary>
        SHA384,
        /// <summary>
        /// The SHA512
        /// </summary>
        SHA512
    }

    public enum Status
    {
        NONE,
        WELCOME,
        CHECKINGFORUPDATES,
        DOWNLOADINGUPDATES,
        DOWNLOADCOMPLETED,
        ABORTUPDATE,
        RESTART,
        UPDATEISAVAILABLE,
        NOAVAILABLEUPDATES
    }

    public enum FileSizes
    {
        BYTES,
        KILOBYTES,
        MEGABYTES,
        GIGABYTES
    }

    public enum UpdatePackageType
    {
        DEFAULT,
        HOTFIX,
        PATCH,
        MINORUPDATE,
        MAJORUPDATE,
        MINORUPGRADE,
        MAJORUPGRADE,
        SERVICEPACK,
        INTERMEDIATEUPGRADE,
        SECURITYUPDATE,
        FEATUREUPDATE,
        NEWFEATURES
    }

    public enum UpdatePackageSeverity
    {
        LOW,
        IMPORTANT,
        MEDIUM,
        HIGH,
        SEVERE,
        CRITICAL
    }

    /// <summary>
    /// The type of update that is being offered to the end-user.
    /// </summary>
    //public enum UpdatePackageType
    //{
    //    DEFAULT,
    //    HOTFIX,
    //    PATCH,
    //    MINORUPDATE,
    //    MAJORUPDATE,
    //    MINORUPGRADE,
    //    INTERMEDIATEUPGRADE,
    //    MAJORUPGRADE,
    //    SECURITYUPDATE,
    //    SERVICEPACK,
    //    FEATUREUPDATE,
    //    NEWFEATURES
    //}

    /// <summary>
    /// 
    /// </summary>
    public enum UpdatePackageSeverityIdentification
    {
        NONE,
        LOW,
        IMPORTANT,
        OPTIONAL,
        MEDIUM,
        HIGH,
        SEVERE,
        CRITICAL
    }

    /// <summary>
    /// 
    /// </summary>
    public enum DigitalSignatureValidationType
    {
        DEFAULT,
        RIPEMD160,
        CRC,
        MD5,
        SHA1,
        SHA256,
        SHA384,
        SHA512
    }

    /// <summary>
    /// 
    /// </summary>
    public enum ConnectionStatus
    {
        DEFAULT,
        CHECKCONNECTION,
        CONNECTIONSUCCEEDED,
        CONNECTIONFAILED,
        CHECKFORUPDATES,
        UPDATEAVAILABLE,
        NOUPDATES,
        DOWNLOADUPDATE,
        DOWNLOADUPDATESUCCEEDED,
        DOWNLOADUPDATEFAILED,
        DOWNLOADUPDATEABORTED,
        REBOOTNOW,
        REBOOTABORTED,
        EXCEPTIONCAPTURE
    }

    /// <summary>
    /// 
    /// </summary>
    public enum UpdateSupportStage
    {
        PREALPHA,
        ALPHA,
        BETA,
        RELEASECANDIDATE,
        RTM,
        MAINSTREAM,
        EXTENDEDSUPPORT,
        LONGTERMSUPPORT,
        ENDOFLIFE
    }

    public enum MultipleFileDownloadStatus
    {
        DOWNLOADING,
        COMPLETED,
        FAILED,
        CANCELLED
    }

    /// <summary>
    /// 
    /// </summary>
    public enum HypertextTransferProtocolType
    {
        /// <summary>
        /// The hypertext transfer protocol normal type (HTTP).
        /// </summary>
        HYPERTEXTTRANSFERPROTOCOL,
        /// <summary>
        /// The hypertext transfer protocol secure type (HTTPS).
        /// </summary>
        HYPERTEXTTRANSFERPROTOCOLSECURE
    }
}