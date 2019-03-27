using ComponentFactory.Krypton.Toolkit;
using Core.Classes;
using GlobalUtilities.Classes;
using KryptonExtendedToolkit.Base.Code;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Security.Principal;
using System.Windows.Forms;

namespace KryptonExtendedToolkit.ExtendedToolkit.Controls
{
    /// <summary>
    /// A standard Krypton button control with UAC shield
    /// Modified from the AeroSuite project.
    /// </summary>
    /// <remarks>
    /// The shield is extracted from the system with LoadImage if possible. Otherwise the shield will be enabled by sending the BCM_SETSHIELD Message to the control.
    /// If the operating system is not Windows Vista or higher, no shield will be displayed as there's no such thing as UAC on the target system -> the shield is obsolete.
    /// </remarks>
    [DesignerCategory("Code")]
    [DisplayName("Krypton UAC Elevated Button")]
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(KryptonButton), "ToolboxBitmaps.UACButton.bmp")]
    public partial class KryptonUACElevatedButton : KryptonButton
    {
        #region Variables
        private bool _elevateApplicationOnClick = true;

        private string _processName = string.Empty;

        private static bool? _isSystemAbleToLoadShield = null;

        private const int BCM_SETSHIELD = 0x160C;

        private GlobalMethods _globalMethods = new GlobalMethods();

        private UtilityMethods _utilityMethods = new UtilityMethods();
        #endregion

        #region Properties
        /// <summary>
        /// Elevates the current running application to administrator level when button is clicked.
        /// </summary>
        /// <remarks>
        /// The application/process will restart when clicked.
        /// </remarks>
        [Category("Code")]
        [Description("Elevates the current running application to administrator level when button is clicked. The application/process will restart when clicked.")]
        [DefaultValue(true)]
        public bool ElevateApplicationOnClick
        {
            get
            {
                return _elevateApplicationOnClick;
            }

            set
            {
                _elevateApplicationOnClick = value;
            }
        }

        /// <summary>
        /// The application assembly.
        /// </summary>
        /// <remarks>
        /// Use 'Process.GetCurrentProcess().ProcessName;' as a start.
        /// </remarks>
        [Category("Code")]
        [Description("The application assembly. Use 'Process.GetCurrentProcess().ProcessName;' as a start.")]
        [DefaultValue("")]
        public string ProcessName
        {
            get
            {
                return _processName;
            }

            set
            {
                _processName = value;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Initialises a new instance of the <see cref="KryptonUACElevatedButton"/> class.
        /// </summary>
        public KryptonUACElevatedButton() : base()
        {
            Size = new Size((int)(Width * 1.5), Height + 1);

            _globalMethods.CheckIfTargetPlatformIsSupported(true);

            if (_globalMethods.GetIsTargetPlatformSupported())
            {
                if (!_isSystemAbleToLoadShield.HasValue || _isSystemAbleToLoadShield.Value)
                {
                    try
                    {
                        var _icon = IconExtractor.LoadIcon(IconExtractor.IconType.SHIELD, SystemInformation.SmallIconSize);

                        if (_icon != null)
                        {
                            Values.Image = _icon.ToBitmap();

                            //this.TextImageRelation = TextImageRelation.ImageBeforeText;

                            //Values.Image.ImageAlign = ContentAlignment.MiddleCenter;

                            _isSystemAbleToLoadShield = true;

                            return;
                        }
                        else
                        {
                            _isSystemAbleToLoadShield = false;
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show($"Your platform is unsupported. Please contact the software vendor for details.\nFor reference, your system is running: { _globalMethods.GetOSFriendlyName() }.\nException message: { exc.Message }.", "Unsupported Software", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        _isSystemAbleToLoadShield = false;
                    }
                }

                //FlatStyle = FlatStyle.System;

                GlobalNativeMethods.SendMessage(Handle, BCM_SETSHIELD, IntPtr.Zero, new IntPtr(1));
            }
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Raises the <see cref="OnClick(EventArgs)"/> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            try
            {
                if (ElevateApplicationOnClick)
                {
                    if (_globalMethods.GetIsTargetPlatformSupported())
                    {
                        if (ProcessName != string.Empty)
                        {
                            ElevateProcessWithAdministrativeRights(ProcessName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (_globalMethods.GetIsTargetPlatformSupported())
                {
                    ExceptionHandler.CaptureException(ex, null, this);
                }
                else
                {
                    MessageBox.Show($"An error has occurred: { ex.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Methods
        public void ElevateProcessWithAdministrativeRights(string processName)
        {
            try
            {
                if (!string.IsNullOrEmpty(ProcessName))
                {
                    processName = ProcessName;
                }

                // Get current user privileges
                WindowsPrincipal currentIdentity = new WindowsPrincipal(WindowsIdentity.GetCurrent());

                bool hasAdministrativeRights = currentIdentity.IsInRole(WindowsBuiltInRole.Administrator);

                if (hasAdministrativeRights)
                {
                    // Launch the process with administrative privileges
                    ProcessStartInfo psi = new ProcessStartInfo();

                    psi.Verb = "runas";

                    psi.FileName = processName;

                    // Try to run the process
                    try
                    {
                        Process.Start(psi);
                    }
                    catch (Win32Exception wexc)
                    {
                        ExceptionHandler.CaptureException(wexc, null, this);
                    }
                }
            }
            catch (Exception exc)
            {
                ExceptionHandler.CaptureException(exc, null, this);
            }
        }
        #endregion
    }
}