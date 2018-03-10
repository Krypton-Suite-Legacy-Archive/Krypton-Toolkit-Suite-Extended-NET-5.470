using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.Base.Code;
using System;
using System.ComponentModel;

namespace KryptonApplicationUpdater.UI.Advanced.XMLBased
{
    public partial class ChecksumViewerForm : KryptonForm
    {
        #region Variables
        private bool _enableValidateCheksumButton, _toggleCasing;

        private string _fileName, _md5Checksum, _sha1Checksum, _sha256Checksum, _sha384Checksum, _sha512Checksum, _ripemd160Checksum;

        private ExceptionHandler _exceptionHandler = new ExceptionHandler();
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets a value indicating whether [enable validate cheksum button].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable validate cheksum button]; otherwise, <c>false</c>.
        /// </value>
        [DefaultValue(true)]
        public bool EnableValidateCheksumButton
        {
            get
            {
                return _enableValidateCheksumButton;
            }

            set
            {
                _enableValidateCheksumButton = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [toggle casing].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [toggle casing]; otherwise, <c>false</c>.
        /// </value>
        [DefaultValue(false)]
        public bool ToggleCasing
        {
            get
            {
                return _toggleCasing;
            }

            set
            {
                _toggleCasing = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName
        {
            get
            {
                return _fileName;
            }

            set
            {
                _fileName = value;
            }
        }

        /// <summary>
        /// Gets or sets the MD5 checksum.
        /// </summary>
        /// <value>
        /// The MD5 checksum.
        /// </value>
        public string MD5Checksum
        {
            get
            {
                return _md5Checksum;
            }

            set
            {
                _md5Checksum = value;
            }
        }

        /// <summary>
        /// Gets or sets the SHA1 checksum.
        /// </summary>
        /// <value>
        /// The SHA1 checksum.
        /// </value>
        public string SHA1Checksum
        {
            get
            {
                return _sha1Checksum;
            }

            set
            {
                _sha1Checksum = value;
            }
        }

        /// <summary>
        /// Gets or sets the SHA256 checksum.
        /// </summary>
        /// <value>
        /// The SHA256 checksum.
        /// </value>
        public string SHA256Checksum
        {
            get
            {
                return _sha256Checksum;
            }

            set
            {
                _sha256Checksum = value;
            }
        }

        /// <summary>
        /// Gets or sets the SHA384 checksum.
        /// </summary>
        /// <value>
        /// The SHA384 checksum.
        /// </value>
        public string SHA384Checksum
        {
            get
            {
                return _sha384Checksum;
            }

            set
            {
                _sha384Checksum = value;
            }
        }

        /// <summary>
        /// Gets or sets the SHA512 checksum.
        /// </summary>
        /// <value>
        /// The SHA512 checksum.
        /// </value>
        public string SHA512Checksum
        {
            get
            {
                return _sha512Checksum;
            }

            set
            {
                _sha512Checksum = value;
            }
        }

        /// <summary>
        /// Gets or sets the RIPEMD160 checksum.
        /// </summary>
        /// <value>
        /// The RIPEMD160 checksum.
        /// </value>
        public string RIPEMD160Checksum
        {
            get
            {
                return _ripemd160Checksum;
            }

            set
            {
                _ripemd160Checksum = value;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initialises a new instance of the <see cref="ChecksumViewerForm"/> class.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="md5Cheksum">The MD5 cheksum.</param>
        /// <param name="sha1Cheksum">The sha1 cheksum.</param>
        /// <param name="sha256Cheksum">The sha256 cheksum.</param>
        /// <param name="sha384Cheksum">The sha384 cheksum.</param>
        /// <param name="sha512Cheksum">The sha512 cheksum.</param>
        /// <param name="ripemd160Cheksum">The ripemd160 cheksum.</param>
        /// <param name="enableValidateCheksumButton">if set to <c>true</c> [enable validate cheksum button].</param>
        public ChecksumViewerForm(string fileName, string md5Cheksum, string sha1Cheksum, string sha256Cheksum, string sha384Cheksum, string sha512Cheksum, string ripemd160Cheksum, bool enableValidateCheksumButton = true)
        {
            InitializeComponent();

            SetFileName(fileName);

            SetMD5Checksum(md5Cheksum);

            SetSHA1Checksum(sha1Cheksum);

            SetSHA256Checksum(sha256Cheksum);

            SetSHA384Checksum(sha384Cheksum);

            SetSHA512Checksum(sha512Cheksum);

            SetRIPEMD160Checksum(ripemd160Cheksum);

            SetEnableValidateCheksumButton(enableValidateCheksumButton);
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Handles the Load event of the ChecksumViewerForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ChecksumViewerForm_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of the kbtnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void kbtnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        /// <summary>
        /// Handles the Click event of the kbtnValidateChecksums control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void kbtnValidateChecksums_Click(object sender, EventArgs e)
        {
            ValidateChecksumsForm validateChecksums = new ValidateChecksumsForm();

            validateChecksums.Show();
        }

        /// <summary>
        /// Handles the Click event of the kcbtnToggle control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void kcbtnToggle_Click(object sender, EventArgs e)
        {
            SetToggleCasing(kcbtnToggle.Checked);

            UpdateUI();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Updates the UI.
        /// </summary>
        private void UpdateUI()
        {
            try
            {
                klblFilename.Text = $"These are the checksum values for the file: { GetFileName() }";

                if (GetToggleCasing())
                {
                    klblMD5.Text = $"MD5: { GetMD5Checksum().ToUpper() }";

                    klblSHA1.Text = $"SHA-1: { GetSHA1Checksum().ToUpper() }";

                    klblSHA256.Text = $"SHA-256: { GetSHA256Checksum().ToUpper() }";

                    klblSHA384.Text = $"SHA-384: { GetSHA384Checksum().ToUpper() }";

                    klblSHA512.Text = $"SHA-512: { GetSHA512Checksum().ToUpper() }";

                    klblRIPEMD160.Text = $"RIPEMD-160: { GetRIPEMD160Checksum().ToUpper() }";
                }
                else
                {
                    klblMD5.Text = $"MD5: { GetMD5Checksum().ToLower() }";

                    klblSHA1.Text = $"SHA-1: { GetSHA1Checksum().ToLower() }";

                    klblSHA256.Text = $"SHA-256: { GetSHA256Checksum().ToLower() }";

                    klblSHA384.Text = $"SHA-384: { GetSHA384Checksum().ToLower() }";

                    klblSHA512.Text = $"SHA-512: { GetSHA512Checksum().ToLower() }";

                    klblRIPEMD160.Text = $"RIPEMD-160: { GetRIPEMD160Checksum().ToLower() }";
                }

                kbtnValidateChecksums.Enabled = GetEnableValidateCheksumButton();
            }
            catch (Exception ex)
            {
                _exceptionHandler.ShowException($"Error: { ex.Message }", true);
            }
        }
        #endregion

        #region Setters and Getters
        /// <summary>
        /// Sets the EnableValidateCheksumButton to the value of value.
        /// </summary>
        /// <param name="value">The desired value of EnableValidateCheksumButton.</param>
        private void SetEnableValidateCheksumButton(bool value)
        {
            EnableValidateCheksumButton = value;
        }

        /// <summary>
        /// Returns the value of the EnableValidateCheksumButton.
        /// </summary>
        /// <returns>The value of the EnableValidateCheksumButton.</returns>
        private bool GetEnableValidateCheksumButton()
        {
            return EnableValidateCheksumButton;
        }

        /// <summary>
        /// Sets the ToggleCasing to the value of value.
        /// </summary>
        /// <param name="value">The desired value of ToggleCasing.</param>
        private void SetToggleCasing(bool value)
        {
            ToggleCasing = value;
        }

        /// <summary>
        /// Returns the value of the ToggleCasing.
        /// </summary>
        /// <returns>The value of the ToggleCasing.</returns>
        private bool GetToggleCasing()
        {
            return ToggleCasing;
        }

        /// <summary>
        /// Sets the FileName to the value of value.
        /// </summary>
        /// <param name="value">The desired value of FileName.</param>
        private void SetFileName(string value)
        {
            FileName = value;
        }

        /// <summary>
        /// Returns the value of the FileName.
        /// </summary>
        /// <returns>The value of the FileName.</returns>
        private string GetFileName()
        {
            return FileName;
        }

        /// <summary>
        /// Sets the MD5Checksum to the value of value.
        /// </summary>
        /// <param name="value">The desired value of MD5Checksum.</param>
        private void SetMD5Checksum(string value)
        {
            MD5Checksum = value;
        }

        /// <summary>
        /// Returns the value of the MD5Checksum.
        /// </summary>
        /// <returns>The value of the MD5Checksum.</returns>
        private string GetMD5Checksum()
        {
            return MD5Checksum;
        }

        /// <summary>
        /// Sets the SHA1Checksum to the value of value.
        /// </summary>
        /// <param name="value">The desired value of SHA1Checksum.</param>
        private void SetSHA1Checksum(string value)
        {
            SHA1Checksum = value;
        }

        /// <summary>
        /// Returns the value of the SHA1Checksum.
        /// </summary>
        /// <returns>The value of the SHA1Checksum.</returns>
        private string GetSHA1Checksum()
        {
            return SHA1Checksum;
        }

        /// <summary>
        /// Sets the SHA256Checksum to the value of value.
        /// </summary>
        /// <param name="value">The desired value of SHA256Checksum.</param>
        private void SetSHA256Checksum(string value)
        {
            SHA256Checksum = value;
        }

        /// <summary>
        /// Returns the value of the SHA256Checksum.
        /// </summary>
        /// <returns>The value of the SHA256Checksum.</returns>
        private string GetSHA256Checksum()
        {
            return SHA256Checksum;
        }

        /// <summary>
        /// Sets the SHA384Checksum to the value of value.
        /// </summary>
        /// <param name="value">The desired value of SHA384Checksum.</param>
        private void SetSHA384Checksum(string value)
        {
            SHA384Checksum = value;
        }

        /// <summary>
        /// Returns the value of the SHA384Checksum.
        /// </summary>
        /// <returns>The value of the SHA384Checksum.</returns>
        private string GetSHA384Checksum()
        {
            return SHA384Checksum;
        }

        /// <summary>
        /// Sets the SHA512Checksum to the value of value.
        /// </summary>
        /// <param name="value">The desired value of SHA512Checksum.</param>
        private void SetSHA512Checksum(string value)
        {
            SHA512Checksum = value;
        }

        /// <summary>
        /// Returns the value of the SHA512Checksum.
        /// </summary>
        /// <returns>The value of the SHA512Checksum.</returns>
        private string GetSHA512Checksum()
        {
            return SHA512Checksum;
        }

        /// <summary>
        /// Sets the RIPEMD160Checksum to the value of value.
        /// </summary>
        /// <param name="value">The desired value of RIPEMD160Checksum.</param>
        private void SetRIPEMD160Checksum(string value)
        {
            RIPEMD160Checksum = value;
        }

        /// <summary>
        /// Returns the value of the RIPEMD160Checksum.
        /// </summary>
        /// <returns>The value of the RIPEMD160Checksum.</returns>
        private string GetRIPEMD160Checksum()
        {
            return RIPEMD160Checksum;
        }
        #endregion
    }
}