#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.470/blob/master/LICENSE
 *
 */
#endregion

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

using ComponentFactory.Krypton.Toolkit;

using Core.Classes;
using GlobalUtilities.Classes;
using KryptonExtendedToolkit.Base.Code;

namespace KryptonExtendedToolkit.ExtendedToolkit.ToolstripControls
{
    /// <summary>
    /// A standard tool strip menu item control with UAC shield.
    /// Modified from the AeroSuite project.
    /// </summary>
    /// <remarks>
    /// The shield is extracted from the system with LoadImage if possible. Otherwise the shield will be enabled by sending the BCM_SETSHIELD Message to the control.
    /// If the operating system is not Windows Vista or higher, no shield will be displayed as there's no such thing as UAC on the target system -> the shield is obsolete.
    /// </remarks>
    [DisplayName("ToolStrip UAC Shield Menu Item")]
    [ToolboxBitmap(typeof(ToolStripMenuItem)), ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public partial class ToolStripMenuItemUACSheld : ToolStripMenuItem
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
        /// Initialises a new instance of the <see cref="ToolStripMenuItemUACSheld"/> class.
        /// </summary>
        public ToolStripMenuItemUACSheld() : base()
        {
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
                            Image = _icon.ToBitmap();

                            TextImageRelation = TextImageRelation.ImageBeforeText;

                            ImageAlign = ContentAlignment.MiddleCenter;

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

                //NativeMethods.SendMessage(Handle, BCM_SETSHIELD, IntPtr.Zero, new IntPtr(1));
            }
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.ToolStripItem.Click" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
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
                            UtilityMethods.ElevateProcessWithAdministrativeRights(ProcessName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (_globalMethods.GetIsTargetPlatformSupported())
                {
                    KryptonMessageBox.Show($"An error has occurred: { ex.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"An error has occurred: { ex.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}