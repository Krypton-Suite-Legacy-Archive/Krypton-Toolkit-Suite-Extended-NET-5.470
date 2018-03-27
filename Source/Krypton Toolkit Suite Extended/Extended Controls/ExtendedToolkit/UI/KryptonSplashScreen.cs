using ComponentFactory.Krypton.Toolkit;
using System.ComponentModel;
using System.Windows.Forms;

namespace ExtendedControls.ExtendedToolkit.UI
{
    public partial class KryptonSplashScreen : KryptonForm
    {
        #region Variables
        private bool _useFadeEffects, _enableProgressBar, _enableModernProgressBar, _enableMinimiseButton, _enableCloseButton, _useDropShadow;

        private string _applicationName, _companyOrAuthorName, _statusString;

        private Form _nextWindow;

        private KryptonForm _nextKryptonWindow;
        #endregion

        #region Properties

        #region Booleans
        /// <summary>
        /// Gets or sets a value indicating whether [use fade effects].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [use fade effects]; otherwise, <c>false</c>.
        /// </value>
        [DefaultValue(true)]
        public bool UseFadeEffects
        {
            get
            {
                return _useFadeEffects;
            }

            set
            {
                _useFadeEffects = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [enable progress bar].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable progress bar]; otherwise, <c>false</c>.
        /// </value>
        [DefaultValue(false)]
        public bool EnableProgressBar
        {
            get
            {
                return _enableProgressBar;
            }

            set
            {
                _enableProgressBar = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [enable modern progress bar].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable modern progress bar]; otherwise, <c>false</c>.
        /// </value>
        [DefaultValue(false)]
        public bool EnableModernProgressBar
        {
            get
            {
                return _enableModernProgressBar;
            }

            set
            {
                _enableModernProgressBar = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [enable minimise button].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable minimise button]; otherwise, <c>false</c>.
        /// </value>
        [DefaultValue(true)]
        public bool EnableMinimiseButton
        {
            get
            {
                return _enableMinimiseButton;
            }

            set
            {
                _enableMinimiseButton = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [enable close button].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable close button]; otherwise, <c>false</c>.
        /// </value>
        [DefaultValue(true)]
        public bool EnableCloseButton
        {
            get
            {
                return _enableCloseButton;
            }

            set
            {
                _enableCloseButton = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [enable use drop shadow].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable use drop shadow]; otherwise, <c>false</c>.
        /// </value>
        [DefaultValue(false)]
        public bool EnableUseDropShadow
        {
            get
            {
                return _useDropShadow;
            }

            set
            {
                _useDropShadow = value;
            }
        }
        #endregion

        #region Strings        
        /// <summary>
        /// Gets or sets the name of the application.
        /// </summary>
        /// <value>
        /// The name of the application.
        /// </value>
        public string ApplicationName
        {
            get
            {
                return _applicationName;
            }

            set
            {
                _applicationName = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the company or author.
        /// </summary>
        /// <value>
        /// The name of the company or author.
        /// </value>
        public string CompanyOrAuthorName
        {
            get
            {
                return _companyOrAuthorName;
            }

            set
            {
                _companyOrAuthorName = value;
            }
        }

        /// <summary>
        /// Gets or sets the status string.
        /// </summary>
        /// <value>
        /// The status string.
        /// </value>
        public string StatusString
        {
            get
            {
                return _statusString;
            }

            set
            {
                _statusString = value;
            }
        }
        #endregion

        #region Forms        
        /// <summary>
        /// Gets or sets the nextwindow.
        /// </summary>
        /// <value>
        /// The nextwindow.
        /// </value>
        public Form Nextwindow
        {
            get
            {
                return _nextWindow;
            }

            set
            {
                _nextWindow = value;
            }
        }
        #endregion

        #region Krypton Forms        
        /// <summary>
        /// Gets or sets the next krypton window.
        /// </summary>
        /// <value>
        /// The next krypton window.
        /// </value>
        public KryptonForm NextKryptonWindow
        {
            get
            {
                return _nextKryptonWindow;
            }

            set
            {
                _nextKryptonWindow = value;
            }
        }
        #endregion

        #endregion

        /// <summary>
        /// Initialises a new instance of the <see cref="KryptonSplashScreen"/> class.
        /// </summary>
        /// <param name="useFadeEffects">if set to <c>true</c> [use fade effects].</param>
        /// <param name="enableProgressBar">if set to <c>true</c> [enable progress bar].</param>
        /// <param name="enableModernProgressBar">if set to <c>true</c> [enable modern progress bar].</param>
        /// <param name="enableMinimiseButton">if set to <c>true</c> [enable minimise button].</param>
        /// <param name="enableCloseButton">if set to <c>true</c> [enable close button].</param>
        /// <param name="useDropShadow">if set to <c>true</c> [use drop shadow].</param>
        /// <param name="applicationName">Name of the application.</param>
        /// <param name="companyOrAuthorName">Name of the company or author.</param>
        /// <param name="statusString">The status string.</param>
        /// <param name="nextWindow">The next window.</param>
        /// <param name="nextKryptonWindow">The next krypton window.</param>
        public KryptonSplashScreen(bool useFadeEffects, bool enableProgressBar, bool enableModernProgressBar, bool enableMinimiseButton, bool enableCloseButton, bool useDropShadow, string applicationName, string companyOrAuthorName, string statusString, Form nextWindow = null, KryptonForm nextKryptonWindow = null)
        {
            InitializeComponent();
        }

        #region Event Handlers          
        private void lblMinimise_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblCloseInactive_MouseEnter(object sender, System.EventArgs e)
        {
            lblCloseInactive.Visible = false;

            lblCloseActive.Visible = true;
        }

        private void lblCloseActive_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void lblCloseActive_MouseLeave(object sender, System.EventArgs e)
        {
            lblCloseActive.Visible = false;

            lblCloseInactive.Visible = true;
        }
        #endregion
    }
}